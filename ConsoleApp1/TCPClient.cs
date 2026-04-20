using System.IO.Pipelines;
using System.Net;
using System.Net.Sockets;
using System.Text;
namespace ConsoleApp1
{
    public class TCPClient
    {
        public Socket? sckClient;
        private FileStream? fs;
        public static int BUFFERSIZE = 65536;
        public byte[] buffer = new byte[BUFFERSIZE];
        public long currentFrame = 0;
        public long numFrame = 0;

        public void Start(string ip, int port)
        {

            sckClient = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
            IPEndPoint ep = new IPEndPoint(IPAddress.Parse(ip), port);
            sckClient.BeginConnect(ep, new AsyncCallback(OnConnect), sckClient);
        }

        private static void OnConnect(IAsyncResult result)
        {
            Socket sck = (Socket)result.AsyncState;
            sck.EndConnect(result);

        }

        public void SendFile(string path)
        {
            if (sckClient == null || !sckClient.Connected)
            {
                Console.WriteLine("Chua ket noi");
                return;
            }
            FileInfo fi = new FileInfo(path);
            string header = fi.Name + ";" + fi.Length + "|";
            Console.WriteLine(header);
            byte[] headerByte = Encoding.UTF8.GetBytes(header);
            fs = fi.OpenRead();
            sckClient.BeginSend(headerByte, 0, headerByte.Length, SocketFlags.None, OnSendHeader, sckClient);

        }

        private void OnSendHeader(IAsyncResult ar)
        {
            sckClient.EndSend(ar);
            SendNextChunk();
        }

        private void SendNextChunk()
        {
            if (fs != null && fs.Position < fs.Length)
            {
                int bytesRead = fs.Read(buffer, 0, buffer.Length);
                sckClient.BeginSend(buffer, 0, bytesRead, SocketFlags.None, OnChunkSend, null);
            }
            else
            {
                CleanUp();
            }
        }

        private void CleanUp()
        {
            fs.Close();
            fs = null;
            Console.Write("gui xong");
        }

        private void OnChunkSend(IAsyncResult ar)
        {
            sckClient.EndSend(ar);

            SendNextChunk();
        }
    }
}
