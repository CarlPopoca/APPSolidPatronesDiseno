using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FrmSolidPatronesDiseño.ModificadoresAcceso
{
	abstract class BaseAuto
	{
		public string Modelo { get; set; }
		private string Transmision { get; set; }
		protected string Motor { get; set; }
		internal string Tipo { get; set; }
		protected internal double Precio { get; set; }

		public BaseAuto ()
		{
			Modelo = "X";
		}
	}
}
