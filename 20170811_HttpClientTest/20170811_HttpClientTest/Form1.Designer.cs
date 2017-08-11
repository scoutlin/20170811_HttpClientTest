namespace _20170811_HttpClientTest
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
            this.button1 = new System.Windows.Forms.Button();
            this.textBox_url = new System.Windows.Forms.TextBox();
            this.textBox_json = new System.Windows.Forms.TextBox();
            this.button2 = new System.Windows.Forms.Button();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(10, 107);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(181, 75);
            this.button1.TabIndex = 0;
            this.button1.Text = "AdminLogin";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // textBox_url
            // 
            this.textBox_url.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.textBox_url.Location = new System.Drawing.Point(10, 10);
            this.textBox_url.Name = "textBox_url";
            this.textBox_url.ReadOnly = true;
            this.textBox_url.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.textBox_url.Size = new System.Drawing.Size(1600, 31);
            this.textBox_url.TabIndex = 1;
            this.textBox_url.Text = "http://192.168.122.145:9478/egs-router/";
            // 
            // textBox_json
            // 
            this.textBox_json.Location = new System.Drawing.Point(10, 60);
            this.textBox_json.Multiline = true;
            this.textBox_json.Name = "textBox_json";
            this.textBox_json.ReadOnly = true;
            this.textBox_json.Size = new System.Drawing.Size(1600, 31);
            this.textBox_json.TabIndex = 2;
            this.textBox_json.Text = "{\"cmd\":\"EGS_Router_AdminLogin\",\"token\":\"\",\"timeStamp\":\"636380490833759307\",\"paylo" +
    "ad\":\"{\\\"account\\\":\\\"ES\\\",\\\"password\\\":\\\"whitehair\\\"}\"}";
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(0, 0);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 3;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // richTextBox1
            // 
            this.richTextBox1.Location = new System.Drawing.Point(12, 199);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(1122, 373);
            this.richTextBox1.TabIndex = 4;
            this.richTextBox1.Text = "";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(2300, 584);
            this.Controls.Add(this.richTextBox1);
            this.Controls.Add(this.textBox_json);
            this.Controls.Add(this.textBox_url);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox textBox_url;
        private System.Windows.Forms.TextBox textBox_json;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.RichTextBox richTextBox1;
    }
}

