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
    public class ThanhVien_DA
    {
        SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["VIDO"].ToString());
        List<ThanhVien_BO> list = new List<ThanhVien_BO>();
        ThanhVien_BO TV;
        public List<ThanhVien_BO> LoadThanhVien()
        {
            try
            {
                SqlCommand cmd = new SqlCommand("LOADTHANHVIEN", con);
                cmd.CommandType = CommandType.StoredProcedure;
                con.Open();
                var reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    TV = new ThanhVien_BO();
                    TV.MaTV = reader["MaTV"].ToString();
                    TV.HoTen = reader["HoTen"].ToString();
                    TV.Email = reader["Email"].ToString();
                    TV.GioiTinh = reader["GioiTinh"].ToString();
                    TV.NgaySinh = DateTime.Parse(reader["NgaySinh"].ToString());
                    TV.DiaChi = reader["DiaChi"].ToString();
                    TV.DienThoai = reader["DienThoai"].ToString();
                    TV.NgayLamThe = DateTime.Parse(reader["NgayLamThe"].ToString());
                    TV.NgayHetHan = DateTime.Parse(reader["NgayHetHan"].ToString());
                    list.Add(TV);
                }
                reader.Close();
                cmd.Dispose();
            }
            catch
            {
                list = null;
            }
            finally
            {
                if (con.State == ConnectionState.Open)
                {
                    con.Close();
                }
            }
            return list;
        }
        public bool InsertUpdateTV(ThanhVien_BO s)
        {
            try
            {
                SqlCommand cmd = new SqlCommand("UPDATEANDINSERTTV", con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@MaTV", s.MaTV);
                cmd.Parameters.AddWithValue("@HoTen", s.HoTen);
                cmd.Parameters.AddWithValue("@Email", s.Email);
                cmd.Parameters.AddWithValue("@GioiTinh", s.GioiTinh);
                cmd.Parameters.AddWithValue("@NgaySinh", s.NgaySinh);
                cmd.Parameters.AddWithValue("@DiaChi", s.DiaChi);
                cmd.Parameters.AddWithValue("@DienThoai", s.DienThoai);
                cmd.Parameters.AddWithValue("@NgayLamThe", s.NgayLamThe);
                cmd.Parameters.AddWithValue("@NgayHetHan", s.NgayHetHan);
                con.Open();
                cmd.ExecuteNonQuery();
                return true;
            }
            catch
            {
                return false;
            }
            finally
            {
                if (con.State == ConnectionState.Open)
                {
                    con.Close();
                }
            }
        }
        public bool DeleteTV(ThanhVien_BO s)
        {
            try
            {
                SqlCommand cmd = new SqlCommand("DELETETV", con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@MaTV", s.MaTV);
                con.Open();
                cmd.ExecuteNonQuery();
                return true;
            }
            catch
            {
                return false;
            }
            finally
            {
                if (con.State == ConnectionState.Open)
                {
                    con.Close();
                }
            }
        }
        public List<ThanhVien_BO> TimTV(ThanhVien_BO s)
        {
            try
            {
                SqlCommand cmd = new SqlCommand("TimTV", con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@MaTV", s.MaTV);
                con.Open();
                var reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    TV = new ThanhVien_BO();
                    TV.MaTV = reader["MaTV"].ToString();
                    TV.HoTen = reader["HoTen"].ToString();
                    TV.Email = reader["Email"].ToString();
                    TV.GioiTinh = reader["GioiTinh"].ToString();
                    TV.NgaySinh = DateTime.Parse(reader["NgaySinh"].ToString());
                    TV.DiaChi = reader["DiaChi"].ToString();
                    TV.DienThoai = reader["DienThoai"].ToString();
                    TV.NgayLamThe = DateTime.Parse(reader["NgayLamThe"].ToString());
                    TV.NgayHetHan = DateTime.Parse(reader["NgayHetHan"].ToString());
                    list.Add(TV);
                }
                reader.Close();
                cmd.Dispose();
            }
            catch
            {
                list = null;
            }
            finally
            {
                if (con.State == ConnectionState.Open)
                {
                    con.Close();
                }
            }
            return list;
        }
    }
}
