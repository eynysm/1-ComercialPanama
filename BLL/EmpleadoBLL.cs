using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entities;
using DAL; 

namespace BLL
{
	public class EmpleadoBLL
	{
		private EmpleadoDAL c = new EmpleadoDAL();

		public void Add(Empleado ob)
		{ c.Add(ob); }

		public void Delete(string Id_empleado)
		{ c.Delete(Id_empleado); }

		public void Update(Empleado ob)
		{ c.Update(ob); }

		public List<Empleado> GetAll()
		{ return c.GetAll(); }

		public Empleado GetById_empleado(string Id_empleado)
		{ return c.GetById_empleado(Id_empleado); }

		public void Save(Empleado ob)
		{ c.Save(ob); }
	}
}
