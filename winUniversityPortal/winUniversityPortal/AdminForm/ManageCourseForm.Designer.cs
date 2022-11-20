
namespace winUniversityPortal.AdminForm
{
    partial class ManageCourseForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ManageCourseForm));
            this.tabManageCourse = new MetroFramework.Controls.MetroTabControl();
            this.tabAddCourse = new MetroFramework.Controls.MetroTabPage();
            this.addCoursePanel = new MetroFramework.Controls.MetroPanel();
            this.cbTeacherID = new MetroFramework.Controls.MetroComboBox();
            this.TeacherID = new MetroFramework.Controls.MetroLabel();
            this.CourseID = new MetroFramework.Controls.MetroLabel();
            this.CourseName = new MetroFramework.Controls.MetroLabel();
            this.txtCourseID = new MetroFramework.Controls.MetroTextBox();
            this.cbCreditHours = new MetroFramework.Controls.MetroComboBox();
            this.CreditHours = new MetroFramework.Controls.MetroLabel();
            this.cbPrerequisite = new MetroFramework.Controls.MetroComboBox();
            this.Prerequisite = new MetroFramework.Controls.MetroLabel();
            this.txtCourseName = new MetroFramework.Controls.MetroTextBox();
            this.btnBack0 = new MetroFramework.Controls.MetroButton();
            this.btnNewRecord = new MetroFramework.Controls.MetroButton();
            this.btnSave = new MetroFramework.Controls.MetroButton();
            this.tabCourseManage = new MetroFramework.Controls.MetroTabPage();
            this.managePanel = new MetroFramework.Controls.MetroPanel();
            this.SearchCourseID = new MetroFramework.Controls.MetroLabel();
            this.txtSearchCourseID = new MetroFramework.Controls.MetroTextBox();
            this.btnSeachCourseID = new MetroFramework.Controls.MetroButton();
            this.gvCourseDetails = new System.Windows.Forms.DataGridView();
            this.btnDeleteCourse = new MetroFramework.Controls.MetroButton();
            this.btnBack1 = new MetroFramework.Controls.MetroButton();
            this.btnUpdateCourse = new MetroFramework.Controls.MetroButton();
            this.tabCourseRecord = new MetroFramework.Controls.MetroTabPage();
            this.btnAllRecord = new MetroFramework.Controls.MetroButton();
            this.CourseRecordPanel = new MetroFramework.Controls.MetroPanel();
            this.SearchCourse = new MetroFramework.Controls.MetroLabel();
            this.txtCourseRecord = new MetroFramework.Controls.MetroTextBox();
            this.btnCourseRecord = new MetroFramework.Controls.MetroButton();
            this.gvRecordCourse = new System.Windows.Forms.DataGridView();
            this.btnBack2 = new MetroFramework.Controls.MetroButton();
            this.tabManageCourse.SuspendLayout();
            this.tabAddCourse.SuspendLayout();
            this.addCoursePanel.SuspendLayout();
            this.tabCourseManage.SuspendLayout();
            this.managePanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gvCourseDetails)).BeginInit();
            this.tabCourseRecord.SuspendLayout();
            this.CourseRecordPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gvRecordCourse)).BeginInit();
            this.SuspendLayout();
            // 
            // tabManageCourse
            // 
            this.tabManageCourse.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tabManageCourse.Controls.Add(this.tabAddCourse);
            this.tabManageCourse.Controls.Add(this.tabCourseManage);
            this.tabManageCourse.Controls.Add(this.tabCourseRecord);
            this.tabManageCourse.Location = new System.Drawing.Point(23, 63);
            this.tabManageCourse.Name = "tabManageCourse";
            this.tabManageCourse.SelectedIndex = 2;
            this.tabManageCourse.Size = new System.Drawing.Size(754, 385);
            this.tabManageCourse.TabIndex = 1;
            this.tabManageCourse.UseSelectable = true;
            // 
            // tabAddCourse
            // 
            this.tabAddCourse.Controls.Add(this.addCoursePanel);
            this.tabAddCourse.Controls.Add(this.btnBack0);
            this.tabAddCourse.Controls.Add(this.btnNewRecord);
            this.tabAddCourse.Controls.Add(this.btnSave);
            this.tabAddCourse.HorizontalScrollbarBarColor = true;
            this.tabAddCourse.HorizontalScrollbarHighlightOnWheel = false;
            this.tabAddCourse.HorizontalScrollbarSize = 10;
            this.tabAddCourse.Location = new System.Drawing.Point(4, 38);
            this.tabAddCourse.Name = "tabAddCourse";
            this.tabAddCourse.Size = new System.Drawing.Size(746, 343);
            this.tabAddCourse.TabIndex = 0;
            this.tabAddCourse.Text = "Add Course";
            this.tabAddCourse.VerticalScrollbarBarColor = true;
            this.tabAddCourse.VerticalScrollbarHighlightOnWheel = false;
            this.tabAddCourse.VerticalScrollbarSize = 10;
            // 
            // addCoursePanel
            // 
            this.addCoursePanel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.addCoursePanel.Controls.Add(this.cbTeacherID);
            this.addCoursePanel.Controls.Add(this.TeacherID);
            this.addCoursePanel.Controls.Add(this.CourseID);
            this.addCoursePanel.Controls.Add(this.CourseName);
            this.addCoursePanel.Controls.Add(this.txtCourseID);
            this.addCoursePanel.Controls.Add(this.cbCreditHours);
            this.addCoursePanel.Controls.Add(this.CreditHours);
            this.addCoursePanel.Controls.Add(this.cbPrerequisite);
            this.addCoursePanel.Controls.Add(this.Prerequisite);
            this.addCoursePanel.Controls.Add(this.txtCourseName);
            this.addCoursePanel.HorizontalScrollbarBarColor = true;
            this.addCoursePanel.HorizontalScrollbarHighlightOnWheel = false;
            this.addCoursePanel.HorizontalScrollbarSize = 10;
            this.addCoursePanel.Location = new System.Drawing.Point(52, 77);
            this.addCoursePanel.Name = "addCoursePanel";
            this.addCoursePanel.Size = new System.Drawing.Size(645, 153);
            this.addCoursePanel.TabIndex = 18;
            this.addCoursePanel.VerticalScrollbarBarColor = true;
            this.addCoursePanel.VerticalScrollbarHighlightOnWheel = false;
            this.addCoursePanel.VerticalScrollbarSize = 10;
            // 
            // cbTeacherID
            // 
            this.cbTeacherID.FormattingEnabled = true;
            this.cbTeacherID.ItemHeight = 23;
            this.cbTeacherID.Location = new System.Drawing.Point(283, 109);
            this.cbTeacherID.Name = "cbTeacherID";
            this.cbTeacherID.PromptText = "Select Teacher ID";
            this.cbTeacherID.Size = new System.Drawing.Size(190, 29);
            this.cbTeacherID.TabIndex = 5;
            this.cbTeacherID.UseSelectable = true;
            // 
            // TeacherID
            // 
            this.TeacherID.AutoSize = true;
            this.TeacherID.Location = new System.Drawing.Point(180, 114);
            this.TeacherID.Name = "TeacherID";
            this.TeacherID.Size = new System.Drawing.Size(72, 19);
            this.TeacherID.TabIndex = 10;
            this.TeacherID.Text = "Teacher ID:";
            // 
            // CourseID
            // 
            this.CourseID.AutoSize = true;
            this.CourseID.Location = new System.Drawing.Point(3, 16);
            this.CourseID.Name = "CourseID";
            this.CourseID.Size = new System.Drawing.Size(69, 19);
            this.CourseID.TabIndex = 8;
            this.CourseID.Text = "Course ID:";
            // 
            // CourseName
            // 
            this.CourseName.AutoSize = true;
            this.CourseName.Location = new System.Drawing.Point(337, 16);
            this.CourseName.Name = "CourseName";
            this.CourseName.Size = new System.Drawing.Size(93, 19);
            this.CourseName.TabIndex = 2;
            this.CourseName.Text = "Course Name:";
            // 
            // txtCourseID
            // 
            // 
            // 
            // 
            this.txtCourseID.CustomButton.Image = null;
            this.txtCourseID.CustomButton.Location = new System.Drawing.Point(168, 1);
            this.txtCourseID.CustomButton.Name = "";
            this.txtCourseID.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtCourseID.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtCourseID.CustomButton.TabIndex = 1;
            this.txtCourseID.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtCourseID.CustomButton.UseSelectable = true;
            this.txtCourseID.CustomButton.Visible = false;
            this.txtCourseID.Lines = new string[0];
            this.txtCourseID.Location = new System.Drawing.Point(114, 15);
            this.txtCourseID.MaxLength = 32767;
            this.txtCourseID.Name = "txtCourseID";
            this.txtCourseID.PasswordChar = '\0';
            this.txtCourseID.PromptText = "Enter Course ID";
            this.txtCourseID.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtCourseID.SelectedText = "";
            this.txtCourseID.SelectionLength = 0;
            this.txtCourseID.SelectionStart = 0;
            this.txtCourseID.ShortcutsEnabled = true;
            this.txtCourseID.Size = new System.Drawing.Size(190, 23);
            this.txtCourseID.TabIndex = 1;
            this.txtCourseID.UseSelectable = true;
            this.txtCourseID.WaterMark = "Enter Course ID";
            this.txtCourseID.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtCourseID.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // cbCreditHours
            // 
            this.cbCreditHours.FormattingEnabled = true;
            this.cbCreditHours.ItemHeight = 23;
            this.cbCreditHours.Items.AddRange(new object[] {
            "3",
            "1",
            "0"});
            this.cbCreditHours.Location = new System.Drawing.Point(113, 55);
            this.cbCreditHours.Name = "cbCreditHours";
            this.cbCreditHours.PromptText = "Select Credit Hours";
            this.cbCreditHours.Size = new System.Drawing.Size(190, 29);
            this.cbCreditHours.TabIndex = 3;
            this.cbCreditHours.UseSelectable = true;
            // 
            // CreditHours
            // 
            this.CreditHours.AutoSize = true;
            this.CreditHours.Location = new System.Drawing.Point(3, 59);
            this.CreditHours.Name = "CreditHours";
            this.CreditHours.Size = new System.Drawing.Size(83, 19);
            this.CreditHours.TabIndex = 5;
            this.CreditHours.Text = "Credit Hours";
            // 
            // cbPrerequisite
            // 
            this.cbPrerequisite.FormattingEnabled = true;
            this.cbPrerequisite.ItemHeight = 23;
            this.cbPrerequisite.Location = new System.Drawing.Point(452, 54);
            this.cbPrerequisite.Name = "cbPrerequisite";
            this.cbPrerequisite.PromptText = "Select Prerequisite Course";
            this.cbPrerequisite.Size = new System.Drawing.Size(190, 29);
            this.cbPrerequisite.TabIndex = 4;
            this.cbPrerequisite.UseSelectable = true;
            // 
            // Prerequisite
            // 
            this.Prerequisite.AutoSize = true;
            this.Prerequisite.Location = new System.Drawing.Point(337, 59);
            this.Prerequisite.Name = "Prerequisite";
            this.Prerequisite.Size = new System.Drawing.Size(81, 19);
            this.Prerequisite.TabIndex = 7;
            this.Prerequisite.Text = "Prerequisite:";
            // 
            // txtCourseName
            // 
            // 
            // 
            // 
            this.txtCourseName.CustomButton.Image = null;
            this.txtCourseName.CustomButton.Location = new System.Drawing.Point(168, 1);
            this.txtCourseName.CustomButton.Name = "";
            this.txtCourseName.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtCourseName.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtCourseName.CustomButton.TabIndex = 1;
            this.txtCourseName.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtCourseName.CustomButton.UseSelectable = true;
            this.txtCourseName.CustomButton.Visible = false;
            this.txtCourseName.Lines = new string[0];
            this.txtCourseName.Location = new System.Drawing.Point(452, 14);
            this.txtCourseName.MaxLength = 32767;
            this.txtCourseName.Name = "txtCourseName";
            this.txtCourseName.PasswordChar = '\0';
            this.txtCourseName.PromptText = "Enter Course Name";
            this.txtCourseName.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtCourseName.SelectedText = "";
            this.txtCourseName.SelectionLength = 0;
            this.txtCourseName.SelectionStart = 0;
            this.txtCourseName.ShortcutsEnabled = true;
            this.txtCourseName.Size = new System.Drawing.Size(190, 23);
            this.txtCourseName.TabIndex = 2;
            this.txtCourseName.UseSelectable = true;
            this.txtCourseName.WaterMark = "Enter Course Name";
            this.txtCourseName.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtCourseName.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
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
            this.btnBack0.TabIndex = 8;
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
            this.btnNewRecord.TabIndex = 7;
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
            this.btnSave.TabIndex = 6;
            this.btnSave.Text = "Save";
            this.btnSave.UseCustomBackColor = true;
            this.btnSave.UseCustomForeColor = true;
            this.btnSave.UseSelectable = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // tabCourseManage
            // 
            this.tabCourseManage.Controls.Add(this.btnUpdateCourse);
            this.tabCourseManage.Controls.Add(this.managePanel);
            this.tabCourseManage.Controls.Add(this.btnDeleteCourse);
            this.tabCourseManage.Controls.Add(this.btnBack1);
            this.tabCourseManage.HorizontalScrollbarBarColor = true;
            this.tabCourseManage.HorizontalScrollbarHighlightOnWheel = false;
            this.tabCourseManage.HorizontalScrollbarSize = 10;
            this.tabCourseManage.Location = new System.Drawing.Point(4, 38);
            this.tabCourseManage.Name = "tabCourseManage";
            this.tabCourseManage.Size = new System.Drawing.Size(746, 343);
            this.tabCourseManage.TabIndex = 1;
            this.tabCourseManage.Text = "Manage Course";
            this.tabCourseManage.VerticalScrollbarBarColor = true;
            this.tabCourseManage.VerticalScrollbarHighlightOnWheel = false;
            this.tabCourseManage.VerticalScrollbarSize = 10;
            // 
            // managePanel
            // 
            this.managePanel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.managePanel.Controls.Add(this.SearchCourseID);
            this.managePanel.Controls.Add(this.txtSearchCourseID);
            this.managePanel.Controls.Add(this.btnSeachCourseID);
            this.managePanel.Controls.Add(this.gvCourseDetails);
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
            // SearchCourseID
            // 
            this.SearchCourseID.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.SearchCourseID.AutoSize = true;
            this.SearchCourseID.Location = new System.Drawing.Point(92, 24);
            this.SearchCourseID.Name = "SearchCourseID";
            this.SearchCourseID.Size = new System.Drawing.Size(96, 19);
            this.SearchCourseID.TabIndex = 2;
            this.SearchCourseID.Text = "Search Course:";
            // 
            // txtSearchCourseID
            // 
            this.txtSearchCourseID.Anchor = System.Windows.Forms.AnchorStyles.Top;
            // 
            // 
            // 
            this.txtSearchCourseID.CustomButton.Image = null;
            this.txtSearchCourseID.CustomButton.Location = new System.Drawing.Point(299, 1);
            this.txtSearchCourseID.CustomButton.Name = "";
            this.txtSearchCourseID.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtSearchCourseID.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtSearchCourseID.CustomButton.TabIndex = 1;
            this.txtSearchCourseID.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtSearchCourseID.CustomButton.UseSelectable = true;
            this.txtSearchCourseID.CustomButton.Visible = false;
            this.txtSearchCourseID.Lines = new string[0];
            this.txtSearchCourseID.Location = new System.Drawing.Point(206, 22);
            this.txtSearchCourseID.MaxLength = 32767;
            this.txtSearchCourseID.Name = "txtSearchCourseID";
            this.txtSearchCourseID.PasswordChar = '\0';
            this.txtSearchCourseID.PromptText = "Enter Course ID";
            this.txtSearchCourseID.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtSearchCourseID.SelectedText = "";
            this.txtSearchCourseID.SelectionLength = 0;
            this.txtSearchCourseID.SelectionStart = 0;
            this.txtSearchCourseID.ShortcutsEnabled = true;
            this.txtSearchCourseID.Size = new System.Drawing.Size(321, 23);
            this.txtSearchCourseID.TabIndex = 1;
            this.txtSearchCourseID.UseSelectable = true;
            this.txtSearchCourseID.WaterMark = "Enter Course ID";
            this.txtSearchCourseID.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtSearchCourseID.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // btnSeachCourseID
            // 
            this.btnSeachCourseID.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnSeachCourseID.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.btnSeachCourseID.FontSize = MetroFramework.MetroButtonSize.Medium;
            this.btnSeachCourseID.FontWeight = MetroFramework.MetroButtonWeight.Regular;
            this.btnSeachCourseID.ForeColor = System.Drawing.Color.White;
            this.btnSeachCourseID.Location = new System.Drawing.Point(561, 15);
            this.btnSeachCourseID.Name = "btnSeachCourseID";
            this.btnSeachCourseID.Size = new System.Drawing.Size(90, 36);
            this.btnSeachCourseID.TabIndex = 2;
            this.btnSeachCourseID.Text = "Search";
            this.btnSeachCourseID.UseCustomBackColor = true;
            this.btnSeachCourseID.UseCustomForeColor = true;
            this.btnSeachCourseID.UseSelectable = true;
            this.btnSeachCourseID.Click += new System.EventHandler(this.btnSeachCourseID_Click);
            // 
            // gvCourseDetails
            // 
            this.gvCourseDetails.AllowUserToAddRows = false;
            this.gvCourseDetails.AllowUserToDeleteRows = false;
            this.gvCourseDetails.AllowUserToResizeRows = false;
            this.gvCourseDetails.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gvCourseDetails.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.gvCourseDetails.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gvCourseDetails.Location = new System.Drawing.Point(3, 65);
            this.gvCourseDetails.Name = "gvCourseDetails";
            this.gvCourseDetails.ReadOnly = true;
            this.gvCourseDetails.RowHeadersVisible = false;
            this.gvCourseDetails.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.gvCourseDetails.Size = new System.Drawing.Size(734, 227);
            this.gvCourseDetails.TabIndex = 18;
            this.gvCourseDetails.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.gvCourseDetails_CellClick);
            // 
            // btnDeleteCourse
            // 
            this.btnDeleteCourse.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btnDeleteCourse.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.btnDeleteCourse.FontSize = MetroFramework.MetroButtonSize.Medium;
            this.btnDeleteCourse.FontWeight = MetroFramework.MetroButtonWeight.Regular;
            this.btnDeleteCourse.ForeColor = System.Drawing.Color.White;
            this.btnDeleteCourse.Location = new System.Drawing.Point(328, 304);
            this.btnDeleteCourse.Name = "btnDeleteCourse";
            this.btnDeleteCourse.Size = new System.Drawing.Size(90, 36);
            this.btnDeleteCourse.TabIndex = 4;
            this.btnDeleteCourse.Text = "Delete";
            this.btnDeleteCourse.UseCustomBackColor = true;
            this.btnDeleteCourse.UseCustomForeColor = true;
            this.btnDeleteCourse.UseSelectable = true;
            this.btnDeleteCourse.Click += new System.EventHandler(this.btnDeleteCourse_Click);
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
            // btnUpdateCourse
            // 
            this.btnUpdateCourse.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btnUpdateCourse.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.btnUpdateCourse.FontSize = MetroFramework.MetroButtonSize.Medium;
            this.btnUpdateCourse.FontWeight = MetroFramework.MetroButtonWeight.Regular;
            this.btnUpdateCourse.ForeColor = System.Drawing.Color.White;
            this.btnUpdateCourse.Location = new System.Drawing.Point(462, 304);
            this.btnUpdateCourse.Name = "btnUpdateCourse";
            this.btnUpdateCourse.Size = new System.Drawing.Size(90, 36);
            this.btnUpdateCourse.TabIndex = 23;
            this.btnUpdateCourse.Text = "Update";
            this.btnUpdateCourse.UseCustomBackColor = true;
            this.btnUpdateCourse.UseCustomForeColor = true;
            this.btnUpdateCourse.UseSelectable = true;
            this.btnUpdateCourse.Click += new System.EventHandler(this.btnUpdateCourse_Click);
            // 
            // tabCourseRecord
            // 
            this.tabCourseRecord.Controls.Add(this.btnAllRecord);
            this.tabCourseRecord.Controls.Add(this.CourseRecordPanel);
            this.tabCourseRecord.Controls.Add(this.btnBack2);
            this.tabCourseRecord.HorizontalScrollbarBarColor = true;
            this.tabCourseRecord.HorizontalScrollbarHighlightOnWheel = false;
            this.tabCourseRecord.HorizontalScrollbarSize = 10;
            this.tabCourseRecord.Location = new System.Drawing.Point(4, 38);
            this.tabCourseRecord.Name = "tabCourseRecord";
            this.tabCourseRecord.Size = new System.Drawing.Size(746, 343);
            this.tabCourseRecord.TabIndex = 2;
            this.tabCourseRecord.Text = "Course Record";
            this.tabCourseRecord.VerticalScrollbarBarColor = true;
            this.tabCourseRecord.VerticalScrollbarHighlightOnWheel = false;
            this.tabCourseRecord.VerticalScrollbarSize = 10;
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
            // CourseRecordPanel
            // 
            this.CourseRecordPanel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.CourseRecordPanel.Controls.Add(this.SearchCourse);
            this.CourseRecordPanel.Controls.Add(this.txtCourseRecord);
            this.CourseRecordPanel.Controls.Add(this.btnCourseRecord);
            this.CourseRecordPanel.Controls.Add(this.gvRecordCourse);
            this.CourseRecordPanel.HorizontalScrollbarBarColor = true;
            this.CourseRecordPanel.HorizontalScrollbarHighlightOnWheel = false;
            this.CourseRecordPanel.HorizontalScrollbarSize = 10;
            this.CourseRecordPanel.Location = new System.Drawing.Point(3, 3);
            this.CourseRecordPanel.Name = "CourseRecordPanel";
            this.CourseRecordPanel.Size = new System.Drawing.Size(740, 295);
            this.CourseRecordPanel.TabIndex = 26;
            this.CourseRecordPanel.VerticalScrollbarBarColor = true;
            this.CourseRecordPanel.VerticalScrollbarHighlightOnWheel = false;
            this.CourseRecordPanel.VerticalScrollbarSize = 10;
            // 
            // SearchCourse
            // 
            this.SearchCourse.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.SearchCourse.AutoSize = true;
            this.SearchCourse.Location = new System.Drawing.Point(92, 24);
            this.SearchCourse.Name = "SearchCourse";
            this.SearchCourse.Size = new System.Drawing.Size(96, 19);
            this.SearchCourse.TabIndex = 2;
            this.SearchCourse.Text = "Search Course:";
            // 
            // txtCourseRecord
            // 
            this.txtCourseRecord.Anchor = System.Windows.Forms.AnchorStyles.Top;
            // 
            // 
            // 
            this.txtCourseRecord.CustomButton.Image = null;
            this.txtCourseRecord.CustomButton.Location = new System.Drawing.Point(299, 1);
            this.txtCourseRecord.CustomButton.Name = "";
            this.txtCourseRecord.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtCourseRecord.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtCourseRecord.CustomButton.TabIndex = 1;
            this.txtCourseRecord.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtCourseRecord.CustomButton.UseSelectable = true;
            this.txtCourseRecord.CustomButton.Visible = false;
            this.txtCourseRecord.Lines = new string[0];
            this.txtCourseRecord.Location = new System.Drawing.Point(206, 22);
            this.txtCourseRecord.MaxLength = 32767;
            this.txtCourseRecord.Name = "txtCourseRecord";
            this.txtCourseRecord.PasswordChar = '\0';
            this.txtCourseRecord.PromptText = "Enter Course ID";
            this.txtCourseRecord.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtCourseRecord.SelectedText = "";
            this.txtCourseRecord.SelectionLength = 0;
            this.txtCourseRecord.SelectionStart = 0;
            this.txtCourseRecord.ShortcutsEnabled = true;
            this.txtCourseRecord.Size = new System.Drawing.Size(321, 23);
            this.txtCourseRecord.TabIndex = 1;
            this.txtCourseRecord.UseSelectable = true;
            this.txtCourseRecord.WaterMark = "Enter Course ID";
            this.txtCourseRecord.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtCourseRecord.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // btnCourseRecord
            // 
            this.btnCourseRecord.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnCourseRecord.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.btnCourseRecord.FontSize = MetroFramework.MetroButtonSize.Medium;
            this.btnCourseRecord.FontWeight = MetroFramework.MetroButtonWeight.Regular;
            this.btnCourseRecord.ForeColor = System.Drawing.Color.White;
            this.btnCourseRecord.Location = new System.Drawing.Point(561, 15);
            this.btnCourseRecord.Name = "btnCourseRecord";
            this.btnCourseRecord.Size = new System.Drawing.Size(90, 36);
            this.btnCourseRecord.TabIndex = 2;
            this.btnCourseRecord.Text = "Search";
            this.btnCourseRecord.UseCustomBackColor = true;
            this.btnCourseRecord.UseCustomForeColor = true;
            this.btnCourseRecord.UseSelectable = true;
            this.btnCourseRecord.Click += new System.EventHandler(this.btnCourseRecord_Click);
            // 
            // gvRecordCourse
            // 
            this.gvRecordCourse.AllowUserToAddRows = false;
            this.gvRecordCourse.AllowUserToDeleteRows = false;
            this.gvRecordCourse.AllowUserToResizeRows = false;
            this.gvRecordCourse.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gvRecordCourse.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.gvRecordCourse.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gvRecordCourse.Location = new System.Drawing.Point(3, 65);
            this.gvRecordCourse.Name = "gvRecordCourse";
            this.gvRecordCourse.ReadOnly = true;
            this.gvRecordCourse.RowHeadersVisible = false;
            this.gvRecordCourse.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.gvRecordCourse.Size = new System.Drawing.Size(734, 227);
            this.gvRecordCourse.TabIndex = 18;
            // 
            // btnBack2
            // 
            this.btnBack2.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btnBack2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.btnBack2.FontSize = MetroFramework.MetroButtonSize.Medium;
            this.btnBack2.FontWeight = MetroFramework.MetroButtonWeight.Regular;
            this.btnBack2.ForeColor = System.Drawing.Color.White;
            this.btnBack2.Location = new System.Drawing.Point(262, 304);
            this.btnBack2.Name = "btnBack2";
            this.btnBack2.Size = new System.Drawing.Size(90, 36);
            this.btnBack2.TabIndex = 4;
            this.btnBack2.Text = "Back";
            this.btnBack2.UseCustomBackColor = true;
            this.btnBack2.UseCustomForeColor = true;
            this.btnBack2.UseSelectable = true;
            this.btnBack2.Click += new System.EventHandler(this.btnBack2_Click);
            // 
            // ManageCourseForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 471);
            this.Controls.Add(this.tabManageCourse);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "ManageCourseForm";
            this.Text = "Manage Course";
            this.Load += new System.EventHandler(this.ManageCourseForm_Load);
            this.tabManageCourse.ResumeLayout(false);
            this.tabAddCourse.ResumeLayout(false);
            this.addCoursePanel.ResumeLayout(false);
            this.addCoursePanel.PerformLayout();
            this.tabCourseManage.ResumeLayout(false);
            this.managePanel.ResumeLayout(false);
            this.managePanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gvCourseDetails)).EndInit();
            this.tabCourseRecord.ResumeLayout(false);
            this.CourseRecordPanel.ResumeLayout(false);
            this.CourseRecordPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gvRecordCourse)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private MetroFramework.Controls.MetroTabControl tabManageCourse;
        private MetroFramework.Controls.MetroTabPage tabAddCourse;
        private MetroFramework.Controls.MetroPanel addCoursePanel;
        private MetroFramework.Controls.MetroLabel CourseID;
        private MetroFramework.Controls.MetroLabel CourseName;
        private MetroFramework.Controls.MetroTextBox txtCourseID;
        private MetroFramework.Controls.MetroComboBox cbCreditHours;
        private MetroFramework.Controls.MetroLabel CreditHours;
        private MetroFramework.Controls.MetroComboBox cbPrerequisite;
        private MetroFramework.Controls.MetroLabel Prerequisite;
        private MetroFramework.Controls.MetroTextBox txtCourseName;
        private MetroFramework.Controls.MetroButton btnBack0;
        private MetroFramework.Controls.MetroButton btnNewRecord;
        private MetroFramework.Controls.MetroButton btnSave;
        private MetroFramework.Controls.MetroTabPage tabCourseManage;
        private MetroFramework.Controls.MetroPanel managePanel;
        private MetroFramework.Controls.MetroLabel SearchCourseID;
        private MetroFramework.Controls.MetroTextBox txtSearchCourseID;
        private MetroFramework.Controls.MetroButton btnSeachCourseID;
        private System.Windows.Forms.DataGridView gvCourseDetails;
        private MetroFramework.Controls.MetroButton btnDeleteCourse;
        private MetroFramework.Controls.MetroButton btnBack1;
        private MetroFramework.Controls.MetroLabel TeacherID;
        private MetroFramework.Controls.MetroComboBox cbTeacherID;
        private MetroFramework.Controls.MetroButton btnUpdateCourse;
        private MetroFramework.Controls.MetroTabPage tabCourseRecord;
        private MetroFramework.Controls.MetroButton btnAllRecord;
        private MetroFramework.Controls.MetroPanel CourseRecordPanel;
        private MetroFramework.Controls.MetroLabel SearchCourse;
        private MetroFramework.Controls.MetroTextBox txtCourseRecord;
        private MetroFramework.Controls.MetroButton btnCourseRecord;
        private System.Windows.Forms.DataGridView gvRecordCourse;
        private MetroFramework.Controls.MetroButton btnBack2;
    }
}