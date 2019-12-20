using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using QuanLyNhaSachDTO;

namespace QuanLyNhaSachDAL
{
    class PhieuNhapSachDAL
    {
        private string connectionString = null;

        public PhieuNhapSachDAL()
        {
            connectionString = ConfigurationManager.AppSettings["ConnectionString"];
        }
        public string insert(PhieuNhapSachDTO obj)
        {
            string query = string.Empty;
            query += "INSERT INTO [PHIEUNHAP] ([MaPhieuNhap], [NgayNhap])";
            query += "VALUES (@MaPhieuNhap,@NgayNhap)";

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                using (SqlCommand comm = new SqlCommand())
                {
                    comm.Connection = conn;
                    comm.CommandType = CommandType.Text;
                    comm.CommandText = query;
                    comm.Parameters.AddWithValue("@MaPhieuNhap", obj.MaPN);
                    comm.Parameters.AddWithValue("@NgayNhap", obj.NgayNhap);
                    try
                    {
                        conn.Open();
                        comm.ExecuteNonQuery();
                    }
                    catch (Exception ex)
                    {
                        conn.Close();
                        //' them that bai!!!
                        return "Thêm ngày nhập phiếu thất bại\n" + ex.Message + "\n" + ex.StackTrace;
                    }
                }
            }
            return "0";
        }
    }
}
