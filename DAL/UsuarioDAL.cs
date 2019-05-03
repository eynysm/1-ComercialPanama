using System;
using System.Data;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entities;

namespace DAL
{
    public class UsuarioDAL : Conexion
    {
        string sql = "";

        public UsuarioDAL() : base()
        {
        }


        public void Add(Usuario ob)
        {
            sql = "insert into Usuario (Id_usuario, Nombre_usuario, direccion_Usuario, telefono_Usuario, id_empleado) values ('{0}','{1}','{2}','{3}','{4}')";
            sql = string.Format(sql, ob.Id_usuario, ob.Nombre_usuario, ob.Password, ob.Id_empleado);
            ExecuteNonQuery(sql);
        }

        public void Delete(string Id_usuario)
        {
            sql = "delete from Usuario where Id_usuario ='{0}')";
            sql = string.Format(sql, Id_usuario);
            ExecuteNonQuery(sql);
        }

        public void Update(Usuario ob)
        {
            sql = "insert into Usuario (Nombre_usuario, direccion_Usuario, telefono_Usuario, id_empleado) values ('{1}','{2}','{3}','{4}')";
            sql = string.Format(sql, ob.Id_usuario, ob.Nombre_usuario, ob.Password, ob.Id_empleado);
            ExecuteNonQuery(sql);
        }

        public List<Usuario> GetAll()
        {
            List<Usuario> ls = new List<Usuario>();
            sql = "select * from Usuario";
            DataTable dt = new DataTable();
            dt = ExecuteQuery(sql);
            foreach (DataRow r in dt.Rows)
            {
                Usuario ob = new Usuario();
                ob.Id_usuario = r[0].ToString();
                ob.Nombre_usuario = r[1].ToString();
                ob.Correo_usuario = r[2].ToString();
                ob.Id_empleado = r[3].ToString();
                ls.Add(ob);

            }
            return ls;
        }

        public Usuario GetById_usuario(string Id_usuario)
        {
            sql = "select * from Usuario where Id_usuario = '{0}'";
            sql = string.Format(sql, Id_usuario);
            DataTable dt = new DataTable();
            dt = ExecuteQuery(sql);
            foreach (DataRow r in dt.Rows)
            {
                Usuario ob = new Usuario();
                ob.Id_usuario = r[0].ToString();
                ob.Nombre_usuario = r[1].ToString();
                ob.Correo_usuario = r[2].ToString();
                ob.Id_empleado = r[3].ToString();

                return ob;
            }
            return null;
        }

        public void Save(Usuario ob)
        {
            if (GetById_usuario(ob.Id_usuario) != null)
                Update(ob);
            else
                Add(ob);
        }
    }
}
