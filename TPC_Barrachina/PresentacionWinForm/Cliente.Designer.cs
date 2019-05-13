namespace PresentacionWinForm
{
    partial class Cliente
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Cliente));
            this.pnlBarraPrincipal = new System.Windows.Forms.Panel();
            this.lblCliente = new System.Windows.Forms.Label();
            this.lblNacimiento = new System.Windows.Forms.Label();
            this.lblApellido = new System.Windows.Forms.Label();
            this.lblNombre = new System.Windows.Forms.Label();
            this.gboxSexo = new System.Windows.Forms.GroupBox();
            this.rbtnOtros = new System.Windows.Forms.RadioButton();
            this.rbtnMasculino = new System.Windows.Forms.RadioButton();
            this.rbtnFemenino = new System.Windows.Forms.RadioButton();
            this.dtpFechaNacimiento = new System.Windows.Forms.DateTimePicker();
            this.txtApellido = new System.Windows.Forms.TextBox();
            this.txtbNombre = new System.Windows.Forms.TextBox();
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnModificar = new System.Windows.Forms.Button();
            this.pnlBarraPrincipal.SuspendLayout();
            this.gboxSexo.SuspendLayout();
            this.gboxDireccion.SuspendLayout();
            this.gboxContacto.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlBarraPrincipal
            // 
            this.pnlBarraPrincipal.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(115)))), ((int)(((byte)(149)))));
            this.pnlBarraPrincipal.Controls.Add(this.lblCliente);
            this.pnlBarraPrincipal.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlBarraPrincipal.Location = new System.Drawing.Point(0, 0);
            this.pnlBarraPrincipal.Name = "pnlBarraPrincipal";
            this.pnlBarraPrincipal.Size = new System.Drawing.Size(448, 41);
            this.pnlBarraPrincipal.TabIndex = 3;
            // 
            // lblCliente
            // 
            this.lblCliente.AutoSize = true;
            this.lblCliente.Font = new System.Drawing.Font("Bebas", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCliente.ForeColor = System.Drawing.Color.White;
            this.lblCliente.Location = new System.Drawing.Point(197, 7);
            this.lblCliente.Name = "lblCliente";
            this.lblCliente.Size = new System.Drawing.Size(66, 23);
            this.lblCliente.TabIndex = 10;
            this.lblCliente.Text = "Cliente";
            // 
            // lblNacimiento
            // 
            this.lblNacimiento.AutoSize = true;
            this.lblNacimiento.Font = new System.Drawing.Font("Oswald Regular", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNacimiento.Location = new System.Drawing.Point(93, 86);
            this.lblNacimiento.Name = "lblNacimiento";
            this.lblNacimiento.Size = new System.Drawing.Size(35, 17);
            this.lblNacimiento.TabIndex = 16;
            this.lblNacimiento.Text = "Fecha";
            // 
            // lblApellido
            // 
            this.lblApellido.AutoSize = true;
            this.lblApellido.Font = new System.Drawing.Font("Oswald Regular", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblApellido.Location = new System.Drawing.Point(93, 57);
            this.lblApellido.Name = "lblApellido";
            this.lblApellido.Size = new System.Drawing.Size(46, 17);
            this.lblApellido.TabIndex = 17;
            this.lblApellido.Text = "Apellido";
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.Font = new System.Drawing.Font("Oswald Regular", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNombre.Location = new System.Drawing.Point(93, 29);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(45, 17);
            this.lblNombre.TabIndex = 19;
            this.lblNombre.Text = "Nombre";
            // 
            // gboxSexo
            // 
            this.gboxSexo.Controls.Add(this.rbtnOtros);
            this.gboxSexo.Controls.Add(this.rbtnMasculino);
            this.gboxSexo.Controls.Add(this.rbtnFemenino);
            this.gboxSexo.Font = new System.Drawing.Font("Oswald Regular", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gboxSexo.Location = new System.Drawing.Point(13, 129);
            this.gboxSexo.Name = "gboxSexo";
            this.gboxSexo.Size = new System.Drawing.Size(424, 59);
            this.gboxSexo.TabIndex = 20;
            this.gboxSexo.TabStop = false;
            this.gboxSexo.Text = "Sexo";
            // 
            // rbtnOtros
            // 
            this.rbtnOtros.AutoSize = true;
            this.rbtnOtros.Location = new System.Drawing.Point(307, 22);
            this.rbtnOtros.Name = "rbtnOtros";
            this.rbtnOtros.Size = new System.Drawing.Size(52, 21);
            this.rbtnOtros.TabIndex = 2;
            this.rbtnOtros.TabStop = true;
            this.rbtnOtros.Text = "Otros";
            this.rbtnOtros.UseVisualStyleBackColor = true;
            // 
            // rbtnMasculino
            // 
            this.rbtnMasculino.AutoSize = true;
            this.rbtnMasculino.Location = new System.Drawing.Point(183, 22);
            this.rbtnMasculino.Name = "rbtnMasculino";
            this.rbtnMasculino.Size = new System.Drawing.Size(75, 21);
            this.rbtnMasculino.TabIndex = 2;
            this.rbtnMasculino.TabStop = true;
            this.rbtnMasculino.Text = "Masculino";
            this.rbtnMasculino.UseVisualStyleBackColor = true;
            // 
            // rbtnFemenino
            // 
            this.rbtnFemenino.AutoSize = true;
            this.rbtnFemenino.Location = new System.Drawing.Point(74, 22);
            this.rbtnFemenino.Name = "rbtnFemenino";
            this.rbtnFemenino.Size = new System.Drawing.Size(71, 21);
            this.rbtnFemenino.TabIndex = 2;
            this.rbtnFemenino.TabStop = true;
            this.rbtnFemenino.Text = "Femenino";
            this.rbtnFemenino.UseVisualStyleBackColor = true;
            // 
            // dtpFechaNacimiento
            // 
            this.dtpFechaNacimiento.Font = new System.Drawing.Font("Oswald Regular", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpFechaNacimiento.Location = new System.Drawing.Point(155, 79);
            this.dtpFechaNacimiento.Name = "dtpFechaNacimiento";
            this.dtpFechaNacimiento.Size = new System.Drawing.Size(173, 25);
            this.dtpFechaNacimiento.TabIndex = 14;
            // 
            // txtApellido
            // 
            this.txtApellido.Font = new System.Drawing.Font("Oswald Regular", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtApellido.Location = new System.Drawing.Point(155, 50);
            this.txtApellido.Name = "txtApellido";
            this.txtApellido.Size = new System.Drawing.Size(173, 25);
            this.txtApellido.TabIndex = 12;
            // 
            // txtbNombre
            // 
            this.txtbNombre.Font = new System.Drawing.Font("Oswald Regular", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtbNombre.Location = new System.Drawing.Point(155, 22);
            this.txtbNombre.Name = "txtbNombre";
            this.txtbNombre.Size = new System.Drawing.Size(173, 25);
            this.txtbNombre.TabIndex = 13;
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
            this.gboxDireccion.Location = new System.Drawing.Point(12, 194);
            this.gboxDireccion.Name = "gboxDireccion";
            this.gboxDireccion.Size = new System.Drawing.Size(425, 105);
            this.gboxDireccion.TabIndex = 34;
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
            // gboxContacto
            // 
            this.gboxContacto.Controls.Add(this.tboxCelular);
            this.gboxContacto.Controls.Add(this.tboxCorreoElectronico);
            this.gboxContacto.Controls.Add(this.tboxTelefono);
            this.gboxContacto.Controls.Add(this.lblCorreoElectronico);
            this.gboxContacto.Controls.Add(this.lblCelular);
            this.gboxContacto.Controls.Add(this.lblTelefono);
            this.gboxContacto.Font = new System.Drawing.Font("Oswald Regular", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gboxContacto.Location = new System.Drawing.Point(12, 305);
            this.gboxContacto.Name = "gboxContacto";
            this.gboxContacto.Size = new System.Drawing.Size(425, 110);
            this.gboxContacto.TabIndex = 37;
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
            // btnCancelar
            // 
            this.btnCancelar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(115)))), ((int)(((byte)(149)))));
            this.btnCancelar.FlatAppearance.BorderSize = 0;
            this.btnCancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancelar.Font = new System.Drawing.Font("Bebas", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancelar.ForeColor = System.Drawing.Color.White;
            this.btnCancelar.Image = ((System.Drawing.Image)(resources.GetObject("btnCancelar.Image")));
            this.btnCancelar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCancelar.Location = new System.Drawing.Point(240, 437);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(94, 37);
            this.btnCancelar.TabIndex = 38;
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
            this.btnAceptar.Location = new System.Drawing.Point(129, 437);
            this.btnAceptar.Name = "btnAceptar";
            this.btnAceptar.Size = new System.Drawing.Size(94, 37);
            this.btnAceptar.TabIndex = 39;
            this.btnAceptar.Text = "Aceptar";
            this.btnAceptar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnAceptar.UseVisualStyleBackColor = false;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.lblNombre);
            this.panel1.Controls.Add(this.btnCancelar);
            this.panel1.Controls.Add(this.txtbNombre);
            this.panel1.Controls.Add(this.btnModificar);
            this.panel1.Controls.Add(this.btnAceptar);
            this.panel1.Controls.Add(this.txtApellido);
            this.panel1.Controls.Add(this.gboxContacto);
            this.panel1.Controls.Add(this.dtpFechaNacimiento);
            this.panel1.Controls.Add(this.gboxDireccion);
            this.panel1.Controls.Add(this.lblApellido);
            this.panel1.Controls.Add(this.gboxSexo);
            this.panel1.Controls.Add(this.lblNacimiento);
            this.panel1.Location = new System.Drawing.Point(0, 35);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(448, 497);
            this.panel1.TabIndex = 40;
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
            this.btnModificar.Location = new System.Drawing.Point(127, 437);
            this.btnModificar.Name = "btnModificar";
            this.btnModificar.Size = new System.Drawing.Size(100, 37);
            this.btnModificar.TabIndex = 39;
            this.btnModificar.Text = "  Modificar";
            this.btnModificar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnModificar.UseVisualStyleBackColor = false;
            this.btnModificar.Visible = false;
            // 
            // Cliente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(448, 533);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.pnlBarraPrincipal);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Cliente";
            this.Text = "NuevoCliente";
            this.pnlBarraPrincipal.ResumeLayout(false);
            this.pnlBarraPrincipal.PerformLayout();
            this.gboxSexo.ResumeLayout(false);
            this.gboxSexo.PerformLayout();
            this.gboxDireccion.ResumeLayout(false);
            this.gboxDireccion.PerformLayout();
            this.gboxContacto.ResumeLayout(false);
            this.gboxContacto.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlBarraPrincipal;
        private System.Windows.Forms.Label lblNacimiento;
        private System.Windows.Forms.Label lblApellido;
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.GroupBox gboxSexo;
        private System.Windows.Forms.RadioButton rbtnOtros;
        private System.Windows.Forms.RadioButton rbtnMasculino;
        private System.Windows.Forms.RadioButton rbtnFemenino;
        private System.Windows.Forms.DateTimePicker dtpFechaNacimiento;
        private System.Windows.Forms.TextBox txtApellido;
        private System.Windows.Forms.TextBox txtbNombre;
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
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnModificar;
    }
}