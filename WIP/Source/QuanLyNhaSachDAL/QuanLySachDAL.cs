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
        /*
        public string searchMaSachandTenSach(string masach, string tensach, List<QuanLySachDTO> lsObj)
        {

            string query = string.Empty;
            query += "SELECT *";
            query += " FROM [SACH]";
            query += " WHERE ";
            query += " [MaSach] like @MaSach ";
            //query += " AND";
            query += " AND [TenSach] like @TenSach ";


            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                using (SqlCommand comm = new SqlCommand())
                {
                    comm.Connection = conn;
                    comm.CommandType = CommandType.Text;
                    comm.CommandText = query;
                    //comm.Parameters.AddWithValue("@MaSach", "%" + kw.ToString() + "%");
                    //comm.Parameters.AddWithValue("@tennamhoc", "%" + kw.ToString() + "%");
                    //comm.Parameters.AddWithValue("@thutunamhoc", "%" + kw.ToString() + "%");
                    comm.Parameters.AddWithValue("@MaSach", "%" + masach.ToString() + "%");
                    comm.Parameters.AddWithValue("@TenSach", "%" + tensach.ToString() + "%");
                    //comm.Parameters.AddWithValue("@TheLoai", "%" + kw.ToString() + "%");
                    //comm.Parameters.AddWithValue("@TacGia", "%" + kw.ToString() + "%");
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
                                //obj.Ma = Convert.ToInt32(reader["manamhoc"].ToString());
                                obj.MaSach = reader["MaSach"].ToString();
                                obj.TenSach = reader["TenSach"].ToString();
                                obj.TheLoai = reader["TheLoai"].ToString();
                                obj.TacGia = reader["TacGia"].ToString();
                                obj.SoLuongTon = Convert.ToInt32(reader["SoLuongTon"].ToString());
                                //obj.Stt = Convert.ToInt32(reader["thutunamhoc"].ToString());
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

        public string searchMaSachandTheLoai(string masach, string theloai, List<QuanLySachDTO> lsObj)
        {

            string query = string.Empty;
            query += "SELECT *";
            query += " FROM [SACH]";
            query += " WHERE ";
            query += " [MaSach] like @MaSach ";
            //query += " AND";
            query += " AND [TheLoai] like @TheLoai ";


            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                using (SqlCommand comm = new SqlCommand())
                {
                    comm.Connection = conn;
                    comm.CommandType = CommandType.Text;
                    comm.CommandText = query;
                    //comm.Parameters.AddWithValue("@MaSach", "%" + kw.ToString() + "%");
                    //comm.Parameters.AddWithValue("@tennamhoc", "%" + kw.ToString() + "%");
                    //comm.Parameters.AddWithValue("@thutunamhoc", "%" + kw.ToString() + "%");
                    comm.Parameters.AddWithValue("@MaSach", "%" + masach.ToString() + "%");
                    comm.Parameters.AddWithValue("@TheLoai", "%" + theloai.ToString() + "%");
                    //comm.Parameters.AddWithValue("@TheLoai", "%" + kw.ToString() + "%");
                    //comm.Parameters.AddWithValue("@TacGia", "%" + kw.ToString() + "%");
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
                                //obj.Ma = Convert.ToInt32(reader["manamhoc"].ToString());
                                obj.MaSach = reader["MaSach"].ToString();
                                obj.TenSach = reader["TenSach"].ToString();
                                obj.TheLoai = reader["TheLoai"].ToString();
                                obj.TacGia = reader["TacGia"].ToString();
                                obj.SoLuongTon = Convert.ToInt32(reader["SoLuongTon"].ToString());
                                //obj.Stt = Convert.ToInt32(reader["thutunamhoc"].ToString());
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

        public string searchMaSachandTacGia(string masach, string tacgia, List<QuanLySachDTO> lsObj)
        {

            string query = string.Empty;
            query += "SELECT *";
            query += " FROM [SACH]";
            query += " WHERE ";
            query += " [MaSach] like @MaSach ";
            //query += " AND";
            query += " and [TacGia] like @TacGia ";


            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                using (SqlCommand comm = new SqlCommand())
                {
                    comm.Connection = conn;
                    comm.CommandType = CommandType.Text;
                    comm.CommandText = query;
                    //comm.Parameters.AddWithValue("@MaSach", "%" + kw.ToString() + "%");
                    //comm.Parameters.AddWithValue("@tennamhoc", "%" + kw.ToString() + "%");
                    //comm.Parameters.AddWithValue("@thutunamhoc", "%" + kw.ToString() + "%");
                    comm.Parameters.AddWithValue("@MaSach", "%" + masach.ToString() + "%");
                    comm.Parameters.AddWithValue("@TacGia", "%" + tacgia.ToString() + "%");
                    //comm.Parameters.AddWithValue("@TheLoai", "%" + kw.ToString() + "%");
                    //comm.Parameters.AddWithValue("@TacGia", "%" + kw.ToString() + "%");
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
                                //obj.Ma = Convert.ToInt32(reader["manamhoc"].ToString());
                                obj.MaSach = reader["MaSach"].ToString();
                                obj.TenSach = reader["TenSach"].ToString();
                                obj.TheLoai = reader["TheLoai"].ToString();
                                obj.TacGia = reader["TacGia"].ToString();
                                obj.SoLuongTon = Convert.ToInt32(reader["SoLuongTon"].ToString());
                                //obj.Stt = Convert.ToInt32(reader["thutunamhoc"].ToString());
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

        public string searchTenSachandTheLoai(string tensach, string theloai, List<QuanLySachDTO> lsObj)
        {

            string query = string.Empty;
            query += "SELECT *";
            query += " FROM [SACH]";
            query += " WHERE ";
            query += " [TheLoai] like @TheLoai ";
            //query += " AND ";
            query += " and [TenSach] like @TenSach ";


            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                using (SqlCommand comm = new SqlCommand())
                {
                    comm.Connection = conn;
                    comm.CommandType = CommandType.Text;
                    comm.CommandText = query;
                    //comm.Parameters.AddWithValue("@MaSach", "%" + kw.ToString() + "%");
                    //comm.Parameters.AddWithValue("@tennamhoc", "%" + kw.ToString() + "%");
                    //comm.Parameters.AddWithValue("@thutunamhoc", "%" + kw.ToString() + "%");
                    comm.Parameters.AddWithValue("@TheLoai", "%" + theloai.ToString() + "%");
                    comm.Parameters.AddWithValue("@TenSach", "%" + tensach.ToString() + "%");
                    //comm.Parameters.AddWithValue("@TheLoai", "%" + kw.ToString() + "%");
                    //comm.Parameters.AddWithValue("@TacGia", "%" + kw.ToString() + "%");
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
                                //obj.Ma = Convert.ToInt32(reader["manamhoc"].ToString());
                                obj.MaSach = reader["MaSach"].ToString();
                                obj.TenSach = reader["TenSach"].ToString();
                                obj.TheLoai = reader["TheLoai"].ToString();
                                obj.TacGia = reader["TacGia"].ToString();
                                obj.SoLuongTon = Convert.ToInt32(reader["SoLuongTon"].ToString());
                                //obj.Stt = Convert.ToInt32(reader["thutunamhoc"].ToString());
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

        public string searchTenSachandTacGia(string tacgia, string tensach, List<QuanLySachDTO> lsObj)
        {

            string query = string.Empty;
            query += "SELECT *";
            query += " FROM [SACH]";
            query += " WHERE ";
            query += " [TacGia] like @TacGia ";
            //query += " AND";
            query += " and [TenSach] like @TenSach ";


            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                using (SqlCommand comm = new SqlCommand())
                {
                    comm.Connection = conn;
                    comm.CommandType = CommandType.Text;
                    comm.CommandText = query;
                    //comm.Parameters.AddWithValue("@MaSach", "%" + kw.ToString() + "%");
                    //comm.Parameters.AddWithValue("@tennamhoc", "%" + kw.ToString() + "%");
                    //comm.Parameters.AddWithValue("@thutunamhoc", "%" + kw.ToString() + "%");
                    comm.Parameters.AddWithValue("@TacGia", "%" + tacgia.ToString() + "%");
                    comm.Parameters.AddWithValue("@TenSach", "%" + tensach.ToString() + "%");
                    //comm.Parameters.AddWithValue("@TheLoai", "%" + kw.ToString() + "%");
                    //comm.Parameters.AddWithValue("@TacGia", "%" + kw.ToString() + "%");
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
                                //obj.Ma = Convert.ToInt32(reader["manamhoc"].ToString());
                                obj.MaSach = reader["MaSach"].ToString();
                                obj.TenSach = reader["TenSach"].ToString();
                                obj.TheLoai = reader["TheLoai"].ToString();
                                obj.TacGia = reader["TacGia"].ToString();
                                obj.SoLuongTon = Convert.ToInt32(reader["SoLuongTon"].ToString());
                                //obj.Stt = Convert.ToInt32(reader["thutunamhoc"].ToString());
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

        public string searchTacGiaandTheLoai(string tacgia, string theloai, List<QuanLySachDTO> lsObj)
        {

            string query = string.Empty;
            query += "SELECT *";
            query += " FROM [SACH]";
            query += " WHERE ";
            query += " [TacGia] like @TacGia ";
            //query += " AND";
            query += " and [TheLoai] like @TheLoai ";


            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                using (SqlCommand comm = new SqlCommand())
                {
                    comm.Connection = conn;
                    comm.CommandType = CommandType.Text;
                    comm.CommandText = query;
                    //comm.Parameters.AddWithValue("@MaSach", "%" + kw.ToString() + "%");
                    //comm.Parameters.AddWithValue("@tennamhoc", "%" + kw.ToString() + "%");
                    //comm.Parameters.AddWithValue("@thutunamhoc", "%" + kw.ToString() + "%");
                    comm.Parameters.AddWithValue("@MaSach", "%" + tacgia.ToString() + "%");
                    comm.Parameters.AddWithValue("@TenSach", "%" + theloai.ToString() + "%");
                    //comm.Parameters.AddWithValue("@TheLoai", "%" + kw.ToString() + "%");
                    //comm.Parameters.AddWithValue("@TacGia", "%" + kw.ToString() + "%");
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
                                //obj.Ma = Convert.ToInt32(reader["manamhoc"].ToString());
                                obj.MaSach = reader["MaSach"].ToString();
                                obj.TenSach = reader["TenSach"].ToString();
                                obj.TheLoai = reader["TheLoai"].ToString();
                                obj.TacGia = reader["TacGia"].ToString();
                                obj.SoLuongTon = Convert.ToInt32(reader["SoLuongTon"].ToString());
                                //obj.Stt = Convert.ToInt32(reader["thutunamhoc"].ToString());
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

        public string searchMaSachandTenSachandTheLoai(string masach, string tensach, string theloai, List<QuanLySachDTO> lsObj)
        {

            string query = string.Empty;
            query += "SELECT *";
            query += " FROM [SACH]";
            query += " WHERE ";
            query += " [MaSach] like @MaSach ";
            //query += " AND";
            query += " and [TenSach] like @TenSach ";
            //query += " AND";
            query += " and [TheLoai] like @TheLoai";


            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                using (SqlCommand comm = new SqlCommand())
                {
                    comm.Connection = conn;
                    comm.CommandType = CommandType.Text;
                    comm.CommandText = query;
                    //comm.Parameters.AddWithValue("@MaSach", "%" + kw.ToString() + "%");
                    //comm.Parameters.AddWithValue("@tennamhoc", "%" + kw.ToString() + "%");
                    //comm.Parameters.AddWithValue("@thutunamhoc", "%" + kw.ToString() + "%");
                    comm.Parameters.AddWithValue("@MaSach", "%" + masach.ToString() + "%");
                    comm.Parameters.AddWithValue("@TenSach", "%" + tensach.ToString() + "%");
                    comm.Parameters.AddWithValue("@TheLoai", "%" + theloai.ToString() + "%");
                    //comm.Parameters.AddWithValue("@TacGia", "%" + kw.ToString() + "%");
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
                                //obj.Ma = Convert.ToInt32(reader["manamhoc"].ToString());
                                obj.MaSach = reader["MaSach"].ToString();
                                obj.TenSach = reader["TenSach"].ToString();
                                obj.TheLoai = reader["TheLoai"].ToString();
                                obj.TacGia = reader["TacGia"].ToString();
                                obj.SoLuongTon = Convert.ToInt32(reader["SoLuongTon"].ToString());
                                //obj.Stt = Convert.ToInt32(reader["thutunamhoc"].ToString());
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

        public string searchMaSachandTenSachandTacGia(string masach, string tensach, string tacgia, List<QuanLySachDTO> lsObj)
        {

            string query = string.Empty;
            query += "SELECT *";
            query += " FROM [SACH]";
            query += " WHERE ";
            query += " [MaSach] like @MaSach ";
            //query += " AND";
            query += " and [TenSach] like @TenSach ";
            //query += " AND";
            query += " and [TacGia] like @TacGia";


            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                using (SqlCommand comm = new SqlCommand())
                {
                    comm.Connection = conn;
                    comm.CommandType = CommandType.Text;
                    comm.CommandText = query;
                    //comm.Parameters.AddWithValue("@MaSach", "%" + kw.ToString() + "%");
                    //comm.Parameters.AddWithValue("@tennamhoc", "%" + kw.ToString() + "%");
                    //comm.Parameters.AddWithValue("@thutunamhoc", "%" + kw.ToString() + "%");
                    comm.Parameters.AddWithValue("@MaSach", "%" + masach.ToString() + "%");
                    comm.Parameters.AddWithValue("@TenSach", "%" + tensach.ToString() + "%");
                    //comm.Parameters.AddWithValue("@TheLoai", "%" + kw.ToString() + "%");
                    comm.Parameters.AddWithValue("@TacGia", "%" + tacgia.ToString() + "%");
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
                                //obj.Ma = Convert.ToInt32(reader["manamhoc"].ToString());
                                obj.MaSach = reader["MaSach"].ToString();
                                obj.TenSach = reader["TenSach"].ToString();
                                obj.TheLoai = reader["TheLoai"].ToString();
                                obj.TacGia = reader["TacGia"].ToString();
                                obj.SoLuongTon = Convert.ToInt32(reader["SoLuongTon"].ToString());
                                //obj.Stt = Convert.ToInt32(reader["thutunamhoc"].ToString());
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

        public string searchMaSachandTheLoaiandTacGia(string masach, string theloai, string tacgia, List<QuanLySachDTO> lsObj)
        {

            string query = string.Empty;
            query += "SELECT *";
            query += " FROM [SACH]";
            query += " WHERE ";
            query += " [MaSach] like @MaSach ";
            //query += " AND";
            query += " and [TheLoai] like @TheLoai ";
           // query += " AND";
            query += " and [TacGia] like @TacGia";


            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                using (SqlCommand comm = new SqlCommand())
                {
                    comm.Connection = conn;
                    comm.CommandType = CommandType.Text;
                    comm.CommandText = query;
                    //comm.Parameters.AddWithValue("@MaSach", "%" + kw.ToString() + "%");
                    //comm.Parameters.AddWithValue("@tennamhoc", "%" + kw.ToString() + "%");
                    //comm.Parameters.AddWithValue("@thutunamhoc", "%" + kw.ToString() + "%");
                    comm.Parameters.AddWithValue("@MaSach", "%" + masach.ToString() + "%");
                    //comm.Parameters.AddWithValue("@TenSach", "%" + tensach.ToString() + "%");
                    comm.Parameters.AddWithValue("@TheLoai", "%" + theloai.ToString() + "%");
                    comm.Parameters.AddWithValue("@TacGia", "%" + tacgia.ToString() + "%");
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
                                //obj.Ma = Convert.ToInt32(reader["manamhoc"].ToString());
                                obj.MaSach = reader["MaSach"].ToString();
                                obj.TenSach = reader["TenSach"].ToString();
                                obj.TheLoai = reader["TheLoai"].ToString();
                                obj.TacGia = reader["TacGia"].ToString();
                                obj.SoLuongTon = Convert.ToInt32(reader["SoLuongTon"].ToString());
                                //obj.Stt = Convert.ToInt32(reader["thutunamhoc"].ToString());
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

        public string searchTenSachandTheLoaiandTacGia(string tensach, string theloai, string tacgia, List<QuanLySachDTO> lsObj)
        {

            string query = string.Empty;
            query += "SELECT *";
            query += " FROM [SACH]";
            query += " WHERE ";
            query += " [TheLoai] like @TheLoai ";
            //query += " AND";
            query += " and [TenSach] like @TenSach ";
            //query += " AND";
            query += " and [TacGia] like @TacGia";


            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                using (SqlCommand comm = new SqlCommand())
                {
                    comm.Connection = conn;
                    comm.CommandType = CommandType.Text;
                    comm.CommandText = query;
                    //comm.Parameters.AddWithValue("@MaSach", "%" + kw.ToString() + "%");
                    //comm.Parameters.AddWithValue("@tennamhoc", "%" + kw.ToString() + "%");
                    //comm.Parameters.AddWithValue("@thutunamhoc", "%" + kw.ToString() + "%");
                    comm.Parameters.AddWithValue("@TheLoai", "%" + theloai.ToString() + "%");
                    comm.Parameters.AddWithValue("@TenSach", "%" + tensach.ToString() + "%");
                    //comm.Parameters.AddWithValue("@TheLoai", "%" + kw.ToString() + "%");
                    comm.Parameters.AddWithValue("@TacGia", "%" + tacgia.ToString() + "%");
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
                                //obj.Ma = Convert.ToInt32(reader["manamhoc"].ToString());
                                obj.MaSach = reader["MaSach"].ToString();
                                obj.TenSach = reader["TenSach"].ToString();
                                obj.TheLoai = reader["TheLoai"].ToString();
                                obj.TacGia = reader["TacGia"].ToString();
                                obj.SoLuongTon = Convert.ToInt32(reader["SoLuongTon"].ToString());
                                //obj.Stt = Convert.ToInt32(reader["thutunamhoc"].ToString());
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
        }*/
    }
}
