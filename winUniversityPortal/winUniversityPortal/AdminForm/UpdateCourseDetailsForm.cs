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
    public partial class UpdateCourseDetailsForm : MetroFramework.Forms.MetroForm
    {
        #region Main Method
        SqlConnection con = new SqlConnection(ConfigurationSettings.AppSettings["strConnect"]);
        DatabaseServices obj = new DatabaseServices();
        String QRY = string.Empty;
        public String Course_ID = string.Empty;
        public UpdateCourseDetailsForm()
        {
            InitializeComponent();
        }
        #endregion

        #region Event Handler
        private void UpdateCourseDetailsForm_Load(object sender, EventArgs e)
        {
            loadPrerequisite();
            loadTeacherID();
            loadCourseDeatils();
        }
        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void btnSave_Click(object sender, EventArgs e)
        {
            updateCourseRecord();
        }
        #endregion

        #region Functions
        private void updateCourseRecord()
        {
            if (cbPrerequisite.Text == string.Empty || cbCreditHours.Text == string.Empty || cbTeacherID.Text == string.Empty ||
                txtCourseName.Text == string.Empty)
            {
                MessageBox.Show("Please Enter All Details", "Course Details", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                QRY = "EXEC dbo.update_course '"+ Course_ID +"','"+ txtCourseName.Text +"','"+ cbCreditHours.Text +"'," +
                    "'"+ cbPrerequisite.Text +"','"+ cbTeacherID.Text +"'";
                try
                {
                    DatabaseServices dd = new DatabaseServices();
                    dd.DMLOperations(QRY);
                    this.Close();
                }
                catch (Exception)
                {
                    MessageBox.Show("Techer Course Limit Completed", "Course Assign", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }
        private void loadCourseDeatils()
        {
            if (Course_ID == string.Empty)
            { }
            else
            {
                QRY = "SELECT * FROM Courses WHERE Course_ID = '" + Course_ID + "'";
                try
                {
                    SqlDataAdapter da = new SqlDataAdapter(QRY, con);
                    DataSet ds = new DataSet();
                    da.Fill(ds);

                    txtCourseID.Text = ds.Tables[0].Rows[0][0].ToString();
                    txtCourseName.Text = ds.Tables[0].Rows[0][1].ToString();
                    cbCreditHours.Text = (Convert.ToInt32(ds.Tables[0].Rows[0][2])).ToString();
                    cbPrerequisite.Text = ds.Tables[0].Rows[0][3].ToString();
                    cbTeacherID.Text = ds.Tables[0].Rows[0][4].ToString();
                }
                catch (Exception) { }
            }
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
        #endregion
    }
}
