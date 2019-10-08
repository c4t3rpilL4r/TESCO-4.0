using System;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using Tesco.BL.Interfaces;
using Tesco.BL.Managers;
using Tesco.DL.Models;
using Tesco.UI.Interfaces;
using Tesco.UI.Utilities;

namespace Tesco.UI
{
	public partial class frmRegisterLogin : Form
	{
		private readonly ICustomerManager _customerManager;
		private readonly IItemCustomerManager _itemCustomerManager;
		private readonly IItemManager _itemManager;
		private readonly IUserManager _userManager;
		private readonly IEmailValidator _emailValidator;
		private User _user;
		private bool _hasMessageBoxShown = false;
		private int _pnlRegisterHeight;

		public frmRegisterLogin(int pnlRegisterHeight, User user = null)
		{
			_customerManager = new CustomerManager();
			_itemCustomerManager = new ItemCustomerManager();
			_itemManager = new ItemManager();
			_userManager = new UserManager();
			_emailValidator = new EmailValidator();
			_user = user;
			_pnlRegisterHeight = pnlRegisterHeight;
			InitializeComponent();
		}

		private void FrmRegisterLogin_Load(object sender, System.EventArgs e)
		{
			linkForgotPassword.LinkBehavior = LinkBehavior.NeverUnderline;
			CheckWhatPanelToDisplay();
			timer.Start();
		}

		private void txtEmail_Leave(object sender, EventArgs e)
		{
			if (_emailValidator.CheckEmailIfValid(txtEmail.Text))
			{
				if (_customerManager.RetrieveDataByWhereCondition(new Customer() {Email = txtEmail.Text}) == null || _hasMessageBoxShown) return;

				if (MessageBox.Show("Email is already used. Do you want to proceed to login instead?",
						"Proceed to login?",
						MessageBoxButtons.YesNo,
						MessageBoxIcon.Question) == DialogResult.Yes)
				{
					_pnlRegisterHeight = 0;
					_hasMessageBoxShown = true;

					txtEmail.Text = string.Empty;
					CheckWhatPanelToDisplay();
					timer.Start();
				}
				else
				{
					MessageBox.Show("Please change the email. Thank you.");
				}
			}
			else
			{
				txtEmail.Focus();
			}
		}

		private void linkForgotPassword_MouseEnter(object sender, EventArgs e) => linkForgotPassword.LinkColor = Color.Blue;

		private void linkForgotPassword_MouseLeave(object sender, EventArgs e) => linkForgotPassword.LinkColor = Color.Black;

		private void linkForgotPassword_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
		{
			var forgotPassword = new frmForgotPassword();
			forgotPassword.Show();
		}

		private void BtnRegister_Click(object sender, System.EventArgs e)
		{
			if (_pnlRegisterHeight > 0)
			{
				if (!string.IsNullOrWhiteSpace(txtFirstName.Text)
					&& !string.IsNullOrWhiteSpace(txtLastName.Text)
					&& !string.IsNullOrWhiteSpace(txtEmail.Text) && _emailValidator.CheckEmailIfValid(txtEmail.Text)
					&& !string.IsNullOrWhiteSpace(txtPhoneNumber.Text)
					&& !string.IsNullOrWhiteSpace(txtUsername.Text)
					&& !string.IsNullOrWhiteSpace(txtPassword.Text))
				{
					var customer = _customerManager.RetrieveDataById<Customer>(_user.CustomerId);

					customer.FullName = $"{txtFirstName.Text} {txtLastName.Text}";
					customer.Email = txtEmail.Text;
					customer.PhoneNumber = txtPhoneNumber.Text;
					customer.IsGuest = false;

					_customerManager.Update(customer);

					_user.Username = txtUsername.Text;
					_user.Password = txtPassword.Text;
					_user.FullName = customer.FullName;

					if (_userManager.Update(_user) != 0)
					{
						MessageBox.Show("Registration successful.");

						var shopping = new frmShopping(_user);
						this.Hide();
						shopping.Show();
					}
					else
					{
						MessageBox.Show("Registration failed. Please check details again if all are correct.");
					}
				}
				else
				{
					MessageBox.Show("Please fill up all the details. Thank you");
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
					_user = _userManager.RetrieveDataByWhereCondition(new User()
					{
						Username = txtLoginUsername.Text,
						Password = txtLoginPassword.Text
					});

					if (_userManager.ValidateUserLogin(_user))
					{
						MessageBox.Show("Login successful.");

						this.Hide();

						if (_user.Type.Equals("admin"))
						{
							MessageBox.Show($"Hello, Admin {_user.FullName}.");
							
							var admin = new frmAdmin(_user);
							admin.Show();
						}
						else if (_user.Type.Equals("attendant"))
						{
							MessageBox.Show($"Hello, Attendant {_user.FullName}.");
							
							var attendant = new frmAttendant(_user);
							attendant.Show();
						}
						else if (_user.Type.Equals("customer"))
						{
							MessageBox.Show($"Hello, Customer {_user.FullName}.");
							
							if (_itemCustomerManager.RetrieveAll<ItemCustomer>()
										.Where(x => x.CustomerId == _user.CustomerId
										            && x.IsCurrentOrder == false
										            && x.IsUnpaid == true
										            && x.IsCancelled == false)
										.ToList().Count > 0)
							{
								if (MessageBox.Show("You have an unfinished transaction. Would you like to proceed to it?",
										"Unfinished Transaction",
										MessageBoxButtons.YesNo,
										MessageBoxIcon.Question) == DialogResult.Yes)
								{
									var unfinishedTransaction = new frmUnfinishedTransaction(_user);
									unfinishedTransaction.Show();

									return;
								}
							}
							else if (_itemCustomerManager.RetrieveAll<ItemCustomer>()
										.Where(x => x.CustomerId == _user.CustomerId
										            && x.IsCurrentOrder == true
										            && x.IsUnpaid == true)
										.ToList().Count > 0)
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
						MessageBox.Show("Login failed.");
					}
				}
				else
				{
					MessageBox.Show("Please fill up all the details. Thank you");
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

		private void FrmRegisterLogin_FormClosing(object sender, FormClosingEventArgs e)
		{
			_itemCustomerManager.RetrieveAll<ItemCustomer>()
				.Where(x => x.CustomerId == _user.CustomerId
				            && x.IsCurrentOrder == true
				            && x.IsUnpaid == true)
				.ToList()
				.ForEach(x =>
				{
					if (_customerManager.RetrieveDataById<Customer>(_user.CustomerId).IsGuest != true)
					{
						var unfinishedOrder = _itemCustomerManager.RetrieveDataByWhereCondition<ItemCustomer>(
							new ItemCustomer()
							{
								CustomerId = x.CustomerId,
								ItemId = x.ItemId,
								IsCurrentOrder = false,
								IsUnpaid = true
							});

						if (unfinishedOrder != null)
						{
							unfinishedOrder.Quantity += x.Quantity;
							unfinishedOrder.Amount += x.Amount;

							_itemCustomerManager.Update(unfinishedOrder);

							x.Quantity = 0;
							x.Amount = 0;
						}

						x.IsCurrentOrder = false;

						_itemCustomerManager.Update(x);
					}
					else
					{
						var item = _itemManager.RetrieveDataById<Item>(x.ItemId);

						item.Stocks += x.Quantity;

						_itemManager.Update(item);

						x.IsCancelled = true;

						_itemCustomerManager.Update(x);
					}
				});
		}



		// <--------------------------------------------------     METHODS     -------------------------------------------------->

		private void CheckWhatPanelToDisplay()
		{
			pnlRegister.Enabled = _pnlRegisterHeight > 0;
			pnlRegister.Visible = _pnlRegisterHeight > 0;

			this.Text = _pnlRegisterHeight > 0 ? "TESCO Registration" : "TESCO Log In";
		}
	}
}