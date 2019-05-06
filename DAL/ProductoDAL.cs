using System;
using System.Data;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entities;

namespace DAL
{
	public class ProductoDAL : Conexion
	{
		string sql = "";

		public ProductoDAL() : base()
		{
		}

		public void Add(Producto ob)
		{
			sql = "insert into Producto (id_producto, nombre_producto, precio_venta_producto, precio_compra_producto, fecha_ingreso_producto, responsable_producto, nit_sede, id_categoria)" +
				"values ('{0}','{1}',{2},{3},'{4}','{5}','{6}','{7}')";
			sql = string.Format(sql, ob.Id_producto, ob.Nombre_producto, ob.Precio_venta_producto, ob.Precio_compra_producto, ob.Fecha_ingreso_producto.ToString("yyyy-MM-dd hh:mm:ss"), ob.Id_empleado, ob.Nit_sede, ob.Id_categoria);
			ExecuteNonQuery(sql);
		}

		public void Delete(string Id_producto)
		{
			sql = "delete from Producto where id_producto='{0}')";
			sql = string.Format(sql, Id_producto);
			ExecuteNonQuery(sql);
		}

		public void Update(Producto ob)
		{
			sql = "update Producto set nombre_producto='{1}', precio_venta_producto={2}, precio_compra_producto={3},";
			sql += "fecha_ingreso_producto='{4}', responsable_producto='{5}', nit_sede='{6}',id_categoria='{7}' where id_producto = '{0}'";
			sql = string.Format(sql, ob.Nombre_producto, ob.Precio_venta_producto, ob.Precio_compra_producto, ob.Fecha_ingreso_producto.ToString("yyyy-MM-dd hh:mm:ss"), ob.Id_empleado, ob.Nit_sede, ob.Id_categoria);
			ExecuteNonQuery(sql);
		}

		public List<Producto> GetAll()
		{
			List<Producto> ls = new List<Producto>();
			sql = "select * from Producto";
			DataTable dt = new DataTable();
			dt = ExecuteQuery(sql);
			foreach (DataRow r in dt.Rows)
			{
				Producto ob = new Producto();
				ob.Id_producto = r[0].ToString();
				ob.Nombre_producto = r[1].ToString();
				ob.Precio_venta_producto = Convert.ToDecimal(r[2]);
				ob.Precio_compra_producto = Convert.ToDecimal(r[3]);
				ob.Fecha_ingreso_producto = Convert.ToDateTime(r[4]);
				ob.Id_empleado = r[5].ToString();
				ob.Nit_sede = r[6].ToString();
				ob.Id_categoria = r[7].ToString();
				ls.Add(ob);

			}
			return ls;
		}

		public Producto GetById_producto(string Id_producto)
		{
			sql = "select * from Producto where id_producto = '{0}'";
			sql = string.Format(sql, Id_producto);
			DataTable dt = new DataTable();
			dt = ExecuteQuery(sql);
			foreach (DataRow r in dt.Rows)
			{
				Producto ob = new Producto();
				ob.Id_producto = r[0].ToString();
				ob.Nombre_producto = r[1].ToString();
				ob.Precio_venta_producto = Convert.ToDecimal(r[2]);
				ob.Precio_compra_producto = Convert.ToDecimal(r[3]);
				ob.Fecha_ingreso_producto = Convert.ToDateTime(r[4]);
				ob.Id_empleado = r[5].ToString();
				ob.Nit_sede = r[6].ToString();
				ob.Id_categoria = r[7].ToString();
				return ob;
			}
			return null;
		}

		public void Save(Producto ob)
		{
			if (GetById_producto(ob.Id_producto) != null)
				Update(ob);
			else
				Add(ob);
		}
	}
}