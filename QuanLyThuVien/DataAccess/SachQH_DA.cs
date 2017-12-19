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
    public class SachQH_DA
    {
        SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["VIDO"].ToString());
        List<SachQH_BO> list = new List<SachQH_BO>();
        SachQH_BO s;
        public List<SachQH_BO> LoadSachQH()
        {
            try
            {
                SqlCommand cmd = new SqlCommand("MuonSachQuaHan", con);
                cmd.CommandType = CommandType.StoredProcedure;
                con.Open();
                var reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    s = new SachQH_BO();
                    s.MaPhieu = reader["MaPhieu"].ToString();
                    s.MaSach = reader["MaSach"].ToString();
                    s.TenSach = reader["TenSach"].ToString();
                    s.HoTenTG = reader["HoTenTG"].ToString();
                    s.MaTV = reader["MaTV"].ToString();
                    s.HoTen = reader["HoTen"].ToString();
                    s.DiaChi = reader["DiaChi"].ToString();
                    s.NgayMuon = DateTime.Parse(reader["NgayMuon"].ToString());
                    s.NgayTra = DateTime.Parse(reader["NgayTra"].ToString());
                    s.SachTraNgay = DateTime.Parse(reader["SachTraNgay"].ToString());
                    s.SoNgayQuaHan = int.Parse(reader["SoNgayQuaHan"].ToString());
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
