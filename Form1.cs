using System;
using System.IO;
using System.Windows.Forms;
//using System.Speech;
using SpeechLib;
using Newtonsoft.Json;
using Markdig;
using Markdig.SyntaxHighlighting;
using MAI.AppConfig;
using MAI.MistralConfig;
using MAI.MistralRequest;

namespace MAI
{
    public partial class MainForm : Form
    {
        readonly MistralChat mistralChat = new();
        readonly MarkdownPipeline pipeline = new MarkdownPipelineBuilder()
            .UseAdvancedExtensions()
            .UseEmojiAndSmiley()
            .UseSyntaxHighlighting()
            .Build();

        private string currentTTSContent = "";

        public MainForm()
        {
            InitializeComponent();
            MistralChatConfig.InitializeChatConfig();
        }

        private void Form1_Closing(object sender, FormClosingEventArgs e)
        {
            string updatedJson = JsonConvert.SerializeObject(MistralChatConfig.ChatConfig, Formatting.Indented);
            File.WriteAllText("config.json", updatedJson);
        }

        private async void Form1_Load(object sender, EventArgs e)
        {
            pictureBox1.Visible = false;
            listenButton.Visible = false;
            await webView21.EnsureCoreWebView2Async();
        }

        private async void SubmitButton_Click(object sender, EventArgs e)
        {
            // TODO: clean this up...
            listenButton.Visible = false;
            pictureBox1.Visible = true;
            string message = await mistralChat.StreamingChatCompletion(richTextUserInput.Text);
            currentTTSContent = message;
            pictureBox1.Visible = false;
            webView21.NavigateToString(Markdown.ToHtml(message, pipeline));
            listenButton.Visible = true;
        }

        private void configurationToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ConfigurationForm configForm = new ();
            configForm.Show();
        }

        private async void ListenButton_Click(object sender, EventArgs e)
        {
            // add a stop button// maybe a different control ?
            SpVoice voice = new();
            voice.Voice = voice.GetVoices("gender=female").Item(0);
            string audioMessage = await mistralChat.StreamingChatCompletion("Transcribe the following Text in a manner that will allow it to be read to a user in a meaningful way. for example, we do not want to read punctuation marks, do we? :   " + currentTTSContent);
            voice.Speak(audioMessage, SpeechVoiceSpeakFlags.SVSFNLPSpeakPunc);
        }
    }
}
