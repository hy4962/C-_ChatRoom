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



        }



        private void btn_Start_Click(object sender, EventArgs e)
        {
            Task.Run(new Action(() =>
            {
                while (true)
                {
                    if (rbtn_Server.Checked)
                    {
                        if (cm.ClientList.Count > 0)
                        {
                            Invoke(new Action(() =>
                            {
                                lsb_List.Items.Add(cm.ClientList.Keys.Last());// 将最新连接的客户端添加到列表框中显示
                            }));
                        }
                    }
                }
            }));

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

        private void btn_CloseSever_Click(object sender, EventArgs e)
        {
            Chat.CloseServer();
            lb_Server.BadgeBack = Color.Red;
            lb_Server.Badge = "False";
        }



        private void btn_Send_Click(object sender, EventArgs e)
        {
            if (Chat.IsServerRunning)
            {
                Chat.Send(rtb_Message.Text.Trim(),lsb_List.SelectedItem.ToString());
                rtb_Message.Text = null;
            }

        }


    }
}
