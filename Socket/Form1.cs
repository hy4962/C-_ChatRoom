using System.Net;
using System.Net.Sockets;

namespace ChatRoom
{
    public partial class Form1 : AntdUI.Window
    {
        public Form1()
        {
            InitializeComponent();

        }

        Cilent cilent;
        Server server;

        bool isServerRunning = false; // 服务器是否正在运行的标志


        /// <summary>
        /// 创建服务器
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_NewServer_Click(object sender, EventArgs e)
        {
            // 创建服务器实例，使用用户输入的IP地址、端口号和最大连接数
            server = new Server(tb_ServerIP.Text.Trim(), tb_ServerPort.Text.Trim(), int.Parse(tb_MaxNum.Text.Trim()));

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


        /// <summary>
        /// 客户端连接至服务器
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_Connect_Click(object sender, EventArgs e)
        {
            cilent = new Cilent(tb_ServerIP.Text.Trim(), tb_ServerPort.Text.Trim());
            if (cilent != null)
            {
                lb_Cilent.BadgeBack = Color.Green;
                lb_Cilent.Badge = "True";
            }
        }

        /// <summary>
        /// 断开客户端与服务器的连接
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_CloseConnect_Click(object sender, EventArgs e)
        {
            cilent.Close();
            lb_Cilent.BadgeBack = Color.Red;
            lb_Cilent.Badge = "False";

        }

        private void btn_Send_Click(object sender, EventArgs e)
        {
            if (isServerRunning)
            {


            }

        }

        private void btn_CloseSever_Click(object sender, EventArgs e)
        {
            server.Close();
        }
    }
}
