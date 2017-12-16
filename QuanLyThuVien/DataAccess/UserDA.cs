using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BusinessObject;
using System.Configuration;
using System.Data;

    public class UserDA
    {
        SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["VIDO"].ToString());
        public ResultMessageBO CheckUserLogin(UserBO ObjBO) // passing Bussiness object Here
        {
            ResultMessageBO result = new ResultMessageBO();
            try
            {
                /* Because We will put all out values from our (UserRegistration.aspx)
				To in Bussiness object and then Pass it to Bussiness logic and then to
				DataAcess
				this way the flow carry on*/
                SqlCommand cmd = new SqlCommand("usp_USER_CheckUser", con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@psUsername", ObjBO.Username);
                cmd.Parameters.AddWithValue("@psPassword", ObjBO.Password);
                cmd.Parameters.AddWithValue("@pResultCode", result.ResultCode);
                cmd.Parameters.AddWithValue("@pResultMessage", result.ResultMessage);
                cmd.Parameters["@pResultCode"].Direction = ParameterDirection.Output;
                cmd.Parameters["@pResultMessage"].Direction = ParameterDirection.Output;
                cmd.Parameters["@pResultMessage"].Size = 50;
                con.Open();
                cmd.ExecuteNonQuery();
                result.ResultCode = (int)cmd.Parameters["@pResultCode"].Value;
                result.ResultMessage = cmd.Parameters["@pResultMessage"].Value.ToString();
                cmd.Dispose();
            }
            catch (Exception ex)
            {
                result.ResultCode = -1;
                result.ResultMessage = ex.Message;
            }
            finally
            {
                if (con.State == ConnectionState.Open)
                {
                    con.Close();
                }
            }
            return result;
        }
    public List<UserPermissionBO> GetPermission(int piUserID, string psModule)
    {
        List<UserPermissionBO> list = new List<UserPermissionBO>();
        UserPermissionBO user;
        try
        {
            /* Because We will put all out values from our (UserRegistration.aspx)
            To in Bussiness object and then Pass it to Bussiness logic and then to
            DataAcess
            this way the flow carry on*/
            SqlCommand cmd = new SqlCommand("usp_USER_GetUserPermision", con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@piUserID", piUserID);
            cmd.Parameters.AddWithValue("@psModule", psModule);
            con.Open();
            var reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                user = new UserPermissionBO();
                user.UserID = int.Parse(reader["UserID"].ToString());
                user.Permission = reader["PermissionCode"].ToString();
                list.Add(user);
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
    public List<ThongTinCN> ThongTinCN(int UserID)
    {
        List<ThongTinCN> listTT = new List<ThongTinCN>();
        ThongTinCN TT;
        try
        {
            SqlCommand cmd = new SqlCommand("ThongTinUser", con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("UserID", UserID);
            con.Open();
            var reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                TT = new ThongTinCN();
                if (reader["MaNV"].ToString() == "")
                {
                    TT.MaCN = reader["MaTV"].ToString();
                }
                else
                {
                    TT.MaCN = reader["MaNV"].ToString();
                }
                TT.HoTen = reader["HoTen"].ToString();
                TT.GioiTinh = reader["GioiTinh"].ToString();
                TT.NgaySinh = DateTime.Parse(reader["NgaySinh"].ToString());
                TT.SDT = int.Parse(reader["DienThoai"].ToString());
                TT.Emial = reader["Email"].ToString();
                listTT.Add(TT);
            }
            reader.Close();
            cmd.Dispose();
        }
        catch
        {
            listTT = null;
        }
        finally
        {
            if (con.State == ConnectionState.Open)
            {
                con.Close();
            }
        }
        return listTT;
    }
    public ResultMessageBO ChangePass(UserBO ObjBO) // passing Bussiness object Here
    {
        ResultMessageBO result = new ResultMessageBO();
        try
        {
            SqlCommand cmd = new SqlCommand("usp_USER_ChangePassword", con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@psUsername", ObjBO.Username);
            cmd.Parameters.AddWithValue("@psPassword", ObjBO.Password);
            cmd.Parameters.AddWithValue("@psChangePasword", ObjBO.ChangePassword);
            cmd.Parameters.AddWithValue("@pResultCode", result.ResultCode);
            cmd.Parameters.AddWithValue("@pResultMessage", result.ResultMessage);
            cmd.Parameters["@pResultCode"].Direction = ParameterDirection.Output;
            cmd.Parameters["@pResultMessage"].Direction = ParameterDirection.Output;
            cmd.Parameters["@pResultMessage"].Size = 50;
            con.Open();
            cmd.ExecuteNonQuery();
            result.ResultCode = (int)cmd.Parameters["@pResultCode"].Value;
            result.ResultMessage = cmd.Parameters["@pResultMessage"].Value.ToString();
            cmd.Dispose();
        }
        catch (Exception ex)
        {
            result.ResultCode = -1;
            result.ResultMessage = ex.Message;
        }
        finally
        {
            if (con.State == ConnectionState.Open)
            {
                con.Close();
            }
        }
        return result;
    }
}

