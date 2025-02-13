namespace MAI.AppConfig
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
            this.button1 = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.SafePromptOff = new System.Windows.Forms.CheckBox();
            this.SafePromptOn = new System.Windows.Forms.CheckBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.numericUpDown2 = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.label3 = new System.Windows.Forms.Label();
            this.modelSelectBox = new System.Windows.Forms.ComboBox();
            this.labelApiKey = new System.Windows.Forms.Label();
            this.textBoxApiKey = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.richTextSystemPrompt = new System.Windows.Forms.RichTextBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.button1.Location = new System.Drawing.Point(871, 622);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(120, 51);
            this.button1.TabIndex = 0;
            this.button1.Text = "Close";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.SafePromptOff);
            this.groupBox1.Controls.Add(this.SafePromptOn);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.numericUpDown2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.numericUpDown1);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.modelSelectBox);
            this.groupBox1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.groupBox1.Location = new System.Drawing.Point(38, 187);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(301, 486);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Completion Options";
            // 
            // SafePromptOff
            // 
            this.SafePromptOff.AutoSize = true;
            this.SafePromptOff.Checked = true;
            this.SafePromptOff.CheckState = System.Windows.Forms.CheckState.Checked;
            this.SafePromptOff.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SafePromptOff.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.SafePromptOff.Location = new System.Drawing.Point(143, 290);
            this.SafePromptOff.Name = "SafePromptOff";
            this.SafePromptOff.Size = new System.Drawing.Size(54, 24);
            this.SafePromptOff.TabIndex = 17;
            this.SafePromptOff.Text = "Off";
            this.SafePromptOff.UseVisualStyleBackColor = true;
            // 
            // SafePromptOn
            // 
            this.SafePromptOn.AutoSize = true;
            this.SafePromptOn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SafePromptOn.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.SafePromptOn.Location = new System.Drawing.Point(84, 290);
            this.SafePromptOn.Name = "SafePromptOn";
            this.SafePromptOn.Size = new System.Drawing.Size(53, 24);
            this.SafePromptOn.TabIndex = 16;
            this.SafePromptOn.Text = "On";
            this.SafePromptOn.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.label4.Location = new System.Drawing.Point(25, 253);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(102, 20);
            this.label4.TabIndex = 15;
            this.label4.Text = "Safe Prompt";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.label2.Location = new System.Drawing.Point(25, 172);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(99, 20);
            this.label2.TabIndex = 13;
            this.label2.Text = "Max Tokens";
            // 
            // numericUpDown2
            // 
            this.numericUpDown2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numericUpDown2.Location = new System.Drawing.Point(29, 195);
            this.numericUpDown2.Maximum = new decimal(new int[] {
            4096,
            0,
            0,
            0});
            this.numericUpDown2.Minimum = new decimal(new int[] {
            300,
            0,
            0,
            0});
            this.numericUpDown2.Name = "numericUpDown2";
            this.numericUpDown2.Size = new System.Drawing.Size(241, 27);
            this.numericUpDown2.TabIndex = 12;
            this.numericUpDown2.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.numericUpDown2.Value = new decimal(new int[] {
            1024,
            0,
            0,
            0});
            this.numericUpDown2.ValueChanged += new System.EventHandler(this.numericUpDown2ValueChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.label1.Location = new System.Drawing.Point(25, 105);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(55, 20);
            this.label1.TabIndex = 11;
            this.label1.Text = "Top_p";
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.DecimalPlaces = 2;
            this.numericUpDown1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numericUpDown1.Increment = new decimal(new int[] {
            1,
            0,
            0,
            131072});
            this.numericUpDown1.Location = new System.Drawing.Point(29, 128);
            this.numericUpDown1.Maximum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(241, 27);
            this.numericUpDown1.TabIndex = 10;
            this.numericUpDown1.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.numericUpDown1.Value = new decimal(new int[] {
            87,
            0,
            0,
            131072});
            this.numericUpDown1.ValueChanged += new System.EventHandler(this.numericUpDown1ValueChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.label3.Location = new System.Drawing.Point(25, 36);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(128, 20);
            this.label3.TabIndex = 9;
            this.label3.Text = "Model Selection";
            // 
            // modelSelectBox
            // 
            this.modelSelectBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.modelSelectBox.FormattingEnabled = true;
            this.modelSelectBox.Items.AddRange(new object[] {
            "mistral-large-latest",
            "mistral-small-latest",
            "pixtral-large-latest"});
            this.modelSelectBox.Location = new System.Drawing.Point(29, 59);
            this.modelSelectBox.Name = "modelSelectBox";
            this.modelSelectBox.Size = new System.Drawing.Size(241, 28);
            this.modelSelectBox.TabIndex = 8;
            this.modelSelectBox.SelectedIndexChanged += new System.EventHandler(this.ModelSelectBox_SelectedIndexChanged);
            // 
            // labelApiKey
            // 
            this.labelApiKey.AutoSize = true;
            this.labelApiKey.BackColor = System.Drawing.Color.Transparent;
            this.labelApiKey.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelApiKey.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.labelApiKey.Location = new System.Drawing.Point(25, 38);
            this.labelApiKey.Name = "labelApiKey";
            this.labelApiKey.Size = new System.Drawing.Size(68, 20);
            this.labelApiKey.TabIndex = 7;
            this.labelApiKey.Text = "API Key";
            // 
            // textBoxApiKey
            // 
            this.textBoxApiKey.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxApiKey.Location = new System.Drawing.Point(99, 36);
            this.textBoxApiKey.Name = "textBoxApiKey";
            this.textBoxApiKey.Size = new System.Drawing.Size(327, 24);
            this.textBoxApiKey.TabIndex = 4;
            this.textBoxApiKey.TextChanged += new System.EventHandler(this.TextBoxApiKey_TextChanged);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.richTextSystemPrompt);
            this.groupBox2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.groupBox2.Location = new System.Drawing.Point(379, 187);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(612, 398);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "System Prompt";
            // 
            // richTextSystemPrompt
            // 
            this.richTextSystemPrompt.Location = new System.Drawing.Point(31, 36);
            this.richTextSystemPrompt.Name = "richTextSystemPrompt";
            this.richTextSystemPrompt.Size = new System.Drawing.Size(552, 332);
            this.richTextSystemPrompt.TabIndex = 5;
            this.richTextSystemPrompt.Text = "";
            this.richTextSystemPrompt.TextChanged += new System.EventHandler(this.RichTextSystemPrompt_TextChanged);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.textBoxApiKey);
            this.groupBox3.Controls.Add(this.labelApiKey);
            this.groupBox3.Location = new System.Drawing.Point(38, 63);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(953, 90);
            this.groupBox3.TabIndex = 8;
            this.groupBox3.TabStop = false;
            // 
            // ConfigurationForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.CancelButton = this.button1;
            this.ClientSize = new System.Drawing.Size(1028, 708);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.button1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "ConfigurationForm";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form2";
            this.TopMost = true;
            this.Load += new System.EventHandler(this.Form2_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox textBoxApiKey;
        private System.Windows.Forms.Label labelApiKey;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.ComboBox modelSelectBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.RichTextBox richTextSystemPrompt;
        private System.Windows.Forms.NumericUpDown numericUpDown1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown numericUpDown2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.CheckBox SafePromptOff;
        private System.Windows.Forms.CheckBox SafePromptOn;
        private System.Windows.Forms.Label label4;
    }
}