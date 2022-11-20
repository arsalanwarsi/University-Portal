
namespace winUniversityPortal.TeacherForm
{
    partial class ManageAnnouncementForm
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
            this.tabManageTeacher = new MetroFramework.Controls.MetroTabControl();
            this.tabAddAnnouncement = new MetroFramework.Controls.MetroTabPage();
            this.addAnnouncementPanel = new MetroFramework.Controls.MetroPanel();
            this.Announcement = new MetroFramework.Controls.MetroLabel();
            this.txtAnnouncement = new MetroFramework.Controls.MetroTextBox();
            this.cbSelectCourse = new MetroFramework.Controls.MetroComboBox();
            this.Course = new MetroFramework.Controls.MetroLabel();
            this.btnBack = new MetroFramework.Controls.MetroButton();
            this.btnSave = new MetroFramework.Controls.MetroButton();
            this.tabDeleteAnnouncement = new MetroFramework.Controls.MetroTabPage();
            this.deleteAnnouncementPanel = new MetroFramework.Controls.MetroPanel();
            this.gvAnnouncDetails = new System.Windows.Forms.DataGridView();
            this.btnDeleteAnn = new MetroFramework.Controls.MetroButton();
            this.btnBack1 = new MetroFramework.Controls.MetroButton();
            this.tabManageTeacher.SuspendLayout();
            this.tabAddAnnouncement.SuspendLayout();
            this.addAnnouncementPanel.SuspendLayout();
            this.tabDeleteAnnouncement.SuspendLayout();
            this.deleteAnnouncementPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gvAnnouncDetails)).BeginInit();
            this.SuspendLayout();
            // 
            // tabManageTeacher
            // 
            this.tabManageTeacher.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tabManageTeacher.Controls.Add(this.tabAddAnnouncement);
            this.tabManageTeacher.Controls.Add(this.tabDeleteAnnouncement);
            this.tabManageTeacher.Location = new System.Drawing.Point(23, 63);
            this.tabManageTeacher.Name = "tabManageTeacher";
            this.tabManageTeacher.SelectedIndex = 1;
            this.tabManageTeacher.Size = new System.Drawing.Size(754, 385);
            this.tabManageTeacher.TabIndex = 2;
            this.tabManageTeacher.UseSelectable = true;
            // 
            // tabAddAnnouncement
            // 
            this.tabAddAnnouncement.Controls.Add(this.addAnnouncementPanel);
            this.tabAddAnnouncement.Controls.Add(this.btnBack);
            this.tabAddAnnouncement.Controls.Add(this.btnSave);
            this.tabAddAnnouncement.HorizontalScrollbarBarColor = true;
            this.tabAddAnnouncement.HorizontalScrollbarHighlightOnWheel = false;
            this.tabAddAnnouncement.HorizontalScrollbarSize = 10;
            this.tabAddAnnouncement.Location = new System.Drawing.Point(4, 38);
            this.tabAddAnnouncement.Name = "tabAddAnnouncement";
            this.tabAddAnnouncement.Size = new System.Drawing.Size(746, 343);
            this.tabAddAnnouncement.TabIndex = 0;
            this.tabAddAnnouncement.Text = "Add Announcement";
            this.tabAddAnnouncement.VerticalScrollbarBarColor = true;
            this.tabAddAnnouncement.VerticalScrollbarHighlightOnWheel = false;
            this.tabAddAnnouncement.VerticalScrollbarSize = 10;
            // 
            // addAnnouncementPanel
            // 
            this.addAnnouncementPanel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.addAnnouncementPanel.Controls.Add(this.Announcement);
            this.addAnnouncementPanel.Controls.Add(this.txtAnnouncement);
            this.addAnnouncementPanel.Controls.Add(this.cbSelectCourse);
            this.addAnnouncementPanel.Controls.Add(this.Course);
            this.addAnnouncementPanel.HorizontalScrollbarBarColor = true;
            this.addAnnouncementPanel.HorizontalScrollbarHighlightOnWheel = false;
            this.addAnnouncementPanel.HorizontalScrollbarSize = 10;
            this.addAnnouncementPanel.Location = new System.Drawing.Point(3, 3);
            this.addAnnouncementPanel.Name = "addAnnouncementPanel";
            this.addAnnouncementPanel.Size = new System.Drawing.Size(740, 295);
            this.addAnnouncementPanel.TabIndex = 18;
            this.addAnnouncementPanel.VerticalScrollbarBarColor = true;
            this.addAnnouncementPanel.VerticalScrollbarHighlightOnWheel = false;
            this.addAnnouncementPanel.VerticalScrollbarSize = 10;
            // 
            // Announcement
            // 
            this.Announcement.AutoSize = true;
            this.Announcement.Location = new System.Drawing.Point(20, 25);
            this.Announcement.Name = "Announcement";
            this.Announcement.Size = new System.Drawing.Size(100, 19);
            this.Announcement.TabIndex = 8;
            this.Announcement.Text = "Announcement:";
            // 
            // txtAnnouncement
            // 
            this.txtAnnouncement.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            // 
            // 
            // 
            this.txtAnnouncement.CustomButton.Image = null;
            this.txtAnnouncement.CustomButton.Location = new System.Drawing.Point(28, 2);
            this.txtAnnouncement.CustomButton.Name = "";
            this.txtAnnouncement.CustomButton.Size = new System.Drawing.Size(245, 245);
            this.txtAnnouncement.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtAnnouncement.CustomButton.TabIndex = 1;
            this.txtAnnouncement.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtAnnouncement.CustomButton.UseSelectable = true;
            this.txtAnnouncement.CustomButton.Visible = false;
            this.txtAnnouncement.Lines = new string[0];
            this.txtAnnouncement.Location = new System.Drawing.Point(146, 25);
            this.txtAnnouncement.MaxLength = 32767;
            this.txtAnnouncement.Multiline = true;
            this.txtAnnouncement.Name = "txtAnnouncement";
            this.txtAnnouncement.PasswordChar = '\0';
            this.txtAnnouncement.PromptText = "Enter Description";
            this.txtAnnouncement.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtAnnouncement.SelectedText = "";
            this.txtAnnouncement.SelectionLength = 0;
            this.txtAnnouncement.SelectionStart = 0;
            this.txtAnnouncement.ShortcutsEnabled = true;
            this.txtAnnouncement.Size = new System.Drawing.Size(276, 250);
            this.txtAnnouncement.TabIndex = 1;
            this.txtAnnouncement.UseSelectable = true;
            this.txtAnnouncement.WaterMark = "Enter Description";
            this.txtAnnouncement.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtAnnouncement.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // cbSelectCourse
            // 
            this.cbSelectCourse.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.cbSelectCourse.FormattingEnabled = true;
            this.cbSelectCourse.ItemHeight = 23;
            this.cbSelectCourse.Location = new System.Drawing.Point(529, 129);
            this.cbSelectCourse.Name = "cbSelectCourse";
            this.cbSelectCourse.PromptText = "Select Course";
            this.cbSelectCourse.Size = new System.Drawing.Size(190, 29);
            this.cbSelectCourse.TabIndex = 1;
            this.cbSelectCourse.UseSelectable = true;
            // 
            // Course
            // 
            this.Course.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.Course.AutoSize = true;
            this.Course.Location = new System.Drawing.Point(452, 134);
            this.Course.Name = "Course";
            this.Course.Size = new System.Drawing.Size(53, 19);
            this.Course.TabIndex = 7;
            this.Course.Text = "Course:";
            // 
            // btnBack
            // 
            this.btnBack.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btnBack.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.btnBack.FontSize = MetroFramework.MetroButtonSize.Medium;
            this.btnBack.FontWeight = MetroFramework.MetroButtonWeight.Regular;
            this.btnBack.ForeColor = System.Drawing.Color.White;
            this.btnBack.Location = new System.Drawing.Point(261, 304);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(90, 36);
            this.btnBack.TabIndex = 4;
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
            this.btnSave.Location = new System.Drawing.Point(395, 304);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(90, 36);
            this.btnSave.TabIndex = 3;
            this.btnSave.Text = "Save";
            this.btnSave.UseCustomBackColor = true;
            this.btnSave.UseCustomForeColor = true;
            this.btnSave.UseSelectable = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // tabDeleteAnnouncement
            // 
            this.tabDeleteAnnouncement.Controls.Add(this.deleteAnnouncementPanel);
            this.tabDeleteAnnouncement.Controls.Add(this.btnDeleteAnn);
            this.tabDeleteAnnouncement.Controls.Add(this.btnBack1);
            this.tabDeleteAnnouncement.HorizontalScrollbarBarColor = true;
            this.tabDeleteAnnouncement.HorizontalScrollbarHighlightOnWheel = false;
            this.tabDeleteAnnouncement.HorizontalScrollbarSize = 10;
            this.tabDeleteAnnouncement.Location = new System.Drawing.Point(4, 38);
            this.tabDeleteAnnouncement.Name = "tabDeleteAnnouncement";
            this.tabDeleteAnnouncement.Size = new System.Drawing.Size(746, 343);
            this.tabDeleteAnnouncement.TabIndex = 1;
            this.tabDeleteAnnouncement.Text = "Delete Announcement";
            this.tabDeleteAnnouncement.VerticalScrollbarBarColor = true;
            this.tabDeleteAnnouncement.VerticalScrollbarHighlightOnWheel = false;
            this.tabDeleteAnnouncement.VerticalScrollbarSize = 10;
            // 
            // deleteAnnouncementPanel
            // 
            this.deleteAnnouncementPanel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.deleteAnnouncementPanel.Controls.Add(this.gvAnnouncDetails);
            this.deleteAnnouncementPanel.HorizontalScrollbarBarColor = true;
            this.deleteAnnouncementPanel.HorizontalScrollbarHighlightOnWheel = false;
            this.deleteAnnouncementPanel.HorizontalScrollbarSize = 10;
            this.deleteAnnouncementPanel.Location = new System.Drawing.Point(3, 3);
            this.deleteAnnouncementPanel.Name = "deleteAnnouncementPanel";
            this.deleteAnnouncementPanel.Size = new System.Drawing.Size(740, 295);
            this.deleteAnnouncementPanel.TabIndex = 22;
            this.deleteAnnouncementPanel.VerticalScrollbarBarColor = true;
            this.deleteAnnouncementPanel.VerticalScrollbarHighlightOnWheel = false;
            this.deleteAnnouncementPanel.VerticalScrollbarSize = 10;
            // 
            // gvAnnouncDetails
            // 
            this.gvAnnouncDetails.AllowUserToAddRows = false;
            this.gvAnnouncDetails.AllowUserToDeleteRows = false;
            this.gvAnnouncDetails.AllowUserToResizeRows = false;
            this.gvAnnouncDetails.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gvAnnouncDetails.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.gvAnnouncDetails.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gvAnnouncDetails.Location = new System.Drawing.Point(3, 3);
            this.gvAnnouncDetails.Name = "gvAnnouncDetails";
            this.gvAnnouncDetails.ReadOnly = true;
            this.gvAnnouncDetails.RowHeadersVisible = false;
            this.gvAnnouncDetails.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.gvAnnouncDetails.Size = new System.Drawing.Size(734, 289);
            this.gvAnnouncDetails.TabIndex = 18;
            this.gvAnnouncDetails.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.gvAnnouncDetails_CellClick);
            // 
            // btnDeleteAnn
            // 
            this.btnDeleteAnn.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btnDeleteAnn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.btnDeleteAnn.FontSize = MetroFramework.MetroButtonSize.Medium;
            this.btnDeleteAnn.FontWeight = MetroFramework.MetroButtonWeight.Regular;
            this.btnDeleteAnn.ForeColor = System.Drawing.Color.White;
            this.btnDeleteAnn.Location = new System.Drawing.Point(395, 304);
            this.btnDeleteAnn.Name = "btnDeleteAnn";
            this.btnDeleteAnn.Size = new System.Drawing.Size(90, 36);
            this.btnDeleteAnn.TabIndex = 4;
            this.btnDeleteAnn.Text = "Delete";
            this.btnDeleteAnn.UseCustomBackColor = true;
            this.btnDeleteAnn.UseCustomForeColor = true;
            this.btnDeleteAnn.UseSelectable = true;
            this.btnDeleteAnn.Click += new System.EventHandler(this.btnDeleteAnn_Click);
            // 
            // btnBack1
            // 
            this.btnBack1.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btnBack1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.btnBack1.FontSize = MetroFramework.MetroButtonSize.Medium;
            this.btnBack1.FontWeight = MetroFramework.MetroButtonWeight.Regular;
            this.btnBack1.ForeColor = System.Drawing.Color.White;
            this.btnBack1.Location = new System.Drawing.Point(261, 304);
            this.btnBack1.Name = "btnBack1";
            this.btnBack1.Size = new System.Drawing.Size(90, 36);
            this.btnBack1.TabIndex = 3;
            this.btnBack1.Text = "Back";
            this.btnBack1.UseCustomBackColor = true;
            this.btnBack1.UseCustomForeColor = true;
            this.btnBack1.UseSelectable = true;
            this.btnBack1.Click += new System.EventHandler(this.btnBack1_Click);
            // 
            // ManageAnnouncementForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 471);
            this.Controls.Add(this.tabManageTeacher);
            this.Name = "ManageAnnouncementForm";
            this.Text = "Manage Announcements";
            this.Load += new System.EventHandler(this.ManageAnnouncementForm_Load);
            this.tabManageTeacher.ResumeLayout(false);
            this.tabAddAnnouncement.ResumeLayout(false);
            this.addAnnouncementPanel.ResumeLayout(false);
            this.addAnnouncementPanel.PerformLayout();
            this.tabDeleteAnnouncement.ResumeLayout(false);
            this.deleteAnnouncementPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gvAnnouncDetails)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private MetroFramework.Controls.MetroTabControl tabManageTeacher;
        private MetroFramework.Controls.MetroTabPage tabAddAnnouncement;
        private MetroFramework.Controls.MetroPanel addAnnouncementPanel;
        private MetroFramework.Controls.MetroLabel Announcement;
        private MetroFramework.Controls.MetroTextBox txtAnnouncement;
        private MetroFramework.Controls.MetroComboBox cbSelectCourse;
        private MetroFramework.Controls.MetroLabel Course;
        private MetroFramework.Controls.MetroButton btnBack;
        private MetroFramework.Controls.MetroButton btnSave;
        private MetroFramework.Controls.MetroTabPage tabDeleteAnnouncement;
        private MetroFramework.Controls.MetroPanel deleteAnnouncementPanel;
        private System.Windows.Forms.DataGridView gvAnnouncDetails;
        private MetroFramework.Controls.MetroButton btnDeleteAnn;
        private MetroFramework.Controls.MetroButton btnBack1;
    }
}