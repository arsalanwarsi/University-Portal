
namespace winUniversityPortal.StudentForm
{
    partial class NoticesForm
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
            this.noticePanel = new MetroFramework.Controls.MetroPanel();
            this.gvShowNotices = new System.Windows.Forms.DataGridView();
            this.Notices = new MetroFramework.Controls.MetroLabel();
            this.btnBack = new MetroFramework.Controls.MetroButton();
            this.noticePanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gvShowNotices)).BeginInit();
            this.SuspendLayout();
            // 
            // noticePanel
            // 
            this.noticePanel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.noticePanel.Controls.Add(this.gvShowNotices);
            this.noticePanel.Controls.Add(this.Notices);
            this.noticePanel.HorizontalScrollbarBarColor = true;
            this.noticePanel.HorizontalScrollbarHighlightOnWheel = false;
            this.noticePanel.HorizontalScrollbarSize = 10;
            this.noticePanel.Location = new System.Drawing.Point(23, 63);
            this.noticePanel.Name = "noticePanel";
            this.noticePanel.Size = new System.Drawing.Size(704, 263);
            this.noticePanel.TabIndex = 27;
            this.noticePanel.VerticalScrollbarBarColor = true;
            this.noticePanel.VerticalScrollbarHighlightOnWheel = false;
            this.noticePanel.VerticalScrollbarSize = 10;
            // 
            // gvShowNotices
            // 
            this.gvShowNotices.AllowUserToAddRows = false;
            this.gvShowNotices.AllowUserToDeleteRows = false;
            this.gvShowNotices.AllowUserToResizeRows = false;
            this.gvShowNotices.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gvShowNotices.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.gvShowNotices.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gvShowNotices.Location = new System.Drawing.Point(3, 44);
            this.gvShowNotices.Name = "gvShowNotices";
            this.gvShowNotices.ReadOnly = true;
            this.gvShowNotices.RowHeadersVisible = false;
            this.gvShowNotices.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.gvShowNotices.Size = new System.Drawing.Size(698, 216);
            this.gvShowNotices.TabIndex = 9;
            // 
            // Notices
            // 
            this.Notices.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.Notices.AutoSize = true;
            this.Notices.Location = new System.Drawing.Point(329, 12);
            this.Notices.Name = "Notices";
            this.Notices.Size = new System.Drawing.Size(47, 19);
            this.Notices.TabIndex = 8;
            this.Notices.Text = "Notice";
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
            this.btnBack.TabIndex = 1;
            this.btnBack.Text = "Back";
            this.btnBack.UseCustomBackColor = true;
            this.btnBack.UseCustomForeColor = true;
            this.btnBack.UseSelectable = true;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // NoticesForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(750, 391);
            this.Controls.Add(this.noticePanel);
            this.Controls.Add(this.btnBack);
            this.Name = "NoticesForm";
            this.Text = "Notices";
            this.Load += new System.EventHandler(this.NoticesForm_Load);
            this.noticePanel.ResumeLayout(false);
            this.noticePanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gvShowNotices)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private MetroFramework.Controls.MetroPanel noticePanel;
        private System.Windows.Forms.DataGridView gvShowNotices;
        private MetroFramework.Controls.MetroLabel Notices;
        private MetroFramework.Controls.MetroButton btnBack;
    }
}