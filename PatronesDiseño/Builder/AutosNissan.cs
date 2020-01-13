using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FrmSolidPatronesDiseño.PatronesDiseño.Builder
{
    public class AutosNissan : ConstructorAuto
    {
        public override void ConstruirCarroceria()
        {
            auto.Cilindrada = 2900;
            auto.Potencia = 190;
        }

        public override void ConstruirMotor()
        {
            auto.Tipo = "Versa 1.8";
            auto.NumAsientos = 5;
        }
    }
}
