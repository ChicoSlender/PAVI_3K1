﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.OleDb;


namespace PrimeraTarea
{
	class Datos
	{
		OleDbConnection conexion = new OleDbConnection();
		OleDbCommand comando = new OleDbCommand();
		string cadenaConexion = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=C:\Users\caoli\Desktop\PAV_2020_3K1\PAVI_3K1\BDPersonas.mdb";

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