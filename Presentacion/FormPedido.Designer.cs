namespace PizzeriaBellaItalia.Presentacion;
    partial class FormPedido : Form
{
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
    ///  Required method for Designer support - do not modify
    ///  the contents of this method with the code editor.
    /// </summary>
    private void InitializeComponent()
    {
        grpCliente = new GroupBox();
        txtTelefono = new TextBox();
        txtCliente = new TextBox();
        lblTelefono = new Label();
        lblNombre = new Label();
        grpPizza = new GroupBox();
        cboMasa = new ComboBox();
        lblMasa = new Label();
        cboTamano = new ComboBox();
        lblTamano = new Label();
        grpIngredientes = new GroupBox();
        chkTocino = new CheckBox();
        chkPepperoni = new CheckBox();
        chkAceitunas = new CheckBox();
        chkChampinones = new CheckBox();
        chkQuesoExtra = new CheckBox();
        grpEntrega = new GroupBox();
        chkConvenioEstudiante = new CheckBox();
        rdbDelivery = new RadioButton();
        rdbRetiro = new RadioButton();
        lblSubtotalValor = new Label();
        lblIvaValor = new Label();
        lblTotalValor = new Label();
        lblDeliveryValor = new Label();
        lblDescuentoValor = new Label();
        grpResumen = new GroupBox();
        lblDescuentoNombre = new Label();
        lblDeliveryNombre = new Label();
        lblIvaNombre = new Label();
        lblTotalNombre = new Label();
        lblSubtotalNombre = new Label();
        btnCalcular = new Button();
        btnLimpiar = new Button();
        btnConfirmar = new Button();
        lstResultados = new ListBox();
        grpCliente.SuspendLayout();
        grpPizza.SuspendLayout();
        grpIngredientes.SuspendLayout();
        grpEntrega.SuspendLayout();
        grpResumen.SuspendLayout();
        SuspendLayout();
        // 
        // grpCliente
        // 
        grpCliente.Controls.Add(txtTelefono);
        grpCliente.Controls.Add(txtCliente);
        grpCliente.Controls.Add(lblTelefono);
        grpCliente.Controls.Add(lblNombre);
        grpCliente.Location = new Point(19, 33);
        grpCliente.Margin = new Padding(3, 2, 3, 2);
        grpCliente.Name = "grpCliente";
        grpCliente.Padding = new Padding(3, 2, 3, 2);
        grpCliente.Size = new Size(321, 83);
        grpCliente.TabIndex = 0;
        grpCliente.TabStop = false;
        grpCliente.Text = "Datos del Cliente";
        // 
        // txtTelefono
        // 
        txtTelefono.Location = new Point(195, 40);
        txtTelefono.Margin = new Padding(3, 2, 3, 2);
        txtTelefono.Name = "txtTelefono";
        txtTelefono.Size = new Size(110, 23);
        txtTelefono.TabIndex = 3;
        // 
        // txtCliente
        // 
        txtCliente.Location = new Point(22, 39);
        txtCliente.Margin = new Padding(3, 2, 3, 2);
        txtCliente.Name = "txtCliente";
        txtCliente.Size = new Size(167, 23);
        txtCliente.TabIndex = 2;
        // 
        // lblTelefono
        // 
        lblTelefono.AutoSize = true;
        lblTelefono.Location = new Point(196, 20);
        lblTelefono.Name = "lblTelefono";
        lblTelefono.Size = new Size(55, 15);
        lblTelefono.TabIndex = 1;
        lblTelefono.Text = "Telefono:";
        // 
        // lblNombre
        // 
        lblNombre.AutoSize = true;
        lblNombre.Location = new Point(22, 20);
        lblNombre.Name = "lblNombre";
        lblNombre.Size = new Size(54, 15);
        lblNombre.TabIndex = 0;
        lblNombre.Text = "Nombre:";
        // 
        // grpPizza
        // 
        grpPizza.Controls.Add(cboMasa);
        grpPizza.Controls.Add(lblMasa);
        grpPizza.Controls.Add(cboTamano);
        grpPizza.Controls.Add(lblTamano);
        grpPizza.Location = new Point(19, 136);
        grpPizza.Margin = new Padding(3, 2, 3, 2);
        grpPizza.Name = "grpPizza";
        grpPizza.Padding = new Padding(3, 2, 3, 2);
        grpPizza.Size = new Size(321, 94);
        grpPizza.TabIndex = 1;
        grpPizza.TabStop = false;
        grpPizza.Text = "Tamaño y Masa:";
        // 
        // cboMasa
        // 
        cboMasa.FormattingEnabled = true;
        cboMasa.Location = new Point(71, 54);
        cboMasa.Margin = new Padding(3, 2, 3, 2);
        cboMasa.Name = "cboMasa";
        cboMasa.Size = new Size(234, 23);
        cboMasa.TabIndex = 4;
        // 
        // lblMasa
        // 
        lblMasa.AutoSize = true;
        lblMasa.Location = new Point(5, 57);
        lblMasa.Name = "lblMasa";
        lblMasa.Size = new Size(38, 15);
        lblMasa.TabIndex = 3;
        lblMasa.Text = "Masa:";
        // 
        // cboTamano
        // 
        cboTamano.FormattingEnabled = true;
        cboTamano.Location = new Point(71, 28);
        cboTamano.Margin = new Padding(3, 2, 3, 2);
        cboTamano.Name = "cboTamano";
        cboTamano.Size = new Size(234, 23);
        cboTamano.TabIndex = 2;
        // 
        // lblTamano
        // 
        lblTamano.AutoSize = true;
        lblTamano.Location = new Point(5, 31);
        lblTamano.Name = "lblTamano";
        lblTamano.Size = new Size(52, 15);
        lblTamano.TabIndex = 1;
        lblTamano.Text = "Tamaño:";
        // 
        // grpIngredientes
        // 
        grpIngredientes.Controls.Add(chkTocino);
        grpIngredientes.Controls.Add(chkPepperoni);
        grpIngredientes.Controls.Add(chkAceitunas);
        grpIngredientes.Controls.Add(chkChampinones);
        grpIngredientes.Controls.Add(chkQuesoExtra);
        grpIngredientes.Location = new Point(346, 33);
        grpIngredientes.Margin = new Padding(3, 2, 3, 2);
        grpIngredientes.Name = "grpIngredientes";
        grpIngredientes.Padding = new Padding(3, 2, 3, 2);
        grpIngredientes.Size = new Size(282, 135);
        grpIngredientes.TabIndex = 3;
        grpIngredientes.TabStop = false;
        grpIngredientes.Text = "Adicionales ($800 c/u)";
        // 
        // chkTocino
        // 
        chkTocino.AutoSize = true;
        chkTocino.Location = new Point(9, 112);
        chkTocino.Margin = new Padding(3, 2, 3, 2);
        chkTocino.Name = "chkTocino";
        chkTocino.Size = new Size(61, 19);
        chkTocino.TabIndex = 5;
        chkTocino.Text = "Tocino";
        chkTocino.UseVisualStyleBackColor = true;
        // 
        // chkPepperoni
        // 
        chkPepperoni.AutoSize = true;
        chkPepperoni.Location = new Point(9, 44);
        chkPepperoni.Margin = new Padding(3, 2, 3, 2);
        chkPepperoni.Name = "chkPepperoni";
        chkPepperoni.Size = new Size(80, 19);
        chkPepperoni.TabIndex = 4;
        chkPepperoni.Text = "Pepperoni";
        chkPepperoni.UseVisualStyleBackColor = true;
        // 
        // chkAceitunas
        // 
        chkAceitunas.AutoSize = true;
        chkAceitunas.Location = new Point(9, 89);
        chkAceitunas.Margin = new Padding(3, 2, 3, 2);
        chkAceitunas.Name = "chkAceitunas";
        chkAceitunas.Size = new Size(78, 19);
        chkAceitunas.TabIndex = 2;
        chkAceitunas.Text = "Aceitunas";
        chkAceitunas.UseVisualStyleBackColor = true;
        // 
        // chkChampinones
        // 
        chkChampinones.AutoSize = true;
        chkChampinones.Location = new Point(9, 67);
        chkChampinones.Margin = new Padding(3, 2, 3, 2);
        chkChampinones.Name = "chkChampinones";
        chkChampinones.Size = new Size(100, 19);
        chkChampinones.TabIndex = 1;
        chkChampinones.Text = "Champiñones";
        chkChampinones.UseVisualStyleBackColor = true;
        // 
        // chkQuesoExtra
        // 
        chkQuesoExtra.AutoSize = true;
        chkQuesoExtra.Location = new Point(9, 22);
        chkQuesoExtra.Margin = new Padding(3, 2, 3, 2);
        chkQuesoExtra.Name = "chkQuesoExtra";
        chkQuesoExtra.Size = new Size(89, 19);
        chkQuesoExtra.TabIndex = 0;
        chkQuesoExtra.Text = "Queso Extra";
        chkQuesoExtra.UseVisualStyleBackColor = true;
        // 
        // grpEntrega
        // 
        grpEntrega.Controls.Add(chkConvenioEstudiante);
        grpEntrega.Controls.Add(rdbDelivery);
        grpEntrega.Controls.Add(rdbRetiro);
        grpEntrega.Location = new Point(346, 194);
        grpEntrega.Margin = new Padding(3, 2, 3, 2);
        grpEntrega.Name = "grpEntrega";
        grpEntrega.Padding = new Padding(3, 2, 3, 2);
        grpEntrega.Size = new Size(282, 82);
        grpEntrega.TabIndex = 4;
        grpEntrega.TabStop = false;
        grpEntrega.Text = "Servicio y Descuento";
        // 
        // chkConvenioEstudiante
        // 
        chkConvenioEstudiante.AutoSize = true;
        chkConvenioEstudiante.Location = new Point(15, 52);
        chkConvenioEstudiante.Margin = new Padding(3, 2, 3, 2);
        chkConvenioEstudiante.Name = "chkConvenioEstudiante";
        chkConvenioEstudiante.Size = new Size(226, 19);
        chkConvenioEstudiante.TabIndex = 2;
        chkConvenioEstudiante.Text = "Convenio Estudiante/IPVG (10% Dcto)";
        chkConvenioEstudiante.UseVisualStyleBackColor = true;
        // 
        // rdbDelivery
        // 
        rdbDelivery.AutoSize = true;
        rdbDelivery.Location = new Point(145, 29);
        rdbDelivery.Margin = new Padding(3, 2, 3, 2);
        rdbDelivery.Name = "rdbDelivery";
        rdbDelivery.Size = new Size(119, 19);
        rdbDelivery.TabIndex = 1;
        rdbDelivery.Text = "Delivery ($2.000.-)";
        rdbDelivery.UseVisualStyleBackColor = true;
        // 
        // rdbRetiro
        // 
        rdbRetiro.AutoSize = true;
        rdbRetiro.Checked = true;
        rdbRetiro.Location = new Point(15, 29);
        rdbRetiro.Margin = new Padding(3, 2, 3, 2);
        rdbRetiro.Name = "rdbRetiro";
        rdbRetiro.Size = new Size(103, 19);
        rdbRetiro.TabIndex = 0;
        rdbRetiro.TabStop = true;
        rdbRetiro.Text = "Retiro en Local";
        rdbRetiro.UseVisualStyleBackColor = true;
        // 
        // lblSubtotalValor
        // 
        lblSubtotalValor.AutoSize = true;
        lblSubtotalValor.Location = new Point(223, 26);
        lblSubtotalValor.Name = "lblSubtotalValor";
        lblSubtotalValor.Size = new Size(43, 15);
        lblSubtotalValor.TabIndex = 5;
        lblSubtotalValor.Text = "$0 CLP";
        // 
        // lblIvaValor
        // 
        lblIvaValor.AutoSize = true;
        lblIvaValor.Location = new Point(222, 93);
        lblIvaValor.Name = "lblIvaValor";
        lblIvaValor.Size = new Size(43, 15);
        lblIvaValor.TabIndex = 6;
        lblIvaValor.Text = "$0 CLP";
        // 
        // lblTotalValor
        // 
        lblTotalValor.AutoSize = true;
        lblTotalValor.Location = new Point(221, 122);
        lblTotalValor.Name = "lblTotalValor";
        lblTotalValor.Size = new Size(43, 15);
        lblTotalValor.TabIndex = 7;
        lblTotalValor.Text = "$0 CLP";
        // 
        // lblDeliveryValor
        // 
        lblDeliveryValor.AutoSize = true;
        lblDeliveryValor.Location = new Point(223, 71);
        lblDeliveryValor.Name = "lblDeliveryValor";
        lblDeliveryValor.Size = new Size(43, 15);
        lblDeliveryValor.TabIndex = 8;
        lblDeliveryValor.Text = "$0 CLP";
        // 
        // lblDescuentoValor
        // 
        lblDescuentoValor.AutoSize = true;
        lblDescuentoValor.Location = new Point(223, 47);
        lblDescuentoValor.Name = "lblDescuentoValor";
        lblDescuentoValor.Size = new Size(43, 15);
        lblDescuentoValor.TabIndex = 9;
        lblDescuentoValor.Text = "$0 CLP";
        // 
        // grpResumen
        // 
        grpResumen.Controls.Add(lblDescuentoNombre);
        grpResumen.Controls.Add(lblDeliveryNombre);
        grpResumen.Controls.Add(lblIvaNombre);
        grpResumen.Controls.Add(lblTotalNombre);
        grpResumen.Controls.Add(lblSubtotalNombre);
        grpResumen.Controls.Add(lblSubtotalValor);
        grpResumen.Controls.Add(lblDescuentoValor);
        grpResumen.Controls.Add(lblIvaValor);
        grpResumen.Controls.Add(lblDeliveryValor);
        grpResumen.Controls.Add(lblTotalValor);
        grpResumen.Location = new Point(19, 292);
        grpResumen.Margin = new Padding(3, 2, 3, 2);
        grpResumen.Name = "grpResumen";
        grpResumen.Padding = new Padding(3, 2, 3, 2);
        grpResumen.Size = new Size(321, 156);
        grpResumen.TabIndex = 10;
        grpResumen.TabStop = false;
        grpResumen.Text = "Detalle de Pago";
        // 
        // lblDescuentoNombre
        // 
        lblDescuentoNombre.AutoSize = true;
        lblDescuentoNombre.Location = new Point(10, 47);
        lblDescuentoNombre.Name = "lblDescuentoNombre";
        lblDescuentoNombre.Size = new Size(99, 15);
        lblDescuentoNombre.TabIndex = 15;
        lblDescuentoNombre.Text = "Descuento (10%):";
        // 
        // lblDeliveryNombre
        // 
        lblDeliveryNombre.AutoSize = true;
        lblDeliveryNombre.Location = new Point(10, 71);
        lblDeliveryNombre.Name = "lblDeliveryNombre";
        lblDeliveryNombre.Size = new Size(98, 15);
        lblDeliveryNombre.TabIndex = 14;
        lblDeliveryNombre.Text = "Recargo Delivery:";
        // 
        // lblIvaNombre
        // 
        lblIvaNombre.AutoSize = true;
        lblIvaNombre.Location = new Point(10, 93);
        lblIvaNombre.Name = "lblIvaNombre";
        lblIvaNombre.Size = new Size(101, 15);
        lblIvaNombre.TabIndex = 13;
        lblIvaNombre.Text = "IVA Chileno (19%)";
        // 
        // lblTotalNombre
        // 
        lblTotalNombre.AutoSize = true;
        lblTotalNombre.Location = new Point(10, 122);
        lblTotalNombre.Name = "lblTotalNombre";
        lblTotalNombre.Size = new Size(93, 15);
        lblTotalNombre.TabIndex = 12;
        lblTotalNombre.Text = "TOTAL A PAGAR:";
        // 
        // lblSubtotalNombre
        // 
        lblSubtotalNombre.AutoSize = true;
        lblSubtotalNombre.Location = new Point(10, 26);
        lblSubtotalNombre.Name = "lblSubtotalNombre";
        lblSubtotalNombre.Size = new Size(83, 15);
        lblSubtotalNombre.TabIndex = 10;
        lblSubtotalNombre.Text = "Subtotal Pizza:";
        // 
        // btnCalcular
        // 
        btnCalcular.Location = new Point(396, 311);
        btnCalcular.Margin = new Padding(3, 2, 3, 2);
        btnCalcular.Name = "btnCalcular";
        btnCalcular.Size = new Size(161, 22);
        btnCalcular.TabIndex = 11;
        btnCalcular.Text = "Calcular Total";
        btnCalcular.UseVisualStyleBackColor = true;
        btnCalcular.Click += BtnCalcular_Click;
        // 
        // btnLimpiar
        // 
        btnLimpiar.Location = new Point(396, 356);
        btnLimpiar.Margin = new Padding(3, 2, 3, 2);
        btnLimpiar.Name = "btnLimpiar";
        btnLimpiar.Size = new Size(161, 22);
        btnLimpiar.TabIndex = 12;
        btnLimpiar.Text = "Nuevo Pedido";
        btnLimpiar.UseVisualStyleBackColor = true;
        btnLimpiar.Click += BtnLimpiar_Click;
        // 
        // btnConfirmar
        // 
        btnConfirmar.Location = new Point(396, 382);
        btnConfirmar.Margin = new Padding(3, 2, 3, 2);
        btnConfirmar.Name = "btnConfirmar";
        btnConfirmar.Size = new Size(161, 22);
        btnConfirmar.TabIndex = 13;
        btnConfirmar.Text = "Salir";
        btnConfirmar.UseVisualStyleBackColor = true;
        btnConfirmar.Click += BtnSalir_Click;
        // 
        // lstResultados
        // 
        lstResultados.FormattingEnabled = true;
        lstResultados.Location = new Point(21, 441);
        lstResultados.Name = "lstResultados";
        lstResultados.Size = new Size(608, 94);
        lstResultados.TabIndex = 14;
        // 
        // FormPedido
        // 
        AutoScaleDimensions = new SizeF(7F, 15F);
        AutoScaleMode = AutoScaleMode.Font;
        ClientSize = new Size(641, 616);
        Controls.Add(lstResultados);
        Controls.Add(btnConfirmar);
        Controls.Add(btnLimpiar);
        Controls.Add(btnCalcular);
        Controls.Add(grpResumen);
        Controls.Add(grpEntrega);
        Controls.Add(grpIngredientes);
        Controls.Add(grpPizza);
        Controls.Add(grpCliente);
        Margin = new Padding(3, 2, 3, 2);
        Name = "FormPedido";
        StartPosition = FormStartPosition.CenterScreen;
        Text = "Sistema de Pedidos - Pizzería Bella Italia (v1.0)";
        Load += FormPedido_Load;
        grpCliente.ResumeLayout(false);
        grpCliente.PerformLayout();
        grpPizza.ResumeLayout(false);
        grpPizza.PerformLayout();
        grpIngredientes.ResumeLayout(false);
        grpIngredientes.PerformLayout();
        grpEntrega.ResumeLayout(false);
        grpEntrega.PerformLayout();
        grpResumen.ResumeLayout(false);
        grpResumen.PerformLayout();
        ResumeLayout(false);
    }

    #endregion

    private GroupBox grpCliente;
        private TextBox txtTelefono;
        private TextBox txtCliente;
        private Label lblTelefono;
        private Label lblNombre;
        private GroupBox grpPizza;
        private Label lblTamano;
        private ComboBox cboMasa;
        private Label lblMasa;
        private ComboBox cboTamano;
        private GroupBox grpIngredientes;
        private CheckBox chkTocino;
        private CheckBox chkPepperoni;
        private CheckBox chkAceitunas;
        private CheckBox chkChampinones;
        private CheckBox chkQuesoExtra;
        private GroupBox grpEntrega;
        private RadioButton rdbDelivery;
        private RadioButton rdbRetiro;
        private CheckBox chkConvenioEstudiante;
        private Label lblSubtotalValor;
        private Label lblIvaValor;
        private Label lblTotalValor;
        private Label lblDeliveryValor;
        private Label lblDescuentoValor;
        private GroupBox grpResumen;
        private Label lblDescuentoNombre;
        private Label lblDeliveryNombre;
        private Label lblIvaNombre;
        private Label lblTotalNombre;
        private Label lblSubtotalNombre;
        private Button btnCalcular;
        private Button btnLimpiar;
        private Button btnConfirmar;
    private ListBox lstResultados;
}
