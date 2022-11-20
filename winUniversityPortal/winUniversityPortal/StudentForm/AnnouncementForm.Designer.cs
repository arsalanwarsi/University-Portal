
namespace winUniversityPortal.StudentForm
{
    partial class AnnouncementForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AnnouncementForm));
            this.announcementPanel = new MetroFramework.Controls.MetroPanel();
            this.gvShowAnnouncement = new System.Windows.Forms.DataGridView();
            this.Announcement = new MetroFramework.Controls.MetroLabel();
            this.btnBack = new MetroFramework.Controls.MetroButton();
            this.announcementPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gvShowAnnouncement)).BeginInit();
            this.SuspendLayout();
            // 
            // announcementPanel
            // 
            this.announcementPanel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.announcementPanel.Controls.Add(this.gvShowAnnouncement);
            this.announcementPanel.Controls.Add(this.Announcement);
            this.announcementPanel.HorizontalScrollbarBarColor = true;
            this.announcementPanel.HorizontalScrollbarHighlightOnWheel = false;
            this.announcementPanel.HorizontalScrollbarSize = 10;
            this.announcementPanel.Location = new System.Drawing.Point(23, 63);
            this.announcementPanel.Name = "announcementPanel";
            this.announcementPanel.Size = new System.Drawing.Size(704, 263);
            this.announcementPanel.TabIndex = 29;
            this.announcementPanel.VerticalScrollbarBarColor = true;
            this.announcementPanel.VerticalScrollbarHighlightOnWheel = false;
            this.announcementPanel.VerticalScrollbarSize = 10;
            // 
            // gvShowAnnouncement
            // 
            this.gvShowAnnouncement.AllowUserToAddRows = false;
            this.gvShowAnnouncement.AllowUserToDeleteRows = false;
            this.gvShowAnnouncement.AllowUserToResizeRows = false;
            this.gvShowAnnouncement.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gvShowAnnouncement.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.gvShowAnnouncement.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gvShowAnnouncement.Location = new System.Drawing.Point(3, 44);
            this.gvShowAnnouncement.Name = "gvShowAnnouncement";
            this.gvShowAnnouncement.ReadOnly = true;
            this.gvShowAnnouncement.RowHeadersVisible = false;
            this.gvShowAnnouncement.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.gvShowAnnouncement.Size = new System.Drawing.Size(698, 216);
            this.gvShowAnnouncement.TabIndex = 9;
            // 
            // Announcement
            // 
            this.Announcement.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.Announcement.AutoSize = true;
            this.Announcement.Location = new System.Drawing.Point(304, 12);
            this.Announcement.Name = "Announcement";
            this.Announcement.Size = new System.Drawing.Size(97, 19);
            this.Announcement.TabIndex = 8;
            this.Announcement.Text = "Announcement";
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
            this.btnBack.TabIndex = 28;
            this.btnBack.Text = "Back";
            this.btnBack.UseCustomBackColor = true;
            this.btnBack.UseCustomForeColor = true;
            this.btnBack.UseSelectable = true;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // AnnouncementForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(750, 391);
            this.Controls.Add(this.announcementPanel);
            this.Controls.Add(this.btnBack);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "AnnouncementForm";
            this.Text = "Announcements";
            this.Load += new System.EventHandler(this.AnnouncementForm_Load);
            this.announcementPanel.ResumeLayout(false);
            this.announcementPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gvShowAnnouncement)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private MetroFramework.Controls.MetroPanel announcementPanel;
        private System.Windows.Forms.DataGridView gvShowAnnouncement;
        private MetroFramework.Controls.MetroLabel Announcement;
        private MetroFramework.Controls.MetroButton btnBack;
    }
}