using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ManagementApp.UI
{
    public partial class BaseForm : Form
    {
        public BaseForm()
        {
            //InitializeComponent();
        }

        public void ShowMessageBox(String message)
        {
            MessageBox.Show(message);
        }

        public void SwitchForm(AppFormes form)
        {
            Form myForm = null;
            switch (form)
            {
                case AppFormes.MAIN_FORM:
                    myForm = new MainForm();
                    break;

             /*   case AppFormes.SIGN_UP_Form:
                    myForm = new SignUpForm();
                    break;*/

                case AppFormes.SIGN_IN_Form:
                    myForm = new LoginForm();
                    break;
            }
            myForm.Show();

        }
    }
}
