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
		public readonly ICompanyService _companyService;

		public FrmMain(ICompanyService companyService)
		{
			this._companyService = companyService;
			InitializeComponent();
		}

		private void FrmMain_Load(object sender, EventArgs e)
		{
			MessageBox.Show(_companyService.GetAll().Count().ToString());
		}
	}
}
