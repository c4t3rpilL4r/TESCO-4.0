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
            this.lblEmail.Location = new System.Drawing.Point(6, 52);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(49, 23);
            this.lblEmail.TabIndex = 0;
            this.lblEmail.Text = "Email:";
            // 
            // grpForgotPassword
            // 
            this.grpForgotPassword.Controls.Add(this.btnSendInstructions);
            this.grpForgotPassword.Controls.Add(this.lblEnterEmail);
            this.grpForgotPassword.Controls.Add(this.txtEmail);
            this.grpForgotPassword.Controls.Add(this.lblEmail);
            this.grpForgotPassword.Location = new System.Drawing.Point(12, 12);
            this.grpForgotPassword.Name = "grpForgotPassword";
            this.grpForgotPassword.Size = new System.Drawing.Size(304, 130);
            this.grpForgotPassword.TabIndex = 1;
            this.grpForgotPassword.TabStop = false;
            this.grpForgotPassword.Text = "Reset Password";
            // 
            // btnSendInstructions
            // 
            this.btnSendInstructions.Location = new System.Drawing.Point(52, 77);
            this.btnSendInstructions.Name = "btnSendInstructions";
            this.btnSendInstructions.Size = new System.Drawing.Size(192, 23);
            this.btnSendInstructions.TabIndex = 1;
            this.btnSendInstructions.Text = "Send Reset Instructions";
            this.btnSendInstructions.UseVisualStyleBackColor = true;
            this.btnSendInstructions.Click += new System.EventHandler(this.btnSend_Click);
            // 
            // lblEnterEmail
            // 
            this.lblEnterEmail.Location = new System.Drawing.Point(6, 29);
            this.lblEnterEmail.Name = "lblEnterEmail";
            this.lblEnterEmail.Size = new System.Drawing.Size(189, 17);
            this.lblEnterEmail.TabIndex = 2;
            this.lblEnterEmail.Text = "Please enter email:";
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(52, 49);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(241, 22);
            this.txtEmail.TabIndex = 0;
            this.txtEmail.Leave += new System.EventHandler(this.txtEmail_Leave);
            // 
            // frmForgotPassword
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(327, 152);
            this.Controls.Add(this.grpForgotPassword);
            this.Font = new System.Drawing.Font("Consolas", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "frmForgotPassword";
            this.Text = "TESCO Forgot Password";
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