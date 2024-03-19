using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class LoaiPhieu
    {
        private int sMaLoaiPhieu;
        private string sTenLoaiPhieu;

        public LoaiPhieu(int sMaLoaiPhieu, string sTenLoaiPhieu)
        {
            this.sMaLoaiPhieu = sMaLoaiPhieu;
            this.sTenLoaiPhieu = sTenLoaiPhieu;
        }

        public LoaiPhieu() { }

        public int SMaLoaiPhieu { get => sMaLoaiPhieu; set => sMaLoaiPhieu = value; }
        public string STenLoaiPhieu { get => sTenLoaiPhieu; set => sTenLoaiPhieu = value; }
    }
}
