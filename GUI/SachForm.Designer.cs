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
            this.dgv_sach = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_sach)).BeginInit();
            this.SuspendLayout();
            // 
            // dgv_sach
            // 
            this.dgv_sach.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgv_sach.BackgroundColor = System.Drawing.SystemColors.Menu;
            this.dgv_sach.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_sach.Location = new System.Drawing.Point(-3, 324);
            this.dgv_sach.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.dgv_sach.Name = "dgv_sach";
            this.dgv_sach.RowHeadersWidth = 51;
            this.dgv_sach.RowTemplate.Height = 24;
            this.dgv_sach.Size = new System.Drawing.Size(886, 323);
            this.dgv_sach.TabIndex = 2;
            // 
            // SachForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 23F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(882, 646);
            this.Controls.Add(this.dgv_sach);
            this.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.Name = "SachForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Quản lý sách";
            this.Load += new System.EventHandler(this.SachForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_sach)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgv_sach;
    }
}