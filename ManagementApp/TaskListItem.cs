using Guna.UI.WinForms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ManagementApp
{
    public partial class TaskListItem : UserControl
    {
        public TaskListItem()
        {
            InitializeComponent();
        }


        #region Properties
        private int ID;
        private String taskName;
        private String taskDes;
        private String taskState;


        [Browsable(true)]
        [Category("Action")]
        [Description("Invoked when user clicks button")]
        public event EventHandler<int> ItemClick;

        [Category("Custom Props")]
        public int TaskID { get { return ID; } set { ID = value;} }
        
        [Category("Custom Props")]
        public String TaskName { get { return taskName; } set { taskName = value; taskLabelTitle.Text = value; } }

        [Category("Custom Props")]
        public String TaskDes { get { return taskDes; } set { taskDes = value; taskLabelDes.Text = value; } }

        [Category("Custom Props")]
        public String TaskState { get { return taskState; } set { taskState = value; taskBtnState.Text = value; } }
        
      

        #endregion

        protected void onItemClicked(object sender, EventArgs e)
        {
            //bubble the event up to the parent
            if (this.ItemClick != null)
                this.ItemClick(this, TaskID);

        }
    }
}
