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
            dgvPhim.Columns[0].HeaderText = "Mã phim";
            dgvPhim.Columns[1].HeaderText = "Tên phim";
            dgvPhim.Columns[2].HeaderText = "Đạo diễn";
            dgvPhim.Columns[3].HeaderText = "Quốc gia";
            dgvPhim.Columns[4].HeaderText = "Năm sản xuất";
            dgvPhim.Columns[5].HeaderText = "Thời lượng (p)";
            dgvPhim.Columns[6].HeaderText = "Thể loại";
            dgvPhim.Columns[7].HeaderText = "Hình ảnh";

            cbMaPhim.DataSource = GetData.GetPhim().Tables[0];
            cbMaPhim.DisplayMember = "MaPhim";
            cbMaPhim.ValueMember = "MaPhim";

            cbTheLoai.DataSource = GetData.GetTheLoai().Tables[0];
            cbTheLoai.DisplayMember = "TheLoai";

            //cbMaPhim.Text= txtTenPhim.Text = txtDaoDien.Text = txtThoiLuong.Text = txtNam.Text = txtQuocGia.Text = cbTheLoai.Text = "";
        }

        private void cbMaPhim_SelectedIndexChanged(object sender, EventArgs e)
        {
            //Tao 1 doi tuong  Phim moi
            GetOneDataBUS np = new GetOneDataBUS();
            PhimDTO phim = np.GetOnePhimBUS(cbMaPhim.Text);

            int index = cbMaPhim.SelectedIndex;
            //Thong tin phim
            cbMaPhim.Text = phim.MaPhim;
            txtTenPhim.Text = phim.TenPhim;
            txtDaoDien.Text = phim.DaoDien;
            txtQuocGia.Text = phim.QuocGia;
            txtNam.Text = phim.Nam.ToString();
            txtThoiLuong.Text = phim.ThoiLuong.ToString();
            cbTheLoai.Text = phim.TheLoai;

            //Lay Hinh
            //picImage.Image = ConvertImage.ConvertByteToImage(phim.HinhAnh);
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

        private void btnThem_Click(object sender, EventArgs e)
        {
            try
            {
                string maPhim, tenPhim, daoDien, quocGia, theLoai;
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

                PhimDTO film = new PhimDTO(maPhim, tenPhim, daoDien, quocGia, nam, thoiLuong, theLoai, hinhAnh);
                int themphim = new ThemBUS().Them_PhimBUS(film);

                dgvPhim.DataSource = GetData.GetPhim().Tables[0];
                cbMaPhim.DataSource = GetData.GetPhim().Tables[0];
                cbMaPhim.Text = txtTenPhim.Text = txtDaoDien.Text = txtQuocGia.Text = cbTheLoai.Text = txtNam.Text = txtThoiLuong.Text = "";
                MessageBox.Show("Thêm phim thành công");
            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.Message);
                //MessageBox.Show("Mã phim đã có, nhập mã khác");
            }
            catch (Exception)
            {
                MessageBox.Show("Điền đầy đủ thông tin");
            }
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            try
            {
                string maPhim, tenPhim, daoDien, quocGia, theLoai;
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

                PhimDTO film = new PhimDTO(maPhim, tenPhim, daoDien, quocGia, nam, thoiLuong, theLoai, hinhAnh);
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
            FormQuanLy quanly = new FormQuanLy();
            quanly.Show();
        }

        private void dgvPhim_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            cbMaPhim.Text = "";
            txtTenPhim.Text = txtDaoDien.Text = txtNam.Text = txtQuocGia.Text = txtThoiLuong.Text = "";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Phim form = new Phim();
            form.Show();
        }

        private void dgvPhim_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            cbMaPhim.Text = dgvPhim.CurrentRow.Cells[0].Value.ToString().Trim();
            txtTenPhim.Text = dgvPhim.CurrentRow.Cells[1].Value.ToString().Trim();
            txtDaoDien.Text = dgvPhim.CurrentRow.Cells[2].Value.ToString().Trim();
            txtQuocGia.Text = dgvPhim.CurrentRow.Cells[3].Value.ToString().Trim();
            txtNam.Text = dgvPhim.CurrentRow.Cells[4].Value.ToString().Trim();
            txtThoiLuong.Text = dgvPhim.CurrentRow.Cells[5].Value.ToString().Trim();
            cbTheLoai.Text = dgvPhim.CurrentRow.Cells[6].Value.ToString().Trim();
        }
    }
}
