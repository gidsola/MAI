using System;
using System.IO;
using System.Windows.Forms;
using Newtonsoft.Json;
using MistralChatApp.MistralConfig;
using MistralChatApp.MistralRequest;

namespace MistralChatApp
{
    public partial class Form1 : Form
    {
        readonly MistralChat mistralChat = new();
        
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

        private void Form1_Load(object sender, EventArgs e)
        {
            textBoxApiKey.Text = MistralChatConfig.ChatConfig["ApiKey"];
            modelSelectBox.Text = MistralChatConfig.ChatConfig["Model"];
            richTextSystemPrompt.Text = MistralChatConfig.ChatConfig["SystemPrompt"];
        }

        private async void SubmitButton_Click(object sender, EventArgs e)
        {
            //TODO: webview with markdown supports.
            string userInput = richTextUserInput.Text;
            //richTextModelOutput.AppendText("\r\nUser: " + userInput + "\r\n");

            string message = await mistralChat.ChatCompletion(userInput);
            //richTextModelOutput.AppendText("\r\nAI: " + message + "\r\n");

            await webView21.EnsureCoreWebView2Async();
            webView21.NavigateToString($"<html><body><pre><code>{message}</code></pre></body></html>");
        }

        private void LabelApiKey_Click(object sender, EventArgs e)
        {

        }

        private void RichTextModelOutput_TextChanged(object sender, EventArgs e)
        {
        }

        private void RichTextUserInput_TextChanged(object sender, EventArgs e)
        {

        }

        private void RichTextSystemPrompt_TextChanged(object sender, EventArgs e)
        {
            string systemprompt = richTextSystemPrompt.Text;
            MistralChatConfig.ChatConfig["SystemPrompt"] = systemprompt;
        }

        private void TextBoxApiKey_TextChanged(object sender, EventArgs e)
        {
            string apikey = textBoxApiKey.Text;
            MistralChatConfig.ChatConfig["ApiKey"] = apikey;

        }

        private void ModelSelectBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            string modelSelect = modelSelectBox.SelectedItem.ToString();
            MistralChatConfig.ChatConfig["Model"] = modelSelect;
        }

        private void webView21_Click(object sender, EventArgs e)
        {

        }
    }
}
