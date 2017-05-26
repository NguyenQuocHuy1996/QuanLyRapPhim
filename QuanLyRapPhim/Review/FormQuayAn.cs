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
    public partial class FormQuayAn : Form
    {
        int tongtien;

        bool check = true;

        public FormQuayAn()
        {
            InitializeComponent();
        }

        public FormQuayAn(string taikhoan,string quyen)
        {
            InitializeComponent();
            lbUser.Text += " " +  taikhoan;
        }

        private void FormQuayAn_Load(object sender, EventArgs e)
        {
            tongtien = 0;

            label2.Hide();

            dgvThucAnTam.DataSource = GetData.GetThucAnTam().Tables[0];
            dgvThucAnTam.GridColor = Color.Blue;
            dgvThucAnTam.BackgroundColor = Color.White;
            dgvThucAnTam.ForeColor = Color.Black;

            //Xoa trắng CSDL mỗi khi thoát chương trình
            int u = GetData.GetThucAnTam().Tables[0].Rows.Count;
            for (int j = 0; j < u; j++)
            {
                //Xoa dòng đầu tiên
                string tenthucan;
                tenthucan = Convert.ToString(dgvThucAnTam.CurrentRow.Cells[0].Value.ToString().Trim());

                ThucAn_TamDTO thucantam = new ThucAn_TamDTO(tenthucan);
                int xoathucantam = new XoaBUS().XoaThucAnTamBUS(thucantam);

                dgvThucAnTam.DataSource = GetData.GetThucAnTam().Tables[0];
            }
            new ResetIndexBUS().ResetSTTBUS();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Button bt = (Button)sender;
            if (check == true)
            {
                btnThanhToan.Enabled = btnLamMoi.Enabled = btnTang.Enabled = btnGiam.Enabled = true;

                //Them thuc an
                string thucan;
                int gia;
                //int id;

                //id = Convert.ToInt32(i);
                thucan = Convert.ToString(GetData.GetThucAnDK(bt.Text.ToString().Trim()).Tables[0].Rows[0][0].ToString().Trim());
                gia = Convert.ToInt32(GetData.GetThucAnDK(bt.Text.ToString().Trim()).Tables[0].Rows[0][1].ToString().Trim());

                ThucAn_TamDTO thucantam = new ThucAn_TamDTO(thucan, gia);
                int themthucantam = new ThemBUS().ThemThucAn_TamBUS(thucantam);

                dgvThucAnTam.DataSource = GetData.GetThucAnTam().Tables[0];

                //Cộng tổng tiền
                tongtien = tongtien + gia;
                lbTongTien.Text = String.Format("{0:0,0}",tongtien);                
            }
        }

        private void btnBoChon_Click(object sender, EventArgs e)
        {
            try
            {
                string thucan;
                thucan = Convert.ToString(dgvThucAnTam.CurrentRow.Cells[0].Value.ToString().Trim());

                ThucAn_TamDTO thucantam = new ThucAn_TamDTO(thucan);
                int xoathucantam = new XoaBUS().XoaThucAnTamBUS(thucantam);

                ResetIndexBUS reset = new ResetIndexBUS();

                dgvThucAnTam.DataSource = GetData.GetThucAnTam().Tables[0];
            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.Message);
            }
            catch (Exception)
            {
                MessageBox.Show("Không có item để xóa");
            }
        }

        private void btnThanhToan_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Thanh toán thành công");
        }

        private void btnLamMoi_Click(object sender, EventArgs e)
        {
            tongtien = 0;

            //Xoa trắng CSDL mỗi khi thoát chương trình
            int u = GetData.GetThucAnTam().Tables[0].Rows.Count;
            for (int j = 0; j < u; j++)
            {
                //Xoa dòng đầu tiên
                string tenthucan;
                tenthucan = Convert.ToString(dgvThucAnTam.CurrentRow.Cells[0].Value.ToString().Trim());

                ThucAn_TamDTO thucantam = new ThucAn_TamDTO(tenthucan);
                int xoathucantam = new XoaBUS().XoaThucAnTamBUS(thucantam);

                dgvThucAnTam.DataSource = GetData.GetThucAnTam().Tables[0];
            }
            new ResetIndexBUS().ResetSTTBUS();

            lbTongTien.Text = "0";
            check = true;
            btnThanhToan.Enabled = btnLamMoi.Enabled = btnTang.Enabled = btnGiam.Enabled = false;
        }

        private void btnDangXuat_Click(object sender, EventArgs e)
        {
            Login login = new Login();
            login.Show();
            this.Close();
        }

        private void FormQuayAn_FormClosing(object sender, FormClosingEventArgs e)
        {
            //Xoa trắng CSDL mỗi khi thoát chương trình
            int u = GetData.GetThucAnTam().Tables[0].Rows.Count;
            for (int j = 0; j < u; j++)
            {
                //Xoa dòng đầu tiên
                string tenthucan;
                tenthucan = Convert.ToString(dgvThucAnTam.CurrentRow.Cells[0].Value.ToString().Trim());

                ThucAn_TamDTO thucantam = new ThucAn_TamDTO(tenthucan);
                int xoathucantam = new XoaBUS().XoaThucAnTamBUS(thucantam);

                dgvThucAnTam.DataSource = GetData.GetThucAnTam().Tables[0];
            }
            new ResetIndexBUS().ResetSTTBUS();

            Application.Exit();
        }

        private void btnTang_Click(object sender, EventArgs e)
        {
            string tenthucan;

            tenthucan = label2.Text;

            ThucAn_TamDTO thucan = new ThucAn_TamDTO(tenthucan);
            int tangthucantam = new SuaBUS().TangThucAnTamBUS(thucan);

            dgvThucAnTam.DataSource = GetData.GetThucAnTam().Tables[0];
        }

        private void btnGiam_Click(object sender, EventArgs e)
        {
            string tenthucan;

            tenthucan = label2.Text;

            ThucAn_TamDTO thucan = new ThucAn_TamDTO(tenthucan);
            int giamthucantam = new SuaBUS().GiamThucAnTamBUS(thucan);

            dgvThucAnTam.DataSource = GetData.GetThucAnTam().Tables[0];

        }

        private void dgvThucAnTam_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            label2.Text = dgvThucAnTam.CurrentRow.Cells[0].Value.ToString().Trim();
        }
    }
}
