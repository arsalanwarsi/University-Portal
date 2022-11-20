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
    public partial class CourseForm : MetroFramework.Forms.MetroForm
    {
        #region Main Method
        SqlConnection con = new SqlConnection(ConfigurationSettings.AppSettings["strConnect"]);
        DatabaseServices obj = new DatabaseServices();
        String QRY = string.Empty;
        public String Teacher_ID = string.Empty;
        public CourseForm()
        {
            InitializeComponent();
        }
        #endregion

        #region Event Handler
        private void CourseForm_Load(object sender, EventArgs e)
        {
            loadCourseData();
        }
        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void gvShowCourses_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if(e.RowIndex >=0)
            {
                loadCourseStudent(e);
            }
        }
        #endregion

        #region Functions
        private void loadCourseStudent(DataGridViewCellEventArgs e)
        {
            EnrolledStudentsForm esf = new EnrolledStudentsForm();
            esf.Course_ID = gvShowCourses.Rows[e.RowIndex].Cells[0].Value.ToString();
            esf.ShowDialog();
        }
        private void loadCourseData()
        {
            QRY = "SELECT ID,Course,Cr_Hour FROM Techer_Assigned_Course WHERE Teacher_ID = '"+ Teacher_ID +"'";
            try
            {
                gvShowCourses.DataSource = obj.tableData(QRY);
                gvShowCourses.Columns[0].Width = 10;
                gvShowCourses.Columns[0].Width = 70;
                gvShowCourses.Columns[2].Width = 20;
                gvShowCourses.Columns[2].Width = 100;
            }
            catch (Exception)
            { }
        }
        #endregion
    }
}
