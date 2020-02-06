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
     public class PhieuThuTienDAL
    {
        private string connectionString = null;

        public PhieuThuTienDAL()
        {
            connectionString = ConfigurationManager.AppSettings["ConnectionString"];
        }

        public string insert(PhieuThuTienDTO obj)
        {
            string query = string.Empty;
            query += "INSERT INTO [PHIEUTHUTIEN] ([MaPhieuThu], [SoTienThu], [NgayThuTien], [MaKhachHang])";
            query += "VALUES (@MaPhieuThu,@SoTienThu,@NgayThuTien,@MaKhachHang)";

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                using (SqlCommand comm = new SqlCommand())
                {
                    comm.Connection = conn;
                    comm.CommandType = CommandType.Text;
                    comm.CommandText = query;
                    comm.Parameters.AddWithValue("@MaPhieuThu", obj.MaPT);
                    comm.Parameters.AddWithValue("@SoTienThu", obj.STT);
                    comm.Parameters.AddWithValue("@NgayThuTien", obj.NgayThuTien);
                    comm.Parameters.AddWithValue("@MaKhachHang", obj.MaKH);
                    //comm.Parameters.AddWithValue("@Email", obj.Email);
                    //comm.Parameters.AddWithValue("@SoTienNo", obj.SoTienNo);
                    try
                    {
                        conn.Open();
                        comm.ExecuteNonQuery();
                    }
                    catch (Exception ex)
                    {
                        conn.Close();
                        // them that bai!!!
                        return "Lập phiếu thu thất bại\n" + ex.Message + "\n" + ex.StackTrace;
                    }
                }
            }
            return "0";
        }

        public string selectAll(List<PhieuThuTienDTO> lsObj)
        {

            string query = string.Empty;
            query += "SELECT *";
            query += "FROM PHIEUTHUTIEN";

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
                                PhieuThuTienDTO obj = new PhieuThuTienDTO();
                                obj.MaPT = reader["MaPhieuThu"].ToString();
                                //.STT = reader["SoTienThu"].ToString(); ////xem cách get ngày nhập trong c# .net nha bây
                                //obj.DiaChi = reader["NgayThuTien"].ToString();
                                //obj.SDT = reader["DienThoai"].ToString();
                                //obj.Email = reader["Email"].ToString();
                                obj.STT = Convert.ToInt32(reader["SoTienThu"].ToString());
                                obj.NgayThuTien = reader["NgayThuTien"].ToString();
                                obj.MaKH = reader["MaKhachHang"].ToString();
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

        public string delete(PhieuThuTienDTO obj)
        {
            string query = string.Empty;
            query += " DELETE FROM [PHIEUTHUTIEN] ";
            query += " WHERE ";
            query += " [MaPhieuThu] = @MaPhieuThu ";

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                using (SqlCommand comm = new SqlCommand())
                {
                    comm.Connection = conn;
                    comm.CommandType = CommandType.Text;
                    comm.CommandText = query;
                    comm.Parameters.AddWithValue("@MaPhieuThu", obj.MaPT);
                    try
                    {
                        conn.Open();
                        comm.ExecuteNonQuery();
                    }
                    catch (Exception ex)
                    {
                        conn.Close();
                        //' xóa that bai!!!
                        return "Xóa phiếu thu tiền thất bại\n" + ex.Message + "\n" + ex.StackTrace;
                    }
                }
            }
            return "0";
        }

        public string update(PhieuThuTienDTO obj)
        {
            string query = string.Empty;
            query += " UPDATE [PHIEUTHUTIEN] SET";
            query += " [MaPhieuThu] = @MaPhieuThu,  ";
            query += " [SoTienThu] = @SoTienThu, ";
            query += " [NgayThuTien] = @NgayThuTien, ";
            query += " [MaKhachHang] = @MaKhachHang ";
            //query += " [Email] = @Email, ";
            //query += "[SoTienNo] = @SoTienNo ";
            query += " WHERE ";
            query += " [MaPhieuThu] = @MaPhieuThu ";

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                using (SqlCommand comm = new SqlCommand())
                {
                    comm.Connection = conn;
                    comm.CommandType = CommandType.Text;
                    comm.CommandText = query;
                    comm.Parameters.AddWithValue("@MaPhieuThu", obj.MaPT);
                    comm.Parameters.AddWithValue("@SoTienThu", obj.STT);
                    comm.Parameters.AddWithValue("@NgayThuTien", obj.NgayThuTien);
                    comm.Parameters.AddWithValue("@MaKhachHang", obj.MaKH);
                    //comm.Parameters.AddWithValue("@Email", obj.Email);
                    //comm.Parameters.AddWithValue("@SoTienNo", obj.SoTienNo);
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

        public string searchMaKH(string maKH, List<PhieuThuTienDTO> lsObj)
        {

            string query = string.Empty;
            query += "SELECT *";
            query += " FROM [PHIEUTHUTIEN]";
            query += " WHERE ";
            query += " [MaKhachHang] like @MaKhachHang ";


            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                using (SqlCommand comm = new SqlCommand())
                {
                    comm.Connection = conn;
                    comm.CommandType = CommandType.Text;
                    comm.CommandText = query;
                    comm.Parameters.AddWithValue("@MaKhachHang", "%" + maKH.ToString() + "%");
                    try
                    {
                        conn.Open();
                        SqlDataReader reader = comm.ExecuteReader();
                        if (reader.HasRows == true)
                        {
                            lsObj.Clear();
                            while (reader.Read())
                            {
                                PhieuThuTienDTO obj = new PhieuThuTienDTO();
                                obj.MaPT = reader["MaPhieuThu"].ToString();
                                //obj.STT = reader["HoTenKhachHang"].ToString();
                                obj.NgayThuTien = reader["NgayThuTien"].ToString();
                                obj.MaKH = reader["MaKhachHang"].ToString();
                                //obj.Email = reader["Email"].ToString();
                                obj.STT = Convert.ToInt32(reader["SoTienThu"].ToString());
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

        public PhieuThuTienDTO searchKhachHang(string maKH, PhieuThuTienDTO obj)
        {

            string query = string.Empty;
            query += "SELECT *";
            query += " FROM [PHIEUTHUTIEN]";
            query += " WHERE ";
            query += " [MaKhachHang] like @MaKhachHang ";
            obj = new PhieuThuTienDTO();


            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                using (SqlCommand comm = new SqlCommand())
                {
                    comm.Connection = conn;
                    comm.CommandType = CommandType.Text;
                    comm.CommandText = query;
                    comm.Parameters.AddWithValue("@MaKhachHang", "%" + maKH.ToString() + "%");
                    try
                    {
                        conn.Open();
                        SqlDataReader reader = comm.ExecuteReader();
                        if (reader.HasRows == true)
                        {
                            //lsObj.Clear();
                            while (reader.Read())
                            {
                                //PhieuThuTienDTO obj = new PhieuThuTienDTO();
                                obj.MaPT = reader["MaPhieuThu"].ToString();
                                //obj.STT = reader["HoTenKhachHang"].ToString();
                                obj.NgayThuTien = reader["NgayThuTien"].ToString();
                                obj.MaKH = reader["MaKhachHang"].ToString();
                                //obj.Email = reader["Email"].ToString();
                                obj.STT = Convert.ToInt32(reader["SoTienThu"].ToString());
                                //lsObj.Add(obj);
                            }
                        }
                    }
                    catch (Exception ex)
                    {
                        conn.Close();
                        //' lấy that bai!!!
                        //return "Tìm khách hàng thất bại\n" + ex.Message + "\n" + ex.StackTrace;
                        Console.WriteLine("Tìm khách hàng thất bại\n" + ex.Message + "\n" + ex.StackTrace);
                    }
                }
            }
            return obj;
        }

        //public PhieuThuTienDTO searchKhachHangTheoNgay(PhieuThuTienDTO obj)
        //{
        //      
        //}
    }
}
