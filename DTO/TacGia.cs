using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class TacGia
    {
        private string sMaTG;
        private string sTenTG;
        private string sDiaChi;
        private string sSdt;

        public TacGia(string sMaTG, string sTenTG, string sDiaChi, string sSdt)
        {
            this.sMaTG = sMaTG;
            this.sTenTG = sTenTG;
            this.sDiaChi = sDiaChi;
            this.sSdt = sSdt;
        }

        public TacGia() { }

        public string SMaTG { get => sMaTG; set => sMaTG = value; }
        public string STenTG { get => sTenTG; set => sTenTG = value; }
        public string SDiaChi { get => sDiaChi; set => sDiaChi = value; }
        public string SSdt { get => sSdt; set => sSdt = value; }
    }
}
