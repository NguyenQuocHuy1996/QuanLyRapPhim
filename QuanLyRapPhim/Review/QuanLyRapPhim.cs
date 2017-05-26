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
    public partial class QuanLyRapPhim : Form
    {
        public QuanLyRapPhim()
        {
            InitializeComponent();
        }

        private void QuanLyRapPhim_Load(object sender, EventArgs e)
        {
            dgvRapPhim.DataSource = GetData.GetRapPhim().Tables[0];
            dgvRapPhim.Columns[0].HeaderText = "Mã rạp phim";
            dgvRapPhim.Columns[1].HeaderText = "Tên rạp phim";
            dgvRapPhim.Columns[2].HeaderText = "Địa chỉ";
            dgvRapPhim.Columns[3].HeaderText = "Mã nhân viên";
            dgvRapPhim.Columns[4].HeaderText = "Nhân viên quản lý";

            cbTenNhanVien.DataSource = GetData.GetNhanVienDK("Quản lý rạp phim").Tables[0];
            cbTenNhanVien.DisplayMember = "TenNV";
            cbTenNhanVien.ValueMember = "MaNV";
            txtMaNhanVien.Text = cbTenNhanVien.SelectedValue.ToString();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            try
            {
                string MaRP, TenRP, DiaChi, MaNV, TenNV;

                MaRP = Convert.ToString(txtMaRP.Text);
                TenRP = Convert.ToString(txtTenRapPhim.Text);
                DiaChi = Convert.ToString(txtDiaChi.Text);
                MaNV = Convert.ToString(txtMaNhanVien.Text);
                TenNV = Convert.ToString(cbTenNhanVien.Text);

                RapPhimDTO rapphim = new RapPhimDTO(MaRP,TenRP,DiaChi,MaNV,TenNV);
                int themrapphim = new ThemBUS().ThemRapPhimBUS(rapphim);

                dgvRapPhim.DataSource = GetData.GetRapPhim().Tables[0];
                MessageBox.Show("Thêm thành công");

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
                string MaRP, TenRP, DiaChi, MaNV, TenNV;

                MaRP = Convert.ToString(txtMaRP.Text);
                TenRP = Convert.ToString(txtTenRapPhim.Text);
                DiaChi = Convert.ToString(txtDiaChi.Text);
                MaNV = Convert.ToString(txtMaNhanVien.Text);
                TenNV = Convert.ToString(cbTenNhanVien.Text);

                RapPhimDTO rapphim = new RapPhimDTO(MaRP, TenRP, DiaChi, MaNV, TenNV);
                int themrapphim = new XoaBUS().XoaRapPhimBUS(rapphim);

                dgvRapPhim.DataSource = GetData.GetRapPhim().Tables[0];
                MessageBox.Show("Xóa thành công");

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

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            try
            {
                string MaRP, TenRP, DiaChi, MaNV, TenNV;

                MaRP = Convert.ToString(txtMaRP.Text);
                TenRP = Convert.ToString(txtTenRapPhim.Text);
                DiaChi = Convert.ToString(txtDiaChi.Text);
                MaNV = Convert.ToString(txtMaNhanVien.Text);
                TenNV = Convert.ToString(cbTenNhanVien.Text);

                RapPhimDTO rapphim = new RapPhimDTO(MaRP, TenRP, DiaChi, MaNV, TenNV);
                int suarapphim = new SuaBUS().SuaRapPhimBUS(rapphim);

                dgvRapPhim.DataSource = GetData.GetRapPhim().Tables[0];
                MessageBox.Show("Sửa thành công");

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

        private void cbTenNhanVien_SelectedIndexChanged(object sender, EventArgs e)
        {
            txtMaNhanVien.Text = cbTenNhanVien.SelectedValue.ToString();
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            cbTenNhanVien.Text = txtMaRP.Text = "";
            txtDiaChi.Text = txtMaNhanVien.Text = txtTenRapPhim.Text = "";
        }

        private void dgvRapPhim_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txtMaRP.Text = dgvRapPhim.CurrentRow.Cells[0].Value.ToString().Trim();
            txtTenRapPhim.Text = dgvRapPhim.CurrentRow.Cells[1].Value.ToString().Trim();
            txtDiaChi.Text = dgvRapPhim.CurrentRow.Cells[2].Value.ToString().Trim();
            txtMaNhanVien.Text = dgvRapPhim.CurrentRow.Cells[3].Value.ToString().Trim();
            cbTenNhanVien.Text = dgvRapPhim.CurrentRow.Cells[4].Value.ToString().Trim();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void QuanLyRapPhim_FormClosing(object sender, FormClosingEventArgs e)
        {

        }
    }
}
