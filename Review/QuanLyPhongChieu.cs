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
            cbTenRapPhim.DataSource = GetData.GetRapPhim().Tables[0];
            cbTenRapPhim.DisplayMember = "TenRapPhim";
            cbTenRapPhim.ValueMember = "MaRapPhim";

            cbTenRapPhim.Text = cbTenPhongChieu.Text = cbMaPhongChieu.Text = txtMaRapPhim.Text = "";
        }

        private void cbTenRapPhim_SelectedIndexChanged(object sender, EventArgs e)
        {
            dgvPhongChieu.DataSource = GetData.GetPhongChieuDK(cbTenRapPhim.SelectedValue.ToString()).Tables[0];
            dgvPhongChieu.Columns[0].HeaderText = "Mã phòng chiếu";
            dgvPhongChieu.Columns[1].HeaderText = "Tên phòng chiếu";
            dgvPhongChieu.Columns[2].HeaderText = "Định dạng";
            dgvPhongChieu.Columns[3].HeaderText = "Mã rạp phim";
            dgvPhongChieu.Columns[4].HeaderText = "Tên rạp phim";

            cbMaPhongChieu.DataSource = GetData.GetPhongChieuDK(cbTenRapPhim.SelectedValue.ToString()).Tables[0];
            cbMaPhongChieu.DisplayMember = "MaPhongChieu";
            cbMaPhongChieu.ValueMember = "MaPhongChieu";

            cbTenPhongChieu.DataSource = GetData.GetPhongChieuDK(cbTenRapPhim.SelectedValue.ToString()).Tables[0];
            cbTenPhongChieu.DisplayMember = "TenPhongChieu";
            cbTenPhongChieu.ValueMember = "MaPhongChieu";

            GetOneDataBUS rp = new GetOneDataBUS();
            RapPhimDTO rapphim = rp.GetOneRapPhimBUS(cbTenRapPhim.SelectedValue.ToString());

            txtTenNV.Text = rapphim.TenNhanVien;
            txtMaNhanVien.Text = rapphim.MaNV;

            txtMaRapPhim.Text = cbTenRapPhim.SelectedValue.ToString();

            cbTenPhongChieu.Text = cbMaPhongChieu.Text = "";
        }

        private void cbTenPhongChieu_SelectedIndexChanged(object sender, EventArgs e)
        {
            cbMaPhongChieu.Text = cbTenPhongChieu.SelectedValue.ToString();
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

                MaPC = Convert.ToString(cbMaPhongChieu.Text.Trim());
                TenPC = Convert.ToString(cbTenPhongChieu.Text.Trim());
                if (rd4DX.Checked)
                {
                    DinhDang = "4DX";
                }
                else if (rd3D.Checked)
                {
                    DinhDang = "3D";
                }
                else
                {
                    DinhDang = "2D";
                }
                MaRP = Convert.ToString(cbTenRapPhim.SelectedValue.ToString().Trim());
                TenRP = Convert.ToString(cbTenRapPhim.Text.Trim());

                PhongChieuDTO phongchieu = new PhongChieuDTO(MaPC, TenPC, DinhDang,MaRP,TenRP);
                int themphongchieu = new ThemBUS().ThemPhongChieuBUS(phongchieu);

                dgvPhongChieu.DataSource = GetData.GetPhongChieuDK(cbTenRapPhim.SelectedValue.ToString()).Tables[0];

                cbMaPhongChieu.DataSource = GetData.GetPhongChieuDK(cbTenRapPhim.SelectedValue.ToString()).Tables[0];
                cbMaPhongChieu.DisplayMember = "MaPhongChieu";
                cbMaPhongChieu.ValueMember = "MaPhongChieu";

                cbTenPhongChieu.DataSource = GetData.GetPhongChieuDK(cbTenRapPhim.SelectedValue.ToString()).Tables[0];
                cbTenPhongChieu.DisplayMember = "TenPhongChieu";
                cbTenPhongChieu.ValueMember = "MaPhongChieu";

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

                MaPC = Convert.ToString(cbMaPhongChieu.Text.Trim());
                TenPC = Convert.ToString(cbTenPhongChieu.Text.Trim());
                if (rd4DX.Checked)
                {
                    DinhDang = "4DX";
                }
                else if (rd3D.Checked)
                {
                    DinhDang = "3D";
                }
                else
                {
                    DinhDang = "2D";
                }
                MaRP = Convert.ToString(cbTenRapPhim.SelectedValue.ToString().Trim());
                TenRP = Convert.ToString(cbTenRapPhim.Text.Trim());

                PhongChieuDTO phongchieu = new PhongChieuDTO(MaPC, TenPC, DinhDang, MaRP, TenRP);
                int suaphongchieu = new SuaBUS().SuaPhongChieuBUS(phongchieu);

                dgvPhongChieu.DataSource = GetData.GetPhongChieuDK(cbTenRapPhim.SelectedValue.ToString()).Tables[0];

                cbMaPhongChieu.DataSource = GetData.GetPhongChieuDK(cbTenRapPhim.SelectedValue.ToString()).Tables[0];
                cbMaPhongChieu.DisplayMember = "MaPhongChieu";
                cbMaPhongChieu.ValueMember = "MaPhongChieu";

                cbTenPhongChieu.DataSource = GetData.GetPhongChieuDK(cbTenRapPhim.SelectedValue.ToString()).Tables[0];
                cbTenPhongChieu.DisplayMember = "TenPhongChieu";
                cbTenPhongChieu.ValueMember = "MaPhongChieu";

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

                MaPC = Convert.ToString(cbMaPhongChieu.Text.Trim());
                TenPC = Convert.ToString(cbTenPhongChieu.Text.Trim());
                if (rd4DX.Checked)
                {
                    DinhDang = "4DX";
                }
                else if (rd3D.Checked)
                {
                    DinhDang = "3D";
                }
                else
                {
                    DinhDang = "2D";
                }
                MaRP = Convert.ToString(cbTenRapPhim.SelectedValue.ToString().Trim());
                TenRP = Convert.ToString(cbTenRapPhim.Text.Trim());

                PhongChieuDTO phongchieu = new PhongChieuDTO(MaPC, TenPC, DinhDang, MaRP, TenRP);
                int xoaphongchieu = new XoaBUS().XoaPhongChieuBUS(phongchieu);

                dgvPhongChieu.DataSource = GetData.GetPhongChieuDK(cbTenRapPhim.SelectedValue.ToString()).Tables[0];

                cbMaPhongChieu.DataSource = GetData.GetPhongChieuDK(cbTenRapPhim.SelectedValue.ToString()).Tables[0];
                cbMaPhongChieu.DisplayMember = "MaPhongChieu";
                cbMaPhongChieu.ValueMember = "MaPhongChieu";

                cbTenPhongChieu.DataSource = GetData.GetPhongChieuDK(cbTenRapPhim.SelectedValue.ToString()).Tables[0];
                cbTenPhongChieu.DisplayMember = "TenPhongChieu";
                cbTenPhongChieu.ValueMember = "MaPhongChieu";

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
            FormQuanLy quanly = new FormQuanLy();
            quanly.Show();
        }

        private void dgvPhongChieu_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            cbMaPhongChieu.Text = dgvPhongChieu.CurrentRow.Cells[0].Value.ToString().Trim();
            cbTenPhongChieu.Text = dgvPhongChieu.CurrentRow.Cells[1].Value.ToString().Trim();
        }
    }
}
