
namespace winUniversityPortal.AdminForm
{
    partial class ManageNoticeForm
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
            this.tabManageNotice = new MetroFramework.Controls.MetroTabControl();
            this.tabAddNotice = new MetroFramework.Controls.MetroTabPage();
            this.addNoticePanel = new MetroFramework.Controls.MetroPanel();
            this.Notice = new MetroFramework.Controls.MetroLabel();
            this.txtNotice = new MetroFramework.Controls.MetroTextBox();
            this.cbNoticeFor = new MetroFramework.Controls.MetroComboBox();
            this.NoticeFor = new MetroFramework.Controls.MetroLabel();
            this.btnBack0 = new MetroFramework.Controls.MetroButton();
            this.btnNewNotice = new MetroFramework.Controls.MetroButton();
            this.btnSaveNotice = new MetroFramework.Controls.MetroButton();
            this.tabDeleteNotice = new MetroFramework.Controls.MetroTabPage();
            this.managePanel = new MetroFramework.Controls.MetroPanel();
            this.gvNoticeDetails = new System.Windows.Forms.DataGridView();
            this.btnBack1 = new MetroFramework.Controls.MetroButton();
            this.btnDelete = new MetroFramework.Controls.MetroButton();
            this.tabManageNotice.SuspendLayout();
            this.tabAddNotice.SuspendLayout();
            this.addNoticePanel.SuspendLayout();
            this.tabDeleteNotice.SuspendLayout();
            this.managePanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gvNoticeDetails)).BeginInit();
            this.SuspendLayout();
            // 
            // tabManageNotice
            // 
            this.tabManageNotice.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tabManageNotice.Controls.Add(this.tabAddNotice);
            this.tabManageNotice.Controls.Add(this.tabDeleteNotice);
            this.tabManageNotice.Location = new System.Drawing.Point(23, 63);
            this.tabManageNotice.Name = "tabManageNotice";
            this.tabManageNotice.SelectedIndex = 1;
            this.tabManageNotice.Size = new System.Drawing.Size(754, 385);
            this.tabManageNotice.TabIndex = 3;
            this.tabManageNotice.UseSelectable = true;
            // 
            // tabAddNotice
            // 
            this.tabAddNotice.Controls.Add(this.addNoticePanel);
            this.tabAddNotice.Controls.Add(this.btnBack0);
            this.tabAddNotice.Controls.Add(this.btnNewNotice);
            this.tabAddNotice.Controls.Add(this.btnSaveNotice);
            this.tabAddNotice.HorizontalScrollbarBarColor = true;
            this.tabAddNotice.HorizontalScrollbarHighlightOnWheel = false;
            this.tabAddNotice.HorizontalScrollbarSize = 10;
            this.tabAddNotice.Location = new System.Drawing.Point(4, 38);
            this.tabAddNotice.Name = "tabAddNotice";
            this.tabAddNotice.Size = new System.Drawing.Size(746, 343);
            this.tabAddNotice.TabIndex = 0;
            this.tabAddNotice.Text = "Add Notice";
            this.tabAddNotice.VerticalScrollbarBarColor = true;
            this.tabAddNotice.VerticalScrollbarHighlightOnWheel = false;
            this.tabAddNotice.VerticalScrollbarSize = 10;
            // 
            // addNoticePanel
            // 
            this.addNoticePanel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.addNoticePanel.Controls.Add(this.Notice);
            this.addNoticePanel.Controls.Add(this.txtNotice);
            this.addNoticePanel.Controls.Add(this.cbNoticeFor);
            this.addNoticePanel.Controls.Add(this.NoticeFor);
            this.addNoticePanel.HorizontalScrollbarBarColor = true;
            this.addNoticePanel.HorizontalScrollbarHighlightOnWheel = false;
            this.addNoticePanel.HorizontalScrollbarSize = 10;
            this.addNoticePanel.Location = new System.Drawing.Point(3, 3);
            this.addNoticePanel.Name = "addNoticePanel";
            this.addNoticePanel.Size = new System.Drawing.Size(740, 295);
            this.addNoticePanel.TabIndex = 2;
            this.addNoticePanel.VerticalScrollbarBarColor = true;
            this.addNoticePanel.VerticalScrollbarHighlightOnWheel = false;
            this.addNoticePanel.VerticalScrollbarSize = 10;
            // 
            // Notice
            // 
            this.Notice.AutoSize = true;
            this.Notice.Location = new System.Drawing.Point(18, 30);
            this.Notice.Name = "Notice";
            this.Notice.Size = new System.Drawing.Size(50, 19);
            this.Notice.TabIndex = 8;
            this.Notice.Text = "Notice:";
            // 
            // txtNotice
            // 
            this.txtNotice.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            // 
            // 
            // 
            this.txtNotice.CustomButton.Image = null;
            this.txtNotice.CustomButton.Location = new System.Drawing.Point(55, 2);
            this.txtNotice.CustomButton.Name = "";
            this.txtNotice.CustomButton.Size = new System.Drawing.Size(243, 243);
            this.txtNotice.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtNotice.CustomButton.TabIndex = 1;
            this.txtNotice.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtNotice.CustomButton.UseSelectable = true;
            this.txtNotice.CustomButton.Visible = false;
            this.txtNotice.Lines = new string[0];
            this.txtNotice.Location = new System.Drawing.Point(96, 29);
            this.txtNotice.MaxLength = 32767;
            this.txtNotice.Multiline = true;
            this.txtNotice.Name = "txtNotice";
            this.txtNotice.PasswordChar = '\0';
            this.txtNotice.PromptText = "Enter Description";
            this.txtNotice.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtNotice.SelectedText = "";
            this.txtNotice.SelectionLength = 0;
            this.txtNotice.SelectionStart = 0;
            this.txtNotice.ShortcutsEnabled = true;
            this.txtNotice.Size = new System.Drawing.Size(301, 248);
            this.txtNotice.TabIndex = 1;
            this.txtNotice.UseSelectable = true;
            this.txtNotice.WaterMark = "Enter Description";
            this.txtNotice.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtNotice.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // cbNoticeFor
            // 
            this.cbNoticeFor.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.cbNoticeFor.FormattingEnabled = true;
            this.cbNoticeFor.ItemHeight = 23;
            this.cbNoticeFor.Items.AddRange(new object[] {
            "Teachers",
            "Students",
            "Both"});
            this.cbNoticeFor.Location = new System.Drawing.Point(527, 130);
            this.cbNoticeFor.Name = "cbNoticeFor";
            this.cbNoticeFor.PromptText = "Select For";
            this.cbNoticeFor.Size = new System.Drawing.Size(190, 29);
            this.cbNoticeFor.TabIndex = 2;
            this.cbNoticeFor.UseSelectable = true;
            // 
            // NoticeFor
            // 
            this.NoticeFor.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.NoticeFor.AutoSize = true;
            this.NoticeFor.Location = new System.Drawing.Point(417, 134);
            this.NoticeFor.Name = "NoticeFor";
            this.NoticeFor.Size = new System.Drawing.Size(75, 19);
            this.NoticeFor.TabIndex = 5;
            this.NoticeFor.Text = "Notice For:";
            // 
            // btnBack0
            // 
            this.btnBack0.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btnBack0.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.btnBack0.FontSize = MetroFramework.MetroButtonSize.Medium;
            this.btnBack0.FontWeight = MetroFramework.MetroButtonWeight.Regular;
            this.btnBack0.ForeColor = System.Drawing.Color.White;
            this.btnBack0.Location = new System.Drawing.Point(194, 304);
            this.btnBack0.Name = "btnBack0";
            this.btnBack0.Size = new System.Drawing.Size(90, 36);
            this.btnBack0.TabIndex = 5;
            this.btnBack0.Text = "Back";
            this.btnBack0.UseCustomBackColor = true;
            this.btnBack0.UseCustomForeColor = true;
            this.btnBack0.UseSelectable = true;
            this.btnBack0.Click += new System.EventHandler(this.btnBack0_Click);
            // 
            // btnNewNotice
            // 
            this.btnNewNotice.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btnNewNotice.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.btnNewNotice.FontSize = MetroFramework.MetroButtonSize.Medium;
            this.btnNewNotice.FontWeight = MetroFramework.MetroButtonWeight.Regular;
            this.btnNewNotice.ForeColor = System.Drawing.Color.White;
            this.btnNewNotice.Location = new System.Drawing.Point(462, 304);
            this.btnNewNotice.Name = "btnNewNotice";
            this.btnNewNotice.Size = new System.Drawing.Size(90, 36);
            this.btnNewNotice.TabIndex = 4;
            this.btnNewNotice.Text = "New Notice";
            this.btnNewNotice.UseCustomBackColor = true;
            this.btnNewNotice.UseCustomForeColor = true;
            this.btnNewNotice.UseSelectable = true;
            this.btnNewNotice.Click += new System.EventHandler(this.btnNewNotice_Click);
            // 
            // btnSaveNotice
            // 
            this.btnSaveNotice.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btnSaveNotice.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.btnSaveNotice.FontSize = MetroFramework.MetroButtonSize.Medium;
            this.btnSaveNotice.FontWeight = MetroFramework.MetroButtonWeight.Regular;
            this.btnSaveNotice.ForeColor = System.Drawing.Color.White;
            this.btnSaveNotice.Location = new System.Drawing.Point(328, 304);
            this.btnSaveNotice.Name = "btnSaveNotice";
            this.btnSaveNotice.Size = new System.Drawing.Size(90, 36);
            this.btnSaveNotice.TabIndex = 3;
            this.btnSaveNotice.Text = "Save Notice";
            this.btnSaveNotice.UseCustomBackColor = true;
            this.btnSaveNotice.UseCustomForeColor = true;
            this.btnSaveNotice.UseSelectable = true;
            this.btnSaveNotice.Click += new System.EventHandler(this.btnSaveNotice_Click);
            // 
            // tabDeleteNotice
            // 
            this.tabDeleteNotice.Controls.Add(this.managePanel);
            this.tabDeleteNotice.Controls.Add(this.btnBack1);
            this.tabDeleteNotice.Controls.Add(this.btnDelete);
            this.tabDeleteNotice.HorizontalScrollbarBarColor = true;
            this.tabDeleteNotice.HorizontalScrollbarHighlightOnWheel = false;
            this.tabDeleteNotice.HorizontalScrollbarSize = 10;
            this.tabDeleteNotice.Location = new System.Drawing.Point(4, 38);
            this.tabDeleteNotice.Name = "tabDeleteNotice";
            this.tabDeleteNotice.Size = new System.Drawing.Size(746, 343);
            this.tabDeleteNotice.TabIndex = 1;
            this.tabDeleteNotice.Text = "Delete Notice";
            this.tabDeleteNotice.VerticalScrollbarBarColor = true;
            this.tabDeleteNotice.VerticalScrollbarHighlightOnWheel = false;
            this.tabDeleteNotice.VerticalScrollbarSize = 10;
            // 
            // managePanel
            // 
            this.managePanel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.managePanel.Controls.Add(this.gvNoticeDetails);
            this.managePanel.HorizontalScrollbarBarColor = true;
            this.managePanel.HorizontalScrollbarHighlightOnWheel = false;
            this.managePanel.HorizontalScrollbarSize = 10;
            this.managePanel.Location = new System.Drawing.Point(3, 3);
            this.managePanel.Name = "managePanel";
            this.managePanel.Size = new System.Drawing.Size(740, 295);
            this.managePanel.TabIndex = 23;
            this.managePanel.VerticalScrollbarBarColor = true;
            this.managePanel.VerticalScrollbarHighlightOnWheel = false;
            this.managePanel.VerticalScrollbarSize = 10;
            // 
            // gvNoticeDetails
            // 
            this.gvNoticeDetails.AllowUserToAddRows = false;
            this.gvNoticeDetails.AllowUserToDeleteRows = false;
            this.gvNoticeDetails.AllowUserToResizeRows = false;
            this.gvNoticeDetails.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gvNoticeDetails.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.gvNoticeDetails.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gvNoticeDetails.Location = new System.Drawing.Point(3, 3);
            this.gvNoticeDetails.Name = "gvNoticeDetails";
            this.gvNoticeDetails.ReadOnly = true;
            this.gvNoticeDetails.RowHeadersVisible = false;
            this.gvNoticeDetails.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.gvNoticeDetails.Size = new System.Drawing.Size(734, 289);
            this.gvNoticeDetails.TabIndex = 18;
            this.gvNoticeDetails.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.gvNoticeDetails_CellClick);
            // 
            // btnBack1
            // 
            this.btnBack1.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btnBack1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.btnBack1.FontSize = MetroFramework.MetroButtonSize.Medium;
            this.btnBack1.FontWeight = MetroFramework.MetroButtonWeight.Regular;
            this.btnBack1.ForeColor = System.Drawing.Color.White;
            this.btnBack1.Location = new System.Drawing.Point(260, 304);
            this.btnBack1.Name = "btnBack1";
            this.btnBack1.Size = new System.Drawing.Size(90, 36);
            this.btnBack1.TabIndex = 8;
            this.btnBack1.Text = "Back";
            this.btnBack1.UseCustomBackColor = true;
            this.btnBack1.UseCustomForeColor = true;
            this.btnBack1.UseSelectable = true;
            this.btnBack1.Click += new System.EventHandler(this.btnBack1_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btnDelete.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.btnDelete.FontSize = MetroFramework.MetroButtonSize.Medium;
            this.btnDelete.FontWeight = MetroFramework.MetroButtonWeight.Regular;
            this.btnDelete.ForeColor = System.Drawing.Color.White;
            this.btnDelete.Location = new System.Drawing.Point(398, 304);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(90, 36);
            this.btnDelete.TabIndex = 7;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseCustomBackColor = true;
            this.btnDelete.UseCustomForeColor = true;
            this.btnDelete.UseSelectable = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // ManageNoticeForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 471);
            this.Controls.Add(this.tabManageNotice);
            this.Name = "ManageNoticeForm";
            this.Text = "Manage Notice";
            this.Load += new System.EventHandler(this.ManageNoticeForm_Load);
            this.tabManageNotice.ResumeLayout(false);
            this.tabAddNotice.ResumeLayout(false);
            this.addNoticePanel.ResumeLayout(false);
            this.addNoticePanel.PerformLayout();
            this.tabDeleteNotice.ResumeLayout(false);
            this.managePanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gvNoticeDetails)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private MetroFramework.Controls.MetroTabControl tabManageNotice;
        private MetroFramework.Controls.MetroTabPage tabAddNotice;
        private MetroFramework.Controls.MetroPanel addNoticePanel;
        private MetroFramework.Controls.MetroLabel Notice;
        private MetroFramework.Controls.MetroTextBox txtNotice;
        private MetroFramework.Controls.MetroComboBox cbNoticeFor;
        private MetroFramework.Controls.MetroLabel NoticeFor;
        private MetroFramework.Controls.MetroButton btnBack0;
        private MetroFramework.Controls.MetroButton btnNewNotice;
        private MetroFramework.Controls.MetroButton btnSaveNotice;
        private MetroFramework.Controls.MetroTabPage tabDeleteNotice;
        private MetroFramework.Controls.MetroButton btnBack1;
        private MetroFramework.Controls.MetroButton btnDelete;
        private MetroFramework.Controls.MetroPanel managePanel;
        private System.Windows.Forms.DataGridView gvNoticeDetails;
    }
}