using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.OleDb;

// Clase utilizada para conexion con la bd
namespace PrimeraTarea
{
	class Datos
	{
		OleDbConnection conexion = new OleDbConnection();
		OleDbCommand comando = new OleDbCommand();
		string cadenaConexion = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=" + Environment.CurrentDirectory + "\\..\\..\\..\\BDPersonas.mdb";

		private void conectar() {
			this.conexion.ConnectionString = this.cadenaConexion;
			this.conexion.Open();
			this.comando.Connection = this.conexion;
			this.comando.CommandType = CommandType.Text;
		}

		private void desconectar() {
			this.conexion.Close();
		}

		public DataTable consultar ( string consulta) {
			DataTable tabla = new DataTable();
			this.conectar();
			this.comando.CommandText = consulta;
			tabla.Load(this.comando.ExecuteReader());
			this.desconectar();
			return tabla; 

		}
	}
}
