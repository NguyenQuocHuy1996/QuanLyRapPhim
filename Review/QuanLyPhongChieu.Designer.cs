namespace Review
{
    partial class QuanLyPhongChieu
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
            this.txtMaRapPhim = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rd4DX = new System.Windows.Forms.RadioButton();
            this.rd2D = new System.Windows.Forms.RadioButton();
            this.label5 = new System.Windows.Forms.Label();
            this.rd3D = new System.Windows.Forms.RadioButton();
            this.cbMaPhongChieu = new System.Windows.Forms.ComboBox();
            this.cbTenPhongChieu = new System.Windows.Forms.ComboBox();
            this.cbTenRapPhim = new System.Windows.Forms.ComboBox();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.txtMaNhanVien = new System.Windows.Forms.TextBox();
            this.txtTenNV = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.dgvPhongChieu = new System.Windows.Forms.DataGridView();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPhongChieu)).BeginInit();
            this.SuspendLayout();
            // 
            // txtMaRapPhim
            // 
            this.txtMaRapPhim.Location = new System.Drawing.Point(108, 62);
            this.txtMaRapPhim.Name = "txtMaRapPhim";
            this.txtMaRapPhim.ReadOnly = true;
            this.txtMaRapPhim.Size = new System.Drawing.Size(100, 20);
            this.txtMaRapPhim.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(72, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Tên rap phim:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(8, 33);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(87, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Mã phòng chiếu:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(8, 60);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(91, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Tên phòng chiếu:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(7, 63);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(68, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "Mã rạp phim:";
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.rd4DX);
            this.groupBox1.Controls.Add(this.rd2D);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.rd3D);
            this.groupBox1.Controls.Add(this.cbMaPhongChieu);
            this.groupBox1.Controls.Add(this.cbTenPhongChieu);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Location = new System.Drawing.Point(396, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(386, 125);
            this.groupBox1.TabIndex = 8;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Thông tin phòng chiếu:";
            // 
            // rd4DX
            // 
            this.rd4DX.Appearance = System.Windows.Forms.Appearance.Button;
            this.rd4DX.BackColor = System.Drawing.Color.Cyan;
            this.rd4DX.Location = new System.Drawing.Point(181, 84);
            this.rd4DX.Name = "rd4DX";
            this.rd4DX.Size = new System.Drawing.Size(32, 24);
            this.rd4DX.TabIndex = 14;
            this.rd4DX.TabStop = true;
            this.rd4DX.Text = "4D";
            this.rd4DX.UseVisualStyleBackColor = false;
            this.rd4DX.CheckedChanged += new System.EventHandler(this.rd2D_CheckedChanged);
            // 
            // rd2D
            // 
            this.rd2D.Appearance = System.Windows.Forms.Appearance.Button;
            this.rd2D.BackColor = System.Drawing.Color.Cyan;
            this.rd2D.Location = new System.Drawing.Point(105, 84);
            this.rd2D.Name = "rd2D";
            this.rd2D.Size = new System.Drawing.Size(32, 24);
            this.rd2D.TabIndex = 12;
            this.rd2D.TabStop = true;
            this.rd2D.Text = "2D";
            this.rd2D.UseVisualStyleBackColor = false;
            this.rd2D.CheckedChanged += new System.EventHandler(this.rd2D_CheckedChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(8, 89);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(59, 13);
            this.label5.TabIndex = 11;
            this.label5.Text = "Định dạng:";
            // 
            // rd3D
            // 
            this.rd3D.Appearance = System.Windows.Forms.Appearance.Button;
            this.rd3D.BackColor = System.Drawing.Color.Cyan;
            this.rd3D.Location = new System.Drawing.Point(143, 84);
            this.rd3D.Name = "rd3D";
            this.rd3D.Size = new System.Drawing.Size(32, 24);
            this.rd3D.TabIndex = 13;
            this.rd3D.TabStop = true;
            this.rd3D.Text = "3D";
            this.rd3D.UseVisualStyleBackColor = false;
            this.rd3D.CheckedChanged += new System.EventHandler(this.rd2D_CheckedChanged);
            // 
            // cbMaPhongChieu
            // 
            this.cbMaPhongChieu.FormattingEnabled = true;
            this.cbMaPhongChieu.Location = new System.Drawing.Point(105, 30);
            this.cbMaPhongChieu.Name = "cbMaPhongChieu";
            this.cbMaPhongChieu.Size = new System.Drawing.Size(121, 21);
            this.cbMaPhongChieu.TabIndex = 10;
            // 
            // cbTenPhongChieu
            // 
            this.cbTenPhongChieu.FormattingEnabled = true;
            this.cbTenPhongChieu.Location = new System.Drawing.Point(105, 57);
            this.cbTenPhongChieu.Name = "cbTenPhongChieu";
            this.cbTenPhongChieu.Size = new System.Drawing.Size(199, 21);
            this.cbTenPhongChieu.TabIndex = 9;
            this.cbTenPhongChieu.SelectedIndexChanged += new System.EventHandler(this.cbTenPhongChieu_SelectedIndexChanged);
            // 
            // cbTenRapPhim
            // 
            this.cbTenRapPhim.FormattingEnabled = true;
            this.cbTenRapPhim.Location = new System.Drawing.Point(108, 35);
            this.cbTenRapPhim.Name = "cbTenRapPhim";
            this.cbTenRapPhim.Size = new System.Drawing.Size(226, 21);
            this.cbTenRapPhim.TabIndex = 10;
            this.cbTenRapPhim.SelectedIndexChanged += new System.EventHandler(this.cbTenRapPhim_SelectedIndexChanged);
            // 
            // btnUpdate
            // 
            this.btnUpdate.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnUpdate.Location = new System.Drawing.Point(534, 143);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(75, 30);
            this.btnUpdate.TabIndex = 9;
            this.btnUpdate.Text = "Cập nhật";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // btnClose
            // 
            this.btnClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnClose.Location = new System.Drawing.Point(696, 143);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(75, 30);
            this.btnClose.TabIndex = 10;
            this.btnClose.Text = "Đóng";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAdd.Location = new System.Drawing.Point(453, 143);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(75, 30);
            this.btnAdd.TabIndex = 11;
            this.btnAdd.Text = "Thêm";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnDelete.Location = new System.Drawing.Point(615, 143);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(75, 30);
            this.btnDelete.TabIndex = 12;
            this.btnDelete.Text = "Xóa";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(6, 89);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(96, 13);
            this.label6.TabIndex = 13;
            this.label6.Text = "Nhân viên quản lý:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(7, 115);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(75, 13);
            this.label7.TabIndex = 14;
            this.label7.Text = "Mã nhân viên:";
            // 
            // txtMaNhanVien
            // 
            this.txtMaNhanVien.Location = new System.Drawing.Point(108, 114);
            this.txtMaNhanVien.Name = "txtMaNhanVien";
            this.txtMaNhanVien.ReadOnly = true;
            this.txtMaNhanVien.Size = new System.Drawing.Size(100, 20);
            this.txtMaNhanVien.TabIndex = 15;
            // 
            // txtTenNV
            // 
            this.txtTenNV.Location = new System.Drawing.Point(108, 88);
            this.txtTenNV.Name = "txtTenNV";
            this.txtTenNV.ReadOnly = true;
            this.txtTenNV.Size = new System.Drawing.Size(100, 20);
            this.txtTenNV.TabIndex = 16;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(13, 9);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(0, 13);
            this.label8.TabIndex = 17;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.txtMaRapPhim);
            this.groupBox2.Controls.Add(this.txtTenNV);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.txtMaNhanVien);
            this.groupBox2.Controls.Add(this.cbTenRapPhim);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Location = new System.Drawing.Point(12, 9);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(384, 149);
            this.groupBox2.TabIndex = 18;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Thông tin rạp phim:";
            // 
            // dgvPhongChieu
            // 
            this.dgvPhongChieu.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvPhongChieu.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPhongChieu.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dgvPhongChieu.Location = new System.Drawing.Point(0, 179);
            this.dgvPhongChieu.Name = "dgvPhongChieu";
            this.dgvPhongChieu.Size = new System.Drawing.Size(794, 293);
            this.dgvPhongChieu.TabIndex = 17;
            this.dgvPhongChieu.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvPhongChieu_CellContentClick);
            // 
            // QuanLyPhongChieu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(794, 472);
            this.Controls.Add(this.dgvPhongChieu);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "QuanLyPhongChieu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Quản lý phòng chiếu phim";
            this.Load += new System.EventHandler(this.RapPhim_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPhongChieu)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtMaRapPhim;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.ComboBox cbTenPhongChieu;
        private System.Windows.Forms.ComboBox cbTenRapPhim;
        private System.Windows.Forms.ComboBox cbMaPhongChieu;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtMaNhanVien;
        private System.Windows.Forms.TextBox txtTenNV;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DataGridView dgvPhongChieu;
        private System.Windows.Forms.RadioButton rd4DX;
        private System.Windows.Forms.RadioButton rd3D;
        private System.Windows.Forms.RadioButton rd2D;
    }
}