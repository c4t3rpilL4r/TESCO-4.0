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
            this.lblWelcome.AutoSize = true;
            this.lblWelcome.Font = new System.Drawing.Font("Consolas", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblWelcome.Location = new System.Drawing.Point(96, 36);
            this.lblWelcome.Name = "lblWelcome";
            this.lblWelcome.Size = new System.Drawing.Size(0, 28);
            this.lblWelcome.TabIndex = 0;
            this.lblWelcome.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblTo
            // 
            this.lblTo.AutoSize = true;
            this.lblTo.Font = new System.Drawing.Font("Consolas", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTo.Location = new System.Drawing.Point(127, 64);
            this.lblTo.Name = "lblTo";
            this.lblTo.Size = new System.Drawing.Size(0, 28);
            this.lblTo.TabIndex = 1;
            this.lblTo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Consolas", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(94, 92);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(107, 37);
            this.label3.TabIndex = 2;
            this.label3.Text = "TESCO";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnStartShopping
            // 
            this.btnStartShopping.Location = new System.Drawing.Point(66, 132);
            this.btnStartShopping.Name = "btnStartShopping";
            this.btnStartShopping.Size = new System.Drawing.Size(166, 31);
            this.btnStartShopping.TabIndex = 3;
            this.btnStartShopping.UseVisualStyleBackColor = true;
            this.btnStartShopping.Click += new System.EventHandler(this.BtnStartShopping_Click);
            // 
            // linkRegister
            // 
            this.linkRegister.LinkColor = System.Drawing.Color.Black;
            this.linkRegister.Location = new System.Drawing.Point(12, 218);
            this.linkRegister.Name = "linkRegister";
            this.linkRegister.Size = new System.Drawing.Size(63, 15);
            this.linkRegister.TabIndex = 4;
            this.linkRegister.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.LinkRegister_LinkClicked);
            this.linkRegister.MouseEnter += new System.EventHandler(this.linkRegister_MouseEnter);
            this.linkRegister.MouseLeave += new System.EventHandler(this.linkRegister_MouseLeave);
            // 
            // linkLogIn
            // 
            this.linkLogIn.LinkColor = System.Drawing.Color.Black;
            this.linkLogIn.Location = new System.Drawing.Point(232, 218);
            this.linkLogIn.Name = "linkLogIn";
            this.linkLogIn.Size = new System.Drawing.Size(49, 15);
            this.linkLogIn.TabIndex = 5;
            this.linkLogIn.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.LinkLogIn_LinkClicked);
            this.linkLogIn.MouseEnter += new System.EventHandler(this.linkLogIn_MouseEnter);
            this.linkLogIn.MouseLeave += new System.EventHandler(this.linkLogIn_MouseLeave);
            // 
            // frmWelcome
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(293, 241);
            this.Controls.Add(this.linkLogIn);
            this.Controls.Add(this.linkRegister);
            this.Controls.Add(this.btnStartShopping);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lblTo);
            this.Controls.Add(this.lblWelcome);
            this.Font = new System.Drawing.Font("Consolas", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
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

