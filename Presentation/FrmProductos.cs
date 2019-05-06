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
	public partial class FrmProductos : Form
	{
		public FrmProductos()
		{
			InitializeComponent();
		}

		private ProductoBLL pbll;
		private EmpleadoBLL ebll;
		private SedeBLL sbll;
		private CategoriaBLL cbll; 



		private void Fillcombos()
		{
			cbxResponsable.DataSource = ebll.GetAll();
			cbxResponsable.DisplayMember = "Nombre_empleado";
			cbxResponsable.ValueMember = "Id_empleado";
			cbxResponsable.Refresh();

			cbxSede.DataSource = sbll.GetAll();
			cbxSede.DisplayMember = "Nombre_sede";
			cbxSede.ValueMember = "Nit_sede";
			cbxSede.Refresh();

			cbxCategoria.DataSource = cbll.GetAll();
			cbxCategoria.DisplayMember = "Nombre_categoria";
			cbxCategoria.ValueMember = "Id_categoria";
			cbxCategoria.Refresh();

		}

		private void FillGrid()
		{
			try
			{
				dgProductos.DataSource = pbll.GetAll();
				dgProductos.Refresh();
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
			txtPrecioVenta.Text = "";
			txtPrecioCompra.Text = "";
			dtpFechaIngreso.Text = "";
			cbxResponsable.Text = "";
			cbxSede.Text = "";
			cbxCategoria.Text = "";

		}

		private void FillData(string x)
		{
			try
			{
				var ob = pbll.GetById_producto(x);
				if (ob != null)
				{
					txtId.Text = ob.Id_categoria.ToString();
					txtNombre.Text = ob.Nombre_producto.ToString();
					txtPrecioVenta.Text = ob.Precio_venta_producto.ToString();
					txtPrecioCompra.Text = ob.Precio_compra_producto.ToString();
					dtpFechaIngreso.Text = ob.Fecha_ingreso_producto.ToString();
					cbxResponsable.SelectedValue = ob.Id_empleado.ToString();
					cbxSede.SelectedValue = ob.Nit_sede.ToString();
					cbxCategoria.SelectedValue = ob.Id_categoria.ToString();
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
				Producto ob = new Producto();
				if (txtId.Text.Trim() != "")
				{
					ob.Id_producto = Convert.ToString(txtId.Text);
					ob.Nombre_producto = Convert.ToString(txtNombre.Text);
					ob.Precio_venta_producto = Convert.ToDecimal(txtPrecioVenta.Text);
					ob.Precio_compra_producto = Convert.ToDecimal(txtPrecioCompra.Text);
					ob.Fecha_ingreso_producto = Convert.ToDateTime(dtpFechaIngreso.Text);
					ob.Id_empleado = cbxResponsable.SelectedValue.ToString(); 
					ob.Nit_sede = cbxSede.SelectedValue.ToString(); 
					ob.Id_categoria = cbxCategoria.SelectedValue.ToString(); 
					pbll.Save(ob);
					FillGrid();
					ClearText();
					MessageBox.Show("Los Datos han sido almacenados correctamente");
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
				if (txtId.Text.Trim() != "")
				{
					pbll.Delete(txtId.Text);
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

		private void txtId_TextChanged(object sender, EventArgs e)
		{
		
		}

		private void FrmProductos_Load(object sender, EventArgs e)
		{
			try
			{
				pbll = new ProductoBLL();
				ebll = new EmpleadoBLL();
				sbll = new SedeBLL ();
				cbll = new CategoriaBLL ();
		FillGrid();
				Fillcombos(); 
			}
			catch (Exception ex)
			{

				MessageBox.Show(ex.Message);
			}
		}

		private void dgProductos_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
		{
			if (e.RowIndex > -1)
			{
				FillData(Convert.ToString(dgProductos[0, e.RowIndex].Value));
			}
		}

		private void dgProductos_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
		{
			if (e.RowIndex > -1)
			{
				FillData(Convert.ToString(dgProductos[0, e.RowIndex].Value));
			}
		}

		private void btnAgregar_Click_1(object sender, EventArgs e)
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
	}
}
