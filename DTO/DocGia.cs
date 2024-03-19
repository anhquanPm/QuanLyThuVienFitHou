using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class DocGia
    {
        private string sMaDG;
        private string sTenDG;
        private DateTime dNgaySinh;
        private bool bGioiTinh;
        private string sDiaChi;
        private string sSdt;

        public DocGia(string sMaDG, string sTenDG, DateTime dNgaySinh, bool bGioiTinh, string sDiaChi, string sSdt)
        {
            this.sMaDG = sMaDG;
            this.sTenDG = sTenDG;
            this.dNgaySinh = dNgaySinh;
            this.bGioiTinh = bGioiTinh;
            this.sDiaChi = sDiaChi;
            this.sSdt = sSdt;
        }

        public DocGia() { }

        public string SMaDG { get => sMaDG; set => sMaDG = value; }
        public string STenDG { get => sTenDG; set => sTenDG = value; }
        public DateTime DNgaySinh { get => dNgaySinh; set => dNgaySinh = value; }
        public bool BGioiTinh { get => bGioiTinh; set => bGioiTinh = value; }
        public string SDiaChi { get => sDiaChi; set => sDiaChi = value; }
        public string SSdt { get => sSdt; set => sSdt = value; }
    }
}
