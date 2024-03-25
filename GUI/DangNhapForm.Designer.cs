namespace GUI
{
    partial class DangNhapForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DangNhapForm));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.chk_save = new System.Windows.Forms.CheckBox();
            this.btn_thoat = new System.Windows.Forms.Button();
            this.btn_dang_nhap = new System.Windows.Forms.Button();
            this.tb_mat_khau = new System.Windows.Forms.TextBox();
            this.tb_tai_khoan = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(41, 67);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(140, 22);
            this.label1.TabIndex = 0;
            this.label1.Text = "Tên đăng nhập";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(41, 126);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(90, 22);
            this.label2.TabIndex = 1;
            this.label2.Text = "Mật khẩu";
            // 
            // chk_save
            // 
            this.chk_save.AutoSize = true;
            this.chk_save.Location = new System.Drawing.Point(198, 186);
            this.chk_save.Name = "chk_save";
            this.chk_save.Size = new System.Drawing.Size(162, 26);
            this.chk_save.TabIndex = 4;
            this.chk_save.Text = "Nhớ đăng nhập";
            this.chk_save.UseVisualStyleBackColor = true;
            this.chk_save.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // btn_thoat
            // 
            this.btn_thoat.Location = new System.Drawing.Point(342, 231);
            this.btn_thoat.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btn_thoat.Name = "btn_thoat";
            this.btn_thoat.Size = new System.Drawing.Size(94, 31);
            this.btn_thoat.TabIndex = 3;
            this.btn_thoat.Text = "Thoát";
            this.btn_thoat.UseVisualStyleBackColor = true;
            this.btn_thoat.Click += new System.EventHandler(this.btn_thoat_Click);
            // 
            // btn_dang_nhap
            // 
            this.btn_dang_nhap.Location = new System.Drawing.Point(94, 231);
            this.btn_dang_nhap.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btn_dang_nhap.Name = "btn_dang_nhap";
            this.btn_dang_nhap.Size = new System.Drawing.Size(114, 31);
            this.btn_dang_nhap.TabIndex = 2;
            this.btn_dang_nhap.Text = "Đăng nhập";
            this.btn_dang_nhap.UseVisualStyleBackColor = true;
            this.btn_dang_nhap.Click += new System.EventHandler(this.btn_dang_nhap_Click);
            // 
            // tb_mat_khau
            // 
            this.tb_mat_khau.Location = new System.Drawing.Point(198, 126);
            this.tb_mat_khau.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tb_mat_khau.Name = "tb_mat_khau";
            this.tb_mat_khau.Size = new System.Drawing.Size(257, 30);
            this.tb_mat_khau.TabIndex = 1;
            this.tb_mat_khau.UseSystemPasswordChar = true;
            this.tb_mat_khau.TextChanged += new System.EventHandler(this.tb_mat_khau_TextChanged);
            // 
            // tb_tai_khoan
            // 
            this.tb_tai_khoan.Location = new System.Drawing.Point(198, 67);
            this.tb_tai_khoan.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tb_tai_khoan.Name = "tb_tai_khoan";
            this.tb_tai_khoan.Size = new System.Drawing.Size(257, 30);
            this.tb_tai_khoan.TabIndex = 0;
            this.tb_tai_khoan.TextChanged += new System.EventHandler(this.tb_tai_khoan_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("JetBrains Mono", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label3.Location = new System.Drawing.Point(300, 30);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(223, 30);
            this.label3.TabIndex = 4;
            this.label3.Text = "THƯ VIỆN FITHOU";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(4, 28);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(214, 229);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.pictureBox1);
            this.groupBox2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.groupBox2.Location = new System.Drawing.Point(14, 99);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox2.Size = new System.Drawing.Size(222, 262);
            this.groupBox2.TabIndex = 3;
            this.groupBox2.TabStop = false;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.chk_save);
            this.groupBox1.Controls.Add(this.btn_thoat);
            this.groupBox1.Controls.Add(this.btn_dang_nhap);
            this.groupBox1.Controls.Add(this.tb_mat_khau);
            this.groupBox1.Controls.Add(this.tb_tai_khoan);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.groupBox1.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.groupBox1.Location = new System.Drawing.Point(246, 99);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox1.Size = new System.Drawing.Size(531, 285);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Thông tin đăng nhập";
            // 
            // DangNhapForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 22F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoValidate = System.Windows.Forms.AutoValidate.EnableAllowFocusChange;
            this.ClientSize = new System.Drawing.Size(798, 398);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("JetBrains Mono", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.MaximizeBox = false;
            this.Name = "DangNhapForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Đăng nhập";
            this.Load += new System.EventHandler(this.DangNhapForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tb_mat_khau;
        private System.Windows.Forms.TextBox tb_tai_khoan;
        private System.Windows.Forms.Button btn_thoat;
        private System.Windows.Forms.Button btn_dang_nhap;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.CheckBox chk_save;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox1;
    }
}

