using System;
using System.Linq;
using System.Windows.Forms;
using Tesco.BL.Managers;
using Tesco.BL.Models;
using Tesco.UI.Helpers;
using Tesco.UI.Interfaces;
using _resource = Tesco.UI.Resources.Strings.en_US.Resources;

namespace Tesco.UI
{
	public partial class frmAttendantEditLogin : Form
	{
		private readonly UserManager _userManager;
		private readonly ICloseWindowHelper _closeWindowHelper; 
		private User _user;

		public frmAttendantEditLogin(User user)
		{
			_userManager = new UserManager();
			_closeWindowHelper = new CloseWindowHelper();
			_user = user;
			InitializeComponent();
		}

		private void FrmAttendantEditLogin_Load(object sender, EventArgs e)
		{
			txtUsername.Text = _user.Username;
			txtPassword.Text = _user.Password;
		}

		private void BtnSave_Click(object sender, EventArgs e)
		{
			if (!string.IsNullOrWhiteSpace(txtUsername.Text) && !string.IsNullOrEmpty(txtUsername.Text)
				&& !string.IsNullOrWhiteSpace(txtPassword.Text) && !string.IsNullOrEmpty(txtPassword.Text))
			{
				if (!_user.Username.SequenceEqual(txtUsername.Text) || !_user.Password.SequenceEqual(txtPassword.Text))
				{
					if (_userManager.RetrieveDataByWhereCondition(new User() { Username = txtUsername.Text }) == null)
					{
						_user.Username = txtUsername.Text;
						_user.Password = txtPassword.Text;

						MessageBox.Show(_userManager.Update(_user) != 0
							? _resource.LoginCredentialsEditSuccessful
							: _resource.LoginCredentialsEditFailed);

						var frmAttendant = new frmAttendant(_user);
						this.Hide();
						frmAttendant.Show();
					}
					else
					{
						MessageBox.Show(_resource.UsedUsernameNotification);

						txtUsername.Focus();
					}
				}
				else
				{
					MessageBox.Show(_resource.NoChangesNotification);
					this.Hide();
				}
			}
			else
			{
				MessageBox.Show(_resource.EmptyTextboxNotification);
			}
		}

		private void frmAttendantEditLogin_FormClosing(object sender, FormClosingEventArgs e) => e.Cancel = !_closeWindowHelper.NotifyUserForCloseWindow();
	}
}
