using System.ComponentModel;

namespace Tesco.UI
{
    partial class frmForgotPassword
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmForgotPassword));
            this.lblEmail = new System.Windows.Forms.Label();
            this.grpForgotPassword = new System.Windows.Forms.GroupBox();
            this.btnSendInstructions = new System.Windows.Forms.Button();
            this.lblEnterEmail = new System.Windows.Forms.Label();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.grpForgotPassword.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblEmail
            // 
            resources.ApplyResources(this.lblEmail, "lblEmail");
            this.lblEmail.Name = "lblEmail";
            // 
            // grpForgotPassword
            // 
            resources.ApplyResources(this.grpForgotPassword, "grpForgotPassword");
            this.grpForgotPassword.Controls.Add(this.btnSendInstructions);
            this.grpForgotPassword.Controls.Add(this.lblEnterEmail);
            this.grpForgotPassword.Controls.Add(this.txtEmail);
            this.grpForgotPassword.Controls.Add(this.lblEmail);
            this.grpForgotPassword.Name = "grpForgotPassword";
            this.grpForgotPassword.TabStop = false;
            // 
            // btnSendInstructions
            // 
            resources.ApplyResources(this.btnSendInstructions, "btnSendInstructions");
            this.btnSendInstructions.Name = "btnSendInstructions";
            this.btnSendInstructions.UseVisualStyleBackColor = true;
            this.btnSendInstructions.Click += new System.EventHandler(this.btnSend_Click);
            // 
            // lblEnterEmail
            // 
            resources.ApplyResources(this.lblEnterEmail, "lblEnterEmail");
            this.lblEnterEmail.Name = "lblEnterEmail";
            // 
            // txtEmail
            // 
            resources.ApplyResources(this.txtEmail, "txtEmail");
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Leave += new System.EventHandler(this.txtEmail_Leave);
            // 
            // frmForgotPassword
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.grpForgotPassword);
            this.Name = "frmForgotPassword";
            this.grpForgotPassword.ResumeLayout(false);
            this.grpForgotPassword.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lblEnterEmail;
        private System.Windows.Forms.GroupBox grpForgotPassword;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.Button btnSendInstructions;
        private System.Windows.Forms.TextBox txtEmail;
    }
}