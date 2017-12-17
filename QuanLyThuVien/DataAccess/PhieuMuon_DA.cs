using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BusinessObject;
using System.Data.SqlClient;
using System.Configuration;
using System.Data;

namespace DataAccess
{
    public class PhieuMuon_DA
    {
        public static SqlConnection conn = new SqlConnection(ConfigurationManager.ConnectionStrings["VIDO"].ToString());

        public static bool PhieuMuonSach(PhieuMuon_BO PhieuMuonBO)
        {
            try
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand("ThemPhieuMuon", conn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@MaPhieu", PhieuMuonBO.MaPhieu);
                cmd.Parameters.AddWithValue("@MaTV", PhieuMuonBO.MaThanhVien);
                cmd.Parameters.AddWithValue("@NgayMuon", PhieuMuonBO.NgayMuon);
                cmd.Parameters.AddWithValue("@MaNV", PhieuMuonBO.MaNhanVien);
                cmd.Parameters.AddWithValue("@NgayTra", PhieuMuonBO.NgayTra);
                cmd.Parameters.AddWithValue("@MaSach", PhieuMuonBO.MaSach);
                cmd.Parameters.AddWithValue("@SoLuong", PhieuMuonBO.SoLuong);
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
    }
}
