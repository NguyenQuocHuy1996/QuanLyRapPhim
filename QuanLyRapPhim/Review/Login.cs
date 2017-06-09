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
    public partial class Login : Form
    {
        DataSet dt;
        string quyen, taikhoan;
        public Login()
        {
            InitializeComponent();
        }

        private void Login_Load(object sender, EventArgs e)
        {
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            if (txtTaiKhoan.Text == "" && txtMatKhau.Text != "")
            {
                lbThongBao.Text = "Nhập tài khoản";
            }
            else if (txtMatKhau.Text == "" && txtTaiKhoan.Text != "")
            {
                lbThongBao.Text = "Nhập mật khẩu";
            }
            else  if (txtTaiKhoan.Text == "" && txtMatKhau.Text == "")
            {
                lbThongBao.Text = "Nhập tài khoản và mật khẩu";
            }
            else
            {
                try
                {
                    dt = GetData.GetTaiKhoanDK2(txtTaiKhoan.Text,txtMatKhau.Text);
                    if (dt.Tables[0].Rows.Count == 1)
                    {
                        lbThongBao.Text = "Đăng nhập thành công";
                        quyen = dt.Tables[0].Rows[0][5].ToString();
                        taikhoan = dt.Tables[0].Rows[0][0].ToString();

                        if (quyen == "Nhân viên quầy vé")
                        {
                            FormQuayVe quayve = new FormQuayVe(taikhoan, quyen);
                            quayve.Show();
                            this.Hide();
                        }
                        else if (quyen == "Nhân viên quầy ăn")
                        {
                            FormQuayAn quayan = new FormQuayAn(taikhoan, quyen);
                            quayan.Show();
                            this.Hide();
                        }
                        else
                        {
                            FormQuanLy quanly = new FormQuanLy(taikhoan, quyen);
                            quanly.Show();
                            this.Hide();
                        }
                    }
                    else
                    {
                        txtTaiKhoan.Text = txtMatKhau.Text = "";
                        lbThongBao.Text = "Sai tên tài khoản hoặc mật khẩu";
                    }
                }
                catch (Exception err) {
                    throw err;
                };
            }
        }

        private void cbPass_CheckedChanged(object sender, EventArgs e)
        {
            if (cbPass.Checked)
            {
                txtMatKhau.UseSystemPasswordChar = false;
            }
            else
            {
                txtMatKhau.UseSystemPasswordChar = true;
            }
        }

        private void Login_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }
    }
}
