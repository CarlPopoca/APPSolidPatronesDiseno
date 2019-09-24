using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FrmSolidPatronesDiseño.Solid.OpenClosed.ConSolid
{
	class UserFeatures
	{
		public bool CanMakeAPayment(BaseUser user)
		{
			// Lógica de negocio
			if (user.Name.Equals("Admin") || user.Name.Equals("User"))
				return true;
			else
				return false;
		}
	}
}
