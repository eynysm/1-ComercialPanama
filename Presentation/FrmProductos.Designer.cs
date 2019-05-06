namespace Presentation
{
	partial class FrmProductos
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
			this.label7 = new System.Windows.Forms.Label();
			this.cbxCategoria = new System.Windows.Forms.ComboBox();
			this.dtpFechaIngreso = new System.Windows.Forms.DateTimePicker();
			this.txtPrecioCompra = new System.Windows.Forms.TextBox();
			this.label8 = new System.Windows.Forms.Label();
			this.label5 = new System.Windows.Forms.Label();
			this.label6 = new System.Windows.Forms.Label();
			this.txtPrecioVenta = new System.Windows.Forms.TextBox();
			this.label3 = new System.Windows.Forms.Label();
			this.label4 = new System.Windows.Forms.Label();
			this.txtNombre = new System.Windows.Forms.TextBox();
			this.btnEliminar = new System.Windows.Forms.Button();
			this.btnActualizar = new System.Windows.Forms.Button();
			this.btnAgregar = new System.Windows.Forms.Button();
			this.dgProductos = new System.Windows.Forms.DataGridView();
			this.txtId = new System.Windows.Forms.TextBox();
			this.label2 = new System.Windows.Forms.Label();
			this.label1 = new System.Windows.Forms.Label();
			this.cbxSede = new System.Windows.Forms.ComboBox();
			this.cbxResponsable = new System.Windows.Forms.ComboBox();
			((System.ComponentModel.ISupportInitialize)(this.dgProductos)).BeginInit();
			this.SuspendLayout();
			// 
			// label7
			// 
			this.label7.AutoSize = true;
			this.label7.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label7.Location = new System.Drawing.Point(338, 122);
			this.label7.Name = "label7";
			this.label7.Size = new System.Drawing.Size(37, 17);
			this.label7.TabIndex = 81;
			this.label7.Text = "Sede";
			// 
			// cbxCategoria
			// 
			this.cbxCategoria.FormattingEnabled = true;
			this.cbxCategoria.Items.AddRange(new object[] {
            "M",
            "F"});
			this.cbxCategoria.Location = new System.Drawing.Point(431, 163);
			this.cbxCategoria.Name = "cbxCategoria";
			this.cbxCategoria.Size = new System.Drawing.Size(136, 21);
			this.cbxCategoria.TabIndex = 89;
			// 
			// dtpFechaIngreso
			// 
			this.dtpFechaIngreso.CustomFormat = "YYYY-MM-DD hh:mm:ss\'";
			this.dtpFechaIngreso.Location = new System.Drawing.Point(431, 30);
			this.dtpFechaIngreso.Name = "dtpFechaIngreso";
			this.dtpFechaIngreso.Size = new System.Drawing.Size(136, 20);
			this.dtpFechaIngreso.TabIndex = 88;
			// 
			// txtPrecioCompra
			// 
			this.txtPrecioCompra.Location = new System.Drawing.Point(155, 164);
			this.txtPrecioCompra.Name = "txtPrecioCompra";
			this.txtPrecioCompra.Size = new System.Drawing.Size(136, 20);
			this.txtPrecioCompra.TabIndex = 86;
			// 
			// label8
			// 
			this.label8.AutoSize = true;
			this.label8.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label8.Location = new System.Drawing.Point(52, 167);
			this.label8.Name = "label8";
			this.label8.Size = new System.Drawing.Size(95, 17);
			this.label8.TabIndex = 85;
			this.label8.Text = "Precio Compra";
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label5.Location = new System.Drawing.Point(338, 33);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(89, 17);
			this.label5.TabIndex = 84;
			this.label5.Text = "Fecha Ingreso";
			// 
			// label6
			// 
			this.label6.AutoSize = true;
			this.label6.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label6.Location = new System.Drawing.Point(338, 167);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(65, 17);
			this.label6.TabIndex = 83;
			this.label6.Text = "Categoria";
			// 
			// txtPrecioVenta
			// 
			this.txtPrecioVenta.Location = new System.Drawing.Point(155, 119);
			this.txtPrecioVenta.Name = "txtPrecioVenta";
			this.txtPrecioVenta.Size = new System.Drawing.Size(136, 20);
			this.txtPrecioVenta.TabIndex = 80;
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label3.Location = new System.Drawing.Point(338, 75);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(83, 17);
			this.label3.TabIndex = 79;
			this.label3.Text = "Responsable";
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label4.Location = new System.Drawing.Point(52, 122);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(80, 17);
			this.label4.TabIndex = 78;
			this.label4.Text = "Precio Venta";
			// 
			// txtNombre
			// 
			this.txtNombre.Location = new System.Drawing.Point(155, 75);
			this.txtNombre.Name = "txtNombre";
			this.txtNombre.Size = new System.Drawing.Size(136, 20);
			this.txtNombre.TabIndex = 77;
			// 
			// btnEliminar
			// 
			this.btnEliminar.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnEliminar.Location = new System.Drawing.Point(404, 234);
			this.btnEliminar.Name = "btnEliminar";
			this.btnEliminar.Size = new System.Drawing.Size(109, 40);
			this.btnEliminar.TabIndex = 76;
			this.btnEliminar.Text = "Eliminar";
			this.btnEliminar.UseVisualStyleBackColor = true;
			this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
			// 
			// btnActualizar
			// 
			this.btnActualizar.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnActualizar.Location = new System.Drawing.Point(272, 234);
			this.btnActualizar.Name = "btnActualizar";
			this.btnActualizar.Size = new System.Drawing.Size(109, 40);
			this.btnActualizar.TabIndex = 75;
			this.btnActualizar.Text = "Actualizar";
			this.btnActualizar.UseVisualStyleBackColor = true;
			this.btnActualizar.Click += new System.EventHandler(this.btnActualizar_Click);
			// 
			// btnAgregar
			// 
			this.btnAgregar.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnAgregar.Location = new System.Drawing.Point(143, 234);
			this.btnAgregar.Name = "btnAgregar";
			this.btnAgregar.Size = new System.Drawing.Size(109, 40);
			this.btnAgregar.TabIndex = 74;
			this.btnAgregar.Text = "Agregar";
			this.btnAgregar.UseVisualStyleBackColor = true;
			this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click_1);
			// 
			// dgProductos
			// 
			this.dgProductos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dgProductos.Location = new System.Drawing.Point(30, 294);
			this.dgProductos.Name = "dgProductos";
			this.dgProductos.Size = new System.Drawing.Size(578, 168);
			this.dgProductos.TabIndex = 73;
			// 
			// txtId
			// 
			this.txtId.Location = new System.Drawing.Point(155, 30);
			this.txtId.Name = "txtId";
			this.txtId.Size = new System.Drawing.Size(136, 20);
			this.txtId.TabIndex = 72;
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label2.Location = new System.Drawing.Point(52, 78);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(57, 17);
			this.label2.TabIndex = 71;
			this.label2.Text = "Nombre";
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.Location = new System.Drawing.Point(52, 37);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(19, 17);
			this.label1.TabIndex = 70;
			this.label1.Text = "Id";
			// 
			// cbxSede
			// 
			this.cbxSede.FormattingEnabled = true;
			this.cbxSede.Items.AddRange(new object[] {
            "M",
            "F"});
			this.cbxSede.Location = new System.Drawing.Point(431, 118);
			this.cbxSede.Name = "cbxSede";
			this.cbxSede.Size = new System.Drawing.Size(136, 21);
			this.cbxSede.TabIndex = 90;
			// 
			// cbxResponsable
			// 
			this.cbxResponsable.FormattingEnabled = true;
			this.cbxResponsable.Items.AddRange(new object[] {
            "M",
            "F"});
			this.cbxResponsable.Location = new System.Drawing.Point(431, 71);
			this.cbxResponsable.Name = "cbxResponsable";
			this.cbxResponsable.Size = new System.Drawing.Size(136, 21);
			this.cbxResponsable.TabIndex = 91;
			// 
			// FrmProductos
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(641, 494);
			this.Controls.Add(this.cbxResponsable);
			this.Controls.Add(this.cbxSede);
			this.Controls.Add(this.label7);
			this.Controls.Add(this.cbxCategoria);
			this.Controls.Add(this.dtpFechaIngreso);
			this.Controls.Add(this.txtPrecioCompra);
			this.Controls.Add(this.label8);
			this.Controls.Add(this.label5);
			this.Controls.Add(this.label6);
			this.Controls.Add(this.txtPrecioVenta);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.txtNombre);
			this.Controls.Add(this.btnEliminar);
			this.Controls.Add(this.btnActualizar);
			this.Controls.Add(this.btnAgregar);
			this.Controls.Add(this.dgProductos);
			this.Controls.Add(this.txtId);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label1);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
			this.Name = "FrmProductos";
			this.Text = "FrmProductos";
			this.Load += new System.EventHandler(this.FrmProductos_Load);
			((System.ComponentModel.ISupportInitialize)(this.dgProductos)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Label label7;
		private System.Windows.Forms.ComboBox cbxCategoria;
		private System.Windows.Forms.DateTimePicker dtpFechaIngreso;
		private System.Windows.Forms.TextBox txtPrecioCompra;
		private System.Windows.Forms.Label label8;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.TextBox txtPrecioVenta;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.TextBox txtNombre;
		private System.Windows.Forms.Button btnEliminar;
		private System.Windows.Forms.Button btnActualizar;
		private System.Windows.Forms.Button btnAgregar;
		private System.Windows.Forms.DataGridView dgProductos;
		private System.Windows.Forms.TextBox txtId;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.ComboBox cbxSede;
		private System.Windows.Forms.ComboBox cbxResponsable;
	}
}