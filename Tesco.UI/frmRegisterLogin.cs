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
		private readonly IItemManager _itemManager;
		private readonly IOrderManager _orderManager;
		private readonly IUserManager _userManager;
		private readonly IEmailValidator _emailValidator;
		private User _user;
		private int _pnlRegisterHeight;

		public frmRegisterLogin(int pnlRegisterHeight, User user = null)
		{
			_customerManager = new CustomerManager();
			_itemManager = new ItemManager();
			_orderManager = new OrderManager();
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
				if (_customerManager.RetrieveDataByWhereCondition(new Customer() { Email = txtEmail.Text }) == null) return;

				if (MessageBox.Show("Email is already used. Do you want to proceed to login instead?",
						"Proceed to login?",
						MessageBoxButtons.YesNo,
						MessageBoxIcon.Question) == DialogResult.Yes)
				{
					_pnlRegisterHeight = 0;
					CheckWhatPanelToDisplay();
				}
				else
				{
					MessageBox.Show("Please change the email. Thank you.");
				}
			}
			else
			{
				if (_pnlRegisterHeight != 0)
				{
					MessageBox.Show("Not a valid email.");
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
					&& !string.IsNullOrWhiteSpace(txtEmail.Text) && _emailValidator.CheckEmailIfValid(txtEmail.Text)
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
							if (_orderManager.RetrieveAll<Order>()
										.Where(x => x.CustomerId == _user.CustomerId
										            && x.IsCurrentOrder == false
										            && x.IsUnpaid == true)
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
							else if (_orderManager.RetrieveAll<Order>()
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
			if (MessageBox.Show("Are you sure you want to close the window?",
				    "Close Window?",
				    MessageBoxButtons.OKCancel,
				    MessageBoxIcon.Question) == DialogResult.OK)
			{
				if (_user != null)
				{
					_orderManager.RetrieveAll<Order>()
						.Where(x => x.CustomerId == _user.CustomerId
						            && x.IsCurrentOrder == true
						            && x.IsUnpaid == true)
						.ToList()
						.ForEach(x =>
						{
							if (_user != null)
							{
								var unfinishedOrder = _orderManager.RetrieveDataByWhereCondition<Order>(
									new Order()
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

									_orderManager.Update(unfinishedOrder);

									x.Quantity = 0;
									x.Amount = 0;
								}

								x.IsCurrentOrder = false;

								_orderManager.Update(x);
							}
							else
							{
								var item = _itemManager.RetrieveDataById<Item>(x.ItemId);

								item.Stocks += x.Quantity;

								_itemManager.Update(item);

								_orderManager.Update(x);
							}
						});
				}
				
				var welcome = new frmWelcome();
				welcome.Show();
			}
			else
			{
				e.Cancel = true;
			}
		}



		// <--------------------------------------------------     METHODS     -------------------------------------------------->

		private void CheckWhatPanelToDisplay()
		{
			pnlRegister.Enabled = _pnlRegisterHeight > 0;
			pnlRegister.Visible = _pnlRegisterHeight > 0;

			this.Text = _pnlRegisterHeight > 0 ? "TESCO Registration" : "TESCO Log In";
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