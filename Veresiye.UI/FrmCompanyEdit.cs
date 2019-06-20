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
		private readonly ICompanyService companyService;
		public FrmCompanies MasterForm { get; set; }
		public FrmCompanyEdit(ICompanyService companyService)
		{
			this.companyService = companyService;
			InitializeComponent();
		}

		private void FrmCompanyEdit_Load(object sender, EventArgs e)
		{
			var dgvSelectedCompanyId = MasterForm.dgvSelectedCompanyId;
			var company = companyService.Get(dgvSelectedCompanyId);
			txtCompanyName.Text = company.Name;
			txtPhone.Text = company.Phone;
			txtCity.Text = company.City;
			txtRegion.Text = company.Region;
			

		}

		private void BtnQuit_Click(object sender, EventArgs e)
		{
			this.Close();
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
			var dgvSelectedCompanyId = MasterForm.dgvSelectedCompanyId;
			var company = companyService.Get(dgvSelectedCompanyId);
			company.Name = txtCompanyName.Text;
			company.Phone = txtPhone.Text;
			company.City = txtCity.Text;
			company.Region = txtRegion.Text;

			companyService.Update(company);

			MessageBox.Show("Firma Başarıyla Güncellendi");
			this.MasterForm.LoadCompanies();
			
			

		}
	}
}
