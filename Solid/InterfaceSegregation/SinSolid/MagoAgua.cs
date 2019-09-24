using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FrmSolidPatronesDiseño.Solid.InterfaceSegregation.SinSolid
{
	class MagoAgua : IPoderesEspeciales
	{
		public string AtaqueAgua()
		{
			return "Ataque de Agua";
		}

		public string AtaqueFuego()
		{
			throw new NotImplementedException();
		}

		public string AtaqueViento()
		{
			throw new NotImplementedException();
		}
	}
}
