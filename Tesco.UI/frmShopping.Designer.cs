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
            this.grpSorting = new System.Windows.Forms.GroupBox();
            this.btnResetSort = new System.Windows.Forms.Button();
            this.lblSortByType = new System.Windows.Forms.Label();
            this.cboSortByType = new System.Windows.Forms.ComboBox();
            this.cboSortByNamePrice = new System.Windows.Forms.ComboBox();
            this.lblSortByNamePrice = new System.Windows.Forms.Label();
            this.grpAddToCart = new System.Windows.Forms.GroupBox();
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
            this.grpCart = new System.Windows.Forms.GroupBox();
            this.btnCheckout = new System.Windows.Forms.Button();
            this.lblTotalAmount = new System.Windows.Forms.Label();
            this.btnRemoveOrder = new System.Windows.Forms.Button();
            this.grpItemDetails = new System.Windows.Forms.GroupBox();
            this.lblUserGreeting = new System.Windows.Forms.Label();
            this.btnSignOff = new System.Windows.Forms.Button();
            this.grpSorting.SuspendLayout();
            this.grpAddToCart.SuspendLayout();
            this.grpCart.SuspendLayout();
            this.grpItemDetails.SuspendLayout();
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
            // grpSorting
            // 
            this.grpSorting.Controls.Add(this.btnResetSort);
            this.grpSorting.Controls.Add(this.lblSortByType);
            this.grpSorting.Controls.Add(this.cboSortByType);
            this.grpSorting.Controls.Add(this.cboSortByNamePrice);
            this.grpSorting.Controls.Add(this.lblSortByNamePrice);
            this.grpSorting.Location = new System.Drawing.Point(12, 12);
            this.grpSorting.Name = "grpSorting";
            this.grpSorting.Size = new System.Drawing.Size(507, 83);
            this.grpSorting.TabIndex = 1;
            this.grpSorting.TabStop = false;
            this.grpSorting.Text = "Sorting Details";
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
            // lblSortByType
            // 
            this.lblSortByType.AutoSize = true;
            this.lblSortByType.Location = new System.Drawing.Point(181, 24);
            this.lblSortByType.Name = "lblSortByType";
            this.lblSortByType.Size = new System.Drawing.Size(98, 14);
            this.lblSortByType.TabIndex = 3;
            this.lblSortByType.Text = "Sort By Type:";
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
            // lblSortByNamePrice
            // 
            this.lblSortByNamePrice.AutoSize = true;
            this.lblSortByNamePrice.Location = new System.Drawing.Point(10, 24);
            this.lblSortByNamePrice.Name = "lblSortByNamePrice";
            this.lblSortByNamePrice.Size = new System.Drawing.Size(140, 14);
            this.lblSortByNamePrice.TabIndex = 0;
            this.lblSortByNamePrice.Text = "Sort By Name/Price:";
            // 
            // grpAddToCart
            // 
            this.grpAddToCart.Controls.Add(this.btnAddToCart);
            this.grpAddToCart.Controls.Add(this.lblQuantity);
            this.grpAddToCart.Controls.Add(this.btnAdd);
            this.grpAddToCart.Controls.Add(this.btnSubtract);
            this.grpAddToCart.Location = new System.Drawing.Point(27, 394);
            this.grpAddToCart.Name = "grpAddToCart";
            this.grpAddToCart.Size = new System.Drawing.Size(134, 131);
            this.grpAddToCart.TabIndex = 2;
            this.grpAddToCart.TabStop = false;
            this.grpAddToCart.Text = "Add To Cart";
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
            this.lblItemDetails.Size = new System.Drawing.Size(70, 70);
            this.lblItemDetails.TabIndex = 8;
            this.lblItemDetails.Text = "Name:\r\nType:\r\nPrice:\r\nQuantity:\r\nTotal:";
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
            // grpCart
            // 
            this.grpCart.Controls.Add(this.btnCheckout);
            this.grpCart.Controls.Add(this.lblTotalAmount);
            this.grpCart.Controls.Add(this.btnRemoveOrder);
            this.grpCart.Controls.Add(this.lvCart);
            this.grpCart.Location = new System.Drawing.Point(545, 91);
            this.grpCart.Name = "grpCart";
            this.grpCart.Size = new System.Drawing.Size(376, 406);
            this.grpCart.TabIndex = 4;
            this.grpCart.TabStop = false;
            this.grpCart.Text = "Cart Details";
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
            // grpItemDetails
            // 
            this.grpItemDetails.Controls.Add(this.lblItemDetails);
            this.grpItemDetails.Location = new System.Drawing.Point(167, 394);
            this.grpItemDetails.Name = "grpItemDetails";
            this.grpItemDetails.Size = new System.Drawing.Size(337, 131);
            this.grpItemDetails.TabIndex = 5;
            this.grpItemDetails.TabStop = false;
            this.grpItemDetails.Text = "Item Details";
            // 
            // lblUserGreeting
            // 
            this.lblUserGreeting.Location = new System.Drawing.Point(561, 36);
            this.lblUserGreeting.Name = "lblUserGreeting";
            this.lblUserGreeting.Size = new System.Drawing.Size(241, 19);
            this.lblUserGreeting.TabIndex = 6;
            this.lblUserGreeting.Text = "Hello,";
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
            this.ClientSize = new System.Drawing.Size(933, 563);
            this.Controls.Add(this.btnSignOff);
            this.Controls.Add(this.lblUserGreeting);
            this.Controls.Add(this.grpItemDetails);
            this.Controls.Add(this.grpCart);
            this.Controls.Add(this.grpAddToCart);
            this.Controls.Add(this.grpSorting);
            this.Controls.Add(this.lvItems);
            this.Font = new System.Drawing.Font("Consolas", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "frmShopping";
            this.Text = "TESCO Shopping";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmShopping_FormClosing);
            this.Load += new System.EventHandler(this.FrmShopping_Load);
            this.grpSorting.ResumeLayout(false);
            this.grpSorting.PerformLayout();
            this.grpAddToCart.ResumeLayout(false);
            this.grpAddToCart.PerformLayout();
            this.grpCart.ResumeLayout(false);
            this.grpItemDetails.ResumeLayout(false);
            this.grpItemDetails.PerformLayout();
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
        private System.Windows.Forms.GroupBox grpSorting;
        private System.Windows.Forms.GroupBox grpAddToCart;
        private System.Windows.Forms.ComboBox cboSortByNamePrice;
        private System.Windows.Forms.Label lblSortByNamePrice;
        private System.Windows.Forms.Button btnResetSort;
        private System.Windows.Forms.Label lblSortByType;
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
        private System.Windows.Forms.GroupBox grpCart;
        private System.Windows.Forms.Button btnRemoveOrder;
        private System.Windows.Forms.Label lblTotalAmount;
        private System.Windows.Forms.Button btnCheckout;
        private System.Windows.Forms.GroupBox grpItemDetails;
        private System.Windows.Forms.Button btnSignOff;
        private System.Windows.Forms.Label lblUserGreeting;
    }
}