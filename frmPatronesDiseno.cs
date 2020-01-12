using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using FrmSolidPatronesDiseño.PatronesDiseño.Singleton;
using FrmSolidPatronesDiseño.PatronesDiseño.FactoryMethod;
using FrmSolidPatronesDiseño.PatronesDiseño.Prototype;
using FrmSolidPatronesDiseño.PatronesDiseño.AbstractFactory;

namespace FrmSolidPatronesDiseño
{
	public partial class frmPatronesDiseno : Form
	{
		public frmPatronesDiseno()
		{
			InitializeComponent();
		}

		private void BtnMostrarResultado_Click(object sender, EventArgs e)
		{
			IProductoProveedor producto;
			Reloj reloj;
			List<Producto> prod = new List<Producto>();

			if (rdbSingleton.Checked)
			{
				reloj = Reloj.ObtenerTiempoIngreso();
				lblResultado.Text = reloj.tiempoIngreso.ToString();
			}

			if (rdbFactoryMethod.Checked)
			{
                switch (cmbTipoProveedorFactoryMethod.SelectedIndex)
                {
                    case 0:
                        producto = new ProductoProveedorLineaBlanca();
                        prod = producto.GetProducto().ObtenerProductos();
                        lblResultado.Text = prod.First().Precio.ToString();
                        break;
                    case 1:
                        producto = new ProductoProveedorHogar();
                        prod = producto.GetProducto().ObtenerProductos();
                        lblResultado.Text = prod.First().Precio.ToString();
                        break;
                    default:
                        lblResultado.Text = "No hay resultados para esa opción";
                        break;
                }
			}

			if (this.rdbPrototype.Checked)
			{
				UploadedFile objPrimario = new UploadedFile();
				objPrimario.FileName = "Libro de ciencia ficción";
				objPrimario.ContentType = "Acción y realidades alternativas";
				objPrimario.size = 300;

				objPrimario.TimeStamp = DateTime.Now;
				IUploadedFile objRespaldo = objPrimario.Clone();
				UploadedFile objSecundario = (UploadedFile)objRespaldo;
				lblResultado.Text = objSecundario.FileName + "," + objSecundario.ContentType;
			}

            if (this.rdbAbstractFactory.Checked)
            {
                string Almacenamiento = "Almacenamiento ";
                 switch (this.cmbProductoAbstractFactory.SelectedIndex)
                {
                    case 0:
                        IFabricaCD objCDR = new ProveedorCD();
                        this.lblResultado.Text = Almacenamiento + objCDR.CrearCDR().Almacenamiento().ToString();
                        break;
                    case 1:
                        IFabricaCD objCDRW = new ProveedorCD();
                        this.lblResultado.Text = Almacenamiento + objCDRW.CrearCDRW().Almacenamiento().ToString();
                        break;
                    case 2:
                        IFabricaDVD objDVDCS = new ProveedorDVD();
                        this.lblResultado.Text = Almacenamiento + objDVDCS.CrearDVDCapaSimple().Almacenamiento().ToString();
                        break;
                    case 3:
                        IFabricaDVD objDVDCD = new ProveedorDVD();
                        this.lblResultado.Text = Almacenamiento + objDVDCD.CrearDVDCapaDoble().Almacenamiento().ToString();
                        break;
                    default:
                        this.lblResultado.Text = "No hay resultados para esa opción";
                        break;
                }     
            }
		}
		private void ConfiguracionControles(bool singleton, bool factoryMethod, bool Prototype, bool abstractFactory) {
            cmbProductoAbstractFactory.SelectedIndex = -1;
            cmbTipoProveedorFactoryMethod.SelectedIndex = -1;
            lblResultado.Text = string.Empty;
            lblTipoProveedorFactoryMethod.Visible = factoryMethod;
			cmbTipoProveedorFactoryMethod.Visible = factoryMethod;
            lblProductoAbstractFactory.Visible = abstractFactory;
            cmbProductoAbstractFactory.Visible = abstractFactory;
		}

        private void RdbSingleton_Click(object sender, EventArgs e)
        {
            string mensaje = "Singleton (Instancia única): Es un patrón de diseño que permite restringir la creación de objetos pertenecientes a una clase o el valor de un tipo a un único objeto." + Environment.NewLine;
            mensaje = mensaje + "Uso " + Environment.NewLine;
            mensaje = mensaje + "Cuando cierto tipo de datos debe estar disponible para todos los demás objetos de la aplicación." + Environment.NewLine;
            mensaje = mensaje + "Para controlar el acceso a un solo objeto. " + Environment.NewLine;
            lblDefinicion.Text = mensaje;
            ConfiguracionControles(true, false, false, false); ;
        }
        private void RdbFactoryMethod_Click(object sender, EventArgs e)
		{
			string mensaje;
			mensaje = "Factory Method (Método de fabricación): permite la creación de objetos de un subtipo determinado a través de una clase Factory,  la cual oculta los detalles de creación del objeto, es una versión resumida del Abstract Factory. " + Environment.NewLine;
            mensaje = mensaje + "Uso" + Environment.NewLine;
            mensaje = mensaje + "Es especialmente útil cuando no sabemos en tiempo de diseño, el subtipo que vamos a utilizar. " + Environment.NewLine;
			mensaje = mensaje + "Cuando queremos delegar la lógica de creación de los objetos a una clase Factory," + Environment.NewLine;
			lblDefinicion.Text = mensaje;
			ConfiguracionControles(false, true,false, false);
		}

		private void RdbPrototype_Click(object sender, EventArgs e)
		{
			string mensaje = "Prototype:Tiene como finalidad crear nuevos objetos clonando ";
            mensaje = mensaje + "una instancia creada previamente." + Environment.NewLine;
			mensaje = mensaje + "Uso" + Environment.NewLine;
			mensaje = mensaje + "La creación de nuevos objetos acarrea un coste computacional elevado" + Environment.NewLine;
			mensaje = mensaje + "Los objetos a crear tienen o suelen tener atributos que repiten su valor." + Environment.NewLine;
			lblDefinicion.Text = mensaje;
            ConfiguracionControles(false, false, true, false); ;
		}

		private void RdbAbstractFactory_Click(object sender, EventArgs e)
		{
			string mensaje = " Abstract Factory Proporciona una interfaz para crear familias de objetos relacionados" + Environment.NewLine;
			mensaje = mensaje + " o que dependen entre sí, sin especificar sus clases concretas." + Environment.NewLine;
			mensaje = mensaje + " Uso" + Environment.NewLine;
			mensaje = mensaje + "Cuando la creación de objetos debe ser independiente del sistema que los utiliza." + Environment.NewLine;
			mensaje = mensaje + "El sistema debe ser capaz de crear y usar múltiples familias de objetos." + Environment.NewLine;
			mensaje = mensaje + "Se prevé la inclusión de nuevas familias de productos." + Environment.NewLine;
			mensaje = mensaje + "Las librerías deben ser publicadas sin exponer detalles de implementación";
			mensaje = mensaje + "Clases concretas deben ser disociadas de los clientes, es decir se separa el código del cliente de la creación de objetos.";
			lblDefinicion.Text = mensaje;
            ConfiguracionControles(false, false, false, true); ;
        }

    }
}
