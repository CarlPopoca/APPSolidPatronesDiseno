using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FrmSolidPatronesDiseño.PatronesDiseño.FactoryMethod
{
	class LineaBanca : IProducto
	{
		public string Tipo { get; set; }
		public double FactorGanancia { get; set; }
		public LineaBanca()
		{
			//Linea Blanca
			Tipo = "LB";
			FactorGanancia = .10;
		}
		public List<Producto> ObtenerProductos()
		{
			List<Producto> dbResult = new List<Producto>();
			dbResult.Add(new Producto()
			{
				Id = 1,
				Nombre = "Regrigerador",
				Cantidad = 12,
				Precio =  1000 * (1 + FactorGanancia)
			});

			return dbResult;
		}
	}
	
}
