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
    public partial class FormBanHang : Form
    {
        public FormBanHang()
        {
            InitializeComponent();
        }

        private void flpMenu_Resize(object sender, EventArgs e)
        {
            foreach (Control ctrl in flpMenu.Controls)
            {
                ctrl.Width = flpMenu.ClientSize.Width - 10; // chừa khoảng padding
            }
        }

        private void flpHoaDon_Resize(object sender, EventArgs e)
        {
            foreach (Control ctrl in flpHoaDon.Controls)
            {
                ctrl.Width = flpHoaDon.ClientSize.Width - 10;
            }
        }

        private void FormBanHang_Load(object sender, EventArgs e)
        {
           
            tableLayoutPanel1.SetColumnSpan(btnXacNhan, 4);
            btnXacNhan.Dock = DockStyle.Fill;
        }
    }

}
