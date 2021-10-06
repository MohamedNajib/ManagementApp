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

namespace ManagementApp
{
     partial class ProjectItem : UserControl
    {
        public ProjectItem()
        {
            InitializeComponent();
            addTaskPanel.Visible = false;
            calenderGroupBox.Visible = false;
            addNewTaskButton.Visible = true;
            if (Utils.CurrentUser.User_IS_Admin)
            {
                addTaskButton.Visible = true;
            }
            else {
                addTaskButton.Visible = false;
            }

           
        }

        #region Properties
        private String projectName;
        private String projectDes;
        private int projectID;
        private FlowLayoutPanel flowLayoutPanel;

        [Browsable(true)]
        [Category("Action")]
        [Description("Invoked when user clicks button")]
        public event EventHandler<TaskModelCompletedEventArgs> InsertTaskButtonClick;

        [Category("Custom Props")]
        public String ProjectName { get { return projectName; } set { projectName = value; projectNameLabel.Text = value; } }

        [Category("Custom Props")]
        public String ProjectDes { get { return projectDes; } set { projectDes = value; projectDesLabel.Text = value; } }
        
        [Category("Custom Props")]
        public int ProjectID { get { return projectID; } set { projectID = value; } }

        [Category("Custom Props")]
        public FlowLayoutPanel FlowLayout { 
           get { return flowLayoutPanel; } 
            set { flowLayoutPanel = value; gunaPanelContainer.Controls.AddRange(new Control[] { flowLayoutPanel });  } }

      

        #endregion

        private void onAddTaskButtonclicked(object sender, EventArgs e)
        {
            addTaskPanel.Visible = true;
        }

        private void onCloseAddTaskFormButtonClicked(object sender, EventArgs e)
        {
            addTaskPanel.Visible = false;
        }

        private DateTime fromDate;
        private DateTime toDate;
        private DateTime dateTime;
        private string date;
        private bool isFromDate;


        private void onMonthCalendarDateChanged(object sender, DateRangeEventArgs e)
        {
            dateTime = monthCalendar.SelectionStart;
            date = monthCalendar.SelectionStart.ToString("MM/dd/yyyy"); 
        }

        private void onDateButtonClicked(object sender, EventArgs e)
        {
            calenderGroupBox.Visible = true;
            addNewTaskButton.Visible = false;
            if (((GunaButton)sender).Name == fromDateButton.Name)
                isFromDate = true;
            else
                isFromDate = false;
        }

        private void onSelectDateButtonClicked(object sender, EventArgs e)
        {
            calenderGroupBox.Visible = false;
            addNewTaskButton.Visible = true;
            if (isFromDate)
            {
                fromDateTextBox.Text = date;
                fromDate = dateTime;
            }
            else
            {
                toDateTextBox.Text = date;
                toDate = dateTime;
            }
        }

        private void onAddNewTaskButtonClicked(object sender, EventArgs e)
        {
            TaskModel newTask = new TaskModel()
            {
                TaskName = taskNameTextBox.Text,
                TaskDes = taskDesTextBox.Text,
                TaskAdminID = (int)Utils.CurrentUser.User_ID,
                TaskProjectID = ProjectID,
                TaskStart = fromDate,
                TaskEnd = toDate,
                TaskDuration = (int)(toDate - fromDate).TotalDays,
                TaskState = "New"
            };
            if (this.InsertTaskButtonClick != null) {
                TaskModelCompletedEventArgs taskModelCompletedEventArgs = new TaskModelCompletedEventArgs();
                taskModelCompletedEventArgs.newObject = newTask;
                this.InsertTaskButtonClick(this, taskModelCompletedEventArgs);
                
            }
                
         
        }
    }
}
