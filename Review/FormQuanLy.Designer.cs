namespace Review
{
    partial class FormQuanLy
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
            this.lbuser = new System.Windows.Forms.Label();
            this.btnRapPhim = new System.Windows.Forms.Button();
            this.btnPhongChieu = new System.Windows.Forms.Button();
            this.btnPhim = new System.Windows.Forms.Button();
            this.btnLichChieu = new System.Windows.Forms.Button();
            this.btnNhanVien = new System.Windows.Forms.Button();
            this.btnBaoCao = new System.Windows.Forms.Button();
            this.btnDangXuat = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lbuser
            // 
            this.lbuser.Location = new System.Drawing.Point(1157, 12);
            this.lbuser.Name = "lbuser";
            this.lbuser.Size = new System.Drawing.Size(100, 23);
            this.lbuser.TabIndex = 15;
            this.lbuser.Text = "Xin chào";
            this.lbuser.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnRapPhim
            // 
            this.btnRapPhim.BackColor = System.Drawing.Color.White;
            this.btnRapPhim.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRapPhim.Image = global::Review.Properties.Resources.IconRapPhim;
            this.btnRapPhim.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnRapPhim.Location = new System.Drawing.Point(12, 12);
            this.btnRapPhim.Name = "btnRapPhim";
            this.btnRapPhim.Size = new System.Drawing.Size(170, 50);
            this.btnRapPhim.TabIndex = 8;
            this.btnRapPhim.Text = "Quản lý rạp phim";
            this.btnRapPhim.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnRapPhim.UseVisualStyleBackColor = false;
            this.btnRapPhim.Click += new System.EventHandler(this.btnRapPhim_Click);
            // 
            // btnPhongChieu
            // 
            this.btnPhongChieu.BackColor = System.Drawing.Color.White;
            this.btnPhongChieu.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPhongChieu.Image = global::Review.Properties.Resources.IconPhongChieu;
            this.btnPhongChieu.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnPhongChieu.Location = new System.Drawing.Point(12, 68);
            this.btnPhongChieu.Name = "btnPhongChieu";
            this.btnPhongChieu.Size = new System.Drawing.Size(170, 50);
            this.btnPhongChieu.TabIndex = 9;
            this.btnPhongChieu.Text = "Quản lý phòng chiếu";
            this.btnPhongChieu.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnPhongChieu.UseVisualStyleBackColor = false;
            this.btnPhongChieu.Click += new System.EventHandler(this.btnPhongChieu_Click);
            // 
            // btnPhim
            // 
            this.btnPhim.AllowDrop = true;
            this.btnPhim.BackColor = System.Drawing.Color.White;
            this.btnPhim.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPhim.Image = global::Review.Properties.Resources.IconPhim1;
            this.btnPhim.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnPhim.Location = new System.Drawing.Point(12, 124);
            this.btnPhim.Name = "btnPhim";
            this.btnPhim.Size = new System.Drawing.Size(170, 50);
            this.btnPhim.TabIndex = 10;
            this.btnPhim.Text = "Quản lý phim";
            this.btnPhim.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnPhim.UseVisualStyleBackColor = false;
            this.btnPhim.Click += new System.EventHandler(this.btnPhim_Click);
            // 
            // btnLichChieu
            // 
            this.btnLichChieu.BackColor = System.Drawing.Color.White;
            this.btnLichChieu.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLichChieu.Image = global::Review.Properties.Resources.IconLichChieu;
            this.btnLichChieu.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnLichChieu.Location = new System.Drawing.Point(12, 180);
            this.btnLichChieu.Name = "btnLichChieu";
            this.btnLichChieu.Size = new System.Drawing.Size(170, 50);
            this.btnLichChieu.TabIndex = 11;
            this.btnLichChieu.Text = "Quản lý lịch chiếu";
            this.btnLichChieu.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnLichChieu.UseVisualStyleBackColor = false;
            this.btnLichChieu.Click += new System.EventHandler(this.btnLichChieu_Click);
            // 
            // btnNhanVien
            // 
            this.btnNhanVien.BackColor = System.Drawing.Color.White;
            this.btnNhanVien.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNhanVien.Image = global::Review.Properties.Resources.IconNhanVien;
            this.btnNhanVien.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnNhanVien.Location = new System.Drawing.Point(12, 236);
            this.btnNhanVien.Name = "btnNhanVien";
            this.btnNhanVien.Size = new System.Drawing.Size(170, 50);
            this.btnNhanVien.TabIndex = 12;
            this.btnNhanVien.Text = "Quản lý nhân viên";
            this.btnNhanVien.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnNhanVien.UseVisualStyleBackColor = false;
            this.btnNhanVien.Click += new System.EventHandler(this.btnNhanVien_Click);
            // 
            // btnBaoCao
            // 
            this.btnBaoCao.BackColor = System.Drawing.Color.White;
            this.btnBaoCao.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBaoCao.Image = global::Review.Properties.Resources.IconBaoCao;
            this.btnBaoCao.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnBaoCao.Location = new System.Drawing.Point(12, 292);
            this.btnBaoCao.Name = "btnBaoCao";
            this.btnBaoCao.Size = new System.Drawing.Size(170, 50);
            this.btnBaoCao.TabIndex = 13;
            this.btnBaoCao.Text = "Báo cáo";
            this.btnBaoCao.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnBaoCao.UseVisualStyleBackColor = false;
            this.btnBaoCao.Click += new System.EventHandler(this.btnBaoCao_Click);
            // 
            // btnDangXuat
            // 
            this.btnDangXuat.Location = new System.Drawing.Point(1263, 8);
            this.btnDangXuat.Name = "btnDangXuat";
            this.btnDangXuat.Size = new System.Drawing.Size(75, 30);
            this.btnDangXuat.TabIndex = 14;
            this.btnDangXuat.Text = "Đăng xuất";
            this.btnDangXuat.UseVisualStyleBackColor = true;
            // 
            // FormQuanLy
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Review.Properties.Resources.FormQuanLy;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1350, 692);
            this.Controls.Add(this.btnDangXuat);
            this.Controls.Add(this.btnBaoCao);
            this.Controls.Add(this.btnNhanVien);
            this.Controls.Add(this.btnLichChieu);
            this.Controls.Add(this.btnPhim);
            this.Controls.Add(this.btnPhongChieu);
            this.Controls.Add(this.btnRapPhim);
            this.Controls.Add(this.lbuser);
            this.Name = "FormQuanLy";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormQuanLy";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FormQuanLy_FormClosing);
            this.Load += new System.EventHandler(this.FormQuanLy_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lbuser;
        private System.Windows.Forms.Button btnRapPhim;
        private System.Windows.Forms.Button btnPhongChieu;
        private System.Windows.Forms.Button btnPhim;
        private System.Windows.Forms.Button btnLichChieu;
        private System.Windows.Forms.Button btnNhanVien;
        private System.Windows.Forms.Button btnBaoCao;
        private System.Windows.Forms.Button btnDangXuat;
    }
}