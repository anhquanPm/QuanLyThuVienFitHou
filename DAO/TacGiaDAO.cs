using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAO
{
    public class TacGiaDAO:DataProviceder
    {
        public DataSet dsTacGia()
        {
            Dictionary<string, object> parameters = new Dictionary<string, object>();
            return GetDataDTO("proc_dsTacGia", parameters);
        }

        public int themTacGia(string maTG, string tenTG, string diaChi, string sdt)
        {
            Dictionary<string, object> parameters = new Dictionary<string, object>();
            parameters.Add("@maTG", maTG);
            parameters.Add("@tenTG", tenTG);
            parameters.Add("@diaChi", diaChi);
            parameters.Add("@sdt", sdt);
            return them_sua_xoa("proc_themTacGia", parameters);
        }

        public int capNhatTacGia(string maTG, string tenTG, string diaChi, string sdt)
        {
            Dictionary<string, object> parameters = new Dictionary<string, object>();
            parameters.Add("@maTG", maTG);
            parameters.Add("@tenTG", tenTG);
            parameters.Add("@diaChi", diaChi);
            parameters.Add("@sdt", sdt);
            return them_sua_xoa("proc_capNhatTacGia", parameters);
        }

        public int xoaTacGia(string maTG)
        {
            Dictionary<string, object> parameters = new Dictionary<string, object>();
            parameters.Add("@maTG", maTG);
            return them_sua_xoa("proc_xoaTacGia", parameters);
        }

        public DataSet timKiemTacGiaTheoTen(string tenTG)
        {
            Dictionary<string, object> parameters = new Dictionary<string, object>();
            parameters.Add("@tenTG", tenTG);
            return GetDataDTO("proc_timKiemTGTheoTen", parameters);
        }

        public DataSet timKiemTacGiaTheoMaTG(string maTG)
        {
            Dictionary<string, object> parameters = new Dictionary<string, object>();
            parameters.Add("@maTG", maTG);
            return GetDataDTO("proc_timKiemTGTheoMaTG", parameters);
        }
    }
}
