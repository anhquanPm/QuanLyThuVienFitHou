using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;
namespace DAO
{
    public class PhieuMuonDAO:DataProviceder
    {
        public DataSet ds_phieuMuon()
        {
            Dictionary<string, object> parameters = new Dictionary<string, object>();
            return GetDataDTO("proc_dsPhieuMuon", parameters);
        }

        public DataSet ds_phieuMuonTheoMa(string maPM)
        {
            Dictionary<string, object> parameters = new Dictionary<string, object>();
            parameters.Add("@maPhieuMuon", maPM);
            return GetDataDTO("proc_dsPhieuMuonTheoMa", parameters);
        }

        public int themPhieuMuon(string maPM, string maDG, string ngayMuon, string maNV,
                                   string maSach, string maLoaiPhieu)
        {
            Dictionary<string, object> parameters = new Dictionary<string, object>();
            parameters.Add("@maPhieuMuon", maPM);
            parameters.Add("@maDG", maDG);
            parameters.Add("@ngayMuon", ngayMuon);
            parameters.Add("@maNV", maNV);
            parameters.Add("@maSach", maSach);
            parameters.Add("@maLoaiPhieu", maLoaiPhieu);
            return them_sua_xoa("proc_themPhieuMuon", parameters);
        }

        public int themChiTietPhieuMuon(string maPM, string maSach, string maLoaiPhieu)
        {
            Dictionary<string, object> parameters = new Dictionary<string, object>();
            parameters.Add("@maPhieuMuon", maPM);
            parameters.Add("@maSach", maSach);
            parameters.Add("@maLoaiPhieu", maLoaiPhieu);
            return them_sua_xoa("proc_themChiTietPhieuMuon", parameters);
        }

        public int xoaPhieuMuon(string maPM)
        {
            Dictionary<string, object> parameters = new Dictionary<string, object>();
            parameters.Add("@maPhieuMuon", maPM);
            return them_sua_xoa("proc_xoaPhieuMuon", parameters);
        }

        public int capNhatPhieuMuon(string maPM, string maSach, string maLoaiPhieu)
        {
            Dictionary<string, object> parameters = new Dictionary<string, object>();
            parameters.Add("@maPhieuMuon", maPM);
            parameters.Add("@maSach", maSach);
            parameters.Add("@maLoaiPhieu", maLoaiPhieu);
            return PhieuMuonDAO.them_sua_xoa("proc_capNhatPhieuMuon", parameters);
        }

        public DataSet timKiemPhieuMuonTheoMaPM(string maPM)
        {
            Dictionary<string, object> parameters = new Dictionary<string, object>();
            parameters.Add("@maPhieuMuon", maPM);
            return GetDataDTO("proc_timKiemPhieuMuonTheoMaPM", parameters);
        }

        public DataSet timKiemPhieuMuonTheoMaDG(string maDG)
        {
            Dictionary<string, object> parameters = new Dictionary<string, object>();
            parameters.Add("@maDG", maDG);
            return GetDataDTO("proc_timKiemPhieuMuonTheoDG", parameters);
        }


    }
}
