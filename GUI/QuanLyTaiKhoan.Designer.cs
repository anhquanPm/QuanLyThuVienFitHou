namespace GUI
{
    partial class QuanLyTaiKhoan
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(QuanLyTaiKhoan));
            this.dgv_tai_khoan = new System.Windows.Forms.DataGridView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cbb_ma_nv = new System.Windows.Forms.ComboBox();
            this.nHANVIENBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.quanLyThuVienDataSet = new GUI.QuanLyThuVienDataSet();
            this.cbb_quyen = new System.Windows.Forms.ComboBox();
            this.tb_mk = new System.Windows.Forms.TextBox();
            this.tb_ten_tk = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btn_clean = new System.Windows.Forms.Button();
            this.btn_xoa = new System.Windows.Forms.Button();
            this.btn_cap_nhat = new System.Windows.Forms.Button();
            this.btn_them = new System.Windows.Forms.Button();
            this.nHANVIENTableAdapter = new GUI.QuanLyThuVienDataSetTableAdapters.NHANVIENTableAdapter();
            this.label5 = new System.Windows.Forms.Label();
            this.cbb_bo_loc = new System.Windows.Forms.ComboBox();
            this.tb_tim_kiem = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_tai_khoan)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nHANVIENBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.quanLyThuVienDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // dgv_tai_khoan
            // 
            this.dgv_tai_khoan.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgv_tai_khoan.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dgv_tai_khoan.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_tai_khoan.Location = new System.Drawing.Point(-1, 451);
            this.dgv_tai_khoan.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.dgv_tai_khoan.Name = "dgv_tai_khoan";
            this.dgv_tai_khoan.RowHeadersWidth = 51;
            this.dgv_tai_khoan.RowTemplate.Height = 24;
            this.dgv_tai_khoan.Size = new System.Drawing.Size(1149, 121);
            this.dgv_tai_khoan.TabIndex = 0;
            this.dgv_tai_khoan.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_tai_khoan_CellClick);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.cbb_ma_nv);
            this.groupBox1.Controls.Add(this.cbb_quyen);
            this.groupBox1.Controls.Add(this.tb_mk);
            this.groupBox1.Controls.Add(this.tb_ten_tk);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(16, 16);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox1.Size = new System.Drawing.Size(514, 427);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            // 
            // cbb_ma_nv
            // 
            this.cbb_ma_nv.DataSource = this.nHANVIENBindingSource;
            this.cbb_ma_nv.DisplayMember = "sMaNV";
            this.cbb_ma_nv.FormattingEnabled = true;
            this.cbb_ma_nv.Location = new System.Drawing.Point(181, 142);
            this.cbb_ma_nv.Name = "cbb_ma_nv";
            this.cbb_ma_nv.Size = new System.Drawing.Size(184, 30);
            this.cbb_ma_nv.TabIndex = 9;
            // 
            // nHANVIENBindingSource
            // 
            this.nHANVIENBindingSource.DataMember = "NHANVIEN";
            this.nHANVIENBindingSource.DataSource = this.quanLyThuVienDataSet;
            // 
            // quanLyThuVienDataSet
            // 
            this.quanLyThuVienDataSet.DataSetName = "QuanLyThuVienDataSet";
            this.quanLyThuVienDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // cbb_quyen
            // 
            this.cbb_quyen.FormattingEnabled = true;
            this.cbb_quyen.Items.AddRange(new object[] {
            "Quản lý",
            "Nhân viên"});
            this.cbb_quyen.Location = new System.Drawing.Point(181, 193);
            this.cbb_quyen.Name = "cbb_quyen";
            this.cbb_quyen.Size = new System.Drawing.Size(184, 30);
            this.cbb_quyen.TabIndex = 8;
            // 
            // tb_mk
            // 
            this.tb_mk.Location = new System.Drawing.Point(181, 87);
            this.tb_mk.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tb_mk.Name = "tb_mk";
            this.tb_mk.Size = new System.Drawing.Size(184, 30);
            this.tb_mk.TabIndex = 5;
            // 
            // tb_ten_tk
            // 
            this.tb_ten_tk.Location = new System.Drawing.Point(181, 33);
            this.tb_ten_tk.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tb_ten_tk.Name = "tb_ten_tk";
            this.tb_ten_tk.Size = new System.Drawing.Size(184, 30);
            this.tb_ten_tk.TabIndex = 4;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(42, 196);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(60, 22);
            this.label4.TabIndex = 3;
            this.label4.Text = "Quyền";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(42, 142);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(130, 22);
            this.label3.TabIndex = 2;
            this.label3.Text = "Mã nhân viên";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(43, 94);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(90, 22);
            this.label2.TabIndex = 1;
            this.label2.Text = "Mật khẩu";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(43, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(140, 22);
            this.label1.TabIndex = 0;
            this.label1.Text = "Tên tài khoản";
            // 
            // btn_clean
            // 
            this.btn_clean.Location = new System.Drawing.Point(1033, 214);
            this.btn_clean.Name = "btn_clean";
            this.btn_clean.Size = new System.Drawing.Size(101, 36);
            this.btn_clean.TabIndex = 14;
            this.btn_clean.Text = "Làm mới";
            this.btn_clean.UseVisualStyleBackColor = true;
            this.btn_clean.Click += new System.EventHandler(this.btn_clean_Click);
            // 
            // btn_xoa
            // 
            this.btn_xoa.Location = new System.Drawing.Point(880, 214);
            this.btn_xoa.Name = "btn_xoa";
            this.btn_xoa.Size = new System.Drawing.Size(83, 36);
            this.btn_xoa.TabIndex = 13;
            this.btn_xoa.Text = "Xóa";
            this.btn_xoa.UseVisualStyleBackColor = true;
            this.btn_xoa.Click += new System.EventHandler(this.btn_xoa_Click);
            // 
            // btn_cap_nhat
            // 
            this.btn_cap_nhat.Location = new System.Drawing.Point(703, 214);
            this.btn_cap_nhat.Name = "btn_cap_nhat";
            this.btn_cap_nhat.Size = new System.Drawing.Size(108, 36);
            this.btn_cap_nhat.TabIndex = 12;
            this.btn_cap_nhat.Text = "Cập nhật";
            this.btn_cap_nhat.UseVisualStyleBackColor = true;
            this.btn_cap_nhat.Click += new System.EventHandler(this.btn_cap_nhat_Click);
            // 
            // btn_them
            // 
            this.btn_them.Location = new System.Drawing.Point(570, 214);
            this.btn_them.Name = "btn_them";
            this.btn_them.Size = new System.Drawing.Size(83, 36);
            this.btn_them.TabIndex = 10;
            this.btn_them.Text = "Thêm";
            this.btn_them.UseVisualStyleBackColor = true;
            this.btn_them.Click += new System.EventHandler(this.btn_them_Click);
            // 
            // nHANVIENTableAdapter
            // 
            this.nHANVIENTableAdapter.ClearBeforeFill = true;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(661, 56);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(140, 22);
            this.label5.TabIndex = 2;
            this.label5.Text = "Tên tài khoản";
            // 
            // cbb_bo_loc
            // 
            this.cbb_bo_loc.FormattingEnabled = true;
            this.cbb_bo_loc.Items.AddRange(new object[] {
            "Username",
            "Mã nhân viên"});
            this.cbb_bo_loc.Location = new System.Drawing.Point(840, 102);
            this.cbb_bo_loc.Name = "cbb_bo_loc";
            this.cbb_bo_loc.Size = new System.Drawing.Size(253, 30);
            this.cbb_bo_loc.TabIndex = 10;
            // 
            // tb_tim_kiem
            // 
            this.tb_tim_kiem.Location = new System.Drawing.Point(840, 46);
            this.tb_tim_kiem.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tb_tim_kiem.Name = "tb_tim_kiem";
            this.tb_tim_kiem.Size = new System.Drawing.Size(253, 30);
            this.tb_tim_kiem.TabIndex = 14;
            this.tb_tim_kiem.TextChanged += new System.EventHandler(this.tb_tim_kiem_TextChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(661, 110);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(70, 22);
            this.label6.TabIndex = 15;
            this.label6.Text = "Bộ lọc";
            // 
            // label10
            // 
            this.label10.Font = new System.Drawing.Font("JetBrains Mono", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Image = ((System.Drawing.Image)(resources.GetObject("label10.Image")));
            this.label10.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label10.Location = new System.Drawing.Point(634, 145);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(476, 22);
            this.label10.TabIndex = 31;
            this.label10.Text = "Lưu ý: Bạn hãy chọn bộ lọc trước khi tìm kiếm nhé!\r\n";
            this.label10.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // QuanLyTaiKhoan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 22F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1148, 573);
            this.Controls.Add(this.btn_clean);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.btn_xoa);
            this.Controls.Add(this.btn_cap_nhat);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.btn_them);
            this.Controls.Add(this.tb_tim_kiem);
            this.Controls.Add(this.cbb_bo_loc);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.dgv_tai_khoan);
            this.Font = new System.Drawing.Font("JetBrains Mono", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "QuanLyTaiKhoan";
            this.Text = "Quản lý tài khoản";
            this.Load += new System.EventHandler(this.QuanLyTaiKhoan_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_tai_khoan)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nHANVIENBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.quanLyThuVienDataSet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgv_tai_khoan;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox tb_mk;
        private System.Windows.Forms.TextBox tb_ten_tk;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cbb_ma_nv;
        private System.Windows.Forms.ComboBox cbb_quyen;
        private QuanLyThuVienDataSet quanLyThuVienDataSet;
        private System.Windows.Forms.BindingSource nHANVIENBindingSource;
        private QuanLyThuVienDataSetTableAdapters.NHANVIENTableAdapter nHANVIENTableAdapter;
        private System.Windows.Forms.Button btn_xoa;
        private System.Windows.Forms.Button btn_cap_nhat;
        private System.Windows.Forms.Button btn_them;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox cbb_bo_loc;
        private System.Windows.Forms.TextBox tb_tim_kiem;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btn_clean;
        private System.Windows.Forms.Label label10;
    }
}