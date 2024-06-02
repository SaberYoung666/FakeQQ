namespace FakeQQ
{
    partial class ChatForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ChatForm));
			this.navigation_bar = new System.Windows.Forms.Panel();
			this.picture_close = new System.Windows.Forms.PictureBox();
			this.picture_minus = new System.Windows.Forms.PictureBox();
			this.username = new System.Windows.Forms.Label();
			this.menu = new System.Windows.Forms.Panel();
			this.picture_image = new System.Windows.Forms.PictureBox();
			this.picture_doc = new System.Windows.Forms.PictureBox();
			this.picture_emoji = new System.Windows.Forms.PictureBox();
			this.btn_send = new System.Windows.Forms.Button();
			this.btn_close = new System.Windows.Forms.Button();
			this.richTextBox_content = new System.Windows.Forms.RichTextBox();
			this.messageArea = new System.Windows.Forms.Panel();
			this.QQEmojiArea = new System.Windows.Forms.Panel();
			this.navigation_bar.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.picture_close)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.picture_minus)).BeginInit();
			this.menu.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.picture_image)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.picture_doc)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.picture_emoji)).BeginInit();
			this.messageArea.SuspendLayout();
			this.SuspendLayout();
			// 
			// navigation_bar
			// 
			this.navigation_bar.AutoScroll = true;
			this.navigation_bar.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.navigation_bar.Controls.Add(this.picture_close);
			this.navigation_bar.Controls.Add(this.picture_minus);
			this.navigation_bar.Controls.Add(this.username);
			this.navigation_bar.Dock = System.Windows.Forms.DockStyle.Top;
			this.navigation_bar.Location = new System.Drawing.Point(0, 0);
			this.navigation_bar.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
			this.navigation_bar.Name = "navigation_bar";
			this.navigation_bar.Size = new System.Drawing.Size(686, 39);
			this.navigation_bar.TabIndex = 0;
			this.navigation_bar.MouseDown += new System.Windows.Forms.MouseEventHandler(this.navigation_bar_MouseDown);
			this.navigation_bar.MouseMove += new System.Windows.Forms.MouseEventHandler(this.navigation_bar_MouseMove);
			this.navigation_bar.MouseUp += new System.Windows.Forms.MouseEventHandler(this.navigation_bar_MouseUp);
			// 
			// picture_close
			// 
			this.picture_close.Image = global::FakeQQ.Properties.Resources.icon_close;
			this.picture_close.Location = new System.Drawing.Point(637, 3);
			this.picture_close.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
			this.picture_close.Name = "picture_close";
			this.picture_close.Size = new System.Drawing.Size(22, 24);
			this.picture_close.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
			this.picture_close.TabIndex = 3;
			this.picture_close.TabStop = false;
			this.picture_close.Click += new System.EventHandler(this.picture_close_Click);
			this.picture_close.MouseLeave += new System.EventHandler(this.picture_close_MouseLeave);
			this.picture_close.MouseMove += new System.Windows.Forms.MouseEventHandler(this.picture_close_MouseMove);
			// 
			// picture_minus
			// 
			this.picture_minus.Image = global::FakeQQ.Properties.Resources.Icon_minus;
			this.picture_minus.Location = new System.Drawing.Point(590, 3);
			this.picture_minus.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
			this.picture_minus.Name = "picture_minus";
			this.picture_minus.Size = new System.Drawing.Size(22, 24);
			this.picture_minus.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
			this.picture_minus.TabIndex = 2;
			this.picture_minus.TabStop = false;
			this.picture_minus.Click += new System.EventHandler(this.picture_minus_Click);
			this.picture_minus.MouseLeave += new System.EventHandler(this.picture_minus_MouseLeave);
			this.picture_minus.MouseMove += new System.Windows.Forms.MouseEventHandler(this.picture_minus_MouseMove);
			// 
			// username
			// 
			this.username.AutoSize = true;
			this.username.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
			this.username.Location = new System.Drawing.Point(13, 11);
			this.username.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
			this.username.Name = "username";
			this.username.Size = new System.Drawing.Size(85, 21);
			this.username.TabIndex = 0;
			this.username.Text = "username";
			// 
			// menu
			// 
			this.menu.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.menu.Controls.Add(this.picture_image);
			this.menu.Controls.Add(this.picture_doc);
			this.menu.Controls.Add(this.picture_emoji);
			this.menu.Controls.Add(this.btn_send);
			this.menu.Controls.Add(this.btn_close);
			this.menu.Controls.Add(this.richTextBox_content);
			this.menu.Dock = System.Windows.Forms.DockStyle.Bottom;
			this.menu.Location = new System.Drawing.Point(0, 339);
			this.menu.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
			this.menu.Name = "menu";
			this.menu.Size = new System.Drawing.Size(686, 191);
			this.menu.TabIndex = 1;
			// 
			// picture_image
			// 
			this.picture_image.Image = global::FakeQQ.Properties.Resources.icon_image;
			this.picture_image.Location = new System.Drawing.Point(98, 2);
			this.picture_image.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
			this.picture_image.Name = "picture_image";
			this.picture_image.Size = new System.Drawing.Size(22, 24);
			this.picture_image.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
			this.picture_image.TabIndex = 2;
			this.picture_image.TabStop = false;
			this.picture_image.Click += new System.EventHandler(this.picture_image_Click);
			// 
			// picture_doc
			// 
			this.picture_doc.Image = global::FakeQQ.Properties.Resources.icon_doc;
			this.picture_doc.Location = new System.Drawing.Point(56, 2);
			this.picture_doc.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
			this.picture_doc.Name = "picture_doc";
			this.picture_doc.Size = new System.Drawing.Size(22, 24);
			this.picture_doc.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
			this.picture_doc.TabIndex = 4;
			this.picture_doc.TabStop = false;
			this.picture_doc.Click += new System.EventHandler(this.picture_doc_Click);
			// 
			// picture_emoji
			// 
			this.picture_emoji.Image = global::FakeQQ.Properties.Resources.icon_emoji;
			this.picture_emoji.Location = new System.Drawing.Point(15, 2);
			this.picture_emoji.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
			this.picture_emoji.Name = "picture_emoji";
			this.picture_emoji.Size = new System.Drawing.Size(22, 24);
			this.picture_emoji.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
			this.picture_emoji.TabIndex = 5;
			this.picture_emoji.TabStop = false;
			this.picture_emoji.Click += new System.EventHandler(this.picture_emoji_Click);
			// 
			// btn_send
			// 
			this.btn_send.Enabled = false;
			this.btn_send.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
			this.btn_send.Location = new System.Drawing.Point(603, 148);
			this.btn_send.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
			this.btn_send.Name = "btn_send";
			this.btn_send.Size = new System.Drawing.Size(56, 28);
			this.btn_send.TabIndex = 2;
			this.btn_send.Text = "发送";
			this.btn_send.UseVisualStyleBackColor = true;
			this.btn_send.Click += new System.EventHandler(this.btn_send_Click);
			// 
			// btn_close
			// 
			this.btn_close.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
			this.btn_close.Location = new System.Drawing.Point(521, 148);
			this.btn_close.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
			this.btn_close.Name = "btn_close";
			this.btn_close.Size = new System.Drawing.Size(56, 28);
			this.btn_close.TabIndex = 1;
			this.btn_close.Text = "关闭";
			this.btn_close.UseVisualStyleBackColor = true;
			this.btn_close.Click += new System.EventHandler(this.btn_close_Click);
			// 
			// richTextBox_content
			// 
			this.richTextBox_content.BackColor = System.Drawing.SystemColors.Control;
			this.richTextBox_content.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.richTextBox_content.Dock = System.Windows.Forms.DockStyle.Bottom;
			this.richTextBox_content.EnableAutoDragDrop = true;
			this.richTextBox_content.Location = new System.Drawing.Point(0, 27);
			this.richTextBox_content.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
			this.richTextBox_content.Name = "richTextBox_content";
			this.richTextBox_content.Size = new System.Drawing.Size(684, 162);
			this.richTextBox_content.TabIndex = 3;
			this.richTextBox_content.Text = "";
			this.richTextBox_content.TextChanged += new System.EventHandler(this.richTextBox_content_TextChanged);
			this.richTextBox_content.ControlAdded += new System.Windows.Forms.ControlEventHandler(this.richTextBox_content_ControlAdded);
			// 
			// messageArea
			// 
			this.messageArea.AutoScroll = true;
			this.messageArea.Controls.Add(this.QQEmojiArea);
			this.messageArea.Dock = System.Windows.Forms.DockStyle.Fill;
			this.messageArea.Location = new System.Drawing.Point(0, 39);
			this.messageArea.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
			this.messageArea.Name = "messageArea";
			this.messageArea.Size = new System.Drawing.Size(686, 300);
			this.messageArea.TabIndex = 2;
			// 
			// QQEmojiArea
			// 
			this.QQEmojiArea.AutoScroll = true;
			this.QQEmojiArea.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.QQEmojiArea.Location = new System.Drawing.Point(16, 57);
			this.QQEmojiArea.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
			this.QQEmojiArea.Name = "QQEmojiArea";
			this.QQEmojiArea.Size = new System.Drawing.Size(300, 240);
			this.QQEmojiArea.TabIndex = 4;
			this.QQEmojiArea.Visible = false;
			// 
			// ChatForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(686, 530);
			this.Controls.Add(this.messageArea);
			this.Controls.Add(this.menu);
			this.Controls.Add(this.navigation_bar);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
			this.Name = "ChatForm";
			this.Text = "ChatForm";
			this.Load += new System.EventHandler(this.ChatForm_Load);
			this.navigation_bar.ResumeLayout(false);
			this.navigation_bar.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.picture_close)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.picture_minus)).EndInit();
			this.menu.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.picture_image)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.picture_doc)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.picture_emoji)).EndInit();
			this.messageArea.ResumeLayout(false);
			this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel navigation_bar;
        private System.Windows.Forms.Label username;
        private System.Windows.Forms.Panel menu;
        private System.Windows.Forms.Button btn_send;
        private System.Windows.Forms.Button btn_close;
        private System.Windows.Forms.RichTextBox richTextBox_content;
        private System.Windows.Forms.Panel messageArea;
        private System.Windows.Forms.PictureBox picture_close;
        private System.Windows.Forms.PictureBox picture_minus;
        private System.Windows.Forms.PictureBox picture_image;
        private System.Windows.Forms.PictureBox picture_doc;
        private System.Windows.Forms.PictureBox picture_emoji;
        private System.Windows.Forms.Panel QQEmojiArea;
    }
}