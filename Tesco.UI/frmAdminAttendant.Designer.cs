namespace Tesco.UI
{
    partial class frmAdminAttendant
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmAdminAttendant));
            this.lvAttendants = new System.Windows.Forms.ListView();
            this.columnAttendantId = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnAttendantFullName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnAttendantUsername = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnAttendantPassword = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.btnAddAttendant = new System.Windows.Forms.Button();
            this.btnDeleteAttendant = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lvAttendants
            // 
            resources.ApplyResources(this.lvAttendants, "lvAttendants");
            this.lvAttendants.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnAttendantId,
            this.columnAttendantFullName,
            this.columnAttendantUsername,
            this.columnAttendantPassword});
            this.lvAttendants.FullRowSelect = true;
            this.lvAttendants.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
            this.lvAttendants.HideSelection = false;
            this.lvAttendants.Name = "lvAttendants";
            this.lvAttendants.UseCompatibleStateImageBehavior = false;
            this.lvAttendants.View = System.Windows.Forms.View.Details;
            this.lvAttendants.SelectedIndexChanged += new System.EventHandler(this.LvAttendants_SelectedIndexChanged);
            // 
            // columnAttendantId
            // 
            resources.ApplyResources(this.columnAttendantId, "columnAttendantId");
            // 
            // columnAttendantFullName
            // 
            resources.ApplyResources(this.columnAttendantFullName, "columnAttendantFullName");
            // 
            // columnAttendantUsername
            // 
            resources.ApplyResources(this.columnAttendantUsername, "columnAttendantUsername");
            // 
            // columnAttendantPassword
            // 
            resources.ApplyResources(this.columnAttendantPassword, "columnAttendantPassword");
            // 
            // btnAddAttendant
            // 
            resources.ApplyResources(this.btnAddAttendant, "btnAddAttendant");
            this.btnAddAttendant.Name = "btnAddAttendant";
            this.btnAddAttendant.UseVisualStyleBackColor = true;
            this.btnAddAttendant.Click += new System.EventHandler(this.BtnAddAttendant_Click);
            // 
            // btnDeleteAttendant
            // 
            resources.ApplyResources(this.btnDeleteAttendant, "btnDeleteAttendant");
            this.btnDeleteAttendant.Name = "btnDeleteAttendant";
            this.btnDeleteAttendant.UseVisualStyleBackColor = true;
            this.btnDeleteAttendant.Click += new System.EventHandler(this.BtnDeleteAttendant_Click);
            // 
            // frmAdminAttendant
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.btnDeleteAttendant);
            this.Controls.Add(this.btnAddAttendant);
            this.Controls.Add(this.lvAttendants);
            this.Name = "frmAdminAttendant";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmAdminAttendant_FormClosing);
            this.Load += new System.EventHandler(this.FrmAdminAttendant_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListView lvAttendants;
        private System.Windows.Forms.ColumnHeader columnAttendantId;
        private System.Windows.Forms.ColumnHeader columnAttendantFullName;
        private System.Windows.Forms.ColumnHeader columnAttendantUsername;
        private System.Windows.Forms.ColumnHeader columnAttendantPassword;
        private System.Windows.Forms.Button btnAddAttendant;
        private System.Windows.Forms.Button btnDeleteAttendant;
    }
}