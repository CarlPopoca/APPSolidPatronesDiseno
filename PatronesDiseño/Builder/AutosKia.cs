using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FrmSolidPatronesDiseño.PatronesDiseño.Builder
{
   public class AutosKia: ConstructorAuto
    {
        public override void ConstruirMotor()
        {
            auto.Cilindrada = 3000;
            auto.Potencia = 200;
        }

        public override void ConstruirCarroceria()
        {
            auto.Tipo = "Rio Sedan 1.6";
            auto.NumAsientos = 5;
        }
    }
}
