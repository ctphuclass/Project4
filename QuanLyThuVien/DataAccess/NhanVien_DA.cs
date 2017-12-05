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
       public static SqlConnection conn = new SqlConnection(ConfigurationManager.ConnectionStrings["VIDO"].ToString());
        List<NhanVien_BO> listNV = new List<NhanVien_BO>();
        
        DataTable dt = new DataTable();
        #region
        public List<NhanVien_BO> HamNV()
        {
            try
            {
                string Squery = "DanhSachNhanVien";
                SqlCommand cmd = new SqlCommand(Squery, conn);
                cmd.CommandType = CommandType.StoredProcedure;
                conn.Open();
                SqlDataAdapter SqldaDSNV = new SqlDataAdapter(cmd);
                SqldaDSNV.Fill(dt);
                NhanVien_BO NhanVien;
                for (int i = 0; i < dt.Rows.Count; i++)
                {
                    NhanVien = new NhanVien_BO();
                    NhanVien.MaNV = dt.Rows[i]["MaNV"].ToString();
                    NhanVien.HoTenNV = dt.Rows[i]["HoTen"].ToString();
                    NhanVien.GioiTinh = dt.Rows[i]["GioiTinh"].ToString();
                    NhanVien.NgaySinh = DateTime.Parse(dt.Rows[i]["NgaySinh"].ToString());
                    NhanVien.SoDienThoai = dt.Rows[i]["DienThoai"].ToString();
                    NhanVien.DiaChi = dt.Rows[i]["DiaChi"].ToString();
                    NhanVien.Email = dt.Rows[i]["Email"].ToString();
                    NhanVien.NgayVaoLam = DateTime.Parse(dt.Rows[i]["NgayVaoLam"].ToString());
                    listNV.Add(NhanVien);
                }   
            }
            catch
            {

            }
            finally
            {
                conn.Close();
            }
            return listNV;
        }
        #endregion

        //Hàm Thêm Nhân Viên
        #region
        public static bool ThemNV(NhanVien_BO NhanVien)
        {
            try
            {
                conn.Open();

                SqlCommand cmd = new SqlCommand("ThemNhanVien", conn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@MaNV", NhanVien.MaNV);
                cmd.Parameters.AddWithValue("@HoTen", NhanVien.HoTenNV);
                cmd.Parameters.AddWithValue("@GioiTinh", NhanVien.GioiTinh);
                cmd.Parameters.AddWithValue("@NgaySinh", NhanVien.NgaySinh);
                cmd.Parameters.AddWithValue("@DienThoai", NhanVien.SoDienThoai);
                cmd.Parameters.AddWithValue("@DiaChi", NhanVien.DiaChi);
                cmd.Parameters.AddWithValue("@Email", NhanVien.Email);
                cmd.Parameters.AddWithValue("@NgayVaoLam", NhanVien.NgayVaoLam);
                var i = cmd.ExecuteNonQuery();
            }
            catch
            {

            }
            finally
            {
                conn.Close();
            }                                
            return true;
        }
        #endregion

        //Hàm Sửa Nhân Viên
        #region
        public static bool UpdateNhanVien(NhanVien_BO NhanVien)
        {
           try
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand("SuaNhanVien",conn);
                cmd.CommandType = CommandType.StoredProcedure;               
                cmd.Parameters.AddWithValue("@HoTen", NhanVien.HoTenNV);
                cmd.Parameters.AddWithValue("@GioiTinh", NhanVien.GioiTinh);
                cmd.Parameters.AddWithValue("@NgaySinh", NhanVien.NgaySinh);
                cmd.Parameters.AddWithValue("@DienThoai", NhanVien.SoDienThoai);
                cmd.Parameters.AddWithValue("@DiaChi", NhanVien.DiaChi);
                cmd.Parameters.AddWithValue("@Email", NhanVien.Email);
                cmd.Parameters.AddWithValue("@NgayVaoLam", NhanVien.NgayVaoLam);
                cmd.Parameters.AddWithValue("@MaNV", NhanVien.MaNV);
                cmd.ExecuteNonQuery();
            }
            catch
            {

            }
            finally
            {
                conn.Close();
            }
            return true;
        }
        #endregion

        //Hàm Xóa Nhân Viên
        #region
        public static bool XoaNhanVien(NhanVien_BO NhanVien)
        {
            try
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand("XoaNhanVien", conn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@MaNV", NhanVien.MaNV);
                cmd.ExecuteNonQuery();
            }
            catch
            {

            }
            finally
            {
                conn.Close();
            }
            return true;
        }
        #endregion
    }
}
