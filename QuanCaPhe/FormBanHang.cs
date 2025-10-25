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
    public partial class FormBanHang : Form
    {
        Button banDangChon = null;
        int maBanDangChon = -1;
        SqlConnection conn;
        Dictionary<int, List<ListViewItem>> hoaDonTam = new Dictionary<int, List<ListViewItem>>();

        public FormBanHang()
        {
            InitializeComponent();
            conn = new SqlConnection(@"Data Source=Xu4nNh4n\SQLEXPRESS;Initial Catalog=QLQUANCAFE;Integrated Security=True");
        }

        private void flpMenu_Resize(object sender, EventArgs e)
        {
        }

        private void flpHoaDon_Resize(object sender, EventArgs e)
        {

        }

        private void FormBanHang_Load(object sender, EventArgs e)
        {
            try
            {
                conn.Open();
                string sql = "SELECT MABAN, TENBAN, TRANGTHAI FROM BAN ORDER BY MABAN ASC";
                SqlCommand cmd = new SqlCommand(sql, conn);
                SqlDataReader reader = cmd.ExecuteReader();

                var buttons = tblDSban.Controls.OfType<Button>().Reverse().ToList();
                int i = 0;

                while (reader.Read() && i < buttons.Count)
                {
                    Button btn = buttons[i];
                    btn.Text = reader["TENBAN"].ToString();
                    btn.Tag = Convert.ToInt32(reader["MABAN"]);

                    string tt = reader["TRANGTHAI"].ToString();
                    if (tt == "Trống") btn.BackColor = Color.LightGray;
                    else if (tt == "Có khách") btn.BackColor = Color.LimeGreen;
                    else btn.BackColor = Color.LightGray;

                    btn.Click += BtnBan_Click;
                    i++;
                }

                reader.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi load danh sách bàn: " + ex.Message);
            }
            finally
            {
                conn.Close();
            }
            LoadLoaiMon();


        }
        private void LoadLoaiMon()
        {
            try
            {
                conn.Open();
                string query = "SELECT * FROM LOAIMON";
                SqlDataAdapter da = new SqlDataAdapter(query, conn);
                DataTable dt = new DataTable();
                da.Fill(dt);

                DataRow dr = dt.NewRow();
                dr["MALOAI"] = 0;
                dr["TENLOAI"] = "--Danh mục--";
                dt.Rows.InsertAt(dr, 0);
                cbDanhMuc.DataSource = dt;
                cbDanhMuc.DisplayMember = "TENLOAI";
                cbDanhMuc.ValueMember = "MALOAI";
                cbDanhMuc.SelectedIndex = 0;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi tải loại món: " + ex.Message);
            }
            finally
            {
                conn.Close();
            }
        }
        private void BtnBan_Click(object sender, EventArgs e)
        {
            Button btn = sender as Button;
            
            if(banDangChon != null)
            {
                List<ListViewItem> dsTam = new List<ListViewItem>();
                foreach (ListViewItem item in lstDSMonAndangsd.Items)
                {
                    dsTam.Add((ListViewItem)item.Clone());
                }

                hoaDonTam[maBanDangChon] = dsTam;
            }
            if (banDangChon == btn)
            {
                // Nếu bàn có món thì về cam, nếu chưa thì về xanh
                if (hoaDonTam.ContainsKey(maBanDangChon) && hoaDonTam[maBanDangChon].Count > 0)
                    btn.BackColor = Color.LimeGreen;
                else
                    btn.BackColor = Color.LightGray;

                banDangChon = null;
                maBanDangChon = -1;
                lstDSMonAndangsd.Items.Clear();
                CapNhatTongTien();
                return;
            }

            if (banDangChon != null && banDangChon != btn)
            {
                if (hoaDonTam.ContainsKey(maBanDangChon) && hoaDonTam[maBanDangChon].Count > 0)
                    banDangChon.BackColor = Color.LimeGreen;
                else
                    banDangChon.BackColor = Color.LightGray;
            }
            banDangChon = btn;
            maBanDangChon = Convert.ToInt32(btn.Tag);
            btn.BackColor = Color.Red;

            lstDSMonAndangsd.Items.Clear();
            if (hoaDonTam.ContainsKey(maBanDangChon))
            {
                foreach (ListViewItem item in hoaDonTam[maBanDangChon])
                {
                    lstDSMonAndangsd.Items.Add((ListViewItem)item.Clone());
                }
            }
            CapNhatTongTien();
        }

        private void btnThanhToan_Click(object sender, EventArgs e)
        {
            if(banDangChon == null)
            {
                MessageBox.Show("Vui lòng chọn bàn trước khi thanh toán.");
                return;
            }
            if(lstDSMonAndangsd.Items.Count == 0)
            {
                MessageBox.Show("Bàn chưa có món để thanh toán.");
                return;
            }
           string TongTien = txtTongTien.Text.Replace("VNĐ", "").Replace(",", "").Trim();
            try
            {
                conn.Open();
                string sqlHoaDon = @"INSERT INTO HOADON (NGAYLAP, TONGTIEN, MANV, MABAN)
                         OUTPUT INSERTED.MAHD
                         VALUES (GETDATE(), @tongTien, @manv, @maban)";
                SqlCommand cmdHD = new SqlCommand(sqlHoaDon, conn);
                cmdHD.Parameters.AddWithValue("@tongTien", TongTien);
                cmdHD.Parameters.AddWithValue("@manv", SessionLogin.MaNV);
                cmdHD.Parameters.AddWithValue("@maban", maBanDangChon);
                int maHD = (int)cmdHD.ExecuteScalar();
                
                foreach(ListViewItem item in lstDSMonAndangsd.Items)
                {
                    string tenMon = item.SubItems[1].Text;
                    string giaText = item.SubItems[2].Text.Replace("VNĐ", "").Replace(",", "").Trim();
                    decimal donGia = Convert.ToDecimal(giaText);
                    int soLuong = Convert.ToInt32(item.SubItems[3].Text);

                    string sqlMon = "SELECT MAMON FROM MONAN WHERE TENMON = @tenMon";
                    SqlCommand cmdMon = new SqlCommand(sqlMon, conn);
                    cmdMon.Parameters.AddWithValue("@tenMon", tenMon);
                    int maMon = Convert.ToInt32(cmdMon.ExecuteScalar());

                    string sqlCT = @"INSERT INTO CHITIETHOADON (MAHD, MAMON, SOLUONG, DONGIA)
                             VALUES (@mahd, @mamon, @soluong, @dongia)";
                    SqlCommand cmdCT = new SqlCommand(sqlCT, conn);
                    cmdCT.Parameters.AddWithValue("@mahd", maHD);
                    cmdCT.Parameters.AddWithValue("@mamon", maMon);
                    cmdCT.Parameters.AddWithValue("@soluong", soLuong);
                    cmdCT.Parameters.AddWithValue("@dongia", donGia);
                    cmdCT.ExecuteNonQuery();
                }
                string sqlBan = "UPDATE BAN SET TRANGTHAI = N'Trống' WHERE MABAN = @maban";
                SqlCommand cmdBan = new SqlCommand(sqlBan, conn);
                cmdBan.Parameters.AddWithValue("@maban", maBanDangChon);
                cmdBan.ExecuteNonQuery();

                hoaDonTam.Remove(maBanDangChon);

                MessageBox.Show($"Thanh toán {banDangChon.Text} thành công!\nTổng tiền: {TongTien:N0} VNĐ");
                lstDSMonAndangsd.Items.Clear();
                CapNhatTongTien();
                banDangChon.BackColor = Color.LightGray;
                banDangChon = null;
                maBanDangChon = -1;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi thanh toán: " + ex.Message);
            }
            finally
            {
                conn.Close();
            }
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            if (banDangChon == null)
            {
                MessageBox.Show("Vui lòng chọn bàn trước khi thêm món.");
                return;
            }
            if(lstDSMonAn.SelectedItems.Count == 0)
            {
                MessageBox.Show("Vui lòng chọn món ăn để thêm.");
                return;
            }


            var chonMon = lstDSMonAn.SelectedItems[0];
            string tenMon = chonMon.SubItems[1].Text;
            string giaText = chonMon.SubItems[2].Text.Replace("VNĐ", "").Trim();
            giaText = giaText.Replace(",", "").Replace(".", ""); 
            decimal donGia = Convert.ToDecimal(giaText);
            int soLuong = (int)numSoLuong.Value;
            if(soLuong <= 0)
            {
                MessageBox.Show("Vui lòng chọn số lượng lớn hơn 0.");
                return;
            }
            decimal thanhTien = donGia * soLuong;
            int stt = lstDSMonAndangsd.Items.Count + 1;
            ListViewItem itemHD = new ListViewItem(stt.ToString());
            itemHD.SubItems.Add(tenMon);
            itemHD.SubItems.Add(donGia.ToString("N0") + " VNĐ");
            itemHD.SubItems.Add(soLuong.ToString());
            itemHD.SubItems.Add(thanhTien.ToString("N0") + " VNĐ");
            lstDSMonAndangsd.Items.Add(itemHD);
            banDangChon.BackColor = Color.LimeGreen;
            CapNhatTongTien();

            List<ListViewItem> dsTam = new List<ListViewItem>();
            foreach(ListViewItem item in lstDSMonAndangsd.Items)
            {
                dsTam.Add((ListViewItem)item.Clone());
            }
            hoaDonTam[maBanDangChon] = dsTam;
            try
            {
                conn.Open();
                string sql = "UPDATE BAN SET TRANGTHAI = N'Có khách' WHERE MABAN = @maban";
                SqlCommand cmd = new SqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("@maban", maBanDangChon);
                cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi cập nhật trạng thái bàn: " + ex.Message);
            }
            finally
            {
                conn.Close();
            }
        }
        private void CapNhatTongTien()
        {
            decimal Tong = 0;
            foreach(ListViewItem item in lstDSMonAndangsd.Items)
            {
                string Tien = item.SubItems[4].Text.Replace("VNĐ", "").Replace(",", "").Trim();
                if(decimal.TryParse(Tien, out decimal tien))
                {
                    Tong += tien;
                }    
            }
            txtTongTien.Text = Tong.ToString() + "VNĐ";

        }

        private void cbDanhMuc_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbDanhMuc.SelectedValue == null)
                return;
            int maLoai;
            bool isNumber = int.TryParse(cbDanhMuc.SelectedValue.ToString(), out maLoai);
            if (!isNumber || maLoai == 0)
            {
                lstDSMonAn.Items.Clear();
                return;
            }
            if (maLoai <= 0)
            {
                lstDSMonAn.Items.Clear();
                return;
            }
            lstDSMonAn.Items.Clear();
            try
            {
                conn.Open();
                string query = "SELECT MAMON, TENMON, DONGIA FROM MONAN WHERE MALOAI = @maLoai";
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@maLoai", maLoai);
                SqlDataReader reader = cmd.ExecuteReader();
                int stt = 1;
                while (reader.Read())
                {
                    ListViewItem item = new ListViewItem(stt.ToString());
                    item.SubItems.Add(reader["TENMON"].ToString());
                    item.SubItems.Add(string.Format("{0:N0} VNĐ", reader["DONGIA"]));
                    item.Tag = reader["MAMON"];
                    lstDSMonAn.Items.Add(item);
                    stt++;
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

    }
}
