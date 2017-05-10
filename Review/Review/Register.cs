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
            cbGioiTinh.Items.Add("Nam");
            cbGioiTinh.Items.Add("Nữ");
            for (int i = 1; i<=31; i++)
            {
                cbNgay.Items.Add(i);
            }

            for (int i = 1; i <= 12; i++)
            {
                cbThang.Items.Add(i);
            }

            for(int i = 1990; i<= 2017; i++)
            {
                cbNam.Items.Add(i);
            }
        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            if (txtMatKhau.Text == txtRePass.Text)
            {
                //Them vao bang Khach Hang
                try
                {
                    KhachHangDTO kh = new KhachHangDTO();

                    kh.TaiKhoan = Convert.ToString(txtTaiKhoan.Text);
                    kh.MatKhau = Convert.ToString(txtMatKhau.Text);
                    kh.HoTen = Convert.ToString(txtHoTen.Text);
                    kh.GioiTinh = Convert.ToString(cbGioiTinh.Text);
                    kh.NgaySinh = Convert.ToString(cbNgay.Text) + "/" + Convert.ToString(cbThang.Text) + "/" + Convert.ToString(cbNam.Text);
                    kh.CMND = Convert.ToInt32(txtCMND.Text);
                    kh.DiaChi = Convert.ToString(txtDiaChi.Text);
                    kh.Email = Convert.ToString(txtEmail.Text);
                    kh.SDT = Convert.ToInt32(txtSDT.Text);

                    KhachHangDTO khachhang = new KhachHangDTO(kh.TaiKhoan, kh.MatKhau, kh.HoTen, kh.GioiTinh, kh.NgaySinh, kh.CMND, kh.DiaChi, kh.Email, kh.SDT);
                    int themkhachhang = new ThemBUS().ThemKhachHangBUS(khachhang);

                    //Them vao bang Tai Khoan
                    TaiKhoanDTO tk = new TaiKhoanDTO();

                    tk.TaiKhoan = Convert.ToString(txtTaiKhoan.Text);
                    tk.MatKhau = Convert.ToString(txtMatKhau.Text);
                    tk.LoaiTaiKhoan = Convert.ToString("User");

                    TaiKhoanDTO taikhoan = new TaiKhoanDTO(tk.TaiKhoan, tk.MatKhau, tk.LoaiTaiKhoan);
                    int themtaikhoan = new ThemBUS().ThemTaiKhoanBUS(taikhoan);
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
            else
            {
                lbRepass.Text = "Mật khẩu nhập lại chưa chính xác";
            }
            //Close();
        }

        private void btnKiemTra_Click(object sender, EventArgs e)
        {
        }
    }
}
