﻿using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using System.Text;
using System.Threading.Tasks;

namespace DAO
{
    public class PhieuTraSachDAO:DataProviceder
    {
        public  DataSet dsPhieuTra()
        {   
            Dictionary<string, object> parameter = new Dictionary<string, object>();
            return GetDataDTO("proc_dsPhieuTraSach", parameter);
        }

        public int themPhieuTraSach(string maPT, string maSach, string maPM, string maNV, string ngayTra,
            string maDG,  int maTT)
        {
            Dictionary<string, object> parameter = new Dictionary<string, object>();
            parameter.Add("@maPhieuTra", maPT);
            parameter.Add("@maSach", maSach);
            parameter.Add("@maPhieuMuon", maPM);
            parameter.Add("@maNV", maNV);
            parameter.Add("@ngayTra", ngayTra);
            parameter.Add("@maDG", maDG);
            parameter.Add("@maTinhTrangSach", maTT);
            return PhieuTraSachDAO.them_sua_xoa("proc_themPhieuTra", parameter);
        }

        public int capNhatPhieuTraSach(string maPT, string maSach, string maPM, string maNV, string ngayTra,
            string maDG, int maTT)
        {
            Dictionary<string, object> parameter = new Dictionary<string, object>();
            parameter.Add("@maPhieuTra", maPT);
            parameter.Add("@maSach", maSach);
            parameter.Add("@maPhieuMuon", maPM);
            parameter.Add("@maNV", maNV);
            parameter.Add("@ngayTra", ngayTra);
            parameter.Add("@maDG", maDG);
            parameter.Add("@maTinhTrangSach", maTT);
            return PhieuTraSachDAO.them_sua_xoa("proc_capNhatPhieuTRa", parameter);
        }

        public int xoaPhieuTraSach(string maPT)
        {
            Dictionary<string, object> parameter = new Dictionary<string, object>();
            parameter.Add("@maPhieuTra", maPT);
            return PhieuTraSachDAO.them_sua_xoa("proc_XoaPhieuTra", parameter);

        }

        public bool checkMaPT(string tableName, string primaryKeyColumnName, object primaryKeyValue)
        {
            return PhieuTraSachDAO.CheckPrimaryKeyExist(tableName, primaryKeyColumnName, primaryKeyValue);  
        }
    }
}
