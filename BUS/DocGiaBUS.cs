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
    public class DocGiaBUS
    {
        DocGiaDAO docGiaDAO = new DocGiaDAO();
        public DataSet dsDocGia()
        {
            return docGiaDAO.getDataDocGia();
        }

        public int themDocGia(string maDG, string tenDG, string ngaySinh, string gioiTinh,
            string diaChi, string sdt)
        {
            return docGiaDAO.themDocGia(maDG, tenDG, ngaySinh, gioiTinh, diaChi, sdt);
        }

        public int suaDocGia(string maDG, string tenDG, string ngaySinh, string gioiTinh,
            string diaChi, string sdt)
        {
            return docGiaDAO.suaDocGia(maDG, tenDG, ngaySinh, gioiTinh, diaChi, sdt);
        }

        public int xoaDocGia(string maDG)
        {
            return docGiaDAO.xoaDocGia(maDG);
        }

        public DataSet timKiemDocGiaTheoTen(string tenDG)
        {
            return docGiaDAO.timKiemDocGiaTheoTen(tenDG);
        }

        public DataSet timKiemDocGiaTheoMaDG(string maDG)
        {
            return docGiaDAO.timKiemDocGiaTheoMaDG(maDG);
        }
    }
}
