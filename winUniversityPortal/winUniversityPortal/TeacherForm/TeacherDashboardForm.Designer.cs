
namespace winUniversityPortal.TeacherForm
{
    partial class TeacherDashboardForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TeacherDashboardForm));
            this.TeacherPanel = new MetroFramework.Controls.MetroPanel();
            this.btnStudentDetails = new MetroFramework.Controls.MetroButton();
            this.btnExit = new MetroFramework.Controls.MetroButton();
            this.btnChangePassword = new MetroFramework.Controls.MetroButton();
            this.btnStudentDetail = new MetroFramework.Controls.MetroButton();
            this.btnLogout = new MetroFramework.Controls.MetroButton();
            this.btnCourses = new MetroFramework.Controls.MetroButton();
            this.bhtNotics = new MetroFramework.Controls.MetroButton();
            this.btnAnnouncement = new MetroFramework.Controls.MetroButton();
            this.TeacherPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // TeacherPanel
            // 
            this.TeacherPanel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.TeacherPanel.Controls.Add(this.btnStudentDetails);
            this.TeacherPanel.Controls.Add(this.btnExit);
            this.TeacherPanel.Controls.Add(this.btnChangePassword);
            this.TeacherPanel.Controls.Add(this.btnStudentDetail);
            this.TeacherPanel.Controls.Add(this.btnLogout);
            this.TeacherPanel.Controls.Add(this.btnCourses);
            this.TeacherPanel.Controls.Add(this.bhtNotics);
            this.TeacherPanel.Controls.Add(this.btnAnnouncement);
            this.TeacherPanel.HorizontalScrollbarBarColor = true;
            this.TeacherPanel.HorizontalScrollbarHighlightOnWheel = false;
            this.TeacherPanel.HorizontalScrollbarSize = 10;
            this.TeacherPanel.Location = new System.Drawing.Point(23, 73);
            this.TeacherPanel.Name = "TeacherPanel";
            this.TeacherPanel.Size = new System.Drawing.Size(502, 235);
            this.TeacherPanel.TabIndex = 9;
            this.TeacherPanel.VerticalScrollbarBarColor = true;
            this.TeacherPanel.VerticalScrollbarHighlightOnWheel = false;
            this.TeacherPanel.VerticalScrollbarSize = 10;
            // 
            // btnStudentDetails
            // 
            this.btnStudentDetails.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.btnStudentDetails.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnStudentDetails.BackgroundImage")));
            this.btnStudentDetails.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnStudentDetails.FontSize = MetroFramework.MetroButtonSize.Tall;
            this.btnStudentDetails.FontWeight = MetroFramework.MetroButtonWeight.Regular;
            this.btnStudentDetails.ForeColor = System.Drawing.Color.White;
            this.btnStudentDetails.Location = new System.Drawing.Point(3, 132);
            this.btnStudentDetails.Name = "btnStudentDetails";
            this.btnStudentDetails.Size = new System.Drawing.Size(100, 100);
            this.btnStudentDetails.TabIndex = 4;
            this.btnStudentDetails.Text = "Students";
            this.btnStudentDetails.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            this.btnStudentDetails.UseCustomBackColor = true;
            this.btnStudentDetails.UseCustomForeColor = true;
            this.btnStudentDetails.UseSelectable = true;
            this.btnStudentDetails.UseStyleColors = true;
            this.btnStudentDetails.Click += new System.EventHandler(this.btnStudentDetails_Click);
            // 
            // btnExit
            // 
            this.btnExit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.btnExit.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnExit.BackgroundImage")));
            this.btnExit.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnExit.FontSize = MetroFramework.MetroButtonSize.Tall;
            this.btnExit.FontWeight = MetroFramework.MetroButtonWeight.Regular;
            this.btnExit.ForeColor = System.Drawing.Color.White;
            this.btnExit.Location = new System.Drawing.Point(399, 132);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(100, 100);
            this.btnExit.TabIndex = 7;
            this.btnExit.Text = "Exit";
            this.btnExit.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            this.btnExit.UseCustomBackColor = true;
            this.btnExit.UseCustomForeColor = true;
            this.btnExit.UseSelectable = true;
            this.btnExit.UseStyleColors = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // btnChangePassword
            // 
            this.btnChangePassword.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.btnChangePassword.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnChangePassword.BackgroundImage")));
            this.btnChangePassword.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnChangePassword.FontSize = MetroFramework.MetroButtonSize.Tall;
            this.btnChangePassword.FontWeight = MetroFramework.MetroButtonWeight.Regular;
            this.btnChangePassword.ForeColor = System.Drawing.Color.White;
            this.btnChangePassword.Location = new System.Drawing.Point(135, 132);
            this.btnChangePassword.Name = "btnChangePassword";
            this.btnChangePassword.Size = new System.Drawing.Size(100, 100);
            this.btnChangePassword.TabIndex = 5;
            this.btnChangePassword.Text = "Password";
            this.btnChangePassword.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            this.btnChangePassword.UseCustomBackColor = true;
            this.btnChangePassword.UseCustomForeColor = true;
            this.btnChangePassword.UseSelectable = true;
            this.btnChangePassword.UseStyleColors = true;
            this.btnChangePassword.Click += new System.EventHandler(this.btnChangePassword_Click);
            // 
            // btnStudentDetail
            // 
            this.btnStudentDetail.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.btnStudentDetail.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnStudentDetail.BackgroundImage")));
            this.btnStudentDetail.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnStudentDetail.FontSize = MetroFramework.MetroButtonSize.Tall;
            this.btnStudentDetail.FontWeight = MetroFramework.MetroButtonWeight.Regular;
            this.btnStudentDetail.ForeColor = System.Drawing.Color.White;
            this.btnStudentDetail.Location = new System.Drawing.Point(3, 3);
            this.btnStudentDetail.Name = "btnStudentDetail";
            this.btnStudentDetail.Size = new System.Drawing.Size(100, 100);
            this.btnStudentDetail.TabIndex = 0;
            this.btnStudentDetail.Text = "Details";
            this.btnStudentDetail.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            this.btnStudentDetail.UseCustomBackColor = true;
            this.btnStudentDetail.UseCustomForeColor = true;
            this.btnStudentDetail.UseSelectable = true;
            this.btnStudentDetail.UseStyleColors = true;
            this.btnStudentDetail.Click += new System.EventHandler(this.btnStudentDetail_Click);
            // 
            // btnLogout
            // 
            this.btnLogout.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.btnLogout.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnLogout.BackgroundImage")));
            this.btnLogout.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnLogout.FontSize = MetroFramework.MetroButtonSize.Tall;
            this.btnLogout.FontWeight = MetroFramework.MetroButtonWeight.Regular;
            this.btnLogout.ForeColor = System.Drawing.Color.White;
            this.btnLogout.Location = new System.Drawing.Point(267, 132);
            this.btnLogout.Name = "btnLogout";
            this.btnLogout.Size = new System.Drawing.Size(100, 100);
            this.btnLogout.TabIndex = 6;
            this.btnLogout.Text = "Logout";
            this.btnLogout.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            this.btnLogout.UseCustomBackColor = true;
            this.btnLogout.UseCustomForeColor = true;
            this.btnLogout.UseSelectable = true;
            this.btnLogout.UseStyleColors = true;
            this.btnLogout.Click += new System.EventHandler(this.btnLogout_Click);
            // 
            // btnCourses
            // 
            this.btnCourses.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.btnCourses.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnCourses.BackgroundImage")));
            this.btnCourses.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnCourses.FontSize = MetroFramework.MetroButtonSize.Tall;
            this.btnCourses.FontWeight = MetroFramework.MetroButtonWeight.Regular;
            this.btnCourses.ForeColor = System.Drawing.Color.White;
            this.btnCourses.Location = new System.Drawing.Point(135, 3);
            this.btnCourses.Name = "btnCourses";
            this.btnCourses.Size = new System.Drawing.Size(100, 100);
            this.btnCourses.TabIndex = 1;
            this.btnCourses.Text = "Courses";
            this.btnCourses.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            this.btnCourses.UseCustomBackColor = true;
            this.btnCourses.UseCustomForeColor = true;
            this.btnCourses.UseSelectable = true;
            this.btnCourses.UseStyleColors = true;
            this.btnCourses.Click += new System.EventHandler(this.btnCourses_Click);
            // 
            // bhtNotics
            // 
            this.bhtNotics.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.bhtNotics.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bhtNotics.BackgroundImage")));
            this.bhtNotics.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.bhtNotics.FontSize = MetroFramework.MetroButtonSize.Tall;
            this.bhtNotics.FontWeight = MetroFramework.MetroButtonWeight.Regular;
            this.bhtNotics.ForeColor = System.Drawing.Color.White;
            this.bhtNotics.Location = new System.Drawing.Point(399, 3);
            this.bhtNotics.Name = "bhtNotics";
            this.bhtNotics.Size = new System.Drawing.Size(100, 100);
            this.bhtNotics.TabIndex = 3;
            this.bhtNotics.Text = "Notice";
            this.bhtNotics.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            this.bhtNotics.UseCustomBackColor = true;
            this.bhtNotics.UseCustomForeColor = true;
            this.bhtNotics.UseSelectable = true;
            this.bhtNotics.UseStyleColors = true;
            this.bhtNotics.Click += new System.EventHandler(this.bhtNotics_Click);
            // 
            // btnAnnouncement
            // 
            this.btnAnnouncement.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.btnAnnouncement.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnAnnouncement.BackgroundImage")));
            this.btnAnnouncement.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnAnnouncement.FontSize = MetroFramework.MetroButtonSize.Tall;
            this.btnAnnouncement.FontWeight = MetroFramework.MetroButtonWeight.Regular;
            this.btnAnnouncement.ForeColor = System.Drawing.Color.White;
            this.btnAnnouncement.Location = new System.Drawing.Point(267, 3);
            this.btnAnnouncement.Name = "btnAnnouncement";
            this.btnAnnouncement.Size = new System.Drawing.Size(100, 100);
            this.btnAnnouncement.TabIndex = 2;
            this.btnAnnouncement.Text = "Message";
            this.btnAnnouncement.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            this.btnAnnouncement.UseCustomBackColor = true;
            this.btnAnnouncement.UseCustomForeColor = true;
            this.btnAnnouncement.UseSelectable = true;
            this.btnAnnouncement.UseStyleColors = true;
            this.btnAnnouncement.Click += new System.EventHandler(this.btnAnnouncement_Click);
            // 
            // TeacherDashboardForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(548, 331);
            this.Controls.Add(this.TeacherPanel);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "TeacherDashboardForm";
            this.Text = "Teacher Dashboard";
            this.TeacherPanel.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private MetroFramework.Controls.MetroPanel TeacherPanel;
        private MetroFramework.Controls.MetroButton btnExit;
        private MetroFramework.Controls.MetroButton btnChangePassword;
        private MetroFramework.Controls.MetroButton btnStudentDetail;
        private MetroFramework.Controls.MetroButton btnLogout;
        private MetroFramework.Controls.MetroButton btnCourses;
        private MetroFramework.Controls.MetroButton bhtNotics;
        private MetroFramework.Controls.MetroButton btnAnnouncement;
        private MetroFramework.Controls.MetroButton btnStudentDetails;
    }
}