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
    public partial class ChangePasswordForm : MetroFramework.Forms.MetroForm
    {
        #region Main Method
        SqlConnection con = new SqlConnection(ConfigurationSettings.AppSettings["strConnect"]);
        DatabaseServices obj = new DatabaseServices();
        String QRY = string.Empty;
        public String User_ID = string.Empty;
        public int table = 0;
        public ChangePasswordForm()
        {
            InitializeComponent();
        }
        #endregion

        #region Event Handler
        private void ChangePasswordForm_Load(object sender, EventArgs e)
        {
            loadRecord();
        }
        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void btnSave_Click(object sender, EventArgs e)
        {
            updatePassword();
        }
        #endregion

        #region Functions
        private void loadRecord()
        {
            if (table == 101)
            {
                QRY = "SELECT Student_ID FROM Student_Login_Table WHERE Student_ID = '"+ User_ID +"'";
            }
            else
            {
                QRY = "SELECT Teacher_ID FROM Teacher_Login_Table WHERE Teacher_ID = '"+ User_ID +"'";
            }
            try
            {
                SqlDataAdapter da = new SqlDataAdapter(QRY,con);
                DataSet ds = new DataSet();
                da.Fill(ds);
                txtUserID.Text = ds.Tables[0].Rows[0][0].ToString();
            }
            catch (Exception)
            { }
        }
        private void updatePassword()
        {
            if(txtNewPassword.Text == string.Empty || !(txtNewPassword.Text == txtConfirmPassword.Text))
            {
                MessageBox.Show("Password Did Not Match","Password",MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
            else
            {
                if(table == 101)
                {
                    QRY = "UPDATE Student_Login_Table SET Password = '"+ txtNewPassword.Text +"' WHERE Student_ID = '"+ User_ID +"'";
                }
                else
                {
                    QRY = "UPDATE Teacher_Login_Table SET Password = '" + txtNewPassword.Text + "' WHERE Teacher_ID = '" + User_ID + "'";
                }
                try
                {
                    obj.DMLOperations(QRY);
                    this.Close();
                }
                catch(Exception) { }
            }
        }
        #endregion
    }
}
