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
    public partial class QuanLyPhongChieu : Form
    {
        public QuanLyPhongChieu()
        {
            InitializeComponent();
        }

        private void RapPhim_Load(object sender, EventArgs e)
        {
            lbTenRP.DataSource = GetData.GetRapPhim().Tables[0];
            lbTenRP.DisplayMember = "TenRapPhim";
            lbTenRP.ValueMember = "MaRapPhim";

            cbDinhDang.Items.Add("2D");
            cbDinhDang.Items.Add("3D");
            cbDinhDang.Items.Add("4DX");

            lbTenRP.Text = txtTenPC.Text = txtMaPC.Text = "";
        }

        private void rd2D_CheckedChanged(object sender, EventArgs e)
        {
            RadioButton rd = (RadioButton)sender;
            if (rd.Checked)
            {
                rd.BackColor = Color.Coral;
            }
            else
            {
                rd.BackColor = Color.Cyan;
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            try
            {
                string MaPC, TenPC, DinhDang, MaRP, TenRP;

                MaPC = Convert.ToString(txtMaPC.Text.Trim());
                TenPC = Convert.ToString(txtTenPC.Text.Trim());
                DinhDang = cbDinhDang.Text;
                MaRP = Convert.ToString(lbTenRP.SelectedValue.ToString().Trim());
                TenRP = Convert.ToString(lbTenRP.Text.Trim());

                PhongChieuDTO phongchieu = new PhongChieuDTO(MaPC, TenPC, DinhDang,MaRP,TenRP);
                int themphongchieu = new ThemBUS().ThemPhongChieuBUS(phongchieu);

                dgvPhongChieu.DataSource = GetData.GetPhongChieuDK(lbTenRP.SelectedValue.ToString()).Tables[0];
                
                MessageBox.Show("Thêm phòng chiếu thành công");
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

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            try
            {
                string MaPC, TenPC, DinhDang, MaRP, TenRP;

                MaPC = Convert.ToString(txtMaPC.Text.Trim());
                TenPC = Convert.ToString(txtTenPC.Text.Trim());
                DinhDang = cbDinhDang.Text;
                MaRP = Convert.ToString(lbTenRP.SelectedValue.ToString().Trim());
                TenRP = Convert.ToString(lbTenRP.Text.Trim());

                PhongChieuDTO phongchieu = new PhongChieuDTO(MaPC, TenPC, DinhDang, MaRP, TenRP);
                int suaphongchieu = new SuaBUS().SuaPhongChieuBUS(phongchieu);

                dgvPhongChieu.DataSource = GetData.GetPhongChieuDK(lbTenRP.SelectedValue.ToString()).Tables[0];

                MessageBox.Show("Sửa phòng chiếu thành công");
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

        private void btnDelete_Click(object sender, EventArgs e)
        {
            try
            {
                string MaPC, TenPC, DinhDang, MaRP, TenRP;

                MaPC = Convert.ToString(txtMaPC.Text.Trim());
                TenPC = Convert.ToString(txtTenPC.Text.Trim());
                DinhDang = cbDinhDang.Text;
                MaRP = Convert.ToString(lbTenRP.SelectedValue.ToString().Trim());
                TenRP = Convert.ToString(lbTenRP.Text.Trim());

                PhongChieuDTO phongchieu = new PhongChieuDTO(MaPC, TenPC, DinhDang, MaRP, TenRP);
                int xoaphongchieu = new XoaBUS().XoaPhongChieuBUS(phongchieu);

                dgvPhongChieu.DataSource = GetData.GetPhongChieuDK(lbTenRP.SelectedValue.ToString()).Tables[0];
                
                MessageBox.Show("Thêm phòng chiếu thành công");
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

        private void dgvPhongChieu_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txtMaPC.Text = dgvPhongChieu.CurrentRow.Cells[0].Value.ToString().Trim();
            txtTenPC.Text = dgvPhongChieu.CurrentRow.Cells[1].Value.ToString().Trim();
            cbDinhDang.Text = dgvPhongChieu.CurrentRow.Cells[2].Value.ToString().Trim();
        }

        private void lbTenRP_SelectedIndexChanged(object sender, EventArgs e)
        {
            dgvPhongChieu.DataSource = GetData.GetPhongChieuDK(lbTenRP.SelectedValue.ToString()).Tables[0];
            dgvPhongChieu.Columns[0].HeaderText = "Mã phòng chiếu";
            dgvPhongChieu.Columns[1].HeaderText = "Tên phòng chiếu";
            dgvPhongChieu.Columns[2].HeaderText = "Định dạng";
            dgvPhongChieu.Columns[3].HeaderText = "Mã rạp phim";
            dgvPhongChieu.Columns[4].HeaderText = "Tên rạp phim";

            GetOneDataBUS rp = new GetOneDataBUS();
            RapPhimDTO rapphim = rp.GetOneRapPhimBUS(lbTenRP.SelectedValue.ToString());

            txtTenNV.Text = rapphim.TenNhanVien;

            txtTenPC.Text = txtMaPC.Text = "";
        }
    }
}
