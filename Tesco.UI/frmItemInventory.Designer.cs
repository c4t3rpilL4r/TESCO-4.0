namespace Tesco.UI
{
    partial class frmItemInventory
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmItemInventory));
            this.lvItems = new System.Windows.Forms.ListView();
            this.columnItemId = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnItemName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnItemType = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnItemDiscount = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnItemPrice = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnItemStocks = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnResetSort = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.cboSortByType = new System.Windows.Forms.ComboBox();
            this.cboSortByNamePrice = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.btnEditItem = new System.Windows.Forms.Button();
            this.btnAddItem = new System.Windows.Forms.Button();
            this.btnDeleteItem = new System.Windows.Forms.Button();
            this.btnAddItemType = new System.Windows.Forms.Button();
            this.btnDeleteItemType = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.grpItemTypes = new System.Windows.Forms.GroupBox();
            this.txtType = new System.Windows.Forms.TextBox();
            this.cboType = new System.Windows.Forms.ComboBox();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.grpItemTypes.SuspendLayout();
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
            // groupBox2
            // 
            resources.ApplyResources(this.groupBox2, "groupBox2");
            this.groupBox2.Controls.Add(this.btnResetSort);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.cboSortByType);
            this.groupBox2.Controls.Add(this.cboSortByNamePrice);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.TabStop = false;
            // 
            // btnResetSort
            // 
            resources.ApplyResources(this.btnResetSort, "btnResetSort");
            this.btnResetSort.Name = "btnResetSort";
            this.btnResetSort.UseVisualStyleBackColor = true;
            this.btnResetSort.Click += new System.EventHandler(this.BtnResetSort_Click);
            // 
            // label6
            // 
            resources.ApplyResources(this.label6, "label6");
            this.label6.Name = "label6";
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
            // label7
            // 
            resources.ApplyResources(this.label7, "label7");
            this.label7.Name = "label7";
            // 
            // btnEditItem
            // 
            resources.ApplyResources(this.btnEditItem, "btnEditItem");
            this.btnEditItem.Name = "btnEditItem";
            this.btnEditItem.UseVisualStyleBackColor = true;
            this.btnEditItem.Click += new System.EventHandler(this.BtnEditItem_Click);
            // 
            // btnAddItem
            // 
            resources.ApplyResources(this.btnAddItem, "btnAddItem");
            this.btnAddItem.Name = "btnAddItem";
            this.btnAddItem.UseVisualStyleBackColor = true;
            this.btnAddItem.Click += new System.EventHandler(this.BtnAddItem_Click);
            // 
            // btnDeleteItem
            // 
            resources.ApplyResources(this.btnDeleteItem, "btnDeleteItem");
            this.btnDeleteItem.Name = "btnDeleteItem";
            this.btnDeleteItem.UseVisualStyleBackColor = true;
            this.btnDeleteItem.Click += new System.EventHandler(this.BtnDeleteItem_Click);
            // 
            // btnAddItemType
            // 
            resources.ApplyResources(this.btnAddItemType, "btnAddItemType");
            this.btnAddItemType.Name = "btnAddItemType";
            this.btnAddItemType.UseVisualStyleBackColor = true;
            this.btnAddItemType.Click += new System.EventHandler(this.BtnAddItemType_Click);
            // 
            // btnDeleteItemType
            // 
            resources.ApplyResources(this.btnDeleteItemType, "btnDeleteItemType");
            this.btnDeleteItemType.Name = "btnDeleteItemType";
            this.btnDeleteItemType.UseVisualStyleBackColor = true;
            this.btnDeleteItemType.Click += new System.EventHandler(this.BtnDeleteItemType_Click);
            // 
            // groupBox1
            // 
            resources.ApplyResources(this.groupBox1, "groupBox1");
            this.groupBox1.Controls.Add(this.btnAddItem);
            this.groupBox1.Controls.Add(this.btnEditItem);
            this.groupBox1.Controls.Add(this.btnDeleteItem);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.TabStop = false;
            // 
            // grpItemTypes
            // 
            resources.ApplyResources(this.grpItemTypes, "grpItemTypes");
            this.grpItemTypes.Controls.Add(this.txtType);
            this.grpItemTypes.Controls.Add(this.cboType);
            this.grpItemTypes.Controls.Add(this.btnDeleteItemType);
            this.grpItemTypes.Controls.Add(this.btnAddItemType);
            this.grpItemTypes.Name = "grpItemTypes";
            this.grpItemTypes.TabStop = false;
            // 
            // txtType
            // 
            resources.ApplyResources(this.txtType, "txtType");
            this.txtType.Name = "txtType";
            this.txtType.Leave += new System.EventHandler(this.TxtType_Leave);
            // 
            // cboType
            // 
            resources.ApplyResources(this.cboType, "cboType");
            this.cboType.FormattingEnabled = true;
            this.cboType.Name = "cboType";
            this.cboType.SelectedIndexChanged += new System.EventHandler(this.CboType_SelectedIndexChanged);
            // 
            // frmItemInventory
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.grpItemTypes);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.lvItems);
            this.Name = "frmItemInventory";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmItemInventory_FormClosing);
            this.Load += new System.EventHandler(this.FrmItemInventory_Load);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.grpItemTypes.ResumeLayout(false);
            this.grpItemTypes.PerformLayout();
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
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnResetSort;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox cboSortByType;
        private System.Windows.Forms.ComboBox cboSortByNamePrice;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button btnEditItem;
        private System.Windows.Forms.Button btnAddItem;
        private System.Windows.Forms.Button btnDeleteItem;
        private System.Windows.Forms.Button btnAddItemType;
        private System.Windows.Forms.Button btnDeleteItemType;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox grpItemTypes;
        private System.Windows.Forms.TextBox txtType;
        private System.Windows.Forms.ComboBox cboType;
    }
}