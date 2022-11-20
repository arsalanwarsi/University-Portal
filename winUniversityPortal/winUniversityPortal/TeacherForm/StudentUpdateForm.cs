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
    public partial class StudentUpdateForm : MetroFramework.Forms.MetroForm
    {
        #region
        SqlConnection con = new SqlConnection(ConfigurationSettings.AppSettings["strConnect"]);
        DatabaseServices obj = new DatabaseServices();
        String QRY = string.Empty;
        public String Student_ID = string.Empty;
        public String Course_ID = string.Empty;
        public string Semester = string.Empty;
        public StudentUpdateForm()
        {
            InitializeComponent();
        }
        #endregion

        #region Event Handler
        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if(isValid())
            {
                updateStudentRecord();
            }
        }
        private void StudentUpdateForm_Load(object sender, EventArgs e)
        {
            loadStudentData();
        }
        private void txtAttendance_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }

            if ((e.KeyChar == '.'))
            {
                e.Handled = true;
            }
        }

        #endregion

        #region Functions
        private void loadStudentData()
        {
            QRY = "SELECT ID,Name,Attendence,Grade FROM Course_Students WHERE ID = '"+ Student_ID +"' AND Course_ID = '"+ Course_ID +"' AND Semester = '"+ Semester +"'";
            try
            {
                SqlDataAdapter da = new SqlDataAdapter(QRY, con);
                DataSet ds = new DataSet();
                da.Fill(ds);

                txtStudentID.Text = ds.Tables[0].Rows[0][0].ToString();
                txtStudentName.Text = ds.Tables[0].Rows[0][1].ToString();
                txtAttendance.Text = ds.Tables[0].Rows[0][2].ToString();
                cbStudentGrade.Text = ds.Tables[0].Rows[0][3].ToString();
            }
            catch(Exception) { }
        }
        private bool isValid()
        {
            if(cbStudentGrade.Text == string.Empty || txtAttendance.Text == string.Empty)
            {
                MessageBox.Show("Please Enter All Details", "Student Details", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            else
            {
                int attend = Convert.ToInt32(txtAttendance.Text);

                if(attend >= 0 && attend <= 100)
                {
                    return true;
                }
                else
                {
                    MessageBox.Show("Invalid Attendance Entered", "Student Details", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return false;
                }
            }
        }
        private void updateStudentRecord()
        {
            QRY = "UPDATE Course_Students SET Attendence = '"+ txtAttendance.Text +"',Grade = '"+ cbStudentGrade.Text +"' WHERE ID = '"+ Student_ID +"' AND Course_ID = '"+ Course_ID +"' AND Semester = '"+ Semester +"'";
            try
            {
                obj.DMLOperations(QRY);
                this.Close();
            }
            catch (Exception)
            { }
        }
        #endregion
    }
}
