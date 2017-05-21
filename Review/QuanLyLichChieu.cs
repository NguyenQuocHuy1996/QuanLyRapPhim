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

namespace Review
{
    public partial class QuanLyLichChieu : Form
    {
        public QuanLyLichChieu()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            cbTenRapPhim.DataSource = GetData.GetRapPhim().Tables[0];
            cbTenRapPhim.DisplayMember = "TenRapPhim";
            cbTenRapPhim.ValueMember = "MaRapPhim";

            cbTenPhim.DataSource = GetData.GetPhim().Tables[0];
            cbTenPhim.DisplayMember = "TenPhim";
            cbTenPhim.ValueMember = "MaPhim";

            for (int i = 1; i <= 7; i++)
            {
                cbNgayChieu.Items.Add(DateTime.Today.AddDays(+i).ToString().Substring(0, 10));
            }

            for (int i = 8; i <= 22; i++)
            {
                cbGioChieu.Items.Add(i);
            }

            cbDinhDang.Items.Add("2D");
            cbDinhDang.Items.Add("3D");
            cbDinhDang.Items.Add("4DX");
        }

        private void cbTenRapPhim_SelectedIndexChanged(object sender, EventArgs e)
        {
            dgvLichChieu.DataSource = GetData.GetLichChieuDK(cbTenRapPhim.SelectedValue.ToString()).Tables[0];

            cbDinhDang.Text = "";
        }

        private void cbDinhDang_SelectedIndexChanged(object sender, EventArgs e)
        {
            cbTenPhongChieu.DataSource = GetData.GetPhongChieuDK2(cbTenRapPhim.SelectedValue.ToString(), cbDinhDang.Text).Tables[0];
            cbTenPhongChieu.DisplayMember = "TenPhongChieu";
            cbTenPhongChieu.ValueMember = "MaPhongChieu"; 

            cbTenPhongChieu.Text = "";
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            try
            {
                //Khai bao bien tam
                string MaRP, TenRP, MaPC, TenPC, MaPhim, TenPhim, NgayChieu, GioChieu, DinhDang;
                //Lay gia tri can them
                MaRP = Convert.ToString(cbTenRapPhim.SelectedValue.ToString());
                TenRP = Convert.ToString(cbTenRapPhim.Text);
                MaPC = Convert.ToString(cbTenPhongChieu.SelectedValue.ToString());
                TenPC = Convert.ToString(cbTenPhongChieu.Text);
                MaPhim = Convert.ToString(cbTenPhim.SelectedValue.ToString());
                TenPhim = Convert.ToString(cbTenPhim.Text);
                NgayChieu = Convert.ToString(cbNgayChieu.Text);
                GioChieu = Convert.ToString(cbGioChieu.Text);
                DinhDang = Convert.ToString(cbDinhDang.Text);
                //Tao ra doi tuong can them
                LichChieuDTO lichchieu = new LichChieuDTO(MaRP,TenRP,MaPC,TenPC,MaPhim,TenPhim,NgayChieu,GioChieu,DinhDang);
                //Them vao doi tuong vua tao
                int themlichchieu = new ThemBUS().ThemLichChieuBUS(lichchieu);
                //Cap nhat lai dgv va dua ra thong bao
                dgvLichChieu.DataSource = GetData.GetLichChieuDK(cbTenRapPhim.SelectedValue.ToString()).Tables[0];
                MessageBox.Show("Thêm lịch chiếu thành công");
            }
            catch (SqlException)
            {
                MessageBox.Show("Lịch chiếu đã có, thêm lịch khác");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            try
            {
                //Khai bao bien tam
                string MaRP, TenRP, MaPC, TenPC, MaPhim, TenPhim, NgayChieu, GioChieu, DinhDang;
                //Lay gia tri can them
                MaRP = Convert.ToString(cbTenRapPhim.SelectedValue.ToString());
                TenRP = Convert.ToString(cbTenRapPhim.Text);
                MaPC = Convert.ToString(cbTenPhongChieu.SelectedValue.ToString());
                TenPC = Convert.ToString(cbTenPhongChieu.Text);
                MaPhim = Convert.ToString(cbTenPhim.SelectedValue.ToString());
                TenPhim = Convert.ToString(cbTenPhim.Text);
                NgayChieu = Convert.ToString(cbNgayChieu.Text);
                GioChieu = Convert.ToString(cbGioChieu.Text);
                DinhDang = Convert.ToString(cbDinhDang.Text);
                //Tao ra doi tuong can them
                LichChieuDTO lichchieu = new LichChieuDTO(MaRP, TenRP, MaPC, TenPC, MaPhim, TenPhim, NgayChieu, GioChieu, DinhDang);
                //Sua vao doi tuong vua tao
                int sualichchieu = new SuaBUS().SuaLichChieuBUS(lichchieu);
                //Cap nhat lai dgv va dua ra thong bao
                dgvLichChieu.DataSource = GetData.GetLichChieuDK(cbTenRapPhim.SelectedValue.ToString()).Tables[0];
                MessageBox.Show("Sửa lịch chiếu thành công");
            }
            catch (SqlException)
            {
                MessageBox.Show("Lịch chiếu đã có, thêm lịch khác");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            try
            {
                //Khai bao bien tam
                string MaRP, TenRP, MaPC, TenPC, MaPhim, TenPhim, NgayChieu, GioChieu, DinhDang;
                //Lay gia tri can them
                MaRP = Convert.ToString(cbTenRapPhim.SelectedValue.ToString());
                TenRP = Convert.ToString(cbTenRapPhim.Text);
                MaPC = Convert.ToString(cbTenPhongChieu.SelectedValue.ToString());
                TenPC = Convert.ToString(cbTenPhongChieu.Text);
                MaPhim = Convert.ToString(cbTenPhim.SelectedValue.ToString());
                TenPhim = Convert.ToString(cbTenPhim.Text);
                NgayChieu = Convert.ToString(cbNgayChieu.Text);
                GioChieu = Convert.ToString(cbGioChieu.Text);
                DinhDang = Convert.ToString(cbDinhDang.Text);
                //Tao ra doi tuong can them
                LichChieuDTO lichchieu = new LichChieuDTO(MaRP, TenRP, MaPC, TenPC, MaPhim, TenPhim, NgayChieu, GioChieu, DinhDang);
                //Xoa vao doi tuong vua tao
                int xoalichchieu = new XoaBUS().XoaLichChieuBUS(lichchieu);
                //Cap nhat lai dgv va dua ra thong bao
                dgvLichChieu.DataSource = GetData.GetLichChieuDK(cbTenRapPhim.SelectedValue.ToString()).Tables[0];
                MessageBox.Show("Xóa lịch chiếu thành công");
            }
            catch (SqlException)
            {
                MessageBox.Show("Lịch chiếu đã có, thêm lịch khác");
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

        private void dgvLichChieu_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            cbTenRapPhim.Text = dgvLichChieu.CurrentRow.Cells[1].Value.ToString().Trim();
            cbTenPhongChieu.Text = dgvLichChieu.CurrentRow.Cells[3].Value.ToString().Trim();
            cbTenPhim.Text = dgvLichChieu.CurrentRow.Cells[5].Value.ToString().Trim();
            cbNgayChieu.Text = dgvLichChieu.CurrentRow.Cells[6].Value.ToString().Trim();
            cbGioChieu.Text = dgvLichChieu.CurrentRow.Cells[7].Value.ToString().Trim();
            cbDinhDang.Text = dgvLichChieu.CurrentRow.Cells[8].Value.ToString().Trim();
        }
    }
}
