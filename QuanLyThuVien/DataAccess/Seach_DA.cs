using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
using BusinessObject;

namespace DataAccess
{
    class Seach_DA
    {
        public static SqlConnection conn;

        public List<SeachBO> Seach()
        {
            List<SeachBO> ListTimKiem = new List<SeachBO>();
            SeachBO TK;
            try
            {

                SqlCommand cmd = new SqlCommand("usp_DanhSach_TimKiem", conn);
                cmd.CommandType = CommandType.StoredProcedure;
                conn = Provider.ConnectProveder();
                var Reader = cmd.ExecuteReader();
                while (Reader.Read())
                {
                    TK = new SeachBO();
                    TK.MaSach = Int32.Parse(Reader["MaSach"].ToString());
                    TK.TenSach = Reader["TenSach"].ToString();
                    TK.Gia = Int32.Parse(Reader["Gia"].ToString());
                    TK.TenNXB = Reader["TenNXB"].ToString();
                    TK.TenTG = Reader["TenTG"].ToString();
                    TK.SoLuong = Int32.Parse(Reader["SoLuong"].ToString());
                    TK.NgayNhap = DateTime.Parse(Reader["NgayNhap"].ToString());
                    TK.TheLoai = Reader["TheLoai"].ToString();
                    ListTimKiem.Add(TK);
                }
                Reader.Close();
                cmd.Dispose();
            }
            catch
            {
                ListTimKiem = null;
            }
            finally
            {
                Provider.EndConnect(conn);
            }
            return ListTimKiem;
        }

    }
}
