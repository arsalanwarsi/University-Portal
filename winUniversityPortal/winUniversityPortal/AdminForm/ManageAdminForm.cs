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
    public partial class ManageAdminForm : MetroFramework.Forms.MetroForm
    {
        #region Main Method
        SqlConnection con = new SqlConnection(ConfigurationSettings.AppSettings["strConnect"]);
        DatabaseServices obj = new DatabaseServices();
        String QRY = string.Empty;
        public String Admin_ID = string.Empty;
        public ManageAdminForm()
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
        private void btnNewRecord_Click(object sender, EventArgs e)
        {
            clearFields();
        }
        private void btnSave_Click(object sender, EventArgs e)
        {
            saveAdminRecord();
        }
        private void txtSaveDetails_Click(object sender, EventArgs e)
        {
            updateAdminRecord();
        }
        private void ManageAdminForm_Load(object sender, EventArgs e)
        {
            loadAdminData();
        }
        #endregion

        #region Functions
        private void loadAdminData()
        {
            QRY = "SELECT * FROM Admin WHERE Admin_ID = '" + Admin_ID + "'";
            try
            {
                SqlDataAdapter da = new SqlDataAdapter(QRY, con);
                DataSet ds = new DataSet();
                da.Fill(ds);

                txtID.Text = ds.Tables[0].Rows[0][0].ToString();
                txtName.Text = ds.Tables[0].Rows[0][1].ToString();
                txtGender.Text = ds.Tables[0].Rows[0][2].ToString();
                txtEmail.Text = ds.Tables[0].Rows[0][3].ToString();
                txtPhoneNo.Text = ds.Tables[0].Rows[0][4].ToString();
                txtPassowrd.Text = ds.Tables[0].Rows[0][5].ToString();
            }
            catch (Exception) { }
        }
        private void clearFields()
        {
            txtAdminID.Clear();
            txtAdminName.Clear();
            cbAdminGender.SelectedIndex = -1;
            txtAdminEmail.Clear();
            txtAdminPhoneNo.Clear();
            txtAdminPassword.Clear();
        }
        private void updateAdminRecord()
        {
            if (txtName.Text == string.Empty || txtEmail.Text == string.Empty || txtPhoneNo.Text == string.Empty || 
                txtPassowrd.Text == string.Empty)
            {
                MessageBox.Show("Please Enter All Details", "Admin Details", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                QRY = "EXEC dbo.update_admin '" + Admin_ID + "','" + txtName.Text + "','" + txtEmail.Text + "','" + txtPhoneNo.Text + "','" + txtPassowrd.Text + "'";
                try
                {
                    obj.DMLOperations(QRY);
                    MessageBox.Show("Record Updated Successfully", "Admin Details", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (Exception) { }
            }
        }
        private void saveAdminRecord()
        {
            if (txtAdminID.Text == string.Empty || txtAdminName.Text == string.Empty || cbAdminGender.Text == string.Empty || 
                txtAdminEmail.Text == string.Empty || txtAdminPhoneNo.Text == string.Empty || txtAdminPassword.Text == string.Empty)
            {
                MessageBox.Show("Please Enter All Details", "Admin Details", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                QRY = "EXEC dbo.add_admin '"+ txtAdminID.Text +"','"+ txtAdminName.Text +"','"+ cbAdminGender.Text +"'," +
                    "'"+ txtAdminEmail.Text +"','"+ txtAdminPhoneNo.Text +"','"+ txtAdminPassword.Text +"'";
                try
                {
                    DatabaseServices dd = new DatabaseServices();
                    dd.DMLOperations(QRY);
                    MessageBox.Show("Admin Record Save Successfully", "Admin", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    clearFields();
                }
                catch (Exception)
                {
                    MessageBox.Show("Admin ID already exists, Change the Admin ID", "Admin", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
        #endregion
    }
}
