
namespace winUniversityPortal
{
    partial class PortalLoginForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PortalLoginForm));
            this.labUserID = new MetroFramework.Controls.MetroLabel();
            this.txtUserID = new MetroFramework.Controls.MetroTextBox();
            this.btnLogin = new MetroFramework.Controls.MetroButton();
            this.pbIcon = new System.Windows.Forms.PictureBox();
            this.txtPassword = new MetroFramework.Controls.MetroTextBox();
            this.labPassword = new MetroFramework.Controls.MetroLabel();
            this.btnExit = new MetroFramework.Controls.MetroButton();
            this.btnBack = new MetroFramework.Controls.MetroButton();
            ((System.ComponentModel.ISupportInitialize)(this.pbIcon)).BeginInit();
            this.SuspendLayout();
            // 
            // labUserID
            // 
            this.labUserID.AutoSize = true;
            this.labUserID.Location = new System.Drawing.Point(130, 76);
            this.labUserID.Name = "labUserID";
            this.labUserID.Size = new System.Drawing.Size(54, 19);
            this.labUserID.TabIndex = 3;
            this.labUserID.Text = "User ID:";
            // 
            // txtUserID
            // 
            // 
            // 
            // 
            this.txtUserID.CustomButton.Image = null;
            this.txtUserID.CustomButton.Location = new System.Drawing.Point(150, 1);
            this.txtUserID.CustomButton.Name = "";
            this.txtUserID.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtUserID.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtUserID.CustomButton.TabIndex = 1;
            this.txtUserID.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtUserID.CustomButton.UseSelectable = true;
            this.txtUserID.CustomButton.Visible = false;
            this.txtUserID.Lines = new string[0];
            this.txtUserID.Location = new System.Drawing.Point(201, 74);
            this.txtUserID.MaxLength = 32767;
            this.txtUserID.Name = "txtUserID";
            this.txtUserID.PasswordChar = '\0';
            this.txtUserID.PromptText = "Enter User ID";
            this.txtUserID.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtUserID.SelectedText = "";
            this.txtUserID.SelectionLength = 0;
            this.txtUserID.SelectionStart = 0;
            this.txtUserID.ShortcutsEnabled = true;
            this.txtUserID.Size = new System.Drawing.Size(165, 23);
            this.txtUserID.TabIndex = 0;
            this.txtUserID.UseSelectable = true;
            this.txtUserID.WaterMark = "Enter User ID";
            this.txtUserID.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtUserID.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // btnLogin
            // 
            this.btnLogin.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.btnLogin.FontSize = MetroFramework.MetroButtonSize.Medium;
            this.btnLogin.FontWeight = MetroFramework.MetroButtonWeight.Regular;
            this.btnLogin.ForeColor = System.Drawing.Color.White;
            this.btnLogin.Location = new System.Drawing.Point(201, 149);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Size = new System.Drawing.Size(75, 30);
            this.btnLogin.TabIndex = 2;
            this.btnLogin.Text = "Login";
            this.btnLogin.UseCustomBackColor = true;
            this.btnLogin.UseCustomForeColor = true;
            this.btnLogin.UseSelectable = true;
            this.btnLogin.UseStyleColors = true;
            this.btnLogin.Click += new System.EventHandler(this.btnLogin_Click);
            // 
            // pbIcon
            // 
            this.pbIcon.Image = ((System.Drawing.Image)(resources.GetObject("pbIcon.Image")));
            this.pbIcon.Location = new System.Drawing.Point(14, 75);
            this.pbIcon.Name = "pbIcon";
            this.pbIcon.Size = new System.Drawing.Size(118, 120);
            this.pbIcon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbIcon.TabIndex = 3;
            this.pbIcon.TabStop = false;
            // 
            // txtPassword
            // 
            // 
            // 
            // 
            this.txtPassword.CustomButton.Image = null;
            this.txtPassword.CustomButton.Location = new System.Drawing.Point(150, 1);
            this.txtPassword.CustomButton.Name = "";
            this.txtPassword.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtPassword.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtPassword.CustomButton.TabIndex = 1;
            this.txtPassword.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtPassword.CustomButton.UseSelectable = true;
            this.txtPassword.CustomButton.Visible = false;
            this.txtPassword.Lines = new string[0];
            this.txtPassword.Location = new System.Drawing.Point(201, 111);
            this.txtPassword.MaxLength = 32767;
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.PasswordChar = '●';
            this.txtPassword.PromptText = "Enter Password";
            this.txtPassword.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtPassword.SelectedText = "";
            this.txtPassword.SelectionLength = 0;
            this.txtPassword.SelectionStart = 0;
            this.txtPassword.ShortcutsEnabled = true;
            this.txtPassword.Size = new System.Drawing.Size(165, 23);
            this.txtPassword.TabIndex = 1;
            this.txtPassword.UseSelectable = true;
            this.txtPassword.UseSystemPasswordChar = true;
            this.txtPassword.WaterMark = "Enter Password";
            this.txtPassword.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtPassword.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // labPassword
            // 
            this.labPassword.AutoSize = true;
            this.labPassword.Location = new System.Drawing.Point(130, 112);
            this.labPassword.Name = "labPassword";
            this.labPassword.Size = new System.Drawing.Size(66, 19);
            this.labPassword.TabIndex = 3;
            this.labPassword.Text = "Password:";
            // 
            // btnExit
            // 
            this.btnExit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.btnExit.FontSize = MetroFramework.MetroButtonSize.Medium;
            this.btnExit.FontWeight = MetroFramework.MetroButtonWeight.Regular;
            this.btnExit.ForeColor = System.Drawing.Color.White;
            this.btnExit.Location = new System.Drawing.Point(201, 188);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(165, 30);
            this.btnExit.TabIndex = 4;
            this.btnExit.Text = "Exit";
            this.btnExit.UseCustomBackColor = true;
            this.btnExit.UseCustomForeColor = true;
            this.btnExit.UseSelectable = true;
            this.btnExit.UseStyleColors = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // btnBack
            // 
            this.btnBack.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.btnBack.FontSize = MetroFramework.MetroButtonSize.Medium;
            this.btnBack.FontWeight = MetroFramework.MetroButtonWeight.Regular;
            this.btnBack.ForeColor = System.Drawing.Color.White;
            this.btnBack.Location = new System.Drawing.Point(291, 149);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(75, 30);
            this.btnBack.TabIndex = 3;
            this.btnBack.Text = "Back";
            this.btnBack.UseCustomBackColor = true;
            this.btnBack.UseCustomForeColor = true;
            this.btnBack.UseSelectable = true;
            this.btnBack.UseStyleColors = true;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // PortalLoginForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(389, 241);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.txtPassword);
            this.Controls.Add(this.labPassword);
            this.Controls.Add(this.pbIcon);
            this.Controls.Add(this.btnLogin);
            this.Controls.Add(this.txtUserID);
            this.Controls.Add(this.labUserID);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "PortalLoginForm";
            this.Text = "Portal Login";
            ((System.ComponentModel.ISupportInitialize)(this.pbIcon)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MetroFramework.Controls.MetroLabel labUserID;
        private MetroFramework.Controls.MetroTextBox txtUserID;
        private MetroFramework.Controls.MetroButton btnLogin;
        private System.Windows.Forms.PictureBox pbIcon;
        private MetroFramework.Controls.MetroTextBox txtPassword;
        private MetroFramework.Controls.MetroLabel labPassword;
        private MetroFramework.Controls.MetroButton btnExit;
        private MetroFramework.Controls.MetroButton btnBack;
    }
}