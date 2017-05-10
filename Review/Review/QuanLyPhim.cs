using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.IO;

using BUS;
using DTO;
namespace Review
{
    public partial class QuanLyPhim : Form
    {

        public QuanLyPhim()
        {
            InitializeComponent();
        }

        private void ThongTinPhim_Load(object sender, EventArgs e)
        {
            dgvPhim.DataSource = GetData.GetPhim().Tables[0];

            cbMaPhim.DataSource = GetData.GetPhim().Tables[0];
            cbMaPhim.DisplayMember = "MaPhim";
            cbMaPhim.ValueMember = "MaPhim";

            cbTheLoai.DataSource = GetData.GetTheLoai().Tables[0];
            cbTheLoai.DisplayMember = "TheLoai";

            cbMaPhim.Text= txtTenPhim.Text = txtDaoDien.Text = txtThoiLuong.Text = txtNam.Text = txtQuocGia.Text = cbTheLoai.Text = "";
        }

        private void cbMaPhim_SelectedIndexChanged(object sender, EventArgs e)
        {
            GetOneDataBUS np = new GetOneDataBUS();
            PhimDTO phim = np.GetOnePhimBUS(cbMaPhim.Text);
            int index = cbMaPhim.SelectedIndex;
            txtTenPhim.Text = dgvPhim.Rows[index].Cells[1].Value.ToString().Trim();
            txtDaoDien.Text = dgvPhim.Rows[index].Cells[2].Value.ToString().Trim();
            txtQuocGia.Text = dgvPhim.Rows[index].Cells[3].Value.ToString().Trim();
            txtNam.Text = dgvPhim.Rows[index].Cells[4].Value.ToString().Trim();
            txtThoiLuong.Text = dgvPhim.Rows[index].Cells[5].Value.ToString().Trim();
            cbTheLoai.Text = dgvPhim.Rows[index].Cells[6].Value.ToString().Trim();
            //Lay hinh anh
            //Tao 1 doi tuong  Phim moi
            //PhimBus np = new PhimBus();
            //PhimDTO phim = np.GetOnePhimBUS(cbMaPhim.SelectedValue.ToString());
            //picImage.Image = ConvertByteToImage(phim.HinhAnh);
        }

        private void btnChonAnh_Click(object sender, EventArgs e)
        {

            OpenFileDialog Image = new OpenFileDialog();
            Image.Filter = "JPG files (*.jpg)|*.jpg|PNG files (*.png)|*.png|All files (*.*)|*.*";
            if (Image.ShowDialog() == DialogResult.OK)
            {
                txtHinhAnh.Text = Image.FileName;
                picImage.ImageLocation = Image.FileName;
            }
        }

        private void btnTrailer_Click(object sender, EventArgs e)
        {
            OpenFileDialog Trailer = new OpenFileDialog();
            if (Trailer.ShowDialog() == DialogResult.OK)
            {
                txtTrailer.Text = Path.GetFileName(Trailer.FileName);
            }
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            try
            {
                string maPhim, tenPhim, daoDien, quocGia, theLoai, trailer;
                int nam, thoiLuong;
                byte[] hinhAnh;

                maPhim = Convert.ToString(cbMaPhim.Text);
                tenPhim = Convert.ToString(txtTenPhim.Text);
                daoDien = Convert.ToString(txtDaoDien.Text);
                quocGia = Convert.ToString(txtQuocGia.Text);
                nam = Convert.ToInt32(txtNam.Text);
                thoiLuong = Convert.ToInt32(txtThoiLuong.Text);
                theLoai = Convert.ToString(cbTheLoai.Text);
                hinhAnh = ConvertImage.ConvertImageToByte(txtHinhAnh.Text);
                trailer = Convert.ToString(txtTrailer.Text);

                PhimDTO film = new PhimDTO(maPhim, tenPhim, daoDien, quocGia, nam, thoiLuong, theLoai, hinhAnh, trailer);
                int themphim = new ThemBUS().Them_PhimBUS(film);

                dgvPhim.DataSource = GetData.GetPhim().Tables[0];
                cbMaPhim.DataSource = GetData.GetPhim().Tables[0];
                cbMaPhim.Text = txtTenPhim.Text = txtDaoDien.Text = txtQuocGia.Text = cbTheLoai.Text = txtNam.Text = txtThoiLuong.Text = "";
                MessageBox.Show("Thêm phim thành công");
            }
            catch (SqlException)
            {
                MessageBox.Show("Mã phim đã có, nhập mã khác");
            }
            catch (Exception)
            {
                MessageBox.Show("Chọn hình ảnh");
            }
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            try
            {
                string maPhim, tenPhim, daoDien, quocGia, theLoai, trailer;
                int nam, thoiLuong;
                byte[] hinhAnh;

                maPhim = Convert.ToString(cbMaPhim.Text);
                tenPhim = Convert.ToString(txtTenPhim.Text);
                daoDien = Convert.ToString(txtDaoDien.Text);
                quocGia = Convert.ToString(txtQuocGia.Text);
                theLoai = Convert.ToString(cbTheLoai.Text);
                nam = Convert.ToInt32(txtNam.Text);
                thoiLuong = Convert.ToInt32(txtThoiLuong.Text);
                hinhAnh = ConvertImage.ConvertImageToByte(txtHinhAnh.Text);
                trailer = Convert.ToString(txtTrailer.Text);

                PhimDTO film = new PhimDTO(maPhim, tenPhim, daoDien, quocGia, nam, thoiLuong, theLoai, hinhAnh, trailer);
                int suaphim = new SuaBUS().SuaPhimBUS(film);

                dgvPhim.DataSource = GetData.GetPhim().Tables[0];
                cbMaPhim.Text = txtTenPhim.Text = txtDaoDien.Text = txtQuocGia.Text = cbTheLoai.Text = txtNam.Text = txtThoiLuong.Text = txtHinhAnh.Text = "";
                MessageBox.Show("Sửa phim thành công");
            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.Message);
            }
            catch (Exception)
            {
                MessageBox.Show("Chọn hình ảnh");
            }
            
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            try
            {
                string maPhim, tenPhim, daoDien, quocGia, theLoai;
                int nam, thoiLuong;

                maPhim = Convert.ToString(cbMaPhim.Text);
                tenPhim = Convert.ToString(txtTenPhim.Text);
                daoDien = Convert.ToString(txtDaoDien.Text);
                quocGia = Convert.ToString(txtQuocGia.Text);
                theLoai = Convert.ToString(cbTheLoai.Text);
                nam = Convert.ToInt32(txtNam.Text);
                thoiLuong = Convert.ToInt32(txtThoiLuong.Text);

                PhimDTO film = new PhimDTO(maPhim, tenPhim, daoDien, quocGia, nam, thoiLuong, theLoai);
                int xoaphim = new XoaBUS().Xoa_PhimBUS(film);

                dgvPhim.DataSource = GetData.GetPhim().Tables[0];
                cbMaPhim.DataSource = GetData.GetPhim().Tables[0];
                cbMaPhim.Text = txtTenPhim.Text = txtDaoDien.Text = txtQuocGia.Text = cbTheLoai.Text = txtNam.Text = txtThoiLuong.Text = txtHinhAnh.Text = "";
                MessageBox.Show("Xóa phim thành công");
            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.Message);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }     

        private void btnClose_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
