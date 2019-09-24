using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FrmSolidPatronesDiseño.Solid.InterfaceSegregation.SinSolid
{
	class GranMago : IPoderesEspeciales
	{
		public string AtaqueFuego()
		{
			return "Ataque de Fuego";
		}

		public string AtaqueViento()
		{
			return "Ataque de Viento";
		}

		public string AtaqueAgua()
		{
			return "Ataque de Agua";
		}
	}
}
