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
			
			var cancelledOrder = _orderManager.RetrieveDataByWhereCondition(new Order()
			{
				CustomerId = order.CustomerId,
				ItemId = order.ItemId,
				Quantity = 0,
				Amount = 0,
				IsCancelled = true
			});

			if (unfinishedOrder != null)
			{
				unfinishedOrder.Quantity += order.Quantity;
				unfinishedOrder.Amount += order.Amount;

				order.Quantity = 0;
				order.Amount = 0;

				_orderManager.Update(unfinishedOrder);
			}
			
			if (currentOrder != null)
			{
				currentOrder.Quantity = order.Quantity;
				currentOrder.Amount = order.Amount;
				currentOrder.IsCurrentOrder = false;
				currentOrder.IsCancelled = currentOrder.Quantity == 0;

				_orderManager.Update(currentOrder);
			}
			else
			{
				if (cancelledOrder != null)
				{
					cancelledOrder.Quantity = order.Quantity;
					cancelledOrder.Amount = order.Amount;
					cancelledOrder.IsCancelled = false;

					_orderManager.Update(cancelledOrder);
				}
				else
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
}