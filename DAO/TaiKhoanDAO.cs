using System;
using System.Collections.Generic;
using System.Data;
using System.Web;
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

        public DataSet GetDataTaiKhoan(string taikhoan, string matkhau)
        {
            Dictionary<string, object> parameters = new Dictionary<string, object>();
            parameters.Add("@user", taikhoan);
            parameters.Add("@pass", matkhau);
            return GetDataDTO("proc_getTaiKhoan", parameters);
        }

        public DataSet GetDataTaiKhoanDMK(string taikhoan, string matkhau)
        {
            Dictionary<string, object> parameters = new Dictionary<string, object>();
            parameters.Add("@user", taikhoan);
            parameters.Add("@pass", matkhau);
            return GetDataDTO("proc_login", parameters);
        }

        public int DoiMatKhau(string tenTaiKhoan, string matkhau)
        {
            Dictionary<string, object> parameters = new Dictionary<string, object>();
            parameters.Add("@user", tenTaiKhoan);
            parameters.Add("@pass", matkhau);
            return them_sua_xoa("proc_doiMatKhau", parameters);
        }

        public DataSet checkQuyen(string tenTaiKhoan, string matKhau)
        {
            Dictionary<string, object> parameters = new Dictionary<string, object>();
            parameters.Add("@user", tenTaiKhoan);
            parameters.Add("@pass", matKhau);
            return GetDataDTO("proc_checkQuyen", parameters);
        }



        public int UpdateTaiKhoan(string manv, string tennv, string gioitinh, 
            string diachi, string sdt, string ngaysinh)
        {
            Dictionary<string, object> parameters = new Dictionary<string, object>();
            parameters.Add("@maNV", manv);
            parameters.Add("@tenNV", tennv);
            parameters.Add("@gioiTinh", gioitinh);
            parameters.Add("@diaChi", diachi);
            parameters.Add("@sdt", sdt);
            parameters.Add("@ngaySinh", ngaysinh);

            return them_sua_xoa("proc_capNhatNhanVien", parameters);
        }

        public DataSet quanLyTaiKhoan()
        {

            Dictionary<string, object> parameters = new Dictionary<string, object>();
            return GetDataDTO("proc_dsTaiKhoan",parameters);
        }

        public int themTaiKhoan(string user, string pass, string manv, bool quyen)
        {
            Dictionary<string, object> parameters = new Dictionary<string, object>();
            parameters.Add("@user", user);
            parameters.Add("@pass", pass);
            parameters.Add("@maNv", manv);
            parameters.Add("@quyen", quyen);
            return them_sua_xoa("proc_themTaiKhoan", parameters);
        }

        public int capNhatTaiKhoan(string user, string pass,  bool quyen)
        {
            Dictionary<string, object> parameters = new Dictionary<string, object>();
            parameters.Add("@user", user);
            parameters.Add("@pass", pass);
            parameters.Add("@quyen", quyen);
            return them_sua_xoa("proc_capNhatTaiKhoan", parameters);
        }

        public int xoaTaiKhoan(string user)
        {
            Dictionary<string, object> parameters = new Dictionary<string, object>();
            parameters.Add("@user", user);
            return them_sua_xoa("proc_xoaTaiKhoan", parameters);
        }

        public DataSet timKiemTKTheoUser(string user)
        {
            Dictionary<string, object> parameters = new Dictionary<string, object>();
            parameters.Add("@user", user);
            return GetDataDTO("proc_timKiemTKTheoUser", parameters);
        }

        public DataSet timKiemTKTheoMaNV(string maNV)
        {
            Dictionary<string, object> parameters = new Dictionary<string, object>();
            parameters.Add("@maNV", maNV);
            return GetDataDTO("proc_timKiemTheoMaNV", parameters);
        }
    }
}
