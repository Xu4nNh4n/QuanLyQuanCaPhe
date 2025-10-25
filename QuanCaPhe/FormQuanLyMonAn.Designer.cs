namespace QuanCaPhe
{
    partial class FormQuanLyMonAn
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
            this.tblQuanLyMonAn = new System.Windows.Forms.TableLayoutPanel();
            this.lstTTMonAn = new System.Windows.Forms.ListView();
            this.maMon = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.tenMon = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.donGia = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.tenLoai = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.grbTTMon = new System.Windows.Forms.GroupBox();
            this.grbTimKiem = new System.Windows.Forms.GroupBox();
            this.lstDSTimKiem = new System.Windows.Forms.ListView();
            this.colmaMon = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colTenMon = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colDonGia = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.label1 = new System.Windows.Forms.Label();
            this.btnTimKiem = new System.Windows.Forms.Button();
            this.txtTenMonCanTim = new System.Windows.Forms.TextBox();
            this.grbTTloaimon = new System.Windows.Forms.GroupBox();
            this.lstTTLoaiMon = new System.Windows.Forms.ListView();
            this.colMaloai = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colTenloai = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.btnXoa = new System.Windows.Forms.Button();
            this.btnThem = new System.Windows.Forms.Button();
            this.btnSua = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.txtDonGia = new System.Windows.Forms.TextBox();
            this.txtTenMon = new System.Windows.Forms.TextBox();
            this.cbMaLoai = new System.Windows.Forms.ComboBox();
            this.grbLoaiMon = new System.Windows.Forms.GroupBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtTenLoaiMon = new System.Windows.Forms.TextBox();
            this.btnThemLoaiMon = new System.Windows.Forms.Button();
            this.labThongBao = new System.Windows.Forms.Label();
            this.btnXoaLoaiMon = new System.Windows.Forms.Button();
            this.btnSuaLoaiMon = new System.Windows.Forms.Button();
            this.tblQuanLyMonAn.SuspendLayout();
            this.grbTTMon.SuspendLayout();
            this.grbTimKiem.SuspendLayout();
            this.grbTTloaimon.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.grbLoaiMon.SuspendLayout();
            this.SuspendLayout();
            // 
            // tblQuanLyMonAn
            // 
            this.tblQuanLyMonAn.ColumnCount = 2;
            this.tblQuanLyMonAn.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 57.125F));
            this.tblQuanLyMonAn.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 42.875F));
            this.tblQuanLyMonAn.Controls.Add(this.lstTTMonAn, 0, 0);
            this.tblQuanLyMonAn.Controls.Add(this.grbTTMon, 1, 0);
            this.tblQuanLyMonAn.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tblQuanLyMonAn.Location = new System.Drawing.Point(0, 0);
            this.tblQuanLyMonAn.Name = "tblQuanLyMonAn";
            this.tblQuanLyMonAn.RowCount = 1;
            this.tblQuanLyMonAn.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tblQuanLyMonAn.Size = new System.Drawing.Size(1085, 629);
            this.tblQuanLyMonAn.TabIndex = 0;
            // 
            // lstTTMonAn
            // 
            this.lstTTMonAn.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.maMon,
            this.tenMon,
            this.donGia,
            this.tenLoai});
            this.lstTTMonAn.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lstTTMonAn.FullRowSelect = true;
            this.lstTTMonAn.HideSelection = false;
            this.lstTTMonAn.Location = new System.Drawing.Point(3, 3);
            this.lstTTMonAn.Name = "lstTTMonAn";
            this.lstTTMonAn.Size = new System.Drawing.Size(613, 623);
            this.lstTTMonAn.TabIndex = 0;
            this.lstTTMonAn.UseCompatibleStateImageBehavior = false;
            this.lstTTMonAn.View = System.Windows.Forms.View.Details;
            this.lstTTMonAn.SelectedIndexChanged += new System.EventHandler(this.lstTTMonAn_SelectedIndexChanged);
            this.lstTTMonAn.Click += new System.EventHandler(this.lstTTMonAn_Click);
            // 
            // maMon
            // 
            this.maMon.Text = "Mã món ";
            this.maMon.Width = 107;
            // 
            // tenMon
            // 
            this.tenMon.Text = "Tên món";
            this.tenMon.Width = 175;
            // 
            // donGia
            // 
            this.donGia.Text = "Đơn giá";
            this.donGia.Width = 181;
            // 
            // tenLoai
            // 
            this.tenLoai.Text = "Tên loại";
            this.tenLoai.Width = 155;
            // 
            // grbTTMon
            // 
            this.grbTTMon.Controls.Add(this.grbLoaiMon);
            this.grbTTMon.Controls.Add(this.grbTimKiem);
            this.grbTTMon.Controls.Add(this.grbTTloaimon);
            this.grbTTMon.Controls.Add(this.groupBox1);
            this.grbTTMon.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grbTTMon.Font = new System.Drawing.Font("Cascadia Code SemiBold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grbTTMon.Location = new System.Drawing.Point(622, 3);
            this.grbTTMon.Name = "grbTTMon";
            this.grbTTMon.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.grbTTMon.Size = new System.Drawing.Size(460, 623);
            this.grbTTMon.TabIndex = 1;
            this.grbTTMon.TabStop = false;
            // 
            // grbTimKiem
            // 
            this.grbTimKiem.Controls.Add(this.lstDSTimKiem);
            this.grbTimKiem.Controls.Add(this.label1);
            this.grbTimKiem.Controls.Add(this.btnTimKiem);
            this.grbTimKiem.Controls.Add(this.txtTenMonCanTim);
            this.grbTimKiem.Location = new System.Drawing.Point(222, 215);
            this.grbTimKiem.Name = "grbTimKiem";
            this.grbTimKiem.Size = new System.Drawing.Size(226, 231);
            this.grbTimKiem.TabIndex = 12;
            this.grbTimKiem.TabStop = false;
            this.grbTimKiem.Text = "Tìm kiếm";
            // 
            // lstDSTimKiem
            // 
            this.lstDSTimKiem.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.colmaMon,
            this.colTenMon,
            this.colDonGia});
            this.lstDSTimKiem.HideSelection = false;
            this.lstDSTimKiem.Location = new System.Drawing.Point(6, 88);
            this.lstDSTimKiem.Name = "lstDSTimKiem";
            this.lstDSTimKiem.Size = new System.Drawing.Size(214, 137);
            this.lstDSTimKiem.TabIndex = 11;
            this.lstDSTimKiem.UseCompatibleStateImageBehavior = false;
            this.lstDSTimKiem.View = System.Windows.Forms.View.Details;
            // 
            // colmaMon
            // 
            this.colmaMon.Text = "Mã món";
            this.colmaMon.Width = 54;
            // 
            // colTenMon
            // 
            this.colTenMon.Text = "Tên món";
            this.colTenMon.Width = 70;
            // 
            // colDonGia
            // 
            this.colDonGia.Text = "Dơn giá";
            this.colDonGia.Width = 71;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(64, 17);
            this.label1.TabIndex = 15;
            this.label1.Text = "Tên món";
            // 
            // btnTimKiem
            // 
            this.btnTimKiem.Location = new System.Drawing.Point(6, 59);
            this.btnTimKiem.Name = "btnTimKiem";
            this.btnTimKiem.Size = new System.Drawing.Size(214, 23);
            this.btnTimKiem.TabIndex = 14;
            this.btnTimKiem.Text = "Tìm kiếm";
            this.btnTimKiem.UseVisualStyleBackColor = true;
            this.btnTimKiem.Click += new System.EventHandler(this.btnTimKiem_Click);
            // 
            // txtTenMonCanTim
            // 
            this.txtTenMonCanTim.Location = new System.Drawing.Point(76, 30);
            this.txtTenMonCanTim.Name = "txtTenMonCanTim";
            this.txtTenMonCanTim.Size = new System.Drawing.Size(144, 23);
            this.txtTenMonCanTim.TabIndex = 13;
            // 
            // grbTTloaimon
            // 
            this.grbTTloaimon.Controls.Add(this.lstTTLoaiMon);
            this.grbTTloaimon.Location = new System.Drawing.Point(6, 215);
            this.grbTTloaimon.Name = "grbTTloaimon";
            this.grbTTloaimon.Size = new System.Drawing.Size(210, 399);
            this.grbTTloaimon.TabIndex = 11;
            this.grbTTloaimon.TabStop = false;
            this.grbTTloaimon.Text = "Thông tin Loại món";
            // 
            // lstTTLoaiMon
            // 
            this.lstTTLoaiMon.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.colMaloai,
            this.colTenloai});
            this.lstTTLoaiMon.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lstTTLoaiMon.FullRowSelect = true;
            this.lstTTLoaiMon.HideSelection = false;
            this.lstTTLoaiMon.Location = new System.Drawing.Point(3, 19);
            this.lstTTLoaiMon.Name = "lstTTLoaiMon";
            this.lstTTLoaiMon.Size = new System.Drawing.Size(204, 377);
            this.lstTTLoaiMon.TabIndex = 10;
            this.lstTTLoaiMon.UseCompatibleStateImageBehavior = false;
            this.lstTTLoaiMon.View = System.Windows.Forms.View.Details;
            this.lstTTLoaiMon.Click += new System.EventHandler(this.lstTTLoaiMon_Click);
            // 
            // colMaloai
            // 
            this.colMaloai.Text = "Mã loại";
            this.colMaloai.Width = 89;
            // 
            // colTenloai
            // 
            this.colTenloai.Text = "Tên loại";
            this.colTenloai.Width = 106;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.btnXoa);
            this.groupBox1.Controls.Add(this.btnThem);
            this.groupBox1.Controls.Add(this.btnSua);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.txtDonGia);
            this.groupBox1.Controls.Add(this.txtTenMon);
            this.groupBox1.Controls.Add(this.cbMaLoai);
            this.groupBox1.Location = new System.Drawing.Point(6, 22);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(448, 187);
            this.groupBox1.TabIndex = 10;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Thêm đồ ăn";
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(15, 65);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(64, 17);
            this.label3.TabIndex = 2;
            this.label3.Text = "Đơn giá";
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(15, 95);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(64, 17);
            this.label4.TabIndex = 3;
            this.label4.Text = "Mã loại";
            // 
            // btnXoa
            // 
            this.btnXoa.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.btnXoa.Location = new System.Drawing.Point(157, 123);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(133, 45);
            this.btnXoa.TabIndex = 4;
            this.btnXoa.Text = "Xóa";
            this.btnXoa.UseVisualStyleBackColor = true;
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // btnThem
            // 
            this.btnThem.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.btnThem.Location = new System.Drawing.Point(6, 123);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(145, 45);
            this.btnThem.TabIndex = 1;
            this.btnThem.Text = "Thêm";
            this.btnThem.UseVisualStyleBackColor = true;
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // btnSua
            // 
            this.btnSua.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSua.Location = new System.Drawing.Point(296, 123);
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(146, 45);
            this.btnSua.TabIndex = 5;
            this.btnSua.Text = "Sửa";
            this.btnSua.UseVisualStyleBackColor = true;
            this.btnSua.Click += new System.EventHandler(this.btnSua_Click);
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(15, 34);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(64, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "Tên món";
            // 
            // txtDonGia
            // 
            this.txtDonGia.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.txtDonGia.Location = new System.Drawing.Point(133, 62);
            this.txtDonGia.Multiline = true;
            this.txtDonGia.Name = "txtDonGia";
            this.txtDonGia.Size = new System.Drawing.Size(309, 24);
            this.txtDonGia.TabIndex = 8;
            // 
            // txtTenMon
            // 
            this.txtTenMon.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.txtTenMon.Location = new System.Drawing.Point(133, 31);
            this.txtTenMon.Multiline = true;
            this.txtTenMon.Name = "txtTenMon";
            this.txtTenMon.Size = new System.Drawing.Size(309, 25);
            this.txtTenMon.TabIndex = 9;
            // 
            // cbMaLoai
            // 
            this.cbMaLoai.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.cbMaLoai.FormattingEnabled = true;
            this.cbMaLoai.Location = new System.Drawing.Point(133, 92);
            this.cbMaLoai.Name = "cbMaLoai";
            this.cbMaLoai.Size = new System.Drawing.Size(309, 25);
            this.cbMaLoai.TabIndex = 7;
            // 
            // grbLoaiMon
            // 
            this.grbLoaiMon.Controls.Add(this.btnSuaLoaiMon);
            this.grbLoaiMon.Controls.Add(this.btnXoaLoaiMon);
            this.grbLoaiMon.Controls.Add(this.labThongBao);
            this.grbLoaiMon.Controls.Add(this.btnThemLoaiMon);
            this.grbLoaiMon.Controls.Add(this.txtTenLoaiMon);
            this.grbLoaiMon.Controls.Add(this.label5);
            this.grbLoaiMon.Location = new System.Drawing.Point(222, 452);
            this.grbLoaiMon.Name = "grbLoaiMon";
            this.grbLoaiMon.Size = new System.Drawing.Size(226, 134);
            this.grbLoaiMon.TabIndex = 11;
            this.grbLoaiMon.TabStop = false;
            this.grbLoaiMon.Text = "Thêm loại món";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 29);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(104, 17);
            this.label5.TabIndex = 16;
            this.label5.Text = "Tên loại món";
            // 
            // txtTenLoaiMon
            // 
            this.txtTenLoaiMon.Location = new System.Drawing.Point(116, 26);
            this.txtTenLoaiMon.Name = "txtTenLoaiMon";
            this.txtTenLoaiMon.Size = new System.Drawing.Size(104, 23);
            this.txtTenLoaiMon.TabIndex = 16;
            // 
            // btnThemLoaiMon
            // 
            this.btnThemLoaiMon.Location = new System.Drawing.Point(6, 55);
            this.btnThemLoaiMon.Name = "btnThemLoaiMon";
            this.btnThemLoaiMon.Size = new System.Drawing.Size(68, 39);
            this.btnThemLoaiMon.TabIndex = 16;
            this.btnThemLoaiMon.Text = "Thêm";
            this.btnThemLoaiMon.UseVisualStyleBackColor = true;
            this.btnThemLoaiMon.Click += new System.EventHandler(this.btnThemLoaiMon_Click);
            // 
            // labThongBao
            // 
            this.labThongBao.Location = new System.Drawing.Point(6, 97);
            this.labThongBao.Name = "labThongBao";
            this.labThongBao.Size = new System.Drawing.Size(211, 24);
            this.labThongBao.TabIndex = 17;
            this.labThongBao.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnXoaLoaiMon
            // 
            this.btnXoaLoaiMon.Location = new System.Drawing.Point(80, 55);
            this.btnXoaLoaiMon.Name = "btnXoaLoaiMon";
            this.btnXoaLoaiMon.Size = new System.Drawing.Size(68, 39);
            this.btnXoaLoaiMon.TabIndex = 18;
            this.btnXoaLoaiMon.Text = "Xóa";
            this.btnXoaLoaiMon.UseVisualStyleBackColor = true;
            this.btnXoaLoaiMon.Click += new System.EventHandler(this.btnXoaLoaiMon_Click);
            // 
            // btnSuaLoaiMon
            // 
            this.btnSuaLoaiMon.Location = new System.Drawing.Point(154, 55);
            this.btnSuaLoaiMon.Name = "btnSuaLoaiMon";
            this.btnSuaLoaiMon.Size = new System.Drawing.Size(68, 39);
            this.btnSuaLoaiMon.TabIndex = 19;
            this.btnSuaLoaiMon.Text = "Sửa";
            this.btnSuaLoaiMon.UseVisualStyleBackColor = true;
            this.btnSuaLoaiMon.Click += new System.EventHandler(this.btnSuaLoaiMon_Click);
            // 
            // FormQuanLyMonAn
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1085, 629);
            this.Controls.Add(this.tblQuanLyMonAn);
            this.Name = "FormQuanLyMonAn";
            this.Text = "FormQuanLyMonAn";
            this.Load += new System.EventHandler(this.FormQuanLyMonAn_Load);
            this.tblQuanLyMonAn.ResumeLayout(false);
            this.grbTTMon.ResumeLayout(false);
            this.grbTimKiem.ResumeLayout(false);
            this.grbTimKiem.PerformLayout();
            this.grbTTloaimon.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.grbLoaiMon.ResumeLayout(false);
            this.grbLoaiMon.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tblQuanLyMonAn;
        private System.Windows.Forms.ListView lstTTMonAn;
        private System.Windows.Forms.ColumnHeader maMon;
        private System.Windows.Forms.ColumnHeader tenMon;
        private System.Windows.Forms.ColumnHeader donGia;
        private System.Windows.Forms.ColumnHeader tenLoai;
        private System.Windows.Forms.GroupBox grbTTMon;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.Button btnSua;
        private System.Windows.Forms.ComboBox cbMaLoai;
        private System.Windows.Forms.TextBox txtDonGia;
        private System.Windows.Forms.TextBox txtTenMon;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox grbTimKiem;
        private System.Windows.Forms.GroupBox grbTTloaimon;
        private System.Windows.Forms.ListView lstTTLoaiMon;
        private System.Windows.Forms.ListView lstDSTimKiem;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnTimKiem;
        private System.Windows.Forms.TextBox txtTenMonCanTim;
        private System.Windows.Forms.ColumnHeader colMaloai;
        private System.Windows.Forms.ColumnHeader colTenloai;
        private System.Windows.Forms.ColumnHeader colmaMon;
        private System.Windows.Forms.ColumnHeader colTenMon;
        private System.Windows.Forms.ColumnHeader colDonGia;
        private System.Windows.Forms.GroupBox grbLoaiMon;
        private System.Windows.Forms.Button btnThemLoaiMon;
        private System.Windows.Forms.TextBox txtTenLoaiMon;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label labThongBao;
        private System.Windows.Forms.Button btnSuaLoaiMon;
        private System.Windows.Forms.Button btnXoaLoaiMon;
    }
}