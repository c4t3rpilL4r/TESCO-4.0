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
            this.btnItemInventory = new System.Windows.Forms.Button();
            this.btnEditLogin = new System.Windows.Forms.Button();
            this.btnLogoff = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnItemInventory
            // 
            this.btnItemInventory.Location = new System.Drawing.Point(143, 11);
            this.btnItemInventory.Name = "btnItemInventory";
            this.btnItemInventory.Size = new System.Drawing.Size(125, 23);
            this.btnItemInventory.TabIndex = 3;
            this.btnItemInventory.Text = "Item Inventory";
            this.btnItemInventory.UseVisualStyleBackColor = true;
            this.btnItemInventory.Click += new System.EventHandler(this.BtnItemInventory_Click);
            // 
            // btnEditLogin
            // 
            this.btnEditLogin.Location = new System.Drawing.Point(12, 11);
            this.btnEditLogin.Name = "btnEditLogin";
            this.btnEditLogin.Size = new System.Drawing.Size(125, 23);
            this.btnEditLogin.TabIndex = 2;
            this.btnEditLogin.Text = "Edit Login";
            this.btnEditLogin.UseVisualStyleBackColor = true;
            this.btnEditLogin.Click += new System.EventHandler(this.BtnEditLogin_Click);
            // 
            // btnLogoff
            // 
            this.btnLogoff.Location = new System.Drawing.Point(78, 40);
            this.btnLogoff.Name = "btnLogoff";
            this.btnLogoff.Size = new System.Drawing.Size(125, 23);
            this.btnLogoff.TabIndex = 4;
            this.btnLogoff.Text = "Log off";
            this.btnLogoff.UseVisualStyleBackColor = true;
            this.btnLogoff.Click += new System.EventHandler(this.BtnLogoff_Click);
            // 
            // frmAttendant
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(281, 72);
            this.Controls.Add(this.btnLogoff);
            this.Controls.Add(this.btnItemInventory);
            this.Controls.Add(this.btnEditLogin);
            this.Font = new System.Drawing.Font("Consolas", 9F, System.Drawing.FontStyle.Regular,
                System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.Name = "frmAttendant";
            this.Text = "TESCO Attendant";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmAttendant_FormClosing);
            this.ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.Button btnItemInventory;
        private System.Windows.Forms.Button btnEditLogin;
        private System.Windows.Forms.Button btnLogoff;
    }
}