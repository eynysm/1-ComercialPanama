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
	public partial class FrmCategoria : Form
	{
		
		private CategoriaBLL c;


		private void FillGrid()
		{
			try
			{
				dgSede.DataSource = c.GetAll();
				dgSede.Refresh();
			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.Message);
			}
		}

		private void FillGridLike(string Id_categoria)
		{
			try
			{
				dgSede.DataSource = c.GetByLikeId_categoria(Id_categoria);
				dgSede.Refresh();
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
		}

		private void FillData(string x)
		{
			try
			{
				var ob = c.GetById_categoria(x);
				if (ob != null)
				{
					txtId.Text = ob.Id_categoria;
					txtNombre.Text = ob.Nombre_categoria;
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
				Categoria ob = new Categoria();
				if (txtId.Text.Trim() != "")
					ob.Id_categoria = txtId.Text;
				ob.Nombre_categoria = txtNombre.Text;

				c.Save(ob);
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
					c.Delete(txtId.Text);
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

		public FrmCategoria()
		{
			InitializeComponent();
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

		private void FrmCategoria_Load(object sender, EventArgs e)
		{
			try
			{
				c = new CategoriaBLL();
				FillGrid();
			}
			catch (Exception ex)
			{

				MessageBox.Show(ex.Message);
			}
		}

		private void dgSede_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
		{
			if (e.RowIndex > -1)
			{
				FillData(Convert.ToString(dgSede[0, e.RowIndex].Value));
			}
		}

		private void dgSede_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
		{
			if (e.RowIndex > -1)
			{
				FillData(Convert.ToString(dgSede[0, e.RowIndex].Value));
			}
		}

		private void txtId_TextChanged(object sender, EventArgs e)
		{
			try
			{
				if (!string.IsNullOrEmpty(txtId.Text))
				{
					FillGridLike(txtId.Text);
				}
				
			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.Message);
			}
		}

		private void btnCategorias_Click(object sender, EventArgs e)
		{
			this.Hide();

			FrmCategoria frm = new FrmCategoria();

			frm.Show();
		}

		private void panel1_Paint(object sender, PaintEventArgs e)
		{

		}
	}
}
