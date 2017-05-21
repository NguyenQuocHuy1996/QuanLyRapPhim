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
    public partial class Ghe : Form
    {
        List<Label> listlabel = new List<Label>();
        List<Label> removelabel = new List<Label>();

        public Ghe()
        {
            InitializeComponent();
        }

        private void Ghe_Load(object sender, EventArgs e)
        {
            cbTenRP.DataSource = GetData.GetRapPhim().Tables[0];
            cbTenRP.DisplayMember = "TenRapPhim";
            cbTenRP.ValueMember = "MaRapPhim";

            cbTenPhim.DataSource = GetData.GetPhim().Tables[0];
            cbTenPhim.DisplayMember = "TenPhim";
            cbTenPhim.ValueMember = "MaPhim";

            for (int i = 0; i <= 7; i++)
            {
                cbNgay.Items.Add(DateTime.Today.AddDays(+i).ToString().Substring(0, 10));
            }
        }

        private void cbNgay_SelectedIndexChanged(object sender, EventArgs e)
        {
            cbGio.DataSource = GetData.GetGioChieu(cbTenRP.SelectedValue.ToString(), cbTenPhim.SelectedValue.ToString(), cbNgay.Text.ToString()).Tables[0];
            cbGio.DisplayMember = "GioChieu";
        }

        private void cbGio_SelectedIndexChanged(object sender, EventArgs e)
        {
            Remove_Label();
            Create_Label();
        }

        private void btnXemGhe_Click(object sender, EventArgs e)
        {
            Create_Label();
        }

        private void btnMuaVe_Click(object sender, EventArgs e)
        {
            foreach (Label lb in listlabel)
            {
                lb.BackColor = Color.Orange;

                string MaRP, TenRP, MaPhim, TenPhim, NgayChieu, GioChieu, SoGhe;

                MaRP = Convert.ToString(cbTenRP.SelectedValue.ToString());
                TenRP = Convert.ToString(cbTenRP.Text.ToString());
                MaPhim = Convert.ToString(cbTenPhim.SelectedValue.ToString());
                TenPhim = Convert.ToString(cbTenPhim.Text.ToString());
                NgayChieu = Convert.ToString(cbNgay.SelectedItem.ToString());
                GioChieu = Convert.ToString(cbGio.Text.ToString());
                SoGhe = Convert.ToString(lb.Name);

                GheDTO ghe = new GheDTO(MaRP, TenRP, MaPhim, TenPhim, NgayChieu, GioChieu, SoGhe);
                int themghe = new ThemBUS().ThemGheBUS(ghe);
            }
            listlabel = new List<Label>();
            MessageBox.Show("Mua vé thành công");
        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            foreach (Label lb in listlabel)
            {
                lb.BackColor = Color.GhostWhite;
            }
            listlabel = new List<Label>();
        }

        private void Create_Label()
        {
            int top = 50; // Vi chi top
            for (int i = 1; i <= 10; i++) // Tao ra 5 label doc
            {
                int left = 628; // Vi tri left 
                for (int j = 1; j <= 10; j++) // Tao ra 5 label ngang
                {
                    Label lb = new Label();
                    lb.Name = i.ToString() + j.ToString();
                    lb.Text = j.ToString();
                    lb.Tag = string.Format("[{0},{1}]", i, j);
                    lb.Size = new Size(50, 50);
                    lb.TextAlign = ContentAlignment.MiddleCenter;
                    lb.Left = left += 60;
                    lb.Top = top;
                    lb.ForeColor = Color.Black;

                    //Set màu cho ghế dựa vào trang thái
                    if (GetData.GetGhe(cbTenRP.SelectedValue.ToString(), cbTenPhim.SelectedValue.ToString(), cbNgay.Text.ToString(), cbGio.Text.ToString(), lb.Name.ToString()).Tables[0].Rows.Count == 1) // Đã có
                    {
                        lb.BackColor = Color.Orange;
                    }
                    else //chưa có
                    {
                        lb.BackColor = Color.GhostWhite;
                    }

                    //Tạo sự kiên cho label và gán tới hàm sử lý sự kiện
                    lb.Click += new EventHandler(lb_Click);

                    this.Controls.Add(lb);

                    removelabel.Add(lb);
                }
                top += 60;
            }
        }

        private void lb_Click(object sender, EventArgs e)
        {
            Label lb = (Label)sender;

            if (lb.BackColor != Color.Orange)
            {
                if (lb.BackColor == Color.GhostWhite)
                {
                    lb.BackColor = Color.Blue;
                    listlabel.Add(lb);
                }
                else
                {
                    lb.BackColor = Color.GhostWhite;
                    listlabel.Remove(lb);
                }
            }
            else
            {
                MessageBox.Show("Ghế đã có người ngồi");
            }
        }

        private void Remove_Label()
        {
            foreach (Label l in removelabel)
            {
                this.Controls.Remove(l);
            }
        }

        private void Ghe_FormClosing(object sender, FormClosingEventArgs e)
        {
            FormQuayVe quayve = new FormQuayVe();
            quayve.Show();
            this.Hide();
        }

        private void btnQuayLai_Click(object sender, EventArgs e)
        {
            FormQuayVe quayve = new FormQuayVe();
            quayve.Show();
            this.Hide();
        }
    }
}
