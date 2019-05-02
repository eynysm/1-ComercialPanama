using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entities;
using DAL; 

namespace BLL
{
	public class ProductoBLL
	{
		private ProductoDAL c = new ProductoDAL();

		public void Add(Producto ob)
		{ c.Add(ob); }

		public void Delete(string Id_producto)
		{ c.Delete(Id_producto); }

		public void Update(Producto ob)
		{ c.Update(ob); }

		public List<Producto> GetAll()
		{ return c.GetAll(); }

		public Producto GetById_producto(string Id_producto)
		{ return c.GetById_producto(Id_producto); }

		public void Save(Producto ob)
		{ c.Save(ob); }
	}
}
