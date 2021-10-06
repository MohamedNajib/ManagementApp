using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ManagementApp.BO
{
    class UserModel
    {
        public int? User_ID { set; get; }
        public String User_Email { set; get; }
        public String User_Password { set; get; }
        public bool User_IS_Admin { set; get; }

        public String User_Name { set; get; }

        public String User_Phone { set; get; }

        public int JobID { set; get; }
        public int TeamID { set; get; }
    }
}
