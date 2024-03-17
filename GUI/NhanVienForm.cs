using BUS;
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
using DTO;

namespace GUI
{
    public partial class NhanVienForm : Form
    {
        NhanVienBUS nhanVienBUS = new NhanVienBUS();
        public NhanVienForm()
        {
            InitializeComponent();
            InitializeDataGridView();
        }

        private void InitializeDataGridView()
        {
            // Thêm các cột vào DataGridView
            dgv_nhan_vien.ColumnCount = 7;
            dgv_nhan_vien.Columns[0].Name = "Mã nhân viên";
            dgv_nhan_vien.Columns[1].Name = "Tên nhân viên";
            dgv_nhan_vien.Columns[2].Name = "Giới tính";
            dgv_nhan_vien.Columns[3].Name = "Địa chỉ";
            dgv_nhan_vien.Columns[4].Name = "Số điện thoại";
            dgv_nhan_vien.Columns[5].Name = "Mã chức vụ";
            dgv_nhan_vien.Columns[6].Name = "Ngày sinh";

            // Không cho phép chỉnh sửa dữ liệu trực tiếp trên DataGridView
            dgv_nhan_vien.ReadOnly = true;
            // Cài đặt chế độ hiển thị dữ liệu đầy đủ trên DataGridView
            dgv_nhan_vien.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgv_nhan_vien.AllowUserToAddRows = false;
        }


        private void btn_get_Click(object sender, EventArgs e)
        {
           
                // Gọi phương thức GetNhanVienData từ đối tượng BUS để lấy dữ liệu
                DataSet dataSet = nhanVienBUS.GetNhanVienDAO();
                dgv_nhan_vien.Rows.Clear(); // Xóa dữ liệu cũ trước khi đổ dữ liệu mới

                // Kiểm tra nếu có dữ liệu trong DataSet
                if (dataSet.Tables.Count > 0 && dataSet.Tables[0].Rows.Count > 0)
                {
                    foreach (DataRow row in dataSet.Tables[0].Rows)
                    {
                        // Thêm dữ liệu từ mỗi dòng của DataSet vào DataGridView
                        dgv_nhan_vien.Rows.Add(row.ItemArray);
                    }
                }
                else
                {
                    MessageBox.Show("Không có dữ liệu để hiển thị.");
                }
            }

        private void NhanVienForm_Load(object sender, EventArgs e)
        {
            DataSet dataSet = nhanVienBUS.GetNhanVienDAO();
            dgv_nhan_vien.Rows.Clear(); // Xóa dữ liệu cũ trước khi đổ dữ liệu mới

            // Kiểm tra nếu có dữ liệu trong DataSet
            if (dataSet.Tables.Count > 0 && dataSet.Tables[0].Rows.Count > 0)
            {
                foreach (DataRow row in dataSet.Tables[0].Rows)
                {
                    // Thêm dữ liệu từ mỗi dòng của DataSet vào DataGridView
                    dgv_nhan_vien.Rows.Add(row.ItemArray);
                }
            }
            else
            {
                MessageBox.Show("Không có dữ liệu để hiển thị.");
            }
        }
    }
}
