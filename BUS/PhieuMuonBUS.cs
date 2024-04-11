using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAO;
namespace BUS
{
    public class PhieuMuonBUS
    {
        PhieuMuonDAO phieuMuonDAO = new PhieuMuonDAO();
        public DataSet ds_phieuMuon()
        {
            return phieuMuonDAO.ds_phieuMuon();
        }

<<<<<<< HEAD
        public DataSet ds_phieuMuonTheoMa(string maPM)
        {
            return phieuMuonDAO.ds_phieuMuonTheoMa(maPM);
        }

=======
>>>>>>> 6fbe207437f69b598926bfb73747f3013897ac5e
        public int themPhieuMuon(string maPM, string maDG, string ngayMuon, string maNV,
                                   string maSach, string maLoaiPhieu)
        {
            return phieuMuonDAO.themPhieuMuon(maPM, maDG, ngayMuon, maNV, maSach, maLoaiPhieu);
        }

        public int themChiTietPhieuMuon(string maPM, string maSach, string maLoaiPhieu)
        {
            return phieuMuonDAO.themChiTietPhieuMuon(maPM, maSach, maLoaiPhieu);

<<<<<<< HEAD
        }

        public int xoaPhieuMuon(string PM)
        {
            return phieuMuonDAO.xoaPhieuMuon(PM);
        }

        public int capNhatPhieuMuon(string maPM, string maSach, string maLoaiPhieu)
        {
            return phieuMuonDAO.capNhatPhieuMuon(maPM, maSach, maLoaiPhieu);
        }

        public DataSet timKiemPhieuMuonTheoMaPM(string maPM)
        {
            return phieuMuonDAO.timKiemPhieuMuonTheoMaPM(maPM);
        }

        public DataSet timKiemPhieuMuonTheoMaDG(string maDG)
        {
            return phieuMuonDAO.timKiemPhieuMuonTheoMaDG(maDG);
        }

=======
        } 
>>>>>>> 6fbe207437f69b598926bfb73747f3013897ac5e
    }
}
