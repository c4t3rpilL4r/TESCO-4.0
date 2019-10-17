using System.Text.RegularExpressions;
using Tesco.UI.Interfaces;

namespace Tesco.UI.Helpers
{
	public class EmailValidationHelper : IEmailValidationHelper
	{
		public bool CheckEmailIfValid(string email)
		{
			return new Regex(@"^[-!#$%&'*+/0-9=?A-Z^_a-z{|}~](\.?[-!#$%&'*+/0-9=?A-Z^_a-z{|}~])*@[a-zA-Z](-?[a-zA-Z0-9])*(\.[a-zA-Z](-?[a-zA-Z0-9])*)+$")
				.IsMatch(email);
		}
	}
}