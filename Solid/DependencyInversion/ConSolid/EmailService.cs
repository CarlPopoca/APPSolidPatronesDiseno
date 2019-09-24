using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FrmSolidPatronesDiseño.Solid.DependencyInversion.ConSolid
{
	class EmailService
	{
		private readonly IEmailProvider _emailProvider;

		public EmailService(IEmailProvider emailProvider)
		{
			_emailProvider = emailProvider;
		}

		public string send() {
			return _emailProvider.send();
		}
	}
}
