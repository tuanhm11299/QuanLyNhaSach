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
    public class HoaDonDAL
    {
        private string connectionString = null;

        public HoaDonDAL()
        {
            connectionString = ConfigurationManager.AppSettings["ConnectionString"];
        }

        public string insert(HoaDonDTO obj)
        {
            string query = string.Empty;
            query += "INSERT INTO [HOADON] ([MaHoaDon], [MaKhachHang], [NgayLapHoaDon], [TongThanhTien])";
            query += "VALUES (@MaHoaDon,@MaKhachHang,@NgayLapHoaDon,@TongThanhTien)";

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                using (SqlCommand comm = new SqlCommand())
                {
                    comm.Connection = conn;
                    comm.CommandType = CommandType.Text;
                    comm.CommandText = query;
                    comm.Parameters.AddWithValue("@MaHoaDon", obj.MaHD);
                    comm.Parameters.AddWithValue("@MaKhachHang", obj.MaKH);
                    comm.Parameters.AddWithValue("@NgayLapHoaDon", obj.NgayLap);
                    comm.Parameters.AddWithValue("@TongThanhTien", obj.TongThanhTien);

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

        public string selectAll(List<HoaDonDTO> lsObj)
        {

            string query = string.Empty;
            query += " SELECT *";
            query += " FROM [HOADON]";

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
                                HoaDonDTO obj = new HoaDonDTO();
                                obj.MaHD = reader["MaHoaDon"].ToString();
                                obj.MaKH = reader["MaKhachHang"].ToString(); ////xem cách get ngày nhập trong c# .net nha bây
                                obj.NgayLap = reader["NgayLapHoaDon"].ToString();
                                obj.TongThanhTien = Convert.ToInt32(reader["TongThanhTien"].ToString());
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

        public string delete(HoaDonDTO obj)
        {
            string query = string.Empty;
            query += " DELETE FROM [HOADON] ";
            query += " WHERE ";
            query += " [MaHoaDon] = @MaHoaDon ";

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                using (SqlCommand comm = new SqlCommand())
                {
                    comm.Connection = conn;
                    comm.CommandType = CommandType.Text;
                    comm.CommandText = query;
                    comm.Parameters.AddWithValue("@MaHoaDon", obj.MaHD);
                    try
                    {
                        conn.Open();
                        comm.ExecuteNonQuery();
                    }
                    catch (Exception ex)
                    {
                        conn.Close();
                        //' xóa that bai!!!
                        return "Xóa hóa đơn thất bại\n" + ex.Message + "\n" + ex.StackTrace;
                    }
                }
            }
            return "0";
        }

        public string insertChiTiet(ChiTietHDDTO obj)
        {
            string query = string.Empty;
            //query += "INSERT INTO [CHITIETPHIEUNHAP] ([MaChiTietPhieuNHap], [MaPhieuNhap], [MaSach], [SoLuongNhap])";
            //query += "VALUES (@MaChiTietPhieuNHap,@MaPhieuNhap,@MaSach,@SoLuongNhap)";

            query += "INSERT INTO [CHITIETHOADON] ([MaChiTietHoaDon], [MaHoaDon], [MaSach] , [SoLuongBan] , [DonGiaBan])";
            query += "VALUES (@MaChiTietPhieuNHap,@MaPhieuNhap,@SoLuongNhap)";
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                using (SqlCommand comm = new SqlCommand())
                {
                    comm.Connection = conn;
                    comm.CommandType = CommandType.Text;
                    comm.CommandText = query;
                    comm.Parameters.AddWithValue("@MaChiTietHoaDon", obj.MaCTHD);
                    comm.Parameters.AddWithValue("@MaHoaDon", obj.MaHD);
                    comm.Parameters.AddWithValue("@MaSach", obj.MaSach);
                    comm.Parameters.AddWithValue("@SoLuongBan", obj.SLB);
                    comm.Parameters.AddWithValue("@DonGiaBan", obj.DonGia);
                    try
                    {
                        conn.Open();
                        comm.ExecuteNonQuery();
                    }
                    catch (Exception ex)
                    {
                        conn.Close();
                        // them that bai!!!
                        return "Thêm chi tiết hóa đơn thất bại\n" + ex.Message + "\n" + ex.StackTrace;
                    }
                }
            }
            return "0";
        }

        public string selectAllCT(List<ChiTietHDDTO> lsObj)
        {

            string query = string.Empty;
            //query += " SELECT [MaChiTietPhieuNHap], [MaPhieuNhap], [MaSach], [SoLuongNhap]";
            //query += " FROM [CHITIETPHIEUNHAP]";

            query += " SELECT *";
            query += " FROM [CHITIETHOADON]";
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
                                ChiTietHDDTO obj = new ChiTietHDDTO();
                                obj.MaCTHD = reader["MaChiTietPhieuNHap"].ToString();
                                obj.MaHD = reader["MaPhieuNhap"].ToString();
                                obj.MaSach = reader["MaSach"].ToString();
                                obj.SLB = Convert.ToInt32(reader["SoLuongNhap"].ToString());
                                obj.DonGia = Convert.ToInt32(reader["DonGia"].ToString());
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

        public string deleteChiTiet(ChiTietHDDTO obj)
        {
            string query = string.Empty;
            query += " DELETE FROM [CHITIETHOADON]  ";
            query += " WHERE ";
            query += " [MaHoaDon] = @MaHoaDon ";
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
                    comm.Parameters.AddWithValue("@MaHoaDon", obj.MaHD);
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
                        return "Xóa chi tiết hóa đơn thất bại\n" + ex.Message + "\n" + ex.StackTrace;
                    }
                }
            }
            return "0";
        }
    }
}
