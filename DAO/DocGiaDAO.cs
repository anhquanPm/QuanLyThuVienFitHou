using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;
namespace DAO
{
    public class DocGiaDAO: DataProviceder
    {
        public DataSet getDataDocGia()
        {
            Dictionary<string, object> parameters = new Dictionary<string, object>();
            return GetDataDTO("proc_dsDocGia", parameters);
        }

        public int suaDocGia(string maDG, string tenDG, string ngaySinh, string gioiTinh,
            string diaChi, string sdt)
        {
            Dictionary<string, object> parameters = new Dictionary<string, object>();
            parameters.Add("@maDG", maDG);
            parameters.Add("@tenDG", tenDG);
            parameters.Add("@ngaySinh", ngaySinh);
            parameters.Add("@gioiTinh", gioiTinh);
            parameters.Add("@diaChi", diaChi);
            parameters.Add("@sdt", sdt);

            return them_sua_xoa("proc_suaDocGia", parameters);
        }

        public int themDocGia(string maDG, string tenDG, string ngaySinh, string gioiTinh,
            string diaChi, string sdt)
        {
            Dictionary<string, object> parameters = new Dictionary<string, object>();
            parameters.Add("@maDG", maDG);
            parameters.Add("@tenDG", tenDG);
            parameters.Add("@ngaySinh", ngaySinh);
            parameters.Add("@gioiTinh", gioiTinh);
            parameters.Add("@diaChi", diaChi);
            parameters.Add("@sdt", sdt);

            return them_sua_xoa("proc_themDocGia", parameters);
        }

        public int xoaDocGia(string maDG)
        {
            Dictionary<string, object> parameters = new Dictionary<string, object>();
            parameters.Add("@maDG", maDG);

            return them_sua_xoa("proc_xoaDocGia", parameters);
        }

        public DataSet timKiemDocGiaTheoTen(string tenDG)
        {
            Dictionary<string, object> parameters = new Dictionary<string, object>();
            parameters.Add("@tenDG", tenDG);

            return GetDataDTO("proc_timKiemDocGiaTheoTen", parameters);
        }

        public DataSet timKiemDocGiaTheoMaDG(string maDG)
        {
            Dictionary<string, object> parameters = new Dictionary<string, object>();
            parameters.Add("@maDG", maDG);

            return GetDataDTO("proc_timKiemDocGiaTheoMaDG", parameters);
        }

    }
}
