using System;
using System.IO;
using System.Windows.Forms;
using Newtonsoft.Json;
using Markdig;
using Markdig.SyntaxHighlighting;
using MistralChatApp.MistralConfig;
using MistralChatApp.MistralRequest;

namespace MistralChatApp
{
    public partial class Form1 : Form
    {
        readonly MistralChat mistralChat = new();
        readonly MarkdownPipeline pipeline = new MarkdownPipelineBuilder()
            .UseAdvancedExtensions()
            .UseEmojiAndSmiley()
            .UseSyntaxHighlighting()
            .Build();

        public Form1()
        {
            InitializeComponent();
            MistralChatConfig.InitializeChatConfig();
        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void Form1_Closing(object sender, FormClosingEventArgs e)
        {
            string updatedJson = JsonConvert.SerializeObject(MistralChatConfig.ChatConfig, Formatting.Indented);
            File.WriteAllText("config.json", updatedJson);
        }

        private async void Form1_Load(object sender, EventArgs e)
        {
            pictureBox1.Visible = false;
            textBoxApiKey.Text = MistralChatConfig.ChatConfig["ApiKey"];
            modelSelectBox.Text = MistralChatConfig.ChatConfig["Model"];
            richTextSystemPrompt.Text = MistralChatConfig.ChatConfig["SystemPrompt"];
            await webView21.EnsureCoreWebView2Async();
        }

        private async void SubmitButton_Click(object sender, EventArgs e)
        {
            
            pictureBox1.Visible = true;
            string 
                message = await mistralChat.ChatCompletion(richTextUserInput.Text),
                result = Markdown.ToHtml(message, pipeline);
            pictureBox1.Visible = false;
            webView21.NavigateToString(result);
        }

        private void LabelApiKey_Click(object sender, EventArgs e)
        {

        }

        private void RichTextUserInput_TextChanged(object sender, EventArgs e)
        {

        }

        private void RichTextSystemPrompt_TextChanged(object sender, EventArgs e)
        {
            MistralChatConfig.ChatConfig["SystemPrompt"] = richTextSystemPrompt.Text;
        }

        private void TextBoxApiKey_TextChanged(object sender, EventArgs e)
        {
            MistralChatConfig.ChatConfig["ApiKey"] = textBoxApiKey.Text;
        }

        private void ModelSelectBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            MistralChatConfig.ChatConfig["Model"] = modelSelectBox.SelectedItem.ToString();
        }

        private void webView21_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}
