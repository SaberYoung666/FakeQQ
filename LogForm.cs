using System;
using System.Drawing;
using System.Net.Sockets;
using System.Net;
using System.Security.Cryptography;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading;
using System.Windows.Forms;
using FakeQQ.RoundedCorners;
using MySql.Data.MySqlClient;
using System.Security.Principal;

namespace FakeQQ
{
	public partial class LogForm : Form
	{
		// 实现无边框窗口的拖动用到的参数
		private bool mouseDown;
		private Point lastLocation;
		// 合法数据的正则表达式
		private string legalUsername = @"^[\u4e00-\u9fa5a-zA-Z0-9]{1,20}$";
		private string legalPassword = @"^(?=.*[A-Za-z])(?=.*\d)[A-Za-z\d]{8,20}$";
		// 创建套接字
		Socket clientSocket = null;
		Thread clientThread = null;

		public LogForm()
		{
			InitializeComponent();
		}

		private void MainWindow_Load(object sender, EventArgs e)
		{
			//设置焦点
			this.ActiveControl = this.HeadImagePicture;
			// 将背景图片设为控件的父级，实现透明色
			LogInClosePicture.Parent = LogInBackgroundPicture;
			LogUpLabel.Parent = LogInBackgroundPicture;
			LogUpClosePicture.Parent = LogUpBackgroundPicture;
			LogInLabel.Parent = LogUpBackgroundPicture;
			WelcomeLogUpLabel.Parent = LogUpBackgroundPicture;
			// 绘制圆角
			DrawRoundedCorners();
			// 设置文本框提示信息
			SetTextBoxCue();
			// 连接服务器
			LinkServer();
		}

		// 设置文本框提示信息
		private void SetTextBoxCue()
		{
			AccountTextBox.Cue = "输入QQ号";
			PasswordTextBox.Cue = "输入QQ密码";
			LogUpUsernameTextBox.Cue = "昵称";
			LogUpPasswordTextBox.Cue = "密码";
			LogUpCheckPasswordTextBox.Cue = "确认密码";
			LogUpPhoneTextBox.Cue = "手机号码";
		}

		// 绘制圆角
		private void DrawRoundedCorners()
		{
			// 绘制窗体的圆角
			int hRgn = RoundCorner.CreateRoundRectRgn(0, 0, this.Width, this.Height, 20, 20);
			RoundCorner.SetWindowRgn(this.Handle, hRgn, true);
			RoundCorner.DeleteObject(hRgn);

			// 绘制圆角
			RoundCorner.SetRoundRectRgn(AccountPanel, 10);
			RoundCorner.SetRoundRectRgn(PasswordPanel, 10);
			RoundCorner.SetRoundRectRgn(LogInButton, 10);
			RoundCorner.SetRoundRectRgn(LogUpUsernamePanel, 10);
			RoundCorner.SetRoundRectRgn(LogUpPasswordPanel, 10);
			RoundCorner.SetRoundRectRgn(LogUpCheckPasswordPanel, 10);
			RoundCorner.SetRoundRectRgn(LogUpPhonePanel, 10);
			RoundCorner.SetRoundRectRgn(LogUpButton, 10);
		}

		// 窗体拖动
		private void BackgroundPicture_MouseDown(object sender, MouseEventArgs e)
		{
			mouseDown = true;
			lastLocation = e.Location;
		}
		private void BackgroundPicture_MouseMove(object sender, MouseEventArgs e)
		{
			if (mouseDown)
			{
				this.Location = new Point((this.Location.X - lastLocation.X) + e.X, (this.Location.Y - lastLocation.Y) + e.Y);

				this.Update();
			}
		}
		private void BackgroundPicture_MouseUp(object sender, MouseEventArgs e)
		{
			mouseDown = false;
		}

		// 关闭窗体的方法
		private void ClosePicture_Click(object sender, EventArgs e)
		{
			this.Close();
		}

		// 鼠标放在关闭键上的方法
		private void ClosePicture_MouseEnter(object sender, EventArgs e)
		{
			LogInClosePicture.BackgroundImage = Properties.Resources.CloseFocus;
			LogInClosePicture.BackColor = Color.IndianRed;
			LogUpClosePicture.BackgroundImage = Properties.Resources.CloseFocus;
			LogUpClosePicture.BackColor = Color.IndianRed;
		}
		private void ClosePicture_MouseLeave(object sender, EventArgs e)
		{
			LogInClosePicture.BackgroundImage = Properties.Resources.Close;
			LogInClosePicture.BackColor = Color.Transparent;
			LogUpClosePicture.BackgroundImage = Properties.Resources.Close;
			LogUpClosePicture.BackColor = Color.Transparent;
		}

		// 登录注册页面切换
		private void LogUpLabel_Click(object sender, EventArgs e)
		{
			// 展示注册用到的控件
			LogInPanel.Visible = false;
		}
		private void LogInLabel_Click(object sender, EventArgs e)
		{
			// 展示登录用到的控件
			LogInPanel.Visible = true;
			SetTextBoxCue();
			LogUpUsernameTextBox.Clear();
			UsernameIndicatorPictureBox.Visible = false;
			LogUpPasswordTextBox.Clear();
			PasswordIndicatorPictureBox.Visible = false;
			LogUpCheckPasswordTextBox.Clear();
			CheckPasswordIndicatorPictureBox.Visible = false;
			LogUpPhoneTextBox.Clear();
			ActiveControl = null;
		}

		// 密码的16位大写的md5加密方法
		public static string MD5Encrypt64(string password)
		{
			var md5 = new MD5CryptoServiceProvider();
			string t2 = BitConverter.ToString(md5.ComputeHash(Encoding.Default.GetBytes(password)), 4, 8);
			t2 = t2.Replace("-", "");
			return t2;
		}

		// 连接到服务器
		private void LinkServer()
		{
			// 创建客户端套接字
			clientSocket = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
			// 设置IP地址
			IPAddress address = IPAddress.Parse("127.0.0.1");
			// 设置IP地址和端口号
			IPEndPoint endPoint = new IPEndPoint(address, 8088);
			try
			{
				// 与服务器建立连接
				clientSocket.Connect(endPoint);
			}
			catch (Exception ex)
			{
				MessageBox.Show("连接失败：" + ex.Message, "友情提示");
				return;
			}
			// 接收或发送消息 使用线程来实现
			clientThread = new Thread(ReceiveMsg);
			// 开启后台线程
			clientThread.IsBackground = true; 
			clientThread.Start();
		}
		// 客户端接收消息
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
						case "LISC":
							this.Invoke(new Action(() =>
							{
								this.Hide();
							}));
							string account = msg;
							string name = sArray[4];
							ListForm listForm = new ListForm(msg, name, clientSocket);
							listForm.ShowDialog();
							break;
						case "LIER":
							MessageBox.Show("账号或密码错误，请重新输入。", "登录失败");
							break;
						case "LUSC":
							// 展示账号
							MessageBox.Show("您的QQ号是：" + msg + ",请牢记", "注册成功");
							// 展示登录用到的控件
							this.Invoke(new Action(() =>
							{
								LogInPanel.Visible = true;
								SetTextBoxCue();
								LogUpUsernameTextBox.Clear();
								UsernameIndicatorPictureBox.Visible = false;
								LogUpPasswordTextBox.Clear();
								PasswordIndicatorPictureBox.Visible = false;
								LogUpCheckPasswordTextBox.Clear();
								CheckPasswordIndicatorPictureBox.Visible = false;
								LogUpPhoneTextBox.Clear();
								ActiveControl = null;
							}));
							break;
						default:
							break;
					}
				}
			}
		}

		// 登录逻辑
		// 判断焦点是否在输入框上
		private void FocusedTimer_Tick(object sender, EventArgs e)
		{
			if (this.ActiveControl == AccountTextBox)
			{
				AccountClosePicture.Visible = true;
			}
			else
			{
				AccountClosePicture.Visible = false;
			}

			if (this.ActiveControl == PasswordTextBox)
			{
				PasswordClosePicture.Visible = true;
			}
			else
			{
				PasswordClosePicture.Visible = false;
			}
		}
		// 清空文本框
		private void ClearPicture_Click(object sender, EventArgs e)
		{
			if (sender == AccountClosePicture)
			{
				AccountTextBox.Clear();
			}
			else if (sender == PasswordClosePicture)
			{
				PasswordTextBox.Clear();
			}
		}
		// 对于账号密码是否有输入做出判断
		private void MonitorTextBoxTimer_Tick(object sender, EventArgs e)
		{
			if (String.IsNullOrEmpty(AccountTextBox.Text) || String.IsNullOrEmpty(PasswordTextBox.Text))
			{
				LogInButton.BackColor = Color.AntiqueWhite;
				LogInButton.Enabled = false;
			}
			else
			{
				LogInButton.BackColor = Color.NavajoWhite;
				LogInButton.Enabled = true;
			}
		}
		// 向服务器请求做登录判断
		private void LoginButton_Click(object sender, EventArgs e)
		{
			string account = AccountTextBox.Text;
			string password = PasswordTextBox.Text;
			string encryptedPassword = MD5Encrypt64(password);

			byte[] accountBuffer = Encoding.Default.GetBytes("[LIAC]" + account + "[LIPW]" + encryptedPassword);
			clientSocket.Send(accountBuffer);
		}

		// 注册逻辑
		// 判断输入是否完全
		private void MonitorLogUpTextBoxTimer_Tick(object sender, EventArgs e)
		{
			if (String.IsNullOrEmpty(LogUpUsernameTextBox.Text) || String.IsNullOrEmpty(LogUpPasswordTextBox.Text) || String.IsNullOrEmpty(LogUpCheckPasswordTextBox.Text) || String.IsNullOrEmpty(LogUpPhoneTextBox.Text))
			{
				LogUpButton.BackColor = Color.AntiqueWhite;
				LogUpButton.Enabled = false;
			}
			else
			{
				LogUpButton.BackColor = Color.NavajoWhite;
				LogUpButton.Enabled = true;
			}
		}
		// 判断昵称是否合法
		private void LogUpUsernameTextBox_Validated(object sender, EventArgs e)
		{
			UsernameIndicatorPictureBox.Visible = true;

			if (Regex.IsMatch(LogUpUsernameTextBox.Text, legalUsername))
			{
				UsernameIndicatorPictureBox.BackgroundImage = Properties.Resources.right;
				LogUpUsernameTextBox.Cue = "昵称";
			}
			else if (String.IsNullOrEmpty(LogUpUsernameTextBox.Text))
			{
				UsernameIndicatorPictureBox.Visible = false;
				LogUpUsernameTextBox.Cue = "昵称";
			}
			else
			{
				UsernameIndicatorPictureBox.BackgroundImage = Properties.Resources.wrong;
				LogUpUsernameTextBox.Clear();
				ActiveControl = null;
				LogUpUsernameTextBox.Cue = "用户名应该在20字以内";
			}
		}
		// 判断密码是否合法
		private void LogUpPasswordTextBox_Validated(object sender, EventArgs e)
		{
			PasswordIndicatorPictureBox.Visible = true;

			if (Regex.IsMatch(LogUpPasswordTextBox.Text, legalPassword))
			{
				PasswordIndicatorPictureBox.BackgroundImage = Properties.Resources.right;
				LogUpPasswordTextBox.Cue = "密码";
			}
			else if (String.IsNullOrEmpty(LogUpPasswordTextBox.Text))
			{
				LogUpPasswordTextBox.Cue = "密码";
				PasswordIndicatorPictureBox.Visible = false;
			}
			else
			{
				PasswordIndicatorPictureBox.BackgroundImage = Properties.Resources.wrong;
				LogUpPasswordTextBox.Clear();
				ActiveControl = null;
				LogUpPasswordTextBox.Cue = "密码应由8-20位字符组成";
			}
		}
		// 判断两次密码输入是否相同
		private void LogUpCheckPasswordTextBox_Validated(object sender, EventArgs e)
		{
			CheckPasswordIndicatorPictureBox.Visible = true;

			if (String.IsNullOrEmpty(LogUpCheckPasswordTextBox.Text))
			{
				LogUpCheckPasswordTextBox.Cue = "确认密码";
				CheckPasswordIndicatorPictureBox.Visible = false;
			}
			else if (LogUpPasswordTextBox.Text.Equals(LogUpCheckPasswordTextBox.Text))
			{
				CheckPasswordIndicatorPictureBox.BackgroundImage = Properties.Resources.right;
				LogUpCheckPasswordTextBox.Cue = "确认密码";
			}
			else
			{
				CheckPasswordIndicatorPictureBox.BackgroundImage = Properties.Resources.wrong;
				LogUpCheckPasswordTextBox.Clear();
				ActiveControl = null;
				LogUpCheckPasswordTextBox.Cue = "两次输入密码应相同";
			}
		}
		// 向服务器请求做注册判断
		private void LogUpButton_Click(object sender, EventArgs e)
		{
			string username = LogUpUsernameTextBox.Text;
			string password = LogUpPasswordTextBox.Text;
			string phone = LogUpPhoneTextBox.Text;
			// 对密码做加密处理
			string encryptedPassword = MD5Encrypt64(password);

			byte[] accountBuffer = Encoding.Default.GetBytes("[LUUN]" + username + "[LUPW]" + encryptedPassword + "[LUPH]" + phone);
			clientSocket.Send(accountBuffer);
		}
		//TODO :防止sql注入
		//TODO :重写提示框
	}
}