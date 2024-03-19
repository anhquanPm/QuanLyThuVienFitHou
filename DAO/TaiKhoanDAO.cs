using System;
using System.Collections.Generic;
using System.Data;
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



        public int UpdateTaiKhoan(string manv, string tennv, string gioitinh, 
            string diachi, string sdt, string ngaysinh)
        {
            Dictionary<string, object> parameters = new Dictionary<string, object>();
            parameters.Add("@maNV", manv);
            parameters.Add("@tenNV", tennv);
            parameters.Add("@gioiTinh", gioitinh);
            parameters.Add("@diaChi", diachi);
            parameters.Add("@sdt", manv);
            parameters.Add("@ngaySinh", ngaysinh);

            return them_sua_xoa("proc_capNhatNhanVien", parameters);
        }

    }
}
