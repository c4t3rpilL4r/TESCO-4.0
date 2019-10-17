using System;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using Tesco.BL.Interfaces;
using Tesco.BL.Managers;
using Tesco.DL.Models;
using Tesco.UI.Helpers;
using Tesco.UI.Interfaces;
using _resource = Tesco.UI.Resources.Strings.en_US.Resources;

namespace Tesco.UI
{
	public partial class frmRegisterLogin : Form
	{
		private readonly ICustomerManager _customerManager;
		private readonly IOrderManager _orderManager;
		private readonly IUserManager _userManager;
		private readonly ICloseWindowHelper _closeWindowHelper;
		private readonly IEmailValidationHelper _emailValidationHelper;
		private User _user;
		private int _pnlRegisterHeight;

		public frmRegisterLogin(int pnlRegisterHeight, User user = null)
		{
			_customerManager = new CustomerManager();
			_orderManager = new OrderManager();
			_userManager = new UserManager();
			_closeWindowHelper = new CloseWindowHelper();
			_emailValidationHelper = new EmailValidationHelper();
			_user = user;
			_pnlRegisterHeight = pnlRegisterHeight;
			InitializeComponent();
		}

		private void FrmRegisterLogin_Load(object sender, System.EventArgs e)
		{
			if (_pnlRegisterHeight > 0)
			{
				txtFirstName.Focus();
			}

			linkForgotPassword.LinkBehavior = LinkBehavior.NeverUnderline;
			CheckWhatPanelToDisplay();
			timer.Start();
		}

		private void txtEmail_Leave(object sender, EventArgs e)
		{
			if (_emailValidationHelper.CheckEmailIfValid(txtEmail.Text))
			{
				if (_customerManager.RetrieveDataByWhereCondition(new Customer() { Email = txtEmail.Text }) == null) return;

				if (MessageBox.Show(_resource.UsedEmailNotification,
						_resource.UsedEmailTitle,
						MessageBoxButtons.YesNo,
						MessageBoxIcon.Question) == DialogResult.Yes)
				{
					_pnlRegisterHeight = 0;
					CheckWhatPanelToDisplay();
				}
				else
				{
					MessageBox.Show(_resource.ChangeEmailNotification);
				}
			}
			else
			{
				if (_pnlRegisterHeight != 0)
				{
					MessageBox.Show(_resource.InvalidEmailNotification);
				}
			}

			txtEmail.Focus();
		}

		private void linkForgotPassword_MouseEnter(object sender, EventArgs e) => linkForgotPassword.LinkColor = Color.Blue;

		private void linkForgotPassword_MouseLeave(object sender, EventArgs e) => linkForgotPassword.LinkColor = Color.Black;

		private void linkForgotPassword_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
		{
			var forgotPassword = new frmForgotPassword();
			forgotPassword.Show();
		}

		private void txtPhoneNumber_KeyPress(object sender, KeyPressEventArgs e) => e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
		
		private void BtnRegister_Click(object sender, System.EventArgs e)
		{
			if (_pnlRegisterHeight > 0)
			{
				if (!string.IsNullOrWhiteSpace(txtFirstName.Text)
					&& !string.IsNullOrWhiteSpace(txtLastName.Text)
					&& !string.IsNullOrWhiteSpace(txtEmail.Text) && _emailValidationHelper.CheckEmailIfValid(txtEmail.Text)
					&& !string.IsNullOrWhiteSpace(txtPhoneNumber.Text)
					&& !string.IsNullOrWhiteSpace(txtUsername.Text)
					&& !string.IsNullOrWhiteSpace(txtPassword.Text))
				{
					if (_user != null) return;
					
					var customerId = _customerManager.Add(new Customer()
					{
						FullName = $"{txtFirstName.Text} {txtLastName.Text}",
						Email = txtEmail.Text,
						PhoneNumber = txtPhoneNumber.Text
					});
						
					_user = new User()
					{
						Username = txtUsername.Text,
						Password = txtPassword.Text,
						FullName = $"{txtFirstName.Text} {txtLastName.Text}",
						CustomerId = customerId,
						Type = "customer",
						IsDeleted = false
					};
						
					if (_userManager.Add(_user) > 0)
					{
						MessageBox.Show(_resource.RegistrationSuccessful);

						var shopping = new frmShopping(_user);
						this.Hide();
						shopping.Show();
					}
					else
					{
						MessageBox.Show(_resource.RegistrationFailed);
					}
				}
				else
				{
					MessageBox.Show(_resource.EmptyTextboxNotification);
				}
			}
			else
			{
				_pnlRegisterHeight = 251;

				CheckWhatPanelToDisplay();
				timer.Start();
			}
		}

		private void btnLogIn_Click(object sender, EventArgs e)
		{
			if (_pnlRegisterHeight == 0)
			{
				if (!string.IsNullOrWhiteSpace(txtLoginUsername.Text)
					&& !string.IsNullOrWhiteSpace(txtLoginPassword.Text))
				{
					if (_userManager.ValidateUserLogin(new User() { Username = txtLoginUsername.Text, Password = txtLoginPassword.Text }))
					{
						_user = _userManager.RetrieveDataByWhereCondition(new User()
						{
							Username = txtLoginUsername.Text,
							Password = txtLoginPassword.Text
						});

						MessageBox.Show(_resource.LoginSuccessful);

						this.Hide();

						if (_user.Type.Equals("admin"))
						{
							MessageBox.Show(string.Format(_resource.AdminGreeting, _user.FullName));
							
							var admin = new frmAdmin(_user);
							admin.Show();
						}
						else if (_user.Type.Equals("attendant"))
						{
							MessageBox.Show(string.Format(_resource.AttendantGreeting, _user.FullName));
							
							var attendant = new frmAttendant(_user);
							attendant.Show();
						}
						else if (_user.Type.Equals("customer"))
						{
							if (_orderManager.RetrieveAll<Order>()
									.Where(x => x.CustomerId == _user.CustomerId
												&& x.IsUnpaid == true
												&& x.IsCancelled == false)
									.ToList()
									.Count > 0
									&& MessageBox.Show(_resource.UnfinishedTransactionNotification,
										_resource.UnfinishedTransactionTitle,
										MessageBoxButtons.YesNo,
										MessageBoxIcon.Question) == DialogResult.Yes)
							{
								var checkout = new frmCheckout(_user);
								checkout.Show();

								return;
							}

							var shopping = new frmShopping(_user);
							shopping.Show();
						}
					}
					else
					{
						MessageBox.Show(_userManager.RetrieveDataByWhereCondition(new User() { Username = txtLoginUsername.Text, Password = txtLoginPassword.Text }) == null
							? _resource.UnregisteredLoginCredentials
							: _resource.LoginFailed);
					}
				}
				else
				{
					MessageBox.Show(_resource.EmptyTextboxNotification);
				}
			}
			else
			{
				_pnlRegisterHeight = 0;

				CheckWhatPanelToDisplay();
				timer.Start();
			}
		}

		private void Timer_Tick(object sender, System.EventArgs e)
		{
			pnlRegister.Height = _pnlRegisterHeight;
			timer.Stop();
			this.Refresh();
		}

		private void FrmRegisterLogin_FormClosing(object sender, FormClosingEventArgs e) => e.Cancel = !_closeWindowHelper.NotifyUserForCloseWindow();



		// <--------------------------------------------------     METHODS     -------------------------------------------------->

		private void CheckWhatPanelToDisplay()
		{
			pnlRegister.Enabled = _pnlRegisterHeight > 0;
			pnlRegister.Visible = _pnlRegisterHeight > 0;

			this.Text = _pnlRegisterHeight > 0
				? _resource.RegistrationTitle
				: _resource.LoginTitle;
			timer.Start();

			ClearTextBoxes();
		}

		private void ClearTextBoxes()
		{
			if (_pnlRegisterHeight == 0)
			{
				txtFirstName.Text = string.Empty;
				txtLastName.Text = string.Empty;
				txtEmail.Text = string.Empty;
				txtPhoneNumber.Text = string.Empty;
				txtUsername.Text = string.Empty;
				txtPassword.Text = string.Empty;
			}
			else
			{
				txtLoginUsername.Text = string.Empty;
				txtLoginPassword.Text = string.Empty;
			}
		}
	}
}