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
    public partial class QuanLyTaiKhoan : Form
    {
        TaiKhoanBUS taiKhoanBUS = new TaiKhoanBUS();
        public QuanLyTaiKhoan()
        {
            InitializeComponent();
            InitializeDataGridView();
        }

        private void InitializeDataGridView()
        {
            // Thêm các cột vào DataGridView
            dgv_tai_khoan.ColumnCount = 4;
            dgv_tai_khoan.Columns[0].Name = "Tên tài khoản";
            dgv_tai_khoan.Columns[1].Name = "Mật khẩu";
            dgv_tai_khoan.Columns[2].Name = "Mã nhân viên";
            dgv_tai_khoan.Columns[3].Name = "Quyền";
            

            // Không cho phép chỉnh sửa dữ liệu trực tiếp trên DataGridView
            dgv_tai_khoan.ReadOnly = true;
            // Cài đặt chế độ hiển thị dữ liệu đầy đủ trên DataGridView
            dgv_tai_khoan.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgv_tai_khoan.AllowUserToAddRows = false;
        }

        private void QuanLyTaiKhoan_Load(object sender, EventArgs e)
        {
            tb_ten_tk.Enabled = false;
            // TODO: This line of code loads data into the 'quanLyThuVienDataSet.NHANVIEN' table. You can move, or remove it, as needed.
            this.nHANVIENTableAdapter.Fill(this.quanLyThuVienDataSet.NHANVIEN);
            DataSet dataSet = taiKhoanBUS.quanLyTaiKhoan();

            dgv_tai_khoan.Rows.Clear();
            if (dataSet.Tables[0].Rows.Count > 0 && dataSet.Tables.Count > 0)
            {
                foreach (DataRow row in dataSet.Tables[0].Rows)
                {
                    // Thêm dữ liệu từ mỗi dòng của DataSet vào DataGridView
                    dgv_tai_khoan.Rows.Add(row.ItemArray);
                }
            }
            else
            {
                MessageBox.Show("Không có dữ liệu để hiển thị");
            }
        }

        private void loadTaiKhoan()
        {
            DataSet dataSet = taiKhoanBUS.quanLyTaiKhoan();

            dgv_tai_khoan.Rows.Clear();
            if (dataSet.Tables[0].Rows.Count > 0 && dataSet.Tables.Count > 0)
            {
                foreach (DataRow row in dataSet.Tables[0].Rows)
                {
                    // Thêm dữ liệu từ mỗi dòng của DataSet vào DataGridView
                    dgv_tai_khoan.Rows.Add(row.ItemArray);
                }
            }
            else
            {
                MessageBox.Show("Không có dữ liệu để hiển thị");
            }
        }

        private void dgv_tai_khoan_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            tb_ten_tk.Enabled = false;
            int rowIndex = e.RowIndex;
            if(rowIndex >= 0 && rowIndex <= dgv_tai_khoan.Rows.Count ) 
            {
                DataGridViewRow selectedRow = dgv_tai_khoan.Rows[rowIndex];
                tb_ten_tk.Text = selectedRow.Cells["Tên tài khoản"].Value.ToString();
                tb_mk.Text = selectedRow.Cells["Mật khẩu"].Value.ToString();
                cbb_ma_nv.Text = selectedRow.Cells["Mã nhân viên"].Value.ToString();
                cbb_quyen.Text = selectedRow.Cells["Quyền"].Value.ToString();
                if (cbb_quyen.Text == "False")
                {
                    cbb_quyen.Text = "Nhân viên";
                }else if(cbb_quyen.Text == "True")
                {
                    cbb_quyen.Text = "Quản lý";
                }
               
            }
        }

        private void btn_them_Click(object sender, EventArgs e)
        {
            if (tb_ten_tk.Text.Trim() != "" &&
                tb_mk.Text.Trim() != "" &&
                cbb_ma_nv.Text.Trim() != "" &&
                cbb_quyen.Text.Trim() != "")
            {
                string user = tb_ten_tk.Text;
                string pass = tb_mk.Text;
                string manv = cbb_ma_nv.Text;
                string quyen = cbb_quyen.Text;
                bool bquyen = false;
                if (quyen == "Quản lý")
                {
                    bquyen = true;
                }
                else if (quyen == "Nhân viên")
                {
                    bquyen = false;
                }

                int res = taiKhoanBUS.themTaiKhoan(user, pass, manv ,bquyen);

                if (res > 0)
                {
                    MessageBox.Show("Thêm tài khoản thành công");
                    loadTaiKhoan();
                    tb_ten_tk.Enabled = false;
                }
                else
                {
                    MessageBox.Show("Thêm tài khoản thất bại");
                }
            }
            else
            {
                MessageBox.Show("Vui lòng nhập đủ thông tin");
            }

        }

        private void btn_cap_nhat_Click(object sender, EventArgs e)
        {
            if(tb_ten_tk.Text.Trim() != "" &&
                tb_mk.Text.Trim() != "" &&
                cbb_ma_nv.Text.Trim() != "" &&
                cbb_quyen.Text.Trim() != "")
            {
                string user = tb_ten_tk.Text;
                string pass = tb_mk.Text;
                string quyen = cbb_quyen.Text;
                bool bquyen = false;
                if(quyen == "Quản lý")
                {
                    bquyen = true;
                }else if(quyen == "Nhân viên")
                {
                    bquyen = false;
                }

                int res = taiKhoanBUS.capNhatTaiKhoan(user, pass, bquyen);

                if(res > 0)
                {
                    MessageBox.Show("Cập nhật thông tin thành công");
                    loadTaiKhoan();
                    DataSet check = taiKhoanBUS.checkQuyen(Properties.Settings.Default.taiKhoan,
                        Properties.Settings.Default.matKhau);

                    if (check.Tables[0].Rows.Count > 0)
                    {

                    }
                    else
                    {
                        
                        MessageBox.Show("Phiên đăng nhập của bạn đã hết hạn");
                        Application.Exit();
                    }
                    
               
                }
                else
                {
                    MessageBox.Show("Cập nhật thông tin thất bại");
                }
            }
            else
            {
                MessageBox.Show("Vui lòng nhập đủ thông tin");
            }
        }

        private void btn_clean_Click(object sender, EventArgs e)
        {
            if (tb_ten_tk.Text.Trim() != "" ||
                tb_mk.Text.Trim() != "" ||
                cbb_ma_nv.Text.Trim() != "" ||
                cbb_quyen.Text.Trim() != "")
            {
                tb_ten_tk.Enabled = true;
                tb_ten_tk.Text = "";
                tb_mk.Text = "";
                cbb_ma_nv.Text = "";
                cbb_quyen.Text = "";
            }
            else
            {
                MessageBox.Show("Dữ liệu đang trống");
            }
        }

        private void btn_xoa_Click(object sender, EventArgs e)
        {
            if(tb_ten_tk.Text.Trim() != "")
            {

                DialogResult result = MessageBox.Show("Bạn có chắc chắn muốn xóa tài khoản có UserName là: " + tb_ten_tk.Text + " không ?",
                    "???", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if(result == DialogResult.Yes)
                {
                    int res = taiKhoanBUS.xoaTaiKhoan(tb_ten_tk.Text.Trim());

                    if (res > 0)
                    {
                        MessageBox.Show("Xoá tài khoản thành công");
                        tb_ten_tk.Text = "";
                        tb_mk.Text = "";
                        cbb_ma_nv.Text = "";
                        cbb_quyen.Text = "";
                        loadTaiKhoan();
                    }
                    else
                    {
                        MessageBox.Show("Xóa tài khoản thất bại");
                    }
                }
                else
                {

                }
            }
            else
            {
                MessageBox.Show("Vui lòng chọn nhân viên trước khi xóa");
            }
        }

        private void tb_tim_kiem_TextChanged(object sender, EventArgs e)
        {
            if(cbb_bo_loc.Text == "Mã nhân viên")
            {
                DataSet data = taiKhoanBUS.timKiemTaiKhoanTheoMaNV(tb_tim_kiem.Text.Trim());
                dgv_tai_khoan.Rows.Clear();

                foreach (DataRow row in data.Tables[0].Rows)
                {
                    // Thêm dữ liệu từ mỗi dòng của DataSet vào DataGridView
                    dgv_tai_khoan.Rows.Add(row.ItemArray);
                }

            }else if(cbb_bo_loc.Text == "Username")
            {
                DataSet data = taiKhoanBUS.timKiemTaiKhoanTheoUser(tb_tim_kiem.Text.Trim());
                dgv_tai_khoan.Rows.Clear();
                foreach (DataRow row in data.Tables[0].Rows)
                {
                    // Thêm dữ liệu từ mỗi dòng của DataSet vào DataGridView
                    dgv_tai_khoan.Rows.Add(row.ItemArray);
                }
            }

        }
    }
}
