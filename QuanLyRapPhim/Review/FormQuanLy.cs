using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Review
{
    public partial class FormQuanLy : Form
    {
        public FormQuanLy()
        {
            InitializeComponent();
        }

        public FormQuanLy(string taikhoan, string quyen)
        {
            InitializeComponent();
            lbuser.Text += " " + taikhoan;
        }

        private void FormQuanLy_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void FormQuanLy_Load(object sender, EventArgs e)
        {

        }

        private void btnRapPhim_Click(object sender, EventArgs e)
        {
            QuanLyRapPhim RapPhim = new QuanLyRapPhim();
            RapPhim.Show();
        }

        private void btnPhongChieu_Click(object sender, EventArgs e)
        {
            QuanLyPhongChieu PhongChieu = new QuanLyPhongChieu();
            PhongChieu.Show();
        }

        private void btnPhim_Click(object sender, EventArgs e)
        {
            QuanLyPhim Phim = new QuanLyPhim();
            Phim.Show();
        }

        private void btnLichChieu_Click(object sender, EventArgs e)
        {
            QuanLyLichChieu LichChieu = new QuanLyLichChieu();
            LichChieu.Show();
        }

        private void btnNhanVien_Click(object sender, EventArgs e)
        {
            QuanLyNhanVien NhanVien = new QuanLyNhanVien();
            NhanVien.Show();
        }

        private void btnTaiKhoan_Click(object sender, EventArgs e)
        {
            Register taikhoan = new Register();
            taikhoan.Show();
        }

        private void btnDangXuat_Click(object sender, EventArgs e)
        {
            Login login = new Login();
            login.Show();
            this.Hide();
        }
    }
}
