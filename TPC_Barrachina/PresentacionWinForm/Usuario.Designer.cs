namespace PresentacionWinForm
{
    partial class Usuario
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
            this.lblCodigoUsuario = new System.Windows.Forms.Label();
            this.textBox14 = new System.Windows.Forms.TextBox();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnAceptar = new System.Windows.Forms.Button();
            this.lblConstrasenia = new System.Windows.Forms.Label();
            this.lblNombre = new System.Windows.Forms.Label();
            this.txtbNombre = new System.Windows.Forms.TextBox();
            this.pnlBarraPrincipal = new System.Windows.Forms.Panel();
            this.lbNombrePrograma = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.gboxSectorDesignado = new System.Windows.Forms.GroupBox();
            this.lblDeposito = new System.Windows.Forms.CheckBox();
            this.lblAdministracion = new System.Windows.Forms.CheckBox();
            this.lblVentas = new System.Windows.Forms.CheckBox();
            this.lblCompra = new System.Windows.Forms.CheckBox();
            this.lblNombreEmpleado = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.pnlBarraPrincipal.SuspendLayout();
            this.gboxSectorDesignado.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblCodigoUsuario
            // 
            this.lblCodigoUsuario.AutoSize = true;
            this.lblCodigoUsuario.Location = new System.Drawing.Point(30, 89);
            this.lblCodigoUsuario.Name = "lblCodigoUsuario";
            this.lblCodigoUsuario.Size = new System.Drawing.Size(79, 13);
            this.lblCodigoUsuario.TabIndex = 72;
            this.lblCodigoUsuario.Text = "Código Usuario";
            // 
            // textBox14
            // 
            this.textBox14.Location = new System.Drawing.Point(134, 86);
            this.textBox14.Name = "textBox14";
            this.textBox14.Size = new System.Drawing.Size(173, 20);
            this.textBox14.TabIndex = 71;
            // 
            // btnCancelar
            // 
            this.btnCancelar.Location = new System.Drawing.Point(179, 299);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(97, 29);
            this.btnCancelar.TabIndex = 69;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            // 
            // btnAceptar
            // 
            this.btnAceptar.Location = new System.Drawing.Point(73, 299);
            this.btnAceptar.Name = "btnAceptar";
            this.btnAceptar.Size = new System.Drawing.Size(100, 29);
            this.btnAceptar.TabIndex = 70;
            this.btnAceptar.Text = "Aceptar";
            this.btnAceptar.UseVisualStyleBackColor = true;
            // 
            // lblConstrasenia
            // 
            this.lblConstrasenia.AutoSize = true;
            this.lblConstrasenia.Location = new System.Drawing.Point(30, 140);
            this.lblConstrasenia.Name = "lblConstrasenia";
            this.lblConstrasenia.Size = new System.Drawing.Size(66, 13);
            this.lblConstrasenia.TabIndex = 67;
            this.lblConstrasenia.Text = "Constraseña";
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.Location = new System.Drawing.Point(30, 113);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(44, 13);
            this.lblNombre.TabIndex = 68;
            this.lblNombre.Text = "Nombre";
            // 
            // txtbNombre
            // 
            this.txtbNombre.Location = new System.Drawing.Point(134, 113);
            this.txtbNombre.Name = "txtbNombre";
            this.txtbNombre.Size = new System.Drawing.Size(173, 20);
            this.txtbNombre.TabIndex = 66;
            // 
            // pnlBarraPrincipal
            // 
            this.pnlBarraPrincipal.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.pnlBarraPrincipal.Controls.Add(this.lbNombrePrograma);
            this.pnlBarraPrincipal.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlBarraPrincipal.Location = new System.Drawing.Point(0, 0);
            this.pnlBarraPrincipal.Name = "pnlBarraPrincipal";
            this.pnlBarraPrincipal.Size = new System.Drawing.Size(340, 41);
            this.pnlBarraPrincipal.TabIndex = 64;
            // 
            // lbNombrePrograma
            // 
            this.lbNombrePrograma.AutoSize = true;
            this.lbNombrePrograma.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbNombrePrograma.Location = new System.Drawing.Point(107, 15);
            this.lbNombrePrograma.Name = "lbNombrePrograma";
            this.lbNombrePrograma.Size = new System.Drawing.Size(110, 13);
            this.lbNombrePrograma.TabIndex = 9;
            this.lbNombrePrograma.Text = "NUEVO USUARIO";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(134, 137);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(173, 20);
            this.textBox1.TabIndex = 66;
            // 
            // gboxSectorDesignado
            // 
            this.gboxSectorDesignado.Controls.Add(this.lblDeposito);
            this.gboxSectorDesignado.Controls.Add(this.lblAdministracion);
            this.gboxSectorDesignado.Controls.Add(this.lblVentas);
            this.gboxSectorDesignado.Controls.Add(this.lblCompra);
            this.gboxSectorDesignado.Location = new System.Drawing.Point(30, 179);
            this.gboxSectorDesignado.Name = "gboxSectorDesignado";
            this.gboxSectorDesignado.Size = new System.Drawing.Size(287, 87);
            this.gboxSectorDesignado.TabIndex = 73;
            this.gboxSectorDesignado.TabStop = false;
            this.gboxSectorDesignado.Text = "Sector Designado";
            // 
            // lblDeposito
            // 
            this.lblDeposito.AutoSize = true;
            this.lblDeposito.Location = new System.Drawing.Point(152, 54);
            this.lblDeposito.Name = "lblDeposito";
            this.lblDeposito.Size = new System.Drawing.Size(68, 17);
            this.lblDeposito.TabIndex = 0;
            this.lblDeposito.Text = "Depósito";
            this.lblDeposito.UseVisualStyleBackColor = true;
            // 
            // lblAdministracion
            // 
            this.lblAdministracion.AutoSize = true;
            this.lblAdministracion.Location = new System.Drawing.Point(46, 54);
            this.lblAdministracion.Name = "lblAdministracion";
            this.lblAdministracion.Size = new System.Drawing.Size(94, 17);
            this.lblAdministracion.TabIndex = 0;
            this.lblAdministracion.Text = "Administración";
            this.lblAdministracion.UseVisualStyleBackColor = true;
            // 
            // lblVentas
            // 
            this.lblVentas.AutoSize = true;
            this.lblVentas.Location = new System.Drawing.Point(152, 28);
            this.lblVentas.Name = "lblVentas";
            this.lblVentas.Size = new System.Drawing.Size(59, 17);
            this.lblVentas.TabIndex = 0;
            this.lblVentas.Text = "Ventas";
            this.lblVentas.UseVisualStyleBackColor = true;
            // 
            // lblCompra
            // 
            this.lblCompra.AutoSize = true;
            this.lblCompra.Location = new System.Drawing.Point(46, 28);
            this.lblCompra.Name = "lblCompra";
            this.lblCompra.Size = new System.Drawing.Size(62, 17);
            this.lblCompra.TabIndex = 0;
            this.lblCompra.Text = "Compra";
            this.lblCompra.UseVisualStyleBackColor = true;
            // 
            // lblNombreEmpleado
            // 
            this.lblNombreEmpleado.AutoSize = true;
            this.lblNombreEmpleado.Location = new System.Drawing.Point(29, 63);
            this.lblNombreEmpleado.Name = "lblNombreEmpleado";
            this.lblNombreEmpleado.Size = new System.Drawing.Size(94, 13);
            this.lblNombreEmpleado.TabIndex = 72;
            this.lblNombreEmpleado.Text = "Nombre Empleado";
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(134, 60);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(173, 21);
            this.comboBox1.TabIndex = 74;
            // 
            // NuevoUsuario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(340, 359);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.gboxSectorDesignado);
            this.Controls.Add(this.lblNombreEmpleado);
            this.Controls.Add(this.lblCodigoUsuario);
            this.Controls.Add(this.textBox14);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnAceptar);
            this.Controls.Add(this.lblConstrasenia);
            this.Controls.Add(this.lblNombre);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.txtbNombre);
            this.Controls.Add(this.pnlBarraPrincipal);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "NuevoUsuario";
            this.Text = "NuevoUsuario";
            this.pnlBarraPrincipal.ResumeLayout(false);
            this.pnlBarraPrincipal.PerformLayout();
            this.gboxSectorDesignado.ResumeLayout(false);
            this.gboxSectorDesignado.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblCodigoUsuario;
        private System.Windows.Forms.TextBox textBox14;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button btnAceptar;
        private System.Windows.Forms.Label lblConstrasenia;
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.TextBox txtbNombre;
        private System.Windows.Forms.Panel pnlBarraPrincipal;
        private System.Windows.Forms.Label lbNombrePrograma;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.GroupBox gboxSectorDesignado;
        private System.Windows.Forms.CheckBox lblDeposito;
        private System.Windows.Forms.CheckBox lblAdministracion;
        private System.Windows.Forms.CheckBox lblVentas;
        private System.Windows.Forms.CheckBox lblCompra;
        private System.Windows.Forms.Label lblNombreEmpleado;
        private System.Windows.Forms.ComboBox comboBox1;
    }
}