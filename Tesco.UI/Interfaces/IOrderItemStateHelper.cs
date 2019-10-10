using Tesco.DL.Models;

namespace Tesco.UI.Interfaces
{
    public interface IOrderItemStateHelper
    {
        void DetermineOrderItemStatus(Order order);
    }
}