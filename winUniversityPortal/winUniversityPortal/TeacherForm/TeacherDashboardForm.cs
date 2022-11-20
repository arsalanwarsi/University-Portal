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

namespace winUniversityPortal.TeacherForm
{
    public partial class TeacherDashboardForm : MetroFramework.Forms.MetroForm
    {
        public string Teacher_ID = string.Empty;
        public TeacherDashboardForm()
        {
            InitializeComponent();
        }

        #region Event Handler
        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        private void btnStudentDetail_Click(object sender, EventArgs e)
        {
            TeacherDetailsForm tdf = new TeacherDetailsForm();
            tdf.Teacher_ID = Teacher_ID;
            tdf.ShowDialog();
        }
        private void btnCourses_Click(object sender, EventArgs e)
        {
            CourseForm cof = new CourseForm();
            cof.Teacher_ID = Teacher_ID;
            cof.ShowDialog();
        }
        private void btnAnnouncement_Click(object sender, EventArgs e)
        {
            ManageAnnouncementForm maf = new ManageAnnouncementForm();
            maf.Teacher_ID = Teacher_ID;
            maf.Show();
        }
        private void bhtNotics_Click(object sender, EventArgs e)
        {
            NoticesForm not = new NoticesForm();
            not.Notic_For = 202;
            not.ShowDialog();
        }
        private void btnStudentDetails_Click(object sender, EventArgs e)
        {
            StudentsForm stf = new StudentsForm();
            stf.Teacher_ID = Teacher_ID;
            stf.ShowDialog();
        }
        private void btnChangePassword_Click(object sender, EventArgs e)
        {
            ChangePasswordForm cpf = new ChangePasswordForm();
            cpf.User_ID = Teacher_ID;
            cpf.table = 202;
            cpf.ShowDialog();
        }
        private void btnLogout_Click(object sender, EventArgs e)
        {
            this.Hide();
            LoginForm log = new LoginForm();
            log.Show();
        }
        #endregion
    }
}
