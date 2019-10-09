using System;
using System.Windows.Forms;
using Tesco.DL.Models;

namespace Tesco.UI
{
	public partial class frmAdmin : Form
	{
		private readonly User _user;

		public frmAdmin(User user)
		{
			_user = user;
			InitializeComponent();
		}

		private void BtnItemInventory_Click(object sender, EventArgs e)
		{
			var itemInventory = new frmItemInventory(_user);
			itemInventory.Show();
		}

		private void BtnAttendant_Click(object sender, EventArgs e)
		{
			var attendant = new frmAdminAttendant();
			attendant.Show();
		}

		private void frmAdmin_FormClosing(object sender, FormClosingEventArgs e)
		{
			if (MessageBox.Show("Are you sure you want to close the window?",
				    "Close Window?",
				    MessageBoxButtons.OKCancel,
				    MessageBoxIcon.Question) == DialogResult.OK)
			{
				MessageBox.Show("Admin has logged out.");

				var welcome = new frmWelcome();
				welcome.Show();
			}
			else
			{
				e.Cancel = true;
			}
		}
	}
}