namespace PresentacionWinForm
{
    partial class Descuento
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
            this.lblCodigoDescuento = new System.Windows.Forms.Label();
            this.tboxCodigoDescuento = new System.Windows.Forms.TextBox();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnAceptar = new System.Windows.Forms.Button();
            this.lblDescripcion = new System.Windows.Forms.Label();
            this.lblNombre = new System.Windows.Forms.Label();
            this.tboxDescripcion = new System.Windows.Forms.TextBox();
            this.txtbNombre = new System.Windows.Forms.TextBox();
            this.pnlBarraPrincipal = new System.Windows.Forms.Panel();
            this.lbNombrePrograma = new System.Windows.Forms.Label();
            this.tboxPorcentaje = new System.Windows.Forms.TextBox();
            this.lblPorcentaje = new System.Windows.Forms.Label();
            this.pnlBarraPrincipal.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblCodigoDescuento
            // 
            this.lblCodigoDescuento.AutoSize = true;
            this.lblCodigoDescuento.Location = new System.Drawing.Point(22, 60);
            this.lblCodigoDescuento.Name = "lblCodigoDescuento";
            this.lblCodigoDescuento.Size = new System.Drawing.Size(95, 13);
            this.lblCodigoDescuento.TabIndex = 72;
            this.lblCodigoDescuento.Text = "Código Descuento";
            // 
            // tboxCodigoDescuento
            // 
            this.tboxCodigoDescuento.Location = new System.Drawing.Point(125, 57);
            this.tboxCodigoDescuento.Name = "tboxCodigoDescuento";
            this.tboxCodigoDescuento.Size = new System.Drawing.Size(173, 20);
            this.tboxCodigoDescuento.TabIndex = 71;
            // 
            // btnCancelar
            // 
            this.btnCancelar.Location = new System.Drawing.Point(181, 191);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(97, 29);
            this.btnCancelar.TabIndex = 69;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            // 
            // btnAceptar
            // 
            this.btnAceptar.Location = new System.Drawing.Point(65, 191);
            this.btnAceptar.Name = "btnAceptar";
            this.btnAceptar.Size = new System.Drawing.Size(100, 29);
            this.btnAceptar.TabIndex = 70;
            this.btnAceptar.Text = "Aceptar";
            this.btnAceptar.UseVisualStyleBackColor = true;
            // 
            // lblDescripcion
            // 
            this.lblDescripcion.AutoSize = true;
            this.lblDescripcion.Location = new System.Drawing.Point(22, 132);
            this.lblDescripcion.Name = "lblDescripcion";
            this.lblDescripcion.Size = new System.Drawing.Size(63, 13);
            this.lblDescripcion.TabIndex = 67;
            this.lblDescripcion.Text = "Descripción";
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.Location = new System.Drawing.Point(22, 84);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(44, 13);
            this.lblNombre.TabIndex = 68;
            this.lblNombre.Text = "Nombre";
            // 
            // tboxDescripcion
            // 
            this.tboxDescripcion.Location = new System.Drawing.Point(125, 132);
            this.tboxDescripcion.Multiline = true;
            this.tboxDescripcion.Name = "tboxDescripcion";
            this.tboxDescripcion.Size = new System.Drawing.Size(173, 40);
            this.tboxDescripcion.TabIndex = 65;
            // 
            // txtbNombre
            // 
            this.txtbNombre.Location = new System.Drawing.Point(125, 81);
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
            this.pnlBarraPrincipal.Size = new System.Drawing.Size(354, 41);
            this.pnlBarraPrincipal.TabIndex = 64;
            // 
            // lbNombrePrograma
            // 
            this.lbNombrePrograma.AutoSize = true;
            this.lbNombrePrograma.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbNombrePrograma.Location = new System.Drawing.Point(110, 15);
            this.lbNombrePrograma.Name = "lbNombrePrograma";
            this.lbNombrePrograma.Size = new System.Drawing.Size(130, 13);
            this.lbNombrePrograma.TabIndex = 9;
            this.lbNombrePrograma.Text = "NUEVO DESCUENTO";
            // 
            // tboxPorcentaje
            // 
            this.tboxPorcentaje.Location = new System.Drawing.Point(125, 107);
            this.tboxPorcentaje.Name = "tboxPorcentaje";
            this.tboxPorcentaje.Size = new System.Drawing.Size(173, 20);
            this.tboxPorcentaje.TabIndex = 73;
            // 
            // lblPorcentaje
            // 
            this.lblPorcentaje.AutoSize = true;
            this.lblPorcentaje.Location = new System.Drawing.Point(22, 110);
            this.lblPorcentaje.Name = "lblPorcentaje";
            this.lblPorcentaje.Size = new System.Drawing.Size(58, 13);
            this.lblPorcentaje.TabIndex = 68;
            this.lblPorcentaje.Text = "Porcentaje";
            // 
            // NuevoDescuento
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(354, 232);
            this.Controls.Add(this.tboxPorcentaje);
            this.Controls.Add(this.lblCodigoDescuento);
            this.Controls.Add(this.tboxCodigoDescuento);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnAceptar);
            this.Controls.Add(this.lblDescripcion);
            this.Controls.Add(this.lblPorcentaje);
            this.Controls.Add(this.lblNombre);
            this.Controls.Add(this.tboxDescripcion);
            this.Controls.Add(this.txtbNombre);
            this.Controls.Add(this.pnlBarraPrincipal);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "NuevoDescuento";
            this.Text = "TipoDescuento";
            this.pnlBarraPrincipal.ResumeLayout(false);
            this.pnlBarraPrincipal.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblCodigoDescuento;
        private System.Windows.Forms.TextBox tboxCodigoDescuento;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button btnAceptar;
        private System.Windows.Forms.Label lblDescripcion;
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.TextBox tboxDescripcion;
        private System.Windows.Forms.TextBox txtbNombre;
        private System.Windows.Forms.Panel pnlBarraPrincipal;
        private System.Windows.Forms.Label lbNombrePrograma;
        private System.Windows.Forms.TextBox tboxPorcentaje;
        private System.Windows.Forms.Label lblPorcentaje;
    }
}