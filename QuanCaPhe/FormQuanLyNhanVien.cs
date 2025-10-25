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

    public partial class FormQuanLyNhanVien : Form
    {
        SqlConnection conn;
        public FormQuanLyNhanVien()
        {
            InitializeComponent();
            conn = new SqlConnection(@"Data Source=Xu4nNh4n\SQLEXPRESS;Initial Catalog=QLQUANCAFE;Integrated Security=True");
        }

        private void FormQuanLyNhanVien_Load(object sender, EventArgs e)
        {
            loadDSNV();
            cbChucVu.Items.Clear();
            cbChucVu.Items.Add("Chọn chức vụ");
            cbChucVu.Items.Add("Quản lý");
            cbChucVu.Items.Add("Nhân viên");
            cbChucVu.SelectedIndex = 0;
        }
        private void loadDSNV()
        {
            try
            {
                if (conn.State == ConnectionState.Closed)
                {
                    conn.Open();
                }
                tvDSNV.Nodes.Clear();

                string sqlChuVu = "SELECT DISTINCT CHUCVU FROM NHANVIEN";
                SqlCommand cmdChucVu = new SqlCommand(sqlChuVu, conn);
                SqlDataReader drChucVu = cmdChucVu.ExecuteReader();
                List<string> lstChucVu = new List<string>();
                while (drChucVu.Read())
                {
                    lstChucVu.Add(drChucVu["CHUCVU"].ToString());
                }
                lstChucVu = lstChucVu.OrderBy(c => c == "Quản lý" ? 0 : 1).ThenBy(c => c).ToList();
                drChucVu.Close();
                foreach (var chucVu in lstChucVu)
                {
                    TreeNode nodeChucVu = new TreeNode(chucVu);
                    tvDSNV.Nodes.Add(nodeChucVu);
                    string sqlNhanVien = "SELECT N.MANV, N.HOTEN, N.SDT,  T.TENDANGNHAP, T.MATKHAU FROM NHANVIEN N JOIN TAIKHOAN T ON N.MANV = T.MANV WHERE N.CHUCVU = @chucvu";
                    SqlCommand cmdNhanVien = new SqlCommand(sqlNhanVien, conn);
                    cmdNhanVien.Parameters.AddWithValue("@chucvu", chucVu);
                    SqlDataReader drNhanVien = cmdNhanVien.ExecuteReader();

                    while (drNhanVien.Read())
                    {
                        int maNV = Convert.ToInt32(drNhanVien["MANV"]);
                        string hoTen = drNhanVien["HOTEN"].ToString();
                        string sdt = drNhanVien["SDT"].ToString();
                        string tenDangNhap = drNhanVien["TENDANGNHAP"].ToString();
                        string matKhau = drNhanVien["MATKHAU"].ToString();
                        TreeNode nodeNV = new TreeNode($"[{maNV}] - {hoTen} - {sdt}");
                        nodeNV.Tag = maNV;
                        TreeNode nodeTenDN = new TreeNode($"Tên đăng nhập: {tenDangNhap}");
                        TreeNode nodeMatKhau = new TreeNode($"Mật khẩu: {matKhau}");

                        nodeNV.Nodes.Add(nodeTenDN);
                        nodeNV.Nodes.Add(nodeMatKhau);
                        nodeChucVu.Nodes.Add(nodeNV);

                    }
                    drNhanVien.Close();
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi: " + ex.Message);
            }
            finally
            {
                conn.Close();
            }
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            try
            {
                if (conn.State == ConnectionState.Closed)
                {
                    conn.Open();
                }
                string hoTen = txtHoTen.Text.Trim();
                string tenDN = txtTenDangNhap.Text.Trim();
                string matKhau = txtMatKhau.Text.Trim();
                string SDT = txtSDT.Text.Trim();
                string chucVu = cbChucVu.SelectedItem.ToString();
                if (string.IsNullOrEmpty(hoTen) || string.IsNullOrEmpty(tenDN) ||
            string.IsNullOrEmpty(matKhau) || string.IsNullOrEmpty(SDT) || string.IsNullOrEmpty(chucVu))
                {
                    MessageBox.Show("Vui lòng nhập đầy đủ thông tin!");
                    return;
                }
                if (cbChucVu.SelectedIndex == 0)
                {
                    MessageBox.Show("Vui lòng chọn chức vụ!");
                    return;
                }
                string checkTenDN = "SELECT COUNT(*) FROM TAIKHOAN WHERE TENDANGNHAP = @tendangnhap";
                SqlCommand cmdCheck = new SqlCommand(checkTenDN, conn);
                cmdCheck.Parameters.AddWithValue("@tendangnhap", tenDN);
                int count = (int)cmdCheck.ExecuteScalar();
                if (count > 0)
                {
                    MessageBox.Show("Tên đăng nhập đã tồn tại, vui lòng chọn tên khác!");
                    return;
                }
                string sqlInsertNV = "INSERT INTO NHANVIEN (HOTEN, SDT, CHUCVU) VALUES (@HOTEN, @SDT, @CHUCVU);" + "SELECT SCOPE_IDENTITY();";
                SqlCommand cmdInsertNV = new SqlCommand(sqlInsertNV, conn);
                cmdInsertNV.Parameters.AddWithValue("@HOTEN", hoTen);
                cmdInsertNV.Parameters.AddWithValue("@SDT", SDT);
                cmdInsertNV.Parameters.AddWithValue("@CHUCVU", chucVu);
                int maNV = Convert.ToInt32(cmdInsertNV.ExecuteScalar());
                int maQuyen = (chucVu == "Quản lý") ? 1 : 2;

                string insertTaiKhoan = "INSERT INTO TAIKHOAN (TENDANGNHAP, MATKHAU, MANV, MAQ) VALUES (@TENDN, @MATKHAU, @MANV, @MAQUYEN)";
                SqlCommand cmdInsertTK = new SqlCommand(insertTaiKhoan, conn);
                cmdInsertTK.Parameters.AddWithValue("@TENDN", tenDN);
                cmdInsertTK.Parameters.AddWithValue("@MATKHAU", matKhau);
                cmdInsertTK.Parameters.AddWithValue("@MANV", maNV);
                cmdInsertTK.Parameters.AddWithValue("@MAQUYEN", maQuyen);
                cmdInsertTK.ExecuteNonQuery();

                MessageBox.Show("Thêm nhân viên thành công!");
                loadDSNV();
                txtHoTen.Clear();
                txtTenDangNhap.Clear();
                txtMatKhau.Clear();
                txtSDT.Clear();
                cbChucVu.SelectedIndex = 0;

            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi: " + ex.Message);
            }
            finally
            {
                conn.Close();
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            try
            {
                if (conn.State == ConnectionState.Closed)
                {
                    conn.Open();
                }
                if (tvDSNV.SelectedNode == null || tvDSNV.SelectedNode.Level != 1)
                {
                    MessageBox.Show("Vui lòng chọn nhân viên để xóa!");
                    return;
                }
                TreeNode treeNode = tvDSNV.SelectedNode;
                if (treeNode.Tag == null)
                {
                    MessageBox.Show("Vui lòng chọn nhân viên để xóa!");
                    return;
                }
                int maNV = Convert.ToInt32(treeNode.Tag);
                string tenNV = treeNode.Text;
                DialogResult confirm = MessageBox.Show(
            $"Bạn có chắc muốn xóa nhân viên {tenNV} không?",
            "Xác nhận xóa",
            MessageBoxButtons.YesNo,
            MessageBoxIcon.Question
        );
                if (confirm == DialogResult.No)
                    return;
                string deleteTaiKhoan = "DELETE FROM TAIKHOAN WHERE MANV = @MANV";
                SqlCommand cmdDeleteTK = new SqlCommand(deleteTaiKhoan, conn);
                cmdDeleteTK.Parameters.AddWithValue("@MANV", maNV);
                cmdDeleteTK.ExecuteNonQuery();
                string deleteNhanVien = "DELETE FROM NHANVIEN WHERE MANV = @MANV";
                SqlCommand cmdDeleteNV = new SqlCommand(deleteNhanVien, conn);
                cmdDeleteNV.Parameters.AddWithValue("@MANV", maNV);
                cmdDeleteNV.ExecuteNonQuery();
                MessageBox.Show("Đã xóa nhân viên thành công!");
                treeNode.Remove();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi: " + ex.Message);
            }
            finally
            {
                conn.Close();
            }
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            try
            {
                if(txtHoTen.Tag == null)
                {
                    MessageBox.Show("Vui lòng chọn nhân viên để sửa!");
                    return;
                }
                if (conn.State == ConnectionState.Closed)
                {
                    conn.Open();
                }
                int maNV = Convert.ToInt32(txtHoTen.Tag);
                string hoTen = txtHoTen.Text.Trim();
                string tenDN = txtTenDangNhap.Text.Trim();
                string matKhau = txtMatKhau.Text.Trim();
                string SDT = txtSDT.Text.Trim();
                string chucVu = cbChucVu.SelectedItem.ToString();
                if (string.IsNullOrEmpty(hoTen) || string.IsNullOrEmpty(tenDN) ||
                    string.IsNullOrEmpty(matKhau) || string.IsNullOrEmpty(SDT) || string.IsNullOrEmpty(chucVu))
                {
                    MessageBox.Show("Vui lòng nhập đầy đủ thông tin!");
                    return;
                }
                string sqlCapNhatNV = "UPDATE NHANVIEN SET HOTEN = @HOTEN, SDT = @SDT, CHUCVU = @CHUCVU WHERE MANV = @MANV";
                SqlCommand cmdCapNhatNV = new SqlCommand(sqlCapNhatNV, conn);
                cmdCapNhatNV.Parameters.AddWithValue("@HOTEN", hoTen);
                cmdCapNhatNV.Parameters.AddWithValue("@SDT", SDT);
                cmdCapNhatNV.Parameters.AddWithValue("@CHUCVU", chucVu);
                cmdCapNhatNV.Parameters.AddWithValue("@MANV", maNV);
                cmdCapNhatNV.ExecuteNonQuery();

                string sqlKiemTraTK = "SELECT COUNT(*) FROM TAIKHOAN WHERE MANV = @MANV";
                SqlCommand cmdKiemTraTK = new SqlCommand(sqlKiemTraTK, conn);
                cmdKiemTraTK.Parameters.AddWithValue("@MANV", maNV);
                int count = (int)cmdKiemTraTK.ExecuteScalar();
                if(count > 0)
                {
                    int maQuyen = (chucVu == "Quản lý") ? 1 : 2;
                    string sqlCapNhatTK = "UPDATE TAIKHOAN SET TENDANGNHAP = @TENDN, MATKHAU = @MATKHAU, MAQ = @MAQ WHERE MANV = @MANV";
                    SqlCommand cmdCapNhatTK = new SqlCommand(sqlCapNhatTK, conn);
                    cmdCapNhatTK.Parameters.AddWithValue("@TENDN", tenDN);
                    cmdCapNhatTK.Parameters.AddWithValue("@MATKHAU", matKhau);
                    cmdCapNhatTK.Parameters.AddWithValue("@MANV", maNV);
                    cmdCapNhatTK.Parameters.AddWithValue("@MAQ", maQuyen);
                    cmdCapNhatTK.ExecuteNonQuery();
                }
                else
                {
                    int maQuyen = (chucVu == "Quản lý") ? 1 : 2;
                    string insertTaiKhoan = "INSERT INTO TAIKHOAN (TENDANGNHAP, MATKHAU, MANV, MAQ) VALUES (@TENDN, @MATKHAU, @MANV, @MAQUYEN)";
                    SqlCommand cmdInsertTK = new SqlCommand(insertTaiKhoan, conn);
                    cmdInsertTK.Parameters.AddWithValue("@TENDN", tenDN);
                    cmdInsertTK.Parameters.AddWithValue("@MATKHAU", matKhau);
                    cmdInsertTK.Parameters.AddWithValue("@MANV", maNV);
                    cmdInsertTK.Parameters.AddWithValue("@MAQUYEN", maQuyen);
                    cmdInsertTK.ExecuteNonQuery();
                }
                MessageBox.Show("Cập nhật nhân viên thành công!");
                loadDSNV();
                txtHoTen.Clear();
                txtSDT.Clear();
                txtTenDangNhap.Clear();
                txtMatKhau.Clear();
                cbChucVu.SelectedIndex = 0;
                txtHoTen.Tag = null;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi: " + ex.Message);
            }
            finally
            {
                conn.Close();
            }
        }

        private void tvDSNV_AfterSelect(object sender, TreeViewEventArgs e)
        {
            if (e.Node.Tag == null)
            {
                return;
            }
            try
            {
                int maNV = Convert.ToInt32(e.Node.Tag);
                if (conn.State == ConnectionState.Closed)
                {
                    conn.Open();
                }
                string sql = "SELECT N.HOTEN, N.SDT, N.CHUCVU, TK.TENDANGNHAP, TK.MATKHAU FROM NHANVIEN N JOIN TAIKHOAN TK ON N.MANV = TK.MANV WHERE N.MANV = @MANV";
                SqlCommand cmd = new SqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("@MANV", maNV);
                SqlDataReader dr = cmd.ExecuteReader();
                if (dr.Read())
                {
                    txtHoTen.Text = dr["HOTEN"].ToString();
                    txtSDT.Text = dr["SDT"].ToString();
                    cbChucVu.SelectedItem = dr["CHUCVU"].ToString();
                    txtTenDangNhap.Text = dr["TENDANGNHAP"].ToString();
                    txtMatKhau.Text = dr["MATKHAU"].ToString();
                }
                dr.Close();
                txtHoTen.Tag = maNV;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi: " + ex.Message);
            }
            finally
            {
                conn.Close();
            }
        }
    } 
}
