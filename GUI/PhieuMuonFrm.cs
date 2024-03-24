using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GUI
{
    public partial class PhieuMuonFrm : Form
    {
        public PhieuMuonFrm()
        {
            InitializeComponent();
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

        }
    }
}
