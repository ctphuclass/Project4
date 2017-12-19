using BusinessObject;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess
{
    public class QL_PhieuTra_DA
    {
        SqlConnection conn = new SqlConnection(ConfigurationManager.ConnectionStrings["VIDO"].ConnectionString);
        List<TraSachBO> lists = new List<TraSachBO>();
        TraSachBO TS;
        public void PhieuTra(TraSachBO TS)
        {
            try
            {
                SqlCommand cmd = new SqlCommand("LuuPhieuTra", conn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@MaPhieu", TS.MaPhieu);
                cmd.Parameters.AddWithValue("@MaSach", TS.MaSach);
                cmd.Parameters.AddWithValue("@MaNV", TS.MaNV);
                cmd.Parameters.AddWithValue("@SoLuong", TS.SoLuong);
                cmd.Parameters.AddWithValue("@SachTraNgay", TS.SachTraNgay);
                cmd.Parameters.AddWithValue("@PhatHuHong", TS.PhatHuHong);
                cmd.Parameters.AddWithValue("@PhatQuaHan", TS.PhatQuaHan);
                conn.Open();
                var i = cmd.ExecuteNonQuery();
            }
            catch
            {
            }
            finally
            {
                if (conn.State == ConnectionState.Open)
                {
                    conn.Close();
                }
            }
        }
        public List<TraSachBO> LoadTraSach()
        {
            try
            {
                SqlCommand cmd = new SqlCommand("LoadTraSach", conn);
                cmd.CommandType = CommandType.StoredProcedure;
                conn.Open();
                var reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    TS = new TraSachBO();
                    TS.MaPhieu = reader["MaPhieu"].ToString();
                    TS.MaSach = reader["MaSach"].ToString();
                    TS.MaNV = reader["MaNV"].ToString();
                    TS.SoLuong = int.Parse(reader["SoLuong"].ToString());
                    TS.SachTraNgay = DateTime.Parse(reader["SachTraNgay"].ToString());
                    TS.PhatHuHong = int.Parse(reader["PhatHuHong"].ToString());
                    TS.PhatQuaHan = int.Parse(reader["PhatQuaHan"].ToString());
                    lists.Add(TS);
                }
                reader.Close();
                cmd.Dispose();
            }
            catch
            {
                lists = null;
            }
            finally
            {
                if (conn.State == ConnectionState.Open)
                {
                    conn.Close();
                }
            }
            return lists;
        }
    }
}
