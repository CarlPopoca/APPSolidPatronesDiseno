using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FrmSolidPatronesDiseño.Solid.InterfaceSegregation.ConSolid
{
	class MagoViento : IAtaqueViento
	{
		public string AtaqueViento()
		{
			return "Ataque de viento";
		}
	}
}
