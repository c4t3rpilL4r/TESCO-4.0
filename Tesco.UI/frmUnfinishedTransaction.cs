using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using Tesco.BL.Interfaces;
using Tesco.BL.Managers;
using Tesco.DL.Models;
using Tesco.UI.Helpers;
using Tesco.UI.Interfaces;

namespace Tesco.UI
{
    public partial class frmUnfinishedTransaction : Form
    {
        private readonly IItemManager _itemManager;
        private readonly IOrderManager _orderManager;
        private readonly IOrderItemStateHelper _orderItemStateHelper;
        private readonly User _user;
        private int _lastSelectedItemInCurrentListView = 0;
        private int _lastSelectedItemInUnfinishedListView = 0;

        public frmUnfinishedTransaction(User user)
        {
            _itemManager = new ItemManager();
            _orderManager = new OrderManager();
            _orderItemStateHelper = new OrderItemStateHelper();
            _user = user;
            InitializeComponent();
        }

        private void frmUnfinishedTransaction_Load(object sender, EventArgs e) => PopulateListViewsWithData();

        private void LvCurrentOrder_Leave(object sender, EventArgs e)
        {
            GetSelectedIndexOfCurrentOrderListView();
            KeepLastSelectedItemFocusInCurrentOrderListView();
        }

        private void LvUnfinishedOrder_Leave(object sender, EventArgs e)
        {
            GetSelectedIndexOfUnfinishedOrderListView();
            KeepLastSelectedItemFocusInUnfinishedOrderListView();
        }

        private void lvCurrentOrder_SelectedIndexChanged(object sender, EventArgs e)
        {
            btnCheckout.Enabled = lvCurrentOrder.Items.Count > 0;
            btnMoveToUnfinishedTransaction.Enabled = lvCurrentOrder.Items.Count > 0;
        }

        private void lvUnfinishedOrder_SelectedIndexChanged(object sender, EventArgs e) => btnMoveToCurrentOrder.Enabled = lvUnfinishedOrder.Items.Count > 0;

        private void btnMoveToUnfinishedTransaction_Click(object sender, EventArgs e)
        {
            if (lvCurrentOrder.SelectedItems.Count <= 0) return;
            
            var itemId = int.Parse(lvCurrentOrder.SelectedItems[0].SubItems[0].Text);
            var quantity = int.Parse(lvCurrentOrder.SelectedItems[0].SubItems[2].Text);
            var amount = int.Parse(lvCurrentOrder.SelectedItems[0].SubItems[3].Text);
            var price = int.Parse(lvCurrentOrder.SelectedItems[0].SubItems[3].Text) / quantity;

            if (int.Parse(lvCurrentOrder.SelectedItems[0].SubItems[2].Text) > 1)
            {
                lvCurrentOrder.SelectedItems[0].SubItems[2].Text = (quantity - 1).ToString();
                lvCurrentOrder.SelectedItems[0].SubItems[3].Text = (amount - price).ToString();

                if (lvUnfinishedOrder.Items.Cast<ListViewItem>()
                    .Any(x => int.Parse(x.SubItems[0].Text) == itemId))
                {
                    lvUnfinishedOrder.Items.Cast<ListViewItem>()
                        .ToList()
                        .ForEach(x =>
                        {
                            if (int.Parse(x.SubItems[0].Text) != itemId) return;

                            x.SubItems[2].Text = (int.Parse(x.SubItems[2].Text) + 1).ToString();
                            x.SubItems[3].Text = (int.Parse(x.SubItems[3].Text) + price).ToString();
                        });
                }
                else
                {
                    lvUnfinishedOrder.Items.Add(ConvertToListViewItem(new Order()
                    {
                        ItemId = itemId,
                        Quantity = 1,
                        Amount = price
                    }));
                }

                KeepLastSelectedItemFocusInCurrentOrderListView();

                if (quantity == 0)
                {
                    var currentOrder = _orderManager.RetrieveDataByWhereCondition(new Order()
                    {
                        CustomerId = _user.CustomerId,
                        ItemId = itemId,
                        IsCurrentOrder = true,
                        IsUnpaid = true,
                        IsCancelled = false
                    });

                    currentOrder.IsCurrentOrder = false;

                    _orderManager.Update(currentOrder);
                    
                    lvCurrentOrder.SelectedItems[0].Remove();
                }
            }

            btnMoveToCurrentOrder.Enabled = lvCurrentOrder.Items.Count > 0;
            btnMoveToUnfinishedTransaction.Enabled = lvUnfinishedOrder.Items.Count > 0;
        }

        private void BtnMoveToCurrentOrder_Click(object sender, EventArgs e)
        {
            if (lvUnfinishedOrder.SelectedItems.Count <= 0) return;

            var itemId = int.Parse(lvUnfinishedOrder.SelectedItems[0].SubItems[0].Text);
            var quantity = int.Parse(lvUnfinishedOrder.SelectedItems[0].SubItems[2].Text);
            var amount = int.Parse(lvUnfinishedOrder.SelectedItems[0].SubItems[3].Text);
            var price = int.Parse(lvUnfinishedOrder.SelectedItems[0].SubItems[3].Text) / quantity;

            if (quantity > 0)
            {
                lvUnfinishedOrder.SelectedItems[0].SubItems[2].Text = (quantity - 1).ToString();
                lvUnfinishedOrder.SelectedItems[0].SubItems[3].Text = (amount - price).ToString();

                if (lvCurrentOrder.Items.Cast<ListViewItem>()
                    .ToList()
                    .Any(x => int.Parse(x.SubItems[0].Text) == itemId))
                {
                    lvCurrentOrder.Items.Cast<ListViewItem>()
                        .ToList()
                        .ForEach(x =>
                        {
                            if (int.Parse(x.SubItems[0].Text) != itemId) return;

                            x.SubItems[2].Text = (int.Parse(x.SubItems[2].Text) + 1).ToString();
                            x.SubItems[3].Text = (int.Parse(x.SubItems[3].Text) + price).ToString();
                        });
                }
                else
                {
                    lvCurrentOrder.Items.Add(ConvertToListViewItem(new Order()
                    {
                        ItemId = itemId,
                        Quantity = 1,
                        Amount = price
                    }));
                }

                KeepLastSelectedItemFocusInUnfinishedOrderListView();

                if (int.Parse(lvUnfinishedOrder.SelectedItems[0].SubItems[2].Text) == 0)
                {
                    var unfinishedOrder = _orderManager.RetrieveDataByWhereCondition(new Order()
                    {
                        CustomerId = _user.CustomerId,
                        ItemId = itemId,
                        IsCurrentOrder = false,
                        IsUnpaid = true,
                        IsCancelled = false
                    });

                    unfinishedOrder.IsCurrentOrder = true;

                    _orderManager.Update(unfinishedOrder);

                    lvUnfinishedOrder.SelectedItems[0].Remove();
                }
            }

            btnMoveToCurrentOrder.Enabled = lvUnfinishedOrder.Items.Count > 0;
            btnMoveToUnfinishedTransaction.Enabled = lvCurrentOrder.Items.Count > 0;
            btnCheckout.Enabled = lvCurrentOrder.Items.Count > 0;
        }

        private void btnCheckout_Click(object sender, EventArgs e)
        {
            lvCurrentOrder.Items.Cast<ListViewItem>()
                .ToList()
                .ForEach(x =>
                {
                    _orderManager.Add(new Order()
                    {
                        CustomerId = _user.CustomerId,
                        ItemId = int.Parse(x.SubItems[0].Text),
                        Quantity = int.Parse(x.SubItems[2].Text),
                        Amount = int.Parse(x.SubItems[3].Text),
                        IsCurrentOrder = true,
                        IsUnpaid = true,
                        IsCancelled = false
                    });
                });

            var checkout = new frmCheckout(_user);
            this.Hide();
            checkout.Show();
        }

        private void btnShopping_Click(object sender, EventArgs e)
        {
            lvCurrentOrder.Items.Cast<ListViewItem>()
                .ToList()
                .ForEach(x =>
                {
                    _orderManager.Add(new Order()
                    {
                        CustomerId = _user.CustomerId,
                        ItemId = int.Parse(x.SubItems[0].Text),
                        Quantity = int.Parse(x.SubItems[2].Text),
                        Amount = int.Parse(x.SubItems[3].Text),
                        IsCurrentOrder = true,
                        IsUnpaid = true,
                        IsCancelled = false
                    });
                });

            var shopping = new frmShopping(_user);
            this.Hide();
            shopping.Show();
        }

        private void FrmUnfinishedTransaction_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (MessageBox.Show("Are you sure you want to close the window?",
                    "Close Window?",
                    MessageBoxButtons.OKCancel,
                    MessageBoxIcon.Question) == DialogResult.OK)
            {
                if (lvCurrentOrder.Items.Count <= 0) return;

                lvCurrentOrder.Items.Cast<ListViewItem>()
                    .ToList()
                    .ForEach(x =>
                    {
                        _orderItemStateHelper.ChangeOrderItemStatusToUnfinished(new Order()
                        {
                            CustomerId = _user.CustomerId,
                            ItemId = int.Parse(x.SubItems[0].Text)
                        });
                    });

                var welcome = new frmWelcome();
                welcome.Show();
            }
            else
            {
                e.Cancel = true;
            }
        }


        // <--------------------------------------------------     METHODS     -------------------------------------------------->


        private void PopulateListViewsWithData()
        {
            lvCurrentOrder.Items.Clear();
            lvUnfinishedOrder.Items.Clear();

            Enumerable.Where(_orderManager.RetrieveAll<Order>(),
                    x => x.CustomerId == _user.CustomerId
                         && x.IsUnpaid == true
                         && x.IsCancelled == false)
                .ToList()
                .ForEach(x =>
                {
                    if (x.IsCurrentOrder == true)
                    {
                        lvCurrentOrder.Items.Add(ConvertToListViewItem(x));
                    }
                    else
                    {
                        if (x.Quantity == 0) return;

                        lvUnfinishedOrder.Items.Add(ConvertToListViewItem(x));
                    }
                });
        }

        private ListViewItem ConvertToListViewItem(Order order)
        {
            var row = new ListViewItem(_itemManager.RetrieveDataById<Item>((int) order.ItemId).Id.ToString());
            row.SubItems.Add(_itemManager.RetrieveDataById<Item>((int) order.ItemId).Name);
            row.SubItems.Add(order.Quantity.ToString());
            row.SubItems.Add(order.Amount.ToString());

            return row;
        }

        private void GetSelectedIndexOfCurrentOrderListView()
        {
            if (lvCurrentOrder.SelectedItems.Count > 0)
            {
                _lastSelectedItemInCurrentListView = int.Parse(lvCurrentOrder.SelectedItems[0].Text);
            }
        }

        private void GetSelectedIndexOfUnfinishedOrderListView()
        {
            if (lvUnfinishedOrder.SelectedItems.Count > 0)
            {
                _lastSelectedItemInUnfinishedListView = int.Parse(lvUnfinishedOrder.SelectedItems[0].Text);
            }
        }

        private void KeepLastSelectedItemFocusInCurrentOrderListView()
        {
            var selectedItem = lvCurrentOrder.Items.Cast<ListViewItem>()
                .FirstOrDefault(x => int.Parse(x.SubItems[0].Text) == _lastSelectedItemInCurrentListView);

            if (selectedItem != null)
            {
                selectedItem.Selected = true;
            }
        }

        private void KeepLastSelectedItemFocusInUnfinishedOrderListView()
        {
            var selectedItem = lvUnfinishedOrder.Items.Cast<ListViewItem>().FirstOrDefault(x =>
                int.Parse(x.SubItems[0].Text) == _lastSelectedItemInUnfinishedListView);

            if (selectedItem != null)
            {
                selectedItem.Selected = true;
            }
        }
    }
}