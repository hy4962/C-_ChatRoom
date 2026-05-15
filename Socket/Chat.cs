namespace ChatRoom
{
    internal class Chat
    {
        private Cilent cilent;
        private Server server;
        private ConnectionManager cm;

        private bool isServerRunning = false; // 服务器是否正在运行的标志

        public bool IsServerRunning { get => isServerRunning; }


        private byte[] data;// 缓存数据的字节数组





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


        public void Send(string message,string client)
        {
            data = System.Text.Encoding.ASCII.GetBytes(message);
            if (server != null)
            {
                server.Send(message,client);
            }
        }

        /// <summary>
        /// 接收消息
        /// </summary>
        public void ReceiveMessage() 
        {
            


        }











    }
}
