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
    public partial class GiaoDienChinh : Form
    {

        private Form currentFormChild;
        public GiaoDienChinh()
        {
            InitializeComponent();
            labHienThiTenDangNhap.Text = $"Xin chào {SessionLogin.HoTen.Trim().Split(' ').Last()}";
            if (SessionLogin.Quyen == "Nhân viên")
            {
                btnQuanLyMA.Visible = false;
                btnQuanLyNV.Visible = false;
            }
        }
        private void OpenChildForm(Form childForm)
        {
            // Nếu đã có form con đang mở thì đóng lại
            if (currentFormChild != null)
            {
                currentFormChild.Close();
            }
            currentFormChild = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            pnlContainer.Controls.Clear();
            pnlContainer.Controls.Add(childForm);
            pnlContainer.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
        }

        private void btnBanHang_Click(object sender, EventArgs e)
        {
            OpenChildForm(new FormBanHang());
        }

        private void pnlContainer_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnQuanLyNV_Click(object sender, EventArgs e)
        {
            OpenChildForm(new FormQuanLyNhanVien());
        }

        private void btnQuanLyMA_Click(object sender, EventArgs e)
        {
            OpenChildForm(new FormQuanLyMonAn());
        }

        private void btnQuanLyHD_Click(object sender, EventArgs e)
        {
            OpenChildForm(new FormQuanLyHoaDon());
        }

        private void btnCaiDat_Click(object sender, EventArgs e)
        {
            FormCatDat frm = new FormCatDat();
            frm.ShowDialog();

        }

        private void btnDangXuat_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Bạn có chắc chắn muốn đăng xuất?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                this.Hide();
                GiaoDienDangNhap dangNhap = new GiaoDienDangNhap();
                dangNhap.ShowDialog();
                this.Close();
            }
        }

        private void GiaoDienChinh_Load(object sender, EventArgs e)
        {
        }

    }
}
