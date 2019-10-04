using System;
using System.Windows.Forms;
using Tesco.DL.Models;

namespace Tesco.UI
{
	public partial class frmAttendant : Form
	{
		private User _user;

		public frmAttendant(User user = null)
		{
			_user = user ?? new User();
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
			_user = new User();

			MessageBox.Show(@"Log off successfully.");

			var welcome = new frmWelcome();
			this.Hide();
			welcome.Show();
		}
	}
}
