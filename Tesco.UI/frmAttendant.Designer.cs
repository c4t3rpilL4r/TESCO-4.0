namespace Tesco.UI
{
    partial class frmAttendant
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmAttendant));
            this.btnItemInventory = new System.Windows.Forms.Button();
            this.btnEditLogin = new System.Windows.Forms.Button();
            this.btnLogoff = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnItemInventory
            // 
            resources.ApplyResources(this.btnItemInventory, "btnItemInventory");
            this.btnItemInventory.Name = "btnItemInventory";
            this.btnItemInventory.UseVisualStyleBackColor = true;
            this.btnItemInventory.Click += new System.EventHandler(this.BtnItemInventory_Click);
            // 
            // btnEditLogin
            // 
            resources.ApplyResources(this.btnEditLogin, "btnEditLogin");
            this.btnEditLogin.Name = "btnEditLogin";
            this.btnEditLogin.UseVisualStyleBackColor = true;
            this.btnEditLogin.Click += new System.EventHandler(this.BtnEditLogin_Click);
            // 
            // btnLogoff
            // 
            resources.ApplyResources(this.btnLogoff, "btnLogoff");
            this.btnLogoff.Name = "btnLogoff";
            this.btnLogoff.UseVisualStyleBackColor = true;
            this.btnLogoff.Click += new System.EventHandler(this.BtnLogoff_Click);
            // 
            // frmAttendant
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.btnLogoff);
            this.Controls.Add(this.btnItemInventory);
            this.Controls.Add(this.btnEditLogin);
            this.Name = "frmAttendant";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmAttendant_FormClosing);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnItemInventory;
        private System.Windows.Forms.Button btnEditLogin;
        private System.Windows.Forms.Button btnLogoff;
    }
}