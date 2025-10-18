using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanCaPhe
{
    public partial class FormQuanLyMonAn : Form
    {
        public FormQuanLyMonAn()
        {
            InitializeComponent();
        }

        private void FormQuanLyMonAn_Load(object sender, EventArgs e)
        {
            tblTTMA.SetColumnSpan(txtTenMon, 2);
            tblTTMA.SetColumnSpan(txtMaMon, 2);
            tblTTMA.SetColumnSpan(txtDonGia, 2);
            tblTTMA.SetColumnSpan(cbMaLoai, 2);
        }

        private void tblTTMA_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
