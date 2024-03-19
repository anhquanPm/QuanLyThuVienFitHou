using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class PhieuTraSach
    {
        private string sMaPhieuTra;
        private string sMaPhieuMuon;
        private string sMaNV;
        private DateTime dNgayTra;
        private string sMaDG;

        public PhieuTraSach(string sMaPhieuTra, string sMaPhieuMuon, string sMaNV, DateTime dNgayTra, string sMaDG)
        {
            this.sMaPhieuTra = sMaPhieuTra;
            this.sMaPhieuMuon = sMaPhieuMuon;
            this.sMaNV = sMaNV;
            this.dNgayTra = dNgayTra;
            this.sMaDG = sMaDG;
        }

        public PhieuTraSach() { }

        public string SMaPhieuTra { get => sMaPhieuTra; set => sMaPhieuTra = value; }
        public string SMaPhieuMuon { get => sMaPhieuMuon; set => sMaPhieuMuon = value; }
        public string SMaNV { get => sMaNV; set => sMaNV = value; }
        public DateTime DNgayTra { get => dNgayTra; set => dNgayTra = value; }
        public string SMaDG { get => sMaDG; set => sMaDG = value; }
    }
}
