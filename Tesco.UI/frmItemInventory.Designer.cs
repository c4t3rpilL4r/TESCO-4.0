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
            this.lvItems = new System.Windows.Forms.ListView();
            this.columnItemId = new System.Windows.Forms.ColumnHeader();
            this.columnItemName = new System.Windows.Forms.ColumnHeader();
            this.columnItemType = new System.Windows.Forms.ColumnHeader();
            this.columnItemDiscount = new System.Windows.Forms.ColumnHeader();
            this.columnItemPrice = new System.Windows.Forms.ColumnHeader();
            this.columnItemStocks = new System.Windows.Forms.ColumnHeader();
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
            this.lvItems.Columns.AddRange(new System.Windows.Forms.ColumnHeader[]
            {
                this.columnItemId, this.columnItemName, this.columnItemType, this.columnItemDiscount,
                this.columnItemPrice, this.columnItemStocks
            });
            this.lvItems.FullRowSelect = true;
            this.lvItems.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
            this.lvItems.HideSelection = false;
            this.lvItems.Location = new System.Drawing.Point(12, 12);
            this.lvItems.Name = "lvItems";
            this.lvItems.Size = new System.Drawing.Size(555, 333);
            this.lvItems.TabIndex = 0;
            this.lvItems.UseCompatibleStateImageBehavior = false;
            this.lvItems.View = System.Windows.Forms.View.Details;
            this.lvItems.SelectedIndexChanged += new System.EventHandler(this.LvItems_SelectedIndexChanged);
            // 
            // columnItemId
            // 
            this.columnItemId.Text = "Id";
            this.columnItemId.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.columnItemId.Width = 50;
            // 
            // columnItemName
            // 
            this.columnItemName.Text = "Name";
            this.columnItemName.Width = 220;
            // 
            // columnItemType
            // 
            this.columnItemType.Text = "Type";
            this.columnItemType.Width = 100;
            // 
            // columnItemDiscount
            // 
            this.columnItemDiscount.Text = "Discount";
            this.columnItemDiscount.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.columnItemDiscount.Width = 70;
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
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnResetSort);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.cboSortByType);
            this.groupBox2.Controls.Add(this.cboSortByNamePrice);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Location = new System.Drawing.Point(621, 23);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(337, 113);
            this.groupBox2.TabIndex = 13;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Sorting";
            // 
            // btnResetSort
            // 
            this.btnResetSort.Location = new System.Drawing.Point(104, 74);
            this.btnResetSort.Name = "btnResetSort";
            this.btnResetSort.Size = new System.Drawing.Size(140, 22);
            this.btnResetSort.TabIndex = 3;
            this.btnResetSort.Text = "Reset Sort Order";
            this.btnResetSort.UseVisualStyleBackColor = true;
            this.btnResetSort.Click += new System.EventHandler(this.BtnResetSort_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(181, 24);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(63, 14);
            this.label6.TabIndex = 3;
            this.label6.Text = "By Type:";
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
            this.cboSortByNamePrice.SelectedIndexChanged +=
                new System.EventHandler(this.CboSortByNamePrice_SelectedIndexChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(10, 24);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(105, 14);
            this.label7.TabIndex = 0;
            this.label7.Text = "By Name/Price:";
            // 
            // btnEditItem
            // 
            this.btnEditItem.Enabled = false;
            this.btnEditItem.Location = new System.Drawing.Point(152, 24);
            this.btnEditItem.Name = "btnEditItem";
            this.btnEditItem.Size = new System.Drawing.Size(102, 23);
            this.btnEditItem.TabIndex = 5;
            this.btnEditItem.Text = "Edit Item";
            this.btnEditItem.UseVisualStyleBackColor = true;
            this.btnEditItem.Click += new System.EventHandler(this.BtnEditItem_Click);
            // 
            // btnAddItem
            // 
            this.btnAddItem.Location = new System.Drawing.Point(21, 24);
            this.btnAddItem.Name = "btnAddItem";
            this.btnAddItem.Size = new System.Drawing.Size(102, 23);
            this.btnAddItem.TabIndex = 4;
            this.btnAddItem.Text = "Add Item";
            this.btnAddItem.UseVisualStyleBackColor = true;
            this.btnAddItem.Click += new System.EventHandler(this.BtnAddItem_Click);
            // 
            // btnDeleteItem
            // 
            this.btnDeleteItem.Enabled = false;
            this.btnDeleteItem.Location = new System.Drawing.Point(279, 24);
            this.btnDeleteItem.Name = "btnDeleteItem";
            this.btnDeleteItem.Size = new System.Drawing.Size(102, 23);
            this.btnDeleteItem.TabIndex = 6;
            this.btnDeleteItem.Text = "Delete Item";
            this.btnDeleteItem.UseVisualStyleBackColor = true;
            this.btnDeleteItem.Click += new System.EventHandler(this.BtnDeleteItem_Click);
            // 
            // btnAddItemType
            // 
            this.btnAddItemType.Location = new System.Drawing.Point(58, 64);
            this.btnAddItemType.Name = "btnAddItemType";
            this.btnAddItemType.Size = new System.Drawing.Size(128, 23);
            this.btnAddItemType.TabIndex = 8;
            this.btnAddItemType.Text = "Add Item Type";
            this.btnAddItemType.UseVisualStyleBackColor = true;
            this.btnAddItemType.Click += new System.EventHandler(this.BtnAddItemType_Click);
            // 
            // btnDeleteItemType
            // 
            this.btnDeleteItemType.Enabled = false;
            this.btnDeleteItemType.Location = new System.Drawing.Point(216, 64);
            this.btnDeleteItemType.Name = "btnDeleteItemType";
            this.btnDeleteItemType.Size = new System.Drawing.Size(128, 23);
            this.btnDeleteItemType.TabIndex = 10;
            this.btnDeleteItemType.Text = "Delete Item Type";
            this.btnDeleteItemType.UseVisualStyleBackColor = true;
            this.btnDeleteItemType.Click += new System.EventHandler(this.BtnDeleteItemType_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnAddItem);
            this.groupBox1.Controls.Add(this.btnEditItem);
            this.groupBox1.Controls.Add(this.btnDeleteItem);
            this.groupBox1.Location = new System.Drawing.Point(586, 142);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(396, 66);
            this.groupBox1.TabIndex = 20;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Items";
            // 
            // grpItemTypes
            // 
            this.grpItemTypes.Controls.Add(this.txtType);
            this.grpItemTypes.Controls.Add(this.cboType);
            this.grpItemTypes.Controls.Add(this.btnDeleteItemType);
            this.grpItemTypes.Controls.Add(this.btnAddItemType);
            this.grpItemTypes.Location = new System.Drawing.Point(589, 223);
            this.grpItemTypes.Name = "grpItemTypes";
            this.grpItemTypes.Size = new System.Drawing.Size(392, 121);
            this.grpItemTypes.TabIndex = 21;
            this.grpItemTypes.TabStop = false;
            this.grpItemTypes.Text = "Item Types";
            // 
            // txtType
            // 
            this.txtType.Location = new System.Drawing.Point(45, 31);
            this.txtType.Name = "txtType";
            this.txtType.Size = new System.Drawing.Size(141, 22);
            this.txtType.TabIndex = 7;
            this.txtType.Leave += new System.EventHandler(this.TxtType_Leave);
            // 
            // cboType
            // 
            this.cboType.FormattingEnabled = true;
            this.cboType.Location = new System.Drawing.Point(216, 31);
            this.cboType.Name = "cboType";
            this.cboType.Size = new System.Drawing.Size(140, 22);
            this.cboType.TabIndex = 9;
            this.cboType.SelectedIndexChanged += new System.EventHandler(this.CboType_SelectedIndexChanged);
            // 
            // frmItemInventory
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1004, 356);
            this.Controls.Add(this.grpItemTypes);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.lvItems);
            this.Font = new System.Drawing.Font("Consolas", 9F, System.Drawing.FontStyle.Regular,
                System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.Name = "frmItemInventory";
            this.Text = "TESCO Item Inventory Page";
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