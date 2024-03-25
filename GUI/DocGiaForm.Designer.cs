﻿namespace GUI
{
    partial class DocGiaForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DocGiaForm));
            this.label10 = new System.Windows.Forms.Label();
            this.btn_clean = new System.Windows.Forms.Button();
            this.btn_xoa = new System.Windows.Forms.Button();
            this.btn_capnhat = new System.Windows.Forms.Button();
            this.btn_them = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.tb_madg = new System.Windows.Forms.TextBox();
            this.dtp_ngaysinh = new System.Windows.Forms.DateTimePicker();
            this.label4 = new System.Windows.Forms.Label();
            this.tb_sdt = new System.Windows.Forms.TextBox();
            this.tb_tendg = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.rad_nam = new System.Windows.Forms.RadioButton();
            this.tb_diachi = new System.Windows.Forms.TextBox();
            this.rad_nu = new System.Windows.Forms.RadioButton();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.cbb_boloc = new System.Windows.Forms.ComboBox();
            this.tb_timkiem = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.dgv_doc_gia = new System.Windows.Forms.DataGridView();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_doc_gia)).BeginInit();
            this.SuspendLayout();
            // 
            // label10
            // 
            this.label10.Font = new System.Drawing.Font("JetBrains Mono", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Image = ((System.Drawing.Image)(resources.GetObject("label10.Image")));
            this.label10.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label10.Location = new System.Drawing.Point(663, 141);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(476, 22);
            this.label10.TabIndex = 31;
            this.label10.Text = "Lưu ý: Bạn hãy chọn bộ lọc trước khi tìm kiếm nhé!\r\n";
            this.label10.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // btn_clean
            // 
            this.btn_clean.Location = new System.Drawing.Point(1044, 327);
            this.btn_clean.Name = "btn_clean";
            this.btn_clean.Size = new System.Drawing.Size(94, 33);
            this.btn_clean.TabIndex = 29;
            this.btn_clean.Text = "Làm mới";
            this.btn_clean.UseVisualStyleBackColor = true;
            this.btn_clean.Click += new System.EventHandler(this.btn_clean_Click);
            // 
            // btn_xoa
            // 
            this.btn_xoa.Location = new System.Drawing.Point(924, 327);
            this.btn_xoa.Name = "btn_xoa";
            this.btn_xoa.Size = new System.Drawing.Size(88, 33);
            this.btn_xoa.TabIndex = 28;
            this.btn_xoa.Text = "Xóa";
            this.btn_xoa.UseVisualStyleBackColor = true;
            this.btn_xoa.Click += new System.EventHandler(this.btn_xoa_Click);
            // 
            // btn_capnhat
            // 
            this.btn_capnhat.Location = new System.Drawing.Point(791, 326);
            this.btn_capnhat.Name = "btn_capnhat";
            this.btn_capnhat.Size = new System.Drawing.Size(100, 33);
            this.btn_capnhat.TabIndex = 27;
            this.btn_capnhat.Text = "Cập nhật";
            this.btn_capnhat.UseVisualStyleBackColor = true;
            this.btn_capnhat.Click += new System.EventHandler(this.btn_capnhat_Click);
            // 
            // btn_them
            // 
            this.btn_them.Location = new System.Drawing.Point(668, 326);
            this.btn_them.Name = "btn_them";
            this.btn_them.Size = new System.Drawing.Size(88, 33);
            this.btn_them.TabIndex = 26;
            this.btn_them.Text = "Thêm";
            this.btn_them.UseVisualStyleBackColor = true;
            this.btn_them.Click += new System.EventHandler(this.btn_them_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.tb_madg);
            this.groupBox1.Controls.Add(this.dtp_ngaysinh);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.tb_sdt);
            this.groupBox1.Controls.Add(this.tb_tendg);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.rad_nam);
            this.groupBox1.Controls.Add(this.tb_diachi);
            this.groupBox1.Controls.Add(this.rad_nu);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Font = new System.Drawing.Font("JetBrains Mono", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(13, 5);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(637, 407);
            this.groupBox1.TabIndex = 30;
            this.groupBox1.TabStop = false;
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(81, 49);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(110, 22);
            this.label3.TabIndex = 6;
            this.label3.Text = "Mã độc giả";
            // 
            // label8
            // 
            this.label8.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(81, 151);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(100, 22);
            this.label8.TabIndex = 18;
            this.label8.Text = "Ngày sinh";
            // 
            // tb_madg
            // 
            this.tb_madg.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.tb_madg.Location = new System.Drawing.Point(213, 44);
            this.tb_madg.Name = "tb_madg";
            this.tb_madg.Size = new System.Drawing.Size(326, 30);
            this.tb_madg.TabIndex = 1;
            // 
            // dtp_ngaysinh
            // 
            this.dtp_ngaysinh.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.dtp_ngaysinh.CustomFormat = "dd/MM/yyyy";
            this.dtp_ngaysinh.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtp_ngaysinh.Location = new System.Drawing.Point(213, 145);
            this.dtp_ngaysinh.Name = "dtp_ngaysinh";
            this.dtp_ngaysinh.Size = new System.Drawing.Size(326, 30);
            this.dtp_ngaysinh.TabIndex = 8;
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(80, 100);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(120, 22);
            this.label4.TabIndex = 8;
            this.label4.Text = "Tên độc giả";
            // 
            // tb_sdt
            // 
            this.tb_sdt.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.tb_sdt.Location = new System.Drawing.Point(213, 296);
            this.tb_sdt.Name = "tb_sdt";
            this.tb_sdt.Size = new System.Drawing.Size(326, 30);
            this.tb_sdt.TabIndex = 6;
            // 
            // tb_tendg
            // 
            this.tb_tendg.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.tb_tendg.Location = new System.Drawing.Point(213, 92);
            this.tb_tendg.Name = "tb_tendg";
            this.tb_tendg.Size = new System.Drawing.Size(326, 30);
            this.tb_tendg.TabIndex = 2;
            // 
            // label7
            // 
            this.label7.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(67, 299);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(140, 22);
            this.label7.TabIndex = 15;
            this.label7.Text = "Số điện thoại";
            // 
            // rad_nam
            // 
            this.rad_nam.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.rad_nam.AutoSize = true;
            this.rad_nam.Location = new System.Drawing.Point(213, 199);
            this.rad_nam.Name = "rad_nam";
            this.rad_nam.Size = new System.Drawing.Size(61, 26);
            this.rad_nam.TabIndex = 3;
            this.rad_nam.TabStop = true;
            this.rad_nam.Text = "Nam";
            this.rad_nam.UseVisualStyleBackColor = true;
            // 
            // tb_diachi
            // 
            this.tb_diachi.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.tb_diachi.Location = new System.Drawing.Point(214, 241);
            this.tb_diachi.Name = "tb_diachi";
            this.tb_diachi.Size = new System.Drawing.Size(326, 30);
            this.tb_diachi.TabIndex = 5;
            // 
            // rad_nu
            // 
            this.rad_nu.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.rad_nu.AutoSize = true;
            this.rad_nu.Location = new System.Drawing.Point(379, 199);
            this.rad_nu.Name = "rad_nu";
            this.rad_nu.Size = new System.Drawing.Size(51, 26);
            this.rad_nu.TabIndex = 4;
            this.rad_nu.TabStop = true;
            this.rad_nu.Text = "Nữ";
            this.rad_nu.UseVisualStyleBackColor = true;
            // 
            // label6
            // 
            this.label6.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(81, 249);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(80, 22);
            this.label6.TabIndex = 13;
            this.label6.Text = "Địa chỉ";
            // 
            // label5
            // 
            this.label5.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(81, 199);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(100, 22);
            this.label5.TabIndex = 12;
            this.label5.Text = "Giới tính";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(711, 94);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(70, 22);
            this.label2.TabIndex = 23;
            this.label2.Text = "Bộ lọc";
            // 
            // cbb_boloc
            // 
            this.cbb_boloc.FormattingEnabled = true;
            this.cbb_boloc.Items.AddRange(new object[] {
            "Mã độc giả",
            "Tên độc giả"});
            this.cbb_boloc.Location = new System.Drawing.Point(806, 91);
            this.cbb_boloc.Name = "cbb_boloc";
            this.cbb_boloc.Size = new System.Drawing.Size(326, 30);
            this.cbb_boloc.TabIndex = 25;
            // 
            // tb_timkiem
            // 
            this.tb_timkiem.Location = new System.Drawing.Point(806, 46);
            this.tb_timkiem.Name = "tb_timkiem";
            this.tb_timkiem.Size = new System.Drawing.Size(326, 30);
            this.tb_timkiem.TabIndex = 24;
            this.tb_timkiem.TextChanged += new System.EventHandler(this.tb_timkiem_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(711, 49);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(90, 22);
            this.label1.TabIndex = 22;
            this.label1.Text = "Tìm kiếm";
            // 
            // dgv_doc_gia
            // 
            this.dgv_doc_gia.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgv_doc_gia.BackgroundColor = System.Drawing.SystemColors.Menu;
            this.dgv_doc_gia.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_doc_gia.Location = new System.Drawing.Point(-8, 411);
            this.dgv_doc_gia.Name = "dgv_doc_gia";
            this.dgv_doc_gia.RowHeadersWidth = 51;
            this.dgv_doc_gia.RowTemplate.Height = 24;
            this.dgv_doc_gia.Size = new System.Drawing.Size(1147, 150);
            this.dgv_doc_gia.TabIndex = 21;
            this.dgv_doc_gia.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_doc_gia_CellClick);
            // 
            // DocGiaForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 22F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1148, 573);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.btn_clean);
            this.Controls.Add(this.btn_xoa);
            this.Controls.Add(this.btn_capnhat);
            this.Controls.Add(this.btn_them);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cbb_boloc);
            this.Controls.Add(this.tb_timkiem);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dgv_doc_gia);
            this.Font = new System.Drawing.Font("JetBrains Mono", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "DocGiaForm";
            this.Text = "Quản lý độc giả";
            this.Load += new System.EventHandler(this.DocGiaForm_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_doc_gia)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Button btn_clean;
        private System.Windows.Forms.Button btn_xoa;
        private System.Windows.Forms.Button btn_capnhat;
        private System.Windows.Forms.Button btn_them;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox tb_madg;
        private System.Windows.Forms.DateTimePicker dtp_ngaysinh;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tb_sdt;
        private System.Windows.Forms.TextBox tb_tendg;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.RadioButton rad_nam;
        private System.Windows.Forms.TextBox tb_diachi;
        private System.Windows.Forms.RadioButton rad_nu;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cbb_boloc;
        private System.Windows.Forms.TextBox tb_timkiem;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dgv_doc_gia;
    }
}