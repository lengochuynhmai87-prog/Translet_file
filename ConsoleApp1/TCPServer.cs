using System.Net;
using System.Net.Sockets;
using System.Text;

namespace ConsoleApp1
{
    public class TCPServer
    {
        public static Socket? sckClient, sckSever;
        private FileStream? fs;
        public static int BUFFERSIZE = 65536;
        public byte[] buffer = new byte[BUFFERSIZE];
        public string Folder = "Receive_File";
        public bool isHeader = true;
        public long countReceive = 0;
        public long totalReceive = 0;
        public void StartSv()
        {
            if (!Directory.Exists(Folder))
            {
                Directory.CreateDirectory(Folder);
            }

            sckSever = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
            IPEndPoint ep = new IPEndPoint(IPAddress.Any, 9999);
            sckSever.Bind(ep);
            sckSever.Listen(4);

            sckSever.BeginAccept(new AsyncCallback(OnAccept), sckSever);
        }

        private void OnAccept(IAsyncResult ar)
        {
            Socket sck = (Socket)ar.AsyncState;
            sckClient = sck.EndAccept(ar);

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
            }

            if (countReceive >= totalReceive)
            {
                fs.Close();
                fs = null;

                isHeader = true;
                countReceive = 0;
                totalReceive = 0;

                Console.WriteLine("Đã nhận file thành công!");
            }

            sckClient.BeginReceive(buffer, 0, BUFFERSIZE, SocketFlags.None, OnReceive, null);
        }
    }
}
