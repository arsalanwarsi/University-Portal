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
    public partial class NoticesForm : MetroFramework.Forms.MetroForm
    {
        #region Main Method
        SqlConnection con = new SqlConnection(ConfigurationSettings.AppSettings["strConnect"]);
        DatabaseServices obj = new DatabaseServices();
        String QRY = string.Empty;
        public int Notic_For = 0;
        public NoticesForm()
        {
            InitializeComponent();
        }
        #endregion

        #region Event Handler
        private void NoticesForm_Load(object sender, EventArgs e)
        {
            loadNoticeData();
        }
        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        #endregion

        #region Functions
        private void loadNoticeData()
        {
            if (Notic_For == 101)
            {
                QRY = "SELECT Notice FROM Notice_Record WHERE Notice_For = 'students' OR Notice_For = 'both'";
            }
            else
            {
                QRY = "SELECT Notice FROM Notice_Record WHERE Notice_For = 'teachers' OR Notice_For ='both'";
            }
            try
            {
                gvShowNotices.DataSource = obj.tableData(QRY);
            }
            catch (Exception)
            { }
        }
        #endregion
    }
}
