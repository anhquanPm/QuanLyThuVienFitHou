﻿namespace GUI
{
    partial class ThongTinTaiKhoanForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ThongTinTaiKhoanForm));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.tb_ma_nv = new System.Windows.Forms.TextBox();
            this.tb_ten_nv = new System.Windows.Forms.TextBox();
            this.rad_nam = new System.Windows.Forms.RadioButton();
            this.rad_nu = new System.Windows.Forms.RadioButton();
            this.tb_dia_chi = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.tb_sdt = new System.Windows.Forms.TextBox();
            this.dtp_ngay_sinh = new System.Windows.Forms.DateTimePicker();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btn_cap_nhat = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(100, 75);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(114, 23);
            this.label1.TabIndex = 0;
            this.label1.Text = "Mã nhân viên";
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(100, 134);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(116, 23);
            this.label2.TabIndex = 1;
            this.label2.Text = "Tên nhân viên";
            // 
            // tb_ma_nv
            // 
            this.tb_ma_nv.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.tb_ma_nv.Enabled = false;
            this.tb_ma_nv.Location = new System.Drawing.Point(241, 68);
            this.tb_ma_nv.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tb_ma_nv.Name = "tb_ma_nv";
            this.tb_ma_nv.Size = new System.Drawing.Size(298, 30);
            this.tb_ma_nv.TabIndex = 2;
            // 
            // tb_ten_nv
            // 
            this.tb_ten_nv.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.tb_ten_nv.Location = new System.Drawing.Point(241, 127);
            this.tb_ten_nv.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tb_ten_nv.Name = "tb_ten_nv";
            this.tb_ten_nv.Size = new System.Drawing.Size(298, 30);
            this.tb_ten_nv.TabIndex = 3;
            // 
            // rad_nam
            // 
            this.rad_nam.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.rad_nam.AutoSize = true;
            this.rad_nam.Location = new System.Drawing.Point(241, 191);
            this.rad_nam.Name = "rad_nam";
            this.rad_nam.Size = new System.Drawing.Size(68, 27);
            this.rad_nam.TabIndex = 4;
            this.rad_nam.TabStop = true;
            this.rad_nam.Text = "Nam";
            this.rad_nam.UseVisualStyleBackColor = true;
            // 
            // rad_nu
            // 
            this.rad_nu.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.rad_nu.AutoSize = true;
            this.rad_nu.Location = new System.Drawing.Point(435, 191);
            this.rad_nu.Name = "rad_nu";
            this.rad_nu.Size = new System.Drawing.Size(54, 27);
            this.rad_nu.TabIndex = 5;
            this.rad_nu.TabStop = true;
            this.rad_nu.Text = "Nữ";
            this.rad_nu.UseVisualStyleBackColor = true;
            // 
            // tb_dia_chi
            // 
            this.tb_dia_chi.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.tb_dia_chi.Location = new System.Drawing.Point(241, 238);
            this.tb_dia_chi.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tb_dia_chi.Name = "tb_dia_chi";
            this.tb_dia_chi.Size = new System.Drawing.Size(298, 30);
            this.tb_dia_chi.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(100, 245);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(62, 23);
            this.label3.TabIndex = 7;
            this.label3.Text = "Địa chỉ";
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(100, 307);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(111, 23);
            this.label4.TabIndex = 8;
            this.label4.Text = "Số điện thoại";
            // 
            // tb_sdt
            // 
            this.tb_sdt.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.tb_sdt.Location = new System.Drawing.Point(241, 300);
            this.tb_sdt.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tb_sdt.Name = "tb_sdt";
            this.tb_sdt.Size = new System.Drawing.Size(298, 30);
            this.tb_sdt.TabIndex = 9;
            // 
            // dtp_ngay_sinh
            // 
            this.dtp_ngay_sinh.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.dtp_ngay_sinh.CustomFormat = "dd/MM/yyyy";
            this.dtp_ngay_sinh.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtp_ngay_sinh.Location = new System.Drawing.Point(241, 365);
            this.dtp_ngay_sinh.Name = "dtp_ngay_sinh";
            this.dtp_ngay_sinh.Size = new System.Drawing.Size(298, 30);
            this.dtp_ngay_sinh.TabIndex = 10;
            // 
            // label5
            // 
            this.label5.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(100, 195);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(75, 23);
            this.label5.TabIndex = 11;
            this.label5.Text = "Giới tính";
            // 
            // label6
            // 
            this.label6.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(100, 371);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(86, 23);
            this.label6.TabIndex = 12;
            this.label6.Text = "Ngày sinh";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btn_cap_nhat);
            this.groupBox1.Controls.Add(this.tb_ma_nv);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.dtp_ngay_sinh);
            this.groupBox1.Controls.Add(this.tb_ten_nv);
            this.groupBox1.Controls.Add(this.tb_sdt);
            this.groupBox1.Controls.Add(this.rad_nam);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.rad_nu);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.tb_dia_chi);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox1.Location = new System.Drawing.Point(0, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(638, 509);
            this.groupBox1.TabIndex = 13;
            this.groupBox1.TabStop = false;
            // 
            // btn_cap_nhat
            // 
            this.btn_cap_nhat.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btn_cap_nhat.BackColor = System.Drawing.Color.MediumSpringGreen;
            this.btn_cap_nhat.FlatAppearance.BorderSize = 0;
            this.btn_cap_nhat.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_cap_nhat.Image = ((System.Drawing.Image)(resources.GetObject("btn_cap_nhat.Image")));
            this.btn_cap_nhat.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_cap_nhat.Location = new System.Drawing.Point(241, 440);
            this.btn_cap_nhat.Name = "btn_cap_nhat";
            this.btn_cap_nhat.Size = new System.Drawing.Size(206, 41);
            this.btn_cap_nhat.TabIndex = 13;
            this.btn_cap_nhat.Text = "Cập nhật thông tin";
            this.btn_cap_nhat.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_cap_nhat.UseVisualStyleBackColor = false;
            this.btn_cap_nhat.Click += new System.EventHandler(this.btn_cap_nhat_Click);
            // 
            // ThongTinTaiKhoanForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 23F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(638, 509);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "ThongTinTaiKhoanForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Thông tin tài khoản";
            this.Load += new System.EventHandler(this.ThongTinTaiKhoanForm_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tb_ma_nv;
        private System.Windows.Forms.TextBox tb_ten_nv;
        private System.Windows.Forms.RadioButton rad_nam;
        private System.Windows.Forms.RadioButton rad_nu;
        private System.Windows.Forms.TextBox tb_dia_chi;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tb_sdt;
        private System.Windows.Forms.DateTimePicker dtp_ngay_sinh;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btn_cap_nhat;
    }
}