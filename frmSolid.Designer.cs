namespace FrmSolidPatronesDiseño
{
	partial class frmSolid
	{
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Windows Form Designer generated code

		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rdbDIP = new System.Windows.Forms.RadioButton();
            this.rdbISP = new System.Windows.Forms.RadioButton();
            this.rdbLSP = new System.Windows.Forms.RadioButton();
            this.rdpOC = new System.Windows.Forms.RadioButton();
            this.rdbSR = new System.Windows.Forms.RadioButton();
            this.btnMostrarResultado = new System.Windows.Forms.Button();
            this.lblDefinicion = new System.Windows.Forms.Label();
            this.lblResultado = new System.Windows.Forms.Label();
            this.lblUsuarioSR = new System.Windows.Forms.Label();
            this.cmbTipoUsuarioOSP = new System.Windows.Forms.ComboBox();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.lblTipoUsuarioOSP = new System.Windows.Forms.Label();
            this.LblTipoRobotLSP = new System.Windows.Forms.Label();
            this.cmbTipoRobotLSP = new System.Windows.Forms.ComboBox();
            this.lblMagoISP = new System.Windows.Forms.Label();
            this.cmbMagoISP = new System.Windows.Forms.ComboBox();
            this.lblProveedorEmailDIP = new System.Windows.Forms.Label();
            this.cmbProveedorEmailDIP = new System.Windows.Forms.ComboBox();
            this.cmbUsuarioSR = new System.Windows.Forms.ComboBox();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rdbDIP);
            this.groupBox1.Controls.Add(this.rdbISP);
            this.groupBox1.Controls.Add(this.rdbLSP);
            this.groupBox1.Controls.Add(this.rdpOC);
            this.groupBox1.Controls.Add(this.rdbSR);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(297, 138);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Seleccione un principio de SOLID";
            // 
            // rdbDIP
            // 
            this.rdbDIP.AutoSize = true;
            this.rdbDIP.Location = new System.Drawing.Point(19, 113);
            this.rdbDIP.Name = "rdbDIP";
            this.rdbDIP.Size = new System.Drawing.Size(205, 17);
            this.rdbDIP.TabIndex = 4;
            this.rdbDIP.TabStop = true;
            this.rdbDIP.Text = " Dependency Inversion Principle (DIP)";
            this.rdbDIP.UseVisualStyleBackColor = true;
            this.rdbDIP.Click += new System.EventHandler(this.RdbDIP_Click);
            // 
            // rdbISP
            // 
            this.rdbISP.AutoSize = true;
            this.rdbISP.Location = new System.Drawing.Point(19, 90);
            this.rdbISP.Name = "rdbISP";
            this.rdbISP.Size = new System.Drawing.Size(196, 17);
            this.rdbISP.TabIndex = 3;
            this.rdbISP.TabStop = true;
            this.rdbISP.Text = "Interface Segregation Principle (ISP)";
            this.rdbISP.UseVisualStyleBackColor = true;
            this.rdbISP.Click += new System.EventHandler(this.ISP_Click);
            // 
            // rdbLSP
            // 
            this.rdbLSP.AutoSize = true;
            this.rdbLSP.Location = new System.Drawing.Point(19, 67);
            this.rdbLSP.Name = "rdbLSP";
            this.rdbLSP.Size = new System.Drawing.Size(184, 17);
            this.rdbLSP.TabIndex = 2;
            this.rdbLSP.TabStop = true;
            this.rdbLSP.Text = "Liskov substitution Principle (LSP)";
            this.rdbLSP.UseVisualStyleBackColor = true;
            this.rdbLSP.Click += new System.EventHandler(this.RdbLSP_Click);
            // 
            // rdpOC
            // 
            this.rdpOC.AutoSize = true;
            this.rdpOC.Location = new System.Drawing.Point(19, 44);
            this.rdpOC.Name = "rdpOC";
            this.rdpOC.Size = new System.Drawing.Size(165, 17);
            this.rdpOC.TabIndex = 1;
            this.rdpOC.TabStop = true;
            this.rdpOC.Text = " Open/Closed Principle (OSP)";
            this.rdpOC.UseVisualStyleBackColor = true;
            this.rdpOC.Click += new System.EventHandler(this.RdpOC_Click);
            // 
            // rdbSR
            // 
            this.rdbSR.AutoSize = true;
            this.rdbSR.Location = new System.Drawing.Point(19, 21);
            this.rdbSR.Name = "rdbSR";
            this.rdbSR.Size = new System.Drawing.Size(195, 17);
            this.rdbSR.TabIndex = 0;
            this.rdbSR.TabStop = true;
            this.rdbSR.Text = "Single Responsibility Principle (SRP)";
            this.rdbSR.UseVisualStyleBackColor = true;
            this.rdbSR.Click += new System.EventHandler(this.RdbSR_Click);
            // 
            // btnMostrarResultado
            // 
            this.btnMostrarResultado.Location = new System.Drawing.Point(606, 176);
            this.btnMostrarResultado.Name = "btnMostrarResultado";
            this.btnMostrarResultado.Size = new System.Drawing.Size(122, 23);
            this.btnMostrarResultado.TabIndex = 6;
            this.btnMostrarResultado.Text = "Mostrar resultado";
            this.btnMostrarResultado.UseVisualStyleBackColor = true;
            this.btnMostrarResultado.Click += new System.EventHandler(this.BtnMostrarResultado_Click);
            // 
            // lblDefinicion
            // 
            this.lblDefinicion.Location = new System.Drawing.Point(315, 22);
            this.lblDefinicion.Name = "lblDefinicion";
            this.lblDefinicion.Size = new System.Drawing.Size(413, 97);
            this.lblDefinicion.TabIndex = 7;
            // 
            // lblResultado
            // 
            this.lblResultado.AutoSize = true;
            this.lblResultado.Location = new System.Drawing.Point(324, 104);
            this.lblResultado.Name = "lblResultado";
            this.lblResultado.Size = new System.Drawing.Size(0, 13);
            this.lblResultado.TabIndex = 8;
            // 
            // lblUsuarioSR
            // 
            this.lblUsuarioSR.AutoSize = true;
            this.lblUsuarioSR.Location = new System.Drawing.Point(141, 181);
            this.lblUsuarioSR.Name = "lblUsuarioSR";
            this.lblUsuarioSR.Size = new System.Drawing.Size(46, 13);
            this.lblUsuarioSR.TabIndex = 10;
            this.lblUsuarioSR.Text = "Usuario:";
            this.lblUsuarioSR.Visible = false;
            // 
            // cmbTipoUsuarioOSP
            // 
            this.cmbTipoUsuarioOSP.FormattingEnabled = true;
            this.cmbTipoUsuarioOSP.Items.AddRange(new object[] {
            "Admin",
            "User"});
            this.cmbTipoUsuarioOSP.Location = new System.Drawing.Point(193, 175);
            this.cmbTipoUsuarioOSP.Name = "cmbTipoUsuarioOSP";
            this.cmbTipoUsuarioOSP.Size = new System.Drawing.Size(121, 21);
            this.cmbTipoUsuarioOSP.TabIndex = 11;
            // 
            // lblTipoUsuarioOSP
            // 
            this.lblTipoUsuarioOSP.AutoSize = true;
            this.lblTipoUsuarioOSP.Location = new System.Drawing.Point(117, 178);
            this.lblTipoUsuarioOSP.Name = "lblTipoUsuarioOSP";
            this.lblTipoUsuarioOSP.Size = new System.Drawing.Size(70, 13);
            this.lblTipoUsuarioOSP.TabIndex = 12;
            this.lblTipoUsuarioOSP.Text = "Tipo Usuario:";
            this.lblTipoUsuarioOSP.Visible = false;
            // 
            // LblTipoRobotLSP
            // 
            this.LblTipoRobotLSP.AutoSize = true;
            this.LblTipoRobotLSP.Location = new System.Drawing.Point(117, 178);
            this.LblTipoRobotLSP.Name = "LblTipoRobotLSP";
            this.LblTipoRobotLSP.Size = new System.Drawing.Size(63, 13);
            this.LblTipoRobotLSP.TabIndex = 13;
            this.LblTipoRobotLSP.Text = "Tipo Robot:";
            this.LblTipoRobotLSP.Visible = false;
            // 
            // cmbTipoRobotLSP
            // 
            this.cmbTipoRobotLSP.FormattingEnabled = true;
            this.cmbTipoRobotLSP.Items.AddRange(new object[] {
            "Normal",
            "Super",
            "Mega"});
            this.cmbTipoRobotLSP.Location = new System.Drawing.Point(193, 175);
            this.cmbTipoRobotLSP.Name = "cmbTipoRobotLSP";
            this.cmbTipoRobotLSP.Size = new System.Drawing.Size(121, 21);
            this.cmbTipoRobotLSP.TabIndex = 14;
            // 
            // lblMagoISP
            // 
            this.lblMagoISP.AutoSize = true;
            this.lblMagoISP.Location = new System.Drawing.Point(150, 181);
            this.lblMagoISP.Name = "lblMagoISP";
            this.lblMagoISP.Size = new System.Drawing.Size(37, 13);
            this.lblMagoISP.TabIndex = 15;
            this.lblMagoISP.Text = "Mago:";
            this.lblMagoISP.Visible = false;
            // 
            // cmbMagoISP
            // 
            this.cmbMagoISP.FormattingEnabled = true;
            this.cmbMagoISP.Items.AddRange(new object[] {
            "Agua",
            "Viento",
            "Fuego",
            "Gran Mago"});
            this.cmbMagoISP.Location = new System.Drawing.Point(193, 175);
            this.cmbMagoISP.Name = "cmbMagoISP";
            this.cmbMagoISP.Size = new System.Drawing.Size(121, 21);
            this.cmbMagoISP.TabIndex = 16;
            // 
            // lblProveedorEmailDIP
            // 
            this.lblProveedorEmailDIP.AutoSize = true;
            this.lblProveedorEmailDIP.Location = new System.Drawing.Point(109, 181);
            this.lblProveedorEmailDIP.Name = "lblProveedorEmailDIP";
            this.lblProveedorEmailDIP.Size = new System.Drawing.Size(87, 13);
            this.lblProveedorEmailDIP.TabIndex = 17;
            this.lblProveedorEmailDIP.Text = "Proveedor Email:";
            this.lblProveedorEmailDIP.Visible = false;
            // 
            // cmbProveedorEmailDIP
            // 
            this.cmbProveedorEmailDIP.FormattingEnabled = true;
            this.cmbProveedorEmailDIP.Items.AddRange(new object[] {
            "EmailChimp",
            "SendGrid"});
            this.cmbProveedorEmailDIP.Location = new System.Drawing.Point(193, 175);
            this.cmbProveedorEmailDIP.Name = "cmbProveedorEmailDIP";
            this.cmbProveedorEmailDIP.Size = new System.Drawing.Size(121, 21);
            this.cmbProveedorEmailDIP.TabIndex = 18;
            // 
            // cmbUsuarioSR
            // 
            this.cmbUsuarioSR.FormattingEnabled = true;
            this.cmbUsuarioSR.Items.AddRange(new object[] {
            "Prueba",
            "Generico"});
            this.cmbUsuarioSR.Location = new System.Drawing.Point(193, 173);
            this.cmbUsuarioSR.Name = "cmbUsuarioSR";
            this.cmbUsuarioSR.Size = new System.Drawing.Size(121, 21);
            this.cmbUsuarioSR.TabIndex = 19;
            // 
            // frmSolid
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(748, 206);
            this.Controls.Add(this.cmbUsuarioSR);
            this.Controls.Add(this.cmbProveedorEmailDIP);
            this.Controls.Add(this.lblProveedorEmailDIP);
            this.Controls.Add(this.cmbMagoISP);
            this.Controls.Add(this.lblMagoISP);
            this.Controls.Add(this.cmbTipoRobotLSP);
            this.Controls.Add(this.LblTipoRobotLSP);
            this.Controls.Add(this.lblTipoUsuarioOSP);
            this.Controls.Add(this.cmbTipoUsuarioOSP);
            this.Controls.Add(this.lblUsuarioSR);
            this.Controls.Add(this.lblResultado);
            this.Controls.Add(this.lblDefinicion);
            this.Controls.Add(this.btnMostrarResultado);
            this.Controls.Add(this.groupBox1);
            this.Name = "frmSolid";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Principios Solid";
            this.Load += new System.EventHandler(this.FrmSolid_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.GroupBox groupBox1;
		private System.Windows.Forms.RadioButton rdbLSP;
		private System.Windows.Forms.RadioButton rdpOC;
		private System.Windows.Forms.RadioButton rdbSR;
		private System.Windows.Forms.RadioButton rdbDIP;
		private System.Windows.Forms.RadioButton rdbISP;
		private System.Windows.Forms.Button btnMostrarResultado;
		private System.Windows.Forms.Label lblDefinicion;
		private System.Windows.Forms.Label lblResultado;
		private System.Windows.Forms.Label lblUsuarioSR;
		private System.Windows.Forms.ComboBox cmbTipoUsuarioOSP;
		private System.ComponentModel.BackgroundWorker backgroundWorker1;
		private System.Windows.Forms.Label lblTipoUsuarioOSP;
		private System.Windows.Forms.Label LblTipoRobotLSP;
		private System.Windows.Forms.ComboBox cmbTipoRobotLSP;
		private System.Windows.Forms.Label lblMagoISP;
		private System.Windows.Forms.ComboBox cmbMagoISP;
		private System.Windows.Forms.Label lblProveedorEmailDIP;
		private System.Windows.Forms.ComboBox cmbProveedorEmailDIP;
		private System.Windows.Forms.ComboBox cmbUsuarioSR;
	}
}