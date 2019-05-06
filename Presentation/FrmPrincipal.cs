using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Presentation
{
	public partial class FrmPrincipal : Form
	{
		public FrmPrincipal()
		{
			InitializeComponent();
		}


		private void AbrirFormHija(object formhija)
		{
			if (this.panelcontenedor.Controls.Count > 0)
				this.panelcontenedor.Controls.RemoveAt(0);
			Form fh = formhija as Form;
			fh.TopLevel = false;
			fh.Parent = panelcontenedor;
			fh.Location = new Point((panelcontenedor.Width - fh.Width) / 2, (panelcontenedor.Height - fh.Height) / 2);
			this.panelcontenedor.Controls.Add(fh);
			this.panelcontenedor.Tag = fh;
			fh.Show();

		}


		private void btnSede_Click(object sender, EventArgs e)
		{
			AbrirFormHija(new FrmSedes());
		}

		private void btnCategorias_Click(object sender, EventArgs e)
		{
			AbrirFormHija(new FrmCategoria());
		}


		private void btnEmpleados_Click(object sender, EventArgs e)
		{
			AbrirFormHija(new FrmEmpleados());
		}

		private void FrmPrincipal_Load(object sender, EventArgs e)
		{

		}

		private void btnProductos_Click(object sender, EventArgs e)
		{
			AbrirFormHija(new FrmProductos());
		}
	}
}
