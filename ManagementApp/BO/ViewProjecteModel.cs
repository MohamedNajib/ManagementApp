using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ManagementApp.BO
{
    class ViewProjecteModel
    {
        public int? ID { set; get; }
        public String TaskName { set; get; }
        public String TaskDes { set; get; }
        public int TaskAdminID { set; get; }
        public int TaskProjectID { set; get; }
        public DateTime TaskStart { set; get; }
        public DateTime TaskEnd { set; get; }
        public int TaskDuration { set; get; }
        public String TaskState { set; get; }
        public String ProjectName { set; get; }
        public String ProjectDes { set; get; }
        public String Admin { set; get; }
    }
}
