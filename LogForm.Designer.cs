namespace FakeQQ
{
	partial class LogForm
	{
		/// <summary>
		/// 必需的设计器变量。
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// 清理所有正在使用的资源。
		/// </summary>
		/// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Windows 窗体设计器生成的代码

		/// <summary>
		/// 设计器支持所需的方法 - 不要修改
		/// 使用代码编辑器修改此方法的内容。
		/// </summary>
		private void InitializeComponent()
		{
			this.components = new System.ComponentModel.Container();
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LogForm));
			this.AccountPanel = new System.Windows.Forms.Panel();
			this.AccountClosePicture = new System.Windows.Forms.PictureBox();
			this.AccountTextBox = new CueTextBox();
			this.PasswordPanel = new System.Windows.Forms.Panel();
			this.PasswordTextBox = new CueTextBox();
			this.PasswordClosePicture = new System.Windows.Forms.PictureBox();
			this.LogUpPhonePanel = new System.Windows.Forms.Panel();
			this.LogUpPhoneTextBox = new CueTextBox();
			this.LogUpLabel = new System.Windows.Forms.Label();
			this.LogUpUsernamePanel = new System.Windows.Forms.Panel();
			this.LogUpUsernameTextBox = new CueTextBox();
			this.UsernameIndicatorPictureBox = new System.Windows.Forms.PictureBox();
			this.LogUpPasswordPanel = new System.Windows.Forms.Panel();
			this.LogUpPasswordTextBox = new CueTextBox();
			this.PasswordIndicatorPictureBox = new System.Windows.Forms.PictureBox();
			this.LogUpButton = new System.Windows.Forms.Button();
			this.LogInLabel = new System.Windows.Forms.Label();
			this.LogInPanel = new System.Windows.Forms.Panel();
			this.HeadImagePicture = new OvalPictureBox();
			this.LogInButton = new System.Windows.Forms.Button();
			this.LogInClosePicture = new System.Windows.Forms.PictureBox();
			this.LogInBackgroundPicture = new System.Windows.Forms.PictureBox();
			this.LogUpPanel = new System.Windows.Forms.Panel();
			this.WelcomeLogUpLabel = new System.Windows.Forms.Label();
			this.LogUpCheckPasswordPanel = new System.Windows.Forms.Panel();
			this.CheckPasswordIndicatorPictureBox = new System.Windows.Forms.PictureBox();
			this.LogUpCheckPasswordTextBox = new CueTextBox();
			this.LogUpBackgroundPicture = new System.Windows.Forms.PictureBox();
			this.LogUpClosePicture = new System.Windows.Forms.PictureBox();
			this.MonitorLogInTextBoxTimer = new System.Windows.Forms.Timer(this.components);
			this.FocusedTimer = new System.Windows.Forms.Timer(this.components);
			this.MonitorLogUpTextBoxTimer = new System.Windows.Forms.Timer(this.components);
			this.AccountPanel.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.AccountClosePicture)).BeginInit();
			this.PasswordPanel.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.PasswordClosePicture)).BeginInit();
			this.LogUpPhonePanel.SuspendLayout();
			this.LogUpUsernamePanel.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.UsernameIndicatorPictureBox)).BeginInit();
			this.LogUpPasswordPanel.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.PasswordIndicatorPictureBox)).BeginInit();
			this.LogInPanel.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.HeadImagePicture)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.LogInClosePicture)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.LogInBackgroundPicture)).BeginInit();
			this.LogUpPanel.SuspendLayout();
			this.LogUpCheckPasswordPanel.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.CheckPasswordIndicatorPictureBox)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.LogUpBackgroundPicture)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.LogUpClosePicture)).BeginInit();
			this.SuspendLayout();
			// 
			// AccountPanel
			// 
			this.AccountPanel.BackColor = System.Drawing.Color.White;
			this.AccountPanel.Controls.Add(this.AccountClosePicture);
			this.AccountPanel.Controls.Add(this.AccountTextBox);
			this.AccountPanel.Location = new System.Drawing.Point(41, 150);
			this.AccountPanel.Name = "AccountPanel";
			this.AccountPanel.Size = new System.Drawing.Size(270, 44);
			this.AccountPanel.TabIndex = 8;
			// 
			// AccountClosePicture
			// 
			this.AccountClosePicture.BackgroundImage = global::FakeQQ.Properties.Resources.Close;
			this.AccountClosePicture.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
			this.AccountClosePicture.Location = new System.Drawing.Point(240, 13);
			this.AccountClosePicture.Name = "AccountClosePicture";
			this.AccountClosePicture.Size = new System.Drawing.Size(19, 19);
			this.AccountClosePicture.TabIndex = 0;
			this.AccountClosePicture.TabStop = false;
			this.AccountClosePicture.Visible = false;
			this.AccountClosePicture.Click += new System.EventHandler(this.ClearPicture_Click);
			// 
			// AccountTextBox
			// 
			this.AccountTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.AccountTextBox.Cue = null;
			this.AccountTextBox.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
			this.AccountTextBox.Location = new System.Drawing.Point(55, 13);
			this.AccountTextBox.Name = "AccountTextBox";
			this.AccountTextBox.ShortcutsEnabled = false;
			this.AccountTextBox.Size = new System.Drawing.Size(160, 19);
			this.AccountTextBox.TabIndex = 4;
			this.AccountTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			// 
			// PasswordPanel
			// 
			this.PasswordPanel.BackColor = System.Drawing.Color.White;
			this.PasswordPanel.Controls.Add(this.PasswordTextBox);
			this.PasswordPanel.Controls.Add(this.PasswordClosePicture);
			this.PasswordPanel.Location = new System.Drawing.Point(41, 224);
			this.PasswordPanel.Name = "PasswordPanel";
			this.PasswordPanel.Size = new System.Drawing.Size(270, 44);
			this.PasswordPanel.TabIndex = 9;
			// 
			// PasswordTextBox
			// 
			this.PasswordTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.PasswordTextBox.Cue = null;
			this.PasswordTextBox.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
			this.PasswordTextBox.Location = new System.Drawing.Point(55, 13);
			this.PasswordTextBox.Name = "PasswordTextBox";
			this.PasswordTextBox.ShortcutsEnabled = false;
			this.PasswordTextBox.Size = new System.Drawing.Size(160, 19);
			this.PasswordTextBox.TabIndex = 4;
			this.PasswordTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			this.PasswordTextBox.UseSystemPasswordChar = true;
			// 
			// PasswordClosePicture
			// 
			this.PasswordClosePicture.BackgroundImage = global::FakeQQ.Properties.Resources.Close;
			this.PasswordClosePicture.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
			this.PasswordClosePicture.Location = new System.Drawing.Point(240, 13);
			this.PasswordClosePicture.Name = "PasswordClosePicture";
			this.PasswordClosePicture.Size = new System.Drawing.Size(19, 19);
			this.PasswordClosePicture.TabIndex = 0;
			this.PasswordClosePicture.TabStop = false;
			this.PasswordClosePicture.Visible = false;
			this.PasswordClosePicture.Click += new System.EventHandler(this.ClearPicture_Click);
			// 
			// LogUpPhonePanel
			// 
			this.LogUpPhonePanel.BackColor = System.Drawing.Color.White;
			this.LogUpPhonePanel.Controls.Add(this.LogUpPhoneTextBox);
			this.LogUpPhonePanel.Location = new System.Drawing.Point(41, 250);
			this.LogUpPhonePanel.Name = "LogUpPhonePanel";
			this.LogUpPhonePanel.Size = new System.Drawing.Size(270, 44);
			this.LogUpPhonePanel.TabIndex = 20;
			// 
			// LogUpPhoneTextBox
			// 
			this.LogUpPhoneTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.LogUpPhoneTextBox.Cue = null;
			this.LogUpPhoneTextBox.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
			this.LogUpPhoneTextBox.Location = new System.Drawing.Point(55, 13);
			this.LogUpPhoneTextBox.Name = "LogUpPhoneTextBox";
			this.LogUpPhoneTextBox.ShortcutsEnabled = false;
			this.LogUpPhoneTextBox.Size = new System.Drawing.Size(160, 19);
			this.LogUpPhoneTextBox.TabIndex = 9;
			this.LogUpPhoneTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			// 
			// LogUpLabel
			// 
			this.LogUpLabel.AutoSize = true;
			this.LogUpLabel.BackColor = System.Drawing.Color.Transparent;
			this.LogUpLabel.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
			this.LogUpLabel.ForeColor = System.Drawing.Color.SaddleBrown;
			this.LogUpLabel.Location = new System.Drawing.Point(246, 394);
			this.LogUpLabel.Name = "LogUpLabel";
			this.LogUpLabel.Size = new System.Drawing.Size(65, 19);
			this.LogUpLabel.TabIndex = 11;
			this.LogUpLabel.Text = "注册账号";
			this.LogUpLabel.Click += new System.EventHandler(this.LogUpLabel_Click);
			// 
			// LogUpUsernamePanel
			// 
			this.LogUpUsernamePanel.BackColor = System.Drawing.Color.White;
			this.LogUpUsernamePanel.Controls.Add(this.LogUpUsernameTextBox);
			this.LogUpUsernamePanel.Controls.Add(this.UsernameIndicatorPictureBox);
			this.LogUpUsernamePanel.ForeColor = System.Drawing.SystemColors.ControlText;
			this.LogUpUsernamePanel.Location = new System.Drawing.Point(41, 100);
			this.LogUpUsernamePanel.Name = "LogUpUsernamePanel";
			this.LogUpUsernamePanel.Size = new System.Drawing.Size(270, 44);
			this.LogUpUsernamePanel.TabIndex = 20;
			// 
			// LogUpUsernameTextBox
			// 
			this.LogUpUsernameTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.LogUpUsernameTextBox.Cue = null;
			this.LogUpUsernameTextBox.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
			this.LogUpUsernameTextBox.Location = new System.Drawing.Point(55, 13);
			this.LogUpUsernameTextBox.Name = "LogUpUsernameTextBox";
			this.LogUpUsernameTextBox.ShortcutsEnabled = false;
			this.LogUpUsernameTextBox.Size = new System.Drawing.Size(160, 19);
			this.LogUpUsernameTextBox.TabIndex = 5;
			this.LogUpUsernameTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			this.LogUpUsernameTextBox.Validated += new System.EventHandler(this.LogUpUsernameTextBox_Validated);
			// 
			// UsernameIndicatorPictureBox
			// 
			this.UsernameIndicatorPictureBox.BackColor = System.Drawing.Color.Transparent;
			this.UsernameIndicatorPictureBox.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
			this.UsernameIndicatorPictureBox.Location = new System.Drawing.Point(240, 13);
			this.UsernameIndicatorPictureBox.Name = "UsernameIndicatorPictureBox";
			this.UsernameIndicatorPictureBox.Size = new System.Drawing.Size(19, 19);
			this.UsernameIndicatorPictureBox.TabIndex = 12;
			this.UsernameIndicatorPictureBox.TabStop = false;
			this.UsernameIndicatorPictureBox.Visible = false;
			// 
			// LogUpPasswordPanel
			// 
			this.LogUpPasswordPanel.BackColor = System.Drawing.Color.White;
			this.LogUpPasswordPanel.Controls.Add(this.LogUpPasswordTextBox);
			this.LogUpPasswordPanel.Controls.Add(this.PasswordIndicatorPictureBox);
			this.LogUpPasswordPanel.Location = new System.Drawing.Point(41, 150);
			this.LogUpPasswordPanel.Name = "LogUpPasswordPanel";
			this.LogUpPasswordPanel.Size = new System.Drawing.Size(270, 44);
			this.LogUpPasswordPanel.TabIndex = 20;
			// 
			// LogUpPasswordTextBox
			// 
			this.LogUpPasswordTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.LogUpPasswordTextBox.Cue = null;
			this.LogUpPasswordTextBox.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
			this.LogUpPasswordTextBox.Location = new System.Drawing.Point(55, 13);
			this.LogUpPasswordTextBox.Name = "LogUpPasswordTextBox";
			this.LogUpPasswordTextBox.ShortcutsEnabled = false;
			this.LogUpPasswordTextBox.Size = new System.Drawing.Size(160, 19);
			this.LogUpPasswordTextBox.TabIndex = 7;
			this.LogUpPasswordTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			this.LogUpPasswordTextBox.UseSystemPasswordChar = true;
			this.LogUpPasswordTextBox.Validated += new System.EventHandler(this.LogUpPasswordTextBox_Validated);
			// 
			// PasswordIndicatorPictureBox
			// 
			this.PasswordIndicatorPictureBox.BackColor = System.Drawing.Color.Transparent;
			this.PasswordIndicatorPictureBox.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
			this.PasswordIndicatorPictureBox.Location = new System.Drawing.Point(240, 13);
			this.PasswordIndicatorPictureBox.Name = "PasswordIndicatorPictureBox";
			this.PasswordIndicatorPictureBox.Size = new System.Drawing.Size(19, 19);
			this.PasswordIndicatorPictureBox.TabIndex = 13;
			this.PasswordIndicatorPictureBox.TabStop = false;
			this.PasswordIndicatorPictureBox.Visible = false;
			// 
			// LogUpButton
			// 
			this.LogUpButton.BackColor = System.Drawing.Color.NavajoWhite;
			this.LogUpButton.FlatAppearance.BorderColor = System.Drawing.Color.NavajoWhite;
			this.LogUpButton.FlatAppearance.BorderSize = 0;
			this.LogUpButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.LogUpButton.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
			this.LogUpButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(43)))), ((int)(((byte)(43)))));
			this.LogUpButton.Location = new System.Drawing.Point(41, 324);
			this.LogUpButton.Name = "LogUpButton";
			this.LogUpButton.Size = new System.Drawing.Size(270, 44);
			this.LogUpButton.TabIndex = 1;
			this.LogUpButton.Text = "注册";
			this.LogUpButton.UseVisualStyleBackColor = false;
			this.LogUpButton.Click += new System.EventHandler(this.LogUpButton_Click);
			// 
			// LogInLabel
			// 
			this.LogInLabel.AutoSize = true;
			this.LogInLabel.BackColor = System.Drawing.Color.Transparent;
			this.LogInLabel.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
			this.LogInLabel.ForeColor = System.Drawing.Color.SaddleBrown;
			this.LogInLabel.Location = new System.Drawing.Point(246, 394);
			this.LogInLabel.Name = "LogInLabel";
			this.LogInLabel.Size = new System.Drawing.Size(65, 19);
			this.LogInLabel.TabIndex = 0;
			this.LogInLabel.Text = "登录账号";
			this.LogInLabel.Click += new System.EventHandler(this.LogInLabel_Click);
			// 
			// LogInPanel
			// 
			this.LogInPanel.Controls.Add(this.PasswordPanel);
			this.LogInPanel.Controls.Add(this.HeadImagePicture);
			this.LogInPanel.Controls.Add(this.LogUpLabel);
			this.LogInPanel.Controls.Add(this.LogInButton);
			this.LogInPanel.Controls.Add(this.AccountPanel);
			this.LogInPanel.Controls.Add(this.LogInClosePicture);
			this.LogInPanel.Controls.Add(this.LogInBackgroundPicture);
			this.LogInPanel.Location = new System.Drawing.Point(0, 0);
			this.LogInPanel.Name = "LogInPanel";
			this.LogInPanel.Size = new System.Drawing.Size(352, 450);
			this.LogInPanel.TabIndex = 13;
			// 
			// HeadImagePicture
			// 
			this.HeadImagePicture.BackColor = System.Drawing.Color.Transparent;
			this.HeadImagePicture.BackgroundImage = global::FakeQQ.Properties.Resources.logo;
			this.HeadImagePicture.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
			this.HeadImagePicture.Location = new System.Drawing.Point(136, 64);
			this.HeadImagePicture.Name = "HeadImagePicture";
			this.HeadImagePicture.Size = new System.Drawing.Size(80, 80);
			this.HeadImagePicture.TabIndex = 2;
			this.HeadImagePicture.TabStop = false;
			// 
			// LogInButton
			// 
			this.LogInButton.BackColor = System.Drawing.Color.NavajoWhite;
			this.LogInButton.FlatAppearance.BorderColor = System.Drawing.Color.NavajoWhite;
			this.LogInButton.FlatAppearance.BorderSize = 0;
			this.LogInButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.LogInButton.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
			this.LogInButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(43)))), ((int)(((byte)(43)))));
			this.LogInButton.Location = new System.Drawing.Point(41, 324);
			this.LogInButton.Name = "LogInButton";
			this.LogInButton.Size = new System.Drawing.Size(270, 44);
			this.LogInButton.TabIndex = 1;
			this.LogInButton.Text = "登录";
			this.LogInButton.UseVisualStyleBackColor = false;
			this.LogInButton.Click += new System.EventHandler(this.LoginButton_Click);
			// 
			// LogInClosePicture
			// 
			this.LogInClosePicture.BackColor = System.Drawing.Color.Transparent;
			this.LogInClosePicture.BackgroundImage = global::FakeQQ.Properties.Resources.Close;
			this.LogInClosePicture.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
			this.LogInClosePicture.Location = new System.Drawing.Point(322, 0);
			this.LogInClosePicture.Name = "LogInClosePicture";
			this.LogInClosePicture.Size = new System.Drawing.Size(30, 30);
			this.LogInClosePicture.TabIndex = 7;
			this.LogInClosePicture.TabStop = false;
			this.LogInClosePicture.Click += new System.EventHandler(this.ClosePicture_Click);
			this.LogInClosePicture.MouseEnter += new System.EventHandler(this.ClosePicture_MouseEnter);
			this.LogInClosePicture.MouseLeave += new System.EventHandler(this.ClosePicture_MouseLeave);
			// 
			// LogInBackgroundPicture
			// 
			this.LogInBackgroundPicture.Dock = System.Windows.Forms.DockStyle.Fill;
			this.LogInBackgroundPicture.Image = global::FakeQQ.Properties.Resources.mainWindowBackground;
			this.LogInBackgroundPicture.Location = new System.Drawing.Point(0, 0);
			this.LogInBackgroundPicture.Name = "LogInBackgroundPicture";
			this.LogInBackgroundPicture.Size = new System.Drawing.Size(352, 450);
			this.LogInBackgroundPicture.TabIndex = 0;
			this.LogInBackgroundPicture.TabStop = false;
			this.LogInBackgroundPicture.MouseDown += new System.Windows.Forms.MouseEventHandler(this.BackgroundPicture_MouseDown);
			this.LogInBackgroundPicture.MouseMove += new System.Windows.Forms.MouseEventHandler(this.BackgroundPicture_MouseMove);
			this.LogInBackgroundPicture.MouseUp += new System.Windows.Forms.MouseEventHandler(this.BackgroundPicture_MouseUp);
			// 
			// LogUpPanel
			// 
			this.LogUpPanel.Controls.Add(this.LogInLabel);
			this.LogUpPanel.Controls.Add(this.LogUpButton);
			this.LogUpPanel.Controls.Add(this.WelcomeLogUpLabel);
			this.LogUpPanel.Controls.Add(this.LogUpUsernamePanel);
			this.LogUpPanel.Controls.Add(this.LogUpPasswordPanel);
			this.LogUpPanel.Controls.Add(this.LogUpCheckPasswordPanel);
			this.LogUpPanel.Controls.Add(this.LogUpPhonePanel);
			this.LogUpPanel.Controls.Add(this.LogUpBackgroundPicture);
			this.LogUpPanel.Controls.Add(this.LogUpClosePicture);
			this.LogUpPanel.Location = new System.Drawing.Point(0, 0);
			this.LogUpPanel.Name = "LogUpPanel";
			this.LogUpPanel.Size = new System.Drawing.Size(352, 450);
			this.LogUpPanel.TabIndex = 0;
			// 
			// WelcomeLogUpLabel
			// 
			this.WelcomeLogUpLabel.AutoSize = true;
			this.WelcomeLogUpLabel.BackColor = System.Drawing.Color.Transparent;
			this.WelcomeLogUpLabel.Font = new System.Drawing.Font("微软雅黑 Light", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
			this.WelcomeLogUpLabel.Location = new System.Drawing.Point(41, 36);
			this.WelcomeLogUpLabel.Name = "WelcomeLogUpLabel";
			this.WelcomeLogUpLabel.Size = new System.Drawing.Size(218, 46);
			this.WelcomeLogUpLabel.TabIndex = 0;
			this.WelcomeLogUpLabel.Text = "欢迎注册QQ";
			// 
			// LogUpCheckPasswordPanel
			// 
			this.LogUpCheckPasswordPanel.BackColor = System.Drawing.Color.White;
			this.LogUpCheckPasswordPanel.Controls.Add(this.CheckPasswordIndicatorPictureBox);
			this.LogUpCheckPasswordPanel.Controls.Add(this.LogUpCheckPasswordTextBox);
			this.LogUpCheckPasswordPanel.Location = new System.Drawing.Point(41, 200);
			this.LogUpCheckPasswordPanel.Name = "LogUpCheckPasswordPanel";
			this.LogUpCheckPasswordPanel.Size = new System.Drawing.Size(270, 44);
			this.LogUpCheckPasswordPanel.TabIndex = 20;
			// 
			// CheckPasswordIndicatorPictureBox
			// 
			this.CheckPasswordIndicatorPictureBox.BackColor = System.Drawing.Color.Transparent;
			this.CheckPasswordIndicatorPictureBox.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
			this.CheckPasswordIndicatorPictureBox.Location = new System.Drawing.Point(240, 13);
			this.CheckPasswordIndicatorPictureBox.Name = "CheckPasswordIndicatorPictureBox";
			this.CheckPasswordIndicatorPictureBox.Size = new System.Drawing.Size(19, 19);
			this.CheckPasswordIndicatorPictureBox.TabIndex = 13;
			this.CheckPasswordIndicatorPictureBox.TabStop = false;
			this.CheckPasswordIndicatorPictureBox.Visible = false;
			// 
			// LogUpCheckPasswordTextBox
			// 
			this.LogUpCheckPasswordTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.LogUpCheckPasswordTextBox.Cue = null;
			this.LogUpCheckPasswordTextBox.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
			this.LogUpCheckPasswordTextBox.Location = new System.Drawing.Point(55, 13);
			this.LogUpCheckPasswordTextBox.Name = "LogUpCheckPasswordTextBox";
			this.LogUpCheckPasswordTextBox.ShortcutsEnabled = false;
			this.LogUpCheckPasswordTextBox.Size = new System.Drawing.Size(160, 19);
			this.LogUpCheckPasswordTextBox.TabIndex = 8;
			this.LogUpCheckPasswordTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			this.LogUpCheckPasswordTextBox.UseSystemPasswordChar = true;
			this.LogUpCheckPasswordTextBox.Validated += new System.EventHandler(this.LogUpCheckPasswordTextBox_Validated);
			// 
			// LogUpBackgroundPicture
			// 
			this.LogUpBackgroundPicture.Dock = System.Windows.Forms.DockStyle.Fill;
			this.LogUpBackgroundPicture.Image = global::FakeQQ.Properties.Resources.mainWindowBackground;
			this.LogUpBackgroundPicture.Location = new System.Drawing.Point(0, 0);
			this.LogUpBackgroundPicture.Name = "LogUpBackgroundPicture";
			this.LogUpBackgroundPicture.Size = new System.Drawing.Size(352, 450);
			this.LogUpBackgroundPicture.TabIndex = 13;
			this.LogUpBackgroundPicture.TabStop = false;
			this.LogUpBackgroundPicture.MouseDown += new System.Windows.Forms.MouseEventHandler(this.BackgroundPicture_MouseDown);
			this.LogUpBackgroundPicture.MouseMove += new System.Windows.Forms.MouseEventHandler(this.BackgroundPicture_MouseMove);
			this.LogUpBackgroundPicture.MouseUp += new System.Windows.Forms.MouseEventHandler(this.BackgroundPicture_MouseUp);
			// 
			// LogUpClosePicture
			// 
			this.LogUpClosePicture.BackColor = System.Drawing.Color.Transparent;
			this.LogUpClosePicture.BackgroundImage = global::FakeQQ.Properties.Resources.Close;
			this.LogUpClosePicture.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
			this.LogUpClosePicture.Location = new System.Drawing.Point(322, 0);
			this.LogUpClosePicture.Name = "LogUpClosePicture";
			this.LogUpClosePicture.Size = new System.Drawing.Size(30, 30);
			this.LogUpClosePicture.TabIndex = 14;
			this.LogUpClosePicture.TabStop = false;
			this.LogUpClosePicture.Click += new System.EventHandler(this.ClosePicture_Click);
			this.LogUpClosePicture.MouseEnter += new System.EventHandler(this.ClosePicture_MouseEnter);
			this.LogUpClosePicture.MouseLeave += new System.EventHandler(this.ClosePicture_MouseLeave);
			// 
			// MonitorLogInTextBoxTimer
			// 
			this.MonitorLogInTextBoxTimer.Enabled = true;
			this.MonitorLogInTextBoxTimer.Tick += new System.EventHandler(this.MonitorTextBoxTimer_Tick);
			// 
			// FocusedTimer
			// 
			this.FocusedTimer.Enabled = true;
			this.FocusedTimer.Tick += new System.EventHandler(this.FocusedTimer_Tick);
			// 
			// MonitorLogUpTextBoxTimer
			// 
			this.MonitorLogUpTextBoxTimer.Enabled = true;
			this.MonitorLogUpTextBoxTimer.Tick += new System.EventHandler(this.MonitorLogUpTextBoxTimer_Tick);
			// 
			// LogForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
			this.ClientSize = new System.Drawing.Size(352, 450);
			this.Controls.Add(this.LogInPanel);
			this.Controls.Add(this.LogUpPanel);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.Name = "LogForm";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Load += new System.EventHandler(this.MainWindow_Load);
			this.AccountPanel.ResumeLayout(false);
			this.AccountPanel.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.AccountClosePicture)).EndInit();
			this.PasswordPanel.ResumeLayout(false);
			this.PasswordPanel.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.PasswordClosePicture)).EndInit();
			this.LogUpPhonePanel.ResumeLayout(false);
			this.LogUpPhonePanel.PerformLayout();
			this.LogUpUsernamePanel.ResumeLayout(false);
			this.LogUpUsernamePanel.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.UsernameIndicatorPictureBox)).EndInit();
			this.LogUpPasswordPanel.ResumeLayout(false);
			this.LogUpPasswordPanel.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.PasswordIndicatorPictureBox)).EndInit();
			this.LogInPanel.ResumeLayout(false);
			this.LogInPanel.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.HeadImagePicture)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.LogInClosePicture)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.LogInBackgroundPicture)).EndInit();
			this.LogUpPanel.ResumeLayout(false);
			this.LogUpPanel.PerformLayout();
			this.LogUpCheckPasswordPanel.ResumeLayout(false);
			this.LogUpCheckPasswordPanel.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.CheckPasswordIndicatorPictureBox)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.LogUpBackgroundPicture)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.LogUpClosePicture)).EndInit();
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.PictureBox LogInBackgroundPicture;
		private OvalPictureBox HeadImagePicture;
		private CueTextBox AccountTextBox;
		private CueTextBox PasswordTextBox;
		private System.Windows.Forms.PictureBox LogInClosePicture;
		private System.Windows.Forms.Panel AccountPanel;
		private System.Windows.Forms.Panel PasswordPanel;
		private System.Windows.Forms.PictureBox AccountClosePicture;
		private System.Windows.Forms.PictureBox PasswordClosePicture;
		private System.Windows.Forms.Label LogUpLabel;
		private System.Windows.Forms.Panel LogUpUsernamePanel;
		private System.Windows.Forms.Panel LogUpPasswordPanel;
		private CueTextBox LogUpUsernameTextBox;
		private CueTextBox LogUpPasswordTextBox;
		private System.Windows.Forms.Button LogUpButton;
		private System.Windows.Forms.Panel LogUpPhonePanel;
		private CueTextBox LogUpPhoneTextBox;
		private System.Windows.Forms.Label LogInLabel;
		private System.Windows.Forms.Panel LogInPanel;
		private System.Windows.Forms.Panel LogUpPanel;
		private System.Windows.Forms.PictureBox LogUpBackgroundPicture;
		private System.Windows.Forms.PictureBox LogUpClosePicture;
		private System.Windows.Forms.Label WelcomeLogUpLabel;
		private System.Windows.Forms.Button LogInButton;
		private System.Windows.Forms.Timer MonitorLogInTextBoxTimer;
		private System.Windows.Forms.Timer FocusedTimer;
		private System.Windows.Forms.Panel LogUpCheckPasswordPanel;
		private CueTextBox LogUpCheckPasswordTextBox;
		private System.Windows.Forms.Timer MonitorLogUpTextBoxTimer;
		private System.Windows.Forms.PictureBox UsernameIndicatorPictureBox;
		private System.Windows.Forms.PictureBox PasswordIndicatorPictureBox;
		private System.Windows.Forms.PictureBox CheckPasswordIndicatorPictureBox;
	}
}

