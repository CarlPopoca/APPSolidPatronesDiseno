using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FrmSolidPatronesDiseño.PatronesDiseño.AbstractFactory
{
    public class DVDCapaSimple: DVD
    {
        //base.Cantidad, extrae el valor proporcionado en la clase abstracta
       
        public override int Cantidad()
        {
            return base.Cantidad() + 100;
        }
    }
}
