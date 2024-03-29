﻿using System.Windows.Forms;
using Tesco.BL.Models;
using Tesco.UI.Interfaces;
using _resource = Tesco.UI.Resources.Resources;

namespace Tesco.UI.Helpers
{
	public class CloseWindowHelper : ICloseWindowHelper
	{
		public bool NotifyUserForCloseWindow(User user = null)
		{
			if (MessageBox.Show(_resource.NotificationCloseWindow,
					_resource.TitleCloseWindow,
					MessageBoxButtons.OKCancel,
					MessageBoxIcon.Question) == DialogResult.OK)
			{
				if (user != null)
				{
					MessageBox.Show(_resource.NotificationSignOff);
				}

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