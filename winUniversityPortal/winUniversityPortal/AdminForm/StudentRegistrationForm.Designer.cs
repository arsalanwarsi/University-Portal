
namespace winUniversityPortal.AdminForm
{
    partial class StudentRegistrationForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(StudentRegistrationForm));
            this.search = new MetroFramework.Controls.MetroLabel();
            this.txtStudent = new MetroFramework.Controls.MetroTextBox();
            this.gvRegCourses = new System.Windows.Forms.DataGridView();
            this.btnSaveReg = new MetroFramework.Controls.MetroButton();
            this.btnBack = new MetroFramework.Controls.MetroButton();
            this.txtStudentName = new MetroFramework.Controls.MetroTextBox();
            this.St_ID = new MetroFramework.Controls.MetroLabel();
            this.txtStudentID = new MetroFramework.Controls.MetroTextBox();
            this.St_Name = new MetroFramework.Controls.MetroLabel();
            this.Courses = new MetroFramework.Controls.MetroLabel();
            this.Course = new MetroFramework.Controls.MetroLabel();
            this.gvCourses = new System.Windows.Forms.DataGridView();
            this.btnSelect = new MetroFramework.Controls.MetroButton();
            this.btnAdd = new MetroFramework.Controls.MetroButton();
            this.btnDelete = new MetroFramework.Controls.MetroButton();
            this.metroPanel1 = new MetroFramework.Controls.MetroPanel();
            this.Semester = new MetroFramework.Controls.MetroLabel();
            this.txtSemester = new MetroFramework.Controls.MetroTextBox();
            ((System.ComponentModel.ISupportInitialize)(this.gvRegCourses)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvCourses)).BeginInit();
            this.metroPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // search
            // 
            this.search.AutoSize = true;
            this.search.Location = new System.Drawing.Point(50, 9);
            this.search.Name = "search";
            this.search.Size = new System.Drawing.Size(96, 19);
            this.search.TabIndex = 0;
            this.search.Text = "Student Search";
            // 
            // txtStudent
            // 
            // 
            // 
            // 
            this.txtStudent.CustomButton.Image = null;
            this.txtStudent.CustomButton.Location = new System.Drawing.Point(168, 1);
            this.txtStudent.CustomButton.Name = "";
            this.txtStudent.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtStudent.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtStudent.CustomButton.TabIndex = 1;
            this.txtStudent.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtStudent.CustomButton.UseSelectable = true;
            this.txtStudent.CustomButton.Visible = false;
            this.txtStudent.Lines = new string[0];
            this.txtStudent.Location = new System.Drawing.Point(4, 36);
            this.txtStudent.MaxLength = 32767;
            this.txtStudent.Name = "txtStudent";
            this.txtStudent.PasswordChar = '\0';
            this.txtStudent.PromptText = "Enter Student ID";
            this.txtStudent.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtStudent.SelectedText = "";
            this.txtStudent.SelectionLength = 0;
            this.txtStudent.SelectionStart = 0;
            this.txtStudent.ShortcutsEnabled = true;
            this.txtStudent.Size = new System.Drawing.Size(190, 23);
            this.txtStudent.TabIndex = 1;
            this.txtStudent.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtStudent.UseSelectable = true;
            this.txtStudent.WaterMark = "Enter Student ID";
            this.txtStudent.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtStudent.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // gvRegCourses
            // 
            this.gvRegCourses.AllowUserToAddRows = false;
            this.gvRegCourses.AllowUserToDeleteRows = false;
            this.gvRegCourses.AllowUserToResizeRows = false;
            this.gvRegCourses.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.gvRegCourses.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gvRegCourses.Location = new System.Drawing.Point(601, 110);
            this.gvRegCourses.Name = "gvRegCourses";
            this.gvRegCourses.ReadOnly = true;
            this.gvRegCourses.RowHeadersVisible = false;
            this.gvRegCourses.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.gvRegCourses.Size = new System.Drawing.Size(236, 240);
            this.gvRegCourses.TabIndex = 5;
            this.gvRegCourses.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.gvRegCourses_CellClick);
            // 
            // btnSaveReg
            // 
            this.btnSaveReg.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btnSaveReg.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.btnSaveReg.FontSize = MetroFramework.MetroButtonSize.Medium;
            this.btnSaveReg.FontWeight = MetroFramework.MetroButtonWeight.Regular;
            this.btnSaveReg.ForeColor = System.Drawing.Color.White;
            this.btnSaveReg.Location = new System.Drawing.Point(453, 443);
            this.btnSaveReg.Name = "btnSaveReg";
            this.btnSaveReg.Size = new System.Drawing.Size(90, 36);
            this.btnSaveReg.TabIndex = 26;
            this.btnSaveReg.Text = "Save Reg";
            this.btnSaveReg.UseCustomBackColor = true;
            this.btnSaveReg.UseCustomForeColor = true;
            this.btnSaveReg.UseSelectable = true;
            this.btnSaveReg.Click += new System.EventHandler(this.btnSaveReg_Click);
            // 
            // btnBack
            // 
            this.btnBack.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btnBack.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.btnBack.FontSize = MetroFramework.MetroButtonSize.Medium;
            this.btnBack.FontWeight = MetroFramework.MetroButtonWeight.Regular;
            this.btnBack.ForeColor = System.Drawing.Color.White;
            this.btnBack.Location = new System.Drawing.Point(314, 443);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(90, 36);
            this.btnBack.TabIndex = 24;
            this.btnBack.Text = "Back";
            this.btnBack.UseCustomBackColor = true;
            this.btnBack.UseCustomForeColor = true;
            this.btnBack.UseSelectable = true;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
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
            this.txtStudentName.Location = new System.Drawing.Point(4, 242);
            this.txtStudentName.MaxLength = 32767;
            this.txtStudentName.Name = "txtStudentName";
            this.txtStudentName.PasswordChar = '\0';
            this.txtStudentName.ReadOnly = true;
            this.txtStudentName.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtStudentName.SelectedText = "";
            this.txtStudentName.SelectionLength = 0;
            this.txtStudentName.SelectionStart = 0;
            this.txtStudentName.ShortcutsEnabled = true;
            this.txtStudentName.Size = new System.Drawing.Size(190, 23);
            this.txtStudentName.TabIndex = 28;
            this.txtStudentName.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtStudentName.UseSelectable = true;
            this.txtStudentName.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtStudentName.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // St_ID
            // 
            this.St_ID.AutoSize = true;
            this.St_ID.Location = new System.Drawing.Point(62, 213);
            this.St_ID.Name = "St_ID";
            this.St_ID.Size = new System.Drawing.Size(72, 19);
            this.St_ID.TabIndex = 27;
            this.St_ID.Text = "Student ID:";
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
            this.txtStudentID.Location = new System.Drawing.Point(4, 180);
            this.txtStudentID.MaxLength = 32767;
            this.txtStudentID.Name = "txtStudentID";
            this.txtStudentID.PasswordChar = '\0';
            this.txtStudentID.ReadOnly = true;
            this.txtStudentID.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtStudentID.SelectedText = "";
            this.txtStudentID.SelectionLength = 0;
            this.txtStudentID.SelectionStart = 0;
            this.txtStudentID.ShortcutsEnabled = true;
            this.txtStudentID.Size = new System.Drawing.Size(190, 23);
            this.txtStudentID.TabIndex = 30;
            this.txtStudentID.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtStudentID.UseSelectable = true;
            this.txtStudentID.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtStudentID.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // St_Name
            // 
            this.St_Name.AutoSize = true;
            this.St_Name.Location = new System.Drawing.Point(50, 151);
            this.St_Name.Name = "St_Name";
            this.St_Name.Size = new System.Drawing.Size(96, 19);
            this.St_Name.TabIndex = 29;
            this.St_Name.Text = "Student Name:";
            // 
            // Courses
            // 
            this.Courses.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.Courses.Location = new System.Drawing.Point(652, 74);
            this.Courses.Name = "Courses";
            this.Courses.Size = new System.Drawing.Size(135, 25);
            this.Courses.TabIndex = 31;
            this.Courses.Text = "Student Courses";
            // 
            // Course
            // 
            this.Course.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.Course.Location = new System.Drawing.Point(371, 74);
            this.Course.Name = "Course";
            this.Course.Size = new System.Drawing.Size(79, 25);
            this.Course.TabIndex = 32;
            this.Course.Text = "Courses";
            // 
            // gvCourses
            // 
            this.gvCourses.AllowUserToAddRows = false;
            this.gvCourses.AllowUserToDeleteRows = false;
            this.gvCourses.AllowUserToResizeRows = false;
            this.gvCourses.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.gvCourses.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gvCourses.Location = new System.Drawing.Point(243, 110);
            this.gvCourses.Name = "gvCourses";
            this.gvCourses.ReadOnly = true;
            this.gvCourses.RowHeadersVisible = false;
            this.gvCourses.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.gvCourses.Size = new System.Drawing.Size(334, 240);
            this.gvCourses.TabIndex = 33;
            this.gvCourses.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.gvCourses_CellClick);
            // 
            // btnSelect
            // 
            this.btnSelect.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnSelect.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.btnSelect.FontSize = MetroFramework.MetroButtonSize.Medium;
            this.btnSelect.FontWeight = MetroFramework.MetroButtonWeight.Regular;
            this.btnSelect.ForeColor = System.Drawing.Color.White;
            this.btnSelect.Location = new System.Drawing.Point(52, 71);
            this.btnSelect.Name = "btnSelect";
            this.btnSelect.Size = new System.Drawing.Size(90, 36);
            this.btnSelect.TabIndex = 2;
            this.btnSelect.Text = "Select";
            this.btnSelect.UseCustomBackColor = true;
            this.btnSelect.UseCustomForeColor = true;
            this.btnSelect.UseSelectable = true;
            this.btnSelect.Click += new System.EventHandler(this.btnSelect_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btnAdd.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.btnAdd.FontSize = MetroFramework.MetroButtonSize.Medium;
            this.btnAdd.FontWeight = MetroFramework.MetroButtonWeight.Regular;
            this.btnAdd.ForeColor = System.Drawing.Color.White;
            this.btnAdd.Location = new System.Drawing.Point(365, 367);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(90, 36);
            this.btnAdd.TabIndex = 35;
            this.btnAdd.Text = "Add Course";
            this.btnAdd.UseCustomBackColor = true;
            this.btnAdd.UseCustomForeColor = true;
            this.btnAdd.UseSelectable = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btnDelete.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.btnDelete.FontSize = MetroFramework.MetroButtonSize.Medium;
            this.btnDelete.FontWeight = MetroFramework.MetroButtonWeight.Regular;
            this.btnDelete.ForeColor = System.Drawing.Color.White;
            this.btnDelete.Location = new System.Drawing.Point(674, 367);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(90, 36);
            this.btnDelete.TabIndex = 36;
            this.btnDelete.Text = "Delete Course";
            this.btnDelete.UseCustomBackColor = true;
            this.btnDelete.UseCustomForeColor = true;
            this.btnDelete.UseSelectable = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // metroPanel1
            // 
            this.metroPanel1.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.metroPanel1.Controls.Add(this.Semester);
            this.metroPanel1.Controls.Add(this.txtSemester);
            this.metroPanel1.Controls.Add(this.search);
            this.metroPanel1.Controls.Add(this.btnSelect);
            this.metroPanel1.Controls.Add(this.txtStudent);
            this.metroPanel1.Controls.Add(this.St_ID);
            this.metroPanel1.Controls.Add(this.txtStudentName);
            this.metroPanel1.Controls.Add(this.St_Name);
            this.metroPanel1.Controls.Add(this.txtStudentID);
            this.metroPanel1.HorizontalScrollbarBarColor = true;
            this.metroPanel1.HorizontalScrollbarHighlightOnWheel = false;
            this.metroPanel1.HorizontalScrollbarSize = 10;
            this.metroPanel1.Location = new System.Drawing.Point(23, 99);
            this.metroPanel1.Name = "metroPanel1";
            this.metroPanel1.Size = new System.Drawing.Size(198, 337);
            this.metroPanel1.TabIndex = 37;
            this.metroPanel1.VerticalScrollbarBarColor = true;
            this.metroPanel1.VerticalScrollbarHighlightOnWheel = false;
            this.metroPanel1.VerticalScrollbarSize = 10;
            // 
            // Semester
            // 
            this.Semester.AutoSize = true;
            this.Semester.Location = new System.Drawing.Point(50, 276);
            this.Semester.Name = "Semester";
            this.Semester.Size = new System.Drawing.Size(106, 19);
            this.Semester.TabIndex = 31;
            this.Semester.Text = "Semester Name:";
            // 
            // txtSemester
            // 
            // 
            // 
            // 
            this.txtSemester.CustomButton.Image = null;
            this.txtSemester.CustomButton.Location = new System.Drawing.Point(168, 1);
            this.txtSemester.CustomButton.Name = "";
            this.txtSemester.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtSemester.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtSemester.CustomButton.TabIndex = 1;
            this.txtSemester.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtSemester.CustomButton.UseSelectable = true;
            this.txtSemester.CustomButton.Visible = false;
            this.txtSemester.Lines = new string[0];
            this.txtSemester.Location = new System.Drawing.Point(4, 305);
            this.txtSemester.MaxLength = 32767;
            this.txtSemester.Name = "txtSemester";
            this.txtSemester.PasswordChar = '\0';
            this.txtSemester.ReadOnly = true;
            this.txtSemester.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtSemester.SelectedText = "";
            this.txtSemester.SelectionLength = 0;
            this.txtSemester.SelectionStart = 0;
            this.txtSemester.ShortcutsEnabled = true;
            this.txtSemester.Size = new System.Drawing.Size(190, 23);
            this.txtSemester.TabIndex = 32;
            this.txtSemester.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtSemester.UseSelectable = true;
            this.txtSemester.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtSemester.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // StudentRegistrationForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(860, 502);
            this.Controls.Add(this.metroPanel1);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.gvCourses);
            this.Controls.Add(this.Course);
            this.Controls.Add(this.Courses);
            this.Controls.Add(this.btnSaveReg);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.gvRegCourses);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "StudentRegistrationForm";
            this.Resizable = false;
            this.Text = "Student Registration";
            this.Load += new System.EventHandler(this.StudentRegistrationForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gvRegCourses)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvCourses)).EndInit();
            this.metroPanel1.ResumeLayout(false);
            this.metroPanel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private MetroFramework.Controls.MetroLabel search;
        private MetroFramework.Controls.MetroTextBox txtStudent;
        private System.Windows.Forms.DataGridView gvRegCourses;
        private MetroFramework.Controls.MetroButton btnSaveReg;
        private MetroFramework.Controls.MetroButton btnBack;
        private MetroFramework.Controls.MetroTextBox txtStudentName;
        private MetroFramework.Controls.MetroLabel St_ID;
        private MetroFramework.Controls.MetroTextBox txtStudentID;
        private MetroFramework.Controls.MetroLabel St_Name;
        private MetroFramework.Controls.MetroLabel Courses;
        private MetroFramework.Controls.MetroLabel Course;
        private System.Windows.Forms.DataGridView gvCourses;
        private MetroFramework.Controls.MetroButton btnSelect;
        private MetroFramework.Controls.MetroButton btnAdd;
        private MetroFramework.Controls.MetroButton btnDelete;
        private MetroFramework.Controls.MetroPanel metroPanel1;
        private MetroFramework.Controls.MetroLabel Semester;
        private MetroFramework.Controls.MetroTextBox txtSemester;
    }
}