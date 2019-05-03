using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BLL;
using Entities;

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

        private void LinkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            new FrmUsuario().Show();
        }

        private void FrmLogin_Load(object sender, EventArgs e)
        {

        }
    }
}
