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
            this.btnAttendant = new System.Windows.Forms.Button();
            this.btnItemInventory = new System.Windows.Forms.Button();
            this.SuspendLayout();
            this.btnAttendant.Location = new System.Drawing.Point(12, 12);
            this.btnAttendant.Name = "btnAttendant";
            this.btnAttendant.Size = new System.Drawing.Size(125, 23);
            this.btnAttendant.TabIndex = 0;
            this.btnAttendant.Text = "Store Attendant";
            this.btnAttendant.UseVisualStyleBackColor = true;
            this.btnAttendant.Click += new System.EventHandler(this.BtnAttendant_Click);
            this.btnItemInventory.Location = new System.Drawing.Point(143, 12);
            this.btnItemInventory.Name = "btnItemInventory";
            this.btnItemInventory.Size = new System.Drawing.Size(125, 23);
            this.btnItemInventory.TabIndex = 1;
            this.btnItemInventory.Text = "Item Inventory";
            this.btnItemInventory.UseVisualStyleBackColor = true;
            this.btnItemInventory.Click += new System.EventHandler(this.BtnItemInventory_Click);
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(281, 45);
            this.Controls.Add(this.btnItemInventory);
            this.Controls.Add(this.btnAttendant);
            this.Font = new System.Drawing.Font("Consolas", 9F, System.Drawing.FontStyle.Regular,
                System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.Name = "frmAdmin";
            this.Text = "TESCO Admin";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmAdmin_FormClosing);
            this.ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.Button btnAttendant;
        private System.Windows.Forms.Button btnItemInventory;
    }
}