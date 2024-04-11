using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.UI.WebControls;
using System.Windows.Forms;
using BUS;
namespace GUI
{
    public partial class PhieuMuonFrm : Form
    {
        PhieuMuonBUS phieuMuonBUS = new PhieuMuonBUS();
       

        public PhieuMuonFrm()
        {
            InitializeComponent();
            InitializeDataGridView();
           
        }

        private void InitializeDataGridView()
        {
            dgv_phieu_muon.ColumnCount = 7;
            dgv_phieu_muon.Columns[0].Name = "Mã phiếu mượn";
            dgv_phieu_muon.Columns[1].Name = "Mã độc giả";
            dgv_phieu_muon.Columns[2].Name = "Ngày mượn";
            dgv_phieu_muon.Columns[3].Name = "Mã nhân viên";
            dgv_phieu_muon.Columns[4].Name = "Mã sách";
            dgv_phieu_muon.Columns[5].Name = "Mã loại phiếu";
            dgv_phieu_muon.Columns[6].Name = "Ngày hẹn trả";

            dgv_phieu_muon.ReadOnly = true;
            dgv_phieu_muon.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgv_phieu_muon.AllowUserToAddRows = false;
            //dgv_phieu_muon.CellFormatting += Dgv_phieu_muon_CellFormatting;
        }

        private void PhieuMuonFrm_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'quanLyThuVienDataSet2.SACH' table. You can move, or remove it, as needed.
            this.sACHTableAdapter.Fill(this.quanLyThuVienDataSet2.SACH);


            // TODO: This line of code loads data into the 'quanLyThuVienDataSet.PHIEUTRASACH' table. You can move, or remove it, as needed.
            this.pHIEUTRASACHTableAdapter.Fill(this.quanLyThuVienDataSet.PHIEUTRASACH);

            // TODO: This line of code loads data into the 'quanLyThuVienDataSet1.LOAIPHIEU' table. You can move, or remove it, as needed.
            this.lOAIPHIEUTableAdapter.Fill(this.quanLyThuVienDataSet1.LOAIPHIEU);
            // TODO: This line of code loads data into the 'quanLyThuVienDataSet1.SACH' table. You can move, or remove it, as needed.
           // this.sACHTableAdapter.Fill(this.quanLyThuVienDataSet1.SACH);
            // TODO: This line of code loads data into the 'quanLyThuVienDataSet1.NHANVIEN' table. You can move, or remove it, as needed.
            this.nHANVIENTableAdapter.Fill(this.quanLyThuVienDataSet1.NHANVIEN);
            // TODO: This line of code loads data into the 'quanLyThuVienDataSet1.DOCGIA' table. You can move, or remove it, as needed.
            this.dOCGIATableAdapter.Fill(this.quanLyThuVienDataSet1.DOCGIA);

            loadPhieuMuon();
           

        }

        private void loadPhieuMuon()
        {
            tb_ma_phieu_muon.Enabled = false;
            dtp_ngay_hen_tra.Enabled = false;
            DataSet dataSet = phieuMuonBUS.ds_phieuMuon();
            dgv_phieu_muon.Rows.Clear();
            // Dictionary để lưu trữ các hàng theo mã phiếu mượn

            if (dataSet.Tables.Count > 0 && dataSet.Tables[0].Rows.Count > 0)
            {
                foreach (DataRow row in dataSet.Tables[0].Rows)
                {
                    dgv_phieu_muon.Rows.Add(row.ItemArray);
                }
            }
            SetGreenColorForSameBorrowIDs();
        }



        private void SetGreenColorForSameBorrowIDs()
        {
            // Initialize id list
           

            foreach (DataGridViewRow row1 in dgv_phieu_muon.Rows)
            {
                // Get the borrow ID of the current row
                string borrowID1 = row1.Cells["Mã phiếu mượn"].Value?.ToString();

                // Skip if borrowID1 is null or empty
                if (string.IsNullOrEmpty(borrowID1))
                    continue; // Iterate through all other rows to find matches
                
                foreach (DataGridViewRow row2 in dgv_phieu_muon.Rows)
                {
                    // Skip comparing with the same row
                    if (row1 == row2)
                        continue;

                    // Get the borrow ID of the current row being compared
                    string borrowID2 = row2.Cells["Mã phiếu mượn"].Value?.ToString();

                    // Skip if borrowID2 is null or empty
                    if (string.IsNullOrEmpty(borrowID2))
                        continue;

                    // If the borrow IDs match, set background color to light green
                    if (borrowID1 == borrowID2)
                    {
                        row1.DefaultCellStyle.BackColor = Color.LightPink;
                        row2.DefaultCellStyle.BackColor = Color.LightPink;
                    }
                }
            }
        }

        private void dgv_phieu_muon_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int rowIndex = e.RowIndex;
            tb_ma_phieu_muon.Enabled = false;
            dtp_ngay_hen_tra.Enabled = false;

            if (rowIndex >= 0 && rowIndex < dgv_phieu_muon.Rows.Count)
            {
                DataGridViewRow selectRow = dgv_phieu_muon.Rows[rowIndex];

                tb_ma_phieu_muon.Text = selectRow.Cells["Mã phiếu mượn"].Value.ToString();
                cbb_ma_dg.Text = selectRow.Cells["Mã độc giả"].Value.ToString();
                dtp_ngay_muon.Text = selectRow.Cells["Ngày mượn"].Value.ToString();
                cbb_ma_nv.Text = selectRow.Cells["Mã nhân viên"].Value.ToString();
                cbb_ma_sach.Text = selectRow.Cells["Mã sách"].Value.ToString();
                cbb_loai_phieu.Text = selectRow.Cells["Mã loại phiếu"].Value.ToString();
                dtp_ngay_hen_tra.Text = selectRow.Cells["Ngày hẹn trả"].Value.ToString();
            }
        }

        private void btn_them_Click(object sender, EventArgs e)
        {
            if(tb_ma_phieu_muon.Text.Trim() != "" &&
                cbb_ma_dg.Text.Trim() != "" &&
                dtp_ngay_muon.Text != "" &&
                cbb_ma_nv.Text.Trim() != "" &&
                cbb_ma_sach.Text.Trim() != "" &&
                cbb_loai_phieu.Text.Trim() != ""&&
                chk_check.Checked == false
                )
            {
                string maPM = tb_ma_phieu_muon.Text.Trim();
                string maDG = cbb_ma_dg.Text.Trim();
                DateTime ngayMuon = dtp_ngay_muon.Value;
                string ngayMuonFormated = ngayMuon.ToString("yyyy/MM/dd");
          
                string maNV = cbb_ma_nv.Text.Trim();
                string maSach = cbb_ma_sach.Text.Trim();
                string maLoaiPhieu = cbb_loai_phieu.Text.Trim();

                

                try
                {
                    int res = phieuMuonBUS.themPhieuMuon(maPM, maDG, ngayMuonFormated, maNV, maSach, maLoaiPhieu);
                    if(res > 0)
                    {
                        MessageBox.Show("Thêm phiếu mượn sách thành công");
                        loadPhieuMuon();
                        tb_ma_phieu_muon.Enabled = false;
                    }
                    else
                    {

                    }
                   
                }
                catch (Exception ex)
                {
                        // Xử lý lỗi SQL Server                 
                        // Xử lý khi sách đã hết
                        MessageBox.Show("Lỗi: " + ex.Message); 
                }

            }else if(tb_ma_phieu_muon.Text.Trim() != "" &&
                cbb_ma_sach.Text.Trim() != "" &&
                cbb_loai_phieu.Text.Trim() != "" &&
                chk_check.Checked == true)
            {
                string maPM = tb_ma_phieu_muon.Text.Trim();
                string maSach = cbb_ma_sach.Text.Trim();
                string maLoaiPhieu = cbb_loai_phieu.Text.Trim();

                try
                {
                    int res = phieuMuonBUS.themChiTietPhieuMuon(maPM, maSach, maLoaiPhieu);
                    if (res > 0)
                    {
                        MessageBox.Show("Thêm phiếu mượn sách thành công");
                        loadPhieuMuon();
                        tb_ma_phieu_muon.Enabled = false;
                    }
                }
                catch(Exception ex)
                {
                    MessageBox.Show("Lỗi: " + ex.Message);
                }

            }
            else
            {
                MessageBox.Show("Vui lòng nhập đủ thông tin");
            }
        }

        private void btn_clean_Click(object sender, EventArgs e)
        {
            if (tb_ma_phieu_muon.Text.Trim() != "" ||
                cbb_ma_dg.Text.Trim() != "" ||
                dtp_ngay_muon.Text != "" ||
                cbb_ma_nv.Text.Trim() != "" ||
                cbb_ma_sach.Text.Trim() != "" ||
                cbb_loai_phieu.Text.Trim() != "")
            {
                tb_ma_phieu_muon.Enabled = true;
                tb_ma_phieu_muon.Text = "";
                cbb_ma_dg.Text = "";
                dtp_ngay_muon.Text = "";
                cbb_ma_nv.Text = "";
                cbb_ma_sach.Text = "";
                cbb_loai_phieu.Text = "";
            }
            else
            {
                MessageBox.Show("Dữ liệu đang trống");
            }
        }

        private void chk_check_CheckedChanged(object sender, EventArgs e)
        {
            if(chk_check.Checked == true)
            {
                tb_ma_phieu_muon.Enabled = false;
                cbb_ma_dg.Enabled = false;
                dtp_ngay_muon.Enabled = false;
                cbb_ma_nv.Enabled = false;
                dtp_ngay_hen_tra.Enabled = false;
            }
            else
            {
                cbb_ma_dg.Enabled = true;
                dtp_ngay_muon.Enabled = true;
                cbb_ma_nv.Enabled = true;
                
            }

        }
<<<<<<< HEAD

        private void btn_xoa_Click(object sender, EventArgs e)
        {
            if(tb_ma_phieu_muon.Text.Trim() != "")
            {
                try
                {
                    string maPM = tb_ma_phieu_muon.Text.Trim();
                    DialogResult result = MessageBox.Show("Bạn có chắc chắn muốn xóa mã phiếu mượn: " + maPM + " ?",
                        "???", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (result == DialogResult.Yes)
                    {
                        int res = phieuMuonBUS.xoaPhieuMuon(maPM);
                        if (res > 0)
                        {
                            MessageBox.Show("Xoá mã phiếu mượn thành công.");
                            loadPhieuMuon();
                        }
                        else
                        {
                            MessageBox.Show("Xóa phiếu mượn sách thất bại.");
                        }
                    }
                    else
                    {

                    }
                }
                catch(Exception ex)
                {
                    MessageBox.Show("Lỗi: "+ex.Message);
                }
            }
            else
            {
                MessageBox.Show("Vui lòng chọn mã phiếu mượn trước khi xóa.");
            }
        }

        private void btn_capnhat_Click(object sender, EventArgs e)
        {
            if(tb_ma_phieu_muon.Text.Trim() != "" || cbb_ma_sach.Text != "" ||
                cbb_loai_phieu.Text != "")
            {
                string maPM = tb_ma_phieu_muon.Text.Trim();
                string maSach = cbb_ma_sach.Text.Trim();
                string maLoaiPhieu = cbb_loai_phieu.Text.Trim();
                try
                {
                    int res = phieuMuonBUS.capNhatPhieuMuon(maPM, maSach, maLoaiPhieu);
                    if (res >= 0)
                    {
                        MessageBox.Show("Cập nhật phiếu mượn thành công.");
                        loadPhieuMuon();
                    }
                    else
                    {
                        MessageBox.Show("Cập nhật phiếu mượn thất bại.");
                    }
                }catch(Exception ex)
                {
                    MessageBox.Show("Lỗi: " + ex.Message);
                }
            }
            else
            {
                MessageBox.Show("Vui lòng nhập đủ thông tin.");
            }
        }

        private void btn_in_Click(object sender, EventArgs e)
        {
            if(tb_ma_phieu_muon.Text.Trim() != "")
            {
                string maPM = tb_ma_phieu_muon.Text.Trim();
                // Gọi phương thức GetDataDTO từ lớp DataProviceder để lấy dữ liệu
                DataSet dataSet = phieuMuonBUS.ds_phieuMuonTheoMa(maPM);

                if(dataSet.Tables.Count > 0 && dataSet.Tables[0].Rows.Count > 0)
                {
                    PhieuMuonReport r = new PhieuMuonReport();
                    r.SetDataSource(dataSet.Tables[0]); // Giả sử dữ liệu trả về nằm ở table đầu tiên trong DataSet

                    // Hiển thị report bằng cửa sổ mới
                    ShowReport f = new ShowReport();
                    // Tạo report bằng Crystal Report
                    f.crystalReportViewer1.ReportSource = r;
                    f.ShowDialog();
                }
                else
                {
                    MessageBox.Show("Không có phiếu mượn hợp lệ.");
                }
            }
            else
            {
                MessageBox.Show("Vui lòng chọn mã phiếu mượn để in.");
            }
        }

        private void tb_timkiem_TextChanged(object sender, EventArgs e)
        {
            if(cbb_boloc.Text.Trim() == "Mã phiếu mượn")
            {
                DataSet data = phieuMuonBUS.timKiemPhieuMuonTheoMaPM(tb_timkiem.Text.Trim());
                dgv_phieu_muon.Rows.Clear();
                foreach (DataRow row in data.Tables[0].Rows)
                {
                    dgv_phieu_muon.Rows.Add(row.ItemArray);
                }

            }

            if (cbb_boloc.Text.Trim() == "Mã độc giả")
            {
                DataSet data = phieuMuonBUS.timKiemPhieuMuonTheoMaDG(tb_timkiem.Text.Trim());
                dgv_phieu_muon.Rows.Clear();
                foreach (DataRow row in data.Tables[0].Rows)
                {
                    dgv_phieu_muon.Rows.Add(row.ItemArray);
                }

            }

        }
=======
>>>>>>> 6fbe207437f69b598926bfb73747f3013897ac5e
    }
}
