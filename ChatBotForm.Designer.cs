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
            this.LoadingImage = new System.Windows.Forms.PictureBox();
            this.richTextUserInput = new System.Windows.Forms.RichTextBox();
            this.submitButton = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.explainButton = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.webView21)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.LoadingImage)).BeginInit();
            this.SuspendLayout();
            // 
            // webView21
            // 
            this.webView21.AllowExternalDrop = true;
            this.webView21.BackColor = System.Drawing.Color.White;
            this.webView21.CreationProperties = null;
            this.webView21.DefaultBackgroundColor = System.Drawing.Color.White;
            this.webView21.Location = new System.Drawing.Point(12, 11);
            this.webView21.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.webView21.Name = "webView21";
            this.webView21.Padding = new System.Windows.Forms.Padding(5);
            this.webView21.Size = new System.Drawing.Size(1343, 582);
            this.webView21.TabIndex = 10;
            this.webView21.ZoomFactor = 1D;
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
            this.LoadingImage.Location = new System.Drawing.Point(591, 219);
            this.LoadingImage.Margin = new System.Windows.Forms.Padding(0);
            this.LoadingImage.Name = "LoadingImage";
            this.LoadingImage.Size = new System.Drawing.Size(148, 162);
            this.LoadingImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.LoadingImage.TabIndex = 11;
            this.LoadingImage.TabStop = false;
            this.LoadingImage.UseWaitCursor = true;
            // 
            // richTextUserInput
            // 
            this.richTextUserInput.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.richTextUserInput.Location = new System.Drawing.Point(290, 600);
            this.richTextUserInput.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.richTextUserInput.Name = "richTextUserInput";
            this.richTextUserInput.Size = new System.Drawing.Size(860, 147);
            this.richTextUserInput.TabIndex = 12;
            this.richTextUserInput.Text = "";
            // 
            // submitButton
            // 
            this.submitButton.BackColor = System.Drawing.Color.Transparent;
            this.submitButton.Font = new System.Drawing.Font("MS Reference Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.submitButton.ForeColor = System.Drawing.Color.Blue;
            this.submitButton.Location = new System.Drawing.Point(12, 600);
            this.submitButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.submitButton.Name = "submitButton";
            this.submitButton.Size = new System.Drawing.Size(170, 110);
            this.submitButton.TabIndex = 13;
            this.submitButton.Text = "Submit";
            this.submitButton.UseVisualStyleBackColor = false;
            this.submitButton.Click += new System.EventHandler(this.SubmitButton_Click);
            // 
            // button2
            // 
            this.button2.ForeColor = System.Drawing.Color.Red;
            this.button2.Location = new System.Drawing.Point(21, 714);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 33);
            this.button2.TabIndex = 15;
            this.button2.Text = "Pause";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.PauseResumeButton_Click);
            // 
            // explainButton
            // 
            this.explainButton.Font = new System.Drawing.Font("MS Reference Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.explainButton.ForeColor = System.Drawing.Color.Fuchsia;
            this.explainButton.Location = new System.Drawing.Point(188, 664);
            this.explainButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.explainButton.Name = "explainButton";
            this.explainButton.Size = new System.Drawing.Size(96, 46);
            this.explainButton.TabIndex = 16;
            this.explainButton.Text = "Explain";
            this.explainButton.UseVisualStyleBackColor = true;
            this.explainButton.Click += new System.EventHandler(this.ExplainButton_Click);
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("MS Reference Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.Fuchsia;
            this.button1.Location = new System.Drawing.Point(188, 600);
            this.button1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(96, 58);
            this.button1.TabIndex = 17;
            this.button1.Text = "Voice";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // ChatBotForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1367, 772);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.explainButton);
            this.Controls.Add(this.submitButton);
            this.Controls.Add(this.richTextUserInput);
            this.Controls.Add(this.LoadingImage);
            this.Controls.Add(this.webView21);
            this.DoubleBuffered = true;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "ChatBotForm";
            this.Text = "MistralAI";
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
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button explainButton;
        private System.Windows.Forms.Button button1;
    }
}