using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FrmSolidPatronesDiseño.RecargaMetodos
{
	class cMensaje
	{
     

        public string MensajeUno { get; set; }
		public string MensajeDos { get; set; }
		public string Mensaje() {

			return "Este es un mensaje simple";
		}

		public string Mensaje(string strMensajeUno, string strMensajedos)
		{
			return strMensajeUno + ","+strMensajedos;
		}

		public cMensaje(string mensajeUno, string mensajeDos)
		{
			MensajeUno = mensajeUno;
			MensajeDos = mensajeDos;
		}
		public cMensaje(string mensajeUno)
		{
			MensajeUno = mensajeUno;
		}
		public cMensaje()
		{

		}

	}
}
