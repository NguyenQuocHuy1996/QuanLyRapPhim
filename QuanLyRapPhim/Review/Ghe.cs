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

            dgvVe.DataSource = GetData.GetVe().Tables[0];

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

                string MaRP, TenRP, MaPhim, TenPhim, NgayChieu, GioChieu, SoGhe, loaighe;
                int giave;

                MaRP = Convert.ToString(cbTenRP.SelectedValue.ToString());
                TenRP = Convert.ToString(cbTenRP.Text.ToString());
                MaPhim = Convert.ToString(cbTenPhim.SelectedValue.ToString());
                TenPhim = Convert.ToString(cbTenPhim.Text.ToString());
                NgayChieu = Convert.ToString(cbNgay.SelectedItem.ToString());
                GioChieu = Convert.ToString(cbGio.Text.ToString());

                SoGhe = Convert.ToString(lb.Name);

                if (lb.Text == "D4" || lb.Text == "D5" || lb.Text == "D6" || lb.Text == "D7" || lb.Text == "E4" || lb.Text == "E5" || lb.Text == "E6" || lb.Text == "E7" || lb.Text == "D4" || lb.Text == "F4" || lb.Text == "F5" || lb.Text == "F6" || lb.Text == "D4" || lb.Text == "F7" || lb.Text == "G4" || lb.Text == "G5" || lb.Text == "G6" || lb.Text == "G7")
                {
                    loaighe = "VIP";
                    giave = 75000;
                }
                else
                {
                    loaighe = "Thường";
                    giave = 70000;
                }

                GheDTO ghe = new GheDTO(MaRP, TenRP, MaPhim, TenPhim, NgayChieu, GioChieu, SoGhe);
                int themghe = new ThemBUS().ThemGheBUS(ghe);

                VeDTO ve = new VeDTO(TenPhim,NgayChieu,GioChieu,SoGhe,loaighe,giave);
                int themve = new ThemBUS().ThemVeBUS(ve);
                dgvVe.DataSource = GetData.GetVe().Tables[0];
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
            string day;
            int index = 0;
            int top = 50; // Vi chi top
            for (int i = 0; i <= 9; i++) // Tao ra 5 label doc
            {
                if (i == 0)
                {
                    day = "A";
                    if (day == "A")
                    {
                        index = 0;
                    }
                }
                else if (i == 1)
                {
                    day = "B";
                    if (day == "B")
                    {
                        index = 0;
                    }
                }
                else if (i == 2)
                {
                    day = "C";
                    if (day == "C")
                    {
                        index = 0;
                    }
                }
                else if (i == 3)
                {
                    day = "D";
                    if (day == "D")
                    {
                        index = 0;
                    }
                }
                else if (i == 4)
                {
                    day = "E";
                    if (day == "E")
                    {
                        index = 0;
                    }
                }
                else if (i == 5)
                {
                    day = "F";
                    if (day == "F")
                    {
                        index = 0;
                    }
                }
                else if (i == 6)
                {
                    day = "G";
                    if (day == "G")
                    {
                        index = 0;
                    }
                }
                else if (i == 7)
                {
                    day = "H";
                    if (day == "H")
                    {
                        index = 0;
                    }
                }
                else if (i == 8)
                {
                    day = "I";
                    if (day == "I")
                    {
                        index = 0;
                    }
                }
                else
                {
                    day = "J";
                    if (day == "J")
                    {
                        index = 0;
                    }
                }

                int left = 628; // Vi tri left 
                for (int j = 0; j <= 9; j++) // Tao ra 5 label ngang
                {
                    index += 1;

                    Label lb = new Label();
                    lb.Name = i.ToString() + j.ToString();
                    lb.Text = Convert.ToString(day + index);
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
