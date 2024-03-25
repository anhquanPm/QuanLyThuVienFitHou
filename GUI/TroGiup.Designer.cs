namespace GUI
{
    partial class HDSD
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(HDSD));
            this.label1 = new System.Windows.Forms.Label();
            this.lb_hdsd = new System.Windows.Forms.Label();
            this.btn_hdsd = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lb_tacgia = new System.Windows.Forms.Label();
            this.btn_lhtg = new System.Windows.Forms.Button();
            this.lb_lienhe = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(148, 87);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 22);
            this.label1.TabIndex = 0;
            // 
            // lb_hdsd
            // 
            this.lb_hdsd.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lb_hdsd.AutoSize = true;
            this.lb_hdsd.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lb_hdsd.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_hdsd.ForeColor = System.Drawing.Color.Black;
            this.lb_hdsd.Location = new System.Drawing.Point(208, 258);
            this.lb_hdsd.Name = "lb_hdsd";
            this.lb_hdsd.Size = new System.Drawing.Size(338, 23);
            this.lb_hdsd.TabIndex = 1;
            this.lb_hdsd.Text = "Bấm vào nút để xem hướng dẫn sử dụng";
            // 
            // btn_hdsd
            // 
            this.btn_hdsd.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btn_hdsd.Image = ((System.Drawing.Image)(resources.GetObject("btn_hdsd.Image")));
            this.btn_hdsd.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_hdsd.Location = new System.Drawing.Point(619, 253);
            this.btn_hdsd.Name = "btn_hdsd";
            this.btn_hdsd.Size = new System.Drawing.Size(129, 33);
            this.btn_hdsd.TabIndex = 2;
            this.btn_hdsd.Text = "Xem HDSD";
            this.btn_hdsd.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_hdsd.UseVisualStyleBackColor = true;
            this.btn_hdsd.Click += new System.EventHandler(this.btn_hdsd_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("groupBox1.BackgroundImage")));
            this.groupBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.groupBox1.Controls.Add(this.lb_tacgia);
            this.groupBox1.Controls.Add(this.btn_lhtg);
            this.groupBox1.Controls.Add(this.lb_lienhe);
            this.groupBox1.Controls.Add(this.btn_hdsd);
            this.groupBox1.Controls.Add(this.lb_hdsd);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox1.Location = new System.Drawing.Point(0, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1000, 619);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            // 
            // lb_tacgia
            // 
            this.lb_tacgia.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lb_tacgia.AutoSize = true;
            this.lb_tacgia.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lb_tacgia.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_tacgia.Location = new System.Drawing.Point(414, 74);
            this.lb_tacgia.Name = "lb_tacgia";
            this.lb_tacgia.Size = new System.Drawing.Size(245, 23);
            this.lb_tacgia.TabIndex = 5;
            this.lb_tacgia.Text = "Phát triển bởi Trần Anh Quân";
            // 
            // btn_lhtg
            // 
            this.btn_lhtg.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btn_lhtg.Image = ((System.Drawing.Image)(resources.GetObject("btn_lhtg.Image")));
            this.btn_lhtg.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_lhtg.Location = new System.Drawing.Point(619, 315);
            this.btn_lhtg.Name = "btn_lhtg";
            this.btn_lhtg.Size = new System.Drawing.Size(192, 33);
            this.btn_lhtg.TabIndex = 4;
            this.btn_lhtg.Text = "Liên hệ Tác giả";
            this.btn_lhtg.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_lhtg.UseVisualStyleBackColor = true;
            this.btn_lhtg.Click += new System.EventHandler(this.btn_lhtg_Click);
            // 
            // lb_lienhe
            // 
            this.lb_lienhe.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lb_lienhe.AutoSize = true;
            this.lb_lienhe.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lb_lienhe.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_lienhe.Location = new System.Drawing.Point(208, 320);
            this.lb_lienhe.Name = "lb_lienhe";
            this.lb_lienhe.Size = new System.Drawing.Size(358, 23);
            this.lb_lienhe.TabIndex = 3;
            this.lb_lienhe.Text = "Bấm vào nút để liên hệ trực tiếp với tác giả";
            // 
            // HDSD
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 22F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1000, 619);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("JetBrains Mono", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "HDSD";
            this.Text = "Hướng dẫn sử dụng";
            this.Load += new System.EventHandler(this.TroGiup_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lb_hdsd;
        private System.Windows.Forms.Button btn_hdsd;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btn_lhtg;
        private System.Windows.Forms.Label lb_lienhe;
        private System.Windows.Forms.Label lb_tacgia;
    }
}