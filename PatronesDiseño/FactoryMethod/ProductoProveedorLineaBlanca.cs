using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FrmSolidPatronesDiseño.PatronesDiseño.FactoryMethod
{
	class ProductoProveedorLineaBlanca : IProductoProveedor
	{
		public IProducto GetProducto()
		{
			return new LineaBanca();
		}
	}
}
