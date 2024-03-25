using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GUI
{
    public partial class HDSD : Form
    {
        private Timer labelTimer = new Timer();
        private bool isLabelBlinking = false;
        public HDSD()
        {
            InitializeComponent();
            InitializeLabelTimer();
            StartLabelBlink(); // Bắt đầu nhấp nháy khi form được tạo
        }

        private void InitializeLabelTimer()
        {
            labelTimer.Interval = 200; // Đặt thời gian nhấp nháy (500ms = 0.5 giây)
            labelTimer.Tick += LabelTimer_Tick;
        }

        private void LabelTimer_Tick(object sender, EventArgs e)
        {
            // Thay đổi màu sắc của Label giữa đỏ và đen
            lb_tacgia.ForeColor = (lb_tacgia.ForeColor == Color.Black) ? Color.Red : Color.Black;
            lb_hdsd.ForeColor = (lb_hdsd.ForeColor == Color.Black) ? Color.Red : Color.Black;
            lb_lienhe.ForeColor = (lb_lienhe.ForeColor == Color.Black) ? Color.Red : Color.Black;

        }

        private void StartLabelBlink()
        {
            labelTimer.Start(); // Bắt đầu nhấp nháy
            isLabelBlinking = true;
        }

        private void TroGiup_Load(object sender, EventArgs e)
        {
         
        }

        private void btn_hdsd_Click(object sender, EventArgs e)
        {
            string url = "";
            //Process.Start(url);
        }

        private void btn_lhtg_Click(object sender, EventArgs e)
        {
            string url = "https://www.facebook.com/2uanvy?locale=vi_VN";
            Process.Start(url);
        }
    }
}
