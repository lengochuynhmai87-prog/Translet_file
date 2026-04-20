using System.Net;
using System.Net.Sockets;
using System.Text;

namespace WinFormsApp1
{
    public class TCPServer
    {
        public Socket? sckClient, sckSever;
        public Form1 f;
        public FileStream? fs;
        public static int BUFFERSIZE = 65536;
        public static int port = 9999;
        public byte[] buffer = new byte[BUFFERSIZE];
        public string Folder = "Receive_File";
        public bool isHeader = true;
        public long countReceive = 0;
        public long totalReceive = 0;

        public static string GetLocalIPAddress()
        {
            var host = Dns.GetHostEntry(Dns.GetHostName());

            foreach (var ip in host.AddressList)
            {
                if (ip.AddressFamily == AddressFamily.InterNetwork) // IPv4
                {
                    return ip.ToString();
                }
            }

            return "Không tìm thấy IP";
        }
        public void StartSv()
        {
            f = Program.form;

            if (!Directory.Exists(Folder))
            {
                Directory.CreateDirectory(Folder);
            }
            while (port > 0)
            {
                try
                {
                    f.textBox1.Text = GetLocalIPAddress();
                    f.textBox2.Text = port.ToString();

                    sckSever = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
                    IPEndPoint ep = new IPEndPoint(IPAddress.Any, port);
                    sckSever.Bind(ep);

                    sckSever.Listen(4);

                    sckSever.BeginAccept(new AsyncCallback(OnAccept), sckSever);

                    break;
                }
                catch
                {
                    port--;
                }
            }

        }

        private void OnAccept(IAsyncResult ar)
        {
            Socket sck = (Socket)ar.AsyncState;
            sckClient = sck.EndAccept(ar);
            f.label2.Text = "Đã Được Kết Nối!";

            sckSever.BeginAccept(new AsyncCallback(OnAccept), sckSever);

            sckClient.BeginReceive(buffer, 0, buffer.Length, SocketFlags.None, OnReceive, null);



        }

        private void OnReceive(IAsyncResult ar)
        {
            int n = sckClient.EndReceive(ar);
            if (n <= 0) return;

            if (isHeader)
            {
                string msg = Encoding.UTF8.GetString(buffer, 0, n);

                if (!msg.Contains("|"))
                {
                    sckClient.BeginReceive(buffer, 0, BUFFERSIZE, SocketFlags.None, OnReceive, null);
                    return;
                }

                string[] header = msg.Split('|');
                string[] parts = header[0].Split(';');

                if (parts.Length < 2)
                {
                    sckClient.BeginReceive(buffer, 0, BUFFERSIZE, SocketFlags.None, OnReceive, null);
                    return;
                }

                string fileName = parts[0];
                f.textBox4.Text = fileName;

                totalReceive = long.Parse(parts[1]);

                fs = new FileStream(Path.Combine(Folder, fileName), FileMode.Create);

                int headerByteCount = Encoding.UTF8.GetByteCount(header[0] + "|");

                int fileInHeader = n - headerByteCount;

                if (fileInHeader > 0)
                {
                    fs.Write(buffer, headerByteCount, fileInHeader);
                    countReceive += fileInHeader;
                }

                isHeader = false;
            }
            else
            {
                fs.Write(buffer, 0, n);
                countReceive += n;

                int percent = (int)(countReceive * 100 / totalReceive);
                f.label7.Text = percent.ToString() + "%";
                f.progressBar2.Value = percent;
            }

            if (countReceive >= totalReceive)
            {
                fs.Close();
                fs = null;

                isHeader = true;
                countReceive = 0;
                totalReceive = 0;

                f.richTextBox2.Text += "Đã nhận " + f.textBox4.Text + "\n";

                Console.WriteLine("Đã nhận file thành công!");
            }

            sckClient.BeginReceive(buffer, 0, BUFFERSIZE, SocketFlags.None, OnReceive, null);
        }
    }
}
