using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace FrmSolidPatronesDiseño.PatronesDiseño.Singleton
{
	
	class Reloj
	{
		public DateTime tiempoIngreso { get; set; }
		private static Reloj reloj;
		public Reloj()
		{
		}

		public static Reloj ObtenerTiempoIngreso()
		{

			if (reloj == null)
				{
				reloj = new Reloj();

				reloj.tiempoIngreso = DateTime.Now;
			}
			return reloj;
		}
	}
}
