using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entities;
using DAL; 

namespace BLL
{
	public class CategoriaBLL
	{
		private CategoriaDAL c = new CategoriaDAL();

		public void Add(Categoria ob)
		{ c.Add(ob); }

		public void Delete(string Id_categoria)
		{ c.Delete(Id_categoria); }

		public void Update(Categoria ob)
		{ c.Update(ob); }

		public List<Categoria> GetAll()
		{ return c.GetAll(); }

		public Categoria GetById_categoria(string Id_categoria)
		{ return c.GetById_categoria(Id_categoria); }

		public List<Categoria> GetByLikeId_categoria(string Id_categoria)
		{ return c.GetByLikeId_categoria(Id_categoria); }

		public void Save(Categoria ob)
		{ c.Save(ob); }
	}
}
