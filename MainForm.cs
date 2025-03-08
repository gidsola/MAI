﻿using System;
using System.Windows.Forms;
using System.Threading.Tasks;
using SpeechLib;
using Markdig;
using Markdig.SyntaxHighlighting;
using MAI.MistralRequest;
using MAI.MistralConfigForm;
using MAI.MistralConfig;

namespace MAI
{
    public partial class MainForm : Form
    {
        private readonly MistralChat mistralChat = new();
        private readonly MarkdownPipeline pipeline = new MarkdownPipelineBuilder()
            .UseAdvancedExtensions()
            .UseEmojiAndSmiley()
            .UseSyntaxHighlighting()
            .Build();
        private readonly SpVoice voice = new();
        private string currentTTSContent = "";
        private bool isPaused = false;
        private bool isPlaying = false;

        public MainForm()
        {
            InitializeComponent();
            MistralChatConfig.InitializeChatConfig();
            voice.Voice = voice.GetVoices("Gender=Female").Item(0);
        }

        private async void MainForm_Load(object sender, EventArgs e)
        {
            chatbotPanel.Visible = false;
            LoadingImage.Visible = false;
            imageGenPanel.Visible = false;
            await webView21.EnsureCoreWebView2Async();
        }



        /////////////////////////////////////////////////////
        //  Helpers


        private async Task<string> ResponseWithLoader()
        {
            LoadingImage.Visible = true;
            currentTTSContent = await mistralChat.StreamingChatCompletion(richTextUserInput.Text);
            LoadingImage.Visible = false;
            return currentTTSContent;
        }



        ////////////////////////////////////////////////////////////////
        //   app menu items
        //   - todo: after cleanup lookat panel positions opposed to visiblity


        private void ChatBotMenuItem_Click(object sender, EventArgs e)
        {
            if (imageGenPanel.Visible)
            {
                imageGenPanel.Visible = false;
            }
            chatbotPanel.Visible = true;
        }

        private void ImageGenMenuItem_Click(object sender, EventArgs e)
        {
            if (chatbotPanel.Visible)
            {
                chatbotPanel.Visible = false;
            }
            imageGenPanel.Visible = true;

        }

        private void ConfigMenuItem_Click(object sender, EventArgs e) // to do
        {
            MessageBox.Show("Not Yet Implemented");
        }




        /////////////////////////////////////////////////////
        //  chat bot panel


        private async void SubmitButton_Click(object sender, EventArgs e)
        {
            webView21.NavigateToString(Markdown.ToHtml(await ResponseWithLoader(), pipeline));
        }

        private async void DictateButton_Click(object sender, EventArgs e)
        {
            if (!isPlaying) 
            {
                string explanation = await mistralChat.StreamingChatCompletion("Dictate the current text in a manner that a blind person would understand: " + currentTTSContent);
                isPlaying = true;
                await Task.Run(() => voice.Speak(explanation, SpeechVoiceSpeakFlags.SVSFNLPSpeakPunc));
            }
            else PauseResumeButton_Click(sender, e);
        }

        private void ChatBotConfigButton_Click(object sender, EventArgs e)
        {
            ConfigurationForm configForm = new();
            configForm.Show();
        }

        private void CloseButton_Click(object sender, EventArgs e)
        {
            chatbotPanel.Visible = false;
        }

        private void PauseResumeButton_Click(object sender, EventArgs e)
        {
            if (!isPaused)
            {
                voice.Pause();
            }
            else
            {
                voice.Resume();
            }
            isPaused = !isPaused;
        }



        /////////////////////////////////////////////////////
        //  image gen panel



    }
}
