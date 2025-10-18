namespace QuanCaPhe
{
    partial class FormBanHang
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
            this.pnlMenu = new System.Windows.Forms.Panel();
            this.flpMenu = new System.Windows.Forms.FlowLayoutPanel();
            this.lstvBan = new System.Windows.Forms.ListView();
            this.maBan = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.tenBan = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.trangThai = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.lstvMenu = new System.Windows.Forms.ListView();
            this.STT = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.MaMonAn = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.TenMonAn = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.DonGia = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.LoaiMonAn = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.pnlHoaDon = new System.Windows.Forms.Panel();
            this.grbDatMon = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnXacNhan = new System.Windows.Forms.Button();
            this.txtTenMon = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtDonGia = new System.Windows.Forms.TextBox();
            this.txtSoLuong = new System.Windows.Forms.TextBox();
            this.txtSTT = new System.Windows.Forms.TextBox();
            this.flpHoaDon = new System.Windows.Forms.FlowLayoutPanel();
            this.lstDonHang = new System.Windows.Forms.ListView();
            this.maMon = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.tenMon = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.donGiaa = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.soLuong = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.tongTien = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.grbXacNhan = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnXacNhanDonHang = new System.Windows.Forms.Button();
            this.cbThanhToan = new System.Windows.Forms.ComboBox();
            this.txtTongTien = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.txtThanhTien = new System.Windows.Forms.TextBox();
            this.txtTienNhan = new System.Windows.Forms.TextBox();
            this.txtTienThua = new System.Windows.Forms.TextBox();
            this.btnHuyDon = new System.Windows.Forms.Button();
            this.tblContainer = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.pnlMenu.SuspendLayout();
            this.flpMenu.SuspendLayout();
            this.pnlHoaDon.SuspendLayout();
            this.grbDatMon.SuspendLayout();
            this.flpHoaDon.SuspendLayout();
            this.grbXacNhan.SuspendLayout();
            this.tblContainer.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlMenu
            // 
            this.pnlMenu.Controls.Add(this.flpMenu);
            this.pnlMenu.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlMenu.Location = new System.Drawing.Point(3, 3);
            this.pnlMenu.Name = "pnlMenu";
            this.pnlMenu.Size = new System.Drawing.Size(466, 522);
            this.pnlMenu.TabIndex = 1;
            // 
            // flpMenu
            // 
            this.flpMenu.BackColor = System.Drawing.SystemColors.GrayText;
            this.flpMenu.Controls.Add(this.lstvBan);
            this.flpMenu.Controls.Add(this.lstvMenu);
            this.flpMenu.Controls.Add(this.grbDatMon);
            this.flpMenu.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flpMenu.Location = new System.Drawing.Point(0, 0);
            this.flpMenu.Name = "flpMenu";
            this.flpMenu.Size = new System.Drawing.Size(466, 522);
            this.flpMenu.TabIndex = 0;
            this.flpMenu.Resize += new System.EventHandler(this.flpMenu_Resize);
            // 
            // lstvBan
            // 
            this.lstvBan.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.maBan,
            this.tenBan,
            this.trangThai});
            this.lstvBan.HideSelection = false;
            this.lstvBan.Location = new System.Drawing.Point(3, 3);
            this.lstvBan.Name = "lstvBan";
            this.lstvBan.Size = new System.Drawing.Size(460, 109);
            this.lstvBan.TabIndex = 0;
            this.lstvBan.UseCompatibleStateImageBehavior = false;
            this.lstvBan.View = System.Windows.Forms.View.Details;
            // 
            // maBan
            // 
            this.maBan.Text = "Mã bàn";
            this.maBan.Width = 112;
            // 
            // tenBan
            // 
            this.tenBan.Text = "Tên bàn";
            this.tenBan.Width = 171;
            // 
            // trangThai
            // 
            this.trangThai.Text = "Trạng thái";
            this.trangThai.Width = 160;
            // 
            // lstvMenu
            // 
            this.lstvMenu.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.STT,
            this.MaMonAn,
            this.TenMonAn,
            this.DonGia,
            this.LoaiMonAn});
            this.lstvMenu.HideSelection = false;
            this.lstvMenu.Location = new System.Drawing.Point(3, 118);
            this.lstvMenu.Name = "lstvMenu";
            this.lstvMenu.Size = new System.Drawing.Size(460, 235);
            this.lstvMenu.TabIndex = 0;
            this.lstvMenu.UseCompatibleStateImageBehavior = false;
            this.lstvMenu.View = System.Windows.Forms.View.Details;
            // 
            // STT
            // 
            this.STT.Text = "STT";
            this.STT.Width = 45;
            // 
            // MaMonAn
            // 
            this.MaMonAn.Text = "Mã";
            this.MaMonAn.Width = 64;
            // 
            // TenMonAn
            // 
            this.TenMonAn.Text = "Tên";
            this.TenMonAn.Width = 117;
            // 
            // DonGia
            // 
            this.DonGia.Text = "Đơn giá";
            this.DonGia.Width = 105;
            // 
            // LoaiMonAn
            // 
            this.LoaiMonAn.Text = "Loại";
            this.LoaiMonAn.Width = 186;
            // 
            // pnlHoaDon
            // 
            this.pnlHoaDon.Controls.Add(this.flpHoaDon);
            this.pnlHoaDon.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlHoaDon.Location = new System.Drawing.Point(475, 3);
            this.pnlHoaDon.Name = "pnlHoaDon";
            this.pnlHoaDon.Size = new System.Drawing.Size(402, 522);
            this.pnlHoaDon.TabIndex = 2;
            // 
            // grbDatMon
            // 
            this.grbDatMon.Controls.Add(this.tableLayoutPanel1);
            this.grbDatMon.Location = new System.Drawing.Point(3, 359);
            this.grbDatMon.Name = "grbDatMon";
            this.grbDatMon.Size = new System.Drawing.Size(460, 135);
            this.grbDatMon.TabIndex = 1;
            this.grbDatMon.TabStop = false;
            this.grbDatMon.Text = "Đặt món";
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(3, 6);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(49, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Tên món";
            // 
            // btnXacNhan
            // 
            this.btnXacNhan.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnXacNhan.Location = new System.Drawing.Point(58, 55);
            this.btnXacNhan.Name = "btnXacNhan";
            this.btnXacNhan.Size = new System.Drawing.Size(139, 57);
            this.btnXacNhan.TabIndex = 1;
            this.btnXacNhan.Text = "Xác nhận";
            this.btnXacNhan.UseVisualStyleBackColor = true;
            // 
            // txtTenMon
            // 
            this.txtTenMon.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtTenMon.Location = new System.Drawing.Point(58, 3);
            this.txtTenMon.Name = "txtTenMon";
            this.txtTenMon.Size = new System.Drawing.Size(139, 20);
            this.txtTenMon.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(203, 6);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(49, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Đơn giá";
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(3, 32);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(49, 13);
            this.label4.TabIndex = 5;
            this.label4.Text = "STT";
            // 
            // label5
            // 
            this.label5.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(203, 32);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(49, 13);
            this.label5.TabIndex = 6;
            this.label5.Text = "Số lượng";
            // 
            // txtDonGia
            // 
            this.txtDonGia.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtDonGia.Location = new System.Drawing.Point(258, 3);
            this.txtDonGia.Name = "txtDonGia";
            this.txtDonGia.Size = new System.Drawing.Size(193, 20);
            this.txtDonGia.TabIndex = 8;
            // 
            // txtSoLuong
            // 
            this.txtSoLuong.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtSoLuong.Location = new System.Drawing.Point(258, 29);
            this.txtSoLuong.Name = "txtSoLuong";
            this.txtSoLuong.Size = new System.Drawing.Size(193, 20);
            this.txtSoLuong.TabIndex = 9;
            // 
            // txtSTT
            // 
            this.txtSTT.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtSTT.Location = new System.Drawing.Point(58, 29);
            this.txtSTT.Name = "txtSTT";
            this.txtSTT.Size = new System.Drawing.Size(139, 20);
            this.txtSTT.TabIndex = 10;
            // 
            // flpHoaDon
            // 
            this.flpHoaDon.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.flpHoaDon.Controls.Add(this.lstDonHang);
            this.flpHoaDon.Controls.Add(this.grbXacNhan);
            this.flpHoaDon.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flpHoaDon.Location = new System.Drawing.Point(0, 0);
            this.flpHoaDon.Name = "flpHoaDon";
            this.flpHoaDon.Size = new System.Drawing.Size(402, 522);
            this.flpHoaDon.TabIndex = 11;
            this.flpHoaDon.Resize += new System.EventHandler(this.flpHoaDon_Resize);
            // 
            // lstDonHang
            // 
            this.lstDonHang.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.maMon,
            this.tenMon,
            this.donGiaa,
            this.soLuong,
            this.tongTien});
            this.lstDonHang.HideSelection = false;
            this.lstDonHang.Location = new System.Drawing.Point(3, 3);
            this.lstDonHang.Name = "lstDonHang";
            this.lstDonHang.Size = new System.Drawing.Size(399, 176);
            this.lstDonHang.TabIndex = 0;
            this.lstDonHang.UseCompatibleStateImageBehavior = false;
            this.lstDonHang.View = System.Windows.Forms.View.Details;
            // 
            // maMon
            // 
            this.maMon.Text = "Mã món";
            // 
            // tenMon
            // 
            this.tenMon.Text = "Tên món";
            // 
            // donGiaa
            // 
            this.donGiaa.Text = "Đơn giá";
            // 
            // soLuong
            // 
            this.soLuong.Text = "Số lượng";
            // 
            // tongTien
            // 
            this.tongTien.Text = "Tổng tiền";
            // 
            // grbXacNhan
            // 
            this.grbXacNhan.Controls.Add(this.tableLayoutPanel2);
            this.grbXacNhan.Location = new System.Drawing.Point(3, 185);
            this.grbXacNhan.Name = "grbXacNhan";
            this.grbXacNhan.Size = new System.Drawing.Size(390, 297);
            this.grbXacNhan.TabIndex = 11;
            this.grbXacNhan.TabStop = false;
            this.grbXacNhan.Text = "Xác nhận";
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(3, 6);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(174, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "Tổng tiền:";
            // 
            // btnXacNhanDonHang
            // 
            this.btnXacNhanDonHang.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnXacNhanDonHang.Location = new System.Drawing.Point(3, 134);
            this.btnXacNhanDonHang.Name = "btnXacNhanDonHang";
            this.btnXacNhanDonHang.Size = new System.Drawing.Size(174, 48);
            this.btnXacNhanDonHang.TabIndex = 1;
            this.btnXacNhanDonHang.Text = "Xác nhận";
            this.btnXacNhanDonHang.UseVisualStyleBackColor = true;
            // 
            // cbThanhToan
            // 
            this.cbThanhToan.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cbThanhToan.FormattingEnabled = true;
            this.cbThanhToan.Location = new System.Drawing.Point(183, 55);
            this.cbThanhToan.Name = "cbThanhToan";
            this.cbThanhToan.Size = new System.Drawing.Size(198, 21);
            this.cbThanhToan.TabIndex = 2;
            // 
            // txtTongTien
            // 
            this.txtTongTien.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtTongTien.Location = new System.Drawing.Point(183, 3);
            this.txtTongTien.Name = "txtTongTien";
            this.txtTongTien.Size = new System.Drawing.Size(198, 20);
            this.txtTongTien.TabIndex = 3;
            // 
            // label6
            // 
            this.label6.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(3, 32);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(174, 13);
            this.label6.TabIndex = 4;
            this.label6.Text = "Thành tiền";
            // 
            // label7
            // 
            this.label7.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(3, 59);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(174, 13);
            this.label7.TabIndex = 5;
            this.label7.Text = "Hình thức thanh toán";
            // 
            // label8
            // 
            this.label8.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(3, 85);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(174, 13);
            this.label8.TabIndex = 6;
            this.label8.Text = "Tiền nhận";
            // 
            // label9
            // 
            this.label9.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(3, 111);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(174, 13);
            this.label9.TabIndex = 7;
            this.label9.Text = "Tiền thừa";
            // 
            // txtThanhTien
            // 
            this.txtThanhTien.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtThanhTien.Location = new System.Drawing.Point(183, 29);
            this.txtThanhTien.Name = "txtThanhTien";
            this.txtThanhTien.Size = new System.Drawing.Size(198, 20);
            this.txtThanhTien.TabIndex = 8;
            // 
            // txtTienNhan
            // 
            this.txtTienNhan.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtTienNhan.Location = new System.Drawing.Point(183, 82);
            this.txtTienNhan.Name = "txtTienNhan";
            this.txtTienNhan.Size = new System.Drawing.Size(198, 20);
            this.txtTienNhan.TabIndex = 9;
            // 
            // txtTienThua
            // 
            this.txtTienThua.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtTienThua.Location = new System.Drawing.Point(183, 108);
            this.txtTienThua.Name = "txtTienThua";
            this.txtTienThua.Size = new System.Drawing.Size(198, 20);
            this.txtTienThua.TabIndex = 10;
            // 
            // btnHuyDon
            // 
            this.btnHuyDon.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnHuyDon.Location = new System.Drawing.Point(183, 134);
            this.btnHuyDon.Name = "btnHuyDon";
            this.btnHuyDon.Size = new System.Drawing.Size(198, 48);
            this.btnHuyDon.TabIndex = 11;
            this.btnHuyDon.Text = "Hủy đơn";
            this.btnHuyDon.UseVisualStyleBackColor = true;
            // 
            // tblContainer
            // 
            this.tblContainer.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.tblContainer.ColumnCount = 2;
            this.tblContainer.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 53.73832F));
            this.tblContainer.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 46.26168F));
            this.tblContainer.Controls.Add(this.pnlHoaDon, 1, 0);
            this.tblContainer.Controls.Add(this.pnlMenu, 0, 0);
            this.tblContainer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tblContainer.Location = new System.Drawing.Point(0, 0);
            this.tblContainer.Name = "tblContainer";
            this.tblContainer.RowCount = 1;
            this.tblContainer.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tblContainer.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tblContainer.Size = new System.Drawing.Size(880, 528);
            this.tblContainer.TabIndex = 0;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 4;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel1.Controls.Add(this.label1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.label4, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.txtSTT, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.txtTenMon, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.label5, 2, 1);
            this.tableLayoutPanel1.Controls.Add(this.txtSoLuong, 3, 1);
            this.tableLayoutPanel1.Controls.Add(this.label3, 2, 0);
            this.tableLayoutPanel1.Controls.Add(this.txtDonGia, 3, 0);
            this.tableLayoutPanel1.Controls.Add(this.btnXacNhan, 1, 2);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(3, 16);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 3;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.Size = new System.Drawing.Size(454, 116);
            this.tableLayoutPanel1.TabIndex = 11;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 2;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel2.Controls.Add(this.label2, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.btnHuyDon, 1, 5);
            this.tableLayoutPanel2.Controls.Add(this.txtTongTien, 1, 0);
            this.tableLayoutPanel2.Controls.Add(this.btnXacNhanDonHang, 0, 5);
            this.tableLayoutPanel2.Controls.Add(this.txtTienThua, 1, 4);
            this.tableLayoutPanel2.Controls.Add(this.label6, 0, 1);
            this.tableLayoutPanel2.Controls.Add(this.txtTienNhan, 1, 3);
            this.tableLayoutPanel2.Controls.Add(this.txtThanhTien, 1, 1);
            this.tableLayoutPanel2.Controls.Add(this.label7, 0, 2);
            this.tableLayoutPanel2.Controls.Add(this.label8, 0, 3);
            this.tableLayoutPanel2.Controls.Add(this.cbThanhToan, 1, 2);
            this.tableLayoutPanel2.Controls.Add(this.label9, 0, 4);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(3, 16);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 6;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel2.Size = new System.Drawing.Size(384, 278);
            this.tableLayoutPanel2.TabIndex = 12;
            // 
            // FormBanHang
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(880, 528);
            this.Controls.Add(this.tblContainer);
            this.Name = "FormBanHang";
            this.Text = "FormBanHang";
            this.Load += new System.EventHandler(this.FormBanHang_Load);
            this.pnlMenu.ResumeLayout(false);
            this.flpMenu.ResumeLayout(false);
            this.pnlHoaDon.ResumeLayout(false);
            this.grbDatMon.ResumeLayout(false);
            this.flpHoaDon.ResumeLayout(false);
            this.grbXacNhan.ResumeLayout(false);
            this.tblContainer.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel pnlMenu;
        private System.Windows.Forms.Panel pnlHoaDon;
        private System.Windows.Forms.FlowLayoutPanel flpMenu;
        private System.Windows.Forms.ListView lstvMenu;
        private System.Windows.Forms.ColumnHeader STT;
        private System.Windows.Forms.ColumnHeader MaMonAn;
        private System.Windows.Forms.ColumnHeader TenMonAn;
        private System.Windows.Forms.ColumnHeader DonGia;
        private System.Windows.Forms.ColumnHeader LoaiMonAn;
        private System.Windows.Forms.ListView lstvBan;
        private System.Windows.Forms.ColumnHeader maBan;
        private System.Windows.Forms.ColumnHeader tenBan;
        private System.Windows.Forms.ColumnHeader trangThai;
        private System.Windows.Forms.GroupBox grbDatMon;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtTenMon;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnXacNhan;
        private System.Windows.Forms.TextBox txtSTT;
        private System.Windows.Forms.TextBox txtSoLuong;
        private System.Windows.Forms.TextBox txtDonGia;
        private System.Windows.Forms.FlowLayoutPanel flpHoaDon;
        private System.Windows.Forms.ListView lstDonHang;
        private System.Windows.Forms.ColumnHeader maMon;
        private System.Windows.Forms.ColumnHeader tenMon;
        private System.Windows.Forms.ColumnHeader donGiaa;
        private System.Windows.Forms.ColumnHeader soLuong;
        private System.Windows.Forms.ColumnHeader tongTien;
        private System.Windows.Forms.GroupBox grbXacNhan;
        private System.Windows.Forms.TextBox txtTongTien;
        private System.Windows.Forms.ComboBox cbThanhToan;
        private System.Windows.Forms.Button btnXacNhanDonHang;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnHuyDon;
        private System.Windows.Forms.TextBox txtTienThua;
        private System.Windows.Forms.TextBox txtTienNhan;
        private System.Windows.Forms.TextBox txtThanhTien;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TableLayoutPanel tblContainer;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
    }
}