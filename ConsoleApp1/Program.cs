
using ConsoleApp1;
using System;
using System.Security.Cryptography.X509Certificates;

namespace ConsoleApp1
{
    internal class Program
    {
        static TCPClient client = new TCPClient();
        static TCPServer sever = new TCPServer();
        static void Main(string[] args)
        {
            //Ket noi
            sever.StartSv();
            client.Start("127.0.0.1", 9999);
            while (true)
            {
                Console.WriteLine("Nhap path");
                string path = Console.ReadLine(); //lấy trên ofd
                client.SendFile(path);
            }


        }

    }
}
