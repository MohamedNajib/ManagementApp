using ManagementApp.BLL;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ManagementApp.DAL
{
    class WorkTeamOperations
    {

        public static bool GetAllWoktTeamsData(out DataTable UsersData, out string errorMessage)
        {
            errorMessage = string.Empty;
            UsersData = new DataTable();
            try
            {
                using (SqlConnection MyConnection = new SqlConnection(Utils.connectionString))
                {
                    MyConnection.Open();
                    string Qs = "GET_ALL_WORK_TEAMS";
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
    }
}
