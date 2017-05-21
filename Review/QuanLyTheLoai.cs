using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;

using DTO;
using BUS;

namespace Review
{
    public partial class QuanLyTheLoai : Form
    {
        public QuanLyTheLoai()
        {
            InitializeComponent();
        }

        private void QuanLyTheLoai_Load(object sender, EventArgs e)
        {
            dgvTheLoai.DataSource = GetData.GetTheLoai().Tables[0];
        }

        private void dgvTheLoai_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txtTheLoai.Text = dgvTheLoai.CurrentRow.Cells[0].Value.ToString().Trim();
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            try
            {
                string theloai;
                theloai = txtTheLoai.Text.ToString();

                TheLoaiDTO tl = new TheLoaiDTO(theloai);
                int themtheloai = new ThemBUS().ThemTheLoaiBUS(tl);

                dgvTheLoai.DataSource = GetData.GetTheLoai().Tables[0];
                MessageBox.Show("Thêm thể loại thành công");
            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.Message);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            try
            {
                string theloai;
                theloai = Convert.ToString(dgvTheLoai.CurrentRow.Cells[0].Value.ToString().Trim());
                TheLoaiDTO tl = new TheLoaiDTO(theloai);
                int xoatheloai = new XoaBUS().XoaTheLoaiBUS(tl);

                dgvTheLoai.DataSource = GetData.GetTheLoai().Tables[0];
                MessageBox.Show("Xóa thể loại thành công");
            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.Message);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            QuanLyPhim phim = new QuanLyPhim();
            phim.Show();
            this.Close();
        }
    }
}
