﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MAI.MistralConfig;

namespace MAI.AppConfig
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
            richTextSystemPrompt.Text = MistralChatConfig.ChatConfig["SystemPrompt"];
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

    }
}
