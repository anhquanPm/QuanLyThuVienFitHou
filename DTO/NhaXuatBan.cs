using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class NhaXuatBan
    {
        private string sMaNXB;
        private string sTenNXB;

        public NhaXuatBan(string sMaNXB, string sTenNXB)
        {
            this.sMaNXB = sMaNXB;
            this.sTenNXB = sTenNXB;
        }

        public NhaXuatBan() { }

        public string SMaNXB { get => sMaNXB; set => sMaNXB = value; }
        public string STenNXB { get => sTenNXB; set => sTenNXB = value; }
    }
}
