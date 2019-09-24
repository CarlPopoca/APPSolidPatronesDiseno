using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FrmSolidPatronesDiseño.PatronesDiseño.FactoryMethod
{
	class Hogar : IProducto
	{
		public string Tipo { get; set; }
		public double FactorGanancia { get; set; }

		public Hogar()
		{
			Tipo = "HG";
			FactorGanancia = .20;
		}
		public List<Producto> ObtenerProductos()
		{
			List<Producto> dbResult = new List<Producto>();
			dbResult.Add(new Producto {
				Id = 2,
				Nombre = "Sala",
				Cantidad = 8,
				Precio = 5000 * (1+FactorGanancia)
			});

			return dbResult;
		}
	}
}
