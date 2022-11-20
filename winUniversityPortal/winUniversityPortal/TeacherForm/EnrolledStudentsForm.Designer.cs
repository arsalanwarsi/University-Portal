
namespace winUniversityPortal.TeacherForm
{
    partial class EnrolledStudentsForm
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
            this.enrolledStudentPanel = new MetroFramework.Controls.MetroPanel();
            this.gvShowStudents = new System.Windows.Forms.DataGridView();
            this.btnBack = new MetroFramework.Controls.MetroButton();
            this.enrolledStudentPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gvShowStudents)).BeginInit();
            this.SuspendLayout();
            // 
            // enrolledStudentPanel
            // 
            this.enrolledStudentPanel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.enrolledStudentPanel.Controls.Add(this.gvShowStudents);
            this.enrolledStudentPanel.HorizontalScrollbarBarColor = true;
            this.enrolledStudentPanel.HorizontalScrollbarHighlightOnWheel = false;
            this.enrolledStudentPanel.HorizontalScrollbarSize = 10;
            this.enrolledStudentPanel.Location = new System.Drawing.Point(23, 63);
            this.enrolledStudentPanel.Name = "enrolledStudentPanel";
            this.enrolledStudentPanel.Size = new System.Drawing.Size(591, 264);
            this.enrolledStudentPanel.TabIndex = 29;
            this.enrolledStudentPanel.VerticalScrollbarBarColor = true;
            this.enrolledStudentPanel.VerticalScrollbarHighlightOnWheel = false;
            this.enrolledStudentPanel.VerticalScrollbarSize = 10;
            // 
            // gvShowStudents
            // 
            this.gvShowStudents.AllowUserToAddRows = false;
            this.gvShowStudents.AllowUserToDeleteRows = false;
            this.gvShowStudents.AllowUserToResizeRows = false;
            this.gvShowStudents.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gvShowStudents.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.gvShowStudents.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gvShowStudents.Location = new System.Drawing.Point(3, 3);
            this.gvShowStudents.Name = "gvShowStudents";
            this.gvShowStudents.ReadOnly = true;
            this.gvShowStudents.RowHeadersVisible = false;
            this.gvShowStudents.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.gvShowStudents.Size = new System.Drawing.Size(585, 258);
            this.gvShowStudents.TabIndex = 9;
            // 
            // btnBack
            // 
            this.btnBack.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btnBack.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.btnBack.FontSize = MetroFramework.MetroButtonSize.Medium;
            this.btnBack.FontWeight = MetroFramework.MetroButtonWeight.Regular;
            this.btnBack.ForeColor = System.Drawing.Color.White;
            this.btnBack.Location = new System.Drawing.Point(273, 344);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(90, 36);
            this.btnBack.TabIndex = 28;
            this.btnBack.Text = "Back";
            this.btnBack.UseCustomBackColor = true;
            this.btnBack.UseCustomForeColor = true;
            this.btnBack.UseSelectable = true;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // EnrolledStudentsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(637, 403);
            this.Controls.Add(this.enrolledStudentPanel);
            this.Controls.Add(this.btnBack);
            this.Name = "EnrolledStudentsForm";
            this.Text = "Enrolled Students";
            this.Load += new System.EventHandler(this.EnrolledStudentsForm_Load);
            this.enrolledStudentPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gvShowStudents)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private MetroFramework.Controls.MetroPanel enrolledStudentPanel;
        private System.Windows.Forms.DataGridView gvShowStudents;
        private MetroFramework.Controls.MetroButton btnBack;
    }
}