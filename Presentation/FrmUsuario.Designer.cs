namespace Presentation
{
	partial class FrmUsuario
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
			this.txtConfirmarPassword = new System.Windows.Forms.TextBox();
			this.label8 = new System.Windows.Forms.Label();
			this.txtIdEmpleado = new System.Windows.Forms.TextBox();
			this.label7 = new System.Windows.Forms.Label();
			this.txtPassword = new System.Windows.Forms.TextBox();
			this.label3 = new System.Windows.Forms.Label();
			this.label4 = new System.Windows.Forms.Label();
			this.txtNombreUsuario = new System.Windows.Forms.TextBox();
			this.btnEliminar = new System.Windows.Forms.Button();
			this.btnActualizar = new System.Windows.Forms.Button();
			this.btnAgregar = new System.Windows.Forms.Button();
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
			this.dgUsuario = new System.Windows.Forms.DataGridView();
			this.panel1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.dgUsuario)).BeginInit();
			this.SuspendLayout();
			// 
			// txtConfirmarPassword
			// 
			this.txtConfirmarPassword.Location = new System.Drawing.Point(655, 157);
			this.txtConfirmarPassword.Name = "txtConfirmarPassword";
			this.txtConfirmarPassword.Size = new System.Drawing.Size(136, 20);
			this.txtConfirmarPassword.TabIndex = 63;
			this.txtConfirmarPassword.UseSystemPasswordChar = true;
			// 
			// label8
			// 
			this.label8.AutoSize = true;
			this.label8.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label8.Location = new System.Drawing.Point(539, 161);
			this.label8.Name = "label8";
			this.label8.Size = new System.Drawing.Size(110, 17);
			this.label8.TabIndex = 62;
			this.label8.Text = "Repetir Password";
			// 
			// txtIdEmpleado
			// 
			this.txtIdEmpleado.Location = new System.Drawing.Point(339, 118);
			this.txtIdEmpleado.Name = "txtIdEmpleado";
			this.txtIdEmpleado.Size = new System.Drawing.Size(136, 20);
			this.txtIdEmpleado.TabIndex = 56;
			// 
			// label7
			// 
			this.label7.AutoSize = true;
			this.label7.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label7.Location = new System.Drawing.Point(236, 118);
			this.label7.Name = "label7";
			this.label7.Size = new System.Drawing.Size(82, 17);
			this.label7.TabIndex = 55;
			this.label7.Text = "Id Empleado";
			// 
			// txtPassword
			// 
			this.txtPassword.Location = new System.Drawing.Point(339, 161);
			this.txtPassword.Name = "txtPassword";
			this.txtPassword.Size = new System.Drawing.Size(136, 20);
			this.txtPassword.TabIndex = 54;
			this.txtPassword.UseSystemPasswordChar = true;
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label3.Location = new System.Drawing.Point(600, 118);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(49, 17);
			this.label3.TabIndex = 53;
			this.label3.Text = "Correo";
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label4.Location = new System.Drawing.Point(254, 161);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(64, 17);
			this.label4.TabIndex = 52;
			this.label4.Text = "Password";
			// 
			// txtNombreUsuario
			// 
			this.txtNombreUsuario.Location = new System.Drawing.Point(655, 78);
			this.txtNombreUsuario.Name = "txtNombreUsuario";
			this.txtNombreUsuario.Size = new System.Drawing.Size(136, 20);
			this.txtNombreUsuario.TabIndex = 51;
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
			this.label2.Location = new System.Drawing.Point(543, 82);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(106, 17);
			this.label2.TabIndex = 45;
			this.label2.Text = "Nombre Usuario";
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.Location = new System.Drawing.Point(299, 83);
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
			//this.btnProductos.Image = global::Presentation.Properties.Resources.box;
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
			//this.btnCategorias.Image = global::Presentation.Properties.Resources.price_tag;
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
			//this.btnEmpleados.Image = global::Presentation.Properties.Resources.team__1_;
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
			//this.btnSede.Image = global::Presentation.Properties.Resources.placeholder__3_;
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
			this.txtCorreo.Location = new System.Drawing.Point(655, 117);
			this.txtCorreo.Name = "txtCorreo";
			this.txtCorreo.Size = new System.Drawing.Size(136, 20);
			this.txtCorreo.TabIndex = 64;
			// 
			// dgUsuario
			// 
			this.dgUsuario.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dgUsuario.Location = new System.Drawing.Point(263, 340);
			this.dgUsuario.Name = "dgUsuario";
			this.dgUsuario.Size = new System.Drawing.Size(574, 166);
			this.dgUsuario.TabIndex = 65;
			// 
			// FrmUsuario
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(972, 518);
			this.Controls.Add(this.dgUsuario);
			this.Controls.Add(this.label7);
			this.Controls.Add(this.txtIdEmpleado);
			this.Controls.Add(this.txtCorreo);
			this.Controls.Add(this.txtConfirmarPassword);
			this.Controls.Add(this.label8);
			this.Controls.Add(this.txtPassword);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.txtNombreUsuario);
			this.Controls.Add(this.btnEliminar);
			this.Controls.Add(this.btnActualizar);
			this.Controls.Add(this.btnAgregar);
			this.Controls.Add(this.txtId);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.panel2);
			this.Controls.Add(this.panel1);
			this.Name = "FrmUsuario";
			this.Text = "Gestión Empleados";
			this.Load += new System.EventHandler(this.FrmUsuario_Load);
			this.panel1.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.dgUsuario)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.TextBox txtConfirmarPassword;
		private System.Windows.Forms.Label label8;
		private System.Windows.Forms.TextBox txtIdEmpleado;
		private System.Windows.Forms.Label label7;
		private System.Windows.Forms.TextBox txtPassword;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.TextBox txtNombreUsuario;
		private System.Windows.Forms.Button btnEliminar;
		private System.Windows.Forms.Button btnActualizar;
		private System.Windows.Forms.Button btnAgregar;
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
        private System.Windows.Forms.DataGridView dgUsuario;
    }
}