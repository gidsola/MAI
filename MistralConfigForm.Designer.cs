namespace MAI.MistralConfigForm
{
    partial class ConfigurationForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ConfigurationForm));
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.chatbotConfigButton = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton1 = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.panel2 = new System.Windows.Forms.Panel();
            this.richTextSystemPrompt = new System.Windows.Forms.RichTextBox();
            this.textBoxApiKey = new System.Windows.Forms.TextBox();
            this.completionOptionsGroupBox = new System.Windows.Forms.GroupBox();
            this.safePromptOffCheckBox = new System.Windows.Forms.CheckBox();
            this.safePromptOnCheckBox = new System.Windows.Forms.CheckBox();
            this.safePromptLabel = new System.Windows.Forms.Label();
            this.maxTokensLabel = new System.Windows.Forms.Label();
            this.maxTokensUpDown = new System.Windows.Forms.NumericUpDown();
            this.topPLabel = new System.Windows.Forms.Label();
            this.topPUpDown = new System.Windows.Forms.NumericUpDown();
            this.modelSelectionLabel = new System.Windows.Forms.Label();
            this.modelSelectBox = new System.Windows.Forms.ComboBox();
            this.toolStrip1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.completionOptionsGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.maxTokensUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.topPUpDown)).BeginInit();
            this.SuspendLayout();
            // 
            // toolStrip1
            // 
            this.toolStrip1.Dock = System.Windows.Forms.DockStyle.Left;
            this.toolStrip1.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripSeparator1,
            this.chatbotConfigButton,
            this.toolStripButton1,
            this.toolStripSeparator2});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional;
            this.toolStrip1.Size = new System.Drawing.Size(141, 619);
            this.toolStrip1.TabIndex = 11;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(138, 6);
            // 
            // chatbotConfigButton
            // 
            this.chatbotConfigButton.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chatbotConfigButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.chatbotConfigButton.Name = "chatbotConfigButton";
            this.chatbotConfigButton.Size = new System.Drawing.Size(138, 21);
            this.chatbotConfigButton.Text = "ChatBot Configuration";
            this.chatbotConfigButton.ToolTipText = "Configure what provider, model and model settings to use for the chat bot interfa" +
    "ce.\r\n";
            // 
            // toolStripButton1
            // 
            this.toolStripButton1.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.toolStripButton1.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton1.Image")));
            this.toolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton1.Name = "toolStripButton1";
            this.toolStripButton1.Size = new System.Drawing.Size(138, 20);
            this.toolStripButton1.Text = "Back to Main";
            this.toolStripButton1.Click += new System.EventHandler(this.toolStripButton1_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(138, 6);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.richTextSystemPrompt);
            this.panel2.Controls.Add(this.textBoxApiKey);
            this.panel2.Controls.Add(this.completionOptionsGroupBox);
            this.panel2.Location = new System.Drawing.Point(144, 80);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1012, 527);
            this.panel2.TabIndex = 10;
            // 
            // richTextSystemPrompt
            // 
            this.richTextSystemPrompt.Font = new System.Drawing.Font("MS Reference Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.richTextSystemPrompt.Location = new System.Drawing.Point(304, 163);
            this.richTextSystemPrompt.Margin = new System.Windows.Forms.Padding(2);
            this.richTextSystemPrompt.Name = "richTextSystemPrompt";
            this.richTextSystemPrompt.Size = new System.Drawing.Size(640, 297);
            this.richTextSystemPrompt.TabIndex = 5;
            this.richTextSystemPrompt.Text = "";
            this.richTextSystemPrompt.TextChanged += new System.EventHandler(this.RichTextSystemPrompt_TextChanged);
            // 
            // textBoxApiKey
            // 
            this.textBoxApiKey.Font = new System.Drawing.Font("MS Reference Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxApiKey.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.textBoxApiKey.Location = new System.Drawing.Point(39, 69);
            this.textBoxApiKey.Margin = new System.Windows.Forms.Padding(2);
            this.textBoxApiKey.Name = "textBoxApiKey";
            this.textBoxApiKey.Size = new System.Drawing.Size(670, 24);
            this.textBoxApiKey.TabIndex = 4;
            this.textBoxApiKey.TextChanged += new System.EventHandler(this.TextBoxApiKey_TextChanged);
            // 
            // completionOptionsGroupBox
            // 
            this.completionOptionsGroupBox.Controls.Add(this.safePromptOffCheckBox);
            this.completionOptionsGroupBox.Controls.Add(this.safePromptOnCheckBox);
            this.completionOptionsGroupBox.Controls.Add(this.safePromptLabel);
            this.completionOptionsGroupBox.Controls.Add(this.maxTokensLabel);
            this.completionOptionsGroupBox.Controls.Add(this.maxTokensUpDown);
            this.completionOptionsGroupBox.Controls.Add(this.topPLabel);
            this.completionOptionsGroupBox.Controls.Add(this.topPUpDown);
            this.completionOptionsGroupBox.Controls.Add(this.modelSelectionLabel);
            this.completionOptionsGroupBox.Controls.Add(this.modelSelectBox);
            this.completionOptionsGroupBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.completionOptionsGroupBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.completionOptionsGroupBox.Location = new System.Drawing.Point(39, 137);
            this.completionOptionsGroupBox.Margin = new System.Windows.Forms.Padding(2);
            this.completionOptionsGroupBox.Name = "completionOptionsGroupBox";
            this.completionOptionsGroupBox.Padding = new System.Windows.Forms.Padding(2);
            this.completionOptionsGroupBox.Size = new System.Drawing.Size(226, 323);
            this.completionOptionsGroupBox.TabIndex = 1;
            this.completionOptionsGroupBox.TabStop = false;
            this.completionOptionsGroupBox.Text = "Completion Options";
            // 
            // safePromptOffCheckBox
            // 
            this.safePromptOffCheckBox.AutoSize = true;
            this.safePromptOffCheckBox.Checked = true;
            this.safePromptOffCheckBox.CheckState = System.Windows.Forms.CheckState.Checked;
            this.safePromptOffCheckBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.safePromptOffCheckBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.safePromptOffCheckBox.Location = new System.Drawing.Point(107, 236);
            this.safePromptOffCheckBox.Margin = new System.Windows.Forms.Padding(2);
            this.safePromptOffCheckBox.Name = "safePromptOffCheckBox";
            this.safePromptOffCheckBox.Size = new System.Drawing.Size(46, 21);
            this.safePromptOffCheckBox.TabIndex = 17;
            this.safePromptOffCheckBox.Text = "Off";
            this.safePromptOffCheckBox.UseVisualStyleBackColor = true;
            // 
            // safePromptOnCheckBox
            // 
            this.safePromptOnCheckBox.AutoSize = true;
            this.safePromptOnCheckBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.safePromptOnCheckBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.safePromptOnCheckBox.Location = new System.Drawing.Point(63, 236);
            this.safePromptOnCheckBox.Margin = new System.Windows.Forms.Padding(2);
            this.safePromptOnCheckBox.Name = "safePromptOnCheckBox";
            this.safePromptOnCheckBox.Size = new System.Drawing.Size(46, 21);
            this.safePromptOnCheckBox.TabIndex = 16;
            this.safePromptOnCheckBox.Text = "On";
            this.safePromptOnCheckBox.UseVisualStyleBackColor = true;
            // 
            // safePromptLabel
            // 
            this.safePromptLabel.AutoSize = true;
            this.safePromptLabel.Font = new System.Drawing.Font("MS Reference Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.safePromptLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.safePromptLabel.Location = new System.Drawing.Point(19, 206);
            this.safePromptLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.safePromptLabel.Name = "safePromptLabel";
            this.safePromptLabel.Size = new System.Drawing.Size(95, 18);
            this.safePromptLabel.TabIndex = 15;
            this.safePromptLabel.Text = "Safe Prompt";
            // 
            // maxTokensLabel
            // 
            this.maxTokensLabel.AutoSize = true;
            this.maxTokensLabel.Font = new System.Drawing.Font("MS Reference Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.maxTokensLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.maxTokensLabel.Location = new System.Drawing.Point(19, 140);
            this.maxTokensLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.maxTokensLabel.Name = "maxTokensLabel";
            this.maxTokensLabel.Size = new System.Drawing.Size(92, 18);
            this.maxTokensLabel.TabIndex = 13;
            this.maxTokensLabel.Text = "Max Tokens";
            // 
            // maxTokensUpDown
            // 
            this.maxTokensUpDown.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.maxTokensUpDown.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.maxTokensUpDown.Location = new System.Drawing.Point(22, 160);
            this.maxTokensUpDown.Margin = new System.Windows.Forms.Padding(2);
            this.maxTokensUpDown.Maximum = new decimal(new int[] {
            4096,
            0,
            0,
            0});
            this.maxTokensUpDown.Minimum = new decimal(new int[] {
            300,
            0,
            0,
            0});
            this.maxTokensUpDown.Name = "maxTokensUpDown";
            this.maxTokensUpDown.Size = new System.Drawing.Size(181, 23);
            this.maxTokensUpDown.TabIndex = 12;
            this.maxTokensUpDown.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.maxTokensUpDown.Value = new decimal(new int[] {
            1024,
            0,
            0,
            0});
            this.maxTokensUpDown.ValueChanged += new System.EventHandler(this.numericUpDown2ValueChanged);
            // 
            // topPLabel
            // 
            this.topPLabel.AutoSize = true;
            this.topPLabel.Font = new System.Drawing.Font("MS Reference Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.topPLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.topPLabel.Location = new System.Drawing.Point(19, 85);
            this.topPLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.topPLabel.Name = "topPLabel";
            this.topPLabel.Size = new System.Drawing.Size(53, 18);
            this.topPLabel.TabIndex = 11;
            this.topPLabel.Text = "Top_p";
            // 
            // topPUpDown
            // 
            this.topPUpDown.DecimalPlaces = 2;
            this.topPUpDown.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.topPUpDown.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.topPUpDown.Increment = new decimal(new int[] {
            1,
            0,
            0,
            131072});
            this.topPUpDown.Location = new System.Drawing.Point(22, 106);
            this.topPUpDown.Margin = new System.Windows.Forms.Padding(2);
            this.topPUpDown.Maximum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.topPUpDown.Name = "topPUpDown";
            this.topPUpDown.Size = new System.Drawing.Size(181, 23);
            this.topPUpDown.TabIndex = 10;
            this.topPUpDown.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.topPUpDown.Value = new decimal(new int[] {
            87,
            0,
            0,
            131072});
            this.topPUpDown.ValueChanged += new System.EventHandler(this.numericUpDown1ValueChanged);
            // 
            // modelSelectionLabel
            // 
            this.modelSelectionLabel.AutoSize = true;
            this.modelSelectionLabel.Font = new System.Drawing.Font("MS Reference Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.modelSelectionLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.modelSelectionLabel.Location = new System.Drawing.Point(19, 29);
            this.modelSelectionLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.modelSelectionLabel.Name = "modelSelectionLabel";
            this.modelSelectionLabel.Size = new System.Drawing.Size(116, 18);
            this.modelSelectionLabel.TabIndex = 9;
            this.modelSelectionLabel.Text = "Model Selection";
            // 
            // modelSelectBox
            // 
            this.modelSelectBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.modelSelectBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.modelSelectBox.FormattingEnabled = true;
            this.modelSelectBox.Items.AddRange(new object[] {
            "mistral-large-latest",
            "mistral-small-latest",
            "pixtral-large-latest"});
            this.modelSelectBox.Location = new System.Drawing.Point(22, 50);
            this.modelSelectBox.Margin = new System.Windows.Forms.Padding(2);
            this.modelSelectBox.Name = "modelSelectBox";
            this.modelSelectBox.Size = new System.Drawing.Size(182, 25);
            this.modelSelectBox.TabIndex = 8;
            this.modelSelectBox.SelectedIndexChanged += new System.EventHandler(this.ModelSelectBox_SelectedIndexChanged);
            // 
            // ConfigurationForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(1168, 619);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.toolStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "ConfigurationForm";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MAI Configuration";
            this.TopMost = true;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MistralConfigForm_Closing);
            this.Load += new System.EventHandler(this.Form2_Load);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.completionOptionsGroupBox.ResumeLayout(false);
            this.completionOptionsGroupBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.maxTokensUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.topPUpDown)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton chatbotConfigButton;
        private System.Windows.Forms.ToolStripButton toolStripButton1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TextBox textBoxApiKey;
        private System.Windows.Forms.GroupBox completionOptionsGroupBox;
        private System.Windows.Forms.CheckBox safePromptOffCheckBox;
        private System.Windows.Forms.CheckBox safePromptOnCheckBox;
        private System.Windows.Forms.Label safePromptLabel;
        private System.Windows.Forms.Label maxTokensLabel;
        private System.Windows.Forms.NumericUpDown maxTokensUpDown;
        private System.Windows.Forms.Label topPLabel;
        private System.Windows.Forms.NumericUpDown topPUpDown;
        private System.Windows.Forms.Label modelSelectionLabel;
        private System.Windows.Forms.ComboBox modelSelectBox;
        private System.Windows.Forms.RichTextBox richTextSystemPrompt;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
    }
}