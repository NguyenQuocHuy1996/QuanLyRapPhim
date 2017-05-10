﻿using System;
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
        bool user = true, login = false;
        public Login()
        {
            InitializeComponent();
        }

        private void Login_Load(object sender, EventArgs e)
        {
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            dt = GetData.GetTaiKhoanDK(txtTaiKhoan.Text, txtMatKhau.Text);

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
                if (dt.Tables[0].Rows.Count == 1)
                {
                    lbThongBao.Text = "Đăng nhập thành công";
                    quyen = dt.Tables[0].Rows[0][3].ToString();
                    taikhoan = dt.Tables[0].Rows[0][1].ToString();
                    if (quyen == "Admin")
                    {
                        lbThongBao.Text = "Xin chào admin";
                    }
                    else if (quyen == "Quản lý")
                    {
                        FormQuanLy show = new FormQuanLy(taikhoan,quyen);
                        show.Show();
                        this.Close();
                    }
                    else
                    {
                        FormChinh show = new FormChinh(taikhoan, quyen, user, login);
                        show.Show();
                        this.Close();
                    }
                }
                else
                {
                    txtTaiKhoan.Text = txtMatKhau.Text = "";
                    lbThongBao.Text = "Sai tên tài khoản hoặc mật khẩu";
                }
            }
        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            Register formRegister = new Register();
            formRegister.ShowDialog();
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
    }
}