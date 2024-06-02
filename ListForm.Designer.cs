namespace FakeQQ
{
    partial class ListForm
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
			this.components = new System.ComponentModel.Container();
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ListForm));
			this.userName = new System.Windows.Forms.Label();
			this.signature = new System.Windows.Forms.Label();
			this.imageList1 = new System.Windows.Forms.ImageList(this.components);
			this.picture_qqicon = new System.Windows.Forms.PictureBox();
			this.picture_minus = new System.Windows.Forms.PictureBox();
			this.picture_close = new System.Windows.Forms.PictureBox();
			this.avatar = new OvalPictureBox();
			((System.ComponentModel.ISupportInitialize)(this.picture_qqicon)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.picture_minus)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.picture_close)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.avatar)).BeginInit();
			this.SuspendLayout();
			// 
			// userName
			// 
			this.userName.AutoSize = true;
			this.userName.BackColor = System.Drawing.Color.Transparent;
			this.userName.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
			this.userName.Location = new System.Drawing.Point(74, 73);
			this.userName.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
			this.userName.Name = "userName";
			this.userName.Size = new System.Drawing.Size(68, 17);
			this.userName.TabIndex = 1;
			this.userName.Text = "userName";
			// 
			// signature
			// 
			this.signature.AutoEllipsis = true;
			this.signature.BackColor = System.Drawing.Color.Transparent;
			this.signature.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
			this.signature.Location = new System.Drawing.Point(74, 94);
			this.signature.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
			this.signature.Name = "signature";
			this.signature.Size = new System.Drawing.Size(180, 16);
			this.signature.TabIndex = 3;
			this.signature.Text = "如果看到前面的阴影，别害怕，那是因为你的背后有阳光。";
			// 
			// imageList1
			// 
			this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
			this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
			this.imageList1.Images.SetKeyName(0, "OIP-C (2).jpg");
			this.imageList1.Images.SetKeyName(1, "OIP-C (3).jpg");
			this.imageList1.Images.SetKeyName(2, "下载 (1).jpg");
			this.imageList1.Images.SetKeyName(3, "下载.jpg");
			this.imageList1.Images.SetKeyName(4, "OIP-C.jpg");
			// 
			// picture_qqicon
			// 
			this.picture_qqicon.BackColor = System.Drawing.Color.Transparent;
			this.picture_qqicon.Image = global::FakeQQ.Properties.Resources.iconqq;
			this.picture_qqicon.Location = new System.Drawing.Point(9, 19);
			this.picture_qqicon.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
			this.picture_qqicon.Name = "picture_qqicon";
			this.picture_qqicon.Size = new System.Drawing.Size(19, 20);
			this.picture_qqicon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
			this.picture_qqicon.TabIndex = 4;
			this.picture_qqicon.TabStop = false;
			// 
			// picture_minus
			// 
			this.picture_minus.BackColor = System.Drawing.Color.Transparent;
			this.picture_minus.Image = global::FakeQQ.Properties.Resources.minus;
			this.picture_minus.Location = new System.Drawing.Point(219, 19);
			this.picture_minus.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
			this.picture_minus.Name = "picture_minus";
			this.picture_minus.Size = new System.Drawing.Size(19, 20);
			this.picture_minus.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
			this.picture_minus.TabIndex = 5;
			this.picture_minus.TabStop = false;
			this.picture_minus.Click += new System.EventHandler(this.picture_minus_Click);
			this.picture_minus.MouseLeave += new System.EventHandler(this.picture_minus_MouseLeave);
			this.picture_minus.MouseMove += new System.Windows.Forms.MouseEventHandler(this.picture_minus_MouseMove);
			// 
			// picture_close
			// 
			this.picture_close.BackColor = System.Drawing.Color.Transparent;
			this.picture_close.Image = global::FakeQQ.Properties.Resources.listclose;
			this.picture_close.Location = new System.Drawing.Point(250, 19);
			this.picture_close.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
			this.picture_close.Name = "picture_close";
			this.picture_close.Size = new System.Drawing.Size(19, 20);
			this.picture_close.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
			this.picture_close.TabIndex = 6;
			this.picture_close.TabStop = false;
			this.picture_close.Click += new System.EventHandler(this.picture_close_Click);
			this.picture_close.MouseLeave += new System.EventHandler(this.picture_close_MouseLeave);
			this.picture_close.MouseMove += new System.Windows.Forms.MouseEventHandler(this.picture_close_MouseMove);
			// 
			// avatar
			// 
			this.avatar.BackColor = System.Drawing.Color.Transparent;
			this.avatar.BackgroundImage = global::FakeQQ.Properties.Resources.logo;
			this.avatar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
			this.avatar.Location = new System.Drawing.Point(9, 58);
			this.avatar.Name = "avatar";
			this.avatar.Size = new System.Drawing.Size(60, 60);
			this.avatar.TabIndex = 7;
			this.avatar.TabStop = false;
			// 
			// ListForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
			this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
			this.ClientSize = new System.Drawing.Size(286, 513);
			this.Controls.Add(this.avatar);
			this.Controls.Add(this.picture_close);
			this.Controls.Add(this.picture_minus);
			this.Controls.Add(this.picture_qqicon);
			this.Controls.Add(this.signature);
			this.Controls.Add(this.userName);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
			this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
			this.Name = "ListForm";
			this.Text = "ListForm";
			this.Load += new System.EventHandler(this.ListForm_Load);
			this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.ListForm_MouseDown);
			this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.ListForm_MouseMove);
			this.MouseUp += new System.Windows.Forms.MouseEventHandler(this.ListForm_MouseUp);
			((System.ComponentModel.ISupportInitialize)(this.picture_qqicon)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.picture_minus)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.picture_close)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.avatar)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label userName;
        private System.Windows.Forms.Label signature;
        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.PictureBox picture_qqicon;
        private System.Windows.Forms.PictureBox picture_minus;
        private System.Windows.Forms.PictureBox picture_close;
		private OvalPictureBox avatar;
	}
}