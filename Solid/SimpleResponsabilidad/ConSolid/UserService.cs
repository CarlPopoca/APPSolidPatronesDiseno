﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FrmSolidPatronesDiseño.Solid.SimpleResponsabilidad.ConSolid

{
	class UserService
	{
		private readonly BankService _bankService;

		public UserService(BankService bankService)
		{
			_bankService = bankService;
		}

		public bool PayMyDebts(string userID)
		{
			var success = false;

			// El usuario necesita saber si tiene dinero en el banco para cubrir su deuda del mes
			if (_bankService.HasMoneyAtBank(userID))
			{
				// El usuario va a pagar sus deudas para el mes actual
				success = true;
			}

			return success;
		}

	}

}
