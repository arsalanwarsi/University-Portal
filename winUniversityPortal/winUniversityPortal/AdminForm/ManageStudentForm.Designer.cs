
namespace winUniversityPortal.AdminForm
{
    partial class ManageStudentForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ManageStudentForm));
            this.tabManageStudent = new MetroFramework.Controls.MetroTabControl();
            this.tabAddStudent = new MetroFramework.Controls.MetroTabPage();
            this.addStudentPanel = new MetroFramework.Controls.MetroPanel();
            this.StudentID = new MetroFramework.Controls.MetroLabel();
            this.StudentName = new MetroFramework.Controls.MetroLabel();
            this.txtStudentID = new MetroFramework.Controls.MetroTextBox();
            this.cbStudentGender = new MetroFramework.Controls.MetroComboBox();
            this.txtPassword = new MetroFramework.Controls.MetroTextBox();
            this.Gender = new MetroFramework.Controls.MetroLabel();
            this.Password = new MetroFramework.Controls.MetroLabel();
            this.cbStudentProgram = new MetroFramework.Controls.MetroComboBox();
            this.txtStudentEmail = new MetroFramework.Controls.MetroTextBox();
            this.Program = new MetroFramework.Controls.MetroLabel();
            this.Email = new MetroFramework.Controls.MetroLabel();
            this.txtStudentName = new MetroFramework.Controls.MetroTextBox();
            this.txtPhoneNo = new MetroFramework.Controls.MetroTextBox();
            this.PhoneNo = new MetroFramework.Controls.MetroLabel();
            this.btnBack0 = new MetroFramework.Controls.MetroButton();
            this.btnNewRecord = new MetroFramework.Controls.MetroButton();
            this.btnSave = new MetroFramework.Controls.MetroButton();
            this.tabStudent = new MetroFramework.Controls.MetroTabPage();
            this.managePanel = new MetroFramework.Controls.MetroPanel();
            this.SearchStudentID = new MetroFramework.Controls.MetroLabel();
            this.txtSearchStudentID = new MetroFramework.Controls.MetroTextBox();
            this.btnSeachStudentID = new MetroFramework.Controls.MetroButton();
            this.gvStudentDetails = new System.Windows.Forms.DataGridView();
            this.btnUpdateDetail = new MetroFramework.Controls.MetroButton();
            this.btnDeleteStudent = new MetroFramework.Controls.MetroButton();
            this.btnBack1 = new MetroFramework.Controls.MetroButton();
            this.tabStudentRercord = new MetroFramework.Controls.MetroTabPage();
            this.btnAllRecord = new MetroFramework.Controls.MetroButton();
            this.bntBack2 = new MetroFramework.Controls.MetroButton();
            this.studentRecordPanel = new MetroFramework.Controls.MetroPanel();
            this.seachProgram = new MetroFramework.Controls.MetroLabel();
            this.txtSeachProgram = new MetroFramework.Controls.MetroTextBox();
            this.btnSeachRecord = new MetroFramework.Controls.MetroButton();
            this.gvRecordProgram = new System.Windows.Forms.DataGridView();
            this.tabManageStudent.SuspendLayout();
            this.tabAddStudent.SuspendLayout();
            this.addStudentPanel.SuspendLayout();
            this.tabStudent.SuspendLayout();
            this.managePanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gvStudentDetails)).BeginInit();
            this.tabStudentRercord.SuspendLayout();
            this.studentRecordPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gvRecordProgram)).BeginInit();
            this.SuspendLayout();
            // 
            // tabManageStudent
            // 
            this.tabManageStudent.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tabManageStudent.Controls.Add(this.tabAddStudent);
            this.tabManageStudent.Controls.Add(this.tabStudent);
            this.tabManageStudent.Controls.Add(this.tabStudentRercord);
            this.tabManageStudent.Location = new System.Drawing.Point(23, 63);
            this.tabManageStudent.Name = "tabManageStudent";
            this.tabManageStudent.SelectedIndex = 1;
            this.tabManageStudent.Size = new System.Drawing.Size(754, 385);
            this.tabManageStudent.TabIndex = 0;
            this.tabManageStudent.UseSelectable = true;
            // 
            // tabAddStudent
            // 
            this.tabAddStudent.Controls.Add(this.addStudentPanel);
            this.tabAddStudent.Controls.Add(this.btnBack0);
            this.tabAddStudent.Controls.Add(this.btnNewRecord);
            this.tabAddStudent.Controls.Add(this.btnSave);
            this.tabAddStudent.HorizontalScrollbarBarColor = true;
            this.tabAddStudent.HorizontalScrollbarHighlightOnWheel = false;
            this.tabAddStudent.HorizontalScrollbarSize = 10;
            this.tabAddStudent.Location = new System.Drawing.Point(4, 38);
            this.tabAddStudent.Name = "tabAddStudent";
            this.tabAddStudent.Size = new System.Drawing.Size(746, 343);
            this.tabAddStudent.TabIndex = 0;
            this.tabAddStudent.Text = "Add Student";
            this.tabAddStudent.VerticalScrollbarBarColor = true;
            this.tabAddStudent.VerticalScrollbarHighlightOnWheel = false;
            this.tabAddStudent.VerticalScrollbarSize = 10;
            // 
            // addStudentPanel
            // 
            this.addStudentPanel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.addStudentPanel.Controls.Add(this.StudentID);
            this.addStudentPanel.Controls.Add(this.StudentName);
            this.addStudentPanel.Controls.Add(this.txtStudentID);
            this.addStudentPanel.Controls.Add(this.cbStudentGender);
            this.addStudentPanel.Controls.Add(this.txtPassword);
            this.addStudentPanel.Controls.Add(this.Gender);
            this.addStudentPanel.Controls.Add(this.Password);
            this.addStudentPanel.Controls.Add(this.cbStudentProgram);
            this.addStudentPanel.Controls.Add(this.txtStudentEmail);
            this.addStudentPanel.Controls.Add(this.Program);
            this.addStudentPanel.Controls.Add(this.Email);
            this.addStudentPanel.Controls.Add(this.txtStudentName);
            this.addStudentPanel.Controls.Add(this.txtPhoneNo);
            this.addStudentPanel.Controls.Add(this.PhoneNo);
            this.addStudentPanel.HorizontalScrollbarBarColor = true;
            this.addStudentPanel.HorizontalScrollbarHighlightOnWheel = false;
            this.addStudentPanel.HorizontalScrollbarSize = 10;
            this.addStudentPanel.Location = new System.Drawing.Point(52, 77);
            this.addStudentPanel.Name = "addStudentPanel";
            this.addStudentPanel.Size = new System.Drawing.Size(645, 153);
            this.addStudentPanel.TabIndex = 18;
            this.addStudentPanel.VerticalScrollbarBarColor = true;
            this.addStudentPanel.VerticalScrollbarHighlightOnWheel = false;
            this.addStudentPanel.VerticalScrollbarSize = 10;
            // 
            // StudentID
            // 
            this.StudentID.AutoSize = true;
            this.StudentID.Location = new System.Drawing.Point(3, 4);
            this.StudentID.Name = "StudentID";
            this.StudentID.Size = new System.Drawing.Size(72, 19);
            this.StudentID.TabIndex = 8;
            this.StudentID.Text = "Student ID:";
            // 
            // StudentName
            // 
            this.StudentName.AutoSize = true;
            this.StudentName.Location = new System.Drawing.Point(3, 44);
            this.StudentName.Name = "StudentName";
            this.StudentName.Size = new System.Drawing.Size(96, 19);
            this.StudentName.TabIndex = 2;
            this.StudentName.Text = "Student Name:";
            // 
            // txtStudentID
            // 
            // 
            // 
            // 
            this.txtStudentID.CustomButton.Image = null;
            this.txtStudentID.CustomButton.Location = new System.Drawing.Point(168, 1);
            this.txtStudentID.CustomButton.Name = "";
            this.txtStudentID.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtStudentID.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtStudentID.CustomButton.TabIndex = 1;
            this.txtStudentID.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtStudentID.CustomButton.UseSelectable = true;
            this.txtStudentID.CustomButton.Visible = false;
            this.txtStudentID.Lines = new string[0];
            this.txtStudentID.Location = new System.Drawing.Point(118, 3);
            this.txtStudentID.MaxLength = 32767;
            this.txtStudentID.Name = "txtStudentID";
            this.txtStudentID.PasswordChar = '\0';
            this.txtStudentID.PromptText = "Enter Student ID";
            this.txtStudentID.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtStudentID.SelectedText = "";
            this.txtStudentID.SelectionLength = 0;
            this.txtStudentID.SelectionStart = 0;
            this.txtStudentID.ShortcutsEnabled = true;
            this.txtStudentID.Size = new System.Drawing.Size(190, 23);
            this.txtStudentID.TabIndex = 1;
            this.txtStudentID.UseSelectable = true;
            this.txtStudentID.WaterMark = "Enter Student ID";
            this.txtStudentID.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtStudentID.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // cbStudentGender
            // 
            this.cbStudentGender.FormattingEnabled = true;
            this.cbStudentGender.ItemHeight = 23;
            this.cbStudentGender.Items.AddRange(new object[] {
            "Male",
            "Female"});
            this.cbStudentGender.Location = new System.Drawing.Point(117, 81);
            this.cbStudentGender.Name = "cbStudentGender";
            this.cbStudentGender.PromptText = "Select Gender";
            this.cbStudentGender.Size = new System.Drawing.Size(190, 29);
            this.cbStudentGender.TabIndex = 3;
            this.cbStudentGender.UseSelectable = true;
            // 
            // txtPassword
            // 
            // 
            // 
            // 
            this.txtPassword.CustomButton.Image = null;
            this.txtPassword.CustomButton.Location = new System.Drawing.Point(168, 1);
            this.txtPassword.CustomButton.Name = "";
            this.txtPassword.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtPassword.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtPassword.CustomButton.TabIndex = 1;
            this.txtPassword.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtPassword.CustomButton.UseSelectable = true;
            this.txtPassword.CustomButton.Visible = false;
            this.txtPassword.Lines = new string[0];
            this.txtPassword.Location = new System.Drawing.Point(452, 87);
            this.txtPassword.MaxLength = 32767;
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.PasswordChar = '\0';
            this.txtPassword.PromptText = "Enter Student Password";
            this.txtPassword.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtPassword.SelectedText = "";
            this.txtPassword.SelectionLength = 0;
            this.txtPassword.SelectionStart = 0;
            this.txtPassword.ShortcutsEnabled = true;
            this.txtPassword.Size = new System.Drawing.Size(190, 23);
            this.txtPassword.TabIndex = 7;
            this.txtPassword.UseSelectable = true;
            this.txtPassword.WaterMark = "Enter Student Password";
            this.txtPassword.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtPassword.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // Gender
            // 
            this.Gender.AutoSize = true;
            this.Gender.Location = new System.Drawing.Point(3, 85);
            this.Gender.Name = "Gender";
            this.Gender.Size = new System.Drawing.Size(56, 19);
            this.Gender.TabIndex = 5;
            this.Gender.Text = "Gender:";
            // 
            // Password
            // 
            this.Password.AutoSize = true;
            this.Password.Location = new System.Drawing.Point(349, 89);
            this.Password.Name = "Password";
            this.Password.Size = new System.Drawing.Size(66, 19);
            this.Password.TabIndex = 14;
            this.Password.Text = "Password:";
            // 
            // cbStudentProgram
            // 
            this.cbStudentProgram.FormattingEnabled = true;
            this.cbStudentProgram.ItemHeight = 23;
            this.cbStudentProgram.Items.AddRange(new object[] {
            "BS SE",
            "BS CS",
            "BBA"});
            this.cbStudentProgram.Location = new System.Drawing.Point(452, 42);
            this.cbStudentProgram.Name = "cbStudentProgram";
            this.cbStudentProgram.PromptText = "Select Program";
            this.cbStudentProgram.Size = new System.Drawing.Size(190, 29);
            this.cbStudentProgram.TabIndex = 6;
            this.cbStudentProgram.UseSelectable = true;
            // 
            // txtStudentEmail
            // 
            // 
            // 
            // 
            this.txtStudentEmail.CustomButton.Image = null;
            this.txtStudentEmail.CustomButton.Location = new System.Drawing.Point(168, 1);
            this.txtStudentEmail.CustomButton.Name = "";
            this.txtStudentEmail.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtStudentEmail.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtStudentEmail.CustomButton.TabIndex = 1;
            this.txtStudentEmail.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtStudentEmail.CustomButton.UseSelectable = true;
            this.txtStudentEmail.CustomButton.Visible = false;
            this.txtStudentEmail.Lines = new string[0];
            this.txtStudentEmail.Location = new System.Drawing.Point(117, 126);
            this.txtStudentEmail.MaxLength = 32767;
            this.txtStudentEmail.Name = "txtStudentEmail";
            this.txtStudentEmail.PasswordChar = '\0';
            this.txtStudentEmail.PromptText = "Enter Student Email";
            this.txtStudentEmail.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtStudentEmail.SelectedText = "";
            this.txtStudentEmail.SelectionLength = 0;
            this.txtStudentEmail.SelectionStart = 0;
            this.txtStudentEmail.ShortcutsEnabled = true;
            this.txtStudentEmail.Size = new System.Drawing.Size(190, 23);
            this.txtStudentEmail.TabIndex = 4;
            this.txtStudentEmail.UseSelectable = true;
            this.txtStudentEmail.WaterMark = "Enter Student Email";
            this.txtStudentEmail.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtStudentEmail.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // Program
            // 
            this.Program.AutoSize = true;
            this.Program.Location = new System.Drawing.Point(349, 47);
            this.Program.Name = "Program";
            this.Program.Size = new System.Drawing.Size(65, 19);
            this.Program.TabIndex = 7;
            this.Program.Text = "Program:";
            // 
            // Email
            // 
            this.Email.AutoSize = true;
            this.Email.Location = new System.Drawing.Point(3, 127);
            this.Email.Name = "Email";
            this.Email.Size = new System.Drawing.Size(44, 19);
            this.Email.TabIndex = 12;
            this.Email.Text = "Email:";
            // 
            // txtStudentName
            // 
            // 
            // 
            // 
            this.txtStudentName.CustomButton.Image = null;
            this.txtStudentName.CustomButton.Location = new System.Drawing.Point(168, 1);
            this.txtStudentName.CustomButton.Name = "";
            this.txtStudentName.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtStudentName.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtStudentName.CustomButton.TabIndex = 1;
            this.txtStudentName.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtStudentName.CustomButton.UseSelectable = true;
            this.txtStudentName.CustomButton.Visible = false;
            this.txtStudentName.Lines = new string[0];
            this.txtStudentName.Location = new System.Drawing.Point(118, 42);
            this.txtStudentName.MaxLength = 32767;
            this.txtStudentName.Name = "txtStudentName";
            this.txtStudentName.PasswordChar = '\0';
            this.txtStudentName.PromptText = "Enter Student Name";
            this.txtStudentName.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtStudentName.SelectedText = "";
            this.txtStudentName.SelectionLength = 0;
            this.txtStudentName.SelectionStart = 0;
            this.txtStudentName.ShortcutsEnabled = true;
            this.txtStudentName.Size = new System.Drawing.Size(190, 23);
            this.txtStudentName.TabIndex = 2;
            this.txtStudentName.UseSelectable = true;
            this.txtStudentName.WaterMark = "Enter Student Name";
            this.txtStudentName.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtStudentName.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
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
            this.txtPhoneNo.Location = new System.Drawing.Point(452, 3);
            this.txtPhoneNo.MaxLength = 32767;
            this.txtPhoneNo.Name = "txtPhoneNo";
            this.txtPhoneNo.PasswordChar = '\0';
            this.txtPhoneNo.PromptText = "Enter Phone No";
            this.txtPhoneNo.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtPhoneNo.SelectedText = "";
            this.txtPhoneNo.SelectionLength = 0;
            this.txtPhoneNo.SelectionStart = 0;
            this.txtPhoneNo.ShortcutsEnabled = true;
            this.txtPhoneNo.Size = new System.Drawing.Size(190, 23);
            this.txtPhoneNo.TabIndex = 5;
            this.txtPhoneNo.UseSelectable = true;
            this.txtPhoneNo.WaterMark = "Enter Phone No";
            this.txtPhoneNo.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtPhoneNo.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // PhoneNo
            // 
            this.PhoneNo.AutoSize = true;
            this.PhoneNo.Location = new System.Drawing.Point(349, 6);
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
            this.btnBack0.TabIndex = 10;
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
            this.btnNewRecord.TabIndex = 9;
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
            this.btnSave.TabIndex = 8;
            this.btnSave.Text = "Save";
            this.btnSave.UseCustomBackColor = true;
            this.btnSave.UseCustomForeColor = true;
            this.btnSave.UseSelectable = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // tabStudent
            // 
            this.tabStudent.Controls.Add(this.managePanel);
            this.tabStudent.Controls.Add(this.btnUpdateDetail);
            this.tabStudent.Controls.Add(this.btnDeleteStudent);
            this.tabStudent.Controls.Add(this.btnBack1);
            this.tabStudent.HorizontalScrollbarBarColor = true;
            this.tabStudent.HorizontalScrollbarHighlightOnWheel = false;
            this.tabStudent.HorizontalScrollbarSize = 10;
            this.tabStudent.Location = new System.Drawing.Point(4, 38);
            this.tabStudent.Name = "tabStudent";
            this.tabStudent.Size = new System.Drawing.Size(746, 343);
            this.tabStudent.TabIndex = 1;
            this.tabStudent.Text = "Manage Student";
            this.tabStudent.VerticalScrollbarBarColor = true;
            this.tabStudent.VerticalScrollbarHighlightOnWheel = false;
            this.tabStudent.VerticalScrollbarSize = 10;
            // 
            // managePanel
            // 
            this.managePanel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.managePanel.Controls.Add(this.SearchStudentID);
            this.managePanel.Controls.Add(this.txtSearchStudentID);
            this.managePanel.Controls.Add(this.btnSeachStudentID);
            this.managePanel.Controls.Add(this.gvStudentDetails);
            this.managePanel.HorizontalScrollbarBarColor = true;
            this.managePanel.HorizontalScrollbarHighlightOnWheel = false;
            this.managePanel.HorizontalScrollbarSize = 10;
            this.managePanel.Location = new System.Drawing.Point(3, 3);
            this.managePanel.Name = "managePanel";
            this.managePanel.Size = new System.Drawing.Size(740, 295);
            this.managePanel.TabIndex = 22;
            this.managePanel.VerticalScrollbarBarColor = true;
            this.managePanel.VerticalScrollbarHighlightOnWheel = false;
            this.managePanel.VerticalScrollbarSize = 10;
            // 
            // SearchStudentID
            // 
            this.SearchStudentID.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.SearchStudentID.AutoSize = true;
            this.SearchStudentID.Location = new System.Drawing.Point(92, 24);
            this.SearchStudentID.Name = "SearchStudentID";
            this.SearchStudentID.Size = new System.Drawing.Size(99, 19);
            this.SearchStudentID.TabIndex = 2;
            this.SearchStudentID.Text = "Search Student:";
            // 
            // txtSearchStudentID
            // 
            this.txtSearchStudentID.Anchor = System.Windows.Forms.AnchorStyles.Top;
            // 
            // 
            // 
            this.txtSearchStudentID.CustomButton.Image = null;
            this.txtSearchStudentID.CustomButton.Location = new System.Drawing.Point(299, 1);
            this.txtSearchStudentID.CustomButton.Name = "";
            this.txtSearchStudentID.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtSearchStudentID.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtSearchStudentID.CustomButton.TabIndex = 1;
            this.txtSearchStudentID.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtSearchStudentID.CustomButton.UseSelectable = true;
            this.txtSearchStudentID.CustomButton.Visible = false;
            this.txtSearchStudentID.Lines = new string[0];
            this.txtSearchStudentID.Location = new System.Drawing.Point(206, 22);
            this.txtSearchStudentID.MaxLength = 32767;
            this.txtSearchStudentID.Name = "txtSearchStudentID";
            this.txtSearchStudentID.PasswordChar = '\0';
            this.txtSearchStudentID.PromptText = "Enter Student ID";
            this.txtSearchStudentID.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtSearchStudentID.SelectedText = "";
            this.txtSearchStudentID.SelectionLength = 0;
            this.txtSearchStudentID.SelectionStart = 0;
            this.txtSearchStudentID.ShortcutsEnabled = true;
            this.txtSearchStudentID.Size = new System.Drawing.Size(321, 23);
            this.txtSearchStudentID.TabIndex = 1;
            this.txtSearchStudentID.UseSelectable = true;
            this.txtSearchStudentID.WaterMark = "Enter Student ID";
            this.txtSearchStudentID.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtSearchStudentID.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // btnSeachStudentID
            // 
            this.btnSeachStudentID.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnSeachStudentID.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.btnSeachStudentID.FontSize = MetroFramework.MetroButtonSize.Medium;
            this.btnSeachStudentID.FontWeight = MetroFramework.MetroButtonWeight.Regular;
            this.btnSeachStudentID.ForeColor = System.Drawing.Color.White;
            this.btnSeachStudentID.Location = new System.Drawing.Point(561, 15);
            this.btnSeachStudentID.Name = "btnSeachStudentID";
            this.btnSeachStudentID.Size = new System.Drawing.Size(90, 36);
            this.btnSeachStudentID.TabIndex = 2;
            this.btnSeachStudentID.Text = "Search";
            this.btnSeachStudentID.UseCustomBackColor = true;
            this.btnSeachStudentID.UseCustomForeColor = true;
            this.btnSeachStudentID.UseSelectable = true;
            this.btnSeachStudentID.Click += new System.EventHandler(this.btnSeachStudentID_Click);
            // 
            // gvStudentDetails
            // 
            this.gvStudentDetails.AllowUserToAddRows = false;
            this.gvStudentDetails.AllowUserToDeleteRows = false;
            this.gvStudentDetails.AllowUserToResizeRows = false;
            this.gvStudentDetails.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gvStudentDetails.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.gvStudentDetails.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gvStudentDetails.Location = new System.Drawing.Point(3, 65);
            this.gvStudentDetails.Name = "gvStudentDetails";
            this.gvStudentDetails.ReadOnly = true;
            this.gvStudentDetails.RowHeadersVisible = false;
            this.gvStudentDetails.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.gvStudentDetails.Size = new System.Drawing.Size(734, 227);
            this.gvStudentDetails.TabIndex = 18;
            this.gvStudentDetails.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.gvStudentDetails_CellClick);
            // 
            // btnUpdateDetail
            // 
            this.btnUpdateDetail.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btnUpdateDetail.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.btnUpdateDetail.FontSize = MetroFramework.MetroButtonSize.Medium;
            this.btnUpdateDetail.FontWeight = MetroFramework.MetroButtonWeight.Regular;
            this.btnUpdateDetail.ForeColor = System.Drawing.Color.White;
            this.btnUpdateDetail.Location = new System.Drawing.Point(462, 304);
            this.btnUpdateDetail.Name = "btnUpdateDetail";
            this.btnUpdateDetail.Size = new System.Drawing.Size(90, 36);
            this.btnUpdateDetail.TabIndex = 5;
            this.btnUpdateDetail.Text = "Update";
            this.btnUpdateDetail.UseCustomBackColor = true;
            this.btnUpdateDetail.UseCustomForeColor = true;
            this.btnUpdateDetail.UseSelectable = true;
            this.btnUpdateDetail.Click += new System.EventHandler(this.btnUpdateDetail_Click);
            // 
            // btnDeleteStudent
            // 
            this.btnDeleteStudent.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btnDeleteStudent.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.btnDeleteStudent.FontSize = MetroFramework.MetroButtonSize.Medium;
            this.btnDeleteStudent.FontWeight = MetroFramework.MetroButtonWeight.Regular;
            this.btnDeleteStudent.ForeColor = System.Drawing.Color.White;
            this.btnDeleteStudent.Location = new System.Drawing.Point(328, 304);
            this.btnDeleteStudent.Name = "btnDeleteStudent";
            this.btnDeleteStudent.Size = new System.Drawing.Size(90, 36);
            this.btnDeleteStudent.TabIndex = 4;
            this.btnDeleteStudent.Text = "Delete";
            this.btnDeleteStudent.UseCustomBackColor = true;
            this.btnDeleteStudent.UseCustomForeColor = true;
            this.btnDeleteStudent.UseSelectable = true;
            this.btnDeleteStudent.Click += new System.EventHandler(this.btnDeleteStudent_Click);
            // 
            // btnBack1
            // 
            this.btnBack1.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btnBack1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.btnBack1.FontSize = MetroFramework.MetroButtonSize.Medium;
            this.btnBack1.FontWeight = MetroFramework.MetroButtonWeight.Regular;
            this.btnBack1.ForeColor = System.Drawing.Color.White;
            this.btnBack1.Location = new System.Drawing.Point(194, 304);
            this.btnBack1.Name = "btnBack1";
            this.btnBack1.Size = new System.Drawing.Size(90, 36);
            this.btnBack1.TabIndex = 3;
            this.btnBack1.Text = "Back";
            this.btnBack1.UseCustomBackColor = true;
            this.btnBack1.UseCustomForeColor = true;
            this.btnBack1.UseSelectable = true;
            this.btnBack1.Click += new System.EventHandler(this.btnBack1_Click);
            // 
            // tabStudentRercord
            // 
            this.tabStudentRercord.Controls.Add(this.btnAllRecord);
            this.tabStudentRercord.Controls.Add(this.bntBack2);
            this.tabStudentRercord.Controls.Add(this.studentRecordPanel);
            this.tabStudentRercord.HorizontalScrollbarBarColor = true;
            this.tabStudentRercord.HorizontalScrollbarHighlightOnWheel = false;
            this.tabStudentRercord.HorizontalScrollbarSize = 10;
            this.tabStudentRercord.Location = new System.Drawing.Point(4, 38);
            this.tabStudentRercord.Name = "tabStudentRercord";
            this.tabStudentRercord.Size = new System.Drawing.Size(746, 343);
            this.tabStudentRercord.TabIndex = 2;
            this.tabStudentRercord.Text = "Student Record";
            this.tabStudentRercord.VerticalScrollbarBarColor = true;
            this.tabStudentRercord.VerticalScrollbarHighlightOnWheel = false;
            this.tabStudentRercord.VerticalScrollbarSize = 10;
            // 
            // btnAllRecord
            // 
            this.btnAllRecord.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btnAllRecord.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.btnAllRecord.FontSize = MetroFramework.MetroButtonSize.Medium;
            this.btnAllRecord.FontWeight = MetroFramework.MetroButtonWeight.Regular;
            this.btnAllRecord.ForeColor = System.Drawing.Color.White;
            this.btnAllRecord.Location = new System.Drawing.Point(396, 304);
            this.btnAllRecord.Name = "btnAllRecord";
            this.btnAllRecord.Size = new System.Drawing.Size(90, 36);
            this.btnAllRecord.TabIndex = 3;
            this.btnAllRecord.Text = "All Record";
            this.btnAllRecord.UseCustomBackColor = true;
            this.btnAllRecord.UseCustomForeColor = true;
            this.btnAllRecord.UseSelectable = true;
            this.btnAllRecord.Click += new System.EventHandler(this.btnAllRecord_Click);
            // 
            // bntBack2
            // 
            this.bntBack2.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.bntBack2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.bntBack2.FontSize = MetroFramework.MetroButtonSize.Medium;
            this.bntBack2.FontWeight = MetroFramework.MetroButtonWeight.Regular;
            this.bntBack2.ForeColor = System.Drawing.Color.White;
            this.bntBack2.Location = new System.Drawing.Point(262, 303);
            this.bntBack2.Name = "bntBack2";
            this.bntBack2.Size = new System.Drawing.Size(90, 36);
            this.bntBack2.TabIndex = 4;
            this.bntBack2.Text = "Back";
            this.bntBack2.UseCustomBackColor = true;
            this.bntBack2.UseCustomForeColor = true;
            this.bntBack2.UseSelectable = true;
            this.bntBack2.Click += new System.EventHandler(this.bntBack2_Click);
            // 
            // studentRecordPanel
            // 
            this.studentRecordPanel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.studentRecordPanel.Controls.Add(this.seachProgram);
            this.studentRecordPanel.Controls.Add(this.txtSeachProgram);
            this.studentRecordPanel.Controls.Add(this.btnSeachRecord);
            this.studentRecordPanel.Controls.Add(this.gvRecordProgram);
            this.studentRecordPanel.HorizontalScrollbarBarColor = true;
            this.studentRecordPanel.HorizontalScrollbarHighlightOnWheel = false;
            this.studentRecordPanel.HorizontalScrollbarSize = 10;
            this.studentRecordPanel.Location = new System.Drawing.Point(3, 3);
            this.studentRecordPanel.Name = "studentRecordPanel";
            this.studentRecordPanel.Size = new System.Drawing.Size(740, 295);
            this.studentRecordPanel.TabIndex = 23;
            this.studentRecordPanel.VerticalScrollbarBarColor = true;
            this.studentRecordPanel.VerticalScrollbarHighlightOnWheel = false;
            this.studentRecordPanel.VerticalScrollbarSize = 10;
            // 
            // seachProgram
            // 
            this.seachProgram.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.seachProgram.AutoSize = true;
            this.seachProgram.Location = new System.Drawing.Point(92, 24);
            this.seachProgram.Name = "seachProgram";
            this.seachProgram.Size = new System.Drawing.Size(108, 19);
            this.seachProgram.TabIndex = 20;
            this.seachProgram.Text = "Search Program:";
            // 
            // txtSeachProgram
            // 
            this.txtSeachProgram.Anchor = System.Windows.Forms.AnchorStyles.Top;
            // 
            // 
            // 
            this.txtSeachProgram.CustomButton.Image = null;
            this.txtSeachProgram.CustomButton.Location = new System.Drawing.Point(299, 1);
            this.txtSeachProgram.CustomButton.Name = "";
            this.txtSeachProgram.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtSeachProgram.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtSeachProgram.CustomButton.TabIndex = 1;
            this.txtSeachProgram.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtSeachProgram.CustomButton.UseSelectable = true;
            this.txtSeachProgram.CustomButton.Visible = false;
            this.txtSeachProgram.Lines = new string[0];
            this.txtSeachProgram.Location = new System.Drawing.Point(206, 22);
            this.txtSeachProgram.MaxLength = 32767;
            this.txtSeachProgram.Name = "txtSeachProgram";
            this.txtSeachProgram.PasswordChar = '\0';
            this.txtSeachProgram.PromptText = "Enter Program Name";
            this.txtSeachProgram.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtSeachProgram.SelectedText = "";
            this.txtSeachProgram.SelectionLength = 0;
            this.txtSeachProgram.SelectionStart = 0;
            this.txtSeachProgram.ShortcutsEnabled = true;
            this.txtSeachProgram.Size = new System.Drawing.Size(321, 23);
            this.txtSeachProgram.TabIndex = 1;
            this.txtSeachProgram.UseSelectable = true;
            this.txtSeachProgram.WaterMark = "Enter Program Name";
            this.txtSeachProgram.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtSeachProgram.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // btnSeachRecord
            // 
            this.btnSeachRecord.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnSeachRecord.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.btnSeachRecord.FontSize = MetroFramework.MetroButtonSize.Medium;
            this.btnSeachRecord.FontWeight = MetroFramework.MetroButtonWeight.Regular;
            this.btnSeachRecord.ForeColor = System.Drawing.Color.White;
            this.btnSeachRecord.Location = new System.Drawing.Point(561, 15);
            this.btnSeachRecord.Name = "btnSeachRecord";
            this.btnSeachRecord.Size = new System.Drawing.Size(90, 36);
            this.btnSeachRecord.TabIndex = 2;
            this.btnSeachRecord.Text = "Search";
            this.btnSeachRecord.UseCustomBackColor = true;
            this.btnSeachRecord.UseCustomForeColor = true;
            this.btnSeachRecord.UseSelectable = true;
            this.btnSeachRecord.Click += new System.EventHandler(this.btnSeachRecord_Click);
            // 
            // gvRecordProgram
            // 
            this.gvRecordProgram.AllowUserToAddRows = false;
            this.gvRecordProgram.AllowUserToDeleteRows = false;
            this.gvRecordProgram.AllowUserToResizeRows = false;
            this.gvRecordProgram.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gvRecordProgram.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.gvRecordProgram.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gvRecordProgram.Location = new System.Drawing.Point(3, 65);
            this.gvRecordProgram.Name = "gvRecordProgram";
            this.gvRecordProgram.ReadOnly = true;
            this.gvRecordProgram.RowHeadersVisible = false;
            this.gvRecordProgram.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.gvRecordProgram.Size = new System.Drawing.Size(734, 227);
            this.gvRecordProgram.TabIndex = 18;
            // 
            // ManageStudentForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 471);
            this.Controls.Add(this.tabManageStudent);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "ManageStudentForm";
            this.Text = "Manage Student";
            this.Load += new System.EventHandler(this.ManageStudentForm_Load);
            this.tabManageStudent.ResumeLayout(false);
            this.tabAddStudent.ResumeLayout(false);
            this.addStudentPanel.ResumeLayout(false);
            this.addStudentPanel.PerformLayout();
            this.tabStudent.ResumeLayout(false);
            this.managePanel.ResumeLayout(false);
            this.managePanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gvStudentDetails)).EndInit();
            this.tabStudentRercord.ResumeLayout(false);
            this.studentRecordPanel.ResumeLayout(false);
            this.studentRecordPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gvRecordProgram)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private MetroFramework.Controls.MetroTabControl tabManageStudent;
        private MetroFramework.Controls.MetroTabPage tabAddStudent;
        private MetroFramework.Controls.MetroTabPage tabStudent;
        private MetroFramework.Controls.MetroTabPage tabStudentRercord;
        private MetroFramework.Controls.MetroTextBox txtPassword;
        private MetroFramework.Controls.MetroLabel Password;
        private MetroFramework.Controls.MetroTextBox txtStudentEmail;
        private MetroFramework.Controls.MetroLabel Email;
        private MetroFramework.Controls.MetroTextBox txtPhoneNo;
        private MetroFramework.Controls.MetroLabel PhoneNo;
        private MetroFramework.Controls.MetroTextBox txtStudentName;
        private MetroFramework.Controls.MetroLabel StudentID;
        private MetroFramework.Controls.MetroLabel Program;
        private MetroFramework.Controls.MetroComboBox cbStudentProgram;
        private MetroFramework.Controls.MetroLabel Gender;
        private MetroFramework.Controls.MetroComboBox cbStudentGender;
        private MetroFramework.Controls.MetroTextBox txtStudentID;
        private MetroFramework.Controls.MetroLabel StudentName;
        private MetroFramework.Controls.MetroButton btnNewRecord;
        private MetroFramework.Controls.MetroButton btnSave;
        private MetroFramework.Controls.MetroButton btnBack0;
        private MetroFramework.Controls.MetroPanel addStudentPanel;
        private System.Windows.Forms.DataGridView gvStudentDetails;
        private MetroFramework.Controls.MetroButton btnSeachStudentID;
        private MetroFramework.Controls.MetroTextBox txtSearchStudentID;
        private MetroFramework.Controls.MetroLabel SearchStudentID;
        private MetroFramework.Controls.MetroButton btnUpdateDetail;
        private MetroFramework.Controls.MetroButton btnDeleteStudent;
        private MetroFramework.Controls.MetroButton btnBack1;
        private MetroFramework.Controls.MetroPanel managePanel;
        private MetroFramework.Controls.MetroPanel studentRecordPanel;
        private MetroFramework.Controls.MetroButton btnSeachRecord;
        private System.Windows.Forms.DataGridView gvRecordProgram;
        private MetroFramework.Controls.MetroLabel seachProgram;
        private MetroFramework.Controls.MetroTextBox txtSeachProgram;
        private MetroFramework.Controls.MetroButton btnAllRecord;
        private MetroFramework.Controls.MetroButton bntBack2;
    }
}