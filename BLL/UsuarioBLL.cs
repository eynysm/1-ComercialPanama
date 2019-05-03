using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entities;
using DAL; 

namespace BLL
{
	public class UsuarioBLL
	{
		private UsuarioDAL c = new UsuarioDAL();

		public void Add(Usuario ob)
		{ c.Add(ob); }

		public void Delete(string Id_Usuario)
		{ c.Delete(Id_Usuario); }

		public void Update(Usuario ob)
		{ c.Update(ob,ob.Id_usuario); }

		public List<Usuario> GetAll()
		{ return c.GetAll(); }

		public Usuario GetById_Usuario(string Id_Usuario)
		{ return c.GetById_Usuario(Id_Usuario); }

		public void Save(Usuario ob)
		{ c.Save(ob); }

        public bool IsLoggedIn(string user, string pass)
        {
            return c.login(user, pass);
        }
    }
}
