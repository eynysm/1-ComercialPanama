using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Entities;
using BLL; 

namespace Presentation
{
	public partial class FrmEmpleados : Form
	{
		private EmpleadoBLL ebll;

		private void FillSede()
		{
			dgEmpleados.DataSource = ebll.GetAll();
			dgEmpleados.Refresh(); ;
		}

		private void FillGrid()
		{
			try
			{
				dgEmpleados.DataSource = ebll.GetAll();
				dgEmpleados.Refresh();
			}
			catch (Exception ex)
			{

				MessageBox.Show(ex.Message);
			}
		}
		private void ClearText()
		{
			txtId.Text = "";
			txtNombre.Text = "";
			txtApellido.Text = "";
			txtTelefono.Text = "";
			txtDireccion.Text = "";
			txtCorreo.Text = "";
			dtpFechaIngreso.Text = "";
			cbxGenero.Text = "";
		}

		private void FillData(string x)
		{
			try
			{
				var ob = ebll.GetById_empleado(x);
				if (ob != null)
				{
					txtId.Text = ob.Id_empleado;
					txtNombre.Text = ob.Nombre_empleado;
					txtApellido.Text = ob.Apellido_empleado;
					txtDireccion.Text = ob.Direccion_empleado;
					txtTelefono.Text = ob.Telefono_empleado;
					cbxGenero.SelectedValue = ob.Genero_empleado;
					pbFoto.Text = ob.Foto_empleado; 
					dtpFechaIngreso.Text = ob.Fecha_ingreso_empleado.ToString();
					txtCorreo.Text = ob.Correo_empleado;
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
				Empleado ob = new Empleado();
				if (txtId.Text.Trim() != "")

				txtId.Text = ob.Id_empleado;
				txtNombre.Text = ob.Nombre_empleado;
				txtApellido.Text = ob.Apellido_empleado;
				txtDireccion.Text = ob.Direccion_empleado;
				txtTelefono.Text = ob.Telefono_empleado;
				cbxGenero.SelectedValue = ob.Genero_empleado;
				pbFoto.Text = ob.Foto_empleado;
				dtpFechaIngreso.Text = ob.Fecha_ingreso_empleado.ToString();
				txtCorreo.Text = ob.Correo_empleado;

				ebll.Save(ob);
				FillGrid();
				ClearText();
				MessageBox.Show("Los datos han sido almacenados correctamente");

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
				if (txtId.Text.Trim() != "")
				{
					ebll.Delete(txtId.Text);
					FillGrid();
					ClearText();
					MessageBox.Show("El registro ha sido eliminado correctamente");
				}
			}
			catch (Exception ex)
			{

				MessageBox.Show(ex.Message);
			}
		}


		public FrmEmpleados()
		{
			InitializeComponent();
		}

		private void FrmEmpleados_Load(object sender, EventArgs e)
		{
			try
			{
				ebll = new EmpleadoBLL();
				FillGrid();
			}
			catch (Exception ex)
			{

				MessageBox.Show(ex.Message);
			}
		}

		private void dgSede_CellContentClick(object sender, DataGridViewCellEventArgs e)
		{

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

		private void dgEmpleados_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
		{
			if (e.RowIndex > -1)
			{
				FillData(Convert.ToString(dgEmpleados[0, e.RowIndex].Value));
			}
		}

		private void dgEmpleados_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
		{
			if (e.RowIndex > -1)
			{
				FillData(Convert.ToString(dgEmpleados[0, e.RowIndex].Value));
			}
		}

		private void dtpFechaIngreso_ValueChanged(object sender, EventArgs e)
		{

		}
	}
}
