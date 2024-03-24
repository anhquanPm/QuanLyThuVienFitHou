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
    public partial class PhieuMuonFrm : Form
    {
        PhieuMuonBUS phieuMuonBUS = new PhieuMuonBUS();
        List<string> id;

        public PhieuMuonFrm()
        {
            InitializeComponent();
            InitializeDataGridView();
            id = new List<string>();
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
            
            // TODO: This line of code loads data into the 'quanLyThuVienDataSet1.LOAIPHIEU' table. You can move, or remove it, as needed.
            this.lOAIPHIEUTableAdapter.Fill(this.quanLyThuVienDataSet1.LOAIPHIEU);
            // TODO: This line of code loads data into the 'quanLyThuVienDataSet1.SACH' table. You can move, or remove it, as needed.
            this.sACHTableAdapter.Fill(this.quanLyThuVienDataSet1.SACH);
            // TODO: This line of code loads data into the 'quanLyThuVienDataSet1.NHANVIEN' table. You can move, or remove it, as needed.
            this.nHANVIENTableAdapter.Fill(this.quanLyThuVienDataSet1.NHANVIEN);
            // TODO: This line of code loads data into the 'quanLyThuVienDataSet1.DOCGIA' table. You can move, or remove it, as needed.
            this.dOCGIATableAdapter.Fill(this.quanLyThuVienDataSet1.DOCGIA);

            loadPhieuMuon();
            SetGreenColorForSameBorrowIDs();

        }

        private void loadPhieuMuon()
        {
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
        }



        private void SetGreenColorForSameBorrowIDs()
        {
            // Initialize id list
            id = new List<string>();

            foreach (DataGridViewRow row1 in dgv_phieu_muon.Rows)
            {
                // Get the borrow ID of the current row
                string borrowID1 = row1.Cells["Mã phiếu mượn"].Value?.ToString();

                // Skip if borrowID1 is null or empty
                if (string.IsNullOrEmpty(borrowID1))
                    continue;

                // Check if this borrow ID has already been processed
                if (id.Contains(borrowID1))
                    continue; // Skip if already processed

                // Mark the borrow ID as processed
                id.Add(borrowID1);

                // Iterate through all other rows to find matches
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

    }
}
