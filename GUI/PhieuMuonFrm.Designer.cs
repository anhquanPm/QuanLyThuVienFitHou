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
            this.dOCGIABindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.quanLyThuVienDataSet1BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.quanLyThuVienDataSet1 = new GUI.QuanLyThuVienDataSet1();
            this.dOCGIATableAdapter = new GUI.QuanLyThuVienDataSet1TableAdapters.DOCGIATableAdapter();
            this.label10 = new System.Windows.Forms.Label();
            this.btn_clean = new System.Windows.Forms.Button();
            this.btn_xoa = new System.Windows.Forms.Button();
            this.btn_capnhat = new System.Windows.Forms.Button();
            this.btn_them = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.chk_check = new System.Windows.Forms.CheckBox();
            this.cbb_loai_phieu = new System.Windows.Forms.ComboBox();
            this.lOAIPHIEUBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.cbb_ma_sach = new System.Windows.Forms.ComboBox();
            this.sACHBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.quanLyThuVienDataSet2 = new GUI.QuanLyThuVienDataSet2();
            this.cbb_ma_nv = new System.Windows.Forms.ComboBox();
            this.nHANVIENBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dtp_ngay_muon = new System.Windows.Forms.DateTimePicker();
            this.label9 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.tb_ma_phieu_muon = new System.Windows.Forms.TextBox();
            this.dtp_ngay_hen_tra = new System.Windows.Forms.DateTimePicker();
            this.label4 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.quanLyThuVienDataSet1BindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.label2 = new System.Windows.Forms.Label();
            this.cbb_boloc = new System.Windows.Forms.ComboBox();
            this.tb_timkiem = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.dgv_phieu_muon = new System.Windows.Forms.DataGridView();
            this.nHANVIENTableAdapter = new GUI.QuanLyThuVienDataSet1TableAdapters.NHANVIENTableAdapter();
            this.lOAIPHIEUTableAdapter = new GUI.QuanLyThuVienDataSet1TableAdapters.LOAIPHIEUTableAdapter();
<<<<<<< HEAD
            this.quanLyThuVienDataSet = new GUI.QuanLyThuVienDataSet();
            this.pHIEUTRASACHBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.pHIEUTRASACHTableAdapter = new GUI.QuanLyThuVienDataSetTableAdapters.PHIEUTRASACHTableAdapter();
            this.quanLyThuVienDataSet2BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.sACHTableAdapter = new GUI.QuanLyThuVienDataSet2TableAdapters.SACHTableAdapter();
            this.btn_in = new System.Windows.Forms.Button();
=======
            this.chk_check = new System.Windows.Forms.CheckBox();
>>>>>>> 6fbe207437f69b598926bfb73747f3013897ac5e
            ((System.ComponentModel.ISupportInitialize)(this.dOCGIABindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.quanLyThuVienDataSet1BindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.quanLyThuVienDataSet1)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.lOAIPHIEUBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sACHBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.quanLyThuVienDataSet2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nHANVIENBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.quanLyThuVienDataSet1BindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_phieu_muon)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.quanLyThuVienDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pHIEUTRASACHBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.quanLyThuVienDataSet2BindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // cbb_ma_dg
            // 
            this.cbb_ma_dg.DataSource = this.dOCGIABindingSource;
            this.cbb_ma_dg.DisplayMember = "sMaDG";
            this.cbb_ma_dg.FormattingEnabled = true;
            this.cbb_ma_dg.Location = new System.Drawing.Point(213, 89);
            this.cbb_ma_dg.Name = "cbb_ma_dg";
            this.cbb_ma_dg.Size = new System.Drawing.Size(325, 30);
            this.cbb_ma_dg.TabIndex = 0;
            // 
            // dOCGIABindingSource
            // 
            this.dOCGIABindingSource.DataMember = "DOCGIA";
            this.dOCGIABindingSource.DataSource = this.quanLyThuVienDataSet1BindingSource;
            // 
            // quanLyThuVienDataSet1BindingSource
            // 
            this.quanLyThuVienDataSet1BindingSource.DataSource = this.quanLyThuVienDataSet1;
            this.quanLyThuVienDataSet1BindingSource.Position = 0;
            // 
            // quanLyThuVienDataSet1
            // 
            this.quanLyThuVienDataSet1.DataSetName = "QuanLyThuVienDataSet1";
            this.quanLyThuVienDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // dOCGIATableAdapter
            // 
            this.dOCGIATableAdapter.ClearBeforeFill = true;
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
            this.btn_clean.Size = new System.Drawing.Size(102, 33);
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
            this.groupBox1.Controls.Add(this.chk_check);
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
            this.groupBox1.Font = new System.Drawing.Font("JetBrains Mono", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(13, 5);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(637, 407);
            this.groupBox1.TabIndex = 30;
            this.groupBox1.TabStop = false;
            // 
            // chk_check
            // 
            this.chk_check.AutoSize = true;
            this.chk_check.Location = new System.Drawing.Point(84, 372);
            this.chk_check.Name = "chk_check";
            this.chk_check.Size = new System.Drawing.Size(392, 26);
            this.chk_check.TabIndex = 25;
            this.chk_check.Text = "Thêm sách vào phiếu có mã đã tồn tại";
            this.chk_check.UseVisualStyleBackColor = true;
            this.chk_check.CheckedChanged += new System.EventHandler(this.chk_check_CheckedChanged);
            // 
            // cbb_loai_phieu
            // 
            this.cbb_loai_phieu.DataSource = this.lOAIPHIEUBindingSource;
            this.cbb_loai_phieu.DisplayMember = "iMaLoaiPhieu";
            this.cbb_loai_phieu.FormattingEnabled = true;
            this.cbb_loai_phieu.Location = new System.Drawing.Point(214, 283);
            this.cbb_loai_phieu.Name = "cbb_loai_phieu";
            this.cbb_loai_phieu.Size = new System.Drawing.Size(324, 30);
            this.cbb_loai_phieu.TabIndex = 24;
            // 
            // lOAIPHIEUBindingSource
            // 
            this.lOAIPHIEUBindingSource.DataMember = "LOAIPHIEU";
            this.lOAIPHIEUBindingSource.DataSource = this.quanLyThuVienDataSet1BindingSource;
            // 
            // cbb_ma_sach
            // 
            this.cbb_ma_sach.DataSource = this.sACHBindingSource;
            this.cbb_ma_sach.DisplayMember = "sMaSach";
            this.cbb_ma_sach.FormattingEnabled = true;
            this.cbb_ma_sach.Location = new System.Drawing.Point(214, 231);
            this.cbb_ma_sach.Name = "cbb_ma_sach";
            this.cbb_ma_sach.Size = new System.Drawing.Size(324, 30);
            this.cbb_ma_sach.TabIndex = 23;
            // 
            // sACHBindingSource
            // 
            this.sACHBindingSource.DataMember = "SACH";
            this.sACHBindingSource.DataSource = this.quanLyThuVienDataSet2;
            // 
            // quanLyThuVienDataSet2
            // 
            this.quanLyThuVienDataSet2.DataSetName = "QuanLyThuVienDataSet2";
            this.quanLyThuVienDataSet2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // cbb_ma_nv
            // 
            this.cbb_ma_nv.DataSource = this.nHANVIENBindingSource;
            this.cbb_ma_nv.DisplayMember = "sMaNV";
            this.cbb_ma_nv.FormattingEnabled = true;
            this.cbb_ma_nv.Location = new System.Drawing.Point(214, 176);
            this.cbb_ma_nv.Name = "cbb_ma_nv";
            this.cbb_ma_nv.Size = new System.Drawing.Size(324, 30);
            this.cbb_ma_nv.TabIndex = 22;
            // 
            // nHANVIENBindingSource
            // 
            this.nHANVIENBindingSource.DataMember = "NHANVIEN";
            this.nHANVIENBindingSource.DataSource = this.quanLyThuVienDataSet1BindingSource;
            // 
            // dtp_ngay_muon
            // 
            this.dtp_ngay_muon.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.dtp_ngay_muon.CustomFormat = "dd/MM/yyyy";
            this.dtp_ngay_muon.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtp_ngay_muon.Location = new System.Drawing.Point(213, 136);
            this.dtp_ngay_muon.Name = "dtp_ngay_muon";
            this.dtp_ngay_muon.Size = new System.Drawing.Size(326, 30);
            this.dtp_ngay_muon.TabIndex = 21;
            // 
            // label9
            // 
            this.label9.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(70, 291);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(140, 22);
            this.label9.TabIndex = 20;
            this.label9.Text = "Mã loại phiếu";
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(57, 51);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(140, 22);
            this.label3.TabIndex = 6;
            this.label3.Text = "Mã phiếu mượn";
            // 
            // label8
            // 
            this.label8.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(70, 332);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(130, 22);
            this.label8.TabIndex = 18;
            this.label8.Text = "Ngày hẹn trả";
            // 
            // tb_ma_phieu_muon
            // 
            this.tb_ma_phieu_muon.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.tb_ma_phieu_muon.Location = new System.Drawing.Point(213, 44);
            this.tb_ma_phieu_muon.Name = "tb_ma_phieu_muon";
            this.tb_ma_phieu_muon.Size = new System.Drawing.Size(326, 30);
            this.tb_ma_phieu_muon.TabIndex = 1;
            // 
            // dtp_ngay_hen_tra
            // 
            this.dtp_ngay_hen_tra.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.dtp_ngay_hen_tra.CustomFormat = "dd/MM/yyyy";
            this.dtp_ngay_hen_tra.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtp_ngay_hen_tra.Location = new System.Drawing.Point(212, 326);
            this.dtp_ngay_hen_tra.Name = "dtp_ngay_hen_tra";
            this.dtp_ngay_hen_tra.Size = new System.Drawing.Size(326, 30);
            this.dtp_ngay_hen_tra.TabIndex = 8;
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(80, 92);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(110, 22);
            this.label4.TabIndex = 8;
            this.label4.Text = "Mã độc giả";
            // 
            // label7
            // 
            this.label7.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(100, 234);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(80, 22);
            this.label7.TabIndex = 15;
            this.label7.Text = "Mã sách";
            // 
            // label6
            // 
            this.label6.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(80, 178);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(130, 22);
            this.label6.TabIndex = 13;
            this.label6.Text = "Mã nhân viên";
            // 
            // label5
            // 
            this.label5.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(80, 136);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(100, 22);
            this.label5.TabIndex = 12;
            this.label5.Text = "Ngày mượn";
            // 
            // quanLyThuVienDataSet1BindingSource1
            // 
            this.quanLyThuVienDataSet1BindingSource1.DataSource = this.quanLyThuVienDataSet1;
            this.quanLyThuVienDataSet1BindingSource1.Position = 0;
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
            "Mã phiếu mượn",
            "Mã độc giả"});
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
            // dgv_phieu_muon
            // 
            this.dgv_phieu_muon.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgv_phieu_muon.BackgroundColor = System.Drawing.SystemColors.Menu;
            this.dgv_phieu_muon.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_phieu_muon.Location = new System.Drawing.Point(0, 429);
            this.dgv_phieu_muon.Name = "dgv_phieu_muon";
            this.dgv_phieu_muon.RowHeadersWidth = 51;
            this.dgv_phieu_muon.RowTemplate.Height = 24;
            this.dgv_phieu_muon.Size = new System.Drawing.Size(1147, 150);
            this.dgv_phieu_muon.TabIndex = 21;
            this.dgv_phieu_muon.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_phieu_muon_CellClick);
            // 
            // nHANVIENTableAdapter
            // 
            this.nHANVIENTableAdapter.ClearBeforeFill = true;
            // 
            // lOAIPHIEUTableAdapter
            // 
            this.lOAIPHIEUTableAdapter.ClearBeforeFill = true;
            // 
<<<<<<< HEAD
            // quanLyThuVienDataSet
            // 
            this.quanLyThuVienDataSet.DataSetName = "QuanLyThuVienDataSet";
            this.quanLyThuVienDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // pHIEUTRASACHBindingSource
            // 
            this.pHIEUTRASACHBindingSource.DataMember = "PHIEUTRASACH";
            this.pHIEUTRASACHBindingSource.DataSource = this.quanLyThuVienDataSet;
            // 
            // pHIEUTRASACHTableAdapter
            // 
            this.pHIEUTRASACHTableAdapter.ClearBeforeFill = true;
            // 
            // quanLyThuVienDataSet2BindingSource
            // 
            this.quanLyThuVienDataSet2BindingSource.DataSource = this.quanLyThuVienDataSet2;
            this.quanLyThuVienDataSet2BindingSource.Position = 0;
            // 
            // sACHTableAdapter
            // 
            this.sACHTableAdapter.ClearBeforeFill = true;
            // 
            // btn_in
            // 
            this.btn_in.Location = new System.Drawing.Point(834, 380);
            this.btn_in.Name = "btn_in";
            this.btn_in.Size = new System.Drawing.Size(149, 33);
            this.btn_in.TabIndex = 32;
            this.btn_in.Text = "In phiếu mượn";
            this.btn_in.UseVisualStyleBackColor = true;
            this.btn_in.Click += new System.EventHandler(this.btn_in_Click);
=======
            // chk_check
            // 
            this.chk_check.AutoSize = true;
            this.chk_check.Location = new System.Drawing.Point(76, 389);
            this.chk_check.Name = "chk_check";
            this.chk_check.Size = new System.Drawing.Size(325, 27);
            this.chk_check.TabIndex = 25;
            this.chk_check.Text = "Thêm sách vào phiếu có mã đã tồn tại";
            this.chk_check.UseVisualStyleBackColor = true;
            this.chk_check.CheckedChanged += new System.EventHandler(this.chk_check_CheckedChanged);
>>>>>>> 6fbe207437f69b598926bfb73747f3013897ac5e
            // 
            // PhieuMuonFrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 22F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1148, 573);
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
            this.Controls.Add(this.dgv_phieu_muon);
            this.Font = new System.Drawing.Font("JetBrains Mono", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "PhieuMuonFrm";
            this.Text = "Phiếu Mượn";
            this.Load += new System.EventHandler(this.PhieuMuonFrm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dOCGIABindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.quanLyThuVienDataSet1BindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.quanLyThuVienDataSet1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.lOAIPHIEUBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sACHBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.quanLyThuVienDataSet2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nHANVIENBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.quanLyThuVienDataSet1BindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_phieu_muon)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.quanLyThuVienDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pHIEUTRASACHBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.quanLyThuVienDataSet2BindingSource)).EndInit();
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
        private System.Windows.Forms.DataGridView dgv_phieu_muon;
        private System.Windows.Forms.ComboBox cbb_loai_phieu;
        private System.Windows.Forms.ComboBox cbb_ma_sach;
        private System.Windows.Forms.ComboBox cbb_ma_nv;
        private System.Windows.Forms.DateTimePicker dtp_ngay_muon;
        private System.Windows.Forms.BindingSource nHANVIENBindingSource;
        private QuanLyThuVienDataSet1TableAdapters.NHANVIENTableAdapter nHANVIENTableAdapter;
        private System.Windows.Forms.BindingSource lOAIPHIEUBindingSource;
        private QuanLyThuVienDataSet1TableAdapters.LOAIPHIEUTableAdapter lOAIPHIEUTableAdapter;
        private System.Windows.Forms.CheckBox chk_check;
<<<<<<< HEAD
        private QuanLyThuVienDataSet quanLyThuVienDataSet;
        private System.Windows.Forms.BindingSource pHIEUTRASACHBindingSource;
        private QuanLyThuVienDataSetTableAdapters.PHIEUTRASACHTableAdapter pHIEUTRASACHTableAdapter;
        private System.Windows.Forms.BindingSource quanLyThuVienDataSet1BindingSource1;
        private System.Windows.Forms.BindingSource quanLyThuVienDataSet2BindingSource;
        private QuanLyThuVienDataSet2 quanLyThuVienDataSet2;
        private System.Windows.Forms.BindingSource sACHBindingSource;
        private QuanLyThuVienDataSet2TableAdapters.SACHTableAdapter sACHTableAdapter;
        private System.Windows.Forms.Button btn_in;
=======
>>>>>>> 6fbe207437f69b598926bfb73747f3013897ac5e
    }
}