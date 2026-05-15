using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Net.Sockets;
using System.Text;

namespace ChatRoom
{
    internal class ConnectionManager
    {
        private ConcurrentDictionary<string, Socket> serverList = new ConcurrentDictionary<string, Socket>();// 存储服务器连接的列表，键(这里实际上存的是IP)为服务器标识，值为服务器的Socket对象
        private ConcurrentDictionary<string, Socket> clientList = new ConcurrentDictionary<string, Socket>();// 存储客户端连接的列表，键(这里实际上存的是IP)为客户端标识，值为客户端的Socket对象

        public ConcurrentDictionary<string, Socket> ServerList { get => serverList; set => serverList = value; }
        public ConcurrentDictionary<string, Socket> ClientList { get => clientList; set => clientList = value; }


        public ConnectionManager()
        {
            // 创建一个定时器
            System.Windows.Forms.Timer timer = new System.Windows.Forms.Timer()
            { 
                Interval = 50,// 设置定时器的时间间隔为100毫秒
            };
            timer.Tick += UpdateClientList;// 定时器的Tick事件处理程序
            timer.Start();
        }




        /// <summary>
        /// 输入server/client来关闭对应的连接，关闭时会遍历对应的列表，调用每个Socket对象的Close方法来关闭连接，并清空列表
        /// </summary>
        /// <param name="name"></param>
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



        /// <summary>
        /// 实时更新客户端列表里面的对象，把已断开的对象删掉
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void UpdateClientList(object sender, EventArgs e)
        {
            Task.Run(() => 
            {
                foreach (var kv in clientList)
                {
                    Socket client = kv.Value;// 获取客户端连接对象
                    bool alive = client.Poll(0,SelectMode.SelectRead);// 使用Poll方法检查客户端连接是否可读，如果返回true表示连接已关闭或出现错误
                    if (alive){clientList.TryRemove(kv.Key,out _);}// 从客户端列表中移除已关闭的连接
                }
            } );


        }

    }
}
