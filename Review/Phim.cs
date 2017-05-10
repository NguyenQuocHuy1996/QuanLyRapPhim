using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;

using BUS;
using DTO;
using System.IO;

namespace Review
{
    public partial class Phim : Form
    {
        public Phim()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            cbTenPhim.DataSource = GetData.GetPhim().Tables[0];
            cbTenPhim.DisplayMember = "TenPhim";
            cbTenPhim.ValueMember = "MaPhim";
            cbTenPhim.Text = "";
        }

        private DataSet NgayChieu()
        {
            try
            {
                string sql = "Select L.* from LichChieu L, Phim P Where L.MaPhim = P.MaPhim and P.MaPhim =N'" + cbTenPhim.SelectedValue.ToString() + "'";
                return (new GetDataBUS().GetNgayChieuBUS(sql));
            }
            catch (SqlException ex)
            {
                throw ex;
            }
        }

        private DataSet GioChieu()
        {
            try
            {
                string sql = "Select GioChieu from LichChieu where MaPhim = N'" + cbTenPhim.SelectedValue.ToString() + "' and NgayChieu = '"+ cbNgayChieu.Text +"'";
                return (new GetDataBUS().GetGioChieuBus(sql));
            }
            catch (SqlException ex)
            {                
                throw ex;
            }
        }

        private void btnBuyTicket_Click(object sender, EventArgs e)
        {
            Review.Ghe show = new Ghe(lbMaPhim.Text, cbTenPhim.Text, cbNgayChieu.Text, lbGioChieu.Text);
            this.Visible = false;
            show.ShowDialog();
            this.Visible = true;
        }

        private void cbTenPhim_SelectedIndexChanged(object sender, EventArgs e)
        {
            cbNgayChieu.DataSource = NgayChieu().Tables[0];
            cbNgayChieu.DisplayMember = "NgayChieu";
            cbNgayChieu.Text = "";
            //An thong tin
            pictureBox1.Visible = gbInfo.Visible = lbTenPhim.Visible = lbGioChieu.Visible = false;
        }

        private void cbNgayChieu_SelectedIndexChanged(object sender, EventArgs e)
        {
            //Tao 1 doi tuong  Phim moi
            GetOneDataBUS np = new GetOneDataBUS();
            PhimDTO phim = np.GetOnePhimBUS(cbTenPhim.SelectedValue.ToString());

            int index = cbTenPhim.SelectedIndex;
            //Thong tin phim
            lbMaPhim.Text = phim.MaPhim;
            lbTenPhim.Text = phim.TenPhim;
            lbDaoDien.Text = phim.DaoDien;
            lbQuocGia.Text = phim.QuocGia;
            lbNam.Text = phim.Nam.ToString();
            lbThoiLuong.Text = phim.ThoiLuong.ToString() +"p";
            lbTheLoai.Text = phim.TheLoai;

            //Gio chieu
            lbGioChieu.DataSource = GioChieu().Tables[0];
            lbGioChieu.DisplayMember = "GioChieu";

            //Lay Hinh
            pictureBox1.Image = ConvertImage.ConvertByteToImage(phim.HinhAnh);
            //Hien thong tin
            pictureBox1.Visible = gbInfo.Visible = lbTenPhim.Visible = lbGioChieu.Visible = true;
        }
    }
}
