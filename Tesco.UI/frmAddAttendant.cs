using System;
using System.Windows.Forms;
using Tesco.BL.Interfaces;
using Tesco.BL.Managers;
using Tesco.DL.Models;

namespace Tesco.UI
{
	public partial class frmAddAttendant : Form
	{
		private IUserManager _userManager;

		public frmAddAttendant()
		{
			_userManager = new UserManager();
			InitializeComponent();
		}

		private void BtnAddAttendant_Click(object sender, EventArgs e)
		{
			MessageBox.Show(!string.IsNullOrEmpty(txtFullName.Text) && !string.IsNullOrWhiteSpace(txtFullName.Text)
				&& !string.IsNullOrEmpty(txtUsername.Text) && !string.IsNullOrWhiteSpace(txtUsername.Text)
				&& !string.IsNullOrEmpty(txtPassword.Text) && !string.IsNullOrWhiteSpace(txtPassword.Text)
					? _userManager.Add(new User()
						{
							Username = txtUsername.Text,
							Password = txtPassword.Text,
							FullName = txtFullName.Text,
							Type = "attendant"
						}) > 0
							? "Store attendant adding successful."
							: "Store attendant adding failed."
					: "Please fill up all the details. Thank you.");

			frmAdminAttendant frmAdminAttendant = new frmAdminAttendant();
			this.Hide();
			frmAdminAttendant.Show();
		}
	}
}
