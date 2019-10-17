using System.Windows.Forms;
using Tesco.UI.Interfaces;
using _resource = Tesco.UI.Resources.Strings.en_US.Resources;

namespace Tesco.UI.Helpers
{
	public class CloseWindowHelper : ICloseWindowHelper
	{
		public bool NotifyUserForCloseWindow()
		{
			if (MessageBox.Show(_resource.CloseWindowNotification,
					_resource.CloseWindowTitle,
					MessageBoxButtons.OKCancel,
					MessageBoxIcon.Question) == DialogResult.OK)
			{
				MessageBox.Show("You are signed off.");

				var welcome = new frmWelcome();
				welcome.Show();

				return true;
			}
			else
			{
				return false;
			}
		}
	}
}