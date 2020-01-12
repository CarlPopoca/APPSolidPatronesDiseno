using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FrmSolidPatronesDiseño.PatronesDiseño.AbstractFactory
{
    public abstract class DVD : IProductoMultimedia
    {
        public virtual int Cantidad()
        {
            return 200;
        }

        public string Categoria()
        {
            return "Multimedia";
        }

        public string Nombre()
        {
            return "DVD";
        }

        public virtual int Almacenamiento()
        {
            return 4700;
        }
    }
}
