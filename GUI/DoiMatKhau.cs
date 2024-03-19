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
    public partial class DoiMatKhau : Form
    {
        TaiKhoanBUS taiKhoanBUS = new TaiKhoanBUS();
        public DoiMatKhau()
        {
            InitializeComponent();
        }

        private void DoiMatKhau_Load(object sender, EventArgs e)
        {
            DataSet dataSet = taiKhoanBUS.getTaiKhoanDataDMK(Properties.Settings.Default.taiKhoan, Properties.Settings.Default.matKhau);

            if (dataSet.Tables.Count > 0 && dataSet.Tables[0].Rows.Count > 0) 
            {
                tb_ten_tai_khoan.Text = dataSet.Tables[0].Rows[0]["sUserName"].ToString();
            }
        }

        private void btn_doi_mat_khau_Click(object sender, EventArgs e)
        {
            string tenTK = tb_ten_tai_khoan.Text;
            string matKhau = tb_mat_khau_moi.Text;
            string nhapLaiMK = tb_nhap_lai_mk.Text;

            if (tb_mat_khau_moi.Text != "" && tb_nhap_lai_mk.Text != "")
            {
                if(matKhau == nhapLaiMK)
                {
                    int res = taiKhoanBUS.doiMatKhau(tenTK, matKhau);
                    if (res > 0) {
                        MessageBox.Show("Cập nhật mật khẩu thành công");
                    }
                    else
                    {
                        MessageBox.Show("Cập nhật mật khẩu thất bại");
                    }
                }
                else
                {
                    MessageBox.Show("Mật khẩu không khớp");
                }
            }
            else
            {
                MessageBox.Show("Vui lòng nhập đủ thông tin");
            }
        }
    }
}
