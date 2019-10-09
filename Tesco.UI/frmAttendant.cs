using System;
using System.Windows.Forms;
using Tesco.DL.Models;

namespace Tesco.UI
{
	public partial class frmAttendant : Form
	{
		private readonly User _user;

		public frmAttendant(User user)
		{
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
			MessageBox.Show(@"Log off successfully.");

			var welcome = new frmWelcome();
			this.Hide();
			welcome.Show();
		}

		private void frmAttendant_FormClosing(object sender, FormClosingEventArgs e)
		{
			e.Cancel = MessageBox.Show("Are you sure you want to close the window?",
				           "Close Window?",
				           MessageBoxButtons.OKCancel,
				           MessageBoxIcon.Question) == DialogResult.Cancel;
		}
	}
}
