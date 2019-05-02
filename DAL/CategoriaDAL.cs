using System;
using System.Data; 
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entities; 

namespace DAL
{
	public class CategoriaDAL:Conexion
	{
		String sql = "";

		public CategoriaDAL() : base()
		{

		}

		public void Add(Categoria ob)
		{
			sql = "insert into categoria (id_categoria, nombre_categoria) values ('{0}','{1}')";
			sql = string.Format(sql, ob.Id_categoria, ob.Nombre_categoria);
			ExecuteNonQuery(sql);
		}

		public void Delete(string Id_categoria)
		{
			sql = "delete from categoria where id_categoria=('{0}')";
			sql = string.Format(sql, Id_categoria);
			ExecuteNonQuery(sql);
		}

		public void Update(Categoria ob)
		{
			sql = "update categoria set nombre_categoria='{1}' where id_categoria = '{0}'";
			sql = string.Format(sql, ob.Id_categoria, ob.Nombre_categoria);
			ExecuteNonQuery(sql);
		}

		public List<Categoria> GetAll()
		{
			List<Categoria> ls = new List<Categoria>();
			sql = "select * from categoria";
			DataTable dt = new DataTable();
			dt = ExecuteQuery(sql);
			foreach (DataRow r in dt.Rows)
			{
				Categoria ob = new Categoria();
				ob.Id_categoria = r[0].ToString();
				ob.Nombre_categoria = r[1].ToString();
				ls.Add(ob);

			}
			return ls;
		}

		public Categoria GetById_categoria(string Id_categoria)
		{
			sql = "select * from Categoria where Id_categoria='{0}'";
			sql = string.Format(sql, Id_categoria);
			DataTable dt = new DataTable();
			dt = ExecuteQuery(sql);
			foreach (DataRow r in dt.Rows)
			{
				Categoria ob = new Categoria();
				ob.Id_categoria = r[0].ToString();
				ob.Nombre_categoria = r[1].ToString();
				return ob;
			}
			return null;
		}

		public List<Categoria> GetByLikeId_categoria(string Id_categoria)
		{
			sql = "select * from Categoria where Id_categoria LIKE '%{0}%'";
			sql = string.Format(sql, Id_categoria);
			List<Categoria> ls = new List<Categoria>();
			DataTable dt = new DataTable();
			dt = ExecuteQuery(sql);
			foreach (DataRow r in dt.Rows)
			{
				Categoria ob = new Categoria();
				ob.Id_categoria = r[0].ToString();
				ob.Nombre_categoria = r[1].ToString();
				ls.Add(ob);

			}
			return ls;
		}

		public void Save(Categoria ob)
		{
			if (GetById_categoria(ob.Id_categoria) != null)
				Update(ob);
			else
				Add(ob);
		}

	}
}
