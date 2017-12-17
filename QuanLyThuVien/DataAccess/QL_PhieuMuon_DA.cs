using System;
using System.Collections.Generic;
using System.Linq;
using System.Data;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Configuration;
using BusinessObject;

namespace DataAccess
{
    public class QL_PhieuMuon_DA
    {
        SqlConnection conn = new SqlConnection(ConfigurationManager.ConnectionStrings["VIDO"].ConnectionString);

        public List<KhoSach_BO> KhoSach()
        {
            List<KhoSach_BO> listKhoSach = new List<KhoSach_BO>();
            KhoSach_BO unitKhoSach;
            try
            {
                SqlCommand cmd = new SqlCommand("KhoSach", conn);
                cmd.CommandType = CommandType.StoredProcedure;
                SqlDataAdapter SqldaKhoSach = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                SqldaKhoSach.Fill(dt);
                for (int i = 0; i < dt.Rows.Count; i++)
                {
                    unitKhoSach = new KhoSach_BO();
                    unitKhoSach.MaSach = dt.Rows[i]["MaSach"].ToString();
                    unitKhoSach.TenSach = dt.Rows[i]["TenSach"].ToString();
                    unitKhoSach.Gia = int.Parse(dt.Rows[i]["Gia"].ToString());
                    unitKhoSach.DaMuon = int.Parse(dt.Rows[i]["DaMuon"].ToString());
                    unitKhoSach.ConLai = int.Parse(dt.Rows[i]["ConLai"].ToString());
                    listKhoSach.Add(unitKhoSach);
                }
            }
            catch
            {

            }
            finally
            {
                conn.Close();
            }
            return listKhoSach;
        }

        public List<ThanhVienMuonSach_BO> ThanhVienMuonS()
        {
            List<ThanhVienMuonSach_BO> listThanhVienMuon = new List<ThanhVienMuonSach_BO>();
            ThanhVienMuonSach_BO ThanhVienMuon;
            try
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand("ThanhVienMuon", conn);
                cmd.CommandType = CommandType.StoredProcedure;
                SqlDataAdapter SqldaTVMuon = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                SqldaTVMuon.Fill(dt);
                for (int i = 0; i < dt.Rows.Count; i++)
                {
                    ThanhVienMuon = new ThanhVienMuonSach_BO();
                    ThanhVienMuon.MaPhieu = dt.Rows[i]["MaPhieu"].ToString();
                    ThanhVienMuon.MaSach = dt.Rows[i]["MaSach"].ToString();
                    ThanhVienMuon.TenSach = dt.Rows[i]["TenSach"].ToString();
                    ThanhVienMuon.MaTV = dt.Rows[i]["MaTV"].ToString();
                    ThanhVienMuon.HoTen = dt.Rows[i]["HoTen"].ToString();
                    ThanhVienMuon.NgayMuon = DateTime.Parse(dt.Rows[i]["NgayMuon"].ToString());
                    ThanhVienMuon.NgayTra = DateTime.Parse(dt.Rows[i]["NgayTra"].ToString());
                    ThanhVienMuon.SoLuong = int.Parse(dt.Rows[i]["SoLuong"].ToString());
                    ThanhVienMuon.DiaChi = dt.Rows[i]["DiaChi"].ToString();
                    ThanhVienMuon.SoDienThoai = dt.Rows[i]["DienThoai"].ToString();
                    ThanhVienMuon.MaNV = dt.Rows[i]["MaNV"].ToString();
                    listThanhVienMuon.Add(ThanhVienMuon);
                }
            }
            catch
            {

            }
            finally
            {
                conn.Close();
            }
            return listThanhVienMuon;
        }
    }
}
