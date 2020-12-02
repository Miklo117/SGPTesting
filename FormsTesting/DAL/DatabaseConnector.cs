using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using MySql.Data;
using MySql.Data.MySqlClient;
using FormsTesting.Models;

namespace FormsTesting.DAL
{
	public class DatabaseConnector
	{

		private const string connStr = "server=localhost;user=root;database=profaunasistema;port=3306;password=local";
		private MySqlConnection conn = new MySqlConnection(connStr);

		public List<Cliente> GetClientes()
		{
			var list =  new List<Cliente>();
			//conn.Open();
			try
			{

				string query = @"SELECT 'idCliente','Nombre','Apellidos','TelefonoCasa','TelefonoCasa2','TelefonoCelular','TelefonoCelular2','CorreoElectronico','CorreoElectronico2','DireccionCalle','DireccionNumeroExt','DireccionNumeroInt','DireccionColonia','DireccionCP','direccionpais_idDireccionPais','direccionestado_idEstado','direccionciudad_idCiudad','Habilitado'
								From Clientes";
				conn.Open();
				MySqlCommand cmd = new MySqlCommand(query, conn);
				MySqlDataReader rdr = cmd.ExecuteReader();

				while (rdr.Read())
				{
					Cliente cli = new Cliente() { 
						idCliente = (int)rdr["idCliente"],
						Nombre = rdr["Nombre"].ToString(),
						Apellidos = rdr["Apellidos"].ToString(),
						TelefonoCasa = rdr["TelefonoCasa"].ToString(),
						TelefonoCasa2 = rdr["TelefonoCasa2"].ToString(),
						TelefonoCelular = rdr["TelefonoCelular"].ToString(),
						TelefonoCelular2 = rdr["TelefonoCelular2"].ToString(),
						CorreoElectronico = rdr["CorreoElectronico"].ToString(),
						CorreoElectronico2 = rdr["CorreoElectronico2"].ToString(),
						DireccionCalle = rdr["DireccionCalle"].ToString(),
						DireccionNumeroExt = rdr["DireccionNumeroExt"].ToString(),
						DireccionNumeroint = rdr["DireccionNumeroInt"].ToString(),
						DireccionColonia = rdr["DireccionColonia"].ToString(),
						DireccionCP = rdr["DireccionCP"].ToString(),
						Habilitado = (int)rdr["Habilitado"] == 1
					};
					list.Add(cli);
				}
				rdr.Close();
			}
			catch (Exception ex)
			{
				Console.WriteLine(ex.ToString());
			}

			conn.Close();
			return list;
		}
		public List<object> ExcecuteQuery(string query)
		{
			var list = new List<object>();
			//conn.Open();
			try
			{
				conn.Open();
				MySqlCommand cmd = new MySqlCommand(query, conn);
				MySqlDataReader rdr = cmd.ExecuteReader();

				while (rdr.Read())
				{
					list = rdr.Cast<object>().ToList();
				}
				rdr.Close();
			}
			catch (Exception ex)
			{
				Console.WriteLine(ex.ToString());
			}

			conn.Close();
			return list;
		}
		public int ExcecuteCountQuery(string query)
		{
			//conn.Open();
			try
			{
				conn.Open();
				using (var cmd = new MySqlCommand(query, conn))
				{
					int count = Convert.ToInt32(cmd.ExecuteScalar());
					conn.Close();
					return count;
				}
			}
			catch (Exception ex)
			{
				Console.WriteLine(ex.ToString());
				return 0;
			}

		}
	}
}
