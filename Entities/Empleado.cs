using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities
{
	public class Empleado
	{
		public string Id_empleado { get; set; }
		public string Nombre_empleado { get; set; }
		public string Apellido_empleado { get; set; }
		public string Direccion_empleado { get; set; }
		public string Telefono_empleado { get; set; }
		public string Genero_empleado { get; set; }
		public DateTime Fecha_ingreso_empleado { get; set; }
		public byte[] Foto_empleado { get; set; }
		public string Correo_empleado { get; set; }
	}
}
