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
	
	public partial class FrmLogin : Form
	{
		public FrmMain MasterForm { get; set; }
		private readonly IUserService userService;
		public FrmLogin(IUserService userService)
		{
			this.userService = userService;
			InitializeComponent();
		}

		private void BtnLogin_Click(object sender, EventArgs e)
		{
			if (string.IsNullOrEmpty(txtUserName.Text))
			{
				MessageBox.Show("Kullanıcı Adı Alanı Boş Bırakılamaz");
				return;
			}
			else if (string.IsNullOrEmpty(txtPassword.Text))
			{
				MessageBox.Show("Parola Alanı Boş Bırakılamaz");
				return;
			}
			
			var username = txtUserName.Text;
			var password = txtPassword.Text;
			var user = userService.Login(username, password);
			if (user!=null)
			{
				MasterForm.ShowCompanies();
				this.Close();

			}else
			{
				MessageBox.Show("Giriş İşlemi Başarılı Değil");
			}
			
				
		
		}

		
	}
}
