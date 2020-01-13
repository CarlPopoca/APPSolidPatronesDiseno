using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FrmSolidPatronesDiseño.PatronesDiseño.Builder
{
    public class Concesionario
    {
        private ConstructorAuto constructorAuto;

        public Concesionario(ConstructorAuto constructorAuto)
        {
            this.constructorAuto = constructorAuto;
        }

        public Auto ObtenerAuto() {
            return constructorAuto.ObtenerAuto();
        }

        public void ConstruirAuto()
        {
            constructorAuto.Nuevo();

            constructorAuto.ConstruirMotor();

            constructorAuto.ConstruirCarroceria();
        }

    }
}
