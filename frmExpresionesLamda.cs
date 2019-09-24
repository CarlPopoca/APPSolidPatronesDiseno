using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FrmSolidPatronesDiseño
{
	public partial class frmExpresionesLamda: Form
	{
		public frmExpresionesLamda()
		{
			InitializeComponent();
		}
		private void InitializeComponent()
		{
			this.btnMostrar = new System.Windows.Forms.Button();
			this.grbExpresiones = new System.Windows.Forms.GroupBox();
			this.rdbSelect = new System.Windows.Forms.RadioButton();
			this.rdbFuncConMultiplicacion = new System.Windows.Forms.RadioButton();
			this.rdbTakeWhile = new System.Windows.Forms.RadioButton();
			this.lblDefinicion = new System.Windows.Forms.Label();
			this.rdbFuncBool = new System.Windows.Forms.RadioButton();
			this.lblResultado = new System.Windows.Forms.Label();
			this.rdbAction = new System.Windows.Forms.RadioButton();
			this.grbExpresiones.SuspendLayout();
			this.SuspendLayout();
			// 
			// btnMostrar
			// 
			this.btnMostrar.Location = new System.Drawing.Point(689, 300);
			this.btnMostrar.Name = "btnMostrar";
			this.btnMostrar.Size = new System.Drawing.Size(75, 23);
			this.btnMostrar.TabIndex = 0;
			this.btnMostrar.Text = "Mostrar";
			this.btnMostrar.UseVisualStyleBackColor = true;
			this.btnMostrar.Click += new System.EventHandler(this.btnMostrar_Click);
			// 
			// grbExpresiones
			// 
			this.grbExpresiones.Controls.Add(this.rdbAction);
			this.grbExpresiones.Controls.Add(this.rdbFuncBool);
			this.grbExpresiones.Controls.Add(this.rdbSelect);
			this.grbExpresiones.Controls.Add(this.rdbFuncConMultiplicacion);
			this.grbExpresiones.Controls.Add(this.rdbTakeWhile);
			this.grbExpresiones.Location = new System.Drawing.Point(12, 12);
			this.grbExpresiones.Name = "grbExpresiones";
			this.grbExpresiones.Size = new System.Drawing.Size(344, 311);
			this.grbExpresiones.TabIndex = 1;
			this.grbExpresiones.TabStop = false;
			this.grbExpresiones.Text = "Expresiones";
			// 
			// rdbSelect
			// 
			this.rdbSelect.AutoSize = true;
			this.rdbSelect.Location = new System.Drawing.Point(6, 66);
			this.rdbSelect.Name = "rdbSelect";
			this.rdbSelect.Size = new System.Drawing.Size(128, 17);
			this.rdbSelect.TabIndex = 2;
			this.rdbSelect.TabStop = true;
			this.rdbSelect.Text = "Select con String.Join";
			this.rdbSelect.UseVisualStyleBackColor = true;
			this.rdbSelect.Click += new System.EventHandler(this.RdbSelect_Click);
			// 
			// rdbFuncConMultiplicacion
			// 
			this.rdbFuncConMultiplicacion.AutoSize = true;
			this.rdbFuncConMultiplicacion.Location = new System.Drawing.Point(6, 43);
			this.rdbFuncConMultiplicacion.Name = "rdbFuncConMultiplicacion";
			this.rdbFuncConMultiplicacion.Size = new System.Drawing.Size(182, 17);
			this.rdbFuncConMultiplicacion.TabIndex = 1;
			this.rdbFuncConMultiplicacion.TabStop = true;
			this.rdbFuncConMultiplicacion.Text = "Func<int, int> square = x => x * x;";
			this.rdbFuncConMultiplicacion.UseVisualStyleBackColor = true;
			this.rdbFuncConMultiplicacion.Click += new System.EventHandler(this.RdbFuncConMultiplicacion_Click);
			// 
			// rdbTakeWhile
			// 
			this.rdbTakeWhile.AutoSize = true;
			this.rdbTakeWhile.Location = new System.Drawing.Point(6, 20);
			this.rdbTakeWhile.Name = "rdbTakeWhile";
			this.rdbTakeWhile.Size = new System.Drawing.Size(77, 17);
			this.rdbTakeWhile.TabIndex = 0;
			this.rdbTakeWhile.TabStop = true;
			this.rdbTakeWhile.Text = "TakeWhile";
			this.rdbTakeWhile.UseVisualStyleBackColor = true;
			this.rdbTakeWhile.Click += new System.EventHandler(this.RdbTakeWhile_Click);
			// 
			// lblDefinicion
			// 
			this.lblDefinicion.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.lblDefinicion.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblDefinicion.Location = new System.Drawing.Point(375, 12);
			this.lblDefinicion.Name = "lblDefinicion";
			this.lblDefinicion.Size = new System.Drawing.Size(389, 151);
			this.lblDefinicion.TabIndex = 9;
			// 
			// rdbFuncBool
			// 
			this.rdbFuncBool.AutoSize = true;
			this.rdbFuncBool.Location = new System.Drawing.Point(6, 89);
			this.rdbFuncBool.Name = "rdbFuncBool";
			this.rdbFuncBool.Size = new System.Drawing.Size(270, 17);
			this.rdbFuncBool.TabIndex = 3;
			this.rdbFuncBool.TabStop = true;
			this.rdbFuncBool.Text = "Func<int, int, bool> testForEquality = (x, y) => x == y;";
			this.rdbFuncBool.UseVisualStyleBackColor = true;
			this.rdbFuncBool.Click += new System.EventHandler(this.RdbFuncBool_Click);
			// 
			// lblResultado
			// 
			this.lblResultado.AutoSize = true;
			this.lblResultado.Location = new System.Drawing.Point(372, 242);
			this.lblResultado.Name = "lblResultado";
			this.lblResultado.Size = new System.Drawing.Size(0, 13);
			this.lblResultado.TabIndex = 10;
			// 
			// rdbAction
			// 
			this.rdbAction.AutoSize = true;
			this.rdbAction.Location = new System.Drawing.Point(6, 112);
			this.rdbAction.Name = "rdbAction";
			this.rdbAction.Size = new System.Drawing.Size(55, 17);
			this.rdbAction.TabIndex = 4;
			this.rdbAction.TabStop = true;
			this.rdbAction.Text = "Action";
			this.rdbAction.UseVisualStyleBackColor = true;
			this.rdbAction.Click += new System.EventHandler(this.RdbAction_Click);
			// 
			// frmExpresionesLamda
			// 
			this.ClientSize = new System.Drawing.Size(776, 335);
			this.Controls.Add(this.lblResultado);
			this.Controls.Add(this.lblDefinicion);
			this.Controls.Add(this.grbExpresiones);
			this.Controls.Add(this.btnMostrar);
			this.Name = "frmExpresionesLamda";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Expresiones Lamda";
			this.grbExpresiones.ResumeLayout(false);
			this.grbExpresiones.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();
		}

		private void btnMostrar_Click(object sender, EventArgs e)
		{
			if (rdbTakeWhile.Checked)
			{
				string datos= string.Empty;
				int[] numbers = { 5, 4, 1, 3, 9, 8, 6, 7, 2, 0 };
				var firstSmallNumbers = numbers.TakeWhile((n, index) => n >= index);
				foreach (int intNumero in firstSmallNumbers)
				{
					datos = datos + intNumero.ToString() + ",";
				}
				lblResultado.Text = datos.Substring(0, datos.Length-1);
			}

			if (rdbFuncConMultiplicacion.Checked)
			{
				Func<int, int> square = x => x * x;
				lblResultado.Text = square(5).ToString();
			}
			if (rdbSelect.Checked)
			{
				int[] numbers = { 2, 3, 4, 5 };
				var squaredNumbers = numbers.Select(x => x * x);
				lblResultado.Text =  string.Join(" ", squaredNumbers);
			}
			if (rdbFuncBool.Checked)
			{
				Func<int, int, bool> testForEquality = (x, y) => x == y;
				lblResultado.Text = testForEquality(7, 7).ToString();
			}
			if (rdbAction.Checked)
			{
				Action<string> greet = name =>
				{
					string greeting = $"Hello {name}!";
					lblResultado.Text = greeting;
				};
				greet("World");
			}
		}

		private void RdbTakeWhile_Click(object sender, EventArgs e)
		{
			string mensaje = string.Empty;
			mensaje = "Devuelve elementos de una secuencia siempre que una condición especificada sea verdadera y luego omite los elementos restantes."+ Environment.NewLine;
			mensaje = mensaje + "int[] numbers = { 5, 4, 1, 3, 9, 8, 6, 7, 2, 0 };" + Environment.NewLine;
			mensaje = mensaje + "var firstSmallNumbers = numbers.TakeWhile((n, index) => n >= index)";
			lblDefinicion.Text = mensaje;
		}

		private void RdbFuncConMultiplicacion_Click(object sender, EventArgs e)
		{
			string mensaje = string.Empty;
			mensaje = "Es una función que recibe un parametro el cual lo multiplica por si mismo" + Environment.NewLine;
			mensaje = mensaje + "Forma de ejecutarlo: square(5).ToString()";
			lblDefinicion.Text = mensaje;
		}

		private void RdbSelect_Click(object sender, EventArgs e)
		{
			string mensaje = string.Empty;
			mensaje = "Select es una expresión que aplica a List o arrays y que permite acceder a sus datos y ejecutar" + Environment.NewLine;
			mensaje = mensaje + "alguna acción sobre ellos y String.Join construye una sola cadena concatenando los datos y separarlos con el caracter que especifique, ejemplo: " + Environment.NewLine;
			mensaje = mensaje + "int[] numbers = { 2, 3, 4, 5 };" + Environment.NewLine;
			mensaje = mensaje + "var squaredNumbers = numbers.Select(x => x * x);" +Environment.NewLine;
			mensaje = mensaje + "string.Join(' ', squaredNumbers)";
			lblDefinicion.Text = mensaje;

		}
		private void RdbFuncBool_Click(object sender, EventArgs e)
		{
			string mensaje = string.Empty;
			mensaje = "Función para devolver true si dos enteros son iguales o false de lo contrario" + Environment.NewLine;
			mensaje = mensaje + "Forma de ejecutarlo: testForEquality (7,7).ToString()";
			lblDefinicion.Text = mensaje;
		}

		private void RdbAction_Click(object sender, EventArgs e)
		{
			string mensaje = string.Empty;
			mensaje = "Una declaración lambda se asemeja a una expresión lambda, excepto que las declaraciones están encerradas entre llaves" + Environment.NewLine;
			mensaje = mensaje + "Ejemplo de uso de declaración Action:" + Environment.NewLine;
			mensaje = mensaje + "Action<string> greet = name => " + Environment.NewLine;
			mensaje = mensaje + "{" + Environment.NewLine; 
			mensaje = mensaje + "	string greeting = $'Hello { name}!';" + Environment.NewLine;
			mensaje = mensaje + "	LblMensaje.Text = greeting;" + Environment.NewLine;
			mensaje = mensaje + "};" + Environment.NewLine;
			mensaje = mensaje + "greet('World');";
			lblDefinicion.Text = mensaje;
		}
	}
}
