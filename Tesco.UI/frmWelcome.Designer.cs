namespace Tesco.UI
{
    public partial class frmWelcome
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmWelcome));
            this.lblWelcome = new System.Windows.Forms.Label();
            this.lblTo = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btnStartShopping = new System.Windows.Forms.Button();
            this.linkRegister = new System.Windows.Forms.LinkLabel();
            this.linkLogIn = new System.Windows.Forms.LinkLabel();
            this.SuspendLayout();
            // 
            // lblWelcome
            // 
            resources.ApplyResources(this.lblWelcome, "lblWelcome");
            this.lblWelcome.Name = "lblWelcome";
            // 
            // lblTo
            // 
            resources.ApplyResources(this.lblTo, "lblTo");
            this.lblTo.Name = "lblTo";
            // 
            // label3
            // 
            resources.ApplyResources(this.label3, "label3");
            this.label3.Name = "label3";
            // 
            // btnStartShopping
            // 
            resources.ApplyResources(this.btnStartShopping, "btnStartShopping");
            this.btnStartShopping.Name = "btnStartShopping";
            this.btnStartShopping.UseVisualStyleBackColor = true;
            this.btnStartShopping.Click += new System.EventHandler(this.BtnStartShopping_Click);
            // 
            // linkRegister
            // 
            resources.ApplyResources(this.linkRegister, "linkRegister");
            this.linkRegister.LinkColor = System.Drawing.Color.Black;
            this.linkRegister.Name = "linkRegister";
            this.linkRegister.TabStop = true;
            this.linkRegister.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.LinkRegister_LinkClicked);
            this.linkRegister.MouseEnter += new System.EventHandler(this.linkRegister_MouseEnter);
            this.linkRegister.MouseLeave += new System.EventHandler(this.linkRegister_MouseLeave);
            // 
            // linkLogIn
            // 
            resources.ApplyResources(this.linkLogIn, "linkLogIn");
            this.linkLogIn.LinkColor = System.Drawing.Color.Black;
            this.linkLogIn.Name = "linkLogIn";
            this.linkLogIn.TabStop = true;
            this.linkLogIn.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.LinkLogIn_LinkClicked);
            this.linkLogIn.MouseEnter += new System.EventHandler(this.linkLogIn_MouseEnter);
            this.linkLogIn.MouseLeave += new System.EventHandler(this.linkLogIn_MouseLeave);
            // 
            // frmWelcome
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.linkLogIn);
            this.Controls.Add(this.linkRegister);
            this.Controls.Add(this.btnStartShopping);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lblTo);
            this.Controls.Add(this.lblWelcome);
            this.Name = "frmWelcome";
            this.Load += new System.EventHandler(this.frmWelcome_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblWelcome;
        private System.Windows.Forms.Label lblTo;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnStartShopping;
        private System.Windows.Forms.LinkLabel linkRegister;
        private System.Windows.Forms.LinkLabel linkLogIn;
    }
}

