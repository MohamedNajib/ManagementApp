using ManagementApp.BO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using ManagementApp.BLL;
using System.Data;

namespace ManagementApp.DAL
{
    class UserDatabaseOperations
    {


        public static bool getUserData(ref UserModel UserData, out string errorMessage) 
        {
            errorMessage = string.Empty;

            if (UserData == null)
            {
                errorMessage = "UserData == null";
                return false;
            }
            if (UserData.User_Email.Trim().Equals(string.Empty))
            {
                errorMessage = "UserData.User_Email == str.empy";
                return false;
            }

            try
            {

                using (SqlConnection MyConnection = new SqlConnection(Utils.connectionString))
                {
                    string Qs = "dbo.[GET_USER_INFORMATION]";
                    SqlCommand cmd = MyDB.GetCmd_SP(MyConnection, Qs, out errorMessage);
                    cmd.Parameters.AddWithValue("@User_Email", UserData.User_Email);
                    cmd.Parameters.AddWithValue("@User_Password", UserData.User_Password);

                    cmd.Parameters.Add("@User_ID", SqlDbType.Int).Direction = ParameterDirection.Output;
                    cmd.Parameters.Add("@User_IS_Admin", SqlDbType.Bit).Direction = ParameterDirection.Output;
                    cmd.Parameters.Add("@User_Name", SqlDbType.NVarChar, 100).Direction = ParameterDirection.Output;
                    cmd.Parameters.Add("@User_Phone", SqlDbType.NVarChar, 50).Direction = ParameterDirection.Output;
                    cmd.ExecuteNonQuery();

                    cmd.Dispose();
                    MyConnection.Close();

                    if ((int)cmd.Parameters["@RV"].Value != 1)
                    {
                        errorMessage = cmd.Parameters["@Error_Msg"].Value.ToString();
                        return false;
                    }

                    UserData.User_ID = (int)cmd.Parameters["@User_ID"].Value;
                    UserData.User_IS_Admin = (bool)cmd.Parameters["@User_IS_Admin"].Value;
                    UserData.User_Name = cmd.Parameters["@User_Name"].Value.ToString();
                    UserData.User_Phone = cmd.Parameters["@User_Phone"].Value.ToString();
                }
                return true;
            }
            catch (Exception ex)
            {
                errorMessage = "UserDatabaseOperations.GetUserData2.Exception:" + ex.Message;
                return false;
            }
        }

        public static bool GetAllUsersData(out DataTable UsersData, out string errorMessage)
        {
            errorMessage = string.Empty;
            UsersData = new DataTable();
            try
            {
                using (SqlConnection MyConnection = new SqlConnection(Utils.connectionString))
                {
                    MyConnection.Open();
                    string Qs = "GET_ALL_USERS";
                    SqlCommand cmd = MyDB.GetCmd_SP(MyConnection, Qs, out errorMessage);

                    SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                    adapter.Fill(UsersData);
                    cmd.Dispose();
                    MyConnection.Close();
                    if ((int)cmd.Parameters["@RV"].Value != 1)
                    {
                        errorMessage = cmd.Parameters["@Error_Msg"].Value.ToString();
                        return false;
                    }

                }

                return true;
            }
            catch (Exception ex)
            {
                errorMessage = "UserDatabaseOperations.GetAllUsersData.Exception:" + ex.Message;
                return false;
            }
        }

        public static bool getUserData1(ref UserModel UserData, out string errorMessage)
        {
        
        errorMessage = string.Empty;

            if (UserData == null)
            {
                errorMessage = "UserData == null";
                return false;
            }
            if (UserData.User_Email.Trim().Equals(string.Empty))
            {
                errorMessage = "UserData.User_Email == str.empy";
                return false;
            }

            try
            {

                using (SqlConnection MyConnection = new SqlConnection(Utils.connectionString))
                {
                    SqlCommand cmd = MyDB.GetCmd_SP(MyConnection, "dbo.[GET_USER_INFORMATION]", out errorMessage);
                    cmd.Parameters.AddWithValue("@User_Email", UserData.User_Email);
                    cmd.Parameters.AddWithValue("@User_Password", UserData.User_Password);

                    cmd.Parameters.Add("@User_ID", SqlDbType.Int).Direction = ParameterDirection.Output;
                    cmd.Parameters.Add("@User_IS_Admin", SqlDbType.Bit).Direction = ParameterDirection.Output;
                    cmd.Parameters.Add("@User_Name", SqlDbType.NVarChar, 100).Direction = ParameterDirection.Output;
                    cmd.Parameters.Add("@User_Phone", SqlDbType.NVarChar, 50).Direction = ParameterDirection.Output;
                    cmd.ExecuteNonQuery();

                    cmd.Dispose();
                    MyConnection.Close();

                    if ((int)cmd.Parameters["@RV"].Value != 1)
                    {
                        errorMessage = cmd.Parameters["@Error_Msg"].Value.ToString();
                        return false;
                    }

                    UserData.User_ID = (int)cmd.Parameters["@User_ID"].Value;
                    UserData.User_IS_Admin = (bool)cmd.Parameters["@User_IS_Admin"].Value;
                    UserData.User_Name = cmd.Parameters["@User_Name"].Value.ToString();
                    UserData.User_Phone = cmd.Parameters["@User_Phone"].Value.ToString();
                }
                return true;
            }
            catch (Exception ex)
            {
                errorMessage = "UserDatabaseOperations.GetUserData2.Exception:" + ex.Message;
                return false;
            }
        }

        public static bool InsertUser(UserModel UserData, out string errorMessage)
        {
            errorMessage = string.Empty;


            DataTable _Dt = new DataTable();
            if (UserData == null)
            {
                errorMessage = "UserData == null";
                return false;
            }

            try
            {
                using (SqlConnection MyConnection = new SqlConnection(Utils.connectionString))
                {
                    MyConnection.Open();
                    string Qs = "INSERT_USER";
                    SqlCommand cmd = MyDB.GetCmd_SP(MyConnection, Qs, out errorMessage);
                 
                    cmd.Parameters.AddWithValue("@User_Email", UserData.User_Email);
                    cmd.Parameters.AddWithValue("@User_Password", UserData.User_Password);
                    cmd.Parameters.AddWithValue("@User_IS_Admin", UserData.User_IS_Admin);
                    cmd.Parameters.AddWithValue("@User_Name", UserData.User_Name);
                    cmd.Parameters.AddWithValue("@User_Phone", UserData.User_Phone);
                    cmd.Parameters.AddWithValue("@JobID", UserData.JobID);
                    cmd.Parameters.AddWithValue("@TeamID", UserData.TeamID);
                    cmd.ExecuteNonQuery();
                    if ((int)cmd.Parameters["@RV"].Value != 1)
                    {
                        errorMessage = cmd.Parameters["@Error_Msg"].Value.ToString();
                        return false;
                    }
                    //if (UserData.User_ID == null) UserData.User_ID = (int)cmd.Parameters["@User_ID"].Value;


                    cmd.Dispose();
                    MyConnection.Close();
                }

                return true;
            }
            catch (Exception ex)
            {
                errorMessage = "UserDatabaseOperations.SignUpUsser.Exception: " + ex.Message;
                return false;
            }
        }
    }
}
