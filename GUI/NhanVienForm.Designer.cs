namespace GUI
{
    partial class NhanVienForm
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
            this.btn_get = new System.Windows.Forms.Button();
            this.dgv_nhan_vien = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_nhan_vien)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_get
            // 
            this.btn_get.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_get.Location = new System.Drawing.Point(597, 29);
            this.btn_get.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btn_get.Name = "btn_get";
            this.btn_get.Size = new System.Drawing.Size(83, 47);
            this.btn_get.TabIndex = 0;
            this.btn_get.Text = "Get";
            this.btn_get.UseVisualStyleBackColor = true;
            this.btn_get.Click += new System.EventHandler(this.btn_get_Click);
            // 
            // dgv_nhan_vien
            // 
            this.dgv_nhan_vien.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgv_nhan_vien.BackgroundColor = System.Drawing.SystemColors.Menu;
            this.dgv_nhan_vien.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_nhan_vien.Location = new System.Drawing.Point(0, 331);
            this.dgv_nhan_vien.Name = "dgv_nhan_vien";
            this.dgv_nhan_vien.RowHeadersWidth = 51;
            this.dgv_nhan_vien.RowTemplate.Height = 24;
            this.dgv_nhan_vien.Size = new System.Drawing.Size(702, 230);
            this.dgv_nhan_vien.TabIndex = 1;
            // 
            // NhanVienForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 23F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(703, 561);
            this.Controls.Add(this.dgv_nhan_vien);
            this.Controls.Add(this.btn_get);
            this.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "NhanVienForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Quản lý nhân viên";
            this.Load += new System.EventHandler(this.NhanVienForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_nhan_vien)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btn_get;
        private System.Windows.Forms.DataGridView dgv_nhan_vien;
    }
}