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
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.rbtnMercaderiaVencida = new System.Windows.Forms.RadioButton();
            this.rbtnMercaderiaMalEstado = new System.Windows.Forms.RadioButton();
            this.rbtnDisconformidadPrecio = new System.Windows.Forms.RadioButton();
            this.rbtnEquivocacionCliente = new System.Windows.Forms.RadioButton();
            this.rbtnOtros = new System.Windows.Forms.RadioButton();
            this.gboxOpciones = new System.Windows.Forms.GroupBox();
            this.rbtnEquivocacionUsuario = new System.Windows.Forms.RadioButton();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
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
            this.pnlBarraPrincipal.Size = new System.Drawing.Size(382, 41);
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
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(24, 244);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(334, 107);
            this.textBox1.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(25, 221);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(81, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Observaciones:";
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
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(86, 371);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(102, 35);
            this.button1.TabIndex = 9;
            this.button1.Text = "Aceptar";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(204, 371);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(102, 35);
            this.button2.TabIndex = 9;
            this.button2.Text = "Cancelar";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // MotivoDevolucion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(382, 442);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.gboxOpciones);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox1);
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
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RadioButton rbtnMercaderiaVencida;
        private System.Windows.Forms.RadioButton rbtnMercaderiaMalEstado;
        private System.Windows.Forms.RadioButton rbtnDisconformidadPrecio;
        private System.Windows.Forms.RadioButton rbtnEquivocacionCliente;
        private System.Windows.Forms.RadioButton rbtnOtros;
        private System.Windows.Forms.GroupBox gboxOpciones;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.RadioButton rbtnEquivocacionUsuario;
    }
}