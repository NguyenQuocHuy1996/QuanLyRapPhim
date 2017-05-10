namespace Review
{
    partial class FormChinh
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormChinh));
            this.btnLogin = new System.Windows.Forms.Button();
            this.btnRegister = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.cbTenPhim = new System.Windows.Forms.ComboBox();
            this.cbNgayChieu = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btnDepositTicket = new System.Windows.Forms.Button();
            this.axWindowsMediaPlayer1 = new AxWMPLib.AxWindowsMediaPlayer();
            this.lbUser = new System.Windows.Forms.Label();
            this.btnLogOut = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.axWindowsMediaPlayer1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnLogin
            // 
            this.btnLogin.Location = new System.Drawing.Point(1184, 12);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Size = new System.Drawing.Size(76, 27);
            this.btnLogin.TabIndex = 4;
            this.btnLogin.Text = "Đăng nhập";
            this.btnLogin.UseVisualStyleBackColor = true;
            this.btnLogin.Click += new System.EventHandler(this.btnLogin_Click);
            // 
            // btnRegister
            // 
            this.btnRegister.Location = new System.Drawing.Point(1266, 12);
            this.btnRegister.Name = "btnRegister";
            this.btnRegister.Size = new System.Drawing.Size(76, 27);
            this.btnRegister.TabIndex = 5;
            this.btnRegister.Text = "Đăng ký";
            this.btnRegister.UseVisualStyleBackColor = true;
            this.btnRegister.Click += new System.EventHandler(this.btnRegister_Click);
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.label1.Location = new System.Drawing.Point(932, 545);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(247, 23);
            this.label1.TabIndex = 0;
            this.label1.Text = "Lựa chọn phim";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // cbTenPhim
            // 
            this.cbTenPhim.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbTenPhim.FormattingEnabled = true;
            this.cbTenPhim.Location = new System.Drawing.Point(1017, 578);
            this.cbTenPhim.Name = "cbTenPhim";
            this.cbTenPhim.Size = new System.Drawing.Size(304, 21);
            this.cbTenPhim.TabIndex = 6;
            this.cbTenPhim.SelectedIndexChanged += new System.EventHandler(this.cbTenPhim_SelectedIndexChanged);
            // 
            // cbNgayChieu
            // 
            this.cbNgayChieu.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbNgayChieu.FormattingEnabled = true;
            this.cbNgayChieu.Location = new System.Drawing.Point(1017, 605);
            this.cbNgayChieu.Name = "cbNgayChieu";
            this.cbNgayChieu.Size = new System.Drawing.Size(121, 21);
            this.cbNgayChieu.TabIndex = 7;
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.label2.Location = new System.Drawing.Point(920, 576);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(91, 23);
            this.label2.TabIndex = 8;
            this.label2.Text = "Tên phim:";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label3
            // 
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.label3.Location = new System.Drawing.Point(920, 603);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(91, 23);
            this.label3.TabIndex = 9;
            this.label3.Text = "Ngạy chiếu:";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // btnDepositTicket
            // 
            this.btnDepositTicket.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDepositTicket.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btnDepositTicket.Location = new System.Drawing.Point(1017, 632);
            this.btnDepositTicket.Name = "btnDepositTicket";
            this.btnDepositTicket.Size = new System.Drawing.Size(75, 23);
            this.btnDepositTicket.TabIndex = 10;
            this.btnDepositTicket.Text = "Đặt vé";
            this.btnDepositTicket.UseVisualStyleBackColor = true;
            this.btnDepositTicket.Click += new System.EventHandler(this.btnDepositTicket_Click);
            // 
            // axWindowsMediaPlayer1
            // 
            this.axWindowsMediaPlayer1.Enabled = true;
            this.axWindowsMediaPlayer1.Location = new System.Drawing.Point(356, 90);
            this.axWindowsMediaPlayer1.Name = "axWindowsMediaPlayer1";
            this.axWindowsMediaPlayer1.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("axWindowsMediaPlayer1.OcxState")));
            this.axWindowsMediaPlayer1.Size = new System.Drawing.Size(655, 426);
            this.axWindowsMediaPlayer1.TabIndex = 11;
            // 
            // lbUser
            // 
            this.lbUser.BackColor = System.Drawing.Color.Transparent;
            this.lbUser.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbUser.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.lbUser.Location = new System.Drawing.Point(1096, 12);
            this.lbUser.Name = "lbUser";
            this.lbUser.Size = new System.Drawing.Size(164, 27);
            this.lbUser.TabIndex = 12;
            this.lbUser.Text = "Xin chào";
            this.lbUser.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.lbUser.Visible = false;
            // 
            // btnLogOut
            // 
            this.btnLogOut.Location = new System.Drawing.Point(1267, 12);
            this.btnLogOut.Name = "btnLogOut";
            this.btnLogOut.Size = new System.Drawing.Size(75, 27);
            this.btnLogOut.TabIndex = 13;
            this.btnLogOut.Text = "Đăng xuất";
            this.btnLogOut.UseVisualStyleBackColor = true;
            this.btnLogOut.Click += new System.EventHandler(this.btnLogOut_Click);
            // 
            // FormChinh
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Review.Properties.Resources.RapPhim;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1350, 692);
            this.Controls.Add(this.btnLogOut);
            this.Controls.Add(this.lbUser);
            this.Controls.Add(this.axWindowsMediaPlayer1);
            this.Controls.Add(this.btnDepositTicket);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cbNgayChieu);
            this.Controls.Add(this.cbTenPhim);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnRegister);
            this.Controls.Add(this.btnLogin);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Name = "FormChinh";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Quản lý rạp phim";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FormChinh_FormClosing);
            this.Load += new System.EventHandler(this.FormChinh_Load);
            ((System.ComponentModel.ISupportInitialize)(this.axWindowsMediaPlayer1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button btnLogin;
        private System.Windows.Forms.Button btnRegister;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cbTenPhim;
        private System.Windows.Forms.ComboBox cbNgayChieu;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnDepositTicket;
        private AxWMPLib.AxWindowsMediaPlayer axWindowsMediaPlayer1;
        private System.Windows.Forms.Label lbUser;
        private System.Windows.Forms.Button btnLogOut;
    }
}