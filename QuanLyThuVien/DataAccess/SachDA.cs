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
    public class SachDA
    {
        SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["VIDO"].ToString());
        List<SachBO> list = new List<SachBO>();
        SachBO s;
        public List<SachBO> LoadSach()
        {
            try
            {
                SqlCommand cmd = new SqlCommand("LOADSACH", con);
                cmd.CommandType = CommandType.StoredProcedure;
                con.Open();
                var reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    s = new SachBO();
                    s.MaSach = reader["MaSach"].ToString();
                    s.TenSach = reader["TenSach"].ToString();
                    s.SoTrang = int.Parse(reader["SoTrang"].ToString());
                    s.DonGia = int.Parse(reader["Gia"].ToString());
                    s.SoLuong = int.Parse(reader["SoLuong"].ToString());
                    s.NgayNhap = DateTime.Parse(reader["NgayNhap"].ToString());
                    s.MaTacGia = reader["MaTG"].ToString();
                    s.MaTheLoai = reader["MaTL"].ToString();
                    s.MaNXB = reader["MaNXB"].ToString();
                    s.TinhTrang = bool.Parse(reader["TinhTrang"].ToString());
                    list.Add(s);
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
        public bool InsertUpdate(SachBO s)
        {
            try
            {
                SqlCommand cmd = new SqlCommand("UPDATEANDINSERT", con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@MaSach", s.MaSach);
                cmd.Parameters.AddWithValue("@TenSach", s.TenSach);
                cmd.Parameters.AddWithValue("@SoTrang", s.SoTrang);
                cmd.Parameters.AddWithValue("@DonGia", s.DonGia);
                cmd.Parameters.AddWithValue("@SoLuong", s.SoLuong);
                cmd.Parameters.AddWithValue("@NgayNhap", s.NgayNhap);
                cmd.Parameters.AddWithValue("@MaNXB", s.MaNXB);
                cmd.Parameters.AddWithValue("@MaTacGia", s.MaTacGia);
                cmd.Parameters.AddWithValue("@MaTheLoai", s.MaTheLoai);
                cmd.Parameters.AddWithValue("@TinhTrang", s.TinhTrang);
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
        public bool Delete(SachBO s)
        {
            try
            {
                SqlCommand cmd = new SqlCommand("DELETESACH", con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@MaSach", s.MaSach); 
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
        public List<SachBO> TimSach(SachBO s)
        {
            try
            {
                SqlCommand cmd = new SqlCommand("TimSach", con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@Sach",s.MaSach);
                con.Open();
                var reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    s = new SachBO();
                    s.MaSach = reader["MaSach"].ToString();
                    s.TenSach = reader["TenSach"].ToString();
                    s.SoTrang = int.Parse(reader["SoTrang"].ToString());
                    s.DonGia = int.Parse(reader["Gia"].ToString());
                    s.SoLuong = int.Parse(reader["SoLuong"].ToString());
                    s.NgayNhap = DateTime.Parse(reader["NgayNhap"].ToString());
                    s.MaTacGia = reader["MaTG"].ToString();
                    s.MaTheLoai = reader["MaTL"].ToString();
                    s.MaNXB = reader["MaNXB"].ToString();
                    s.TinhTrang = bool.Parse(reader["TinhTrang"].ToString());
                    list.Add(s);
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
