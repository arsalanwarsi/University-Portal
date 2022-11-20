
namespace winUniversityPortal
{
    partial class LoginForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LoginForm));
            this.pbStudent = new System.Windows.Forms.PictureBox();
            this.labStudent = new MetroFramework.Controls.MetroLabel();
            this.pbTeacher = new System.Windows.Forms.PictureBox();
            this.labAdmin = new MetroFramework.Controls.MetroLabel();
            this.pbAdmin = new System.Windows.Forms.PictureBox();
            this.labTeacher = new MetroFramework.Controls.MetroLabel();
            ((System.ComponentModel.ISupportInitialize)(this.pbStudent)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbTeacher)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbAdmin)).BeginInit();
            this.SuspendLayout();
            // 
            // pbStudent
            // 
            this.pbStudent.Image = ((System.Drawing.Image)(resources.GetObject("pbStudent.Image")));
            this.pbStudent.Location = new System.Drawing.Point(23, 72);
            this.pbStudent.Name = "pbStudent";
            this.pbStudent.Size = new System.Drawing.Size(100, 100);
            this.pbStudent.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbStudent.TabIndex = 0;
            this.pbStudent.TabStop = false;
            this.pbStudent.Click += new System.EventHandler(this.pbStudent_Click);
            // 
            // labStudent
            // 
            this.labStudent.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.labStudent.Location = new System.Drawing.Point(23, 186);
            this.labStudent.Name = "labStudent";
            this.labStudent.Size = new System.Drawing.Size(100, 25);
            this.labStudent.TabIndex = 1;
            this.labStudent.Text = "Student";
            this.labStudent.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.labStudent.Click += new System.EventHandler(this.labStudent_Click);
            // 
            // pbTeacher
            // 
            this.pbTeacher.Image = ((System.Drawing.Image)(resources.GetObject("pbTeacher.Image")));
            this.pbTeacher.Location = new System.Drawing.Point(150, 72);
            this.pbTeacher.Name = "pbTeacher";
            this.pbTeacher.Size = new System.Drawing.Size(100, 100);
            this.pbTeacher.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbTeacher.TabIndex = 2;
            this.pbTeacher.TabStop = false;
            this.pbTeacher.Click += new System.EventHandler(this.pbTeacher_Click);
            // 
            // labAdmin
            // 
            this.labAdmin.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.labAdmin.Location = new System.Drawing.Point(277, 186);
            this.labAdmin.Name = "labAdmin";
            this.labAdmin.Size = new System.Drawing.Size(100, 25);
            this.labAdmin.TabIndex = 3;
            this.labAdmin.Text = "Admin";
            this.labAdmin.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.labAdmin.Click += new System.EventHandler(this.labAdmin_Click);
            // 
            // pbAdmin
            // 
            this.pbAdmin.Image = ((System.Drawing.Image)(resources.GetObject("pbAdmin.Image")));
            this.pbAdmin.Location = new System.Drawing.Point(277, 72);
            this.pbAdmin.Name = "pbAdmin";
            this.pbAdmin.Size = new System.Drawing.Size(100, 100);
            this.pbAdmin.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbAdmin.TabIndex = 4;
            this.pbAdmin.TabStop = false;
            this.pbAdmin.Click += new System.EventHandler(this.pbAdmin_Click);
            // 
            // labTeacher
            // 
            this.labTeacher.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.labTeacher.Location = new System.Drawing.Point(150, 186);
            this.labTeacher.Name = "labTeacher";
            this.labTeacher.Size = new System.Drawing.Size(100, 25);
            this.labTeacher.TabIndex = 2;
            this.labTeacher.Text = "Teacher";
            this.labTeacher.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.labTeacher.Click += new System.EventHandler(this.labTeacher_Click);
            // 
            // LoginForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(400, 240);
            this.Controls.Add(this.labTeacher);
            this.Controls.Add(this.labAdmin);
            this.Controls.Add(this.pbAdmin);
            this.Controls.Add(this.pbTeacher);
            this.Controls.Add(this.labStudent);
            this.Controls.Add(this.pbStudent);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "LoginForm";
            this.Resizable = false;
            this.Text = "Login";
            ((System.ComponentModel.ISupportInitialize)(this.pbStudent)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbTeacher)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbAdmin)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pbStudent;
        private MetroFramework.Controls.MetroLabel labStudent;
        private System.Windows.Forms.PictureBox pbTeacher;
        private MetroFramework.Controls.MetroLabel labAdmin;
        private System.Windows.Forms.PictureBox pbAdmin;
        private MetroFramework.Controls.MetroLabel labTeacher;
    }
}

