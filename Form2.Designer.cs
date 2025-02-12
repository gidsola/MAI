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
            this.labelApiKey = new System.Windows.Forms.Label();
            this.textBoxApiKey = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.modelSelectBox = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.richTextSystemPrompt = new System.Windows.Forms.RichTextBox();
            this.groupBox1.SuspendLayout();
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
            // modelSelectBox
            // 
            this.modelSelectBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.modelSelectBox.FormattingEnabled = true;
            this.modelSelectBox.Items.AddRange(new object[] {
            "mistral-large-latest",
            "mistral-small-latest",
            "pixtral-large-latest"});
            this.modelSelectBox.Location = new System.Drawing.Point(15, 59);
            this.modelSelectBox.Name = "modelSelectBox";
            this.modelSelectBox.Size = new System.Drawing.Size(268, 28);
            this.modelSelectBox.TabIndex = 8;
            this.modelSelectBox.SelectedIndexChanged += new System.EventHandler(this.ModelSelectBox_SelectedIndexChanged);
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
            // richTextSystemPrompt
            // 
            this.richTextSystemPrompt.Location = new System.Drawing.Point(31, 36);
            this.richTextSystemPrompt.Name = "richTextSystemPrompt";
            this.richTextSystemPrompt.Size = new System.Drawing.Size(552, 332);
            this.richTextSystemPrompt.TabIndex = 5;
            this.richTextSystemPrompt.Text = "";
            this.richTextSystemPrompt.TextChanged += new System.EventHandler(this.RichTextSystemPrompt_TextChanged);
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
    }
}