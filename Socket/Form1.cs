using AntdUI;
using AntdUI.Chat;
using System.Net;
using System.Net.Sockets;

namespace ChatRoom
{
    public partial class Form1 : AntdUI.Window
    {

        Chat Chat;
        ConnectionManager cm = new ConnectionManager();


        public Form1()
        {
            InitializeComponent();
            Chat = new Chat(cm);

            Chat.OnMessageReceived += (endpoint, msg) =>
            {
                this.Invoke(() => UpdateMessage(endpoint, msg,false));
            };

        }


        /// <summary>
        /// 创建服务器
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_NewServer_Click(object sender, EventArgs e)
        {
            // 创建服务器实例，使用用户输入的IP地址、端口号和最大连接数
            Chat.CreateServer(tb_ServerIP.Text.Trim(), tb_ServerPort.Text.Trim(), int.Parse(tb_MaxNum.Text.Trim()));
            lb_Server.BadgeBack = Color.Green;
            lb_Server.Badge = "True";

            time_listbox.Start();
        }


        /// <summary>
        /// 关闭服务
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_CloseSever_Click(object sender, EventArgs e)
        {
            Chat.CloseServer();
            lb_Server.BadgeBack = Color.Red;
            lb_Server.Badge = "False";
        }



        /// <summary>
        /// 发送数据
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_Send_Click(object sender, EventArgs e)
        {

            string msg = rtb_Message.Text.Trim();
            if (string.IsNullOrEmpty(msg)) return;

            if (Chat.IsServerRunning)
            {
                if(lsb_List.SelectedItem == null)
                {
                    MessageBox.Show("请选择一个客户端发送消息！");
                    return;
                }
                Chat.Send(msg, lsb_List.SelectedItem.ToString());
                UpdateMessage("我", msg, true);
                rtb_Message.Clear();
            }
         }


        /// <summary>
        /// 实时更新listbox
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void time_listbox_Tick(object sender, EventArgs e)
        {
            Task.Run(new Action(() =>
            {
                    if (cm.ClientList.Count > 0)// 只有当客户端列表中有对象时才更新listbox
                    {
                        // 使用Invoke方法在UI线程上更新listbox，确保线程安全
                        lsb_List.Invoke(new Action(() =>
                        {
                            object SelectedItem = lsb_List.SelectedItem;// 记录当前选中的项，以便更新后重新选中
                            lsb_List.Items.Clear();
                            foreach (var item in cm.ClientList)
                            {
                                lsb_List.Items.Add(item.Key);
                            }
                            lsb_List.SelectedItem = SelectedItem;// 更新后重新选中之前选中的项
                        }));

                    }
            }));
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
        }




        private void UpdateMessage(string sender, string text, bool isOwn)
        {
            if (this.InvokeRequired)
                this.Invoke(() => chatList.AddToBottom(new AntdUI.Chat.TextChatItem(text, null, sender) { Me = isOwn }));
            else
                chatList.AddToBottom(new AntdUI.Chat.TextChatItem(text,null,sender) { Me = isOwn });
        }


    }

}

