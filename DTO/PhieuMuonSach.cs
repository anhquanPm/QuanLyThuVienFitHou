using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class PhieuMuonSach
    {
        private string sMaPhieuMuon;
        private string sMaDocGia;
        private DateTime dNgayMuon;
        private string sMaNV;

        public PhieuMuonSach(string sMaPhieuMuon, string sMaDocGia, DateTime dNgayMuon, string sMaNV)
        {
            this.sMaPhieuMuon = sMaPhieuMuon;
            this.sMaDocGia = sMaDocGia;
            this.dNgayMuon = dNgayMuon;
            this.sMaNV = sMaNV;
        }

        public PhieuMuonSach()
        {

        }

        public string SMaPhieuMuon { get => sMaPhieuMuon; set => sMaPhieuMuon = value; }
        public string SMaDocGia { get => sMaDocGia; set => sMaDocGia = value; }
        public DateTime DNgayMuon { get => dNgayMuon; set => dNgayMuon = value; }
        public string SMaNV { get => sMaNV; set => sMaNV = value; }
    }
}
