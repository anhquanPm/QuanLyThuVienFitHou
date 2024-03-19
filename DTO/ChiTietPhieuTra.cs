using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class ChiTietPhieuTra
    {
        private string sMaPhieuTra;
        private string sMaSach;
        private int iMaTinhTrangSach;
        private int iMaPhieuPhat;

        public ChiTietPhieuTra(string sMaPhieuTra, string sMaSach, int iMaTinhTrangSach, int iMaPhieuPhat)
        {
            this.sMaPhieuTra = sMaPhieuTra;
            this.sMaSach = sMaSach;
            this.iMaTinhTrangSach = iMaTinhTrangSach;
            this.iMaPhieuPhat = iMaPhieuPhat;
        }

        public ChiTietPhieuTra() { }

        public string SMaPhieuTra { get => sMaPhieuTra; set => sMaPhieuTra = value; }
        public string SMaSach { get => sMaSach; set => sMaSach = value; }
        public int IMaTinhTrangSach { get => iMaTinhTrangSach; set => iMaTinhTrangSach = value; }
        public int IMaPhieuPhat { get => iMaPhieuPhat; set => iMaPhieuPhat = value; }
    }
}
