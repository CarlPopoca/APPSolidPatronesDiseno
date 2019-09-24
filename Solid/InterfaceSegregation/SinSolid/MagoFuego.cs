using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FrmSolidPatronesDiseño.Solid.InterfaceSegregation.SinSolid
{
	class MagoFuego : IPoderesEspeciales
	{
		public string AtaqueFuego()
		{
			return "Ataque de Fuego";
		}

		public string AtaqueViento()
		{
			throw new Exception("No puede usar esto");
		}

		public string AtaqueAgua()
		{
			throw new Exception("No puede usar esto");
		}
	}
}
