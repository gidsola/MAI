namespace MIA.MistralChatBot
{
    partial class ChatBotForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ChatBotForm));
            this.webView21 = new Microsoft.Web.WebView2.WinForms.WebView2();
            this.richTextUserInput = new System.Windows.Forms.RichTextBox();
            this.submitButton = new System.Windows.Forms.Button();
            this.LoadingImage = new System.Windows.Forms.PictureBox();
            this.ChatBotConfigButton = new System.Windows.Forms.Button();
            this.CloseButton = new System.Windows.Forms.Button();
            this.DictateButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.webView21)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.LoadingImage)).BeginInit();
            this.SuspendLayout();
            // 
            // webView21
            // 
            this.webView21.AllowExternalDrop = true;
            this.webView21.BackColor = System.Drawing.Color.DarkGray;
            this.webView21.CausesValidation = false;
            this.webView21.CreationProperties = null;
            this.webView21.DefaultBackgroundColor = System.Drawing.Color.DarkGray;
            this.webView21.Location = new System.Drawing.Point(143, 11);
            this.webView21.Margin = new System.Windows.Forms.Padding(2);
            this.webView21.Name = "webView21";
            this.webView21.Padding = new System.Windows.Forms.Padding(4);
            this.webView21.Size = new System.Drawing.Size(1155, 550);
            this.webView21.TabIndex = 10;
            this.webView21.ZoomFactor = 1D;
            // 
            // richTextUserInput
            // 
            this.richTextUserInput.BackColor = System.Drawing.Color.DarkGray;
            this.richTextUserInput.CausesValidation = false;
            this.richTextUserInput.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.richTextUserInput.Location = new System.Drawing.Point(143, 566);
            this.richTextUserInput.Margin = new System.Windows.Forms.Padding(2);
            this.richTextUserInput.Name = "richTextUserInput";
            this.richTextUserInput.Size = new System.Drawing.Size(892, 120);
            this.richTextUserInput.TabIndex = 12;
            this.richTextUserInput.Text = "";
            // 
            // submitButton
            // 
            this.submitButton.BackColor = System.Drawing.Color.Transparent;
            this.submitButton.CausesValidation = false;
            this.submitButton.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.submitButton.FlatAppearance.BorderSize = 0;
            this.submitButton.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.submitButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.submitButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.submitButton.Location = new System.Drawing.Point(1040, 566);
            this.submitButton.Margin = new System.Windows.Forms.Padding(2);
            this.submitButton.Name = "submitButton";
            this.submitButton.Size = new System.Drawing.Size(113, 120);
            this.submitButton.TabIndex = 13;
            this.submitButton.Text = "Submit";
            this.submitButton.UseVisualStyleBackColor = false;
            this.submitButton.Click += new System.EventHandler(this.SubmitButton_Click);
            // 
            // LoadingImage
            // 
            this.LoadingImage.BackColor = System.Drawing.Color.Transparent;
            this.LoadingImage.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.LoadingImage.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.LoadingImage.Cursor = System.Windows.Forms.Cursors.WaitCursor;
            this.LoadingImage.ErrorImage = null;
            this.LoadingImage.Image = ((System.Drawing.Image)(resources.GetObject("LoadingImage.Image")));
            this.LoadingImage.InitialImage = null;
            this.LoadingImage.Location = new System.Drawing.Point(656, 201);
            this.LoadingImage.Margin = new System.Windows.Forms.Padding(0);
            this.LoadingImage.Name = "LoadingImage";
            this.LoadingImage.Size = new System.Drawing.Size(148, 162);
            this.LoadingImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.LoadingImage.TabIndex = 11;
            this.LoadingImage.TabStop = false;
            this.LoadingImage.UseWaitCursor = true;
            // 
            // ChatBotConfigButton
            // 
            this.ChatBotConfigButton.CausesValidation = false;
            this.ChatBotConfigButton.Location = new System.Drawing.Point(1229, 566);
            this.ChatBotConfigButton.Name = "ChatBotConfigButton";
            this.ChatBotConfigButton.Size = new System.Drawing.Size(69, 57);
            this.ChatBotConfigButton.TabIndex = 14;
            this.ChatBotConfigButton.Text = "Config";
            this.ChatBotConfigButton.UseVisualStyleBackColor = true;
            this.ChatBotConfigButton.Click += new System.EventHandler(this.ChatBotConfigButton_Click);
            // 
            // CloseButton
            // 
            this.CloseButton.CausesValidation = false;
            this.CloseButton.Location = new System.Drawing.Point(1229, 628);
            this.CloseButton.Name = "CloseButton";
            this.CloseButton.Size = new System.Drawing.Size(69, 57);
            this.CloseButton.TabIndex = 15;
            this.CloseButton.Text = "Close";
            this.CloseButton.UseVisualStyleBackColor = true;
            this.CloseButton.Click += new System.EventHandler(this.CloseButton_Click);
            // 
            // DictateButton
            // 
            this.DictateButton.CausesValidation = false;
            this.DictateButton.Location = new System.Drawing.Point(1158, 566);
            this.DictateButton.Name = "DictateButton";
            this.DictateButton.Size = new System.Drawing.Size(65, 120);
            this.DictateButton.TabIndex = 16;
            this.DictateButton.Text = "Dictate";
            this.DictateButton.UseVisualStyleBackColor = true;
            this.DictateButton.Click += new System.EventHandler(this.DictateButton_Click);
            // 
            // ChatBotForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Gainsboro;
            this.CausesValidation = false;
            this.ClientSize = new System.Drawing.Size(1309, 697);
            this.Controls.Add(this.DictateButton);
            this.Controls.Add(this.CloseButton);
            this.Controls.Add(this.ChatBotConfigButton);
            this.Controls.Add(this.LoadingImage);
            this.Controls.Add(this.submitButton);
            this.Controls.Add(this.richTextUserInput);
            this.Controls.Add(this.webView21);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "ChatBotForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Chat Bot";
            this.TopMost = true;
            this.Load += new System.EventHandler(this.ChatBotForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.webView21)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.LoadingImage)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Microsoft.Web.WebView2.WinForms.WebView2 webView21;
        private System.Windows.Forms.PictureBox LoadingImage;
        private System.Windows.Forms.RichTextBox richTextUserInput;
        private System.Windows.Forms.Button submitButton;
        private System.Windows.Forms.Button ChatBotConfigButton;
        private System.Windows.Forms.Button CloseButton;
        private System.Windows.Forms.Button DictateButton;
    }
}