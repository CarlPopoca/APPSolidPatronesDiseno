﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FrmSolidPatronesDiseño.PatronesDiseño.AbstractFactory
{
    public class CDRW: CD
    {
        public override int Cantidad()
        {
            return 300;
        }
    }
}
