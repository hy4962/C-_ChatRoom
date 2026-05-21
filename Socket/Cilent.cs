using System.Net;
using System.Net.Sockets;
using System.Text;

namespace ChatRoom
{
    internal class Client
    {
        private Socket socket;
        private ConnectionManager cm;

        public event Action<EndPoint, string>? MessageReceived;  // (serverEndpoint, message)

        public Client(string ip_str, string port_str, ConnectionManager cm)
        {
            socket = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
            socket.Connect(ip_str, int.Parse(port_str));
            this.cm = cm;

            EndPoint endPoint = socket.RemoteEndPoint;// 获取服务器的IP地址和端口号作为标识

            cm.ServerList.TryAdd(endPoint, socket);// 将服务器连接添加到服务器列表中

            Task.Run(() => ReceiveLoop(socket,endPoint));  // ← 新增：后台线程持续收消息
        }

        private void ReceiveLoop(Socket socket,EndPoint endPoint)
        {
            byte[] buffer = new byte[4096];
            try
            {
                while (true)
                {
                    int len = socket.Receive(buffer);
                    if (len == 0) break;
                    string message = Encoding.UTF8.GetString(buffer, 0, len);
                    MessageReceived?.Invoke(endPoint, message);
                }
            }
            catch { /* 断开 */ }
            finally 
            { 
                socket.Close(); 
                cm.ServerList.TryRemove(endPoint, out _); // 从服务器列表中移除这个连接
            }
        }

        public void Send(string message)
        {
            byte[] data = System.Text.Encoding.UTF8.GetBytes(message);
            socket.Send(data);
        }

        public void Close(){socket.Close(); }






    }
}
