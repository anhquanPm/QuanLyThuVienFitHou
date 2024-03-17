using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class Sach
    {
        private string sMaSach;
        private string sTenSach;
        private DateTime dNamXB;
        private int iSoLuong;
        private string sMaLoai;
        private string sTenTG;
        private float fGiaTien;
        private string sMaNxb;



        public Sach() { }

        public Sach(string sMaSach, string sTenSach, DateTime dNamXB, int iSoLuong, string sMaLoai, string sTenTG, float fGiaTien, string sMaNxb)
        {
            this.sMaSach = sMaSach;
            this.sTenSach = sTenSach;
            this.dNamXB = dNamXB;
            this.iSoLuong = iSoLuong;
            this.sMaLoai = sMaLoai;
            this.sTenTG = sTenTG;
            this.fGiaTien = fGiaTien;
            this.sMaNxb = sMaNxb;
        }

        public string SMaSach { get => sMaSach; set => sMaSach = value; }
        public string STenSach { get => sTenSach; set => sTenSach = value; }
        public DateTime DNamXB { get => dNamXB; set => dNamXB = value; }
        public int ISoLuong { get => iSoLuong; set => iSoLuong = value; }
        public string SMaLoai { get => sMaLoai; set => sMaLoai = value; }
        public string STenTG { get => sTenTG; set => sTenTG = value; }
        public float FGiaTien { get => fGiaTien; set => fGiaTien = value; }
        public string SMaNxb { get => sMaNxb; set => sMaNxb = value; }
    }
}
