using System;
using System.Windows.Forms;
using Tesco.BL.Models;
using Tesco.UI.Helpers;
using Tesco.UI.Interfaces;

namespace Tesco.UI
{
	public partial class frmAdmin : Form
	{
		private readonly ICloseWindowHelper _closeWindowHelper;
		private readonly User _user;

		public frmAdmin(User user)
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

		private void BtnAttendant_Click(object sender, EventArgs e)
		{
			var attendant = new frmAdminAttendant();
			attendant.Show();
		}

		private void frmAdmin_FormClosing(object sender, FormClosingEventArgs e) => e.Cancel = !_closeWindowHelper.NotifyUserForCloseWindow();
	}
}