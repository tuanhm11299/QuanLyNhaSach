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

        /*public string update(PhieuNhapSachDTO obj)
        {
            string query = string.Empty;
            query += " UPDATE [PHIEUNHAP] SET";
            query += " [MaPhieuNhap] = @MaPhieuNhap ";
            //query += " WHERE ";
            //query += " [NgayNhap] = @NgayNhap ";

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                using (SqlCommand comm = new SqlCommand())
                {
                    comm.Connection = conn;
                    comm.CommandType = CommandType.Text;
                    comm.CommandText = query;
                    //comm.Parameters.AddWithValue("@NgayNhap", obj.MaPN);
                    comm.Parameters.AddWithValue("@MaPhieuNhap", obj.MaPN);
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
        }*/

        public string delete(PhieuNhapSachDTO obj)
        {
            string query = string.Empty;
            query += " DELETE FROM [PHIEUNHAP] ";
            query += " WHERE ";
            query += " [MaPhieuNhap] = @MaPhieuNhap ";

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                using (SqlCommand comm = new SqlCommand())
                {
                    comm.Connection = conn;
                    comm.CommandType = CommandType.Text;
                    comm.CommandText = query;
                    comm.Parameters.AddWithValue("@MaPhieuNhap", obj.MaPN);
                    try
                    {
                        conn.Open();
                        comm.ExecuteNonQuery();
                    }
                    catch (Exception ex)
                    {
                        conn.Close();
                        //' xóa that bai!!!
                        return "Xóa phiếu nhập thất bại\n" + ex.Message + "\n" + ex.StackTrace;
                    }
                }
            }
            return "0";
        }

        public string insertChiTiet(CTPhieuNhapSachDTO obj)
        {
            string query = string.Empty;
            //query += "INSERT INTO [CHITIETPHIEUNHAP] ([MaChiTietPhieuNHap], [MaPhieuNhap], [MaSach], [SoLuongNhap])";
            //query += "VALUES (@MaChiTietPhieuNHap,@MaPhieuNhap,@MaSach,@SoLuongNhap)";

            query += "INSERT INTO [CHITIETPHIEUNHAP] ([MaChiTietPhieuNHap], [MaPhieuNhap], [SoLuongNhap])";
            query += "VALUES (@MaChiTietPhieuNHap,@MaPhieuNhap,@SoLuongNhap)";
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                using (SqlCommand comm = new SqlCommand())
                {
                    comm.Connection = conn;
                    comm.CommandType = CommandType.Text;
                    comm.CommandText = query;
                    comm.Parameters.AddWithValue("@MaChiTietPhieuNHap", obj.MaCT);
                    comm.Parameters.AddWithValue("@MaPhieuNhap", obj.MaPN);
                    //comm.Parameters.AddWithValue("@MaSach", obj.MaSach);
                    comm.Parameters.AddWithValue("@SoLuongNhap", obj.SLN);
                    try
                    {
                        conn.Open();
                        comm.ExecuteNonQuery();
                    }
                    catch (Exception ex)
                    {
                        conn.Close();
                        // them that bai!!!
                        return "Thêm chi tiết phiếu thất bại\n" + ex.Message + "\n" + ex.StackTrace;
                    }
                }
            }
            return "0";
        }

        public string selectAllCT(List<CTPhieuNhapSachDTO> lsObj)
        {

            string query = string.Empty;
            //query += " SELECT [MaChiTietPhieuNHap], [MaPhieuNhap], [MaSach], [SoLuongNhap]";
            //query += " FROM [CHITIETPHIEUNHAP]";

            query += " SELECT [MaChiTietPhieuNHap], [MaPhieuNhap], [SoLuongNhap]";
            query += " FROM [CHITIETPHIEUNHAP]";
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
                                CTPhieuNhapSachDTO obj = new CTPhieuNhapSachDTO();
                                obj.MaCT = reader["MaChiTietPhieuNHap"].ToString();
                                obj.MaPN = reader["MaPhieuNhap"].ToString();
                                //obj.MaSach = reader["MaSach"].ToString();
                                obj.SLN = reader["SoLuongNhap"].ToString();
                                lsObj.Add(obj);
                            }
                        }
                    }
                    catch (Exception ex)
                    {
                        conn.Close();
                        //' lấy that bai!!!
                        return "Lấy chi tiết phiếu nhập thất bại\n" + ex.Message + "\n" + ex.StackTrace;
                    }
                }
            }
            return "0";
        }

        public string deleteChiTiet(CTPhieuNhapSachDTO obj)
        {
            string query = string.Empty;
            query += " DELETE FROM [CHITIETPHIEUNHAP]  ";
            query += " WHERE ";
            query += " [MaPhieuNhap] = @MaPhieuNhap ";
            //query += " [MaChiTietPhieuNhap] = @MaChiTietPhieuNhap ";
            //query += " [MaSach] = @MaSach ";
            //query += " [SoLuongNhap] = @SoLuongNhap ";

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                using (SqlCommand comm = new SqlCommand())
                {
                    comm.Connection = conn;
                    comm.CommandType = CommandType.Text;
                    comm.CommandText = query;
                    comm.Parameters.AddWithValue("@MaPhieuNhap", obj.MaPN);
                    //comm.Parameters.AddWithValue("@MaChiTietPhieuNhap", obj.MaCT);
                    //comm.Parameters.AddWithValue("@MaSach", obj.MaSach);
                    //comm.Parameters.AddWithValue("@SoLuongNhap", obj.SLN);
                    try
                    {
                        conn.Open();
                        comm.ExecuteNonQuery();
                    }
                    catch (Exception ex)
                    {
                        conn.Close();
                        //' xóa that bai!!!
                        return "Xóa chi tiết phiếu nhập thất bại\n" + ex.Message + "\n" + ex.StackTrace;
                    }
                }
            }
            return "0";
        }
    }
}
