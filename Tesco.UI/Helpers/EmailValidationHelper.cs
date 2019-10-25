using System.Text.RegularExpressions;
using Tesco.UI.Interfaces;

namespace Tesco.UI.Helpers
{
	public class EmailValidationHelper : IEmailValidationHelper
	{
		public bool CheckEmailIfValid(string email)
		{
			return new Regex(Resources.Resources.Regex).IsMatch(email);
		}
	}
}