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

namespace GUI
{
    public partial class SachForm : Form
    {
        SachBUS sachBUS = new SachBUS();
        public SachForm()
        {
            InitializeComponent();
            InitializeDataGridView();
        }

        private void InitializeDataGridView()
        {
            // Thêm các cột vào DataGridView
            dgv_sach.ColumnCount = 8;
            dgv_sach.Columns[0].Name = "Mã sách";
            dgv_sach.Columns[1].Name = "Tên sách";
            dgv_sach.Columns[2].Name = "Năm xuất bản";
            dgv_sach.Columns[3].Name = "Số lượng";
            dgv_sach.Columns[4].Name = "Mã loại";
            dgv_sach.Columns[5].Name = "Mã tác giả";
            dgv_sach.Columns[6].Name = "Giá tiền";
            dgv_sach.Columns[7].Name = "Mã nhà xuất bản";

            // Không cho phép chỉnh sửa dữ liệu trực tiếp trên DataGridView
            dgv_sach.ReadOnly = true;
            // Cài đặt chế độ hiển thị dữ liệu đầy đủ trên DataGridView
            dgv_sach.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgv_sach.AllowUserToAddRows = false;
        }

        private void SachForm_Load(object sender, EventArgs e)
        {
            DataSet dataSet = sachBUS.getSachData();
            dgv_sach.Rows.Clear(); // Xóa dữ liệu cũ trước khi đổ dữ liệu mới

            // Kiểm tra nếu có dữ liệu trong DataSet
            if (dataSet.Tables.Count > 0 && dataSet.Tables[0].Rows.Count > 0)
            {
                foreach (DataRow row in dataSet.Tables[0].Rows)
                {
                    // Thêm dữ liệu từ mỗi dòng của DataSet vào DataGridView
                    dgv_sach.Rows.Add(row.ItemArray);
                }
            }
            else
            {
                MessageBox.Show("Không có dữ liệu để hiển thị.");
            }
        }
    }
}
