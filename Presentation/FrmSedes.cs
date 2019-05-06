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
	public partial class FrmSedes : Form
	{
		public FrmSedes()
		{
			InitializeComponent();
		}

		private SedeBLL sbll;
		private EmpleadoBLL ebll;

		private void Fillcombos()
		{
			cbxResponsable.DataSource = ebll.GetAll();
			cbxResponsable.DisplayMember = "Nombre_empleado";
			cbxResponsable.ValueMember = "Id_empleado";
			cbxResponsable.Refresh(); 
			
		}

		private void FillGrid()
		{
			try
			{
				dgSedes.DataSource = sbll.GetAll(); dgSedes.Refresh();
			}
			catch (Exception ex)
			{

				MessageBox.Show(ex.Message);
			}
		}

		private void ClearText()
		{
			txtNit.Text = "";
			txtNombre.Text = "";
			txtDireccion.Text = "";
			txtTelefono.Text = "";
			cbxResponsable.Text = "";
		}

		private void FillData(string x)
		{
			try
			{
				var ob = sbll.GetByNit_Sede(x);
				if (ob != null)
				{
					txtNit.Text = ob.Nit_sede;
					txtNombre.Text = ob.Nombre_sede;
					txtDireccion.Text = ob.Direccion_sede;
					txtTelefono.Text = ob.Telefono_sede;
					cbxResponsable.SelectedValue = ob.Id_empleado;
				}
			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.Message);
			}
		}

		private void Save()
		{
			try
			{
				Sede ob = new Sede();
				if (txtNit.Text.Trim() != "")
				{
					ob.Nit_sede = txtNit.Text;
					ob.Nombre_sede = txtNombre.Text;
					ob.Direccion_sede = txtDireccion.Text;
					ob.Direccion_sede = txtTelefono.Text;
					ob.Id_empleado = cbxResponsable.SelectedValue.ToString();

					sbll.Save(ob);
					FillGrid();
					ClearText();
					MessageBox.Show("Los datos han sido almacenados correctamente");
				}				
			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.Message);
			}
		}

		public void Delete()
		{
			try
			{
				if (txtNit.Text.Trim() != "")
				{
					sbll.Delete(txtNit.Text);
					FillGrid();
					ClearText();
					MessageBox.Show("El registro ha sido elimininado correctamente");
				}
			}
			catch (Exception ex)
			{

				MessageBox.Show(ex.Message);
			}
		}

		private void btnAgregar_Click(object sender, EventArgs e)
		{
			Save(); 
		}

		private void btnActualizar_Click(object sender, EventArgs e)
		{
			ClearText(); 
		}

		private void btnEliminar_Click(object sender, EventArgs e)
		{
			Delete(); 
		}

		private void FrmSedes_Load(object sender, EventArgs e)
		{
			try
			{
				sbll = new SedeBLL();
				ebll = new EmpleadoBLL(); 
				FillGrid();
				Fillcombos(); 
			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.Message);
			}
		}


		private void dgSedes_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
		{
			if (e.RowIndex > -1)
			{
				FillData(Convert.ToString(dgSedes[0, e.RowIndex].Value));
			}
		}

		private void dgSedes_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
		{
			if (e.RowIndex > -1)
			{
				FillData(Convert.ToString(dgSedes[0, e.RowIndex].Value));
			}
		}


	}
}
