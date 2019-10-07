using System;
using System.Drawing;
using System.Windows.Forms;
using Tesco.BL.Interfaces;
using Tesco.BL.Managers;
using Tesco.DL.Models;

namespace Tesco.UI
{
	public partial class frmWelcome : Form
	{
		private readonly ICustomerManager _customerManager;
		private readonly IUserManager _userManager;
		private User _user;

		public frmWelcome(User user = null)
		{
			_customerManager = new CustomerManager();
			_userManager = new UserManager();
			_user = user ?? SetGuestValues();
			InitializeComponent();
		}

		private void frmWelcome_Load(object sender, EventArgs e)
		{
			linkRegister.LinkBehavior = LinkBehavior.NeverUnderline;
			linkLogIn.LinkBehavior = LinkBehavior.NeverUnderline;
		}
		
		private void BtnStartShopping_Click(object sender, EventArgs e)
		{
			var frmShop = new frmShopping(_user);

			this.Hide();
			frmShop.Show();
		}
		
		private void linkRegister_MouseEnter(object sender, EventArgs e) => linkRegister.LinkColor = Color.Blue;

		private void linkRegister_MouseLeave(object sender, EventArgs e) => linkRegister.LinkColor = Color.Black;

		private void linkLogIn_MouseEnter(object sender, EventArgs e) => linkLogIn.LinkColor = Color.Blue;

		private void linkLogIn_MouseLeave(object sender, EventArgs e) => linkLogIn.LinkColor = Color.Black;

		private void LinkRegister_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
		{
			var register = new frmRegisterLogin(251, _user);

			this.Hide();
			register.Show();
		}

		private void LinkLogIn_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
		{
			var login = new frmRegisterLogin(0);

			this.Hide();
			login.Show();
		}



		// <--------------------------------------------------     METHODS     -------------------------------------------------->

		private User SetGuestValues()
		{
			return _userManager.RetrieveDataById<User>(_userManager.Add<User>(new User()
			{
				CustomerId = _customerManager.Add<Customer>(new Customer() { IsGuest = true }),
				Type = "customer",
				IsDeleted = false
			}));
		}
	}
}
