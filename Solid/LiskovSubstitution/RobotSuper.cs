using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FrmSolidPatronesDiseño.Solid.LiskovSubstitution
{
	class RobotSuper: Robot
	{
		public override int Attack()
		{
			return 200; // Damage Points
		}
	}
}
