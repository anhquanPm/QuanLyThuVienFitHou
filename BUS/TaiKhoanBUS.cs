using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;
using DAO;
using System.Runtime.InteropServices.WindowsRuntime;
using System.Data;
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

        public DataSet getTaiKhoanData(string taiKhoan, string matkhau)
        {
            return taiKhoanDAO.GetDataTaiKhoan(taiKhoan, matkhau);
        }

        public DataSet getTaiKhoanDataDMK(string taiKhoan, string matkhau)
        {
            return taiKhoanDAO.GetDataTaiKhoanDMK(taiKhoan, matkhau);
        }

        public DataSet checkQuyen(string tenTaiKhoan, string matKhau)
        {
            return taiKhoanDAO.checkQuyen(tenTaiKhoan, matKhau);
        }

        public int updateTaiKhoanData(string manv, string tennv, string gioitinh,
            string diachi, string sdt, string ngaysinh)
        {
            return taiKhoanDAO.UpdateTaiKhoan(manv, tennv, gioitinh, diachi, sdt, ngaysinh);
        }

        public int doiMatKhau(string tenTaiKhoan, string matKhau)
        {
            return taiKhoanDAO.DoiMatKhau(tenTaiKhoan, matKhau);
        }

        public DataSet quanLyTaiKhoan()
        {
            return taiKhoanDAO.quanLyTaiKhoan();
        }

        public int capNhatTaiKhoan(string user, string pass, bool quyen)
        {
            return taiKhoanDAO.capNhatTaiKhoan(user, pass, quyen);
        }

        public int themTaiKhoan(string user, string pass, string maNV ,bool quyen)
        {
            return taiKhoanDAO.themTaiKhoan(user, pass, maNV, quyen);
        }

        public int xoaTaiKhoan(string user)
        {
            return taiKhoanDAO.xoaTaiKhoan(user);
        }

        public DataSet timKiemTaiKhoanTheoUser(string user)
        {
            return taiKhoanDAO.timKiemTKTheoUser(user);
        }

        public DataSet timKiemTaiKhoanTheoMaNV(string maNV)
        {
            return taiKhoanDAO.timKiemTKTheoMaNV(maNV);
        }

    }
}
