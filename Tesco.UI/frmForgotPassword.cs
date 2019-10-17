using System;
using System.Windows.Forms;
using Tesco.UI.Helpers;
using Tesco.UI.Interfaces;
using _resource = Tesco.UI.Resources.Strings.en_US.Resources;

namespace Tesco.UI
{
	public partial class frmForgotPassword : Form
	{
		private readonly IEmailValidationHelper _emailValidationHelper;
		
		public frmForgotPassword()
		{
			_emailValidationHelper = new EmailValidationHelper();
			InitializeComponent();
		}
		
		private void txtEmail_Leave(object sender, EventArgs e) => _emailValidationHelper.CheckEmailIfValid(txtEmail.Text);

		private void btnSend_Click(object sender, EventArgs e) => MessageBox.Show(_resource.CheckEmailNotification);
	}
}