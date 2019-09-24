using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FrmSolidPatronesDiseño.Solid.SimpleResponsabilidad.ConSolid
{
	class BankService
	{
		public bool HasMoneyAtBank(string userId)
		{
			if (userId == "Prueba" )
				return true;
			else
				return false;
		}
	}
}
