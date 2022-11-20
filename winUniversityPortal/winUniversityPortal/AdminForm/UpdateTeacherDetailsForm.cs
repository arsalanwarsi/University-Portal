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
    public partial class UpdateTeacherDetailsForm : MetroFramework.Forms.MetroForm
    {
        #region Main Method
        SqlConnection con = new SqlConnection(ConfigurationSettings.AppSettings["strConnect"]);
        DatabaseServices obj = new DatabaseServices();
        String QRY = string.Empty;
        public String Teacher_ID = string.Empty;

        public UpdateTeacherDetailsForm()
        {
            InitializeComponent();
        }
        #endregion

        #region Event Handler
        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void btnSave_Click(object sender, EventArgs e)
        {
            updateTeacherRecord();
        }
        private void UpdateTeacherDetailsForm_Load(object sender, EventArgs e)
        {
            loadTeacherDepartments();
            loadTeacherDeatils();
        }
        #endregion

        #region Functions
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
        private void updateTeacherRecord()
        {
            if (txtTeacherName.Text == string.Empty || txtTeacherEmail.Text == string.Empty || txtPhoneNo.Text == string.Empty ||
                cbTeacherDepartment.Text == string.Empty || txtPassword.Text == string.Empty)
            {
                MessageBox.Show("Please Enter All Details", "Teacher Details", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                QRY = "EXEC dbo.update_teacher '" + Teacher_ID + "','" + txtTeacherName.Text + "','" + txtTeacherEmail.Text + "'," +
                    "'" + txtPhoneNo.Text + "','" + txtPassword.Text + "','" + cbTeacherDepartment.Text + "'";
                try
                {
                    obj.DMLOperations(QRY);
                    this.Close();
                }
                catch (Exception) { }
            }
        }
        private void loadTeacherDeatils()
        {
            if (Teacher_ID == string.Empty)
            { }
            else
            {
                QRY = "SELECT * FROM Teachers WHERE Teacher_ID = '" + Teacher_ID + "'";
                try
                {
                    SqlDataAdapter da = new SqlDataAdapter(QRY, con);
                    DataSet ds = new DataSet();
                    da.Fill(ds);

                    txtTeacherID.Text = ds.Tables[0].Rows[0][0].ToString();
                    txtTeacherName.Text = ds.Tables[0].Rows[0][1].ToString();
                    txtTeacherGender.Text = ds.Tables[0].Rows[0][2].ToString();
                    txtTeacherEmail.Text = ds.Tables[0].Rows[0][3].ToString();
                    txtPhoneNo.Text = ds.Tables[0].Rows[0][4].ToString();
                    txtPassword.Text = ds.Tables[0].Rows[0][5].ToString();
                    cbTeacherDepartment.Text = ds.Tables[0].Rows[0][6].ToString();
                }
                catch (Exception) { }
            }
        }
        #endregion
    }
}
