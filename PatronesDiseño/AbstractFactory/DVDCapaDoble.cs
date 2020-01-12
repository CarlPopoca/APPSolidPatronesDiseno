using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FrmSolidPatronesDiseño.PatronesDiseño.AbstractFactory
{
    public class DVDCapaDoble: DVD
    {
        public override int Cantidad()
        {
            return base.Cantidad()+300;
        }

        public override int Almacenamiento()
        {
            return 8500;
        }
    }
}
