﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FrmSolidPatronesDiseño.Solid.DependencyInversion.ConSolid
{
	class Mailchimp : IEmailProvider
	{
		public string send()
		{
			return "Envio de correo del proveedor EmailChimp";
		}
	}
}
