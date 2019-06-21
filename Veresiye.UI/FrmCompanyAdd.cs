using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Veresiye.Data;
using Veresiye.Model;
using Veresiye.Service;

namespace Veresiye.UI
{

	public partial class FrmCompanyAdd : Form
	{
		public FrmCompanies MasterForm { get; set; }
		private readonly ICompanyService companyService;

		public FrmCompanyAdd(ICompanyService companyService)
		{

			this.companyService = companyService;
			InitializeComponent();
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
			var company = new Company();
			company.Name = txtCompanyName.Text;
			company.Phone = txtPhone.Text;
			company.City = txtCity.Text;
			company.Region = txtRegion.Text;

			companyService.Insert(company);

			MessageBox.Show("Firma Başarıyla Eklendi");
			this.MasterForm.LoadCompanies();
		}

		private void FrmCompanyAdd_Load(object sender, EventArgs e)
		{
			this.FormClosing += FrmCompanyAdd_FormClosing;
		}

		private void FrmCompanyAdd_FormClosing(object sender, FormClosingEventArgs e)
		{
			e.Cancel = true;
			LoadForm();
			this.Hide();
		}
		public void LoadForm()
		{
			txtCompanyName.Clear();
			txtPhone.Clear();
			txtCity.Clear();
			txtRegion.Clear();
		}

		
	}
}

