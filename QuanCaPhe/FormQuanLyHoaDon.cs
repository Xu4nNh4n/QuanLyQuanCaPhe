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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace QuanCaPhe
{
    public partial class FormQuanLyHoaDon : Form
    {
        SqlConnection conn;
        public FormQuanLyHoaDon()
        {
            InitializeComponent();
            conn = new SqlConnection(@"Data Source=Xu4nNh4n\SQLEXPRESS;Initial Catalog=QLQUANCAFE;Integrated Security=True");
        }

        private void FormQuanLyHoaDon_Load(object sender, EventArgs e)
        {
            loadHoaDon();
        }
        int lastHoaDon = -1;
        private void loadHoaDon()
        {
            try
            {
                if (conn.State == ConnectionState.Closed)
                    conn.Open();
                string sqlHoaDon = "SELECT HD.MAHD, HD.NGAYLAP, NV.HOTEN, B.TENBAN, HD.TONGTIEN FROM HOADON HD JOIN NHANVIEN NV ON NV.MANV = HD.MANV JOIN BAN B ON B.MABAN = HD.MABAN";
                SqlCommand cmdHoaDon = new SqlCommand(sqlHoaDon, conn);
                SqlDataReader reader = cmdHoaDon.ExecuteReader();
                lstHoaDon.Items.Clear();
                while (reader.Read())
                {
                    ListViewItem item = new ListViewItem(reader["MAHD"].ToString());
                    item.SubItems.Add(Convert.ToDateTime(reader["NGAYLAP"]).ToString("dd/MM/yyyy HH:mm"));
                    item.SubItems.Add(reader["HOTEN"].ToString());
                    item.SubItems.Add(reader["TENBAN"].ToString());
                    item.SubItems.Add(reader["TONGTIEN"].ToString());
                    lstHoaDon.Items.Add(item);
                }
                reader.Close();

            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi tải hóa đơn: " + ex.Message);
            }
            finally
            {
                if (conn.State == ConnectionState.Open)
                    conn.Close();
            }
        }
        private void loadChiTietHoaDon(int maHD)
        {
            try
            {
                if (conn.State == ConnectionState.Closed)
                    conn.Open();
                lstChiTietHD.Items.Clear();
                string sqlChiTietHoaDon =  @"SELECT CTHD.MAMON, M.TENMON, CTHD.SOLUONG, CTHD.DONGIA, CTHD.THANHTIEN FROM CHITIETHOADON CTHD JOIN MONAN M ON CTHD.MAMON = M.MAMON WHERE CTHD.MAHD = @mahd";
                SqlCommand cmdCTHoaDon = new SqlCommand(sqlChiTietHoaDon, conn);
                cmdCTHoaDon.Parameters.AddWithValue("@mahd", maHD);
                SqlDataReader dr = cmdCTHoaDon.ExecuteReader();
                while (dr.Read())
                {
                    ListViewItem item = new ListViewItem(dr["MAMON"].ToString());
                    item.SubItems.Add(dr["TENMON"].ToString());
                    item.SubItems.Add(dr["SOLUONG"].ToString());
                    item.SubItems.Add(Convert.ToDecimal(dr["DONGIA"]).ToString("N0") + "VNĐ");
                    item.SubItems.Add(Convert.ToDecimal(dr["THANHTIEN"]).ToString("N0") + "VNĐ");
                    lstChiTietHD.Items.Add(item);
                }
                dr.Close();
                    
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi tải chi tiết hóa đơn: " + ex.Message);
            }
            finally
            {
                if (conn.State == ConnectionState.Open)
                    conn.Close();
            }
        }

        private void lstHoaDon_Click(object sender, EventArgs e)
        {
            if (lstHoaDon.SelectedItems.Count == 0)
                return;
            int maHD = Convert.ToInt32(lstHoaDon.SelectedItems[0].SubItems[0].Text);
            loadChiTietHoaDon(maHD);
        }
        private void loadHoaDonTheoKeyWord(string key)
        {
            try
            {
                if (conn.State == ConnectionState.Closed)
                    conn.Open();

                bool isNumeric = int.TryParse(key, out int mahd);
                bool isDate = DateTime.TryParse(key, out DateTime ngayLap);
                bool isMoney = decimal.TryParse(key, out decimal tongTien);
                string sqlHoaDon = @"SELECT HD.MAHD, HD.NGAYLAP, NV.HOTEN, B.TENBAN, HD.TONGTIEN FROM HOADON HD JOIN NHANVIEN NV ON NV.MANV = HD.MANV JOIN BAN B ON B.MABAN = HD.MABAN WHERE B.TENBAN LIKE @key OR NV.HOTEN LIKE @key";
                if (isNumeric) sqlHoaDon += " OR HD.MAHD = @mahd";
                if (isDate) sqlHoaDon += " OR CONVERT(DATE, HD.NGAYLAP) = @ngaylap";
                if (isMoney) sqlHoaDon += " OR HD.TONGTIEN = @tongtien";

                SqlCommand cmdHoaDon = new SqlCommand(sqlHoaDon, conn);
                cmdHoaDon.Parameters.Add("@key", SqlDbType.NVarChar).Value = "%" + key + "%";

                if (isNumeric)
                    cmdHoaDon.Parameters.AddWithValue("@mahd", mahd);
                if (isDate)
                    cmdHoaDon.Parameters.AddWithValue("@ngaylap", ngayLap.Date);
                if (isMoney)
                    cmdHoaDon.Parameters.AddWithValue("@tongtien", tongTien);
                SqlDataReader reader = cmdHoaDon.ExecuteReader();
                lstHoaDon.Items.Clear();
                while (reader.Read())
                {
                    ListViewItem item = new ListViewItem(reader["MAHD"].ToString());
                    item.SubItems.Add(Convert.ToDateTime(reader["NGAYLAP"]).ToString("dd/MM/yyyy HH:mm"));
                    item.SubItems.Add(reader["HOTEN"].ToString());
                    item.SubItems.Add(reader["TENBAN"].ToString());
                    item.SubItems.Add(reader["TONGTIEN"].ToString());
                    lstHoaDon.Items.Add(item);
                }
                reader.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi tải hóa đơn: " + ex.Message);
            }
            finally
            {
                if (conn.State == ConnectionState.Open)
                    conn.Close();

            }
        }
        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            string input = txtTimKiem.Text.Trim();
            loadHoaDonTheoKeyWord(input);
        }

        private void lstHoaDon_Resize(object sender, EventArgs e)
        {
            ResizeColumns();
        }
        private void ResizeColumns()
        {
            int colCount = lstHoaDon.Columns.Count;
            int colCount2 = lstChiTietHD.Columns.Count;
            if (colCount == 0) return;

            int totalWidth = lstHoaDon.ClientSize.Width;
            int colWidth = totalWidth / colCount;

            foreach (ColumnHeader col in lstHoaDon.Columns)
            {
                col.Width = colWidth;
            }
            if (colCount2 == 0) return;
            int totalWidth2 = lstChiTietHD.ClientSize.Width;
            int colWidth2 = totalWidth2 / colCount2;
            foreach (ColumnHeader col in lstChiTietHD.Columns)
            {
                col.Width = colWidth2;
            }
        }
    }
}
