using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAO;
namespace BUS
{
    public class PhieuMuonBUS
    {
        PhieuMuonDAO phieuMuonDAO = new PhieuMuonDAO();
        public DataSet ds_phieuMuon()
        {
            return phieuMuonDAO.ds_phieuMuon();
        }
             
    }
}
