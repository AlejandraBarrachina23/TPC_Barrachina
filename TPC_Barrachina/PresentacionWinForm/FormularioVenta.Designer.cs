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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormularioVenta));
            this.pnlCabecera = new System.Windows.Forms.Panel();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.lblDatosOperacion = new System.Windows.Forms.Label();
            this.btnAceptar = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.lblSaldo = new System.Windows.Forms.Label();
            this.lblUsuario = new System.Windows.Forms.Label();
            this.lblCliente = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.lblNumeroOperacion = new System.Windows.Forms.Label();
            this.btnCierreCaja = new System.Windows.Forms.Button();
            this.btnRetiroDinero = new System.Windows.Forms.Button();
            this.btnUltimasActualizaciones = new System.Windows.Forms.Button();
            this.btnAgregarCliente = new System.Windows.Forms.Button();
            this.btnDevolucion = new System.Windows.Forms.Button();
            this.btnMetodoPago = new System.Windows.Forms.Button();
            this.pnlDetalleVenta = new System.Windows.Forms.Panel();
            this.dgvDetalleVenta = new System.Windows.Forms.DataGridView();
            this.btnBusqueda = new System.Windows.Forms.Button();
            this.tboxCodigoBarra = new System.Windows.Forms.TextBox();
            this.panel7 = new System.Windows.Forms.Panel();
            this.lblDescuentoNumerico = new System.Windows.Forms.Label();
            this.lblSubtotalNumerico = new System.Windows.Forms.Label();
            this.label38 = new System.Windows.Forms.Label();
            this.lblTotalFactura = new System.Windows.Forms.Label();
            this.lblDescuento = new System.Windows.Forms.Label();
            this.lblSubtotal = new System.Windows.Forms.Label();
            this.tboxCantidad = new System.Windows.Forms.TextBox();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.pnlCabecera.SuspendLayout();
            this.pnlDetalleVenta.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDetalleVenta)).BeginInit();
            this.panel7.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlCabecera
            // 
            this.pnlCabecera.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.pnlCabecera.Controls.Add(this.btnCancelar);
            this.pnlCabecera.Controls.Add(this.lblDatosOperacion);
            this.pnlCabecera.Controls.Add(this.btnAceptar);
            this.pnlCabecera.Controls.Add(this.label6);
            this.pnlCabecera.Controls.Add(this.lblSaldo);
            this.pnlCabecera.Controls.Add(this.lblUsuario);
            this.pnlCabecera.Controls.Add(this.lblCliente);
            this.pnlCabecera.Controls.Add(this.label8);
            this.pnlCabecera.Controls.Add(this.label7);
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
            this.lblDatosOperacion.Location = new System.Drawing.Point(29, 12);
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
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Oswald Regular", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(11, 274);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(86, 21);
            this.label6.TabIndex = 8;
            this.label6.Text = "Método pago";
            // 
            // lblSaldo
            // 
            this.lblSaldo.AutoSize = true;
            this.lblSaldo.Font = new System.Drawing.Font("Oswald Regular", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSaldo.Location = new System.Drawing.Point(11, 237);
            this.lblSaldo.Name = "lblSaldo";
            this.lblSaldo.Size = new System.Drawing.Size(43, 21);
            this.lblSaldo.TabIndex = 8;
            this.lblSaldo.Text = "Saldo";
            // 
            // lblUsuario
            // 
            this.lblUsuario.AutoSize = true;
            this.lblUsuario.Font = new System.Drawing.Font("Oswald Regular", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUsuario.Location = new System.Drawing.Point(11, 199);
            this.lblUsuario.Name = "lblUsuario";
            this.lblUsuario.Size = new System.Drawing.Size(55, 21);
            this.lblUsuario.TabIndex = 8;
            this.lblUsuario.Text = "Usuario";
            // 
            // lblCliente
            // 
            this.lblCliente.AutoSize = true;
            this.lblCliente.Font = new System.Drawing.Font("Oswald Regular", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCliente.Location = new System.Drawing.Point(11, 156);
            this.lblCliente.Name = "lblCliente";
            this.lblCliente.Size = new System.Drawing.Size(56, 21);
            this.lblCliente.TabIndex = 8;
            this.lblCliente.Text = "Cliente ";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Oswald Regular", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(11, 114);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(38, 21);
            this.label8.TabIndex = 8;
            this.label8.Text = "Hora";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Oswald Regular", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(11, 78);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(44, 21);
            this.label7.TabIndex = 8;
            this.label7.Text = "Fecha";
            // 
            // lblNumeroOperacion
            // 
            this.lblNumeroOperacion.AutoSize = true;
            this.lblNumeroOperacion.Font = new System.Drawing.Font("Oswald Regular", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNumeroOperacion.Location = new System.Drawing.Point(45, 38);
            this.lblNumeroOperacion.Name = "lblNumeroOperacion";
            this.lblNumeroOperacion.Size = new System.Drawing.Size(70, 21);
            this.lblNumeroOperacion.TabIndex = 8;
            this.lblNumeroOperacion.Text = "Operación";
            // 
            // btnCierreCaja
            // 
            this.btnCierreCaja.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.btnCierreCaja.FlatAppearance.BorderSize = 0;
            this.btnCierreCaja.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCierreCaja.Font = new System.Drawing.Font("Bebas", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCierreCaja.Image = ((System.Drawing.Image)(resources.GetObject("btnCierreCaja.Image")));
            this.btnCierreCaja.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCierreCaja.Location = new System.Drawing.Point(734, 423);
            this.btnCierreCaja.Name = "btnCierreCaja";
            this.btnCierreCaja.Size = new System.Drawing.Size(119, 50);
            this.btnCierreCaja.TabIndex = 13;
            this.btnCierreCaja.Text = "CIERRE CAJA";
            this.btnCierreCaja.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
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
            this.btnRetiroDinero.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnRetiroDinero.Location = new System.Drawing.Point(734, 367);
            this.btnRetiroDinero.Name = "btnRetiroDinero";
            this.btnRetiroDinero.Size = new System.Drawing.Size(119, 50);
            this.btnRetiroDinero.TabIndex = 12;
            this.btnRetiroDinero.Text = "RETIRO DINERO";
            this.btnRetiroDinero.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnRetiroDinero.UseVisualStyleBackColor = false;
            this.btnRetiroDinero.Click += new System.EventHandler(this.btnRetiroDinero_Click);
            // 
            // btnUltimasActualizaciones
            // 
            this.btnUltimasActualizaciones.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.btnUltimasActualizaciones.FlatAppearance.BorderSize = 0;
            this.btnUltimasActualizaciones.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUltimasActualizaciones.Font = new System.Drawing.Font("Bebas", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUltimasActualizaciones.Image = ((System.Drawing.Image)(resources.GetObject("btnUltimasActualizaciones.Image")));
            this.btnUltimasActualizaciones.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnUltimasActualizaciones.Location = new System.Drawing.Point(734, 255);
            this.btnUltimasActualizaciones.Name = "btnUltimasActualizaciones";
            this.btnUltimasActualizaciones.Size = new System.Drawing.Size(119, 50);
            this.btnUltimasActualizaciones.TabIndex = 9;
            this.btnUltimasActualizaciones.Text = "ETIQUETAS";
            this.btnUltimasActualizaciones.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnUltimasActualizaciones.UseVisualStyleBackColor = false;
            this.btnUltimasActualizaciones.Click += new System.EventHandler(this.btnUltimasActualizaciones_Click);
            // 
            // btnAgregarCliente
            // 
            this.btnAgregarCliente.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.btnAgregarCliente.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btnAgregarCliente.FlatAppearance.BorderSize = 0;
            this.btnAgregarCliente.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAgregarCliente.Font = new System.Drawing.Font("Bebas", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAgregarCliente.Image = ((System.Drawing.Image)(resources.GetObject("btnAgregarCliente.Image")));
            this.btnAgregarCliente.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAgregarCliente.Location = new System.Drawing.Point(734, 199);
            this.btnAgregarCliente.Name = "btnAgregarCliente";
            this.btnAgregarCliente.Size = new System.Drawing.Size(119, 50);
            this.btnAgregarCliente.TabIndex = 9;
            this.btnAgregarCliente.Text = "CLIENTES";
            this.btnAgregarCliente.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
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
            this.btnDevolucion.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDevolucion.Location = new System.Drawing.Point(734, 311);
            this.btnDevolucion.Name = "btnDevolucion";
            this.btnDevolucion.Size = new System.Drawing.Size(119, 50);
            this.btnDevolucion.TabIndex = 9;
            this.btnDevolucion.Text = "DEVOLUCION";
            this.btnDevolucion.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
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
            this.btnMetodoPago.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnMetodoPago.Location = new System.Drawing.Point(734, 143);
            this.btnMetodoPago.Name = "btnMetodoPago";
            this.btnMetodoPago.Size = new System.Drawing.Size(119, 50);
            this.btnMetodoPago.TabIndex = 9;
            this.btnMetodoPago.Text = "METODO PAGO";
            this.btnMetodoPago.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnMetodoPago.UseVisualStyleBackColor = false;
            this.btnMetodoPago.Click += new System.EventHandler(this.btnMetodoPago_Click);
            // 
            // pnlDetalleVenta
            // 
            this.pnlDetalleVenta.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.pnlDetalleVenta.Controls.Add(this.panel7);
            this.pnlDetalleVenta.Controls.Add(this.tboxCantidad);
            this.pnlDetalleVenta.Controls.Add(this.dgvDetalleVenta);
            this.pnlDetalleVenta.Controls.Add(this.btnCierreCaja);
            this.pnlDetalleVenta.Controls.Add(this.btnAgregar);
            this.pnlDetalleVenta.Controls.Add(this.btnBusqueda);
            this.pnlDetalleVenta.Controls.Add(this.tboxCodigoBarra);
            this.pnlDetalleVenta.Controls.Add(this.btnMetodoPago);
            this.pnlDetalleVenta.Controls.Add(this.btnRetiroDinero);
            this.pnlDetalleVenta.Controls.Add(this.btnAgregarCliente);
            this.pnlDetalleVenta.Controls.Add(this.btnUltimasActualizaciones);
            this.pnlDetalleVenta.Controls.Add(this.btnDevolucion);
            this.pnlDetalleVenta.Location = new System.Drawing.Point(5, 12);
            this.pnlDetalleVenta.Name = "pnlDetalleVenta";
            this.pnlDetalleVenta.Size = new System.Drawing.Size(871, 495);
            this.pnlDetalleVenta.TabIndex = 2;
            // 
            // dgvDetalleVenta
            // 
            this.dgvDetalleVenta.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dgvDetalleVenta.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDetalleVenta.Location = new System.Drawing.Point(16, 74);
            this.dgvDetalleVenta.Name = "dgvDetalleVenta";
            this.dgvDetalleVenta.Size = new System.Drawing.Size(698, 330);
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
            this.btnBusqueda.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnBusqueda.Location = new System.Drawing.Point(733, 87);
            this.btnBusqueda.Name = "btnBusqueda";
            this.btnBusqueda.Size = new System.Drawing.Size(120, 50);
            this.btnBusqueda.TabIndex = 1;
            this.btnBusqueda.Text = "BUSQUEDA";
            this.btnBusqueda.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnBusqueda.UseVisualStyleBackColor = false;
            this.btnBusqueda.Click += new System.EventHandler(this.btnBusqueda_Click);
            // 
            // tboxCodigoBarra
            // 
            this.tboxCodigoBarra.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tboxCodigoBarra.Location = new System.Drawing.Point(16, 21);
            this.tboxCodigoBarra.Name = "tboxCodigoBarra";
            this.tboxCodigoBarra.Size = new System.Drawing.Size(611, 38);
            this.tboxCodigoBarra.TabIndex = 0;
            this.tboxCodigoBarra.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tboxCodigoBarra_KeyPress);
            // 
            // panel7
            // 
            this.panel7.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.panel7.Controls.Add(this.lblDescuentoNumerico);
            this.panel7.Controls.Add(this.lblSubtotalNumerico);
            this.panel7.Controls.Add(this.label38);
            this.panel7.Controls.Add(this.lblTotalFactura);
            this.panel7.Controls.Add(this.lblDescuento);
            this.panel7.Controls.Add(this.lblSubtotal);
            this.panel7.Location = new System.Drawing.Point(16, 410);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(698, 78);
            this.panel7.TabIndex = 3;
            // 
            // lblDescuentoNumerico
            // 
            this.lblDescuentoNumerico.AutoSize = true;
            this.lblDescuentoNumerico.Font = new System.Drawing.Font("Bebas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDescuentoNumerico.Location = new System.Drawing.Point(175, 40);
            this.lblDescuentoNumerico.Name = "lblDescuentoNumerico";
            this.lblDescuentoNumerico.Size = new System.Drawing.Size(34, 19);
            this.lblDescuentoNumerico.TabIndex = 11;
            this.lblDescuentoNumerico.Text = "0.00";
            // 
            // lblSubtotalNumerico
            // 
            this.lblSubtotalNumerico.AutoSize = true;
            this.lblSubtotalNumerico.Font = new System.Drawing.Font("Bebas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSubtotalNumerico.Location = new System.Drawing.Point(175, 20);
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
            // lblDescuento
            // 
            this.lblDescuento.AutoSize = true;
            this.lblDescuento.Font = new System.Drawing.Font("Bebas", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDescuento.Location = new System.Drawing.Point(27, 40);
            this.lblDescuento.Name = "lblDescuento";
            this.lblDescuento.Size = new System.Drawing.Size(79, 19);
            this.lblDescuento.TabIndex = 10;
            this.lblDescuento.Text = "DESCUENTO";
            // 
            // lblSubtotal
            // 
            this.lblSubtotal.AutoSize = true;
            this.lblSubtotal.Font = new System.Drawing.Font("Bebas", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSubtotal.Location = new System.Drawing.Point(28, 20);
            this.lblSubtotal.Name = "lblSubtotal";
            this.lblSubtotal.Size = new System.Drawing.Size(70, 19);
            this.lblSubtotal.TabIndex = 10;
            this.lblSubtotal.Text = "SUBTOTAL";
            // 
            // tboxCantidad
            // 
            this.tboxCantidad.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tboxCantidad.Location = new System.Drawing.Point(659, 21);
            this.tboxCantidad.Name = "tboxCantidad";
            this.tboxCantidad.Size = new System.Drawing.Size(55, 38);
            this.tboxCantidad.TabIndex = 1;
            this.tboxCantidad.Text = "1";
            this.tboxCantidad.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // btnAgregar
            // 
            this.btnAgregar.BackColor = System.Drawing.Color.Silver;
            this.btnAgregar.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
            this.btnAgregar.FlatAppearance.BorderSize = 0;
            this.btnAgregar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAgregar.Font = new System.Drawing.Font("Bebas", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAgregar.Image = ((System.Drawing.Image)(resources.GetObject("btnAgregar.Image")));
            this.btnAgregar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAgregar.Location = new System.Drawing.Point(733, 31);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(120, 50);
            this.btnAgregar.TabIndex = 3;
            this.btnAgregar.Text = "AGREGAR";
            this.btnAgregar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnAgregar.UseVisualStyleBackColor = false;
            this.btnAgregar.Click += new System.EventHandler(this.btnBusqueda_Click);
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
            this.Text = "Detalle:";
            this.Load += new System.EventHandler(this.FormularioVenta_Load);
            this.pnlCabecera.ResumeLayout(false);
            this.pnlCabecera.PerformLayout();
            this.pnlDetalleVenta.ResumeLayout(false);
            this.pnlDetalleVenta.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDetalleVenta)).EndInit();
            this.panel7.ResumeLayout(false);
            this.panel7.PerformLayout();
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
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btnDevolucion;
        private System.Windows.Forms.Button btnMetodoPago;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button btnUltimasActualizaciones;
        private System.Windows.Forms.Button btnCierreCaja;
        private System.Windows.Forms.Button btnRetiroDinero;
        private System.Windows.Forms.DataGridView dgvDetalleVenta;
        private System.Windows.Forms.TextBox tboxCantidad;
        private System.Windows.Forms.Button btnAgregar;
    }
}

