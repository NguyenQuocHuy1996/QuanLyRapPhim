﻿using System;
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
            dgvNhanVien.Columns[0].HeaderText = "Mã nhân viên";
            dgvNhanVien.Columns[1].HeaderText = "Tên nhân viên";
            dgvNhanVien.Columns[2].HeaderText = "Ngày sinh";
            dgvNhanVien.Columns[3].HeaderText = "Giới tính";
            dgvNhanVien.Columns[4].HeaderText = "Số CMND";
            dgvNhanVien.Columns[5].HeaderText = "Địa chỉ";
            dgvNhanVien.Columns[6].HeaderText = "Điện thoại";
            dgvNhanVien.Columns[7].HeaderText = "Email";
            dgvNhanVien.Columns[8].HeaderText = "Chức vụ";
            dgvNhanVien.Columns[9].HeaderText = "Ngày vào làm";

            cbGioiTinh.Items.Add("Nam");
            cbGioiTinh.Items.Add("Nữ");

            cbChucVu.DataSource = GetData.GetChucVu().Tables[0];
            cbChucVu.DisplayMember = "ChucVu";
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            try
            {
                string MaNV, TenNV, NgaySinh, GioiTinh, DiaChi, Email, ChucVu, NgayVaoLam;
                int SDT, SoCMND;

                MaNV = Convert.ToString(txtMaNV.Text);
                TenNV = Convert.ToString(txtTenNV.Text);
                NgaySinh = Convert.ToString(txtNgaySinh.Text);
                SoCMND = Convert.ToInt32(txtCMND.Text);
                GioiTinh = Convert.ToString(cbGioiTinh.Text);
                DiaChi = Convert.ToString(txtDiaChi.Text);
                Email = Convert.ToString(txtEmail.Text);
                ChucVu = Convert.ToString(cbChucVu.Text);
                NgayVaoLam = Convert.ToString(txtNgayVaoLam.Text);
                SDT = Convert.ToInt32(txtSoDT.Text);

                NhanVienDTO nhanvien = new NhanVienDTO(MaNV, TenNV, NgaySinh, GioiTinh, SoCMND, DiaChi, SDT, Email, ChucVu, NgayVaoLam);
                int themnhanvien = new ThemBUS().ThemNhanVienBUS(nhanvien);

                dgvNhanVien.DataSource = GetData.GetNhanVien().Tables[0];

                MessageBox.Show("Thêm phim thành công");
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
                string MaNV, TenNV, NgaySinh, GioiTinh, DiaChi, Email, ChucVu, NgayVaoLam;
                int SDT, SoCMND;

                MaNV = Convert.ToString(txtMaNV.Text);
                TenNV = Convert.ToString(txtTenNV.Text);
                NgaySinh = Convert.ToString(txtNgaySinh.Text);
                SoCMND = Convert.ToInt32(txtCMND.Text);
                GioiTinh = Convert.ToString(cbGioiTinh.Text);
                DiaChi = Convert.ToString(txtDiaChi.Text);
                Email = Convert.ToString(txtEmail.Text);
                ChucVu = Convert.ToString(cbChucVu.Text);
                NgayVaoLam = Convert.ToString(txtNgayVaoLam.Text);
                SDT = Convert.ToInt32(txtSoDT.Text);

                if (GetData.GetRapPhimDK2(txtMaNV.Text).Tables[0].Rows.Count >= 1)
                {
                    MessageBox.Show("Nhân viên này đang quản lý 1 trong các rạp phim. Cập nhật lại nhân viên quản lý trước khi thực hiện việc thay đổi chức vụ");
                }
                else if (dgvNhanVien.CurrentRow.Cells[8].Value.ToString().Trim() == "Admin")
                {
                    MessageBox.Show("Đây là Admin, không thể thay đổi chức vụ");
                }
                else
                {
                    NhanVienDTO nhanvien = new NhanVienDTO(MaNV, TenNV, NgaySinh, GioiTinh, SoCMND, DiaChi, SDT, Email, ChucVu, NgayVaoLam);
                    int suanhanvien = new SuaBUS().SuaNhanVienBUS(nhanvien);

                    dgvNhanVien.DataSource = GetData.GetNhanVien().Tables[0];

                    MessageBox.Show("Sửa nhân viên thành công");
                }
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
                string MaNV, TenNV, NgaySinh, GioiTinh, DiaChi, Email, ChucVu, NgayVaoLam;
                int SDT, SoCMND;

                MaNV = Convert.ToString(txtMaNV.Text);
                TenNV = Convert.ToString(txtTenNV.Text);
                NgaySinh = Convert.ToString(txtNgaySinh.Text);
                SoCMND = Convert.ToInt32(txtCMND.Text);
                GioiTinh = Convert.ToString(cbGioiTinh.Text);
                DiaChi = Convert.ToString(txtDiaChi.Text);
                Email = Convert.ToString(txtEmail.Text);
                ChucVu = Convert.ToString(cbChucVu.Text);
                NgayVaoLam = Convert.ToString(txtNgayVaoLam.Text);
                SDT = Convert.ToInt32(txtSoDT.Text);

                if (GetData.GetRapPhimDK2(txtMaNV.Text).Tables[0].Rows.Count >= 1)
                {
                    MessageBox.Show("Nhân viên này đang quản lý 1 trong các rạp phim. Cập nhật lại nhân viên quản lý trước khi thực hiện xóa");
                }
                else if (dgvNhanVien.CurrentRow.Cells[8].Value.ToString().Trim() == "Admin")
                {
                    MessageBox.Show("Đây là Admin, không thể xóa");
                }
                else
                {

                    NhanVienDTO nhanvien = new NhanVienDTO(MaNV, TenNV, NgaySinh, GioiTinh, SoCMND, DiaChi, SDT, Email, ChucVu, NgayVaoLam);
                    int xoanhanvien = new XoaBUS().XoaNhanVienBUS(nhanvien);

                    dgvNhanVien.DataSource = GetData.GetNhanVien().Tables[0];

                    MessageBox.Show("Xóa nhân viên thành công");
                }
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
            Close();       
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            txtCMND.Text = txtSoDT.Text = txtNgaySinh.Text = txtNgayVaoLam.Text = txtEmail.Text = txtDiaChi.Text = "";
            txtMaNV.Text = txtTenNV.Text = cbGioiTinh.Text = cbChucVu.Text = "";
        }

        private void dgvNhanVien_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txtMaNV.Text = dgvNhanVien.CurrentRow.Cells[0].Value.ToString().Trim();
            txtTenNV.Text = dgvNhanVien.CurrentRow.Cells[1].Value.ToString().Trim();
            txtNgaySinh.Text = dgvNhanVien.CurrentRow.Cells[2].Value.ToString().Trim();
            cbGioiTinh.Text = dgvNhanVien.CurrentRow.Cells[3].Value.ToString().Trim();
            txtCMND.Text = dgvNhanVien.CurrentRow.Cells[4].Value.ToString().Trim();
            txtDiaChi.Text = dgvNhanVien.CurrentRow.Cells[5].Value.ToString().Trim();
            txtSoDT.Text = dgvNhanVien.CurrentRow.Cells[6].Value.ToString().Trim();
            txtEmail.Text = dgvNhanVien.CurrentRow.Cells[7].Value.ToString().Trim();
            cbChucVu.Text = dgvNhanVien.CurrentRow.Cells[8].Value.ToString().Trim();
            txtNgayVaoLam.Text = dgvNhanVien.CurrentRow.Cells[9].Value.ToString().Trim();
        }
    }
}
