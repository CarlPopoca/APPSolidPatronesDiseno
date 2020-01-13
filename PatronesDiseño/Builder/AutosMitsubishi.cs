using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FrmSolidPatronesDiseño.PatronesDiseño.Builder
{
    public class AutosMitsubishi : ConstructorAuto
    {
        public override void ConstruirCarroceria()
        {
            auto.Cilindrada = 2800;
            auto.Potencia = 180;
        }

        public override void ConstruirMotor()
        {
            auto.Tipo = "Mirage 1.2";
            auto.NumAsientos= 5;
        }
    }
}
