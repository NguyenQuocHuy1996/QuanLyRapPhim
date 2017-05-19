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
        int i, tongtien;
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
            i = 1;
            tongtien = 0;
            dgvThucAnTam.DataSource = GetData.GetThucAnTam().Tables[0];

            //Xoa trắng CSDL mỗi khi thoát chương trình
            int u = GetData.GetThucAnTam().Tables[0].Rows.Count;
            for (int j = 0; j < u; j++)
            {
                //Xoa dòng đầu tiên
                int id;
                id = Convert.ToInt32(dgvThucAnTam.CurrentRow.Cells[0].Value.ToString().Trim());

                ThucAn_TamDTO thucantam = new ThucAn_TamDTO(id);
                int xoathucantam = new XoaBUS().XoaThucAnTamBUS(thucantam);

                dgvThucAnTam.DataSource = GetData.GetThucAnTam().Tables[0];
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Button bt = (Button)sender;
            if (check == true)
            {
                //Them thuc an
                string thucan;
                int gia, id;

                id = Convert.ToInt32(i);
                thucan = Convert.ToString(GetData.GetThucAnDK(bt.Text.ToString().Trim()).Tables[0].Rows[0][0].ToString().Trim());
                gia = Convert.ToInt32(GetData.GetThucAnDK(bt.Text.ToString().Trim()).Tables[0].Rows[0][1].ToString().Trim());

                ThucAn_TamDTO thucantam = new ThucAn_TamDTO(id,thucan, gia);
                int themthucantam = new ThemBUS().ThemThucAn_TamBUS(thucantam);

                i = i + 1;
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
                int gia, id;
                id = Convert.ToInt32(dgvThucAnTam.CurrentRow.Cells[0].Value.ToString().Trim());
                thucan = Convert.ToString(dgvThucAnTam.CurrentRow.Cells[1].Value.ToString().Trim());
                gia = Convert.ToInt32(dgvThucAnTam.CurrentRow.Cells[2].Value.ToString().Trim());

                ThucAn_TamDTO thucantam = new ThucAn_TamDTO(id,thucan, gia);
                int xoathucantam = new XoaBUS().XoaThucAnTamBUS(thucantam);

                dgvThucAnTam.DataSource = GetData.GetThucAnTam().Tables[0];
                i = 1;
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
            check = false;
        }

        private void dgvThucAnTam_CellClick(object sender, DataGridViewCellEventArgs e)
        {
        }

        private void btnLamMoi_Click(object sender, EventArgs e)
        {
            i = 1;
            tongtien = 0;
            //Xoa trắng CSDL mỗi khi thoát chương trình
            int u = GetData.GetThucAnTam().Tables[0].Rows.Count;
            for (int j = 0; j < u; j++)
            {
                //Xoa dòng đầu tiên
                int id;
                id = Convert.ToInt32(dgvThucAnTam.CurrentRow.Cells[0].Value.ToString().Trim());

                ThucAn_TamDTO thucantam = new ThucAn_TamDTO(id);
                int xoathucantam = new XoaBUS().XoaThucAnTamBUS(thucantam);

                dgvThucAnTam.DataSource = GetData.GetThucAnTam().Tables[0];
            }
            lbTongTien.Text = "";
            check = true;
        }
    }
}
