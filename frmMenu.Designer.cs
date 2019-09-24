namespace FrmSolidPatronesDiseño
{
	partial class frmMenu
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
			this.btnPatronesDiseno = new System.Windows.Forms.Button();
			this.button1 = new System.Windows.Forms.Button();
			this.btnSolid = new System.Windows.Forms.Button();
			this.btnExpresionesLamda = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// btnPatronesDiseno
			// 
			this.btnPatronesDiseno.Location = new System.Drawing.Point(50, 136);
			this.btnPatronesDiseno.Name = "btnPatronesDiseno";
			this.btnPatronesDiseno.Size = new System.Drawing.Size(131, 37);
			this.btnPatronesDiseno.TabIndex = 2;
			this.btnPatronesDiseno.Text = "Patrones de Diseño";
			this.btnPatronesDiseno.UseVisualStyleBackColor = true;
			this.btnPatronesDiseno.Click += new System.EventHandler(this.BtnPatronesDiseno_Click);
			// 
			// button1
			// 
			this.button1.Location = new System.Drawing.Point(50, 15);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(131, 50);
			this.button1.TabIndex = 0;
			this.button1.Text = "Sobre Carga y Modificadores de Acceso";
			this.button1.UseVisualStyleBackColor = true;
			this.button1.Click += new System.EventHandler(this.Button1_Click);
			// 
			// btnSolid
			// 
			this.btnSolid.Location = new System.Drawing.Point(50, 82);
			this.btnSolid.Name = "btnSolid";
			this.btnSolid.Size = new System.Drawing.Size(131, 37);
			this.btnSolid.TabIndex = 1;
			this.btnSolid.Text = "Solid";
			this.btnSolid.UseVisualStyleBackColor = true;
			this.btnSolid.Click += new System.EventHandler(this.BtnSolid_Click);
			// 
			// btnExpresionesLamda
			// 
			this.btnExpresionesLamda.Location = new System.Drawing.Point(50, 192);
			this.btnExpresionesLamda.Name = "btnExpresionesLamda";
			this.btnExpresionesLamda.Size = new System.Drawing.Size(131, 37);
			this.btnExpresionesLamda.TabIndex = 3;
			this.btnExpresionesLamda.Text = "Expresiones Lamda";
			this.btnExpresionesLamda.UseVisualStyleBackColor = true;
			this.btnExpresionesLamda.Click += new System.EventHandler(this.BtnExpresionesLamda_Click);
			// 
			// frmMenu
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(651, 241);
			this.Controls.Add(this.btnExpresionesLamda);
			this.Controls.Add(this.btnPatronesDiseno);
			this.Controls.Add(this.btnSolid);
			this.Controls.Add(this.button1);
			this.Name = "frmMenu";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Menu";
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.Button btnPatronesDiseno;
		private System.Windows.Forms.Button button1;
		private System.Windows.Forms.Button btnSolid;
		private System.Windows.Forms.Button btnExpresionesLamda;
	}
}