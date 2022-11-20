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
    public partial class TeacherDetailsForm : MetroFramework.Forms.MetroForm
    {
        #region Main Method
        SqlConnection con = new SqlConnection(ConfigurationSettings.AppSettings["strConnect"]);
        DatabaseServices obj = new DatabaseServices();
        String QRY = string.Empty;
        public String Teacher_ID = string.Empty;
        public TeacherDetailsForm()
        {
            InitializeComponent();
        }
        #endregion

        #region Event Handler
        private void TeacherDetailsForm_Load(object sender, EventArgs e)
        {
            loadTeacherRecord();
        }
        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        #endregion

        #region Functions
        private void loadTeacherRecord()
        {
            QRY = "SELECT * FROM Teacher_Table WHERE Teacher_ID = '" + Teacher_ID +"'";
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
                txtTeacherDepart.Text = ds.Tables[0].Rows[0][6].ToString();
            }
            catch (Exception) { }
        }
        #endregion
    }
}
