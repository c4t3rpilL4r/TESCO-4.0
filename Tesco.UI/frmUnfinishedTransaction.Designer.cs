using System.ComponentModel;

namespace Tesco.UI
{
    partial class frmUnfinishedTransaction
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private IContainer components = null;

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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lvCurrentOrder = new System.Windows.Forms.ListView();
            this.columnCurrentOrderId = new System.Windows.Forms.ColumnHeader();
            this.columnCurrentOrderName = new System.Windows.Forms.ColumnHeader();
            this.columnCurrentOrderQuantity = new System.Windows.Forms.ColumnHeader();
            this.columnCurrentOrderAmount = new System.Windows.Forms.ColumnHeader();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.lvUnfinishedOrder = new System.Windows.Forms.ListView();
            this.columnUnfinishedOrderId = new System.Windows.Forms.ColumnHeader();
            this.columnUnfinishedOrderName = new System.Windows.Forms.ColumnHeader();
            this.columnUnfinishedOrderQuantity = new System.Windows.Forms.ColumnHeader();
            this.columnUnfinishedOrderAmount = new System.Windows.Forms.ColumnHeader();
            this.btnMoveToUnfinishedTransaction = new System.Windows.Forms.Button();
            this.btnMoveToCurrentOrder = new System.Windows.Forms.Button();
            this.btnCheckout = new System.Windows.Forms.Button();
            this.btnShopping = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lvCurrentOrder);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(376, 286);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Current Order";
            // 
            // lvCurrentOrder
            // 
            this.lvCurrentOrder.Columns.AddRange(new System.Windows.Forms.ColumnHeader[]
            {
                this.columnCurrentOrderId, this.columnCurrentOrderName, this.columnCurrentOrderQuantity,
                this.columnCurrentOrderAmount
            });
            this.lvCurrentOrder.FullRowSelect = true;
            this.lvCurrentOrder.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
            this.lvCurrentOrder.HideSelection = false;
            this.lvCurrentOrder.Location = new System.Drawing.Point(6, 20);
            this.lvCurrentOrder.Name = "lvCurrentOrder";
            this.lvCurrentOrder.Size = new System.Drawing.Size(364, 260);
            this.lvCurrentOrder.TabIndex = 9;
            this.lvCurrentOrder.UseCompatibleStateImageBehavior = false;
            this.lvCurrentOrder.View = System.Windows.Forms.View.Details;
            this.lvCurrentOrder.SelectedIndexChanged +=
                new System.EventHandler(this.lvCurrentOrder_SelectedIndexChanged);
            this.lvCurrentOrder.Leave += new System.EventHandler(this.LvCurrentOrder_Leave);
            // 
            // columnCurrentOrderId
            // 
            this.columnCurrentOrderId.Text = "";
            this.columnCurrentOrderId.Width = 0;
            // 
            // columnCurrentOrderName
            // 
            this.columnCurrentOrderName.Text = "Name";
            this.columnCurrentOrderName.Width = 210;
            // 
            // columnCurrentOrderQuantity
            // 
            this.columnCurrentOrderQuantity.Text = "Quantity";
            this.columnCurrentOrderQuantity.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.columnCurrentOrderQuantity.Width = 75;
            // 
            // columnCurrentOrderAmount
            // 
            this.columnCurrentOrderAmount.Text = "Amount";
            this.columnCurrentOrderAmount.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.columnCurrentOrderAmount.Width = 75;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.lvUnfinishedOrder);
            this.groupBox2.Location = new System.Drawing.Point(410, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(376, 286);
            this.groupBox2.TabIndex = 6;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Unfinished Order";
            // 
            // lvUnfinishedOrder
            // 
            this.lvUnfinishedOrder.Columns.AddRange(new System.Windows.Forms.ColumnHeader[]
            {
                this.columnUnfinishedOrderId, this.columnUnfinishedOrderName, this.columnUnfinishedOrderQuantity,
                this.columnUnfinishedOrderAmount
            });
            this.lvUnfinishedOrder.FullRowSelect = true;
            this.lvUnfinishedOrder.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
            this.lvUnfinishedOrder.HideSelection = false;
            this.lvUnfinishedOrder.Location = new System.Drawing.Point(6, 20);
            this.lvUnfinishedOrder.Name = "lvUnfinishedOrder";
            this.lvUnfinishedOrder.Size = new System.Drawing.Size(364, 260);
            this.lvUnfinishedOrder.TabIndex = 10;
            this.lvUnfinishedOrder.UseCompatibleStateImageBehavior = false;
            this.lvUnfinishedOrder.View = System.Windows.Forms.View.Details;
            this.lvUnfinishedOrder.SelectedIndexChanged +=
                new System.EventHandler(this.lvUnfinishedOrder_SelectedIndexChanged);
            this.lvUnfinishedOrder.Leave += new System.EventHandler(this.LvUnfinishedOrder_Leave);
            // 
            // columnUnfinishedOrderId
            // 
            this.columnUnfinishedOrderId.Text = "";
            this.columnUnfinishedOrderId.Width = 0;
            // 
            // columnUnfinishedOrderName
            // 
            this.columnUnfinishedOrderName.Text = "Name";
            this.columnUnfinishedOrderName.Width = 210;
            // 
            // columnUnfinishedOrderQuantity
            // 
            this.columnUnfinishedOrderQuantity.Text = "Quantity";
            this.columnUnfinishedOrderQuantity.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.columnUnfinishedOrderQuantity.Width = 75;
            // 
            // columnUnfinishedOrderAmount
            // 
            this.columnUnfinishedOrderAmount.Text = "Amount";
            this.columnUnfinishedOrderAmount.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.columnUnfinishedOrderAmount.Width = 75;
            // 
            // btnMoveToUnfinishedTransaction
            // 
            this.btnMoveToUnfinishedTransaction.Enabled = false;
            this.btnMoveToUnfinishedTransaction.Location = new System.Drawing.Point(62, 313);
            this.btnMoveToUnfinishedTransaction.Name = "btnMoveToUnfinishedTransaction";
            this.btnMoveToUnfinishedTransaction.Size = new System.Drawing.Size(276, 23);
            this.btnMoveToUnfinishedTransaction.TabIndex = 0;
            this.btnMoveToUnfinishedTransaction.Text = "Move to Unfinished Transaction ->";
            this.btnMoveToUnfinishedTransaction.UseVisualStyleBackColor = true;
            this.btnMoveToUnfinishedTransaction.Click +=
                new System.EventHandler(this.btnMoveToUnfinishedTransaction_Click);
            // 
            // btnMoveToCurrentOrder
            // 
            this.btnMoveToCurrentOrder.Enabled = false;
            this.btnMoveToCurrentOrder.Location = new System.Drawing.Point(504, 313);
            this.btnMoveToCurrentOrder.Name = "btnMoveToCurrentOrder";
            this.btnMoveToCurrentOrder.Size = new System.Drawing.Size(205, 23);
            this.btnMoveToCurrentOrder.TabIndex = 1;
            this.btnMoveToCurrentOrder.Text = "<- Move to Current Order";
            this.btnMoveToCurrentOrder.UseVisualStyleBackColor = true;
            this.btnMoveToCurrentOrder.Click += new System.EventHandler(this.BtnMoveToCurrentOrder_Click);
            // 
            // btnCheckout
            // 
            this.btnCheckout.Enabled = false;
            this.btnCheckout.Location = new System.Drawing.Point(185, 357);
            this.btnCheckout.Name = "btnCheckout";
            this.btnCheckout.Size = new System.Drawing.Size(205, 23);
            this.btnCheckout.TabIndex = 2;
            this.btnCheckout.Text = "Continue to Checkout";
            this.btnCheckout.UseVisualStyleBackColor = true;
            this.btnCheckout.Click += new System.EventHandler(this.btnCheckout_Click);
            // 
            // btnShopping
            // 
            this.btnShopping.Location = new System.Drawing.Point(419, 357);
            this.btnShopping.Name = "btnShopping";
            this.btnShopping.Size = new System.Drawing.Size(205, 23);
            this.btnShopping.TabIndex = 3;
            this.btnShopping.Text = "Continue to Shopping";
            this.btnShopping.UseVisualStyleBackColor = true;
            this.btnShopping.Click += new System.EventHandler(this.btnShopping_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.label1);
            this.groupBox3.Location = new System.Drawing.Point(12, 399);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(774, 54);
            this.groupBox3.TabIndex = 7;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Note:";
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(6, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(762, 28);
            this.label1.TabIndex = 0;
            this.label1.Text = "If you want to continue shopping along with your items, move your items from the " +
                               "Unfinished Order to the Current Order. Then click the Continue to Shopping butto" +
                               "n.";
            // 
            // frmUnfinishedTransaction
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(798, 462);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.btnShopping);
            this.Controls.Add(this.btnCheckout);
            this.Controls.Add(this.btnMoveToCurrentOrder);
            this.Controls.Add(this.btnMoveToUnfinishedTransaction);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("Consolas", 9F, System.Drawing.FontStyle.Regular,
                System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.Name = "frmUnfinishedTransaction";
            this.Text = "TESCO Unfinished Transaction";
            this.FormClosing +=
                new System.Windows.Forms.FormClosingEventHandler(this.FrmUnfinishedTransaction_FormClosing);
            this.Load += new System.EventHandler(this.frmUnfinishedTransaction_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.ResumeLayout(false);
        }

        #endregion
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnMoveToCurrentOrder;
        private System.Windows.Forms.Button btnMoveToUnfinishedTransaction;
        private System.Windows.Forms.Button btnShopping;
        private System.Windows.Forms.Button btnCheckout;
        private System.Windows.Forms.ListView lvCurrentOrder;
        private System.Windows.Forms.ColumnHeader columnCurrentOrderId;
        private System.Windows.Forms.ColumnHeader columnCurrentOrderName;
        private System.Windows.Forms.ColumnHeader columnCurrentOrderQuantity;
        private System.Windows.Forms.ColumnHeader columnCurrentOrderAmount;
        private System.Windows.Forms.ListView lvUnfinishedOrder;
        private System.Windows.Forms.ColumnHeader columnUnfinishedOrderId;
        private System.Windows.Forms.ColumnHeader columnUnfinishedOrderName;
        private System.Windows.Forms.ColumnHeader columnUnfinishedOrderQuantity;
        private System.Windows.Forms.ColumnHeader columnUnfinishedOrderAmount;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label label1;
    }
}