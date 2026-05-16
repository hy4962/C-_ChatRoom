using AntdUI;
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
                this.Invoke(() => CreateMessage(endpoint, msg));
                Invoke(() => UpdateMessage(endpoint, msg));
            };

        }



        private void btn_Start_Click(object sender, EventArgs e)
        {
            time_listbox.Start();
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
            if (Chat.IsServerRunning)
            {
                Chat.Send(rtb_Message.Text.Trim(), lsb_List.SelectedItem.ToString());
                rtb_Message.Text = null;
            }

        }


        private void UpdateMessage(string endpoint, string msg)
        {
            rtb_Message.AppendText($"[{endpoint}]: {msg}\n");

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
                if (Chat.IsServerRunning)// 只有当服务器正在运行时才更新客户端列表
                {
                    if (cm.ClientList.Count > 0)// 只有当客户端列表中有连接时才更新listbox
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
                }
            }));
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
        }

        private void CreateMessage(string endpoint, string msg)
        {
            
            AntdUI.Panel panel = new AntdUI.Panel()
            {
                Left = 50,Top = 50,
            };
            Avatar avatar = new Avatar()
            {
                ImageSvg = "UserOutlined",
                Width = 30, Height = 30,
                Left = 0, Top = 0,
            };
            AntdUI.Label lb_endpoint = new AntdUI.Label()
            {
                Text = endpoint,
                Left = 40,
                Top = 0,
            };
            AntdUI.Label lb_msg = new AntdUI.Label()
            {
                Text = msg,
                Left = 40,
                Top = 20,
            };

            splitter1.Panel2.Controls.Add(panel);
            panel.Controls.Add(avatar);
            panel.Controls.Add(lb_endpoint);
            panel.Controls.Add(lb_msg);

        }


    }
}
