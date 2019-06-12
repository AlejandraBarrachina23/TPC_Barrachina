namespace PresentacionWinForm
{
    partial class FormularioVenta
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormularioVenta));
            this.pnlCabecera = new System.Windows.Forms.Panel();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.lblDatosOperacion = new System.Windows.Forms.Label();
            this.btnAceptar = new System.Windows.Forms.Button();
            this.lblMetodoPago = new System.Windows.Forms.Label();
            this.lblSaldo = new System.Windows.Forms.Label();
            this.lblUsuario = new System.Windows.Forms.Label();
            this.lblCliente = new System.Windows.Forms.Label();
            this.lblHora = new System.Windows.Forms.Label();
            this.lblFecha = new System.Windows.Forms.Label();
            this.lblNumeroOperacion = new System.Windows.Forms.Label();
            this.btnCierreCaja = new System.Windows.Forms.Button();
            this.btnRetiroDinero = new System.Windows.Forms.Button();
            this.btnAgregarCliente = new System.Windows.Forms.Button();
            this.btnDevolucion = new System.Windows.Forms.Button();
            this.btnMetodoPago = new System.Windows.Forms.Button();
            this.pnlDetalleVenta = new System.Windows.Forms.Panel();
            this.panel6 = new System.Windows.Forms.Panel();
            this.panel5 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.panel7 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.lblDescuentoNumerico = new System.Windows.Forms.Label();
            this.lblSubtotalNumerico = new System.Windows.Forms.Label();
            this.label38 = new System.Windows.Forms.Label();
            this.lblTotalFactura = new System.Windows.Forms.Label();
            this.lblInteres = new System.Windows.Forms.Label();
            this.lblDescuento = new System.Windows.Forms.Label();
            this.lblSubtotal = new System.Windows.Forms.Label();
            this.tboxCantidad = new System.Windows.Forms.TextBox();
            this.dgvDetalleVenta = new System.Windows.Forms.DataGridView();
            this.btnBusqueda = new System.Windows.Forms.Button();
            this.tboxCodigoBarra = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.HoraActual = new System.Windows.Forms.Timer(this.components);
            this.pnlCabecera.SuspendLayout();
            this.pnlDetalleVenta.SuspendLayout();
            this.panel7.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDetalleVenta)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlCabecera
            // 
            this.pnlCabecera.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.pnlCabecera.Controls.Add(this.btnCancelar);
            this.pnlCabecera.Controls.Add(this.lblDatosOperacion);
            this.pnlCabecera.Controls.Add(this.btnAceptar);
            this.pnlCabecera.Controls.Add(this.lblMetodoPago);
            this.pnlCabecera.Controls.Add(this.lblSaldo);
            this.pnlCabecera.Controls.Add(this.lblUsuario);
            this.pnlCabecera.Controls.Add(this.lblCliente);
            this.pnlCabecera.Controls.Add(this.lblHora);
            this.pnlCabecera.Controls.Add(this.lblFecha);
            this.pnlCabecera.Controls.Add(this.lblNumeroOperacion);
            this.pnlCabecera.Location = new System.Drawing.Point(882, 12);
            this.pnlCabecera.Name = "pnlCabecera";
            this.pnlCabecera.Size = new System.Drawing.Size(265, 495);
            this.pnlCabecera.TabIndex = 0;
            // 
            // btnCancelar
            // 
            this.btnCancelar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(115)))), ((int)(((byte)(149)))));
            this.btnCancelar.FlatAppearance.BorderSize = 0;
            this.btnCancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancelar.Font = new System.Drawing.Font("Bebas", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancelar.Image = ((System.Drawing.Image)(resources.GetObject("btnCancelar.Image")));
            this.btnCancelar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCancelar.Location = new System.Drawing.Point(84, 430);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(96, 35);
            this.btnCancelar.TabIndex = 11;
            this.btnCancelar.Text = "CANCELAR";
            this.btnCancelar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnCancelar.UseVisualStyleBackColor = false;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // lblDatosOperacion
            // 
            this.lblDatosOperacion.AutoSize = true;
            this.lblDatosOperacion.Font = new System.Drawing.Font("Oswald", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDatosOperacion.Location = new System.Drawing.Point(92, 12);
            this.lblDatosOperacion.Name = "lblDatosOperacion";
            this.lblDatosOperacion.Size = new System.Drawing.Size(114, 26);
            this.lblDatosOperacion.TabIndex = 9;
            this.lblDatosOperacion.Text = "DATOS VENTA";
            // 
            // btnAceptar
            // 
            this.btnAceptar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(115)))), ((int)(((byte)(149)))));
            this.btnAceptar.FlatAppearance.BorderSize = 0;
            this.btnAceptar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAceptar.Font = new System.Drawing.Font("Bebas", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAceptar.Image = ((System.Drawing.Image)(resources.GetObject("btnAceptar.Image")));
            this.btnAceptar.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.btnAceptar.Location = new System.Drawing.Point(84, 387);
            this.btnAceptar.Name = "btnAceptar";
            this.btnAceptar.Size = new System.Drawing.Size(96, 35);
            this.btnAceptar.TabIndex = 10;
            this.btnAceptar.Text = "ACEPTAR";
            this.btnAceptar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnAceptar.UseVisualStyleBackColor = false;
            this.btnAceptar.Click += new System.EventHandler(this.btnAceptar_Click);
            // 
            // lblMetodoPago
            // 
            this.lblMetodoPago.AutoSize = true;
            this.lblMetodoPago.Font = new System.Drawing.Font("Oswald Regular", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMetodoPago.Location = new System.Drawing.Point(14, 289);
            this.lblMetodoPago.Name = "lblMetodoPago";
            this.lblMetodoPago.Size = new System.Drawing.Size(86, 21);
            this.lblMetodoPago.TabIndex = 8;
            this.lblMetodoPago.Text = "Método pago";
            // 
            // lblSaldo
            // 
            this.lblSaldo.AutoSize = true;
            this.lblSaldo.Font = new System.Drawing.Font("Oswald Regular", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSaldo.Location = new System.Drawing.Point(14, 252);
            this.lblSaldo.Name = "lblSaldo";
            this.lblSaldo.Size = new System.Drawing.Size(89, 21);
            this.lblSaldo.TabIndex = 8;
            this.lblSaldo.Text = "Saldo : $0.00";
            // 
            // lblUsuario
            // 
            this.lblUsuario.AutoSize = true;
            this.lblUsuario.Font = new System.Drawing.Font("Oswald Regular", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUsuario.Location = new System.Drawing.Point(14, 214);
            this.lblUsuario.Name = "lblUsuario";
            this.lblUsuario.Size = new System.Drawing.Size(55, 21);
            this.lblUsuario.TabIndex = 8;
            this.lblUsuario.Text = "Usuario";
            // 
            // lblCliente
            // 
            this.lblCliente.AutoSize = true;
            this.lblCliente.Font = new System.Drawing.Font("Oswald Regular", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCliente.Location = new System.Drawing.Point(14, 171);
            this.lblCliente.Name = "lblCliente";
            this.lblCliente.Size = new System.Drawing.Size(56, 21);
            this.lblCliente.TabIndex = 8;
            this.lblCliente.Text = "Cliente ";
            // 
            // lblHora
            // 
            this.lblHora.AutoSize = true;
            this.lblHora.Font = new System.Drawing.Font("Oswald Regular", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHora.Location = new System.Drawing.Point(14, 129);
            this.lblHora.Name = "lblHora";
            this.lblHora.Size = new System.Drawing.Size(38, 21);
            this.lblHora.TabIndex = 8;
            this.lblHora.Text = "Hora";
            // 
            // lblFecha
            // 
            this.lblFecha.AutoSize = true;
            this.lblFecha.Font = new System.Drawing.Font("Oswald Regular", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFecha.Location = new System.Drawing.Point(14, 93);
            this.lblFecha.Name = "lblFecha";
            this.lblFecha.Size = new System.Drawing.Size(44, 21);
            this.lblFecha.TabIndex = 8;
            this.lblFecha.Text = "Fecha";
            // 
            // lblNumeroOperacion
            // 
            this.lblNumeroOperacion.AutoSize = true;
            this.lblNumeroOperacion.Font = new System.Drawing.Font("Oswald Regular", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNumeroOperacion.Location = new System.Drawing.Point(14, 60);
            this.lblNumeroOperacion.Name = "lblNumeroOperacion";
            this.lblNumeroOperacion.Size = new System.Drawing.Size(138, 21);
            this.lblNumeroOperacion.TabIndex = 8;
            this.lblNumeroOperacion.Text = "NUMERO OPERACION:";
            // 
            // btnCierreCaja
            // 
            this.btnCierreCaja.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.btnCierreCaja.FlatAppearance.BorderSize = 0;
            this.btnCierreCaja.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCierreCaja.Font = new System.Drawing.Font("Bebas", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCierreCaja.Image = ((System.Drawing.Image)(resources.GetObject("btnCierreCaja.Image")));
            this.btnCierreCaja.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnCierreCaja.Location = new System.Drawing.Point(752, 425);
            this.btnCierreCaja.Name = "btnCierreCaja";
            this.btnCierreCaja.Size = new System.Drawing.Size(100, 60);
            this.btnCierreCaja.TabIndex = 13;
            this.btnCierreCaja.Text = "CIERRE CAJA";
            this.btnCierreCaja.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnCierreCaja.UseVisualStyleBackColor = false;
            this.btnCierreCaja.Click += new System.EventHandler(this.btnCierreCaja_Click);
            // 
            // btnRetiroDinero
            // 
            this.btnRetiroDinero.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.btnRetiroDinero.FlatAppearance.BorderSize = 0;
            this.btnRetiroDinero.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRetiroDinero.Font = new System.Drawing.Font("Bebas", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRetiroDinero.Image = ((System.Drawing.Image)(resources.GetObject("btnRetiroDinero.Image")));
            this.btnRetiroDinero.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnRetiroDinero.Location = new System.Drawing.Point(752, 359);
            this.btnRetiroDinero.Name = "btnRetiroDinero";
            this.btnRetiroDinero.Size = new System.Drawing.Size(100, 60);
            this.btnRetiroDinero.TabIndex = 12;
            this.btnRetiroDinero.Text = "RETIRO DINERO";
            this.btnRetiroDinero.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnRetiroDinero.UseVisualStyleBackColor = false;
            this.btnRetiroDinero.Click += new System.EventHandler(this.btnRetiroDinero_Click);
            // 
            // btnAgregarCliente
            // 
            this.btnAgregarCliente.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.btnAgregarCliente.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btnAgregarCliente.FlatAppearance.BorderSize = 0;
            this.btnAgregarCliente.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAgregarCliente.Font = new System.Drawing.Font("Bebas", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAgregarCliente.Image = ((System.Drawing.Image)(resources.GetObject("btnAgregarCliente.Image")));
            this.btnAgregarCliente.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnAgregarCliente.Location = new System.Drawing.Point(752, 227);
            this.btnAgregarCliente.Name = "btnAgregarCliente";
            this.btnAgregarCliente.Size = new System.Drawing.Size(100, 60);
            this.btnAgregarCliente.TabIndex = 9;
            this.btnAgregarCliente.Text = "CLIENTES";
            this.btnAgregarCliente.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnAgregarCliente.UseVisualStyleBackColor = false;
            this.btnAgregarCliente.Click += new System.EventHandler(this.btnAgregarCliente_Click);
            // 
            // btnDevolucion
            // 
            this.btnDevolucion.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.btnDevolucion.FlatAppearance.BorderSize = 0;
            this.btnDevolucion.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDevolucion.Font = new System.Drawing.Font("Bebas", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDevolucion.Image = ((System.Drawing.Image)(resources.GetObject("btnDevolucion.Image")));
            this.btnDevolucion.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnDevolucion.Location = new System.Drawing.Point(752, 293);
            this.btnDevolucion.Name = "btnDevolucion";
            this.btnDevolucion.Size = new System.Drawing.Size(100, 60);
            this.btnDevolucion.TabIndex = 9;
            this.btnDevolucion.Text = "DEVOLUCION";
            this.btnDevolucion.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnDevolucion.UseVisualStyleBackColor = false;
            this.btnDevolucion.Click += new System.EventHandler(this.btnDevolucion_Click);
            // 
            // btnMetodoPago
            // 
            this.btnMetodoPago.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.btnMetodoPago.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
            this.btnMetodoPago.FlatAppearance.BorderSize = 0;
            this.btnMetodoPago.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMetodoPago.Font = new System.Drawing.Font("Bebas", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMetodoPago.Image = ((System.Drawing.Image)(resources.GetObject("btnMetodoPago.Image")));
            this.btnMetodoPago.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnMetodoPago.Location = new System.Drawing.Point(752, 161);
            this.btnMetodoPago.Name = "btnMetodoPago";
            this.btnMetodoPago.Size = new System.Drawing.Size(100, 60);
            this.btnMetodoPago.TabIndex = 9;
            this.btnMetodoPago.Text = "METODO PAGO";
            this.btnMetodoPago.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnMetodoPago.UseVisualStyleBackColor = false;
            this.btnMetodoPago.Click += new System.EventHandler(this.btnMetodoPago_Click);
            // 
            // pnlDetalleVenta
            // 
            this.pnlDetalleVenta.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.pnlDetalleVenta.Controls.Add(this.panel6);
            this.pnlDetalleVenta.Controls.Add(this.panel5);
            this.pnlDetalleVenta.Controls.Add(this.panel4);
            this.pnlDetalleVenta.Controls.Add(this.panel3);
            this.pnlDetalleVenta.Controls.Add(this.panel2);
            this.pnlDetalleVenta.Controls.Add(this.panel1);
            this.pnlDetalleVenta.Controls.Add(this.btnAgregar);
            this.pnlDetalleVenta.Controls.Add(this.panel7);
            this.pnlDetalleVenta.Controls.Add(this.tboxCantidad);
            this.pnlDetalleVenta.Controls.Add(this.dgvDetalleVenta);
            this.pnlDetalleVenta.Controls.Add(this.btnCierreCaja);
            this.pnlDetalleVenta.Controls.Add(this.btnBusqueda);
            this.pnlDetalleVenta.Controls.Add(this.tboxCodigoBarra);
            this.pnlDetalleVenta.Controls.Add(this.label3);
            this.pnlDetalleVenta.Controls.Add(this.label1);
            this.pnlDetalleVenta.Controls.Add(this.btnMetodoPago);
            this.pnlDetalleVenta.Controls.Add(this.btnRetiroDinero);
            this.pnlDetalleVenta.Controls.Add(this.btnAgregarCliente);
            this.pnlDetalleVenta.Controls.Add(this.btnDevolucion);
            this.pnlDetalleVenta.Location = new System.Drawing.Point(5, 12);
            this.pnlDetalleVenta.Name = "pnlDetalleVenta";
            this.pnlDetalleVenta.Size = new System.Drawing.Size(871, 495);
            this.pnlDetalleVenta.TabIndex = 2;
            // 
            // panel6
            // 
            this.panel6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(220)))), ((int)(((byte)(70)))));
            this.panel6.Location = new System.Drawing.Point(752, 425);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(5, 60);
            this.panel6.TabIndex = 18;
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(220)))), ((int)(((byte)(70)))));
            this.panel5.Location = new System.Drawing.Point(752, 359);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(5, 60);
            this.panel5.TabIndex = 18;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(220)))), ((int)(((byte)(70)))));
            this.panel4.Location = new System.Drawing.Point(752, 293);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(5, 60);
            this.panel4.TabIndex = 18;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(220)))), ((int)(((byte)(70)))));
            this.panel3.Location = new System.Drawing.Point(752, 227);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(5, 60);
            this.panel3.TabIndex = 18;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(220)))), ((int)(((byte)(70)))));
            this.panel2.Location = new System.Drawing.Point(752, 161);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(5, 60);
            this.panel2.TabIndex = 18;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(220)))), ((int)(((byte)(70)))));
            this.panel1.Location = new System.Drawing.Point(752, 95);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(5, 60);
            this.panel1.TabIndex = 18;
            // 
            // btnAgregar
            // 
            this.btnAgregar.BackColor = System.Drawing.Color.Transparent;
            this.btnAgregar.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
            this.btnAgregar.FlatAppearance.BorderSize = 0;
            this.btnAgregar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAgregar.Font = new System.Drawing.Font("Bebas", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAgregar.Image = ((System.Drawing.Image)(resources.GetObject("btnAgregar.Image")));
            this.btnAgregar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAgregar.Location = new System.Drawing.Point(785, 30);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(44, 38);
            this.btnAgregar.TabIndex = 2;
            this.btnAgregar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnAgregar.UseVisualStyleBackColor = false;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // panel7
            // 
            this.panel7.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.panel7.Controls.Add(this.label2);
            this.panel7.Controls.Add(this.lblDescuentoNumerico);
            this.panel7.Controls.Add(this.lblSubtotalNumerico);
            this.panel7.Controls.Add(this.label38);
            this.panel7.Controls.Add(this.lblTotalFactura);
            this.panel7.Controls.Add(this.lblInteres);
            this.panel7.Controls.Add(this.lblDescuento);
            this.panel7.Controls.Add(this.lblSubtotal);
            this.panel7.Location = new System.Drawing.Point(16, 410);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(711, 78);
            this.panel7.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Bebas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(175, 48);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(34, 19);
            this.label2.TabIndex = 11;
            this.label2.Text = "0.00";
            // 
            // lblDescuentoNumerico
            // 
            this.lblDescuentoNumerico.AutoSize = true;
            this.lblDescuentoNumerico.Font = new System.Drawing.Font("Bebas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDescuentoNumerico.Location = new System.Drawing.Point(175, 28);
            this.lblDescuentoNumerico.Name = "lblDescuentoNumerico";
            this.lblDescuentoNumerico.Size = new System.Drawing.Size(34, 19);
            this.lblDescuentoNumerico.TabIndex = 11;
            this.lblDescuentoNumerico.Text = "0.00";
            // 
            // lblSubtotalNumerico
            // 
            this.lblSubtotalNumerico.AutoSize = true;
            this.lblSubtotalNumerico.Font = new System.Drawing.Font("Bebas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSubtotalNumerico.Location = new System.Drawing.Point(175, 7);
            this.lblSubtotalNumerico.Name = "lblSubtotalNumerico";
            this.lblSubtotalNumerico.Size = new System.Drawing.Size(34, 19);
            this.lblSubtotalNumerico.TabIndex = 11;
            this.lblSubtotalNumerico.Text = "0.00";
            // 
            // label38
            // 
            this.label38.AutoSize = true;
            this.label38.Font = new System.Drawing.Font("Bebas", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label38.Location = new System.Drawing.Point(623, 4);
            this.label38.Name = "label38";
            this.label38.Size = new System.Drawing.Size(46, 19);
            this.label38.TabIndex = 10;
            this.label38.Text = "TOTAL";
            // 
            // lblTotalFactura
            // 
            this.lblTotalFactura.AutoSize = true;
            this.lblTotalFactura.Font = new System.Drawing.Font("Bebas", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalFactura.Location = new System.Drawing.Point(601, 21);
            this.lblTotalFactura.Name = "lblTotalFactura";
            this.lblTotalFactura.Size = new System.Drawing.Size(91, 42);
            this.lblTotalFactura.TabIndex = 10;
            this.lblTotalFactura.Text = "$0.00";
            // 
            // lblInteres
            // 
            this.lblInteres.AutoSize = true;
            this.lblInteres.Font = new System.Drawing.Font("Bebas", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblInteres.Location = new System.Drawing.Point(27, 48);
            this.lblInteres.Name = "lblInteres";
            this.lblInteres.Size = new System.Drawing.Size(60, 19);
            this.lblInteres.TabIndex = 10;
            this.lblInteres.Text = "INTERES";
            // 
            // lblDescuento
            // 
            this.lblDescuento.AutoSize = true;
            this.lblDescuento.Font = new System.Drawing.Font("Bebas", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDescuento.Location = new System.Drawing.Point(27, 28);
            this.lblDescuento.Name = "lblDescuento";
            this.lblDescuento.Size = new System.Drawing.Size(79, 19);
            this.lblDescuento.TabIndex = 10;
            this.lblDescuento.Text = "DESCUENTO";
            // 
            // lblSubtotal
            // 
            this.lblSubtotal.AutoSize = true;
            this.lblSubtotal.Font = new System.Drawing.Font("Bebas", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSubtotal.Location = new System.Drawing.Point(28, 7);
            this.lblSubtotal.Name = "lblSubtotal";
            this.lblSubtotal.Size = new System.Drawing.Size(70, 19);
            this.lblSubtotal.TabIndex = 10;
            this.lblSubtotal.Text = "SUBTOTAL";
            // 
            // tboxCantidad
            // 
            this.tboxCantidad.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tboxCantidad.Location = new System.Drawing.Point(655, 30);
            this.tboxCantidad.Name = "tboxCantidad";
            this.tboxCantidad.Size = new System.Drawing.Size(72, 38);
            this.tboxCantidad.TabIndex = 1;
            this.tboxCantidad.Text = "1";
            this.tboxCantidad.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // dgvDetalleVenta
            // 
            this.dgvDetalleVenta.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dgvDetalleVenta.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDetalleVenta.Location = new System.Drawing.Point(16, 74);
            this.dgvDetalleVenta.Name = "dgvDetalleVenta";
            this.dgvDetalleVenta.Size = new System.Drawing.Size(711, 330);
            this.dgvDetalleVenta.TabIndex = 16;
            // 
            // btnBusqueda
            // 
            this.btnBusqueda.BackColor = System.Drawing.Color.Silver;
            this.btnBusqueda.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
            this.btnBusqueda.FlatAppearance.BorderSize = 0;
            this.btnBusqueda.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBusqueda.Font = new System.Drawing.Font("Bebas", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBusqueda.Image = ((System.Drawing.Image)(resources.GetObject("btnBusqueda.Image")));
            this.btnBusqueda.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnBusqueda.Location = new System.Drawing.Point(752, 94);
            this.btnBusqueda.Name = "btnBusqueda";
            this.btnBusqueda.Size = new System.Drawing.Size(100, 60);
            this.btnBusqueda.TabIndex = 4;
            this.btnBusqueda.Text = "busqueda";
            this.btnBusqueda.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnBusqueda.UseVisualStyleBackColor = false;
            this.btnBusqueda.Click += new System.EventHandler(this.btnBusqueda_Click);
            // 
            // tboxCodigoBarra
            // 
            this.tboxCodigoBarra.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tboxCodigoBarra.Location = new System.Drawing.Point(16, 30);
            this.tboxCodigoBarra.Name = "tboxCodigoBarra";
            this.tboxCodigoBarra.Size = new System.Drawing.Size(633, 38);
            this.tboxCodigoBarra.TabIndex = 0;
            this.tboxCodigoBarra.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tboxCodigoBarra_KeyPress);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Oswald", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(656, 10);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(56, 17);
            this.label3.TabIndex = 10;
            this.label3.Text = "Cantidad";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Oswald", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(19, 10);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(95, 17);
            this.label1.TabIndex = 10;
            this.label1.Text = "Código Producto";
            // 
            // HoraActual
            // 
            this.HoraActual.Tick += new System.EventHandler(this.HoraActual_Tick);
            // 
            // FormularioVenta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(115)))), ((int)(((byte)(149)))));
            this.ClientSize = new System.Drawing.Size(1154, 519);
            this.Controls.Add(this.pnlDetalleVenta);
            this.Controls.Add(this.pnlCabecera);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormularioVenta";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "Detalle:";
            this.Load += new System.EventHandler(this.FormularioVenta_Load);
            this.pnlCabecera.ResumeLayout(false);
            this.pnlCabecera.PerformLayout();
            this.pnlDetalleVenta.ResumeLayout(false);
            this.pnlDetalleVenta.PerformLayout();
            this.panel7.ResumeLayout(false);
            this.panel7.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDetalleVenta)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel pnlCabecera;
        private System.Windows.Forms.Panel pnlDetalleVenta;
        private System.Windows.Forms.Panel panel7;
        private System.Windows.Forms.Button btnBusqueda;
        private System.Windows.Forms.TextBox tboxCodigoBarra;
        private System.Windows.Forms.Label lblNumeroOperacion;
        private System.Windows.Forms.Label lblDescuentoNumerico;
        private System.Windows.Forms.Label lblSubtotalNumerico;
        private System.Windows.Forms.Label lblTotalFactura;
        private System.Windows.Forms.Label lblDescuento;
        private System.Windows.Forms.Label lblSubtotal;
        private System.Windows.Forms.Label lblUsuario;
        private System.Windows.Forms.Label lblCliente;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button btnAceptar;
        private System.Windows.Forms.Button btnAgregarCliente;
        private System.Windows.Forms.Label lblSaldo;
        private System.Windows.Forms.Label label38;
        private System.Windows.Forms.Label lblDatosOperacion;
        private System.Windows.Forms.Label lblMetodoPago;
        private System.Windows.Forms.Button btnDevolucion;
        private System.Windows.Forms.Button btnMetodoPago;
        private System.Windows.Forms.Label lblHora;
        private System.Windows.Forms.Label lblFecha;
        private System.Windows.Forms.Button btnCierreCaja;
        private System.Windows.Forms.Button btnRetiroDinero;
        private System.Windows.Forms.DataGridView dgvDetalleVenta;
        private System.Windows.Forms.TextBox tboxCantidad;
        private System.Windows.Forms.Timer HoraActual;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblInteres;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Panel panel5;
    }
}

