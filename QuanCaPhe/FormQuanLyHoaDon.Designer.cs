namespace QuanCaPhe
{
    partial class FormQuanLyHoaDon
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
            this.lstHoaDon = new System.Windows.Forms.ListView();
            this.colmaHD = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colngayLap = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.coltenNV = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.coltenBan = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colTongtien = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.lstChiTietHD = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnTimKiem = new System.Windows.Forms.Button();
            this.txtTimKiem = new System.Windows.Forms.TextBox();
            this.grbTTHoaDon = new System.Windows.Forms.GroupBox();
            this.grbTong = new System.Windows.Forms.GroupBox();
            this.btnTong = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.tableLayoutPanel1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.grbTTHoaDon.SuspendLayout();
            this.grbTong.SuspendLayout();
            this.SuspendLayout();
            // 
            // lstHoaDon
            // 
            this.lstHoaDon.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.colmaHD,
            this.colngayLap,
            this.coltenNV,
            this.coltenBan,
            this.colTongtien});
            this.lstHoaDon.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lstHoaDon.FullRowSelect = true;
            this.lstHoaDon.HideSelection = false;
            this.lstHoaDon.Location = new System.Drawing.Point(3, 3);
            this.lstHoaDon.Name = "lstHoaDon";
            this.lstHoaDon.Size = new System.Drawing.Size(567, 297);
            this.lstHoaDon.TabIndex = 2;
            this.lstHoaDon.UseCompatibleStateImageBehavior = false;
            this.lstHoaDon.View = System.Windows.Forms.View.Details;
            this.lstHoaDon.Click += new System.EventHandler(this.lstHoaDon_Click);
            this.lstHoaDon.Resize += new System.EventHandler(this.lstHoaDon_Resize);
            // 
            // colmaHD
            // 
            this.colmaHD.Text = "Mã hóa đơn";
            // 
            // colngayLap
            // 
            this.colngayLap.Text = "Ngày lập";
            // 
            // coltenNV
            // 
            this.coltenNV.Text = "Tên nhân viên";
            this.coltenNV.Width = 91;
            // 
            // coltenBan
            // 
            this.coltenBan.Text = "Tên bàn";
            // 
            // colTongtien
            // 
            this.colTongtien.Text = "Tổng tiền";
            // 
            // lstChiTietHD
            // 
            this.lstChiTietHD.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4,
            this.columnHeader5});
            this.lstChiTietHD.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lstChiTietHD.FullRowSelect = true;
            this.lstChiTietHD.HideSelection = false;
            this.lstChiTietHD.Location = new System.Drawing.Point(3, 306);
            this.lstChiTietHD.Name = "lstChiTietHD";
            this.lstChiTietHD.Size = new System.Drawing.Size(567, 298);
            this.lstChiTietHD.TabIndex = 3;
            this.lstChiTietHD.UseCompatibleStateImageBehavior = false;
            this.lstChiTietHD.View = System.Windows.Forms.View.Details;
            this.lstChiTietHD.Resize += new System.EventHandler(this.lstHoaDon_Resize);
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Mã món";
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Tên món";
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Số lượng";
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Đơn giá";
            // 
            // columnHeader5
            // 
            this.columnHeader5.Text = "Thành tiền";
            this.columnHeader5.Width = 77;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.lstChiTietHD, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.lstHoaDon, 0, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(3, 19);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(573, 607);
            this.tableLayoutPanel1.TabIndex = 4;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.tableLayoutPanel1);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Left;
            this.groupBox1.Font = new System.Drawing.Font("Cascadia Code SemiBold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(0, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(579, 629);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Các bảng thông tin ";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 51);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(136, 17);
            this.label1.TabIndex = 4;
            this.label1.Text = "Tìm kiếm hóa đơn";
            // 
            // btnTimKiem
            // 
            this.btnTimKiem.Location = new System.Drawing.Point(393, 42);
            this.btnTimKiem.Name = "btnTimKiem";
            this.btnTimKiem.Size = new System.Drawing.Size(101, 34);
            this.btnTimKiem.TabIndex = 5;
            this.btnTimKiem.Text = "Tìm kiếm";
            this.btnTimKiem.UseVisualStyleBackColor = true;
            this.btnTimKiem.Click += new System.EventHandler(this.btnTimKiem_Click);
            // 
            // txtTimKiem
            // 
            this.txtTimKiem.Location = new System.Drawing.Point(148, 42);
            this.txtTimKiem.Multiline = true;
            this.txtTimKiem.Name = "txtTimKiem";
            this.txtTimKiem.Size = new System.Drawing.Size(239, 34);
            this.txtTimKiem.TabIndex = 6;
            // 
            // grbTTHoaDon
            // 
            this.grbTTHoaDon.Controls.Add(this.btnTimKiem);
            this.grbTTHoaDon.Controls.Add(this.txtTimKiem);
            this.grbTTHoaDon.Controls.Add(this.label1);
            this.grbTTHoaDon.Dock = System.Windows.Forms.DockStyle.Top;
            this.grbTTHoaDon.Font = new System.Drawing.Font("Cascadia Code SemiBold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grbTTHoaDon.Location = new System.Drawing.Point(579, 0);
            this.grbTTHoaDon.Name = "grbTTHoaDon";
            this.grbTTHoaDon.Size = new System.Drawing.Size(506, 100);
            this.grbTTHoaDon.TabIndex = 7;
            this.grbTTHoaDon.TabStop = false;
            this.grbTTHoaDon.Text = "Tìm kiếm";
            // 
            // grbTong
            // 
            this.grbTong.Controls.Add(this.btnTong);
            this.grbTong.Controls.Add(this.label5);
            this.grbTong.Controls.Add(this.textBox4);
            this.grbTong.Controls.Add(this.textBox3);
            this.grbTong.Controls.Add(this.textBox2);
            this.grbTong.Controls.Add(this.textBox1);
            this.grbTong.Controls.Add(this.label4);
            this.grbTong.Controls.Add(this.label3);
            this.grbTong.Controls.Add(this.label2);
            this.grbTong.Font = new System.Drawing.Font("Cascadia Code SemiBold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grbTong.Location = new System.Drawing.Point(579, 106);
            this.grbTong.Name = "grbTong";
            this.grbTong.Size = new System.Drawing.Size(506, 523);
            this.grbTong.TabIndex = 8;
            this.grbTong.TabStop = false;
            this.grbTong.Text = "Tổng";
            // 
            // btnTong
            // 
            this.btnTong.Location = new System.Drawing.Point(393, 39);
            this.btnTong.Name = "btnTong";
            this.btnTong.Size = new System.Drawing.Size(101, 226);
            this.btnTong.TabIndex = 12;
            this.btnTong.Text = "Tổng";
            this.btnTong.UseVisualStyleBackColor = true;
            this.btnTong.Click += new System.EventHandler(this.btnTong_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 242);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(49, 16);
            this.label5.TabIndex = 11;
            this.label5.Text = "label5";
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(207, 231);
            this.textBox4.Multiline = true;
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(180, 34);
            this.textBox4.TabIndex = 10;
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(207, 162);
            this.textBox3.Multiline = true;
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(180, 34);
            this.textBox3.TabIndex = 9;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(207, 98);
            this.textBox2.Multiline = true;
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(180, 34);
            this.textBox2.TabIndex = 8;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(207, 39);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(180, 34);
            this.textBox1.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 173);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(49, 16);
            this.label4.TabIndex = 3;
            this.label4.Text = "label4";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 109);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(49, 16);
            this.label3.TabIndex = 2;
            this.label3.Text = "label3";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 50);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(49, 16);
            this.label2.TabIndex = 0;
            this.label2.Text = "label2";
            // 
            // FormQuanLyHoaDon
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1085, 629);
            this.Controls.Add(this.grbTong);
            this.Controls.Add(this.grbTTHoaDon);
            this.Controls.Add(this.groupBox1);
            this.Name = "FormQuanLyHoaDon";
            this.Text = "FormQuanLyHoaDon";
            this.Load += new System.EventHandler(this.FormQuanLyHoaDon_Load);
            this.Resize += new System.EventHandler(this.lstHoaDon_Resize);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.grbTTHoaDon.ResumeLayout(false);
            this.grbTTHoaDon.PerformLayout();
            this.grbTong.ResumeLayout(false);
            this.grbTong.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListView lstHoaDon;
        private System.Windows.Forms.ListView lstChiTietHD;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.ColumnHeader columnHeader5;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ColumnHeader colmaHD;
        private System.Windows.Forms.ColumnHeader colngayLap;
        private System.Windows.Forms.ColumnHeader coltenNV;
        private System.Windows.Forms.ColumnHeader coltenBan;
        private System.Windows.Forms.ColumnHeader colTongtien;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnTimKiem;
        private System.Windows.Forms.TextBox txtTimKiem;
        private System.Windows.Forms.GroupBox grbTTHoaDon;
        private System.Windows.Forms.GroupBox grbTong;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnTong;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox textBox2;
    }
}