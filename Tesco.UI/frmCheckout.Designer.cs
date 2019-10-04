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
            this.label1 = new System.Windows.Forms.Label();
            this.txtFullName = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.lblAmountToPay = new System.Windows.Forms.Label();
            this.Label5 = new System.Windows.Forms.Label();
            this.btnPayOrder = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtCashOnHand = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtPhoneNumber = new System.Windows.Forms.TextBox();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lvCheckoutItems = new System.Windows.Forms.ListView();
            this.columnOrderItemId = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnOrderItemName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnOrderItemPrice = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnOrderItemQuantity = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnOrderItemAmount = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(35, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(70, 14);
            this.label1.TabIndex = 1;
            this.label1.Text = "FullName:";
            // 
            // txtFullName
            // 
            this.txtFullName.Location = new System.Drawing.Point(106, 27);
            this.txtFullName.Name = "txtFullName";
            this.txtFullName.Size = new System.Drawing.Size(390, 22);
            this.txtFullName.TabIndex = 1;
            this.txtFullName.Leave += new System.EventHandler(this.TxtFullName_Leave);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.lblAmountToPay);
            this.groupBox2.Controls.Add(this.Label5);
            this.groupBox2.Controls.Add(this.btnPayOrder);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.txtCashOnHand);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.txtPhoneNumber);
            this.groupBox2.Controls.Add(this.txtEmail);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.txtFullName);
            this.groupBox2.Location = new System.Drawing.Point(12, 57);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(514, 182);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Customer Details";
            // 
            // lblAmountToPay
            // 
            this.lblAmountToPay.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.lblAmountToPay.Location = new System.Drawing.Point(413, 112);
            this.lblAmountToPay.Name = "lblAmountToPay";
            this.lblAmountToPay.Size = new System.Drawing.Size(83, 19);
            this.lblAmountToPay.TabIndex = 10;
            this.lblAmountToPay.Text = "0";
            this.lblAmountToPay.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // Label5
            // 
            this.Label5.AutoSize = true;
            this.Label5.Location = new System.Drawing.Point(302, 114);
            this.Label5.Name = "Label5";
            this.Label5.Size = new System.Drawing.Size(105, 14);
            this.Label5.TabIndex = 6;
            this.Label5.Text = "Amount To Pay:";
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
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(7, 114);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(98, 14);
            this.label4.TabIndex = 3;
            this.label4.Text = "Cash On Hand:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(7, 86);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(98, 14);
            this.label3.TabIndex = 3;
            this.label3.Text = "Phone Number:";
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
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(56, 58);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(49, 14);
            this.label2.TabIndex = 3;
            this.label2.Text = "Email:";
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
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lvCheckoutItems);
            this.groupBox1.Location = new System.Drawing.Point(532, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(473, 271);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Checkout Details";
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
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.groupBox2);
            this.Font = new System.Drawing.Font("Consolas", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "frmCheckout";
            this.Text = "TESCO Checkout";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FrmCheckout_FormClosing);
            this.Load += new System.EventHandler(this.FrmCheckout_Load);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtFullName;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtPhoneNumber;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtCashOnHand;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnPayOrder;
        private System.Windows.Forms.ListView lvCheckoutItems;
        private System.Windows.Forms.ColumnHeader columnOrderItemId;
        private System.Windows.Forms.ColumnHeader columnOrderItemName;
        private System.Windows.Forms.ColumnHeader columnOrderItemPrice;
        private System.Windows.Forms.ColumnHeader columnOrderItemQuantity;
        private System.Windows.Forms.ColumnHeader columnOrderItemAmount;
        private System.Windows.Forms.Label Label5;
        private System.Windows.Forms.Label lblAmountToPay;
    }
}