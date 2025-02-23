using System;
using System.IO;
using System.Windows.Forms;
using MAI.MistralConfig;
using Newtonsoft.Json;

namespace MAI.MistralConfigForm
{
    public partial class ConfigurationForm : Form
    {
        public ConfigurationForm()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            textBoxApiKey.Text = MistralChatConfig.ChatConfig["ApiKey"];
            modelSelectBox.Text = MistralChatConfig.ChatConfig["Model"];
            numericUpDown1.Value = (decimal)MistralChatConfig.ChatConfig["Top_p"];
            numericUpDown2.Value = MistralChatConfig.ChatConfig["Max_tokens"];
            richTextSystemPrompt.Text = MistralChatConfig.ChatConfig["SystemPrompt"];
        }

        private void MistralConfigForm_Closing(object sender, FormClosingEventArgs e)
        {
            string updatedJson = JsonConvert.SerializeObject(MistralChatConfig.ChatConfig, Formatting.Indented);
            File.WriteAllText("config.json", updatedJson);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void TextBoxApiKey_TextChanged(object sender, EventArgs e)
        {
            MistralChatConfig.ChatConfig["ApiKey"] = textBoxApiKey.Text;
        }

        private void RichTextSystemPrompt_TextChanged(object sender, EventArgs e)
        {
            MistralChatConfig.ChatConfig["SystemPrompt"] = richTextSystemPrompt.Text;
        }

        private void ModelSelectBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            MistralChatConfig.ChatConfig["Model"] = modelSelectBox.SelectedItem.ToString();
        }

        private void numericUpDown1ValueChanged(object sender, EventArgs e)
        {
            MistralChatConfig.ChatConfig["Top_p"] = (double)numericUpDown1.Value;
        }

        private void numericUpDown2ValueChanged(object sender, EventArgs e)
        {
            MistralChatConfig.ChatConfig["Max_tokens"] = (int)numericUpDown2.Value;
        }

    }
}
