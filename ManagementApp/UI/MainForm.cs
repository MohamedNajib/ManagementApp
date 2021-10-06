using Guna.UI.WinForms;
using ManagementApp.BLL;
using ManagementApp.BO;
using ManagementApp.DAL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ManagementApp.UI
{
    public partial class MainForm : BaseForm
    {
        public MainForm()
        {
            InitializeComponent();

            titleLabel.Text = "Wilcom: " + Utils.CurrentUser.User_Name + "ID: " + Utils.CurrentUser.User_ID;
            tasksPanel.BringToFront();
            if (flowLayoutPanel2.Controls.Count >= 1)
            {
                return;
            }
            getAllUserTaskesFromAllProjects();
        }


       
        private void insertUser() 
        {
            string errorMessage;
            
            try
            {
                if (!IsValidInpot())
                {
                    return;
                }
                int jobRoleID = -1;
                int workTeamID = -1;
                string jobRole = this.jobRoleComboBox.GetItemText(this.jobRoleComboBox.SelectedItem);
                string workTeam = this.workTeamsComboBox.GetItemText(this.workTeamsComboBox.SelectedItem);

              

                for (int i = 0; i < workTeamList.Count; i++)
                {
                    if (workTeamList[i].TeamName == workTeam) 
                    {
                        workTeamID = (int)workTeamList[i].ID;
                    }
                }
                for (int i = 0; i < jopsList.Count; i++)
                {
                    if (jopsList[i].JobName == jobRole) 
                    {
                        jobRoleID = (int)jopsList[i].ID;  
                    }
                }

                if (jobRoleID != -1 && workTeamID != -1)
                {
                    UserModel NewUser = new UserModel()
                    {
                        User_ID = null,
                        User_Name = tb_UserName.Text,
                        User_Email = tb_Email.Text.Trim(),
                        User_Password = tb_Password.Text.Trim(),
                        User_Phone = tb_Phone.Text.Trim(),
                        User_IS_Admin = false,
                        JobID = jobRoleID,
                        TeamID = workTeamID
                    };
                    if (!UserDatabaseOperations.InsertUser(NewUser, out errorMessage))
                    {
                        MessageBox.Show(errorMessage);
                        return;
                    }
                    getAllUsers();
                    tb_UserName.Text = tb_Email.Text = tb_Password.Text = tb_rePassword.Text = tb_Phone.Text = string.Empty;
                    ShowMessageBox("Email Added Successfully..." + NewUser.User_ID);
                }
            }
            catch (Exception ex)
            {
                ShowMessageBox("LoadingForm.getUserFromDB.Exception:" + ex.Message);
            }
        }

        private bool IsValidInpot()
        {
            if (tb_Email.Text.Trim().Equals(string.Empty))
            {
                tb_Email.SelectAll();
                tb_Email.Focus();
                ShowMessageBox("Pleaase Enter Valid Email Address ....");
                return false;
            }
            if (tb_Password.Text.Trim().Equals(string.Empty))
            {
                tb_Password.SelectAll();
                tb_Password.Focus();
                ShowMessageBox("Pleaase Enter Valid Password ....");
                return false;
            }
            if (tb_UserName.Text.Trim().Equals(string.Empty))
            {
                tb_UserName.SelectAll();
                tb_UserName.Focus();
                ShowMessageBox("Pleaase Enter Valid Name ....");
                return false;
            }

            if (tb_Phone.Text.Trim().Equals(string.Empty))
            {
                tb_Phone.SelectAll();
                tb_Phone.Focus();
                ShowMessageBox("Pleaase Enter Valid Phone Numper ....");
                return false;
            }

            return true;
        }

        List<WorkTeamModel> workTeamList;

        private void getAllWoktTeams() 
        {
            DataTable woktTeamsData;
            string errorMessage;
            workTeamList = new List<WorkTeamModel>();
            try
            {
                if (!WorkTeamOperations.GetAllWoktTeamsData(out woktTeamsData, out errorMessage))
                {
                    ShowMessageBox(errorMessage);
                    return;
                }
                // Convert DataTable To List of Opject `workTeamList`.
                workTeamList = (from DataRow row in woktTeamsData.Rows
                            select new WorkTeamModel
                            {
                                ID = Convert.ToInt32(row["ID"]),
                                TeamName = row["TeamName"].ToString(),
                            }).ToList();

                for (int index = 0; index < workTeamList.Count; index++)
                {
                    workTeamsComboBox.Items.Add(workTeamList[index].TeamName);
                }

            }
            catch (Exception ex)
            {
                ShowMessageBox("MainForm.GetAllUsers.Exception:" + ex);
            }
        }
        List<JopModel> jopsList;
        private void getAllJops() 
        {
            DataTable JopsData;
            string errorMessage;
            jopsList = new List<JopModel>();
            try
            {
                if (!JopsOperations.GetAllJopsData(out JopsData, out errorMessage))
                {
                    ShowMessageBox(errorMessage);
                    return;
                }
                // Convert DataTable To List of Opject `jopsList`.
                jopsList = (from DataRow row in JopsData.Rows
                             select new JopModel
                             {
                                 ID = Convert.ToInt32(row["ID"]),
                                 JobName = row["JobName"].ToString(),
                                 jobDes = row["jobDes"].ToString(),
                             }).ToList();

                for (int index = 0; index < jopsList.Count; index++) 
                {
                    jobRoleComboBox.Items.Add(jopsList[index].JobName);
                }
              
            }
            catch (Exception ex)
            {
                ShowMessageBox("MainForm.GetAllUsers.Exception:" + ex);
            }
        }

        private void getAllUsers() 
        {
            userFlowLayoutPanel.Controls.Clear();
           DataTable userData;
            string errorMessage;
            List<UserModel> uesrsList = new List<UserModel>();
            try
            {
                if (!UserDatabaseOperations.GetAllUsersData(out userData, out errorMessage))
                {
                    ShowMessageBox(errorMessage);
                    return;
                }
                // Convert DataTable To List of Opject `projectsList`.
                uesrsList = (from DataRow row in userData.Rows
                                select new UserModel
                                {
                                    User_ID = Convert.ToInt32(row["User_ID"]),
                                    User_Email = row["User_Email"].ToString(),
                                    User_Password = row["User_Password"].ToString(),
                                    User_IS_Admin = (bool) row["User_IS_Admin"],
                                    User_Name = row["User_Name"].ToString(),
                                    User_Phone = row["User_Phone"].ToString(),
                                    JobID = Convert.ToInt32(row["JobID"]),
                                    TeamID = Convert.ToInt32(row["TeamID"]),
                                }).ToList();

                UserItem[] userItems = new UserItem[uesrsList.Count];
                for (int index = 0; index < uesrsList.Count; index++)
                {
                    userItems[index] = new UserItem();
                   
                    userItems[index].UserName = uesrsList[index].User_Name;
                    userItems[index].UserEmail = uesrsList[index].User_Email;
                    userItems[index].UserPhone = uesrsList[index].User_Phone;
                    userItems[index].UserIsAdmin = uesrsList[index].User_IS_Admin;
                    userItems[index].IsShowStaus = true;

                    userFlowLayoutPanel.Controls.Add(userItems[index]);
                }
            }
            catch (Exception ex)
            {
                ShowMessageBox("MainForm.GetAllUsers.Exception:" + ex);
            }
        }

        private void getAllUserTaskesFromAllProjects() 
        {
            flowLayoutPanel2.Controls.Clear();
            DataTable projectData;
            string proErrorMessage;
            List<ProjectModel> projectsList = new List<ProjectModel>();
            //projectsList.Clear();
            try
            {
                if (!ProjectOperation.GetAllProjects(out projectData, out proErrorMessage))
                {
                    ShowMessageBox(proErrorMessage);
                    return;
                }
                // Convert DataTable To List of Opject `projectsList`.
                projectsList = (from DataRow row in projectData.Rows
                             select new ProjectModel
                             {
                                 ID = Convert.ToInt32(row["ID"]),
                                 ProjectName = row["ProjectName"].ToString(),
                                 ProjectDes = row["ProjectDes"].ToString(), 
                             }).ToList();
                for (int index = 0; index < projectsList.Count; index++) 
                {
                    DataTable UsersData;
                    string errorMessage;
                    List<ViewProjecteModel> tasksList = new List<ViewProjecteModel>();

                    // Chick if the User Is Admin or not
                    if (Utils.CurrentUser.User_IS_Admin)
                    {
                        if (!TasksOperations.GetAdminUserAllProjectsTasksData(out UsersData, out errorMessage, projectsList[index].ID))
                        {
                            ShowMessageBox(errorMessage);
                            return;
                        }
                    }
                    else {
                        if (!TasksOperations.GetAllUsersTasksData(out UsersData, out errorMessage, projectsList[index].ID))
                        {
                            ShowMessageBox(errorMessage);
                            return;
                        }
                    }


                    
                    // Convert DataTable To List of Opject `tasksList`.
                        tasksList = (from DataRow row in UsersData.Rows
                                     select new ViewProjecteModel
                                     {
                                         ID = Convert.ToInt32(row["ID"]),
                                         TaskName = row["TaskName"].ToString(),
                                         TaskDes = row["TaskDes"].ToString(),
                                         TaskAdminID = Convert.ToInt32(row["TaskAdminID"]),
                                         TaskProjectID = Convert.ToInt32(row["TaskProjectID"]),
                                         TaskStart = (DateTime)row["TaskStart"],
                                         TaskEnd = (DateTime)row["TaskEnd"],
                                         TaskDuration = Convert.ToInt32(row["TaskDuration"]),
                                         TaskState = row["TaskState"].ToString(),
                                         ProjectName = row["ProjectName"].ToString(),
                                         ProjectDes = row["ProjectDes"].ToString(),
                                         Admin = row["Admin"].ToString(),
                                     }).ToList();
                    FlowLayoutPanel flow = new FlowLayoutPanel();
                    flow.BackColor = Color.FromArgb(24, 26, 35);
                    flow.AutoScroll = true;
                    flow.Dock = DockStyle.Fill;
                    //flow.Controls.Clear();

                    TaskListItem[] taskListItems = new TaskListItem[tasksList.Count];
                    for (int i = 0; i < taskListItems.Length; i++)
                    {
                        taskListItems[i] = new TaskListItem();
                        taskListItems[i].TaskID = (int) tasksList[i].ID;
                        taskListItems[i].TaskName = tasksList[i].TaskName;
                        taskListItems[i].TaskDes = tasksList[i].TaskDes;
                        taskListItems[i].TaskState = tasksList[i].TaskState;
                        taskListItems[i].ItemClick += new EventHandler<int>(onTaskListItemControlClicked);
                        flow.Controls.Add(taskListItems[i]);
                    }

                    ProjectItem[] projectItem = new ProjectItem[projectsList.Count];
                    projectItem[index] = new ProjectItem();
                    projectItem[index].FlowLayout = flow;
                    projectItem[index].ProjectName = tasksList[0].ProjectName;
                    projectItem[index].ProjectDes = tasksList[0].ProjectDes;
                    projectItem[index].ProjectID = tasksList[0].TaskProjectID;
                    projectItem[index].InsertTaskButtonClick += new EventHandler<TaskModelCompletedEventArgs>(onInsertTaskButtonClicked);
                    flowLayoutPanel2.Controls.Add(projectItem[index]);
                }
            }
            catch (Exception ex)
            {
                ShowMessageBox("MainForm.getAllUserTaskesFromAllProjects.Exception:" + ex);
            }

        }


        private void onInsertTaskButtonClicked(object sender, TaskModelCompletedEventArgs e) {
            //ShowMessageBox("TTTTTTTTTTTTT:  " + e.newObject.TaskName);
            try
            {
                String errorMessage;

                if (!TasksOperations.InsertNewTask(e.newObject, out errorMessage))
                {
                    MessageBox.Show(errorMessage);
                    return;
                }
                getAllUserTaskesFromAllProjects();
                MessageBox.Show("Task Added Successfully...");
            }
            catch (Exception ex)
            {
                MessageBox.Show("LoadingForm.getUserFromDB.Exception:" + ex.Message);
            }
        }

        protected void onTaskListItemControlClicked(object sender, int e)
        {
            // ShowMessageBox("Item Clicked: " + e.ToString());
            CustomDialogTaskItem dialogTaskItem = new CustomDialogTaskItem();
            dialogTaskItem.ShowDialog();
            
        }
       
        private void onNavItemClicked(object sender, EventArgs e)
        {
            if (((GunaAdvenceButton)sender).Name == navProjects.Name)
            {
                projectsPanel.BringToFront();
            }
            else if (((GunaAdvenceButton)sender).Name == navTasks.Name) {
                tasksPanel.BringToFront();
                if (flowLayoutPanel2.Controls.Count >= 1) {
                    return;
                }
                getAllUserTaskesFromAllProjects();
            }
            else if (((GunaAdvenceButton)sender).Name == navUsers.Name)
            {
                usersPanel.BringToFront();
                if (userFlowLayoutPanel.Controls.Count >= 2)
                {
                    return;
                }
                getAllUsers();
                getAllJops();
                getAllWoktTeams();
            }
            else if (((GunaAdvenceButton)sender).Name == navSettings.Name)
            {
                settingsPanel.BringToFront();
            }
        }

        private void onCloseButtonClicked(object sender, EventArgs e)
        {
            Application.Exit();
        }

        bool IsSystemClose = true;
        private void signOutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            IsSystemClose = false;
            this.Close();
            Utils.CurrentUser = null;
            SwitchForm(AppFormes.SIGN_IN_Form);
        }

        public Point downPoint = Point.Empty;
        private void AppFormBase_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
                downPoint = new Point(e.X, e.Y);
        }
        private void AppFormBase_MouseMove(object sender, MouseEventArgs e)
        {
            if (downPoint != Point.Empty)
                Location = new Point(Left + e.X - downPoint.X, Top + e.Y -downPoint.Y);
        }
        private void AppFormBase_MouseUp(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
                downPoint = Point.Empty;
        }

        private void onAddButtonClicked(object sender, EventArgs e)
        {
            insertUser();
        }
    }
}
