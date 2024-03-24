namespace GUI
{
    partial class PhieuMuonFrm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PhieuMuonFrm));
            this.cbb_ma_dg = new System.Windows.Forms.ComboBox();
            this.quanLyThuVienDataSet1 = new GUI.QuanLyThuVienDataSet1();
            this.quanLyThuVienDataSet1BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dOCGIABindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dOCGIATableAdapter = new GUI.QuanLyThuVienDataSet1TableAdapters.DOCGIATableAdapter();
            this.label10 = new System.Windows.Forms.Label();
            this.btn_clean = new System.Windows.Forms.Button();
            this.btn_xoa = new System.Windows.Forms.Button();
            this.btn_capnhat = new System.Windows.Forms.Button();
            this.btn_them = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.tb_ma_phieu_muon = new System.Windows.Forms.TextBox();
            this.dtp_ngay_hen_tra = new System.Windows.Forms.DateTimePicker();
            this.label4 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.cbb_boloc = new System.Windows.Forms.ComboBox();
            this.tb_timkiem = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.dgv_nhan_vien = new System.Windows.Forms.DataGridView();
            this.dtp_ngay_muon = new System.Windows.Forms.DateTimePicker();
            this.cbb_ma_nv = new System.Windows.Forms.ComboBox();
            this.cbb_ma_sach = new System.Windows.Forms.ComboBox();
            this.cbb_loai_phieu = new System.Windows.Forms.ComboBox();
            this.nHANVIENBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.nHANVIENTableAdapter = new GUI.QuanLyThuVienDataSet1TableAdapters.NHANVIENTableAdapter();
            this.sACHBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.sACHTableAdapter = new GUI.QuanLyThuVienDataSet1TableAdapters.SACHTableAdapter();
            this.lOAIPHIEUBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.lOAIPHIEUTableAdapter = new GUI.QuanLyThuVienDataSet1TableAdapters.LOAIPHIEUTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.quanLyThuVienDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.quanLyThuVienDataSet1BindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dOCGIABindingSource)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_nhan_vien)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nHANVIENBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sACHBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lOAIPHIEUBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // cbb_ma_dg
            // 
            this.cbb_ma_dg.DataSource = this.dOCGIABindingSource;
            this.cbb_ma_dg.DisplayMember = "sMaDG";
            this.cbb_ma_dg.FormattingEnabled = true;
            this.cbb_ma_dg.Location = new System.Drawing.Point(192, 93);
            this.cbb_ma_dg.Name = "cbb_ma_dg";
            this.cbb_ma_dg.Size = new System.Drawing.Size(293, 31);
            this.cbb_ma_dg.TabIndex = 0;
            // 
            // quanLyThuVienDataSet1
            // 
            this.quanLyThuVienDataSet1.DataSetName = "QuanLyThuVienDataSet1";
            this.quanLyThuVienDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // quanLyThuVienDataSet1BindingSource
            // 
            this.quanLyThuVienDataSet1BindingSource.DataSource = this.quanLyThuVienDataSet1;
            this.quanLyThuVienDataSet1BindingSource.Position = 0;
            // 
            // dOCGIABindingSource
            // 
            this.dOCGIABindingSource.DataMember = "DOCGIA";
            this.dOCGIABindingSource.DataSource = this.quanLyThuVienDataSet1BindingSource;
            // 
            // dOCGIATableAdapter
            // 
            this.dOCGIATableAdapter.ClearBeforeFill = true;
            // 
            // label10
            // 
            this.label10.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Image = ((System.Drawing.Image)(resources.GetObject("label10.Image")));
            this.label10.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label10.Location = new System.Drawing.Point(597, 147);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(428, 23);
            this.label10.TabIndex = 31;
            this.label10.Text = "Lưu ý: Bạn hãy chọn bộ lọc trước khi tìm kiếm nhé!\r\n";
            this.label10.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // btn_clean
            // 
            this.btn_clean.Location = new System.Drawing.Point(940, 342);
            this.btn_clean.Name = "btn_clean";
            this.btn_clean.Size = new System.Drawing.Size(92, 34);
            this.btn_clean.TabIndex = 29;
            this.btn_clean.Text = "Làm mới";
            this.btn_clean.UseVisualStyleBackColor = true;
            // 
            // btn_xoa
            // 
            this.btn_xoa.Location = new System.Drawing.Point(832, 342);
            this.btn_xoa.Name = "btn_xoa";
            this.btn_xoa.Size = new System.Drawing.Size(79, 34);
            this.btn_xoa.TabIndex = 28;
            this.btn_xoa.Text = "Xóa";
            this.btn_xoa.UseVisualStyleBackColor = true;
            // 
            // btn_capnhat
            // 
            this.btn_capnhat.Location = new System.Drawing.Point(712, 341);
            this.btn_capnhat.Name = "btn_capnhat";
            this.btn_capnhat.Size = new System.Drawing.Size(90, 34);
            this.btn_capnhat.TabIndex = 27;
            this.btn_capnhat.Text = "Cập nhật";
            this.btn_capnhat.UseVisualStyleBackColor = true;
            // 
            // btn_them
            // 
            this.btn_them.Location = new System.Drawing.Point(601, 341);
            this.btn_them.Name = "btn_them";
            this.btn_them.Size = new System.Drawing.Size(79, 34);
            this.btn_them.TabIndex = 26;
            this.btn_them.Text = "Thêm";
            this.btn_them.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.cbb_loai_phieu);
            this.groupBox1.Controls.Add(this.cbb_ma_sach);
            this.groupBox1.Controls.Add(this.cbb_ma_nv);
            this.groupBox1.Controls.Add(this.dtp_ngay_muon);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.tb_ma_phieu_muon);
            this.groupBox1.Controls.Add(this.dtp_ngay_hen_tra);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.cbb_ma_dg);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(12, 5);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(573, 426);
            this.groupBox1.TabIndex = 30;
            this.groupBox1.TabStop = false;
            // 
            // label9
            // 
            this.label9.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(72, 296);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(114, 23);
            this.label9.TabIndex = 20;
            this.label9.Text = "Mã loại phiếu";
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(51, 53);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(132, 23);
            this.label3.TabIndex = 6;
            this.label3.Text = "Mã phiếu mượn";
            // 
            // label8
            // 
            this.label8.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(72, 347);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(110, 23);
            this.label8.TabIndex = 18;
            this.label8.Text = "Ngày hẹn trả";
            // 
            // tb_ma_phieu_muon
            // 
            this.tb_ma_phieu_muon.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.tb_ma_phieu_muon.Location = new System.Drawing.Point(192, 46);
            this.tb_ma_phieu_muon.Name = "tb_ma_phieu_muon";
            this.tb_ma_phieu_muon.Size = new System.Drawing.Size(294, 30);
            this.tb_ma_phieu_muon.TabIndex = 1;
            // 
            // dtp_ngay_hen_tra
            // 
            this.dtp_ngay_hen_tra.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.dtp_ngay_hen_tra.CustomFormat = "dd/MM/yyyy";
            this.dtp_ngay_hen_tra.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtp_ngay_hen_tra.Location = new System.Drawing.Point(191, 341);
            this.dtp_ngay_hen_tra.Name = "dtp_ngay_hen_tra";
            this.dtp_ngay_hen_tra.Size = new System.Drawing.Size(294, 30);
            this.dtp_ngay_hen_tra.TabIndex = 8;
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(72, 96);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(95, 23);
            this.label4.TabIndex = 8;
            this.label4.Text = "Mã độc giả";
            // 
            // label7
            // 
            this.label7.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(72, 244);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(73, 23);
            this.label7.TabIndex = 15;
            this.label7.Text = "Mã sách";
            // 
            // label6
            // 
            this.label6.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(72, 186);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(114, 23);
            this.label6.TabIndex = 13;
            this.label6.Text = "Mã nhân viên";
            // 
            // label5
            // 
            this.label5.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(72, 142);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(100, 23);
            this.label5.TabIndex = 12;
            this.label5.Text = "Ngày mượn";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(640, 98);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(57, 23);
            this.label2.TabIndex = 23;
            this.label2.Text = "Bộ lọc";
            // 
            // cbb_boloc
            // 
            this.cbb_boloc.FormattingEnabled = true;
            this.cbb_boloc.Items.AddRange(new object[] {
            "Mã nhân viên",
            "Tên nhân viên"});
            this.cbb_boloc.Location = new System.Drawing.Point(725, 95);
            this.cbb_boloc.Name = "cbb_boloc";
            this.cbb_boloc.Size = new System.Drawing.Size(294, 31);
            this.cbb_boloc.TabIndex = 25;
            // 
            // tb_timkiem
            // 
            this.tb_timkiem.Location = new System.Drawing.Point(725, 48);
            this.tb_timkiem.Name = "tb_timkiem";
            this.tb_timkiem.Size = new System.Drawing.Size(294, 30);
            this.tb_timkiem.TabIndex = 24;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(640, 51);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(79, 23);
            this.label1.TabIndex = 22;
            this.label1.Text = "Tìm kiếm";
            // 
            // dgv_nhan_vien
            // 
            this.dgv_nhan_vien.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgv_nhan_vien.BackgroundColor = System.Drawing.SystemColors.Menu;
            this.dgv_nhan_vien.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_nhan_vien.Location = new System.Drawing.Point(0, 449);
            this.dgv_nhan_vien.Name = "dgv_nhan_vien";
            this.dgv_nhan_vien.RowHeadersWidth = 51;
            this.dgv_nhan_vien.RowTemplate.Height = 24;
            this.dgv_nhan_vien.Size = new System.Drawing.Size(1032, 157);
            this.dgv_nhan_vien.TabIndex = 21;
            // 
            // dtp_ngay_muon
            // 
            this.dtp_ngay_muon.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.dtp_ngay_muon.CustomFormat = "dd/MM/yyyy";
            this.dtp_ngay_muon.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtp_ngay_muon.Location = new System.Drawing.Point(192, 142);
            this.dtp_ngay_muon.Name = "dtp_ngay_muon";
            this.dtp_ngay_muon.Size = new System.Drawing.Size(294, 30);
            this.dtp_ngay_muon.TabIndex = 21;
            // 
            // cbb_ma_nv
            // 
            this.cbb_ma_nv.DataSource = this.nHANVIENBindingSource;
            this.cbb_ma_nv.DisplayMember = "sMaNV";
            this.cbb_ma_nv.FormattingEnabled = true;
            this.cbb_ma_nv.Location = new System.Drawing.Point(193, 184);
            this.cbb_ma_nv.Name = "cbb_ma_nv";
            this.cbb_ma_nv.Size = new System.Drawing.Size(292, 31);
            this.cbb_ma_nv.TabIndex = 22;
            // 
            // cbb_ma_sach
            // 
            this.cbb_ma_sach.DataSource = this.sACHBindingSource;
            this.cbb_ma_sach.DisplayMember = "sMaSach";
            this.cbb_ma_sach.FormattingEnabled = true;
            this.cbb_ma_sach.Location = new System.Drawing.Point(193, 242);
            this.cbb_ma_sach.Name = "cbb_ma_sach";
            this.cbb_ma_sach.Size = new System.Drawing.Size(292, 31);
            this.cbb_ma_sach.TabIndex = 23;
            // 
            // cbb_loai_phieu
            // 
            this.cbb_loai_phieu.DataSource = this.lOAIPHIEUBindingSource;
            this.cbb_loai_phieu.DisplayMember = "iMaLoaiPhieu";
            this.cbb_loai_phieu.FormattingEnabled = true;
            this.cbb_loai_phieu.Location = new System.Drawing.Point(193, 296);
            this.cbb_loai_phieu.Name = "cbb_loai_phieu";
            this.cbb_loai_phieu.Size = new System.Drawing.Size(292, 31);
            this.cbb_loai_phieu.TabIndex = 24;
            // 
            // nHANVIENBindingSource
            // 
            this.nHANVIENBindingSource.DataMember = "NHANVIEN";
            this.nHANVIENBindingSource.DataSource = this.quanLyThuVienDataSet1BindingSource;
            // 
            // nHANVIENTableAdapter
            // 
            this.nHANVIENTableAdapter.ClearBeforeFill = true;
            // 
            // sACHBindingSource
            // 
            this.sACHBindingSource.DataMember = "SACH";
            this.sACHBindingSource.DataSource = this.quanLyThuVienDataSet1BindingSource;
            // 
            // sACHTableAdapter
            // 
            this.sACHTableAdapter.ClearBeforeFill = true;
            // 
            // lOAIPHIEUBindingSource
            // 
            this.lOAIPHIEUBindingSource.DataMember = "LOAIPHIEU";
            this.lOAIPHIEUBindingSource.DataSource = this.quanLyThuVienDataSet1BindingSource;
            // 
            // lOAIPHIEUTableAdapter
            // 
            this.lOAIPHIEUTableAdapter.ClearBeforeFill = true;
            // 
            // PhieuMuonFrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 23F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1033, 599);
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
            this.Controls.Add(this.dgv_nhan_vien);
            this.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "PhieuMuonFrm";
            this.Text = "PhieuMuonFrm";
            this.Load += new System.EventHandler(this.PhieuMuonFrm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.quanLyThuVienDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.quanLyThuVienDataSet1BindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dOCGIABindingSource)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_nhan_vien)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nHANVIENBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sACHBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lOAIPHIEUBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cbb_ma_dg;
        private System.Windows.Forms.BindingSource quanLyThuVienDataSet1BindingSource;
        private QuanLyThuVienDataSet1 quanLyThuVienDataSet1;
        private System.Windows.Forms.BindingSource dOCGIABindingSource;
        private QuanLyThuVienDataSet1TableAdapters.DOCGIATableAdapter dOCGIATableAdapter;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Button btn_clean;
        private System.Windows.Forms.Button btn_xoa;
        private System.Windows.Forms.Button btn_capnhat;
        private System.Windows.Forms.Button btn_them;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox tb_ma_phieu_muon;
        private System.Windows.Forms.DateTimePicker dtp_ngay_hen_tra;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cbb_boloc;
        private System.Windows.Forms.TextBox tb_timkiem;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dgv_nhan_vien;
        private System.Windows.Forms.ComboBox cbb_loai_phieu;
        private System.Windows.Forms.ComboBox cbb_ma_sach;
        private System.Windows.Forms.ComboBox cbb_ma_nv;
        private System.Windows.Forms.DateTimePicker dtp_ngay_muon;
        private System.Windows.Forms.BindingSource nHANVIENBindingSource;
        private QuanLyThuVienDataSet1TableAdapters.NHANVIENTableAdapter nHANVIENTableAdapter;
        private System.Windows.Forms.BindingSource sACHBindingSource;
        private QuanLyThuVienDataSet1TableAdapters.SACHTableAdapter sACHTableAdapter;
        private System.Windows.Forms.BindingSource lOAIPHIEUBindingSource;
        private QuanLyThuVienDataSet1TableAdapters.LOAIPHIEUTableAdapter lOAIPHIEUTableAdapter;
    }
}