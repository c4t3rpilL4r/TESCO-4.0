using System;
using System.Net.Mail;
using System.Text.RegularExpressions;
using System.Windows.Forms;
using Tesco.UI.Interfaces;

namespace Tesco.UI.Utilities
{
    public class EmailValidator : IEmailValidator
    {
        public bool CheckEmailIfValid(string email)
        {
            if (new Regex(@"^[-!#$%&'*+/0-9=?A-Z^_a-z{|}~](\.?[-!#$%&'*+/0-9=?A-Z^_a-z{|}~])*@[a-zA-Z](-?[a-zA-Z0-9])*(\.[a-zA-Z](-?[a-zA-Z0-9])*)+$")
                .IsMatch(email)) return true;
            
            MessageBox.Show("Not a valid email.");
            return false;

        }
    }
}