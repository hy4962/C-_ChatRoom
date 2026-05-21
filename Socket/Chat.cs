using System.Net;
using System.Security.Cryptography;

namespace ChatRoom
{
    internal class Chat
    {
        private Client client;
        private Server server;
        private ConnectionManager cm;

        private bool isServerRunning = false; // 服务器是否正在运行的标志
        private bool isClientConnected = false; // 客户端是否已连接的标志

        public bool IsServerRunning { get => isServerRunning; }


        private byte[] data;// 缓存数据的字节数组

        // 提供给 Form1 订阅的回调
        public event Action<EndPoint, string>? OnMessageReceived;


        public Chat(ConnectionManager cm) { this.cm = cm; }

        /// <summary>
        /// 创建服务器
        /// </summary>
        /// <param name="ip"></param>
        /// <param name="port"></param>
        /// <param name="maxnum"></param>
        public void CreateServer(string ip, string port, int maxnum)
        {
            // 创建服务器实例，使用用户输入的IP地址、端口号和最大连接数
            server = new Server(ip, port, maxnum, cm);

            server.MessageReceived += (endpoint, msg) =>
            {
                // 需要跨线程安全地传给 UI
                OnMessageReceived?.Invoke(endpoint, msg);
            };


            // 服务器循环监听，直到服务器被关闭
            Task.Run(new Action(() =>
            {
                while (server != null)
                {
                    server.Accept();
                    isServerRunning = true;//服务器正在运行
                }
            }));
        }


        public void CloseServer()
        {
            cm.Close("server");
        }


        public void Send(string message, string ip_port)
        {
            data = System.Text.Encoding.UTF8.GetBytes(message);
            EndPoint endPoint = new IPEndPoint(IPAddress.Parse(ip_port.Split(':')[1]), int.Parse(ip_port.Split(':')[2]));


            foreach (var item in cm.ServerList)
            {
                if (item.Key.Equals(endPoint))
                {
                    item.Value.Send(data);
                    return;
                }
            }

            foreach (var item in cm.ClientList)
            {
                if (item.Key.Equals(endPoint))
                {
                    item.Value.Send(data);
                    return;
                }
            }
        }

        /// <summary>
        /// 客户端连接至服务端
        /// </summary>
        /// <param name="ip"></param>
        /// <param name="port"></param>
        public void ConnectServer(string ip, string port)
        {
            client = new Client(ip, port, cm);
            client.MessageReceived += (endpoint, msg) =>
            {
                // 需要跨线程安全地传给 UI
                OnMessageReceived?.Invoke(endpoint, msg);
            };

            isClientConnected = true;


        }









    }
}
