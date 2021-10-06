using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ManagementApp.BLL
{
    class MainControlClass
    {

        public static void showControl(Control control, Control content) 
        {
            //control.Dock = DockStyle.Fill;
            content.Controls.Add(control);
        }
    }
}
