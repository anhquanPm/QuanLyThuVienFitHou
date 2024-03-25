namespace GUI
{
    partial class DoiMatKhau
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
            this.tb_ten_tai_khoan = new System.Windows.Forms.TextBox();
            this.btn_doi_mat_khau = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label3 = new System.Windows.Forms.Label();
            this.tb_nhap_lai_mk = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.tb_mat_khau_moi = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(251, 104);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(140, 22);
            this.label1.TabIndex = 0;
            this.label1.Text = "Tên tài khoản";
            // 
            // tb_ten_tai_khoan
            // 
            this.tb_ten_tai_khoan.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.tb_ten_tai_khoan.Enabled = false;
            this.tb_ten_tai_khoan.Location = new System.Drawing.Point(474, 101);
            this.tb_ten_tai_khoan.Name = "tb_ten_tai_khoan";
            this.tb_ten_tai_khoan.Size = new System.Drawing.Size(255, 30);
            this.tb_ten_tai_khoan.TabIndex = 1;
            // 
            // btn_doi_mat_khau
            // 
            this.btn_doi_mat_khau.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btn_doi_mat_khau.Location = new System.Drawing.Point(474, 283);
            this.btn_doi_mat_khau.Name = "btn_doi_mat_khau";
            this.btn_doi_mat_khau.Size = new System.Drawing.Size(139, 38);
            this.btn_doi_mat_khau.TabIndex = 4;
            this.btn_doi_mat_khau.Text = "Đổi mật khẩu";
            this.btn_doi_mat_khau.UseVisualStyleBackColor = true;
            this.btn_doi_mat_khau.Click += new System.EventHandler(this.btn_doi_mat_khau_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.tb_nhap_lai_mk);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.tb_mat_khau_moi);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.btn_doi_mat_khau);
            this.groupBox1.Controls.Add(this.tb_ten_tai_khoan);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox1.Location = new System.Drawing.Point(0, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1000, 430);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(251, 211);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(220, 22);
            this.label3.TabIndex = 5;
            this.label3.Text = "Nhập lại mật khẩu mới";
            // 
            // tb_nhap_lai_mk
            // 
            this.tb_nhap_lai_mk.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.tb_nhap_lai_mk.Location = new System.Drawing.Point(474, 205);
            this.tb_nhap_lai_mk.Name = "tb_nhap_lai_mk";
            this.tb_nhap_lai_mk.Size = new System.Drawing.Size(255, 30);
            this.tb_nhap_lai_mk.TabIndex = 3;
            this.tb_nhap_lai_mk.UseSystemPasswordChar = true;
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(251, 156);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(130, 22);
            this.label2.TabIndex = 3;
            this.label2.Text = "Mật khẩu mới";
            // 
            // tb_mat_khau_moi
            // 
            this.tb_mat_khau_moi.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.tb_mat_khau_moi.Location = new System.Drawing.Point(474, 149);
            this.tb_mat_khau_moi.Name = "tb_mat_khau_moi";
            this.tb_mat_khau_moi.Size = new System.Drawing.Size(255, 30);
            this.tb_mat_khau_moi.TabIndex = 2;
            this.tb_mat_khau_moi.UseSystemPasswordChar = true;
            // 
            // DoiMatKhau
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 22F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1000, 430);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("JetBrains Mono", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "DoiMatKhau";
            this.Text = "Đổi mật khẩu";
            this.Load += new System.EventHandler(this.DoiMatKhau_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tb_ten_tai_khoan;
        private System.Windows.Forms.Button btn_doi_mat_khau;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tb_mat_khau_moi;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tb_nhap_lai_mk;
    }
}