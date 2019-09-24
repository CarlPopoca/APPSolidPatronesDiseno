using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FrmSolidPatronesDiseño.Solid.InterfaceSegregation.ConSolid
{
	class GranMago : IAtaqueAgua, IAtaqueFuego, IAtaqueViento
	{
		public string AtaqueAgua()
		{
			return "Ataque de agua";
		}

		public string AtaqueFuego()
		{
			return "Ataque de fuego";
		}

		public string AtaqueViento()
		{
			return "Ataque de viento";
		}
	}
}
