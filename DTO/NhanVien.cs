using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class NhanVien
    {
        private string sMaNV;
        private string sTenNV;
        private string sGioiTinh;
        private string sDiaChi;
        private string sSDT;
        private string sMaChucVu;
        private DateTime dNgaySinh;

        public NhanVien() 
        { 
        
        }

        public NhanVien(string sMaNV, string sTenNV, string sGioiTinh, string sDiaChi, string sSDT, string sMaChucVu, DateTime dNgaySinh)
        {
            this.sMaNV = sMaNV;
            this.sTenNV = sTenNV;
            this.sGioiTinh = sGioiTinh;
            this.sDiaChi = sDiaChi;
            this.sSDT = sSDT;
            this.sMaChucVu = sMaChucVu;
            this.dNgaySinh = dNgaySinh;
        }

        public string SMaNV { get => sMaNV; set => sMaNV = value; }
        public string STenNV { get => sTenNV; set => sTenNV = value; }
        public string SGioiTinh { get => sGioiTinh; set => sGioiTinh = value; }
        public string SDiaChi { get => sDiaChi; set => sDiaChi = value; }
        public string SSDT { get => sSDT; set => sSDT = value; }
        public string SMaChucVu { get => sMaChucVu; set => sMaChucVu = value; }
        public DateTime DNgaySinh { get => dNgaySinh; set => dNgaySinh = value; }
    }
}
