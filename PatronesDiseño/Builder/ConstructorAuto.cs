using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FrmSolidPatronesDiseño.PatronesDiseño.Builder
{
   public abstract class ConstructorAuto
    {

        protected Auto auto;

        public void Nuevo() {
            auto = new Auto();
        }

        public Auto ObtenerAuto()
        {
            return auto;
        }
        public abstract void ConstruirMotor();

        public abstract void ConstruirCarroceria();
    }
}
