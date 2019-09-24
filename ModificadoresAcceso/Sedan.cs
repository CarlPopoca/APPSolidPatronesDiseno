using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FrmSolidPatronesDiseño.ModificadoresAcceso
{
	class Sedan:BaseAuto
	{
		public string SedanModelo { get; set; }
		private string SedanTransmision { get; set; }
		protected string SedanMotor { get; set; }
		internal string SedanTipo { get; set; }
		protected internal double SedanPrecio { get; set; }
		public Sedan()
		{
			//Se permite acceder a la propiedad publico por herencia
			SedanModelo = Modelo;
			//No se puede acceder a metodos privados por herencia
			//SedanTransmision = Transmision;

			//Se permite acceder a la propiedad protected por herencia
			SedanMotor = Motor;
			//Se permite acceder a la propiedad internal por herencia
			SedanTipo = Tipo;
			//Se permite acceder a la propiedad protected internal por herencia
			SedanPrecio = Precio;

		}
	}
}
