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
    public partial class ManageCourseForm : MetroFramework.Forms.MetroForm
    {
        #region Main Method
        SqlConnection con = new SqlConnection(ConfigurationSettings.AppSettings["strConnect"]);
        DatabaseServices obj = new DatabaseServices();
        String QRY = string.Empty;
        String Course_ID = string.Empty;
        public ManageCourseForm()
        {
            InitializeComponent();
        }
        #endregion

        #region Event Handler
        private void btnBack0_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void btnBack1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void btnBack2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void btnNewRecord_Click(object sender, EventArgs e)
        {
            clearFields();
        }
        private void ManageCourseForm_Load(object sender, EventArgs e)
        {
            loadPrerequisite();
            loadTeacherID();
            loadCourseData();
        }
        private void btnUpdateCourse_Click(object sender, EventArgs e)
        {
            if (!(Course_ID == string.Empty))
            {
                updateCourseRecord();
            }
        }
        private void btnSave_Click(object sender, EventArgs e)
        {
            addCourseRecord();
            loadCourseData();
        }
        private void btnDeleteCourse_Click(object sender, EventArgs e)
        {
            if (!(Course_ID == string.Empty))
            {
                deleteCourseRecord();
            }
        }
        private void btnSeachCourseID_Click(object sender, EventArgs e)
        {
            loadCourseRecord1();
        }
        private void btnAllRecord_Click(object sender, EventArgs e)
        {
            txtCourseRecord.Clear();
            loadCourseData();
        }
        private void btnCourseRecord_Click(object sender, EventArgs e)
        {
            loadCourseRecord();
        }
        private void gvCourseDetails_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            loadCourseID(e);
        }
        #endregion

        #region Functions
        private void addCourseRecord()
        {
            if (txtCourseID.Text == string.Empty || txtCourseName.Text == string.Empty || cbCreditHours.Text == string.Empty || 
                cbPrerequisite.Text == string.Empty || cbTeacherID.Text == string.Empty)
            {
                MessageBox.Show("Please Enter All Details", "Course Details", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                QRY = "EXEC dbo.add_course '"+ txtCourseID.Text +"','"+ txtCourseName.Text +"','"+ cbCreditHours.Text +"','"+ cbPrerequisite.Text +"','"+ cbTeacherID.Text +"'";
                try
                {
                    DatabaseServices dd = new DatabaseServices();
                    dd.DMLOperations(QRY);
                    MessageBox.Show("Course Record Save Successfully", "Course", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    clearFields();
                }
                catch (Exception)
                {
                    MessageBox.Show("Techer Course Limit Completed", "Course Assign", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            cbPrerequisite.Items.Clear();
            loadPrerequisite();
        }

        private void loadTeacherID()
        {
            QRY = "SELECT Teacher_ID FROM Teachers";
            SqlDataAdapter da = new SqlDataAdapter(QRY, con);
            DataSet ds = new DataSet();
            da.Fill(ds);

            for (int i = 0; i < (ds.Tables[0].Rows.Count); i++)
            {
                cbTeacherID.Items.Add(ds.Tables[0].Rows[i]["Teacher_ID"].ToString());
            }
        }
        private void loadPrerequisite()
        {
            QRY = "SELECT Course_ID FROM Courses";
            SqlDataAdapter da = new SqlDataAdapter(QRY, con);
            DataSet ds = new DataSet();
            da.Fill(ds);

            for (int i = 0; i < (ds.Tables[0].Rows.Count); i++)
            {
                cbPrerequisite.Items.Add(ds.Tables[0].Rows[i]["Course_ID"].ToString());
            }
        }
        private void loadCourseData()
        {
            QRY = "SELECT * FROM Course_Table";
            try
            {
                gvCourseDetails.DataSource = obj.tableData(QRY);
                gvRecordCourse.DataSource = obj.tableData(QRY);
            }
            catch (Exception)
            { }
        }
        private void clearFields()
        {
            txtCourseID.Clear();
            txtCourseName.Clear();
            cbCreditHours.SelectedIndex = -1;
            cbPrerequisite.SelectedIndex = -1;
            cbTeacherID.SelectedIndex = -1;
        }
        private void loadCourseRecord()
        {
            QRY = "EXEC dbo.search_course '" + txtCourseRecord.Text + "'";
            try
            {
                gvRecordCourse.DataSource = obj.tableData(QRY);
            }
            catch (Exception)
            { }
        }


        private void loadCourseRecord1()
        {
            QRY = "EXEC dbo.search_course '" + txtSearchCourseID.Text + "'";
            try
            {
                gvCourseDetails.DataSource = obj.tableData(QRY);
            }
            catch (Exception)
            { }
        }
        private void loadCourseID(DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                Course_ID = gvCourseDetails.Rows[e.RowIndex].Cells[0].Value.ToString();
            }
        }
        private void deleteCourseRecord()
        {
            QRY = "DELETE FROM Courses WHERE Course_ID = '" + Course_ID + "'";
            if (MessageBox.Show("Do You Want To Delete The Course Record", "Delete Record", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                try
                {
                    DatabaseServices dt = new DatabaseServices();
                    dt.DMLOperations(QRY);
                    loadCourseData();
                    cbPrerequisite.Items.Clear();
                    loadPrerequisite();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("First Remove This Course From Prerequisite", "Delete Record", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            Course_ID = string.Empty;
        }
        private void updateCourseRecord()
        {
            UpdateCourseDetailsForm ucr = new UpdateCourseDetailsForm();
            ucr.Course_ID = Course_ID;
            ucr.ShowDialog();
            Course_ID = string.Empty;
            loadCourseData();
        }
        #endregion
    }
}
