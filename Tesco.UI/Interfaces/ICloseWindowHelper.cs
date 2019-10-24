using Tesco.BL.Models;

namespace Tesco.UI.Interfaces
{
	public interface ICloseWindowHelper
	{
		bool NotifyUserForCloseWindow(User user = null);
	}
}