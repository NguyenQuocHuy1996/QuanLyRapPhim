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
    public partial class FormQuayVe : Form
    {
        public FormQuayVe()
        {
            InitializeComponent();
        }
        public FormQuayVe(string taikhoan,string quyen)
        {
            InitializeComponent();
            lbUser.Text += " " + taikhoan;
        }

        private void FormChinh_Load(object sender, EventArgs e)
        {
            try
            {
            GetOneDataBUS np = new GetOneDataBUS();
            PhimDTO phim;
            //Phim 1
            phim = np.GetOnePhimBUS(GetData.GetPhim().Tables[0].Rows[0][0].ToString().Trim());
            pictureBox1.Image = ConvertImage.ConvertByteToImage(phim.HinhAnh);
            label1.Text = GetData.GetPhim().Tables[0].Rows[0][1].ToString().Trim();

            //Phim 2
            phim = np.GetOnePhimBUS(GetData.GetPhim().Tables[0].Rows[1][0].ToString().Trim());
            pictureBox2.Image = ConvertImage.ConvertByteToImage(phim.HinhAnh);
            label2.Text = GetData.GetPhim().Tables[0].Rows[1][1].ToString().Trim();

            //Phim 3
            phim = np.GetOnePhimBUS(GetData.GetPhim().Tables[0].Rows[2][0].ToString().Trim());
            pictureBox3.Image = ConvertImage.ConvertByteToImage(phim.HinhAnh);
            label3.Text = GetData.GetPhim().Tables[0].Rows[2][1].ToString().Trim();

            //Phim 4
            phim = np.GetOnePhimBUS(GetData.GetPhim().Tables[0].Rows[3][0].ToString().Trim());
            pictureBox4.Image = ConvertImage.ConvertByteToImage(phim.HinhAnh);
            label4.Text = GetData.GetPhim().Tables[0].Rows[3][1].ToString().Trim();

            //Phim 5
            phim = np.GetOnePhimBUS(GetData.GetPhim().Tables[0].Rows[4][0].ToString().Trim());
            pictureBox5.Image = ConvertImage.ConvertByteToImage(phim.HinhAnh);
            label5.Text = GetData.GetPhim().Tables[0].Rows[4][1].ToString().Trim();

            //Phim 6
            phim = np.GetOnePhimBUS(GetData.GetPhim().Tables[0].Rows[5][0].ToString().Trim());
            pictureBox6.Image = ConvertImage.ConvertByteToImage(phim.HinhAnh);
            label6.Text = GetData.GetPhim().Tables[0].Rows[5][1].ToString().Trim();

            //Phim 7
            phim = np.GetOnePhimBUS(GetData.GetPhim().Tables[0].Rows[6][0].ToString().Trim());
            pictureBox7.Image = ConvertImage.ConvertByteToImage(phim.HinhAnh);
            label7.Text = GetData.GetPhim().Tables[0].Rows[6][1].ToString().Trim();

            //Phim 8
            phim = np.GetOnePhimBUS(GetData.GetPhim().Tables[0].Rows[7][0].ToString().Trim());
            pictureBox8.Image = ConvertImage.ConvertByteToImage(phim.HinhAnh);
            label8.Text = GetData.GetPhim().Tables[0].Rows[7][1].ToString().Trim();

            //Phim 9
            phim = np.GetOnePhimBUS(GetData.GetPhim().Tables[0].Rows[8][0].ToString().Trim());
            pictureBox9.Image = ConvertImage.ConvertByteToImage(phim.HinhAnh);
            label9.Text = GetData.GetPhim().Tables[0].Rows[8][1].ToString().Trim();

            //Phim 10
            phim = np.GetOnePhimBUS(GetData.GetPhim().Tables[0].Rows[9][0].ToString().Trim());
            pictureBox10.Image = ConvertImage.ConvertByteToImage(phim.HinhAnh);
            label10.Text = GetData.GetPhim().Tables[0].Rows[9][1].ToString().Trim();
            }           
            catch (Exception)
            {                
                MessageBox.Show("Không có thông tin phim");
            }
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
            FormQuayVe show = new FormQuayVe();
            show.Show();
            this.Close();
        }

        private void FormChinh_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }
    }
}
