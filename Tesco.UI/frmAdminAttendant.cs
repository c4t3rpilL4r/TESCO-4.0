using System.Linq;
using System.Windows.Forms;
using Tesco.BL.Interfaces;
using Tesco.BL.Managers;
using Tesco.BL.Models;
using Tesco.UI.Helpers;
using Tesco.UI.Interfaces;
using _resource = Tesco.UI.Resources.Resources;

namespace Tesco.UI
{
	public partial class frmAdminAttendant : Form
	{
		private readonly IUserManager _userManager;
		private readonly ICloseWindowHelper _closeWindowHelper;
		private readonly User _user;

		public frmAdminAttendant(User user)
		{
			_userManager = new UserManager();
			_closeWindowHelper = new CloseWindowHelper();
			_user = user;
			InitializeComponent();
		}

		private void FrmAdminAttendant_Load(object sender, System.EventArgs e) => DisplayDataInAttendantListView();

		private void BtnAddAttendant_Click(object sender, System.EventArgs e)
		{
			var frmAddAttendant = new frmAddAttendant(_user);
			this.Hide();
			frmAddAttendant.Show();
		}

		private void LvAttendants_SelectedIndexChanged(object sender, System.EventArgs e) => btnDeleteAttendant.Enabled = lvAttendants.SelectedItems.Count > 0;

		private void BtnDeleteAttendant_Click(object sender, System.EventArgs e)
		{
			MessageBox.Show(_userManager.Delete<User>(int.Parse(lvAttendants.SelectedItems[0].SubItems[0].Text)) > 0
							? _resource.DeleteAttendantSuccessful
							: _resource.DeleteAttendantFailed);

			DisplayDataInAttendantListView();
		}

		private void frmAdminAttendant_FormClosing(object sender, FormClosingEventArgs e) => e.Cancel = !_closeWindowHelper.NotifyUserForCloseWindow(_user);

		// <--------------------------------------------------     METHODS     -------------------------------------------------->

		private void DisplayDataInAttendantListView()
		{
			lvAttendants.Items.Clear();

			_userManager.RetrieveAll<User>()
				.Where(x => x.Type.Equals(User.UserTypes.attendant.ToString()))
				.ToList()
				.ForEach(x => lvAttendants.Items.Add(ConvertToAttendantListViewItem(x)));
		}

		private static ListViewItem ConvertToAttendantListViewItem(User user)
		{
			var row = new ListViewItem(user.Id.ToString());
			row.SubItems.Add(user.FullName);
			row.SubItems.Add(user.Username);
			row.SubItems.Add(user.Password);

			return row;
		}
	}
}
