using System;
using System.Data;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entities;
using MySql.Data.MySqlClient;

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
            sql = "INSERT INTO usuario (id_usuario,password,nombre_usuario,correo_usuario,id_empleado)VALUES('{0}','{1}','{2}','{3}','{4}')";
            sql = string.Format(sql, ob.Id_usuario, ob.Password, ob.Nombre_usuario, ob.Correo_usuario, ob.Id_empleado);
            ExecuteNonQuery(sql);
        }

        public Usuario GetById_Usuario(string id_Usuario)
        {
            throw new NotImplementedException();
        }

        public bool login(string user, string pass)
        {
            sql = "Select* from usuario where nombre_usuario = {0} and password = {1}";
            sql = string.Format(sql, user, pass);
            ExecuteNonQuery(sql);
            return Loguear(sql);
        }



        public void Delete(string Id_usuario)
        {
            sql = "delete from Usuario where id_usuario ='{0}')";
            sql = string.Format(sql, Id_usuario);
            ExecuteNonQuery(sql);
        }

        public void Update(Usuario ob, string id)
        {
            sql = "Update  Usuario set SET id_usuario ={0}, password = {1}, nombre_usuario = {2}, correo_usuario = {3}, id_empleado = {4}  WHERE id_usuario = {5}";
            sql = string.Format(sql, ob.Id_usuario, ob.Nombre_usuario, ob.Password, ob.Id_empleado, id);
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
                Update(ob, ob.Id_usuario);
            else
                Add(ob);
        }
    }
}
