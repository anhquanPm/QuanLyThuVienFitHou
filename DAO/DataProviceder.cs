using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;
namespace DAO
{

    public class SqlConnectionData
    {
        public static SqlConnection Connection()
        {
            string strConn = @"Data Source=ANHQUAN;Initial Catalog=QuanLyThuVien;Integrated Security=True";
            SqlConnection conn = new SqlConnection(strConn); // khởi tạo connection
            return conn;
        }
    }

    public class DataProviceder
    {
        
        public static string checkLoginDTO(TaiKhoan taiKhoan)
        {
            string user = null;
            // Hàm này sẽ kết nối đến CSDL 
            SqlConnection conn = SqlConnectionData.Connection();
            conn.Open();
            SqlCommand cmd = new SqlCommand("proc_login", conn);
            cmd.CommandType = System.Data.CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@user", taiKhoan.SUserName);
            cmd.Parameters.AddWithValue("@pass", taiKhoan.SPassWord);

            cmd.Connection = conn;

            SqlDataReader reader = cmd.ExecuteReader();
            if(reader.HasRows) // nếu có dữ liệu
            {
               while(reader.Read()) // đọc hết những dòng mà kết quả trả về
                {
                    user = reader.GetString(0);
                    return user;
                }
               reader.Close();
                conn.Close();
            }
            else
            {
                return "Tài khoản hoặc mật khẩu không chính xác !";
            }
            return user;
        }

    }
}
