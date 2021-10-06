using ManagementApp.BLL;
using ManagementApp.BO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ManagementApp.DAL
{
    class TasksOperations
    {
        private static String procedureAllUsersTasks = "GET_ALL_USER_PROJECT_TASKS";
        private static String procedureAdminAllProjectsTasks = "GET_ALL_PROJECTS_TASKS";
        private static String procedureTaskInsert = "INSERT_TASK";

        /// <summary>
        ///  `procedureAllUsersTasks` Procedur Parameters for get all User Tasks
        ///  `procedureAdminAllProjectsTasks` Procedur Parameters for get Admin all projekts and taskes
        /// </summary>
        private static String parameterEmail = "@User_Email";
        private static String parameterProjectID = "@TaskProjectID";


        /// <summary>
        ///  `procedureTaskInsert` Procedur Parameters for Inser New Task 
        /// </summary>
        private static String parameterTaskName = "@TaskName";
        private static String parameterTaskDes = "@TaskDes";
        private static String parameterAdminID = "@TaskAdminID";
        private static String parameterTaskProjectID = "@TaskProjectID";
        private static String parameterTaskStart = "@TaskStart";
        private static String parameterTaskEnd = "@TaskEnd";
        private static String parameterTaskDuration = "@TaskDuration";
        private static String parameterTaskState = "@TaskState";


        private static String parameterErrorMsg = "@Error_Msg";
        private static String parameterReturnVaue = "@RV";


        public static bool GetAllUsersTasksData(out DataTable tasksData, out string errorMessage, int projectId)
        {
            errorMessage = string.Empty;
            tasksData = new DataTable();
            try
            {
                using (SqlConnection MyConnection = new SqlConnection(Utils.connectionString))
                {
                    MyConnection.Open();
                    SqlCommand cmd = MyDB.GetCmd_SP(MyConnection, procedureAllUsersTasks, out errorMessage);

                    cmd.Parameters.AddWithValue(parameterEmail, Utils.CurrentUser.User_Email);
                    cmd.Parameters.AddWithValue(parameterProjectID, projectId);
                    cmd.ExecuteNonQuery();

                    SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                    adapter.Fill(tasksData);
                    
                    cmd.Dispose();
                    MyConnection.Close();
                  
                    if ((int)cmd.Parameters[parameterReturnVaue].Value != 1)
                    {
                        errorMessage = cmd.Parameters[parameterErrorMsg].Value.ToString();
                        return false;
                    }

                }

                if (tasksData.Rows.Count > 0)
                {
                    return true;
                }
                else {
                    errorMessage = "You don't have any tasks";
                    return false;
                }

                
            }
            catch (Exception ex)
            {
                errorMessage = "TasksOperations.GetAllUsersTasksData.Exception:" + ex.Message;
                return false;
            }
        } 
        
        public static bool GetAdminUserAllProjectsTasksData(out DataTable tasksData, out string errorMessage, int projectId)
        {
            errorMessage = string.Empty;
            tasksData = new DataTable();
            try
            {
                using (SqlConnection MyConnection = new SqlConnection(Utils.connectionString))
                {
                    MyConnection.Open();
                    SqlCommand cmd = MyDB.GetCmd_SP(MyConnection, procedureAdminAllProjectsTasks, out errorMessage);

                    cmd.Parameters.AddWithValue(parameterProjectID, projectId);
                    cmd.ExecuteNonQuery();

                    SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                    adapter.Fill(tasksData);
                                     
                    if ((int)cmd.Parameters[parameterReturnVaue].Value != 1)
                    {
                        errorMessage = cmd.Parameters[parameterErrorMsg].Value.ToString();
                        return false;
                    }
                    cmd.Dispose();
                    MyConnection.Close();
                }

                if (tasksData.Rows.Count > 0)
                {
                    return true;
                }
                else {
                    errorMessage = "You don't have any tasks";
                    return false;
                }

                
            }
            catch (Exception ex)
            {
                errorMessage = "TasksOperations.GetAllUsersTasksData.Exception:" + ex.Message;
                return false;
            }
        }

        public static bool InsertNewTask(TaskModel newTask, out string errorMessage)
        {
            errorMessage = string.Empty;
            try
            {
                using (SqlConnection MyConnection = new SqlConnection(Utils.connectionString))
                {
                    MyConnection.Open();
                    SqlCommand cmd = MyDB.GetCmd_SP(MyConnection, procedureTaskInsert, out errorMessage);

                    cmd.Parameters.AddWithValue(parameterTaskName, newTask.TaskName);
                    cmd.Parameters.AddWithValue(parameterTaskDes, newTask.TaskDes);
                    cmd.Parameters.AddWithValue(parameterAdminID, newTask.TaskAdminID);
                    cmd.Parameters.AddWithValue(parameterTaskProjectID, newTask.TaskProjectID);
                    cmd.Parameters.AddWithValue(parameterTaskStart, newTask.TaskStart);
                    cmd.Parameters.AddWithValue(parameterTaskEnd, newTask.TaskEnd);
                    cmd.Parameters.AddWithValue(parameterTaskDuration, newTask.TaskDuration);
                    cmd.Parameters.AddWithValue(parameterTaskState, newTask.TaskState);
                    cmd.ExecuteNonQuery();

                    if ((int)cmd.Parameters[parameterReturnVaue].Value != 1)
                    {
                        errorMessage = cmd.Parameters[parameterErrorMsg].Value.ToString();
                        return false;
                    }
                    cmd.Dispose();
                    MyConnection.Close();
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
