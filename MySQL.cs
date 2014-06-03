/*
 * Created by SharpDevelop.
 * User: Owner
 * Date: 6/2/2014
 * Time: 6:30 PM
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using MySql.Data.MySqlClient;

namespace practica6_7_8_9
{
	/// <summary>
	/// Description of MySQL.
	/// </summary>
	public class MySQL
	{
		protected  MySqlConnection  myConnection ;
		public MySQL()
		{
		}
		protected void abrirConexion()
		{
			string connectionString = 
			"Server=127.0.0.1;" +
			"Database=escuela;" +
			"User ID=root;" +
			"Password=;" +
			"Pooling=false;";

			this.myConnection = new MySqlConnection(connectionString);
			this.myConnection.Open();
			
		}
		
		
		protected void cerrarConexion()
		{
			this.myConnection.Close();
			this.myConnection = null;
		}
	}
}
