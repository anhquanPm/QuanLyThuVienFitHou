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


        public DataSet ds_phieuMuonTheoMa(string maPM)
        {
            return phieuMuonDAO.ds_phieuMuonTheoMa(maPM);
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

        public bool checkKhoaChinh(string tableName, string primaryKeyColumnName, object primaryKeyValue)
        {
            return phieuMuonDAO.checkKhoaChinh(tableName, primaryKeyColumnName, primaryKeyValue);
        }

        } 

    }

