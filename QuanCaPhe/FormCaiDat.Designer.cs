﻿namespace QuanCaPhe
{
    partial class FormCaiDat
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtPasswordHientai = new System.Windows.Forms.TextBox();
            this.txtPasswordNew = new System.Windows.Forms.TextBox();
            this.txtPasswordXN = new System.Windows.Forms.TextBox();
            this.btnDoiMatKhau = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Cascadia Code", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(220, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(167, 46);
            this.label1.TabIndex = 0;
            this.label1.Text = "Cài đặt";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(178, 158);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(88, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "mật khẩu hiện tại";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(178, 232);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(114, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "xác nhận lại mật khẩu";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(178, 202);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(70, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "mật khẩu mới";
            // 
            // txtPasswordHientai
            // 
            this.txtPasswordHientai.Location = new System.Drawing.Point(320, 155);
            this.txtPasswordHientai.Name = "txtPasswordHientai";
            this.txtPasswordHientai.Size = new System.Drawing.Size(100, 20);
            this.txtPasswordHientai.TabIndex = 4;
            // 
            // txtPasswordNew
            // 
            this.txtPasswordNew.Location = new System.Drawing.Point(320, 199);
            this.txtPasswordNew.Name = "txtPasswordNew";
            this.txtPasswordNew.Size = new System.Drawing.Size(100, 20);
            this.txtPasswordNew.TabIndex = 5;
            // 
            // txtPasswordXN
            // 
            this.txtPasswordXN.Location = new System.Drawing.Point(320, 229);
            this.txtPasswordXN.Name = "txtPasswordXN";
            this.txtPasswordXN.Size = new System.Drawing.Size(100, 20);
            this.txtPasswordXN.TabIndex = 6;
            // 
            // btnDoiMatKhau
            // 
            this.btnDoiMatKhau.Location = new System.Drawing.Point(236, 279);
            this.btnDoiMatKhau.Name = "btnDoiMatKhau";
            this.btnDoiMatKhau.Size = new System.Drawing.Size(137, 23);
            this.btnDoiMatKhau.TabIndex = 7;
            this.btnDoiMatKhau.Text = "Đổi mật khẩu";
            this.btnDoiMatKhau.UseVisualStyleBackColor = true;
            // 
            // FormCaiDat
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(632, 376);
            this.Controls.Add(this.btnDoiMatKhau);
            this.Controls.Add(this.txtPasswordXN);
            this.Controls.Add(this.txtPasswordNew);
            this.Controls.Add(this.txtPasswordHientai);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "FormCaiDat";
            this.Text = "FormCaiDat";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtPasswordHientai;
        private System.Windows.Forms.TextBox txtPasswordNew;
        private System.Windows.Forms.TextBox txtPasswordXN;
        private System.Windows.Forms.Button btnDoiMatKhau;
    }
}