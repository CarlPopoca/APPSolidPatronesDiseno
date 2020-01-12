using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FrmSolidPatronesDiseño.PatronesDiseño.AbstractFactory
{
    public class ProveedorDVD : IFabricaDVD
    {
        public DVD CrearDVDCapaDoble()
        {
            return new DVDCapaDoble();
        }

        public DVD CrearDVDCapaSimple()
        {
            return new DVDCapaSimple();
        }
    }
}
