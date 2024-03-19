using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class ChiTietPhieuMuon
    {
        private string sMaPhieuMuon;
        private string sMaSach;
        private int iMaLoaiPhieu;
        private DateTime dNgayHenTra;

        public ChiTietPhieuMuon(string sMaPhieuMuon, string sMaSach, int iMaLoaiPhieu, DateTime dNgayHenTra)
        {
            this.sMaPhieuMuon = sMaPhieuMuon;
            this.sMaSach = sMaSach;
            this.iMaLoaiPhieu = iMaLoaiPhieu;
            this.dNgayHenTra = dNgayHenTra;
        }

        public  ChiTietPhieuMuon()
        {

        }

        public string SMaPhieuMuon { get => sMaPhieuMuon; set => sMaPhieuMuon = value; }
        public string SMaSach { get => sMaSach; set => sMaSach = value; }
        public int IMaLoaiPhieu { get => iMaLoaiPhieu; set => iMaLoaiPhieu = value; }
        public DateTime DNgayHenTra { get => dNgayHenTra; set => dNgayHenTra = value; }
    }
}
