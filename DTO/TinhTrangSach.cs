using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class TinhTrangSach
    {
        private int iMaTinhTrang;
        private string sTinhTrangSach;

        public TinhTrangSach(int iMaTinhTrang, string sTinhTrangSach)
        {
            this.iMaTinhTrang = iMaTinhTrang;
            this.sTinhTrangSach = sTinhTrangSach;
        }

        public TinhTrangSach() { }

        public int IMaTinhTrang { get => iMaTinhTrang; set => iMaTinhTrang = value; }
        public string STinhTrangSach { get => sTinhTrangSach; set => sTinhTrangSach = value; }
    }
}
