using System;
using System.Windows.Forms;
using Tesco.BL.Interfaces;
using Tesco.BL.Managers;
using Tesco.BL.Models;
using _resource = Tesco.UI.Resources.Strings.en_US.Resources;

namespace Tesco.UI
{
	public partial class frmAddAttendant : Form
	{
		private readonly IUserManager _userManager;

		public frmAddAttendant()
		{
			_userManager = new UserManager();
			InitializeComponent();
		}

		private void BtnAddAttendant_Click(object sender, EventArgs e)
		{
			MessageBox.Show(
				!string.IsNullOrEmpty(txtFullName.Text) && !string.IsNullOrWhiteSpace(txtFullName.Text)
				&& !string.IsNullOrEmpty(txtUsername.Text) && !string.IsNullOrWhiteSpace(txtUsername.Text)
				&& !string.IsNullOrEmpty(txtPassword.Text) && !string.IsNullOrWhiteSpace(txtPassword.Text)
					? _userManager.Add(new User()
						{
							Username = txtUsername.Text,
							Password = txtPassword.Text,
							FullName = txtFullName.Text,
							Type = "attendant",
							IsDeleted = false
						}) > 0
							? _resource.AddAttendantSuccessful
							: _resource.AddAttendantFailed
					: _resource.EmptyTextboxNotification);

			var frmAdminAttendant = new frmAdminAttendant();
			this.Hide();
			frmAdminAttendant.Show();
		}
	}
}
