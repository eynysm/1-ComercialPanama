namespace Presentation
{
	partial class FrmCategoria
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
			this.panel1 = new System.Windows.Forms.Panel();
			this.panel2 = new System.Windows.Forms.Panel();
			this.btnSede = new System.Windows.Forms.Button();
			this.btnEmpleados = new System.Windows.Forms.Button();
			this.btnCategorias = new System.Windows.Forms.Button();
			this.btnProductos = new System.Windows.Forms.Button();
			this.panel1.SuspendLayout();
			this.SuspendLayout();
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
			this.panel1.Size = new System.Drawing.Size(194, 450);
			this.panel1.TabIndex = 1;
			// 
			// panel2
			// 
			this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(160)))), ((int)(((byte)(234)))));
			this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
			this.panel2.Location = new System.Drawing.Point(194, 0);
			this.panel2.Name = "panel2";
			this.panel2.Size = new System.Drawing.Size(606, 36);
			this.panel2.TabIndex = 2;
			// 
			// btnSede
			// 
			this.btnSede.FlatAppearance.BorderSize = 0;
			this.btnSede.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnSede.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnSede.ForeColor = System.Drawing.Color.White;
			this.btnSede.Location = new System.Drawing.Point(0, 88);
			this.btnSede.Name = "btnSede";
			this.btnSede.Size = new System.Drawing.Size(194, 44);
			this.btnSede.TabIndex = 3;
			this.btnSede.Text = "Sedes";
			this.btnSede.UseVisualStyleBackColor = true;
			// 
			// btnEmpleados
			// 
			this.btnEmpleados.FlatAppearance.BorderSize = 0;
			this.btnEmpleados.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnEmpleados.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnEmpleados.ForeColor = System.Drawing.Color.White;
			this.btnEmpleados.Location = new System.Drawing.Point(0, 154);
			this.btnEmpleados.Name = "btnEmpleados";
			this.btnEmpleados.Size = new System.Drawing.Size(194, 44);
			this.btnEmpleados.TabIndex = 4;
			this.btnEmpleados.Text = "Empleados";
			this.btnEmpleados.UseVisualStyleBackColor = true;
			// 
			// btnCategorias
			// 
			this.btnCategorias.FlatAppearance.BorderSize = 0;
			this.btnCategorias.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnCategorias.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnCategorias.ForeColor = System.Drawing.Color.White;
			this.btnCategorias.Location = new System.Drawing.Point(0, 220);
			this.btnCategorias.Name = "btnCategorias";
			this.btnCategorias.Size = new System.Drawing.Size(194, 44);
			this.btnCategorias.TabIndex = 5;
			this.btnCategorias.Text = "Categorias";
			this.btnCategorias.UseVisualStyleBackColor = true;
			// 
			// btnProductos
			// 
			this.btnProductos.FlatAppearance.BorderSize = 0;
			this.btnProductos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnProductos.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnProductos.ForeColor = System.Drawing.Color.White;
			this.btnProductos.Location = new System.Drawing.Point(0, 284);
			this.btnProductos.Name = "btnProductos";
			this.btnProductos.Size = new System.Drawing.Size(194, 44);
			this.btnProductos.TabIndex = 6;
			this.btnProductos.Text = "Productos";
			this.btnProductos.UseVisualStyleBackColor = true;
			// 
			// FrmCategoria
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(800, 450);
			this.Controls.Add(this.panel2);
			this.Controls.Add(this.panel1);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
			this.Name = "FrmCategoria";
			this.Text = "FrmCategoria";
			this.panel1.ResumeLayout(false);
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.Panel panel1;
		private System.Windows.Forms.Panel panel2;
		private System.Windows.Forms.Button btnSede;
		private System.Windows.Forms.Button btnEmpleados;
		private System.Windows.Forms.Button btnProductos;
		private System.Windows.Forms.Button btnCategorias;
	}
}