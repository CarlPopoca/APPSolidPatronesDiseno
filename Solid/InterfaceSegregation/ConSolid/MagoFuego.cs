using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FrmSolidPatronesDiseño.Solid.InterfaceSegregation.ConSolid
{
	class MagoFuego : IAtaqueFuego
	{
		public string AtaqueFuego()
		{
			return "Ataque de fuego";
		}
	}
}
