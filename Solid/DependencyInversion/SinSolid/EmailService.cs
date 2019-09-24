using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FrmSolidPatronesDiseño.Solid.DependencyInversion.SinSolid
{
	class EmailService
	{
		public string  SendAnEmailUsingSendGrid(Sendgrid mailProvider)
		{
			return mailProvider.Send();
		}

		public string  SendAnEmailUsingMailchimp(Mailchimp mailProvider)
		{
			return mailProvider.Send();
		}
	}
}
