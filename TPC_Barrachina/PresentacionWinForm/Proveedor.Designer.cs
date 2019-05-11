namespace PresentacionWinForm
{
    partial class Proveedor
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Proveedor));
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
            this.lblCP = new System.Windows.Forms.Label();
            this.lblLocalidad = new System.Windows.Forms.Label();
            this.lblProvincia = new System.Windows.Forms.Label();
            this.lblNumero = new System.Windows.Forms.Label();
            this.lblCalle = new System.Windows.Forms.Label();
            this.lblNombreFantasia = new System.Windows.Forms.Label();
            this.lbNumeroCUIT = new System.Windows.Forms.Label();
            this.lblRazonSocial = new System.Windows.Forms.Label();
            this.tboxNumeroCUIT = new System.Windows.Forms.TextBox();
            this.tboxRazonSocial = new System.Windows.Forms.TextBox();
            this.pnlBarraPrincipal = new System.Windows.Forms.Panel();
            this.tboxNombreFantasia = new System.Windows.Forms.TextBox();
            this.lblCondicionIVA = new System.Windows.Forms.Label();
            this.cboxCondicionIVA = new System.Windows.Forms.ComboBox();
            this.gboxImpuesto = new System.Windows.Forms.GroupBox();
            this.lblImpuesto2 = new System.Windows.Forms.Label();
            this.lblImpuesto1 = new System.Windows.Forms.Label();
            this.lblIB = new System.Windows.Forms.Label();
            this.tboxImpuesto2 = new System.Windows.Forms.TextBox();
            this.tboxImpuesto1 = new System.Windows.Forms.TextBox();
            this.tboxIB = new System.Windows.Forms.TextBox();
            this.lblIVA = new System.Windows.Forms.Label();
            this.tboxIVA = new System.Windows.Forms.TextBox();
            this.lblCodigoProveedor = new System.Windows.Forms.Label();
            this.tboxCodigoProveedor = new System.Windows.Forms.TextBox();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnAceptar = new System.Windows.Forms.Button();
            this.lblNombreFormulario = new System.Windows.Forms.Label();
            this.gboxContacto.SuspendLayout();
            this.gboxDireccion.SuspendLayout();
            this.pnlBarraPrincipal.SuspendLayout();
            this.gboxImpuesto.SuspendLayout();
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
            this.gboxContacto.Location = new System.Drawing.Point(18, 302);
            this.gboxContacto.Name = "gboxContacto";
            this.gboxContacto.Size = new System.Drawing.Size(425, 110);
            this.gboxContacto.TabIndex = 36;
            this.gboxContacto.TabStop = false;
            this.gboxContacto.Text = "Contacto";
            // 
            // tboxCelular
            // 
            this.tboxCelular.Location = new System.Drawing.Point(256, 37);
            this.tboxCelular.Name = "tboxCelular";
            this.tboxCelular.Size = new System.Drawing.Size(149, 25);
            this.tboxCelular.TabIndex = 13;
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
            this.tboxTelefono.TabIndex = 13;
            // 
            // lblCorreoElectronico
            // 
            this.lblCorreoElectronico.AutoSize = true;
            this.lblCorreoElectronico.Location = new System.Drawing.Point(15, 77);
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
            this.gboxDireccion.Controls.Add(this.lblCP);
            this.gboxDireccion.Controls.Add(this.lblLocalidad);
            this.gboxDireccion.Controls.Add(this.lblProvincia);
            this.gboxDireccion.Controls.Add(this.lblNumero);
            this.gboxDireccion.Controls.Add(this.lblCalle);
            this.gboxDireccion.Font = new System.Drawing.Font("Oswald Regular", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gboxDireccion.Location = new System.Drawing.Point(18, 191);
            this.gboxDireccion.Name = "gboxDireccion";
            this.gboxDireccion.Size = new System.Drawing.Size(425, 105);
            this.gboxDireccion.TabIndex = 33;
            this.gboxDireccion.TabStop = false;
            this.gboxDireccion.Text = "Dirección";
            // 
            // tboxCP
            // 
            this.tboxCP.Location = new System.Drawing.Point(362, 23);
            this.tboxCP.Name = "tboxCP";
            this.tboxCP.Size = new System.Drawing.Size(43, 25);
            this.tboxCP.TabIndex = 13;
            // 
            // tboxNumero
            // 
            this.tboxNumero.Location = new System.Drawing.Point(279, 23);
            this.tboxNumero.Name = "tboxNumero";
            this.tboxNumero.Size = new System.Drawing.Size(43, 25);
            this.tboxNumero.TabIndex = 13;
            // 
            // tboxLocalidad
            // 
            this.tboxLocalidad.Location = new System.Drawing.Point(262, 60);
            this.tboxLocalidad.Name = "tboxLocalidad";
            this.tboxLocalidad.Size = new System.Drawing.Size(143, 25);
            this.tboxLocalidad.TabIndex = 13;
            // 
            // tboxProvincia
            // 
            this.tboxProvincia.Location = new System.Drawing.Point(68, 60);
            this.tboxProvincia.Name = "tboxProvincia";
            this.tboxProvincia.Size = new System.Drawing.Size(124, 25);
            this.tboxProvincia.TabIndex = 13;
            // 
            // tboxCalle
            // 
            this.tboxCalle.Location = new System.Drawing.Point(47, 23);
            this.tboxCalle.Name = "tboxCalle";
            this.tboxCalle.Size = new System.Drawing.Size(173, 25);
            this.tboxCalle.TabIndex = 13;
            // 
            // lblCP
            // 
            this.lblCP.AutoSize = true;
            this.lblCP.Location = new System.Drawing.Point(338, 26);
            this.lblCP.Name = "lblCP";
            this.lblCP.Size = new System.Drawing.Size(21, 17);
            this.lblCP.TabIndex = 19;
            this.lblCP.Text = "CP";
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
            // lblNombreFantasia
            // 
            this.lblNombreFantasia.AutoSize = true;
            this.lblNombreFantasia.Font = new System.Drawing.Font("Oswald Regular", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNombreFantasia.Location = new System.Drawing.Point(90, 141);
            this.lblNombreFantasia.Name = "lblNombreFantasia";
            this.lblNombreFantasia.Size = new System.Drawing.Size(89, 17);
            this.lblNombreFantasia.TabIndex = 29;
            this.lblNombreFantasia.Text = "Nombre Fantasía";
            // 
            // lbNumeroCUIT
            // 
            this.lbNumeroCUIT.AutoSize = true;
            this.lbNumeroCUIT.Font = new System.Drawing.Font("Oswald Regular", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbNumeroCUIT.Location = new System.Drawing.Point(90, 114);
            this.lbNumeroCUIT.Name = "lbNumeroCUIT";
            this.lbNumeroCUIT.Size = new System.Drawing.Size(70, 17);
            this.lbNumeroCUIT.TabIndex = 30;
            this.lbNumeroCUIT.Text = "Numero CUIT";
            // 
            // lblRazonSocial
            // 
            this.lblRazonSocial.AutoSize = true;
            this.lblRazonSocial.Font = new System.Drawing.Font("Oswald Regular", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRazonSocial.Location = new System.Drawing.Point(90, 85);
            this.lblRazonSocial.Name = "lblRazonSocial";
            this.lblRazonSocial.Size = new System.Drawing.Size(70, 17);
            this.lblRazonSocial.TabIndex = 31;
            this.lblRazonSocial.Text = "Razón Social";
            // 
            // tboxNumeroCUIT
            // 
            this.tboxNumeroCUIT.Font = new System.Drawing.Font("Oswald Regular", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tboxNumeroCUIT.Location = new System.Drawing.Point(188, 110);
            this.tboxNumeroCUIT.Name = "tboxNumeroCUIT";
            this.tboxNumeroCUIT.Size = new System.Drawing.Size(173, 25);
            this.tboxNumeroCUIT.TabIndex = 26;
            // 
            // tboxRazonSocial
            // 
            this.tboxRazonSocial.Font = new System.Drawing.Font("Oswald Regular", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tboxRazonSocial.Location = new System.Drawing.Point(188, 82);
            this.tboxRazonSocial.Name = "tboxRazonSocial";
            this.tboxRazonSocial.Size = new System.Drawing.Size(173, 25);
            this.tboxRazonSocial.TabIndex = 27;
            // 
            // pnlBarraPrincipal
            // 
            this.pnlBarraPrincipal.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(115)))), ((int)(((byte)(149)))));
            this.pnlBarraPrincipal.Controls.Add(this.lblNombreFormulario);
            this.pnlBarraPrincipal.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlBarraPrincipal.Location = new System.Drawing.Point(0, 0);
            this.pnlBarraPrincipal.Name = "pnlBarraPrincipal";
            this.pnlBarraPrincipal.Size = new System.Drawing.Size(455, 41);
            this.pnlBarraPrincipal.TabIndex = 25;
            // 
            // tboxNombreFantasia
            // 
            this.tboxNombreFantasia.Font = new System.Drawing.Font("Oswald Regular", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tboxNombreFantasia.Location = new System.Drawing.Point(188, 138);
            this.tboxNombreFantasia.Name = "tboxNombreFantasia";
            this.tboxNombreFantasia.Size = new System.Drawing.Size(173, 25);
            this.tboxNombreFantasia.TabIndex = 26;
            // 
            // lblCondicionIVA
            // 
            this.lblCondicionIVA.AutoSize = true;
            this.lblCondicionIVA.Font = new System.Drawing.Font("Oswald Regular", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCondicionIVA.Location = new System.Drawing.Point(90, 169);
            this.lblCondicionIVA.Name = "lblCondicionIVA";
            this.lblCondicionIVA.Size = new System.Drawing.Size(75, 17);
            this.lblCondicionIVA.TabIndex = 29;
            this.lblCondicionIVA.Text = "Condición IVA";
            // 
            // cboxCondicionIVA
            // 
            this.cboxCondicionIVA.Font = new System.Drawing.Font("Oswald Regular", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboxCondicionIVA.FormattingEnabled = true;
            this.cboxCondicionIVA.Location = new System.Drawing.Point(188, 166);
            this.cboxCondicionIVA.Name = "cboxCondicionIVA";
            this.cboxCondicionIVA.Size = new System.Drawing.Size(173, 25);
            this.cboxCondicionIVA.TabIndex = 20;
            // 
            // gboxImpuesto
            // 
            this.gboxImpuesto.Controls.Add(this.lblImpuesto2);
            this.gboxImpuesto.Controls.Add(this.lblImpuesto1);
            this.gboxImpuesto.Controls.Add(this.lblIB);
            this.gboxImpuesto.Controls.Add(this.tboxImpuesto2);
            this.gboxImpuesto.Controls.Add(this.tboxImpuesto1);
            this.gboxImpuesto.Controls.Add(this.tboxIB);
            this.gboxImpuesto.Controls.Add(this.lblIVA);
            this.gboxImpuesto.Controls.Add(this.tboxIVA);
            this.gboxImpuesto.Font = new System.Drawing.Font("Oswald Regular", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gboxImpuesto.Location = new System.Drawing.Point(18, 418);
            this.gboxImpuesto.Name = "gboxImpuesto";
            this.gboxImpuesto.Size = new System.Drawing.Size(425, 102);
            this.gboxImpuesto.TabIndex = 36;
            this.gboxImpuesto.TabStop = false;
            this.gboxImpuesto.Text = "Impuesto";
            // 
            // lblImpuesto2
            // 
            this.lblImpuesto2.AutoSize = true;
            this.lblImpuesto2.Location = new System.Drawing.Point(212, 69);
            this.lblImpuesto2.Name = "lblImpuesto2";
            this.lblImpuesto2.Size = new System.Drawing.Size(35, 17);
            this.lblImpuesto2.TabIndex = 19;
            this.lblImpuesto2.Text = "IMP 2";
            // 
            // lblImpuesto1
            // 
            this.lblImpuesto1.AutoSize = true;
            this.lblImpuesto1.Location = new System.Drawing.Point(17, 69);
            this.lblImpuesto1.Name = "lblImpuesto1";
            this.lblImpuesto1.Size = new System.Drawing.Size(32, 17);
            this.lblImpuesto1.TabIndex = 19;
            this.lblImpuesto1.Text = "IMP1";
            // 
            // lblIB
            // 
            this.lblIB.AutoSize = true;
            this.lblIB.Location = new System.Drawing.Point(212, 34);
            this.lblIB.Name = "lblIB";
            this.lblIB.Size = new System.Drawing.Size(18, 17);
            this.lblIB.TabIndex = 19;
            this.lblIB.Text = "IB";
            // 
            // tboxImpuesto2
            // 
            this.tboxImpuesto2.Location = new System.Drawing.Point(273, 66);
            this.tboxImpuesto2.Name = "tboxImpuesto2";
            this.tboxImpuesto2.Size = new System.Drawing.Size(129, 25);
            this.tboxImpuesto2.TabIndex = 13;
            // 
            // tboxImpuesto1
            // 
            this.tboxImpuesto1.Location = new System.Drawing.Point(70, 66);
            this.tboxImpuesto1.Name = "tboxImpuesto1";
            this.tboxImpuesto1.Size = new System.Drawing.Size(129, 25);
            this.tboxImpuesto1.TabIndex = 13;
            // 
            // tboxIB
            // 
            this.tboxIB.Location = new System.Drawing.Point(272, 31);
            this.tboxIB.Name = "tboxIB";
            this.tboxIB.Size = new System.Drawing.Size(129, 25);
            this.tboxIB.TabIndex = 13;
            // 
            // lblIVA
            // 
            this.lblIVA.AutoSize = true;
            this.lblIVA.Location = new System.Drawing.Point(17, 34);
            this.lblIVA.Name = "lblIVA";
            this.lblIVA.Size = new System.Drawing.Size(24, 17);
            this.lblIVA.TabIndex = 19;
            this.lblIVA.Text = "IVA";
            // 
            // tboxIVA
            // 
            this.tboxIVA.Location = new System.Drawing.Point(70, 31);
            this.tboxIVA.Name = "tboxIVA";
            this.tboxIVA.Size = new System.Drawing.Size(129, 25);
            this.tboxIVA.TabIndex = 13;
            // 
            // lblCodigoProveedor
            // 
            this.lblCodigoProveedor.AutoSize = true;
            this.lblCodigoProveedor.Font = new System.Drawing.Font("Oswald Regular", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCodigoProveedor.Location = new System.Drawing.Point(90, 57);
            this.lblCodigoProveedor.Name = "lblCodigoProveedor";
            this.lblCodigoProveedor.Size = new System.Drawing.Size(92, 17);
            this.lblCodigoProveedor.TabIndex = 38;
            this.lblCodigoProveedor.Text = "Código Proveedor";
            // 
            // tboxCodigoProveedor
            // 
            this.tboxCodigoProveedor.Font = new System.Drawing.Font("Oswald Regular", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tboxCodigoProveedor.Location = new System.Drawing.Point(188, 54);
            this.tboxCodigoProveedor.Name = "tboxCodigoProveedor";
            this.tboxCodigoProveedor.Size = new System.Drawing.Size(173, 25);
            this.tboxCodigoProveedor.TabIndex = 37;
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
            this.btnCancelar.Location = new System.Drawing.Point(244, 532);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(94, 37);
            this.btnCancelar.TabIndex = 39;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnCancelar.UseVisualStyleBackColor = false;
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
            this.btnAceptar.Location = new System.Drawing.Point(133, 532);
            this.btnAceptar.Name = "btnAceptar";
            this.btnAceptar.Size = new System.Drawing.Size(94, 37);
            this.btnAceptar.TabIndex = 40;
            this.btnAceptar.Text = "Aceptar";
            this.btnAceptar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnAceptar.UseVisualStyleBackColor = false;
            // 
            // lblNombreFormulario
            // 
            this.lblNombreFormulario.AutoSize = true;
            this.lblNombreFormulario.Font = new System.Drawing.Font("Bebas", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNombreFormulario.ForeColor = System.Drawing.Color.White;
            this.lblNombreFormulario.Location = new System.Drawing.Point(189, 9);
            this.lblNombreFormulario.Name = "lblNombreFormulario";
            this.lblNombreFormulario.Size = new System.Drawing.Size(80, 23);
            this.lblNombreFormulario.TabIndex = 9;
            this.lblNombreFormulario.Text = "PROVEEDOR";
            // 
            // Proveedor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(455, 593);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnAceptar);
            this.Controls.Add(this.lblCodigoProveedor);
            this.Controls.Add(this.cboxCondicionIVA);
            this.Controls.Add(this.tboxCodigoProveedor);
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
            this.Name = "Proveedor";
            this.Text = "NuevoProveedor";
            this.gboxContacto.ResumeLayout(false);
            this.gboxContacto.PerformLayout();
            this.gboxDireccion.ResumeLayout(false);
            this.gboxDireccion.PerformLayout();
            this.pnlBarraPrincipal.ResumeLayout(false);
            this.pnlBarraPrincipal.PerformLayout();
            this.gboxImpuesto.ResumeLayout(false);
            this.gboxImpuesto.PerformLayout();
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
        private System.Windows.Forms.TextBox tboxCP;
        private System.Windows.Forms.TextBox tboxNumero;
        private System.Windows.Forms.TextBox tboxLocalidad;
        private System.Windows.Forms.TextBox tboxProvincia;
        private System.Windows.Forms.TextBox tboxCalle;
        private System.Windows.Forms.Label lblCP;
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
        private System.Windows.Forms.Label lblCondicionIVA;
        private System.Windows.Forms.ComboBox cboxCondicionIVA;
        private System.Windows.Forms.GroupBox gboxImpuesto;
        private System.Windows.Forms.Label lblImpuesto2;
        private System.Windows.Forms.Label lblImpuesto1;
        private System.Windows.Forms.Label lblIB;
        private System.Windows.Forms.TextBox tboxImpuesto2;
        private System.Windows.Forms.TextBox tboxImpuesto1;
        private System.Windows.Forms.TextBox tboxIB;
        private System.Windows.Forms.Label lblIVA;
        private System.Windows.Forms.TextBox tboxIVA;
        private System.Windows.Forms.Label lblCodigoProveedor;
        private System.Windows.Forms.TextBox tboxCodigoProveedor;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button btnAceptar;
        private System.Windows.Forms.Label lblNombreFormulario;
    }
}