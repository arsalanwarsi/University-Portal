using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace winUniversityPortal.AdminForm
{
    public partial class AdminDashboardForm : MetroFramework.Forms.MetroForm
    {
        public string Admin_ID = string.Empty;
        public AdminDashboardForm()
        {
            InitializeComponent();
        }

        #region Event Handler
        private void btnStudentManage_Click(object sender, EventArgs e)
        {
            ManageStudentForm msf = new ManageStudentForm();
            msf.Show();
        }
        private void btnTeacherManage_Click(object sender, EventArgs e)
        {
            ManageTeacherForm mtf = new ManageTeacherForm();
            mtf.Show();
        }
        private void btnCourseManage_Click(object sender, EventArgs e)
        {
            ManageCourseForm mcf = new ManageCourseForm();
            mcf.Show();
        }
        private void bhtAdminManage_Click(object sender, EventArgs e)
        {
            ManageAdminForm maf = new ManageAdminForm();
            maf.Admin_ID = Admin_ID;
            maf.Show();
        }
        private void btnNoticeManage_Click(object sender, EventArgs e)
        {
            ManageNoticeForm mnf = new ManageNoticeForm();
            mnf.Show();
        }
        private void btnLogout_Click(object sender, EventArgs e)
        {
            this.Hide();
            LoginForm log = new LoginForm();
            log.Show();
        }
        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        private void btnRegistration_Click(object sender, EventArgs e)
        {
            StudentRegistrationForm srf = new StudentRegistrationForm();
            srf.Show();
        }
        #endregion
    }
}
