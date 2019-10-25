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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmReceipt));
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
            resources.ApplyResources(this.label1, "label1");
            this.label1.Name = "label1";
            // 
            // label2
            // 
            resources.ApplyResources(this.label2, "label2");
            this.label2.Name = "label2";
            // 
            // lblDateTime
            // 
            resources.ApplyResources(this.lblDateTime, "lblDateTime");
            this.lblDateTime.Name = "lblDateTime";
            // 
            // lblStartTransaction
            // 
            resources.ApplyResources(this.lblStartTransaction, "lblStartTransaction");
            this.lblStartTransaction.Name = "lblStartTransaction";
            // 
            // lblTransactionDetails
            // 
            resources.ApplyResources(this.lblTransactionDetails, "lblTransactionDetails");
            this.lblTransactionDetails.Name = "lblTransactionDetails";
            // 
            // lblTransactionAmount
            // 
            resources.ApplyResources(this.lblTransactionAmount, "lblTransactionAmount");
            this.lblTransactionAmount.Name = "lblTransactionAmount";
            // 
            // label4
            // 
            resources.ApplyResources(this.label4, "label4");
            this.label4.Name = "label4";
            // 
            // label5
            // 
            resources.ApplyResources(this.label5, "label5");
            this.label5.Name = "label5";
            // 
            // lblTotal
            // 
            resources.ApplyResources(this.lblTotal, "lblTotal");
            this.lblTotal.Name = "lblTotal";
            // 
            // lblCash
            // 
            resources.ApplyResources(this.lblCash, "lblCash");
            this.lblCash.Name = "lblCash";
            // 
            // lblChange
            // 
            resources.ApplyResources(this.lblChange, "lblChange");
            this.lblChange.Name = "lblChange";
            // 
            // lblEndTransaction
            // 
            resources.ApplyResources(this.lblEndTransaction, "lblEndTransaction");
            this.lblEndTransaction.Name = "lblEndTransaction";
            // 
            // lblTotalAmount
            // 
            resources.ApplyResources(this.lblTotalAmount, "lblTotalAmount");
            this.lblTotalAmount.Name = "lblTotalAmount";
            // 
            // lblCashAmount
            // 
            resources.ApplyResources(this.lblCashAmount, "lblCashAmount");
            this.lblCashAmount.Name = "lblCashAmount";
            // 
            // lblChangeText
            // 
            resources.ApplyResources(this.lblChangeText, "lblChangeText");
            this.lblChangeText.Name = "lblChangeText";
            // 
            // frmReceipt
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.lblCash);
            this.Controls.Add(this.lblChange);
            this.Controls.Add(this.lblChangeText);
            this.Controls.Add(this.lblCashAmount);
            this.Controls.Add(this.lblTotalAmount);
            this.Controls.Add(this.lblEndTransaction);
            this.Controls.Add(this.lblTotal);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.lblTransactionAmount);
            this.Controls.Add(this.lblTransactionDetails);
            this.Controls.Add(this.lblStartTransaction);
            this.Controls.Add(this.lblDateTime);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "frmReceipt";
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