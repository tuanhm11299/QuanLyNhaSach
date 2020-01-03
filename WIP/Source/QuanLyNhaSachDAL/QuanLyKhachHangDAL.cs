using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using QuanLyNhaSachDTO;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;

namespace QuanLyNhaSachDAL
{
    public class QuanLyKhachHangDAL
    {
        private string connectionString = null;
        public QuanLyKhachHangDAL()
        {
            connectionString = ConfigurationManager.AppSettings["ConnectionString"];
        }

        public string insert(QuanLyKhachHangDTO obj)
        {
            string query = string.Empty;
            query += "INSERT INTO [KHACHHANG] ([MaKhachHang], [HoTenKhachHang], [DiaChi] , [DienThoai] , [Email] , [SoTienNo])";
            query += "VALUES (@MaKhachHang,@HoTenKhachHang,@DiaChi,@DienThoai,@Email,@SoTienNo)";

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                using (SqlCommand comm = new SqlCommand())
                {
                    comm.Connection = conn;
                    comm.CommandType = CommandType.Text;
                    comm.CommandText = query;
                    comm.Parameters.AddWithValue("@MaKhachHang", obj.MaKH);
                    comm.Parameters.AddWithValue("@HoTenKhachHang", obj.HoTen);
                    comm.Parameters.AddWithValue("@DiaChi", obj.DiaChi);
                    comm.Parameters.AddWithValue("@DienThoai", obj.SDT);
                    comm.Parameters.AddWithValue("@Email", obj.Email);
                    comm.Parameters.AddWithValue("@SoTienNo", obj.SoTienNo);
                    try
                    {
                        conn.Open();
                        comm.ExecuteNonQuery();
                    }
                    catch (Exception ex)
                    {
                        conn.Close();
                        // them that bai!!!
                        return "Thêm khách hàng thất bại\n" + ex.Message + "\n" + ex.StackTrace;
                    }
                }
            }
            return "0";
        }

        public string selectAll(List<QuanLyKhachHangDTO> lsObj)
        {

            string query = string.Empty;
            query += " SELECT *";
            query += " FROM [KHACHHANG]";

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
                                QuanLyKhachHangDTO obj = new QuanLyKhachHangDTO();
                                obj.MaKH = reader["MaKhachHang"].ToString();
                                obj.HoTen = reader["HoTenKhachHang"].ToString(); ////xem cách get ngày nhập trong c# .net nha bây
                                obj.DiaChi = reader["DiaChi"].ToString();
                                obj.SDT = reader["DienThoai"].ToString();
                                obj.Email = reader["Email"].ToString();
                                obj.SoTienNo = Convert.ToInt32(reader["SoTienNo"].ToString());
                                lsObj.Add(obj);
                            }
                        }
                    }
                    catch (Exception ex)
                    {
                        conn.Close();
                        //' lấy that bai!!!
                        return "Lấy thông tin khách hàng thất bại\n" + ex.Message + "\n" + ex.StackTrace;
                    }
                }
            }
            return "0";
        }

        public string delete(QuanLyKhachHangDTO obj)
        {
            string query = string.Empty;
            query += " DELETE FROM [KHACHHANG] ";
            query += " WHERE ";
            query += " [MaKhachHang] = @MaKhachHang ";

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                using (SqlCommand comm = new SqlCommand())
                {
                    comm.Connection = conn;
                    comm.CommandType = CommandType.Text;
                    comm.CommandText = query;
                    comm.Parameters.AddWithValue("@MaKhachHang", obj.MaKH);
                    try
                    {
                        conn.Open();
                        comm.ExecuteNonQuery();
                    }
                    catch (Exception ex)
                    {
                        conn.Close();
                        //' xóa that bai!!!
                        return "Xóa khách hàng thất bại\n" + ex.Message + "\n" + ex.StackTrace;
                    }
                }
            }
            return "0";
        }

        public string update(QuanLyKhachHangDTO obj)
        {
            string query = string.Empty;
            query += " UPDATE [KHACHHANG] SET";
            query += " [MaKhachHang] = @MaKhachHang,  ";
            query += " [HoTenKhachHang] = @HoTenKhachHang, ";
            query += " [DiaChi] = @DiaChi, ";
            query += " [DienThoai] = @DienThoai, ";
            query += " [Email] = @Email, ";
            query += "[SoTienNo] = @SoTienNo ";
            query += " WHERE ";
            query += " [MaKhachHang] = @MaKhachHang ";

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                using (SqlCommand comm = new SqlCommand())
                {
                    comm.Connection = conn;
                    comm.CommandType = CommandType.Text;
                    comm.CommandText = query;
                    comm.Parameters.AddWithValue("@MaKhachHang", obj.MaKH);
                    comm.Parameters.AddWithValue("@HoTenKhachHang", obj.HoTen);
                    comm.Parameters.AddWithValue("@DiaChi", obj.DiaChi);
                    comm.Parameters.AddWithValue("@DienThoai", obj.SDT);
                    comm.Parameters.AddWithValue("@Email", obj.Email);
                    comm.Parameters.AddWithValue("@SoTienNo", obj.SoTienNo);
                    try
                    {
                        conn.Open();
                        comm.ExecuteNonQuery();
                    }
                    catch (Exception ex)
                    {
                        conn.Close();
                        //' Cập nhật that bai!!!
                        return "Sửa thông tin thất bại\n" + ex.Message + "\n" + ex.StackTrace;
                    }
                }
            }
            return "0";
        }

        //public string deleteALL(List<QuanLyKhachHangDTO> obj)
        //{
        //    string query = string.Empty;
        //    query += " DELETE FROM [KHACHHHANG] ";
        //    query += " WHERE ";
        //    query += " [MaKhachHang] = @MaKhachHang ";

        //    using (SqlConnection conn = new SqlConnection(connectionString))
        //    {
        //        using (SqlCommand comm = new SqlCommand())
        //        {
        //            comm.Connection = conn;
        //            comm.CommandType = CommandType.Text;
        //            comm.CommandText = query;
        //            comm.Parameters.AddWithValue("@MaKhachHang", obj.MaKH);
        //            try
        //            {
        //                conn.Open();
        //                comm.ExecuteNonQuery();
        //            }
        //            catch (Exception ex)
        //            {
        //                conn.Close();
        //                //' xóa that bai!!!
        //                return "Xóa tất cả khách hàng thất bại\n" + ex.Message + "\n" + ex.StackTrace;
        //            }
        //        }
        //    }
        //    return "0";
        //}

        public string searchTenKH(string tenKH, List<QuanLyKhachHangDTO> lsObj)
        {

            string query = string.Empty;
            query += "SELECT *";
            query += " FROM [KHACHHANG]";
            query += " WHERE ";
            query += " [HoTenKhachHang] like @HoTenKhachHang ";


            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                using (SqlCommand comm = new SqlCommand())
                {
                    comm.Connection = conn;
                    comm.CommandType = CommandType.Text;
                    comm.CommandText = query;
                    comm.Parameters.AddWithValue("@HoTenKhachHang", "%" + tenKH.ToString() + "%");
                    try
                    {
                        conn.Open();
                        SqlDataReader reader = comm.ExecuteReader();
                        if (reader.HasRows == true)
                        {
                            lsObj.Clear();
                            while (reader.Read())
                            {
                                QuanLyKhachHangDTO obj = new QuanLyKhachHangDTO();
                                obj.MaKH = reader["MaKhachHang"].ToString();
                                obj.HoTen = reader["HoTenKhachHang"].ToString();
                                obj.DiaChi = reader["DiaChi"].ToString();
                                obj.SDT = reader["DienThoai"].ToString();
                                obj.Email = reader["Email"].ToString();
                                obj.SoTienNo = Convert.ToInt32(reader["SoTienNo"].ToString());
                                lsObj.Add(obj);
                            }
                        }
                    }
                    catch (Exception ex)
                    {
                        conn.Close();
                        //' lấy that bai!!!
                        return "Tìm khách hàng thất bại\n" + ex.Message + "\n" + ex.StackTrace;
                    }
                }
            }
            return "0";
        }

        public string deleteAll(List<QuanLyKhachHangDTO> lsObj)
        {
            string query = string.Empty;
            query += " DELETE FROM [KHACHHANG] ";

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                using (SqlCommand comm = new SqlCommand())
                {
                    comm.Connection = conn;
                    comm.CommandType = CommandType.Text;
                    comm.CommandText = query;
                    //comm.Parameters.AddWithValue("@MaKhachHang", );
                    try
                    {
                        conn.Open();
                        comm.ExecuteNonQuery();
                    }
                    catch (Exception ex)
                    {
                        conn.Close();
                        //' xóa that bai!!!
                        return "Xóa tất cả khách hàng thất bại\n" + ex.Message + "\n" + ex.StackTrace;
                    }
                }
            }
            return "0";
        }
    }
}
