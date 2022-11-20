
namespace winUniversityPortal.TeacherForm
{
    partial class StudentUpdateForm
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
            this.updateStudentPanel = new MetroFramework.Controls.MetroPanel();
            this.StudentID = new MetroFramework.Controls.MetroLabel();
            this.StudentName = new MetroFramework.Controls.MetroLabel();
            this.txtStudentID = new MetroFramework.Controls.MetroTextBox();
            this.cbStudentGrade = new MetroFramework.Controls.MetroComboBox();
            this.Grade = new MetroFramework.Controls.MetroLabel();
            this.txtStudentName = new MetroFramework.Controls.MetroTextBox();
            this.txtAttendance = new MetroFramework.Controls.MetroTextBox();
            this.Attendance = new MetroFramework.Controls.MetroLabel();
            this.btnBack = new MetroFramework.Controls.MetroButton();
            this.btnUpdate = new MetroFramework.Controls.MetroButton();
            this.updateStudentPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // updateStudentPanel
            // 
            this.updateStudentPanel.Controls.Add(this.StudentID);
            this.updateStudentPanel.Controls.Add(this.StudentName);
            this.updateStudentPanel.Controls.Add(this.txtStudentID);
            this.updateStudentPanel.Controls.Add(this.cbStudentGrade);
            this.updateStudentPanel.Controls.Add(this.Grade);
            this.updateStudentPanel.Controls.Add(this.txtStudentName);
            this.updateStudentPanel.Controls.Add(this.txtAttendance);
            this.updateStudentPanel.Controls.Add(this.Attendance);
            this.updateStudentPanel.HorizontalScrollbarBarColor = true;
            this.updateStudentPanel.HorizontalScrollbarHighlightOnWheel = false;
            this.updateStudentPanel.HorizontalScrollbarSize = 10;
            this.updateStudentPanel.Location = new System.Drawing.Point(23, 63);
            this.updateStudentPanel.Name = "updateStudentPanel";
            this.updateStudentPanel.Size = new System.Drawing.Size(314, 162);
            this.updateStudentPanel.TabIndex = 24;
            this.updateStudentPanel.VerticalScrollbarBarColor = true;
            this.updateStudentPanel.VerticalScrollbarHighlightOnWheel = false;
            this.updateStudentPanel.VerticalScrollbarSize = 10;
            // 
            // StudentID
            // 
            this.StudentID.AutoSize = true;
            this.StudentID.Location = new System.Drawing.Point(6, 12);
            this.StudentID.Name = "StudentID";
            this.StudentID.Size = new System.Drawing.Size(72, 19);
            this.StudentID.TabIndex = 8;
            this.StudentID.Text = "Student ID:";
            // 
            // StudentName
            // 
            this.StudentName.AutoSize = true;
            this.StudentName.Location = new System.Drawing.Point(6, 50);
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
            this.txtStudentID.Location = new System.Drawing.Point(121, 11);
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
            this.txtStudentID.TabIndex = 1;
            this.txtStudentID.UseSelectable = true;
            this.txtStudentID.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtStudentID.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // cbStudentGrade
            // 
            this.cbStudentGrade.FormattingEnabled = true;
            this.cbStudentGrade.ItemHeight = 23;
            this.cbStudentGrade.Items.AddRange(new object[] {
            "A",
            "B",
            "C",
            "D",
            "F",
            "I",
            "W"});
            this.cbStudentGrade.Location = new System.Drawing.Point(121, 122);
            this.cbStudentGrade.Name = "cbStudentGrade";
            this.cbStudentGrade.PromptText = "Select Grade";
            this.cbStudentGrade.Size = new System.Drawing.Size(190, 29);
            this.cbStudentGrade.TabIndex = 4;
            this.cbStudentGrade.UseSelectable = true;
            // 
            // Grade
            // 
            this.Grade.AutoSize = true;
            this.Grade.Location = new System.Drawing.Point(6, 126);
            this.Grade.Name = "Grade";
            this.Grade.Size = new System.Drawing.Size(48, 19);
            this.Grade.TabIndex = 7;
            this.Grade.Text = "Grade:";
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
            this.txtStudentName.Location = new System.Drawing.Point(121, 48);
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
            this.txtStudentName.TabIndex = 2;
            this.txtStudentName.UseSelectable = true;
            this.txtStudentName.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtStudentName.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // txtAttendance
            // 
            // 
            // 
            // 
            this.txtAttendance.CustomButton.Image = null;
            this.txtAttendance.CustomButton.Location = new System.Drawing.Point(168, 1);
            this.txtAttendance.CustomButton.Name = "";
            this.txtAttendance.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtAttendance.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtAttendance.CustomButton.TabIndex = 1;
            this.txtAttendance.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtAttendance.CustomButton.UseSelectable = true;
            this.txtAttendance.CustomButton.Visible = false;
            this.txtAttendance.Lines = new string[0];
            this.txtAttendance.Location = new System.Drawing.Point(121, 85);
            this.txtAttendance.MaxLength = 32767;
            this.txtAttendance.Name = "txtAttendance";
            this.txtAttendance.PasswordChar = '\0';
            this.txtAttendance.PromptText = "Enter Attendance";
            this.txtAttendance.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtAttendance.SelectedText = "";
            this.txtAttendance.SelectionLength = 0;
            this.txtAttendance.SelectionStart = 0;
            this.txtAttendance.ShortcutsEnabled = true;
            this.txtAttendance.Size = new System.Drawing.Size(190, 23);
            this.txtAttendance.TabIndex = 3;
            this.txtAttendance.UseSelectable = true;
            this.txtAttendance.WaterMark = "Enter Attendance";
            this.txtAttendance.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtAttendance.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.txtAttendance.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtAttendance_KeyPress);
            // 
            // Attendance
            // 
            this.Attendance.AutoSize = true;
            this.Attendance.Location = new System.Drawing.Point(6, 88);
            this.Attendance.Name = "Attendance";
            this.Attendance.Size = new System.Drawing.Size(78, 19);
            this.Attendance.TabIndex = 10;
            this.Attendance.Text = "Attendance:";
            // 
            // btnBack
            // 
            this.btnBack.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btnBack.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.btnBack.FontSize = MetroFramework.MetroButtonSize.Medium;
            this.btnBack.FontWeight = MetroFramework.MetroButtonWeight.Regular;
            this.btnBack.ForeColor = System.Drawing.Color.White;
            this.btnBack.Location = new System.Drawing.Point(249, 237);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(85, 36);
            this.btnBack.TabIndex = 26;
            this.btnBack.Text = "Back";
            this.btnBack.UseCustomBackColor = true;
            this.btnBack.UseCustomForeColor = true;
            this.btnBack.UseSelectable = true;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btnUpdate.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.btnUpdate.FontSize = MetroFramework.MetroButtonSize.Medium;
            this.btnUpdate.FontWeight = MetroFramework.MetroButtonWeight.Regular;
            this.btnUpdate.ForeColor = System.Drawing.Color.White;
            this.btnUpdate.Location = new System.Drawing.Point(144, 237);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(85, 36);
            this.btnUpdate.TabIndex = 25;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.UseCustomBackColor = true;
            this.btnUpdate.UseCustomForeColor = true;
            this.btnUpdate.UseSelectable = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // StudentUpdateForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(360, 298);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.updateStudentPanel);
            this.MaximizeBox = false;
            this.Name = "StudentUpdateForm";
            this.Resizable = false;
            this.Text = "Student Detail";
            this.Load += new System.EventHandler(this.StudentUpdateForm_Load);
            this.updateStudentPanel.ResumeLayout(false);
            this.updateStudentPanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private MetroFramework.Controls.MetroPanel updateStudentPanel;
        private MetroFramework.Controls.MetroLabel StudentID;
        private MetroFramework.Controls.MetroTextBox txtStudentID;
        private MetroFramework.Controls.MetroButton btnBack;
        private MetroFramework.Controls.MetroButton btnUpdate;
        private MetroFramework.Controls.MetroLabel StudentName;
        private MetroFramework.Controls.MetroComboBox cbStudentGrade;
        private MetroFramework.Controls.MetroLabel Grade;
        private MetroFramework.Controls.MetroTextBox txtStudentName;
        private MetroFramework.Controls.MetroTextBox txtAttendance;
        private MetroFramework.Controls.MetroLabel Attendance;
    }
}