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

        public string searchTuKhoa(string kw, List<QuanLySachDTO> lsObj)
        {

            string query = string.Empty;
            query += " SELECT [MaSach], [TenSach], [TheLoai], [TacGia], [SoLuongTon]";
            query += " FROM [SACH]";
            query += " WHERE ";
            query += " [MaSach] like @MaSach ";
            query += " or [TenSach] like @TenSach ";
            query += " or [TheLoai] like @TheLoai ";
            query += " or [TacGia] like @TacGia ";

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
                    comm.Parameters.AddWithValue("@MaSach", "%" + kw.ToString() + "%");
                    comm.Parameters.AddWithValue("@TenSach", "%" + kw.ToString() + "%");
                    comm.Parameters.AddWithValue("@TheLoai", "%" + kw.ToString() + "%");
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
    }
}
