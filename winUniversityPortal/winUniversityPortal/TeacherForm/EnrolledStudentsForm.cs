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

namespace winUniversityPortal.TeacherForm
{
    public partial class EnrolledStudentsForm : MetroFramework.Forms.MetroForm
    {
        #region Main Method
        SqlConnection con = new SqlConnection(ConfigurationSettings.AppSettings["strConnect"]);
        DatabaseServices obj = new DatabaseServices();
        String QRY = string.Empty;
        public String Teacher_ID = string.Empty;
        public String Course_ID = string.Empty;
        string Semester = string.Empty;
        public EnrolledStudentsForm()
        {
            InitializeComponent();
        }
        #endregion

        #region Event Handler
        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void EnrolledStudentsForm_Load(object sender, EventArgs e)
        {
            loadSemester();
            loadStudetData();
        }
        #endregion

        #region Functions
        private void loadSemester()
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
        }
        private void loadStudetData()
        {
            QRY = "SELECT ID,Name,Email,Attendence,Grade FROM Course_Students WHERE Course_ID = '" + Course_ID +"' AND Semester = '"+ Semester +"'";
            try
            {
                gvShowStudents.DataSource = obj.tableData(QRY);
                gvShowStudents.Columns[0].Width = 20;
                gvShowStudents.Columns[0].Width = 100;
                gvShowStudents.Columns[3].Width = 20;
                gvShowStudents.Columns[3].Width = 70;
                gvShowStudents.Columns[4].Width = 20;
                gvShowStudents.Columns[4].Width = 70;
            }
            catch (Exception)
            { }
        }
        #endregion
    }
}
