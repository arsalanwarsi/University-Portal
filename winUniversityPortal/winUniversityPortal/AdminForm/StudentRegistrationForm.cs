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

namespace winUniversityPortal.AdminForm
{
    public partial class StudentRegistrationForm : MetroFramework.Forms.MetroForm
    {
        #region Main Method
        SqlConnection con = new SqlConnection(ConfigurationSettings.AppSettings["strConnect"]);
        DatabaseServices obj = new DatabaseServices();
        String QRY = string.Empty;
        String addCourse_ID = string.Empty;
        String delCourse_ID = string.Empty;
        bool save = false;

        public StudentRegistrationForm()
        {
            InitializeComponent();
        }
        #endregion

        #region Event Handler
        private void btnSaveReg_Click(object sender, EventArgs e)
        {
            save = false;
            clearFields();
        }
        private void btnBack_Click(object sender, EventArgs e)
        {
            saveRegistration();
        }
        private void gvRegCourses_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                delCourse_ID = gvRegCourses.Rows[e.RowIndex].Cells[0].Value.ToString();
            }
        }
        private void StudentRegistrationForm_Load(object sender, EventArgs e)
        {
            loadCourseData();
        }
        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (!(txtStudentID.Text == string.Empty) && !(addCourse_ID == string.Empty))
            {
                saveStudentCourse();
            }
        }
        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (!(txtStudentID.Text == string.Empty) && !(delCourse_ID == string.Empty))
            {
                deleteStudentCourse();
            }
        }
        private void gvCourses_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                addCourse_ID = gvCourses.Rows[e.RowIndex].Cells[0].Value.ToString();
            }
        }
        private void btnSelect_Click(object sender, EventArgs e)
        {
            if (save == false)
            {
                loadStudentRecord();
            }
            else
            {
                MessageBox.Show("Save Registration First","Registraion",MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
        }
        #endregion

        #region Functions
        private void loadStudentRecord()
        {
            txtStudentID.Clear();
            txtStudentName.Clear();
            txtSemester.Clear();
            
            QRY = "SELECT Student_ID,Name FROM Students WHERE Student_ID = '" + txtStudent.Text + "'";
            try
            {
                SqlDataAdapter da = new SqlDataAdapter(QRY, con);
                DataSet ds = new DataSet();
                da.Fill(ds);

                txtStudentID.Text = ds.Tables[0].Rows[0][0].ToString();
                txtStudentName.Text = ds.Tables[0].Rows[0][1].ToString();

                int sem = DateTime.Now.Month;

                if (sem >= 1 && sem <= 6)
                {
                    txtSemester.Text = "SPRING "+ DateTime.Now.Year;
                }
                else 
                {
                    txtSemester.Text = "FALL " + DateTime.Now.Year;
                }
                registerCourse();
            }
            catch (Exception) { }
        }
        private void saveRegistration()
        {
            if(save == false)
            {
                this.Close();
            }
            else
            {
                MessageBox.Show("Save Registration First", "Registraion", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void clearFields()
        {
            txtStudent.Clear();
            txtStudentID.Clear();
            txtStudentName.Clear();
            txtSemester.Clear();
            gvRegCourses.DataSource = null;
        }
        private void saveStudentCourse()
        {
            QRY = "EXEC dbo.enroll_student '"+ addCourse_ID +"','"+ txtStudentID.Text +"','"+ DateTime.Now.ToString("MM/dd/yyyy") +"'," +
                "'"+ txtSemester.Text +"'";
            try
            {
                DatabaseServices ds = new DatabaseServices();
                ds.DMLOperations(QRY);
                save = true;
                addCourse_ID = string.Empty;
                registerCourse();
            }
            catch (Exception)
            {
                MessageBox.Show("Can Not Add More Course, Limit Completed", "Course Registration",MessageBoxButtons.OK,MessageBoxIcon.Information);
            }
        }
        private void registerCourse()
        {
            QRY = "SELECT * FROM Register_Course WHERE Student_ID = '"+ txtStudentID.Text +"' AND Semester = '"+ txtSemester.Text +"'";
            try
            {
                gvRegCourses.DataSource = obj.tableData(QRY);
                gvRegCourses.Columns[0].Width = 70;
                gvRegCourses.Columns[2].Visible = false;
                gvRegCourses.Columns[3].Visible = false;
            }
            catch (Exception)
            { }
        }
        private void deleteStudentCourse()
        {
            QRY = "Delete FROM Enrolled WHERE Course_ID = '"+ delCourse_ID +"' AND Student_ID = '"+ txtStudentID.Text +"'";
            try
            {
                DatabaseServices ds = new DatabaseServices();
                ds.DMLOperations(QRY);
                save = true;
                delCourse_ID = string.Empty;
                registerCourse();
            }
            catch (Exception){ }
        }
        private void loadCourseData()
        {
            QRY = "SELECT * FROM Reg_Course";
            try
            {
                gvCourses.DataSource = obj.tableData(QRY);
                gvCourses.Columns[0].Width = 50;
                gvCourses.Columns[2].Width = 30;
                gvCourses.Columns[3].Width = 70;
            }
            catch (Exception)
            { }
        }
        #endregion
    }
}
