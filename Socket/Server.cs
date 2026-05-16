using System.Net;
using System.Net.Sockets;

namespace ChatRoom
{
    internal class Server
    {

        private Socket socket;
        private ConnectionManager cm;

        public event Action<string, string>? MessageReceived;  // (clientEndpoint, message)
        public event Action<string>? ClientDisconnected;        // (clientEndpoint)
        public Server(string ip_str, string port_str, int maxnum,ConnectionManager cm)
        {
            // 创建一个TCP/IP套接字，AddressFamily.InterNetwork表示使用IPv4地址，SocketType.Stream表示使用流式套接字，ProtocolType.Tcp表示使用TCP协议
            socket = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);

            // 将IP地址和端口号转换为IPEndPoint对象，IPEndPoint表示一个网络端点，包括IP地址和端口号
            IPAddress ip = IPAddress.Parse(ip_str);
            int port = int.Parse(port_str);


            socket.Bind(new IPEndPoint(ip, port));// 绑定IP地址和端口号

            socket.Listen(maxnum);// 开始监听，maxnum为最大连接数


            this.cm = cm;
            cm.ServerList.TryAdd(ip_str, socket);// 将服务器连接添加到服务器列表中
        }

        /// <summary>
        /// 接收客户端连接，并使用KV存储
        /// </summary>
        public void Accept()
        {
            Socket newclient = socket.Accept();// 接受一个新的客户端连接,并返回一个新的Socket对象用于与该客户端通信
            string EndPoint = newclient.RemoteEndPoint.ToString(); // 获取客户端的IP地址和端口号作为标识

            cm.ClientList.TryAdd(EndPoint, newclient);// 将新的客户端连接添加到客户端列表中

            // 为每个客户端启动独立 Task 持续接收
            Task.Run(() => ReceiveLoop(newclient, EndPoint));
        }

        /// <summary>
        /// 接收消息
        /// </summary>
        /// <param name="newclient"></param>
        /// <param name="endPoint"></param>
        private void ReceiveLoop(Socket newclient, string endPoint)
        {
            byte[] buffer = new byte[4096];

            try
            {
                while (true)
                { 
                    int byte_message = newclient.Receive(buffer);

                    if (byte_message > 0)
                    {
                        string message = System.Text.Encoding.UTF8.GetString(buffer, 0, byte_message);
                        MessageReceived?.Invoke(endPoint, message);
                    }


                }
            }
            catch (SocketException)
            {
            }
            //这是一个 清理操作的代码块，finally 的意思是不管前面代码有没有报错，这段一定会执行。
            finally
            {
                newclient.Close();
                cm.ClientList.TryRemove(endPoint, out _);
                ClientDisconnected?.Invoke(endPoint);
            }




        }

        public void Send(string message,string ip)
        {
            byte[] data = System.Text.Encoding.UTF8.GetBytes(message);
            Socket client = cm.ClientList[ip];// 从客户端列表中获取指定IP的客户端连接
            client.Send(data);
        }



        public void CloseClient(Socket client)
        {
            client.Close();
        }


       


    }   
}
