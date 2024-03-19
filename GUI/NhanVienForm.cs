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

        private void NhanVienForm_Load(object sender, EventArgs e)
        {
            tb_manv.Enabled = false;
            // TODO: This line of code loads data into the 'quanLyThuVienDataSet.CHUCVU' table. You can move, or remove it, as needed.
            this.cHUCVUTableAdapter.Fill(this.quanLyThuVienDataSet.CHUCVU);
            // TODO: This line of code loads data into the 'quanLyThuVienDataSet.NHANVIEN' table. You can move, or remove it, as needed.
            this.nHANVIENTableAdapter.Fill(this.quanLyThuVienDataSet.NHANVIEN);
            loadNhanVien();
        }

        private void loadNhanVien()
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


        private void dgv_nhan_vien_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int rowIndex = e.RowIndex;

            if (rowIndex >= 0 && rowIndex < dgv_nhan_vien.Rows.Count)
            {
                DataGridViewRow selectedRow = dgv_nhan_vien.Rows[rowIndex];

                tb_manv.Text = selectedRow.Cells["Mã nhân viên"].Value.ToString();
                tb_tennv.Text = selectedRow.Cells["Tên nhân viên"].Value.ToString();
                string gioitinh = selectedRow.Cells["Giới tính"].Value.ToString();

                if (gioitinh == "Nam")
                {
                    rad_nam.Checked = true;
                }
                else if (gioitinh == "Nữ")
                {
                    rad_nu.Checked = true;
                }

                tb_diachi.Text = selectedRow.Cells["Địa chỉ"].Value.ToString();
                tb_sdt.Text = selectedRow.Cells["Số điện thoại"].Value.ToString();
                cbb_macv.Text = selectedRow.Cells["Mã chức vụ"].Value.ToString();
                dtp_ngaysinh.Value = DateTime.Parse(selectedRow.Cells["Ngày sinh"].Value.ToString());
            }
        }

        private void btn_capnhat_Click(object sender, EventArgs e)
        {
            string manv = tb_manv.Text;
            string tennv = tb_tennv.Text;
            string gioitinh = "";
            if (rad_nam.Checked)
            {
                gioitinh = "Nam";
            } else if (rad_nu.Checked)
            {
                gioitinh = "Nữ";
            }

            string diachi = tb_diachi.Text;
            string sdt = tb_sdt.Text;
            string macv = cbb_macv.Text;
            DateTime ngaySinh = dtp_ngaysinh.Value;
            string ngaySinhFormatted = ngaySinh.ToString("yyyy/MM/dd");

            if (tb_tennv.Text != "" &&
                tb_manv.Text != "" &&
                gioitinh != "" &&
                tb_diachi.Text != "" &&
                tb_sdt.Text != "" &&
                cbb_macv.Text != "" &&
                dtp_ngaysinh.Text != "")
            {
                int res = nhanVienBUS.updateNhanVien(manv, tennv, gioitinh, diachi,
                    sdt, macv, ngaySinhFormatted);

                if (res > 0)
                {
                    MessageBox.Show("Cập nhật thông tin thành công");
                    loadNhanVien();
                }
                else
                {
                    MessageBox.Show("Cập nhật thông tin thất bại");
                }
            }
        }

        private void btn_them_Click(object sender, EventArgs e)
        {
            string manv = tb_manv.Text;
            string tennv = tb_tennv.Text;
            string gioitinh = "";
            if (rad_nam.Checked)
            {
                gioitinh = "Nam";
            }
            else if (rad_nu.Checked)
            {
                gioitinh = "Nữ";
            }

            string diachi = tb_diachi.Text;
            string sdt = tb_sdt.Text;
            string macv = cbb_macv.Text;
            DateTime ngaySinh = dtp_ngaysinh.Value;
            string ngaySinhFormatted = ngaySinh.ToString("yyyy/MM/dd");

                if (tb_manv.Text != "" &&
                tb_tennv.Text != "" &&
                tb_manv.Text != "" &&
                gioitinh != "" &&
                tb_diachi.Text != "" &&
                tb_sdt.Text != "" &&
                cbb_macv.Text != "" &&
                dtp_ngaysinh.Text != "")
            {
                int res = nhanVienBUS.themNhanVien(manv, tennv, gioitinh, diachi,
                    sdt, macv, ngaySinhFormatted);

                if(res > 0)
                {
                    MessageBox.Show("Thêm nhân viên mới thành công");
                    loadNhanVien();
                    tb_manv.Enabled = false;
                }
                else
                {
                    MessageBox.Show("Thêm nhân viên mới thất bại !");
                }
            }

                
        }

        private void btn_clean_Click(object sender, EventArgs e)
        {
            string manv = tb_manv.Text;
            string tennv = tb_tennv.Text;
            string gioitinh = "";
            if (rad_nam.Checked)
            {
                gioitinh = "Nam";
            }
            else if (rad_nu.Checked)
            {
                gioitinh = "Nữ";
            }

            string diachi = tb_diachi.Text;
            string sdt = tb_sdt.Text;
            string macv = cbb_macv.Text;
            DateTime ngaySinh = dtp_ngaysinh.Value;
            string ngaySinhFormatted = ngaySinh.ToString("yyyy/MM/dd");

            if (tb_manv.Text != "" ||
                tb_tennv.Text != "" ||
                tb_manv.Text != "" ||
                gioitinh != "" ||
                tb_diachi.Text != "" ||
                tb_sdt.Text != "" ||
                cbb_macv.Text != "" ||
                dtp_ngaysinh.Text != "")
            {
                tb_manv.Text = "";
                tb_tennv.Text = "";
                tb_manv.Text = "";
                gioitinh = "";
                tb_diachi.Text = "";
                tb_sdt.Text = "";
                cbb_macv.Text = "";
                dtp_ngaysinh.Text = "";
                tb_manv.Enabled = true;
            }
        }

        private void btn_xoa_Click(object sender, EventArgs e)
        {
            string gioitinh = "";
            if (rad_nam.Checked)
            {
                gioitinh = "Nam";
            }
            else if (rad_nu.Checked)
            {
                gioitinh = "Nữ";
            }
            if (tb_manv.Text != "")
            {
                DialogResult result = MessageBox.Show("Bạn có chắc chắn muốn xóa mã nhân viên: "
                    + tb_manv.Text + " này không ?", "???", 
                    MessageBoxButtons.YesNo, 
                    MessageBoxIcon.Question);
                if (result == DialogResult.Yes)
                {
                    int res = nhanVienBUS.xoaNhanVien(tb_manv.Text);
                    if(res > 0)
                    {
                        MessageBox.Show("Xóa nhân viên thành công");
                        loadNhanVien();
                        tb_manv.Text = "";
                        tb_tennv.Text = "";
                        tb_manv.Text = "";
                        gioitinh = "";
                        tb_diachi.Text = "";
                        tb_sdt.Text = "";
                        cbb_macv.Text = "";
                        dtp_ngaysinh.Text = "";
                    }
                    else
                    {
                        MessageBox.Show("Xóa nhân viên thất bại!");
                    }
                }
                else
                {

                }
                
            }
            else
            {
                MessageBox.Show("Vui lòng chọn nhân viên mà bạn muốn xóa");
            }
        }

        private void tb_timkiem_TextChanged(object sender, EventArgs e)
        {
            if(cbb_boloc.Text == "Mã nhân viên")
            {
                dgv_nhan_vien.Rows.Clear();   
                DataSet dataSet = nhanVienBUS.timKiemNhanVienTheoMaNV(tb_timkiem.Text);
                
                    foreach (DataRow row in dataSet.Tables[0].Rows)
                    {
                        // Thêm dữ liệu từ mỗi dòng của DataSet vào DataGridView
                        dgv_nhan_vien.Rows.Add(row.ItemArray);
                    }
            }

            if (cbb_boloc.Text == "Tên nhân viên")
            {
                dgv_nhan_vien.Rows.Clear();
                DataSet dataSet = nhanVienBUS.timKiemNhanVienTheoTen(tb_timkiem.Text);

                foreach (DataRow row in dataSet.Tables[0].Rows)
                {
                    // Thêm dữ liệu từ mỗi dòng của DataSet vào DataGridView
                    dgv_nhan_vien.Rows.Add(row.ItemArray);
                }
            }
        }

        private void label10_Click(object sender, EventArgs e)
        {

        }
    }
}
