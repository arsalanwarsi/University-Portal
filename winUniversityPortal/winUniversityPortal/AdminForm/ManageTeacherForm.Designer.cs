
namespace winUniversityPortal.AdminForm
{
    partial class ManageTeacherForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ManageTeacherForm));
            this.tabManageTeacher = new MetroFramework.Controls.MetroTabControl();
            this.tabAddTeacher = new MetroFramework.Controls.MetroTabPage();
            this.addTeacherPanel = new MetroFramework.Controls.MetroPanel();
            this.TeacherID = new MetroFramework.Controls.MetroLabel();
            this.TeacherName = new MetroFramework.Controls.MetroLabel();
            this.txtTeacherID = new MetroFramework.Controls.MetroTextBox();
            this.cbTeacherGender = new MetroFramework.Controls.MetroComboBox();
            this.txtPassword = new MetroFramework.Controls.MetroTextBox();
            this.Gender = new MetroFramework.Controls.MetroLabel();
            this.Password = new MetroFramework.Controls.MetroLabel();
            this.cbTeacherDepartment = new MetroFramework.Controls.MetroComboBox();
            this.txtTeacherEmail = new MetroFramework.Controls.MetroTextBox();
            this.Department = new MetroFramework.Controls.MetroLabel();
            this.Email = new MetroFramework.Controls.MetroLabel();
            this.txtTeacherName = new MetroFramework.Controls.MetroTextBox();
            this.txtPhoneNo = new MetroFramework.Controls.MetroTextBox();
            this.PhoneNo = new MetroFramework.Controls.MetroLabel();
            this.btnBack0 = new MetroFramework.Controls.MetroButton();
            this.btnNewRecord = new MetroFramework.Controls.MetroButton();
            this.btnSave = new MetroFramework.Controls.MetroButton();
            this.tabTeacher = new MetroFramework.Controls.MetroTabPage();
            this.managePanel = new MetroFramework.Controls.MetroPanel();
            this.SearchTeacherID = new MetroFramework.Controls.MetroLabel();
            this.txtSearchTeacherID = new MetroFramework.Controls.MetroTextBox();
            this.btnSeachTeacherID = new MetroFramework.Controls.MetroButton();
            this.gvTeacherDetails = new System.Windows.Forms.DataGridView();
            this.btnUpdateDetail = new MetroFramework.Controls.MetroButton();
            this.btnDeleteTeacher = new MetroFramework.Controls.MetroButton();
            this.btnBack1 = new MetroFramework.Controls.MetroButton();
            this.tabTeacherRercord = new MetroFramework.Controls.MetroTabPage();
            this.btnAllRecord = new MetroFramework.Controls.MetroButton();
            this.bntBack2 = new MetroFramework.Controls.MetroButton();
            this.teacherRecordPanel = new MetroFramework.Controls.MetroPanel();
            this.seachDepartment = new MetroFramework.Controls.MetroLabel();
            this.txtSeachDepartment = new MetroFramework.Controls.MetroTextBox();
            this.btnSeachRecord = new MetroFramework.Controls.MetroButton();
            this.gvRecordDepartment = new System.Windows.Forms.DataGridView();
            this.tabManageTeacher.SuspendLayout();
            this.tabAddTeacher.SuspendLayout();
            this.addTeacherPanel.SuspendLayout();
            this.tabTeacher.SuspendLayout();
            this.managePanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gvTeacherDetails)).BeginInit();
            this.tabTeacherRercord.SuspendLayout();
            this.teacherRecordPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gvRecordDepartment)).BeginInit();
            this.SuspendLayout();
            // 
            // tabManageTeacher
            // 
            this.tabManageTeacher.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tabManageTeacher.Controls.Add(this.tabAddTeacher);
            this.tabManageTeacher.Controls.Add(this.tabTeacher);
            this.tabManageTeacher.Controls.Add(this.tabTeacherRercord);
            this.tabManageTeacher.Location = new System.Drawing.Point(23, 63);
            this.tabManageTeacher.Name = "tabManageTeacher";
            this.tabManageTeacher.SelectedIndex = 2;
            this.tabManageTeacher.Size = new System.Drawing.Size(754, 385);
            this.tabManageTeacher.TabIndex = 1;
            this.tabManageTeacher.UseSelectable = true;
            // 
            // tabAddTeacher
            // 
            this.tabAddTeacher.Controls.Add(this.addTeacherPanel);
            this.tabAddTeacher.Controls.Add(this.btnBack0);
            this.tabAddTeacher.Controls.Add(this.btnNewRecord);
            this.tabAddTeacher.Controls.Add(this.btnSave);
            this.tabAddTeacher.HorizontalScrollbarBarColor = true;
            this.tabAddTeacher.HorizontalScrollbarHighlightOnWheel = false;
            this.tabAddTeacher.HorizontalScrollbarSize = 10;
            this.tabAddTeacher.Location = new System.Drawing.Point(4, 38);
            this.tabAddTeacher.Name = "tabAddTeacher";
            this.tabAddTeacher.Size = new System.Drawing.Size(746, 343);
            this.tabAddTeacher.TabIndex = 0;
            this.tabAddTeacher.Text = "Add Teacher";
            this.tabAddTeacher.VerticalScrollbarBarColor = true;
            this.tabAddTeacher.VerticalScrollbarHighlightOnWheel = false;
            this.tabAddTeacher.VerticalScrollbarSize = 10;
            // 
            // addTeacherPanel
            // 
            this.addTeacherPanel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.addTeacherPanel.Controls.Add(this.TeacherID);
            this.addTeacherPanel.Controls.Add(this.TeacherName);
            this.addTeacherPanel.Controls.Add(this.txtTeacherID);
            this.addTeacherPanel.Controls.Add(this.cbTeacherGender);
            this.addTeacherPanel.Controls.Add(this.txtPassword);
            this.addTeacherPanel.Controls.Add(this.Gender);
            this.addTeacherPanel.Controls.Add(this.Password);
            this.addTeacherPanel.Controls.Add(this.cbTeacherDepartment);
            this.addTeacherPanel.Controls.Add(this.txtTeacherEmail);
            this.addTeacherPanel.Controls.Add(this.Department);
            this.addTeacherPanel.Controls.Add(this.Email);
            this.addTeacherPanel.Controls.Add(this.txtTeacherName);
            this.addTeacherPanel.Controls.Add(this.txtPhoneNo);
            this.addTeacherPanel.Controls.Add(this.PhoneNo);
            this.addTeacherPanel.HorizontalScrollbarBarColor = true;
            this.addTeacherPanel.HorizontalScrollbarHighlightOnWheel = false;
            this.addTeacherPanel.HorizontalScrollbarSize = 10;
            this.addTeacherPanel.Location = new System.Drawing.Point(52, 77);
            this.addTeacherPanel.Name = "addTeacherPanel";
            this.addTeacherPanel.Size = new System.Drawing.Size(645, 153);
            this.addTeacherPanel.TabIndex = 18;
            this.addTeacherPanel.VerticalScrollbarBarColor = true;
            this.addTeacherPanel.VerticalScrollbarHighlightOnWheel = false;
            this.addTeacherPanel.VerticalScrollbarSize = 10;
            // 
            // TeacherID
            // 
            this.TeacherID.AutoSize = true;
            this.TeacherID.Location = new System.Drawing.Point(3, 4);
            this.TeacherID.Name = "TeacherID";
            this.TeacherID.Size = new System.Drawing.Size(72, 19);
            this.TeacherID.TabIndex = 8;
            this.TeacherID.Text = "Teacher ID:";
            // 
            // TeacherName
            // 
            this.TeacherName.AutoSize = true;
            this.TeacherName.Location = new System.Drawing.Point(3, 44);
            this.TeacherName.Name = "TeacherName";
            this.TeacherName.Size = new System.Drawing.Size(102, 19);
            this.TeacherName.TabIndex = 2;
            this.TeacherName.Text = "Teachcer Name:";
            // 
            // txtTeacherID
            // 
            // 
            // 
            // 
            this.txtTeacherID.CustomButton.Image = null;
            this.txtTeacherID.CustomButton.Location = new System.Drawing.Point(168, 1);
            this.txtTeacherID.CustomButton.Name = "";
            this.txtTeacherID.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtTeacherID.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtTeacherID.CustomButton.TabIndex = 1;
            this.txtTeacherID.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtTeacherID.CustomButton.UseSelectable = true;
            this.txtTeacherID.CustomButton.Visible = false;
            this.txtTeacherID.Lines = new string[0];
            this.txtTeacherID.Location = new System.Drawing.Point(118, 3);
            this.txtTeacherID.MaxLength = 32767;
            this.txtTeacherID.Name = "txtTeacherID";
            this.txtTeacherID.PasswordChar = '\0';
            this.txtTeacherID.PromptText = "Enter Teacher ID";
            this.txtTeacherID.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtTeacherID.SelectedText = "";
            this.txtTeacherID.SelectionLength = 0;
            this.txtTeacherID.SelectionStart = 0;
            this.txtTeacherID.ShortcutsEnabled = true;
            this.txtTeacherID.Size = new System.Drawing.Size(190, 23);
            this.txtTeacherID.TabIndex = 1;
            this.txtTeacherID.UseSelectable = true;
            this.txtTeacherID.WaterMark = "Enter Teacher ID";
            this.txtTeacherID.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtTeacherID.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // cbTeacherGender
            // 
            this.cbTeacherGender.FormattingEnabled = true;
            this.cbTeacherGender.ItemHeight = 23;
            this.cbTeacherGender.Items.AddRange(new object[] {
            "Male",
            "Female"});
            this.cbTeacherGender.Location = new System.Drawing.Point(117, 81);
            this.cbTeacherGender.Name = "cbTeacherGender";
            this.cbTeacherGender.PromptText = "Select Gender";
            this.cbTeacherGender.Size = new System.Drawing.Size(190, 29);
            this.cbTeacherGender.TabIndex = 3;
            this.cbTeacherGender.UseSelectable = true;
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
            this.txtPassword.PromptText = "Enter Teacher Password";
            this.txtPassword.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtPassword.SelectedText = "";
            this.txtPassword.SelectionLength = 0;
            this.txtPassword.SelectionStart = 0;
            this.txtPassword.ShortcutsEnabled = true;
            this.txtPassword.Size = new System.Drawing.Size(190, 23);
            this.txtPassword.TabIndex = 7;
            this.txtPassword.UseSelectable = true;
            this.txtPassword.WaterMark = "Enter Teacher Password";
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
            // cbTeacherDepartment
            // 
            this.cbTeacherDepartment.FormattingEnabled = true;
            this.cbTeacherDepartment.ItemHeight = 23;
            this.cbTeacherDepartment.Location = new System.Drawing.Point(452, 42);
            this.cbTeacherDepartment.Name = "cbTeacherDepartment";
            this.cbTeacherDepartment.PromptText = "Select Department";
            this.cbTeacherDepartment.Size = new System.Drawing.Size(190, 29);
            this.cbTeacherDepartment.TabIndex = 6;
            this.cbTeacherDepartment.UseSelectable = true;
            // 
            // txtTeacherEmail
            // 
            // 
            // 
            // 
            this.txtTeacherEmail.CustomButton.Image = null;
            this.txtTeacherEmail.CustomButton.Location = new System.Drawing.Point(168, 1);
            this.txtTeacherEmail.CustomButton.Name = "";
            this.txtTeacherEmail.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtTeacherEmail.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtTeacherEmail.CustomButton.TabIndex = 1;
            this.txtTeacherEmail.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtTeacherEmail.CustomButton.UseSelectable = true;
            this.txtTeacherEmail.CustomButton.Visible = false;
            this.txtTeacherEmail.Lines = new string[0];
            this.txtTeacherEmail.Location = new System.Drawing.Point(117, 126);
            this.txtTeacherEmail.MaxLength = 32767;
            this.txtTeacherEmail.Name = "txtTeacherEmail";
            this.txtTeacherEmail.PasswordChar = '\0';
            this.txtTeacherEmail.PromptText = "Enter Teacher Email";
            this.txtTeacherEmail.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtTeacherEmail.SelectedText = "";
            this.txtTeacherEmail.SelectionLength = 0;
            this.txtTeacherEmail.SelectionStart = 0;
            this.txtTeacherEmail.ShortcutsEnabled = true;
            this.txtTeacherEmail.Size = new System.Drawing.Size(190, 23);
            this.txtTeacherEmail.TabIndex = 4;
            this.txtTeacherEmail.UseSelectable = true;
            this.txtTeacherEmail.WaterMark = "Enter Teacher Email";
            this.txtTeacherEmail.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtTeacherEmail.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // Department
            // 
            this.Department.AutoSize = true;
            this.Department.Location = new System.Drawing.Point(349, 47);
            this.Department.Name = "Department";
            this.Department.Size = new System.Drawing.Size(83, 19);
            this.Department.TabIndex = 7;
            this.Department.Text = "Department:";
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
            // txtTeacherName
            // 
            // 
            // 
            // 
            this.txtTeacherName.CustomButton.Image = null;
            this.txtTeacherName.CustomButton.Location = new System.Drawing.Point(168, 1);
            this.txtTeacherName.CustomButton.Name = "";
            this.txtTeacherName.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtTeacherName.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtTeacherName.CustomButton.TabIndex = 1;
            this.txtTeacherName.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtTeacherName.CustomButton.UseSelectable = true;
            this.txtTeacherName.CustomButton.Visible = false;
            this.txtTeacherName.Lines = new string[0];
            this.txtTeacherName.Location = new System.Drawing.Point(118, 42);
            this.txtTeacherName.MaxLength = 32767;
            this.txtTeacherName.Name = "txtTeacherName";
            this.txtTeacherName.PasswordChar = '\0';
            this.txtTeacherName.PromptText = "Enter Teacher Name";
            this.txtTeacherName.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtTeacherName.SelectedText = "";
            this.txtTeacherName.SelectionLength = 0;
            this.txtTeacherName.SelectionStart = 0;
            this.txtTeacherName.ShortcutsEnabled = true;
            this.txtTeacherName.Size = new System.Drawing.Size(190, 23);
            this.txtTeacherName.TabIndex = 2;
            this.txtTeacherName.UseSelectable = true;
            this.txtTeacherName.WaterMark = "Enter Teacher Name";
            this.txtTeacherName.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtTeacherName.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
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
            // tabTeacher
            // 
            this.tabTeacher.Controls.Add(this.managePanel);
            this.tabTeacher.Controls.Add(this.btnUpdateDetail);
            this.tabTeacher.Controls.Add(this.btnDeleteTeacher);
            this.tabTeacher.Controls.Add(this.btnBack1);
            this.tabTeacher.HorizontalScrollbarBarColor = true;
            this.tabTeacher.HorizontalScrollbarHighlightOnWheel = false;
            this.tabTeacher.HorizontalScrollbarSize = 10;
            this.tabTeacher.Location = new System.Drawing.Point(4, 38);
            this.tabTeacher.Name = "tabTeacher";
            this.tabTeacher.Size = new System.Drawing.Size(746, 343);
            this.tabTeacher.TabIndex = 1;
            this.tabTeacher.Text = "Manage Teacher";
            this.tabTeacher.VerticalScrollbarBarColor = true;
            this.tabTeacher.VerticalScrollbarHighlightOnWheel = false;
            this.tabTeacher.VerticalScrollbarSize = 10;
            // 
            // managePanel
            // 
            this.managePanel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.managePanel.Controls.Add(this.SearchTeacherID);
            this.managePanel.Controls.Add(this.txtSearchTeacherID);
            this.managePanel.Controls.Add(this.btnSeachTeacherID);
            this.managePanel.Controls.Add(this.gvTeacherDetails);
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
            // SearchTeacherID
            // 
            this.SearchTeacherID.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.SearchTeacherID.AutoSize = true;
            this.SearchTeacherID.Location = new System.Drawing.Point(92, 24);
            this.SearchTeacherID.Name = "SearchTeacherID";
            this.SearchTeacherID.Size = new System.Drawing.Size(100, 19);
            this.SearchTeacherID.TabIndex = 2;
            this.SearchTeacherID.Text = "Search Teacher:";
            // 
            // txtSearchTeacherID
            // 
            this.txtSearchTeacherID.Anchor = System.Windows.Forms.AnchorStyles.Top;
            // 
            // 
            // 
            this.txtSearchTeacherID.CustomButton.Image = null;
            this.txtSearchTeacherID.CustomButton.Location = new System.Drawing.Point(299, 1);
            this.txtSearchTeacherID.CustomButton.Name = "";
            this.txtSearchTeacherID.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtSearchTeacherID.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtSearchTeacherID.CustomButton.TabIndex = 1;
            this.txtSearchTeacherID.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtSearchTeacherID.CustomButton.UseSelectable = true;
            this.txtSearchTeacherID.CustomButton.Visible = false;
            this.txtSearchTeacherID.Lines = new string[0];
            this.txtSearchTeacherID.Location = new System.Drawing.Point(206, 22);
            this.txtSearchTeacherID.MaxLength = 32767;
            this.txtSearchTeacherID.Name = "txtSearchTeacherID";
            this.txtSearchTeacherID.PasswordChar = '\0';
            this.txtSearchTeacherID.PromptText = "Enter Teacher ID";
            this.txtSearchTeacherID.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtSearchTeacherID.SelectedText = "";
            this.txtSearchTeacherID.SelectionLength = 0;
            this.txtSearchTeacherID.SelectionStart = 0;
            this.txtSearchTeacherID.ShortcutsEnabled = true;
            this.txtSearchTeacherID.Size = new System.Drawing.Size(321, 23);
            this.txtSearchTeacherID.TabIndex = 1;
            this.txtSearchTeacherID.UseSelectable = true;
            this.txtSearchTeacherID.WaterMark = "Enter Teacher ID";
            this.txtSearchTeacherID.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtSearchTeacherID.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // btnSeachTeacherID
            // 
            this.btnSeachTeacherID.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnSeachTeacherID.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.btnSeachTeacherID.FontSize = MetroFramework.MetroButtonSize.Medium;
            this.btnSeachTeacherID.FontWeight = MetroFramework.MetroButtonWeight.Regular;
            this.btnSeachTeacherID.ForeColor = System.Drawing.Color.White;
            this.btnSeachTeacherID.Location = new System.Drawing.Point(561, 15);
            this.btnSeachTeacherID.Name = "btnSeachTeacherID";
            this.btnSeachTeacherID.Size = new System.Drawing.Size(90, 36);
            this.btnSeachTeacherID.TabIndex = 2;
            this.btnSeachTeacherID.Text = "Search";
            this.btnSeachTeacherID.UseCustomBackColor = true;
            this.btnSeachTeacherID.UseCustomForeColor = true;
            this.btnSeachTeacherID.UseSelectable = true;
            this.btnSeachTeacherID.Click += new System.EventHandler(this.btnSeachTeacherID_Click);
            // 
            // gvTeacherDetails
            // 
            this.gvTeacherDetails.AllowUserToAddRows = false;
            this.gvTeacherDetails.AllowUserToDeleteRows = false;
            this.gvTeacherDetails.AllowUserToResizeRows = false;
            this.gvTeacherDetails.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gvTeacherDetails.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.gvTeacherDetails.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gvTeacherDetails.Location = new System.Drawing.Point(3, 65);
            this.gvTeacherDetails.Name = "gvTeacherDetails";
            this.gvTeacherDetails.ReadOnly = true;
            this.gvTeacherDetails.RowHeadersVisible = false;
            this.gvTeacherDetails.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.gvTeacherDetails.Size = new System.Drawing.Size(734, 227);
            this.gvTeacherDetails.TabIndex = 18;
            this.gvTeacherDetails.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.gvTeacherDetails_CellClick);
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
            // btnDeleteTeacher
            // 
            this.btnDeleteTeacher.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btnDeleteTeacher.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.btnDeleteTeacher.FontSize = MetroFramework.MetroButtonSize.Medium;
            this.btnDeleteTeacher.FontWeight = MetroFramework.MetroButtonWeight.Regular;
            this.btnDeleteTeacher.ForeColor = System.Drawing.Color.White;
            this.btnDeleteTeacher.Location = new System.Drawing.Point(328, 304);
            this.btnDeleteTeacher.Name = "btnDeleteTeacher";
            this.btnDeleteTeacher.Size = new System.Drawing.Size(90, 36);
            this.btnDeleteTeacher.TabIndex = 4;
            this.btnDeleteTeacher.Text = "Delete";
            this.btnDeleteTeacher.UseCustomBackColor = true;
            this.btnDeleteTeacher.UseCustomForeColor = true;
            this.btnDeleteTeacher.UseSelectable = true;
            this.btnDeleteTeacher.Click += new System.EventHandler(this.btnDeleteTeacher_Click);
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
            // tabTeacherRercord
            // 
            this.tabTeacherRercord.Controls.Add(this.btnAllRecord);
            this.tabTeacherRercord.Controls.Add(this.bntBack2);
            this.tabTeacherRercord.Controls.Add(this.teacherRecordPanel);
            this.tabTeacherRercord.HorizontalScrollbarBarColor = true;
            this.tabTeacherRercord.HorizontalScrollbarHighlightOnWheel = false;
            this.tabTeacherRercord.HorizontalScrollbarSize = 10;
            this.tabTeacherRercord.Location = new System.Drawing.Point(4, 38);
            this.tabTeacherRercord.Name = "tabTeacherRercord";
            this.tabTeacherRercord.Size = new System.Drawing.Size(746, 343);
            this.tabTeacherRercord.TabIndex = 2;
            this.tabTeacherRercord.Text = "Teacher Record";
            this.tabTeacherRercord.VerticalScrollbarBarColor = true;
            this.tabTeacherRercord.VerticalScrollbarHighlightOnWheel = false;
            this.tabTeacherRercord.VerticalScrollbarSize = 10;
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
            // teacherRecordPanel
            // 
            this.teacherRecordPanel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.teacherRecordPanel.Controls.Add(this.seachDepartment);
            this.teacherRecordPanel.Controls.Add(this.txtSeachDepartment);
            this.teacherRecordPanel.Controls.Add(this.btnSeachRecord);
            this.teacherRecordPanel.Controls.Add(this.gvRecordDepartment);
            this.teacherRecordPanel.HorizontalScrollbarBarColor = true;
            this.teacherRecordPanel.HorizontalScrollbarHighlightOnWheel = false;
            this.teacherRecordPanel.HorizontalScrollbarSize = 10;
            this.teacherRecordPanel.Location = new System.Drawing.Point(3, 3);
            this.teacherRecordPanel.Name = "teacherRecordPanel";
            this.teacherRecordPanel.Size = new System.Drawing.Size(740, 295);
            this.teacherRecordPanel.TabIndex = 23;
            this.teacherRecordPanel.VerticalScrollbarBarColor = true;
            this.teacherRecordPanel.VerticalScrollbarHighlightOnWheel = false;
            this.teacherRecordPanel.VerticalScrollbarSize = 10;
            // 
            // seachDepartment
            // 
            this.seachDepartment.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.seachDepartment.AutoSize = true;
            this.seachDepartment.Location = new System.Drawing.Point(80, 24);
            this.seachDepartment.Name = "seachDepartment";
            this.seachDepartment.Size = new System.Drawing.Size(126, 19);
            this.seachDepartment.TabIndex = 20;
            this.seachDepartment.Text = "Search Department:";
            // 
            // txtSeachDepartment
            // 
            this.txtSeachDepartment.Anchor = System.Windows.Forms.AnchorStyles.Top;
            // 
            // 
            // 
            this.txtSeachDepartment.CustomButton.Image = null;
            this.txtSeachDepartment.CustomButton.Location = new System.Drawing.Point(299, 1);
            this.txtSeachDepartment.CustomButton.Name = "";
            this.txtSeachDepartment.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtSeachDepartment.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtSeachDepartment.CustomButton.TabIndex = 1;
            this.txtSeachDepartment.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtSeachDepartment.CustomButton.UseSelectable = true;
            this.txtSeachDepartment.CustomButton.Visible = false;
            this.txtSeachDepartment.Lines = new string[0];
            this.txtSeachDepartment.Location = new System.Drawing.Point(218, 22);
            this.txtSeachDepartment.MaxLength = 32767;
            this.txtSeachDepartment.Name = "txtSeachDepartment";
            this.txtSeachDepartment.PasswordChar = '\0';
            this.txtSeachDepartment.PromptText = "Enter Department Number";
            this.txtSeachDepartment.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtSeachDepartment.SelectedText = "";
            this.txtSeachDepartment.SelectionLength = 0;
            this.txtSeachDepartment.SelectionStart = 0;
            this.txtSeachDepartment.ShortcutsEnabled = true;
            this.txtSeachDepartment.Size = new System.Drawing.Size(321, 23);
            this.txtSeachDepartment.TabIndex = 1;
            this.txtSeachDepartment.UseSelectable = true;
            this.txtSeachDepartment.WaterMark = "Enter Department Number";
            this.txtSeachDepartment.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtSeachDepartment.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // btnSeachRecord
            // 
            this.btnSeachRecord.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnSeachRecord.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.btnSeachRecord.FontSize = MetroFramework.MetroButtonSize.Medium;
            this.btnSeachRecord.FontWeight = MetroFramework.MetroButtonWeight.Regular;
            this.btnSeachRecord.ForeColor = System.Drawing.Color.White;
            this.btnSeachRecord.Location = new System.Drawing.Point(568, 15);
            this.btnSeachRecord.Name = "btnSeachRecord";
            this.btnSeachRecord.Size = new System.Drawing.Size(90, 36);
            this.btnSeachRecord.TabIndex = 2;
            this.btnSeachRecord.Text = "Search";
            this.btnSeachRecord.UseCustomBackColor = true;
            this.btnSeachRecord.UseCustomForeColor = true;
            this.btnSeachRecord.UseSelectable = true;
            this.btnSeachRecord.Click += new System.EventHandler(this.btnSeachRecord_Click);
            // 
            // gvRecordDepartment
            // 
            this.gvRecordDepartment.AllowUserToAddRows = false;
            this.gvRecordDepartment.AllowUserToDeleteRows = false;
            this.gvRecordDepartment.AllowUserToResizeRows = false;
            this.gvRecordDepartment.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gvRecordDepartment.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.gvRecordDepartment.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gvRecordDepartment.Location = new System.Drawing.Point(3, 65);
            this.gvRecordDepartment.Name = "gvRecordDepartment";
            this.gvRecordDepartment.ReadOnly = true;
            this.gvRecordDepartment.RowHeadersVisible = false;
            this.gvRecordDepartment.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.gvRecordDepartment.Size = new System.Drawing.Size(734, 227);
            this.gvRecordDepartment.TabIndex = 18;
            // 
            // ManageTeacherForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 471);
            this.Controls.Add(this.tabManageTeacher);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "ManageTeacherForm";
            this.Text = "Manage Teacher";
            this.Load += new System.EventHandler(this.ManageTeacherForm_Load);
            this.tabManageTeacher.ResumeLayout(false);
            this.tabAddTeacher.ResumeLayout(false);
            this.addTeacherPanel.ResumeLayout(false);
            this.addTeacherPanel.PerformLayout();
            this.tabTeacher.ResumeLayout(false);
            this.managePanel.ResumeLayout(false);
            this.managePanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gvTeacherDetails)).EndInit();
            this.tabTeacherRercord.ResumeLayout(false);
            this.teacherRecordPanel.ResumeLayout(false);
            this.teacherRecordPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gvRecordDepartment)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private MetroFramework.Controls.MetroTabControl tabManageTeacher;
        private MetroFramework.Controls.MetroTabPage tabAddTeacher;
        private MetroFramework.Controls.MetroPanel addTeacherPanel;
        private MetroFramework.Controls.MetroLabel TeacherID;
        private MetroFramework.Controls.MetroLabel TeacherName;
        private MetroFramework.Controls.MetroTextBox txtTeacherID;
        private MetroFramework.Controls.MetroComboBox cbTeacherGender;
        private MetroFramework.Controls.MetroTextBox txtPassword;
        private MetroFramework.Controls.MetroLabel Gender;
        private MetroFramework.Controls.MetroLabel Password;
        private MetroFramework.Controls.MetroComboBox cbTeacherDepartment;
        private MetroFramework.Controls.MetroTextBox txtTeacherEmail;
        private MetroFramework.Controls.MetroLabel Department;
        private MetroFramework.Controls.MetroLabel Email;
        private MetroFramework.Controls.MetroTextBox txtTeacherName;
        private MetroFramework.Controls.MetroTextBox txtPhoneNo;
        private MetroFramework.Controls.MetroLabel PhoneNo;
        private MetroFramework.Controls.MetroButton btnBack0;
        private MetroFramework.Controls.MetroButton btnNewRecord;
        private MetroFramework.Controls.MetroButton btnSave;
        private MetroFramework.Controls.MetroTabPage tabTeacher;
        private MetroFramework.Controls.MetroPanel managePanel;
        private MetroFramework.Controls.MetroLabel SearchTeacherID;
        private MetroFramework.Controls.MetroTextBox txtSearchTeacherID;
        private MetroFramework.Controls.MetroButton btnSeachTeacherID;
        private System.Windows.Forms.DataGridView gvTeacherDetails;
        private MetroFramework.Controls.MetroButton btnUpdateDetail;
        private MetroFramework.Controls.MetroButton btnDeleteTeacher;
        private MetroFramework.Controls.MetroButton btnBack1;
        private MetroFramework.Controls.MetroTabPage tabTeacherRercord;
        private MetroFramework.Controls.MetroButton btnAllRecord;
        private MetroFramework.Controls.MetroButton bntBack2;
        private MetroFramework.Controls.MetroPanel teacherRecordPanel;
        private MetroFramework.Controls.MetroLabel seachDepartment;
        private MetroFramework.Controls.MetroTextBox txtSeachDepartment;
        private MetroFramework.Controls.MetroButton btnSeachRecord;
        private System.Windows.Forms.DataGridView gvRecordDepartment;
    }
}