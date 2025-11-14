using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanCaPhe
{
    public partial class FormCatDat : Form
    {
        SqlConnection conn;
        public FormCatDat()
        {
            InitializeComponent();
            conn = new SqlConnection(@"Data Source=Xu4nNh4n\SQLEXPRESS;Initial Catalog=QLQUANCAFE;Integrated Security=True");
        }

        private void btnDoiMatKhau_Click(object sender, EventArgs e)
        {

            string matKhauCu = txtPasswordHientai.Text.Trim();
            string matKhauMoi = txtPasswordNew.Text.Trim();
            string xacNhan = txtPasswordXN.Text.Trim();

            if (string.IsNullOrEmpty(matKhauCu) || string.IsNullOrEmpty(matKhauMoi) || string.IsNullOrEmpty(xacNhan))
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (matKhauMoi != xacNhan)
            {
                MessageBox.Show("Mật khẩu xác nhận không trùng khớp!", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            try
            {
                if (conn.State == ConnectionState.Closed)
                    conn.Open();
                string queryCheck = "SELECT COUNT(*) FROM TAIKHOAN WHERE TENDANGNHAP = @user AND MATKHAU = @oldpass";
                SqlCommand cmdCheck = new SqlCommand(queryCheck, conn);
                cmdCheck.Parameters.AddWithValue("@user", Account.Current.Username);
                cmdCheck.Parameters.AddWithValue("@oldpass", matKhauCu);
                int count = (int)cmdCheck.ExecuteScalar();
                if (count == 0)
                {
                    MessageBox.Show("Mật khẩu cũ không đúng!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                string queryUpdate = "UPDATE TAIKHOAN SET MATKHAU = @newpass WHERE TENDANGNHAP = @user";
                SqlCommand cmdUpdate = new SqlCommand(queryUpdate, conn);
                cmdUpdate.Parameters.AddWithValue("@newpass", matKhauMoi);
                cmdUpdate.Parameters.AddWithValue("@user", Account.Current.Username);
                cmdUpdate.ExecuteNonQuery();
                Account.Current.Password = matKhauMoi;

                MessageBox.Show("Đổi mật khẩu thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);

                txtPasswordHientai.Clear();
                txtPasswordNew.Clear();
                txtPasswordXN.Clear();

            }
 
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi đổi mật khẩu: " + ex.Message);
            }
        }

        private void FormCatDat_Load(object sender, EventArgs e)
        {
            label1.BackColor = Color.Transparent;
            label2.BackColor = Color.Transparent;
            label3.BackColor = Color.Transparent;
            label4.BackColor = Color.Transparent;

        }
    }
}
