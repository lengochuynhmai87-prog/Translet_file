
namespace WinFormsApp1
{
    public partial class Form1 : Form
    {
        static TCPClient tcpClient = new TCPClient();
        static TCPServer tcpServer = new TCPServer();
        public Form1()
        {
            InitializeComponent();
            Task.Run(() =>
            {
                tcpServer.StartSv();
            });

        }

        private void button2_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();

            ofd.Title = "Chọn file";
            ofd.Filter = "All files (*.*)|*.*";

            if (ofd.ShowDialog() == DialogResult.OK)
            {
                string filePath = ofd.FileName;
                textBox3.Text = filePath;
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (tcpClient.sckClient == null)
            {
                tcpClient.Start(comboBox1.Text, (int)numericUpDown1.Value);
                button3.Enabled = false;
                button1.Enabled = true;

            }

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (tcpClient.isSending) return;
            Task.Run(() =>
            {
                tcpClient.SendFile(textBox3.Text);
            });
        }
    }
}
