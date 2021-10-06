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
    class ProjectOperation
    {

        public static bool GetAllProjects(out DataTable UsersData, out string errorMessage)
        {
            errorMessage = string.Empty;
            UsersData = new DataTable();
            try
            {
                using (SqlConnection MyConnection = new SqlConnection(Utils.connectionString))
                {
                    MyConnection.Open();
                    string Qs = "GET_ALL_PROJECTS";
                    SqlCommand cmd = MyDB.GetCmd_SP(MyConnection, Qs, out errorMessage);
                  
                    cmd.ExecuteNonQuery();

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
                errorMessage = "TasksOperations.GetAllUsersTasksData.Exception:" + ex.Message;
                return false;
            }
        }
    }
}
