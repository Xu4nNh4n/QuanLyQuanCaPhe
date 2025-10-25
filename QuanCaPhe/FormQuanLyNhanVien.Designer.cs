namespace QuanCaPhe
{
    partial class FormQuanLyNhanVien
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.tblQuanLyNhanVien = new System.Windows.Forms.TableLayoutPanel();
            this.tvDSNV = new System.Windows.Forms.TreeView();
            this.grbNV = new System.Windows.Forms.GroupBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.cbChucVu = new System.Windows.Forms.ComboBox();
            this.txtTenDangNhap = new System.Windows.Forms.TextBox();
            this.btnThem = new System.Windows.Forms.Button();
            this.txtHoTen = new System.Windows.Forms.TextBox();
            this.txtMatKhau = new System.Windows.Forms.TextBox();
            this.txtSDT = new System.Windows.Forms.TextBox();
            this.btnXoa = new System.Windows.Forms.Button();
            this.btnSua = new System.Windows.Forms.Button();
            this.grbThongTinNV = new System.Windows.Forms.GroupBox();
            this.tblQuanLyNhanVien.SuspendLayout();
            this.grbNV.SuspendLayout();
            this.grbThongTinNV.SuspendLayout();
            this.SuspendLayout();
            // 
            // tblQuanLyNhanVien
            // 
            this.tblQuanLyNhanVien.ColumnCount = 2;
            this.tblQuanLyNhanVien.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tblQuanLyNhanVien.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tblQuanLyNhanVien.Controls.Add(this.tvDSNV, 0, 0);
            this.tblQuanLyNhanVien.Controls.Add(this.grbThongTinNV, 1, 0);
            this.tblQuanLyNhanVien.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tblQuanLyNhanVien.Location = new System.Drawing.Point(0, 0);
            this.tblQuanLyNhanVien.Name = "tblQuanLyNhanVien";
            this.tblQuanLyNhanVien.RowCount = 1;
            this.tblQuanLyNhanVien.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tblQuanLyNhanVien.Size = new System.Drawing.Size(1085, 629);
            this.tblQuanLyNhanVien.TabIndex = 0;
            // 
            // tvDSNV
            // 
            this.tvDSNV.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tvDSNV.Font = new System.Drawing.Font("Cascadia Code SemiBold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tvDSNV.Location = new System.Drawing.Point(3, 3);
            this.tvDSNV.Name = "tvDSNV";
            this.tvDSNV.Size = new System.Drawing.Size(536, 623);
            this.tvDSNV.TabIndex = 1;
            this.tvDSNV.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.tvDSNV_AfterSelect);
            // 
            // grbNV
            // 
            this.grbNV.Controls.Add(this.btnSua);
            this.grbNV.Controls.Add(this.btnXoa);
            this.grbNV.Controls.Add(this.txtSDT);
            this.grbNV.Controls.Add(this.txtMatKhau);
            this.grbNV.Controls.Add(this.txtHoTen);
            this.grbNV.Controls.Add(this.btnThem);
            this.grbNV.Controls.Add(this.txtTenDangNhap);
            this.grbNV.Controls.Add(this.cbChucVu);
            this.grbNV.Controls.Add(this.label8);
            this.grbNV.Controls.Add(this.label4);
            this.grbNV.Controls.Add(this.label3);
            this.grbNV.Controls.Add(this.label2);
            this.grbNV.Controls.Add(this.label7);
            this.grbNV.Location = new System.Drawing.Point(6, 40);
            this.grbNV.Name = "grbNV";
            this.grbNV.Size = new System.Drawing.Size(345, 290);
            this.grbNV.TabIndex = 2;
            this.grbNV.TabStop = false;
            this.grbNV.Text = "Thêm nhân viên";
            // 
            // label7
            // 
            this.label7.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label7.Location = new System.Drawing.Point(6, 75);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(123, 24);
            this.label7.TabIndex = 12;
            this.label7.Text = "Tên đăng nhập";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label2.Location = new System.Drawing.Point(6, 40);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(123, 19);
            this.label2.TabIndex = 2;
            this.label2.Text = "Họ tên";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label3.Location = new System.Drawing.Point(6, 145);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(123, 24);
            this.label3.TabIndex = 4;
            this.label3.Text = "Số điện thoại";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label4.Location = new System.Drawing.Point(6, 180);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(123, 24);
            this.label4.TabIndex = 6;
            this.label4.Text = "Chức vụ";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label8
            // 
            this.label8.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label8.Location = new System.Drawing.Point(6, 110);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(123, 24);
            this.label8.TabIndex = 14;
            this.label8.Text = "Mật khẩu";
            this.label8.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // cbChucVu
            // 
            this.cbChucVu.FormattingEnabled = true;
            this.cbChucVu.Location = new System.Drawing.Point(135, 180);
            this.cbChucVu.Name = "cbChucVu";
            this.cbChucVu.Size = new System.Drawing.Size(185, 25);
            this.cbChucVu.TabIndex = 15;
            // 
            // txtTenDangNhap
            // 
            this.txtTenDangNhap.Location = new System.Drawing.Point(135, 76);
            this.txtTenDangNhap.Name = "txtTenDangNhap";
            this.txtTenDangNhap.Size = new System.Drawing.Size(185, 23);
            this.txtTenDangNhap.TabIndex = 16;
            // 
            // btnThem
            // 
            this.btnThem.Location = new System.Drawing.Point(9, 219);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(100, 52);
            this.btnThem.TabIndex = 17;
            this.btnThem.Text = "Thêm";
            this.btnThem.UseVisualStyleBackColor = true;
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // txtHoTen
            // 
            this.txtHoTen.Location = new System.Drawing.Point(135, 38);
            this.txtHoTen.Name = "txtHoTen";
            this.txtHoTen.Size = new System.Drawing.Size(185, 23);
            this.txtHoTen.TabIndex = 18;
            // 
            // txtMatKhau
            // 
            this.txtMatKhau.Location = new System.Drawing.Point(135, 110);
            this.txtMatKhau.Name = "txtMatKhau";
            this.txtMatKhau.Size = new System.Drawing.Size(185, 23);
            this.txtMatKhau.TabIndex = 19;
            // 
            // txtSDT
            // 
            this.txtSDT.Location = new System.Drawing.Point(135, 145);
            this.txtSDT.Name = "txtSDT";
            this.txtSDT.Size = new System.Drawing.Size(185, 23);
            this.txtSDT.TabIndex = 20;
            // 
            // btnXoa
            // 
            this.btnXoa.Location = new System.Drawing.Point(115, 219);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(100, 52);
            this.btnXoa.TabIndex = 21;
            this.btnXoa.Text = "Xóa";
            this.btnXoa.UseVisualStyleBackColor = true;
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // btnSua
            // 
            this.btnSua.Location = new System.Drawing.Point(220, 219);
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(100, 52);
            this.btnSua.TabIndex = 22;
            this.btnSua.Text = "Sửa";
            this.btnSua.UseVisualStyleBackColor = true;
            this.btnSua.Click += new System.EventHandler(this.btnSua_Click);
            // 
            // grbThongTinNV
            // 
            this.grbThongTinNV.Controls.Add(this.grbNV);
            this.grbThongTinNV.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grbThongTinNV.Font = new System.Drawing.Font("Cascadia Code SemiBold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grbThongTinNV.Location = new System.Drawing.Point(545, 3);
            this.grbThongTinNV.Name = "grbThongTinNV";
            this.grbThongTinNV.Size = new System.Drawing.Size(537, 623);
            this.grbThongTinNV.TabIndex = 0;
            this.grbThongTinNV.TabStop = false;
            this.grbThongTinNV.Text = "Thông tin nhân viên";
            // 
            // FormQuanLyNhanVien
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1085, 629);
            this.Controls.Add(this.tblQuanLyNhanVien);
            this.Name = "FormQuanLyNhanVien";
            this.Text = "FormQuanLyNhanVien";
            this.Load += new System.EventHandler(this.FormQuanLyNhanVien_Load);
            this.tblQuanLyNhanVien.ResumeLayout(false);
            this.grbNV.ResumeLayout(false);
            this.grbNV.PerformLayout();
            this.grbThongTinNV.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tblQuanLyNhanVien;
        private System.Windows.Forms.TreeView tvDSNV;
        private System.Windows.Forms.GroupBox grbThongTinNV;
        private System.Windows.Forms.GroupBox grbNV;
        private System.Windows.Forms.Button btnSua;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.TextBox txtSDT;
        private System.Windows.Forms.TextBox txtMatKhau;
        private System.Windows.Forms.TextBox txtHoTen;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.TextBox txtTenDangNhap;
        private System.Windows.Forms.ComboBox cbChucVu;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label7;
    }
}