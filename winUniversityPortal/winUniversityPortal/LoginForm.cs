using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using winUniversityPortal.AdminForm;
using winUniversityPortal.StudentForm;

namespace winUniversityPortal
{
    public partial class LoginForm : MetroFramework.Forms.MetroForm
    {
        public LoginForm()
        {
            InitializeComponent();
        }

        #region Events Handler

        private void pbStudent_Click(object sender, EventArgs e)
        {
            portalLogin(101);
        }

        private void pbTeacher_Click(object sender, EventArgs e)
        {
            portalLogin(202);
        }

        private void pbAdmin_Click(object sender, EventArgs e)
        {
            portalLogin(303);
        }

        private void labStudent_Click(object sender, EventArgs e)
        {
            portalLogin(101);
        }

        private void labTeacher_Click(object sender, EventArgs e)
        {
            portalLogin(202);
        }

        private void labAdmin_Click(object sender, EventArgs e)
        {
            portalLogin(303);
        }
        #endregion

        #region Functions
        private void portalLogin(int tab)
        {
            this.Hide();
            PortalLoginForm plf = new PortalLoginForm();
            plf.table = tab;
            plf.Show();
        }
        #endregion
    }
}