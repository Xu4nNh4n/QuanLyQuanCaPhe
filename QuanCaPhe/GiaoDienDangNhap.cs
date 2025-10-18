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
    public partial class GiaoDienDangNhap : Form
    {
        public GiaoDienDangNhap()
        {
            InitializeComponent();
        }

        private void btnDangNhap_Click(object sender, EventArgs e)
        {
            string username = txtTenDangNhap.Text;
            string password = txtMatKhau.Text;
            if (username == "admin" && password == "123")
            {
                // Ẩn form đăng nhập
                this.Hide();

                // Mở form chính
                GiaoDienChinh mainForm = new GiaoDienChinh();
                mainForm.ShowDialog();

                // Khi form chính đóng lại thì thoát hẳn chương trình
                this.Close();
            }
            else
            {
                MessageBox.Show("Sai tên đăng nhập hoặc mật khẩu!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
