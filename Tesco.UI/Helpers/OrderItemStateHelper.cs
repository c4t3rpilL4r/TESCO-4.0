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
		
		public void ChangeOrderItemStatusToUnfinished(Order order)
		{
			var inDb = false;
			
			var unfinishedOrder = _orderManager.RetrieveDataByWhereCondition(new Order()
			{
				CustomerId = order.CustomerId,
				ItemId = order.ItemId,
				IsCurrentOrder = false,
				IsUnpaid = true,
				IsCancelled = false
			});

			var currentOrder = _orderManager.RetrieveDataByWhereCondition(new Order()
			{
				CustomerId = order.CustomerId,
				ItemId = order.ItemId,
				IsCurrentOrder = true,
				IsUnpaid = true,
				IsCancelled = false
			});

			if (unfinishedOrder != null)
			{
				unfinishedOrder.Quantity += order.Quantity;
				unfinishedOrder.Amount += order.Amount;

				order.Quantity = 0;
				order.Amount = 0;

				inDb = true;
				
				_orderManager.Update(unfinishedOrder);
			}
			
			if (currentOrder != null)
			{
				currentOrder.Quantity = order.Quantity;
				currentOrder.Amount = order.Amount;
				currentOrder.IsCurrentOrder = false;
				currentOrder.IsCancelled = currentOrder.Quantity == 0;

				inDb = true;

				_orderManager.Update(currentOrder);
			}

			if (!inDb)
			{
				_orderManager.Add(new Order()
				{
					CustomerId = order.CustomerId,
					ItemId = order.ItemId,
					Quantity = order.Quantity,
					Amount = order.Amount,
					IsCurrentOrder = false,
					IsUnpaid = true,
					IsCancelled = false
				});
			}
		}
	}
}