using System;
using System.Collections.Generic;
using System.Net.Sockets;
using System.Text;

namespace ChatRoom
{
    internal class ConnectionManager
    {
        private Dictionary<string, Socket> serverList = new Dictionary<string, Socket>();// 存储服务器连接的列表，键(这里实际上存的是IP)为服务器标识，值为服务器的Socket对象
        private Dictionary<string, Socket> clientList = new Dictionary<string, Socket>();// 存储客户端连接的列表，键(这里实际上存的是IP)为客户端标识，值为客户端的Socket对象

        public Dictionary<string, Socket> ServerList { get => serverList; set => serverList = value; }
        public Dictionary<string, Socket> ClientList { get => clientList; set => clientList = value; }


        public void Close(string name) 
        {
            if(name == "server")
            {
                foreach (var item in serverList)
                {
                    item.Value.Close();
                }
                serverList.Clear();
            }
            else if (name == "client")
            {
                foreach (var item in clientList)
                {
                    item.Value.Close();
                }
                clientList.Clear();
            }
        }



    }
}
