namespace ChatRoom
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            AntdUI.Tabs.StyleCard styleCard1 = new AntdUI.Tabs.StyleCard();
            AntdUI.StepsItem stepsItem1 = new AntdUI.StepsItem();
            AntdUI.StepsItem stepsItem2 = new AntdUI.StepsItem();
            pgh_pgh = new AntdUI.PageHeader();
            panel1 = new Panel();
            tabs1 = new AntdUI.Tabs();
            tb_setting = new AntdUI.TabPage();
            divider1 = new AntdUI.Divider();
            btn_Start = new AntdUI.Button();
            lb_s_o_c = new AntdUI.Label();
            rbtn_Client = new RadioButton();
            rbtn_Server = new RadioButton();
            btn_CloseSever = new AntdUI.ButtonShadow();
            btn_CloseConnect = new AntdUI.ButtonShadow();
            label5 = new AntdUI.Label();
            label6 = new AntdUI.Label();
            btn_Connect = new AntdUI.ButtonShadow();
            tb_CilentPort = new TextBox();
            tb_CilentIP = new TextBox();
            label7 = new AntdUI.Label();
            label3 = new AntdUI.Label();
            label2 = new AntdUI.Label();
            label1 = new AntdUI.Label();
            btn_NewServer = new AntdUI.ButtonShadow();
            tb_MaxNum = new TextBox();
            tb_ServerPort = new TextBox();
            tb_ServerIP = new TextBox();
            lb_ser = new AntdUI.Label();
            tb_Chat = new AntdUI.TabPage();
            splitter1 = new AntdUI.Splitter();
            lsb_List = new ListBox();
            panel3 = new Panel();
            btn_Send = new AntdUI.Button();
            rtb_Message = new RichTextBox();
            tb_Guide = new AntdUI.TabPage();
            steps1 = new AntdUI.Steps();
            panel2 = new Panel();
            lb_Cilent = new AntdUI.Label();
            lb_Server = new AntdUI.Label();
            lb_状态栏 = new AntdUI.Label();
            time_listbox = new System.Windows.Forms.Timer(components);
            panel1.SuspendLayout();
            tabs1.SuspendLayout();
            tb_setting.SuspendLayout();
            divider1.SuspendLayout();
            tb_Chat.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)splitter1).BeginInit();
            splitter1.Panel1.SuspendLayout();
            splitter1.Panel2.SuspendLayout();
            splitter1.SuspendLayout();
            panel3.SuspendLayout();
            tb_Guide.SuspendLayout();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // pgh_pgh
            // 
            pgh_pgh.Dock = DockStyle.Fill;
            pgh_pgh.Location = new Point(0, 0);
            pgh_pgh.Name = "pgh_pgh";
            pgh_pgh.ShowBack = true;
            pgh_pgh.ShowButton = true;
            pgh_pgh.Size = new Size(1242, 42);
            pgh_pgh.TabIndex = 0;
            pgh_pgh.Text = "局域网聊天";
            // 
            // panel1
            // 
            panel1.BorderStyle = BorderStyle.FixedSingle;
            panel1.Controls.Add(pgh_pgh);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(1244, 44);
            panel1.TabIndex = 2;
            // 
            // tabs1
            // 
            tabs1.Centered = true;
            tabs1.Controls.Add(tb_Chat);
            tabs1.Controls.Add(tb_setting);
            tabs1.Controls.Add(tb_Guide);
            tabs1.Dock = DockStyle.Fill;
            tabs1.Location = new Point(0, 44);
            tabs1.Name = "tabs1";
            tabs1.Pages.Add(tb_Guide);
            tabs1.Pages.Add(tb_Chat);
            tabs1.Pages.Add(tb_setting);
            tabs1.SelectedIndex = 1;
            tabs1.Size = new Size(1244, 632);
            styleCard1.Border = 2;
            styleCard1.BorderActive = SystemColors.ActiveBorder;
            styleCard1.BorderColor = Color.AliceBlue;
            tabs1.Style = styleCard1;
            tabs1.TabIndex = 3;
            tabs1.Text = "tabs1";
            tabs1.TextCenter = true;
            tabs1.Type = AntdUI.TabType.Card;
            // 
            // tb_setting
            // 
            tb_setting.Controls.Add(divider1);
            tb_setting.Location = new Point(-2488, -1188);
            tb_setting.Name = "tb_setting";
            tb_setting.Size = new Size(1244, 594);
            tb_setting.TabIndex = 2;
            tb_setting.Text = "设置";
            // 
            // divider1
            // 
            divider1.Controls.Add(btn_Start);
            divider1.Controls.Add(lb_s_o_c);
            divider1.Controls.Add(rbtn_Client);
            divider1.Controls.Add(rbtn_Server);
            divider1.Controls.Add(btn_CloseSever);
            divider1.Controls.Add(btn_CloseConnect);
            divider1.Controls.Add(label5);
            divider1.Controls.Add(label6);
            divider1.Controls.Add(btn_Connect);
            divider1.Controls.Add(tb_CilentPort);
            divider1.Controls.Add(tb_CilentIP);
            divider1.Controls.Add(label7);
            divider1.Controls.Add(label3);
            divider1.Controls.Add(label2);
            divider1.Controls.Add(label1);
            divider1.Controls.Add(btn_NewServer);
            divider1.Controls.Add(tb_MaxNum);
            divider1.Controls.Add(tb_ServerPort);
            divider1.Controls.Add(tb_ServerIP);
            divider1.Controls.Add(lb_ser);
            divider1.Dock = DockStyle.Fill;
            divider1.Location = new Point(0, 0);
            divider1.Name = "divider1";
            divider1.Size = new Size(1244, 594);
            divider1.TabIndex = 3;
            divider1.Text = "分割线";
            divider1.Vertical = true;
            // 
            // btn_Start
            // 
            btn_Start.Location = new Point(563, 131);
            btn_Start.Name = "btn_Start";
            btn_Start.Size = new Size(112, 34);
            btn_Start.TabIndex = 20;
            btn_Start.Text = "Start";
            btn_Start.Click += btn_Start_Click;
            // 
            // lb_s_o_c
            // 
            lb_s_o_c.Location = new Point(563, 23);
            lb_s_o_c.Name = "lb_s_o_c";
            lb_s_o_c.Size = new Size(112, 34);
            lb_s_o_c.TabIndex = 19;
            lb_s_o_c.Text = "选择运行模式";
            // 
            // rbtn_Client
            // 
            rbtn_Client.AutoSize = true;
            rbtn_Client.Location = new Point(576, 97);
            rbtn_Client.Name = "rbtn_Client";
            rbtn_Client.Size = new Size(85, 28);
            rbtn_Client.TabIndex = 18;
            rbtn_Client.Text = "Client";
            rbtn_Client.UseVisualStyleBackColor = true;
            // 
            // rbtn_Server
            // 
            rbtn_Server.AutoSize = true;
            rbtn_Server.Checked = true;
            rbtn_Server.Location = new Point(576, 63);
            rbtn_Server.Name = "rbtn_Server";
            rbtn_Server.Size = new Size(88, 28);
            rbtn_Server.TabIndex = 17;
            rbtn_Server.TabStop = true;
            rbtn_Server.Text = "Server";
            rbtn_Server.UseVisualStyleBackColor = true;
            // 
            // btn_CloseSever
            // 
            btn_CloseSever.Location = new Point(206, 378);
            btn_CloseSever.Name = "btn_CloseSever";
            btn_CloseSever.Size = new Size(112, 34);
            btn_CloseSever.TabIndex = 16;
            btn_CloseSever.Text = "关闭服务";
            btn_CloseSever.Click += btn_CloseSever_Click;
            // 
            // btn_CloseConnect
            // 
            btn_CloseConnect.Location = new Point(883, 378);
            btn_CloseConnect.Name = "btn_CloseConnect";
            btn_CloseConnect.Size = new Size(112, 34);
            btn_CloseConnect.TabIndex = 15;
            btn_CloseConnect.Text = "断开连接";
            // 
            // label5
            // 
            label5.Location = new Point(754, 210);
            label5.Name = "label5";
            label5.Size = new Size(74, 30);
            label5.TabIndex = 14;
            label5.Text = "Port";
            // 
            // label6
            // 
            label6.Location = new Point(754, 154);
            label6.Name = "label6";
            label6.Size = new Size(74, 30);
            label6.TabIndex = 13;
            label6.Text = "IP";
            // 
            // btn_Connect
            // 
            btn_Connect.Location = new Point(883, 328);
            btn_Connect.Name = "btn_Connect";
            btn_Connect.Size = new Size(112, 34);
            btn_Connect.TabIndex = 12;
            btn_Connect.Text = "连接服务器";
            // 
            // tb_CilentPort
            // 
            tb_CilentPort.Location = new Point(868, 210);
            tb_CilentPort.Name = "tb_CilentPort";
            tb_CilentPort.Size = new Size(150, 30);
            tb_CilentPort.TabIndex = 10;
            tb_CilentPort.Text = "8686";
            // 
            // tb_CilentIP
            // 
            tb_CilentIP.Location = new Point(868, 154);
            tb_CilentIP.Name = "tb_CilentIP";
            tb_CilentIP.Size = new Size(150, 30);
            tb_CilentIP.TabIndex = 9;
            tb_CilentIP.Text = "127.0.0.1";
            // 
            // label7
            // 
            label7.Location = new Point(911, 81);
            label7.Name = "label7";
            label7.Size = new Size(84, 45);
            label7.TabIndex = 8;
            label7.Text = "Cilent";
            // 
            // label3
            // 
            label3.Location = new Point(77, 260);
            label3.Name = "label3";
            label3.Size = new Size(84, 30);
            label3.TabIndex = 7;
            label3.Text = "MaxNum";
            // 
            // label2
            // 
            label2.Location = new Point(77, 210);
            label2.Name = "label2";
            label2.Size = new Size(74, 30);
            label2.TabIndex = 6;
            label2.Text = "Port";
            // 
            // label1
            // 
            label1.Location = new Point(77, 154);
            label1.Name = "label1";
            label1.Size = new Size(74, 30);
            label1.TabIndex = 5;
            label1.Text = "IP";
            // 
            // btn_NewServer
            // 
            btn_NewServer.Location = new Point(206, 328);
            btn_NewServer.Name = "btn_NewServer";
            btn_NewServer.Size = new Size(112, 34);
            btn_NewServer.TabIndex = 4;
            btn_NewServer.Text = "启动服务";
            btn_NewServer.Click += btn_NewServer_Click;
            // 
            // tb_MaxNum
            // 
            tb_MaxNum.Location = new Point(191, 260);
            tb_MaxNum.Name = "tb_MaxNum";
            tb_MaxNum.Size = new Size(150, 30);
            tb_MaxNum.TabIndex = 3;
            tb_MaxNum.Text = "10";
            // 
            // tb_ServerPort
            // 
            tb_ServerPort.Location = new Point(191, 210);
            tb_ServerPort.Name = "tb_ServerPort";
            tb_ServerPort.Size = new Size(150, 30);
            tb_ServerPort.TabIndex = 2;
            tb_ServerPort.Text = "8686";
            // 
            // tb_ServerIP
            // 
            tb_ServerIP.Location = new Point(191, 154);
            tb_ServerIP.Name = "tb_ServerIP";
            tb_ServerIP.Size = new Size(150, 30);
            tb_ServerIP.TabIndex = 1;
            tb_ServerIP.Text = "127.0.0.1";
            // 
            // lb_ser
            // 
            lb_ser.Location = new Point(234, 81);
            lb_ser.Name = "lb_ser";
            lb_ser.Size = new Size(84, 45);
            lb_ser.TabIndex = 0;
            lb_ser.Text = "Sever";
            // 
            // tb_Chat
            // 
            tb_Chat.Controls.Add(splitter1);
            tb_Chat.Location = new Point(0, 38);
            tb_Chat.Name = "tb_Chat";
            tb_Chat.Size = new Size(1244, 594);
            tb_Chat.TabIndex = 1;
            tb_Chat.Text = "聊天";
            // 
            // splitter1
            // 
            splitter1.Dock = DockStyle.Fill;
            splitter1.Location = new Point(0, 0);
            splitter1.Name = "splitter1";
            // 
            // splitter1.Panel1
            // 
            splitter1.Panel1.BackColor = SystemColors.Control;
            splitter1.Panel1.Controls.Add(lsb_List);
            // 
            // splitter1.Panel2
            // 
            splitter1.Panel2.Controls.Add(panel3);
            splitter1.Panel2.Controls.Add(rtb_Message);
            splitter1.Size = new Size(1244, 594);
            splitter1.SplitterDistance = 258;
            splitter1.TabIndex = 0;
            // 
            // lsb_List
            // 
            lsb_List.Dock = DockStyle.Fill;
            lsb_List.FormattingEnabled = true;
            lsb_List.Location = new Point(0, 0);
            lsb_List.Name = "lsb_List";
            lsb_List.Size = new Size(258, 594);
            lsb_List.TabIndex = 1;
            // 
            // panel3
            // 
            panel3.Controls.Add(btn_Send);
            panel3.Dock = DockStyle.Bottom;
            panel3.Location = new Point(0, 428);
            panel3.Name = "panel3";
            panel3.Size = new Size(982, 41);
            panel3.TabIndex = 2;
            // 
            // btn_Send
            // 
            btn_Send.Location = new Point(858, 4);
            btn_Send.Name = "btn_Send";
            btn_Send.Size = new Size(112, 34);
            btn_Send.TabIndex = 1;
            btn_Send.Text = "Send";
            btn_Send.Click += btn_Send_Click;
            // 
            // rtb_Message
            // 
            rtb_Message.Dock = DockStyle.Bottom;
            rtb_Message.Location = new Point(0, 469);
            rtb_Message.Name = "rtb_Message";
            rtb_Message.Size = new Size(982, 125);
            rtb_Message.TabIndex = 0;
            rtb_Message.Text = "";
            // 
            // tb_Guide
            // 
            tb_Guide.Controls.Add(steps1);
            tb_Guide.Location = new Point(-2488, -1188);
            tb_Guide.Name = "tb_Guide";
            tb_Guide.Size = new Size(1244, 594);
            tb_Guide.TabIndex = 0;
            tb_Guide.Text = "引导";
            // 
            // steps1
            // 
            steps1.Dock = DockStyle.Fill;
            stepsItem1.Name = "one";
            stepsItem1.Title = "进入设置启用服务端/客户端";
            stepsItem2.Name = "two";
            stepsItem2.Title = "完成";
            steps1.Items.Add(stepsItem1);
            steps1.Items.Add(stepsItem2);
            steps1.Location = new Point(0, 0);
            steps1.Name = "steps1";
            steps1.Size = new Size(1244, 594);
            steps1.TabIndex = 4;
            steps1.Text = "steps1";
            // 
            // panel2
            // 
            panel2.Controls.Add(lb_Cilent);
            panel2.Controls.Add(lb_Server);
            panel2.Controls.Add(lb_状态栏);
            panel2.Dock = DockStyle.Bottom;
            panel2.Location = new Point(0, 676);
            panel2.Name = "panel2";
            panel2.Size = new Size(1244, 34);
            panel2.TabIndex = 4;
            // 
            // lb_Cilent
            // 
            lb_Cilent.Badge = "False";
            lb_Cilent.BadgeAlign = AntdUI.TAlign.Right;
            lb_Cilent.BadgeBack = Color.Red;
            lb_Cilent.Dock = DockStyle.Left;
            lb_Cilent.Location = new Point(176, 0);
            lb_Cilent.Name = "lb_Cilent";
            lb_Cilent.Size = new Size(92, 34);
            lb_Cilent.TabIndex = 2;
            lb_Cilent.Text = "客户端";
            // 
            // lb_Server
            // 
            lb_Server.Badge = "False";
            lb_Server.BadgeAlign = AntdUI.TAlign.Right;
            lb_Server.BadgeBack = Color.Red;
            lb_Server.Dock = DockStyle.Left;
            lb_Server.Location = new Point(84, 0);
            lb_Server.Name = "lb_Server";
            lb_Server.Size = new Size(92, 34);
            lb_Server.TabIndex = 1;
            lb_Server.Text = "服务端";
            // 
            // lb_状态栏
            // 
            lb_状态栏.Dock = DockStyle.Left;
            lb_状态栏.Location = new Point(0, 0);
            lb_状态栏.Name = "lb_状态栏";
            lb_状态栏.Size = new Size(84, 34);
            lb_状态栏.TabIndex = 0;
            lb_状态栏.Text = "  状态栏：";
            // 
            // time_listbox
            // 
            time_listbox.Tick += time_listbox_Tick;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(11F, 24F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1244, 710);
            Controls.Add(tabs1);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Name = "Form1";
            Text = "Form1";
            panel1.ResumeLayout(false);
            tabs1.ResumeLayout(false);
            tb_setting.ResumeLayout(false);
            divider1.ResumeLayout(false);
            divider1.PerformLayout();
            tb_Chat.ResumeLayout(false);
            splitter1.Panel1.ResumeLayout(false);
            splitter1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)splitter1).EndInit();
            splitter1.ResumeLayout(false);
            panel3.ResumeLayout(false);
            tb_Guide.ResumeLayout(false);
            panel2.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private AntdUI.PageHeader pgh_pgh;
        private Panel panel1;
        private AntdUI.Tabs tabs1;
        private AntdUI.TabPage tb_Guide;
        private AntdUI.Steps steps1;
        private AntdUI.TabPage tb_Chat;
        private AntdUI.TabPage tb_setting;
        private AntdUI.Divider divider1;
        private AntdUI.Label lb_ser;
        private TextBox tb_ServerIP;
        private TextBox tb_ServerPort;
        private AntdUI.ButtonShadow btn_NewServer;
        private TextBox tb_MaxNum;
        private AntdUI.Label label3;
        private AntdUI.Label label2;
        private AntdUI.Label label1;
        private AntdUI.Label lb_Server;
        private AntdUI.Label label5;
        private AntdUI.Label label6;
        private AntdUI.ButtonShadow btn_Connect;
        private TextBox textBox1;
        private TextBox tb_CilentPort;
        private TextBox tb_CilentIP;
        private AntdUI.Label label7;
        private AntdUI.Splitter splitter1;
        private AntdUI.ButtonShadow btn_CloseConnect;
        private AntdUI.Button btn_Send;
        private RichTextBox rtb_Message;
        private AntdUI.ButtonShadow btn_CloseSever;
        private Panel panel2;
        private AntdUI.Label lb_状态栏;
        private AntdUI.Label lb_Cilent;
        private Panel panel3;
        private AntdUI.Chat.ChatList chatList1;
        private ListBox lsb_List;
        private AntdUI.Label lb_s_o_c;
        private RadioButton rbtn_Client;
        private RadioButton rbtn_Server;
        private AntdUI.Button btn_Start;
        private System.Windows.Forms.Timer time_listbox;
    }
}
