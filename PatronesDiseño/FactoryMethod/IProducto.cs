using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FrmSolidPatronesDiseño.PatronesDiseño.FactoryMethod
{
	interface IProducto
	{
		string Tipo { get; set; }
		double FactorGanancia { get; set; }
		List<Producto> ObtenerProductos();
	}
}
