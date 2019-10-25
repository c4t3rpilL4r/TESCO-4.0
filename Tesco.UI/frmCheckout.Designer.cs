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
            this.lblFullName.AutoSize = true;
            this.lblFullName.Location = new System.Drawing.Point(28, 30);
            this.lblFullName.Name = "lblFullName";
            this.lblFullName.Size = new System.Drawing.Size(77, 14);
            this.lblFullName.TabIndex = 1;
            this.lblFullName.Text = "Full Name:";
            // 
            // txtFullName
            // 
            this.txtFullName.Location = new System.Drawing.Point(106, 27);
            this.txtFullName.Name = "txtFullName";
            this.txtFullName.Size = new System.Drawing.Size(390, 22);
            this.txtFullName.TabIndex = 1;
            this.txtFullName.Leave += new System.EventHandler(this.TxtFullName_Leave);
            // 
            // grpCustomerDetails
            // 
            this.grpCustomerDetails.Controls.Add(this.lblAmount);
            this.grpCustomerDetails.Controls.Add(this.lblAmountToPay);
            this.grpCustomerDetails.Controls.Add(this.btnPayOrder);
            this.grpCustomerDetails.Controls.Add(this.lblCashInHand);
            this.grpCustomerDetails.Controls.Add(this.lblPhoneNumber);
            this.grpCustomerDetails.Controls.Add(this.txtCashOnHand);
            this.grpCustomerDetails.Controls.Add(this.lblEmail);
            this.grpCustomerDetails.Controls.Add(this.txtPhoneNumber);
            this.grpCustomerDetails.Controls.Add(this.txtEmail);
            this.grpCustomerDetails.Controls.Add(this.lblFullName);
            this.grpCustomerDetails.Controls.Add(this.txtFullName);
            this.grpCustomerDetails.Location = new System.Drawing.Point(12, 57);
            this.grpCustomerDetails.Name = "grpCustomerDetails";
            this.grpCustomerDetails.Size = new System.Drawing.Size(514, 182);
            this.grpCustomerDetails.TabIndex = 1;
            this.grpCustomerDetails.TabStop = false;
            this.grpCustomerDetails.Text = "Customer Details";
            // 
            // lblAmount
            // 
            this.lblAmount.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.lblAmount.Location = new System.Drawing.Point(413, 112);
            this.lblAmount.Name = "lblAmount";
            this.lblAmount.Size = new System.Drawing.Size(83, 19);
            this.lblAmount.TabIndex = 10;
            this.lblAmount.Text = "0";
            this.lblAmount.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblAmountToPay
            // 
            this.lblAmountToPay.AutoSize = true;
            this.lblAmountToPay.Location = new System.Drawing.Point(302, 114);
            this.lblAmountToPay.Name = "lblAmountToPay";
            this.lblAmountToPay.Size = new System.Drawing.Size(105, 14);
            this.lblAmountToPay.TabIndex = 6;
            this.lblAmountToPay.Text = "Amount To Pay:";
            // 
            // btnPayOrder
            // 
            this.btnPayOrder.Enabled = false;
            this.btnPayOrder.Location = new System.Drawing.Point(215, 139);
            this.btnPayOrder.Name = "btnPayOrder";
            this.btnPayOrder.Size = new System.Drawing.Size(95, 23);
            this.btnPayOrder.TabIndex = 5;
            this.btnPayOrder.Text = "Pay Order";
            this.btnPayOrder.UseVisualStyleBackColor = true;
            this.btnPayOrder.Click += new System.EventHandler(this.BtnPayOrder_Click);
            // 
            // lblCashInHand
            // 
            this.lblCashInHand.AutoSize = true;
            this.lblCashInHand.Location = new System.Drawing.Point(7, 114);
            this.lblCashInHand.Name = "lblCashInHand";
            this.lblCashInHand.Size = new System.Drawing.Size(98, 14);
            this.lblCashInHand.TabIndex = 3;
            this.lblCashInHand.Text = "Cash On Hand:";
            // 
            // lblPhoneNumber
            // 
            this.lblPhoneNumber.AutoSize = true;
            this.lblPhoneNumber.Location = new System.Drawing.Point(7, 86);
            this.lblPhoneNumber.Name = "lblPhoneNumber";
            this.lblPhoneNumber.Size = new System.Drawing.Size(98, 14);
            this.lblPhoneNumber.TabIndex = 3;
            this.lblPhoneNumber.Text = "Phone Number:";
            // 
            // txtCashOnHand
            // 
            this.txtCashOnHand.Location = new System.Drawing.Point(106, 111);
            this.txtCashOnHand.Name = "txtCashOnHand";
            this.txtCashOnHand.Size = new System.Drawing.Size(172, 22);
            this.txtCashOnHand.TabIndex = 4;
            this.txtCashOnHand.TextChanged += new System.EventHandler(this.TxtCashOnHand_TextChanged);
            this.txtCashOnHand.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtCashOnHand_KeyPress);
            // 
            // lblEmail
            // 
            this.lblEmail.AutoSize = true;
            this.lblEmail.Location = new System.Drawing.Point(56, 58);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(49, 14);
            this.lblEmail.TabIndex = 3;
            this.lblEmail.Text = "Email:";
            // 
            // txtPhoneNumber
            // 
            this.txtPhoneNumber.Location = new System.Drawing.Point(106, 83);
            this.txtPhoneNumber.MaxLength = 11;
            this.txtPhoneNumber.Name = "txtPhoneNumber";
            this.txtPhoneNumber.Size = new System.Drawing.Size(390, 22);
            this.txtPhoneNumber.TabIndex = 3;
            this.txtPhoneNumber.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtPhoneNumber_KeyPress);
            this.txtPhoneNumber.Leave += new System.EventHandler(this.TxtPhoneNumber_Leave);
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(106, 55);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(390, 22);
            this.txtEmail.TabIndex = 2;
            this.txtEmail.Leave += new System.EventHandler(this.TxtEmail_Leave);
            // 
            // grpCheckoutDetails
            // 
            this.grpCheckoutDetails.Controls.Add(this.lvCheckoutItems);
            this.grpCheckoutDetails.Location = new System.Drawing.Point(532, 12);
            this.grpCheckoutDetails.Name = "grpCheckoutDetails";
            this.grpCheckoutDetails.Size = new System.Drawing.Size(473, 271);
            this.grpCheckoutDetails.TabIndex = 5;
            this.grpCheckoutDetails.TabStop = false;
            this.grpCheckoutDetails.Text = "Checkout Details";
            // 
            // lvCheckoutItems
            // 
            this.lvCheckoutItems.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnOrderItemId,
            this.columnOrderItemName,
            this.columnOrderItemPrice,
            this.columnOrderItemQuantity,
            this.columnOrderItemAmount});
            this.lvCheckoutItems.Enabled = false;
            this.lvCheckoutItems.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
            this.lvCheckoutItems.HideSelection = false;
            this.lvCheckoutItems.Location = new System.Drawing.Point(6, 21);
            this.lvCheckoutItems.Name = "lvCheckoutItems";
            this.lvCheckoutItems.Size = new System.Drawing.Size(458, 242);
            this.lvCheckoutItems.TabIndex = 0;
            this.lvCheckoutItems.UseCompatibleStateImageBehavior = false;
            this.lvCheckoutItems.View = System.Windows.Forms.View.Details;
            // 
            // columnOrderItemId
            // 
            this.columnOrderItemId.Text = "";
            this.columnOrderItemId.Width = 0;
            // 
            // columnOrderItemName
            // 
            this.columnOrderItemName.Text = "Name";
            this.columnOrderItemName.Width = 250;
            // 
            // columnOrderItemPrice
            // 
            this.columnOrderItemPrice.Text = "Price";
            this.columnOrderItemPrice.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // columnOrderItemQuantity
            // 
            this.columnOrderItemQuantity.Text = "Quantity";
            this.columnOrderItemQuantity.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.columnOrderItemQuantity.Width = 70;
            // 
            // columnOrderItemAmount
            // 
            this.columnOrderItemAmount.Text = "Amount";
            this.columnOrderItemAmount.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.columnOrderItemAmount.Width = 70;
            // 
            // frmCheckout
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1018, 295);
            this.Controls.Add(this.grpCheckoutDetails);
            this.Controls.Add(this.grpCustomerDetails);
            this.Font = new System.Drawing.Font("Consolas", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "frmCheckout";
            this.Text = "TESCO Checkout";
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