using System;
using System.Drawing;
using System.Windows.Forms;

namespace Tesco.UI
{
	public partial class frmWelcome : Form
	{
		public frmWelcome()
		{
			InitializeComponent();
		}

		private void frmWelcome_Load(object sender, EventArgs e)
		{
			linkRegister.LinkBehavior = LinkBehavior.NeverUnderline;
			linkLogIn.LinkBehavior = LinkBehavior.NeverUnderline;
			this.ControlBox = false;
		}
		
		private void BtnStartShopping_Click(object sender, EventArgs e)
		{
			var frmShop = new frmShopping();
			this.Hide();
			frmShop.Show();
		}
		
		private void linkRegister_MouseEnter(object sender, EventArgs e) => linkRegister.LinkColor = Color.Blue;

		private void linkRegister_MouseLeave(object sender, EventArgs e) => linkRegister.LinkColor = Color.Black;

		private void linkLogIn_MouseEnter(object sender, EventArgs e) => linkLogIn.LinkColor = Color.Blue;

		private void linkLogIn_MouseLeave(object sender, EventArgs e) => linkLogIn.LinkColor = Color.Black;

		private void LinkRegister_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
		{
			var register = new frmRegisterLogin(251);
			this.Hide();
			register.Show();
		}

		private void LinkLogIn_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
		{
			var login = new frmRegisterLogin(0);
			this.Hide();
			login.Show();
		}
	}
}
