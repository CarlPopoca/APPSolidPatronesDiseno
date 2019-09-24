using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FrmSolidPatronesDiseño.Solid.InterfaceSegregation.ConSolid
{
	class MagoAgua : IAtaqueAgua
	{
		public string AtaqueAgua()
		{
			return "Ataque de agua";
		}
	}
}
