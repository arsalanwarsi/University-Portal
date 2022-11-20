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

namespace winUniversityPortal.StudentForm
{
    public partial class StudentDetailsForm : MetroFramework.Forms.MetroForm
    {
        #region Main Method
        SqlConnection con = new SqlConnection(ConfigurationSettings.AppSettings["strConnect"]);
        DatabaseServices obj = new DatabaseServices();
        String QRY = string.Empty;
        public String Student_ID = string.Empty;
        public StudentDetailsForm()
        {
            InitializeComponent();
        }
        #endregion

        #region Event Handler
        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void StudentDetailsForm_Load(object sender, EventArgs e)
        {
            loadStudentRecord();
        }
        #endregion

        #region Functions
        private void loadStudentRecord()
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
            }
            catch (Exception) { }
        }
        #endregion
    }
}
