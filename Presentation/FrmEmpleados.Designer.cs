namespace Presentation
{
	partial class FrmEmpleados
	{
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Windows Form Designer generated code

		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			this.txtDireccion = new System.Windows.Forms.TextBox();
			this.label8 = new System.Windows.Forms.Label();
			this.label5 = new System.Windows.Forms.Label();
			this.label6 = new System.Windows.Forms.Label();
			this.txtTelefono = new System.Windows.Forms.TextBox();
			this.label7 = new System.Windows.Forms.Label();
			this.txtApellido = new System.Windows.Forms.TextBox();
			this.label3 = new System.Windows.Forms.Label();
			this.label4 = new System.Windows.Forms.Label();
			this.txtNombre = new System.Windows.Forms.TextBox();
			this.btnEliminar = new System.Windows.Forms.Button();
			this.btnActualizar = new System.Windows.Forms.Button();
			this.btnAgregar = new System.Windows.Forms.Button();
			this.dgEmpleados = new System.Windows.Forms.DataGridView();
			this.txtId = new System.Windows.Forms.TextBox();
			this.label2 = new System.Windows.Forms.Label();
			this.label1 = new System.Windows.Forms.Label();
			this.panel2 = new System.Windows.Forms.Panel();
			this.panel1 = new System.Windows.Forms.Panel();
			this.btnProductos = new System.Windows.Forms.Button();
			this.btnCategorias = new System.Windows.Forms.Button();
			this.btnEmpleados = new System.Windows.Forms.Button();
			this.btnSede = new System.Windows.Forms.Button();
			this.txtCorreo = new System.Windows.Forms.TextBox();
			this.dtpFechaIngreso = new System.Windows.Forms.DateTimePicker();
			this.cbxGenero = new System.Windows.Forms.ComboBox();
			this.pbFoto = new System.Windows.Forms.PictureBox();
			this.btnAgregarFoto = new System.Windows.Forms.Button();
			this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Column7 = new System.Windows.Forms.DataGridViewImageColumn();
			this.Column8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Column9 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			((System.ComponentModel.ISupportInitialize)(this.dgEmpleados)).BeginInit();
			this.panel1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.pbFoto)).BeginInit();
			this.SuspendLayout();
			// 
			// txtDireccion
			// 
			this.txtDireccion.Location = new System.Drawing.Point(339, 213);
			this.txtDireccion.Name = "txtDireccion";
			this.txtDireccion.Size = new System.Drawing.Size(136, 20);
			this.txtDireccion.TabIndex = 63;
			// 
			// label8
			// 
			this.label8.AutoSize = true;
			this.label8.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label8.Location = new System.Drawing.Point(236, 216);
			this.label8.Name = "label8";
			this.label8.Size = new System.Drawing.Size(62, 17);
			this.label8.TabIndex = 62;
			this.label8.Text = "Direccion";
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label5.Location = new System.Drawing.Point(522, 171);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(89, 17);
			this.label5.TabIndex = 58;
			this.label5.Text = "Fecha Ingreso";
			// 
			// label6
			// 
			this.label6.AutoSize = true;
			this.label6.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label6.Location = new System.Drawing.Point(520, 127);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(51, 17);
			this.label6.TabIndex = 57;
			this.label6.Text = "Género";
			// 
			// txtTelefono
			// 
			this.txtTelefono.Location = new System.Drawing.Point(615, 79);
			this.txtTelefono.Name = "txtTelefono";
			this.txtTelefono.Size = new System.Drawing.Size(136, 20);
			this.txtTelefono.TabIndex = 56;
			// 
			// label7
			// 
			this.label7.AutoSize = true;
			this.label7.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label7.Location = new System.Drawing.Point(522, 82);
			this.label7.Name = "label7";
			this.label7.Size = new System.Drawing.Size(58, 17);
			this.label7.TabIndex = 55;
			this.label7.Text = "Télefono";
			// 
			// txtApellido
			// 
			this.txtApellido.Location = new System.Drawing.Point(339, 168);
			this.txtApellido.Name = "txtApellido";
			this.txtApellido.Size = new System.Drawing.Size(136, 20);
			this.txtApellido.TabIndex = 54;
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label3.Location = new System.Drawing.Point(522, 213);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(49, 17);
			this.label3.TabIndex = 53;
			this.label3.Text = "Correo";
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label4.Location = new System.Drawing.Point(236, 171);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(56, 17);
			this.label4.TabIndex = 52;
			this.label4.Text = "Apellido";
			// 
			// txtNombre
			// 
			this.txtNombre.Location = new System.Drawing.Point(339, 124);
			this.txtNombre.Name = "txtNombre";
			this.txtNombre.Size = new System.Drawing.Size(136, 20);
			this.txtNombre.TabIndex = 51;
			// 
			// btnEliminar
			// 
			this.btnEliminar.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnEliminar.Location = new System.Drawing.Point(600, 270);
			this.btnEliminar.Name = "btnEliminar";
			this.btnEliminar.Size = new System.Drawing.Size(109, 40);
			this.btnEliminar.TabIndex = 50;
			this.btnEliminar.Text = "Eliminar";
			this.btnEliminar.UseVisualStyleBackColor = true;
			this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
			// 
			// btnActualizar
			// 
			this.btnActualizar.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnActualizar.Location = new System.Drawing.Point(468, 270);
			this.btnActualizar.Name = "btnActualizar";
			this.btnActualizar.Size = new System.Drawing.Size(109, 40);
			this.btnActualizar.TabIndex = 49;
			this.btnActualizar.Text = "Actualizar";
			this.btnActualizar.UseVisualStyleBackColor = true;
			this.btnActualizar.Click += new System.EventHandler(this.btnActualizar_Click);
			// 
			// btnAgregar
			// 
			this.btnAgregar.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnAgregar.Location = new System.Drawing.Point(339, 270);
			this.btnAgregar.Name = "btnAgregar";
			this.btnAgregar.Size = new System.Drawing.Size(109, 40);
			this.btnAgregar.TabIndex = 48;
			this.btnAgregar.Text = "Agregar";
			this.btnAgregar.UseVisualStyleBackColor = true;
			this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
			// 
			// dgEmpleados
			// 
			this.dgEmpleados.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dgEmpleados.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4,
            this.Column5,
            this.Column6,
            this.Column7,
            this.Column8,
            this.Column9});
			this.dgEmpleados.Location = new System.Drawing.Point(263, 341);
			this.dgEmpleados.Name = "dgEmpleados";
			this.dgEmpleados.Size = new System.Drawing.Size(511, 151);
			this.dgEmpleados.TabIndex = 47;
			this.dgEmpleados.CellContentDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgEmpleados_CellContentDoubleClick);
			this.dgEmpleados.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgEmpleados_CellDoubleClick);
			// 
			// txtId
			// 
			this.txtId.Location = new System.Drawing.Point(339, 79);
			this.txtId.Name = "txtId";
			this.txtId.Size = new System.Drawing.Size(136, 20);
			this.txtId.TabIndex = 46;
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label2.Location = new System.Drawing.Point(236, 127);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(57, 17);
			this.label2.TabIndex = 45;
			this.label2.Text = "Nombre";
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.Location = new System.Drawing.Point(236, 86);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(19, 17);
			this.label1.TabIndex = 44;
			this.label1.Text = "Id";
			// 
			// panel2
			// 
			this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(160)))), ((int)(((byte)(234)))));
			this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
			this.panel2.Location = new System.Drawing.Point(194, 0);
			this.panel2.Name = "panel2";
			this.panel2.Size = new System.Drawing.Size(778, 43);
			this.panel2.TabIndex = 43;
			// 
			// panel1
			// 
			this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(160)))), ((int)(((byte)(234)))));
			this.panel1.Controls.Add(this.btnProductos);
			this.panel1.Controls.Add(this.btnCategorias);
			this.panel1.Controls.Add(this.btnEmpleados);
			this.panel1.Controls.Add(this.btnSede);
			this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
			this.panel1.Location = new System.Drawing.Point(0, 0);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(194, 518);
			this.panel1.TabIndex = 42;
			// 
			// btnProductos
			// 
			this.btnProductos.FlatAppearance.BorderSize = 0;
			this.btnProductos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnProductos.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnProductos.ForeColor = System.Drawing.Color.White;
			this.btnProductos.Image = global::Presentation.Properties.Resources.box;
			this.btnProductos.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.btnProductos.Location = new System.Drawing.Point(12, 314);
			this.btnProductos.Name = "btnProductos";
			this.btnProductos.Size = new System.Drawing.Size(194, 44);
			this.btnProductos.TabIndex = 6;
			this.btnProductos.Text = "Productos";
			this.btnProductos.UseVisualStyleBackColor = true;
			// 
			// btnCategorias
			// 
			this.btnCategorias.FlatAppearance.BorderSize = 0;
			this.btnCategorias.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnCategorias.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnCategorias.ForeColor = System.Drawing.Color.White;
			this.btnCategorias.Image = global::Presentation.Properties.Resources.price_tag;
			this.btnCategorias.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.btnCategorias.Location = new System.Drawing.Point(12, 250);
			this.btnCategorias.Name = "btnCategorias";
			this.btnCategorias.Size = new System.Drawing.Size(194, 44);
			this.btnCategorias.TabIndex = 5;
			this.btnCategorias.Text = "Categorias";
			this.btnCategorias.UseVisualStyleBackColor = true;
			// 
			// btnEmpleados
			// 
			this.btnEmpleados.FlatAppearance.BorderSize = 0;
			this.btnEmpleados.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnEmpleados.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnEmpleados.ForeColor = System.Drawing.Color.White;
			this.btnEmpleados.Image = global::Presentation.Properties.Resources.team__1_;
			this.btnEmpleados.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.btnEmpleados.Location = new System.Drawing.Point(12, 184);
			this.btnEmpleados.Name = "btnEmpleados";
			this.btnEmpleados.Size = new System.Drawing.Size(194, 44);
			this.btnEmpleados.TabIndex = 4;
			this.btnEmpleados.Text = "Empleados";
			this.btnEmpleados.UseVisualStyleBackColor = true;
			// 
			// btnSede
			// 
			this.btnSede.FlatAppearance.BorderSize = 0;
			this.btnSede.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnSede.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnSede.ForeColor = System.Drawing.Color.White;
			this.btnSede.Image = global::Presentation.Properties.Resources.placeholder__3_;
			this.btnSede.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.btnSede.Location = new System.Drawing.Point(12, 118);
			this.btnSede.Name = "btnSede";
			this.btnSede.Size = new System.Drawing.Size(194, 44);
			this.btnSede.TabIndex = 3;
			this.btnSede.Text = "Sedes";
			this.btnSede.UseVisualStyleBackColor = true;
			// 
			// txtCorreo
			// 
			this.txtCorreo.Location = new System.Drawing.Point(615, 213);
			this.txtCorreo.Name = "txtCorreo";
			this.txtCorreo.Size = new System.Drawing.Size(136, 20);
			this.txtCorreo.TabIndex = 64;
			// 
			// dtpFechaIngreso
			// 
			this.dtpFechaIngreso.CustomFormat = "YYYY-MM-DD hh:mm:ss\'";
			this.dtpFechaIngreso.Location = new System.Drawing.Point(615, 168);
			this.dtpFechaIngreso.Name = "dtpFechaIngreso";
			this.dtpFechaIngreso.Size = new System.Drawing.Size(136, 20);
			this.dtpFechaIngreso.TabIndex = 65;
			this.dtpFechaIngreso.ValueChanged += new System.EventHandler(this.dtpFechaIngreso_ValueChanged);
			// 
			// cbxGenero
			// 
			this.cbxGenero.FormattingEnabled = true;
			this.cbxGenero.Items.AddRange(new object[] {
            "M",
            "F"});
			this.cbxGenero.Location = new System.Drawing.Point(615, 123);
			this.cbxGenero.Name = "cbxGenero";
			this.cbxGenero.Size = new System.Drawing.Size(136, 21);
			this.cbxGenero.TabIndex = 66;
			// 
			// pbFoto
			// 
			this.pbFoto.Location = new System.Drawing.Point(805, 79);
			this.pbFoto.Name = "pbFoto";
			this.pbFoto.Size = new System.Drawing.Size(133, 113);
			this.pbFoto.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
			this.pbFoto.TabIndex = 67;
			this.pbFoto.TabStop = false;
			// 
			// btnAgregarFoto
			// 
			this.btnAgregarFoto.Location = new System.Drawing.Point(835, 211);
			this.btnAgregarFoto.Name = "btnAgregarFoto";
			this.btnAgregarFoto.Size = new System.Drawing.Size(75, 23);
			this.btnAgregarFoto.TabIndex = 69;
			this.btnAgregarFoto.Text = "Agregar";
			this.btnAgregarFoto.UseVisualStyleBackColor = true;
			this.btnAgregarFoto.Click += new System.EventHandler(this.btnAgregarFoto_Click);
			// 
			// Column1
			// 
			this.Column1.HeaderText = "Id";
			this.Column1.Name = "Column1";
			// 
			// Column2
			// 
			this.Column2.HeaderText = "Nombre";
			this.Column2.Name = "Column2";
			// 
			// Column3
			// 
			this.Column3.HeaderText = "Apellido";
			this.Column3.Name = "Column3";
			// 
			// Column4
			// 
			this.Column4.HeaderText = "Direcion";
			this.Column4.Name = "Column4";
			// 
			// Column5
			// 
			this.Column5.HeaderText = "Telefono";
			this.Column5.Name = "Column5";
			// 
			// Column6
			// 
			this.Column6.HeaderText = "Genero";
			this.Column6.Name = "Column6";
			// 
			// Column7
			// 
			this.Column7.HeaderText = "Imagen";
			this.Column7.Name = "Column7";
			// 
			// Column8
			// 
			this.Column8.HeaderText = "Fecha Ingreso";
			this.Column8.Name = "Column8";
			// 
			// Column9
			// 
			this.Column9.HeaderText = "Correo";
			this.Column9.Name = "Column9";
			// 
			// FrmEmpleados
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(972, 518);
			this.Controls.Add(this.btnAgregarFoto);
			this.Controls.Add(this.label7);
			this.Controls.Add(this.pbFoto);
			this.Controls.Add(this.txtTelefono);
			this.Controls.Add(this.cbxGenero);
			this.Controls.Add(this.dtpFechaIngreso);
			this.Controls.Add(this.txtCorreo);
			this.Controls.Add(this.txtDireccion);
			this.Controls.Add(this.label8);
			this.Controls.Add(this.label5);
			this.Controls.Add(this.label6);
			this.Controls.Add(this.txtApellido);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.txtNombre);
			this.Controls.Add(this.btnEliminar);
			this.Controls.Add(this.btnActualizar);
			this.Controls.Add(this.btnAgregar);
			this.Controls.Add(this.dgEmpleados);
			this.Controls.Add(this.txtId);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.panel2);
			this.Controls.Add(this.panel1);
			this.Name = "FrmEmpleados";
			this.Text = "Gestión Empleados";
			this.Load += new System.EventHandler(this.FrmEmpleados_Load);
			((System.ComponentModel.ISupportInitialize)(this.dgEmpleados)).EndInit();
			this.panel1.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.pbFoto)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.TextBox txtDireccion;
		private System.Windows.Forms.Label label8;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.TextBox txtTelefono;
		private System.Windows.Forms.Label label7;
		private System.Windows.Forms.TextBox txtApellido;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.TextBox txtNombre;
		private System.Windows.Forms.Button btnEliminar;
		private System.Windows.Forms.Button btnActualizar;
		private System.Windows.Forms.Button btnAgregar;
		private System.Windows.Forms.DataGridView dgEmpleados;
		private System.Windows.Forms.TextBox txtId;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Panel panel2;
		private System.Windows.Forms.Panel panel1;
		private System.Windows.Forms.Button btnProductos;
		private System.Windows.Forms.Button btnCategorias;
		private System.Windows.Forms.Button btnEmpleados;
		private System.Windows.Forms.Button btnSede;
		private System.Windows.Forms.TextBox txtCorreo;
		private System.Windows.Forms.DateTimePicker dtpFechaIngreso;
		private System.Windows.Forms.ComboBox cbxGenero;
		private System.Windows.Forms.PictureBox pbFoto;
		private System.Windows.Forms.Button btnAgregarFoto;
		private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
		private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
		private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
		private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
		private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
		private System.Windows.Forms.DataGridViewTextBoxColumn Column6;
		private System.Windows.Forms.DataGridViewImageColumn Column7;
		private System.Windows.Forms.DataGridViewTextBoxColumn Column8;
		private System.Windows.Forms.DataGridViewTextBoxColumn Column9;
	}
}