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
    public partial class Ghe : Form
    {
        private bool c1, c2, c3, c4, c5;
        private string MaPhim, TenPhim, NgayChieu, GioChieu;
        //private List<string> SoGhe;

        public Ghe()
        {
            InitializeComponent();
        }
        public Ghe(string label1, string label2, string label3, string label4)
        {
            InitializeComponent();
            MaPhim = label1;
            TenPhim = label2;
            NgayChieu = label3;
            GioChieu = label4;
        }

        private void Ghe_Load(object sender, EventArgs e)
        {
            c1 = c2 = c3 = c4 = c5 = false;
            //SoGhe = new List<string>();
            label1.Text = MaPhim;
            label2.Text = TenPhim;
            label3.Text = NgayChieu;
            label4.Text = GioChieu;
            dataGridView1.DataSource = GetRapPhim().Tables[0];
            //Load trang thai
            GetOneDataBUS  np = new GetOneDataBUS();
            GheDTO rapphim = np.GetOnePhongChieuBUS(label1.Text);
            checkBox1.Checked = Convert.ToBoolean(rapphim.G1.ToString());
            checkBox2.Checked = Convert.ToBoolean(rapphim.G2.ToString());
            checkBox3.Checked = Convert.ToBoolean(rapphim.G3.ToString());
            checkBox4.Checked = Convert.ToBoolean(rapphim.G4.ToString());
            checkBox5.Checked = Convert.ToBoolean(rapphim.G5.ToString());

            cbDoiTuong.Items.Add("HS-SV");
            cbDoiTuong.Items.Add("Người lớn");
            cbDoiTuong.Items.Add("Voucher");
            cbDoiTuong.Items.Add("Đặt vé");

            cbGiaVe.Items.Add("45000");
            cbGiaVe.Items.Add("50000");
            cbGiaVe.Items.Add("70000");
            cbGiaVe.Items.Add("75000");

            cbLoaiGhe.Items.Add("Thường");
            cbLoaiGhe.Items.Add("VIP");
            cbLoaiGhe.Items.Add("SweetBox");
        }
        private DataSet GetRapPhim()
        {
            string sql = "SELECT * FROM RapPhim where MaPhim= N'" + label1.Text + "'";
            return (new GetDataBUS().GetPhongChieuBUS(sql));
        }
        private void CheckCB()
        {
            if (checkBox1.Checked)
            {
                c1 = true;
            }
            else
            {
                c1 = false;
            }
            if (checkBox2.Checked)
            {
                c2 = true;
            }
            else
            {
                c2 = false;
            }
            if (checkBox3.Checked)
            {
                c3 = true;
            }
            else
            {
                c3 = false;
            }
            if (checkBox4.Checked)
            {
                c4 = true;
            }
            else
            {
                c4 = false;
            }
            if (checkBox5.Checked)
            {
                c5 = true;
            }
            else
            {
                c5 = false;
            }
        }

        //Ghe FULL
        private void checkBox1_MouseClick(object sender, MouseEventArgs e)
        {
            CheckBox chbbox = (CheckBox)sender;
            if (chbbox.Checked == false)
            {
                MessageBox.Show("Ghế đã có người ngồi");
                chbbox.Checked = true;
            }

            label5.Text = chbbox.Text;
        }

        private void Button3_Click(object sender, EventArgs e)
        {
            c1 = c2 = c3 = c4 = c5 = false;
        }

        private void btnBuy_Ticket_Click(object sender, EventArgs e)
        {
            //Cập nhật lại trạng thái ghế
            try
            {                
                DTO.GheDTO rap = new GheDTO();

                CheckCB();
                rap.MaPhim = label1.Text;
                rap.G1 = c1;
                rap.G2 = c2;
                rap.G3 = c3;
                rap.G4 = c4;
                rap.G5 = c5;
                BUS.SuaBUS sua = new SuaBUS();
                sua.Insert_PhongChieuBUS(rap);

                dataGridView1.DataSource = GetRapPhim().Tables[0];                
            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.Message);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            //Thêm vào bản vé
            try
            {
                string tenPhim, ngayChieu, gioChieu, soGhe, loaiGhe, doiTuong;
                int giaVe;
                tenPhim = Convert.ToString(label2.Text);
                ngayChieu = Convert.ToString(label3.Text);
                gioChieu = Convert.ToString(label4.Text);
                soGhe = Convert.ToString(label5.Text);
                loaiGhe = Convert.ToString(cbLoaiGhe.Text);
                doiTuong = Convert.ToString(cbDoiTuong.Text);
                giaVe = Convert.ToInt32(cbGiaVe.Text);

                VeDTO ve = new VeDTO(tenPhim, ngayChieu, gioChieu, soGhe, loaiGhe, doiTuong, giaVe);
                int themve = new ThemBUS().Them_VeBUS(ve);
            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.Message);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            MessageBox.Show("Mua vé thành công");
            //Chuyen form
            Review.Ve show = new Ve(label2.Text, label3.Text, label4.Text, label5.Text, cbLoaiGhe.Text, cbDoiTuong.Text,Convert.ToInt32(cbGiaVe.Text));
            this.Visible = false;
            show.ShowDialog();
            this.Visible = true;
        }
    }
}
