
namespace winUniversityPortal.AdminForm
{
    partial class UpdateCourseDetailsForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UpdateCourseDetailsForm));
            this.btnBack = new MetroFramework.Controls.MetroButton();
            this.btnSave = new MetroFramework.Controls.MetroButton();
            this.updateCoursePanel = new MetroFramework.Controls.MetroPanel();
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
            this.updateCoursePanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnBack
            // 
            this.btnBack.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btnBack.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.btnBack.FontSize = MetroFramework.MetroButtonSize.Medium;
            this.btnBack.FontWeight = MetroFramework.MetroButtonWeight.Regular;
            this.btnBack.ForeColor = System.Drawing.Color.White;
            this.btnBack.Location = new System.Drawing.Point(232, 258);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(90, 36);
            this.btnBack.TabIndex = 25;
            this.btnBack.Text = "Back";
            this.btnBack.UseCustomBackColor = true;
            this.btnBack.UseCustomForeColor = true;
            this.btnBack.UseSelectable = true;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // btnSave
            // 
            this.btnSave.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btnSave.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.btnSave.FontSize = MetroFramework.MetroButtonSize.Medium;
            this.btnSave.FontWeight = MetroFramework.MetroButtonWeight.Regular;
            this.btnSave.ForeColor = System.Drawing.Color.White;
            this.btnSave.Location = new System.Drawing.Point(366, 258);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(90, 36);
            this.btnSave.TabIndex = 24;
            this.btnSave.Text = "Save";
            this.btnSave.UseCustomBackColor = true;
            this.btnSave.UseCustomForeColor = true;
            this.btnSave.UseSelectable = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // updateCoursePanel
            // 
            this.updateCoursePanel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.updateCoursePanel.Controls.Add(this.cbTeacherID);
            this.updateCoursePanel.Controls.Add(this.TeacherID);
            this.updateCoursePanel.Controls.Add(this.CourseID);
            this.updateCoursePanel.Controls.Add(this.CourseName);
            this.updateCoursePanel.Controls.Add(this.txtCourseID);
            this.updateCoursePanel.Controls.Add(this.cbCreditHours);
            this.updateCoursePanel.Controls.Add(this.CreditHours);
            this.updateCoursePanel.Controls.Add(this.cbPrerequisite);
            this.updateCoursePanel.Controls.Add(this.Prerequisite);
            this.updateCoursePanel.Controls.Add(this.txtCourseName);
            this.updateCoursePanel.HorizontalScrollbarBarColor = true;
            this.updateCoursePanel.HorizontalScrollbarHighlightOnWheel = false;
            this.updateCoursePanel.HorizontalScrollbarSize = 10;
            this.updateCoursePanel.Location = new System.Drawing.Point(23, 76);
            this.updateCoursePanel.Name = "updateCoursePanel";
            this.updateCoursePanel.Size = new System.Drawing.Size(645, 153);
            this.updateCoursePanel.TabIndex = 26;
            this.updateCoursePanel.VerticalScrollbarBarColor = true;
            this.updateCoursePanel.VerticalScrollbarHighlightOnWheel = false;
            this.updateCoursePanel.VerticalScrollbarSize = 10;
            // 
            // cbTeacherID
            // 
            this.cbTeacherID.FormattingEnabled = true;
            this.cbTeacherID.ItemHeight = 23;
            this.cbTeacherID.Location = new System.Drawing.Point(283, 115);
            this.cbTeacherID.Name = "cbTeacherID";
            this.cbTeacherID.PromptText = "Select Teacher ID";
            this.cbTeacherID.Size = new System.Drawing.Size(190, 29);
            this.cbTeacherID.TabIndex = 5;
            this.cbTeacherID.UseSelectable = true;
            // 
            // TeacherID
            // 
            this.TeacherID.AutoSize = true;
            this.TeacherID.Location = new System.Drawing.Point(180, 120);
            this.TeacherID.Name = "TeacherID";
            this.TeacherID.Size = new System.Drawing.Size(72, 19);
            this.TeacherID.TabIndex = 20;
            this.TeacherID.Text = "Teacher ID:";
            // 
            // CourseID
            // 
            this.CourseID.AutoSize = true;
            this.CourseID.Location = new System.Drawing.Point(3, 22);
            this.CourseID.Name = "CourseID";
            this.CourseID.Size = new System.Drawing.Size(69, 19);
            this.CourseID.TabIndex = 19;
            this.CourseID.Text = "Course ID:";
            // 
            // CourseName
            // 
            this.CourseName.AutoSize = true;
            this.CourseName.Location = new System.Drawing.Point(337, 22);
            this.CourseName.Name = "CourseName";
            this.CourseName.Size = new System.Drawing.Size(93, 19);
            this.CourseName.TabIndex = 12;
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
            this.txtCourseID.Location = new System.Drawing.Point(114, 21);
            this.txtCourseID.MaxLength = 32767;
            this.txtCourseID.Name = "txtCourseID";
            this.txtCourseID.PasswordChar = '\0';
            this.txtCourseID.ReadOnly = true;
            this.txtCourseID.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtCourseID.SelectedText = "";
            this.txtCourseID.SelectionLength = 0;
            this.txtCourseID.SelectionStart = 0;
            this.txtCourseID.ShortcutsEnabled = true;
            this.txtCourseID.Size = new System.Drawing.Size(190, 23);
            this.txtCourseID.TabIndex = 1;
            this.txtCourseID.UseSelectable = true;
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
            this.cbCreditHours.Location = new System.Drawing.Point(113, 61);
            this.cbCreditHours.Name = "cbCreditHours";
            this.cbCreditHours.PromptText = "Select Credit Hours";
            this.cbCreditHours.Size = new System.Drawing.Size(190, 29);
            this.cbCreditHours.TabIndex = 3;
            this.cbCreditHours.UseSelectable = true;
            // 
            // CreditHours
            // 
            this.CreditHours.AutoSize = true;
            this.CreditHours.Location = new System.Drawing.Point(3, 65);
            this.CreditHours.Name = "CreditHours";
            this.CreditHours.Size = new System.Drawing.Size(83, 19);
            this.CreditHours.TabIndex = 17;
            this.CreditHours.Text = "Credit Hours";
            // 
            // cbPrerequisite
            // 
            this.cbPrerequisite.FormattingEnabled = true;
            this.cbPrerequisite.ItemHeight = 23;
            this.cbPrerequisite.Location = new System.Drawing.Point(452, 60);
            this.cbPrerequisite.Name = "cbPrerequisite";
            this.cbPrerequisite.PromptText = "Select Prerequisite Course";
            this.cbPrerequisite.Size = new System.Drawing.Size(190, 29);
            this.cbPrerequisite.TabIndex = 4;
            this.cbPrerequisite.UseSelectable = true;
            // 
            // Prerequisite
            // 
            this.Prerequisite.AutoSize = true;
            this.Prerequisite.Location = new System.Drawing.Point(337, 65);
            this.Prerequisite.Name = "Prerequisite";
            this.Prerequisite.Size = new System.Drawing.Size(81, 19);
            this.Prerequisite.TabIndex = 18;
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
            this.txtCourseName.Location = new System.Drawing.Point(452, 20);
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
            // UpdateCourseDetailsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(691, 317);
            this.Controls.Add(this.updateCoursePanel);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.btnSave);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "UpdateCourseDetailsForm";
            this.Resizable = false;
            this.Text = "Course Details";
            this.Load += new System.EventHandler(this.UpdateCourseDetailsForm_Load);
            this.updateCoursePanel.ResumeLayout(false);
            this.updateCoursePanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private MetroFramework.Controls.MetroButton btnBack;
        private MetroFramework.Controls.MetroButton btnSave;
        private MetroFramework.Controls.MetroPanel updateCoursePanel;
        private MetroFramework.Controls.MetroComboBox cbTeacherID;
        private MetroFramework.Controls.MetroLabel TeacherID;
        private MetroFramework.Controls.MetroLabel CourseID;
        private MetroFramework.Controls.MetroLabel CourseName;
        private MetroFramework.Controls.MetroTextBox txtCourseID;
        private MetroFramework.Controls.MetroComboBox cbCreditHours;
        private MetroFramework.Controls.MetroLabel CreditHours;
        private MetroFramework.Controls.MetroComboBox cbPrerequisite;
        private MetroFramework.Controls.MetroLabel Prerequisite;
        private MetroFramework.Controls.MetroTextBox txtCourseName;
    }
}