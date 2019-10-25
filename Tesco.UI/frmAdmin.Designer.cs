namespace Tesco.UI
{
    partial class frmAdmin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmAdmin));
            this.btnAttendant = new System.Windows.Forms.Button();
            this.btnItemInventory = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnAttendant
            // 
            resources.ApplyResources(this.btnAttendant, "btnAttendant");
            this.btnAttendant.Name = "btnAttendant";
            this.btnAttendant.UseVisualStyleBackColor = true;
            this.btnAttendant.Click += new System.EventHandler(this.BtnAttendant_Click);
            // 
            // btnItemInventory
            // 
            resources.ApplyResources(this.btnItemInventory, "btnItemInventory");
            this.btnItemInventory.Name = "btnItemInventory";
            this.btnItemInventory.UseVisualStyleBackColor = true;
            this.btnItemInventory.Click += new System.EventHandler(this.BtnItemInventory_Click);
            // 
            // frmAdmin
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.btnItemInventory);
            this.Controls.Add(this.btnAttendant);
            this.Name = "frmAdmin";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmAdmin_FormClosing);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnAttendant;
        private System.Windows.Forms.Button btnItemInventory;
    }
}