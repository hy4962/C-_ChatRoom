using System.Net;
using System.Net.Sockets;

namespace ChatRoom
{
    internal class Server
    {

        private Socket socket;
        private ConnectionManager cm;
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
            cm.ServerList.Add(ip_str, socket);// 将服务器连接添加到服务器列表中
        }

        /// <summary>
        /// 接收客户端连接，并使用KV存储
        /// </summary>
        public void Accept()
        {
            Socket newclient = socket.Accept();// 接受一个新的客户端连接,并返回一个新的Socket对象用于与该客户端通信
            string EndPoint = newclient.RemoteEndPoint.ToString(); // 获取客户端的IP地址和端口号作为标识

            cm.ClientList.Add(EndPoint, newclient);// 将新的客户端连接添加到客户端列表中
            
        }


        public void Send(string message,string ip)
        {
            byte[] data = System.Text.Encoding.ASCII.GetBytes(message);
            Socket client = cm.ClientList[ip];// 从客户端列表中获取指定IP的客户端连接
            client.Send(data);
        }

        public void SendToClient(Socket client, string message)
        {
            byte[] data = System.Text.Encoding.ASCII.GetBytes(message);
            client.Send(data);
        }


        public void CloseClient(Socket client)
        {
            client.Close();
        }

        public void CloseAllClients()
        {
            // 这里需要维护一个客户端列表，遍历关闭所有客户端连接
            // 例如：foreach (var client in clients) { client.Close(); }
        }


        public void GetClientMessage(Socket client)
        {
            byte[] buffer = new byte[1024];
            int bytesRead = client.Receive(buffer);
            string message = System.Text.Encoding.ASCII.GetString(buffer, 0, bytesRead);
            // 处理接收到的消息，例如显示在界面上
        }


        public void GetAllClientsMessage()
        {
            // 这里需要维护一个客户端列表，遍历接收所有客户端的消息
            // 例如：foreach (var client in clients) { GetClientMessage(client); }
        }

        public void BroadcastMessage(string message)
        {
            // 这里需要维护一个客户端列表，遍历发送消息给所有客户端
            // 例如：foreach (var client in clients) { SendToClient(client, message); }



        }

       


    }   
}
