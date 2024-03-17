using System;
using System.Windows.Forms;
using BUS;
using DTO;
namespace GUI
{
    public partial class DangNhapForm : Form
    {
        TaiKhoan taiKhoan = new TaiKhoan();
        TaiKhoanBUS taiKhoanBUS = new TaiKhoanBUS();
        public DangNhapForm()
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

            // MessageBox.Show("Đăng nhập thành công ");
            MenuForm menuForm = new MenuForm();
            menuForm.Show(this);
            this.Hide();
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if(tb_tai_khoan.Text != "" && tb_mat_khau.Text != "")
            {
                if (chk_save.Checked == true)
                {
                    string taiKhoan = tb_tai_khoan.Text.Trim();
                    string matKhau = tb_mat_khau.Text.Trim();
                    Properties.Settings.Default.taiKhoan = taiKhoan;
                    Properties.Settings.Default.matKhau = matKhau;

                    Properties.Settings.Default.Save();
                }
                else
                {
                    Properties.Settings.Default.Reset();
                }
            }
       
        }

        private void DangNhapForm_Load(object sender, EventArgs e)
        {
            tb_tai_khoan.Text = Properties.Settings.Default.taiKhoan;
            tb_mat_khau.Text = Properties.Settings.Default.matKhau;
            if(tb_tai_khoan.Text != "" && tb_mat_khau.Text != "")
            {
                chk_save.Checked = true;
            }
        }
    }
}
