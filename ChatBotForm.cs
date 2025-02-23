using System;
using SpeechLib;
using System.Windows.Forms;
using System.Threading.Tasks;
using Markdig;
using Markdig.SyntaxHighlighting;
using MAI.MistralRequest;
using MAI.MistralConfigForm;

namespace MIA.MistralChatBot
{
    public partial class ChatBotForm : Form
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

        public ChatBotForm()
        {
            InitializeComponent();
            voice.Voice = voice.GetVoices("Gender=Female").Item(0);
        }
        
        private async void ChatBotForm_Load(object sender, EventArgs e)
        {
            LoadingImage.Visible = false;
            await webView21.EnsureCoreWebView2Async();
        }

        private async void SubmitButton_Click(object sender, EventArgs e)
        {
            webView21.NavigateToString(Markdown.ToHtml(await ResponseWithLoader(), pipeline));
        }

        private async Task<string> ResponseWithLoader()
        {
            LoadingImage.Visible = true;
            currentTTSContent = await mistralChat.StreamingChatCompletion(richTextUserInput.Text);
            LoadingImage.Visible = false;
            return currentTTSContent;
        }

        private void PauseResumeButton_Click(object sender, EventArgs e)
        {
            if (!isPaused)
            {
                isPaused = true;
                //button2.Text = "Resume";
                voice.Pause();
            }
            else
            {
                isPaused = false;
                //button2.Text = "Pause";
                voice.Resume();
            }
        }

        private void ChatBotConfigButton_Click(object sender, EventArgs e)
        {
            ConfigurationForm configForm = new();
            configForm.Show();
        }

        private void CloseButton_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private async void DictateButton_Click(object sender, EventArgs e)
        {
            if (!isPlaying) await Task.Run(async () =>
            {
                string explanation = await mistralChat.StreamingChatCompletion("Dictate the current text in a manner that a blind person would understand: " + currentTTSContent);
                voice.Speak(explanation, SpeechVoiceSpeakFlags.SVSFNLPSpeakPunc);
                isPlaying = true;
            });
            else PauseResumeButton_Click(sender, e);
        }
    }
}
