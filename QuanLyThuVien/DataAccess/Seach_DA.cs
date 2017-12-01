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
    public class Seach_DA
    {
        SqlConnection conn = new SqlConnection(ConfigurationManager.ConnectionStrings["VIDO"].ToString());
        List<SeachBO> ListTimKiem = new List<SeachBO>();       
        DataTable dt = new DataTable();
        public List<SeachBO> Seach(SeachBO SBO)
        {
            SeachBO TK;
            try
            {
                string query = string.Format("exec [store_timkiem] @TenSach = N'%{0}%'", SBO.TenSach);
                SqlCommand cmd = new SqlCommand(query, conn);
                conn.Open();

                SqlDataAdapter da = new SqlDataAdapter(cmd);
                da.Fill(dt);
                for (int i=0;i<dt.Rows.Count;i++)
                {
                    TK = new SeachBO();
                    TK.MaSach = dt.Rows[i]["MaSach"].ToString();
                    TK.TenSach = dt.Rows[i]["TenSach"].ToString();
                    TK.TenTG = dt.Rows[i]["HoTenTG"].ToString();
                    TK.TenNXB = dt.Rows[i]["TenNXB"].ToString();
                    TK.TheLoai = dt.Rows[i]["TenTL"].ToString();
                    TK.NgayNhap = DateTime.Parse(dt.Rows[i]["NgayNhap"].ToString());
                    TK.Gia = Int32.Parse(dt.Rows[i]["Gia"].ToString());
                    TK.SoLuong = Int32.Parse(dt.Rows[i]["SoLuong"].ToString());
                    ListTimKiem.Add(TK);
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
