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
    public partial class DocGiaForm : Form
    {
        DocGiaBUS DocGiaBUS = new DocGiaBUS();
        public DocGiaForm()
        {
            InitializeComponent();
            InitializeDataGridView();
        }

        private void InitializeDataGridView()
        {
            // Thêm các cột vào DataGridView
            dgv_doc_gia.ColumnCount = 6;
            dgv_doc_gia.Columns[0].Name = "Mã độc giả";
            dgv_doc_gia.Columns[1].Name = "Tên độc giả";
            dgv_doc_gia.Columns[2].Name = "Ngày sinh";
            dgv_doc_gia.Columns[3].Name = "Giới tính";
            dgv_doc_gia.Columns[4].Name = "Địa chỉ";
            dgv_doc_gia.Columns[5].Name = "SĐT";


            // Không cho phép chỉnh sửa dữ liệu trực tiếp trên DataGridView
            dgv_doc_gia.ReadOnly = true;
            // Cài đặt chế độ hiển thị dữ liệu đầy đủ trên DataGridView
            dgv_doc_gia.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgv_doc_gia.AllowUserToAddRows = false;
        }

        private void DocGiaForm_Load(object sender, EventArgs e)
        {
            tb_madg.Enabled = false;
            DataSet dataSet = DocGiaBUS.dsDocGia();
            dgv_doc_gia.Rows.Clear();

            if (dataSet.Tables[0].Rows.Count > 0 && dataSet.Tables.Count > 0)
            {
                foreach(DataRow row in dataSet.Tables[0].Rows)
                {
                    dgv_doc_gia.Rows.Add(row.ItemArray);
                }
            }
        }

        private void loadDocGia()
        {
            DataSet dataSet = DocGiaBUS.dsDocGia();
            dgv_doc_gia.Rows.Clear();

            if (dataSet.Tables[0].Rows.Count > 0 && dataSet.Tables.Count > 0)
            {
                foreach (DataRow row in dataSet.Tables[0].Rows)
                {
                    dgv_doc_gia.Rows.Add(row.ItemArray);
                }
            }
        }

        private void dgv_doc_gia_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            tb_madg.Enabled = false;   
            int indexRow = e.RowIndex;
            if(indexRow >= 0 && indexRow <= dgv_doc_gia.Rows.Count)
            {
                DataGridViewRow selectedRow = dgv_doc_gia.Rows[indexRow];
                tb_madg.Text = selectedRow.Cells["Mã độc giả"].Value.ToString();
                tb_tendg.Text = selectedRow.Cells["Tên độc giả"].Value.ToString();
                if (DateTime.TryParseExact(selectedRow.Cells["Ngày sinh"].Value.ToString(), "dd/MM/yyyy", null, System.Globalization.DateTimeStyles.None, out DateTime namXB))
                {
                    dtp_ngaysinh.Value = namXB;
                }
                else
                {
                    MessageBox.Show("Invalid date format!");
                }
                String gioiTinh = selectedRow.Cells["Giới tính"].Value.ToString();
                if(gioiTinh == "True")
                {
                    rad_nam.Checked = true;
                }
                if(gioiTinh == "False")
                {
                    rad_nu.Checked = true;
                }
      
                string sex = selectedRow.Cells["Giới tính"].Value.ToString();
                if(sex == "Nam")
                {
                    rad_nam.Checked = true;
                }else if(sex == "Nữ")
                {
                    rad_nu.Checked = true;
                }
                tb_diachi.Text = selectedRow.Cells["Địa chỉ"].Value.ToString();
                tb_sdt.Text = selectedRow.Cells["SĐT"].Value.ToString();
            }
        }

        private void btn_them_Click(object sender, EventArgs e)
        {
            if(tb_tendg.Text.Trim() != "" && tb_madg.Text.Trim() != "" &&
                dtp_ngaysinh.Text.Trim() != "" && (rad_nu.Checked == true || rad_nam.Checked == true) &&
                tb_diachi.Text.Trim() != "" && tb_sdt.Text.Trim() != "")
            {
                string maDG = tb_madg.Text.Trim();
                string tenDG = tb_tendg.Text.Trim();
                string ngaySinh = dtp_ngaysinh.Value.ToString("yyyy/MM/dd");
                string gioiTinh = "";
                if(rad_nam.Checked == true)
                {
                    gioiTinh = "Nam";
                }else if(rad_nu.Checked == true)
                {
                    gioiTinh = "Nữ";
                }
                string diaChi = tb_madg.Text.Trim();
                string sdt = tb_sdt.Text.Trim();
                int res = DocGiaBUS.themDocGia(maDG, tenDG, ngaySinh, gioiTinh, diaChi, sdt);
                if (res > 0) {
                    MessageBox.Show("Thêm độc giả thành công");
                    loadDocGia();
                    tb_madg.Enabled = false;
                }
                else
                {
                    MessageBox.Show("Thêm độc giả thất bại");
                }
            }
            else
            {
                MessageBox.Show("Vui lòng nhập đủ thông tin");
            }
        }

        private void btn_capnhat_Click(object sender, EventArgs e)
        {
            if (tb_tendg.Text.Trim() != "" && tb_madg.Text.Trim() != "" &&
                dtp_ngaysinh.Text.Trim() != "" && (rad_nu.Checked == true || rad_nam.Checked == true) &&
                tb_diachi.Text.Trim() != "" && tb_sdt.Text.Trim() != "")
            {
                string maDG = tb_madg.Text.Trim();
                string tenDG = tb_tendg.Text.Trim();
                string ngaySinh = dtp_ngaysinh.Value.ToString("yyyy/MM/dd");
                string gioiTinh = "";
                if (rad_nam.Checked == true)
                {
                    gioiTinh = "Nam";
                }
                else if (rad_nu.Checked == true)
                {
                    gioiTinh = "Nữ";
                }
                string diaChi = tb_madg.Text.Trim();
                string sdt = tb_sdt.Text.Trim();
                int res = DocGiaBUS.suaDocGia(maDG, tenDG, ngaySinh, gioiTinh, diaChi, sdt);
                if (res > 0)
                {
                    MessageBox.Show("Cập nhật thông tin độc giả thành công");
                    loadDocGia();
                }
                else
                {
                    MessageBox.Show("Cập nhật thông tin độc giả thất bại");
                }
            }
            else
            {
                MessageBox.Show("Vui lòng nhập đủ thông tin");
            }
        }

        private void btn_clean_Click(object sender, EventArgs e)
        {
            if (tb_tendg.Text.Trim() != "" || tb_madg.Text.Trim() != "" ||
               dtp_ngaysinh.Text.Trim() != "" || (rad_nu.Checked == true || rad_nam.Checked == true) ||
               tb_diachi.Text.Trim() != "" || tb_sdt.Text.Trim() != "")
            {
                tb_madg.Enabled = true;

                tb_tendg.Text = "";
                tb_madg.Text = "";
                dtp_ngaysinh.Text = "";
                rad_nam.Checked = false;
                rad_nu.Checked = false;
                tb_diachi.Text = "";
                tb_sdt.Text = "";

            }
            else
            {
                MessageBox.Show("Dữ liệu đang trống");
            }
        }

        private void btn_xoa_Click(object sender, EventArgs e)
        {
            if (tb_tendg.Text.Trim() != "")
            {
                string maDG = tb_madg.Text.Trim();
                DialogResult result = MessageBox.Show("Bạn có chắc chắn muốn xóa độc giả có mã là: " + maDG + " ?"
                    , "???", MessageBoxButtons.YesNo, MessageBoxIcon.Question );
                if (result == DialogResult.Yes)
                {
                    int res = DocGiaBUS.xoaDocGia(maDG);
                    if(res > 0)
                    {
                        MessageBox.Show("Xóa độc giả thành công");
                        loadDocGia();
                    }
                    else
                    {
                        MessageBox.Show("Xóa mã độc giả thất bại");
                    }
                }
                else
                {

                }
               
            }
            else
            {
                MessageBox.Show("Vui lòng chọn độc giả trước khi xóa");
            }
        }

        private void tb_timkiem_TextChanged(object sender, EventArgs e)
        {
            if(cbb_boloc.Text == "Mã độc giả")
            {
                DataSet data = DocGiaBUS.timKiemDocGiaTheoMaDG(tb_timkiem.Text.Trim());
                dgv_doc_gia.Rows.Clear();
                foreach (DataRow row in data.Tables[0].Rows)
                {
                    dgv_doc_gia.Rows.Add(row.ItemArray);
                }
            } else if(cbb_boloc.Text == "Tên độc giả")
            {
                DataSet data = DocGiaBUS.timKiemDocGiaTheoTen(tb_timkiem.Text.Trim());
                dgv_doc_gia.Rows.Clear();
                foreach (DataRow row in data.Tables[0].Rows)
                {
                    dgv_doc_gia.Rows.Add(row.ItemArray);
                }
            }
        }
    }
}
