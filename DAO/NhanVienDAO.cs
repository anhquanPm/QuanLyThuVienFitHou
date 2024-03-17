using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;
namespace DAO
{
    public class NhanVienDAO:DataProviceder
    {
        // Phương thức này để lấy dữ liệu của nhân viên từ stored procedure
        public DataSet GetNhanVienData()
        {
            // Tạo một từ điển chứa các tham số (nếu cần)
            Dictionary<string, object> parameters = new Dictionary<string, object>();

            // Gọi hàm GetDataDTO từ lớp cơ sở DataProviceder để lấy dữ liệu
            // Chúng ta truyền tên của stored procedure và từ điển tham số vào hàm này
            return GetDataDTO("proc_getNhanVien", parameters);
        }
    }
}
