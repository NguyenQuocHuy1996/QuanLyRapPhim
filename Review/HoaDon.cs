using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Review
{
    public partial class HoaDon : Form
    {
        public HoaDon()
        {
            InitializeComponent();
        }

        private void HoaDon_Load(object sender, EventArgs e)
        {
            listBox1.DataSource = GetData.GetThucAnTam().Tables[0];
            listBox1.DisplayMember = "TenThucAn";

            listBox2.DataSource = GetData.GetThucAnTam().Tables[0];
            listBox2.DisplayMember = "DonGia";

            
        }
    }
}
