using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;
using DAO;
using System.Runtime.InteropServices.WindowsRuntime;
namespace BUS
{
    public class TaiKhoanBUS
    {
        TaiKhoanDAO taiKhoanDAO = new TaiKhoanDAO();
        public string checkLogin(TaiKhoan taiKhoan)
        {
            // kiem tra nghiep vu
            if(taiKhoan.SUserName == "")
            {
                return "requeid_taiKhoan";
            }

            if(taiKhoan.SPassWord == "")
            {
                return "requeid_matKhau";
            }

            string infor = taiKhoanDAO.checkLogin(taiKhoan);
            return infor;
        }
    }
}
