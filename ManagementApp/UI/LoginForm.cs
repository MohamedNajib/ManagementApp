using System;
using System.Collections.Generic;
using ManagementApp.UI;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ManagementApp.BLL;
using ManagementApp.DAL;
using Guna.UI.WinForms;
using System.Data.SqlClient;

namespace ManagementApp
{
    public partial class LoginForm : BaseForm
    {
        #region Variables Declaration
        string errorMessage;
        #endregion

        public LoginForm()
        {
            InitializeComponent();
        }


        private void getUserInfo() {
            /*using (var instance = DataAccess<SqlConnection>.Instance)
            {
                instance.ExecuteCommand<bool>((cmd) => {
                    cmd.CommandText = ".......";
                    return cmd.ExecuteNonQuery();
                });
            }*/
            try
            {
                if (!IsValidInpot())
                {
                    return;
                }
                Utils.CurrentUser = new BO.UserModel()
                {
                    User_Email = tb_Email.Text.Trim(),
                    User_Password = tb_Password.Text.Trim(),
                };
                if (!UserDatabaseOperations.getUserData(ref Utils.CurrentUser, out errorMessage))
                {
                    Utils.CurrentUser = null;
                    ShowMessageBox(errorMessage);
                    return;
                }
                this.Hide();
                tb_Email.Text = tb_Password.Text = string.Empty;
                SwitchForm(AppFormes.MAIN_FORM);
                //ShowMessageBox("User Found >>> User ID : " + Utils.CurrentUser.User_Name);
            }
            catch (Exception ex)
            {
                ShowMessageBox("LoadingForm.getUserFromDB.Exception:" + ex.Message);
                Utils.CurrentUser = null;
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
            return true;
        }

        // Evintes

        private void onSignInButtonClicked(object sender, EventArgs e)
        {
            getUserInfo();
        }

        private void keyPressEvent(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar.Equals((char)13) && !((GunaTextBox)sender).Text.Trim().Equals(string.Empty))
            {
                if (((GunaTextBox)sender).Name == tb_Email.Name)
                {
                    tb_Password.SelectAll();
                    tb_Password.Focus();
                }
                else if (((GunaTextBox)sender).Name == tb_Password.Name) 
                {
                    onSignInButtonClicked(btn_Login, null);
                }
            }
        }

        private void onCloseButtonClicked(object sender, EventArgs e)
        {
            Application.Exit();
        }

       
    }
}
