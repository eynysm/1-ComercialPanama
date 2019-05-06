using System;
using System.Data;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entities;

namespace DAL
{
	public class SedeDAL : Conexion
	{
		string sql = "";

		public SedeDAL() : base()
		{
		}


		public void Add(Sede ob)
		{
			sql = "insert into Sede (nit_sede, nombre_sede, direccion_sede, telefono_sede, responsable_sede) values ('{0}','{1}','{2}','{3}','{4}')";
			sql = string.Format(sql, ob.Nit_sede, ob.Nombre_sede, ob.Direccion_sede, ob.Telefono_sede, ob.Id_empleado);
			ExecuteNonQuery(sql);
		}

		public void Delete(string Nit_sede)
		{
			sql = "delete from Sede where nit_sede ='{0}')";
			sql = string.Format(sql, Nit_sede);
			ExecuteNonQuery(sql);
		}

		public void Update(Sede ob)
		{
			sql = "insert into Sede (nombre_sede, direccion_sede, telefono_sede, responsable_sede) values ('{1}','{2}','{3}','{4}')";
			sql = string.Format(sql, ob.Nombre_sede, ob.Direccion_sede, ob.Telefono_sede, ob.Id_empleado);
			ExecuteNonQuery(sql);
		}

		public List<Sede> GetAll()
		{
			List<Sede> ls = new List<Sede>();
			sql = "select * from Sede";
			DataTable dt = new DataTable();
			dt = ExecuteQuery(sql);
			foreach (DataRow r in dt.Rows)
			{
				Sede ob = new Sede();
				ob.Nit_sede = r[0].ToString();
				ob.Nombre_sede = r[1].ToString();
				ob.Direccion_sede = r[2].ToString();
				ob.Telefono_sede = r[3].ToString();
				ob.Id_empleado = r[4].ToString();
				ls.Add(ob);

			}
			return ls;
		}

		public Sede GetByNit_Sede(string Nit_sede)
		{
			sql = "select * from Sede where nit_sede = '{0}'";
			sql = string.Format(sql, Nit_sede);
			DataTable dt = new DataTable();
			dt = ExecuteQuery(sql);
			foreach (DataRow r in dt.Rows)
			{
				Sede ob = new Sede();
				ob.Nit_sede = r[0].ToString();
				ob.Nombre_sede = r[1].ToString();
				ob.Direccion_sede = r[2].ToString();
				ob.Telefono_sede = r[3].ToString();
				ob.Id_empleado = r[4].ToString();
				return ob;
			}
			return null;
		}

		public void Save(Sede ob)
		{
			if (GetByNit_Sede(ob.Nit_sede) != null)
				Update(ob);
			else
				Add(ob);
		}
	}
}
