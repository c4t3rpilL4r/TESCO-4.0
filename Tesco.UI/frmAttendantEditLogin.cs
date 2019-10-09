using System;
using System.Linq;
using System.Windows.Forms;
using Tesco.BL.Managers;
using Tesco.DL.Models;

namespace Tesco.UI
{
	public partial class frmAttendantEditLogin : Form
	{
		private UserManager _userManager;
		private User _user;

		public frmAttendantEditLogin(User user)
		{
			_userManager = new UserManager();
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
							? "Login credentials edit successful."
							: "Login credentials edit failed.");

						var frmAttendant = new frmAttendant(_user);
						this.Hide();
						frmAttendant.Show();
					}
					else
					{
						MessageBox.Show(@"Username is taken.");

						txtUsername.Focus();
					}
				}
				else
				{
					MessageBox.Show(@"No changes were made.");
					this.Hide();
				}
			}
			else
			{
				MessageBox.Show(@"Please fill up the details. Thank you.");
			}
			
			
		}

		private void frmAttendantEditLogin_FormClosing(object sender, FormClosingEventArgs e)
		{
			e.Cancel = MessageBox.Show("Are you sure you want to close the window?",
				"Close Window?",
				MessageBoxButtons.OKCancel,
				MessageBoxIcon.Question) == DialogResult.Cancel;
		}
	}
}
