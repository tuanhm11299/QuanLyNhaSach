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
    public class BaoCaoTonDAL
    {
        private string connectionString = null;
        public BaoCaoTonDAL()
        {
            connectionString = ConfigurationManager.AppSettings["ConnectionString"];
        }

        public string insert(BaoCaoTonDTO obj)
        {
            string query = string.Empty;
            query += "INSERT INTO [BAOCAOTON] ([MaChiTietTon], [Thang], [Nam] , [MaSach] , [TonDau] , [TonPhatSinh], [TonCuoi])";
            query += "VALUES (@MaChiTietTon,@Thang,@Nam,@MaSach,@TonDau,@TonPhatSinh,@TonCuoi)";

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                using (SqlCommand comm = new SqlCommand())
                {
                    comm.Connection = conn;
                    comm.CommandType = CommandType.Text;
                    comm.CommandText = query;
                    comm.Parameters.AddWithValue("@MaChiTietTon", obj.MaCTTon);
                    comm.Parameters.AddWithValue("@Thang", obj.Month);
                    comm.Parameters.AddWithValue("@Nam", obj.Year);
                    comm.Parameters.AddWithValue("@MaSach", obj.MaSach);
                    comm.Parameters.AddWithValue("@TonDau", obj.TonDau);
                    comm.Parameters.AddWithValue("@TonPhatSinh", obj.TonPhatSinh);
                    comm.Parameters.AddWithValue("@TonCuoi", obj.TonCuoi);
                    try
                    {
                        conn.Open();
                        comm.ExecuteNonQuery();
                    }
                    catch (Exception ex)
                    {
                        conn.Close();
                        // them that bai!!!
                        return "Thêm báo cáo tồn thất bại\n" + ex.Message + "\n" + ex.StackTrace;
                    }
                }
            }
            return "0";
        }

        public string selectAll(List<BaoCaoTonDTO> lsObj)
        {

            string query = string.Empty;
            query += " SELECT *";
            query += " FROM [BAOCAOTON]";

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
                                BaoCaoTonDTO obj = new BaoCaoTonDTO();
                                obj.MaCTTon = reader["MaChiTietTon"].ToString();
                                obj.Month = Convert.ToInt32(reader["Thang"].ToString()); ////xem cách get ngày nhập trong c# .net nha bây
                                obj.Year = Convert.ToInt32(reader["Nam"].ToString());
                                obj.MaSach = reader["MaSach"].ToString();
                                obj.TonDau = Convert.ToInt32(reader["TonDau"].ToString());
                                obj.TonPhatSinh = Convert.ToInt32(reader["TonPhatSinh"].ToString());
                                obj.TonCuoi = Convert.ToInt32(reader["TonCuoi"].ToString());
                                lsObj.Add(obj);
                            }
                        }
                    }
                    catch (Exception ex)
                    {
                        conn.Close();
                        //' lấy that bai!!!
                        return "Lấy thông tin báo cáo tồn thất bại\n" + ex.Message + "\n" + ex.StackTrace;
                    }
                }
            }
            return "0";
        }

        public string searchThanghoacNam(string kw, List<BaoCaoTonDTO> lsObj)
        {

            string query = string.Empty;
            query += "SELECT *";
            query += " FROM [BAOCAOTON]";
            query += " WHERE ";
            query += " [Thang] like @Thang ";
            query += "or [Nam] like @Nam";


            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                using (SqlCommand comm = new SqlCommand())
                {
                    comm.Connection = conn;
                    comm.CommandType = CommandType.Text;
                    comm.CommandText = query;
                    comm.Parameters.AddWithValue("@Thang", "%" + kw.ToString() + "%");
                    comm.Parameters.AddWithValue("@Nam", "%" + kw.ToString() + "%");
                    try
                    {
                        conn.Open();
                        SqlDataReader reader = comm.ExecuteReader();
                        if (reader.HasRows == true)
                        {
                            lsObj.Clear();
                            while (reader.Read())
                            {
                                BaoCaoTonDTO obj = new BaoCaoTonDTO();
                                obj.MaCTTon = reader["MaChiTietTon"].ToString();
                                obj.Month = Convert.ToInt32(reader["Thang"].ToString());
                                obj.Year = Convert.ToInt32(reader["Nam"].ToString());
                                obj.MaSach = reader["MaSach"].ToString();
                                obj.TonDau = Convert.ToInt32(reader["TonDau"].ToString());
                                obj.TonPhatSinh = Convert.ToInt32(reader["TonPhatSinh"].ToString());
                                obj.TonCuoi = Convert.ToInt32(reader["TonCuoi"].ToString());
                                lsObj.Add(obj);
                            }
                        }
                    }
                    catch (Exception ex)
                    {
                        conn.Close();
                        //' lấy that bai!!!
                        return "Tìm báo cáo thất bại\n" + ex.Message + "\n" + ex.StackTrace;
                    }
                }
            }
            return "0";
        }

        public string searchThangvaNam(string thang, string nam , List<BaoCaoTonDTO> lsObj)
        {

            string query = string.Empty;
            query += "SELECT *";
            query += " FROM [BAOCAOTON]";
            query += " WHERE ";
            query += " [Thang] like @Thang ";
            query += "and [Nam] like @Nam";


            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                using (SqlCommand comm = new SqlCommand())
                {
                    comm.Connection = conn;
                    comm.CommandType = CommandType.Text;
                    comm.CommandText = query;
                    comm.Parameters.AddWithValue("@Thang", "%" + thang.ToString() + "%");
                    comm.Parameters.AddWithValue("@Nam", "%" + nam.ToString() + "%");
                    try
                    {
                        conn.Open();
                        SqlDataReader reader = comm.ExecuteReader();
                        if (reader.HasRows == true)
                        {
                            lsObj.Clear();
                            while (reader.Read())
                            {
                                BaoCaoTonDTO obj = new BaoCaoTonDTO();
                                obj.MaCTTon = reader["MaChiTietTon"].ToString();
                                obj.Month = Convert.ToInt32(reader["Thang"].ToString());
                                obj.Year = Convert.ToInt32(reader["Nam"].ToString());
                                obj.MaSach = reader["MaSach"].ToString();
                                obj.TonDau = Convert.ToInt32(reader["TonDau"].ToString());
                                obj.TonPhatSinh = Convert.ToInt32(reader["TonPhatSinh"].ToString());
                                obj.TonCuoi = Convert.ToInt32(reader["TonCuoi"].ToString());
                                lsObj.Add(obj);
                            }
                        }
                    }
                    catch (Exception ex)
                    {
                        conn.Close();
                        //' lấy that bai!!!
                        return "Tìm báo cáo thất bại\n" + ex.Message + "\n" + ex.StackTrace;
                    }
                }
            }
            return "0";
        }
    }
}
