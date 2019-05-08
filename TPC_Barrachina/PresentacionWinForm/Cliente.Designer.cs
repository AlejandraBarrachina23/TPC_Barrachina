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
            this.pnlBarraPrincipal = new System.Windows.Forms.Panel();
            this.lbNombrePrograma = new System.Windows.Forms.Label();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnAceptar = new System.Windows.Forms.Button();
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
            this.pnlBarraPrincipal.SuspendLayout();
            this.gboxSexo.SuspendLayout();
            this.gboxDireccion.SuspendLayout();
            this.gboxContacto.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlBarraPrincipal
            // 
            this.pnlBarraPrincipal.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.pnlBarraPrincipal.Controls.Add(this.lbNombrePrograma);
            this.pnlBarraPrincipal.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlBarraPrincipal.Location = new System.Drawing.Point(0, 0);
            this.pnlBarraPrincipal.Name = "pnlBarraPrincipal";
            this.pnlBarraPrincipal.Size = new System.Drawing.Size(460, 41);
            this.pnlBarraPrincipal.TabIndex = 3;
            // 
            // lbNombrePrograma
            // 
            this.lbNombrePrograma.AutoSize = true;
            this.lbNombrePrograma.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbNombrePrograma.Location = new System.Drawing.Point(190, 14);
            this.lbNombrePrograma.Name = "lbNombrePrograma";
            this.lbNombrePrograma.Size = new System.Drawing.Size(106, 13);
            this.lbNombrePrograma.TabIndex = 9;
            this.lbNombrePrograma.Text = "NUEVO CLIENTE";
            // 
            // btnCancelar
            // 
            this.btnCancelar.Location = new System.Drawing.Point(244, 474);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(111, 44);
            this.btnCancelar.TabIndex = 22;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            // 
            // btnAceptar
            // 
            this.btnAceptar.Location = new System.Drawing.Point(124, 474);
            this.btnAceptar.Name = "btnAceptar";
            this.btnAceptar.Size = new System.Drawing.Size(113, 44);
            this.btnAceptar.TabIndex = 23;
            this.btnAceptar.Text = "Aceptar";
            this.btnAceptar.UseVisualStyleBackColor = true;
            // 
            // lblNacimiento
            // 
            this.lblNacimiento.AutoSize = true;
            this.lblNacimiento.Location = new System.Drawing.Point(104, 120);
            this.lblNacimiento.Name = "lblNacimiento";
            this.lblNacimiento.Size = new System.Drawing.Size(37, 13);
            this.lblNacimiento.TabIndex = 16;
            this.lblNacimiento.Text = "Fecha";
            // 
            // lblApellido
            // 
            this.lblApellido.AutoSize = true;
            this.lblApellido.Location = new System.Drawing.Point(104, 94);
            this.lblApellido.Name = "lblApellido";
            this.lblApellido.Size = new System.Drawing.Size(44, 13);
            this.lblApellido.TabIndex = 17;
            this.lblApellido.Text = "Apellido";
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.Location = new System.Drawing.Point(104, 68);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(44, 13);
            this.lblNombre.TabIndex = 19;
            this.lblNombre.Text = "Nombre";
            // 
            // gboxSexo
            // 
            this.gboxSexo.Controls.Add(this.rbtnOtros);
            this.gboxSexo.Controls.Add(this.rbtnMasculino);
            this.gboxSexo.Controls.Add(this.rbtnFemenino);
            this.gboxSexo.Location = new System.Drawing.Point(18, 166);
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
            this.rbtnOtros.Size = new System.Drawing.Size(50, 17);
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
            this.rbtnMasculino.Size = new System.Drawing.Size(73, 17);
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
            this.rbtnFemenino.Size = new System.Drawing.Size(71, 17);
            this.rbtnFemenino.TabIndex = 2;
            this.rbtnFemenino.TabStop = true;
            this.rbtnFemenino.Text = "Femenino";
            this.rbtnFemenino.UseVisualStyleBackColor = true;
            // 
            // dtpFechaNacimiento
            // 
            this.dtpFechaNacimiento.Location = new System.Drawing.Point(166, 113);
            this.dtpFechaNacimiento.Name = "dtpFechaNacimiento";
            this.dtpFechaNacimiento.Size = new System.Drawing.Size(173, 20);
            this.dtpFechaNacimiento.TabIndex = 14;
            // 
            // txtApellido
            // 
            this.txtApellido.Location = new System.Drawing.Point(166, 87);
            this.txtApellido.Name = "txtApellido";
            this.txtApellido.Size = new System.Drawing.Size(173, 20);
            this.txtApellido.TabIndex = 12;
            // 
            // txtbNombre
            // 
            this.txtbNombre.Location = new System.Drawing.Point(166, 61);
            this.txtbNombre.Name = "txtbNombre";
            this.txtbNombre.Size = new System.Drawing.Size(173, 20);
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
            this.gboxDireccion.Location = new System.Drawing.Point(18, 231);
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
            this.tboxCP.Size = new System.Drawing.Size(43, 20);
            this.tboxCP.TabIndex = 13;
            // 
            // tboxNumero
            // 
            this.tboxNumero.Location = new System.Drawing.Point(279, 23);
            this.tboxNumero.Name = "tboxNumero";
            this.tboxNumero.Size = new System.Drawing.Size(43, 20);
            this.tboxNumero.TabIndex = 13;
            // 
            // tboxLocalidad
            // 
            this.tboxLocalidad.Location = new System.Drawing.Point(262, 60);
            this.tboxLocalidad.Name = "tboxLocalidad";
            this.tboxLocalidad.Size = new System.Drawing.Size(143, 20);
            this.tboxLocalidad.TabIndex = 13;
            // 
            // tboxProvincia
            // 
            this.tboxProvincia.Location = new System.Drawing.Point(68, 60);
            this.tboxProvincia.Name = "tboxProvincia";
            this.tboxProvincia.Size = new System.Drawing.Size(124, 20);
            this.tboxProvincia.TabIndex = 13;
            // 
            // tboxCalle
            // 
            this.tboxCalle.Location = new System.Drawing.Point(47, 23);
            this.tboxCalle.Name = "tboxCalle";
            this.tboxCalle.Size = new System.Drawing.Size(173, 20);
            this.tboxCalle.TabIndex = 13;
            // 
            // lblCP
            // 
            this.lblCP.AutoSize = true;
            this.lblCP.Location = new System.Drawing.Point(338, 26);
            this.lblCP.Name = "lblCP";
            this.lblCP.Size = new System.Drawing.Size(21, 13);
            this.lblCP.TabIndex = 19;
            this.lblCP.Text = "CP";
            // 
            // lblLocalidad
            // 
            this.lblLocalidad.AutoSize = true;
            this.lblLocalidad.Location = new System.Drawing.Point(206, 63);
            this.lblLocalidad.Name = "lblLocalidad";
            this.lblLocalidad.Size = new System.Drawing.Size(53, 13);
            this.lblLocalidad.TabIndex = 19;
            this.lblLocalidad.Text = "Localidad";
            // 
            // lblProvincia
            // 
            this.lblProvincia.AutoSize = true;
            this.lblProvincia.Location = new System.Drawing.Point(11, 63);
            this.lblProvincia.Name = "lblProvincia";
            this.lblProvincia.Size = new System.Drawing.Size(51, 13);
            this.lblProvincia.TabIndex = 19;
            this.lblProvincia.Text = "Provincia";
            // 
            // lblNumero
            // 
            this.lblNumero.AutoSize = true;
            this.lblNumero.Location = new System.Drawing.Point(231, 27);
            this.lblNumero.Name = "lblNumero";
            this.lblNumero.Size = new System.Drawing.Size(44, 13);
            this.lblNumero.TabIndex = 19;
            this.lblNumero.Text = "Número";
            // 
            // lblCalle
            // 
            this.lblCalle.AutoSize = true;
            this.lblCalle.Location = new System.Drawing.Point(11, 27);
            this.lblCalle.Name = "lblCalle";
            this.lblCalle.Size = new System.Drawing.Size(30, 13);
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
            this.gboxContacto.Location = new System.Drawing.Point(18, 347);
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
            this.tboxCelular.Size = new System.Drawing.Size(149, 20);
            this.tboxCelular.TabIndex = 13;
            // 
            // tboxCorreoElectronico
            // 
            this.tboxCorreoElectronico.Location = new System.Drawing.Point(115, 74);
            this.tboxCorreoElectronico.Name = "tboxCorreoElectronico";
            this.tboxCorreoElectronico.Size = new System.Drawing.Size(290, 20);
            this.tboxCorreoElectronico.TabIndex = 13;
            // 
            // tboxTelefono
            // 
            this.tboxTelefono.Location = new System.Drawing.Point(66, 37);
            this.tboxTelefono.Name = "tboxTelefono";
            this.tboxTelefono.Size = new System.Drawing.Size(129, 20);
            this.tboxTelefono.TabIndex = 13;
            // 
            // lblCorreoElectronico
            // 
            this.lblCorreoElectronico.AutoSize = true;
            this.lblCorreoElectronico.Location = new System.Drawing.Point(15, 77);
            this.lblCorreoElectronico.Name = "lblCorreoElectronico";
            this.lblCorreoElectronico.Size = new System.Drawing.Size(94, 13);
            this.lblCorreoElectronico.TabIndex = 19;
            this.lblCorreoElectronico.Text = "Correo Electrónico";
            // 
            // lblCelular
            // 
            this.lblCelular.AutoSize = true;
            this.lblCelular.Location = new System.Drawing.Point(206, 40);
            this.lblCelular.Name = "lblCelular";
            this.lblCelular.Size = new System.Drawing.Size(39, 13);
            this.lblCelular.TabIndex = 19;
            this.lblCelular.Text = "Celular";
            // 
            // lblTelefono
            // 
            this.lblTelefono.AutoSize = true;
            this.lblTelefono.Location = new System.Drawing.Point(11, 40);
            this.lblTelefono.Name = "lblTelefono";
            this.lblTelefono.Size = new System.Drawing.Size(49, 13);
            this.lblTelefono.TabIndex = 19;
            this.lblTelefono.Text = "Teléfono";
            // 
            // NuevoCliente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(460, 544);
            this.Controls.Add(this.gboxContacto);
            this.Controls.Add(this.gboxDireccion);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnAceptar);
            this.Controls.Add(this.lblNacimiento);
            this.Controls.Add(this.lblApellido);
            this.Controls.Add(this.lblNombre);
            this.Controls.Add(this.gboxSexo);
            this.Controls.Add(this.dtpFechaNacimiento);
            this.Controls.Add(this.txtApellido);
            this.Controls.Add(this.txtbNombre);
            this.Controls.Add(this.pnlBarraPrincipal);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "NuevoCliente";
            this.Text = "NuevoCliente";
            this.pnlBarraPrincipal.ResumeLayout(false);
            this.pnlBarraPrincipal.PerformLayout();
            this.gboxSexo.ResumeLayout(false);
            this.gboxSexo.PerformLayout();
            this.gboxDireccion.ResumeLayout(false);
            this.gboxDireccion.PerformLayout();
            this.gboxContacto.ResumeLayout(false);
            this.gboxContacto.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel pnlBarraPrincipal;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button btnAceptar;
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
        private System.Windows.Forms.Label lbNombrePrograma;
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
    }
}