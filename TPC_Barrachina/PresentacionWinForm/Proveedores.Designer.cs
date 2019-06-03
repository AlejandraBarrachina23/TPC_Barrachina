namespace PresentacionWinForm
{
    partial class Proveedores
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Proveedores));
            this.gboxContacto = new System.Windows.Forms.GroupBox();
            this.tboxCelular = new System.Windows.Forms.TextBox();
            this.tboxCorreoElectronico = new System.Windows.Forms.TextBox();
            this.tboxTelefono = new System.Windows.Forms.TextBox();
            this.lblCorreoElectronico = new System.Windows.Forms.Label();
            this.lblCelular = new System.Windows.Forms.Label();
            this.lblTelefono = new System.Windows.Forms.Label();
            this.gboxDireccion = new System.Windows.Forms.GroupBox();
            this.tboxCP = new System.Windows.Forms.TextBox();
            this.tboxNumero = new System.Windows.Forms.TextBox();
            this.tboxLocalidad = new System.Windows.Forms.TextBox();
            this.tboxProvincia = new System.Windows.Forms.TextBox();
            this.tboxCalle = new System.Windows.Forms.TextBox();
            this.lblLocalidad = new System.Windows.Forms.Label();
            this.lblProvincia = new System.Windows.Forms.Label();
            this.lblCP = new System.Windows.Forms.Label();
            this.lblNumero = new System.Windows.Forms.Label();
            this.lblCalle = new System.Windows.Forms.Label();
            this.tboxPorcentaje = new System.Windows.Forms.TextBox();
            this.lblPorcentaje = new System.Windows.Forms.Label();
            this.lblNombreFantasia = new System.Windows.Forms.Label();
            this.lbNumeroCUIT = new System.Windows.Forms.Label();
            this.lblRazonSocial = new System.Windows.Forms.Label();
            this.tboxNumeroCUIT = new System.Windows.Forms.TextBox();
            this.tboxRazonSocial = new System.Windows.Forms.TextBox();
            this.pnlBarraPrincipal = new System.Windows.Forms.Panel();
            this.lblNombreFormulario = new System.Windows.Forms.Label();
            this.tboxNombreFantasia = new System.Windows.Forms.TextBox();
            this.lblImpuestos = new System.Windows.Forms.Label();
            this.cboxCondicionIVA = new System.Windows.Forms.ComboBox();
            this.gboxImpuesto = new System.Windows.Forms.GroupBox();
            this.cboxImpuesto = new System.Windows.Forms.ComboBox();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.dgvImpuestos = new System.Windows.Forms.DataGridView();
            this.lblCodigoProveedor = new System.Windows.Forms.Label();
            this.tboxCodigoProveedor = new System.Windows.Forms.TextBox();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnAceptar = new System.Windows.Forms.Button();
            this.lblCondicionIVA = new System.Windows.Forms.Label();
            this.gboxContacto.SuspendLayout();
            this.gboxDireccion.SuspendLayout();
            this.pnlBarraPrincipal.SuspendLayout();
            this.gboxImpuesto.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvImpuestos)).BeginInit();
            this.SuspendLayout();
            // 
            // gboxContacto
            // 
            this.gboxContacto.Controls.Add(this.tboxCelular);
            this.gboxContacto.Controls.Add(this.tboxCorreoElectronico);
            this.gboxContacto.Controls.Add(this.tboxTelefono);
            this.gboxContacto.Controls.Add(this.lblCorreoElectronico);
            this.gboxContacto.Controls.Add(this.lblCelular);
            this.gboxContacto.Controls.Add(this.lblTelefono);
            this.gboxContacto.Font = new System.Drawing.Font("Oswald Regular", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gboxContacto.Location = new System.Drawing.Point(25, 309);
            this.gboxContacto.Name = "gboxContacto";
            this.gboxContacto.Size = new System.Drawing.Size(445, 110);
            this.gboxContacto.TabIndex = 11;
            this.gboxContacto.TabStop = false;
            this.gboxContacto.Text = "Contacto";
            // 
            // tboxCelular
            // 
            this.tboxCelular.Location = new System.Drawing.Point(256, 37);
            this.tboxCelular.Name = "tboxCelular";
            this.tboxCelular.Size = new System.Drawing.Size(149, 25);
            this.tboxCelular.TabIndex = 12;
            // 
            // tboxCorreoElectronico
            // 
            this.tboxCorreoElectronico.Location = new System.Drawing.Point(115, 74);
            this.tboxCorreoElectronico.Name = "tboxCorreoElectronico";
            this.tboxCorreoElectronico.Size = new System.Drawing.Size(290, 25);
            this.tboxCorreoElectronico.TabIndex = 13;
            // 
            // tboxTelefono
            // 
            this.tboxTelefono.Location = new System.Drawing.Point(66, 37);
            this.tboxTelefono.Name = "tboxTelefono";
            this.tboxTelefono.Size = new System.Drawing.Size(129, 25);
            this.tboxTelefono.TabIndex = 11;
            // 
            // lblCorreoElectronico
            // 
            this.lblCorreoElectronico.AutoSize = true;
            this.lblCorreoElectronico.Location = new System.Drawing.Point(14, 77);
            this.lblCorreoElectronico.Name = "lblCorreoElectronico";
            this.lblCorreoElectronico.Size = new System.Drawing.Size(95, 17);
            this.lblCorreoElectronico.TabIndex = 19;
            this.lblCorreoElectronico.Text = "Correo Electrónico";
            // 
            // lblCelular
            // 
            this.lblCelular.AutoSize = true;
            this.lblCelular.Location = new System.Drawing.Point(206, 40);
            this.lblCelular.Name = "lblCelular";
            this.lblCelular.Size = new System.Drawing.Size(42, 17);
            this.lblCelular.TabIndex = 19;
            this.lblCelular.Text = "Celular";
            // 
            // lblTelefono
            // 
            this.lblTelefono.AutoSize = true;
            this.lblTelefono.Location = new System.Drawing.Point(11, 40);
            this.lblTelefono.Name = "lblTelefono";
            this.lblTelefono.Size = new System.Drawing.Size(48, 17);
            this.lblTelefono.TabIndex = 19;
            this.lblTelefono.Text = "Teléfono";
            // 
            // gboxDireccion
            // 
            this.gboxDireccion.Controls.Add(this.tboxCP);
            this.gboxDireccion.Controls.Add(this.tboxNumero);
            this.gboxDireccion.Controls.Add(this.tboxLocalidad);
            this.gboxDireccion.Controls.Add(this.tboxProvincia);
            this.gboxDireccion.Controls.Add(this.tboxCalle);
            this.gboxDireccion.Controls.Add(this.lblLocalidad);
            this.gboxDireccion.Controls.Add(this.lblProvincia);
            this.gboxDireccion.Controls.Add(this.lblCP);
            this.gboxDireccion.Controls.Add(this.lblNumero);
            this.gboxDireccion.Controls.Add(this.lblCalle);
            this.gboxDireccion.Font = new System.Drawing.Font("Oswald Regular", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gboxDireccion.Location = new System.Drawing.Point(25, 198);
            this.gboxDireccion.Name = "gboxDireccion";
            this.gboxDireccion.Size = new System.Drawing.Size(445, 105);
            this.gboxDireccion.TabIndex = 6;
            this.gboxDireccion.TabStop = false;
            this.gboxDireccion.Text = "Dirección";
            // 
            // tboxCP
            // 
            this.tboxCP.Location = new System.Drawing.Point(372, 23);
            this.tboxCP.Name = "tboxCP";
            this.tboxCP.Size = new System.Drawing.Size(43, 25);
            this.tboxCP.TabIndex = 7;
            // 
            // tboxNumero
            // 
            this.tboxNumero.Location = new System.Drawing.Point(279, 23);
            this.tboxNumero.Name = "tboxNumero";
            this.tboxNumero.Size = new System.Drawing.Size(43, 25);
            this.tboxNumero.TabIndex = 7;
            // 
            // tboxLocalidad
            // 
            this.tboxLocalidad.Location = new System.Drawing.Point(262, 60);
            this.tboxLocalidad.Name = "tboxLocalidad";
            this.tboxLocalidad.Size = new System.Drawing.Size(143, 25);
            this.tboxLocalidad.TabIndex = 10;
            // 
            // tboxProvincia
            // 
            this.tboxProvincia.Location = new System.Drawing.Point(68, 60);
            this.tboxProvincia.Name = "tboxProvincia";
            this.tboxProvincia.Size = new System.Drawing.Size(124, 25);
            this.tboxProvincia.TabIndex = 9;
            // 
            // tboxCalle
            // 
            this.tboxCalle.Location = new System.Drawing.Point(47, 23);
            this.tboxCalle.Name = "tboxCalle";
            this.tboxCalle.Size = new System.Drawing.Size(173, 25);
            this.tboxCalle.TabIndex = 6;
            // 
            // lblLocalidad
            // 
            this.lblLocalidad.AutoSize = true;
            this.lblLocalidad.Location = new System.Drawing.Point(206, 63);
            this.lblLocalidad.Name = "lblLocalidad";
            this.lblLocalidad.Size = new System.Drawing.Size(54, 17);
            this.lblLocalidad.TabIndex = 19;
            this.lblLocalidad.Text = "Localidad";
            // 
            // lblProvincia
            // 
            this.lblProvincia.AutoSize = true;
            this.lblProvincia.Location = new System.Drawing.Point(11, 63);
            this.lblProvincia.Name = "lblProvincia";
            this.lblProvincia.Size = new System.Drawing.Size(52, 17);
            this.lblProvincia.TabIndex = 19;
            this.lblProvincia.Text = "Provincia";
            // 
            // lblCP
            // 
            this.lblCP.AutoSize = true;
            this.lblCP.Location = new System.Drawing.Point(345, 27);
            this.lblCP.Name = "lblCP";
            this.lblCP.Size = new System.Drawing.Size(21, 17);
            this.lblCP.TabIndex = 19;
            this.lblCP.Text = "CP";
            // 
            // lblNumero
            // 
            this.lblNumero.AutoSize = true;
            this.lblNumero.Location = new System.Drawing.Point(231, 27);
            this.lblNumero.Name = "lblNumero";
            this.lblNumero.Size = new System.Drawing.Size(45, 17);
            this.lblNumero.TabIndex = 19;
            this.lblNumero.Text = "Número";
            // 
            // lblCalle
            // 
            this.lblCalle.AutoSize = true;
            this.lblCalle.Location = new System.Drawing.Point(11, 27);
            this.lblCalle.Name = "lblCalle";
            this.lblCalle.Size = new System.Drawing.Size(32, 17);
            this.lblCalle.TabIndex = 19;
            this.lblCalle.Text = "Calle";
            // 
            // tboxPorcentaje
            // 
            this.tboxPorcentaje.Location = new System.Drawing.Point(328, 24);
            this.tboxPorcentaje.Name = "tboxPorcentaje";
            this.tboxPorcentaje.Size = new System.Drawing.Size(50, 25);
            this.tboxPorcentaje.TabIndex = 8;
            // 
            // lblPorcentaje
            // 
            this.lblPorcentaje.AutoSize = true;
            this.lblPorcentaje.Location = new System.Drawing.Point(267, 28);
            this.lblPorcentaje.Name = "lblPorcentaje";
            this.lblPorcentaje.Size = new System.Drawing.Size(58, 17);
            this.lblPorcentaje.TabIndex = 19;
            this.lblPorcentaje.Text = "Porcentaje";
            // 
            // lblNombreFantasia
            // 
            this.lblNombreFantasia.AutoSize = true;
            this.lblNombreFantasia.Font = new System.Drawing.Font("Oswald Regular", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNombreFantasia.Location = new System.Drawing.Point(104, 146);
            this.lblNombreFantasia.Name = "lblNombreFantasia";
            this.lblNombreFantasia.Size = new System.Drawing.Size(89, 17);
            this.lblNombreFantasia.TabIndex = 29;
            this.lblNombreFantasia.Text = "Nombre Fantasía";
            // 
            // lbNumeroCUIT
            // 
            this.lbNumeroCUIT.AutoSize = true;
            this.lbNumeroCUIT.Font = new System.Drawing.Font("Oswald Regular", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbNumeroCUIT.Location = new System.Drawing.Point(104, 119);
            this.lbNumeroCUIT.Name = "lbNumeroCUIT";
            this.lbNumeroCUIT.Size = new System.Drawing.Size(70, 17);
            this.lbNumeroCUIT.TabIndex = 30;
            this.lbNumeroCUIT.Text = "Numero CUIT";
            // 
            // lblRazonSocial
            // 
            this.lblRazonSocial.AutoSize = true;
            this.lblRazonSocial.Font = new System.Drawing.Font("Oswald Regular", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRazonSocial.Location = new System.Drawing.Point(104, 90);
            this.lblRazonSocial.Name = "lblRazonSocial";
            this.lblRazonSocial.Size = new System.Drawing.Size(70, 17);
            this.lblRazonSocial.TabIndex = 31;
            this.lblRazonSocial.Text = "Razón Social";
            // 
            // tboxNumeroCUIT
            // 
            this.tboxNumeroCUIT.Font = new System.Drawing.Font("Oswald Regular", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tboxNumeroCUIT.Location = new System.Drawing.Point(202, 115);
            this.tboxNumeroCUIT.Name = "tboxNumeroCUIT";
            this.tboxNumeroCUIT.Size = new System.Drawing.Size(173, 25);
            this.tboxNumeroCUIT.TabIndex = 3;
            // 
            // tboxRazonSocial
            // 
            this.tboxRazonSocial.Font = new System.Drawing.Font("Oswald Regular", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tboxRazonSocial.Location = new System.Drawing.Point(202, 87);
            this.tboxRazonSocial.Name = "tboxRazonSocial";
            this.tboxRazonSocial.Size = new System.Drawing.Size(173, 25);
            this.tboxRazonSocial.TabIndex = 2;
            // 
            // pnlBarraPrincipal
            // 
            this.pnlBarraPrincipal.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(115)))), ((int)(((byte)(149)))));
            this.pnlBarraPrincipal.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlBarraPrincipal.Controls.Add(this.lblNombreFormulario);
            this.pnlBarraPrincipal.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlBarraPrincipal.Location = new System.Drawing.Point(0, 0);
            this.pnlBarraPrincipal.Name = "pnlBarraPrincipal";
            this.pnlBarraPrincipal.Size = new System.Drawing.Size(482, 41);
            this.pnlBarraPrincipal.TabIndex = 25;
            // 
            // lblNombreFormulario
            // 
            this.lblNombreFormulario.AutoSize = true;
            this.lblNombreFormulario.Font = new System.Drawing.Font("Bebas", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNombreFormulario.ForeColor = System.Drawing.Color.White;
            this.lblNombreFormulario.Location = new System.Drawing.Point(220, 8);
            this.lblNombreFormulario.Name = "lblNombreFormulario";
            this.lblNombreFormulario.Size = new System.Drawing.Size(80, 23);
            this.lblNombreFormulario.TabIndex = 9;
            this.lblNombreFormulario.Text = "PROVEEDOR";
            // 
            // tboxNombreFantasia
            // 
            this.tboxNombreFantasia.Font = new System.Drawing.Font("Oswald Regular", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tboxNombreFantasia.Location = new System.Drawing.Point(202, 143);
            this.tboxNombreFantasia.Name = "tboxNombreFantasia";
            this.tboxNombreFantasia.Size = new System.Drawing.Size(173, 25);
            this.tboxNombreFantasia.TabIndex = 4;
            // 
            // lblImpuestos
            // 
            this.lblImpuestos.AutoSize = true;
            this.lblImpuestos.Font = new System.Drawing.Font("Oswald Regular", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblImpuestos.Location = new System.Drawing.Point(25, 27);
            this.lblImpuestos.Name = "lblImpuestos";
            this.lblImpuestos.Size = new System.Drawing.Size(57, 17);
            this.lblImpuestos.TabIndex = 29;
            this.lblImpuestos.Text = "Impuestos";
            // 
            // cboxCondicionIVA
            // 
            this.cboxCondicionIVA.Font = new System.Drawing.Font("Oswald Regular", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboxCondicionIVA.FormattingEnabled = true;
            this.cboxCondicionIVA.Location = new System.Drawing.Point(202, 171);
            this.cboxCondicionIVA.Name = "cboxCondicionIVA";
            this.cboxCondicionIVA.Size = new System.Drawing.Size(173, 25);
            this.cboxCondicionIVA.TabIndex = 5;
            // 
            // gboxImpuesto
            // 
            this.gboxImpuesto.Controls.Add(this.cboxImpuesto);
            this.gboxImpuesto.Controls.Add(this.btnAgregar);
            this.gboxImpuesto.Controls.Add(this.tboxPorcentaje);
            this.gboxImpuesto.Controls.Add(this.dgvImpuestos);
            this.gboxImpuesto.Controls.Add(this.lblImpuestos);
            this.gboxImpuesto.Controls.Add(this.lblPorcentaje);
            this.gboxImpuesto.Font = new System.Drawing.Font("Oswald Regular", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gboxImpuesto.Location = new System.Drawing.Point(25, 425);
            this.gboxImpuesto.Name = "gboxImpuesto";
            this.gboxImpuesto.Size = new System.Drawing.Size(445, 174);
            this.gboxImpuesto.TabIndex = 14;
            this.gboxImpuesto.TabStop = false;
            this.gboxImpuesto.Text = "Impuesto";
            // 
            // cboxImpuesto
            // 
            this.cboxImpuesto.Font = new System.Drawing.Font("Oswald Regular", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboxImpuesto.FormattingEnabled = true;
            this.cboxImpuesto.Location = new System.Drawing.Point(85, 23);
            this.cboxImpuesto.Name = "cboxImpuesto";
            this.cboxImpuesto.Size = new System.Drawing.Size(173, 25);
            this.cboxImpuesto.TabIndex = 31;
            // 
            // btnAgregar
            // 
            this.btnAgregar.Image = ((System.Drawing.Image)(resources.GetObject("btnAgregar.Image")));
            this.btnAgregar.Location = new System.Drawing.Point(385, 23);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(30, 27);
            this.btnAgregar.TabIndex = 30;
            this.btnAgregar.UseVisualStyleBackColor = true;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // dgvImpuestos
            // 
            this.dgvImpuestos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvImpuestos.Location = new System.Drawing.Point(10, 66);
            this.dgvImpuestos.Name = "dgvImpuestos";
            this.dgvImpuestos.ReadOnly = true;
            this.dgvImpuestos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvImpuestos.Size = new System.Drawing.Size(423, 96);
            this.dgvImpuestos.TabIndex = 0;
            this.dgvImpuestos.SelectionChanged += new System.EventHandler(this.dgvImpuestos_SelectionChanged);
            // 
            // lblCodigoProveedor
            // 
            this.lblCodigoProveedor.AutoSize = true;
            this.lblCodigoProveedor.Font = new System.Drawing.Font("Oswald Regular", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCodigoProveedor.Location = new System.Drawing.Point(104, 62);
            this.lblCodigoProveedor.Name = "lblCodigoProveedor";
            this.lblCodigoProveedor.Size = new System.Drawing.Size(92, 17);
            this.lblCodigoProveedor.TabIndex = 38;
            this.lblCodigoProveedor.Text = "Código Proveedor";
            // 
            // tboxCodigoProveedor
            // 
            this.tboxCodigoProveedor.Font = new System.Drawing.Font("Oswald Regular", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tboxCodigoProveedor.Location = new System.Drawing.Point(202, 59);
            this.tboxCodigoProveedor.Name = "tboxCodigoProveedor";
            this.tboxCodigoProveedor.Size = new System.Drawing.Size(173, 25);
            this.tboxCodigoProveedor.TabIndex = 1;
            // 
            // btnCancelar
            // 
            this.btnCancelar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(115)))), ((int)(((byte)(149)))));
            this.btnCancelar.FlatAppearance.BorderSize = 0;
            this.btnCancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancelar.Font = new System.Drawing.Font("Bebas", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancelar.ForeColor = System.Drawing.Color.White;
            this.btnCancelar.Image = ((System.Drawing.Image)(resources.GetObject("btnCancelar.Image")));
            this.btnCancelar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCancelar.Location = new System.Drawing.Point(253, 605);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(94, 37);
            this.btnCancelar.TabIndex = 19;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
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
            this.btnAceptar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAceptar.Location = new System.Drawing.Point(151, 605);
            this.btnAceptar.Name = "btnAceptar";
            this.btnAceptar.Size = new System.Drawing.Size(94, 37);
            this.btnAceptar.TabIndex = 18;
            this.btnAceptar.Text = "Aceptar";
            this.btnAceptar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnAceptar.UseVisualStyleBackColor = false;
            this.btnAceptar.Click += new System.EventHandler(this.btnAceptar_Click);
            // 
            // lblCondicionIVA
            // 
            this.lblCondicionIVA.AutoSize = true;
            this.lblCondicionIVA.Font = new System.Drawing.Font("Oswald Regular", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCondicionIVA.Location = new System.Drawing.Point(104, 174);
            this.lblCondicionIVA.Name = "lblCondicionIVA";
            this.lblCondicionIVA.Size = new System.Drawing.Size(75, 17);
            this.lblCondicionIVA.TabIndex = 29;
            this.lblCondicionIVA.Text = "Condición IVA";
            // 
            // Proveedores
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(482, 655);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnAceptar);
            this.Controls.Add(this.lblCodigoProveedor);
            this.Controls.Add(this.tboxCodigoProveedor);
            this.Controls.Add(this.cboxCondicionIVA);
            this.Controls.Add(this.gboxImpuesto);
            this.Controls.Add(this.gboxContacto);
            this.Controls.Add(this.gboxDireccion);
            this.Controls.Add(this.lblCondicionIVA);
            this.Controls.Add(this.lblNombreFantasia);
            this.Controls.Add(this.lbNumeroCUIT);
            this.Controls.Add(this.lblRazonSocial);
            this.Controls.Add(this.tboxNombreFantasia);
            this.Controls.Add(this.tboxNumeroCUIT);
            this.Controls.Add(this.tboxRazonSocial);
            this.Controls.Add(this.pnlBarraPrincipal);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Proveedores";
            this.Text = "NuevoProveedor";
            this.Load += new System.EventHandler(this.Proveedores_Load);
            this.gboxContacto.ResumeLayout(false);
            this.gboxContacto.PerformLayout();
            this.gboxDireccion.ResumeLayout(false);
            this.gboxDireccion.PerformLayout();
            this.pnlBarraPrincipal.ResumeLayout(false);
            this.pnlBarraPrincipal.PerformLayout();
            this.gboxImpuesto.ResumeLayout(false);
            this.gboxImpuesto.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvImpuestos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox gboxContacto;
        private System.Windows.Forms.TextBox tboxCelular;
        private System.Windows.Forms.TextBox tboxCorreoElectronico;
        private System.Windows.Forms.TextBox tboxTelefono;
        private System.Windows.Forms.Label lblCorreoElectronico;
        private System.Windows.Forms.Label lblCelular;
        private System.Windows.Forms.Label lblTelefono;
        private System.Windows.Forms.GroupBox gboxDireccion;
        private System.Windows.Forms.TextBox tboxPorcentaje;
        private System.Windows.Forms.TextBox tboxNumero;
        private System.Windows.Forms.TextBox tboxLocalidad;
        private System.Windows.Forms.TextBox tboxProvincia;
        private System.Windows.Forms.TextBox tboxCalle;
        private System.Windows.Forms.Label lblPorcentaje;
        private System.Windows.Forms.Label lblLocalidad;
        private System.Windows.Forms.Label lblProvincia;
        private System.Windows.Forms.Label lblNumero;
        private System.Windows.Forms.Label lblCalle;
        private System.Windows.Forms.Label lblNombreFantasia;
        private System.Windows.Forms.Label lbNumeroCUIT;
        private System.Windows.Forms.Label lblRazonSocial;
        private System.Windows.Forms.TextBox tboxNumeroCUIT;
        private System.Windows.Forms.TextBox tboxRazonSocial;
        private System.Windows.Forms.Panel pnlBarraPrincipal;
        private System.Windows.Forms.TextBox tboxNombreFantasia;
        private System.Windows.Forms.Label lblImpuestos;
        private System.Windows.Forms.ComboBox cboxCondicionIVA;
        private System.Windows.Forms.GroupBox gboxImpuesto;
        private System.Windows.Forms.Label lblCodigoProveedor;
        private System.Windows.Forms.TextBox tboxCodigoProveedor;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button btnAceptar;
        private System.Windows.Forms.Label lblNombreFormulario;
        private System.Windows.Forms.DataGridView dgvImpuestos;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.ComboBox cboxImpuesto;
        private System.Windows.Forms.Label lblCondicionIVA;
        private System.Windows.Forms.TextBox tboxCP;
        private System.Windows.Forms.Label lblCP;
    }
}