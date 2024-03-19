using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;
namespace DAO
{
    public class SachDAO:DataProviceder
    {
        public DataSet getSachData()
        {
            Dictionary<string, object> parameters = new Dictionary<string, object>();
            return GetDataDTO("proc_getSach", parameters);
        }

        public int themSach(string maSach, string tenSach, string namXb, int soLuong,
            string maLoai, string maTG, float giaTien, string maNXB)
        {
            Dictionary<string, object> parameters = new Dictionary<string, object>();
            parameters.Add("@maSach", maSach);
            parameters.Add("@tenSach", tenSach);
            parameters.Add("@namXB", namXb);
            parameters.Add("@soLuong", soLuong);
            parameters.Add("@maLoai", maLoai);
            parameters.Add("@maTacGia", maTG);
            parameters.Add("@giaTien", giaTien);
            parameters.Add("@maNXB", maNXB);
            return them_sua_xoa("proc_themSach", parameters);
        }

        public int capNhatSach(string maSach, string tenSach, string namXb, int soLuong,
            string maLoai, string maTG, float giaTien, string maNXB)
        {
            Dictionary<string, object> parameters = new Dictionary<string, object>();
            parameters.Add("@maSach", maSach);
            parameters.Add("@tenSach", tenSach);
            parameters.Add("@namXB", namXb);
            parameters.Add("@soLuong", soLuong);
            parameters.Add("@maLoai", maLoai);
            parameters.Add("@maTacGia", maTG);
            parameters.Add("@giaTien", giaTien);
            parameters.Add("@maNXB", maNXB);
            return them_sua_xoa("proc_capNhatSach", parameters);
        }

        public int xoaSach(string maSach)
        {
            Dictionary<string, object> parameters = new Dictionary<string, object>();
            parameters.Add("@maSach", maSach);
            return them_sua_xoa("proc_xoaSach", parameters);
        }

        public DataSet timKiemSachTheoMaSach(string maSach)
        {
            Dictionary<string, object> parameters = new Dictionary<string, object>();
            parameters.Add("@maSach", maSach);
            return GetDataDTO("proc_timKiemTheoMaSach", parameters);
        }

        public DataSet timKiemSachTheoTenSach(string tenSach)
        {
            Dictionary<string, object> parameters = new Dictionary<string, object>();
            parameters.Add("@tenSach", tenSach);
            return GetDataDTO("proc_timKiemTheoTenSach", parameters);
        }

        public DataSet timKiemSachTheoMaLoai(string maLoai)
        {
            Dictionary<string, object> parameters = new Dictionary<string, object>();
            parameters.Add("@maLoai", maLoai);
            return GetDataDTO("proc_timKiemTheoMaLoai", parameters);
        }
    }
}
