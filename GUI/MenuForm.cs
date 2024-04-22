using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BUS;
namespace GUI
{
    public partial class MenuForm : Form
    {
        TaiKhoanBUS taiKhoanBUS = new TaiKhoanBUS();
        public MenuForm()
        {
            InitializeComponent();
        }

        public void MenuForm_Load(object sender, EventArgs e)
        {
            WellCome wellCome = new WellCome();
            addForm(wellCome);

            DataSet dataSet = taiKhoanBUS.checkQuyen(Properties.Settings.Default.taiKhoan, Properties.Settings.Default.matKhau);
            if (dataSet.Tables[0].Rows.Count > 0)
            {

            }
            else
            {
                NhanVienToolStripMenuItem.Visible = false;
                TKToolStripMenuItem.Visible = false;
            }
        }

        private void addForm(Form f)
        {
            this.panelContent.Controls.Clear();
            f.TopLevel = false;
            f.AutoScroll = true;
            f.Dock = DockStyle.Fill;
            this.Text = f.Text;
            this.panelContent.Controls.Add(f);
            f.FormBorderStyle = FormBorderStyle.None;
            f.Show();
        }

        private void NhanVienToolStripMenuItem_Click(object sender, EventArgs e)
        {
            NhanVienForm nhanVienForm = new NhanVienForm();
            addForm(nhanVienForm);
        }

        private void ThoatToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Bạn có chắc chắn thoát", "???", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if(result == DialogResult.Yes)
            {
               Application.Exit();
            }
            else
            {

            }
        }

        private void SachToolStripMenuItem_Click(object sender, EventArgs e)
        {
          
            SachForm sachForm = new SachForm();
            addForm(sachForm);
        }

        private void homeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            WellCome wellCome = new WellCome();
            addForm(wellCome);
        }

        private void InforToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ThongTinTaiKhoanForm f = new ThongTinTaiKhoanForm();
            addForm(f);
        }

        private void DangXuatToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DangNhapForm f = new DangNhapForm();
            
           this.Close();
            f.Show();
        }

        private void DoiMatKhauToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DoiMatKhau doiMatKhau = new DoiMatKhau();
            addForm(doiMatKhau);
        }

        private void HDSDToolStripMenuItem_Click(object sender, EventArgs e)
        {
            HDSD f = new HDSD();
            addForm(f);
        }

        private void TKToolStripMenuItem_Click(object sender, EventArgs e)
        {
            QuanLyTaiKhoan f = new QuanLyTaiKhoan();
            addForm(f);
        }

        private void DocGiaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DocGiaForm docGiaForm = new DocGiaForm();
            addForm(docGiaForm);
        }

        private void panelContent_Paint(object sender, PaintEventArgs e)
        {

        }

        private void tácGiảToolStripMenuItem_Click(object sender, EventArgs e)
        {
            TacGiafrm f = new TacGiafrm();
            addForm(f);
        }

        private void phiếuMượnToolStripMenuItem_Click(object sender, EventArgs e)
        {
            PhieuMuonFrm frm = new PhieuMuonFrm();
            addForm(frm);
        }

        private void phiếuTrảToolStripMenuItem_Click(object sender, EventArgs e)
        {
            PhieuTraForm frm = new PhieuTraForm();
            addForm(frm);
        }
    }
}
