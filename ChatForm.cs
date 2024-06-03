using FakeQQ.RoundedCorners;
using System;
using System.Drawing;
using System.Net.Sockets;
using System.Net;
using System.Text;
using System.Threading;
using System.Windows.Forms;
using System.Collections.Generic;
using System.Drawing.Drawing2D;

namespace FakeQQ
{
    public partial class ChatForm : Form
    {
        List<string> qqEmojiList= new List<string>();//qq表情列表
        private String qqEmojiURL;//qq表情链接
        private String imageURL;
        private Boolean is_changed = false;//判断用户输入是否改变
        private Boolean is_checkd = false;//判断用户是否发送消息
        private Boolean flag = false;//判断该消息是用户发送还是接收
        private String textBox_content;//文本框的值
        private Point init_location = new Point(0, 0);//初始位置
        private int send_count = 1;//消息发送次数
        private int recive_count = 1;// 消息接收次数
        private enum btn_type
        {
            text, emoji, image, document
        }
        btn_type type = btn_type.text;  
		// 创建套接字
		Socket clientSocket = null;
		Thread clientThread = null;
		private Point mousepoint;
		private Boolean leftflag = false;
        List<Friends> friendsList = new List<Friends>();
        int friendNumber = 0;

        // 接收传入的参数 
        private string firstMessage = "";
        private string sendAccount = "";
        private string receiveAccount = "";
        private string receiveUsername = "";

		public ChatForm()
        {
            InitializeComponent();
        }

		public ChatForm(string sendAccount, string receiveAccount, string receiveUsername, Socket clientSocket)
		{
			InitializeComponent();
			this.clientSocket = clientSocket;
			this.sendAccount = sendAccount;
			this.receiveAccount = receiveAccount;
			this.receiveUsername = receiveUsername;
		}

		public ChatForm(string firstMessage, string sendAccount, string receiveAccount, string receiveUsername, Socket clientSocket)
        {
            InitializeComponent();
            this.firstMessage = firstMessage;
            this.clientSocket = clientSocket;
            this.sendAccount = sendAccount;
            this.receiveAccount = receiveAccount;
            this.receiveUsername = receiveUsername;
        }

        private void ChatForm_Load(object sender, EventArgs e)
        {
            username.Text = receiveUsername;

            QQEmojiArea.Parent = this;
            QQEmojiArea.BringToFront();
            qqEmojiList.Add(@"C:\Users\ASUS\Desktop\qq表情包\QQ表情1.jpg");
            qqEmojiList.Add(@"C:\Users\ASUS\Desktop\qq表情包\QQ表情2.jpg");
            qqEmojiList.Add(@"C:\Users\ASUS\Desktop\qq表情包\QQ表情3.jpg");
            qqEmojiList.Add(@"C:\Users\ASUS\Desktop\qq表情包\QQ表情4.jpg");
            qqEmojiList.Add(@"C:\Users\ASUS\Desktop\qq表情包\QQ表情5.jpg");
            qqEmojiList.Add(@"C:\Users\ASUS\Desktop\qq表情包\QQ表情6.gif");
            qqEmojiList.Add(@"C:\Users\ASUS\Desktop\qq表情包\QQ表情7.jpg");
            qqEmojiList.Add(@"C:\Users\ASUS\Desktop\qq表情包\QQ表情8.jpg");
            qqEmojiList.Add(@"C:\Users\ASUS\Desktop\qq表情包\QQ表情9.jpg");

            if (!string.IsNullOrEmpty(firstMessage))
            {
                flag = true;
                // 头像位置
                send_count++;
				addReciveMessage(firstMessage);
            }

			// 开启后台socket线程
			clientThread = new Thread(ReceiveMsg);
			clientThread.IsBackground = true;
			clientThread.Start();
		}

        // 关闭按钮
        private void btn_close_Click(object sender, EventArgs e)
        {
            ListForm.chatFormStatus[receiveAccount] = false;
            this.Close();
        }
		private void picture_close_Click(object sender, EventArgs e)
		{
			this.Close();
		}
		private void picture_minus_Click(object sender, EventArgs e)
		{
			this.WindowState = FormWindowState.Minimized;
		}
		private void picture_minus_MouseMove(object sender, MouseEventArgs e)
		{
			picture_minus.BackColor = Color.Red;
		}
		private void picture_minus_MouseLeave(object sender, EventArgs e)
		{
			picture_minus.BackColor = Color.Transparent;
		}
		private void picture_close_MouseMove(object sender, MouseEventArgs e)
		{
			picture_close.BackColor = Color.Red;
		}
		private void picture_close_MouseLeave(object sender, EventArgs e)
		{
			picture_close.BackColor = Color.Transparent;
		}

		// 窗体移动
		private void navigation_bar_MouseDown(object sender, MouseEventArgs e)
		{
			if (e.Button == MouseButtons.Left)
			{
				mousepoint = e.Location;
				leftflag = true;
			}
		}
		private void navigation_bar_MouseMove(object sender, MouseEventArgs e)
		{
			if (leftflag)
			{
				Left = MousePosition.X - mousepoint.X;
				Top = MousePosition.Y - mousepoint.Y;
			}
		}
		private void navigation_bar_MouseUp(object sender, MouseEventArgs e)
		{
			leftflag = false;
		}

		// 发送消息
		// 动态添加聊天框
		private void btn_send_Click(object sender, EventArgs e)
        {
            is_checkd = true;
            flag= false;
            if (send_count == 1&&flag==false)
            {
                init_location.Y = 20;
			}
            init_location.X=this.Width - 50;
			if (type == btn_type.text || type == btn_type.document)
            {
                PictureBox userAvatar = new PictureBox();
                RichTextBox message = new RichTextBox();
                set_userAvatar(userAvatar, init_location);
                set_message(message, init_location);
                messageArea.Controls.Add(message);
                messageArea.Controls.Add(userAvatar);
                messageArea.ScrollControlIntoView(userAvatar);
                messageArea.ScrollControlIntoView(message);
            }
            if(type == btn_type.image || type == btn_type.emoji)
            {
                PictureBox userAvatar = new PictureBox();
                PictureBox message = new PictureBox();
                set_userAvatar(userAvatar, init_location);
                set_message(message, init_location);
                messageArea.Controls.Add(message);
                messageArea.Controls.Add(userAvatar);
                messageArea.ScrollControlIntoView(userAvatar);
                messageArea.ScrollControlIntoView(message);
            }
            send_count +=1;
            richTextBox_content.Clear();
            richTextBox_content.Controls.Clear();
            richTextBox_content.Focus();
            type = btn_type.text;
        }
        // 设置头像框属性
        private void set_userAvatar(PictureBox userAvatar,Point location)
        {
            userAvatar.Size = new Size(30, 30);
            userAvatar.Location = init_location;
            userAvatar.Image = Properties.Resources.logo;
            userAvatar.SizeMode=PictureBoxSizeMode.StretchImage;
            RoundCorner.SetRoundRectRgn(userAvatar, 30);
        }
        // 设置消息框属性
        private void set_message(Control message,Point location)
        {
            if (type == btn_type.text)
            {
                RichTextBox text_message = (RichTextBox)message;
				if (!flag)
				{
					text_message.Text = textBox_content;
					// 发送消息
					string str = textBox_content;
					if (!string.IsNullOrEmpty(str))
					{
						byte[] buffer = Encoding.Default.GetBytes("[SDMG]" + str + "[SDAC]" + sendAccount + "[REAC]" + receiveAccount);
						clientSocket.Send(buffer);
					}
				}
				text_message.Width = 200;
				text_message.BackColor = Color.White;
                text_message.BorderStyle = BorderStyle.None;
				text_message.ContentsResized += Message_ContentsResized;
				set_location(text_message);
				text_message.ReadOnly = true;
                
			}
            else if (type == btn_type.image)
            {
				PictureBox image_message= (PictureBox)message;
                image_message.Image = Clipboard.GetImage();
                image_message.SizeMode=PictureBoxSizeMode.AutoSize;
                set_location(image_message);
                init_location.Y += image_message.Height + 20;
                if (init_location.Y > messageArea.Height)
                {
                    init_location.Y = messageArea.Height + 20;
                }
            }
            else if(type == btn_type.document)
            {
                RichTextBox document_message = (RichTextBox)message;
                document_message.Width = 50;
                document_message.BorderStyle = BorderStyle.None;
                set_location(document_message);
                document_message.ContentsResized += Message_ContentsResized;
                document_message.Paste();
            }
            else if (type == btn_type.emoji)
            {
                PictureBox qq_emoji_message = (PictureBox)message;
                qq_emoji_message.ImageLocation = qqEmojiURL;
                qq_emoji_message.Size = new Size(100,100);
                qq_emoji_message.SizeMode = PictureBoxSizeMode.StretchImage;
                set_location(qq_emoji_message);
                init_location.Y += qq_emoji_message.Height+20;
                if (init_location.Y > messageArea.Height)
                {
                    init_location.Y=messageArea.Height+20;
                }
            }  
        }
        private void set_location(Control message)
        {
            if (flag)
            {
                message.Location = new Point(init_location.X + 50, init_location.Y + 5);
            }
            else
            {
                message.Location = new Point(init_location.X - message.Width - 20, init_location.Y + 5);
            }
        }
        
        private void Message_ContentsResized(object sender, ContentsResizedEventArgs e)
        {
            RichTextBox message = sender as RichTextBox;
            message.Height = e.NewRectangle.Height;
            init_location.Y += message.Height;
            if (init_location.Y > messageArea.Height)
            {
                init_location.Y = messageArea.Height + 20;
            }
        }
        private void richTextBox_content_TextChanged(object sender, EventArgs e)
        {
            is_checkd = false;
            textBox_content = richTextBox_content.Text;
            if (textBox_content=="")
            {
                btn_send.Enabled = false;
            }
            else
            {
                is_changed= true;
                btn_send.Enabled = true;
            }
        }
        private void richTextBox_content_ControlAdded(object sender, ControlEventArgs e)
        {
            is_checkd= false;
            is_changed= true;
            btn_send.Enabled = true;
        }

        // 发送文件
        private void picture_doc_Click(object sender, EventArgs e)
        {
            type= btn_type.document;
            OpenFileDialog openDocumentDialog = new OpenFileDialog();
            openDocumentDialog.Filter = "文本文件(*.txt)|*.txt|所有文件(*.*)|*.*";
            openDocumentDialog.Multiselect = false;//关闭多选
            if (openDocumentDialog.ShowDialog() == DialogResult.OK)
            {
                MessageBox.Show(openDocumentDialog.FileName);
                Clipboard.Clear();   //清空剪贴板
                System.Collections.Specialized.StringCollection files = new System.Collections.Specialized.StringCollection();
                files.Add(openDocumentDialog.FileName);
                Clipboard.SetFileDropList(files);
                Thread thread = new Thread(new ThreadStart(Dialog));
                thread.SetApartmentState(ApartmentState.STA); //重点
                thread.Start();
                
            }    
        }

        // 发送表情包
        private void picture_emoji_Click(object sender, EventArgs e)
        {
            type= btn_type.emoji;
            Point qqEmojiLocation=new Point(20,20);
            QQEmojiArea.Visible= true;
            for(int i = 0; i < qqEmojiList.Count; i++)
            {
                PictureBox qqEmoji=new PictureBox();
                qqEmoji.ImageLocation = qqEmojiList[i];
                qqEmoji.Location = qqEmojiLocation;
                qqEmoji.Size = new Size(40, 40);
                qqEmoji.SizeMode = PictureBoxSizeMode.StretchImage;
                qqEmoji.Click += QqEmoji_Click;
                qqEmojiLocation.X += 72;
                if (qqEmojiLocation.X >=QQEmojiArea.Width-60)
                {
                    qqEmojiLocation.Y += 50;
                    qqEmojiLocation.X = 20;
                }
                QQEmojiArea.Controls.Add(qqEmoji);
            }
        }

        private void QqEmoji_Click(object sender, EventArgs e)
        {
            QQEmojiArea.VerticalScroll.Value = 0;
            PictureBox qq_emoji=new PictureBox();
            qq_emoji.ImageLocation = (sender as PictureBox).ImageLocation;
            qqEmojiURL = (sender as PictureBox).ImageLocation;
            qq_emoji.Size = new Size(100, 100);
            qq_emoji.SizeMode = PictureBoxSizeMode.StretchImage;
            richTextBox_content.Controls.Add(qq_emoji);
            QQEmojiArea.Visible = false;
        }

        // 发送图片
        private void picture_image_Click(object sender, EventArgs e)
        {
			type = btn_type.image;
            OpenFileDialog openImageFileDialog = new OpenFileDialog();
            openImageFileDialog.Filter = "图片文件|*.jpg|BMP图片|*.bmp|Gif图片|*.gif";
            openImageFileDialog.Multiselect = false;
            if (openImageFileDialog.ShowDialog() == DialogResult.OK)
            {
                MessageBox.Show(openImageFileDialog.FileName);
                Clipboard.Clear();   //清空剪贴板
                Bitmap bmp = new Bitmap(openImageFileDialog.FileName);  //创建Bitmap类对象
                Clipboard.SetImage(bmp);  //将Bitmap类对象写入剪贴板
                Thread thread = new Thread(new ThreadStart(Dialog));
                thread.SetApartmentState(ApartmentState.STA); //重点
                thread.Start();
            }
        }

        // 添加接收消息框
        private void addReciveMessage(String reciveMessage)
        {
			flag = true;
            if (send_count == 1&&is_checkd==false)
            {
                init_location.Y=20;
            }
            init_location.X=20;
			PictureBox userAvatar = new PictureBox();
            RichTextBox recive_message= new RichTextBox();
            recive_message.Text= reciveMessage;
            set_userAvatar(userAvatar, init_location);
            set_message(recive_message, init_location);
            messageArea.Controls.Add(recive_message);
            messageArea.Controls.Add(userAvatar);
            messageArea.ScrollControlIntoView(userAvatar);
            messageArea.ScrollControlIntoView(recive_message);
        }

        private void Dialog()
        {
            this.Invoke(new Action(() =>
            {
                richTextBox_content.Paste();   //将剪贴板中的对象粘贴到对话框里
            }));
        }

        // 客户端接收消息
		private void ReceiveMsg()
		{
			while (true)
			{
				byte[] recBuffer = new byte[1024 * 1024 * 2];//声明最大字符内存
				int length = -1; //字节长度
				try
				{
					length = clientSocket.Receive(recBuffer);//返回接收到的实际的字节数量
				}
				catch (SocketException ex)
				{
                    MessageBox.Show(ex.Message,"1");
					break;
				}
				catch (Exception ex)
				{
                    MessageBox.Show(ex.Message,"2");
					break;
				}
				// 接收到消息
				if (length > 0)
				{
					string originMsg = Encoding.Default.GetString(recBuffer, 0, length);
					string[] sArray = originMsg.Split(new char[2] { '[', ']' });
					string mark = sArray[1];
					string msg = sArray[2];
					switch (mark)
					{
						case "REMG":
                            string receiveMessage = sArray[2];
							this.Invoke(new Action(() =>
							{
								addReciveMessage(receiveMessage);
							}));
                            break;
						default:
							break;
					}
				}
			}
		}


    }
}
