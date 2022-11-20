
namespace winUniversityPortal.TeacherForm
{
    partial class CourseForm
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
            this.coursesPanel = new MetroFramework.Controls.MetroPanel();
            this.gvShowCourses = new System.Windows.Forms.DataGridView();
            this.Courses = new MetroFramework.Controls.MetroLabel();
            this.btnBack = new MetroFramework.Controls.MetroButton();
            this.coursesPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gvShowCourses)).BeginInit();
            this.SuspendLayout();
            // 
            // coursesPanel
            // 
            this.coursesPanel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.coursesPanel.Controls.Add(this.gvShowCourses);
            this.coursesPanel.Controls.Add(this.Courses);
            this.coursesPanel.HorizontalScrollbarBarColor = true;
            this.coursesPanel.HorizontalScrollbarHighlightOnWheel = false;
            this.coursesPanel.HorizontalScrollbarSize = 10;
            this.coursesPanel.Location = new System.Drawing.Point(22, 63);
            this.coursesPanel.Name = "coursesPanel";
            this.coursesPanel.Size = new System.Drawing.Size(704, 263);
            this.coursesPanel.TabIndex = 29;
            this.coursesPanel.VerticalScrollbarBarColor = true;
            this.coursesPanel.VerticalScrollbarHighlightOnWheel = false;
            this.coursesPanel.VerticalScrollbarSize = 10;
            // 
            // gvShowCourses
            // 
            this.gvShowCourses.AllowUserToAddRows = false;
            this.gvShowCourses.AllowUserToDeleteRows = false;
            this.gvShowCourses.AllowUserToResizeRows = false;
            this.gvShowCourses.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gvShowCourses.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.gvShowCourses.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gvShowCourses.Location = new System.Drawing.Point(3, 44);
            this.gvShowCourses.Name = "gvShowCourses";
            this.gvShowCourses.ReadOnly = true;
            this.gvShowCourses.RowHeadersVisible = false;
            this.gvShowCourses.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.gvShowCourses.Size = new System.Drawing.Size(698, 216);
            this.gvShowCourses.TabIndex = 9;
            this.gvShowCourses.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.gvShowCourses_CellDoubleClick);
            // 
            // Courses
            // 
            this.Courses.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.Courses.AutoSize = true;
            this.Courses.Location = new System.Drawing.Point(162, 14);
            this.Courses.Name = "Courses";
            this.Courses.Size = new System.Drawing.Size(380, 19);
            this.Courses.TabIndex = 8;
            this.Courses.Text = "Double Click On Course To See Students Enrolled In The Course";
            // 
            // btnBack
            // 
            this.btnBack.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btnBack.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.btnBack.FontSize = MetroFramework.MetroButtonSize.Medium;
            this.btnBack.FontWeight = MetroFramework.MetroButtonWeight.Regular;
            this.btnBack.ForeColor = System.Drawing.Color.White;
            this.btnBack.Location = new System.Drawing.Point(330, 332);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(90, 36);
            this.btnBack.TabIndex = 1;
            this.btnBack.Text = "Back";
            this.btnBack.UseCustomBackColor = true;
            this.btnBack.UseCustomForeColor = true;
            this.btnBack.UseSelectable = true;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // CourseForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(750, 391);
            this.Controls.Add(this.coursesPanel);
            this.Controls.Add(this.btnBack);
            this.Name = "CourseForm";
            this.Text = "Courses";
            this.Load += new System.EventHandler(this.CourseForm_Load);
            this.coursesPanel.ResumeLayout(false);
            this.coursesPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gvShowCourses)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private MetroFramework.Controls.MetroPanel coursesPanel;
        private System.Windows.Forms.DataGridView gvShowCourses;
        private MetroFramework.Controls.MetroLabel Courses;
        private MetroFramework.Controls.MetroButton btnBack;
    }
}