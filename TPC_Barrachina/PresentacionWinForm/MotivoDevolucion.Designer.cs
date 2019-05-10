namespace PresentacionWinForm
{
    partial class MotivoDevolucion
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MotivoDevolucion));
            this.pnlBarraPrincipal = new System.Windows.Forms.Panel();
            this.lbNombrePrograma = new System.Windows.Forms.Label();
            this.tboxObservaciones = new System.Windows.Forms.TextBox();
            this.lblObservaciones = new System.Windows.Forms.Label();
            this.rbtnMercaderiaVencida = new System.Windows.Forms.RadioButton();
            this.rbtnMercaderiaMalEstado = new System.Windows.Forms.RadioButton();
            this.rbtnDisconformidadPrecio = new System.Windows.Forms.RadioButton();
            this.rbtnEquivocacionCliente = new System.Windows.Forms.RadioButton();
            this.rbtnOtros = new System.Windows.Forms.RadioButton();
            this.gboxOpciones = new System.Windows.Forms.GroupBox();
            this.rbtnEquivocacionUsuario = new System.Windows.Forms.RadioButton();
            this.btnAceptar = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pnlBarraPrincipal.SuspendLayout();
            this.gboxOpciones.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlBarraPrincipal
            // 
            this.pnlBarraPrincipal.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(115)))), ((int)(((byte)(149)))));
            this.pnlBarraPrincipal.Controls.Add(this.lbNombrePrograma);
            this.pnlBarraPrincipal.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlBarraPrincipal.Location = new System.Drawing.Point(0, 0);
            this.pnlBarraPrincipal.Name = "pnlBarraPrincipal";
            this.pnlBarraPrincipal.Size = new System.Drawing.Size(376, 41);
            this.pnlBarraPrincipal.TabIndex = 3;
            // 
            // lbNombrePrograma
            // 
            this.lbNombrePrograma.AutoSize = true;
            this.lbNombrePrograma.Font = new System.Drawing.Font("Bebas", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbNombrePrograma.ForeColor = System.Drawing.Color.White;
            this.lbNombrePrograma.Location = new System.Drawing.Point(116, 9);
            this.lbNombrePrograma.Name = "lbNombrePrograma";
            this.lbNombrePrograma.Size = new System.Drawing.Size(152, 23);
            this.lbNombrePrograma.TabIndex = 9;
            this.lbNombrePrograma.Text = "MOTIVO DEVOLUCION";
            // 
            // tboxObservaciones
            // 
            this.tboxObservaciones.Location = new System.Drawing.Point(20, 198);
            this.tboxObservaciones.Multiline = true;
            this.tboxObservaciones.Name = "tboxObservaciones";
            this.tboxObservaciones.Size = new System.Drawing.Size(334, 107);
            this.tboxObservaciones.TabIndex = 4;
            // 
            // lblObservaciones
            // 
            this.lblObservaciones.AutoSize = true;
            this.lblObservaciones.Font = new System.Drawing.Font("Oswald", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblObservaciones.Location = new System.Drawing.Point(21, 175);
            this.lblObservaciones.Name = "lblObservaciones";
            this.lblObservaciones.Size = new System.Drawing.Size(77, 17);
            this.lblObservaciones.TabIndex = 5;
            this.lblObservaciones.Text = "Observaciones:";
            // 
            // rbtnMercaderiaVencida
            // 
            this.rbtnMercaderiaVencida.AutoSize = true;
            this.rbtnMercaderiaVencida.Location = new System.Drawing.Point(12, 25);
            this.rbtnMercaderiaVencida.Name = "rbtnMercaderiaVencida";
            this.rbtnMercaderiaVencida.Size = new System.Drawing.Size(120, 21);
            this.rbtnMercaderiaVencida.TabIndex = 6;
            this.rbtnMercaderiaVencida.TabStop = true;
            this.rbtnMercaderiaVencida.Text = "Mercadería Vencida";
            this.rbtnMercaderiaVencida.UseVisualStyleBackColor = true;
            // 
            // rbtnMercaderiaMalEstado
            // 
            this.rbtnMercaderiaMalEstado.AutoSize = true;
            this.rbtnMercaderiaMalEstado.Location = new System.Drawing.Point(172, 25);
            this.rbtnMercaderiaMalEstado.Name = "rbtnMercaderiaMalEstado";
            this.rbtnMercaderiaMalEstado.Size = new System.Drawing.Size(149, 21);
            this.rbtnMercaderiaMalEstado.TabIndex = 6;
            this.rbtnMercaderiaMalEstado.TabStop = true;
            this.rbtnMercaderiaMalEstado.Text = "Mercaderia en mal estado";
            this.rbtnMercaderiaMalEstado.UseVisualStyleBackColor = true;
            // 
            // rbtnDisconformidadPrecio
            // 
            this.rbtnDisconformidadPrecio.AutoSize = true;
            this.rbtnDisconformidadPrecio.Location = new System.Drawing.Point(12, 97);
            this.rbtnDisconformidadPrecio.Name = "rbtnDisconformidadPrecio";
            this.rbtnDisconformidadPrecio.Size = new System.Drawing.Size(154, 21);
            this.rbtnDisconformidadPrecio.TabIndex = 6;
            this.rbtnDisconformidadPrecio.TabStop = true;
            this.rbtnDisconformidadPrecio.Text = "Disconformidad con Precio";
            this.rbtnDisconformidadPrecio.UseVisualStyleBackColor = true;
            // 
            // rbtnEquivocacionCliente
            // 
            this.rbtnEquivocacionCliente.AutoSize = true;
            this.rbtnEquivocacionCliente.Location = new System.Drawing.Point(12, 61);
            this.rbtnEquivocacionCliente.Name = "rbtnEquivocacionCliente";
            this.rbtnEquivocacionCliente.Size = new System.Drawing.Size(136, 21);
            this.rbtnEquivocacionCliente.TabIndex = 6;
            this.rbtnEquivocacionCliente.TabStop = true;
            this.rbtnEquivocacionCliente.Text = "Equivocación de cliente";
            this.rbtnEquivocacionCliente.UseVisualStyleBackColor = true;
            // 
            // rbtnOtros
            // 
            this.rbtnOtros.AutoSize = true;
            this.rbtnOtros.Location = new System.Drawing.Point(172, 97);
            this.rbtnOtros.Name = "rbtnOtros";
            this.rbtnOtros.Size = new System.Drawing.Size(52, 21);
            this.rbtnOtros.TabIndex = 7;
            this.rbtnOtros.TabStop = true;
            this.rbtnOtros.Text = "Otros";
            this.rbtnOtros.UseVisualStyleBackColor = true;
            // 
            // gboxOpciones
            // 
            this.gboxOpciones.Controls.Add(this.rbtnEquivocacionUsuario);
            this.gboxOpciones.Controls.Add(this.rbtnOtros);
            this.gboxOpciones.Controls.Add(this.rbtnEquivocacionCliente);
            this.gboxOpciones.Controls.Add(this.rbtnDisconformidadPrecio);
            this.gboxOpciones.Controls.Add(this.rbtnMercaderiaMalEstado);
            this.gboxOpciones.Controls.Add(this.rbtnMercaderiaVencida);
            this.gboxOpciones.Font = new System.Drawing.Font("Oswald Regular", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gboxOpciones.Location = new System.Drawing.Point(24, 29);
            this.gboxOpciones.Name = "gboxOpciones";
            this.gboxOpciones.Size = new System.Drawing.Size(334, 134);
            this.gboxOpciones.TabIndex = 8;
            this.gboxOpciones.TabStop = false;
            this.gboxOpciones.Text = "Opciones";
            // 
            // rbtnEquivocacionUsuario
            // 
            this.rbtnEquivocacionUsuario.AutoSize = true;
            this.rbtnEquivocacionUsuario.Location = new System.Drawing.Point(172, 61);
            this.rbtnEquivocacionUsuario.Name = "rbtnEquivocacionUsuario";
            this.rbtnEquivocacionUsuario.Size = new System.Drawing.Size(141, 21);
            this.rbtnEquivocacionUsuario.TabIndex = 6;
            this.rbtnEquivocacionUsuario.TabStop = true;
            this.rbtnEquivocacionUsuario.Text = "Equivocación de usuario";
            this.rbtnEquivocacionUsuario.UseVisualStyleBackColor = true;
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
            this.btnAceptar.Location = new System.Drawing.Point(96, 322);
            this.btnAceptar.Name = "btnAceptar";
            this.btnAceptar.Size = new System.Drawing.Size(94, 37);
            this.btnAceptar.TabIndex = 10;
            this.btnAceptar.Text = "Aceptar";
            this.btnAceptar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnAceptar.UseVisualStyleBackColor = false;
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
            this.btnCancelar.Location = new System.Drawing.Point(196, 322);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(94, 37);
            this.btnCancelar.TabIndex = 11;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnCancelar.UseVisualStyleBackColor = false;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.gboxOpciones);
            this.panel1.Controls.Add(this.btnCancelar);
            this.panel1.Controls.Add(this.lblObservaciones);
            this.panel1.Controls.Add(this.btnAceptar);
            this.panel1.Controls.Add(this.tboxObservaciones);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 35);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(376, 392);
            this.panel1.TabIndex = 12;
            // 
            // MotivoDevolucion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(376, 427);
            this.Controls.Add(this.pnlBarraPrincipal);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "MotivoDevolucion";
            this.Text = "MotivoDevolucion";
            this.Load += new System.EventHandler(this.MotivoDevolucion_Load);
            this.pnlBarraPrincipal.ResumeLayout(false);
            this.pnlBarraPrincipal.PerformLayout();
            this.gboxOpciones.ResumeLayout(false);
            this.gboxOpciones.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlBarraPrincipal;
        private System.Windows.Forms.TextBox tboxObservaciones;
        private System.Windows.Forms.Label lblObservaciones;
        private System.Windows.Forms.RadioButton rbtnMercaderiaVencida;
        private System.Windows.Forms.RadioButton rbtnMercaderiaMalEstado;
        private System.Windows.Forms.RadioButton rbtnDisconformidadPrecio;
        private System.Windows.Forms.RadioButton rbtnEquivocacionCliente;
        private System.Windows.Forms.RadioButton rbtnOtros;
        private System.Windows.Forms.GroupBox gboxOpciones;
        private System.Windows.Forms.RadioButton rbtnEquivocacionUsuario;
        private System.Windows.Forms.Button btnAceptar;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Label lbNombrePrograma;
        private System.Windows.Forms.Panel panel1;
    }
}