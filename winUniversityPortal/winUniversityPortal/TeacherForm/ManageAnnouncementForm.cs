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
    public partial class ManageAnnouncementForm : MetroFramework.Forms.MetroForm
    {
        #region Main Method
        SqlConnection con = new SqlConnection(ConfigurationSettings.AppSettings["strConnect"]);
        DatabaseServices obj = new DatabaseServices();
        String QRY = string.Empty;
        public String Teacher_ID = string.Empty;
        String Ann_No = string.Empty;
        public ManageAnnouncementForm()
        {
            InitializeComponent();
        }
        #endregion

        #region Event Handler
        private void ManageAnnouncementForm_Load(object sender, EventArgs e)
        {
            loadCourseData();
            loadAccounceData();
        }
        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void btnSave_Click(object sender, EventArgs e)
        {
            addAnnounceRecord();
        }
        private void btnDeleteAnn_Click(object sender, EventArgs e)
        {
            if(!(Ann_No == string.Empty))
            {
                deleteAnnounceRecord();
            }
        }
        private void btnBack1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void gvAnnouncDetails_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if(e.RowIndex >= 0)
            {
                Ann_No = gvAnnouncDetails.Rows[e.RowIndex].Cells[0].Value.ToString();
            }
        }
        #endregion

        #region Functions
        private void loadCourseData()
        {
            QRY = "SELECT ID FROM Teacher_Course WHERE Teacher_ID = '"+ Teacher_ID +"'";
            SqlDataAdapter da = new SqlDataAdapter(QRY, con);
            DataSet ds = new DataSet();
            da.Fill(ds);

            for (int i = 0; i < (ds.Tables[0].Rows.Count); i++)
            {
                cbSelectCourse.Items.Add(ds.Tables[0].Rows[i]["ID"].ToString());
            }
        }
        private void loadAccounceData()
        {
            QRY = "SELECT ID,Announcement,Course FROM Teacher_Announce WHERE Teacher_ID  =  '" + Teacher_ID +"'";
            try
            {
                gvAnnouncDetails.DataSource = obj.tableData(QRY);
                gvAnnouncDetails.Columns[0].Width = 70;
                gvAnnouncDetails.Columns[0].Width = 100;
                gvAnnouncDetails.Columns[2].Width = 70;
                gvAnnouncDetails.Columns[2].Width = 120;
            }
            catch (Exception)
            { }
        }
        private void deleteAnnounceRecord()
        {
            QRY = "DELETE FROM Announcements WHERE Ann_No = '"+ Ann_No +"'";
            if (MessageBox.Show("Do You Want To Delete The Announcement", "Delete Record", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                try
                {
                    obj.DMLOperations(QRY);
                    loadAccounceData();
                }
                catch (Exception) { }
            }
            Ann_No = string.Empty;
        }
        private void addAnnounceRecord()
        {
            if (txtAnnouncement.Text == string.Empty || cbSelectCourse.Text == string.Empty)
            {
                MessageBox.Show("Please Enter All Details", "Announcement Details", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                QRY = "EXEC dbo.add_announcement '"+ txtAnnouncement.Text +"','"+ Teacher_ID +"','"+ cbSelectCourse.Text +"'";
                try
                {
                    obj.DMLOperations(QRY);
                    MessageBox.Show("Announcement Published Successfully", "Announcement", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    clearFields();
                    loadAccounceData();
                }
                catch (Exception)
                { }
            }
        }
        private void clearFields()
        {
            txtAnnouncement.Clear();
            cbSelectCourse.SelectedIndex = -1;
        }
        #endregion
    }
}
