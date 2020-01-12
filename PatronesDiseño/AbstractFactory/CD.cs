using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FrmSolidPatronesDiseño.PatronesDiseño.AbstractFactory
{
    public abstract class CD : IProductoMultimedia
    {
        public virtual int Cantidad()
        {
            return 100;
        }

        public string Categoria()
        {
            return "Multimedia";
        }

        public string Nombre()
        {
            return "CD";
        }

        public virtual int Almacenamiento()
        {
            return 700;
        }
    }
}
