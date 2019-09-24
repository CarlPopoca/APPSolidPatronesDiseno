using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FrmSolidPatronesDiseño.Solid.LiskovSubstitution
{
	abstract class Robot
	{
		public virtual int Attack()
		{
			return 100; // Damage Points
		}
		
	}
}
