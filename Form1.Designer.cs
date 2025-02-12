using System;
using System.Windows.Forms;

namespace MistralChatApp
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.richTextUserInput = new System.Windows.Forms.RichTextBox();
            this.submitButton = new System.Windows.Forms.Button();
            this.textBoxApiKey = new System.Windows.Forms.TextBox();
            this.richTextSystemPrompt = new System.Windows.Forms.RichTextBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.labelSystemPrompt = new System.Windows.Forms.Label();
            this.labelApiKey = new System.Windows.Forms.Label();
            this.modelSelectBox = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.webView21 = new Microsoft.Web.WebView2.WinForms.WebView2();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.webView21)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // richTextUserInput
            // 
            this.richTextUserInput.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.richTextUserInput.Location = new System.Drawing.Point(435, 667);
            this.richTextUserInput.Name = "richTextUserInput";
            this.richTextUserInput.Size = new System.Drawing.Size(689, 110);
            this.richTextUserInput.TabIndex = 1;
            this.richTextUserInput.Text = "";
            this.richTextUserInput.TextChanged += new System.EventHandler(this.RichTextUserInput_TextChanged);
            // 
            // submitButton
            // 
            this.submitButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.submitButton.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.submitButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.submitButton.Location = new System.Drawing.Point(1166, 667);
            this.submitButton.Name = "submitButton";
            this.submitButton.Size = new System.Drawing.Size(138, 110);
            this.submitButton.TabIndex = 2;
            this.submitButton.Text = "Submit";
            this.submitButton.UseVisualStyleBackColor = false;
            this.submitButton.Click += new System.EventHandler(this.SubmitButton_Click);
            // 
            // textBoxApiKey
            // 
            this.textBoxApiKey.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxApiKey.Location = new System.Drawing.Point(46, 89);
            this.textBoxApiKey.Name = "textBoxApiKey";
            this.textBoxApiKey.Size = new System.Drawing.Size(348, 24);
            this.textBoxApiKey.TabIndex = 3;
            this.textBoxApiKey.TextChanged += new System.EventHandler(this.TextBoxApiKey_TextChanged);
            // 
            // richTextSystemPrompt
            // 
            this.richTextSystemPrompt.Location = new System.Drawing.Point(46, 464);
            this.richTextSystemPrompt.Name = "richTextSystemPrompt";
            this.richTextSystemPrompt.Size = new System.Drawing.Size(348, 313);
            this.richTextSystemPrompt.TabIndex = 4;
            this.richTextSystemPrompt.Text = "";
            this.richTextSystemPrompt.TextChanged += new System.EventHandler(this.RichTextSystemPrompt_TextChanged);
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem1});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1342, 30);
            this.menuStrip1.TabIndex = 5;
            this.menuStrip1.Text = "menuStrip1";
            this.menuStrip1.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.menuStrip1_ItemClicked);
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.exitToolStripMenuItem});
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(49, 26);
            this.toolStripMenuItem1.Text = "Edit";
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(209, 26);
            this.exitToolStripMenuItem.Text = "API Configuration";
            // 
            // labelSystemPrompt
            // 
            this.labelSystemPrompt.AutoSize = true;
            this.labelSystemPrompt.BackColor = System.Drawing.Color.Transparent;
            this.labelSystemPrompt.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelSystemPrompt.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.labelSystemPrompt.Location = new System.Drawing.Point(51, 441);
            this.labelSystemPrompt.Name = "labelSystemPrompt";
            this.labelSystemPrompt.Size = new System.Drawing.Size(283, 20);
            this.labelSystemPrompt.TabIndex = 6;
            this.labelSystemPrompt.Text = "Assistant Guidance (system prompt)";
            // 
            // labelApiKey
            // 
            this.labelApiKey.AutoSize = true;
            this.labelApiKey.BackColor = System.Drawing.Color.Transparent;
            this.labelApiKey.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelApiKey.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.labelApiKey.Location = new System.Drawing.Point(51, 66);
            this.labelApiKey.Name = "labelApiKey";
            this.labelApiKey.Size = new System.Drawing.Size(68, 20);
            this.labelApiKey.TabIndex = 6;
            this.labelApiKey.Text = "API Key";
            this.labelApiKey.Click += new System.EventHandler(this.LabelApiKey_Click);
            // 
            // modelSelectBox
            // 
            this.modelSelectBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.modelSelectBox.FormattingEnabled = true;
            this.modelSelectBox.Items.AddRange(new object[] {
            "mistral-large-latest",
            "mistral-small-latest",
            "pixtral-large-latest"});
            this.modelSelectBox.Location = new System.Drawing.Point(46, 170);
            this.modelSelectBox.Name = "modelSelectBox";
            this.modelSelectBox.Size = new System.Drawing.Size(348, 28);
            this.modelSelectBox.TabIndex = 7;
            this.modelSelectBox.SelectedIndexChanged += new System.EventHandler(this.ModelSelectBox_SelectedIndexChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.label3.Location = new System.Drawing.Point(55, 148);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(128, 20);
            this.label3.TabIndex = 8;
            this.label3.Text = "Model Selection";
            // 
            // webView21
            // 
            this.webView21.AllowExternalDrop = true;
            this.webView21.BackColor = System.Drawing.Color.White;
            this.webView21.CreationProperties = null;
            this.webView21.DefaultBackgroundColor = System.Drawing.Color.White;
            this.webView21.Location = new System.Drawing.Point(435, 66);
            this.webView21.Name = "webView21";
            this.webView21.Padding = new System.Windows.Forms.Padding(5);
            this.webView21.Size = new System.Drawing.Size(869, 560);
            this.webView21.TabIndex = 9;
            this.webView21.ZoomFactor = 1D;
            this.webView21.Click += new System.EventHandler(this.webView21_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox1.Cursor = System.Windows.Forms.Cursors.WaitCursor;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(745, 227);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(148, 162);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox1.TabIndex = 10;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.UseWaitCursor = true;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(1342, 814);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.webView21);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.modelSelectBox);
            this.Controls.Add(this.labelApiKey);
            this.Controls.Add(this.labelSystemPrompt);
            this.Controls.Add(this.richTextSystemPrompt);
            this.Controls.Add(this.textBoxApiKey);
            this.Controls.Add(this.submitButton);
            this.Controls.Add(this.richTextUserInput);
            this.Controls.Add(this.menuStrip1);
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MIA (Mistral Api Interface)";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_Closing);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.webView21)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.RichTextBox richTextUserInput;
        private System.Windows.Forms.Button submitButton;
        private System.Windows.Forms.TextBox textBoxApiKey;
        private System.Windows.Forms.RichTextBox richTextSystemPrompt;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.Label labelSystemPrompt;
        private System.Windows.Forms.Label labelApiKey;
        private ComboBox modelSelectBox;
        private Label label3;
        private Microsoft.Web.WebView2.WinForms.WebView2 webView21;
        private PictureBox pictureBox1;
    }
}

