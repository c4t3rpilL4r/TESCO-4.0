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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmShopping));
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
            resources.ApplyResources(this.lvItems, "lvItems");
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
            this.lvItems.Name = "lvItems";
            this.lvItems.UseCompatibleStateImageBehavior = false;
            this.lvItems.View = System.Windows.Forms.View.Details;
            this.lvItems.SelectedIndexChanged += new System.EventHandler(this.LvItems_SelectedIndexChanged);
            this.lvItems.Leave += new System.EventHandler(this.LvItems_Leave);
            // 
            // columnItemId
            // 
            resources.ApplyResources(this.columnItemId, "columnItemId");
            // 
            // columnItemName
            // 
            resources.ApplyResources(this.columnItemName, "columnItemName");
            // 
            // columnItemType
            // 
            resources.ApplyResources(this.columnItemType, "columnItemType");
            // 
            // columnItemDiscount
            // 
            resources.ApplyResources(this.columnItemDiscount, "columnItemDiscount");
            // 
            // columnItemPrice
            // 
            resources.ApplyResources(this.columnItemPrice, "columnItemPrice");
            // 
            // columnItemStocks
            // 
            resources.ApplyResources(this.columnItemStocks, "columnItemStocks");
            // 
            // grpSorting
            // 
            resources.ApplyResources(this.grpSorting, "grpSorting");
            this.grpSorting.Controls.Add(this.btnResetSort);
            this.grpSorting.Controls.Add(this.lblSortByType);
            this.grpSorting.Controls.Add(this.cboSortByType);
            this.grpSorting.Controls.Add(this.cboSortByNamePrice);
            this.grpSorting.Controls.Add(this.lblSortByNamePrice);
            this.grpSorting.Name = "grpSorting";
            this.grpSorting.TabStop = false;
            // 
            // btnResetSort
            // 
            resources.ApplyResources(this.btnResetSort, "btnResetSort");
            this.btnResetSort.Name = "btnResetSort";
            this.btnResetSort.UseVisualStyleBackColor = true;
            this.btnResetSort.Click += new System.EventHandler(this.BtnResetSort_Click);
            // 
            // lblSortByType
            // 
            resources.ApplyResources(this.lblSortByType, "lblSortByType");
            this.lblSortByType.Name = "lblSortByType";
            // 
            // cboSortByType
            // 
            resources.ApplyResources(this.cboSortByType, "cboSortByType");
            this.cboSortByType.FormattingEnabled = true;
            this.cboSortByType.Name = "cboSortByType";
            this.cboSortByType.SelectedIndexChanged += new System.EventHandler(this.CboSortByType_SelectedIndexChanged);
            // 
            // cboSortByNamePrice
            // 
            resources.ApplyResources(this.cboSortByNamePrice, "cboSortByNamePrice");
            this.cboSortByNamePrice.FormattingEnabled = true;
            this.cboSortByNamePrice.Name = "cboSortByNamePrice";
            this.cboSortByNamePrice.SelectedIndexChanged += new System.EventHandler(this.CboSortByNamePrice_SelectedIndexChanged);
            // 
            // lblSortByNamePrice
            // 
            resources.ApplyResources(this.lblSortByNamePrice, "lblSortByNamePrice");
            this.lblSortByNamePrice.Name = "lblSortByNamePrice";
            // 
            // grpAddToCart
            // 
            resources.ApplyResources(this.grpAddToCart, "grpAddToCart");
            this.grpAddToCart.Controls.Add(this.btnAddToCart);
            this.grpAddToCart.Controls.Add(this.lblQuantity);
            this.grpAddToCart.Controls.Add(this.btnAdd);
            this.grpAddToCart.Controls.Add(this.btnSubtract);
            this.grpAddToCart.Name = "grpAddToCart";
            this.grpAddToCart.TabStop = false;
            // 
            // btnAddToCart
            // 
            resources.ApplyResources(this.btnAddToCart, "btnAddToCart");
            this.btnAddToCart.Name = "btnAddToCart";
            this.btnAddToCart.UseVisualStyleBackColor = true;
            this.btnAddToCart.Click += new System.EventHandler(this.BtnAddToCart_Click);
            // 
            // lblQuantity
            // 
            resources.ApplyResources(this.lblQuantity, "lblQuantity");
            this.lblQuantity.Name = "lblQuantity";
            this.lblQuantity.TextChanged += new System.EventHandler(this.LblQuantity_TextChanged);
            // 
            // btnAdd
            // 
            resources.ApplyResources(this.btnAdd, "btnAdd");
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.BtnAdd_Click);
            // 
            // btnSubtract
            // 
            resources.ApplyResources(this.btnSubtract, "btnSubtract");
            this.btnSubtract.Name = "btnSubtract";
            this.btnSubtract.UseVisualStyleBackColor = true;
            this.btnSubtract.Click += new System.EventHandler(this.BtnSubtract_Click);
            // 
            // lblItemDetails
            // 
            resources.ApplyResources(this.lblItemDetails, "lblItemDetails");
            this.lblItemDetails.Name = "lblItemDetails";
            // 
            // lvCart
            // 
            resources.ApplyResources(this.lvCart, "lvCart");
            this.lvCart.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnCartItemId,
            this.columnCartItemName,
            this.columnCartItemQuantity,
            this.columnCartItemAmount});
            this.lvCart.FullRowSelect = true;
            this.lvCart.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
            this.lvCart.HideSelection = false;
            this.lvCart.Name = "lvCart";
            this.lvCart.UseCompatibleStateImageBehavior = false;
            this.lvCart.View = System.Windows.Forms.View.Details;
            this.lvCart.SelectedIndexChanged += new System.EventHandler(this.LvCart_SelectedIndexChanged);
            // 
            // columnCartItemId
            // 
            resources.ApplyResources(this.columnCartItemId, "columnCartItemId");
            // 
            // columnCartItemName
            // 
            resources.ApplyResources(this.columnCartItemName, "columnCartItemName");
            // 
            // columnCartItemQuantity
            // 
            resources.ApplyResources(this.columnCartItemQuantity, "columnCartItemQuantity");
            // 
            // columnCartItemAmount
            // 
            resources.ApplyResources(this.columnCartItemAmount, "columnCartItemAmount");
            // 
            // grpCart
            // 
            resources.ApplyResources(this.grpCart, "grpCart");
            this.grpCart.Controls.Add(this.btnCheckout);
            this.grpCart.Controls.Add(this.lblTotalAmount);
            this.grpCart.Controls.Add(this.btnRemoveOrder);
            this.grpCart.Controls.Add(this.lvCart);
            this.grpCart.Name = "grpCart";
            this.grpCart.TabStop = false;
            // 
            // btnCheckout
            // 
            resources.ApplyResources(this.btnCheckout, "btnCheckout");
            this.btnCheckout.Name = "btnCheckout";
            this.btnCheckout.UseVisualStyleBackColor = true;
            this.btnCheckout.Click += new System.EventHandler(this.BtnCheckout_Click);
            // 
            // lblTotalAmount
            // 
            resources.ApplyResources(this.lblTotalAmount, "lblTotalAmount");
            this.lblTotalAmount.Name = "lblTotalAmount";
            // 
            // btnRemoveOrder
            // 
            resources.ApplyResources(this.btnRemoveOrder, "btnRemoveOrder");
            this.btnRemoveOrder.Name = "btnRemoveOrder";
            this.btnRemoveOrder.UseVisualStyleBackColor = true;
            this.btnRemoveOrder.Click += new System.EventHandler(this.BtnRemoveOrder_Click);
            // 
            // grpItemDetails
            // 
            resources.ApplyResources(this.grpItemDetails, "grpItemDetails");
            this.grpItemDetails.Controls.Add(this.lblItemDetails);
            this.grpItemDetails.Name = "grpItemDetails";
            this.grpItemDetails.TabStop = false;
            // 
            // lblUserGreeting
            // 
            resources.ApplyResources(this.lblUserGreeting, "lblUserGreeting");
            this.lblUserGreeting.Name = "lblUserGreeting";
            // 
            // btnSignOff
            // 
            resources.ApplyResources(this.btnSignOff, "btnSignOff");
            this.btnSignOff.Name = "btnSignOff";
            this.btnSignOff.UseVisualStyleBackColor = true;
            this.btnSignOff.Click += new System.EventHandler(this.BtnSignOff_Click);
            // 
            // frmShopping
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.btnSignOff);
            this.Controls.Add(this.lblUserGreeting);
            this.Controls.Add(this.grpItemDetails);
            this.Controls.Add(this.grpCart);
            this.Controls.Add(this.grpAddToCart);
            this.Controls.Add(this.grpSorting);
            this.Controls.Add(this.lvItems);
            this.Name = "frmShopping";
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