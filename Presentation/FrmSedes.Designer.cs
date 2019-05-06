namespace Presentation
{
	partial class FrmSedes
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
			this.txtTelefono = new System.Windows.Forms.TextBox();
			this.cbxResponsable = new System.Windows.Forms.ComboBox();
			this.txtDireccion = new System.Windows.Forms.TextBox();
			this.label8 = new System.Windows.Forms.Label();
			this.label6 = new System.Windows.Forms.Label();
			this.txtNombre = new System.Windows.Forms.TextBox();
			this.btnEliminar = new System.Windows.Forms.Button();
			this.btnActualizar = new System.Windows.Forms.Button();
			this.btnAgregar = new System.Windows.Forms.Button();
			this.dgSedes = new System.Windows.Forms.DataGridView();
			this.txtNit = new System.Windows.Forms.TextBox();
			this.label2 = new System.Windows.Forms.Label();
			this.label1 = new System.Windows.Forms.Label();
			((System.ComponentModel.ISupportInitialize)(this.dgSedes)).BeginInit();
			this.SuspendLayout();
			// 
			// label7
			// 
			this.label7.AutoSize = true;
			this.label7.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label7.Location = new System.Drawing.Point(398, 48);
			this.label7.Name = "label7";
			this.label7.Size = new System.Drawing.Size(58, 17);
			this.label7.TabIndex = 81;
			this.label7.Text = "Télefono";
			// 
			// txtTelefono
			// 
			this.txtTelefono.Location = new System.Drawing.Point(501, 45);
			this.txtTelefono.Name = "txtTelefono";
			this.txtTelefono.Size = new System.Drawing.Size(136, 20);
			this.txtTelefono.TabIndex = 82;
			// 
			// cbxResponsable
			// 
			this.cbxResponsable.FormattingEnabled = true;
			this.cbxResponsable.Items.AddRange(new object[] {
            "M",
            "F"});
			this.cbxResponsable.Location = new System.Drawing.Point(501, 89);
			this.cbxResponsable.Name = "cbxResponsable";
			this.cbxResponsable.Size = new System.Drawing.Size(136, 21);
			this.cbxResponsable.TabIndex = 89;
			// 
			// txtDireccion
			// 
			this.txtDireccion.Location = new System.Drawing.Point(214, 134);
			this.txtDireccion.Name = "txtDireccion";
			this.txtDireccion.Size = new System.Drawing.Size(136, 20);
			this.txtDireccion.TabIndex = 86;
			// 
			// label8
			// 
			this.label8.AutoSize = true;
			this.label8.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label8.Location = new System.Drawing.Point(111, 137);
			this.label8.Name = "label8";
			this.label8.Size = new System.Drawing.Size(62, 17);
			this.label8.TabIndex = 85;
			this.label8.Text = "Direccion";
			// 
			// label6
			// 
			this.label6.AutoSize = true;
			this.label6.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label6.Location = new System.Drawing.Point(395, 93);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(83, 17);
			this.label6.TabIndex = 83;
			this.label6.Text = "Responsable";
			// 
			// txtNombre
			// 
			this.txtNombre.Location = new System.Drawing.Point(214, 90);
			this.txtNombre.Name = "txtNombre";
			this.txtNombre.Size = new System.Drawing.Size(136, 20);
			this.txtNombre.TabIndex = 77;
			// 
			// btnEliminar
			// 
			this.btnEliminar.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnEliminar.Location = new System.Drawing.Point(475, 201);
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
			this.btnActualizar.Location = new System.Drawing.Point(343, 201);
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
			this.btnAgregar.Location = new System.Drawing.Point(214, 201);
			this.btnAgregar.Name = "btnAgregar";
			this.btnAgregar.Size = new System.Drawing.Size(109, 40);
			this.btnAgregar.TabIndex = 74;
			this.btnAgregar.Text = "Agregar";
			this.btnAgregar.UseVisualStyleBackColor = true;
			this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
			// 
			// dgSedes
			// 
			this.dgSedes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dgSedes.Location = new System.Drawing.Point(56, 262);
			this.dgSedes.Name = "dgSedes";
			this.dgSedes.Size = new System.Drawing.Size(671, 168);
			this.dgSedes.TabIndex = 73;
			// 
			// txtNit
			// 
			this.txtNit.Location = new System.Drawing.Point(214, 45);
			this.txtNit.Name = "txtNit";
			this.txtNit.Size = new System.Drawing.Size(136, 20);
			this.txtNit.TabIndex = 72;
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label2.Location = new System.Drawing.Point(111, 93);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(57, 17);
			this.label2.TabIndex = 71;
			this.label2.Text = "Nombre";
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.Location = new System.Drawing.Point(111, 52);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(25, 17);
			this.label1.TabIndex = 70;
			this.label1.Text = "Nit";
			// 
			// FrmSedes
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(799, 477);
			this.Controls.Add(this.label7);
			this.Controls.Add(this.txtTelefono);
			this.Controls.Add(this.cbxResponsable);
			this.Controls.Add(this.txtDireccion);
			this.Controls.Add(this.label8);
			this.Controls.Add(this.label6);
			this.Controls.Add(this.txtNombre);
			this.Controls.Add(this.btnEliminar);
			this.Controls.Add(this.btnActualizar);
			this.Controls.Add(this.btnAgregar);
			this.Controls.Add(this.dgSedes);
			this.Controls.Add(this.txtNit);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label1);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
			this.Name = "FrmSedes";
			this.Text = "FrmSedes";
			this.Load += new System.EventHandler(this.FrmSedes_Load);
			((System.ComponentModel.ISupportInitialize)(this.dgSedes)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Label label7;
		private System.Windows.Forms.TextBox txtTelefono;
		private System.Windows.Forms.ComboBox cbxResponsable;
		private System.Windows.Forms.TextBox txtDireccion;
		private System.Windows.Forms.Label label8;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.TextBox txtNombre;
		private System.Windows.Forms.Button btnEliminar;
		private System.Windows.Forms.Button btnActualizar;
		private System.Windows.Forms.Button btnAgregar;
		private System.Windows.Forms.DataGridView dgSedes;
		private System.Windows.Forms.TextBox txtNit;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label1;
	}
}