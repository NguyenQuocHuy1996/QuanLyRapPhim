using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

using DTO;
using BUS;

namespace Review
{
    public partial class Ve : Form
    {
        public Ve()
        {
            InitializeComponent();
        }

        string TenPhim, NgayChieu, GioChieu, LoaiVe, DoiTuong, SoGhe;
        int GiaVe;
        public Ve(string label1, string label2, string label3, string label4, string label5, string label6, int label7)
        {
            InitializeComponent();
            TenPhim = label1;
            NgayChieu = label2;
            GioChieu = label3;
            LoaiVe = label4;
            DoiTuong = label5;
            SoGhe = label6;
            GiaVe = label7;

        }

        private void Ve_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource = GetData.GetVe().Tables[0];
        }

        //private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        //{
        //    lbTenPhim.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString();
        //    lbNgayChieu.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
        //    lbGioChieu.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
        //    lbSoGhe.Text = dataGridView1.CurrentRow.Cells[3].Value.ToString();
        //    lbLoaiGhe.Text = dataGridView1.CurrentRow.Cells[4].Value.ToString();
        //    lbDoiTuong.Text = dataGridView1.CurrentRow.Cells[5].Value.ToString();
        //    lbGiaVe.Text = dataGridView1.CurrentRow.Cells[6].Value.ToString();
        //}
    }
}
