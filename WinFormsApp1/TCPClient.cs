using System.Net;
using System.Net.Sockets;
using System.Reflection.Emit;
using System.Text;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace WinFormsApp1
{
    public class TCPClient
    {
        public Socket? sckClient;
        public Form1 f;
        public static int BUFFERSIZE = 65536;
        public byte[] buffer = new byte[BUFFERSIZE];
        public bool isSending = false;

        public void Start(string ip, int port)
        {
            f = Program.form;
            sckClient = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
            IPEndPoint ep = new IPEndPoint(IPAddress.Parse(ip), port);
            sckClient.Connect(ep);
            if (sckClient == null || !sckClient.Connected)
            {
                f.label2.Text = "Kết Nối Thất Bại!";
                return;

            }
            f.label2.Text = "Kết Nối Thành Công!";
        }

        public void SendFile(string path)
        {
            if (sckClient == null || !sckClient.Connected)
            {
                Console.WriteLine("Chua ket noi");
                return;
            }
            
            isSending = true;

            FileInfo fi = new FileInfo(path);
            if (!fi.Exists)
            {
                Console.WriteLine("Khong tim thay file");
                isSending = false;
                return;
            }
            f.textBox4.Text = fi.Name;
            string header = fi.Name + ";" + fi.Length + "|";
            Console.WriteLine(header);

            byte[] headerBytes = Encoding.UTF8.GetBytes(header);
            SendAll(headerBytes, headerBytes.Length);

            long totalBytes = fi.Length;
            long sentBytes = 0;

            using FileStream fs = fi.OpenRead();
            int bytesRead;
            while ((bytesRead = fs.Read(buffer, 0, buffer.Length)) > 0)
            {
                SendAll(buffer, bytesRead);
                sentBytes += bytesRead;

                int percent = (int)(sentBytes * 100 / totalBytes);
                f.label7.Text = percent.ToString() + "%";
                f.progressBar2.Value = percent;



            }

            isSending = false;
            f.richTextBox2.Text = "Đã gửi xong " + f.textBox4.Text + "\n";
            Console.WriteLine("gui xong");
        }

        private void SendAll(byte[] data, int count)
        {
            int totalSent = 0;
            while (totalSent < count)
            {
                int sent = sckClient!.Send(data, totalSent, count - totalSent, SocketFlags.None);
                totalSent += sent;
            }
        }
    }
}