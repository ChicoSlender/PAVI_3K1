using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace PrimeraTarea
{
	class Persona
	{
		string nombre;
		string apellido;
		int dni;
		// Falta guardar cambios y soy obediente benja, NO ENTIENDO ....
		public Persona(int dni) {
			this.dni = dni;
		}
		public string Nombre 
		{
			get { return this.nombre; }
			set { this.nombre = value;}
		}

		public string Apellido { get => apellido; set => apellido = value; }
		public int Dni { get => dni; set => dni = value; }

		public bool validar() {
			DataTable tabla;
			Datos datos = new Datos();
			string consulta = "SELECT * FROM Persona WHERE Dni=" + this.dni;
			tabla = datos.consultar(consulta);

			if (tabla.Rows.Count > 0)	{

				this.nombre = tabla.Rows[0][1].ToString();
				this.apellido = tabla.Rows[0][2].ToString();
				return true;
			}
			else {
				return false; 
			}
		}
	}
}
