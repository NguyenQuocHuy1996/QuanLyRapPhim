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

        private void button3_Click(object sender, EventArgs e)
        {
            QuanLyPhim formPhim = new QuanLyPhim();
            formPhim.ShowDialog();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            QuanLyLichChieu formLichChieu = new QuanLyLichChieu();
            formLichChieu.ShowDialog();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            QuanLyRapPhim formRapPhim = new QuanLyRapPhim();
            formRapPhim.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            QuanLyPhongChieu formPhongChieu = new QuanLyPhongChieu();
            formPhongChieu.ShowDialog();
        }

        private void FormQuanLy_Load(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {
            QuanLyNhanVien show = new QuanLyNhanVien();
            show.ShowDialog();
        }

        private void FormQuanLy_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        // Button Report Clicked
        private void button6_Click(object sender, EventArgs e)
        {
            Report form = new Report();
            form.ShowDialog();
        }
    }
}
