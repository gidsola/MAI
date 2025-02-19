using System;
using System.Windows.Forms;
using System.Threading.Tasks;
using SpeechLib;
using Markdig;
using Markdig.SyntaxHighlighting;
using MAI.MistralRequest;

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
            voice.Voice = voice.GetVoices("Name=Microsoft Zira Desktop").Item(0);
        }

       

        private async void ChatBotForm_Load(object sender, EventArgs e)
        {
            LoadingImage.Visible = false;
            await webView21.EnsureCoreWebView2Async();
        }

        

        private async void SubmitButton_Click(object sender, EventArgs e)
        {
            if (isPlaying)
            {
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
            LoadingImage.Visible = true;
            currentTTSContent = await mistralChat.StreamingChatCompletion(richTextUserInput.Text);
            LoadingImage.Visible = false;
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
            if (!isPaused)
            {
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
