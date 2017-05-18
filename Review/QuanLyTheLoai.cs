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
            txtTheLoai.Text = dgvTheLoai.CurrentRow.Cells[1].Value.ToString().Trim();
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
            }
            catch (SqlException ex)
            {                
                throw ex;
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {

        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
