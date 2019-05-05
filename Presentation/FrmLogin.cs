using System;
using System.Windows.Forms;
using BLL;

namespace Presentation
{
    public partial class FrmLogin : Form
    {
        private UsuarioBLL ebll;



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

        private void Button1_Click(object sender, EventArgs e)
        {
            //define local variables from the user inputs 
            string user = txtNombreUsuario.Text;
            string pass = txtPassword.Text;
            if (!string.IsNullOrEmpty(user) && !string.IsNullOrEmpty(pass))
            {

                try
                {
                    //check if eligible to be logged in 
                    if (ebll.IsLoggedIn(user, pass))
                    {
                        MessageBox.Show("You are logged in successfully");
                    }
                    else
                    {
                        //show default login error message 
                        MessageBox.Show("Login Error!");
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

        private void LinkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            new FrmUsuario().Show();
        }

        private void FrmLogin_Load(object sender, EventArgs e)
        {

        }
    }
}
