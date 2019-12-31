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

        /*public DataTable loadThamSo(List<ThamSoDTO> lsObj) // fix data table
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
        }*/

        public ThamSoDTO QuyDinh()
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
                                qd.Mathamso= reader.GetInt32(0);
                                qd.SoLuongNhapItNhat = reader.GetInt32(1);
                                qd.SoLuongTonToiDaTruocNhap = reader.GetInt32(2);
                                qd.SoLuongTonSauToiThieu = reader.GetInt32(3);
                                qd.SoTienNoToiDa = reader.GetInt32(4);
                                qd.SuDungQuyDinh4 = reader.GetInt32(5);
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
            query += "SET [MaThamSo] = @MaThamSo , [SoLuongNhapItNhat] = @SoLuongNhapItNhat, [SoLuongTonToiDaTruocNhap] = @SoLuongTonToiDaTruocNhap, [SoLuongTonSauToiThieu] = @SoLuongTonSauToiThieu, [SoTienNoToiDa] = @SoTienNoToiDa, [SuDungQuyDinh4] = @SuDungQuyDinh4";

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                using (SqlCommand cmd = new SqlCommand())
                {
                    cmd.Connection = conn;
                    cmd.CommandType = System.Data.CommandType.Text;
                    cmd.CommandText = query;

                    cmd.Parameters.AddWithValue("@MaThamSo", qd.Mathamso);
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
