using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Review
{
    public partial class FormChinh : Form
    {
        bool user = false, login = true;
        public FormChinh()
        {
            InitializeComponent();
        }
        public FormChinh(string taikhoan,string quyen, bool user, bool login)
        {
            InitializeComponent();
            lbUser.Text += " " + taikhoan;
            this.user = user;
            this.login = login;
        }

        private void FormChinh_Load(object sender, EventArgs e)
        {
            cbTenPhim.DataSource = GetData.GetPhim().Tables[0];
            cbTenPhim.DisplayMember = "TenPhim";

            lbUser.Visible = user;
            btnLogin.Visible = login;
            btnLogin.Visible = login;
            btnLogOut.Visible = user;
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            Login formLogin = new Login();
            formLogin.ShowDialog();
            this.Hide();
        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            Register formRegister = new Register();
            formRegister.ShowDialog();
        }

        private void btnDepositTicket_Click(object sender, EventArgs e)
        {
            Phim formPhim = new Phim();
            formPhim.ShowDialog();
        }

        private void cbTenPhim_SelectedIndexChanged(object sender, EventArgs e)
        {
        
        }

        private void btnLogOut_Click(object sender, EventArgs e)
        {
            FormChinh show = new FormChinh();
            show.Show();
            this.Close();
        }

        private void FormChinh_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }
    }
}
