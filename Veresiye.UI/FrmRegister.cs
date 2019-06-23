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

	public partial class FrmRegister : Form
	{
		private readonly FrmLogin frmLogin;
		public readonly IUserService userService;
		public FrmRegister(IUserService userService,FrmLogin frmLogin)
		{
			this.frmLogin = frmLogin;
			this.userService = userService;
			InitializeComponent();
		}

		private void FrmRegister_Load(object sender, EventArgs e)
		{

		}
		
		private void BtnSignIn_Click(object sender, EventArgs e)
		{
			if (string.IsNullOrEmpty(txtUserName.Text))
			{
				MessageBox.Show("Kullanıcı Adı Girmediniz.");
				return;
			}
			else if (string.IsNullOrEmpty(txtPassword.Text))
			{
				MessageBox.Show("Parola Girmediniz.");
				return;
			}
			else if (string.IsNullOrEmpty(txtComfirmPassword.Text))
			{
				MessageBox.Show("Parolanızı Bir Kez Daha Giriniz.");
				return;
			}
			else if (string.IsNullOrEmpty(txtCompanyName.Text))
			{
				MessageBox.Show("Firma Adı Girmediniz");
				return;
			}
			else if (string.IsNullOrEmpty(txtPhone.Text))
			{
				MessageBox.Show("Telefon Numarası Girmediniz");
				return;
			}
			else if (string.IsNullOrEmpty(txtCity.Text))
			{
				MessageBox.Show("Şehir Girmediniz");
				return;
			}
			else if (string.IsNullOrEmpty(txtRegion.Text))
			{
				MessageBox.Show("Bölge Girmediniz");
				return;
			}
			else if (txtPassword.Text != txtComfirmPassword.Text)
			{
				MessageBox.Show("Girdiğiniz Parolalar Birbiriyle Eşleşmiyor");
				return;
			}


			var user = new User();
			user.UserName = txtUserName.Text;
			user.Password = txtPassword.Text;
			user.CompanyName = txtCompanyName.Text;
			user.Phone = txtPhone.Text;
			user.City = txtCity.Text;
			user.Region = txtRegion.Text;
			

			var status = userService.Register(user);
			switch (status)
			{
				case RegisterStatus.Success:
					MessageBox.Show("Üyelik İşlemi Başarıyla Tamamlandı.");
					this.Close();
					frmLogin.Show();
					
					break;
				case RegisterStatus.InvalidField:
					MessageBox.Show("Kullanıcı Adı Boş Olamaz.");
					this.Close();
					break;
				case RegisterStatus.UserAlreadyExists:
					MessageBox.Show("Bu Kullanıcı Adı Zaten Kullanılıyor.");
					this.Close();
					break;
				
			}

		}

		private void FrmRegister_FormClosing(object sender, FormClosingEventArgs e)
		{
			e.Cancel = true;
			this.Hide();
		}

		private void btnQuit_Click(object sender, EventArgs e)
		{
			this.Hide();
		}
	}
}
