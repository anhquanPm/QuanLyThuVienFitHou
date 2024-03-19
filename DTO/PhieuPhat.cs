using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class PhieuPhat
    {
        private string sMaPhieuPhat;
        private string sMaPhieuTra;
        private float fTienPhat;
        private string sGhiChu;

        public PhieuPhat(string sMaPhieuPhat, string sMaPhieuTra, float fTienPhat, string sGhiChu)
        {
            this.sMaPhieuPhat = sMaPhieuPhat;
            this.sMaPhieuTra = sMaPhieuTra;
            this.fTienPhat = fTienPhat;
            this.sGhiChu = sGhiChu;
        }

        public PhieuPhat() { }

        public string SMaPhieuPhat { get => sMaPhieuPhat; set => sMaPhieuPhat = value; }
        public string SMaPhieuTra { get => sMaPhieuTra; set => sMaPhieuTra = value; }
        public float FTienPhat { get => fTienPhat; set => fTienPhat = value; }
        public string SGhiChu { get => sGhiChu; set => sGhiChu = value; }
    }
}
