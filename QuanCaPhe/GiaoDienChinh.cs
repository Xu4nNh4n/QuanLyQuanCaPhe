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
            if (currentFormChild != null)
            {
                if (currentFormChild != childForm)
                    currentFormChild.Hide();  // chỉ ẩn form cũ, không đóng
            }
            currentFormChild = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;

            if (!pnlContainer.Controls.Contains(childForm))
                pnlContainer.Controls.Add(childForm);

            childForm.BringToFront();
            childForm.Show();
        }
        private FormBanHang formBanHang;
        private void btnBanHang_Click(object sender, EventArgs e)
        {
            if(formBanHang == null || formBanHang.IsDisposed)
            {
                formBanHang = new FormBanHang();
            }
            OpenChildForm(formBanHang);
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
