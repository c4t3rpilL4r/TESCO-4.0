using System.ComponentModel;

namespace Tesco.UI
{
    partial class frmRegisterLogin
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private IContainer components = null;

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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmRegisterLogin));
            this.grpRegistrationDetails = new System.Windows.Forms.GroupBox();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.txtUsername = new System.Windows.Forms.TextBox();
            this.txtPhoneNumber = new System.Windows.Forms.TextBox();
            this.txtFirstName = new System.Windows.Forms.TextBox();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.txtLastName = new System.Windows.Forms.TextBox();
            this.lblPassword = new System.Windows.Forms.Label();
            this.lblPhoneNumber = new System.Windows.Forms.Label();
            this.lblEmail = new System.Windows.Forms.Label();
            this.lblLastName = new System.Windows.Forms.Label();
            this.lblFirstName = new System.Windows.Forms.Label();
            this.lblUserName = new System.Windows.Forms.Label();
            this.btnLogIn = new System.Windows.Forms.Button();
            this.btnRegister = new System.Windows.Forms.Button();
            this.pnlRegister = new System.Windows.Forms.Panel();
            this.grpLogin = new System.Windows.Forms.GroupBox();
            this.lblLoginUserName = new System.Windows.Forms.Label();
            this.linkForgotPassword = new System.Windows.Forms.LinkLabel();
            this.txtLoginPassword = new System.Windows.Forms.TextBox();
            this.txtLoginUsername = new System.Windows.Forms.TextBox();
            this.lblLoginPassword = new System.Windows.Forms.Label();
            this.timer = new System.Windows.Forms.Timer(this.components);
            this.grpRegistrationDetails.SuspendLayout();
            this.pnlRegister.SuspendLayout();
            this.grpLogin.SuspendLayout();
            this.SuspendLayout();
            // 
            // grpRegistrationDetails
            // 
            resources.ApplyResources(this.grpRegistrationDetails, "grpRegistrationDetails");
            this.grpRegistrationDetails.Controls.Add(this.txtPassword);
            this.grpRegistrationDetails.Controls.Add(this.txtUsername);
            this.grpRegistrationDetails.Controls.Add(this.txtPhoneNumber);
            this.grpRegistrationDetails.Controls.Add(this.txtFirstName);
            this.grpRegistrationDetails.Controls.Add(this.txtEmail);
            this.grpRegistrationDetails.Controls.Add(this.txtLastName);
            this.grpRegistrationDetails.Controls.Add(this.lblPassword);
            this.grpRegistrationDetails.Controls.Add(this.lblPhoneNumber);
            this.grpRegistrationDetails.Controls.Add(this.lblEmail);
            this.grpRegistrationDetails.Controls.Add(this.lblLastName);
            this.grpRegistrationDetails.Controls.Add(this.lblFirstName);
            this.grpRegistrationDetails.Controls.Add(this.lblUserName);
            this.grpRegistrationDetails.Name = "grpRegistrationDetails";
            this.grpRegistrationDetails.TabStop = false;
            // 
            // txtPassword
            // 
            resources.ApplyResources(this.txtPassword, "txtPassword");
            this.txtPassword.Name = "txtPassword";
            // 
            // txtUsername
            // 
            resources.ApplyResources(this.txtUsername, "txtUsername");
            this.txtUsername.Name = "txtUsername";
            // 
            // txtPhoneNumber
            // 
            resources.ApplyResources(this.txtPhoneNumber, "txtPhoneNumber");
            this.txtPhoneNumber.Name = "txtPhoneNumber";
            this.txtPhoneNumber.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtPhoneNumber_KeyPress);
            // 
            // txtFirstName
            // 
            resources.ApplyResources(this.txtFirstName, "txtFirstName");
            this.txtFirstName.Name = "txtFirstName";
            // 
            // txtEmail
            // 
            resources.ApplyResources(this.txtEmail, "txtEmail");
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Leave += new System.EventHandler(this.txtEmail_Leave);
            // 
            // txtLastName
            // 
            resources.ApplyResources(this.txtLastName, "txtLastName");
            this.txtLastName.Name = "txtLastName";
            // 
            // lblPassword
            // 
            resources.ApplyResources(this.lblPassword, "lblPassword");
            this.lblPassword.Name = "lblPassword";
            // 
            // lblPhoneNumber
            // 
            resources.ApplyResources(this.lblPhoneNumber, "lblPhoneNumber");
            this.lblPhoneNumber.Name = "lblPhoneNumber";
            // 
            // lblEmail
            // 
            resources.ApplyResources(this.lblEmail, "lblEmail");
            this.lblEmail.Name = "lblEmail";
            // 
            // lblLastName
            // 
            resources.ApplyResources(this.lblLastName, "lblLastName");
            this.lblLastName.Name = "lblLastName";
            // 
            // lblFirstName
            // 
            resources.ApplyResources(this.lblFirstName, "lblFirstName");
            this.lblFirstName.Name = "lblFirstName";
            // 
            // lblUserName
            // 
            resources.ApplyResources(this.lblUserName, "lblUserName");
            this.lblUserName.Name = "lblUserName";
            // 
            // btnLogIn
            // 
            resources.ApplyResources(this.btnLogIn, "btnLogIn");
            this.btnLogIn.Name = "btnLogIn";
            this.btnLogIn.UseVisualStyleBackColor = true;
            this.btnLogIn.Click += new System.EventHandler(this.btnLogIn_Click);
            // 
            // btnRegister
            // 
            resources.ApplyResources(this.btnRegister, "btnRegister");
            this.btnRegister.Name = "btnRegister";
            this.btnRegister.UseVisualStyleBackColor = true;
            this.btnRegister.Click += new System.EventHandler(this.BtnRegister_Click);
            // 
            // pnlRegister
            // 
            resources.ApplyResources(this.pnlRegister, "pnlRegister");
            this.pnlRegister.Controls.Add(this.grpRegistrationDetails);
            this.pnlRegister.Name = "pnlRegister";
            // 
            // grpLogin
            // 
            resources.ApplyResources(this.grpLogin, "grpLogin");
            this.grpLogin.Controls.Add(this.lblLoginUserName);
            this.grpLogin.Controls.Add(this.linkForgotPassword);
            this.grpLogin.Controls.Add(this.txtLoginPassword);
            this.grpLogin.Controls.Add(this.txtLoginUsername);
            this.grpLogin.Controls.Add(this.lblLoginPassword);
            this.grpLogin.Name = "grpLogin";
            this.grpLogin.TabStop = false;
            // 
            // lblLoginUserName
            // 
            resources.ApplyResources(this.lblLoginUserName, "lblLoginUserName");
            this.lblLoginUserName.Name = "lblLoginUserName";
            // 
            // linkForgotPassword
            // 
            resources.ApplyResources(this.linkForgotPassword, "linkForgotPassword");
            this.linkForgotPassword.LinkColor = System.Drawing.Color.Black;
            this.linkForgotPassword.Name = "linkForgotPassword";
            this.linkForgotPassword.TabStop = true;
            this.linkForgotPassword.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkForgotPassword_LinkClicked);
            this.linkForgotPassword.MouseEnter += new System.EventHandler(this.linkForgotPassword_MouseEnter);
            this.linkForgotPassword.MouseLeave += new System.EventHandler(this.linkForgotPassword_MouseLeave);
            // 
            // txtLoginPassword
            // 
            resources.ApplyResources(this.txtLoginPassword, "txtLoginPassword");
            this.txtLoginPassword.Name = "txtLoginPassword";
            // 
            // txtLoginUsername
            // 
            resources.ApplyResources(this.txtLoginUsername, "txtLoginUsername");
            this.txtLoginUsername.Name = "txtLoginUsername";
            // 
            // lblLoginPassword
            // 
            resources.ApplyResources(this.lblLoginPassword, "lblLoginPassword");
            this.lblLoginPassword.Name = "lblLoginPassword";
            // 
            // timer
            // 
            this.timer.Tick += new System.EventHandler(this.Timer_Tick);
            // 
            // frmRegisterLogin
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.btnLogIn);
            this.Controls.Add(this.pnlRegister);
            this.Controls.Add(this.btnRegister);
            this.Controls.Add(this.grpLogin);
            this.Name = "frmRegisterLogin";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FrmRegisterLogin_FormClosing);
            this.Load += new System.EventHandler(this.FrmRegisterLogin_Load);
            this.grpRegistrationDetails.ResumeLayout(false);
            this.grpRegistrationDetails.PerformLayout();
            this.pnlRegister.ResumeLayout(false);
            this.grpLogin.ResumeLayout(false);
            this.grpLogin.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grpRegistrationDetails;
        private System.Windows.Forms.Button btnLogIn;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.TextBox txtUsername;
        private System.Windows.Forms.TextBox txtPhoneNumber;
        private System.Windows.Forms.TextBox txtFirstName;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.TextBox txtLastName;
        private System.Windows.Forms.Button btnRegister;
        private System.Windows.Forms.Label lblPhoneNumber;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.Label lblUserName;
        private System.Windows.Forms.Label lblLastName;
        private System.Windows.Forms.Label lblFirstName;
        private System.Windows.Forms.Panel pnlRegister;
        private System.Windows.Forms.Timer timer;
        private System.Windows.Forms.GroupBox grpLogin;
        private System.Windows.Forms.TextBox txtLoginPassword;
        private System.Windows.Forms.TextBox txtLoginUsername;
        private System.Windows.Forms.Label lblLoginPassword;
        private System.Windows.Forms.Label lblLoginUserName;
        private System.Windows.Forms.LinkLabel linkForgotPassword;
        private System.Windows.Forms.Label lblPassword;
    }
}