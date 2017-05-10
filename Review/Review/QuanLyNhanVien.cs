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
    public partial class QuanLyNhanVien : Form
    {
        public QuanLyNhanVien()
        {
            InitializeComponent();
        }

        private void QuanLyNhanVien_Load(object sender, EventArgs e)
        {
            dgvNhanVien.DataSource = GetData.GetNhanVien().Tables[0];
            cbGioiTinh.Items.Add("Nam");
            cbGioiTinh.Items.Add("Nữ");

            cbMaNhanVien.DataSource = GetData.GetNhanVien().Tables[0];
            cbMaNhanVien.DisplayMember = "MaNV";
            cbMaNhanVien.ValueMember = "MaNV";

            cbTenNhanVien.DataSource = GetData.GetNhanVien().Tables[0];
            cbTenNhanVien.DisplayMember = "TenNV";
            cbTenNhanVien.ValueMember = "MaNV";

            cbChucVu.DataSource = GetData.GetChucVu().Tables[0];
            cbChucVu.DisplayMember = "ChucVu";
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            try
            {
                string MaNV, TenNV, NgaySinh, GioiTinh, DiaChi, Email, ChucVu, NgayVaoLam;
                int SDT, SoCMND;

                MaNV = Convert.ToString(cbMaNhanVien.Text);
                TenNV = Convert.ToString(cbTenNhanVien.Text);
                NgaySinh = Convert.ToString(txtNgaySinh.Text);
                SoCMND = Convert.ToInt32(txtCMND.Text);
                GioiTinh = Convert.ToString(cbGioiTinh.Text);
                DiaChi = Convert.ToString(txtDiaChi.Text);
                Email = Convert.ToString(txtEmail.Text);
                ChucVu = Convert.ToString(cbChucVu.Text);
                NgayVaoLam = Convert.ToString(txtNgayVaoLam.Text);
                SDT = Convert.ToInt32(txtSoDT.Text);

                NhanVienDTO nhanvien = new NhanVienDTO(MaNV,TenNV,NgaySinh,GioiTinh,SoCMND,DiaChi,SDT,Email,ChucVu,NgayVaoLam);
                int themnhanvien = new ThemBUS().ThemNhanVienBUS(nhanvien);

                dgvNhanVien.DataSource = GetData.GetNhanVien().Tables[0];

                MessageBox.Show("Thêm phim thành công");
            }
            catch (SqlException)
            {
                MessageBox.Show("Mã phim đã có, nhập mã khác");
            }
            catch (Exception)
            {
                MessageBox.Show("Chọn hình ảnh");
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            try
            {
                string MaNV, TenNV, NgaySinh, GioiTinh, DiaChi, Email, ChucVu, NgayVaoLam;
                int SDT, SoCMND;

                MaNV = Convert.ToString(cbMaNhanVien.Text);
                TenNV = Convert.ToString(cbTenNhanVien.Text);
                NgaySinh = Convert.ToString(txtNgaySinh.Text);
                SoCMND = Convert.ToInt32(txtCMND.Text);
                GioiTinh = Convert.ToString(cbGioiTinh.Text);
                DiaChi = Convert.ToString(txtDiaChi.Text);
                Email = Convert.ToString(txtEmail.Text);
                ChucVu = Convert.ToString(cbChucVu.Text);
                NgayVaoLam = Convert.ToString(txtNgayVaoLam.Text);
                SDT = Convert.ToInt32(txtSoDT.Text);

                NhanVienDTO nhanvien = new NhanVienDTO(MaNV, TenNV, NgaySinh, GioiTinh, SoCMND, DiaChi, SDT, Email, ChucVu, NgayVaoLam);
                int suanhanvien = new SuaBUS().SuaNhanVienBUS(nhanvien);

                dgvNhanVien.DataSource = GetData.GetNhanVien().Tables[0];

                MessageBox.Show("Sửa nhân viên thành công");
            }
            catch (SqlException)
            {
                MessageBox.Show("Mã phim đã có, nhập mã khác");
            }
            catch (Exception)
            {
                MessageBox.Show("Chọn hình ảnh");
            }

        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            try
            {
                string MaNV, TenNV, NgaySinh, GioiTinh, DiaChi, Email, ChucVu, NgayVaoLam;
                int SDT, SoCMND;

                MaNV = Convert.ToString(cbMaNhanVien.Text);
                TenNV = Convert.ToString(cbTenNhanVien.Text);
                NgaySinh = Convert.ToString(txtNgaySinh.Text);
                SoCMND = Convert.ToInt32(txtCMND.Text);
                GioiTinh = Convert.ToString(cbGioiTinh.Text);
                DiaChi = Convert.ToString(txtDiaChi.Text);
                Email = Convert.ToString(txtEmail.Text);
                ChucVu = Convert.ToString(cbChucVu.Text);
                NgayVaoLam = Convert.ToString(txtNgayVaoLam.Text);
                SDT = Convert.ToInt32(txtSoDT.Text);

                NhanVienDTO nhanvien = new NhanVienDTO(MaNV, TenNV, NgaySinh, GioiTinh, SoCMND, DiaChi, SDT, Email, ChucVu, NgayVaoLam);
                int xoanhanvien = new XoaBUS().XoaNhanVienBUS(nhanvien);

                dgvNhanVien.DataSource = GetData.GetNhanVien().Tables[0];

                MessageBox.Show("Xóa nhân viên thành công");
            }
            catch (SqlException)
            {
                MessageBox.Show("Mã phim đã có, nhập mã khác");
            }
            catch (Exception)
            {
                MessageBox.Show("Chọn hình ảnh");
            }

        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void dgvNhanVien_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            cbMaNhanVien.Text = dgvNhanVien.CurrentRow.Cells[0].Value.ToString().Trim();
            cbTenNhanVien.Text = dgvNhanVien.CurrentRow.Cells[1].Value.ToString().Trim();
            txtNgaySinh.Text = dgvNhanVien.CurrentRow.Cells[2].Value.ToString().Trim();
            cbGioiTinh.Text = dgvNhanVien.CurrentRow.Cells[3].Value.ToString().Trim();
            txtCMND.Text = dgvNhanVien.CurrentRow.Cells[4].Value.ToString().Trim();
            txtDiaChi.Text = dgvNhanVien.CurrentRow.Cells[5].Value.ToString().Trim();
            txtSoDT.Text = dgvNhanVien.CurrentRow.Cells[6].Value.ToString().Trim();
            txtEmail.Text = dgvNhanVien.CurrentRow.Cells[7].Value.ToString().Trim();
            cbChucVu.Text = dgvNhanVien.CurrentRow.Cells[8].Value.ToString().Trim();
            txtNgayVaoLam.Text = dgvNhanVien.CurrentRow.Cells[9].Value.ToString().Trim();
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            txtCMND.Text = txtSoDT.Text = txtNgaySinh.Text = txtNgayVaoLam.Text = txtEmail.Text = txtDiaChi.Text = "";
            cbMaNhanVien.Text = cbTenNhanVien.Text = cbGioiTinh.Text = cbChucVu.Text = "";
        }
    }
}
