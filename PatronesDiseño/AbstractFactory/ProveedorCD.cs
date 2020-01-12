using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FrmSolidPatronesDiseño.PatronesDiseño.AbstractFactory
{
    class ProveedorCD : IFabricaCD
    {
        public CD CrearCDR()
        {
            return new CDR();
        }

        public CD CrearCDRW()
        {
            return new CDRW();
        }
    }
}
