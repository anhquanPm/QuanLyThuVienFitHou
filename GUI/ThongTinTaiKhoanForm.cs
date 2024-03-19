using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DTO;
using BUS;
using GUI.Properties;
namespace GUI
{
    public partial class ThongTinTaiKhoanForm : Form
    {
        TaiKhoanBUS taiKhoanBUS = new TaiKhoanBUS();
        DangNhapForm dangNhapForm;
        public ThongTinTaiKhoanForm()
        {
            InitializeComponent();
        }

        private void ThongTinTaiKhoanForm_Load(object sender, EventArgs e)
        {
            DataSet data = taiKhoanBUS.getTaiKhoanData(Properties.Settings.Default.taiKhoan, Properties.Settings.Default.matKhau);

           

            if(data.Tables.Count > 0 && data.Tables[0].Rows.Count > 0)
            {
                tb_ma_nv.Text = data.Tables[0].Rows[0]["sMaNV"].ToString();
                tb_ten_nv.Text = data.Tables[0].Rows[0]["sTenNV"].ToString();

                if (data.Tables[0].Rows[0]["sGioiTinh"].ToString() == "Nam")
                {
                    rad_nam.Checked = true;
                }

                if(data.Tables[0].Rows[0]["sGioiTinh"].ToString() == "Nữ")
                {
                    rad_nu.Checked = true;
                }    

                tb_dia_chi.Text = data.Tables[0].Rows[0]["sDiaChi"].ToString();
                tb_sdt.Text = data.Tables[0].Rows[0]["sSdt"].ToString();
                string ngaySinhString = data.Tables[0].Rows[0]["dNgaySinh"].ToString();
                DateTime ngaySinh;
                if (DateTime.TryParse(ngaySinhString, out ngaySinh))
                {
                    dtp_ngay_sinh.CustomFormat = "dd/MM/yyyy"; // Định dạng hiển thị của DateTimePicker
                    dtp_ngay_sinh.Value = ngaySinh;
                }
                else
                {
                    // Xử lý trường hợp không thể chuyển đổi ngày tháng từ chuỗi
                }
            }

        }

        private void btn_cap_nhat_Click(object sender, EventArgs e)
        {
            string manv = tb_ma_nv.Text;
            string tennv = tb_ten_nv.Text;
            string gioitinh = rad_nam.Checked ? "Nam" : "Nữ";
            string diachi = tb_dia_chi.Text;
            string sdt = tb_sdt.Text;
            string ngaysinh = dtp_ngay_sinh.Value.ToString("yyyy-MM-dd"); // Chuyển định dạng ngày tháng về đúng định dạng cho ngày sinh
            int rowsAffected = taiKhoanBUS.updateTaiKhoanData(manv, tennv, gioitinh, diachi, sdt, ngaysinh);
            if(rowsAffected > 0) {
                MessageBox.Show("Cập nhật thông tin thành công");
            }
            else
            {
                MessageBox.Show("Cập nhật thông tin thất bại");
            }
        }
    }
}
