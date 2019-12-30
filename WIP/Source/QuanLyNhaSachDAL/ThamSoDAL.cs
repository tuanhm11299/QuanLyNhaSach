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
    public class ThamSoDAL
    {
        private string connectionString = null;

        public ThamSoDAL()
        {
            connectionString = ConfigurationManager.AppSettings["ConnectionString"];
        }

        public DataTable loadThamSo(List<ThamSoDTO> lsObj) // fix data table
        {
            string query = string.Empty;
            query += "SELECT [MaThamSo], [SoLuongNhapItNhat], [SoLuongTonToiDaTruocNhap], [SoLuongTonSauToiThieu], [SoTienNoToiDa], [SuDungQuyDinh4] FROM [THAMSO]";
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
                                ThamSoDTO obj = new ThamSoDTO();
                                obj.Mathamso = Convert.ToInt32(reader["MaThamSo"].ToString());
                                obj.SoLuongNhapItNhat = Convert.ToInt32(reader["SoLuongNhapItNhat"].ToString());
                                obj.SoLuongTonToiDaTruocNhap = Convert.ToInt32(reader["SoLuongTonToiDaTruocNhap"].ToString());
                                obj.SoLuongTonSauToiThieu = Convert.ToInt32(reader["SoLuongTonSauToiThieu"].ToString());
                                obj.SoTienNoToiDa = Convert.ToInt32(reader["SoTienNoToiDa"].ToString());
                                obj.SuDungQuyDinh4 = Convert.ToInt32(reader["SuDungQuyDinh4"].ToString());
                                lsObj.Add(obj);
                            }
                        }
                    }
                    catch (Exception ex)
                    {
                        conn.Close();
                        //' lấy that bai!!!
                        //return "Lấy tham số quy định thất bại\n" + ex.Message + "\n" + ex.StackTrace;
                    }
                }
            }
            //return "0";
        }
    }
}
