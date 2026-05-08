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


        public ConnectionManager()
        {
            // 创建一个定时器
            System.Windows.Forms.Timer timer = new System.Windows.Forms.Timer()
            { 
                Interval = 100,// 设置定时器的时间间隔为100毫秒
            };
            timer.Tick += UpdateClientList;// 定时器的Tick事件处理程序
            
        }



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

        private void UpdateClientList(object sender, EventArgs e)
        {
            Task.Run(() => 
            {
                foreach (var kv in clientList)
                {
                    Socket client = kv.Value;// 获取客户端连接对象
                    bool alive = client.Poll(0,SelectMode.SelectRead);// 使用Poll方法检查客户端连接是否可读，如果返回true表示连接已关闭或出现错误
                    if (alive){clientList.Remove(kv.Key);}// 从客户端列表中移除已关闭的连接
                }
            } );


        }

    }
}
