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
	public partial class FrmActivityEdit : Form
	{
		public FrmCompanyEdit MasterForm { get; set; }
		private readonly IActivityService activityService;

		public FrmActivityEdit(IActivityService activityService)
		{
			this.activityService = activityService;
			InitializeComponent();
		}
		private void FrmActivityEdit_Load(object sender, EventArgs e)
		{

		}
		
		private int id;
		public void LoadActivityEdit(int id)
		{
			this.id = id;
			var companyid = MasterForm.SendId();
			var activity = activityService.GetActivity(id); // ACTİVİTY ID İLE CAGIR . COMPANY ID İLE CAGIRINCA FİRST OR DEFAULT KULLANDIGIN İÇİN İLK KAYDI GETİRİYOR

			if (activity != null)
			{
				txtName.Text = activity.Name;
				txtAmount.Text = activity.Amount.ToString();
				dtpDate.Value = activity.TransactionDate;

				if (activity.ActivityType == ActivityType.Dept)
				{
					cmbActivityType.SelectedIndex = 0;
				}
				else if (activity.ActivityType == ActivityType.Payment)
				{
					cmbActivityType.SelectedIndex = 1;

				}
				else if (activity.ActivityType == ActivityType.Credit)
				{
					cmbActivityType.SelectedIndex = 2;

				}
				else if (activity.ActivityType == ActivityType.Collection)
				{
					cmbActivityType.SelectedIndex = 3;
				}
			}

			else
			{
				MessageBox.Show("Seçilen İşlem Bulunamadı");
			}
		}
		private void BtnSave_Click(object sender, EventArgs e)
		{
			var companyid = MasterForm.SendId();
			var activity = activityService.Get(companyid);
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
			activity.CompanyId = MasterForm.SendId();
			activityService.Update(activity);
			MasterForm.LoadActivities();
			MessageBox.Show("Kayıt Başarıyla Güncellendi");
		}
		private void FrmActivityEdit_FormClosing(object sender, FormClosingEventArgs e)
		{
			e.Cancel = true;

			this.Hide();
		}
		private void BtnQuit_Click(object sender, EventArgs e)
		{
			this.Hide();
		}

	}
}
