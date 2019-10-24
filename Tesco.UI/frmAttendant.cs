using System;
using System.Windows.Forms;
using Tesco.BL.Models;
using Tesco.UI.Helpers;
using Tesco.UI.Interfaces;
using _resource = Tesco.UI.Resources.Strings.en_US.Resources;

namespace Tesco.UI
{
	public partial class frmAttendant : Form
	{
		private readonly ICloseWindowHelper _closeWindowHelper;
		private readonly User _user;

		public frmAttendant(User user)
		{
			_closeWindowHelper = new CloseWindowHelper();
			_user = user;
			InitializeComponent();
		}

		private void BtnItemInventory_Click(object sender, EventArgs e)
		{
			var itemInventory = new frmItemInventory(_user);

			itemInventory.Show();
		}

		private void BtnEditLogin_Click(object sender, EventArgs e)
		{
			var attendantEditLogin = new frmAttendantEditLogin(_user);

			attendantEditLogin.Show();
		}

		private void BtnLogoff_Click(object sender, EventArgs e)
		{
			MessageBox.Show(_resource.LogoffSuccessful);

			var welcome = new frmWelcome();
			this.Hide();
			welcome.Show();
		}

		private void frmAttendant_FormClosing(object sender, FormClosingEventArgs e) => e.Cancel = !_closeWindowHelper.NotifyUserForCloseWindow(_user);
	}
}
