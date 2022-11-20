
namespace winUniversityPortal.AdminForm
{
    partial class ManageAdminForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ManageAdminForm));
            this.tabManageCourse = new MetroFramework.Controls.MetroTabControl();
            this.tabAddAdmin = new MetroFramework.Controls.MetroTabPage();
            this.addAdminPanel = new MetroFramework.Controls.MetroPanel();
            this.AdminID = new MetroFramework.Controls.MetroLabel();
            this.AdminName = new MetroFramework.Controls.MetroLabel();
            this.txtAdminID = new MetroFramework.Controls.MetroTextBox();
            this.cbAdminGender = new MetroFramework.Controls.MetroComboBox();
            this.txtAdminPassword = new MetroFramework.Controls.MetroTextBox();
            this.Gender = new MetroFramework.Controls.MetroLabel();
            this.Password = new MetroFramework.Controls.MetroLabel();
            this.txtAdminEmail = new MetroFramework.Controls.MetroTextBox();
            this.Email = new MetroFramework.Controls.MetroLabel();
            this.txtAdminName = new MetroFramework.Controls.MetroTextBox();
            this.txtAdminPhoneNo = new MetroFramework.Controls.MetroTextBox();
            this.PhoneNo = new MetroFramework.Controls.MetroLabel();
            this.btnBack0 = new MetroFramework.Controls.MetroButton();
            this.btnNewRecord = new MetroFramework.Controls.MetroButton();
            this.btnSave = new MetroFramework.Controls.MetroButton();
            this.tabUpdateAdmin = new MetroFramework.Controls.MetroTabPage();
            this.updateDetailPanel = new MetroFramework.Controls.MetroPanel();
            this.txtGender = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            this.txtID = new MetroFramework.Controls.MetroTextBox();
            this.txtPassowrd = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel3 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel4 = new MetroFramework.Controls.MetroLabel();
            this.txtEmail = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel5 = new MetroFramework.Controls.MetroLabel();
            this.txtName = new MetroFramework.Controls.MetroTextBox();
            this.txtPhoneNo = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel6 = new MetroFramework.Controls.MetroLabel();
            this.btnBack1 = new MetroFramework.Controls.MetroButton();
            this.txtSaveDetails = new MetroFramework.Controls.MetroButton();
            this.tabManageCourse.SuspendLayout();
            this.tabAddAdmin.SuspendLayout();
            this.addAdminPanel.SuspendLayout();
            this.tabUpdateAdmin.SuspendLayout();
            this.updateDetailPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabManageCourse
            // 
            this.tabManageCourse.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tabManageCourse.Controls.Add(this.tabAddAdmin);
            this.tabManageCourse.Controls.Add(this.tabUpdateAdmin);
            this.tabManageCourse.Location = new System.Drawing.Point(23, 63);
            this.tabManageCourse.Name = "tabManageCourse";
            this.tabManageCourse.SelectedIndex = 0;
            this.tabManageCourse.Size = new System.Drawing.Size(754, 385);
            this.tabManageCourse.TabIndex = 2;
            this.tabManageCourse.UseSelectable = true;
            // 
            // tabAddAdmin
            // 
            this.tabAddAdmin.Controls.Add(this.addAdminPanel);
            this.tabAddAdmin.Controls.Add(this.btnBack0);
            this.tabAddAdmin.Controls.Add(this.btnNewRecord);
            this.tabAddAdmin.Controls.Add(this.btnSave);
            this.tabAddAdmin.HorizontalScrollbarBarColor = true;
            this.tabAddAdmin.HorizontalScrollbarHighlightOnWheel = false;
            this.tabAddAdmin.HorizontalScrollbarSize = 10;
            this.tabAddAdmin.Location = new System.Drawing.Point(4, 38);
            this.tabAddAdmin.Name = "tabAddAdmin";
            this.tabAddAdmin.Size = new System.Drawing.Size(746, 343);
            this.tabAddAdmin.TabIndex = 0;
            this.tabAddAdmin.Text = "Add Admin";
            this.tabAddAdmin.VerticalScrollbarBarColor = true;
            this.tabAddAdmin.VerticalScrollbarHighlightOnWheel = false;
            this.tabAddAdmin.VerticalScrollbarSize = 10;
            // 
            // addAdminPanel
            // 
            this.addAdminPanel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.addAdminPanel.Controls.Add(this.AdminID);
            this.addAdminPanel.Controls.Add(this.AdminName);
            this.addAdminPanel.Controls.Add(this.txtAdminID);
            this.addAdminPanel.Controls.Add(this.cbAdminGender);
            this.addAdminPanel.Controls.Add(this.txtAdminPassword);
            this.addAdminPanel.Controls.Add(this.Gender);
            this.addAdminPanel.Controls.Add(this.Password);
            this.addAdminPanel.Controls.Add(this.txtAdminEmail);
            this.addAdminPanel.Controls.Add(this.Email);
            this.addAdminPanel.Controls.Add(this.txtAdminName);
            this.addAdminPanel.Controls.Add(this.txtAdminPhoneNo);
            this.addAdminPanel.Controls.Add(this.PhoneNo);
            this.addAdminPanel.HorizontalScrollbarBarColor = true;
            this.addAdminPanel.HorizontalScrollbarHighlightOnWheel = false;
            this.addAdminPanel.HorizontalScrollbarSize = 10;
            this.addAdminPanel.Location = new System.Drawing.Point(51, 77);
            this.addAdminPanel.Name = "addAdminPanel";
            this.addAdminPanel.Size = new System.Drawing.Size(645, 153);
            this.addAdminPanel.TabIndex = 19;
            this.addAdminPanel.VerticalScrollbarBarColor = true;
            this.addAdminPanel.VerticalScrollbarHighlightOnWheel = false;
            this.addAdminPanel.VerticalScrollbarSize = 10;
            // 
            // AdminID
            // 
            this.AdminID.AutoSize = true;
            this.AdminID.Location = new System.Drawing.Point(2, 22);
            this.AdminID.Name = "AdminID";
            this.AdminID.Size = new System.Drawing.Size(67, 19);
            this.AdminID.TabIndex = 8;
            this.AdminID.Text = "Admin ID:";
            // 
            // AdminName
            // 
            this.AdminName.AutoSize = true;
            this.AdminName.Location = new System.Drawing.Point(2, 62);
            this.AdminName.Name = "AdminName";
            this.AdminName.Size = new System.Drawing.Size(91, 19);
            this.AdminName.TabIndex = 2;
            this.AdminName.Text = "Admin Name:";
            // 
            // txtAdminID
            // 
            // 
            // 
            // 
            this.txtAdminID.CustomButton.Image = null;
            this.txtAdminID.CustomButton.Location = new System.Drawing.Point(168, 1);
            this.txtAdminID.CustomButton.Name = "";
            this.txtAdminID.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtAdminID.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtAdminID.CustomButton.TabIndex = 1;
            this.txtAdminID.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtAdminID.CustomButton.UseSelectable = true;
            this.txtAdminID.CustomButton.Visible = false;
            this.txtAdminID.Lines = new string[0];
            this.txtAdminID.Location = new System.Drawing.Point(117, 21);
            this.txtAdminID.MaxLength = 32767;
            this.txtAdminID.Name = "txtAdminID";
            this.txtAdminID.PasswordChar = '\0';
            this.txtAdminID.PromptText = "Enter Admin ID";
            this.txtAdminID.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtAdminID.SelectedText = "";
            this.txtAdminID.SelectionLength = 0;
            this.txtAdminID.SelectionStart = 0;
            this.txtAdminID.ShortcutsEnabled = true;
            this.txtAdminID.Size = new System.Drawing.Size(190, 23);
            this.txtAdminID.TabIndex = 1;
            this.txtAdminID.UseSelectable = true;
            this.txtAdminID.WaterMark = "Enter Admin ID";
            this.txtAdminID.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtAdminID.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // cbAdminGender
            // 
            this.cbAdminGender.FormattingEnabled = true;
            this.cbAdminGender.ItemHeight = 23;
            this.cbAdminGender.Items.AddRange(new object[] {
            "Male",
            "Female"});
            this.cbAdminGender.Location = new System.Drawing.Point(116, 99);
            this.cbAdminGender.Name = "cbAdminGender";
            this.cbAdminGender.PromptText = "Select Gender";
            this.cbAdminGender.Size = new System.Drawing.Size(190, 29);
            this.cbAdminGender.TabIndex = 3;
            this.cbAdminGender.UseSelectable = true;
            // 
            // txtAdminPassword
            // 
            // 
            // 
            // 
            this.txtAdminPassword.CustomButton.Image = null;
            this.txtAdminPassword.CustomButton.Location = new System.Drawing.Point(168, 1);
            this.txtAdminPassword.CustomButton.Name = "";
            this.txtAdminPassword.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtAdminPassword.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtAdminPassword.CustomButton.TabIndex = 1;
            this.txtAdminPassword.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtAdminPassword.CustomButton.UseSelectable = true;
            this.txtAdminPassword.CustomButton.Visible = false;
            this.txtAdminPassword.Lines = new string[0];
            this.txtAdminPassword.Location = new System.Drawing.Point(452, 105);
            this.txtAdminPassword.MaxLength = 32767;
            this.txtAdminPassword.Name = "txtAdminPassword";
            this.txtAdminPassword.PasswordChar = '\0';
            this.txtAdminPassword.PromptText = "Enter Admin Password";
            this.txtAdminPassword.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtAdminPassword.SelectedText = "";
            this.txtAdminPassword.SelectionLength = 0;
            this.txtAdminPassword.SelectionStart = 0;
            this.txtAdminPassword.ShortcutsEnabled = true;
            this.txtAdminPassword.Size = new System.Drawing.Size(190, 23);
            this.txtAdminPassword.TabIndex = 6;
            this.txtAdminPassword.UseSelectable = true;
            this.txtAdminPassword.WaterMark = "Enter Admin Password";
            this.txtAdminPassword.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtAdminPassword.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // Gender
            // 
            this.Gender.AutoSize = true;
            this.Gender.Location = new System.Drawing.Point(2, 103);
            this.Gender.Name = "Gender";
            this.Gender.Size = new System.Drawing.Size(56, 19);
            this.Gender.TabIndex = 5;
            this.Gender.Text = "Gender:";
            // 
            // Password
            // 
            this.Password.AutoSize = true;
            this.Password.Location = new System.Drawing.Point(349, 107);
            this.Password.Name = "Password";
            this.Password.Size = new System.Drawing.Size(66, 19);
            this.Password.TabIndex = 14;
            this.Password.Text = "Password:";
            // 
            // txtAdminEmail
            // 
            // 
            // 
            // 
            this.txtAdminEmail.CustomButton.Image = null;
            this.txtAdminEmail.CustomButton.Location = new System.Drawing.Point(168, 1);
            this.txtAdminEmail.CustomButton.Name = "";
            this.txtAdminEmail.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtAdminEmail.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtAdminEmail.CustomButton.TabIndex = 1;
            this.txtAdminEmail.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtAdminEmail.CustomButton.UseSelectable = true;
            this.txtAdminEmail.CustomButton.Visible = false;
            this.txtAdminEmail.Lines = new string[0];
            this.txtAdminEmail.Location = new System.Drawing.Point(452, 21);
            this.txtAdminEmail.MaxLength = 32767;
            this.txtAdminEmail.Name = "txtAdminEmail";
            this.txtAdminEmail.PasswordChar = '\0';
            this.txtAdminEmail.PromptText = "Enter Admin Email";
            this.txtAdminEmail.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtAdminEmail.SelectedText = "";
            this.txtAdminEmail.SelectionLength = 0;
            this.txtAdminEmail.SelectionStart = 0;
            this.txtAdminEmail.ShortcutsEnabled = true;
            this.txtAdminEmail.Size = new System.Drawing.Size(190, 23);
            this.txtAdminEmail.TabIndex = 4;
            this.txtAdminEmail.UseSelectable = true;
            this.txtAdminEmail.WaterMark = "Enter Admin Email";
            this.txtAdminEmail.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtAdminEmail.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // Email
            // 
            this.Email.AutoSize = true;
            this.Email.Location = new System.Drawing.Point(349, 22);
            this.Email.Name = "Email";
            this.Email.Size = new System.Drawing.Size(44, 19);
            this.Email.TabIndex = 12;
            this.Email.Text = "Email:";
            // 
            // txtAdminName
            // 
            // 
            // 
            // 
            this.txtAdminName.CustomButton.Image = null;
            this.txtAdminName.CustomButton.Location = new System.Drawing.Point(168, 1);
            this.txtAdminName.CustomButton.Name = "";
            this.txtAdminName.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtAdminName.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtAdminName.CustomButton.TabIndex = 1;
            this.txtAdminName.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtAdminName.CustomButton.UseSelectable = true;
            this.txtAdminName.CustomButton.Visible = false;
            this.txtAdminName.Lines = new string[0];
            this.txtAdminName.Location = new System.Drawing.Point(117, 60);
            this.txtAdminName.MaxLength = 32767;
            this.txtAdminName.Name = "txtAdminName";
            this.txtAdminName.PasswordChar = '\0';
            this.txtAdminName.PromptText = "Enter Admin Name";
            this.txtAdminName.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtAdminName.SelectedText = "";
            this.txtAdminName.SelectionLength = 0;
            this.txtAdminName.SelectionStart = 0;
            this.txtAdminName.ShortcutsEnabled = true;
            this.txtAdminName.Size = new System.Drawing.Size(190, 23);
            this.txtAdminName.TabIndex = 2;
            this.txtAdminName.UseSelectable = true;
            this.txtAdminName.WaterMark = "Enter Admin Name";
            this.txtAdminName.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtAdminName.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // txtAdminPhoneNo
            // 
            // 
            // 
            // 
            this.txtAdminPhoneNo.CustomButton.Image = null;
            this.txtAdminPhoneNo.CustomButton.Location = new System.Drawing.Point(168, 1);
            this.txtAdminPhoneNo.CustomButton.Name = "";
            this.txtAdminPhoneNo.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtAdminPhoneNo.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtAdminPhoneNo.CustomButton.TabIndex = 1;
            this.txtAdminPhoneNo.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtAdminPhoneNo.CustomButton.UseSelectable = true;
            this.txtAdminPhoneNo.CustomButton.Visible = false;
            this.txtAdminPhoneNo.Lines = new string[0];
            this.txtAdminPhoneNo.Location = new System.Drawing.Point(452, 59);
            this.txtAdminPhoneNo.MaxLength = 32767;
            this.txtAdminPhoneNo.Name = "txtAdminPhoneNo";
            this.txtAdminPhoneNo.PasswordChar = '\0';
            this.txtAdminPhoneNo.PromptText = "Enter Admin No";
            this.txtAdminPhoneNo.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtAdminPhoneNo.SelectedText = "";
            this.txtAdminPhoneNo.SelectionLength = 0;
            this.txtAdminPhoneNo.SelectionStart = 0;
            this.txtAdminPhoneNo.ShortcutsEnabled = true;
            this.txtAdminPhoneNo.Size = new System.Drawing.Size(190, 23);
            this.txtAdminPhoneNo.TabIndex = 5;
            this.txtAdminPhoneNo.UseSelectable = true;
            this.txtAdminPhoneNo.WaterMark = "Enter Admin No";
            this.txtAdminPhoneNo.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtAdminPhoneNo.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // PhoneNo
            // 
            this.PhoneNo.AutoSize = true;
            this.PhoneNo.Location = new System.Drawing.Point(349, 62);
            this.PhoneNo.Name = "PhoneNo";
            this.PhoneNo.Size = new System.Drawing.Size(71, 19);
            this.PhoneNo.TabIndex = 10;
            this.PhoneNo.Text = "Phone No:";
            // 
            // btnBack0
            // 
            this.btnBack0.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btnBack0.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.btnBack0.FontSize = MetroFramework.MetroButtonSize.Medium;
            this.btnBack0.FontWeight = MetroFramework.MetroButtonWeight.Regular;
            this.btnBack0.ForeColor = System.Drawing.Color.White;
            this.btnBack0.Location = new System.Drawing.Point(194, 304);
            this.btnBack0.Name = "btnBack0";
            this.btnBack0.Size = new System.Drawing.Size(90, 36);
            this.btnBack0.TabIndex = 9;
            this.btnBack0.Text = "Back";
            this.btnBack0.UseCustomBackColor = true;
            this.btnBack0.UseCustomForeColor = true;
            this.btnBack0.UseSelectable = true;
            this.btnBack0.Click += new System.EventHandler(this.btnBack0_Click);
            // 
            // btnNewRecord
            // 
            this.btnNewRecord.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btnNewRecord.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.btnNewRecord.FontSize = MetroFramework.MetroButtonSize.Medium;
            this.btnNewRecord.FontWeight = MetroFramework.MetroButtonWeight.Regular;
            this.btnNewRecord.ForeColor = System.Drawing.Color.White;
            this.btnNewRecord.Location = new System.Drawing.Point(462, 304);
            this.btnNewRecord.Name = "btnNewRecord";
            this.btnNewRecord.Size = new System.Drawing.Size(90, 36);
            this.btnNewRecord.TabIndex = 8;
            this.btnNewRecord.Text = "New Record";
            this.btnNewRecord.UseCustomBackColor = true;
            this.btnNewRecord.UseCustomForeColor = true;
            this.btnNewRecord.UseSelectable = true;
            this.btnNewRecord.Click += new System.EventHandler(this.btnNewRecord_Click);
            // 
            // btnSave
            // 
            this.btnSave.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btnSave.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.btnSave.FontSize = MetroFramework.MetroButtonSize.Medium;
            this.btnSave.FontWeight = MetroFramework.MetroButtonWeight.Regular;
            this.btnSave.ForeColor = System.Drawing.Color.White;
            this.btnSave.Location = new System.Drawing.Point(328, 304);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(90, 36);
            this.btnSave.TabIndex = 7;
            this.btnSave.Text = "Save";
            this.btnSave.UseCustomBackColor = true;
            this.btnSave.UseCustomForeColor = true;
            this.btnSave.UseSelectable = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // tabUpdateAdmin
            // 
            this.tabUpdateAdmin.Controls.Add(this.updateDetailPanel);
            this.tabUpdateAdmin.Controls.Add(this.btnBack1);
            this.tabUpdateAdmin.Controls.Add(this.txtSaveDetails);
            this.tabUpdateAdmin.HorizontalScrollbarBarColor = true;
            this.tabUpdateAdmin.HorizontalScrollbarHighlightOnWheel = false;
            this.tabUpdateAdmin.HorizontalScrollbarSize = 10;
            this.tabUpdateAdmin.Location = new System.Drawing.Point(4, 38);
            this.tabUpdateAdmin.Name = "tabUpdateAdmin";
            this.tabUpdateAdmin.Size = new System.Drawing.Size(746, 343);
            this.tabUpdateAdmin.TabIndex = 1;
            this.tabUpdateAdmin.Text = "Update Detail";
            this.tabUpdateAdmin.VerticalScrollbarBarColor = true;
            this.tabUpdateAdmin.VerticalScrollbarHighlightOnWheel = false;
            this.tabUpdateAdmin.VerticalScrollbarSize = 10;
            // 
            // updateDetailPanel
            // 
            this.updateDetailPanel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.updateDetailPanel.Controls.Add(this.txtGender);
            this.updateDetailPanel.Controls.Add(this.metroLabel1);
            this.updateDetailPanel.Controls.Add(this.metroLabel2);
            this.updateDetailPanel.Controls.Add(this.txtID);
            this.updateDetailPanel.Controls.Add(this.txtPassowrd);
            this.updateDetailPanel.Controls.Add(this.metroLabel3);
            this.updateDetailPanel.Controls.Add(this.metroLabel4);
            this.updateDetailPanel.Controls.Add(this.txtEmail);
            this.updateDetailPanel.Controls.Add(this.metroLabel5);
            this.updateDetailPanel.Controls.Add(this.txtName);
            this.updateDetailPanel.Controls.Add(this.txtPhoneNo);
            this.updateDetailPanel.Controls.Add(this.metroLabel6);
            this.updateDetailPanel.HorizontalScrollbarBarColor = true;
            this.updateDetailPanel.HorizontalScrollbarHighlightOnWheel = false;
            this.updateDetailPanel.HorizontalScrollbarSize = 10;
            this.updateDetailPanel.Location = new System.Drawing.Point(52, 77);
            this.updateDetailPanel.Name = "updateDetailPanel";
            this.updateDetailPanel.Size = new System.Drawing.Size(645, 153);
            this.updateDetailPanel.TabIndex = 20;
            this.updateDetailPanel.VerticalScrollbarBarColor = true;
            this.updateDetailPanel.VerticalScrollbarHighlightOnWheel = false;
            this.updateDetailPanel.VerticalScrollbarSize = 10;
            // 
            // txtGender
            // 
            // 
            // 
            // 
            this.txtGender.CustomButton.Image = null;
            this.txtGender.CustomButton.Location = new System.Drawing.Point(168, 1);
            this.txtGender.CustomButton.Name = "";
            this.txtGender.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtGender.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtGender.CustomButton.TabIndex = 1;
            this.txtGender.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtGender.CustomButton.UseSelectable = true;
            this.txtGender.CustomButton.Visible = false;
            this.txtGender.Lines = new string[0];
            this.txtGender.Location = new System.Drawing.Point(118, 101);
            this.txtGender.MaxLength = 32767;
            this.txtGender.Name = "txtGender";
            this.txtGender.PasswordChar = '\0';
            this.txtGender.ReadOnly = true;
            this.txtGender.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtGender.SelectedText = "";
            this.txtGender.SelectionLength = 0;
            this.txtGender.SelectionStart = 0;
            this.txtGender.ShortcutsEnabled = true;
            this.txtGender.Size = new System.Drawing.Size(190, 23);
            this.txtGender.TabIndex = 15;
            this.txtGender.UseSelectable = true;
            this.txtGender.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtGender.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.Location = new System.Drawing.Point(3, 22);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(67, 19);
            this.metroLabel1.TabIndex = 8;
            this.metroLabel1.Text = "Admin ID:";
            // 
            // metroLabel2
            // 
            this.metroLabel2.AutoSize = true;
            this.metroLabel2.Location = new System.Drawing.Point(3, 62);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(91, 19);
            this.metroLabel2.TabIndex = 2;
            this.metroLabel2.Text = "Admin Name:";
            // 
            // txtID
            // 
            // 
            // 
            // 
            this.txtID.CustomButton.Image = null;
            this.txtID.CustomButton.Location = new System.Drawing.Point(168, 1);
            this.txtID.CustomButton.Name = "";
            this.txtID.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtID.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtID.CustomButton.TabIndex = 1;
            this.txtID.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtID.CustomButton.UseSelectable = true;
            this.txtID.CustomButton.Visible = false;
            this.txtID.Lines = new string[0];
            this.txtID.Location = new System.Drawing.Point(118, 21);
            this.txtID.MaxLength = 32767;
            this.txtID.Name = "txtID";
            this.txtID.PasswordChar = '\0';
            this.txtID.ReadOnly = true;
            this.txtID.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtID.SelectedText = "";
            this.txtID.SelectionLength = 0;
            this.txtID.SelectionStart = 0;
            this.txtID.ShortcutsEnabled = true;
            this.txtID.Size = new System.Drawing.Size(190, 23);
            this.txtID.TabIndex = 1;
            this.txtID.UseSelectable = true;
            this.txtID.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtID.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // txtPassowrd
            // 
            // 
            // 
            // 
            this.txtPassowrd.CustomButton.Image = null;
            this.txtPassowrd.CustomButton.Location = new System.Drawing.Point(168, 1);
            this.txtPassowrd.CustomButton.Name = "";
            this.txtPassowrd.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtPassowrd.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtPassowrd.CustomButton.TabIndex = 1;
            this.txtPassowrd.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtPassowrd.CustomButton.UseSelectable = true;
            this.txtPassowrd.CustomButton.Visible = false;
            this.txtPassowrd.Lines = new string[0];
            this.txtPassowrd.Location = new System.Drawing.Point(452, 101);
            this.txtPassowrd.MaxLength = 32767;
            this.txtPassowrd.Name = "txtPassowrd";
            this.txtPassowrd.PasswordChar = '\0';
            this.txtPassowrd.PromptText = "Enter Passwrod";
            this.txtPassowrd.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtPassowrd.SelectedText = "";
            this.txtPassowrd.SelectionLength = 0;
            this.txtPassowrd.SelectionStart = 0;
            this.txtPassowrd.ShortcutsEnabled = true;
            this.txtPassowrd.Size = new System.Drawing.Size(190, 23);
            this.txtPassowrd.TabIndex = 6;
            this.txtPassowrd.UseSelectable = true;
            this.txtPassowrd.WaterMark = "Enter Passwrod";
            this.txtPassowrd.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtPassowrd.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // metroLabel3
            // 
            this.metroLabel3.AutoSize = true;
            this.metroLabel3.Location = new System.Drawing.Point(3, 99);
            this.metroLabel3.Name = "metroLabel3";
            this.metroLabel3.Size = new System.Drawing.Size(56, 19);
            this.metroLabel3.TabIndex = 5;
            this.metroLabel3.Text = "Gender:";
            // 
            // metroLabel4
            // 
            this.metroLabel4.AutoSize = true;
            this.metroLabel4.Location = new System.Drawing.Point(349, 103);
            this.metroLabel4.Name = "metroLabel4";
            this.metroLabel4.Size = new System.Drawing.Size(66, 19);
            this.metroLabel4.TabIndex = 14;
            this.metroLabel4.Text = "Password:";
            // 
            // txtEmail
            // 
            // 
            // 
            // 
            this.txtEmail.CustomButton.Image = null;
            this.txtEmail.CustomButton.Location = new System.Drawing.Point(168, 1);
            this.txtEmail.CustomButton.Name = "";
            this.txtEmail.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtEmail.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtEmail.CustomButton.TabIndex = 1;
            this.txtEmail.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtEmail.CustomButton.UseSelectable = true;
            this.txtEmail.CustomButton.Visible = false;
            this.txtEmail.Lines = new string[0];
            this.txtEmail.Location = new System.Drawing.Point(452, 21);
            this.txtEmail.MaxLength = 32767;
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.PasswordChar = '\0';
            this.txtEmail.PromptText = "Enter Email";
            this.txtEmail.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtEmail.SelectedText = "";
            this.txtEmail.SelectionLength = 0;
            this.txtEmail.SelectionStart = 0;
            this.txtEmail.ShortcutsEnabled = true;
            this.txtEmail.Size = new System.Drawing.Size(190, 23);
            this.txtEmail.TabIndex = 4;
            this.txtEmail.UseSelectable = true;
            this.txtEmail.WaterMark = "Enter Email";
            this.txtEmail.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtEmail.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // metroLabel5
            // 
            this.metroLabel5.AutoSize = true;
            this.metroLabel5.Location = new System.Drawing.Point(349, 22);
            this.metroLabel5.Name = "metroLabel5";
            this.metroLabel5.Size = new System.Drawing.Size(44, 19);
            this.metroLabel5.TabIndex = 12;
            this.metroLabel5.Text = "Email:";
            // 
            // txtName
            // 
            // 
            // 
            // 
            this.txtName.CustomButton.Image = null;
            this.txtName.CustomButton.Location = new System.Drawing.Point(168, 1);
            this.txtName.CustomButton.Name = "";
            this.txtName.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtName.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtName.CustomButton.TabIndex = 1;
            this.txtName.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtName.CustomButton.UseSelectable = true;
            this.txtName.CustomButton.Visible = false;
            this.txtName.Lines = new string[0];
            this.txtName.Location = new System.Drawing.Point(118, 60);
            this.txtName.MaxLength = 32767;
            this.txtName.Name = "txtName";
            this.txtName.PasswordChar = '\0';
            this.txtName.PromptText = "Enter Name";
            this.txtName.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtName.SelectedText = "";
            this.txtName.SelectionLength = 0;
            this.txtName.SelectionStart = 0;
            this.txtName.ShortcutsEnabled = true;
            this.txtName.Size = new System.Drawing.Size(190, 23);
            this.txtName.TabIndex = 2;
            this.txtName.UseSelectable = true;
            this.txtName.WaterMark = "Enter Name";
            this.txtName.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtName.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // txtPhoneNo
            // 
            // 
            // 
            // 
            this.txtPhoneNo.CustomButton.Image = null;
            this.txtPhoneNo.CustomButton.Location = new System.Drawing.Point(168, 1);
            this.txtPhoneNo.CustomButton.Name = "";
            this.txtPhoneNo.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtPhoneNo.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtPhoneNo.CustomButton.TabIndex = 1;
            this.txtPhoneNo.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtPhoneNo.CustomButton.UseSelectable = true;
            this.txtPhoneNo.CustomButton.Visible = false;
            this.txtPhoneNo.Lines = new string[0];
            this.txtPhoneNo.Location = new System.Drawing.Point(452, 59);
            this.txtPhoneNo.MaxLength = 32767;
            this.txtPhoneNo.Name = "txtPhoneNo";
            this.txtPhoneNo.PasswordChar = '\0';
            this.txtPhoneNo.PromptText = "Enter Number";
            this.txtPhoneNo.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtPhoneNo.SelectedText = "";
            this.txtPhoneNo.SelectionLength = 0;
            this.txtPhoneNo.SelectionStart = 0;
            this.txtPhoneNo.ShortcutsEnabled = true;
            this.txtPhoneNo.Size = new System.Drawing.Size(190, 23);
            this.txtPhoneNo.TabIndex = 5;
            this.txtPhoneNo.UseSelectable = true;
            this.txtPhoneNo.WaterMark = "Enter Number";
            this.txtPhoneNo.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtPhoneNo.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // metroLabel6
            // 
            this.metroLabel6.AutoSize = true;
            this.metroLabel6.Location = new System.Drawing.Point(349, 62);
            this.metroLabel6.Name = "metroLabel6";
            this.metroLabel6.Size = new System.Drawing.Size(71, 19);
            this.metroLabel6.TabIndex = 10;
            this.metroLabel6.Text = "Phone No:";
            // 
            // btnBack1
            // 
            this.btnBack1.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btnBack1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.btnBack1.FontSize = MetroFramework.MetroButtonSize.Medium;
            this.btnBack1.FontWeight = MetroFramework.MetroButtonWeight.Regular;
            this.btnBack1.ForeColor = System.Drawing.Color.White;
            this.btnBack1.Location = new System.Drawing.Point(260, 304);
            this.btnBack1.Name = "btnBack1";
            this.btnBack1.Size = new System.Drawing.Size(90, 36);
            this.btnBack1.TabIndex = 8;
            this.btnBack1.Text = "Back";
            this.btnBack1.UseCustomBackColor = true;
            this.btnBack1.UseCustomForeColor = true;
            this.btnBack1.UseSelectable = true;
            this.btnBack1.Click += new System.EventHandler(this.btnBack1_Click);
            // 
            // txtSaveDetails
            // 
            this.txtSaveDetails.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.txtSaveDetails.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.txtSaveDetails.FontSize = MetroFramework.MetroButtonSize.Medium;
            this.txtSaveDetails.FontWeight = MetroFramework.MetroButtonWeight.Regular;
            this.txtSaveDetails.ForeColor = System.Drawing.Color.White;
            this.txtSaveDetails.Location = new System.Drawing.Point(398, 304);
            this.txtSaveDetails.Name = "txtSaveDetails";
            this.txtSaveDetails.Size = new System.Drawing.Size(90, 36);
            this.txtSaveDetails.TabIndex = 7;
            this.txtSaveDetails.Text = "Save";
            this.txtSaveDetails.UseCustomBackColor = true;
            this.txtSaveDetails.UseCustomForeColor = true;
            this.txtSaveDetails.UseSelectable = true;
            this.txtSaveDetails.Click += new System.EventHandler(this.txtSaveDetails_Click);
            // 
            // ManageAdminForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 471);
            this.Controls.Add(this.tabManageCourse);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "ManageAdminForm";
            this.Text = "Manage Admin";
            this.Load += new System.EventHandler(this.ManageAdminForm_Load);
            this.tabManageCourse.ResumeLayout(false);
            this.tabAddAdmin.ResumeLayout(false);
            this.addAdminPanel.ResumeLayout(false);
            this.addAdminPanel.PerformLayout();
            this.tabUpdateAdmin.ResumeLayout(false);
            this.updateDetailPanel.ResumeLayout(false);
            this.updateDetailPanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private MetroFramework.Controls.MetroTabControl tabManageCourse;
        private MetroFramework.Controls.MetroTabPage tabAddAdmin;
        private MetroFramework.Controls.MetroButton btnBack0;
        private MetroFramework.Controls.MetroButton btnNewRecord;
        private MetroFramework.Controls.MetroButton btnSave;
        private MetroFramework.Controls.MetroTabPage tabUpdateAdmin;
        private MetroFramework.Controls.MetroButton txtSaveDetails;
        private MetroFramework.Controls.MetroButton btnBack1;
        private MetroFramework.Controls.MetroPanel addAdminPanel;
        private MetroFramework.Controls.MetroLabel AdminID;
        private MetroFramework.Controls.MetroLabel AdminName;
        private MetroFramework.Controls.MetroTextBox txtAdminID;
        private MetroFramework.Controls.MetroComboBox cbAdminGender;
        private MetroFramework.Controls.MetroTextBox txtAdminPassword;
        private MetroFramework.Controls.MetroLabel Gender;
        private MetroFramework.Controls.MetroLabel Password;
        private MetroFramework.Controls.MetroTextBox txtAdminEmail;
        private MetroFramework.Controls.MetroLabel Email;
        private MetroFramework.Controls.MetroTextBox txtAdminName;
        private MetroFramework.Controls.MetroTextBox txtAdminPhoneNo;
        private MetroFramework.Controls.MetroLabel PhoneNo;
        private MetroFramework.Controls.MetroPanel updateDetailPanel;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Controls.MetroLabel metroLabel2;
        private MetroFramework.Controls.MetroTextBox txtID;
        private MetroFramework.Controls.MetroTextBox txtPassowrd;
        private MetroFramework.Controls.MetroLabel metroLabel3;
        private MetroFramework.Controls.MetroLabel metroLabel4;
        private MetroFramework.Controls.MetroTextBox txtEmail;
        private MetroFramework.Controls.MetroLabel metroLabel5;
        private MetroFramework.Controls.MetroTextBox txtName;
        private MetroFramework.Controls.MetroTextBox txtPhoneNo;
        private MetroFramework.Controls.MetroLabel metroLabel6;
        private MetroFramework.Controls.MetroTextBox txtGender;
    }
}