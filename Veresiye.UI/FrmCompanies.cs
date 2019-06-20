﻿using System;
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
		private readonly FrmCompanyAdd frmCompanyAdd;
		private readonly ICompanyService companyService;
		public FrmCompanies(ICompanyService companyService , FrmCompanyAdd frmCompanyAdd)
		{
			this.frmCompanyAdd = frmCompanyAdd;
			this.companyService = companyService;
			InitializeComponent();
			this.frmCompanyAdd.MdiParent = this.MdiParent;
			this.frmCompanyAdd.MasterForm = this;
			
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
	}
}