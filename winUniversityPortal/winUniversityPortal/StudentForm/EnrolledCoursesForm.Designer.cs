
namespace winUniversityPortal.StudentForm
{
    partial class EnrolledCoursesForm
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
            this.studentCoursesPanel = new MetroFramework.Controls.MetroPanel();
            this.TeacherName = new MetroFramework.Controls.MetroLabel();
            this.txtTeacherName = new MetroFramework.Controls.MetroTextBox();
            this.Grade = new MetroFramework.Controls.MetroLabel();
            this.Attendance = new MetroFramework.Controls.MetroLabel();
            this.CourseName = new MetroFramework.Controls.MetroLabel();
            this.txtCourseName = new MetroFramework.Controls.MetroTextBox();
            this.cpbGrade = new CircularProgressBar.CircularProgressBar();
            this.cpbAttandance = new CircularProgressBar.CircularProgressBar();
            this.CourseID = new MetroFramework.Controls.MetroLabel();
            this.txtCourseID = new MetroFramework.Controls.MetroTextBox();
            this.btnSelectCourse = new MetroFramework.Controls.MetroButton();
            this.cbEnrolledCourse = new MetroFramework.Controls.MetroComboBox();
            this.StudentID = new MetroFramework.Controls.MetroLabel();
            this.btnBack = new MetroFramework.Controls.MetroButton();
            this.studentCoursesPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // studentCoursesPanel
            // 
            this.studentCoursesPanel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.studentCoursesPanel.Controls.Add(this.TeacherName);
            this.studentCoursesPanel.Controls.Add(this.txtTeacherName);
            this.studentCoursesPanel.Controls.Add(this.Grade);
            this.studentCoursesPanel.Controls.Add(this.Attendance);
            this.studentCoursesPanel.Controls.Add(this.CourseName);
            this.studentCoursesPanel.Controls.Add(this.txtCourseName);
            this.studentCoursesPanel.Controls.Add(this.cpbGrade);
            this.studentCoursesPanel.Controls.Add(this.cpbAttandance);
            this.studentCoursesPanel.Controls.Add(this.CourseID);
            this.studentCoursesPanel.Controls.Add(this.txtCourseID);
            this.studentCoursesPanel.Controls.Add(this.btnSelectCourse);
            this.studentCoursesPanel.Controls.Add(this.cbEnrolledCourse);
            this.studentCoursesPanel.Controls.Add(this.StudentID);
            this.studentCoursesPanel.HorizontalScrollbarBarColor = true;
            this.studentCoursesPanel.HorizontalScrollbarHighlightOnWheel = false;
            this.studentCoursesPanel.HorizontalScrollbarSize = 10;
            this.studentCoursesPanel.Location = new System.Drawing.Point(23, 63);
            this.studentCoursesPanel.Name = "studentCoursesPanel";
            this.studentCoursesPanel.Size = new System.Drawing.Size(704, 263);
            this.studentCoursesPanel.TabIndex = 25;
            this.studentCoursesPanel.VerticalScrollbarBarColor = true;
            this.studentCoursesPanel.VerticalScrollbarHighlightOnWheel = false;
            this.studentCoursesPanel.VerticalScrollbarSize = 10;
            // 
            // TeacherName
            // 
            this.TeacherName.AutoSize = true;
            this.TeacherName.Location = new System.Drawing.Point(58, 190);
            this.TeacherName.Name = "TeacherName";
            this.TeacherName.Size = new System.Drawing.Size(96, 19);
            this.TeacherName.TabIndex = 18;
            this.TeacherName.Text = "Teacher Name:";
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
            this.txtTeacherName.Location = new System.Drawing.Point(170, 188);
            this.txtTeacherName.MaxLength = 32767;
            this.txtTeacherName.Name = "txtTeacherName";
            this.txtTeacherName.PasswordChar = '\0';
            this.txtTeacherName.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtTeacherName.SelectedText = "";
            this.txtTeacherName.SelectionLength = 0;
            this.txtTeacherName.SelectionStart = 0;
            this.txtTeacherName.ShortcutsEnabled = true;
            this.txtTeacherName.Size = new System.Drawing.Size(190, 23);
            this.txtTeacherName.TabIndex = 5;
            this.txtTeacherName.UseSelectable = true;
            this.txtTeacherName.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtTeacherName.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // Grade
            // 
            this.Grade.AutoSize = true;
            this.Grade.Location = new System.Drawing.Point(400, 190);
            this.Grade.Name = "Grade";
            this.Grade.Size = new System.Drawing.Size(48, 19);
            this.Grade.TabIndex = 16;
            this.Grade.Text = "Grade:";
            // 
            // Attendance
            // 
            this.Attendance.AutoSize = true;
            this.Attendance.Location = new System.Drawing.Point(400, 97);
            this.Attendance.Name = "Attendance";
            this.Attendance.Size = new System.Drawing.Size(78, 19);
            this.Attendance.TabIndex = 15;
            this.Attendance.Text = "Attendance:";
            // 
            // CourseName
            // 
            this.CourseName.AutoSize = true;
            this.CourseName.Location = new System.Drawing.Point(58, 142);
            this.CourseName.Name = "CourseName";
            this.CourseName.Size = new System.Drawing.Size(93, 19);
            this.CourseName.TabIndex = 14;
            this.CourseName.Text = "Course Name:";
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
            this.txtCourseName.Location = new System.Drawing.Point(170, 142);
            this.txtCourseName.MaxLength = 32767;
            this.txtCourseName.Name = "txtCourseName";
            this.txtCourseName.PasswordChar = '\0';
            this.txtCourseName.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtCourseName.SelectedText = "";
            this.txtCourseName.SelectionLength = 0;
            this.txtCourseName.SelectionStart = 0;
            this.txtCourseName.ShortcutsEnabled = true;
            this.txtCourseName.Size = new System.Drawing.Size(190, 23);
            this.txtCourseName.TabIndex = 4;
            this.txtCourseName.UseSelectable = true;
            this.txtCourseName.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtCourseName.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // cpbGrade
            // 
            this.cpbGrade.AnimationFunction = WinFormAnimation.KnownAnimationFunctions.Liner;
            this.cpbGrade.AnimationSpeed = 800;
            this.cpbGrade.BackColor = System.Drawing.Color.Transparent;
            this.cpbGrade.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold);
            this.cpbGrade.ForeColor = System.Drawing.Color.Black;
            this.cpbGrade.InnerColor = System.Drawing.Color.White;
            this.cpbGrade.InnerMargin = 2;
            this.cpbGrade.InnerWidth = -1;
            this.cpbGrade.Location = new System.Drawing.Point(510, 162);
            this.cpbGrade.MarqueeAnimationSpeed = 2000;
            this.cpbGrade.Name = "cpbGrade";
            this.cpbGrade.OuterColor = System.Drawing.Color.White;
            this.cpbGrade.OuterMargin = -25;
            this.cpbGrade.OuterWidth = 25;
            this.cpbGrade.ProgressColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.cpbGrade.ProgressWidth = 10;
            this.cpbGrade.SecondaryFont = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.cpbGrade.Size = new System.Drawing.Size(75, 75);
            this.cpbGrade.StartAngle = 270;
            this.cpbGrade.SubscriptColor = System.Drawing.Color.FromArgb(((int)(((byte)(166)))), ((int)(((byte)(166)))), ((int)(((byte)(166)))));
            this.cpbGrade.SubscriptMargin = new System.Windows.Forms.Padding(10, -35, 0, 0);
            this.cpbGrade.SubscriptText = "";
            this.cpbGrade.SuperscriptColor = System.Drawing.Color.FromArgb(((int)(((byte)(166)))), ((int)(((byte)(166)))), ((int)(((byte)(166)))));
            this.cpbGrade.SuperscriptMargin = new System.Windows.Forms.Padding(10, 35, 0, 0);
            this.cpbGrade.SuperscriptText = "";
            this.cpbGrade.TabIndex = 12;
            this.cpbGrade.Text = "I";
            this.cpbGrade.TextMargin = new System.Windows.Forms.Padding(0);
            this.cpbGrade.Value = 1;
            // 
            // cpbAttandance
            // 
            this.cpbAttandance.AnimationFunction = WinFormAnimation.KnownAnimationFunctions.Liner;
            this.cpbAttandance.AnimationSpeed = 800;
            this.cpbAttandance.BackColor = System.Drawing.Color.Transparent;
            this.cpbAttandance.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold);
            this.cpbAttandance.ForeColor = System.Drawing.Color.Black;
            this.cpbAttandance.InnerColor = System.Drawing.Color.White;
            this.cpbAttandance.InnerMargin = 2;
            this.cpbAttandance.InnerWidth = -1;
            this.cpbAttandance.Location = new System.Drawing.Point(510, 69);
            this.cpbAttandance.MarqueeAnimationSpeed = 2000;
            this.cpbAttandance.Name = "cpbAttandance";
            this.cpbAttandance.OuterColor = System.Drawing.Color.White;
            this.cpbAttandance.OuterMargin = -25;
            this.cpbAttandance.OuterWidth = 25;
            this.cpbAttandance.ProgressColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.cpbAttandance.ProgressWidth = 10;
            this.cpbAttandance.SecondaryFont = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.cpbAttandance.Size = new System.Drawing.Size(75, 75);
            this.cpbAttandance.StartAngle = 270;
            this.cpbAttandance.SubscriptColor = System.Drawing.Color.FromArgb(((int)(((byte)(166)))), ((int)(((byte)(166)))), ((int)(((byte)(166)))));
            this.cpbAttandance.SubscriptMargin = new System.Windows.Forms.Padding(10, -35, 0, 0);
            this.cpbAttandance.SubscriptText = "";
            this.cpbAttandance.SuperscriptColor = System.Drawing.Color.FromArgb(((int)(((byte)(166)))), ((int)(((byte)(166)))), ((int)(((byte)(166)))));
            this.cpbAttandance.SuperscriptMargin = new System.Windows.Forms.Padding(10, 35, 0, 0);
            this.cpbAttandance.SuperscriptText = "";
            this.cpbAttandance.TabIndex = 11;
            this.cpbAttandance.Text = "I";
            this.cpbAttandance.TextMargin = new System.Windows.Forms.Padding(0);
            this.cpbAttandance.Value = 1;
            // 
            // CourseID
            // 
            this.CourseID.AutoSize = true;
            this.CourseID.Location = new System.Drawing.Point(58, 97);
            this.CourseID.Name = "CourseID";
            this.CourseID.Size = new System.Drawing.Size(69, 19);
            this.CourseID.TabIndex = 10;
            this.CourseID.Text = "Course ID:";
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
            this.txtCourseID.Location = new System.Drawing.Point(170, 95);
            this.txtCourseID.MaxLength = 32767;
            this.txtCourseID.Name = "txtCourseID";
            this.txtCourseID.PasswordChar = '\0';
            this.txtCourseID.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtCourseID.SelectedText = "";
            this.txtCourseID.SelectionLength = 0;
            this.txtCourseID.SelectionStart = 0;
            this.txtCourseID.ShortcutsEnabled = true;
            this.txtCourseID.Size = new System.Drawing.Size(190, 23);
            this.txtCourseID.TabIndex = 3;
            this.txtCourseID.UseSelectable = true;
            this.txtCourseID.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtCourseID.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // btnSelectCourse
            // 
            this.btnSelectCourse.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnSelectCourse.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.btnSelectCourse.FontSize = MetroFramework.MetroButtonSize.Medium;
            this.btnSelectCourse.FontWeight = MetroFramework.MetroButtonWeight.Regular;
            this.btnSelectCourse.ForeColor = System.Drawing.Color.White;
            this.btnSelectCourse.Location = new System.Drawing.Point(509, 11);
            this.btnSelectCourse.Name = "btnSelectCourse";
            this.btnSelectCourse.Size = new System.Drawing.Size(90, 29);
            this.btnSelectCourse.TabIndex = 2;
            this.btnSelectCourse.Text = "Select";
            this.btnSelectCourse.UseCustomBackColor = true;
            this.btnSelectCourse.UseCustomForeColor = true;
            this.btnSelectCourse.UseSelectable = true;
            this.btnSelectCourse.Click += new System.EventHandler(this.btnSelectCourse_Click);
            // 
            // cbEnrolledCourse
            // 
            this.cbEnrolledCourse.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.cbEnrolledCourse.FormattingEnabled = true;
            this.cbEnrolledCourse.ItemHeight = 23;
            this.cbEnrolledCourse.Location = new System.Drawing.Point(256, 11);
            this.cbEnrolledCourse.Name = "cbEnrolledCourse";
            this.cbEnrolledCourse.Size = new System.Drawing.Size(226, 29);
            this.cbEnrolledCourse.TabIndex = 1;
            this.cbEnrolledCourse.UseSelectable = true;
            // 
            // StudentID
            // 
            this.StudentID.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.StudentID.AutoSize = true;
            this.StudentID.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.StudentID.Location = new System.Drawing.Point(94, 12);
            this.StudentID.Name = "StudentID";
            this.StudentID.Size = new System.Drawing.Size(143, 25);
            this.StudentID.TabIndex = 8;
            this.StudentID.Text = "Enrolled Courses:";
            this.StudentID.UseCustomBackColor = true;
            this.StudentID.UseCustomForeColor = true;
            this.StudentID.UseStyleColors = true;
            // 
            // btnBack
            // 
            this.btnBack.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btnBack.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.btnBack.FontSize = MetroFramework.MetroButtonSize.Medium;
            this.btnBack.FontWeight = MetroFramework.MetroButtonWeight.Regular;
            this.btnBack.ForeColor = System.Drawing.Color.White;
            this.btnBack.Location = new System.Drawing.Point(331, 332);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(90, 36);
            this.btnBack.TabIndex = 3;
            this.btnBack.Text = "Back";
            this.btnBack.UseCustomBackColor = true;
            this.btnBack.UseCustomForeColor = true;
            this.btnBack.UseSelectable = true;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // EnrolledCoursesForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(750, 391);
            this.Controls.Add(this.studentCoursesPanel);
            this.Controls.Add(this.btnBack);
            this.Name = "EnrolledCoursesForm";
            this.Text = "Enrolled Courses";
            this.Load += new System.EventHandler(this.EnrolledCoursesForm_Load);
            this.studentCoursesPanel.ResumeLayout(false);
            this.studentCoursesPanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private MetroFramework.Controls.MetroPanel studentCoursesPanel;
        private MetroFramework.Controls.MetroLabel StudentID;
        private MetroFramework.Controls.MetroLabel Grade;
        private MetroFramework.Controls.MetroLabel Attendance;
        private MetroFramework.Controls.MetroLabel CourseName;
        private MetroFramework.Controls.MetroTextBox txtCourseName;
        private CircularProgressBar.CircularProgressBar cpbGrade;
        private CircularProgressBar.CircularProgressBar cpbAttandance;
        private MetroFramework.Controls.MetroLabel CourseID;
        private MetroFramework.Controls.MetroTextBox txtCourseID;
        private MetroFramework.Controls.MetroButton btnSelectCourse;
        private MetroFramework.Controls.MetroComboBox cbEnrolledCourse;
        private MetroFramework.Controls.MetroButton btnBack;
        private MetroFramework.Controls.MetroLabel TeacherName;
        private MetroFramework.Controls.MetroTextBox txtTeacherName;
    }
}