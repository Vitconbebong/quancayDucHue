using QuanLyBanHang.Controllers;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyBanHang.Models
{
    internal class ADO
    {
        private static bool limitedTime; // limit login time
        private static string savedUser, savedPassword;


        #region CREATE CONNECTION TO THE DATABASE
        public static SqlConnection sqlConnection(string username, string password)
        { 
            if (limitedTime)
            {
                username = savedUser;
                password = savedPassword;
            }
            string connectionString = $@"server = VITCONBEBONG;
                                         database = QuanLyBanHang;
                                         user = {username};
                                         password = {password};";
            if (limitedTime) return new SqlConnection(connectionString);    

            SqlConnection connection = new SqlConnection(connectionString);

            try
            {
                connection.Open();

                if (connection.State == ConnectionState.Open)
                {
                    authentication.connectionMessage = "Kết nối thành công.";
                    authentication.connectionStatus = true;
                    limitedTime = true; savedUser = username; savedPassword = password;
                }

                else
                {
                    authentication.connectionMessage = "Kết nối không thành công.";
                    authentication.connectionStatus = false;
                    limitedTime = false;
                }
                    
                
            }
            catch (Exception ex)
            {
                if (ex.Message.Contains("Login failed for user"))
                    authentication.connectionMessage = $"Tên Đăng Nhập hoặc Mật Khẩu Không Đúng! {savedUser}, {savedPassword} ";
                else authentication.connectionMessage = $"Lỗi khi thử kết nối!\n Chi Tiết: {ex.Message}";
            }
            finally
            {
                connection.Close(); 
            }

            return connection;
        }
        #endregion

        #region GET DATA FROM DATABASE
        public static DataTable dataTable (string sql)
        {
            using (SqlConnection connection = sqlConnection(null,null))
            {
                connection.Open();

                SqlCommand cmd = new SqlCommand(sql, connection);
                SqlDataAdapter adapter = new SqlDataAdapter(cmd);

                DataTable dt = new DataTable();
                adapter.Fill(dt);

                connection.Close();

                return dt;
            }
        }
        #endregion

        #region EXECUTE QUERY
        public static void executeQuery(string sql)
        {
            using (SqlConnection connection = sqlConnection(null, null))
            {
                connection.Open();

                SqlCommand cmd = new SqlCommand(sql, connection);
                cmd.ExecuteNonQuery();

                connection.Close();
            }
        }
        #endregion
    }
}
