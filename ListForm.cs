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
        string currentAccount = "";
        string name = "";
        // 连接服务器的套接字
		Socket clientSocket = null;
		Thread clientThread = null;
        // 用户好友的数量
        int frendNumber = 0;
        Boolean responseStatus = false;
        // 字典存放用户对话框打开状态
        public static Dictionary<string, Boolean> chatFormStatus = new Dictionary<string, Boolean>();

		public ListForm()
        {
            InitializeComponent();
        }

        public ListForm(string account, string name, Socket clientSocket)
        {
            InitializeComponent();
            this.currentAccount = account;
            this.clientSocket = clientSocket;
            this.name = name;
        }

        private void ListForm_Load(object sender, EventArgs e)
        {
            userName.Text = name;
			Point panel_location = new Point(0, 0);
			// 开启后台socket线程
			clientThread = new Thread(ReceiveMsg);
			clientThread.IsBackground = true;
			clientThread.Start();

            // 初始化好友列表
            initializeFriendsList();

            foreach (Friends friends in friendsList)
            {
                chatFormStatus[friends.account] = false;
            }

            // 绘制窗体的圆角
            int hRgn = RoundCorner.CreateRoundRectRgn(0, 0, this.Width, this.Height, 20, 20);
            RoundCorner.SetWindowRgn(this.Handle, hRgn, true);
            RoundCorner.DeleteObject(hRgn);
		}

        private void initializeFriendsList()
        {
			byte[] accountBuffer = Encoding.Default.GetBytes("[FLIN]" + currentAccount);
			clientSocket.Send(accountBuffer);
            while (!responseStatus || friendsList.Count != frendNumber)
            {
                continue;
            }
			// 设置当前用户信息
            Point panel_location = new Point(0, 0); 
			Point label_location = new Point(70, 15);
			Point pictureBox_location = new Point(10, 0);
			// 绘制好友列表
			for (int i = 0; i < friendsList.Count; i++, panel_location.Y += 80)
			{
                Panel panel = new Panel();
				OvalPictureBox pictureBox = new OvalPictureBox();
				Label label = new Label();
                Label accountLabel = new Label();

                accountLabel.Visible = false;
                accountLabel.Text = friendsList[i].account;
                set_panel(panel,panel_location);
				set_pictureBox(pictureBox, pictureBox_location, i);
				set_label(label, label_location, i);

				panel.Controls.Add(pictureBox);
				panel.Controls.Add(label);
                panel.Controls.Add(accountLabel);
                panel_friendslist.Controls.Add(panel);
			}
		}

		// 设置单个好友头像
		public void set_pictureBox(PictureBox pictureBox,Point pictureBox_location,int index)
        {
            pictureBox.Location = pictureBox_location;
            pictureBox.Size = new Size(50, 50);
            pictureBox.BackgroundImage = friendsList[index].avatar;
            pictureBox.BackgroundImageLayout = ImageLayout.Stretch;
			pictureBox.DoubleClick += Panel_DoubleClick;
        }

		// 双击好友头像的事件
		// 设置单个好友名称
		public void set_label(Label label,Point label_location,int index) {
            label.Text = friendsList[index].name;
            label.Location = label_location;
            label.BackColor = Color.Transparent;
            label.Font = new Font("微软雅黑",9f);
            label.DoubleClick+= Panel_DoubleClick;
        }

        public void set_panel(Panel panel,Point panel_location)
        {
            panel.Size = new Size(panel_friendslist.Width-18, 80);
            panel.Location = panel_location;
            panel.DoubleClick += Panel_DoubleClick;
        }
        private void Panel_DoubleClick(object sender, EventArgs e)
        {
            string receiveAccount = "";
            string receiveUsername = "";
            if (sender is Panel)
            {
                receiveAccount = (sender as Panel).Controls[2].Text;
                receiveUsername = (sender as Panel).Controls[1].Text;
			}
            else if (sender is PictureBox)
            {
				receiveAccount = (sender as PictureBox).Parent.Controls[2].Text;
				receiveUsername = (sender as PictureBox).Parent.Controls[1].Text;
			}
            else
            {
				receiveAccount = (sender as Label).Parent.Controls[2].Text;
                receiveUsername = (sender as Label).Text;
			}

			byte[] beginBuffer = Encoding.Default.GetBytes("[CHOP]" + receiveAccount);
			clientSocket.Send(beginBuffer);
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
                        case "REMG":
                            // 被动打开对话窗体
                            string receiveMessage = sArray[2];
                            string sendAccount = sArray[4];
                            string sendUsername = "";

                            foreach (Friends friends in friendsList)
                            {
                                if (friends.account == sendAccount)
                                {
                                    sendUsername = friends.name;
                                }
                            }
                            if (!chatFormStatus[sendAccount])
                            {
                                ChatForm passiveChatForm = new ChatForm(receiveMessage, currentAccount, sendAccount, sendUsername, clientSocket);
                                passiveChatForm.ShowDialog();
                                chatFormStatus[sendAccount] = true;
                            }
                            break;
                        case "ALCH":
                            // 主动打开对话窗体
                            string chatAccount = msg;
                            string chatUsername = "";
							foreach (Friends friends in friendsList)
							{
								if (friends.account == chatAccount)
								{
									chatUsername = friends.name;
								}
							}
							ChatForm activeChatForm = new ChatForm(currentAccount, chatAccount, chatUsername, clientSocket);
							activeChatForm.ShowDialog();
							chatFormStatus[chatAccount] = true;
							break;
                        default:
							break;
					}
				}
			}
		}
	}
}