using QuanLyNhaSachDTO;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyNhaSachDAL
{
    public class PhieuNhapSachDAL
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
                        // them that bai!!!
                        return "Thêm ngày nhập phiếu thất bại\n" + ex.Message + "\n" + ex.StackTrace;
                    }
                }
            }
            return "0";
        }
        public string selectAll(List<PhieuNhapSachDTO> lsObj)
        {

            string query = string.Empty;
            query += " SELECT [MaPhieuNhap], [NgayNhap]";
            query += " FROM [PHIEUNHAP]";

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                using (SqlCommand comm = new SqlCommand())
                {
                    comm.Connection = conn;
                    comm.CommandType = CommandType.Text;
                    comm.CommandText = query;

                    try
                    {
                        conn.Open();
                        SqlDataReader reader = comm.ExecuteReader();
                        if (reader.HasRows == true)
                        {
                            lsObj.Clear();
                            while (reader.Read())
                            {
                                PhieuNhapSachDTO obj = new PhieuNhapSachDTO(); 
                                obj.MaPN = reader["MaPhieuNhap"].ToString();
                                obj.NgayNhap = reader["NgayNhap"].ToString(); ////xem cách get ngày nhập trong c# .net nha bây
                                lsObj.Add(obj);
                            }
                        }
                    }
                    catch (Exception ex)
                    {
                        conn.Close();
                        //' lấy that bai!!!
                        return "Lấy phiếu nhập thất bại\n" + ex.Message + "\n" + ex.StackTrace;
                    }
                }
            }
            return "0";
        }
        public string update(PhieuNhapSachDTO obj)
        {
            string query = string.Empty;
            query += " UPDATE [PHIEUNHAP] SET";
            query += " [MaPhieuNhap] = @MaPhieuNhap ";
            query += " WHERE ";
            query += " [NgayNhap] = @NgayNhap ";

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                using (SqlCommand comm = new SqlCommand())
                {
                    comm.Connection = conn;
                    comm.CommandType = CommandType.Text;
                    comm.CommandText = query;
                    comm.Parameters.AddWithValue("@NgayNhap", obj.MaPN);
                    comm.Parameters.AddWithValue("@MaPhieuNhap", obj.NgayNhap);
                    try
                    {
                        conn.Open();
                        comm.ExecuteNonQuery();
                    }
                    catch (Exception ex)
                    {
                        conn.Close();
                        //' Cập nhật that bai!!!
                        return "Cập nhật phiếu nhập thất bại\n" + ex.Message + "\n" + ex.StackTrace;
                    }
                }
            }
            return "0";
        }
    }
}
