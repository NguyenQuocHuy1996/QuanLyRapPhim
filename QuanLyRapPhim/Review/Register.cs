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
    public partial class Register : Form
    {
        public Register()
        {
            InitializeComponent();
        }

        private void Register_Load(object sender, EventArgs e)
        {
            dgvNV.DataSource = GetData.GetNhanVien_TK().Tables[0];
            dgvTK.DataSource = GetData.GetTaiKhoan().Tables[0];
        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            if (txtTaiKhoan.Text != "" || txtMatKhau.Text != "")
            {
                if (txtMatKhau.Text == txtRePass.Text)
                {
                    try
                    {
                        //Them vao bang Tai Khoan
                        TaiKhoanDTO tk = new TaiKhoanDTO();

                        tk.TaiKhoan = Convert.ToString(txtTaiKhoan.Text);
                        tk.MatKhau = Convert.ToString(txtMatKhau.Text);
                        tk.MaNV = Convert.ToString(txtMaNV.Text);
                        tk.TenNV = Convert.ToString(txtHoTen.Text);
                        tk.NgaySinh = Convert.ToString(txtNgaySinh.Text);
                        tk.ChucVu = Convert.ToString(txtChucVu.Text);

                        TaiKhoanDTO taikhoan = new TaiKhoanDTO(tk.TaiKhoan, tk.MatKhau, tk.MaNV, tk.TenNV, tk.NgaySinh, tk.ChucVu);
                        int themtaikhoan = new ThemBUS().ThemTaiKhoanBUS(taikhoan);

                        dgvTK.DataSource = GetData.GetTaiKhoan().Tables[0];
                        MessageBox.Show("Thêm tài khoản thành công");
                        txtTaiKhoan.Text = txtMatKhau.Text = txtRePass.Text = txtMaNV.Text = txtHoTen.Text = txtChucVu.Text = txtNgaySinh.Text = lbRepass.Text = "";
                    }
                    catch (SqlException ex)
                    {
                        MessageBox.Show(ex.Message);
                    }
                    catch (Exception)
                    {
                        MessageBox.Show("Điền đầy đủ thông tin");
                    }
                }
                else
                {
                    lbRepass.Text = "Mật khẩu nhập lại không chính xác";
                }
                
            }
            else
            {
                lbRepass.Text = "Tài khoản và mật khẩu không được để trống";
            }
        }

        private void btnKiemTra_Click(object sender, EventArgs e)
        {
            if (GetData.GetTaiKhoanDK(txtTaiKhoan.Text.ToString()).Tables[0].Rows.Count == 1)
            {
                lbRepass.Text = "Tài khoản đã có, chọn tài khoản khác";
            }
            else if(txtTaiKhoan.Text == "")
            {
                lbRepass.Text = "Nhập vào tên tài khoản";
            }
            else
            {
                lbRepass.Text = "Bạn có thể sử dụng tài khoản này";
            }
                    
        }

        private void dgvNV_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txtHoTen.Text = dgvNV.CurrentRow.Cells[0].Value.ToString().Trim();
            txtChucVu.Text = dgvNV.CurrentRow.Cells[1].Value.ToString().Trim();
            txtNgaySinh.Text = dgvNV.CurrentRow.Cells[2].Value.ToString().Trim();
            txtMaNV.Text = dgvNV.CurrentRow.Cells[3].Value.ToString().Trim();
        }

        private void btnDeleteAcc_Click(object sender, EventArgs e)
        {
            try
            {
                string taikhoan;

                taikhoan = Convert.ToString(dgvTK.CurrentRow.Cells[0].Value.ToString().Trim());

                TaiKhoanDTO tk = new TaiKhoanDTO(taikhoan);
                int themrapphim = new XoaBUS().XoaTaiKhoanBUS(tk);

                dgvTK.DataSource = GetData.GetTaiKhoan().Tables[0];

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

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtTaiKhoan.Text = txtMatKhau.Text = txtRePass.Text = txtHoTen.Text = txtMaNV.Text = txtChucVu.Text = txtNgaySinh.Text = "";
        }
    }
}
