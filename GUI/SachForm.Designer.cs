namespace GUI
{
    partial class SachForm
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SachForm));
            this.dgv_sach = new System.Windows.Forms.DataGridView();
            this.label10 = new System.Windows.Forms.Label();
            this.btn_clean = new System.Windows.Forms.Button();
            this.btn_xoa = new System.Windows.Forms.Button();
            this.btn_capnhat = new System.Windows.Forms.Button();
            this.btn_them = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.chk_dongTG = new System.Windows.Forms.CheckBox();
            this.cbb_ma_loai = new System.Windows.Forms.ComboBox();
            this.tHELOAISACHBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.quanLyThuVienDataSet = new GUI.QuanLyThuVienDataSet();
            this.cbb_nha_xb = new System.Windows.Forms.ComboBox();
            this.nHAXUATBANBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.label5 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.tb_gia_tien = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.cbb_ma_tg = new System.Windows.Forms.ComboBox();
            this.tACGIABindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.label3 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.tb_ma_sach = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.dtp_nam_xb = new System.Windows.Forms.DateTimePicker();
            this.tb_ten_sach = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.tb_so_luong = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.cbb_boloc = new System.Windows.Forms.ComboBox();
            this.tb_timkiem = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.tHELOAISACHTableAdapter = new GUI.QuanLyThuVienDataSetTableAdapters.THELOAISACHTableAdapter();
            this.tACGIATableAdapter = new GUI.QuanLyThuVienDataSetTableAdapters.TACGIATableAdapter();
            this.nHAXUATBANTableAdapter = new GUI.QuanLyThuVienDataSetTableAdapters.NHAXUATBANTableAdapter();
            this.btn_in = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_sach)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tHELOAISACHBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.quanLyThuVienDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nHAXUATBANBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tACGIABindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dgv_sach
            // 
            this.dgv_sach.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgv_sach.BackgroundColor = System.Drawing.SystemColors.Menu;
            this.dgv_sach.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_sach.Location = new System.Drawing.Point(-2, 476);
            this.dgv_sach.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.dgv_sach.Name = "dgv_sach";
            this.dgv_sach.RowHeadersWidth = 51;
            this.dgv_sach.RowTemplate.Height = 24;
            this.dgv_sach.Size = new System.Drawing.Size(1147, 152);
            this.dgv_sach.TabIndex = 2;
            this.dgv_sach.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_sach_CellClick);
            // 
            // label10
            // 
            this.label10.Font = new System.Drawing.Font("JetBrains Mono", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Image = ((System.Drawing.Image)(resources.GetObject("label10.Image")));
            this.label10.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label10.Location = new System.Drawing.Point(663, 147);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(476, 22);
            this.label10.TabIndex = 30;
            this.label10.Text = "Lưu ý: Bạn hãy chọn bộ lọc trước khi tìm kiếm nhé!\r\n";
            this.label10.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // btn_clean
            // 
            this.btn_clean.Location = new System.Drawing.Point(1044, 334);
            this.btn_clean.Name = "btn_clean";
            this.btn_clean.Size = new System.Drawing.Size(100, 33);
            this.btn_clean.TabIndex = 6;
            this.btn_clean.Text = "Làm mới";
            this.btn_clean.UseVisualStyleBackColor = true;
            this.btn_clean.Click += new System.EventHandler(this.btn_clean_Click);
            // 
            // btn_xoa
            // 
            this.btn_xoa.Location = new System.Drawing.Point(924, 334);
            this.btn_xoa.Name = "btn_xoa";
            this.btn_xoa.Size = new System.Drawing.Size(88, 33);
            this.btn_xoa.TabIndex = 5;
            this.btn_xoa.Text = "Xóa";
            this.btn_xoa.UseVisualStyleBackColor = true;
            this.btn_xoa.Click += new System.EventHandler(this.btn_xoa_Click);
            // 
            // btn_capnhat
            // 
            this.btn_capnhat.Location = new System.Drawing.Point(791, 334);
            this.btn_capnhat.Name = "btn_capnhat";
            this.btn_capnhat.Size = new System.Drawing.Size(100, 33);
            this.btn_capnhat.TabIndex = 4;
            this.btn_capnhat.Text = "Cập nhật";
            this.btn_capnhat.UseVisualStyleBackColor = true;
            this.btn_capnhat.Click += new System.EventHandler(this.btn_capnhat_Click);
            // 
            // btn_them
            // 
            this.btn_them.Location = new System.Drawing.Point(668, 334);
            this.btn_them.Name = "btn_them";
            this.btn_them.Size = new System.Drawing.Size(88, 33);
            this.btn_them.TabIndex = 3;
            this.btn_them.Text = "Thêm";
            this.btn_them.UseVisualStyleBackColor = true;
            this.btn_them.Click += new System.EventHandler(this.btn_them_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.chk_dongTG);
            this.groupBox1.Controls.Add(this.cbb_ma_loai);
            this.groupBox1.Controls.Add(this.cbb_nha_xb);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label11);
            this.groupBox1.Controls.Add(this.tb_gia_tien);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.cbb_ma_tg);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.tb_ma_sach);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.dtp_nam_xb);
            this.groupBox1.Controls.Add(this.tb_ten_sach);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.tb_so_luong);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Font = new System.Drawing.Font("JetBrains Mono", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(13, 11);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(637, 457);
            this.groupBox1.TabIndex = 29;
            this.groupBox1.TabStop = false;
            // 
            // chk_dongTG
            // 
            this.chk_dongTG.AutoSize = true;
            this.chk_dongTG.Location = new System.Drawing.Point(214, 335);
            this.chk_dongTG.Name = "chk_dongTG";
            this.chk_dongTG.Size = new System.Drawing.Size(152, 26);
            this.chk_dongTG.TabIndex = 24;
            this.chk_dongTG.Text = "Đồng tác giả";
            this.chk_dongTG.UseVisualStyleBackColor = true;
            this.chk_dongTG.CheckedChanged += new System.EventHandler(this.chk_dongTG_CheckedChanged);
            // 
            // cbb_ma_loai
            // 
            this.cbb_ma_loai.DataSource = this.tHELOAISACHBindingSource;
            this.cbb_ma_loai.DisplayMember = "sMaLoai";
            this.cbb_ma_loai.FormattingEnabled = true;
            this.cbb_ma_loai.Location = new System.Drawing.Point(214, 234);
            this.cbb_ma_loai.Name = "cbb_ma_loai";
            this.cbb_ma_loai.Size = new System.Drawing.Size(326, 30);
            this.cbb_ma_loai.TabIndex = 5;
            // 
            // tHELOAISACHBindingSource
            // 
            this.tHELOAISACHBindingSource.DataMember = "THELOAISACH";
            this.tHELOAISACHBindingSource.DataSource = this.quanLyThuVienDataSet;
            // 
            // quanLyThuVienDataSet
            // 
            this.quanLyThuVienDataSet.DataSetName = "QuanLyThuVienDataSet";
            this.quanLyThuVienDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // cbb_nha_xb
            // 
            this.cbb_nha_xb.DataSource = this.nHAXUATBANBindingSource;
            this.cbb_nha_xb.DisplayMember = "sMaNxb";
            this.cbb_nha_xb.FormattingEnabled = true;
            this.cbb_nha_xb.Location = new System.Drawing.Point(214, 407);
            this.cbb_nha_xb.Name = "cbb_nha_xb";
            this.cbb_nha_xb.Size = new System.Drawing.Size(326, 30);
            this.cbb_nha_xb.TabIndex = 8;
            // 
            // nHAXUATBANBindingSource
            // 
            this.nHAXUATBANBindingSource.DataMember = "NHAXUATBAN";
            this.nHAXUATBANBindingSource.DataSource = this.quanLyThuVienDataSet;
            // 
            // label5
            // 
            this.label5.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(42, 410);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(160, 22);
            this.label5.TabIndex = 23;
            this.label5.Text = "Mã nhà xuất bản";
            // 
            // label11
            // 
            this.label11.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(101, 374);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(90, 22);
            this.label11.TabIndex = 22;
            this.label11.Text = "Giá tiền";
            // 
            // tb_gia_tien
            // 
            this.tb_gia_tien.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.tb_gia_tien.Location = new System.Drawing.Point(214, 366);
            this.tb_gia_tien.Name = "tb_gia_tien";
            this.tb_gia_tien.Size = new System.Drawing.Size(326, 30);
            this.tb_gia_tien.TabIndex = 7;
            // 
            // label9
            // 
            this.label9.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(92, 294);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(110, 22);
            this.label9.TabIndex = 20;
            this.label9.Text = "Mã tác giả";
            // 
            // cbb_ma_tg
            // 
            this.cbb_ma_tg.DataSource = this.tACGIABindingSource;
            this.cbb_ma_tg.DisplayMember = "sMaTG";
            this.cbb_ma_tg.FormattingEnabled = true;
            this.cbb_ma_tg.Location = new System.Drawing.Point(214, 286);
            this.cbb_ma_tg.Name = "cbb_ma_tg";
            this.cbb_ma_tg.Size = new System.Drawing.Size(326, 30);
            this.cbb_ma_tg.TabIndex = 6;
            // 
            // tACGIABindingSource
            // 
            this.tACGIABindingSource.DataMember = "TACGIA";
            this.tACGIABindingSource.DataSource = this.quanLyThuVienDataSet;
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(101, 53);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(80, 22);
            this.label3.TabIndex = 6;
            this.label3.Text = "Mã sách";
            // 
            // label8
            // 
            this.label8.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(72, 149);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(130, 22);
            this.label8.TabIndex = 18;
            this.label8.Text = "Năm xuất bản";
            // 
            // tb_ma_sach
            // 
            this.tb_ma_sach.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.tb_ma_sach.Location = new System.Drawing.Point(214, 50);
            this.tb_ma_sach.Name = "tb_ma_sach";
            this.tb_ma_sach.Size = new System.Drawing.Size(326, 30);
            this.tb_ma_sach.TabIndex = 1;
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(92, 101);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(90, 22);
            this.label4.TabIndex = 8;
            this.label4.Text = "Tên sách";
            // 
            // dtp_nam_xb
            // 
            this.dtp_nam_xb.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.dtp_nam_xb.CustomFormat = "dd/MM/yyyy";
            this.dtp_nam_xb.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtp_nam_xb.Location = new System.Drawing.Point(214, 143);
            this.dtp_nam_xb.Name = "dtp_nam_xb";
            this.dtp_nam_xb.Size = new System.Drawing.Size(326, 30);
            this.dtp_nam_xb.TabIndex = 3;
            // 
            // tb_ten_sach
            // 
            this.tb_ten_sach.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.tb_ten_sach.Location = new System.Drawing.Point(214, 98);
            this.tb_ten_sach.Name = "tb_ten_sach";
            this.tb_ten_sach.Size = new System.Drawing.Size(326, 30);
            this.tb_ten_sach.TabIndex = 2;
            // 
            // label7
            // 
            this.label7.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(92, 242);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(80, 22);
            this.label7.TabIndex = 15;
            this.label7.Text = "Mã loại";
            // 
            // tb_so_luong
            // 
            this.tb_so_luong.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.tb_so_luong.Location = new System.Drawing.Point(214, 184);
            this.tb_so_luong.Name = "tb_so_luong";
            this.tb_so_luong.Size = new System.Drawing.Size(326, 30);
            this.tb_so_luong.TabIndex = 4;
            // 
            // label6
            // 
            this.label6.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(82, 192);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(90, 22);
            this.label6.TabIndex = 13;
            this.label6.Text = "Số lượng";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(711, 100);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(70, 22);
            this.label2.TabIndex = 22;
            this.label2.Text = "Bộ lọc";
            // 
            // cbb_boloc
            // 
            this.cbb_boloc.FormattingEnabled = true;
            this.cbb_boloc.Items.AddRange(new object[] {
            "Mã sách",
            "Tên sách",
            "Mã loại"});
            this.cbb_boloc.Location = new System.Drawing.Point(806, 98);
            this.cbb_boloc.Name = "cbb_boloc";
            this.cbb_boloc.Size = new System.Drawing.Size(326, 30);
            this.cbb_boloc.TabIndex = 2;
            // 
            // tb_timkiem
            // 
            this.tb_timkiem.Location = new System.Drawing.Point(806, 53);
            this.tb_timkiem.Name = "tb_timkiem";
            this.tb_timkiem.Size = new System.Drawing.Size(326, 30);
            this.tb_timkiem.TabIndex = 1;
            this.tb_timkiem.TextChanged += new System.EventHandler(this.tb_timkiem_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(711, 55);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(90, 22);
            this.label1.TabIndex = 21;
            this.label1.Text = "Tìm kiếm";
            // 
            // tHELOAISACHTableAdapter
            // 
            this.tHELOAISACHTableAdapter.ClearBeforeFill = true;
            // 
            // tACGIATableAdapter
            // 
            this.tACGIATableAdapter.ClearBeforeFill = true;
            // 
            // nHAXUATBANTableAdapter
            // 
            this.nHAXUATBANTableAdapter.ClearBeforeFill = true;
            // 
            // btn_in
            // 
            this.btn_in.Location = new System.Drawing.Point(670, 394);
            this.btn_in.Name = "btn_in";
            this.btn_in.Size = new System.Drawing.Size(138, 30);
            this.btn_in.TabIndex = 31;
            this.btn_in.Text = "In Ds sách";
            this.btn_in.UseVisualStyleBackColor = true;
            this.btn_in.Click += new System.EventHandler(this.btn_in_Click);
            // 
            // SachForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 22F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1148, 627);
            this.Controls.Add(this.btn_in);
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
            this.Controls.Add(this.dgv_sach);
            this.Font = new System.Drawing.Font("JetBrains Mono", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.Name = "SachForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Quản lý sách";
            this.Load += new System.EventHandler(this.SachForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_sach)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tHELOAISACHBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.quanLyThuVienDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nHAXUATBANBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tACGIABindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgv_sach;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Button btn_clean;
        private System.Windows.Forms.Button btn_xoa;
        private System.Windows.Forms.Button btn_capnhat;
        private System.Windows.Forms.Button btn_them;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox tb_gia_tien;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.ComboBox cbb_ma_tg;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox tb_ma_sach;
        private System.Windows.Forms.DateTimePicker dtp_nam_xb;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tb_ten_sach;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox tb_so_luong;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cbb_boloc;
        private System.Windows.Forms.TextBox tb_timkiem;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cbb_ma_loai;
        private System.Windows.Forms.ComboBox cbb_nha_xb;
        private System.Windows.Forms.Label label5;
        private QuanLyThuVienDataSet quanLyThuVienDataSet;
        private System.Windows.Forms.BindingSource tHELOAISACHBindingSource;
        private QuanLyThuVienDataSetTableAdapters.THELOAISACHTableAdapter tHELOAISACHTableAdapter;
        private System.Windows.Forms.BindingSource tACGIABindingSource;
        private QuanLyThuVienDataSetTableAdapters.TACGIATableAdapter tACGIATableAdapter;
        private System.Windows.Forms.BindingSource nHAXUATBANBindingSource;
        private QuanLyThuVienDataSetTableAdapters.NHAXUATBANTableAdapter nHAXUATBANTableAdapter;
        private System.Windows.Forms.CheckBox chk_dongTG;
        private System.Windows.Forms.Button btn_in;
    }
}