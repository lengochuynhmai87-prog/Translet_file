        using System.Net;
        using System.Net.Sockets;
        using System.Text;

        namespace WinFormsApp1
        {
            public class TCPServer
            {
                Socket? sckSever;
                public static int port = 9999;
                public Form1 f;
                public string Folder = "Receive_File";
                public static int BUFFERSIZE = 65536;



                public class ClientState
                {
                    public Socket? sckClient;
                    public FileStream? fs;
                    public byte[] buffer = new byte[BUFFERSIZE];
                    public bool isHeader = true;
                    public long countReceive = 0; // đếm số byte đã nhận được của file hiện tại
                    public long totalReceive = 0;
                }

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
                    ClientState st = new ClientState();
                    Socket sck = (Socket)ar.AsyncState;
                    st.sckClient = sck.EndAccept(ar);
                    f.Invoke(() =>
                    {
                        f.label2.Text = "Đã Được Kết Nối!";
                    });
                    sckSever.BeginAccept(new AsyncCallback(OnAccept), sckSever);
           
                    st.sckClient.BeginReceive(st.buffer, 0, st.buffer.Length, SocketFlags.None, OnReceive, st);

              

                }

                private void OnReceive(IAsyncResult ar)
                {
                    ClientState st = (ClientState)ar.AsyncState;
                    int n = st.sckClient.EndReceive(ar);
                    if (n <= 0) return;
                    // Trường hợp header
                    int offset = 0;
                    while (n > 0) { 
                        if (st.isHeader)
                        {
              
                            // Đọc header để lấy tên file và kích thước
                            string msg = Encoding.UTF8.GetString(st.buffer, offset, n);
                            //if (!msg.Contains("|") || !msg.Contains(";"))
                            //{
                            //    st.sckClient.BeginReceive(st.buffer, 0, BUFFERSIZE, SocketFlags.None, OnReceive, st);
                            //    return;
                            //}

                            string[] header = msg.Split('|');
                            string[] parts = header[0].Split(';');
                            //if (parts.Length < 2)
                            //{
                            //    st.sckClient.BeginReceive(st.buffer, 0, BUFFERSIZE, SocketFlags.None, OnReceive, st);
                            //    return;
                            //}


                            string fileName = parts[0];
                            f.Invoke(() =>
                            {
                                f.txtFilename.Text = fileName;
                            });

                            st.totalReceive = long.Parse(parts[1]);
                            // Tạo file để lưu dữ liệu nhận được
                            st.fs = new FileStream(Path.Combine(Folder, fileName), FileMode.Create);

                            f.Invoke(() =>
                            {
                                f.txtFilename.Text = fileName;
                                f.progressBar2.Value = 0;
                                f.label7.Text = "0%";
                            });

                            // Tính số byte của phần header đã nhận ( không tính số byte của file)
                            int headerByteCount = Encoding.UTF8.GetByteCount(header[0] + "|");
                            offset += headerByteCount;
                            n -= headerByteCount;

                            st.isHeader = false;
                           // st.sckClient.BeginReceive(st.buffer, 0, BUFFERSIZE, SocketFlags.None, OnReceive, st);
                
                    }
                    // nếu đã nhận header rồi thì tiếp tục nhận phần file
                        else
                        {
                        //tính số byte còn lại cần nhận
                        long  remaining = st.totalReceive - st.countReceive;
                        int belongCurrentFile = (int)Math.Min(remaining, n);
                        st.fs.Write(st.buffer, offset, belongCurrentFile);
                
                        st.countReceive += belongCurrentFile;
                        offset += belongCurrentFile;
                        n -= belongCurrentFile;

                        int percent = (int)(st.countReceive * 100 / st.totalReceive);
                        f.Invoke(() =>
                        {
                            f.label7.Text = percent.ToString() + "%";
                            f.progressBar2.Value = percent;
                        });
                    }
                // nếu chưa nhận đủ file thì tiếp tục nhận

                    if (st.countReceive >= st.totalReceive)
                    {
                        st.fs?.Close();
                        st.fs = null;
                        st.isHeader = true;
                        st.countReceive = 0;
                        st.totalReceive = 0;
                        f.Invoke(() =>
                        {
                            f.richTextBox2.Text += "Đã nhận " + f.txtFilename.Text + "\n";
                        });
                    }
                        st.sckClient.BeginReceive(st.buffer, 0, BUFFERSIZE, SocketFlags.None, OnReceive, st);
                        Console.WriteLine("Đã nhận file thành công!");
                    }


            
                }
            }
        }
