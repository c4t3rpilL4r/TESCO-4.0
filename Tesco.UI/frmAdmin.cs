using System;
using System.Windows.Forms;
using Tesco.DL.Models;

namespace Tesco.UI
{
	public partial class frmAdmin : Form
	{
		private readonly User _user;

		public frmAdmin(User user = null)
		{
			_user = user ?? new User();
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
	}
}