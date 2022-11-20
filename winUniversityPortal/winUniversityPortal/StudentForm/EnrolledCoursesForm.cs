using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using winUniversityPortal.Services;

namespace winUniversityPortal.StudentForm
{
    public partial class EnrolledCoursesForm : MetroFramework.Forms.MetroForm
    {
        #region Main Method
        SqlConnection con = new SqlConnection(ConfigurationSettings.AppSettings["strConnect"]);
        DatabaseServices obj = new DatabaseServices();
        String QRY = string.Empty;
        public String Student_ID = string.Empty;
        String Semester = string.Empty;
        public EnrolledCoursesForm()
        {
            InitializeComponent();
        }
        #endregion

        #region Event Handler
        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void btnSelectCourse_Click(object sender, EventArgs e)
        {
            showCourseDetail();
        }
        private void EnrolledCoursesForm_Load(object sender, EventArgs e)
        {
            loadCourseData();
        }
        #endregion

        #region Functions
        private void showCourseDetail()
        {
            QRY = "SELECT * FROM Course_Registered WHERE St_ID = '" + Student_ID + "' AND Semester = '" + Semester + "' AND ID = '"+ cbEnrolledCourse.Text +"'";
            try
            {
                SqlDataAdapter da = new SqlDataAdapter(QRY, con);
                DataSet ds = new DataSet();
                da.Fill(ds);

                txtCourseID.Text = ds.Tables[0].Rows[0]["ID"].ToString();
                txtCourseName.Text = ds.Tables[0].Rows[0]["Name"].ToString();
                txtTeacherName.Text = ds.Tables[0].Rows[0]["Teacher"].ToString();
                cpbAttandance.Value = Convert.ToInt32(ds.Tables[0].Rows[0]["Attendence"]);
                cpbAttandance.Text = cpbAttandance.Value.ToString();
                String grade = ds.Tables[0].Rows[0]["Grade"].ToString().ToUpper();
                if(grade == "A")
                {
                    cpbGrade.Value = 100;
                    cpbGrade.Text = grade;
                }
                else if (grade == "B")
                {
                    cpbGrade.Value = 81;
                    cpbGrade.Text = grade;
                }
                else if (grade == "C")
                {
                    cpbGrade.Value = 69;
                    cpbGrade.Text = grade;
                }
                else if (grade == "D")
                {
                    cpbGrade.Value = 57;
                    cpbGrade.Text = grade;
                }
                else if (grade == "F")
                {
                    cpbGrade.Value = 0;
                    cpbGrade.Text = grade;
                }
                else
                {
                    cpbGrade.Value = 20;
                    cpbGrade.Text = grade;
                }
            }
            catch (Exception) { }
        }
        private void loadCourseData()
        {
            int sem = DateTime.Now.Month;

            if (sem >= 1 && sem <= 6)
            {
                Semester = "SPRING " + DateTime.Now.Year;
            }
            else
            {
                Semester = "FALL " + DateTime.Now.Year;
            }

            QRY = "SELECT * FROM Course_Registered WHERE St_ID = '"+ Student_ID +"' AND Semester = '"+ Semester +"'";
            try
            {
                SqlDataAdapter da = new SqlDataAdapter(QRY, con);
                DataSet ds = new DataSet();
                da.Fill(ds);

                for (int i = 0; i < (ds.Tables[0].Rows.Count); i++)
                {
                    cbEnrolledCourse.Items.Add(ds.Tables[0].Rows[i]["ID"].ToString());
                }
            }
            catch(Exception) { }
        }
        #endregion
    }
}
