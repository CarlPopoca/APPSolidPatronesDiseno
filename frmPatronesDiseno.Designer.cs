namespace FrmSolidPatronesDiseño
{
	partial class frmPatronesDiseno
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
            this.grbCreacionales = new System.Windows.Forms.GroupBox();
            this.rdbBuilder = new System.Windows.Forms.RadioButton();
            this.rdbAbstractFactory = new System.Windows.Forms.RadioButton();
            this.rdbPrototype = new System.Windows.Forms.RadioButton();
            this.rdbFactoryMethod = new System.Windows.Forms.RadioButton();
            this.rdbSingleton = new System.Windows.Forms.RadioButton();
            this.grbEstructurales = new System.Windows.Forms.GroupBox();
            this.rdbProxy = new System.Windows.Forms.RadioButton();
            this.rdbFlyweight = new System.Windows.Forms.RadioButton();
            this.rdbFacade = new System.Windows.Forms.RadioButton();
            this.rdbDecorator = new System.Windows.Forms.RadioButton();
            this.rdbComposite = new System.Windows.Forms.RadioButton();
            this.rdbBridge = new System.Windows.Forms.RadioButton();
            this.rdbAdapter = new System.Windows.Forms.RadioButton();
            this.grbComportamiento = new System.Windows.Forms.GroupBox();
            this.rdbVisitor = new System.Windows.Forms.RadioButton();
            this.rdbTemplateMethod = new System.Windows.Forms.RadioButton();
            this.rdbState = new System.Windows.Forms.RadioButton();
            this.rdbObserver = new System.Windows.Forms.RadioButton();
            this.rdbMemento = new System.Windows.Forms.RadioButton();
            this.rdbMediator = new System.Windows.Forms.RadioButton();
            this.rdbInterpreter = new System.Windows.Forms.RadioButton();
            this.rdbCommand = new System.Windows.Forms.RadioButton();
            this.rdbChainofResponsability = new System.Windows.Forms.RadioButton();
            this.btnMostrarResultado = new System.Windows.Forms.Button();
            this.lblDefinicion = new System.Windows.Forms.Label();
            this.lblResultado = new System.Windows.Forms.Label();
            this.cmbTipoProveedorFactoryMethod = new System.Windows.Forms.ComboBox();
            this.lblTipoProveedorFactoryMethod = new System.Windows.Forms.Label();
            this.lblProductoAbstractFactory = new System.Windows.Forms.Label();
            this.cmbProductoAbstractFactory = new System.Windows.Forms.ComboBox();
            this.lblAutoBuilder = new System.Windows.Forms.Label();
            this.cmbAutoBuilder = new System.Windows.Forms.ComboBox();
            this.grbCreacionales.SuspendLayout();
            this.grbEstructurales.SuspendLayout();
            this.grbComportamiento.SuspendLayout();
            this.SuspendLayout();
            // 
            // grbCreacionales
            // 
            this.grbCreacionales.Controls.Add(this.rdbBuilder);
            this.grbCreacionales.Controls.Add(this.rdbAbstractFactory);
            this.grbCreacionales.Controls.Add(this.rdbPrototype);
            this.grbCreacionales.Controls.Add(this.rdbFactoryMethod);
            this.grbCreacionales.Controls.Add(this.rdbSingleton);
            this.grbCreacionales.Location = new System.Drawing.Point(22, 5);
            this.grbCreacionales.Name = "grbCreacionales";
            this.grbCreacionales.Size = new System.Drawing.Size(270, 138);
            this.grbCreacionales.TabIndex = 0;
            this.grbCreacionales.TabStop = false;
            this.grbCreacionales.Text = "Creacionales";
            // 
            // rdbBuilder
            // 
            this.rdbBuilder.AutoSize = true;
            this.rdbBuilder.Location = new System.Drawing.Point(17, 111);
            this.rdbBuilder.Name = "rdbBuilder";
            this.rdbBuilder.Size = new System.Drawing.Size(57, 17);
            this.rdbBuilder.TabIndex = 4;
            this.rdbBuilder.TabStop = true;
            this.rdbBuilder.Text = "Builder";
            this.rdbBuilder.UseVisualStyleBackColor = true;
            this.rdbBuilder.Click += new System.EventHandler(this.RdbBuilder_Click);
            // 
            // rdbAbstractFactory
            // 
            this.rdbAbstractFactory.AutoSize = true;
            this.rdbAbstractFactory.Location = new System.Drawing.Point(17, 88);
            this.rdbAbstractFactory.Name = "rdbAbstractFactory";
            this.rdbAbstractFactory.Size = new System.Drawing.Size(102, 17);
            this.rdbAbstractFactory.TabIndex = 3;
            this.rdbAbstractFactory.TabStop = true;
            this.rdbAbstractFactory.Text = "Abstract Factory";
            this.rdbAbstractFactory.UseVisualStyleBackColor = true;
            this.rdbAbstractFactory.Click += new System.EventHandler(this.RdbAbstractFactory_Click);
            // 
            // rdbPrototype
            // 
            this.rdbPrototype.AutoSize = true;
            this.rdbPrototype.Location = new System.Drawing.Point(17, 65);
            this.rdbPrototype.Name = "rdbPrototype";
            this.rdbPrototype.Size = new System.Drawing.Size(70, 17);
            this.rdbPrototype.TabIndex = 2;
            this.rdbPrototype.TabStop = true;
            this.rdbPrototype.Text = "Prototype";
            this.rdbPrototype.UseVisualStyleBackColor = true;
            this.rdbPrototype.Click += new System.EventHandler(this.RdbPrototype_Click);
            // 
            // rdbFactoryMethod
            // 
            this.rdbFactoryMethod.AutoSize = true;
            this.rdbFactoryMethod.Location = new System.Drawing.Point(17, 42);
            this.rdbFactoryMethod.Name = "rdbFactoryMethod";
            this.rdbFactoryMethod.Size = new System.Drawing.Size(99, 17);
            this.rdbFactoryMethod.TabIndex = 1;
            this.rdbFactoryMethod.TabStop = true;
            this.rdbFactoryMethod.Text = "Factory Method";
            this.rdbFactoryMethod.UseVisualStyleBackColor = true;
            this.rdbFactoryMethod.Click += new System.EventHandler(this.RdbFactoryMethod_Click);
            // 
            // rdbSingleton
            // 
            this.rdbSingleton.AutoSize = true;
            this.rdbSingleton.Location = new System.Drawing.Point(17, 19);
            this.rdbSingleton.Name = "rdbSingleton";
            this.rdbSingleton.Size = new System.Drawing.Size(69, 17);
            this.rdbSingleton.TabIndex = 0;
            this.rdbSingleton.TabStop = true;
            this.rdbSingleton.Text = "Singleton";
            this.rdbSingleton.UseVisualStyleBackColor = true;
            this.rdbSingleton.Click += new System.EventHandler(this.RdbSingleton_Click);
            // 
            // grbEstructurales
            // 
            this.grbEstructurales.Controls.Add(this.rdbProxy);
            this.grbEstructurales.Controls.Add(this.rdbFlyweight);
            this.grbEstructurales.Controls.Add(this.rdbFacade);
            this.grbEstructurales.Controls.Add(this.rdbDecorator);
            this.grbEstructurales.Controls.Add(this.rdbComposite);
            this.grbEstructurales.Controls.Add(this.rdbBridge);
            this.grbEstructurales.Controls.Add(this.rdbAdapter);
            this.grbEstructurales.Location = new System.Drawing.Point(22, 144);
            this.grbEstructurales.Name = "grbEstructurales";
            this.grbEstructurales.Size = new System.Drawing.Size(270, 180);
            this.grbEstructurales.TabIndex = 1;
            this.grbEstructurales.TabStop = false;
            this.grbEstructurales.Text = "Estructurales";
            // 
            // rdbProxy
            // 
            this.rdbProxy.AutoSize = true;
            this.rdbProxy.Location = new System.Drawing.Point(18, 159);
            this.rdbProxy.Name = "rdbProxy";
            this.rdbProxy.Size = new System.Drawing.Size(51, 17);
            this.rdbProxy.TabIndex = 11;
            this.rdbProxy.TabStop = true;
            this.rdbProxy.Text = "Proxy";
            this.rdbProxy.UseVisualStyleBackColor = true;
            // 
            // rdbFlyweight
            // 
            this.rdbFlyweight.AutoSize = true;
            this.rdbFlyweight.Location = new System.Drawing.Point(17, 136);
            this.rdbFlyweight.Name = "rdbFlyweight";
            this.rdbFlyweight.Size = new System.Drawing.Size(69, 17);
            this.rdbFlyweight.TabIndex = 10;
            this.rdbFlyweight.TabStop = true;
            this.rdbFlyweight.Text = "Flyweight";
            this.rdbFlyweight.UseVisualStyleBackColor = true;
            // 
            // rdbFacade
            // 
            this.rdbFacade.AutoSize = true;
            this.rdbFacade.Location = new System.Drawing.Point(17, 111);
            this.rdbFacade.Name = "rdbFacade";
            this.rdbFacade.Size = new System.Drawing.Size(61, 17);
            this.rdbFacade.TabIndex = 9;
            this.rdbFacade.TabStop = true;
            this.rdbFacade.Text = "Facade";
            this.rdbFacade.UseVisualStyleBackColor = true;
            // 
            // rdbDecorator
            // 
            this.rdbDecorator.AutoSize = true;
            this.rdbDecorator.Location = new System.Drawing.Point(17, 88);
            this.rdbDecorator.Name = "rdbDecorator";
            this.rdbDecorator.Size = new System.Drawing.Size(72, 17);
            this.rdbDecorator.TabIndex = 8;
            this.rdbDecorator.TabStop = true;
            this.rdbDecorator.Text = "Decorator";
            this.rdbDecorator.UseVisualStyleBackColor = true;
            // 
            // rdbComposite
            // 
            this.rdbComposite.AutoSize = true;
            this.rdbComposite.Location = new System.Drawing.Point(17, 65);
            this.rdbComposite.Name = "rdbComposite";
            this.rdbComposite.Size = new System.Drawing.Size(74, 17);
            this.rdbComposite.TabIndex = 7;
            this.rdbComposite.TabStop = true;
            this.rdbComposite.Text = "Composite";
            this.rdbComposite.UseVisualStyleBackColor = true;
            // 
            // rdbBridge
            // 
            this.rdbBridge.AutoSize = true;
            this.rdbBridge.Location = new System.Drawing.Point(17, 42);
            this.rdbBridge.Name = "rdbBridge";
            this.rdbBridge.Size = new System.Drawing.Size(55, 17);
            this.rdbBridge.TabIndex = 6;
            this.rdbBridge.TabStop = true;
            this.rdbBridge.Text = "Bridge";
            this.rdbBridge.UseVisualStyleBackColor = true;
            // 
            // rdbAdapter
            // 
            this.rdbAdapter.AutoSize = true;
            this.rdbAdapter.Location = new System.Drawing.Point(17, 19);
            this.rdbAdapter.Name = "rdbAdapter";
            this.rdbAdapter.Size = new System.Drawing.Size(115, 17);
            this.rdbAdapter.TabIndex = 5;
            this.rdbAdapter.TabStop = true;
            this.rdbAdapter.Text = "Adapter o Wrapper";
            this.rdbAdapter.UseVisualStyleBackColor = true;
            // 
            // grbComportamiento
            // 
            this.grbComportamiento.Controls.Add(this.rdbVisitor);
            this.grbComportamiento.Controls.Add(this.rdbTemplateMethod);
            this.grbComportamiento.Controls.Add(this.rdbState);
            this.grbComportamiento.Controls.Add(this.rdbObserver);
            this.grbComportamiento.Controls.Add(this.rdbMemento);
            this.grbComportamiento.Controls.Add(this.rdbMediator);
            this.grbComportamiento.Controls.Add(this.rdbInterpreter);
            this.grbComportamiento.Controls.Add(this.rdbCommand);
            this.grbComportamiento.Controls.Add(this.rdbChainofResponsability);
            this.grbComportamiento.Location = new System.Drawing.Point(22, 324);
            this.grbComportamiento.Name = "grbComportamiento";
            this.grbComportamiento.Size = new System.Drawing.Size(270, 232);
            this.grbComportamiento.TabIndex = 2;
            this.grbComportamiento.TabStop = false;
            this.grbComportamiento.Text = "Comportamiento";
            // 
            // rdbVisitor
            // 
            this.rdbVisitor.AutoSize = true;
            this.rdbVisitor.Location = new System.Drawing.Point(19, 208);
            this.rdbVisitor.Name = "rdbVisitor";
            this.rdbVisitor.Size = new System.Drawing.Size(53, 17);
            this.rdbVisitor.TabIndex = 19;
            this.rdbVisitor.TabStop = true;
            this.rdbVisitor.Text = "Visitor";
            this.rdbVisitor.UseVisualStyleBackColor = true;
            // 
            // rdbTemplateMethod
            // 
            this.rdbTemplateMethod.AutoSize = true;
            this.rdbTemplateMethod.Location = new System.Drawing.Point(18, 184);
            this.rdbTemplateMethod.Name = "rdbTemplateMethod";
            this.rdbTemplateMethod.Size = new System.Drawing.Size(108, 17);
            this.rdbTemplateMethod.TabIndex = 18;
            this.rdbTemplateMethod.TabStop = true;
            this.rdbTemplateMethod.Text = "Template Method";
            this.rdbTemplateMethod.UseVisualStyleBackColor = true;
            // 
            // rdbState
            // 
            this.rdbState.AutoSize = true;
            this.rdbState.Location = new System.Drawing.Point(18, 161);
            this.rdbState.Name = "rdbState";
            this.rdbState.Size = new System.Drawing.Size(50, 17);
            this.rdbState.TabIndex = 17;
            this.rdbState.TabStop = true;
            this.rdbState.Text = "State";
            this.rdbState.UseVisualStyleBackColor = true;
            // 
            // rdbObserver
            // 
            this.rdbObserver.AutoSize = true;
            this.rdbObserver.Location = new System.Drawing.Point(19, 137);
            this.rdbObserver.Name = "rdbObserver";
            this.rdbObserver.Size = new System.Drawing.Size(68, 17);
            this.rdbObserver.TabIndex = 16;
            this.rdbObserver.TabStop = true;
            this.rdbObserver.Text = "Observer";
            this.rdbObserver.UseVisualStyleBackColor = true;
            // 
            // rdbMemento
            // 
            this.rdbMemento.AutoSize = true;
            this.rdbMemento.Location = new System.Drawing.Point(19, 112);
            this.rdbMemento.Name = "rdbMemento";
            this.rdbMemento.Size = new System.Drawing.Size(69, 17);
            this.rdbMemento.TabIndex = 15;
            this.rdbMemento.TabStop = true;
            this.rdbMemento.Text = "Memento";
            this.rdbMemento.UseVisualStyleBackColor = true;
            // 
            // rdbMediator
            // 
            this.rdbMediator.AutoSize = true;
            this.rdbMediator.Location = new System.Drawing.Point(19, 89);
            this.rdbMediator.Name = "rdbMediator";
            this.rdbMediator.Size = new System.Drawing.Size(66, 17);
            this.rdbMediator.TabIndex = 14;
            this.rdbMediator.TabStop = true;
            this.rdbMediator.Text = "Mediator";
            this.rdbMediator.UseVisualStyleBackColor = true;
            // 
            // rdbInterpreter
            // 
            this.rdbInterpreter.AutoSize = true;
            this.rdbInterpreter.Location = new System.Drawing.Point(19, 66);
            this.rdbInterpreter.Name = "rdbInterpreter";
            this.rdbInterpreter.Size = new System.Drawing.Size(73, 17);
            this.rdbInterpreter.TabIndex = 13;
            this.rdbInterpreter.TabStop = true;
            this.rdbInterpreter.Text = "Interpreter";
            this.rdbInterpreter.UseVisualStyleBackColor = true;
            // 
            // rdbCommand
            // 
            this.rdbCommand.AutoSize = true;
            this.rdbCommand.Location = new System.Drawing.Point(19, 43);
            this.rdbCommand.Name = "rdbCommand";
            this.rdbCommand.Size = new System.Drawing.Size(72, 17);
            this.rdbCommand.TabIndex = 12;
            this.rdbCommand.TabStop = true;
            this.rdbCommand.Text = "Command";
            this.rdbCommand.UseVisualStyleBackColor = true;
            // 
            // rdbChainofResponsability
            // 
            this.rdbChainofResponsability.AutoSize = true;
            this.rdbChainofResponsability.Location = new System.Drawing.Point(19, 20);
            this.rdbChainofResponsability.Name = "rdbChainofResponsability";
            this.rdbChainofResponsability.Size = new System.Drawing.Size(135, 17);
            this.rdbChainofResponsability.TabIndex = 11;
            this.rdbChainofResponsability.TabStop = true;
            this.rdbChainofResponsability.Text = "Chain of Responsability";
            this.rdbChainofResponsability.UseVisualStyleBackColor = true;
            // 
            // btnMostrarResultado
            // 
            this.btnMostrarResultado.Location = new System.Drawing.Point(666, 532);
            this.btnMostrarResultado.Name = "btnMostrarResultado";
            this.btnMostrarResultado.Size = new System.Drawing.Size(122, 23);
            this.btnMostrarResultado.TabIndex = 7;
            this.btnMostrarResultado.Text = "Mostrar resultado";
            this.btnMostrarResultado.UseVisualStyleBackColor = true;
            this.btnMostrarResultado.Click += new System.EventHandler(this.BtnMostrarResultado_Click);
            // 
            // lblDefinicion
            // 
            this.lblDefinicion.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblDefinicion.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDefinicion.Location = new System.Drawing.Point(308, 9);
            this.lblDefinicion.Name = "lblDefinicion";
            this.lblDefinicion.Size = new System.Drawing.Size(480, 240);
            this.lblDefinicion.TabIndex = 8;
            // 
            // lblResultado
            // 
            this.lblResultado.AutoSize = true;
            this.lblResultado.Location = new System.Drawing.Point(315, 404);
            this.lblResultado.Name = "lblResultado";
            this.lblResultado.Size = new System.Drawing.Size(0, 13);
            this.lblResultado.TabIndex = 9;
            // 
            // cmbTipoProveedorFactoryMethod
            // 
            this.cmbTipoProveedorFactoryMethod.FormattingEnabled = true;
            this.cmbTipoProveedorFactoryMethod.Items.AddRange(new object[] {
            "Linea Blanca",
            "Hogar"});
            this.cmbTipoProveedorFactoryMethod.Location = new System.Drawing.Point(389, 272);
            this.cmbTipoProveedorFactoryMethod.Name = "cmbTipoProveedorFactoryMethod";
            this.cmbTipoProveedorFactoryMethod.Size = new System.Drawing.Size(121, 21);
            this.cmbTipoProveedorFactoryMethod.TabIndex = 21;
            // 
            // lblTipoProveedorFactoryMethod
            // 
            this.lblTipoProveedorFactoryMethod.AutoSize = true;
            this.lblTipoProveedorFactoryMethod.Location = new System.Drawing.Point(305, 277);
            this.lblTipoProveedorFactoryMethod.Name = "lblTipoProveedorFactoryMethod";
            this.lblTipoProveedorFactoryMethod.Size = new System.Drawing.Size(87, 13);
            this.lblTipoProveedorFactoryMethod.TabIndex = 20;
            this.lblTipoProveedorFactoryMethod.Text = "Proveedor Email:";
            this.lblTipoProveedorFactoryMethod.Visible = false;
            // 
            // lblProductoAbstractFactory
            // 
            this.lblProductoAbstractFactory.AutoSize = true;
            this.lblProductoAbstractFactory.Location = new System.Drawing.Point(305, 277);
            this.lblProductoAbstractFactory.Name = "lblProductoAbstractFactory";
            this.lblProductoAbstractFactory.Size = new System.Drawing.Size(53, 13);
            this.lblProductoAbstractFactory.TabIndex = 22;
            this.lblProductoAbstractFactory.Text = "Producto:";
            // 
            // cmbProductoAbstractFactory
            // 
            this.cmbProductoAbstractFactory.FormattingEnabled = true;
            this.cmbProductoAbstractFactory.Items.AddRange(new object[] {
            "CDR",
            "CDRW",
            "DVD capa simple",
            "DVD capa doble"});
            this.cmbProductoAbstractFactory.Location = new System.Drawing.Point(389, 272);
            this.cmbProductoAbstractFactory.Name = "cmbProductoAbstractFactory";
            this.cmbProductoAbstractFactory.Size = new System.Drawing.Size(121, 21);
            this.cmbProductoAbstractFactory.TabIndex = 23;
            // 
            // lblAutoBuilder
            // 
            this.lblAutoBuilder.AutoSize = true;
            this.lblAutoBuilder.Location = new System.Drawing.Point(305, 277);
            this.lblAutoBuilder.Name = "lblAutoBuilder";
            this.lblAutoBuilder.Size = new System.Drawing.Size(32, 13);
            this.lblAutoBuilder.TabIndex = 24;
            this.lblAutoBuilder.Text = "Auto:";
            this.lblAutoBuilder.Visible = false;
            // 
            // cmbAutoBuilder
            // 
            this.cmbAutoBuilder.FormattingEnabled = true;
            this.cmbAutoBuilder.Items.AddRange(new object[] {
            "Kia",
            "Nissan",
            "Mitsubishi"});
            this.cmbAutoBuilder.Location = new System.Drawing.Point(389, 273);
            this.cmbAutoBuilder.Name = "cmbAutoBuilder";
            this.cmbAutoBuilder.Size = new System.Drawing.Size(121, 21);
            this.cmbAutoBuilder.TabIndex = 25;
            // 
            // frmPatronesDiseno
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 559);
            this.Controls.Add(this.cmbAutoBuilder);
            this.Controls.Add(this.lblAutoBuilder);
            this.Controls.Add(this.cmbProductoAbstractFactory);
            this.Controls.Add(this.lblProductoAbstractFactory);
            this.Controls.Add(this.cmbTipoProveedorFactoryMethod);
            this.Controls.Add(this.lblTipoProveedorFactoryMethod);
            this.Controls.Add(this.lblResultado);
            this.Controls.Add(this.lblDefinicion);
            this.Controls.Add(this.btnMostrarResultado);
            this.Controls.Add(this.grbComportamiento);
            this.Controls.Add(this.grbEstructurales);
            this.Controls.Add(this.grbCreacionales);
            this.Name = "frmPatronesDiseno";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Patrones de Diseño";
            this.grbCreacionales.ResumeLayout(false);
            this.grbCreacionales.PerformLayout();
            this.grbEstructurales.ResumeLayout(false);
            this.grbEstructurales.PerformLayout();
            this.grbComportamiento.ResumeLayout(false);
            this.grbComportamiento.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.GroupBox grbCreacionales;
		private System.Windows.Forms.GroupBox grbEstructurales;
		private System.Windows.Forms.GroupBox grbComportamiento;
		private System.Windows.Forms.RadioButton rdbBuilder;
		private System.Windows.Forms.RadioButton rdbAbstractFactory;
		private System.Windows.Forms.RadioButton rdbPrototype;
		private System.Windows.Forms.RadioButton rdbFactoryMethod;
		private System.Windows.Forms.RadioButton rdbSingleton;
		private System.Windows.Forms.Button btnMostrarResultado;
		private System.Windows.Forms.Label lblDefinicion;
		private System.Windows.Forms.RadioButton rdbFacade;
		private System.Windows.Forms.RadioButton rdbDecorator;
		private System.Windows.Forms.RadioButton rdbComposite;
		private System.Windows.Forms.RadioButton rdbBridge;
		private System.Windows.Forms.RadioButton rdbAdapter;
		private System.Windows.Forms.RadioButton rdbProxy;
		private System.Windows.Forms.RadioButton rdbFlyweight;
		private System.Windows.Forms.RadioButton rdbVisitor;
		private System.Windows.Forms.RadioButton rdbTemplateMethod;
		private System.Windows.Forms.RadioButton rdbState;
		private System.Windows.Forms.RadioButton rdbObserver;
		private System.Windows.Forms.RadioButton rdbMemento;
		private System.Windows.Forms.RadioButton rdbMediator;
		private System.Windows.Forms.RadioButton rdbInterpreter;
		private System.Windows.Forms.RadioButton rdbCommand;
		private System.Windows.Forms.RadioButton rdbChainofResponsability;
		private System.Windows.Forms.Label lblResultado;
		private System.Windows.Forms.ComboBox cmbTipoProveedorFactoryMethod;
		private System.Windows.Forms.Label lblTipoProveedorFactoryMethod;
        private System.Windows.Forms.Label lblProductoAbstractFactory;
        private System.Windows.Forms.ComboBox cmbProductoAbstractFactory;
        private System.Windows.Forms.Label lblAutoBuilder;
        private System.Windows.Forms.ComboBox cmbAutoBuilder;
    }
}