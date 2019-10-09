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
            this.lvAttendants = new System.Windows.Forms.ListView();
            this.columnAttendantId = new System.Windows.Forms.ColumnHeader();
            this.columnAttendantFullName = new System.Windows.Forms.ColumnHeader();
            this.columnAttendantUsername = new System.Windows.Forms.ColumnHeader();
            this.columnAttendantPassword = new System.Windows.Forms.ColumnHeader();
            this.btnAddAttendant = new System.Windows.Forms.Button();
            this.btnDeleteAttendant = new System.Windows.Forms.Button();
            this.SuspendLayout();
            this.lvAttendants.Columns.AddRange(new System.Windows.Forms.ColumnHeader[]
            {
                this.columnAttendantId, this.columnAttendantFullName, this.columnAttendantUsername,
                this.columnAttendantPassword
            });
            this.lvAttendants.FullRowSelect = true;
            this.lvAttendants.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
            this.lvAttendants.HideSelection = false;
            this.lvAttendants.Location = new System.Drawing.Point(12, 12);
            this.lvAttendants.Name = "lvAttendants";
            this.lvAttendants.Size = new System.Drawing.Size(604, 333);
            this.lvAttendants.TabIndex = 0;
            this.lvAttendants.UseCompatibleStateImageBehavior = false;
            this.lvAttendants.View = System.Windows.Forms.View.Details;
            this.lvAttendants.SelectedIndexChanged += new System.EventHandler(this.LvAttendants_SelectedIndexChanged);
            this.columnAttendantId.Text = "Id";
            this.columnAttendantId.Width = 50;
            this.columnAttendantFullName.Text = "Full Name";
            this.columnAttendantFullName.Width = 250;
            this.columnAttendantUsername.Text = "Username";
            this.columnAttendantUsername.Width = 150;
            this.columnAttendantPassword.Text = "Password";
            this.columnAttendantPassword.Width = 150;
            this.btnAddAttendant.Location = new System.Drawing.Point(162, 360);
            this.btnAddAttendant.Name = "btnAddAttendant";
            this.btnAddAttendant.Size = new System.Drawing.Size(135, 22);
            this.btnAddAttendant.TabIndex = 1;
            this.btnAddAttendant.Text = "Add Attendant";
            this.btnAddAttendant.UseVisualStyleBackColor = true;
            this.btnAddAttendant.Click += new System.EventHandler(this.BtnAddAttendant_Click);
            this.btnDeleteAttendant.Enabled = false;
            this.btnDeleteAttendant.Location = new System.Drawing.Point(337, 360);
            this.btnDeleteAttendant.Name = "btnDeleteAttendant";
            this.btnDeleteAttendant.Size = new System.Drawing.Size(135, 22);
            this.btnDeleteAttendant.TabIndex = 2;
            this.btnDeleteAttendant.Text = "Delete Attendant";
            this.btnDeleteAttendant.UseVisualStyleBackColor = true;
            this.btnDeleteAttendant.Click += new System.EventHandler(this.BtnDeleteAttendant_Click);
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(629, 398);
            this.Controls.Add(this.btnDeleteAttendant);
            this.Controls.Add(this.btnAddAttendant);
            this.Controls.Add(this.lvAttendants);
            this.Font = new System.Drawing.Font("Consolas", 9F, System.Drawing.FontStyle.Regular,
                System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.Name = "frmAdminAttendant";
            this.Text = "TESCO Admin Attendant Page";
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