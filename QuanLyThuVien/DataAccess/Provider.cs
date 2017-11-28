using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace DataAccess
{
    class Provider
    {
        //Hàm Kết Nối
        #region
        public static SqlConnection ConnectProveder()
        {
            string sConnect = @"Data Source=LAPTOP-2UJ66JCP\SQLEXPRESS;Initial Catalog=QuanLyThuVien;Integrated Security=True";
            SqlConnection conn = new SqlConnection(sConnect);
            conn.Open();
            return conn;
        }
        #endregion

        //Hàm Đóng Kết Nối
        #region
        public static void EndConnect(SqlConnection conn)
        {
            conn.Close();
        }
        #endregion

    }
}
