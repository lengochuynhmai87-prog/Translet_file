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
            remotePort = new NumericUpDown();
            remoteIP = new ComboBox();
            groupBox2 = new GroupBox();
            textBox2 = new TextBox();
            textBox1 = new TextBox();
            label4 = new Label();
            label5 = new Label();
            txtFilename = new TextBox();
            label6 = new Label();
            btnSend = new Button();
            label7 = new Label();
            progressBar2 = new ProgressBar();
            richTextBox2 = new RichTextBox();
            label8 = new Label();
            btnConnect = new Button();
            button2 = new Button();
            textBox3 = new TextBox();
            label2 = new Label();
            label10 = new Label();
            tabControl1 = new TabControl();
            Send = new TabPage();
            Queue = new TabPage();
            listBox1 = new ListBox();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)remotePort).BeginInit();
            groupBox2.SuspendLayout();
            tabControl1.SuspendLayout();
            Send.SuspendLayout();
            Queue.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 30F);
            label1.Location = new Point(427, 13);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(289, 67);
            label1.TabIndex = 0;
            label1.Text = "File Transfer";
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(label9);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(remotePort);
            groupBox1.Controls.Add(remoteIP);
            groupBox1.Font = new Font("Segoe UI", 15F);
            groupBox1.Location = new Point(37, 92);
            groupBox1.Margin = new Padding(4);
            groupBox1.Name = "groupBox1";
            groupBox1.Padding = new Padding(4);
            groupBox1.Size = new Size(539, 140);
            groupBox1.TabIndex = 2;
            groupBox1.TabStop = false;
            groupBox1.Text = "Remote Device";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Segoe UI", 15F);
            label9.Location = new Point(26, 57);
            label9.Margin = new Padding(4, 0, 4, 0);
            label9.Name = "label9";
            label9.Size = new Size(36, 35);
            label9.TabIndex = 9;
            label9.Text = "IP";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 15F);
            label3.Location = new Point(330, 57);
            label3.Margin = new Padding(4, 0, 4, 0);
            label3.Name = "label3";
            label3.Size = new Size(75, 35);
            label3.TabIndex = 5;
            label3.Text = "PORT";
            // 
            // remotePort
            // 
            remotePort.Location = new Point(414, 55);
            remotePort.Margin = new Padding(4);
            remotePort.Maximum = new decimal(new int[] { 65535, 0, 0, 0 });
            remotePort.Name = "remotePort";
            remotePort.Size = new Size(117, 41);
            remotePort.TabIndex = 4;
            remotePort.Value = new decimal(new int[] { 9999, 0, 0, 0 });
            // 
            // remoteIP
            // 
            remoteIP.FormattingEnabled = true;
            remoteIP.Items.AddRange(new object[] { "127.0.0.1" });
            remoteIP.Location = new Point(69, 52);
            remoteIP.Margin = new Padding(4);
            remoteIP.Name = "remoteIP";
            remoteIP.Size = new Size(224, 43);
            remoteIP.TabIndex = 3;
            remoteIP.Text = "127.0.0.1";
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(textBox2);
            groupBox2.Controls.Add(textBox1);
            groupBox2.Controls.Add(label4);
            groupBox2.Controls.Add(label5);
            groupBox2.Font = new Font("Segoe UI", 15F);
            groupBox2.Location = new Point(584, 92);
            groupBox2.Margin = new Padding(4);
            groupBox2.Name = "groupBox2";
            groupBox2.Padding = new Padding(4);
            groupBox2.Size = new Size(539, 140);
            groupBox2.TabIndex = 6;
            groupBox2.TabStop = false;
            groupBox2.Text = "My Device ";
            // 
            // textBox2
            // 
            textBox2.Location = new Point(414, 55);
            textBox2.Margin = new Padding(4);
            textBox2.Name = "textBox2";
            textBox2.ReadOnly = true;
            textBox2.Size = new Size(116, 41);
            textBox2.TabIndex = 8;
            textBox2.Text = "9999";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(69, 53);
            textBox1.Margin = new Padding(4);
            textBox1.Name = "textBox1";
            textBox1.ReadOnly = true;
            textBox1.Size = new Size(224, 41);
            textBox1.TabIndex = 7;
            textBox1.Text = "127.0.0.1";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 15F);
            label4.Location = new Point(330, 57);
            label4.Margin = new Padding(4, 0, 4, 0);
            label4.Name = "label4";
            label4.Size = new Size(75, 35);
            label4.TabIndex = 5;
            label4.Text = "PORT";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 15F);
            label5.Location = new Point(26, 57);
            label5.Margin = new Padding(4, 0, 4, 0);
            label5.Name = "label5";
            label5.Size = new Size(36, 35);
            label5.TabIndex = 2;
            label5.Text = "IP";
            // 
            // txtFilename
            // 
            txtFilename.Font = new Font("Segoe UI", 15F);
            txtFilename.Location = new Point(678, 8);
            txtFilename.Margin = new Padding(4);
            txtFilename.Name = "txtFilename";
            txtFilename.ReadOnly = true;
            txtFilename.Size = new Size(387, 41);
            txtFilename.TabIndex = 14;
            txtFilename.Text = "nameFile";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 15F);
            label6.Location = new Point(543, 13);
            label6.Margin = new Padding(4, 0, 4, 0);
            label6.Name = "label6";
            label6.Size = new Size(126, 35);
            label6.TabIndex = 13;
            label6.Text = "File Name";
            // 
            // btnSend
            // 
            btnSend.Enabled = false;
            btnSend.Font = new Font("Segoe UI", 15F);
            btnSend.Location = new Point(8, 220);
            btnSend.Margin = new Padding(4);
            btnSend.Name = "btnSend";
            btnSend.Size = new Size(505, 69);
            btnSend.TabIndex = 9;
            btnSend.Text = "Send";
            btnSend.UseVisualStyleBackColor = true;
            btnSend.Click += btnSend_Click;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 15F);
            label7.Location = new Point(543, 56);
            label7.Margin = new Padding(4, 0, 4, 0);
            label7.Name = "label7";
            label7.Size = new Size(48, 35);
            label7.TabIndex = 6;
            label7.Text = "0%";
            // 
            // progressBar2
            // 
            progressBar2.Location = new Point(629, 63);
            progressBar2.Margin = new Padding(4);
            progressBar2.Name = "progressBar2";
            progressBar2.Size = new Size(437, 32);
            progressBar2.TabIndex = 5;
            // 
            // richTextBox2
            // 
            richTextBox2.Font = new Font("Segoe UI", 12F);
            richTextBox2.Location = new Point(543, 104);
            richTextBox2.Margin = new Padding(4);
            richTextBox2.Name = "richTextBox2";
            richTextBox2.Size = new Size(525, 266);
            richTextBox2.TabIndex = 4;
            richTextBox2.Text = "";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI", 15F);
            label8.Location = new Point(8, 98);
            label8.Margin = new Padding(4, 0, 4, 0);
            label8.Name = "label8";
            label8.Size = new Size(114, 35);
            label8.TabIndex = 17;
            label8.Text = "File Send";
            // 
            // btnConnect
            // 
            btnConnect.Font = new Font("Segoe UI", 15F);
            btnConnect.Location = new Point(8, 0);
            btnConnect.Margin = new Padding(4);
            btnConnect.Name = "btnConnect";
            btnConnect.Size = new Size(505, 69);
            btnConnect.TabIndex = 12;
            btnConnect.Text = "Connect";
            btnConnect.UseVisualStyleBackColor = true;
            btnConnect.Click += btnConnect_Click;
            // 
            // button2
            // 
            button2.Font = new Font("Segoe UI", 15F);
            button2.Location = new Point(8, 139);
            button2.Margin = new Padding(4);
            button2.Name = "button2";
            button2.Size = new Size(67, 48);
            button2.TabIndex = 11;
            button2.Text = "...";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // textBox3
            // 
            textBox3.Font = new Font("Segoe UI", 15F);
            textBox3.Location = new Point(82, 139);
            textBox3.Margin = new Padding(4);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(430, 41);
            textBox3.TabIndex = 10;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 15F);
            label2.ForeColor = Color.Fuchsia;
            label2.Location = new Point(131, 332);
            label2.Margin = new Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new Size(169, 35);
            label2.TabIndex = 2;
            label2.Text = "Chưa Kết Nối!";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Segoe UI", 15F);
            label10.Location = new Point(9, 332);
            label10.Margin = new Padding(4, 0, 4, 0);
            label10.Name = "label10";
            label10.Size = new Size(130, 35);
            label10.TabIndex = 8;
            label10.Text = "Trạng Thái";
            // 
            // tabControl1
            // 
            tabControl1.Controls.Add(Send);
            tabControl1.Controls.Add(Queue);
            tabControl1.Font = new Font("Segoe UI", 15F);
            tabControl1.Location = new Point(39, 241);
            tabControl1.Margin = new Padding(4);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(1084, 435);
            tabControl1.TabIndex = 18;
            // 
            // Send
            // 
            Send.BackColor = SystemColors.Control;
            Send.Controls.Add(btnConnect);
            Send.Controls.Add(label10);
            Send.Controls.Add(button2);
            Send.Controls.Add(textBox3);
            Send.Controls.Add(label2);
            Send.Controls.Add(btnSend);
            Send.Controls.Add(label8);
            Send.Controls.Add(txtFilename);
            Send.Controls.Add(richTextBox2);
            Send.Controls.Add(label6);
            Send.Controls.Add(progressBar2);
            Send.Controls.Add(label7);
            Send.Font = new Font("Segoe UI", 15F);
            Send.Location = new Point(4, 44);
            Send.Margin = new Padding(4);
            Send.Name = "Send";
            Send.Padding = new Padding(4);
            Send.Size = new Size(1076, 387);
            Send.TabIndex = 0;
            Send.Text = "Send";
            // 
            // Queue
            // 
            Queue.BackColor = SystemColors.Control;
            Queue.Controls.Add(listBox1);
            Queue.Font = new Font("Segoe UI", 15F);
            Queue.Location = new Point(4, 44);
            Queue.Margin = new Padding(4);
            Queue.Name = "Queue";
            Queue.Padding = new Padding(4);
            Queue.Size = new Size(1076, 387);
            Queue.TabIndex = 1;
            Queue.Text = "Queue";
            // 
            // listBox1
            // 
            listBox1.FormattingEnabled = true;
            listBox1.Location = new Point(34, 25);
            listBox1.Name = "listBox1";
            listBox1.Size = new Size(1008, 319);
            listBox1.TabIndex = 0;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(9F, 21F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1152, 690);
            Controls.Add(tabControl1);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Controls.Add(label1);
            Margin = new Padding(4);
            Name = "Form1";
            Text = "File Transfer";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)remotePort).EndInit();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            tabControl1.ResumeLayout(false);
            Send.ResumeLayout(false);
            Send.PerformLayout();
            Queue.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private GroupBox groupBox1;
        private NumericUpDown remotePort;
        private ComboBox remoteIP;
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
        private Button btnSend;
        public TextBox txtFilename;
        private Label label6;
        private Button btnConnect;
        private Label label8;
        public Label label2;
        private Label label10;
        private Label label9;
        private TabControl tabControl1;
        private TabPage Send;
        private TabPage Queue;
        public ListBox listBox1;
    }
}
