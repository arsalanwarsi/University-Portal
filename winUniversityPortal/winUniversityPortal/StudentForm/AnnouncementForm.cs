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
    public partial class AnnouncementForm : MetroFramework.Forms.MetroForm
    {
        #region Main Method
        SqlConnection con = new SqlConnection(ConfigurationSettings.AppSettings["strConnect"]);
        DatabaseServices obj = new DatabaseServices();
        String QRY = string.Empty;
        public string Student_ID = string.Empty;
        public AnnouncementForm()
        {
            InitializeComponent();
        }
        #endregion

        #region Event Handler
        private void AnnouncementForm_Load(object sender, EventArgs e)
        {
            loadAnnouncementData();
        }
        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        #endregion

        #region Functions
        private void loadAnnouncementData()
        {
            QRY = "SELECT Course,Announcement FROM Student_Announcement WHERE Student_ID = '" + Student_ID +"'";
            try
            {
                gvShowAnnouncement.DataSource = obj.tableData(QRY);
                gvShowAnnouncement.Columns[0].Width = 70;
            }
            catch (Exception)
            { }
        }
        #endregion
    }
}
