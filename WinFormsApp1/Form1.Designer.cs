namespace WinFormsApp1
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label1 = new Label();
            groupBox1 = new GroupBox();
            label9 = new Label();
            label3 = new Label();
            numericUpDown1 = new NumericUpDown();
            comboBox1 = new ComboBox();
            groupBox2 = new GroupBox();
            textBox2 = new TextBox();
            textBox1 = new TextBox();
            label4 = new Label();
            label5 = new Label();
            textBox4 = new TextBox();
            label6 = new Label();
            button1 = new Button();
            label7 = new Label();
            progressBar2 = new ProgressBar();
            richTextBox2 = new RichTextBox();
            label8 = new Label();
            button3 = new Button();
            button2 = new Button();
            textBox3 = new TextBox();
            label2 = new Label();
            label10 = new Label();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)numericUpDown1).BeginInit();
            groupBox2.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 30F);
            label1.Location = new Point(332, 9);
            label1.Name = "label1";
            label1.Size = new Size(235, 54);
            label1.TabIndex = 0;
            label1.Text = "File Transfer";
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(label9);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(numericUpDown1);
            groupBox1.Controls.Add(comboBox1);
            groupBox1.Font = new Font("Segoe UI", 15F);
            groupBox1.Location = new Point(29, 66);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(419, 100);
            groupBox1.TabIndex = 2;
            groupBox1.TabStop = false;
            groupBox1.Text = "Remote Device";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Segoe UI", 15F);
            label9.Location = new Point(20, 41);
            label9.Name = "label9";
            label9.Size = new Size(28, 28);
            label9.TabIndex = 9;
            label9.Text = "IP";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 15F);
            label3.Location = new Point(257, 41);
            label3.Name = "label3";
            label3.Size = new Size(59, 28);
            label3.TabIndex = 5;
            label3.Text = "PORT";
            // 
            // numericUpDown1
            // 
            numericUpDown1.Location = new Point(322, 39);
            numericUpDown1.Maximum = new decimal(new int[] { 65535, 0, 0, 0 });
            numericUpDown1.Name = "numericUpDown1";
            numericUpDown1.Size = new Size(91, 34);
            numericUpDown1.TabIndex = 4;
            numericUpDown1.Value = new decimal(new int[] { 9999, 0, 0, 0 });
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Items.AddRange(new object[] { "127.0.0.1" });
            comboBox1.Location = new Point(54, 37);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(175, 36);
            comboBox1.TabIndex = 3;
            comboBox1.Text = "127.0.0.1";
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(textBox2);
            groupBox2.Controls.Add(textBox1);
            groupBox2.Controls.Add(label4);
            groupBox2.Controls.Add(label5);
            groupBox2.Font = new Font("Segoe UI", 15F);
            groupBox2.Location = new Point(454, 66);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(419, 100);
            groupBox2.TabIndex = 6;
            groupBox2.TabStop = false;
            groupBox2.Text = "My Device ";
            // 
            // textBox2
            // 
            textBox2.Location = new Point(322, 39);
            textBox2.Name = "textBox2";
            textBox2.ReadOnly = true;
            textBox2.Size = new Size(91, 34);
            textBox2.TabIndex = 8;
            textBox2.Text = "9999";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(54, 38);
            textBox1.Name = "textBox1";
            textBox1.ReadOnly = true;
            textBox1.Size = new Size(175, 34);
            textBox1.TabIndex = 7;
            textBox1.Text = "127.0.0.1";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 15F);
            label4.Location = new Point(257, 41);
            label4.Name = "label4";
            label4.Size = new Size(59, 28);
            label4.TabIndex = 5;
            label4.Text = "PORT";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 15F);
            label5.Location = new Point(20, 41);
            label5.Name = "label5";
            label5.Size = new Size(28, 28);
            label5.TabIndex = 2;
            label5.Text = "IP";
            // 
            // textBox4
            // 
            textBox4.Font = new Font("Segoe UI", 15F);
            textBox4.Location = new Point(559, 169);
            textBox4.Name = "textBox4";
            textBox4.ReadOnly = true;
            textBox4.Size = new Size(302, 34);
            textBox4.TabIndex = 14;
            textBox4.Text = "nameFile";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 15F);
            label6.Location = new Point(454, 172);
            label6.Name = "label6";
            label6.Size = new Size(99, 28);
            label6.TabIndex = 13;
            label6.Text = "File Name";
            // 
            // button1
            // 
            button1.Enabled = false;
            button1.Font = new Font("Segoe UI", 15F);
            button1.Location = new Point(29, 333);
            button1.Name = "button1";
            button1.Size = new Size(393, 49);
            button1.TabIndex = 9;
            button1.Text = "Send";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 15F);
            label7.Location = new Point(454, 203);
            label7.Name = "label7";
            label7.Size = new Size(39, 28);
            label7.TabIndex = 6;
            label7.Text = "0%";
            // 
            // progressBar2
            // 
            progressBar2.Location = new Point(521, 208);
            progressBar2.Name = "progressBar2";
            progressBar2.Size = new Size(340, 23);
            progressBar2.TabIndex = 5;
            // 
            // richTextBox2
            // 
            richTextBox2.Font = new Font("Segoe UI", 12F);
            richTextBox2.Location = new Point(454, 237);
            richTextBox2.Name = "richTextBox2";
            richTextBox2.Size = new Size(409, 205);
            richTextBox2.TabIndex = 4;
            richTextBox2.Text = "";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI", 15F);
            label8.Location = new Point(29, 246);
            label8.Name = "label8";
            label8.Size = new Size(91, 28);
            label8.TabIndex = 17;
            label8.Text = "File Send";
            // 
            // button3
            // 
            button3.Font = new Font("Segoe UI", 15F);
            button3.Location = new Point(29, 182);
            button3.Name = "button3";
            button3.Size = new Size(393, 49);
            button3.TabIndex = 12;
            button3.Text = "Connect";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // button2
            // 
            button2.Font = new Font("Segoe UI", 15F);
            button2.Location = new Point(29, 275);
            button2.Name = "button2";
            button2.Size = new Size(52, 34);
            button2.TabIndex = 11;
            button2.Text = "...";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // textBox3
            // 
            textBox3.Font = new Font("Segoe UI", 15F);
            textBox3.Location = new Point(87, 275);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(335, 34);
            textBox3.TabIndex = 10;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 15F);
            label2.ForeColor = Color.Fuchsia;
            label2.Location = new Point(124, 414);
            label2.Name = "label2";
            label2.Size = new Size(134, 28);
            label2.TabIndex = 2;
            label2.Text = "Chưa Kết Nối!";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Segoe UI", 15F);
            label10.Location = new Point(29, 414);
            label10.Name = "label10";
            label10.Size = new Size(101, 28);
            label10.TabIndex = 8;
            label10.Text = "Trạng Thái";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(897, 470);
            Controls.Add(label10);
            Controls.Add(groupBox2);
            Controls.Add(label2);
            Controls.Add(label8);
            Controls.Add(groupBox1);
            Controls.Add(textBox4);
            Controls.Add(label1);
            Controls.Add(label6);
            Controls.Add(label7);
            Controls.Add(button3);
            Controls.Add(progressBar2);
            Controls.Add(button1);
            Controls.Add(richTextBox2);
            Controls.Add(textBox3);
            Controls.Add(button2);
            Name = "Form1";
            Text = "File Transfer";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)numericUpDown1).EndInit();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private GroupBox groupBox1;
        private NumericUpDown numericUpDown1;
        private ComboBox comboBox1;
        private Label label3;
        private GroupBox groupBox2;
        private Label label4;
        private Label label5;
        public TextBox textBox2;
        public TextBox textBox1;
        public Label label7;
        public ProgressBar progressBar2;
        public RichTextBox richTextBox2;
        private Button button2;
        private TextBox textBox3;
        private Button button1;
        public TextBox textBox4;
        private Label label6;
        private Button button3;
        private Label label8;
        public Label label2;
        private Label label10;
        private Label label9;
    }
}
