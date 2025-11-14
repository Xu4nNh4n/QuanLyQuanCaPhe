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
using QuanCaPhe;
namespace QuanCaPhe
{
    public partial class GiaoDienDangNhap : Form
    {
        public static int MaNhanVienDangNhap = -1;
        SqlConnection conn;
        public GiaoDienDangNhap()
        {
            InitializeComponent();
            conn = new SqlConnection(@"Data Source=Xu4nNh4n\SQLEXPRESS;Initial Catalog=QLQUANCAFE;Integrated Security=True");
        }

        private void btnDangNhap_Click(object sender, EventArgs e)
        {
            string username = txtTenDangNhap.Text.Trim();
            string password = txtMatKhau.Text.Trim();
            if (username == "" || password == "")
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin đăng nhập.");
                return;
            }
            try
            {
                conn.Open();
                string query = @"
                SELECT NV.HOTEN, PQ.TENQ, TK.MANV, TK.MAQ
                    FROM TAIKHOAN TK
                    JOIN NHANVIEN NV ON TK.MANV = NV.MANV
                    JOIN PHANQUYEN PQ ON TK.MAQ = PQ.MAQ
                    WHERE TK.TENDANGNHAP = @username AND TK.MATKHAU = @password";
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@username", username);
                cmd.Parameters.AddWithValue("@password", password);
                SqlDataReader reader = cmd.ExecuteReader();
                if (reader.Read())
                {
                    SessionLogin.MaNV = Convert.ToInt32(reader["MANV"]);
                    SessionLogin.HoTen = reader["HOTEN"].ToString();
                    SessionLogin.Quyen = reader["TENQ"].ToString();

                    Account.Current = new Account(
                        maNV: Convert.ToInt32(reader["MANV"]),
                        maQ: Convert.ToInt32(reader["MAQ"]),
                        user: username,
                        password: password
                    );

                    string tenNV = reader["HOTEN"].ToString();
                    string quyen = reader["TENQ"].ToString();

                    MessageBox.Show($"Đăng nhập thành công!\nXin chào {tenNV} ({quyen})", "Thông báo");

                    this.Hide();
                    GiaoDienChinh frm = new GiaoDienChinh();
                    frm.ShowDialog();
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Sai tên đăng nhập hoặc mật khẩu!");
                }

                reader.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi đăng nhập: " + ex.Message);
            }
            finally
            {
                conn.Close();
            }
        

        }

        private void GiaoDienDangNhap_Load(object sender, EventArgs e)
        {
            txtMatKhau.PasswordChar = '*';
            btnShowPass.Text = "👁️";
            label1.Parent = pictureBox1;
            label1.BackColor = Color.Transparent;

            label2.Parent = pictureBox1;
            label2.BackColor = Color.Transparent;

            label3.Parent = pictureBox1;
            label3.BackColor = Color.Transparent;
        }

        private void btnShowPass_Click(object sender, EventArgs e)
        {
            if (txtMatKhau.PasswordChar == '*')
            {
                txtMatKhau.PasswordChar = '\0';
                btnShowPass.Text = "🙈"; 
            }
            else
            {
                 txtMatKhau.PasswordChar = '*';
                btnShowPass.Text = "👁️"; 

            }

        }

        private void txtMatKhau_TextChanged(object sender, EventArgs e)
        {
            this.AcceptButton = btnDangNhap;
        }

        private void txtTenDangNhap_TextChanged(object sender, EventArgs e)
        {
            this.AcceptButton = btnDangNhap;
        }
    }
}
