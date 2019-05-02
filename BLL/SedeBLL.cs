using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entities;
using DAL; 

namespace BLL
{
	public class SedeBLL
	{
		private SedeDAL c = new SedeDAL();

		public void Add(Sede ob)
		{ c.Add(ob); }

		public void Delete(string Nit_Sede)
		{ c.Delete(Nit_Sede); }

		public void Update(Sede ob)
		{ c.Update(ob); }

		public List<Sede> GetAll()
		{ return c.GetAll(); }

		public Sede GetByNit_Sede(string Nit_Sede)
		{ return c.GetByNit_Sede(Nit_Sede); }

		public void Save(Sede ob)
		{ c.Save(ob); }
	}
}
