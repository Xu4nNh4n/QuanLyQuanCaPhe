using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanCaPhe
{
    public partial class FormQuanLyMonAn : Form
    {
        SqlConnection conn;
        public FormQuanLyMonAn()
        {
            InitializeComponent();
            conn = new SqlConnection(@"Data Source=Xu4nNh4n\SQLEXPRESS;Initial Catalog=QLQUANCAFE;Integrated Security=True");
        }
        private void loadMonAn()
        {
            try
            {
                if (conn.State == ConnectionState.Closed)
                    conn.Open();
                string query = "SELECT MAMON, TENMON, DONGIA, LM.TENLOAI FROM MONAN JOIN LOAIMON LM ON LM.MALOAI = MONAN.MALOAI";
                SqlCommand cmd = new SqlCommand(query, conn);
                SqlDataReader reader = cmd.ExecuteReader();
                lstTTMonAn.Items.Clear();
                while (reader.Read())
                {
                    ListViewItem item = new ListViewItem(reader["MAMON"].ToString());
                    item.SubItems.Add(reader["TENMON"].ToString());
                    item.SubItems.Add(reader["DONGIA"].ToString());
                    item.SubItems.Add(reader["TENLOAI"].ToString());
                    lstTTMonAn.Items.Add(item);
                }
                reader.Close();

            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi hiển thị món: " + ex.Message);
            }
            finally
            {
                conn.Close();
            }
        }
        private void loadLoaiMonAN()
        {
            try
            {
                lstTTLoaiMon.Items.Clear();
                cbMaLoai.Items.Clear();
                string loaiMon = "Chọn loại món";
                cbMaLoai.Items.Add(loaiMon);
                cbMaLoai.SelectedIndex = 0;
                if (conn.State == ConnectionState.Closed)
                    conn.Open();
                string query = "SELECT * FROM LOAIMON";
                SqlCommand cmd = new SqlCommand(query, conn);
                SqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    ListViewItem item = new ListViewItem(reader["MALOAI"].ToString());
                    item.SubItems.Add(reader["TENLOAI"].ToString());
                    lstTTLoaiMon.Items.Add(item);
                    cbMaLoai.Items.Add(reader["MALOAI"].ToString());
                }
                reader.Close();
                cbMaLoai.SelectedIndex = 0;



            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi hiển thị loại món: " + ex.Message);
            }
            finally
            {
                if (conn.State == ConnectionState.Open)
                    conn.Close();
            }
        }
        private void FormQuanLyMonAn_Load(object sender, EventArgs e)
        {
            loadMonAn();
            loadLoaiMonAN();
            // Giãn đều ra //
            int tongWidth = lstTTMonAn.ClientSize.Width;
            lstTTMonAn.Columns[0].Width = (int)(tongWidth * 0.2);
            lstTTMonAn.Columns[1].Width = (int)(tongWidth * 0.4);
            lstTTMonAn.Columns[2].Width = (int)(tongWidth * 0.2);
            lstTTMonAn.Columns[3].Width = (int)(tongWidth * 0.2);
            labThongBao.Visible = false;
        }
        private void HienThongBao(string message, Color color)
        {
            labThongBao.Text = message;
            labThongBao.ForeColor = color;
            labThongBao.Visible = true;

            Timer timer = new Timer();
            timer.Interval = 5000;
            timer.Tick += (s, e) =>
            {
                labThongBao.Visible = false;
                timer.Stop();
                timer.Dispose();
            };
            timer.Start();
        }
        private void tblTTMA_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnThemLoaiMon_Click(object sender, EventArgs e)
        {

            try
            {
                if (conn.State == ConnectionState.Closed)
                    conn.Open();
                string tenLoai = txtTenLoaiMon.Text.Trim();
                if (tenLoai == "")
                {
                    MessageBox.Show("Vui lòng nhập tên loại món!");
                    return;
                }
                string KiemTraQuery = "SELECT COUNT(*) FROM LOAIMON WHERE TENLOAI = @tenloai";
                SqlCommand cmd = new SqlCommand(KiemTraQuery, conn);
                cmd.Parameters.AddWithValue("@tenloai", tenLoai);
                int count = (int)cmd.ExecuteScalar();
                if (count > 0)
                {
                    MessageBox.Show("Loại món đã tồn tại!");
                    txtTenLoaiMon.Clear();
                    txtTenLoaiMon.Focus();
                    return;
                }
                string insertQuery = "INSERT INTO LOAIMON (TENLOAI) VALUES (@tenloai)";
                SqlCommand insertCmd = new SqlCommand(insertQuery, conn);
                insertCmd.Parameters.AddWithValue("@tenloai", tenLoai);
                insertCmd.ExecuteNonQuery();
                HienThongBao("Thêm thành công!", Color.Green);
                loadLoaiMonAN();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi kiểm tra loại món: " + ex.Message);
            }
            finally
            {
                conn.Close();
            }
        }

        private void btnXoaLoaiMon_Click(object sender, EventArgs e)
        {
            try
            {
                if (conn.State == ConnectionState.Closed)
                    conn.Open();

                string tenLoai = txtTenLoaiMon.Text.Trim();
                string KiemTraQuery = "SELECT MALOAI FROM LOAIMON WHERE TENLOAI = @tenloai";
                SqlCommand cmd = new SqlCommand(KiemTraQuery, conn);
                cmd.Parameters.AddWithValue("@tenloai", tenLoai);
                object result = cmd.ExecuteScalar();

                if (result == null || result == DBNull.Value)
                {
                    HienThongBao("Loại món không tồn tại!", Color.Red);
                    conn.Close();
                    return;
                }
                int maLoai = Convert.ToInt32(result);
                string KiemTraThongTinMonAN = "SELECT COUNT(*) FROM MONAN WHERE MALOAI = @maloai";
                SqlCommand cmdKiemTra = new SqlCommand(KiemTraThongTinMonAN, conn);
                cmdKiemTra.Parameters.AddWithValue("@maloai", maLoai);
                int count = (int)cmdKiemTra.ExecuteScalar();
                if (count > 0)
                {
                    MessageBox.Show("Không thể xóa loại món này vì có món ăn thuộc loại này!");
                    HienThongBao("Xóa thất bại", Color.Red);
                    conn.Close();

                    return;
                }
                string deleteQuery = "DELETE FROM LOAIMON WHERE MALOAI = @maloai";
                SqlCommand deleteCmd = new SqlCommand(deleteQuery, conn);
                deleteCmd.Parameters.AddWithValue("@maloai", maLoai);
                deleteCmd.ExecuteNonQuery();
                HienThongBao("Xóa thành công", Color.Green);
                loadLoaiMonAN();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi xóa loại món: " + ex.Message);
            }
            finally
            {
                if (conn.State == ConnectionState.Open)
                {
                    conn.Close();
                }
            }
        }

        private void btnSuaLoaiMon_Click(object sender, EventArgs e)
        {
            try
            {
                if (conn.State == ConnectionState.Closed)
                    conn.Open();
                string tenLoai = txtTenLoaiMon.Text.Trim();
                if (string.IsNullOrEmpty(tenLoai))
                {
                    MessageBox.Show("Vui lòng nhập tên loại món cần sửa!");
                    return;
                }
                if (lstTTLoaiMon.SelectedItems.Count == 0)
                {
                    MessageBox.Show("Vui lòng chọn loại món cần sửa trong danh sách!");
                    return;
                }
                int maLoai = Convert.ToInt32(lstTTLoaiMon.SelectedItems[0].SubItems[0].Text);
                string KiemTraTen = "SELECT COUNT(*) FROM LOAIMON WHERE TENLOAI = @tenloai AND MALOAI <> @maloai";
                SqlCommand cmdCheck = new SqlCommand(KiemTraTen, conn);
                cmdCheck.Parameters.AddWithValue("@tenloai", tenLoai);
                cmdCheck.Parameters.AddWithValue("@maloai", maLoai);
                int count = (int)cmdCheck.ExecuteScalar();
                if (count > 0)
                {
                    MessageBox.Show("Tên loại món này đã tồn tại!");
                    return;
                }
                string sqlUpdate = "UPDATE LOAIMON SET TENLOAI = @tenloai WHERE MALOAI = @maloai";
                SqlCommand cmdUpdate = new SqlCommand(sqlUpdate, conn);
                cmdUpdate.Parameters.AddWithValue("@tenloai", tenLoai);
                cmdUpdate.Parameters.AddWithValue("@maloai", maLoai);
                int rows = cmdUpdate.ExecuteNonQuery();

                if (rows > 0)
                {
                    HienThongBao("Cập nhật thành công", Color.Green);
                }
                else
                {
                    HienThongBao("Cập nhậ thất bại", Color.Red);
                }


                loadLoaiMonAN();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi sửa loại món: " + ex.Message);
            }
            finally
            {
                if (conn.State == ConnectionState.Open)
                    conn.Close();
            }
        }
        private void lstTTLoaiMon_Click(object sender, EventArgs e)
        {
            if (lstTTLoaiMon.SelectedItems.Count > 0)
            {
                txtTenLoaiMon.Text = lstTTLoaiMon.SelectedItems[0].SubItems[1].Text;
            }
        }

        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            try
            {
                if (conn.State == ConnectionState.Closed)
                    conn.Open();
                string tenMonAn = txtTenMonCanTim.Text.Trim();
                string Xuatquery = "SELECT MAMON, TENMON, DONGIA FROM MONAN WHERE TENMON = @tenmon";
                SqlCommand cmd = new SqlCommand(Xuatquery, conn);
                cmd.Parameters.AddWithValue("@tenmon", tenMonAn);
                SqlDataReader reader = cmd.ExecuteReader();
                lstDSTimKiem.Items.Clear();
                while (reader.Read())
                {
                    ListViewItem item = new ListViewItem(reader["MAMON"].ToString());
                    item.SubItems.Add(reader["TENMON"].ToString());
                    item.SubItems.Add(reader["DONGIA"].ToString());
                    lstDSTimKiem.Items.Add(item);
                }
                reader.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi tìm kiếm món ăn: " + ex.Message);
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
                    conn.Open();
                string tenMon = txtTenMon.Text.Trim();
                decimal donGia = int.Parse(txtDonGia.Text.Trim());
                int maLoai = int.Parse(cbMaLoai.SelectedItem.ToString());
                string insertQuery = "INSERT INTO MONAN (TENMON, DONGIA, MALOAI) VALUES (@tenmon, @dongia, @maloai)";
                SqlCommand cmd = new SqlCommand(insertQuery, conn);
                cmd.Parameters.AddWithValue("@tenmon", tenMon);
                cmd.Parameters.AddWithValue("@dongia", donGia);
                cmd.Parameters.AddWithValue("@maloai", maLoai);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Thêm món ăn thành công!");
                ResetMonAn();
                loadMonAn();

            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi thêm món ăn: " + ex.Message);
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
                    conn.Open();
                if (lstTTMonAn.SelectedItems.Count == 0)
                {
                    MessageBox.Show("Vui lòng chọn món ăn cần xóa!");
                    return;
                }
                int maMon = Convert.ToInt32(lstTTMonAn.SelectedItems[0].SubItems[0].Text);
                string deleteQuery = "DELETE FROM MONAN WHERE MAMON = @mamon";
                SqlCommand cmd = new SqlCommand(deleteQuery, conn);
                cmd.Parameters.AddWithValue("@mamon", maMon);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Xóa món ăn thành công!");
                ResetMonAn();
                loadMonAn();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi xóa món ăn: " + ex.Message);
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
                if (conn.State == ConnectionState.Closed)
                    conn.Open();
                if (lstTTMonAn.SelectedItems.Count == 0)
                {
                    MessageBox.Show("Vui lòng chọn món ăn cần sửa!");
                    return;
                }
                int maMon = Convert.ToInt32(lstTTMonAn.SelectedItems[0].SubItems[0].Text);
                string tenMon = txtTenMon.Text.Trim();
                if (string.IsNullOrEmpty(tenMon))
                {
                    MessageBox.Show("Tên món không được để trống!");
                    return;
                }
                if (!decimal.TryParse(txtDonGia.Text.Trim(), out decimal donGia))
                {
                    MessageBox.Show("Đơn giá không hợp lệ!");
                    return;
                }
                if (cbMaLoai.SelectedIndex <= 0)
                {
                    MessageBox.Show("Vui lòng chọn loại món!");
                    return;
                }
                int maLoai = int.Parse(cbMaLoai.SelectedItem.ToString());

                string updateQuery = "UPDATE MONAN SET TENMON = @tenmon, DONGIA = @dongia, MALOAI = @maloai WHERE MAMON = @mamon";
                SqlCommand cmd = new SqlCommand(updateQuery, conn);
                cmd.Parameters.AddWithValue("@tenmon", tenMon);
                cmd.Parameters.AddWithValue("@dongia", donGia);
                cmd.Parameters.AddWithValue("@maloai", maLoai);
                cmd.Parameters.AddWithValue("@mamon", maMon);
                cmd.ExecuteNonQuery();
                int rows = cmd.ExecuteNonQuery();

                if (rows > 0)
                    MessageBox.Show("Sửa món ăn thành công!");
                else
                    MessageBox.Show("Không có thay đổi nào được thực hiện.");
                ResetMonAn();
                loadMonAn();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi sửa món ăn: " + ex.Message);
            }
            finally
            {
                conn.Close();
            }
        }

        private void lstTTMonAn_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void lstTTMonAn_Click(object sender, EventArgs e)
        {
            if (lstTTMonAn.SelectedItems.Count > 0)
            {
                ListViewItem item = lstTTMonAn.SelectedItems[0];
                txtTenMon.Text = item.SubItems[1].Text;    
                txtDonGia.Text = item.SubItems[2].Text;

            }
        }
        private void ResetMonAn()
        {
            txtTenMon.Clear();
            txtDonGia.Clear();
            cbMaLoai.SelectedIndex = 0;
        }
    }
}
