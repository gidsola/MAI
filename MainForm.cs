using System;
using System.IO;
using System.Windows.Forms;
using Newtonsoft.Json;
using MAI.MistralConfigForm;
using MAI.MistralConfig;
using MIA.MistralChatBot;

namespace MAI
{
    public partial class MainForm : Form
    {

        public MainForm()
        {
            InitializeComponent();
            MistralChatConfig.InitializeChatConfig();
        }

        private void MainForm_Closing(object sender, FormClosingEventArgs e)
        {
            string updatedJson = JsonConvert.SerializeObject(MistralChatConfig.ChatConfig, Formatting.Indented);
            File.WriteAllText("config.json", updatedJson);
        }


        private void ConfigurationMenuItem_Click(object sender, EventArgs e)
        {
            ConfigurationForm configForm = new();
            configForm.Show();
        }

        private void MistralChatItem(object sender, EventArgs e)
        {
            ChatBotForm chatForm = new();
            chatForm.Show();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {

        }
    }
}
