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
            this.pnlBarraPrincipal = new System.Windows.Forms.Panel();
            this.lbMotivoDevolucion = new System.Windows.Forms.Label();
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
            this.pnlBarraPrincipal.SuspendLayout();
            this.gboxOpciones.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlBarraPrincipal
            // 
            this.pnlBarraPrincipal.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.pnlBarraPrincipal.Controls.Add(this.lbMotivoDevolucion);
            this.pnlBarraPrincipal.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlBarraPrincipal.Location = new System.Drawing.Point(0, 0);
            this.pnlBarraPrincipal.Name = "pnlBarraPrincipal";
            this.pnlBarraPrincipal.Size = new System.Drawing.Size(380, 41);
            this.pnlBarraPrincipal.TabIndex = 3;
            // 
            // lbMotivoDevolucion
            // 
            this.lbMotivoDevolucion.AutoSize = true;
            this.lbMotivoDevolucion.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbMotivoDevolucion.Location = new System.Drawing.Point(127, 15);
            this.lbMotivoDevolucion.Name = "lbMotivoDevolucion";
            this.lbMotivoDevolucion.Size = new System.Drawing.Size(139, 13);
            this.lbMotivoDevolucion.TabIndex = 8;
            this.lbMotivoDevolucion.Text = "MOTIVO DEVOLUCION";
            // 
            // tboxObservaciones
            // 
            this.tboxObservaciones.Location = new System.Drawing.Point(24, 244);
            this.tboxObservaciones.Multiline = true;
            this.tboxObservaciones.Name = "tboxObservaciones";
            this.tboxObservaciones.Size = new System.Drawing.Size(334, 107);
            this.tboxObservaciones.TabIndex = 4;
            // 
            // lblObservaciones
            // 
            this.lblObservaciones.AutoSize = true;
            this.lblObservaciones.Location = new System.Drawing.Point(25, 221);
            this.lblObservaciones.Name = "lblObservaciones";
            this.lblObservaciones.Size = new System.Drawing.Size(81, 13);
            this.lblObservaciones.TabIndex = 5;
            this.lblObservaciones.Text = "Observaciones:";
            // 
            // rbtnMercaderiaVencida
            // 
            this.rbtnMercaderiaVencida.AutoSize = true;
            this.rbtnMercaderiaVencida.Location = new System.Drawing.Point(12, 25);
            this.rbtnMercaderiaVencida.Name = "rbtnMercaderiaVencida";
            this.rbtnMercaderiaVencida.Size = new System.Drawing.Size(122, 17);
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
            this.rbtnMercaderiaMalEstado.Size = new System.Drawing.Size(147, 17);
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
            this.rbtnDisconformidadPrecio.Size = new System.Drawing.Size(152, 17);
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
            this.rbtnEquivocacionCliente.Size = new System.Drawing.Size(139, 17);
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
            this.rbtnOtros.Size = new System.Drawing.Size(50, 17);
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
            this.gboxOpciones.Location = new System.Drawing.Point(24, 74);
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
            this.rbtnEquivocacionUsuario.Size = new System.Drawing.Size(142, 17);
            this.rbtnEquivocacionUsuario.TabIndex = 6;
            this.rbtnEquivocacionUsuario.TabStop = true;
            this.rbtnEquivocacionUsuario.Text = "Equivocación de usuario";
            this.rbtnEquivocacionUsuario.UseVisualStyleBackColor = true;
            // 
            // btnAceptar
            // 
            this.btnAceptar.Location = new System.Drawing.Point(86, 371);
            this.btnAceptar.Name = "btnAceptar";
            this.btnAceptar.Size = new System.Drawing.Size(102, 35);
            this.btnAceptar.TabIndex = 9;
            this.btnAceptar.Text = "Aceptar";
            this.btnAceptar.UseVisualStyleBackColor = true;
            // 
            // btnCancelar
            // 
            this.btnCancelar.Location = new System.Drawing.Point(204, 371);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(102, 35);
            this.btnCancelar.TabIndex = 9;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            // 
            // MotivoDevolucion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(380, 434);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnAceptar);
            this.Controls.Add(this.gboxOpciones);
            this.Controls.Add(this.lblObservaciones);
            this.Controls.Add(this.tboxObservaciones);
            this.Controls.Add(this.pnlBarraPrincipal);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "MotivoDevolucion";
            this.Text = "MotivoDevolucion";
            this.Load += new System.EventHandler(this.MotivoDevolucion_Load);
            this.pnlBarraPrincipal.ResumeLayout(false);
            this.pnlBarraPrincipal.PerformLayout();
            this.gboxOpciones.ResumeLayout(false);
            this.gboxOpciones.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel pnlBarraPrincipal;
        private System.Windows.Forms.Label lbMotivoDevolucion;
        private System.Windows.Forms.TextBox tboxObservaciones;
        private System.Windows.Forms.Label lblObservaciones;
        private System.Windows.Forms.RadioButton rbtnMercaderiaVencida;
        private System.Windows.Forms.RadioButton rbtnMercaderiaMalEstado;
        private System.Windows.Forms.RadioButton rbtnDisconformidadPrecio;
        private System.Windows.Forms.RadioButton rbtnEquivocacionCliente;
        private System.Windows.Forms.RadioButton rbtnOtros;
        private System.Windows.Forms.GroupBox gboxOpciones;
        private System.Windows.Forms.Button btnAceptar;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.RadioButton rbtnEquivocacionUsuario;
    }
}