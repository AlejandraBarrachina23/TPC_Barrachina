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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Usuario));
            this.lblCodigoUsuario = new System.Windows.Forms.Label();
            this.textBox14 = new System.Windows.Forms.TextBox();
            this.lblConstrasenia = new System.Windows.Forms.Label();
            this.lblNombre = new System.Windows.Forms.Label();
            this.txtbNombre = new System.Windows.Forms.TextBox();
            this.pnlBarraPrincipal = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.gboxSectorDesignado = new System.Windows.Forms.GroupBox();
            this.lblDeposito = new System.Windows.Forms.CheckBox();
            this.lblAdministracion = new System.Windows.Forms.CheckBox();
            this.lblVentas = new System.Windows.Forms.CheckBox();
            this.lblCompra = new System.Windows.Forms.CheckBox();
            this.lblNombreEmpleado = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
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
            this.pnlBarraPrincipal.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(115)))), ((int)(((byte)(149)))));
            this.pnlBarraPrincipal.Controls.Add(this.label1);
            this.pnlBarraPrincipal.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlBarraPrincipal.Location = new System.Drawing.Point(0, 0);
            this.pnlBarraPrincipal.Name = "pnlBarraPrincipal";
            this.pnlBarraPrincipal.Size = new System.Drawing.Size(340, 41);
            this.pnlBarraPrincipal.TabIndex = 64;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Bebas", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(138, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(69, 23);
            this.label1.TabIndex = 10;
            this.label1.Text = "USUARIO";
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
            this.gboxSectorDesignado.Font = new System.Drawing.Font("Oswald Regular", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
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
            this.lblDeposito.Size = new System.Drawing.Size(69, 21);
            this.lblDeposito.TabIndex = 0;
            this.lblDeposito.Text = "Depósito";
            this.lblDeposito.UseVisualStyleBackColor = true;
            // 
            // lblAdministracion
            // 
            this.lblAdministracion.AutoSize = true;
            this.lblAdministracion.Location = new System.Drawing.Point(46, 54);
            this.lblAdministracion.Name = "lblAdministracion";
            this.lblAdministracion.Size = new System.Drawing.Size(99, 21);
            this.lblAdministracion.TabIndex = 0;
            this.lblAdministracion.Text = "Administración";
            this.lblAdministracion.UseVisualStyleBackColor = true;
            // 
            // lblVentas
            // 
            this.lblVentas.AutoSize = true;
            this.lblVentas.Location = new System.Drawing.Point(152, 28);
            this.lblVentas.Name = "lblVentas";
            this.lblVentas.Size = new System.Drawing.Size(60, 21);
            this.lblVentas.TabIndex = 0;
            this.lblVentas.Text = "Ventas";
            this.lblVentas.UseVisualStyleBackColor = true;
            // 
            // lblCompra
            // 
            this.lblCompra.AutoSize = true;
            this.lblCompra.Location = new System.Drawing.Point(46, 28);
            this.lblCompra.Name = "lblCompra";
            this.lblCompra.Size = new System.Drawing.Size(65, 21);
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
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(115)))), ((int)(((byte)(149)))));
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Bebas", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Image = ((System.Drawing.Image)(resources.GetObject("button1.Image")));
            this.button1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button1.Location = new System.Drawing.Point(182, 298);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(94, 37);
            this.button1.TabIndex = 75;
            this.button1.Text = "Cancelar";
            this.button1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button1.UseVisualStyleBackColor = false;
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(115)))), ((int)(((byte)(149)))));
            this.button2.FlatAppearance.BorderSize = 0;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("Bebas", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.ForeColor = System.Drawing.Color.White;
            this.button2.Image = ((System.Drawing.Image)(resources.GetObject("button2.Image")));
            this.button2.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button2.Location = new System.Drawing.Point(71, 298);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(94, 37);
            this.button2.TabIndex = 76;
            this.button2.Text = "Aceptar";
            this.button2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button2.UseVisualStyleBackColor = false;
            // 
            // Usuario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(340, 359);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.gboxSectorDesignado);
            this.Controls.Add(this.lblNombreEmpleado);
            this.Controls.Add(this.lblCodigoUsuario);
            this.Controls.Add(this.textBox14);
            this.Controls.Add(this.lblConstrasenia);
            this.Controls.Add(this.lblNombre);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.txtbNombre);
            this.Controls.Add(this.pnlBarraPrincipal);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Usuario";
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
        private System.Windows.Forms.Label lblConstrasenia;
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.TextBox txtbNombre;
        private System.Windows.Forms.Panel pnlBarraPrincipal;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.GroupBox gboxSectorDesignado;
        private System.Windows.Forms.CheckBox lblDeposito;
        private System.Windows.Forms.CheckBox lblAdministracion;
        private System.Windows.Forms.CheckBox lblVentas;
        private System.Windows.Forms.CheckBox lblCompra;
        private System.Windows.Forms.Label lblNombreEmpleado;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
    }
}