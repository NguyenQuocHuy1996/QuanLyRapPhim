namespace Review
{
    partial class QuanLyLichChieu
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
            this.cbDinhDang = new System.Windows.Forms.ComboBox();
            this.cbTenPhongChieu = new System.Windows.Forms.ComboBox();
            this.txtMaRapPhim = new System.Windows.Forms.TextBox();
            this.txtMaPhongChieu = new System.Windows.Forms.TextBox();
            this.cbTenRapPhim = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.btnClose = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.btnXoa = new System.Windows.Forms.Button();
            this.cbTenPhim = new System.Windows.Forms.ComboBox();
            this.btnThem = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cbNgayChieu = new System.Windows.Forms.ComboBox();
            this.label9 = new System.Windows.Forms.Label();
            this.cbGioChieu = new System.Windows.Forms.ComboBox();
            this.btnSua = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.txtMaPhim = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.dgvLichChieu = new System.Windows.Forms.DataGridView();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvLichChieu)).BeginInit();
            this.SuspendLayout();
            // 
            // cbDinhDang
            // 
            this.cbDinhDang.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbDinhDang.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.cbDinhDang.FormattingEnabled = true;
            this.cbDinhDang.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.cbDinhDang.Location = new System.Drawing.Point(105, 67);
            this.cbDinhDang.Name = "cbDinhDang";
            this.cbDinhDang.Size = new System.Drawing.Size(121, 21);
            this.cbDinhDang.TabIndex = 30;
            this.cbDinhDang.SelectedIndexChanged += new System.EventHandler(this.cbDinhDang_SelectedIndexChanged);
            // 
            // cbTenPhongChieu
            // 
            this.cbTenPhongChieu.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbTenPhongChieu.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.cbTenPhongChieu.FormattingEnabled = true;
            this.cbTenPhongChieu.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.cbTenPhongChieu.Location = new System.Drawing.Point(105, 93);
            this.cbTenPhongChieu.Name = "cbTenPhongChieu";
            this.cbTenPhongChieu.Size = new System.Drawing.Size(121, 21);
            this.cbTenPhongChieu.TabIndex = 29;
            this.cbTenPhongChieu.SelectedIndexChanged += new System.EventHandler(this.cbTenPhongChieu_SelectedIndexChanged);
            // 
            // txtMaRapPhim
            // 
            this.txtMaRapPhim.Location = new System.Drawing.Point(103, 147);
            this.txtMaRapPhim.Name = "txtMaRapPhim";
            this.txtMaRapPhim.ReadOnly = true;
            this.txtMaRapPhim.Size = new System.Drawing.Size(64, 20);
            this.txtMaRapPhim.TabIndex = 28;
            // 
            // txtMaPhongChieu
            // 
            this.txtMaPhongChieu.Location = new System.Drawing.Point(103, 173);
            this.txtMaPhongChieu.Name = "txtMaPhongChieu";
            this.txtMaPhongChieu.ReadOnly = true;
            this.txtMaPhongChieu.Size = new System.Drawing.Size(100, 20);
            this.txtMaPhongChieu.TabIndex = 27;
            // 
            // cbTenRapPhim
            // 
            this.cbTenRapPhim.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbTenRapPhim.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.cbTenRapPhim.FormattingEnabled = true;
            this.cbTenRapPhim.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.cbTenRapPhim.Location = new System.Drawing.Point(105, 13);
            this.cbTenRapPhim.Name = "cbTenRapPhim";
            this.cbTenRapPhim.Size = new System.Drawing.Size(237, 21);
            this.cbTenRapPhim.TabIndex = 24;
            this.cbTenRapPhim.SelectedIndexChanged += new System.EventHandler(this.cbTenRapPhim_SelectedIndexChanged);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(6, 70);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(59, 13);
            this.label8.TabIndex = 23;
            this.label8.Text = "Định dạng:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(6, 150);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(68, 13);
            this.label7.TabIndex = 22;
            this.label7.Text = "Mã rạp phim:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(6, 176);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(84, 13);
            this.label6.TabIndex = 21;
            this.label6.Text = "Mã phòng chiếu";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 96);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(91, 13);
            this.label5.TabIndex = 20;
            this.label5.Text = "Tên phòng chiếu:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 16);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(72, 13);
            this.label4.TabIndex = 19;
            this.label4.Text = "Tên rạp phim:";
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(255, 205);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(71, 23);
            this.btnClose.TabIndex = 18;
            this.btnClose.Text = "Đóng";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 43);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(55, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Tên Phim:";
            // 
            // btnXoa
            // 
            this.btnXoa.Location = new System.Drawing.Point(178, 205);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(71, 23);
            this.btnXoa.TabIndex = 16;
            this.btnXoa.Text = "Xóa";
            this.btnXoa.UseVisualStyleBackColor = true;
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // cbTenPhim
            // 
            this.cbTenPhim.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbTenPhim.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.cbTenPhim.FormattingEnabled = true;
            this.cbTenPhim.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.cbTenPhim.Location = new System.Drawing.Point(105, 40);
            this.cbTenPhim.Name = "cbTenPhim";
            this.cbTenPhim.Size = new System.Drawing.Size(237, 21);
            this.cbTenPhim.TabIndex = 1;
            this.cbTenPhim.SelectedIndexChanged += new System.EventHandler(this.cbTenPhim_SelectedIndexChanged);
            // 
            // btnThem
            // 
            this.btnThem.Location = new System.Drawing.Point(20, 205);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(71, 23);
            this.btnThem.TabIndex = 15;
            this.btnThem.Text = "Thêm";
            this.btnThem.UseVisualStyleBackColor = true;
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.cbNgayChieu);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.cbGioChieu);
            this.groupBox1.Controls.Add(this.btnSua);
            this.groupBox1.Controls.Add(this.cbDinhDang);
            this.groupBox1.Controls.Add(this.cbTenPhongChieu);
            this.groupBox1.Controls.Add(this.txtMaRapPhim);
            this.groupBox1.Controls.Add(this.txtMaPhongChieu);
            this.groupBox1.Controls.Add(this.cbTenRapPhim);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.btnClose);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.btnXoa);
            this.groupBox1.Controls.Add(this.cbTenPhim);
            this.groupBox1.Controls.Add(this.btnThem);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.txtMaPhim);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Left;
            this.groupBox1.Location = new System.Drawing.Point(0, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(355, 500);
            this.groupBox1.TabIndex = 19;
            this.groupBox1.TabStop = false;
            // 
            // cbNgayChieu
            // 
            this.cbNgayChieu.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbNgayChieu.FormattingEnabled = true;
            this.cbNgayChieu.Location = new System.Drawing.Point(105, 120);
            this.cbNgayChieu.Name = "cbNgayChieu";
            this.cbNgayChieu.Size = new System.Drawing.Size(85, 21);
            this.cbNgayChieu.TabIndex = 32;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(196, 123);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(55, 13);
            this.label9.TabIndex = 20;
            this.label9.Text = "Giờ chiếu:";
            // 
            // cbGioChieu
            // 
            this.cbGioChieu.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbGioChieu.FormattingEnabled = true;
            this.cbGioChieu.Location = new System.Drawing.Point(257, 120);
            this.cbGioChieu.Name = "cbGioChieu";
            this.cbGioChieu.Size = new System.Drawing.Size(69, 21);
            this.cbGioChieu.TabIndex = 21;
            // 
            // btnSua
            // 
            this.btnSua.Location = new System.Drawing.Point(97, 205);
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(75, 23);
            this.btnSua.TabIndex = 31;
            this.btnSua.Text = "Sửa";
            this.btnSua.UseVisualStyleBackColor = true;
            this.btnSua.Click += new System.EventHandler(this.btnSua_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(175, 150);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(51, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Mã Phim:";
            // 
            // txtMaPhim
            // 
            this.txtMaPhim.Location = new System.Drawing.Point(232, 147);
            this.txtMaPhim.Name = "txtMaPhim";
            this.txtMaPhim.ReadOnly = true;
            this.txtMaPhim.Size = new System.Drawing.Size(64, 20);
            this.txtMaPhim.TabIndex = 14;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 123);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(64, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Ngày chiếu:";
            // 
            // dgvLichChieu
            // 
            this.dgvLichChieu.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvLichChieu.Dock = System.Windows.Forms.DockStyle.Right;
            this.dgvLichChieu.Location = new System.Drawing.Point(361, 0);
            this.dgvLichChieu.Name = "dgvLichChieu";
            this.dgvLichChieu.Size = new System.Drawing.Size(439, 500);
            this.dgvLichChieu.TabIndex = 33;
            this.dgvLichChieu.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvLichChieu_CellContentClick);
            // 
            // QuanLyLichChieu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 500);
            this.Controls.Add(this.dgvLichChieu);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "QuanLyLichChieu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Quản lý lịch chiếu phim";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvLichChieu)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox txtMaRapPhim;
        private System.Windows.Forms.TextBox txtMaPhongChieu;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtMaPhim;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cbDinhDang;
        private System.Windows.Forms.ComboBox cbTenPhongChieu;
        private System.Windows.Forms.ComboBox cbTenRapPhim;
        private System.Windows.Forms.ComboBox cbTenPhim;
        private System.Windows.Forms.Button btnSua;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.ComboBox cbGioChieu;
        private System.Windows.Forms.DataGridView dgvLichChieu;
        private System.Windows.Forms.ComboBox cbNgayChieu;
    }
}