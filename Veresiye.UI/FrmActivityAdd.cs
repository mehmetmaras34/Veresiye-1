using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Veresiye.Model;
using Veresiye.Service;

namespace Veresiye.UI
{

	public partial class FrmActivityAdd : Form
	{
		private readonly int CompanyId;
		private readonly IActivityService activityService;
		public FrmCompanyEdit MasterForm { get; set; }
		public FrmActivityAdd(IActivityService activityService)
		{
			this.activityService = activityService;
			InitializeComponent();
		}

		private void FrmActivityAdd_Load(object sender, EventArgs e)
		{

		}

		public void LoadForm(int companyid)
		{
			this.CompanyId = companyid;
			this.txtName.Clear();
			this.txtAmount.Clear();

		}
		private void BtnAdd_Click(object sender, EventArgs e)
		{
			var activity = new Activity();
			activity.Name = txtName.Text;
			activity.Amount = decimal.Parse(txtAmount.Text);
			activity.TransactionDate = dtpDate.Value;
			if (cmbActivityType.SelectedIndex == 0)
			{
				activity.ActivityType = ActivityType.Dept;
			}
			else if (cmbActivityType.SelectedIndex == 1)
			{
				activity.ActivityType = ActivityType.Payment;
			}
			else if (cmbActivityType.SelectedIndex == 2)
			{
				activity.ActivityType = ActivityType.Credit;
			}
			else if (cmbActivityType.SelectedIndex == 3)
			{
				activity.ActivityType = ActivityType.Collection;
			}

			activityService.Insert(activity);
			MasterForm.LoadActivities();

		}
	}
}

