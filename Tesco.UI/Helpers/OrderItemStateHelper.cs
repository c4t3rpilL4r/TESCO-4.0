using Tesco.BL.Interfaces;
using Tesco.BL.Managers;
using Tesco.DL.Models;
using Tesco.UI.Interfaces;

namespace Tesco.UI.Helpers
{
    public class OrderItemStateHelper : IOrderItemStateHelper
    {
        private readonly IOrderManager _orderManager;

        public OrderItemStateHelper()
        {
            _orderManager = new OrderManager();
        }
        
        public void DetermineOrderItemStatus(Order order)
        {
            var unfinishedOrder = _orderManager.RetrieveDataByWhereCondition(new Order()
            {
                CustomerId = order.CustomerId,
                ItemId = order.ItemId,
                IsCurrentOrder = false,
                IsUnpaid = true
            });
            
            var currentOrder = _orderManager.RetrieveDataByWhereCondition(new Order()
            {
                CustomerId = order.CustomerId,
                ItemId = order.ItemId,
                IsCurrentOrder = true,
                IsUnpaid = true
            });

            currentOrder.IsCurrentOrder = false;
            
            if (unfinishedOrder != null)
            {
                unfinishedOrder.Quantity += currentOrder.Quantity;
                unfinishedOrder.Amount += currentOrder.Amount;

                currentOrder.Quantity = 0;
                currentOrder.Amount = 0;

                _orderManager.Update(unfinishedOrder);
                _orderManager.Update(currentOrder);
            }
            else
            {
                _orderManager.Add(currentOrder);
            }
        }
    }
}