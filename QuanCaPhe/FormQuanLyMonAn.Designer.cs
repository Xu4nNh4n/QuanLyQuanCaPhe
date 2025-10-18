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
            this.listView1 = new System.Windows.Forms.ListView();
            this.maMon = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.tenMon = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.donGia = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.maLoai = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.tenLoai = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.grbTTMon = new System.Windows.Forms.GroupBox();
            this.tblTTMA = new System.Windows.Forms.TableLayoutPanel();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.txtMaMon = new System.Windows.Forms.TextBox();
            this.cbMaLoai = new System.Windows.Forms.ComboBox();
            this.txtTenMon = new System.Windows.Forms.TextBox();
            this.txtDonGia = new System.Windows.Forms.TextBox();
            this.tblQuanLyMonAn.SuspendLayout();
            this.grbTTMon.SuspendLayout();
            this.tblTTMA.SuspendLayout();
            this.SuspendLayout();
            // 
            // tblQuanLyMonAn
            // 
            this.tblQuanLyMonAn.ColumnCount = 2;
            this.tblQuanLyMonAn.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 57.125F));
            this.tblQuanLyMonAn.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 42.875F));
            this.tblQuanLyMonAn.Controls.Add(this.listView1, 0, 0);
            this.tblQuanLyMonAn.Controls.Add(this.grbTTMon, 1, 0);
            this.tblQuanLyMonAn.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tblQuanLyMonAn.Location = new System.Drawing.Point(0, 0);
            this.tblQuanLyMonAn.Name = "tblQuanLyMonAn";
            this.tblQuanLyMonAn.RowCount = 1;
            this.tblQuanLyMonAn.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tblQuanLyMonAn.Size = new System.Drawing.Size(800, 450);
            this.tblQuanLyMonAn.TabIndex = 0;
            // 
            // listView1
            // 
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.maMon,
            this.tenMon,
            this.donGia,
            this.maLoai,
            this.tenLoai});
            this.listView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listView1.HideSelection = false;
            this.listView1.Location = new System.Drawing.Point(3, 3);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(451, 444);
            this.listView1.TabIndex = 0;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            // 
            // maMon
            // 
            this.maMon.Text = "Mã món ";
            // 
            // tenMon
            // 
            this.tenMon.Text = "Tên món";
            // 
            // donGia
            // 
            this.donGia.Text = "Đơn giá";
            // 
            // maLoai
            // 
            this.maLoai.Text = "Mã loại";
            // 
            // tenLoai
            // 
            this.tenLoai.Text = "Tên loại";
            // 
            // grbTTMon
            // 
            this.grbTTMon.Controls.Add(this.tblTTMA);
            this.grbTTMon.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grbTTMon.Location = new System.Drawing.Point(460, 3);
            this.grbTTMon.Name = "grbTTMon";
            this.grbTTMon.Size = new System.Drawing.Size(337, 444);
            this.grbTTMon.TabIndex = 1;
            this.grbTTMon.TabStop = false;
            this.grbTTMon.Text = "Thông tin món ăn";
            // 
            // tblTTMA
            // 
            this.tblTTMA.ColumnCount = 3;
            this.tblTTMA.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tblTTMA.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tblTTMA.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tblTTMA.Controls.Add(this.button1, 0, 4);
            this.tblTTMA.Controls.Add(this.label1, 0, 0);
            this.tblTTMA.Controls.Add(this.label2, 0, 1);
            this.tblTTMA.Controls.Add(this.label3, 0, 2);
            this.tblTTMA.Controls.Add(this.label4, 0, 3);
            this.tblTTMA.Controls.Add(this.button2, 1, 4);
            this.tblTTMA.Controls.Add(this.button3, 2, 4);
            this.tblTTMA.Controls.Add(this.txtMaMon, 1, 0);
            this.tblTTMA.Controls.Add(this.cbMaLoai, 1, 3);
            this.tblTTMA.Controls.Add(this.txtTenMon, 1, 1);
            this.tblTTMA.Controls.Add(this.txtDonGia, 1, 2);
            this.tblTTMA.Dock = System.Windows.Forms.DockStyle.Top;
            this.tblTTMA.Location = new System.Drawing.Point(3, 16);
            this.tblTTMA.Name = "tblTTMA";
            this.tblTTMA.RowCount = 5;
            this.tblTTMA.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tblTTMA.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tblTTMA.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tblTTMA.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tblTTMA.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tblTTMA.Size = new System.Drawing.Size(331, 260);
            this.tblTTMA.TabIndex = 0;
            this.tblTTMA.Paint += new System.Windows.Forms.PaintEventHandler(this.tblTTMA_Paint);
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(3, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(104, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Mã món";
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(3, 71);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(104, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Tên món";
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(3, 123);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(104, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Đơn giá";
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(3, 175);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(104, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Mã loại";
            // 
            // button1
            // 
            this.button1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.button1.Location = new System.Drawing.Point(3, 211);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(104, 45);
            this.button1.TabIndex = 1;
            this.button1.Text = "Thêm";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.button2.Location = new System.Drawing.Point(113, 211);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(104, 45);
            this.button2.TabIndex = 4;
            this.button2.Text = "Xóa";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            this.button3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.button3.Location = new System.Drawing.Point(223, 211);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(105, 45);
            this.button3.TabIndex = 5;
            this.button3.Text = "Sửa";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // txtMaMon
            // 
            this.txtMaMon.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.txtMaMon.Location = new System.Drawing.Point(113, 9);
            this.txtMaMon.Multiline = true;
            this.txtMaMon.Name = "txtMaMon";
            this.txtMaMon.Size = new System.Drawing.Size(104, 33);
            this.txtMaMon.TabIndex = 6;
            // 
            // cbMaLoai
            // 
            this.cbMaLoai.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.cbMaLoai.FormattingEnabled = true;
            this.cbMaLoai.Location = new System.Drawing.Point(113, 171);
            this.cbMaLoai.Name = "cbMaLoai";
            this.cbMaLoai.Size = new System.Drawing.Size(104, 21);
            this.cbMaLoai.TabIndex = 7;
            // 
            // txtTenMon
            // 
            this.txtTenMon.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.txtTenMon.Location = new System.Drawing.Point(113, 61);
            this.txtTenMon.Multiline = true;
            this.txtTenMon.Name = "txtTenMon";
            this.txtTenMon.Size = new System.Drawing.Size(104, 33);
            this.txtTenMon.TabIndex = 8;
            // 
            // txtDonGia
            // 
            this.txtDonGia.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.txtDonGia.Location = new System.Drawing.Point(113, 113);
            this.txtDonGia.Multiline = true;
            this.txtDonGia.Name = "txtDonGia";
            this.txtDonGia.Size = new System.Drawing.Size(104, 33);
            this.txtDonGia.TabIndex = 9;
            // 
            // FormQuanLyMonAn
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tblQuanLyMonAn);
            this.Name = "FormQuanLyMonAn";
            this.Text = "FormQuanLyMonAn";
            this.Load += new System.EventHandler(this.FormQuanLyMonAn_Load);
            this.tblQuanLyMonAn.ResumeLayout(false);
            this.grbTTMon.ResumeLayout(false);
            this.tblTTMA.ResumeLayout(false);
            this.tblTTMA.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tblQuanLyMonAn;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.ColumnHeader maMon;
        private System.Windows.Forms.ColumnHeader tenMon;
        private System.Windows.Forms.ColumnHeader donGia;
        private System.Windows.Forms.ColumnHeader maLoai;
        private System.Windows.Forms.ColumnHeader tenLoai;
        private System.Windows.Forms.GroupBox grbTTMon;
        private System.Windows.Forms.TableLayoutPanel tblTTMA;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.TextBox txtMaMon;
        private System.Windows.Forms.ComboBox cbMaLoai;
        private System.Windows.Forms.TextBox txtTenMon;
        private System.Windows.Forms.TextBox txtDonGia;
    }
}