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
    public class QuanLySachDAL
    {
        private string connectionString = null;

        public QuanLySachDAL()
        {
            connectionString = ConfigurationManager.AppSettings["ConnectionString"];
        }

        public string insert(QuanLySachDTO obj)
        {
            string query = string.Empty;
            query += "INSERT INTO [SACH] ( [MaSach] , [TenSach], [TheLoai] , [TacGia] , [SoLuongTon] , [DonGiaNhap])";
            query += "VALUES (@MaSach,@TenSach,@TheLoai,@TacGia,@SoLuongTon,@DonGiaNhap)";

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                using (SqlCommand comm = new SqlCommand())
                {
                    comm.Connection = conn;
                    comm.CommandType = CommandType.Text;
                    comm.CommandText = query;
                    comm.Parameters.AddWithValue("@MaSach", obj.MaSach);
                    comm.Parameters.AddWithValue("@TenSach", obj.TenSach);
                    comm.Parameters.AddWithValue("@TheLoai", obj.TheLoai);
                    comm.Parameters.AddWithValue("@TacGia", obj.TacGia);
                    comm.Parameters.AddWithValue("@SoLuongTon", obj.SoLuongTon);
                    comm.Parameters.AddWithValue("@DonGiaNhap", obj.DonGiaNhap);
                    try
                    {
                        conn.Open();
                        comm.ExecuteNonQuery();
                    }
                    catch (Exception ex)
                    {
                        conn.Close();
                        // them that bai!!!
                        return "Thêm sách thất bại\n" + ex.Message + "\n" + ex.StackTrace;
                    }
                }
            }
            return "0";
        }

        public string searchMaSach(string kw, List<QuanLySachDTO> lsObj)
        {

            string query = string.Empty;
            query += "SELECT *";
            query += " FROM [SACH]";
            query += " WHERE ";
            query += " [MaSach] like @MaSach ";


            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                using (SqlCommand comm = new SqlCommand())
                {
                    comm.Connection = conn;
                    comm.CommandType = CommandType.Text;
                    comm.CommandText = query;
                    comm.Parameters.AddWithValue("@MaSach", "%" + kw.ToString() + "%");
                    try
                    {
                        conn.Open();
                        SqlDataReader reader = comm.ExecuteReader();
                        if (reader.HasRows == true)
                        {
                            lsObj.Clear();
                            while (reader.Read())
                            {
                                QuanLySachDTO obj = new QuanLySachDTO();
                                obj.MaSach = reader["MaSach"].ToString();
                                obj.TenSach = reader["TenSach"].ToString();
                                obj.TheLoai = reader["TheLoai"].ToString();
                                obj.TacGia = reader["TacGia"].ToString();
                                obj.SoLuongTon = Convert.ToInt32(reader["SoLuongTon"].ToString());
                                lsObj.Add(obj);
                            }
                        }
                    }
                    catch (Exception ex)
                    {
                        conn.Close();
                        //' lấy that bai!!!
                        return "Tìm sách thất bại\n" + ex.Message + "\n" + ex.StackTrace;
                    }
                }
            }
            return "0";
        }

        public string searchTenSach(string kw, List<QuanLySachDTO> lsObj)
        {

            string query = string.Empty;
            query += "SELECT *";
            query += " FROM [SACH]";
            query += " WHERE ";
            query += " [TenSach] like @TenSach ";


            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                using (SqlCommand comm = new SqlCommand())
                {
                    comm.Connection = conn;
                    comm.CommandType = CommandType.Text;
                    comm.CommandText = query;
                    comm.Parameters.AddWithValue("@TenSach", "%" + kw.ToString() + "%");
                    try
                    {
                        conn.Open();
                        SqlDataReader reader = comm.ExecuteReader();
                        if (reader.HasRows == true)
                        {
                            lsObj.Clear();
                            while (reader.Read())
                            {
                                QuanLySachDTO obj = new QuanLySachDTO();
                                obj.MaSach = reader["MaSach"].ToString();
                                obj.TenSach = reader["TenSach"].ToString();
                                obj.TheLoai = reader["TheLoai"].ToString();
                                obj.TacGia = reader["TacGia"].ToString();
                                obj.SoLuongTon = Convert.ToInt32(reader["SoLuongTon"].ToString());
                                lsObj.Add(obj);
                            }
                        }
                    }
                    catch (Exception ex)
                    {
                        conn.Close();
                        //' lấy that bai!!!
                        return "Tìm sách thất bại\n" + ex.Message + "\n" + ex.StackTrace;
                    }
                }
            }
            return "0";
        }

        public string searchTheLoai(string kw, List<QuanLySachDTO> lsObj)
        {

            string query = string.Empty;
            query += "SELECT *";
            query += " FROM [SACH]";
            query += " WHERE ";
            query += " [TheLoai] like @TheLoai ";


            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                using (SqlCommand comm = new SqlCommand())
                {
                    comm.Connection = conn;
                    comm.CommandType = CommandType.Text;
                    comm.CommandText = query;
                    comm.Parameters.AddWithValue("@TheLoai", "%" + kw.ToString() + "%");
                    try
                    {
                        conn.Open();
                        SqlDataReader reader = comm.ExecuteReader();
                        if (reader.HasRows == true)
                        {
                            lsObj.Clear();
                            while (reader.Read())
                            {
                                QuanLySachDTO obj = new QuanLySachDTO();
                                obj.MaSach = reader["MaSach"].ToString();
                                obj.TenSach = reader["TenSach"].ToString();
                                obj.TheLoai = reader["TheLoai"].ToString();
                                obj.TacGia = reader["TacGia"].ToString();
                                obj.SoLuongTon = Convert.ToInt32(reader["SoLuongTon"].ToString());
                                lsObj.Add(obj);
                            }
                        }
                    }
                    catch (Exception ex)
                    {
                        conn.Close();
                        //' lấy that bai!!!
                        return "Tìm sách thất bại\n" + ex.Message + "\n" + ex.StackTrace;
                    }
                }
            }
            return "0";
        }

        public string searchTacGia(string kw, List<QuanLySachDTO> lsObj)
        {

            string query = string.Empty;
            query += "SELECT *";
            query += " FROM [SACH]";
            query += " WHERE ";
            query += " [TacGia] like @TacGia ";


            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                using (SqlCommand comm = new SqlCommand())
                {
                    comm.Connection = conn;
                    comm.CommandType = CommandType.Text;
                    comm.CommandText = query;
                    comm.Parameters.AddWithValue("@TacGia", "%" + kw.ToString() + "%");
                    try
                    {
                        conn.Open();
                        SqlDataReader reader = comm.ExecuteReader();
                        if (reader.HasRows == true)
                        {
                            lsObj.Clear();
                            while (reader.Read())
                            {
                                QuanLySachDTO obj = new QuanLySachDTO();

                                obj.MaSach = reader["MaSach"].ToString();
                                obj.TenSach = reader["TenSach"].ToString();
                                obj.TheLoai = reader["TheLoai"].ToString();
                                obj.TacGia = reader["TacGia"].ToString();
                                obj.SoLuongTon = Convert.ToInt32(reader["SoLuongTon"].ToString());
                                lsObj.Add(obj);
                            }
                        }
                    }
                    catch (Exception ex)
                    {
                        conn.Close();
                        //' lấy that bai!!!
                        return "Tìm sách thất bại\n" + ex.Message + "\n" + ex.StackTrace;
                    }
                }
            }
            return "0";
        }
    }
}
