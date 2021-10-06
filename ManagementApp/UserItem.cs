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
    public partial class UserItem : UserControl
    {
        public UserItem()
        {
            InitializeComponent();
        }

        #region Properties
        private String userName;
        private String userEmail;
        private String userPhone;
        private bool userIsAdmin;
        private bool isShowStaus;

        [Category("Custom Props")]
        public String UserName { get { return userName; } set { userName = value; userNameLabel.Text = value; } }

        [Category("Custom Props")]
        public String UserEmail { get { return userEmail; } set { userEmail = value; userEmailLabel.Text = value; } }

        [Category("Custom Props")]
        public String UserPhone { get { return userPhone; } set { userPhone = value; userPhoneLabel.Text = value; } }  
        
        [Category("Custom Props")]
        public bool UserIsAdmin { get { return userIsAdmin; } set { userIsAdmin = value; if (value) { gunaPanel1.BackColor = Color.FromArgb(255, 192, 128); } } }
        
        [Category("Custom Props")]
        public bool IsShowStaus { get { return isShowStaus; } set { isShowStaus = value; if (value) { gunaPanel1.Visible = true; } else { gunaPanel1.Visible = false; userNameLabel.Font = new Font("Arial", 11, FontStyle.Bold); userEmailLabel.Font = new Font("Arial", 11, FontStyle.Bold); userPhoneLabel.Font = new Font("Arial", 11, FontStyle.Bold); } } }

        #endregion
    }
}
