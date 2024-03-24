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
    public partial class TacGiafrm : Form
    {
        TacGiaBUS tacGiaBUS = new TacGiaBUS();
        public TacGiafrm()
        {
            InitializeComponent();
            InitializeDataGridView();
        }

        private void InitializeDataGridView()
        {
            dgv_tac_gia.ColumnCount = 4;
            dgv_tac_gia.Columns[0].Name = "Mã tác giả";
            dgv_tac_gia.Columns[1].Name = "Tên tác giả";
            dgv_tac_gia.Columns[2].Name = "Địa chỉ";
            dgv_tac_gia.Columns[3].Name = "SĐT";

            dgv_tac_gia.ReadOnly = true;
            dgv_tac_gia.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgv_tac_gia.AllowUserToAddRows = false;

        }

        private void TacGiafrm_Load(object sender, EventArgs e)
        {
            tb_matg.Enabled = false;
            DataSet dataSet = tacGiaBUS.ds_tacGia();
            dgv_tac_gia.Rows.Clear();
            if (dataSet.Tables[0].Rows.Count > 0  && dataSet.Tables.Count > 0)
            {
                foreach(DataRow dataRow in dataSet.Tables[0].Rows)
                {
                    dgv_tac_gia.Rows.Add(dataRow.ItemArray);
                }
            }
        }

        private void loadTacGia()
        {
            DataSet dataSet = tacGiaBUS.ds_tacGia();
            dgv_tac_gia.Rows.Clear();
            if (dataSet.Tables[0].Rows.Count > 0 && dataSet.Tables.Count > 0)
            {
                foreach (DataRow dataRow in dataSet.Tables[0].Rows)
                {
                    dgv_tac_gia.Rows.Add(dataRow.ItemArray);
                }
            }
        }

        private void dgv_tac_gia_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int rowIndex = e.RowIndex;

            tb_matg.Enabled = false;
            int indexRow = e.RowIndex;
            if (indexRow >= 0 && indexRow <= dgv_tac_gia.Rows.Count)
            {
                DataGridViewRow selectedRow = dgv_tac_gia.Rows[indexRow];
                tb_matg.Text = selectedRow.Cells["Mã tác giả"].Value.ToString();
                tb_tentg.Text = selectedRow.Cells["Tên tác giả"].Value.ToString();
                tb_diachi.Text = selectedRow.Cells["Địa chỉ"].Value.ToString();
                tb_sdt.Text = selectedRow.Cells["SĐT"].Value.ToString();
            }
        }

        private void btn_them_Click(object sender, EventArgs e)
        {
            if (tb_matg.Text.Trim() != "" && tb_tentg.Text.Trim() != "" &&
                tb_diachi.Text.Trim() != "" && tb_sdt.Text.Trim() != "")
            {
                string maDG = tb_matg.Text.Trim();
                string tenDG = tb_tentg.Text.Trim();
             
                string diaChi = tb_diachi.Text.Trim();
                string sdt = tb_sdt.Text.Trim();
                int res = tacGiaBUS.themTacGia(maDG, tenDG, diaChi, sdt);
                if (res > 0)
                {
                    MessageBox.Show("Thêm tác giả thành công");
                    loadTacGia();
                    tb_matg.Enabled = false;
                }
                else
                {
                    MessageBox.Show("Thêm tác giả thất bại");
                }
            }
            else
            {
                MessageBox.Show("Vui lòng nhập đủ thông tin");
            }
        }

        private void btn_capnhat_Click(object sender, EventArgs e)
        {
            if (tb_matg.Text.Trim() != "" && tb_tentg.Text.Trim() != "" &&
                tb_diachi.Text.Trim() != "" && tb_sdt.Text.Trim() != "")
            {
                string maDG = tb_matg.Text.Trim();
                string tenDG = tb_tentg.Text.Trim();

                string diaChi = tb_diachi.Text.Trim();
                string sdt = tb_sdt.Text.Trim();
                int res = tacGiaBUS.capNhatTacGia(maDG, tenDG, diaChi, sdt);
                if (res > 0)
                {
                    MessageBox.Show("Cập nhật tác giả thành công");
                    loadTacGia();
                    tb_matg.Enabled = false;
                }
                else
                {
                    MessageBox.Show("Cập nhật tác giả thất bại");
                }
            }
            else
            {
                MessageBox.Show("Vui lòng nhập đủ thông tin");
            }
        }

        private void btn_xoa_Click(object sender, EventArgs e)
        {
            if (tb_matg.Text.Trim() != "")
            {
                string maTG = tb_matg.Text.Trim();
                int res = tacGiaBUS.xoaTacGia(maTG);

                DialogResult result = MessageBox.Show("Bạn có chắc chắn muốn xóa Tác giả có mã là: " + maTG + " không ?",
                                        "???", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (result == DialogResult.Yes)
                {
                    if (res > 0)
                    {
                        MessageBox.Show("Cập nhật tác giả thành công");
                        loadTacGia();
                      
                    }
                    else
                    {
                        MessageBox.Show("Cập nhật tác giả thất bại");
                    }
                }
                else
                {

                }    
            }
            else
            {
                MessageBox.Show("Vui lòng nhập đủ thông tin");
            }
        }

        private void btn_clean_Click(object sender, EventArgs e)
        {
            if (tb_matg.Text.Trim() != "" || tb_tentg.Text.Trim() != "" ||
                tb_diachi.Text.Trim() != "" || tb_sdt.Text.Trim() != "")
            {
                tb_matg.Enabled = true;
                tb_matg.Text = "";
                tb_tentg.Text = "";
                tb_diachi.Text = "";
                tb_sdt.Text = "";
                tb_matg.Enabled = true;

            }
            else
            {
                MessageBox.Show("Dữ liệu đang trống");
            }
        }

        private void tb_timkiem_TextChanged(object sender, EventArgs e)
        {
            if(cbb_boloc.Text == "Tên tác giả")
            {
                DataSet data = tacGiaBUS.timKiemTacGiaTheoTen(tb_timkiem.Text.Trim());
                dgv_tac_gia.Rows.Clear();

                foreach(DataRow row in data.Tables[0].Rows)
                {
                    dgv_tac_gia.Rows.Add(row.ItemArray);
                }
            }else if(cbb_boloc.Text == "Mã tác giả")
            {
                DataSet data = tacGiaBUS.timKiemTacGiaTheoMaTG(tb_timkiem.Text.Trim());
                dgv_tac_gia.Rows.Clear();

                foreach (DataRow row in data.Tables[0].Rows)
                {
                    dgv_tac_gia.Rows.Add(row.ItemArray);
                }
            }
        }
    }
}
