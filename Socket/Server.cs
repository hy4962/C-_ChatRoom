using System.Net;
using System.Net.Sockets;

namespace ChatRoom
{
    internal class Server
    {

        private Socket socket;


        public Server(string ip_str, string port_str, int maxnum)
        {
            socket = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);

            IPAddress ip = IPAddress.Parse(ip_str);
            int port = int.Parse(port_str);

            socket.Bind(new IPEndPoint(ip, port));

            socket.Listen(maxnum);
        }

        public void Accept()
        {
            Socket client = socket.Accept();
        }

        public void Close() { socket.Close(); }


        public void Send(string message)
        {
            byte[] data = System.Text.Encoding.ASCII.GetBytes(message);
            socket.Send(data);
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
