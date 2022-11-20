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
    public partial class StudentsForm : MetroFramework.Forms.MetroForm
    {
        #region Main Method
        SqlConnection con = new SqlConnection(ConfigurationSettings.AppSettings["strConnect"]);
        DatabaseServices obj = new DatabaseServices();
        String QRY = string.Empty;
        public String Teacher_ID = string.Empty;
        public String Course_ID = string.Empty;
        string Semester = string.Empty;
        String Student_ID = string.Empty;
        public StudentsForm()
        {
            InitializeComponent();
        }
        #endregion

        #region Event Handler
        private void StudentsForm_Load(object sender, EventArgs e)
        {
            loadCourseData();
        }
        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void gvStudents_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if(e.RowIndex >=0)
            {
                Course_ID = gvStudents.Rows[e.RowIndex].Cells[0].Value.ToString();
                Student_ID = gvStudents.Rows[e.RowIndex].Cells[1].Value.ToString();
            }
        }
        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if(!(Student_ID == string.Empty) && !(Course_ID == string.Empty))
            {
                updateStudentRecord();
            }
        }
        private void btnSelectCourse_Click(object sender, EventArgs e)
        {
            if (!(cbSelectCourse.Text == string.Empty))
            {
                loadSemester();
                loadStudentsData();
            }
        }
        #endregion

        #region Functions
        private void loadCourseData()
        {
            QRY = "SELECT ID FROM Teacher_Course WHERE Teacher_ID = '" + Teacher_ID + "'";
            SqlDataAdapter da = new SqlDataAdapter(QRY, con);
            DataSet ds = new DataSet();
            da.Fill(ds);

            for (int i = 0; i < (ds.Tables[0].Rows.Count); i++)
            {
                cbSelectCourse.Items.Add(ds.Tables[0].Rows[i]["ID"].ToString());
            }
        }
        private void loadStudentsData()
        {
            QRY = "SELECT Course_ID,ID,Name,Email,Attendence,Grade FROM Course_Students WHERE Course_ID = '"+ cbSelectCourse.Text +"' AND Semester = '"+ Semester +"'";
            try
            {
                gvStudents.DataSource = obj.tableData(QRY);
                gvStudents.Columns[0].Visible = false;
                gvStudents.Columns[4].Width = 70;
                gvStudents.Columns[5].Width = 70;
            }
            catch (Exception)
            { }
        }
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
        private void updateStudentRecord()
        {
            StudentUpdateForm suf = new StudentUpdateForm();
            suf.Student_ID = Student_ID;
            suf.Course_ID = Course_ID;
            suf.Semester = Semester;
            suf.ShowDialog();
            Student_ID = string.Empty;
            loadStudentsData();
        }
        #endregion
    }
}
