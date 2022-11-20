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
    public partial class ManageNoticeForm : MetroFramework.Forms.MetroForm
    {
        #region Main Method
        SqlConnection con = new SqlConnection(ConfigurationSettings.AppSettings["strConnect"]);
        DatabaseServices obj = new DatabaseServices();
        String QRY = string.Empty;
        String Notice_No = string.Empty;
        public ManageNoticeForm()
        {
            InitializeComponent();
        }
        #endregion

        #region Event Handler
        private void btnBack0_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void btnSaveNotice_Click(object sender, EventArgs e)
        {
            addNoticeRecord();
        }
        private void btnNewNotice_Click(object sender, EventArgs e)
        {
            clearFields();
        }
        private void btnBack1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (!(Notice_No == string.Empty))
            {
                deleteNoticRecord();
            }
        }
        private void gvNoticeDetails_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            loadNoticeID(e);
        }
        private void ManageNoticeForm_Load(object sender, EventArgs e)
        {
            loadNoticeData();
        }
        #endregion

        #region Functions
        private void clearFields()
        {
            txtNotice.Clear();
            cbNoticeFor.SelectedIndex = -1;
        }
        private void deleteNoticRecord()
        {
            QRY = "DELETE FROM Notices WHERE Notice_NO = '"+ Notice_No +"'";
            if (MessageBox.Show("Do You Want To Delete The Notice", "Delete Record", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                try
                {
                    obj.DMLOperations(QRY);
                    loadNoticeData();
                }
                catch (Exception) { }
            }
            Notice_No = string.Empty;
        }
        private void loadNoticeID(DataGridViewCellEventArgs e)
        {
            if(e.RowIndex >=0)
            {
                Notice_No = gvNoticeDetails.Rows[e.RowIndex].Cells[0].Value.ToString();
            }

        }
        private void addNoticeRecord()
        {
            if (txtNotice.Text == string.Empty || cbNoticeFor.Text == string.Empty)
            {
                MessageBox.Show("Please Enter All Details", "Notice Details", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                QRY = "EXEC dbo.add_notice '"+ txtNotice.Text +"','"+ cbNoticeFor.Text +"'";
                try
                {
                    obj.DMLOperations(QRY);
                    MessageBox.Show("Notice Published Successfully", "Notice", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    clearFields();
                    loadNoticeData();
                }
                catch (Exception)
                { }
            }
        }
        private void loadNoticeData()
        {
            QRY = "SELECT * FROM Notices";
            try
            {
                gvNoticeDetails.DataSource = obj.tableData(QRY);
                gvNoticeDetails.Columns[0].Width = 70;
                gvNoticeDetails.Columns[2].Width = 110;
            }
            catch (Exception)
            { }
        }
        #endregion
    }
}
