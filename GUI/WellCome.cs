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
        private Timer labelTimer = new Timer();
        private bool isLabelBlinking = false;
        public WellCome()
        {
            InitializeComponent();
            InitializeLabelTimer();
            StartLabelBlink(); // Bắt đầu nhấp nháy khi form được tạo
        }

        private void WellCome_Load(object sender, EventArgs e)
        {
            DataSet data = taiKhoanBUS.checkQuyen(Properties.Settings.Default.taiKhoan, Properties.Settings.Default.matKhau);

            if (data.Tables[0].Rows.Count > 0)
            {
                lb_chao.Text = "Chào ngài: ";
            }
            else
            {
                lb_chao.Text = "Xin chào: ";
            }

            DataSet dataSet = taiKhoanBUS.getTaiKhoanData(Properties.Settings.Default.taiKhoan, Properties.Settings.Default.matKhau);
            if (dataSet.Tables[0].Rows.Count > 0 )
            {
                lb_ten_ngui_dung.Text = dataSet.Tables[0].Rows[0]["sTenNV"].ToString();
            }

           
        }

        private void InitializeLabelTimer()
        {
            labelTimer.Interval = 200; // Đặt thời gian nhấp nháy (500ms = 0.5 giây)
            labelTimer.Tick += LabelTimer_Tick;
        }

        private void LabelTimer_Tick(object sender, EventArgs e)
        {
            // Thay đổi màu sắc của Label giữa đỏ và đen
            lb_chao.ForeColor = (lb_chao.ForeColor == Color.Black) ? Color.Red : Color.Black;
            lb_ten_ngui_dung.ForeColor = (lb_chao.ForeColor == Color.Black) ? Color.Red : Color.Black;
        }

        private void StartLabelBlink()
        {
            labelTimer.Start(); // Bắt đầu nhấp nháy
            isLabelBlinking = true;
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
