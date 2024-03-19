using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class TheLoaiSach
    {
        private string sMaLoai;
        private string sTenTheLoai;

        public TheLoaiSach(string sMaLoai, string sTenTheLoai)
        {
            this.sMaLoai = sMaLoai;
            this.sTenTheLoai = sTenTheLoai;
        }

        public TheLoaiSach() { }

        public string SMaLoai { get => sMaLoai; set => sMaLoai = value; }
        public string STenTheLoai { get => sTenTheLoai; set => sTenTheLoai = value; }
    }
}
