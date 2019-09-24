using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using FrmSolidPatronesDiseño.Solid.SimpleResponsabilidad;
using FrmSolidPatronesDiseño.Solid.OpenClosed;
using FrmSolidPatronesDiseño.Solid.LiskovSubstitution;
using FrmSolidPatronesDiseño.Solid.SimpleResponsabilidad.ConSolid;
using FrmSolidPatronesDiseño.Solid.OpenClosed.ConSolid;
using FrmSolidPatronesDiseño.Solid.InterfaceSegregation.ConSolid;
using FrmSolidPatronesDiseño.Solid.DependencyInversion.ConSolid;


namespace FrmSolidPatronesDiseño
{
	public partial class frmSolid : Form
	{
		public frmSolid()
		{
			InitializeComponent();
		}

		private void Configuracioncontroles(bool blSR, bool blOC, bool blLS, bool blISP, bool blDIP)
		{
			lblUsuarioSR.Visible = blSR;
			cmbUsuarioSR.Visible = blSR;
			cmbTipoUsuarioOSP.Visible = blOC;
			lblTipoUsuarioOSP.Visible = blOC;
			LblTipoRobotLSP.Visible = blLS;
			cmbTipoRobotLSP.Visible = blLS;
			lblMagoISP.Visible = blISP;
			cmbMagoISP.Visible = blISP;
			lblProveedorEmailDIP.Visible = blDIP;
			cmbProveedorEmailDIP.Visible = blDIP;
		}

		private void RdbSR_Click(object sender, EventArgs e)
		{
			lblDefinicion.Text = "Cada módulo de tu software tiene una sola responsabilidad, por lo tanto no debería ser mutli tarea.";
			LimpiarControles();
			Configuracioncontroles(true, false, false, false, false);
		}

		private void RdpOC_Click(object sender, EventArgs e)
		{
			lblDefinicion.Text = "Una clase u objeto debe estar disponible para su extensión pero no para su modificación.";
			LimpiarControles();
			Configuracioncontroles(false, true,false, false, false);
		}

		private void LimpiarControles() {
			cmbUsuarioSR.Text = string.Empty;
			lblResultado.Text = string.Empty;
			cmbMagoISP.Text = string.Empty;
			cmbProveedorEmailDIP.Text = string.Empty;
			cmbTipoRobotLSP.Text = string.Empty;
			cmbTipoUsuarioOSP.Text = string.Empty;
		}
		private void RdbLSP_Click(object sender, EventArgs e)
		{
			lblDefinicion.Text = "Si S es un subtipo de T, entonces los objetos de tipo T en un programa de computadora pueden ser sustituidos por objetos de tipo S (es decir, los objetos de tipo S pueden sustituir objetos de tipo T), sin alterar ninguna de las propiedades deseables de ese programa (la corrección, la tarea que realiza, etc.) - Wikpedia";
			LimpiarControles();
			Configuracioncontroles(false, false, true, false, false);
		}

		private void ISP_Click(object sender, EventArgs e)
		{
			lblDefinicion.Text = "Partiendo del primer principio, lo que quiere decir basicamente este es que aprendas a crear interfaces para definir comportamientos y de esta manera lo puedas desacoplar libremente.";
			LimpiarControles();
			Configuracioncontroles(false, false, false, true, false);
		}

		private void RdbDIP_Click(object sender, EventArgs e)
		{
			lblDefinicion.Text = "en pocas palabras es hacer uso de inyección de dependencia para evitar de esta manera trabajar con las instancias dentro de nuestro código";
			LimpiarControles();
			Configuracioncontroles(false, false, false, false, true);
		}

		private void BtnMostrarResultado_Click(object sender, EventArgs e)
		{
			//Variables Simple Responsabilidad
			BankService objBankService;
			UserService objService;
			//Variables Open Closed
			Admin objAdmin;
			UserFeatures userFeatures;
			User objUser;
			//Variables Liskov Sustitución
			Robot objRobot;
			//Variables de segregación de interfaces
			IAtaqueAgua objMagoAgua;
			IAtaqueViento objMagoViento;
			IAtaqueFuego objMagoFuego;
			string strAtaqueAgua, strAtaqueViento, strAtaqueFuego;
			//Variables Inversión de Dependencias
			IEmailProvider emailProvider;
			EmailService emailService;

			//LLamada a metodo Simple Responsabilidad
			if (this.rdbSR.Checked)
			{
				objBankService = new BankService();
				objService = new UserService(objBankService);
				if (objService.PayMyDebts(cmbUsuarioSR.Text))
					lblResultado.Text = "Si tiene dinero";
				else
					lblResultado.Text = "No tiene dinero";
			}
			//LLamada a metodo Open Closed
			if (this.rdpOC.Checked)
			{
				if (this.cmbTipoUsuarioOSP.Text == "Admin")
				{
					objAdmin = new Admin();
					objAdmin.Id = 1;
					objAdmin.Name = this.cmbTipoUsuarioOSP.Text;
					userFeatures = new UserFeatures();
					if (userFeatures.CanMakeAPayment(objAdmin))
						this.lblResultado.Text = "Se realizo el pago del Admin";
					else
						this.lblResultado.Text = "No se realizo el pago";
				}
				else
				{
					objUser = new User();
					objUser.Id = 2;
					objUser.Name = cmbTipoUsuarioOSP.Text;
					userFeatures = new UserFeatures();
					if (userFeatures.CanMakeAPayment(objUser))
						this.lblResultado.Text = "Se realizo el pago del User";
					else
						this.lblResultado.Text = "No se realizo el pago";
				}
			}
			if (this.rdbLSP.Checked == true)
			{
				//LLamada a metodo Liskov Substitution
				if (this.cmbTipoRobotLSP.Text.Equals("Normal"))
				{
					objRobot = new RobotNormal();
					lblResultado.Text = objRobot.Attack().ToString();
				}
				if (this.cmbTipoRobotLSP.Text.Equals("Super"))
				{
					objRobot = new RobotSuper();

                    lblResultado.Text = objRobot.Attack().ToString();
				}
				if (this.cmbTipoRobotLSP.Text.Equals("Mega"))
				{
					objRobot = new RobotMega();
					lblResultado.Text = objRobot.Attack().ToString();
				}
			}
			//Llamada a metodo de Segregación de interfaces
			if (this.rdbISP.Checked == true) {
				if (this.cmbMagoISP.Text.Equals("Agua"))
					{
					objMagoAgua = new MagoAgua();
					lblResultado.Text = objMagoAgua.AtaqueAgua();
				}
				if (this.cmbMagoISP.Text.Equals("Viento"))
				{
					objMagoViento = new MagoViento();
					lblResultado.Text = objMagoViento.AtaqueViento();
				}
				if (this.cmbMagoISP.Text.Equals("Fuego"))
				{
					objMagoFuego = new MagoFuego();
					lblResultado.Text = objMagoFuego.AtaqueFuego();
				}
				if (this.cmbMagoISP.Text.Equals("Gran Mago"))
				{
					objMagoAgua = new GranMago();
					strAtaqueAgua = objMagoAgua.AtaqueAgua();
					objMagoViento = new GranMago();
					strAtaqueViento = objMagoViento.AtaqueViento();
					objMagoFuego = new GranMago();
					strAtaqueFuego = objMagoFuego.AtaqueFuego();
					lblResultado.Text = strAtaqueAgua + "," + strAtaqueViento + "," + strAtaqueFuego;
				}
			}
			//LLamada a metodo Inversión de dependencias
			if (this.rdbDIP.Checked)
			{
				if (this.cmbProveedorEmailDIP.Text.Equals("EmailChimp"))
				{
					emailProvider = new Mailchimp();
					emailService = new EmailService(emailProvider);
					lblResultado.Text = emailService.send();
				}
				if (this.cmbProveedorEmailDIP.Text.Equals("SendGrid"))
				{
					emailProvider = new Sendgrid();
					emailService = new EmailService(emailProvider);
					lblResultado.Text = emailService.send();
				}
			}

		}

		private void FrmSolid_Load(object sender, EventArgs e)
		{
			Configuracioncontroles(false, false, false, false, false);
		}
    }
}