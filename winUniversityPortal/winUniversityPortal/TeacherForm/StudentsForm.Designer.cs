
namespace winUniversityPortal.TeacherForm
{
    partial class StudentsForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(StudentsForm));
            this.CourseStudentsPanel = new MetroFramework.Controls.MetroPanel();
            this.cbSelectCourse = new MetroFramework.Controls.MetroComboBox();
            this.Course = new MetroFramework.Controls.MetroLabel();
            this.gvStudents = new System.Windows.Forms.DataGridView();
            this.btnBack = new MetroFramework.Controls.MetroButton();
            this.btnUpdate = new MetroFramework.Controls.MetroButton();
            this.btnSelectCourse = new MetroFramework.Controls.MetroButton();
            this.CourseStudentsPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gvStudents)).BeginInit();
            this.SuspendLayout();
            // 
            // CourseStudentsPanel
            // 
            this.CourseStudentsPanel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.CourseStudentsPanel.Controls.Add(this.btnSelectCourse);
            this.CourseStudentsPanel.Controls.Add(this.cbSelectCourse);
            this.CourseStudentsPanel.Controls.Add(this.Course);
            this.CourseStudentsPanel.Controls.Add(this.gvStudents);
            this.CourseStudentsPanel.HorizontalScrollbarBarColor = true;
            this.CourseStudentsPanel.HorizontalScrollbarHighlightOnWheel = false;
            this.CourseStudentsPanel.HorizontalScrollbarSize = 10;
            this.CourseStudentsPanel.Location = new System.Drawing.Point(23, 63);
            this.CourseStudentsPanel.Name = "CourseStudentsPanel";
            this.CourseStudentsPanel.Size = new System.Drawing.Size(675, 313);
            this.CourseStudentsPanel.TabIndex = 0;
            this.CourseStudentsPanel.VerticalScrollbarBarColor = true;
            this.CourseStudentsPanel.VerticalScrollbarHighlightOnWheel = false;
            this.CourseStudentsPanel.VerticalScrollbarSize = 10;
            // 
            // cbSelectCourse
            // 
            this.cbSelectCourse.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.cbSelectCourse.FormattingEnabled = true;
            this.cbSelectCourse.ItemHeight = 23;
            this.cbSelectCourse.Location = new System.Drawing.Point(224, 14);
            this.cbSelectCourse.Name = "cbSelectCourse";
            this.cbSelectCourse.PromptText = "Select Course";
            this.cbSelectCourse.Size = new System.Drawing.Size(190, 29);
            this.cbSelectCourse.TabIndex = 8;
            this.cbSelectCourse.UseSelectable = true;
            // 
            // Course
            // 
            this.Course.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.Course.AutoSize = true;
            this.Course.Location = new System.Drawing.Point(147, 19);
            this.Course.Name = "Course";
            this.Course.Size = new System.Drawing.Size(53, 19);
            this.Course.TabIndex = 9;
            this.Course.Text = "Course:";
            // 
            // gvStudents
            // 
            this.gvStudents.AllowUserToAddRows = false;
            this.gvStudents.AllowUserToDeleteRows = false;
            this.gvStudents.AllowUserToResizeRows = false;
            this.gvStudents.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gvStudents.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.gvStudents.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gvStudents.Location = new System.Drawing.Point(3, 60);
            this.gvStudents.Name = "gvStudents";
            this.gvStudents.ReadOnly = true;
            this.gvStudents.RowHeadersVisible = false;
            this.gvStudents.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.gvStudents.Size = new System.Drawing.Size(669, 250);
            this.gvStudents.TabIndex = 2;
            this.gvStudents.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.gvStudents_CellClick);
            // 
            // btnBack
            // 
            this.btnBack.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btnBack.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.btnBack.FontSize = MetroFramework.MetroButtonSize.Medium;
            this.btnBack.FontWeight = MetroFramework.MetroButtonWeight.Regular;
            this.btnBack.ForeColor = System.Drawing.Color.White;
            this.btnBack.Location = new System.Drawing.Point(249, 391);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(90, 36);
            this.btnBack.TabIndex = 11;
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
            this.btnUpdate.Location = new System.Drawing.Point(383, 391);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(90, 36);
            this.btnUpdate.TabIndex = 10;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.UseCustomBackColor = true;
            this.btnUpdate.UseCustomForeColor = true;
            this.btnUpdate.UseSelectable = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // btnSelectCourse
            // 
            this.btnSelectCourse.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnSelectCourse.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.btnSelectCourse.FontSize = MetroFramework.MetroButtonSize.Medium;
            this.btnSelectCourse.FontWeight = MetroFramework.MetroButtonWeight.Regular;
            this.btnSelectCourse.ForeColor = System.Drawing.Color.White;
            this.btnSelectCourse.Location = new System.Drawing.Point(446, 11);
            this.btnSelectCourse.Name = "btnSelectCourse";
            this.btnSelectCourse.Size = new System.Drawing.Size(90, 36);
            this.btnSelectCourse.TabIndex = 12;
            this.btnSelectCourse.Text = "Select";
            this.btnSelectCourse.UseCustomBackColor = true;
            this.btnSelectCourse.UseCustomForeColor = true;
            this.btnSelectCourse.UseSelectable = true;
            this.btnSelectCourse.Click += new System.EventHandler(this.btnSelectCourse_Click);
            // 
            // StudentsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(721, 450);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.CourseStudentsPanel);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "StudentsForm";
            this.Text = "Students";
            this.Load += new System.EventHandler(this.StudentsForm_Load);
            this.CourseStudentsPanel.ResumeLayout(false);
            this.CourseStudentsPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gvStudents)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private MetroFramework.Controls.MetroPanel CourseStudentsPanel;
        private System.Windows.Forms.DataGridView gvStudents;
        private MetroFramework.Controls.MetroComboBox cbSelectCourse;
        private MetroFramework.Controls.MetroLabel Course;
        private MetroFramework.Controls.MetroButton btnBack;
        private MetroFramework.Controls.MetroButton btnUpdate;
        private MetroFramework.Controls.MetroButton btnSelectCourse;
    }
}