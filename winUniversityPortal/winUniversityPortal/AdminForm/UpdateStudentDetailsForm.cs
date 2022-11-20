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
    public partial class UpdateStudentDetailsForm : MetroFramework.Forms.MetroForm
    {
        #region Main Method
        SqlConnection con = new SqlConnection(ConfigurationSettings.AppSettings["strConnect"]);
        DatabaseServices obj = new DatabaseServices();
        String QRY = string.Empty;
        public String Student_ID = string.Empty;

        public UpdateStudentDetailsForm()
        {
            InitializeComponent();
        }
        #endregion

        #region Event Handler
        private void UpdateStudentDetailsForm_Load(object sender, EventArgs e)
        {
            loadStudentDeatils();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            updateStudentRecord();
        }
        #endregion

        #region Functions
        private void updateStudentRecord()
        {
            if (txtStudentName.Text == string.Empty || txtStudentEmail.Text == string.Empty || txtPhoneNo.Text == string.Empty ||
                txtPassword.Text == string.Empty)
            {
                MessageBox.Show("Please Enter All Details", "Students Details", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                QRY = "EXEC dbo.update_student '" + Student_ID + "','" + txtStudentName.Text + "','" + txtStudentEmail.Text + "'," +
                    "'" + txtPhoneNo.Text + "','" + txtPassword.Text + "'";
                try
                {
                    obj.DMLOperations(QRY);
                    this.Close();
                }
                catch (Exception) { }
            }
        }

        private void loadStudentDeatils()
        {
            if (Student_ID == string.Empty)
            { }
            else
            {
                QRY = "SELECT * FROM Students WHERE Student_ID = '" + Student_ID + "'";
                try
                {
                    SqlDataAdapter da = new SqlDataAdapter(QRY, con);
                    DataSet ds = new DataSet();
                    da.Fill(ds);

                    txtStudentID.Text = ds.Tables[0].Rows[0][0].ToString();
                    txtStudentName.Text = ds.Tables[0].Rows[0][1].ToString();
                    txtStudentGender.Text = ds.Tables[0].Rows[0][2].ToString();
                    txtStudentEmail.Text = ds.Tables[0].Rows[0][3].ToString();
                    txtPhoneNo.Text = ds.Tables[0].Rows[0][4].ToString();
                    txtStudentProgram.Text = ds.Tables[0].Rows[0][5].ToString();
                    txtPassword.Text = ds.Tables[0].Rows[0][6].ToString();
                }
                catch (Exception) { }
            }
        }
        #endregion
    }
}
