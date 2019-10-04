using System;
using System.Windows.Forms;
using Tesco.UI.Interfaces;
using Tesco.UI.Utilities;

namespace Tesco.UI
{
    public partial class frmForgotPassword : Form
    {
        private readonly IEmailValidator _emailValidator;
        
        public frmForgotPassword()
        {
            _emailValidator = new EmailValidator();
            InitializeComponent();
        }
        
        private void txtEmail_Leave(object sender, EventArgs e) => _emailValidator.CheckEmailIfValid(txtEmail.Text);

        private void btnSend_Click(object sender, EventArgs e) => MessageBox.Show("Please check your email for instructions on how to reset your password.");
    }
}