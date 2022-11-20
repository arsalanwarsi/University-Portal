using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Configuration;
using winUniversityPortal.AdminForm;
using winUniversityPortal.StudentForm;
using winUniversityPortal.TeacherForm;

namespace winUniversityPortal
{
    public partial class PortalLoginForm : MetroFramework.Forms.MetroForm
    {
        #region Main Method
        SqlConnection con = new SqlConnection(ConfigurationSettings.AppSettings["strConnect"]);
        public int table = 0;
        String QRY = string.Empty;

        public PortalLoginForm()
        {
            InitializeComponent();
        }
        #endregion

        #region Events Handler
        private void btnLogin_Click(object sender, EventArgs e)
        {
            loginVerification();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Hide();
            LoginForm log = new LoginForm();
            log.Show();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        #endregion

        #region Functions
        private void loginVerification()
        {
            if (table == 101)
            {
                QRY = "EXEC dbo.student_login '" + txtUserID.Text + "','" + txtPassword.Text + "'";
                SqlDataAdapter da = new SqlDataAdapter(QRY, con);
                DataSet ds = new DataSet();
                da.Fill(ds);

                if (ds.Tables[0].Rows.Count > 0)
                {
                    this.Hide();
                    StudentDashboardForm sdf = new StudentDashboardForm();
                    sdf.Student_ID = txtUserID.Text;
                    sdf.Show();
                }
                else
                {
                    MessageBox.Show("Invalid User ID or Password ", "Login Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else if (table == 202)
            {
                QRY = "EXEC dbo.teacher_login '" + txtUserID.Text + "','" + txtPassword.Text + "'";
                SqlDataAdapter da = new SqlDataAdapter(QRY, con);
                DataSet ds = new DataSet();
                da.Fill(ds);

                if (ds.Tables[0].Rows.Count > 0)
                {
                    this.Hide();
                    TeacherDashboardForm tdf = new TeacherDashboardForm();
                    tdf.Teacher_ID = txtUserID.Text;
                    tdf.Show();
                }
                else
                {
                    MessageBox.Show("Invalid User ID or Password ", "Login Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else if (table == 303)
            {
                QRY = "dbo.admin_login '" + txtUserID.Text + "','" + txtPassword.Text + "'";
                SqlDataAdapter da = new SqlDataAdapter(QRY, con);
                DataSet ds = new DataSet();
                da.Fill(ds);

                if (ds.Tables[0].Rows.Count > 0)
                {
                    this.Hide();
                    AdminDashboardForm sdf = new AdminDashboardForm();
                    sdf.Admin_ID = txtUserID.Text;
                    sdf.Show();
                }
                else
                {
                    MessageBox.Show("Invalid User ID or Password ", "Login Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
        #endregion
    }
}
