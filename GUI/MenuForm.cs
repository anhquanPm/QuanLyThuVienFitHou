using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GUI
{
    public partial class MenuForm : Form
    {
        public MenuForm()
        {
            InitializeComponent();
        }

        private void MenuForm_Load(object sender, EventArgs e)
        {
            WellCome wellCome = new WellCome();
            addForm(wellCome);
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
            Close();
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
    }
}
