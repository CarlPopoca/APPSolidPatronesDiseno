using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FrmSolidPatronesDiseño.Solid.InterfaceSegregation.SinSolid
{
	class MagoViento : IPoderesEspeciales
	{
		public string AtaqueFuego()
		{
			throw new Exception("No puede usar esto");
		}

		public string AtaqueViento()
		{
			return "Ataque de Viento";
		}

		public string AtaqueAgua()
		{
			throw new Exception("No puede usar esto");
		}
	}
}
