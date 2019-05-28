namespace PresentacionWinForm
{
    partial class Clientes
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Clientes));
            this.pnlBarraPrincipal = new System.Windows.Forms.Panel();
            this.lblCliente = new System.Windows.Forms.Label();
            this.lblApellido = new System.Windows.Forms.Label();
            this.lblNombre = new System.Windows.Forms.Label();
            this.tboxApellido = new System.Windows.Forms.TextBox();
            this.tboxNombre = new System.Windows.Forms.TextBox();
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
            this.gboxContacto = new System.Windows.Forms.GroupBox();
            this.tboxCelular = new System.Windows.Forms.TextBox();
            this.tboxCorreoElectronico = new System.Windows.Forms.TextBox();
            this.tboxTelefono = new System.Windows.Forms.TextBox();
            this.lblCorreoElectronico = new System.Windows.Forms.Label();
            this.lblCelular = new System.Windows.Forms.Label();
            this.lblTelefono = new System.Windows.Forms.Label();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnAceptar = new System.Windows.Forms.Button();
            this.pnlContenedor = new System.Windows.Forms.Panel();
            this.lblCodigo = new System.Windows.Forms.Label();
            this.tboxCodigo = new System.Windows.Forms.TextBox();
            this.gboxCuentaCorriente = new System.Windows.Forms.GroupBox();
            this.cboxDescuento = new System.Windows.Forms.ComboBox();
            this.tboxLimitecuenta = new System.Windows.Forms.TextBox();
            this.lblCuentaCorriente = new System.Windows.Forms.Label();
            this.lblDescuento = new System.Windows.Forms.Label();
            this.btnModificar = new System.Windows.Forms.Button();
            this.pnlBarraPrincipal.SuspendLayout();
            this.gboxDireccion.SuspendLayout();
            this.gboxContacto.SuspendLayout();
            this.pnlContenedor.SuspendLayout();
            this.gboxCuentaCorriente.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlBarraPrincipal
            // 
            this.pnlBarraPrincipal.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(115)))), ((int)(((byte)(149)))));
            this.pnlBarraPrincipal.Controls.Add(this.lblCliente);
            this.pnlBarraPrincipal.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlBarraPrincipal.Location = new System.Drawing.Point(0, 0);
            this.pnlBarraPrincipal.Name = "pnlBarraPrincipal";
            this.pnlBarraPrincipal.Size = new System.Drawing.Size(510, 49);
            this.pnlBarraPrincipal.TabIndex = 3;
            // 
            // lblCliente
            // 
            this.lblCliente.AutoSize = true;
            this.lblCliente.Font = new System.Drawing.Font("Bebas", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCliente.ForeColor = System.Drawing.Color.White;
            this.lblCliente.Location = new System.Drawing.Point(227, 8);
            this.lblCliente.Name = "lblCliente";
            this.lblCliente.Size = new System.Drawing.Size(66, 23);
            this.lblCliente.TabIndex = 10;
            this.lblCliente.Text = "Cliente";
            // 
            // lblApellido
            // 
            this.lblApellido.AutoSize = true;
            this.lblApellido.Font = new System.Drawing.Font("Oswald Regular", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblApellido.Location = new System.Drawing.Point(130, 85);
            this.lblApellido.Name = "lblApellido";
            this.lblApellido.Size = new System.Drawing.Size(46, 17);
            this.lblApellido.TabIndex = 17;
            this.lblApellido.Text = "Apellido";
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.Font = new System.Drawing.Font("Oswald Regular", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNombre.Location = new System.Drawing.Point(130, 52);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(45, 17);
            this.lblNombre.TabIndex = 19;
            this.lblNombre.Text = "Nombre";
            // 
            // tboxApellido
            // 
            this.tboxApellido.Font = new System.Drawing.Font("Oswald Regular", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tboxApellido.Location = new System.Drawing.Point(192, 81);
            this.tboxApellido.Name = "tboxApellido";
            this.tboxApellido.Size = new System.Drawing.Size(158, 25);
            this.tboxApellido.TabIndex = 3;
            // 
            // tboxNombre
            // 
            this.tboxNombre.Font = new System.Drawing.Font("Oswald Regular", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tboxNombre.Location = new System.Drawing.Point(192, 50);
            this.tboxNombre.Name = "tboxNombre";
            this.tboxNombre.Size = new System.Drawing.Size(158, 25);
            this.tboxNombre.TabIndex = 2;
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
            this.gboxDireccion.Location = new System.Drawing.Point(55, 248);
            this.gboxDireccion.Name = "gboxDireccion";
            this.gboxDireccion.Size = new System.Drawing.Size(410, 105);
            this.gboxDireccion.TabIndex = 8;
            this.gboxDireccion.TabStop = false;
            this.gboxDireccion.Text = "Dirección";
            // 
            // tboxCP
            // 
            this.tboxCP.Location = new System.Drawing.Point(362, 23);
            this.tboxCP.Name = "tboxCP";
            this.tboxCP.Size = new System.Drawing.Size(28, 25);
            this.tboxCP.TabIndex = 9;
            // 
            // tboxNumero
            // 
            this.tboxNumero.Location = new System.Drawing.Point(279, 23);
            this.tboxNumero.Name = "tboxNumero";
            this.tboxNumero.Size = new System.Drawing.Size(28, 25);
            this.tboxNumero.TabIndex = 8;
            // 
            // tboxLocalidad
            // 
            this.tboxLocalidad.Location = new System.Drawing.Point(262, 60);
            this.tboxLocalidad.Name = "tboxLocalidad";
            this.tboxLocalidad.Size = new System.Drawing.Size(128, 25);
            this.tboxLocalidad.TabIndex = 11;
            // 
            // tboxProvincia
            // 
            this.tboxProvincia.Location = new System.Drawing.Point(68, 60);
            this.tboxProvincia.Name = "tboxProvincia";
            this.tboxProvincia.Size = new System.Drawing.Size(109, 25);
            this.tboxProvincia.TabIndex = 10;
            // 
            // tboxCalle
            // 
            this.tboxCalle.Location = new System.Drawing.Point(47, 23);
            this.tboxCalle.Name = "tboxCalle";
            this.tboxCalle.Size = new System.Drawing.Size(158, 25);
            this.tboxCalle.TabIndex = 7;
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
            // gboxContacto
            // 
            this.gboxContacto.Controls.Add(this.tboxCelular);
            this.gboxContacto.Controls.Add(this.tboxCorreoElectronico);
            this.gboxContacto.Controls.Add(this.tboxTelefono);
            this.gboxContacto.Controls.Add(this.lblCorreoElectronico);
            this.gboxContacto.Controls.Add(this.lblCelular);
            this.gboxContacto.Controls.Add(this.lblTelefono);
            this.gboxContacto.Font = new System.Drawing.Font("Oswald Regular", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gboxContacto.Location = new System.Drawing.Point(55, 132);
            this.gboxContacto.Name = "gboxContacto";
            this.gboxContacto.Size = new System.Drawing.Size(410, 110);
            this.gboxContacto.TabIndex = 4;
            this.gboxContacto.TabStop = false;
            this.gboxContacto.Text = "Contacto";
            // 
            // tboxCelular
            // 
            this.tboxCelular.Location = new System.Drawing.Point(256, 31);
            this.tboxCelular.Name = "tboxCelular";
            this.tboxCelular.Size = new System.Drawing.Size(134, 25);
            this.tboxCelular.TabIndex = 5;
            // 
            // tboxCorreoElectronico
            // 
            this.tboxCorreoElectronico.Location = new System.Drawing.Point(115, 68);
            this.tboxCorreoElectronico.Name = "tboxCorreoElectronico";
            this.tboxCorreoElectronico.Size = new System.Drawing.Size(275, 25);
            this.tboxCorreoElectronico.TabIndex = 6;
            // 
            // tboxTelefono
            // 
            this.tboxTelefono.Location = new System.Drawing.Point(66, 31);
            this.tboxTelefono.Name = "tboxTelefono";
            this.tboxTelefono.Size = new System.Drawing.Size(114, 25);
            this.tboxTelefono.TabIndex = 4;
            // 
            // lblCorreoElectronico
            // 
            this.lblCorreoElectronico.AutoSize = true;
            this.lblCorreoElectronico.Location = new System.Drawing.Point(15, 71);
            this.lblCorreoElectronico.Name = "lblCorreoElectronico";
            this.lblCorreoElectronico.Size = new System.Drawing.Size(95, 17);
            this.lblCorreoElectronico.TabIndex = 19;
            this.lblCorreoElectronico.Text = "Correo Electrónico";
            // 
            // lblCelular
            // 
            this.lblCelular.AutoSize = true;
            this.lblCelular.Location = new System.Drawing.Point(206, 34);
            this.lblCelular.Name = "lblCelular";
            this.lblCelular.Size = new System.Drawing.Size(42, 17);
            this.lblCelular.TabIndex = 19;
            this.lblCelular.Text = "Celular";
            // 
            // lblTelefono
            // 
            this.lblTelefono.AutoSize = true;
            this.lblTelefono.Location = new System.Drawing.Point(11, 34);
            this.lblTelefono.Name = "lblTelefono";
            this.lblTelefono.Size = new System.Drawing.Size(48, 17);
            this.lblTelefono.TabIndex = 19;
            this.lblTelefono.Text = "Teléfono";
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
            this.btnCancelar.Location = new System.Drawing.Point(259, 499);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(91, 37);
            this.btnCancelar.TabIndex = 15;
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
            this.btnAceptar.Location = new System.Drawing.Point(123, 499);
            this.btnAceptar.Name = "btnAceptar";
            this.btnAceptar.Size = new System.Drawing.Size(98, 37);
            this.btnAceptar.TabIndex = 14;
            this.btnAceptar.Text = "Aceptar";
            this.btnAceptar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnAceptar.UseVisualStyleBackColor = false;
            this.btnAceptar.Click += new System.EventHandler(this.btnAceptar_Click);
            // 
            // pnlContenedor
            // 
            this.pnlContenedor.Controls.Add(this.lblCodigo);
            this.pnlContenedor.Controls.Add(this.lblNombre);
            this.pnlContenedor.Controls.Add(this.btnCancelar);
            this.pnlContenedor.Controls.Add(this.tboxCodigo);
            this.pnlContenedor.Controls.Add(this.tboxNombre);
            this.pnlContenedor.Controls.Add(this.btnAceptar);
            this.pnlContenedor.Controls.Add(this.tboxApellido);
            this.pnlContenedor.Controls.Add(this.gboxCuentaCorriente);
            this.pnlContenedor.Controls.Add(this.gboxContacto);
            this.pnlContenedor.Controls.Add(this.gboxDireccion);
            this.pnlContenedor.Controls.Add(this.lblApellido);
            this.pnlContenedor.Controls.Add(this.btnModificar);
            this.pnlContenedor.Location = new System.Drawing.Point(0, 38);
            this.pnlContenedor.Name = "pnlContenedor";
            this.pnlContenedor.Size = new System.Drawing.Size(510, 579);
            this.pnlContenedor.TabIndex = 40;
            // 
            // lblCodigo
            // 
            this.lblCodigo.AutoSize = true;
            this.lblCodigo.Font = new System.Drawing.Font("Oswald Regular", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCodigo.Location = new System.Drawing.Point(97, 22);
            this.lblCodigo.Name = "lblCodigo";
            this.lblCodigo.Size = new System.Drawing.Size(78, 17);
            this.lblCodigo.TabIndex = 19;
            this.lblCodigo.Text = "Codigo Cliente";
            // 
            // tboxCodigo
            // 
            this.tboxCodigo.Font = new System.Drawing.Font("Oswald Regular", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tboxCodigo.Location = new System.Drawing.Point(192, 19);
            this.tboxCodigo.Name = "tboxCodigo";
            this.tboxCodigo.Size = new System.Drawing.Size(158, 25);
            this.tboxCodigo.TabIndex = 1;
            // 
            // gboxCuentaCorriente
            // 
            this.gboxCuentaCorriente.Controls.Add(this.cboxDescuento);
            this.gboxCuentaCorriente.Controls.Add(this.tboxLimitecuenta);
            this.gboxCuentaCorriente.Controls.Add(this.lblCuentaCorriente);
            this.gboxCuentaCorriente.Controls.Add(this.lblDescuento);
            this.gboxCuentaCorriente.Font = new System.Drawing.Font("Oswald Regular", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gboxCuentaCorriente.Location = new System.Drawing.Point(55, 368);
            this.gboxCuentaCorriente.Name = "gboxCuentaCorriente";
            this.gboxCuentaCorriente.Size = new System.Drawing.Size(410, 110);
            this.gboxCuentaCorriente.TabIndex = 16;
            this.gboxCuentaCorriente.TabStop = false;
            this.gboxCuentaCorriente.Text = "CuentaCorriente";
            // 
            // cboxDescuento
            // 
            this.cboxDescuento.FormattingEnabled = true;
            this.cboxDescuento.ItemHeight = 17;
            this.cboxDescuento.Location = new System.Drawing.Point(137, 32);
            this.cboxDescuento.Name = "cboxDescuento";
            this.cboxDescuento.Size = new System.Drawing.Size(195, 25);
            this.cboxDescuento.TabIndex = 20;
            // 
            // tboxLimitecuenta
            // 
            this.tboxLimitecuenta.Location = new System.Drawing.Point(212, 67);
            this.tboxLimitecuenta.Name = "tboxLimitecuenta";
            this.tboxLimitecuenta.Size = new System.Drawing.Size(64, 25);
            this.tboxLimitecuenta.TabIndex = 13;
            // 
            // lblCuentaCorriente
            // 
            this.lblCuentaCorriente.AutoSize = true;
            this.lblCuentaCorriente.Location = new System.Drawing.Point(82, 75);
            this.lblCuentaCorriente.Name = "lblCuentaCorriente";
            this.lblCuentaCorriente.Size = new System.Drawing.Size(117, 17);
            this.lblCuentaCorriente.TabIndex = 19;
            this.lblCuentaCorriente.Text = "Limite cuenta corriente";
            // 
            // lblDescuento
            // 
            this.lblDescuento.AutoSize = true;
            this.lblDescuento.Location = new System.Drawing.Point(74, 35);
            this.lblDescuento.Name = "lblDescuento";
            this.lblDescuento.Size = new System.Drawing.Size(57, 17);
            this.lblDescuento.TabIndex = 19;
            this.lblDescuento.Text = "Descuento";
            // 
            // btnModificar
            // 
            this.btnModificar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(115)))), ((int)(((byte)(149)))));
            this.btnModificar.FlatAppearance.BorderSize = 0;
            this.btnModificar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnModificar.Font = new System.Drawing.Font("Bebas", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnModificar.ForeColor = System.Drawing.Color.White;
            this.btnModificar.Image = ((System.Drawing.Image)(resources.GetObject("btnModificar.Image")));
            this.btnModificar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnModificar.Location = new System.Drawing.Point(155, 499);
            this.btnModificar.Name = "btnModificar";
            this.btnModificar.Size = new System.Drawing.Size(98, 37);
            this.btnModificar.TabIndex = 14;
            this.btnModificar.Text = "Modificar";
            this.btnModificar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnModificar.UseVisualStyleBackColor = false;
            this.btnModificar.Click += new System.EventHandler(this.btnModificar_Click);
            // 
            // Clientes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(510, 613);
            this.Controls.Add(this.pnlContenedor);
            this.Controls.Add(this.pnlBarraPrincipal);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Clientes";
            this.Text = "NuevoCliente";
            this.Load += new System.EventHandler(this.Clientes_Load);
            this.pnlBarraPrincipal.ResumeLayout(false);
            this.pnlBarraPrincipal.PerformLayout();
            this.gboxDireccion.ResumeLayout(false);
            this.gboxDireccion.PerformLayout();
            this.gboxContacto.ResumeLayout(false);
            this.gboxContacto.PerformLayout();
            this.pnlContenedor.ResumeLayout(false);
            this.pnlContenedor.PerformLayout();
            this.gboxCuentaCorriente.ResumeLayout(false);
            this.gboxCuentaCorriente.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlBarraPrincipal;
        private System.Windows.Forms.Label lblApellido;
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.TextBox tboxApellido;
        private System.Windows.Forms.TextBox tboxNombre;
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
        private System.Windows.Forms.GroupBox gboxContacto;
        private System.Windows.Forms.TextBox tboxCelular;
        private System.Windows.Forms.TextBox tboxCorreoElectronico;
        private System.Windows.Forms.TextBox tboxTelefono;
        private System.Windows.Forms.Label lblCorreoElectronico;
        private System.Windows.Forms.Label lblCelular;
        private System.Windows.Forms.Label lblTelefono;
        private System.Windows.Forms.Label lblCliente;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button btnAceptar;
        private System.Windows.Forms.Panel pnlContenedor;
        private System.Windows.Forms.Label lblCodigo;
        private System.Windows.Forms.TextBox tboxCodigo;
        private System.Windows.Forms.GroupBox gboxCuentaCorriente;
        private System.Windows.Forms.ComboBox cboxDescuento;
        private System.Windows.Forms.TextBox tboxLimitecuenta;
        private System.Windows.Forms.Label lblCuentaCorriente;
        private System.Windows.Forms.Label lblDescuento;
        private System.Windows.Forms.Button btnModificar;
    }
}