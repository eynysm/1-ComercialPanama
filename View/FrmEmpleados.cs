using System;
using System.Drawing;
using System.IO;
using System.Windows.Forms;
using BLL;
using Entities;

namespace Presentation
{
    public partial class FrmEmpleados : Form
    {
        private EmpleadoBLL ebll;
        public string RutaFoto { get; set; }


        private void FillEmpleado()
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

		private void FillGridLike(string Id_empleado)
		{
			try
			{
				dgEmpleados.DataSource = ebll.GetByLikeId_empleado(Id_empleado);
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

        public void LoadPhoto()
        {
            try
            {
                OpenFileDialog openFileDialog1 = new OpenFileDialog
                {
                    Title = "Seleccione la Imagen",
                    Filter = "Imagenes|*.jpg;*.png*.jpeg;*.gif"
                };

                if (openFileDialog1.ShowDialog() != DialogResult.Cancel)
                {
                    RutaFoto = openFileDialog1.FileName;
                    pbFoto.Image = Image.FromFile(RutaFoto);
                    string nombreImagen = string.Format("foto{0:yyyyMMdd_HHmmss}", DateTime.Now) + Path.GetExtension(RutaFoto);
                    string destino = Path.Combine(Application.StartupPath, "..\\..\\Images\\"+nombreImagen);
                    File.Copy(openFileDialog1.FileName, destino);
                    RutaFoto = nombreImagen;
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
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
                    cbxGenero.SelectedItem = ob.Genero_empleado;
                    pbFoto.Image = Image.FromFile(Path.Combine(Application.StartupPath, "..\\..\\Images\\" + ob.Foto_empleado));
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
                {
                    ob.Id_empleado = txtId.Text;
                    ob.Nombre_empleado = txtNombre.Text;
                    ob.Apellido_empleado = txtApellido.Text;
                    ob.Direccion_empleado = txtDireccion.Text;
                    ob.Telefono_empleado = txtTelefono.Text;
                    ob.Genero_empleado = cbxGenero.SelectedItem.ToString();
                    ob.Foto_empleado = RutaFoto;
                    ob.Fecha_ingreso_empleado = Convert.ToDateTime(dtpFechaIngreso.Text);
                    ob.Correo_empleado = txtCorreo.Text;
                    ebll.Save(ob);
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

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnAgregarFoto_Click(object sender, EventArgs e)
        {
            LoadPhoto();
            MessageBox.Show(RutaFoto);
        }

		private void panel2_Paint(object sender, PaintEventArgs e)
		{

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
	}
}
