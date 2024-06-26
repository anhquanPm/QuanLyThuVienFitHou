﻿using System;
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
            dgv_sach.Columns[5].Name = "Giá tiền";
            dgv_sach.Columns[6].Name = "Mã nhà xuất bản";
            dgv_sach.Columns[7].Name = "Mã tác giả";

            // Không cho phép chỉnh sửa dữ liệu trực tiếp trên DataGridView
            dgv_sach.ReadOnly = true;
            // Cài đặt chế độ hiển thị dữ liệu đầy đủ trên DataGridView
            dgv_sach.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgv_sach.AllowUserToAddRows = false;
            dgv_sach.CellFormatting += dgv_sach_CellFormatting;
        }

        private void SachForm_Load(object sender, EventArgs e)
        {
            tb_ma_sach.Enabled = false;
            // TODO: This line of code loads data into the 'quanLyThuVienDataSet.NHAXUATBAN' table. You can move, or remove it, as needed.
            this.nHAXUATBANTableAdapter.Fill(this.quanLyThuVienDataSet.NHAXUATBAN);
            // TODO: This line of code loads data into the 'quanLyThuVienDataSet.TACGIA' table. You can move, or remove it, as needed.
            this.tACGIATableAdapter.Fill(this.quanLyThuVienDataSet.TACGIA);
            // TODO: This line of code loads data into the 'quanLyThuVienDataSet.THELOAISACH' table. You can move, or remove it, as needed.
            this.tHELOAISACHTableAdapter.Fill(this.quanLyThuVienDataSet.THELOAISACH);

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

        private void loadSach()
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

        private void dgv_sach_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {

            // Kiểm tra cột "Số lượng" và dòng có giá trị là 0
            if (dgv_sach.Columns[e.ColumnIndex].Name == "Số lượng" && Convert.ToInt32(e.Value) == 0)
            {
                // Đổi màu cell sang màu đỏ
                e.CellStyle.BackColor = Color.Red;
                e.CellStyle.ForeColor = Color.White;
            }
        }

        private void dgv_sach_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int indexRow = e.RowIndex;
            tb_ma_sach.Enabled = false;

            if (indexRow >= 0 && indexRow <= dgv_sach.Rows.Count)
            {
                DataGridViewRow selectedRow = dgv_sach.Rows[indexRow];

                tb_ma_sach.Text = selectedRow.Cells["Mã sách"].Value.ToString();
                tb_ten_sach.Text = selectedRow.Cells["Tên sách"].Value.ToString();
                //dtp_nam_xb.Value = DateTime.Parse(selectedRow.Cells["Năm xuất bản"].Value.ToString());
                if (DateTime.TryParseExact(selectedRow.Cells["Năm xuất bản"].Value.ToString(), "dd/MM/yyyy", null, System.Globalization.DateTimeStyles.None, out DateTime namXB))
                {
                    dtp_nam_xb.Value = namXB;
                }
                else
                {
                    MessageBox.Show("Invalid date format!");
                }
                tb_so_luong.Text = selectedRow.Cells["Số lượng"].Value.ToString();
                cbb_ma_loai.Text = selectedRow.Cells["Mã loại"].Value.ToString();
                cbb_ma_tg.Text = selectedRow.Cells["Mã tác giả"].Value.ToString();
                tb_gia_tien.Text = selectedRow.Cells["Giá tiền"].Value.ToString();
                cbb_nha_xb.Text = selectedRow.Cells["Mã nhà xuất bản"].Value.ToString();
            }
        }

        private void btn_them_Click(object sender, EventArgs e)
        {
            if (tb_ma_sach.Text != "" &&
                tb_ten_sach.Text != "" &&
                dtp_nam_xb.Text != "" &&
                tb_so_luong.Text != "" &&
                cbb_ma_loai.Text != "" &&
                cbb_ma_tg.Text != "" &&
                tb_gia_tien.Text != "" &&
                cbb_nha_xb.Text != "" && chk_dongTG.Checked == false)
            {
                string maSach = tb_ma_sach.Text.Trim();
                string tenSach = tb_ten_sach.Text.Trim();
                //string namXB = dtp_nam_xb.Text.Trim();
                DateTime namXB = dtp_nam_xb.Value;
                string namXBFormatted = namXB.ToString("yyyy/MM/dd");
                int soLuong = int.Parse(tb_so_luong.Text.Trim());
                string maLoai = cbb_ma_loai.Text.Trim();
                string maTG = cbb_ma_tg.Text.Trim();
                float giaTien = float.Parse(tb_gia_tien.Text.Trim());
                string nhaXB = cbb_nha_xb.Text.Trim();
                try
                {
                    if(sachBUS.checkKey("dbo.SACH", "sMaSach", tb_ma_sach))
                    {
                        MessageBox.Show("Mã sách đã tồn tại trong hệ thống");
                    }
                    else
                    {
                        int res = sachBUS.themSach(maSach, tenSach, namXBFormatted, soLuong, maLoai, maTG, giaTien, nhaXB);
                        if (res > 0)
                        {
                            MessageBox.Show("Thêm sách thành công");
                            loadSach();
                            tb_ma_sach.Enabled = false;
                        }
                        else
                        {
                            MessageBox.Show("Thêm sách thất bại!");
                        }
                    }
                    
                }
                catch
                {
                    MessageBox.Show("Mã sách đã tồn tại trong hệ thống");
                }
                
            }
            else if (chk_dongTG.Checked == true && cbb_ma_tg.Text.Trim() != ""
                 && tb_ma_sach.Text.Trim() != "")
            {
                try
                {
                    int res = sachBUS.dongTacGia(cbb_ma_tg.Text.Trim(), tb_ma_sach.Text.Trim());
                    if (res > 0)
                    {
                        MessageBox.Show("Thêm đồng tác giả thành công");
                        loadSach();

                    }
                    else
                    {
                        MessageBox.Show("Thêm đồng tác giả thất bại");
                    }
                }
                catch
                {
                    MessageBox.Show("Tác giả này đã viết cuốn sách này rồi, bạn không thể thêm");
                }

            }
            else
            {
                MessageBox.Show("Vui lòng nhập đủ thông tin");
            }
        }

        private void btn_clean_Click(object sender, EventArgs e)
        {

            if (tb_ma_sach.Text != "" ||
                tb_ten_sach.Text != "" ||
                dtp_nam_xb.Text != "" ||
                tb_so_luong.Text != "" ||
                cbb_ma_loai.Text != "" ||
                cbb_ma_tg.Text != "" ||
                tb_gia_tien.Text != "" ||
                cbb_nha_xb.Text != "")
            {
                tb_ma_sach.Enabled = true;
                tb_ma_sach.Text = "";
                tb_ten_sach.Text = "";
                dtp_nam_xb.Text = "";
                tb_so_luong.Text = "";
                cbb_ma_loai.Text = "";
                cbb_ma_tg.Text = "";
                tb_gia_tien.Text = "";
                cbb_nha_xb.Text = "";
            }


        }

        private void btn_capnhat_Click(object sender, EventArgs e)
        {
            if (tb_ma_sach.Text != "" &&
                tb_ten_sach.Text != "" &&
                dtp_nam_xb.Text != "" &&
                tb_so_luong.Text != "" &&
                cbb_ma_loai.Text != "" &&
                cbb_ma_tg.Text != "" &&
                tb_gia_tien.Text != "" &&
                cbb_nha_xb.Text != "")
            {
                string maSach = tb_ma_sach.Text.Trim();
                string tenSach = tb_ten_sach.Text.Trim();
                //string namXB = dtp_nam_xb.Text.Trim();
                DateTime namXB = dtp_nam_xb.Value;
                string namXBFormatted = namXB.ToString("yyyy/MM/dd");
                int soLuong = int.Parse(tb_so_luong.Text.Trim());
                string maLoai = cbb_ma_loai.Text.Trim();
                string maTG = cbb_ma_tg.Text.Trim();
                float giaTien = float.Parse(tb_gia_tien.Text.Trim());
                string nhaXB = cbb_nha_xb.Text.Trim();
                int res = sachBUS.capNhatSach(maSach, tenSach, namXBFormatted, soLuong, maLoai, giaTien, nhaXB);
                if (res > 0)
                {
                    MessageBox.Show("Cập nhật sách thành công");
                    loadSach();
                }
                else
                {
                    MessageBox.Show("Cập nhật sách thất bại!");
                }
            }
            else
            {
                MessageBox.Show("Vui lòng nhập đủ thông tin");
            }
        }

        private void btn_xoa_Click(object sender, EventArgs e)
        {
            if (tb_ma_sach.Text.Trim() != "" && cbb_ma_tg.Text.Trim() != "")
            {
                string maSach = tb_ma_sach.Text.Trim();
                DialogResult result = MessageBox.Show("Bạn có chắc chắn muốn xóa: " + maSach +
                    " này không ?", "???",
                    MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (result == DialogResult.Yes)
                {
                    try
                    {
                        int res = sachBUS.xoaSach(tb_ma_sach.Text, cbb_ma_tg.Text);
                        if (res > 0)
                        {
                            MessageBox.Show("Xóa sách thành công");
                            loadSach();
                        }
                        else
                        {
                            MessageBox.Show("Xóa sách thất bại!");
                        }
                    }
                    catch
                    {
                        MessageBox.Show("Xóa sách thành công");
                        loadSach();
                    }


                }
                else
                {

                }

            }
        }

        private void tb_timkiem_TextChanged(object sender, EventArgs e)
        {
            if (cbb_boloc.Text == "Mã sách")
            {
                dgv_sach.Rows.Clear();
                DataSet data = sachBUS.timKiemSachTheoMaSach(tb_timkiem.Text.Trim());

                foreach (DataRow row in data.Tables[0].Rows)
                {
                    // Thêm dữ liệu từ mỗi dòng của DataSet vào DataGridView
                    dgv_sach.Rows.Add(row.ItemArray);
                }
            }

            if (cbb_boloc.Text == "Tên sách")
            {
                dgv_sach.Rows.Clear();
                DataSet data = sachBUS.timKiemSachTheoTenSach(tb_timkiem.Text.Trim());

                foreach (DataRow row in data.Tables[0].Rows)
                {
                    // Thêm dữ liệu từ mỗi dòng của DataSet vào DataGridView
                    dgv_sach.Rows.Add(row.ItemArray);
                }
            }

            if (cbb_boloc.Text == "Mã loại")
            {
                dgv_sach.Rows.Clear();
                DataSet data = sachBUS.timKiemSachTheoMaLoai(tb_timkiem.Text.Trim());

                foreach (DataRow row in data.Tables[0].Rows)
                {
                    // Thêm dữ liệu từ mỗi dòng của DataSet vào DataGridView
                    dgv_sach.Rows.Add(row.ItemArray);
                }
            }
        }

        private void chk_dongTG_CheckedChanged(object sender, EventArgs e)
        {
            if (chk_dongTG.Checked == true)
            {
                tb_ma_sach.Enabled = false;
                tb_ten_sach.Enabled = false;
                dtp_nam_xb.Enabled = false;
                tb_so_luong.Enabled = false;
                cbb_ma_loai.Enabled = false;
                tb_gia_tien.Enabled = false;
                cbb_nha_xb.Enabled = false;
            }
            else
            {
                tb_ten_sach.Enabled = true;
                dtp_nam_xb.Enabled = true;
                tb_so_luong.Enabled = true;
                cbb_ma_loai.Enabled = true;
                tb_gia_tien.Enabled = true;
                cbb_nha_xb.Enabled = true;
            }
        }

        private void btn_in_Click(object sender, EventArgs e)
        {
            DataSet dataSet = sachBUS.getSachChocLoc();

            if (dataSet.Tables.Count > 0 && dataSet.Tables[0].Rows.Count > 0)
            {
                DSSachChonLoc r = new DSSachChonLoc();
                r.SetDataSource(dataSet.Tables[0]);


                ShowReport f = new ShowReport();

                f.crystalReportViewer1.ReportSource = r;
                f.ShowDialog();
            }
            else
            {
                MessageBox.Show("Không có phiếu mượn hợp lệ.");
            }
        }
    }
}

