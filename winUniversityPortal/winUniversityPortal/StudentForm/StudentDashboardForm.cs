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

namespace winUniversityPortal.StudentForm
{
    public partial class StudentDashboardForm : MetroFramework.Forms.MetroForm
    {
        public string Student_ID = string.Empty;
        public StudentDashboardForm()
        {
            InitializeComponent();
        }

        #region Event Handler
        private void btnCourses_Click(object sender, EventArgs e)
        {
            EnrolledCoursesForm ecf = new EnrolledCoursesForm();
            ecf.Student_ID = Student_ID;
            ecf.ShowDialog();
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            this.Hide();
            LoginForm log = new LoginForm();
            log.Show();
        }

        private void btnStudentDetail_Click(object sender, EventArgs e)
        {
            StudentDetailsForm sdf = new StudentDetailsForm();
            sdf.Student_ID = Student_ID;
            sdf.ShowDialog();
        }

        private void bhtNotics_Click(object sender, EventArgs e)
        {
            NoticesForm not = new NoticesForm();
            not.Notic_For = 101;
            not.ShowDialog();
        }

        private void btnAnnouncement_Click(object sender, EventArgs e)
        {
            AnnouncementForm ann = new AnnouncementForm();
            ann.Student_ID = Student_ID;
            ann.ShowDialog();
        }

        private void btnChangePassword_Click(object sender, EventArgs e)
        {
            ChangePasswordForm cpf = new ChangePasswordForm();
            cpf.User_ID = Student_ID;
            cpf.table = 101;
            cpf.ShowDialog();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        #endregion
    }
}
