using System;
using System.Windows.Forms;
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
    }
}
