using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAO;
using DTO;
namespace BUS
{
    public class NhanVienBUS
    {
        NhanVienDAO NhanVienDAO = new NhanVienDAO();
        public DataSet GetNhanVienDAO()
        {
            return NhanVienDAO.GetNhanVienData();
        }
    }
}
