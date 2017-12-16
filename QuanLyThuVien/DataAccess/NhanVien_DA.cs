using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Configuration;
using System.Data;
using BusinessObject;

namespace DataAccess
{
    public class NhanVien_DA
    {
        public static SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["VIDO"].ToString());
        List<NhanVien_BO> listNV = new List<NhanVien_BO>();
        NhanVien_BO NhanVien;
        public List<NhanVien_BO> LoadNV()
        {
            try
            {
                SqlCommand cmd = new SqlCommand("DanhSachNhanVien", con);
                cmd.CommandType = CommandType.StoredProcedure;
                con.Open();
                var reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    NhanVien = new NhanVien_BO();
                    NhanVien.MaNV = reader["MaNV"].ToString();
                    NhanVien.HoTen = reader["HoTen"].ToString();
                    NhanVien.GioiTinh = reader["GioiTinh"].ToString();
                    NhanVien.NgaySinh = DateTime.Parse(reader["NgaySinh"].ToString());
                    NhanVien.DienThoai = reader["DienThoai"].ToString();
                    NhanVien.DiaChi = reader["DiaChi"].ToString();
                    NhanVien.Email = reader["Email"].ToString();
                    NhanVien.NgayVaoLam = DateTime.Parse(reader["NgayVaoLam"].ToString());
                    listNV.Add(NhanVien);
                }
                reader.Close();
                cmd.Dispose();
            }
            catch
            {
                listNV = null;
            }
            finally
            {
                if (con.State == ConnectionState.Open)
                {
                    con.Close();
                }
            }
            return listNV;
        }
        //TimNV
        public List<NhanVien_BO> TimNV(NhanVien_BO NV)
        {
            try
            {
                SqlCommand cmd = new SqlCommand("TimNV", con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@MaNV", NV.MaNV);
                con.Open();
                var reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    NhanVien = new NhanVien_BO();
                    NhanVien.MaNV = reader["MaNV"].ToString();
                    NhanVien.HoTen = reader["HoTen"].ToString();
                    NhanVien.GioiTinh = reader["GioiTinh"].ToString();
                    NhanVien.NgaySinh = DateTime.Parse(reader["NgaySinh"].ToString());
                    NhanVien.DienThoai = reader["DienThoai"].ToString();
                    NhanVien.DiaChi = reader["DiaChi"].ToString();
                    NhanVien.Email = reader["Email"].ToString();
                    NhanVien.NgayVaoLam = DateTime.Parse(reader["NgayVaoLam"].ToString());
                    listNV.Add(NhanVien);
                }
                reader.Close();
                cmd.Dispose();
            }
            catch
            {
                listNV = null;
            }
            finally
            {
                if (con.State == ConnectionState.Open)
                {
                    con.Close();
                }
            }
            return listNV;
        }

        //Hàm Sửa Nhân Viên
        public bool UpdateNhanVien(NhanVien_BO NhanVien)
        {
            try
            {
                
                SqlCommand cmd = new SqlCommand("SuaNhanVien", con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@HoTen", NhanVien.HoTen);
                cmd.Parameters.AddWithValue("@GioiTinh", NhanVien.GioiTinh);
                cmd.Parameters.AddWithValue("@NgaySinh", NhanVien.NgaySinh);
                cmd.Parameters.AddWithValue("@DienThoai", NhanVien.DienThoai);
                cmd.Parameters.AddWithValue("@DiaChi", NhanVien.DiaChi);
                cmd.Parameters.AddWithValue("@Email", NhanVien.Email);
                cmd.Parameters.AddWithValue("@NgayVaoLam", NhanVien.NgayVaoLam);
                cmd.Parameters.AddWithValue("@MaNV", NhanVien.MaNV);
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

        //Hàm Xóa Nhân Viên
        public bool XoaNhanVien(NhanVien_BO NhanVien)
        {
            try
            {
                
                SqlCommand cmd = new SqlCommand("XoaNhanVien", con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@MaNV", NhanVien.MaNV);
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
    }
}
