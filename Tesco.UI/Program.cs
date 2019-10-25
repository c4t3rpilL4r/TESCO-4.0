using System;
using System.Threading;
using System.Windows.Forms;

namespace Tesco.UI
{
	static class Program
	{
		/// <summary>
		/// The main entry point for the application.
		/// </summary>
		[STAThread]
		static void Main()
		{
			//Thread.CurrentThread.CurrentCulture = new System.Globalization.CultureInfo("sv-SE");
			//Thread.CurrentThread.CurrentUICulture = new System.Globalization.CultureInfo("sv-SE");
			Application.EnableVisualStyles();
			Application.SetCompatibleTextRenderingDefault(false);
			Application.Run(new frmWelcome());
		}
	}
}
