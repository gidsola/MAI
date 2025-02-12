using System;
using System.IO;
using System.Windows.Forms;
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
            
            await webView21.EnsureCoreWebView2Async();
        }

        private async void SubmitButton_Click(object sender, EventArgs e)
        {
            pictureBox1.Visible = true;
            string message = await mistralChat.StreamingChatCompletion(richTextUserInput.Text);
            pictureBox1.Visible = false;
            webView21.NavigateToString(Markdown.ToHtml(message, pipeline));
        }

        private void configurationToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ConfigurationForm configForm = new ();
            configForm.Show();
        }
    }
}
