using System;
using System.IO;
using System.Windows.Forms;
using System.Threading.Tasks;
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

        readonly SpVoice voice = new();

        private string currentTTSContent = "";
        private bool isPaused = false;
        private bool isPlaying = false;

        public MainForm()
        {
            InitializeComponent();
            MistralChatConfig.InitializeChatConfig();
            voice.Voice = voice.GetVoices("gender=female").Item(0);
        }

        private void Form1_Closing(object sender, FormClosingEventArgs e)
        {
            string updatedJson = JsonConvert.SerializeObject(MistralChatConfig.ChatConfig, Formatting.Indented);
            File.WriteAllText("config.json", updatedJson);
        }

        private async void Form1_Load(object sender, EventArgs e)
        {
            pictureBox1.Visible = false;
            await webView21.EnsureCoreWebView2Async();
        }

        private void ConfigurationMenuItem_Click(object sender, EventArgs e)
        {
            ConfigurationForm configForm = new();
            configForm.Show();
        }

        private async void SubmitButton_Click(object sender, EventArgs e)
        {
            if (isPlaying){
                // redo : this is just queing another entry. maybe skip sentance, length ?..saving here
                await Task.Run(() => {
                    voice.Pause();
                    voice.Speak(string.Empty, SpeechVoiceSpeakFlags.SVSFPurgeBeforeSpeak);
                });
                isPlaying = false;
                isPaused = false;
            }            
            webView21.NavigateToString(Markdown.ToHtml(await ResponseWithLoader(), pipeline));
        }
        private async Task<string> ResponseWithLoader()
        {
            pictureBox1.Visible = true;
            currentTTSContent = await mistralChat.StreamingChatCompletion(richTextUserInput.Text);
            pictureBox1.Visible = false;
            return currentTTSContent;
        }

        private async void ExplainButton_Click(object sender, EventArgs e)
        {
            if (!isPlaying) await Task.Run(async () =>
            {
                string explanation = await mistralChat.StreamingChatCompletion("Transcribe the following Text in a manner that will allow it to be read to a user in a meaningful way. for example, we do not want to read punctuation marks, do we? :   " + currentTTSContent);
                voice.Speak(explanation, SpeechVoiceSpeakFlags.SVSFNLPSpeakPunc);
                isPlaying = true;
            });
            else PauseResumeButton_Click(sender, e);
        }

        private void PauseResumeButton_Click(object sender, EventArgs e)
        {
            if(!isPaused) {
                isPaused = true;
                button2.Text = "Resume";
                voice.Pause();
            }
            else
            {
                isPaused = false;
                button2.Text = "Pause";
                voice.Resume();
            }
        }
    }
}
