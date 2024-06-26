﻿using System;
using System.Collections.Generic;
using System.Data;
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

        public static DataSet GetDataDTO(string procName, Dictionary<string, object> parameters)
        {
            DataSet dataSet = new DataSet();
            using (SqlConnection conn = SqlConnectionData.Connection())
            {
                conn.Open();
                using (SqlCommand cmd = new SqlCommand(procName, conn))
                {
                    cmd.CommandType = CommandType.StoredProcedure;

                    // Thêm các tham số vào command
                    foreach (var param in parameters)
                    {
                        cmd.Parameters.AddWithValue(param.Key, param.Value);
                    }

                    using (SqlDataAdapter adapter = new SqlDataAdapter(cmd))
                    {
                        // Đổ dữ liệu vào DataSet
                        adapter.Fill(dataSet);
                    }
                }
            }
            return dataSet;
        }

        public static int them_sua_xoa(string procName, Dictionary<string, object> parameters)
        {
            using (SqlConnection conn = SqlConnectionData.Connection())
            {
                conn.Open();
                using (SqlCommand cmd = new SqlCommand(procName, conn))
                {
                    cmd.CommandType = CommandType.StoredProcedure;

                    // Thêm các tham số vào command
                    foreach (var param in parameters)
                    {
                        cmd.Parameters.AddWithValue(param.Key, param.Value);
                    }
                    // Thực thi stored procedure cập nhật và trả về số dòng ảnh hưởng
                    return cmd.ExecuteNonQuery();
                }
            }
        }

        public static bool CheckPrimaryKeyExist(string tableName, string primaryKeyColumnName, object primaryKeyValue)
        {
            bool isExist = false;
            try
            {
                using (SqlConnection conn = SqlConnectionData.Connection())
                {
                    conn.Open();

                    string query = $"SELECT COUNT(*) FROM {tableName} WHERE {primaryKeyColumnName} = @PrimaryKeyValue";

                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@PrimaryKeyValue", primaryKeyValue);

                        int count = (int)cmd.ExecuteScalar();

                        if (count > 0)
                        {
                            isExist = true;
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error: " + ex.Message);
            }
            return isExist;
        }
    }
}
