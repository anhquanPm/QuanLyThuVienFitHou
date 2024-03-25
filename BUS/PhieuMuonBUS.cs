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

        public int themPhieuMuon(string maPM, string maDG, string ngayMuon, string maNV,
                                   string maSach, string maLoaiPhieu)
        {
            return phieuMuonDAO.themPhieuMuon(maPM, maDG, ngayMuon, maNV, maSach, maLoaiPhieu);
        }

        public int themChiTietPhieuMuon(string maPM, string maSach, string maLoaiPhieu)
        {
            return phieuMuonDAO.themChiTietPhieuMuon(maPM, maSach, maLoaiPhieu);

        } 
    }
}
