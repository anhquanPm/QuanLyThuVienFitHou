using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class TaiKhoan
    {
        private string sUserName;
        private string sPassWord;
        private string sMaNV;
        private bool bQuyen;

        public TaiKhoan(string sUserName, string sPassWord, string sMaNV, bool bQuyen1)
        {
            SUserName = sUserName;
            SPassWord = sPassWord;
            SMaNV = sMaNV;
            BQuyen1 = bQuyen1;
        }

        public TaiKhoan() { }

        public string SUserName { get => sUserName; set => sUserName = value; }
        public string SPassWord { get => sPassWord; set => sPassWord = value; }
        public string SMaNV { get => sMaNV; set => sMaNV = value; }
        public bool BQuyen1 { get => bQuyen; set => bQuyen = value; }
    }
}
