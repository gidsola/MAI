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
            textBoxApiKeyInput.Text = MistralChatConfig.ChatConfig["ApiKey"];
            modelSelectBox.Text = MistralChatConfig.ChatConfig["Model"];
            RichTextSystemPrompt.Text = MistralChatConfig.ChatConfig["SystemPrompt"];
        }

        private async void button1_Click(object sender, EventArgs e)
        {
            string userInput = RichTextUserInput.Text;
            RichTextModelOutput.AppendText("\r\nUser: " + userInput + "\r\n");

            string message = await mistralChat.ChatCompletion(userInput);
            RichTextModelOutput.AppendText("\r\nAI: " + message + "\r\n");
        }

        private void label2_Click(object sender, EventArgs e)
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
            string systemprompt = RichTextSystemPrompt.Text;
            MistralChatConfig.ChatConfig["SystemPrompt"] = systemprompt;
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            string apikey = textBoxApiKeyInput.Text;
            MistralChatConfig.ChatConfig["ApiKey"] = apikey;

        }

        private void modelSelectBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            string modelSelect = modelSelectBox.SelectedItem.ToString();
            MistralChatConfig.ChatConfig["Model"] = modelSelect;
        }
    }
}
