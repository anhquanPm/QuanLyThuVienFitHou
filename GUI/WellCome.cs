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
    public partial class WellCome : Form
    {
        TaiKhoanBUS taiKhoanBUS = new TaiKhoanBUS();
       
        public WellCome()
        {
            InitializeComponent();
          
        }

        private void WellCome_Load(object sender, EventArgs e)
        {
            DataSet data = taiKhoanBUS.checkQuyen(Properties.Settings.Default.taiKhoan, Properties.Settings.Default.matKhau);
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
