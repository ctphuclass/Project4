using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
using BusinessObject;
using System.Configuration;

namespace DataAccess
{
    public class SeachNV_DA
    {
        SqlConnection conn = new SqlConnection(ConfigurationManager.ConnectionStrings["VIDO"].ToString());
        List<NhanVien_BO> ListTimKiem = new List<NhanVien_BO>();
        DataTable dt = new DataTable();
        public List<NhanVien_BO> Seach(NhanVien_BO SBO)
        {
            NhanVien_BO NhanVien;
            try
            {
                string query = string.Format("Exec TimKiemNV @TenNV = N'%{0}%'", SBO.HoTenNV);
                SqlCommand cmd = new SqlCommand(query, conn);
                conn.Open();
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                da.Fill(dt);
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
                    ListTimKiem.Add(NhanVien);
                }
            }
            catch
            {

            }
            finally
            {
                conn.Close();
            }
            return ListTimKiem;
        }
    }
}
