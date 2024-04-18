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
using CrystalDecisions.Shared;
namespace GUI
{
    public partial class PhieuTraForm : Form
    {
        private PhieuMuonFrm phieuMuonForm;
        private bool isSecondFormVisible = false;

        PhieuTraSachBUS phieuTraSachBUS = new PhieuTraSachBUS();
        public PhieuTraForm()
        {
            InitializeComponent();
            InitializeDataGridView();
            phieuMuonForm  = new PhieuMuonFrm();
        }

        public void InitializeDataGridView()
        {
            dgv_phieu_tra.ColumnCount = 8;
            dgv_phieu_tra.Columns[0].Name = "Mã phiếu trả";
            dgv_phieu_tra.Columns[1].Name = "Mã sách";
            dgv_phieu_tra.Columns[2].Name = "Mã phiếu mượn";
            dgv_phieu_tra.Columns[3].Name = "Mã nhân viên";
            dgv_phieu_tra.Columns[4].Name = "Ngày trả sách";
            dgv_phieu_tra.Columns[5].Name = "Mã độc giả";
            dgv_phieu_tra.Columns[6].Name = "Mã tình trạng sách";
            dgv_phieu_tra.Columns[7].Name = "Mã phiếu phạt";


            dgv_phieu_tra.ReadOnly = true;
            dgv_phieu_tra.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgv_phieu_tra.AllowUserToAddRows = false;
        }

 

        private void PhieuTraForm_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'quanLyThuVienDataSet2.CHITIETPHIEUMUON' table. You can move, or remove it, as needed.
            this.cHITIETPHIEUMUONTableAdapter.Fill(this.quanLyThuVienDataSet2.CHITIETPHIEUMUON);
            // TODO: This line of code loads data into the 'quanLyThuVienDataSet2.TINHTRANGSACH' table. You can move, or remove it, as needed.
            this.tINHTRANGSACHTableAdapter.Fill(this.quanLyThuVienDataSet2.TINHTRANGSACH);
            // TODO: This line of code loads data into the 'quanLyThuVienDataSet2.SACH' table. You can move, or remove it, as needed.
            this.sACHTableAdapter.Fill(this.quanLyThuVienDataSet2.SACH);
            // TODO: This line of code loads data into the 'quanLyThuVienDataSet2.NHANVIEN' table. You can move, or remove it, as needed.
            this.nHANVIENTableAdapter.Fill(this.quanLyThuVienDataSet2.NHANVIEN);
            // TODO: This line of code loads data into the 'quanLyThuVienDataSet2.PHIEUMUONSACH' table. You can move, or remove it, as needed.
            this.pHIEUMUONSACHTableAdapter.Fill(this.quanLyThuVienDataSet2.PHIEUMUONSACH);

            chk_check.Enabled = false;
            btn_them_phieu_phat.Enabled = false;
            lb_tb.Text = "Sách nguyên vẹn";
            tb_ma_phieu_tra.Enabled = false;

            DataSet data = phieuTraSachBUS.dsPhieuTraSach();
            dgv_phieu_tra.Rows.Clear();
            if (data.Tables.Count > 0 && data.Tables[0].Rows.Count > 0)
            {
                foreach (DataRow row in data.Tables[0].Rows)
                {
                    dgv_phieu_tra.Rows.Add(row.ItemArray);
                }
            }
        }

       

        private void dgv_phieu_tra_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int rowIndex = e.RowIndex;
            tb_ma_phieu_tra.Enabled = false;
            // dtp_ngay_hen_tra.Enabled = false;

            if (rowIndex >= 0 && rowIndex < dgv_phieu_tra.Rows.Count)
            {
                DataGridViewRow selectRow = dgv_phieu_tra.Rows[rowIndex];

                tb_ma_phieu_tra.Text = selectRow.Cells["Mã phiếu trả"].Value.ToString();
                cbb_ma_dg.Text = selectRow.Cells["Mã độc giả"].Value.ToString();
                cbb_ma_phieu_muon.Text = selectRow.Cells["Mã phiếu mượn"].Value.ToString();
                cbb_ma_nv.Text = selectRow.Cells["Mã nhân viên"].Value.ToString();
                cbb_ma_sach.Text = selectRow.Cells["Mã sách"].Value.ToString();
                cbb_ma_tinh_trang_sach.Text = selectRow.Cells["Mã tình trạng sách"].Value.ToString();
                dtp_ngay_tra.Text = selectRow.Cells["Ngày trả sách"].Value.ToString();
            }
        }

        private void loadDanhSachPhieuTra()
        {
            DataSet data = phieuTraSachBUS.dsPhieuTraSach();
            dgv_phieu_tra.Rows.Clear();
            if (data.Tables.Count > 0 && data.Tables[0].Rows.Count > 0)
            {
                foreach (DataRow row in data.Tables[0].Rows)
                {
                    dgv_phieu_tra.Rows.Add(row.ItemArray);
                }
            }
        }

        private void btn_them_Click(object sender, EventArgs e)
        {
            if (tb_ma_phieu_tra.Text.Trim() != "" &&
                cbb_ma_dg.Text.Trim() != "" &&
                cbb_ma_phieu_muon.Text != "" &&
                cbb_ma_nv.Text != "" &&
                cbb_ma_sach.Text != "" &&
                cbb_ma_tinh_trang_sach.Text != "" &&
                dtp_ngay_tra.Text != ""
                )
            {
                string maPT = tb_ma_phieu_tra.Text.Trim();
                string maPm = cbb_ma_phieu_muon.Text.Trim();
                string maDG = cbb_ma_dg.Text;
                string maNV = cbb_ma_nv.Text;
                string maSach = cbb_ma_sach.Text;
                int maTT =  Convert.ToInt32( cbb_ma_tinh_trang_sach.Text);
                DateTime ngayTra = dtp_ngay_tra.Value;
                string ngayTraFomated = ngayTra.ToString("yyyy/MM/dd");

                try
                {
                    if(phieuTraSachBUS.checkMaPT("PHIEUTRASACH", "sMaPhieuTra", tb_ma_phieu_tra.Text.Trim()) 
                        && phieuTraSachBUS.checkMaPT("PHIEUTRASACH", "sMaSach", cbb_ma_sach.Text.Trim()))
                    {
                        MessageBox.Show("Mã sách và phiếu trả đã tồn tại trong hệ thống");
                    }
                    else
                    {
                        int res = phieuTraSachBUS.themPhieuTraSach(maPT, maSach, maPm, maNV, ngayTraFomated, maDG, maTT);
                        if (res > 0)
                        {
                            MessageBox.Show("Thêm phiếu trả sách thành công");
                            loadDanhSachPhieuTra();
                            
                        }
                    }
                }
                catch(Exception ex)
                {
                    
                    loadDanhSachPhieuTra();
                }
            }
            else
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin");
            }
        }

        private void btn_ds_Click(object sender, EventArgs e)
        {
            
          
            // Kiểm tra nếu form thứ hai đang hiển thị
            if (isSecondFormVisible)
            {
                // Nếu đúng, đóng form thứ hai
                phieuMuonForm.Close();
                isSecondFormVisible = false;
            }
            else
            {
                phieuMuonForm = new PhieuMuonFrm();
                // Nếu không, hiển thị form thứ hai
                phieuMuonForm.Show();
                isSecondFormVisible = true;
            }
        }

        private void chk_check_CheckedChanged(object sender, EventArgs e)
        {
            
        }

        private void cbb_ma_tinh_trang_sach_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(cbb_ma_tinh_trang_sach.Text == "1")
            {
                chk_check.Checked = false;
                lb_tb.Text = "Sách nguyên vẹn";
                btn_them_phieu_phat.Enabled = false;
            }
            else if(cbb_ma_tinh_trang_sach.Text == "2")
            {
                chk_check.Checked = true;
                lb_tb.Text = "(Độc giả làm mất sách)";
                btn_them_phieu_phat.Enabled = true;
            }
            else
            {
                chk_check.Checked = true;
                lb_tb.Text = "(Độc giả làm hỏng sách)";
                btn_them_phieu_phat.Enabled = true;
            }
        }

        private void btn_them_phieu_phat_Click(object sender, EventArgs e)
        {
            
        }

        private void btn_capnhat_Click(object sender, EventArgs e)
        {
            if (tb_ma_phieu_tra.Text.Trim() != "" &&
                cbb_ma_dg.Text.Trim() != "" &&
                cbb_ma_phieu_muon.Text != "" &&
                cbb_ma_nv.Text != "" &&
                cbb_ma_sach.Text != "" &&
                cbb_ma_tinh_trang_sach.Text != "" &&
                dtp_ngay_tra.Text != ""
                )
            {
                string maPT = tb_ma_phieu_tra.Text.Trim();
                string maPm = cbb_ma_phieu_muon.Text.Trim();
                string maDG = cbb_ma_dg.Text;
                string maNV = cbb_ma_nv.Text;
                string maSach = cbb_ma_sach.Text;
                int maTT = Convert.ToInt32(cbb_ma_tinh_trang_sach.Text);
                DateTime ngayTra = dtp_ngay_tra.Value;
                string ngayTraFomated = ngayTra.ToString("yyyy/MM/dd");

                try
                {
                    int res = phieuTraSachBUS.capNhatPhieuTraSach(maPT, maSach, maPm, maNV, ngayTraFomated, maDG, maTT);
                    if (res > 0)
                    {
                        MessageBox.Show("Cập nhật phiếu trả sách thành công");
                        loadDanhSachPhieuTra();
                    }
                    else
                    {
                        MessageBox.Show("Cập nhật phiếu trả sách thất bại");
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi: " + ex.Message);
                }
            }
            else
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin");
            }
        }

        private void btn_xoa_Click(object sender, EventArgs e)
        {
            if(tb_ma_phieu_tra.Text.Trim() != "") {
                string maPT = tb_ma_phieu_tra.Text.Trim();

                try
                {
                    DialogResult result = MessageBox.Show("Bạn có chắc chắn muốn xóa phiếu trả sách có mã là: " + maPT + " ?", "???"
                        , MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                    if(result == DialogResult.Yes)
                    {
                        int res = phieuTraSachBUS.xoaPhieuTra(maPT);
                         if (res > 0)
                        {
                            MessageBox.Show("Xoá phiếu trả sách thành công");
                            loadDanhSachPhieuTra() ;
                        }
                        else
                        {
                            MessageBox.Show("Xóa phiếu mượn sách thất bại");
                        }
                    }
                    else
                    {

                    }
                }
                catch(Exception ex)
                {
                    MessageBox.Show("Lỗi: "+ex);
                }
            }
            else
            {
                MessageBox.Show("Vui lòng chọn mã phiếu trả trước khi xóa");
            }
        }

        private void btn_clean_Click(object sender, EventArgs e)
        {
            tb_ma_phieu_tra.Enabled = true;
            tb_ma_phieu_tra.Text = "";
            cbb_ma_dg.Text = "";
            cbb_ma_nv.Text = "";
            cbb_ma_phieu_muon.Text = "";
            cbb_ma_sach.Text = "";
            cbb_ma_tinh_trang_sach.Text = "";
            dtp_ngay_tra.Text = "";

        }
    }
}
