namespace Review
{
    partial class QuanLyPhim
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
            this.dgvPhim = new System.Windows.Forms.DataGridView();
            this.txtTenPhim = new System.Windows.Forms.TextBox();
            this.txtDaoDien = new System.Windows.Forms.TextBox();
            this.txtNam = new System.Windows.Forms.TextBox();
            this.txtThoiLuong = new System.Windows.Forms.TextBox();
            this.txtQuocGia = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.txtHinhAnh = new System.Windows.Forms.TextBox();
            this.btnChonAnh = new System.Windows.Forms.Button();
            this.btnXoa = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtMaPhim = new System.Windows.Forms.TextBox();
            this.btnClear = new System.Windows.Forms.Button();
            this.cbTheLoai = new System.Windows.Forms.ComboBox();
            this.btnClose = new System.Windows.Forms.Button();
            this.btnThem = new System.Windows.Forms.Button();
            this.btnSua = new System.Windows.Forms.Button();
            this.picImage = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPhim)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picImage)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvPhim
            // 
            this.dgvPhim.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvPhim.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCellsExceptHeaders;
            this.dgvPhim.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dgvPhim.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPhim.Dock = System.Windows.Forms.DockStyle.Right;
            this.dgvPhim.Location = new System.Drawing.Point(471, 0);
            this.dgvPhim.Name = "dgvPhim";
            this.dgvPhim.Size = new System.Drawing.Size(723, 572);
            this.dgvPhim.TabIndex = 6;
            this.dgvPhim.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvPhim_CellClick);
            this.dgvPhim.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvPhim_CellContentClick);
            // 
            // txtTenPhim
            // 
            this.txtTenPhim.Location = new System.Drawing.Point(97, 42);
            this.txtTenPhim.Name = "txtTenPhim";
            this.txtTenPhim.Size = new System.Drawing.Size(347, 20);
            this.txtTenPhim.TabIndex = 1;
            // 
            // txtDaoDien
            // 
            this.txtDaoDien.Location = new System.Drawing.Point(97, 64);
            this.txtDaoDien.Name = "txtDaoDien";
            this.txtDaoDien.Size = new System.Drawing.Size(155, 20);
            this.txtDaoDien.TabIndex = 2;
            // 
            // txtNam
            // 
            this.txtNam.Location = new System.Drawing.Point(340, 114);
            this.txtNam.Name = "txtNam";
            this.txtNam.Size = new System.Drawing.Size(104, 20);
            this.txtNam.TabIndex = 3;
            // 
            // txtThoiLuong
            // 
            this.txtThoiLuong.Location = new System.Drawing.Point(97, 113);
            this.txtThoiLuong.Name = "txtThoiLuong";
            this.txtThoiLuong.Size = new System.Drawing.Size(123, 20);
            this.txtThoiLuong.TabIndex = 4;
            // 
            // txtQuocGia
            // 
            this.txtQuocGia.Location = new System.Drawing.Point(340, 67);
            this.txtQuocGia.Name = "txtQuocGia";
            this.txtQuocGia.Size = new System.Drawing.Size(104, 20);
            this.txtQuocGia.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(6, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(63, 16);
            this.label1.TabIndex = 10;
            this.label1.Text = "Mã Phim:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(6, 42);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(68, 16);
            this.label2.TabIndex = 11;
            this.label2.Text = "Tên Phim:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(6, 68);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(67, 16);
            this.label3.TabIndex = 12;
            this.label3.Text = "Đạo Diễn:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(258, 65);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(67, 16);
            this.label4.TabIndex = 13;
            this.label4.Text = "Quốc Gia:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(226, 117);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(96, 16);
            this.label5.TabIndex = 14;
            this.label5.Text = "Năm Sản Xuất:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(6, 118);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(78, 16);
            this.label6.TabIndex = 15;
            this.label6.Text = "Thời Lượng:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(6, 91);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(64, 16);
            this.label7.TabIndex = 16;
            this.label7.Text = "Thể Loại:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(6, 145);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(64, 16);
            this.label8.TabIndex = 17;
            this.label8.Text = "Hình Ảnh:";
            // 
            // txtHinhAnh
            // 
            this.txtHinhAnh.Location = new System.Drawing.Point(97, 144);
            this.txtHinhAnh.Name = "txtHinhAnh";
            this.txtHinhAnh.Size = new System.Drawing.Size(247, 20);
            this.txtHinhAnh.TabIndex = 18;
            // 
            // btnChonAnh
            // 
            this.btnChonAnh.Location = new System.Drawing.Point(350, 142);
            this.btnChonAnh.Name = "btnChonAnh";
            this.btnChonAnh.Size = new System.Drawing.Size(75, 23);
            this.btnChonAnh.TabIndex = 21;
            this.btnChonAnh.Text = "Chọn ảnh";
            this.btnChonAnh.UseVisualStyleBackColor = true;
            this.btnChonAnh.Click += new System.EventHandler(this.btnChonAnh_Click);
            // 
            // btnXoa
            // 
            this.btnXoa.BackColor = System.Drawing.Color.GhostWhite;
            this.btnXoa.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnXoa.Image = global::Review.Properties.Resources.IconXoa1;
            this.btnXoa.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnXoa.Location = new System.Drawing.Point(128, 221);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(105, 45);
            this.btnXoa.TabIndex = 24;
            this.btnXoa.Text = "Xóa";
            this.btnXoa.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnXoa.UseVisualStyleBackColor = false;
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.groupBox1.BackColor = System.Drawing.Color.GhostWhite;
            this.groupBox1.Controls.Add(this.txtMaPhim);
            this.groupBox1.Controls.Add(this.btnClear);
            this.groupBox1.Controls.Add(this.cbTheLoai);
            this.groupBox1.Controls.Add(this.btnClose);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.btnXoa);
            this.groupBox1.Controls.Add(this.btnThem);
            this.groupBox1.Controls.Add(this.txtTenPhim);
            this.groupBox1.Controls.Add(this.btnSua);
            this.groupBox1.Controls.Add(this.txtDaoDien);
            this.groupBox1.Controls.Add(this.btnChonAnh);
            this.groupBox1.Controls.Add(this.txtNam);
            this.groupBox1.Controls.Add(this.txtThoiLuong);
            this.groupBox1.Controls.Add(this.txtHinhAnh);
            this.groupBox1.Controls.Add(this.txtQuocGia);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Location = new System.Drawing.Point(-1, 286);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(472, 286);
            this.groupBox1.TabIndex = 25;
            this.groupBox1.TabStop = false;
            // 
            // txtMaPhim
            // 
            this.txtMaPhim.Location = new System.Drawing.Point(97, 15);
            this.txtMaPhim.Name = "txtMaPhim";
            this.txtMaPhim.Size = new System.Drawing.Size(121, 20);
            this.txtMaPhim.TabIndex = 30;
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(224, 15);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(75, 23);
            this.btnClear.TabIndex = 26;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // cbTheLoai
            // 
            this.cbTheLoai.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbTheLoai.FormattingEnabled = true;
            this.cbTheLoai.Location = new System.Drawing.Point(97, 90);
            this.cbTheLoai.Name = "cbTheLoai";
            this.cbTheLoai.Size = new System.Drawing.Size(347, 21);
            this.cbTheLoai.TabIndex = 29;
            // 
            // btnClose
            // 
            this.btnClose.BackColor = System.Drawing.Color.GhostWhite;
            this.btnClose.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClose.Image = global::Review.Properties.Resources.IconClose;
            this.btnClose.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnClose.Location = new System.Drawing.Point(239, 221);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(105, 45);
            this.btnClose.TabIndex = 26;
            this.btnClose.Text = "Đóng";
            this.btnClose.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnClose.UseVisualStyleBackColor = false;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // btnThem
            // 
            this.btnThem.BackColor = System.Drawing.Color.GhostWhite;
            this.btnThem.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThem.Image = global::Review.Properties.Resources.IconThem;
            this.btnThem.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnThem.Location = new System.Drawing.Point(128, 170);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(105, 45);
            this.btnThem.TabIndex = 23;
            this.btnThem.Text = "Thêm";
            this.btnThem.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnThem.UseVisualStyleBackColor = false;
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // btnSua
            // 
            this.btnSua.BackColor = System.Drawing.Color.GhostWhite;
            this.btnSua.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSua.Image = global::Review.Properties.Resources.IconSua;
            this.btnSua.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSua.Location = new System.Drawing.Point(239, 170);
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(105, 45);
            this.btnSua.TabIndex = 22;
            this.btnSua.Text = "Sửa";
            this.btnSua.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnSua.UseVisualStyleBackColor = false;
            this.btnSua.Click += new System.EventHandler(this.btnSua_Click);
            // 
            // picImage
            // 
            this.picImage.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.picImage.Location = new System.Drawing.Point(104, 12);
            this.picImage.Name = "picImage";
            this.picImage.Size = new System.Drawing.Size(241, 268);
            this.picImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picImage.TabIndex = 19;
            this.picImage.TabStop = false;
            // 
            // QuanLyPhim
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1194, 572);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.picImage);
            this.Controls.Add(this.dgvPhim);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "QuanLyPhim";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Quản lý phim";
            this.Load += new System.EventHandler(this.ThongTinPhim_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvPhim)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picImage)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvPhim;
        private System.Windows.Forms.PictureBox picImage;
        private System.Windows.Forms.TextBox txtTenPhim;
        private System.Windows.Forms.TextBox txtDaoDien;
        private System.Windows.Forms.TextBox txtNam;
        private System.Windows.Forms.TextBox txtThoiLuong;
        private System.Windows.Forms.TextBox txtQuocGia;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtHinhAnh;
        private System.Windows.Forms.Button btnChonAnh;
        private System.Windows.Forms.Button btnSua;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.ComboBox cbTheLoai;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.TextBox txtMaPhim;
    }
}