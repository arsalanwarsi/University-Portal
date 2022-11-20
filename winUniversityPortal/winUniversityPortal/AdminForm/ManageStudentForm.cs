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
using winUniversityPortal.Services;

namespace winUniversityPortal.AdminForm
{
    public partial class ManageStudentForm : MetroFramework.Forms.MetroForm
    {
        #region Main Method
        SqlConnection con = new SqlConnection(ConfigurationSettings.AppSettings["strConnect"]);
        DatabaseServices obj = new DatabaseServices();
        String QRY = string.Empty;
        String Student_ID = string.Empty;

        public ManageStudentForm()
        {
            InitializeComponent();
        }
        #endregion

        #region Event Handler
        private void btnUpdateDetail_Click(object sender, EventArgs e)
        {
            if (!(Student_ID == string.Empty))
            {
                updateStudentRecord();
            }
        }
        private void btnBack0_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void btnNewRecord_Click(object sender, EventArgs e)
        {
            clearFields();
        }
        private void btnSeachStudentID_Click(object sender, EventArgs e)
        {
            seacrhStudentRecord();
        }
        private void btnSave_Click(object sender, EventArgs e)
        {
            saveStudentRecord();
            loadStudentsData();
        }
        private void ManageStudentForm_Load(object sender, EventArgs e)
        {
            loadStudentsData();
        }
        private void bntBack2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void btnAllRecord_Click(object sender, EventArgs e)
        {
            txtSeachProgram.Clear();
            loadStudentsData();
        }
        private void btnSeachRecord_Click(object sender, EventArgs e)
        {
            loadProgramStudents();
        }
        private void btnBack1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void gvStudentDetails_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            loadStudentsDataID(e);
        }
        private void btnDeleteStudent_Click(object sender, EventArgs e)
        {
            if (!(Student_ID == string.Empty))
            {
                deleteStudentRecord();
            }

        }
        #endregion

        #region Functions
        private void clearFields()
        {
            txtStudentID.Clear();
            txtStudentName.Clear();
            cbStudentGender.SelectedIndex = -1;
            txtStudentEmail.Clear();
            txtPhoneNo.Clear();
            cbStudentProgram.SelectedIndex = -1;
            txtPassword.Clear();
        }
        private void updateStudentRecord()
        {
            UpdateStudentDetailsForm usr = new UpdateStudentDetailsForm();
            usr.Student_ID = Student_ID;
            usr.ShowDialog();
            Student_ID = string.Empty;
            loadStudentsData();
        }
        private void saveStudentRecord()
        {
            if (txtStudentID.Text == string.Empty || txtStudentName.Text == string.Empty ||
                cbStudentGender.Text == string.Empty || txtStudentEmail.Text == string.Empty ||
                txtPhoneNo.Text == string.Empty || cbStudentProgram.Text == string.Empty ||
                txtPassword.Text == string.Empty)
            {
                MessageBox.Show("Please Enter All Details", "Students Details", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                QRY = "EXEC dbo.add_student '" + txtStudentID.Text + "','" + txtStudentName.Text + "','" + cbStudentGender.Text + "'," +
                    "'" + txtStudentEmail.Text + "','" + txtPhoneNo.Text + "','" + cbStudentProgram.Text + "','" + txtPassword.Text + "'";
                try
                {
                    DatabaseServices dd = new DatabaseServices();
                    dd.DMLOperations(QRY);
                    MessageBox.Show("Student Record Save Successfully", "Student", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    clearFields();
                }
                catch (Exception)
                {
                    MessageBox.Show("Student ID already exists, Change the Student ID", "Student", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
        private void loadProgramStudents()
        {
            QRY = "EXEC dbo.program_students '"+txtSeachProgram.Text+"'";
            try
            {
                gvRecordProgram.DataSource = obj.tableData(QRY);
            }
            catch(Exception)
            { }
        }
        private void loadStudentsDataID(DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                Student_ID = gvStudentDetails.Rows[e.RowIndex].Cells[0].Value.ToString();
            }
        }
        private void deleteStudentRecord()
        {
            QRY = "DELETE FROM Students WHERE Student_ID = '"+Student_ID+"'";
            if (MessageBox.Show("Do You Want To Delete The Student Record", "Delete Record", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                try
                {
                    obj.DMLOperations(QRY);
                    loadStudentsData();
                }
                catch (Exception) { }
            }
            Student_ID = string.Empty;
        }
        private void seacrhStudentRecord()
        {
            QRY = "EXEC dbo.search_student '"+txtSearchStudentID.Text+"'";
            try
            {
                gvStudentDetails.DataSource = obj.tableData(QRY);
            }
            catch (Exception) { }
        }
        private void loadStudentsData()
        {
            QRY = "SELECT * FROM Students";
            try
            {
                gvStudentDetails.DataSource = obj.tableData(QRY);
                gvRecordProgram.DataSource = obj.tableData(QRY);
            }
            catch (Exception)
            { }
        }
        #endregion
    }
}