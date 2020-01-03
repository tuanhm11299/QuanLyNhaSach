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

        public string ConnectionString { get => connectionString; set => connectionString = value; }

        public ThamSoDAL()
        {
            connectionString = ConfigurationManager.AppSettings["ConnectionString"];
        }

        public ThamSoDTO QuyDinh()//laysach
        {
            string query = string.Empty;
            query = "SELECT * FROM THAMSO";

            ThamSoDTO qd = new ThamSoDTO();

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
                                qd.Mathamso = Convert.ToInt32(reader["MaThamSo"]);
                                qd.SoLuongNhapItNhat = Convert.ToInt32(reader["SoLuongNhapItNhat"]);
                                qd.SoLuongTonToiDaTruocNhap = Convert.ToInt32(reader["SoLuongTonToiDaTruocNhap"]);
                                qd.SoLuongTonSauToiThieu = Convert.ToInt32(reader["SoLuongTonSauToiThieu"]);
                                qd.SoTienNoToiDa = Convert.ToInt32(reader["SoTienNoToiDa"]);
                                qd.SuDungQuyDinh4 = Convert.ToInt32(reader["SuDungQuyDinh4"]);
                            }
                            conn.Close();
                            conn.Dispose();
                            return qd;
                        }

                    }
                    catch
                    {
                        conn.Close();
                        return null;
                    }

                }
            }
            return qd;
        }

        public bool chinhsuaQuyDinh(ThamSoDTO qd)
        {
            string query = string.Empty;
            query += "UPDATE [THAMSO] ";
            query += "SET [SoLuongNhapItNhat] = @SoLuongNhapItNhat, [SoLuongTonToiDaTruocNhap] = @SoLuongTonToiDaTruocNhap, [SoLuongTonSauToiThieu] = @SoLuongTonSauToiThieu, [SoTienNoToiDa] = @SoTienNoToiDa, [SuDungQuyDinh4] = @SuDungQuyDinh4";

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                using (SqlCommand cmd = new SqlCommand())
                {
                    cmd.Connection = conn;
                    cmd.CommandType = System.Data.CommandType.Text;
                    cmd.CommandText = query;

                    //cmd.Parameters.AddWithValue("@MaThamSo", qd.Mathamso);
                    cmd.Parameters.AddWithValue("@SoLuongNhapItNhat", qd.SoLuongNhapItNhat);
                    cmd.Parameters.AddWithValue("@SoLuongTonToiDaTruocNhap", qd.SoLuongTonToiDaTruocNhap);
                    cmd.Parameters.AddWithValue("@SoLuongTonSauToiThieu", qd.SoLuongTonSauToiThieu);
                    cmd.Parameters.AddWithValue("@SoTienNoToiDa", qd.SoTienNoToiDa);
                    cmd.Parameters.AddWithValue("@SuDungQuyDinh4", qd.SuDungQuyDinh4);

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
