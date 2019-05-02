using System;
using System.Data; 
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using Entities; 

namespace DAL
{
	public class EmpleadoDAL:Conexion
	{
		string sql = "";

		public EmpleadoDAL() : base()
		{
		}

		public void Add(Empleado ob)
		{
			sql = "insert into Empleado (id_empleado, nombre_empleado, apellido_empleado, direccion_empleado, telefono_empleado, genero_empleado, fecha_ingreso_empleado, foto_empleado, correo_empleado) values ('{0}','{1}',{2},{3},{4},'{5}','{6}','{7}','{8}')";
			sql = string.Format(sql, ob.Id_empleado, ob.Nombre_empleado, ob.Apellido_empleado, ob.Direccion_empleado, ob.Telefono_empleado, ob.Genero_empleado, ob.Fecha_ingreso_empleado, ob.Foto_empleado, ob.Correo_empleado);
			ExecuteNonQuery(sql);
		}

		public void Delete(string Id_empleado)
		{
			sql = "delete from Empleado where id_empleado='{0}')";
			sql = string.Format(sql, Id_empleado);
			ExecuteNonQuery(sql);
		}

		public void Update(Empleado ob)
		{
			sql = "update Empleado set nombre_empleado='{1}', apellido_empleado='{2}',  direccion_empleado='{3}', telefono_empleado='{4}', genero_empleado='{5}', fecha_ingreso_empleado='{6}', foto_empleado='{7}', correo_empleado='{8}' where id_empleado = '{0}'";
			sql = string.Format(sql, ob.Id_empleado, ob.Nombre_empleado, ob.Apellido_empleado, ob.Direccion_empleado, ob.Telefono_empleado, ob.Genero_empleado, ob.Fecha_ingreso_empleado, ob.Foto_empleado, ob.Correo_empleado);
			ExecuteNonQuery(sql);
		}

		public List<Empleado> GetAll()
		{
			List<Empleado> ls = new List<Empleado>();
			sql = "select * from Empleado";
			DataTable dt = new DataTable();
			dt = ExecuteQuery(sql);
			foreach (DataRow r in dt.Rows)
			{
				Empleado ob = new Empleado();
				ob.Id_empleado = r[0].ToString();
				ob.Nombre_empleado = r[1].ToString();
				ob.Apellido_empleado = r[2].ToString();
				ob.Direccion_empleado = r[3].ToString();
				ob.Telefono_empleado = r[4].ToString();
				ob.Genero_empleado = r[5].ToString();
				ob.Fecha_ingreso_empleado = Convert.ToDateTime(r[6]);
				ob.Foto_empleado = r[7].ToString();
				ob.Correo_empleado = r[8].ToString();
				ls.Add(ob);

			}
			return ls;
		}

		public Empleado GetById_empleado(string Id_empleado)
		{
			sql = "select * from Empleado where id_empleado='{0}'";
			sql = string.Format(sql, Id_empleado);
			DataTable dt = new DataTable();
			dt = ExecuteQuery(sql);
			foreach (DataRow r in dt.Rows)
			{
				Empleado ob = new Empleado();
				ob.Id_empleado = r[0].ToString();
				ob.Nombre_empleado = r[1].ToString();
				ob.Apellido_empleado = r[2].ToString();
				ob.Direccion_empleado = r[3].ToString();
				ob.Telefono_empleado = r[4].ToString();
				ob.Genero_empleado = r[5].ToString();
				ob.Fecha_ingreso_empleado = Convert.ToDateTime(r[6]);
				ob.Foto_empleado = r[7].ToString();
				ob.Correo_empleado = r[8].ToString();
				return ob;
			}
			return null;
		}

		public void Save(Empleado ob)
		{
			if (GetById_empleado(ob.Id_empleado) != null)
				Update(ob);
			else
				Add(ob);
		}
	}
}
