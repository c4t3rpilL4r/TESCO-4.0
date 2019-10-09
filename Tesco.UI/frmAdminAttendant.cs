using System.Linq;
using System.Windows.Forms;
using Tesco.BL.Interfaces;
using Tesco.BL.Managers;
using Tesco.DL.Models;

namespace Tesco.UI
{
	public partial class frmAdminAttendant : Form
	{
		private readonly IItemManager _itemManager;
		private readonly IUserManager _userManager;

		public frmAdminAttendant()
		{
			_itemManager = new ItemManager();
			_userManager = new UserManager();
			InitializeComponent();
		}

		private void FrmAdminAttendant_Load(object sender, System.EventArgs e) => DisplayDataInAttendantListView();

		private void BtnAddAttendant_Click(object sender, System.EventArgs e)
		{
			var frmAddAttendant = new frmAddAttendant();
			this.Hide();
			frmAddAttendant.Show();
		}

		private void LvAttendants_SelectedIndexChanged(object sender, System.EventArgs e) => btnDeleteAttendant.Enabled = lvAttendants.SelectedItems.Count > 0;

		private void BtnDeleteAttendant_Click(object sender, System.EventArgs e)
		{
			MessageBox.Show(_userManager.Delete(int.Parse(lvAttendants.SelectedItems[0].SubItems[0].Text)) > 0
			                ? "Attendant deletion successful."
			                : "Attendant deletion failed.");

			DisplayDataInAttendantListView();
		}
		
		private void frmAdminAttendant_FormClosing(object sender, FormClosingEventArgs e)
		{
			if (MessageBox.Show("Are you sure you want to close the window?",
				"Close Window?",
				MessageBoxButtons.OKCancel,
				MessageBoxIcon.Question) == DialogResult.OK)
			{
				MessageBox.Show("Admin has signed out.");

				var welcome = new frmWelcome();
				this.Hide();
				welcome.Show();
			}
			else
			{
				e.Cancel = true;
			}
		}
		

		// <--------------------------------------------------     METHODS     -------------------------------------------------->

		// handles the displaying of the items in the lvItems
		private void DisplayDataInAttendantListView()
		{
			lvAttendants.Items.Clear();

			_userManager.RetrieveAll<User>()
				.Where(x => x.Type == "attendant")
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
