using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using FrmSolidPatronesDiseño.ModificadoresAcceso;
using FrmSolidPatronesDiseño.RecargaMetodos;


namespace FrmSolidPatronesDiseño
{
	public partial class frmSobreCarga : Form
	{
		public frmSobreCarga()
		{
			InitializeComponent();
		}
		private void Button1_Click(object sender, EventArgs e)
		{
			cMensaje objMensaje;
			//Mostrar un mensaje simple
			if (rdbMensajeSimple.Checked)
			{
				objMensaje = new cMensaje();
				lblResultado.Text = objMensaje.Mensaje();
				
			}
			//Mostrar un mensaje compuesto
			if (rdbMensajeCompuesto.Checked)
			{
				objMensaje = new cMensaje();
				lblResultado.Text = objMensaje.Mensaje(txtMensajeUno.Text, txtMensajeDos.Text);
			}

			if (rdbPorConstructor.Checked)
			{
				if (string.IsNullOrEmpty(txtMensajeUno.Text) == false && string.IsNullOrEmpty(txtMensajeDos.Text) == false)
				{
					objMensaje = new cMensaje(txtMensajeUno.Text, txtMensajeDos.Text);
					lblResultado.Text = objMensaje.MensajeUno + "," + objMensaje.MensajeDos;
				}
				else {
					if (string.IsNullOrEmpty(txtMensajeUno.Text) == false)
						{
						objMensaje = new cMensaje(txtMensajeUno.Text);
						lblResultado.Text = objMensaje.MensajeUno;
					}
					if (string.IsNullOrEmpty(txtMensajeDos.Text) == false) {
						objMensaje = new cMensaje(txtMensajeDos.Text);
						lblResultado.Text = objMensaje.MensajeUno;
					}
				}
			}

		}

		private void BtnModificadoresAcceso_Click(object sender, EventArgs e)
		{
            Sedan sedan;

			if (rdbInstancia.Checked)
			{
				if (cmbInstanciaMod.Text == "Public")
				{
                    //Por instancia se puede puede acceder a propiedades publicas
                    sedan = new Sedan();
                    lblResultadoModAcceso.Text = "Se puede acceder a propiedades " + sedan.SedanModelo.ToString();
                }
				if (cmbInstanciaMod.Text == "Private")
				{
					lblResultadoModAcceso.Text = "No se puede acceder a propiedades";
				}
				if (cmbInstanciaMod.Text == "Protected")
				{
					lblResultadoModAcceso.Text = "No se puede acceder a propiedades";
				}
				if (cmbInstanciaMod.Text == "Protected Internal")
				{
                    sedan = new Sedan();
                    lblResultadoModAcceso.Text = "Se puede acceder a propiedades" + sedan.SedanPrecio.ToString();
				}
				if (cmbInstanciaMod.Text == "Internal")
				{
                    sedan = new Sedan();
                    lblResultadoModAcceso.Text = "Se puede acceder a propiedades" + sedan.SedanTipo;
				}
			}

			if (rdbHerencia.Checked)
			{
				if (cmbInstanciaMod.Text == "Public")
				{
					//Por herencia se puede puede acceder a propiedades publicas
					lblResultadoModAcceso.Text = "Se puede acceder a propiedades ";
				}
				if (cmbInstanciaMod.Text == "Private")
				{
					//Por herencia no se puede puede acceder a propiedades privadas
					lblResultadoModAcceso.Text = "No se puede acceder a propiedades";
				}
				if (cmbInstanciaMod.Text == "Protected")
				{
					//Por herencia se puede puede acceder a propiedades protected
					lblResultadoModAcceso.Text = "Se puede acceder a propiedades";
				}
				if (cmbInstanciaMod.Text == "Protected Internal")
				{
					lblResultadoModAcceso.Text = "Se puede acceder a propiedades";
				}
				if (cmbInstanciaMod.Text == "Internal")
				{
					lblResultadoModAcceso.Text = "Se puede acceder a propiedades";
				}
			}

		}
	}
}
