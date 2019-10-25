namespace Tesco.UI
{
    partial class frmReceipt
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lblDateTime = new System.Windows.Forms.Label();
            this.lblStartTransaction = new System.Windows.Forms.Label();
            this.lblTransactionDetails = new System.Windows.Forms.Label();
            this.lblTransactionAmount = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.lblTotal = new System.Windows.Forms.Label();
            this.lblCash = new System.Windows.Forms.Label();
            this.lblChange = new System.Windows.Forms.Label();
            this.lblEndTransaction = new System.Windows.Forms.Label();
            this.lblTotalAmount = new System.Windows.Forms.Label();
            this.lblCashAmount = new System.Windows.Forms.Label();
            this.lblChangeText = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Consolas", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(145, 6);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(70, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "TESCO";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(142, 28);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(77, 15);
            this.label2.TabIndex = 1;
            this.label2.Text = "Entreprise";
            // 
            // lblDateTime
            // 
            this.lblDateTime.AutoSize = true;
            this.lblDateTime.Location = new System.Drawing.Point(54, 69);
            this.lblDateTime.Name = "lblDateTime";
            this.lblDateTime.Size = new System.Drawing.Size(0, 14);
            this.lblDateTime.TabIndex = 2;
            // 
            // lblStartTransaction
            // 
            this.lblStartTransaction.AutoSize = true;
            this.lblStartTransaction.Location = new System.Drawing.Point(21, 97);
            this.lblStartTransaction.Name = "lblStartTransaction";
            this.lblStartTransaction.Size = new System.Drawing.Size(329, 14);
            this.lblStartTransaction.TabIndex = 3;
            this.lblStartTransaction.Text = "**********   START OF TRANSACTION   **********";
            // 
            // lblTransactionDetails
            // 
            this.lblTransactionDetails.AutoSize = true;
            this.lblTransactionDetails.Location = new System.Drawing.Point(21, 129);
            this.lblTransactionDetails.Name = "lblTransactionDetails";
            this.lblTransactionDetails.Size = new System.Drawing.Size(0, 14);
            this.lblTransactionDetails.TabIndex = 4;
            this.lblTransactionDetails.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblTransactionAmount
            // 
            this.lblTransactionAmount.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.lblTransactionAmount.AutoSize = true;
            this.lblTransactionAmount.Location = new System.Drawing.Point(342, 87);
            this.lblTransactionAmount.Name = "lblTransactionAmount";
            this.lblTransactionAmount.Size = new System.Drawing.Size(0, 14);
            this.lblTransactionAmount.TabIndex = 5;
            this.lblTransactionAmount.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(266, 387);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(84, 14);
            this.label4.TabIndex = 6;
            this.label4.Text = "___________";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(266, 430);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(84, 14);
            this.label5.TabIndex = 7;
            this.label5.Text = "___________";
            // 
            // lblTotal
            // 
            this.lblTotal.AutoSize = true;
            this.lblTotal.Location = new System.Drawing.Point(222, 405);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(49, 14);
            this.lblTotal.TabIndex = 8;
            this.lblTotal.Text = "Total:";
            // 
            // lblCash
            // 
            this.lblCash.AutoSize = true;
            this.lblCash.Location = new System.Drawing.Point(229, 423);
            this.lblCash.Name = "lblCash";
            this.lblCash.Size = new System.Drawing.Size(42, 14);
            this.lblCash.TabIndex = 9;
            this.lblCash.Text = "Cash:";
            // 
            // lblChange
            // 
            this.lblChange.AutoSize = true;
            this.lblChange.Location = new System.Drawing.Point(215, 448);
            this.lblChange.Name = "lblChange";
            this.lblChange.Size = new System.Drawing.Size(56, 14);
            this.lblChange.TabIndex = 10;
            this.lblChange.Text = "Change:";
            // 
            // lblEndTransaction
            // 
            this.lblEndTransaction.AutoSize = true;
            this.lblEndTransaction.Location = new System.Drawing.Point(27, 487);
            this.lblEndTransaction.Name = "lblEndTransaction";
            this.lblEndTransaction.Size = new System.Drawing.Size(315, 14);
            this.lblEndTransaction.TabIndex = 11;
            this.lblEndTransaction.Text = "**********   END OF TRANSACTION   **********";
            // 
            // lblTotalAmount
            // 
            this.lblTotalAmount.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.lblTotalAmount.Location = new System.Drawing.Point(269, 406);
            this.lblTotalAmount.Name = "lblTotalAmount";
            this.lblTotalAmount.Size = new System.Drawing.Size(81, 13);
            this.lblTotalAmount.TabIndex = 12;
            this.lblTotalAmount.Text = "0";
            this.lblTotalAmount.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblCashAmount
            // 
            this.lblCashAmount.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.lblCashAmount.Location = new System.Drawing.Point(269, 424);
            this.lblCashAmount.Name = "lblCashAmount";
            this.lblCashAmount.Size = new System.Drawing.Size(81, 13);
            this.lblCashAmount.TabIndex = 13;
            this.lblCashAmount.Text = "0";
            this.lblCashAmount.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblChangeText
            // 
            this.lblChangeText.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.lblChangeText.Location = new System.Drawing.Point(269, 449);
            this.lblChangeText.Name = "lblChangeText";
            this.lblChangeText.Size = new System.Drawing.Size(81, 13);
            this.lblChangeText.TabIndex = 14;
            this.lblChangeText.Text = "0";
            this.lblChangeText.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // frmReceipt
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(371, 514);
            this.Controls.Add(this.lblChangeText);
            this.Controls.Add(this.lblCashAmount);
            this.Controls.Add(this.lblTotalAmount);
            this.Controls.Add(this.lblEndTransaction);
            this.Controls.Add(this.lblChange);
            this.Controls.Add(this.lblCash);
            this.Controls.Add(this.lblTotal);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.lblTransactionAmount);
            this.Controls.Add(this.lblTransactionDetails);
            this.Controls.Add(this.lblStartTransaction);
            this.Controls.Add(this.lblDateTime);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Consolas", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "frmReceipt";
            this.Text = "TESCO Receipt";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FrmReceipt_FormClosing);
            this.Load += new System.EventHandler(this.FrmReceipt_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblDateTime;
        private System.Windows.Forms.Label lblStartTransaction;
        private System.Windows.Forms.Label lblTransactionDetails;
        private System.Windows.Forms.Label lblTransactionAmount;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lblTotal;
        private System.Windows.Forms.Label lblCash;
        private System.Windows.Forms.Label lblChange;
        private System.Windows.Forms.Label lblEndTransaction;
        private System.Windows.Forms.Label lblTotalAmount;
        private System.Windows.Forms.Label lblCashAmount;
        private System.Windows.Forms.Label lblChangeText;
    }
}