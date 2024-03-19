using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;
using DAO;
using System.Runtime.InteropServices.WindowsRuntime;
namespace BUS
{
    public class SachBUS
    {
        SachDAO sachDAO = new SachDAO();
        public DataSet getSachData()
        {
            return sachDAO.getSachData();
        }

        public int themSach(string maSach, string tenSach, string namXb, int soLuong,
            string maLoai, string maTG, float giaTien, string maNXB)
        {
            return sachDAO.themSach(maSach, tenSach, namXb, soLuong, maLoai, maTG, giaTien, maNXB);
        }

        public int capNhatSach(string maSach, string tenSach, string namXb, int soLuong,
            string maLoai, string maTG, float giaTien, string maNXB)
        {
            return sachDAO.capNhatSach(maSach, tenSach, namXb, soLuong, maLoai, maTG, giaTien, maNXB);
        }

        public int xoaSach(string maSach)
        {
            return sachDAO.xoaSach(maSach);
        }

        public DataSet timKiemSachTheoMaSach(string maSach)
        {
            return sachDAO.timKiemSachTheoMaSach(maSach);
        }

        public DataSet timKiemSachTheoTenSach(string tenSach)
        {
            return sachDAO.timKiemSachTheoTenSach(tenSach);
        }

        public DataSet timKiemSachTheoMaLoai(string maLoai)
        {
            return sachDAO.timKiemSachTheoMaLoai(maLoai);
        }
    }
}
