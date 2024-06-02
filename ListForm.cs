using FakeQQ.RoundedCorners;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Net.Sockets;
using System.Security.Policy;
using System.Security.Principal;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FakeQQ
{
    public partial class ListForm : Form
    {
		private Point mousepoint;
		private Boolean leftflag = false;
		List<Friends> friendsList = new List<Friends>();
        // 当前用户的qq号
        string sendAccount = "";
        // 连接服务器的套接字
		Socket clientSocket = null;
		Thread clientThread = null;
        // 用户好友的数量
        int frendNumber = 0;
        Boolean responseStatus = false;

		public ListForm()
        {
            InitializeComponent();
        }

        public ListForm(string account, Socket clientSocket)
        {
            InitializeComponent();
            this.sendAccount = account;
            this.clientSocket = clientSocket;
        }

        private void ListForm_Load(object sender, EventArgs e)
        {
            // 开启后台socket线程
			clientThread = new Thread(ReceiveMsg);
			clientThread.IsBackground = true;
			clientThread.Start();

            // 初始化好友列表
            initializeFriendsList();

            // 绘制窗体的圆角
            int hRgn = RoundCorner.CreateRoundRectRgn(0, 0, this.Width, this.Height, 20, 20);
            RoundCorner.SetWindowRgn(this.Handle, hRgn, true);
            RoundCorner.DeleteObject(hRgn);
		}

        private void initializeFriendsList()
        {
			byte[] accountBuffer = Encoding.Default.GetBytes("[FLIN]" + sendAccount);
			clientSocket.Send(accountBuffer);
            while (!responseStatus || friendsList.Count != frendNumber)
            {
                continue;
            }
			// 设置当前用户信息
			Point label_location = new Point(70, 160);
			Point pictureBox_location = new Point(10, 140);
			// 绘制好友列表
			for (int i = 0; i < friendsList.Count; i++, label_location.Y += 80, pictureBox_location.Y += 80)
			{
				OvalPictureBox pictureBox = new OvalPictureBox();
				Label label = new Label();
				set_pictureBox(pictureBox, pictureBox_location, i);
				set_label(label, label_location, i);
				this.Controls.Add(pictureBox);
				this.Controls.Add(label);
			}
		}

		// 设置单个好友头像
		public void set_pictureBox(PictureBox pictureBox,Point pictureBox_location,int index)
        {
            pictureBox.Location = pictureBox_location;
            pictureBox.Size = new Size(50, 50);
            pictureBox.BackgroundImage = friendsList[index].avatar;
            pictureBox.BackgroundImageLayout = ImageLayout.Stretch;
            pictureBox.DoubleClick += PictureBox_DoubleClick;
        }
        // 双击好友头像的事件
        private void PictureBox_DoubleClick(object sender, EventArgs e)
        {
            ChatForm chatForm = new ChatForm(sendAccount,"",clientSocket);
            chatForm.Show(); 
        }
        // 设置单个好友名称
        public void set_label(Label label,Point label_location,int index) {
            label.Text = friendsList[index].name;
            label.Location = label_location;
            label.BackColor = Color.Transparent;
            label.Font = new Font("微软雅黑",9f);
        }

        // 最小化
        private void picture_minus_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }
        private void picture_minus_MouseMove(object sender, MouseEventArgs e)
        {
            picture_minus.BackColor= Color.Red;
        }
        private void picture_minus_MouseLeave(object sender, EventArgs e)
        {
            picture_minus.BackColor= Color.Transparent;
        }
        // 关闭
        private void picture_close_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        private void picture_close_MouseMove(object sender, MouseEventArgs e)
        {
            picture_close.BackColor= Color.Red;
        }
        private void picture_close_MouseLeave(object sender, EventArgs e)
        {
            picture_close.BackColor= Color.Transparent;
        }
        
        // 窗体拖动
        private void ListForm_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                mousepoint=e.Location;
                leftflag = true;
            }
        }
        private void ListForm_MouseMove(object sender, MouseEventArgs e)
        {
            if (leftflag)
            {
                Left = MousePosition.X - mousepoint.X;
                Top = MousePosition.Y - mousepoint.Y;
            }
        }
        private void ListForm_MouseUp(object sender, MouseEventArgs e)
        {
            leftflag=false;
        }

		private void ReceiveMsg()
		{
			while (true)
			{
				byte[] recBuffer = new byte[1024 * 1024 * 2];// 声明最大字符内存
				int length = -1; // 字节长度
				try
				{
					length = clientSocket.Receive(recBuffer);// 返回接收到的实际的字节数量
				}
				catch (SocketException ex)
				{
					break;
				}
				catch (Exception ex)
				{
					MessageBox.Show("与服务器断开连接");
					break;
				}
				// 解析消息
				if (length > 0)
				{
					// 转译字符串(字符串，开始的索引，字符串长度)
					string originMsg = Encoding.Default.GetString(recBuffer, 0, length);
					string[] sArray = originMsg.Split(new char[2] { '[', ']' });
					string mark = sArray[1];
					string msg = sArray[2];
					switch (mark)
					{
						case "FLNB":
                            frendNumber = int.Parse(msg);
							responseStatus = true;
                            if (frendNumber > 0)
                            {
                                byte[] beginBuffer = Encoding.Default.GetBytes("[FLNT]0");
							    clientSocket.Send(beginBuffer);
                            }
							break;
                        case "FLAC":
                            string account = sArray[2];
                            string username = sArray[4];
                            string onlineStatus = sArray[6];
                            friendsList.Add(new Friends(account, username, Properties.Resources.logo, Convert.ToBoolean(onlineStatus)));
                            if (friendsList.Count != frendNumber)
                            {
                                byte[] beginBuffer = Encoding.Default.GetBytes("[FLNT]" + friendsList.Count);
                                clientSocket.Send(beginBuffer);
                            }
                            break;
						default:
							break;
					}
				}
			}
		}
	}
}