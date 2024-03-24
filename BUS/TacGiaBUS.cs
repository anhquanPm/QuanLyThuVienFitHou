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
    public class TacGiaBUS
    {
        TacGiaDAO tacGiaDAO = new TacGiaDAO();
        public DataSet ds_tacGia()
        {
            return tacGiaDAO.dsTacGia();
        }

        public int themTacGia(string maTG, string tenTG, string diaChi, string sdt)
        {
            return tacGiaDAO.themTacGia(maTG, tenTG, diaChi, sdt);
        }

        public int capNhatTacGia(string maTG, string tenTG, string diaChi, string sdt)
        {
            return tacGiaDAO.capNhatTacGia(maTG, tenTG, diaChi, sdt);
        }

        public int xoaTacGia(string maTG)
        {
            return tacGiaDAO.xoaTacGia(maTG);
        }
        
        public DataSet timKiemTacGiaTheoTen(string tenTG)
        {
            return tacGiaDAO.timKiemTacGiaTheoTen(tenTG);
        }

        public DataSet timKiemTacGiaTheoMaTG(string maTG)
        {
            return tacGiaDAO.timKiemTacGiaTheoMaTG(maTG);
        }
    }
}
