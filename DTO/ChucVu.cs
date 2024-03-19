using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class ChucVu
    {
        private string sMaChucVu;
        private string sTenChucVu;

        public ChucVu(string sMaChucVu, string sTenChucVu)
        {
            this.sMaChucVu = sMaChucVu;
            this.sTenChucVu = sTenChucVu;
        }

        public ChucVu() { }

        public string SMaChucVu { get => sMaChucVu; set => sMaChucVu = value; }
        public string STenChucVu { get => sTenChucVu; set => sTenChucVu = value; }
    }
}
