using System;
using System.Windows.Forms;
using BLL;
using Entities;

namespace Presentation
{
	public partial class FrmLogin : Form
	{
		private UsuarioBLL ubll;



		private void linkLabel2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
		{
			//enter your code for forget password case 
			MessageBox.Show("Under development");
		}

		private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
		{
			//Enter your code for registration form of your choice 
			MessageBox.Show("Under development");
		}
		public FrmLogin()
		{
			InitializeComponent();
		}

		//this is count 
		int cont = 0;

		private void Button1_Click(object sender, EventArgs e)
		{
			//define local variables from the user inputs 
			string user = txtNombreUsuario.Text;
			string pass = txtPassword.Text;
			//
			if (!string.IsNullOrEmpty(user) && !string.IsNullOrEmpty(pass))
			{

				try
				{
					if (++cont < 3)
					{

						//check if eligible to be logged in 
						if (ubll.IsLoggedIn(user, pass))
						{
							MessageBox.Show($"Bienvenido {user}");
							FrmPrincipal frm = new FrmPrincipal();
							frm.Show();
							this.Close();
						}
						else
						{
							//show default login error message 
							MessageBox.Show("Login Error!");
						}
					}
					else
					{
						MessageBox.Show("Has excedido el limite de intentos!");
						this.Close();
					}
				}
				catch (Exception ex)
				{

					MessageBox.Show($"Error {ex.Message}");
				}
			}
			else
			{
				MessageBox.Show("Hay campos vacios verifica");
			}
		}

		private void FrmLogin_Load(object sender, EventArgs e)
		{
			try
			{
				ubll = new UsuarioBLL();
			}
			catch (Exception ex)
			{

				MessageBox.Show(ex.Message);
			}
		}
	}
}
