using System.Windows.Forms;

namespace MAI
{
    partial class MainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.chatBotMenuItem = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.imageGenMenuItem = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.configMenuItem = new System.Windows.Forms.ToolStripButton();
            this.chatbotPanel = new System.Windows.Forms.Panel();
            this.closeButton = new System.Windows.Forms.Button();
            this.dictateButton = new System.Windows.Forms.Button();
            this.chatBotConfigButton = new System.Windows.Forms.Button();
            this.LoadingImage = new System.Windows.Forms.PictureBox();
            this.webView21 = new Microsoft.Web.WebView2.WinForms.WebView2();
            this.richTextUserInput = new System.Windows.Forms.RichTextBox();
            this.submitButton = new System.Windows.Forms.Button();
            this.imageGenPanel = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.imageGenLoadingImage = new System.Windows.Forms.PictureBox();
            this.imageGenResponseWindow = new Microsoft.Web.WebView2.WinForms.WebView2();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.button4 = new System.Windows.Forms.Button();
            this.toolStrip1.SuspendLayout();
            this.chatbotPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.LoadingImage)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.webView21)).BeginInit();
            this.imageGenPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.imageGenLoadingImage)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imageGenResponseWindow)).BeginInit();
            this.SuspendLayout();
            // 
            // toolStrip1
            // 
            this.toolStrip1.AllowItemReorder = true;
            this.toolStrip1.BackColor = System.Drawing.Color.Transparent;
            this.toolStrip1.Dock = System.Windows.Forms.DockStyle.Left;
            this.toolStrip1.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.toolStrip1.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.toolStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripSeparator1,
            this.chatBotMenuItem,
            this.toolStripSeparator2,
            this.imageGenMenuItem,
            this.toolStripSeparator3,
            this.configMenuItem});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional;
            this.toolStrip1.Size = new System.Drawing.Size(124, 729);
            this.toolStrip1.TabIndex = 12;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(121, 6);
            // 
            // chatBotMenuItem
            // 
            this.chatBotMenuItem.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.chatBotMenuItem.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.chatBotMenuItem.Name = "chatBotMenuItem";
            this.chatBotMenuItem.Size = new System.Drawing.Size(121, 23);
            this.chatBotMenuItem.Text = "Chat Bot";
            this.chatBotMenuItem.ToolTipText = "Chat Bot Interface";
            this.chatBotMenuItem.Click += new System.EventHandler(this.ChatBotMenuItem_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(121, 6);
            // 
            // imageGenMenuItem
            // 
            this.imageGenMenuItem.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.imageGenMenuItem.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.imageGenMenuItem.Name = "imageGenMenuItem";
            this.imageGenMenuItem.Size = new System.Drawing.Size(121, 23);
            this.imageGenMenuItem.Text = "Image Generation";
            this.imageGenMenuItem.ToolTipText = "GetImg Image Generator";
            this.imageGenMenuItem.Click += new System.EventHandler(this.ImageGenMenuItem_Click);
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(121, 6);
            // 
            // configMenuItem
            // 
            this.configMenuItem.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.configMenuItem.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.configMenuItem.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.configMenuItem.Image = global::MAI.Properties.Resources._10711790;
            this.configMenuItem.Name = "configMenuItem";
            this.configMenuItem.Size = new System.Drawing.Size(121, 24);
            this.configMenuItem.Text = "Configuration";
            this.configMenuItem.Click += new System.EventHandler(this.ConfigMenuItem_Click);
            // 
            // chatbotPanel
            // 
            this.chatbotPanel.Controls.Add(this.closeButton);
            this.chatbotPanel.Controls.Add(this.dictateButton);
            this.chatbotPanel.Controls.Add(this.chatBotConfigButton);
            this.chatbotPanel.Controls.Add(this.LoadingImage);
            this.chatbotPanel.Controls.Add(this.webView21);
            this.chatbotPanel.Controls.Add(this.richTextUserInput);
            this.chatbotPanel.Controls.Add(this.submitButton);
            this.chatbotPanel.Location = new System.Drawing.Point(154, 12);
            this.chatbotPanel.Name = "chatbotPanel";
            this.chatbotPanel.Size = new System.Drawing.Size(1181, 705);
            this.chatbotPanel.TabIndex = 13;
            // 
            // closeButton
            // 
            this.closeButton.CausesValidation = false;
            this.closeButton.Location = new System.Drawing.Point(1097, 636);
            this.closeButton.Name = "closeButton";
            this.closeButton.Size = new System.Drawing.Size(69, 57);
            this.closeButton.TabIndex = 15;
            this.closeButton.Text = "Close";
            this.closeButton.UseVisualStyleBackColor = true;
            this.closeButton.Click += new System.EventHandler(this.CloseButton_Click);
            // 
            // dictateButton
            // 
            this.dictateButton.CausesValidation = false;
            this.dictateButton.Location = new System.Drawing.Point(1027, 573);
            this.dictateButton.Name = "dictateButton";
            this.dictateButton.Size = new System.Drawing.Size(65, 120);
            this.dictateButton.TabIndex = 16;
            this.dictateButton.Text = "Dictate";
            this.dictateButton.UseVisualStyleBackColor = true;
            this.dictateButton.Click += new System.EventHandler(this.DictateButton_Click);
            // 
            // chatBotConfigButton
            // 
            this.chatBotConfigButton.CausesValidation = false;
            this.chatBotConfigButton.Location = new System.Drawing.Point(1098, 573);
            this.chatBotConfigButton.Name = "chatBotConfigButton";
            this.chatBotConfigButton.Size = new System.Drawing.Size(69, 57);
            this.chatBotConfigButton.TabIndex = 14;
            this.chatBotConfigButton.Text = "Config";
            this.chatBotConfigButton.UseVisualStyleBackColor = true;
            this.chatBotConfigButton.Click += new System.EventHandler(this.ChatBotConfigButton_Click);
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
            this.LoadingImage.Location = new System.Drawing.Point(503, 212);
            this.LoadingImage.Margin = new System.Windows.Forms.Padding(0);
            this.LoadingImage.Name = "LoadingImage";
            this.LoadingImage.Size = new System.Drawing.Size(148, 162);
            this.LoadingImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.LoadingImage.TabIndex = 11;
            this.LoadingImage.TabStop = false;
            this.LoadingImage.UseWaitCursor = true;
            // 
            // webView21
            // 
            this.webView21.AllowExternalDrop = true;
            this.webView21.BackColor = System.Drawing.Color.DarkGray;
            this.webView21.CausesValidation = false;
            this.webView21.CreationProperties = null;
            this.webView21.DefaultBackgroundColor = System.Drawing.Color.DarkGray;
            this.webView21.Location = new System.Drawing.Point(13, 12);
            this.webView21.Margin = new System.Windows.Forms.Padding(2);
            this.webView21.Name = "webView21";
            this.webView21.Padding = new System.Windows.Forms.Padding(4);
            this.webView21.Size = new System.Drawing.Size(1153, 550);
            this.webView21.TabIndex = 10;
            this.webView21.ZoomFactor = 1D;
            // 
            // richTextUserInput
            // 
            this.richTextUserInput.BackColor = System.Drawing.Color.DarkGray;
            this.richTextUserInput.CausesValidation = false;
            this.richTextUserInput.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.richTextUserInput.Location = new System.Drawing.Point(13, 573);
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
            this.submitButton.Location = new System.Drawing.Point(909, 573);
            this.submitButton.Margin = new System.Windows.Forms.Padding(2);
            this.submitButton.Name = "submitButton";
            this.submitButton.Size = new System.Drawing.Size(113, 120);
            this.submitButton.TabIndex = 13;
            this.submitButton.Text = "Submit";
            this.submitButton.UseVisualStyleBackColor = false;
            this.submitButton.Click += new System.EventHandler(this.SubmitButton_Click);
            // 
            // imageGenPanel
            // 
            this.imageGenPanel.Controls.Add(this.button1);
            this.imageGenPanel.Controls.Add(this.button2);
            this.imageGenPanel.Controls.Add(this.button3);
            this.imageGenPanel.Controls.Add(this.imageGenLoadingImage);
            this.imageGenPanel.Controls.Add(this.imageGenResponseWindow);
            this.imageGenPanel.Controls.Add(this.richTextBox1);
            this.imageGenPanel.Controls.Add(this.button4);
            this.imageGenPanel.Location = new System.Drawing.Point(154, 12);
            this.imageGenPanel.Name = "imageGenPanel";
            this.imageGenPanel.Size = new System.Drawing.Size(1181, 705);
            this.imageGenPanel.TabIndex = 17;
            // 
            // button1
            // 
            this.button1.CausesValidation = false;
            this.button1.Location = new System.Drawing.Point(1097, 636);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(69, 57);
            this.button1.TabIndex = 15;
            this.button1.Text = "Close";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.CausesValidation = false;
            this.button2.Location = new System.Drawing.Point(1027, 573);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(65, 120);
            this.button2.TabIndex = 16;
            this.button2.Text = "Dictate";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            this.button3.CausesValidation = false;
            this.button3.Location = new System.Drawing.Point(1098, 573);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(69, 57);
            this.button3.TabIndex = 14;
            this.button3.Text = "Config";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // imageGenLoadingImage
            // 
            this.imageGenLoadingImage.BackColor = System.Drawing.Color.Transparent;
            this.imageGenLoadingImage.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.imageGenLoadingImage.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.imageGenLoadingImage.Cursor = System.Windows.Forms.Cursors.WaitCursor;
            this.imageGenLoadingImage.ErrorImage = null;
            this.imageGenLoadingImage.Image = ((System.Drawing.Image)(resources.GetObject("imageGenLoadingImage.Image")));
            this.imageGenLoadingImage.InitialImage = null;
            this.imageGenLoadingImage.Location = new System.Drawing.Point(503, 212);
            this.imageGenLoadingImage.Margin = new System.Windows.Forms.Padding(0);
            this.imageGenLoadingImage.Name = "imageGenLoadingImage";
            this.imageGenLoadingImage.Size = new System.Drawing.Size(148, 162);
            this.imageGenLoadingImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.imageGenLoadingImage.TabIndex = 11;
            this.imageGenLoadingImage.TabStop = false;
            this.imageGenLoadingImage.UseWaitCursor = true;
            // 
            // imageGenResponseWindow
            // 
            this.imageGenResponseWindow.AllowExternalDrop = true;
            this.imageGenResponseWindow.BackColor = System.Drawing.Color.DarkGray;
            this.imageGenResponseWindow.CausesValidation = false;
            this.imageGenResponseWindow.CreationProperties = null;
            this.imageGenResponseWindow.DefaultBackgroundColor = System.Drawing.Color.DarkGray;
            this.imageGenResponseWindow.Location = new System.Drawing.Point(13, 12);
            this.imageGenResponseWindow.Margin = new System.Windows.Forms.Padding(2);
            this.imageGenResponseWindow.Name = "imageGenResponseWindow";
            this.imageGenResponseWindow.Padding = new System.Windows.Forms.Padding(4);
            this.imageGenResponseWindow.Size = new System.Drawing.Size(1153, 550);
            this.imageGenResponseWindow.TabIndex = 10;
            this.imageGenResponseWindow.ZoomFactor = 1D;
            // 
            // richTextBox1
            // 
            this.richTextBox1.BackColor = System.Drawing.Color.DarkGray;
            this.richTextBox1.CausesValidation = false;
            this.richTextBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.richTextBox1.Location = new System.Drawing.Point(13, 573);
            this.richTextBox1.Margin = new System.Windows.Forms.Padding(2);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(892, 120);
            this.richTextBox1.TabIndex = 12;
            this.richTextBox1.Text = "";
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.Color.Transparent;
            this.button4.CausesValidation = false;
            this.button4.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.button4.FlatAppearance.BorderSize = 0;
            this.button4.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.button4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.button4.Location = new System.Drawing.Point(909, 573);
            this.button4.Margin = new System.Windows.Forms.Padding(2);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(113, 120);
            this.button4.TabIndex = 13;
            this.button4.Text = "Submit";
            this.button4.UseVisualStyleBackColor = false;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(1460, 729);
            this.Controls.Add(this.imageGenPanel);
            this.Controls.Add(this.chatbotPanel);
            this.Controls.Add(this.toolStrip1);
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2);
            this.MaximizeBox = false;
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MIA";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.chatbotPanel.ResumeLayout(false);
            this.chatbotPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.LoadingImage)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.webView21)).EndInit();
            this.imageGenPanel.ResumeLayout(false);
            this.imageGenPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.imageGenLoadingImage)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imageGenResponseWindow)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private ToolStrip toolStrip1;
        private ToolStripSeparator toolStripSeparator1;
        private ToolStripButton chatBotMenuItem;
        private ToolStripSeparator toolStripSeparator2;
        private ToolStripSeparator toolStripSeparator3;
        private ToolStripButton imageGenMenuItem;
        private ToolStripButton configMenuItem;
        private Panel chatbotPanel;
        private Microsoft.Web.WebView2.WinForms.WebView2 webView21;
        private PictureBox LoadingImage;
        private RichTextBox richTextUserInput;
        private Button submitButton;
        private Button dictateButton;
        private Button chatBotConfigButton;
        private Button closeButton;
        private Panel imageGenPanel;
        private Button button1;
        private Button button2;
        private Button button3;
        private PictureBox imageGenLoadingImage;
        private Microsoft.Web.WebView2.WinForms.WebView2 imageGenResponseWindow;
        private RichTextBox richTextBox1;
        private Button button4;
    }
}

