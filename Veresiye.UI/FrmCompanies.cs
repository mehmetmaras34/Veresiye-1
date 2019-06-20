using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Veresiye.Service;

namespace Veresiye.UI
{
	public partial class FrmCompanies : Form
	{
		public int dgvSelectedCompanyId;
		private readonly FrmCompanyEdit frmCompanyEdit;
		private readonly FrmCompanyAdd frmCompanyAdd;
		private readonly ICompanyService companyService;
		public FrmCompanies(ICompanyService companyService ,FrmCompanyEdit frmCompanyEdit, FrmCompanyAdd frmCompanyAdd)
		{
			this.frmCompanyEdit = frmCompanyEdit;
			this.frmCompanyAdd = frmCompanyAdd;
			this.companyService = companyService;
			InitializeComponent();
			this.frmCompanyAdd.MdiParent = this.MdiParent;
			this.frmCompanyAdd.MasterForm = this;
			this.frmCompanyEdit.MdiParent = this.MdiParent;
			this.frmCompanyEdit.MasterForm = this;
			
		}

		private void FrmCompanies_Load(object sender, EventArgs e)
		{
			LoadCompanies();
		}
		public void	LoadCompanies()
		{
			var companies = companyService.GetAll();
			this.dgvCompanies.AutoGenerateColumns = false;
			this.dgvCompanies.DataSource = companies;
		}

		private void BtnAdd_Click(object sender, EventArgs e)
		{
			frmCompanyAdd.Show();
		}

		private void Panel1_Paint(object sender, PaintEventArgs e)
		{

		}

		private void BtnDelete_Click(object sender, EventArgs e)
		{
			if (this.dgvCompanies.SelectedRows.Count > 0)
			{
				var id = int.Parse(this.dgvCompanies.SelectedRows[0].Cells[0].Value.ToString());

				companyService.Delete(id);
				LoadCompanies();
			}
		}

		private void BtnEdit_Click(object sender, EventArgs e)
		{
			if (this.dgvCompanies.SelectedRows.Count > 0)
			{
				 dgvSelectedCompanyId = int.Parse(this.dgvCompanies.SelectedRows[0].Cells[0].Value.ToString());
								
			}
			frmCompanyEdit.Show();
		}
	}
}
