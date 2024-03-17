using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;

namespace DAO
{
    public class TaiKhoanDAO:DataProviceder
    {
       public string checkLogin(TaiKhoan taiKhoan)
        {
            string infor = checkLoginDTO(taiKhoan);
            return infor;
        }

    }
}
