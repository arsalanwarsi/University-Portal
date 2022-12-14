
namespace winUniversityPortal.StudentForm
{
    partial class StudentDetailsForm
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
            this.Gender = new MetroFramework.Controls.MetroLabel();
            this.txtStudentEmail = new MetroFramework.Controls.MetroTextBox();
            this.Program = new MetroFramework.Controls.MetroLabel();
            this.Email = new MetroFramework.Controls.MetroLabel();
            this.txtStudentName = new MetroFramework.Controls.MetroTextBox();
            this.txtPhoneNo = new MetroFramework.Controls.MetroTextBox();
            this.PhoneNo = new MetroFramework.Controls.MetroLabel();
            this.btnBack = new MetroFramework.Controls.MetroButton();
            this.txtStudentProgram = new MetroFramework.Controls.MetroTextBox();
            this.txtStudentGender = new MetroFramework.Controls.MetroTextBox();
            this.updateStudentPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // updateStudentPanel
            // 
            this.updateStudentPanel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.updateStudentPanel.Controls.Add(this.txtStudentProgram);
            this.updateStudentPanel.Controls.Add(this.txtStudentGender);
            this.updateStudentPanel.Controls.Add(this.StudentID);
            this.updateStudentPanel.Controls.Add(this.StudentName);
            this.updateStudentPanel.Controls.Add(this.txtStudentID);
            this.updateStudentPanel.Controls.Add(this.Gender);
            this.updateStudentPanel.Controls.Add(this.txtStudentEmail);
            this.updateStudentPanel.Controls.Add(this.Program);
            this.updateStudentPanel.Controls.Add(this.Email);
            this.updateStudentPanel.Controls.Add(this.txtStudentName);
            this.updateStudentPanel.Controls.Add(this.txtPhoneNo);
            this.updateStudentPanel.Controls.Add(this.PhoneNo);
            this.updateStudentPanel.HorizontalScrollbarBarColor = true;
            this.updateStudentPanel.HorizontalScrollbarHighlightOnWheel = false;
            this.updateStudentPanel.HorizontalScrollbarSize = 10;
            this.updateStudentPanel.Location = new System.Drawing.Point(23, 75);
            this.updateStudentPanel.Name = "updateStudentPanel";
            this.updateStudentPanel.Size = new System.Drawing.Size(645, 153);
            this.updateStudentPanel.TabIndex = 23;
            this.updateStudentPanel.VerticalScrollbarBarColor = true;
            this.updateStudentPanel.VerticalScrollbarHighlightOnWheel = false;
            this.updateStudentPanel.VerticalScrollbarSize = 10;
            // 
            // StudentID
            // 
            this.StudentID.AutoSize = true;
            this.StudentID.Location = new System.Drawing.Point(3, 23);
            this.StudentID.Name = "StudentID";
            this.StudentID.Size = new System.Drawing.Size(72, 19);
            this.StudentID.TabIndex = 8;
            this.StudentID.Text = "Student ID:";
            // 
            // StudentName
            // 
            this.StudentName.AutoSize = true;
            this.StudentName.Location = new System.Drawing.Point(3, 63);
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
            this.txtStudentID.Location = new System.Drawing.Point(118, 22);
            this.txtStudentID.MaxLength = 32767;
            this.txtStudentID.Name = "txtStudentID";
            this.txtStudentID.PasswordChar = '\0';
            this.txtStudentID.PromptText = "Enter Student ID";
            this.txtStudentID.ReadOnly = true;
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
            // Gender
            // 
            this.Gender.AutoSize = true;
            this.Gender.Location = new System.Drawing.Point(3, 104);
            this.Gender.Name = "Gender";
            this.Gender.Size = new System.Drawing.Size(56, 19);
            this.Gender.TabIndex = 5;
            this.Gender.Text = "Gender:";
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
            this.txtStudentEmail.Location = new System.Drawing.Point(452, 61);
            this.txtStudentEmail.MaxLength = 32767;
            this.txtStudentEmail.Name = "txtStudentEmail";
            this.txtStudentEmail.PasswordChar = '\0';
            this.txtStudentEmail.PromptText = "Enter Student Email";
            this.txtStudentEmail.ReadOnly = true;
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
            this.Program.Location = new System.Drawing.Point(349, 104);
            this.Program.Name = "Program";
            this.Program.Size = new System.Drawing.Size(65, 19);
            this.Program.TabIndex = 7;
            this.Program.Text = "Program:";
            // 
            // Email
            // 
            this.Email.AutoSize = true;
            this.Email.Location = new System.Drawing.Point(349, 61);
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
            this.txtStudentName.Location = new System.Drawing.Point(118, 61);
            this.txtStudentName.MaxLength = 32767;
            this.txtStudentName.Name = "txtStudentName";
            this.txtStudentName.PasswordChar = '\0';
            this.txtStudentName.PromptText = "Enter Student Name";
            this.txtStudentName.ReadOnly = true;
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
            this.txtPhoneNo.Location = new System.Drawing.Point(452, 22);
            this.txtPhoneNo.MaxLength = 32767;
            this.txtPhoneNo.Name = "txtPhoneNo";
            this.txtPhoneNo.PasswordChar = '\0';
            this.txtPhoneNo.PromptText = "Enter Phone No";
            this.txtPhoneNo.ReadOnly = true;
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
            this.PhoneNo.Location = new System.Drawing.Point(349, 25);
            this.PhoneNo.Name = "PhoneNo";
            this.PhoneNo.Size = new System.Drawing.Size(71, 19);
            this.PhoneNo.TabIndex = 10;
            this.PhoneNo.Text = "Phone No:";
            // 
            // btnBack
            // 
            this.btnBack.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btnBack.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.btnBack.FontSize = MetroFramework.MetroButtonSize.Medium;
            this.btnBack.FontWeight = MetroFramework.MetroButtonWeight.Regular;
            this.btnBack.ForeColor = System.Drawing.Color.White;
            this.btnBack.Location = new System.Drawing.Point(300, 255);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(90, 36);
            this.btnBack.TabIndex = 7;
            this.btnBack.Text = "Back";
            this.btnBack.UseCustomBackColor = true;
            this.btnBack.UseCustomForeColor = true;
            this.btnBack.UseSelectable = true;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // txtStudentProgram
            // 
            // 
            // 
            // 
            this.txtStudentProgram.CustomButton.Image = null;
            this.txtStudentProgram.CustomButton.Location = new System.Drawing.Point(168, 1);
            this.txtStudentProgram.CustomButton.Name = "";
            this.txtStudentProgram.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtStudentProgram.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtStudentProgram.CustomButton.TabIndex = 1;
            this.txtStudentProgram.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtStudentProgram.CustomButton.UseSelectable = true;
            this.txtStudentProgram.CustomButton.Visible = false;
            this.txtStudentProgram.Lines = new string[0];
            this.txtStudentProgram.Location = new System.Drawing.Point(452, 102);
            this.txtStudentProgram.MaxLength = 32767;
            this.txtStudentProgram.Name = "txtStudentProgram";
            this.txtStudentProgram.PasswordChar = '\0';
            this.txtStudentProgram.PromptText = "Enter Student Email";
            this.txtStudentProgram.ReadOnly = true;
            this.txtStudentProgram.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtStudentProgram.SelectedText = "";
            this.txtStudentProgram.SelectionLength = 0;
            this.txtStudentProgram.SelectionStart = 0;
            this.txtStudentProgram.ShortcutsEnabled = true;
            this.txtStudentProgram.Size = new System.Drawing.Size(190, 23);
            this.txtStudentProgram.TabIndex = 4;
            this.txtStudentProgram.UseSelectable = true;
            this.txtStudentProgram.WaterMark = "Enter Student Email";
            this.txtStudentProgram.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtStudentProgram.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // txtStudentGender
            // 
            // 
            // 
            // 
            this.txtStudentGender.CustomButton.Image = null;
            this.txtStudentGender.CustomButton.Location = new System.Drawing.Point(168, 1);
            this.txtStudentGender.CustomButton.Name = "";
            this.txtStudentGender.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtStudentGender.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtStudentGender.CustomButton.TabIndex = 1;
            this.txtStudentGender.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtStudentGender.CustomButton.UseSelectable = true;
            this.txtStudentGender.CustomButton.Visible = false;
            this.txtStudentGender.Lines = new string[0];
            this.txtStudentGender.Location = new System.Drawing.Point(118, 102);
            this.txtStudentGender.MaxLength = 32767;
            this.txtStudentGender.Name = "txtStudentGender";
            this.txtStudentGender.PasswordChar = '\0';
            this.txtStudentGender.PromptText = "Enter Student Name";
            this.txtStudentGender.ReadOnly = true;
            this.txtStudentGender.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtStudentGender.SelectedText = "";
            this.txtStudentGender.SelectionLength = 0;
            this.txtStudentGender.SelectionStart = 0;
            this.txtStudentGender.ShortcutsEnabled = true;
            this.txtStudentGender.Size = new System.Drawing.Size(190, 23);
            this.txtStudentGender.TabIndex = 3;
            this.txtStudentGender.UseSelectable = true;
            this.txtStudentGender.WaterMark = "Enter Student Name";
            this.txtStudentGender.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtStudentGender.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // StudentDetailsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(691, 317);
            this.Controls.Add(this.updateStudentPanel);
            this.Controls.Add(this.btnBack);
            this.MaximizeBox = false;
            this.Name = "StudentDetailsForm";
            this.Resizable = false;
            this.Text = "Student Details";
            this.Load += new System.EventHandler(this.StudentDetailsForm_Load);
            this.updateStudentPanel.ResumeLayout(false);
            this.updateStudentPanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private MetroFramework.Controls.MetroPanel updateStudentPanel;
        private MetroFramework.Controls.MetroLabel StudentID;
        private MetroFramework.Controls.MetroLabel StudentName;
        private MetroFramework.Controls.MetroTextBox txtStudentID;
        private MetroFramework.Controls.MetroLabel Gender;
        private MetroFramework.Controls.MetroTextBox txtStudentEmail;
        private MetroFramework.Controls.MetroLabel Program;
        private MetroFramework.Controls.MetroLabel Email;
        private MetroFramework.Controls.MetroTextBox txtStudentName;
        private MetroFramework.Controls.MetroTextBox txtPhoneNo;
        private MetroFramework.Controls.MetroLabel PhoneNo;
        private MetroFramework.Controls.MetroButton btnBack;
        private MetroFramework.Controls.MetroTextBox txtStudentProgram;
        private MetroFramework.Controls.MetroTextBox txtStudentGender;
    }
}