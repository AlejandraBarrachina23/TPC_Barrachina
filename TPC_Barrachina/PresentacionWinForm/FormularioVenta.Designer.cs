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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormularioVenta));
            this.pnlCabecera = new System.Windows.Forms.Panel();
            this.cboxMotivoDevolucion = new System.Windows.Forms.ComboBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.tboxSaldo = new System.Windows.Forms.TextBox();
            this.tboxClientes = new System.Windows.Forms.TextBox();
            this.tboxMetodoPago = new System.Windows.Forms.TextBox();
            this.tboxUsuario = new System.Windows.Forms.TextBox();
            this.tboxHora = new System.Windows.Forms.TextBox();
            this.tboxFechaEmision = new System.Windows.Forms.TextBox();
            this.tboxNumeroOperacion = new System.Windows.Forms.TextBox();
            this.lblDatosOperacion = new System.Windows.Forms.Label();
            this.lblMotivoDevolucion = new System.Windows.Forms.Label();
            this.lblMetodoPago = new System.Windows.Forms.Label();
            this.lblSaldo = new System.Windows.Forms.Label();
            this.lblUsuario = new System.Windows.Forms.Label();
            this.lblCliente = new System.Windows.Forms.Label();
            this.lblHora = new System.Windows.Forms.Label();
            this.lblFechaEmision = new System.Windows.Forms.Label();
            this.lblNumeroOperacion = new System.Windows.Forms.Label();
            this.tboxCantidad = new System.Windows.Forms.TextBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.tboxCodigoBarra = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnAceptar = new System.Windows.Forms.Button();
            this.btnCierreCaja = new System.Windows.Forms.Button();
            this.btnRetiroDinero = new System.Windows.Forms.Button();
            this.btnAgregarCliente = new System.Windows.Forms.Button();
            this.btnDevolucion = new System.Windows.Forms.Button();
            this.btnMetodoPago = new System.Windows.Forms.Button();
            this.pnlDetalleVenta = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.btnBorrar = new System.Windows.Forms.Button();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.panel7 = new System.Windows.Forms.Panel();
            this.lblDescuentoNumerico = new System.Windows.Forms.Label();
            this.lblSubtotalNumerico = new System.Windows.Forms.Label();
            this.label38 = new System.Windows.Forms.Label();
            this.lblTotalFactura = new System.Windows.Forms.Label();
            this.lblDescuento = new System.Windows.Forms.Label();
            this.lblSubtotal = new System.Windows.Forms.Label();
            this.dgvDetalleVenta = new System.Windows.Forms.DataGridView();
            this.panel5 = new System.Windows.Forms.Panel();
            this.btnBusqueda = new System.Windows.Forms.Button();
            this.HoraActual = new System.Windows.Forms.Timer(this.components);
            this.panelMenu = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnLogOut = new System.Windows.Forms.Button();
            this.panel9 = new System.Windows.Forms.Panel();
            this.panel8 = new System.Windows.Forms.Panel();
            this.panel10 = new System.Windows.Forms.Panel();
            this.panel11 = new System.Windows.Forms.Panel();
            this.panel12 = new System.Windows.Forms.Panel();
            this.panel13 = new System.Windows.Forms.Panel();
            this.panel14 = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.lblCompras = new System.Windows.Forms.Label();
            this.btnResetear = new System.Windows.Forms.Button();
            this.pnlCabecera.SuspendLayout();
            this.pnlDetalleVenta.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel7.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDetalleVenta)).BeginInit();
            this.panelMenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlCabecera
            // 
            this.pnlCabecera.BackColor = System.Drawing.Color.OldLace;
            this.pnlCabecera.Controls.Add(this.btnResetear);
            this.pnlCabecera.Controls.Add(this.cboxMotivoDevolucion);
            this.pnlCabecera.Controls.Add(this.panel2);
            this.pnlCabecera.Controls.Add(this.tboxSaldo);
            this.pnlCabecera.Controls.Add(this.tboxClientes);
            this.pnlCabecera.Controls.Add(this.tboxMetodoPago);
            this.pnlCabecera.Controls.Add(this.tboxUsuario);
            this.pnlCabecera.Controls.Add(this.tboxHora);
            this.pnlCabecera.Controls.Add(this.tboxFechaEmision);
            this.pnlCabecera.Controls.Add(this.tboxNumeroOperacion);
            this.pnlCabecera.Controls.Add(this.lblDatosOperacion);
            this.pnlCabecera.Controls.Add(this.lblMotivoDevolucion);
            this.pnlCabecera.Controls.Add(this.lblMetodoPago);
            this.pnlCabecera.Controls.Add(this.lblSaldo);
            this.pnlCabecera.Controls.Add(this.lblUsuario);
            this.pnlCabecera.Controls.Add(this.lblCliente);
            this.pnlCabecera.Controls.Add(this.lblHora);
            this.pnlCabecera.Controls.Add(this.lblFechaEmision);
            this.pnlCabecera.Controls.Add(this.lblNumeroOperacion);
            this.pnlCabecera.Location = new System.Drawing.Point(0, 0);
            this.pnlCabecera.Name = "pnlCabecera";
            this.pnlCabecera.Size = new System.Drawing.Size(1056, 134);
            this.pnlCabecera.TabIndex = 0;
            // 
            // cboxMotivoDevolucion
            // 
            this.cboxMotivoDevolucion.Font = new System.Drawing.Font("Oswald Regular", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboxMotivoDevolucion.FormattingEnabled = true;
            this.cboxMotivoDevolucion.Items.AddRange(new object[] {
            "Mercaderia vencida",
            "Mercadería en mal estado",
            "Equivocación Cliente",
            "Equivocación Usuario",
            "Disconformidad con precio",
            "Otros"});
            this.cboxMotivoDevolucion.Location = new System.Drawing.Point(867, 94);
            this.cboxMotivoDevolucion.Name = "cboxMotivoDevolucion";
            this.cboxMotivoDevolucion.Size = new System.Drawing.Size(157, 25);
            this.cboxMotivoDevolucion.TabIndex = 22;
            this.cboxMotivoDevolucion.Visible = false;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Black;
            this.panel2.Location = new System.Drawing.Point(0, 39);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1050, 2);
            this.panel2.TabIndex = 21;
            // 
            // tboxSaldo
            // 
            this.tboxSaldo.Font = new System.Drawing.Font("Oswald Regular", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tboxSaldo.Location = new System.Drawing.Point(619, 94);
            this.tboxSaldo.Name = "tboxSaldo";
            this.tboxSaldo.Size = new System.Drawing.Size(157, 25);
            this.tboxSaldo.TabIndex = 11;
            // 
            // tboxClientes
            // 
            this.tboxClientes.Font = new System.Drawing.Font("Oswald Regular", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tboxClientes.Location = new System.Drawing.Point(365, 96);
            this.tboxClientes.Name = "tboxClientes";
            this.tboxClientes.Size = new System.Drawing.Size(157, 25);
            this.tboxClientes.TabIndex = 11;
            // 
            // tboxMetodoPago
            // 
            this.tboxMetodoPago.Font = new System.Drawing.Font("Oswald Regular", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tboxMetodoPago.Location = new System.Drawing.Point(140, 96);
            this.tboxMetodoPago.Name = "tboxMetodoPago";
            this.tboxMetodoPago.Size = new System.Drawing.Size(157, 25);
            this.tboxMetodoPago.TabIndex = 11;
            // 
            // tboxUsuario
            // 
            this.tboxUsuario.Font = new System.Drawing.Font("Oswald Regular", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tboxUsuario.Location = new System.Drawing.Point(867, 54);
            this.tboxUsuario.Name = "tboxUsuario";
            this.tboxUsuario.Size = new System.Drawing.Size(157, 25);
            this.tboxUsuario.TabIndex = 11;
            // 
            // tboxHora
            // 
            this.tboxHora.Font = new System.Drawing.Font("Oswald Regular", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tboxHora.Location = new System.Drawing.Point(619, 54);
            this.tboxHora.Name = "tboxHora";
            this.tboxHora.Size = new System.Drawing.Size(157, 25);
            this.tboxHora.TabIndex = 11;
            // 
            // tboxFechaEmision
            // 
            this.tboxFechaEmision.Font = new System.Drawing.Font("Oswald Regular", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tboxFechaEmision.Location = new System.Drawing.Point(365, 54);
            this.tboxFechaEmision.Name = "tboxFechaEmision";
            this.tboxFechaEmision.Size = new System.Drawing.Size(157, 25);
            this.tboxFechaEmision.TabIndex = 11;
            // 
            // tboxNumeroOperacion
            // 
            this.tboxNumeroOperacion.Font = new System.Drawing.Font("Oswald Regular", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tboxNumeroOperacion.Location = new System.Drawing.Point(140, 54);
            this.tboxNumeroOperacion.Name = "tboxNumeroOperacion";
            this.tboxNumeroOperacion.Size = new System.Drawing.Size(157, 25);
            this.tboxNumeroOperacion.TabIndex = 11;
            // 
            // lblDatosOperacion
            // 
            this.lblDatosOperacion.AutoSize = true;
            this.lblDatosOperacion.Font = new System.Drawing.Font("Oswald", 20.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDatosOperacion.Location = new System.Drawing.Point(5, 1);
            this.lblDatosOperacion.Name = "lblDatosOperacion";
            this.lblDatosOperacion.Size = new System.Drawing.Size(146, 36);
            this.lblDatosOperacion.TabIndex = 9;
            this.lblDatosOperacion.Text = "Datos Venta";
            // 
            // lblMotivoDevolucion
            // 
            this.lblMotivoDevolucion.AutoSize = true;
            this.lblMotivoDevolucion.Font = new System.Drawing.Font("Oswald", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMotivoDevolucion.Location = new System.Drawing.Point(791, 99);
            this.lblMotivoDevolucion.Name = "lblMotivoDevolucion";
            this.lblMotivoDevolucion.Size = new System.Drawing.Size(70, 17);
            this.lblMotivoDevolucion.TabIndex = 8;
            this.lblMotivoDevolucion.Text = "Devolución:";
            this.lblMotivoDevolucion.Visible = false;
            // 
            // lblMetodoPago
            // 
            this.lblMetodoPago.AutoSize = true;
            this.lblMetodoPago.Font = new System.Drawing.Font("Oswald", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMetodoPago.Location = new System.Drawing.Point(55, 99);
            this.lblMetodoPago.Name = "lblMetodoPago";
            this.lblMetodoPago.Size = new System.Drawing.Size(79, 17);
            this.lblMetodoPago.TabIndex = 8;
            this.lblMetodoPago.Text = "Método pago:";
            // 
            // lblSaldo
            // 
            this.lblSaldo.AutoSize = true;
            this.lblSaldo.Font = new System.Drawing.Font("Oswald", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSaldo.Location = new System.Drawing.Point(570, 99);
            this.lblSaldo.Name = "lblSaldo";
            this.lblSaldo.Size = new System.Drawing.Size(42, 17);
            this.lblSaldo.TabIndex = 8;
            this.lblSaldo.Text = "Saldo:";
            // 
            // lblUsuario
            // 
            this.lblUsuario.AutoSize = true;
            this.lblUsuario.Font = new System.Drawing.Font("Oswald", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUsuario.Location = new System.Drawing.Point(809, 58);
            this.lblUsuario.Name = "lblUsuario";
            this.lblUsuario.Size = new System.Drawing.Size(52, 17);
            this.lblUsuario.TabIndex = 8;
            this.lblUsuario.Text = "Usuario:";
            // 
            // lblCliente
            // 
            this.lblCliente.AutoSize = true;
            this.lblCliente.Font = new System.Drawing.Font("Oswald", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCliente.Location = new System.Drawing.Point(309, 99);
            this.lblCliente.Name = "lblCliente";
            this.lblCliente.Size = new System.Drawing.Size(50, 17);
            this.lblCliente.TabIndex = 8;
            this.lblCliente.Text = "Cliente:";
            // 
            // lblHora
            // 
            this.lblHora.AutoSize = true;
            this.lblHora.Font = new System.Drawing.Font("Oswald", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHora.Location = new System.Drawing.Point(575, 58);
            this.lblHora.Name = "lblHora";
            this.lblHora.Size = new System.Drawing.Size(37, 17);
            this.lblHora.TabIndex = 8;
            this.lblHora.Text = "Hora:";
            // 
            // lblFechaEmision
            // 
            this.lblFechaEmision.AutoSize = true;
            this.lblFechaEmision.Font = new System.Drawing.Font("Oswald", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFechaEmision.Location = new System.Drawing.Point(316, 58);
            this.lblFechaEmision.Name = "lblFechaEmision";
            this.lblFechaEmision.Size = new System.Drawing.Size(43, 17);
            this.lblFechaEmision.TabIndex = 8;
            this.lblFechaEmision.Text = "Fecha:";
            // 
            // lblNumeroOperacion
            // 
            this.lblNumeroOperacion.AutoSize = true;
            this.lblNumeroOperacion.Font = new System.Drawing.Font("Oswald", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNumeroOperacion.Location = new System.Drawing.Point(24, 58);
            this.lblNumeroOperacion.Name = "lblNumeroOperacion";
            this.lblNumeroOperacion.Size = new System.Drawing.Size(110, 17);
            this.lblNumeroOperacion.TabIndex = 8;
            this.lblNumeroOperacion.Text = "Número Operación:";
            // 
            // tboxCantidad
            // 
            this.tboxCantidad.Font = new System.Drawing.Font("Oswald", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tboxCantidad.Location = new System.Drawing.Point(613, 26);
            this.tboxCantidad.Name = "tboxCantidad";
            this.tboxCantidad.Size = new System.Drawing.Size(93, 36);
            this.tboxCantidad.TabIndex = 1;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.Black;
            this.panel3.Location = new System.Drawing.Point(1, -8);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1058, 10);
            this.panel3.TabIndex = 21;
            // 
            // tboxCodigoBarra
            // 
            this.tboxCodigoBarra.Font = new System.Drawing.Font("Oswald", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tboxCodigoBarra.Location = new System.Drawing.Point(180, 26);
            this.tboxCodigoBarra.Name = "tboxCodigoBarra";
            this.tboxCodigoBarra.Size = new System.Drawing.Size(360, 36);
            this.tboxCodigoBarra.TabIndex = 0;
            this.tboxCodigoBarra.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tboxCodigoBarra_KeyPress);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Oswald", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(556, 38);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(56, 17);
            this.label3.TabIndex = 10;
            this.label3.Text = "Cantidad";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Oswald", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(79, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(95, 17);
            this.label1.TabIndex = 10;
            this.label1.Text = "Código Producto";
            // 
            // btnCancelar
            // 
            this.btnCancelar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(115)))), ((int)(((byte)(149)))));
            this.btnCancelar.FlatAppearance.BorderSize = 0;
            this.btnCancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancelar.Font = new System.Drawing.Font("Bebas", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancelar.ForeColor = System.Drawing.Color.White;
            this.btnCancelar.Image = ((System.Drawing.Image)(resources.GetObject("btnCancelar.Image")));
            this.btnCancelar.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnCancelar.Location = new System.Drawing.Point(923, 18);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(100, 60);
            this.btnCancelar.TabIndex = 12;
            this.btnCancelar.Text = "CANCELAR";
            this.btnCancelar.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnCancelar.UseVisualStyleBackColor = false;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // btnAceptar
            // 
            this.btnAceptar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(115)))), ((int)(((byte)(149)))));
            this.btnAceptar.FlatAppearance.BorderSize = 0;
            this.btnAceptar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAceptar.Font = new System.Drawing.Font("Bebas", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAceptar.ForeColor = System.Drawing.Color.White;
            this.btnAceptar.Image = ((System.Drawing.Image)(resources.GetObject("btnAceptar.Image")));
            this.btnAceptar.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnAceptar.Location = new System.Drawing.Point(817, 18);
            this.btnAceptar.Name = "btnAceptar";
            this.btnAceptar.Size = new System.Drawing.Size(100, 60);
            this.btnAceptar.TabIndex = 11;
            this.btnAceptar.Text = "ACEPTAR";
            this.btnAceptar.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnAceptar.UseVisualStyleBackColor = false;
            this.btnAceptar.Click += new System.EventHandler(this.btnAceptar_Click);
            // 
            // btnCierreCaja
            // 
            this.btnCierreCaja.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(115)))), ((int)(((byte)(149)))));
            this.btnCierreCaja.FlatAppearance.BorderSize = 0;
            this.btnCierreCaja.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCierreCaja.Font = new System.Drawing.Font("Bebas", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCierreCaja.ForeColor = System.Drawing.Color.White;
            this.btnCierreCaja.Image = ((System.Drawing.Image)(resources.GetObject("btnCierreCaja.Image")));
            this.btnCierreCaja.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnCierreCaja.Location = new System.Drawing.Point(1, 272);
            this.btnCierreCaja.Name = "btnCierreCaja";
            this.btnCierreCaja.Size = new System.Drawing.Size(100, 60);
            this.btnCierreCaja.TabIndex = 7;
            this.btnCierreCaja.Text = "CIERRE CAJA";
            this.btnCierreCaja.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnCierreCaja.UseVisualStyleBackColor = false;
            this.btnCierreCaja.Click += new System.EventHandler(this.btnCierreCaja_Click);
            // 
            // btnRetiroDinero
            // 
            this.btnRetiroDinero.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(115)))), ((int)(((byte)(149)))));
            this.btnRetiroDinero.FlatAppearance.BorderSize = 0;
            this.btnRetiroDinero.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRetiroDinero.Font = new System.Drawing.Font("Bebas", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRetiroDinero.ForeColor = System.Drawing.Color.White;
            this.btnRetiroDinero.Image = ((System.Drawing.Image)(resources.GetObject("btnRetiroDinero.Image")));
            this.btnRetiroDinero.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnRetiroDinero.Location = new System.Drawing.Point(3, 207);
            this.btnRetiroDinero.Name = "btnRetiroDinero";
            this.btnRetiroDinero.Size = new System.Drawing.Size(100, 60);
            this.btnRetiroDinero.TabIndex = 6;
            this.btnRetiroDinero.Text = "RETIRO DINERO";
            this.btnRetiroDinero.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnRetiroDinero.UseVisualStyleBackColor = false;
            this.btnRetiroDinero.Click += new System.EventHandler(this.btnRetiroDinero_Click);
            // 
            // btnAgregarCliente
            // 
            this.btnAgregarCliente.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(115)))), ((int)(((byte)(149)))));
            this.btnAgregarCliente.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btnAgregarCliente.FlatAppearance.BorderSize = 0;
            this.btnAgregarCliente.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAgregarCliente.Font = new System.Drawing.Font("Bebas", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAgregarCliente.ForeColor = System.Drawing.Color.White;
            this.btnAgregarCliente.Image = ((System.Drawing.Image)(resources.GetObject("btnAgregarCliente.Image")));
            this.btnAgregarCliente.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnAgregarCliente.Location = new System.Drawing.Point(1, 107);
            this.btnAgregarCliente.Name = "btnAgregarCliente";
            this.btnAgregarCliente.Size = new System.Drawing.Size(100, 60);
            this.btnAgregarCliente.TabIndex = 5;
            this.btnAgregarCliente.Text = "CLIENTES";
            this.btnAgregarCliente.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnAgregarCliente.UseVisualStyleBackColor = false;
            this.btnAgregarCliente.Click += new System.EventHandler(this.btnAgregarCliente_Click);
            // 
            // btnDevolucion
            // 
            this.btnDevolucion.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(115)))), ((int)(((byte)(149)))));
            this.btnDevolucion.FlatAppearance.BorderSize = 0;
            this.btnDevolucion.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDevolucion.Font = new System.Drawing.Font("Bebas", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDevolucion.ForeColor = System.Drawing.Color.White;
            this.btnDevolucion.Image = ((System.Drawing.Image)(resources.GetObject("btnDevolucion.Image")));
            this.btnDevolucion.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnDevolucion.Location = new System.Drawing.Point(3, 412);
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
            this.btnMetodoPago.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(115)))), ((int)(((byte)(149)))));
            this.btnMetodoPago.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
            this.btnMetodoPago.FlatAppearance.BorderSize = 0;
            this.btnMetodoPago.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMetodoPago.Font = new System.Drawing.Font("Bebas", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMetodoPago.ForeColor = System.Drawing.Color.White;
            this.btnMetodoPago.Image = ((System.Drawing.Image)(resources.GetObject("btnMetodoPago.Image")));
            this.btnMetodoPago.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnMetodoPago.Location = new System.Drawing.Point(3, 339);
            this.btnMetodoPago.Name = "btnMetodoPago";
            this.btnMetodoPago.Size = new System.Drawing.Size(100, 60);
            this.btnMetodoPago.TabIndex = 8;
            this.btnMetodoPago.Text = "METODO PAGO";
            this.btnMetodoPago.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnMetodoPago.UseVisualStyleBackColor = false;
            this.btnMetodoPago.Click += new System.EventHandler(this.btnMetodoPago_Click);
            // 
            // pnlDetalleVenta
            // 
            this.pnlDetalleVenta.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.pnlDetalleVenta.Controls.Add(this.panel4);
            this.pnlDetalleVenta.Controls.Add(this.pnlCabecera);
            this.pnlDetalleVenta.Controls.Add(this.panel7);
            this.pnlDetalleVenta.Controls.Add(this.dgvDetalleVenta);
            this.pnlDetalleVenta.Location = new System.Drawing.Point(0, 0);
            this.pnlDetalleVenta.Name = "pnlDetalleVenta";
            this.pnlDetalleVenta.Size = new System.Drawing.Size(1050, 593);
            this.pnlDetalleVenta.TabIndex = 2;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(115)))), ((int)(((byte)(149)))));
            this.panel4.Controls.Add(this.btnBorrar);
            this.panel4.Controls.Add(this.btnAgregar);
            this.panel4.Controls.Add(this.panel3);
            this.panel4.Controls.Add(this.tboxCantidad);
            this.panel4.Controls.Add(this.tboxCodigoBarra);
            this.panel4.Controls.Add(this.label3);
            this.panel4.Controls.Add(this.label1);
            this.panel4.Location = new System.Drawing.Point(0, 133);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(1056, 87);
            this.panel4.TabIndex = 18;
            // 
            // btnBorrar
            // 
            this.btnBorrar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(115)))), ((int)(((byte)(149)))));
            this.btnBorrar.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnBorrar.FlatAppearance.BorderSize = 0;
            this.btnBorrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBorrar.Font = new System.Drawing.Font("Bebas", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBorrar.ForeColor = System.Drawing.Color.White;
            this.btnBorrar.Image = ((System.Drawing.Image)(resources.GetObject("btnBorrar.Image")));
            this.btnBorrar.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnBorrar.Location = new System.Drawing.Point(835, 14);
            this.btnBorrar.Name = "btnBorrar";
            this.btnBorrar.Size = new System.Drawing.Size(60, 60);
            this.btnBorrar.TabIndex = 3;
            this.btnBorrar.Text = "borrar";
            this.btnBorrar.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnBorrar.UseVisualStyleBackColor = false;
            this.btnBorrar.Click += new System.EventHandler(this.btnBorrar_Click);
            // 
            // btnAgregar
            // 
            this.btnAgregar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(115)))), ((int)(((byte)(149)))));
            this.btnAgregar.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnAgregar.FlatAppearance.BorderSize = 0;
            this.btnAgregar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAgregar.Font = new System.Drawing.Font("Bebas", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAgregar.ForeColor = System.Drawing.Color.White;
            this.btnAgregar.Image = ((System.Drawing.Image)(resources.GetObject("btnAgregar.Image")));
            this.btnAgregar.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnAgregar.Location = new System.Drawing.Point(769, 14);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(60, 60);
            this.btnAgregar.TabIndex = 2;
            this.btnAgregar.Text = "agregar";
            this.btnAgregar.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnAgregar.UseVisualStyleBackColor = false;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // panel7
            // 
            this.panel7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(115)))), ((int)(((byte)(149)))));
            this.panel7.Controls.Add(this.btnCancelar);
            this.panel7.Controls.Add(this.lblDescuentoNumerico);
            this.panel7.Controls.Add(this.btnAceptar);
            this.panel7.Controls.Add(this.lblSubtotalNumerico);
            this.panel7.Controls.Add(this.label38);
            this.panel7.Controls.Add(this.lblTotalFactura);
            this.panel7.Controls.Add(this.lblDescuento);
            this.panel7.Controls.Add(this.lblSubtotal);
            this.panel7.Location = new System.Drawing.Point(0, 503);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(1050, 90);
            this.panel7.TabIndex = 3;
            // 
            // lblDescuentoNumerico
            // 
            this.lblDescuentoNumerico.AutoSize = true;
            this.lblDescuentoNumerico.Font = new System.Drawing.Font("Bebas", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDescuentoNumerico.ForeColor = System.Drawing.Color.White;
            this.lblDescuentoNumerico.Location = new System.Drawing.Point(193, 46);
            this.lblDescuentoNumerico.Name = "lblDescuentoNumerico";
            this.lblDescuentoNumerico.Size = new System.Drawing.Size(44, 25);
            this.lblDescuentoNumerico.TabIndex = 11;
            this.lblDescuentoNumerico.Text = "0.00";
            // 
            // lblSubtotalNumerico
            // 
            this.lblSubtotalNumerico.AutoSize = true;
            this.lblSubtotalNumerico.Font = new System.Drawing.Font("Bebas", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSubtotalNumerico.ForeColor = System.Drawing.Color.White;
            this.lblSubtotalNumerico.Location = new System.Drawing.Point(193, 18);
            this.lblSubtotalNumerico.Name = "lblSubtotalNumerico";
            this.lblSubtotalNumerico.Size = new System.Drawing.Size(44, 25);
            this.lblSubtotalNumerico.TabIndex = 11;
            this.lblSubtotalNumerico.Text = "0.00";
            // 
            // label38
            // 
            this.label38.AutoSize = true;
            this.label38.Font = new System.Drawing.Font("Bebas", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label38.ForeColor = System.Drawing.Color.White;
            this.label38.Location = new System.Drawing.Point(686, 18);
            this.label38.Name = "label38";
            this.label38.Size = new System.Drawing.Size(46, 19);
            this.label38.TabIndex = 10;
            this.label38.Text = "TOTAL";
            // 
            // lblTotalFactura
            // 
            this.lblTotalFactura.AutoSize = true;
            this.lblTotalFactura.Font = new System.Drawing.Font("Bebas", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalFactura.ForeColor = System.Drawing.Color.White;
            this.lblTotalFactura.Location = new System.Drawing.Point(660, 35);
            this.lblTotalFactura.Name = "lblTotalFactura";
            this.lblTotalFactura.Size = new System.Drawing.Size(91, 42);
            this.lblTotalFactura.TabIndex = 10;
            this.lblTotalFactura.Text = "$0.00";
            // 
            // lblDescuento
            // 
            this.lblDescuento.AutoSize = true;
            this.lblDescuento.Font = new System.Drawing.Font("Oswald", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDescuento.ForeColor = System.Drawing.Color.White;
            this.lblDescuento.Location = new System.Drawing.Point(48, 49);
            this.lblDescuento.Name = "lblDescuento";
            this.lblDescuento.Size = new System.Drawing.Size(84, 21);
            this.lblDescuento.TabIndex = 10;
            this.lblDescuento.Text = "DESCUENTO";
            // 
            // lblSubtotal
            // 
            this.lblSubtotal.AutoSize = true;
            this.lblSubtotal.Font = new System.Drawing.Font("Oswald", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSubtotal.ForeColor = System.Drawing.Color.White;
            this.lblSubtotal.Location = new System.Drawing.Point(48, 18);
            this.lblSubtotal.Name = "lblSubtotal";
            this.lblSubtotal.Size = new System.Drawing.Size(75, 21);
            this.lblSubtotal.TabIndex = 10;
            this.lblSubtotal.Text = "SUBTOTAL";
            // 
            // dgvDetalleVenta
            // 
            this.dgvDetalleVenta.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dgvDetalleVenta.BackgroundColor = System.Drawing.Color.OldLace;
            this.dgvDetalleVenta.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleVertical;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Oswald", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvDetalleVenta.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvDetalleVenta.ColumnHeadersHeight = 35;
            this.dgvDetalleVenta.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Oswald Regular", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvDetalleVenta.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgvDetalleVenta.EnableHeadersVisualStyles = false;
            this.dgvDetalleVenta.GridColor = System.Drawing.Color.OldLace;
            this.dgvDetalleVenta.Location = new System.Drawing.Point(0, 213);
            this.dgvDetalleVenta.Name = "dgvDetalleVenta";
            this.dgvDetalleVenta.ReadOnly = true;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Oswald", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(115)))), ((int)(((byte)(149)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvDetalleVenta.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dgvDetalleVenta.RowHeadersVisible = false;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Oswald Regular", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(115)))), ((int)(((byte)(149)))));
            this.dgvDetalleVenta.RowsDefaultCellStyle = dataGridViewCellStyle4;
            this.dgvDetalleVenta.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvDetalleVenta.Size = new System.Drawing.Size(1053, 292);
            this.dgvDetalleVenta.TabIndex = 16;
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.Gray;
            this.panel5.Location = new System.Drawing.Point(97, 412);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(5, 60);
            this.panel5.TabIndex = 18;
            // 
            // btnBusqueda
            // 
            this.btnBusqueda.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(115)))), ((int)(((byte)(149)))));
            this.btnBusqueda.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnBusqueda.FlatAppearance.BorderSize = 0;
            this.btnBusqueda.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBusqueda.Font = new System.Drawing.Font("Bebas", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBusqueda.ForeColor = System.Drawing.Color.White;
            this.btnBusqueda.Image = ((System.Drawing.Image)(resources.GetObject("btnBusqueda.Image")));
            this.btnBusqueda.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnBusqueda.Location = new System.Drawing.Point(-1, 41);
            this.btnBusqueda.Name = "btnBusqueda";
            this.btnBusqueda.Size = new System.Drawing.Size(100, 60);
            this.btnBusqueda.TabIndex = 4;
            this.btnBusqueda.Text = "productos";
            this.btnBusqueda.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnBusqueda.UseVisualStyleBackColor = false;
            this.btnBusqueda.Click += new System.EventHandler(this.btnBusqueda_Click);
            // 
            // HoraActual
            // 
            this.HoraActual.Tick += new System.EventHandler(this.HoraActual_Tick);
            // 
            // panelMenu
            // 
            this.panelMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(115)))), ((int)(((byte)(149)))));
            this.panelMenu.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panelMenu.Controls.Add(this.panel1);
            this.panelMenu.Controls.Add(this.btnLogOut);
            this.panelMenu.Controls.Add(this.panel9);
            this.panelMenu.Controls.Add(this.panel5);
            this.panelMenu.Controls.Add(this.panel8);
            this.panelMenu.Controls.Add(this.panel10);
            this.panelMenu.Controls.Add(this.panel11);
            this.panelMenu.Controls.Add(this.panel12);
            this.panelMenu.Controls.Add(this.panel13);
            this.panelMenu.Controls.Add(this.panel14);
            this.panelMenu.Controls.Add(this.label4);
            this.panelMenu.Controls.Add(this.lblCompras);
            this.panelMenu.Controls.Add(this.btnBusqueda);
            this.panelMenu.Controls.Add(this.btnAgregarCliente);
            this.panelMenu.Controls.Add(this.btnCierreCaja);
            this.panelMenu.Controls.Add(this.btnRetiroDinero);
            this.panelMenu.Controls.Add(this.btnMetodoPago);
            this.panelMenu.Controls.Add(this.btnDevolucion);
            this.panelMenu.Dock = System.Windows.Forms.DockStyle.Right;
            this.panelMenu.Font = new System.Drawing.Font("Bebas", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panelMenu.Location = new System.Drawing.Point(1054, 0);
            this.panelMenu.Name = "panelMenu";
            this.panelMenu.Size = new System.Drawing.Size(105, 593);
            this.panelMenu.TabIndex = 4;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(220)))), ((int)(((byte)(70)))));
            this.panel1.Location = new System.Drawing.Point(96, 487);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(5, 60);
            this.panel1.TabIndex = 20;
            // 
            // btnLogOut
            // 
            this.btnLogOut.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(115)))), ((int)(((byte)(149)))));
            this.btnLogOut.FlatAppearance.BorderSize = 0;
            this.btnLogOut.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLogOut.Font = new System.Drawing.Font("Bebas", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLogOut.ForeColor = System.Drawing.Color.White;
            this.btnLogOut.Image = ((System.Drawing.Image)(resources.GetObject("btnLogOut.Image")));
            this.btnLogOut.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnLogOut.Location = new System.Drawing.Point(3, 487);
            this.btnLogOut.Name = "btnLogOut";
            this.btnLogOut.Size = new System.Drawing.Size(100, 60);
            this.btnLogOut.TabIndex = 10;
            this.btnLogOut.Text = "LOG OUT";
            this.btnLogOut.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnLogOut.UseVisualStyleBackColor = false;
            this.btnLogOut.Click += new System.EventHandler(this.btnLogOut_Click);
            // 
            // panel9
            // 
            this.panel9.BackColor = System.Drawing.Color.White;
            this.panel9.Location = new System.Drawing.Point(1, 36);
            this.panel9.Name = "panel9";
            this.panel9.Size = new System.Drawing.Size(105, 2);
            this.panel9.TabIndex = 11;
            // 
            // panel8
            // 
            this.panel8.BackColor = System.Drawing.Color.White;
            this.panel8.Location = new System.Drawing.Point(-2, 200);
            this.panel8.Name = "panel8";
            this.panel8.Size = new System.Drawing.Size(105, 2);
            this.panel8.TabIndex = 11;
            // 
            // panel10
            // 
            this.panel10.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(213)))), ((int)(((byte)(178)))));
            this.panel10.Location = new System.Drawing.Point(97, 41);
            this.panel10.Name = "panel10";
            this.panel10.Size = new System.Drawing.Size(4, 60);
            this.panel10.TabIndex = 10;
            // 
            // panel11
            // 
            this.panel11.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(78)))), ((int)(((byte)(118)))), ((int)(((byte)(147)))));
            this.panel11.Location = new System.Drawing.Point(96, 273);
            this.panel11.Name = "panel11";
            this.panel11.Size = new System.Drawing.Size(5, 60);
            this.panel11.TabIndex = 9;
            // 
            // panel12
            // 
            this.panel12.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(169)))), ((int)(((byte)(38)))));
            this.panel12.Location = new System.Drawing.Point(96, 107);
            this.panel12.Name = "panel12";
            this.panel12.Size = new System.Drawing.Size(5, 60);
            this.panel12.TabIndex = 5;
            // 
            // panel13
            // 
            this.panel13.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(195)))), ((int)(((byte)(239)))));
            this.panel13.Location = new System.Drawing.Point(96, 339);
            this.panel13.Name = "panel13";
            this.panel13.Size = new System.Drawing.Size(5, 60);
            this.panel13.TabIndex = 7;
            // 
            // panel14
            // 
            this.panel14.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(211)))), ((int)(((byte)(159)))));
            this.panel14.Location = new System.Drawing.Point(96, 206);
            this.panel14.Name = "panel14";
            this.panel14.Size = new System.Drawing.Size(5, 60);
            this.panel14.TabIndex = 6;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Bebas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(-2, 17);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(64, 19);
            this.label4.TabIndex = 1;
            this.label4.Text = "Busqueda";
            // 
            // lblCompras
            // 
            this.lblCompras.AutoSize = true;
            this.lblCompras.Font = new System.Drawing.Font("Bebas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCompras.ForeColor = System.Drawing.Color.White;
            this.lblCompras.Location = new System.Drawing.Point(-3, 178);
            this.lblCompras.Name = "lblCompras";
            this.lblCompras.Size = new System.Drawing.Size(35, 19);
            this.lblCompras.TabIndex = 1;
            this.lblCompras.Text = "CAJA";
            // 
            // btnResetear
            // 
            this.btnResetear.FlatAppearance.BorderSize = 0;
            this.btnResetear.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnResetear.Image = ((System.Drawing.Image)(resources.GetObject("btnResetear.Image")));
            this.btnResetear.Location = new System.Drawing.Point(528, 95);
            this.btnResetear.Name = "btnResetear";
            this.btnResetear.Size = new System.Drawing.Size(25, 24);
            this.btnResetear.TabIndex = 19;
            this.btnResetear.UseVisualStyleBackColor = true;
            this.btnResetear.Click += new System.EventHandler(this.btnResetear_Click);
            // 
            // FormularioVenta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.ClientSize = new System.Drawing.Size(1159, 593);
            this.Controls.Add(this.panelMenu);
            this.Controls.Add(this.pnlDetalleVenta);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormularioVenta";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "Detalle:";
            this.Load += new System.EventHandler(this.FormularioVenta_Load);
            this.pnlCabecera.ResumeLayout(false);
            this.pnlCabecera.PerformLayout();
            this.pnlDetalleVenta.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.panel7.ResumeLayout(false);
            this.panel7.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDetalleVenta)).EndInit();
            this.panelMenu.ResumeLayout(false);
            this.panelMenu.PerformLayout();
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
        private System.Windows.Forms.Label lblFechaEmision;
        private System.Windows.Forms.Button btnCierreCaja;
        private System.Windows.Forms.Button btnRetiroDinero;
        private System.Windows.Forms.DataGridView dgvDetalleVenta;
        private System.Windows.Forms.Timer HoraActual;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Panel panelMenu;
        private System.Windows.Forms.Panel panel9;
        private System.Windows.Forms.Panel panel8;
        private System.Windows.Forms.Panel panel10;
        private System.Windows.Forms.Panel panel11;
        private System.Windows.Forms.Panel panel12;
        private System.Windows.Forms.Panel panel13;
        private System.Windows.Forms.Panel panel14;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lblCompras;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnLogOut;
        private System.Windows.Forms.TextBox tboxNumeroOperacion;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TextBox tboxSaldo;
        private System.Windows.Forms.TextBox tboxClientes;
        private System.Windows.Forms.TextBox tboxMetodoPago;
        private System.Windows.Forms.TextBox tboxUsuario;
        private System.Windows.Forms.TextBox tboxHora;
        private System.Windows.Forms.TextBox tboxFechaEmision;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.TextBox tboxCantidad;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.Button btnBorrar;
        private System.Windows.Forms.Label lblMotivoDevolucion;
        private System.Windows.Forms.ComboBox cboxMotivoDevolucion;
        private System.Windows.Forms.Button btnResetear;
    }
}

