using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities
{
	public class Producto
	{
		public string Id_producto { get; set; }
		public string Nombre_producto { get; set; }
		public decimal Precio_venta_producto { get; set; }
		public decimal Precio_compra_producto { get; set; }
		public DateTime Fecha_ingreso_producto { get; set; }
		public string Id_empleado { get; set; }
		public string Nit_sede { get; set; }
		public string Id_categoria { get; set; }
	}
}
