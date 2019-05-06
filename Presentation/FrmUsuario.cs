using System;
using System.Drawing;
using System.IO;
using System.Windows.Forms;
using BLL;
using Entities;

namespace Presentation
{
    public partial class FrmUsuario : Form
    {
        private UsuarioBLL ubll;
		private EmpleadoBLL ebll; 
        public string RutaFoto { get; set; }


		private void Fillcombos()
		{
			cbxEmpleado.DataSource = ebll.GetAll();
			cbxEmpleado.ValueMember = "Id_empleado";
			cbxEmpleado.Refresh();

		}

		private void FillGrid()
        {
            try
            {
                dgUsuario.DataSource = ubll.GetAll();
                dgUsuario.Refresh();
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }
        private void ClearText()
        {
            txtId.Text = "";
			cbxEmpleado.Text = "";
			txtNombreUsuario.Text = "";
            txtPassword.Text = "";
            txtConfirmarPassword.Text = "";
            txtCorreo.Text = "";
        }


        private void FillData(string x)
        {
            try
            {
                var ob = ubll.GetById_Usuario(x);
                if (ob != null)
                {
                    txtId.Text = ob.Id_usuario;
					cbxEmpleado.SelectedValue = ob.Id_empleado;
					txtNombreUsuario.Text = ob.Nombre_usuario;
                    txtPassword.Text = ob.Password;              
                    txtCorreo.Text = ob.Correo_usuario;
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
                Usuario ob = new Usuario();

                if (txtId.Text.Trim() != "")
                {
                    if (txtPassword.Text == txtConfirmarPassword.Text)
                    {

                        ob.Id_usuario = txtId.Text;
                        ob.Id_empleado = cbxEmpleado.SelectedValue.ToString();
                        ob.Nombre_usuario = txtNombreUsuario.Text;
                        ob.Password = txtPassword.Text;
                        ob.Correo_usuario = txtCorreo.Text;
                    }
                    else
                    {
                        MessageBox.Show("Paswword Incorrectos") ;
                    }

                    ubll.Save(ob);
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
                if (txtId.Text.Trim() != "")
                {
                    ubll.Delete(txtId.Text);
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


        public FrmUsuario()
        {
            InitializeComponent();
        }

        private void dgUsuarios_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex > -1)
            {
                FillData(Convert.ToString(dgUsuario[0, e.RowIndex].Value));
            }
        }

        private void dgUsuarios_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex > -1)
            {
                FillData(Convert.ToString(dgUsuario[0, e.RowIndex].Value));
            }
        }

        private void dtpFechaIngreso_ValueChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

		private void FrmUsuario_Load(object sender, EventArgs e)
		{
			try
			{
				ubll = new UsuarioBLL();
				ebll = new EmpleadoBLL(); 
				FillGrid();
				Fillcombos();
			}
			catch (Exception ex)
			{

				MessageBox.Show(ex.Message);
			}
		}

		private void cbxEmpleado_SelectedIndexChanged(object sender, EventArgs e)
		{

		}
	}
}
