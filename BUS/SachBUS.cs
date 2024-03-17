using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;
using DAO;
namespace BUS
{
    public class SachBUS
    {
        SachDAO sachDAO = new SachDAO();
        public DataSet getSachData()
        {
            return sachDAO.getSachData();
        }
    }
}
