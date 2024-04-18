using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using DAO;
using DTO;
namespace BUS
{
    public class PhieuTraSachBUS
    {
       PhieuTraSachDAO phieuTraSachDAO = new PhieuTraSachDAO();
        public DataSet dsPhieuTraSach()
        {
            return phieuTraSachDAO.dsPhieuTra();
        }

        public int themPhieuTraSach(string maPT, string maSach,string maPM ,string maNV,
            string ngayTra, string maDG, int maTT)
        {

            return phieuTraSachDAO.themPhieuTraSach(maPT, maSach, maPM, maNV, ngayTra, maDG, maTT);
        }

        public int capNhatPhieuTraSach(string maPT, string maSach, string maPM, string maNV,
            string ngayTra, string maDG, int maTT)
        {
            return phieuTraSachDAO.capNhatPhieuTraSach(maPT, maSach, maPM, maNV, ngayTra, maDG, maTT);
        }

        public int xoaPhieuTra(string maPT)
        {
            return phieuTraSachDAO.xoaPhieuTraSach(maPT);
        }

        public bool checkMaPT(string tableName, string primaryKeyColumnName, object primaryKeyValue)
        {
            return phieuTraSachDAO.checkMaPT(tableName, primaryKeyColumnName, primaryKeyValue);
        }
    }
}
