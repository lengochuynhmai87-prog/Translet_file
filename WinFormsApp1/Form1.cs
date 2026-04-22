
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
            ofd.Multiselect = true;

            if (ofd.ShowDialog() == DialogResult.OK)
            {
                foreach (string filePath in ofd.FileNames)
                {
                    if (!listBox1.Items.Contains(filePath))
                    {
                        listBox1.Items.Add(filePath);
                    }
                    textBox3.Text = filePath;

                }
            }
        }

        private void btnConnect_Click(object sender, EventArgs e)
        {
            if (tcpClient.sckClient == null)
            {
                tcpClient.Start(remoteIP.Text, (int)remotePort.Value);
                btnConnect.Enabled = false;
                btnSend.Enabled = true;

            }

        }

        private void btnSend_Click(object sender, EventArgs e)
        {
            if(tcpClient.isSending) return;
            tcpClient.GetPathFormList();
        }

          
    }
}
