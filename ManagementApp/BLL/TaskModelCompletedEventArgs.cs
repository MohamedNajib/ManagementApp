using ManagementApp.BO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ManagementApp.BLL
{
     class TaskModelCompletedEventArgs : EventArgs
    {

        private TaskModel newTaskObject;

        public TaskModel newwObject() {
            return newTaskObject;
        }

        public TaskModel newObject { get { return newTaskObject; } set { newTaskObject = value; } }
    }
}
