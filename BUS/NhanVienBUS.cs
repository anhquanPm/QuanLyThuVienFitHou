using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAO;
using DTO;
namespace BUS
{
    public class NhanVienBUS
    {
        NhanVienDAO NhanVienDAO = new NhanVienDAO();
        public DataSet GetNhanVienDAO()
        {
            return NhanVienDAO.GetNhanVienData();
        }

        public int updateNhanVien(string manv, string tennv, string gioitinh,
            string diachi, string sdt, string macv, string ngaysinh)
        {
            return NhanVienDAO.upDateNhanVien(manv, tennv, gioitinh, diachi, sdt, macv ,ngaysinh);
        }

        public int themNhanVien(string manv, string tennv, string gioitinh,
           string diachi, string sdt, string macv, string ngaysinh)
        {
            return NhanVienDAO.themNhanVien(manv, tennv, gioitinh, diachi, sdt, macv, ngaysinh);
        }

        public int xoaNhanVien(string manv)
        {
            return NhanVienDAO.xoaNhanVien(manv);
        }

        public DataSet timKiemNhanVienTheoMaNV(string manv)
        {
            return NhanVienDAO.timKiemTheoMaNV(manv);
        }

        public DataSet timKiemNhanVienTheoTen(string tennv)
        {
            return NhanVienDAO.timKiemTheoTen(tennv);
        }
    }
}
