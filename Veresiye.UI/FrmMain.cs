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
	
	public partial class FrmMain : Form
	{
		public readonly IUserService _userService;
		private readonly FrmRegister frmRegister;
		private readonly FrmCompanies frmCompanies;
		public FrmMain(IUserService userService , FrmRegister frmRegister,FrmCompanies frmCompanies)
		{
			this.frmCompanies = frmCompanies;
			this.frmRegister = frmRegister;
			this._userService = userService;
			InitializeComponent();
			this.frmRegister.MdiParent = this;
		}

		private void FrmMain_Load(object sender, EventArgs e)
		{
			
			int userCount = _userService.GetAll().Count();
			if (userCount>=0)
			{
				frmRegister.Show();				
				frmRegister.FormClosed += FrmRegister_FormClosed;
			}
		}

		private void FrmRegister_FormClosed(object sender, FormClosedEventArgs e)
		{
			frmCompanies.Show();
		}
	}
}
