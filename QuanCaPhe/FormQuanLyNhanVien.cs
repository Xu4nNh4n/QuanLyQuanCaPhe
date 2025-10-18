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
    public partial class FormQuanLyNhanVien : Form
    {
        public FormQuanLyNhanVien()
        {
            InitializeComponent();
        }

        private void FormQuanLyNhanVien_Load(object sender, EventArgs e)
        {
            tblTTNV.SetColumnSpan(txtMaNV, 2);
            tblTTNV.SetColumnSpan(txtHoTen, 2);
            tblTTNV.SetColumnSpan(txtSDT, 2);
            tblTTNV.SetColumnSpan(txtChucVu, 2);
            tblTTNV.SetColumnSpan(txtLuong, 2);
            tblTTNV.SetColumnSpan(txtTrangThai, 2);
            tblTTNV.SetColumnSpan(txtTenDangNhap, 2);
            tblTTNV.SetColumnSpan(txtMatKhau, 2);

        }
    }
}
