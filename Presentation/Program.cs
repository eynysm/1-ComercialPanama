using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Presentation
{
	static class Program
	{
		/// <summary>
		/// Punto de entrada principal para la aplicación.
		/// </summary>
		[STAThread]
		static void Main()
		{
			Application.EnableVisualStyles();
			Application.SetCompatibleTextRenderingDefault(false);
			FrmEmpleados frmLogin = new FrmEmpleados();
			frmLogin.FormClosed += FrmLogin_closed;
			frmLogin.Show();
			Application.Run();
		}
		//this method is remove from page satck overflow
		private static void FrmLogin_closed(object sender, FormClosedEventArgs e)
		{
			((Form)sender).FormClosed -= FrmLogin_closed;
			if (Application.OpenForms.Count == 0)
			{
				Application.ExitThread();
			}
			else
			{
				Application.OpenForms[0].FormClosed += FrmLogin_closed;
			}
		}
	}
}
