namespace Tesco.UI
{
    partial class frmCheckout
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmCheckout));
            this.lblFullName = new System.Windows.Forms.Label();
            this.txtFullName = new System.Windows.Forms.TextBox();
            this.grpCustomerDetails = new System.Windows.Forms.GroupBox();
            this.lblAmount = new System.Windows.Forms.Label();
            this.lblAmountToPay = new System.Windows.Forms.Label();
            this.btnPayOrder = new System.Windows.Forms.Button();
            this.lblCashInHand = new System.Windows.Forms.Label();
            this.lblPhoneNumber = new System.Windows.Forms.Label();
            this.txtCashOnHand = new System.Windows.Forms.TextBox();
            this.lblEmail = new System.Windows.Forms.Label();
            this.txtPhoneNumber = new System.Windows.Forms.TextBox();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.grpCheckoutDetails = new System.Windows.Forms.GroupBox();
            this.lvCheckoutItems = new System.Windows.Forms.ListView();
            this.columnOrderItemId = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnOrderItemName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnOrderItemPrice = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnOrderItemQuantity = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnOrderItemAmount = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.grpCustomerDetails.SuspendLayout();
            this.grpCheckoutDetails.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblFullName
            // 
            resources.ApplyResources(this.lblFullName, "lblFullName");
            this.lblFullName.Name = "lblFullName";
            // 
            // txtFullName
            // 
            resources.ApplyResources(this.txtFullName, "txtFullName");
            this.txtFullName.Name = "txtFullName";
            this.txtFullName.Leave += new System.EventHandler(this.TxtFullName_Leave);
            // 
            // grpCustomerDetails
            // 
            resources.ApplyResources(this.grpCustomerDetails, "grpCustomerDetails");
            this.grpCustomerDetails.Controls.Add(this.lblAmountToPay);
            this.grpCustomerDetails.Controls.Add(this.txtFullName);
            this.grpCustomerDetails.Controls.Add(this.lblAmount);
            this.grpCustomerDetails.Controls.Add(this.btnPayOrder);
            this.grpCustomerDetails.Controls.Add(this.lblCashInHand);
            this.grpCustomerDetails.Controls.Add(this.lblPhoneNumber);
            this.grpCustomerDetails.Controls.Add(this.txtCashOnHand);
            this.grpCustomerDetails.Controls.Add(this.lblEmail);
            this.grpCustomerDetails.Controls.Add(this.txtPhoneNumber);
            this.grpCustomerDetails.Controls.Add(this.txtEmail);
            this.grpCustomerDetails.Controls.Add(this.lblFullName);
            this.grpCustomerDetails.Name = "grpCustomerDetails";
            this.grpCustomerDetails.TabStop = false;
            // 
            // lblAmount
            // 
            resources.ApplyResources(this.lblAmount, "lblAmount");
            this.lblAmount.Name = "lblAmount";
            // 
            // lblAmountToPay
            // 
            resources.ApplyResources(this.lblAmountToPay, "lblAmountToPay");
            this.lblAmountToPay.Name = "lblAmountToPay";
            // 
            // btnPayOrder
            // 
            resources.ApplyResources(this.btnPayOrder, "btnPayOrder");
            this.btnPayOrder.Name = "btnPayOrder";
            this.btnPayOrder.UseVisualStyleBackColor = true;
            this.btnPayOrder.Click += new System.EventHandler(this.BtnPayOrder_Click);
            // 
            // lblCashInHand
            // 
            resources.ApplyResources(this.lblCashInHand, "lblCashInHand");
            this.lblCashInHand.Name = "lblCashInHand";
            // 
            // lblPhoneNumber
            // 
            resources.ApplyResources(this.lblPhoneNumber, "lblPhoneNumber");
            this.lblPhoneNumber.Name = "lblPhoneNumber";
            // 
            // txtCashOnHand
            // 
            resources.ApplyResources(this.txtCashOnHand, "txtCashOnHand");
            this.txtCashOnHand.Name = "txtCashOnHand";
            this.txtCashOnHand.TextChanged += new System.EventHandler(this.TxtCashOnHand_TextChanged);
            this.txtCashOnHand.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtCashOnHand_KeyPress);
            // 
            // lblEmail
            // 
            resources.ApplyResources(this.lblEmail, "lblEmail");
            this.lblEmail.Name = "lblEmail";
            // 
            // txtPhoneNumber
            // 
            resources.ApplyResources(this.txtPhoneNumber, "txtPhoneNumber");
            this.txtPhoneNumber.Name = "txtPhoneNumber";
            this.txtPhoneNumber.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtPhoneNumber_KeyPress);
            this.txtPhoneNumber.Leave += new System.EventHandler(this.TxtPhoneNumber_Leave);
            // 
            // txtEmail
            // 
            resources.ApplyResources(this.txtEmail, "txtEmail");
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Leave += new System.EventHandler(this.TxtEmail_Leave);
            // 
            // grpCheckoutDetails
            // 
            resources.ApplyResources(this.grpCheckoutDetails, "grpCheckoutDetails");
            this.grpCheckoutDetails.Controls.Add(this.lvCheckoutItems);
            this.grpCheckoutDetails.Name = "grpCheckoutDetails";
            this.grpCheckoutDetails.TabStop = false;
            // 
            // lvCheckoutItems
            // 
            resources.ApplyResources(this.lvCheckoutItems, "lvCheckoutItems");
            this.lvCheckoutItems.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnOrderItemId,
            this.columnOrderItemName,
            this.columnOrderItemPrice,
            this.columnOrderItemQuantity,
            this.columnOrderItemAmount});
            this.lvCheckoutItems.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
            this.lvCheckoutItems.HideSelection = false;
            this.lvCheckoutItems.Name = "lvCheckoutItems";
            this.lvCheckoutItems.UseCompatibleStateImageBehavior = false;
            this.lvCheckoutItems.View = System.Windows.Forms.View.Details;
            // 
            // columnOrderItemId
            // 
            resources.ApplyResources(this.columnOrderItemId, "columnOrderItemId");
            // 
            // columnOrderItemName
            // 
            resources.ApplyResources(this.columnOrderItemName, "columnOrderItemName");
            // 
            // columnOrderItemPrice
            // 
            resources.ApplyResources(this.columnOrderItemPrice, "columnOrderItemPrice");
            // 
            // columnOrderItemQuantity
            // 
            resources.ApplyResources(this.columnOrderItemQuantity, "columnOrderItemQuantity");
            // 
            // columnOrderItemAmount
            // 
            resources.ApplyResources(this.columnOrderItemAmount, "columnOrderItemAmount");
            // 
            // frmCheckout
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.grpCheckoutDetails);
            this.Controls.Add(this.grpCustomerDetails);
            this.Name = "frmCheckout";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FrmCheckout_FormClosing);
            this.Load += new System.EventHandler(this.FrmCheckout_Load);
            this.grpCustomerDetails.ResumeLayout(false);
            this.grpCustomerDetails.PerformLayout();
            this.grpCheckoutDetails.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Label lblFullName;
        private System.Windows.Forms.TextBox txtFullName;
        private System.Windows.Forms.GroupBox grpCustomerDetails;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.Label lblPhoneNumber;
        private System.Windows.Forms.TextBox txtPhoneNumber;
        private System.Windows.Forms.Label lblCashInHand;
        private System.Windows.Forms.TextBox txtCashOnHand;
        private System.Windows.Forms.GroupBox grpCheckoutDetails;
        private System.Windows.Forms.Button btnPayOrder;
        private System.Windows.Forms.ListView lvCheckoutItems;
        private System.Windows.Forms.ColumnHeader columnOrderItemId;
        private System.Windows.Forms.ColumnHeader columnOrderItemName;
        private System.Windows.Forms.ColumnHeader columnOrderItemPrice;
        private System.Windows.Forms.ColumnHeader columnOrderItemQuantity;
        private System.Windows.Forms.ColumnHeader columnOrderItemAmount;
        private System.Windows.Forms.Label lblAmountToPay;
        private System.Windows.Forms.Label lblAmount;
    }
}