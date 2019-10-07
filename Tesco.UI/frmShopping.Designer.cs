namespace Tesco.UI
{
    partial class frmShopping
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
            this.lvItems = new System.Windows.Forms.ListView();
            this.columnItemId = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnItemName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnItemType = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnItemDiscount = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnItemPrice = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnItemStocks = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnResetSort = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.cboSortByType = new System.Windows.Forms.ComboBox();
            this.cboSortByNamePrice = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnAddToCart = new System.Windows.Forms.Button();
            this.lblQuantity = new System.Windows.Forms.Label();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnSubtract = new System.Windows.Forms.Button();
            this.lblItemDetails = new System.Windows.Forms.Label();
            this.lvCart = new System.Windows.Forms.ListView();
            this.columnCartItemId = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnCartItemName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnCartItemQuantity = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnCartItemAmount = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.btnCheckout = new System.Windows.Forms.Button();
            this.lblTotalAmount = new System.Windows.Forms.Label();
            this.btnRemoveOrder = new System.Windows.Forms.Button();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.lblUserGreeting = new System.Windows.Forms.Label();
            this.btnSignOff = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.SuspendLayout();
            // 
            // lvItems
            // 
            this.lvItems.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnItemId,
            this.columnItemName,
            this.columnItemType,
            this.columnItemDiscount,
            this.columnItemPrice,
            this.columnItemStocks});
            this.lvItems.FullRowSelect = true;
            this.lvItems.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
            this.lvItems.HideSelection = false;
            this.lvItems.Location = new System.Drawing.Point(12, 101);
            this.lvItems.Name = "lvItems";
            this.lvItems.Size = new System.Drawing.Size(507, 287);
            this.lvItems.TabIndex = 0;
            this.lvItems.UseCompatibleStateImageBehavior = false;
            this.lvItems.View = System.Windows.Forms.View.Details;
            this.lvItems.SelectedIndexChanged += new System.EventHandler(this.LvItems_SelectedIndexChanged);
            this.lvItems.Leave += new System.EventHandler(this.LvItems_Leave);
            // 
            // columnItemId
            // 
            this.columnItemId.Text = "";
            this.columnItemId.Width = 0;
            // 
            // columnItemName
            // 
            this.columnItemName.Text = "Name";
            this.columnItemName.Width = 240;
            // 
            // columnItemType
            // 
            this.columnItemType.Text = "Type";
            this.columnItemType.Width = 100;
            // 
            // columnItemDiscount
            // 
            this.columnItemDiscount.Text = "";
            this.columnItemDiscount.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.columnItemDiscount.Width = 50;
            // 
            // columnItemPrice
            // 
            this.columnItemPrice.Text = "Price";
            this.columnItemPrice.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.columnItemPrice.Width = 50;
            // 
            // columnItemStocks
            // 
            this.columnItemStocks.Text = "Stocks";
            this.columnItemStocks.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnResetSort);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.cboSortByType);
            this.groupBox1.Controls.Add(this.cboSortByNamePrice);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(507, 83);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Sorting";
            // 
            // btnResetSort
            // 
            this.btnResetSort.Location = new System.Drawing.Point(352, 41);
            this.btnResetSort.Name = "btnResetSort";
            this.btnResetSort.Size = new System.Drawing.Size(140, 22);
            this.btnResetSort.TabIndex = 4;
            this.btnResetSort.Text = "Reset Sort Order";
            this.btnResetSort.UseVisualStyleBackColor = true;
            this.btnResetSort.Click += new System.EventHandler(this.BtnResetSort_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(181, 24);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(63, 14);
            this.label2.TabIndex = 3;
            this.label2.Text = "By Type:";
            // 
            // cboSortByType
            // 
            this.cboSortByType.FormattingEnabled = true;
            this.cboSortByType.Location = new System.Drawing.Point(184, 41);
            this.cboSortByType.Name = "cboSortByType";
            this.cboSortByType.Size = new System.Drawing.Size(141, 22);
            this.cboSortByType.TabIndex = 2;
            this.cboSortByType.SelectedIndexChanged += new System.EventHandler(this.CboSortByType_SelectedIndexChanged);
            // 
            // cboSortByNamePrice
            // 
            this.cboSortByNamePrice.FormattingEnabled = true;
            this.cboSortByNamePrice.Location = new System.Drawing.Point(13, 41);
            this.cboSortByNamePrice.Name = "cboSortByNamePrice";
            this.cboSortByNamePrice.Size = new System.Drawing.Size(141, 22);
            this.cboSortByNamePrice.TabIndex = 1;
            this.cboSortByNamePrice.SelectedIndexChanged += new System.EventHandler(this.CboSortByNamePrice_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(10, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(105, 14);
            this.label1.TabIndex = 0;
            this.label1.Text = "By Name/Price:";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnAddToCart);
            this.groupBox2.Controls.Add(this.lblQuantity);
            this.groupBox2.Controls.Add(this.btnAdd);
            this.groupBox2.Controls.Add(this.btnSubtract);
            this.groupBox2.Location = new System.Drawing.Point(27, 394);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(134, 131);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Add To Cart";
            // 
            // btnAddToCart
            // 
            this.btnAddToCart.Enabled = false;
            this.btnAddToCart.Location = new System.Drawing.Point(11, 70);
            this.btnAddToCart.Name = "btnAddToCart";
            this.btnAddToCart.Size = new System.Drawing.Size(111, 22);
            this.btnAddToCart.TabIndex = 5;
            this.btnAddToCart.Text = "Add To Cart";
            this.btnAddToCart.UseVisualStyleBackColor = true;
            this.btnAddToCart.Click += new System.EventHandler(this.BtnAddToCart_Click);
            // 
            // lblQuantity
            // 
            this.lblQuantity.AutoSize = true;
            this.lblQuantity.Location = new System.Drawing.Point(59, 43);
            this.lblQuantity.Name = "lblQuantity";
            this.lblQuantity.Size = new System.Drawing.Size(14, 14);
            this.lblQuantity.TabIndex = 7;
            this.lblQuantity.Text = "0";
            this.lblQuantity.TextChanged += new System.EventHandler(this.LblQuantity_TextChanged);
            // 
            // btnAdd
            // 
            this.btnAdd.Enabled = false;
            this.btnAdd.Location = new System.Drawing.Point(81, 39);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(26, 22);
            this.btnAdd.TabIndex = 6;
            this.btnAdd.Text = "+";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.BtnAdd_Click);
            // 
            // btnSubtract
            // 
            this.btnSubtract.Enabled = false;
            this.btnSubtract.Location = new System.Drawing.Point(24, 39);
            this.btnSubtract.Name = "btnSubtract";
            this.btnSubtract.Size = new System.Drawing.Size(26, 22);
            this.btnSubtract.TabIndex = 5;
            this.btnSubtract.Text = "-";
            this.btnSubtract.UseVisualStyleBackColor = true;
            this.btnSubtract.Click += new System.EventHandler(this.BtnSubtract_Click);
            // 
            // lblItemDetails
            // 
            this.lblItemDetails.AutoSize = true;
            this.lblItemDetails.Location = new System.Drawing.Point(25, 18);
            this.lblItemDetails.Name = "lblItemDetails";
            this.lblItemDetails.Size = new System.Drawing.Size(0, 14);
            this.lblItemDetails.TabIndex = 8;
            // 
            // lvCart
            // 
            this.lvCart.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnCartItemId,
            this.columnCartItemName,
            this.columnCartItemQuantity,
            this.columnCartItemAmount});
            this.lvCart.FullRowSelect = true;
            this.lvCart.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
            this.lvCart.HideSelection = false;
            this.lvCart.Location = new System.Drawing.Point(6, 19);
            this.lvCart.Name = "lvCart";
            this.lvCart.Size = new System.Drawing.Size(364, 304);
            this.lvCart.TabIndex = 3;
            this.lvCart.UseCompatibleStateImageBehavior = false;
            this.lvCart.View = System.Windows.Forms.View.Details;
            this.lvCart.SelectedIndexChanged += new System.EventHandler(this.LvCart_SelectedIndexChanged);
            // 
            // columnCartItemId
            // 
            this.columnCartItemId.Text = "";
            this.columnCartItemId.Width = 0;
            // 
            // columnCartItemName
            // 
            this.columnCartItemName.Text = "Name";
            this.columnCartItemName.Width = 210;
            // 
            // columnCartItemQuantity
            // 
            this.columnCartItemQuantity.Text = "Quantity";
            this.columnCartItemQuantity.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.columnCartItemQuantity.Width = 75;
            // 
            // columnCartItemAmount
            // 
            this.columnCartItemAmount.Text = "Amount";
            this.columnCartItemAmount.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.columnCartItemAmount.Width = 75;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.btnCheckout);
            this.groupBox3.Controls.Add(this.lblTotalAmount);
            this.groupBox3.Controls.Add(this.btnRemoveOrder);
            this.groupBox3.Controls.Add(this.lvCart);
            this.groupBox3.Location = new System.Drawing.Point(545, 91);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(376, 406);
            this.groupBox3.TabIndex = 4;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Cart";
            // 
            // btnCheckout
            // 
            this.btnCheckout.Enabled = false;
            this.btnCheckout.Location = new System.Drawing.Point(141, 373);
            this.btnCheckout.Name = "btnCheckout";
            this.btnCheckout.Size = new System.Drawing.Size(109, 23);
            this.btnCheckout.TabIndex = 10;
            this.btnCheckout.Text = "Checkout";
            this.btnCheckout.UseVisualStyleBackColor = true;
            this.btnCheckout.Click += new System.EventHandler(this.BtnCheckout_Click);
            // 
            // lblTotalAmount
            // 
            this.lblTotalAmount.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.lblTotalAmount.Location = new System.Drawing.Point(214, 340);
            this.lblTotalAmount.Name = "lblTotalAmount";
            this.lblTotalAmount.Size = new System.Drawing.Size(147, 19);
            this.lblTotalAmount.TabIndex = 9;
            this.lblTotalAmount.Text = "0";
            this.lblTotalAmount.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // btnRemoveOrder
            // 
            this.btnRemoveOrder.Enabled = false;
            this.btnRemoveOrder.Location = new System.Drawing.Point(19, 338);
            this.btnRemoveOrder.Name = "btnRemoveOrder";
            this.btnRemoveOrder.Size = new System.Drawing.Size(109, 23);
            this.btnRemoveOrder.TabIndex = 4;
            this.btnRemoveOrder.Text = "Remove Order";
            this.btnRemoveOrder.UseVisualStyleBackColor = true;
            this.btnRemoveOrder.Click += new System.EventHandler(this.BtnRemoveOrder_Click);
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.lblItemDetails);
            this.groupBox4.Location = new System.Drawing.Point(167, 394);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(337, 131);
            this.groupBox4.TabIndex = 5;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Item Details";
            // 
            // lblUserGreeting
            // 
            this.lblUserGreeting.Location = new System.Drawing.Point(561, 36);
            this.lblUserGreeting.Name = "lblUserGreeting";
            this.lblUserGreeting.Size = new System.Drawing.Size(241, 19);
            this.lblUserGreeting.TabIndex = 6;
            // 
            // btnSignOff
            // 
            this.btnSignOff.Enabled = false;
            this.btnSignOff.Location = new System.Drawing.Point(828, 32);
            this.btnSignOff.Name = "btnSignOff";
            this.btnSignOff.Size = new System.Drawing.Size(75, 23);
            this.btnSignOff.TabIndex = 7;
            this.btnSignOff.Text = "Sign Off";
            this.btnSignOff.UseVisualStyleBackColor = true;
            this.btnSignOff.Visible = false;
            this.btnSignOff.Click += new System.EventHandler(this.BtnSignOff_Click);
            // 
            // frmShopping
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(933, 562);
            this.Controls.Add(this.btnSignOff);
            this.Controls.Add(this.lblUserGreeting);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.lvItems);
            this.Font = new System.Drawing.Font("Consolas", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "frmShopping";
            this.Text = "frmShopping";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmShopping_FormClosing);
            this.Load += new System.EventHandler(this.FrmShopping_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListView lvItems;
        private System.Windows.Forms.ColumnHeader columnItemId;
        private System.Windows.Forms.ColumnHeader columnItemName;
        private System.Windows.Forms.ColumnHeader columnItemType;
        private System.Windows.Forms.ColumnHeader columnItemDiscount;
        private System.Windows.Forms.ColumnHeader columnItemPrice;
        private System.Windows.Forms.ColumnHeader columnItemStocks;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.ComboBox cboSortByNamePrice;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnResetSort;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cboSortByType;
        private System.Windows.Forms.Button btnAddToCart;
        private System.Windows.Forms.Label lblQuantity;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnSubtract;
        private System.Windows.Forms.Label lblItemDetails;
        private System.Windows.Forms.ListView lvCart;
        private System.Windows.Forms.ColumnHeader columnCartItemId;
        private System.Windows.Forms.ColumnHeader columnCartItemName;
        private System.Windows.Forms.ColumnHeader columnCartItemQuantity;
        private System.Windows.Forms.ColumnHeader columnCartItemAmount;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button btnRemoveOrder;
        private System.Windows.Forms.Label lblTotalAmount;
        private System.Windows.Forms.Button btnCheckout;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Button btnSignOff;
        private System.Windows.Forms.Label lblUserGreeting;
    }
}