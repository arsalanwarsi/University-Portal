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
    public partial class ManageTeacherForm : MetroFramework.Forms.MetroForm
    {
        #region Main Method
        SqlConnection con = new SqlConnection(ConfigurationSettings.AppSettings["strConnect"]);
        DatabaseServices obj = new DatabaseServices();
        String QRY = string.Empty;
        String Teacher_ID = string.Empty;

        public ManageTeacherForm()
        {
            InitializeComponent();
        }
        #endregion

        #region Event Handler
        private void btnBack0_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void btnSave_Click(object sender, EventArgs e)
        {
            saveTeacherRecord();
            loadTechersData();
        }
        private void btnNewRecord_Click(object sender, EventArgs e)
        {
            clearFields();
        }
        private void btnSeachTeacherID_Click(object sender, EventArgs e)
        {
            seacrhTeacherRecord();
        }
        private void btnBack1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void btnDeleteTeacher_Click(object sender, EventArgs e)
        {
            if (!(Teacher_ID == string.Empty))
            {
                deleteTeacherRecord();
            }
        }
        private void btnUpdateDetail_Click(object sender, EventArgs e)
        {
            if (!(Teacher_ID == string.Empty))
            {
                updateTeacherRecord();
            }
        }
        private void btnSeachRecord_Click(object sender, EventArgs e)
        {
            loadDepartmentTeacher();
        }
        private void bntBack2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void btnAllRecord_Click(object sender, EventArgs e)
        {
            txtSeachDepartment.Clear();
            loadTechersData();
        }
        private void ManageTeacherForm_Load(object sender, EventArgs e)
        {
            loadTeacherDepartments();
            loadTechersData();
        }
        private void gvTeacherDetails_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            loadTeachersDataID(e);
        }
        #endregion

        #region Functions
        private void saveTeacherRecord()
        {
            if (txtTeacherID.Text == string.Empty || txtTeacherName.Text == string.Empty ||
                cbTeacherGender.Text == string.Empty || txtTeacherEmail.Text == string.Empty ||
                txtPhoneNo.Text == string.Empty || cbTeacherDepartment.Text == string.Empty ||
                txtPassword.Text == string.Empty)
            {
                MessageBox.Show("Please Enter All Details", "Teacher Details", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                QRY = "EXEC dbo.add_teacher '" + txtTeacherID.Text + "','" + txtTeacherName.Text + "','" + cbTeacherGender.Text + "'," +
                    "'" + txtTeacherEmail.Text + "','" + txtPhoneNo.Text + "','" + txtPassword.Text + "','" + cbTeacherDepartment.Text + "'";
                try
                {
                    DatabaseServices dd = new DatabaseServices();
                    dd.DMLOperations(QRY);
                    MessageBox.Show("Teacher Record Save Successfully", "Teacher", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    clearFields();
                }
                catch (Exception)
                {
                    MessageBox.Show("Teacher ID already exists, Change the Teacher ID", "Teacher", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
        private void clearFields()
        {
            txtTeacherID.Clear();
            txtTeacherName.Clear();
            cbTeacherGender.SelectedIndex = -1;
            txtTeacherEmail.Clear();
            txtPhoneNo.Clear();
            cbTeacherDepartment.SelectedIndex = -1;
            txtPassword.Clear();
        }
        private void seacrhTeacherRecord()
        {
            QRY = "EXEC dbo.search_teacher '" + txtSearchTeacherID.Text + "'";
            try
            {
                gvTeacherDetails.DataSource = obj.tableData(QRY);
            }
            catch (Exception) { }
        }
        private void deleteTeacherRecord()
        {
            QRY = "DELETE FROM Teachers WHERE Teacher_ID = '" + Teacher_ID + "'";
            if (MessageBox.Show("Do You Want To Delete The Teacher Record", "Delete Record", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                try
                {
                    obj.DMLOperations(QRY);
                    loadTechersData();
                }
                catch (Exception)
                {
                    MessageBox.Show("Please Remove Assign Course First", "Delete Record", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            Teacher_ID = string.Empty;
        }
        private void updateTeacherRecord()
        {
            UpdateTeacherDetailsForm utr = new UpdateTeacherDetailsForm();
            utr.Teacher_ID = Teacher_ID;
            utr.ShowDialog();
            Teacher_ID = string.Empty;
            loadTechersData();
        }
        private void loadDepartmentTeacher()
        {
            QRY = "EXEC dbo.dept_teacher '" + txtSeachDepartment.Text + "'";
            try
            {
                gvRecordDepartment.DataSource = obj.tableData(QRY);
            }
            catch (Exception)
            { }
        }
        private void loadTeacherDepartments()
        {
            QRY = "SELECT Dept_No FROM Departments";
            SqlDataAdapter da = new SqlDataAdapter(QRY, con);
            DataSet ds = new DataSet();
            da.Fill(ds);

            for (int i = 0; i < (ds.Tables[0].Rows.Count); i++)
            {
                cbTeacherDepartment.Items.Add(ds.Tables[0].Rows[i]["Dept_No"].ToString());
            }
        }
        private void loadTechersData()
        {
            QRY = "SELECT * FROM Teacher_Table";
            try
            {
                gvTeacherDetails.DataSource = obj.tableData(QRY);
                gvRecordDepartment.DataSource = obj.tableData(QRY);
            }
            catch (Exception)
            { }
        }
        private void loadTeachersDataID(DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                Teacher_ID = gvTeacherDetails.Rows[e.RowIndex].Cells[0].Value.ToString();
            }
        }
        #endregion
    }
}
