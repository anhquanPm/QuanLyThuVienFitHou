using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using System.Text;
using System.Threading.Tasks;
using DTO;
namespace DAO
{
    public class NhanVienDAO:DataProviceder
    {
        // Phương thức này để lấy dữ liệu của nhân viên từ stored procedure
        public DataSet GetNhanVienData()
        {
            // Tạo một từ điển chứa các tham số (nếu cần)
            Dictionary<string, object> parameters = new Dictionary<string, object>();

            // Gọi hàm GetDataDTO từ lớp cơ sở DataProviceder để lấy dữ liệu
            // Chúng ta truyền tên của stored procedure và từ điển tham số vào hàm này
            return GetDataDTO("proc_getNhanVien", parameters);
        }

        public int upDateNhanVien(string manv, string tennv, string gioitinh,
            string diachi, string sdt, string macv, string ngaysinh)
        {
            Dictionary<string, object> parameters = new Dictionary<string, object>();
            parameters.Add("@maNV", manv);
            parameters.Add("@tenNV", tennv);
            parameters.Add("@gioiTinh", gioitinh);
            parameters.Add("@diaChi", diachi);
            parameters.Add("@sdt", sdt);
            parameters.Add("@macv", macv);
            parameters.Add("@ngaySinh", ngaysinh);
            return them_sua_xoa("proc_capNhatNhanVienQLNV", parameters);
        }

        public int themNhanVien(string manv, string tennv, string gioitinh,
            string diachi, string sdt, string macv, string ngaysinh)
        {
            Dictionary<string, object> parameters = new Dictionary<string, object>();
            parameters.Add("@maNV", manv);
            parameters.Add("@tenNV", tennv);
            parameters.Add("@gioiTinh", gioitinh);
            parameters.Add("@diaChi", diachi);
            parameters.Add("@sdt", sdt);
            parameters.Add("@macv", macv);
            parameters.Add("@ngaySinh", ngaysinh);
            return them_sua_xoa("proc_themNhanVien", parameters);
        }

        public int xoaNhanVien(string manv)
        {
            Dictionary<string, object> parameters = new Dictionary<string, object>();
            parameters.Add("@manv", manv);
            return them_sua_xoa("proc_xoaNhanVien", parameters);
        }

        public DataSet timKiemTheoMaNV(string manv)
        {
            Dictionary<string, object> parameters = new Dictionary<string, object>();
            parameters.Add("@manv", manv);
            return GetDataDTO("proc_timKiemTheoMaNV", parameters);
        }

        public DataSet timKiemTheoTen(string tennv)
        {
            Dictionary<string, object> parameters = new Dictionary<string, object>();
            parameters.Add("@tennv", tennv);
            return GetDataDTO("proc_timKiemTheoTenNV", parameters);
        }
    }
}
