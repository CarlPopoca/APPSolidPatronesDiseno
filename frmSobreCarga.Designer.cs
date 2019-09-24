namespace FrmSolidPatronesDiseño
{
	partial class frmSobreCarga
	{
		/// <summary>
		/// Variable del diseñador necesaria.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Limpiar los recursos que se estén usando.
		/// </summary>
		/// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Código generado por el Diseñador de Windows Forms

		/// <summary>
		/// Método necesario para admitir el Diseñador. No se puede modificar
		/// el contenido de este método con el editor de código.
		/// </summary>
		private void InitializeComponent()
		{
			this.pnlSobrecargaMetodos = new System.Windows.Forms.Panel();
			this.lblResultado = new System.Windows.Forms.Label();
			this.rdbPorConstructor = new System.Windows.Forms.RadioButton();
			this.rdbMensajeCompuesto = new System.Windows.Forms.RadioButton();
			this.rdbMensajeSimple = new System.Windows.Forms.RadioButton();
			this.btnSobreCarga = new System.Windows.Forms.Button();
			this.txtMensajeDos = new System.Windows.Forms.TextBox();
			this.txtMensajeUno = new System.Windows.Forms.TextBox();
			this.label2 = new System.Windows.Forms.Label();
			this.label1 = new System.Windows.Forms.Label();
			this.grpModificadoresAcceso = new System.Windows.Forms.GroupBox();
			this.btnModificadoresAcceso = new System.Windows.Forms.Button();
			this.lblResultadoModAcceso = new System.Windows.Forms.Label();
			this.cmbInstanciaMod = new System.Windows.Forms.ComboBox();
			this.rdbInstancia = new System.Windows.Forms.RadioButton();
			this.rdbHerencia = new System.Windows.Forms.RadioButton();
			this.pnlSobrecargaMetodos.SuspendLayout();
			this.grpModificadoresAcceso.SuspendLayout();
			this.SuspendLayout();
			// 
			// pnlSobrecargaMetodos
			// 
			this.pnlSobrecargaMetodos.Controls.Add(this.lblResultado);
			this.pnlSobrecargaMetodos.Controls.Add(this.rdbPorConstructor);
			this.pnlSobrecargaMetodos.Controls.Add(this.rdbMensajeCompuesto);
			this.pnlSobrecargaMetodos.Controls.Add(this.rdbMensajeSimple);
			this.pnlSobrecargaMetodos.Controls.Add(this.btnSobreCarga);
			this.pnlSobrecargaMetodos.Controls.Add(this.txtMensajeDos);
			this.pnlSobrecargaMetodos.Controls.Add(this.txtMensajeUno);
			this.pnlSobrecargaMetodos.Controls.Add(this.label2);
			this.pnlSobrecargaMetodos.Controls.Add(this.label1);
			this.pnlSobrecargaMetodos.Location = new System.Drawing.Point(12, 12);
			this.pnlSobrecargaMetodos.Name = "pnlSobrecargaMetodos";
			this.pnlSobrecargaMetodos.Size = new System.Drawing.Size(593, 99);
			this.pnlSobrecargaMetodos.TabIndex = 0;
			// 
			// lblResultado
			// 
			this.lblResultado.AutoSize = true;
			this.lblResultado.Location = new System.Drawing.Point(256, 62);
			this.lblResultado.Name = "lblResultado";
			this.lblResultado.Size = new System.Drawing.Size(0, 13);
			this.lblResultado.TabIndex = 8;
			// 
			// rdbPorConstructor
			// 
			this.rdbPorConstructor.AutoSize = true;
			this.rdbPorConstructor.Location = new System.Drawing.Point(243, 3);
			this.rdbPorConstructor.Name = "rdbPorConstructor";
			this.rdbPorConstructor.Size = new System.Drawing.Size(97, 17);
			this.rdbPorConstructor.TabIndex = 7;
			this.rdbPorConstructor.TabStop = true;
			this.rdbPorConstructor.Text = "Por constructor";
			this.rdbPorConstructor.UseVisualStyleBackColor = true;
			// 
			// rdbMensajeCompuesto
			// 
			this.rdbMensajeCompuesto.AutoSize = true;
			this.rdbMensajeCompuesto.Location = new System.Drawing.Point(117, 3);
			this.rdbMensajeCompuesto.Name = "rdbMensajeCompuesto";
			this.rdbMensajeCompuesto.Size = new System.Drawing.Size(120, 17);
			this.rdbMensajeCompuesto.TabIndex = 6;
			this.rdbMensajeCompuesto.TabStop = true;
			this.rdbMensajeCompuesto.Text = "Mensaje compuesto";
			this.rdbMensajeCompuesto.UseVisualStyleBackColor = true;
			// 
			// rdbMensajeSimple
			// 
			this.rdbMensajeSimple.AutoSize = true;
			this.rdbMensajeSimple.Location = new System.Drawing.Point(5, 3);
			this.rdbMensajeSimple.Name = "rdbMensajeSimple";
			this.rdbMensajeSimple.Size = new System.Drawing.Size(97, 17);
			this.rdbMensajeSimple.TabIndex = 5;
			this.rdbMensajeSimple.TabStop = true;
			this.rdbMensajeSimple.Text = "Mensaje simple";
			this.rdbMensajeSimple.UseVisualStyleBackColor = true;
			// 
			// btnSobreCarga
			// 
			this.btnSobreCarga.Location = new System.Drawing.Point(515, 73);
			this.btnSobreCarga.Name = "btnSobreCarga";
			this.btnSobreCarga.Size = new System.Drawing.Size(75, 23);
			this.btnSobreCarga.TabIndex = 4;
			this.btnSobreCarga.Text = "Sobrecarga";
			this.btnSobreCarga.UseVisualStyleBackColor = true;
			this.btnSobreCarga.Click += new System.EventHandler(this.Button1_Click);
			// 
			// txtMensajeDos
			// 
			this.txtMensajeDos.Location = new System.Drawing.Point(108, 62);
			this.txtMensajeDos.Name = "txtMensajeDos";
			this.txtMensajeDos.Size = new System.Drawing.Size(100, 20);
			this.txtMensajeDos.TabIndex = 3;
			// 
			// txtMensajeUno
			// 
			this.txtMensajeUno.Location = new System.Drawing.Point(108, 39);
			this.txtMensajeUno.Name = "txtMensajeUno";
			this.txtMensajeUno.Size = new System.Drawing.Size(100, 20);
			this.txtMensajeUno.TabIndex = 2;
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(32, 65);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(67, 13);
			this.label2.TabIndex = 1;
			this.label2.Text = "Mensaje dos";
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(32, 39);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(70, 13);
			this.label1.TabIndex = 0;
			this.label1.Text = "Mensaje Uno";
			// 
			// grpModificadoresAcceso
			// 
			this.grpModificadoresAcceso.Controls.Add(this.rdbHerencia);
			this.grpModificadoresAcceso.Controls.Add(this.rdbInstancia);
			this.grpModificadoresAcceso.Controls.Add(this.cmbInstanciaMod);
			this.grpModificadoresAcceso.Controls.Add(this.lblResultadoModAcceso);
			this.grpModificadoresAcceso.Controls.Add(this.btnModificadoresAcceso);
			this.grpModificadoresAcceso.Location = new System.Drawing.Point(13, 121);
			this.grpModificadoresAcceso.Name = "grpModificadoresAcceso";
			this.grpModificadoresAcceso.Size = new System.Drawing.Size(588, 147);
			this.grpModificadoresAcceso.TabIndex = 1;
			this.grpModificadoresAcceso.TabStop = false;
			this.grpModificadoresAcceso.Text = "Modificadores de acceso";
			// 
			// btnModificadoresAcceso
			// 
			this.btnModificadoresAcceso.Location = new System.Drawing.Point(507, 118);
			this.btnModificadoresAcceso.Name = "btnModificadoresAcceso";
			this.btnModificadoresAcceso.Size = new System.Drawing.Size(75, 23);
			this.btnModificadoresAcceso.TabIndex = 5;
			this.btnModificadoresAcceso.Text = "Mostrar";
			this.btnModificadoresAcceso.UseVisualStyleBackColor = true;
			this.btnModificadoresAcceso.Click += new System.EventHandler(this.BtnModificadoresAcceso_Click);
			// 
			// lblResultadoModAcceso
			// 
			this.lblResultadoModAcceso.AutoSize = true;
			this.lblResultadoModAcceso.Location = new System.Drawing.Point(258, 58);
			this.lblResultadoModAcceso.Name = "lblResultadoModAcceso";
			this.lblResultadoModAcceso.Size = new System.Drawing.Size(0, 13);
			this.lblResultadoModAcceso.TabIndex = 6;
			// 
			// cmbInstanciaMod
			// 
			this.cmbInstanciaMod.FormattingEnabled = true;
			this.cmbInstanciaMod.Items.AddRange(new object[] {
            "Public",
            "Private",
            "Protected",
            "Internal",
            "Protected Internal"});
			this.cmbInstanciaMod.Location = new System.Drawing.Point(18, 80);
			this.cmbInstanciaMod.Name = "cmbInstanciaMod";
			this.cmbInstanciaMod.Size = new System.Drawing.Size(121, 21);
			this.cmbInstanciaMod.TabIndex = 0;
			// 
			// rdbInstancia
			// 
			this.rdbInstancia.AutoSize = true;
			this.rdbInstancia.Location = new System.Drawing.Point(18, 20);
			this.rdbInstancia.Name = "rdbInstancia";
			this.rdbInstancia.Size = new System.Drawing.Size(68, 17);
			this.rdbInstancia.TabIndex = 7;
			this.rdbInstancia.TabStop = true;
			this.rdbInstancia.Text = "Instancia";
			this.rdbInstancia.UseVisualStyleBackColor = true;
			// 
			// rdbHerencia
			// 
			this.rdbHerencia.AutoSize = true;
			this.rdbHerencia.Location = new System.Drawing.Point(18, 43);
			this.rdbHerencia.Name = "rdbHerencia";
			this.rdbHerencia.Size = new System.Drawing.Size(68, 17);
			this.rdbHerencia.TabIndex = 8;
			this.rdbHerencia.TabStop = true;
			this.rdbHerencia.Text = "Herencia";
			this.rdbHerencia.UseVisualStyleBackColor = true;
			// 
			// frmSobreCarga
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(611, 271);
			this.Controls.Add(this.grpModificadoresAcceso);
			this.Controls.Add(this.pnlSobrecargaMetodos);
			this.Name = "frmSobreCarga";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "SobreCarga de metodos y modificadores de acceso";
			this.pnlSobrecargaMetodos.ResumeLayout(false);
			this.pnlSobrecargaMetodos.PerformLayout();
			this.grpModificadoresAcceso.ResumeLayout(false);
			this.grpModificadoresAcceso.PerformLayout();
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.Panel pnlSobrecargaMetodos;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.RadioButton rdbMensajeCompuesto;
		private System.Windows.Forms.RadioButton rdbMensajeSimple;
		private System.Windows.Forms.Button btnSobreCarga;
		private System.Windows.Forms.TextBox txtMensajeDos;
		private System.Windows.Forms.TextBox txtMensajeUno;
		private System.Windows.Forms.RadioButton rdbPorConstructor;
		private System.Windows.Forms.Label lblResultado;
		private System.Windows.Forms.GroupBox grpModificadoresAcceso;
		private System.Windows.Forms.Button btnModificadoresAcceso;
		private System.Windows.Forms.Label lblResultadoModAcceso;
		private System.Windows.Forms.RadioButton rdbHerencia;
		private System.Windows.Forms.RadioButton rdbInstancia;
		private System.Windows.Forms.ComboBox cmbInstanciaMod;
	}
}

