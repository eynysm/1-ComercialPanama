using System;
using System.Data;
using MySql.Data;
using MySql.Data.MySqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
	public class Conexion
	{
		private MySqlConnection con;
		private MySqlCommand cmd;
		private string cad;

		public Conexion()
		{
			try
			{
				cad = "server={0};uid={1};pwd={2};database=comercialpanama;port={3}";
				cad = string.Format(cad, "localhost", "root", "", "3306");
				con = new MySqlConnection(cad);
				con.Open();
				con.Close();
			}
			catch (Exception)
			{

				throw;
			}

		}

		public void ExecuteNonQuery(string sql)
		{
			try
			{
				using (con = new MySqlConnection(cad))
				{
					con.Open();
					cmd = con.CreateCommand();
					cmd.CommandText = sql;
					cmd.CommandType = System.Data.CommandType.Text;
					cmd.ExecuteNonQuery();
					cmd.Dispose();
				}
			}
			catch (Exception)
			{

				throw;
			}

		}


		public DataTable ExecuteQuery(string sql)
		{
			try
			{
				using (con = new MySqlConnection(cad))
				{
					con.Open();
					cmd = con.CreateCommand();
					cmd.CommandText = sql;
					cmd.CommandType = System.Data.CommandType.Text;
					MySqlDataAdapter da = new MySqlDataAdapter();
					DataTable dt = new DataTable();

					da.SelectCommand = cmd;
					da.Fill(dt);
					da.Dispose();
					cmd.Dispose();
					return dt;
				}
			}
			catch (Exception)
			{

				throw;
			}
		}
	}
}
