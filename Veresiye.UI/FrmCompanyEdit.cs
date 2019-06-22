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
	public partial class FrmCompanyEdit : Form
	{
		private readonly FrmActivityEdit frmActivityEdit;
		private readonly FrmActivityAdd frmActivityAdd;
		private readonly IActivityService activityService;
		private readonly ICompanyService companyService;

		public FrmCompanies MasterForm { get; set; }
		public FrmCompanyEdit(ICompanyService companyService,FrmActivityEdit frmActivityEdit ,FrmActivityAdd frmActivityAdd , IActivityService activityService)
		{
			this.frmActivityEdit = frmActivityEdit;
			this.frmActivityAdd = frmActivityAdd;
			this.activityService = activityService;
			this.companyService = companyService;
			InitializeComponent();
			frmActivityAdd.MdiParent = this.MdiParent;
			frmActivityAdd.MasterForm = this;
			frmActivityEdit.MdiParent = this.MdiParent;
			frmActivityEdit.MasterForm = this;
		}

		private void FrmCompanyEdit_Load(object sender, EventArgs e)
		{
			 		
			
		}

		private  int id;
		public void LoadForm(int Id)
		{
			this.id = Id;			
			var company = companyService.Get(id);
			txtCompanyName.Text = company.Name;
			txtPhone.Text = company.Phone;
			txtCity.Text = company.City;
			txtRegion.Text = company.Region;
			LoadActivities();
		}

		public void LoadActivities()
		{
			this.dgvActivity.AutoGenerateColumns = false;
			this.dgvActivity.DataSource = activityService.GetAllByCompanyId(this.id);
		}

		private void BtnQuit_Click(object sender, EventArgs e)
		{
			this.Hide();
		}

		private void BtnSave_Click(object sender, EventArgs e)
		{
			if (string.IsNullOrEmpty(txtCompanyName.Text))
			{
				MessageBox.Show("Firma Adı Girmediniz.");
				return;
			}
			else if (string.IsNullOrEmpty(txtPhone.Text))
			{
				MessageBox.Show("Telefon Numarası Girmediniz.");
				return;
			}
			else if (string.IsNullOrEmpty(txtCity.Text))
			{
				MessageBox.Show("Şehir Girmediniz.");
				return;
			}
			else if (string.IsNullOrEmpty(txtRegion.Text))
			{
				MessageBox.Show("Bölge Girmediniz");
				return;
			}
			;
			var company = companyService.Get(this.id);
			company.Name = txtCompanyName.Text;
			company.Phone = txtPhone.Text;
			company.City = txtCity.Text;
			company.Region = txtRegion.Text;

			companyService.Update(company);

			MessageBox.Show("Firma Başarıyla Güncellendi");
			this.MasterForm.LoadCompanies();
			
			

		}
		public int SendId()
		{
			return this.id;
		}
	
		private void FrmCompanyEdit_FormClosing(object sender, FormClosingEventArgs e)
		{
			e.Cancel = true;
			this.Hide();
		}

		private void BtnEditActivity_Click(object sender, EventArgs e)
		{
			if (this.dgvActivity.SelectedRows.Count > 0)
			{
				int dgvSelectedActivityId = int.Parse(this.dgvActivity.SelectedRows[0].Cells[0].Value.ToString());
				frmActivityEdit.Show();
				frmActivityEdit.LoadActivityEdit(dgvSelectedActivityId);
			}
			else
			{
				MessageBox.Show("Lütfen Güncellemek İstediğiniz Kaydı Seçin");
			}
		}

		private void BtnAddActivity_Click(object sender, EventArgs e)
		{
			frmActivityAdd.Show();
		}

		private void BtnDeleteActivity_Click(object sender, EventArgs e)
		{
			if (this.dgvActivity.SelectedRows.Count>0)
			{
				var activityid = int.Parse(this.dgvActivity.SelectedRows[0].Cells[0].Value.ToString());
				activityService.Delete(activityid);
				//LoadActivities();
			}
		}
	}
}
