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

        public QuanLySachDTO laySach()
        {
            string query = string.Empty;
            query = "SELECT * FROM SACH";

            QuanLySachDTO ls = new QuanLySachDTO();

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                using (SqlCommand cmd = new SqlCommand())
                {
                    cmd.Connection = conn;
                    cmd.CommandType = System.Data.CommandType.Text;
                    cmd.CommandText = query;

                    try
                    {
                        conn.Open();
                        SqlDataReader reader = cmd.ExecuteReader();
                        if (reader.HasRows)
                        {
                            while (reader.Read())
                            {
                                ls.MaSach = reader["MaSach"].ToString();
                                ls.TenSach = reader["SoLuongNhapItNhat"].ToString();
                                ls.TheLoai = reader["SoLuongTonToiDaTruocNhap"].ToString();
                                ls.TacGia = reader["SoLuongTonSauToiThieu"].ToString();
                                ls.SoLuongTon = Convert.ToInt32(reader["SoLuongTon"]);
                                ls.DonGiaNhap = Convert.ToInt32(reader["DonGiaNhap"]);
                            }
                            conn.Close();
                            conn.Dispose();
                            return ls;
                        }

                    }
                    catch
                    {
                        conn.Close();
                        return null;
                    }

                }
            }
            return ls;
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

        public bool capnhatLuongTon(QuanLySachDTO sach)
        {
            string query = string.Empty;
            query += "UPDATE [SACH] ";
            query += "SET [SoLuongTon] = @SoLuongTon";
            query += "WHERE [MaSach] = @MaSach";

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                using (SqlCommand cmd = new SqlCommand())
                {
                    cmd.Connection = conn;
                    cmd.CommandType = System.Data.CommandType.Text;
                    cmd.CommandText = query;

                    //cmd.Parameters.AddWithValue("@MaThamSo", qd.Mathamso);
                    cmd.Parameters.AddWithValue("@SoLuongTon", sach.SoLuongTon);

                    try
                    {
                        conn.Open();
                        if (cmd.ExecuteNonQuery() > 0)
                        {
                            conn.Close();
                            conn.Dispose();
                            return true;
                        }
                    }
                    catch
                    {
                        conn.Close();
                        return false;
                    }
                }
            }

            return true;
        }
    }
}
