using System;
using System.Windows.Forms;
using BUS;
using DTO;
namespace GUI
{
    public partial class Form1 : Form
    {
        TaiKhoan taiKhoan = new TaiKhoan();
        TaiKhoanBUS taiKhoanBUS = new TaiKhoanBUS();
        public Form1()
        {
            InitializeComponent();
        }

        private void btn_thoat_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btn_dang_nhap_Click(object sender, EventArgs e)
        {
            taiKhoan.SUserName = tb_tai_khoan.Text;
            taiKhoan.SPassWord = tb_mat_khau.Text;

            string getUser = taiKhoanBUS.checkLogin(taiKhoan);
            // trả lại kết quả nghiệp vụ không đúng
            switch(getUser)
            {
                case "requeid_taiKhoan": 
                    MessageBox.Show("Tài khoản không được để trống");
                    return;
                case "requeid_matKhau":
                    MessageBox.Show("Mật khẩu không được để trống");
                    return;
                case "Tài khoản hoặc mật khẩu không chính xác !":
                    MessageBox.Show("Tài khoản hoặc mật khẩu không chính xác !");
                    return;
            }

            MessageBox.Show("Đăng nhập thành công ");
        }
    }
}
