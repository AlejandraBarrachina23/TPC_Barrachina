namespace PresentacionWinForm
{
    partial class TipoProducto
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
            this.lblCodigoTipo = new System.Windows.Forms.Label();
            this.tboxCodigoTipo = new System.Windows.Forms.TextBox();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnAceptar = new System.Windows.Forms.Button();
            this.lblDescripcion = new System.Windows.Forms.Label();
            this.lblNombre = new System.Windows.Forms.Label();
            this.tboxDescripcion = new System.Windows.Forms.TextBox();
            this.tboxNombre = new System.Windows.Forms.TextBox();
            this.pnlBarraPrincipal = new System.Windows.Forms.Panel();
            this.lbNombrePrograma = new System.Windows.Forms.Label();
            this.pnlBarraPrincipal.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblCodigoTipo
            // 
            this.lblCodigoTipo.AutoSize = true;
            this.lblCodigoTipo.Location = new System.Drawing.Point(42, 60);
            this.lblCodigoTipo.Name = "lblCodigoTipo";
            this.lblCodigoTipo.Size = new System.Drawing.Size(64, 13);
            this.lblCodigoTipo.TabIndex = 72;
            this.lblCodigoTipo.Text = "Código Tipo";
            // 
            // tboxCodigoTipo
            // 
            this.tboxCodigoTipo.Location = new System.Drawing.Point(140, 57);
            this.tboxCodigoTipo.Name = "tboxCodigoTipo";
            this.tboxCodigoTipo.Size = new System.Drawing.Size(173, 20);
            this.tboxCodigoTipo.TabIndex = 71;
            // 
            // btnCancelar
            // 
            this.btnCancelar.Location = new System.Drawing.Point(200, 164);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(97, 29);
            this.btnCancelar.TabIndex = 69;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            // 
            // btnAceptar
            // 
            this.btnAceptar.Location = new System.Drawing.Point(84, 164);
            this.btnAceptar.Name = "btnAceptar";
            this.btnAceptar.Size = new System.Drawing.Size(100, 29);
            this.btnAceptar.TabIndex = 70;
            this.btnAceptar.Text = "Aceptar";
            this.btnAceptar.UseVisualStyleBackColor = true;
            // 
            // lblDescripcion
            // 
            this.lblDescripcion.AutoSize = true;
            this.lblDescripcion.Location = new System.Drawing.Point(42, 111);
            this.lblDescripcion.Name = "lblDescripcion";
            this.lblDescripcion.Size = new System.Drawing.Size(63, 13);
            this.lblDescripcion.TabIndex = 67;
            this.lblDescripcion.Text = "Descripción";
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.Location = new System.Drawing.Point(42, 84);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(44, 13);
            this.lblNombre.TabIndex = 68;
            this.lblNombre.Text = "Nombre";
            // 
            // tboxDescripcion
            // 
            this.tboxDescripcion.Location = new System.Drawing.Point(140, 107);
            this.tboxDescripcion.Multiline = true;
            this.tboxDescripcion.Name = "tboxDescripcion";
            this.tboxDescripcion.Size = new System.Drawing.Size(173, 40);
            this.tboxDescripcion.TabIndex = 65;
            // 
            // tboxNombre
            // 
            this.tboxNombre.Location = new System.Drawing.Point(140, 81);
            this.tboxNombre.Name = "tboxNombre";
            this.tboxNombre.Size = new System.Drawing.Size(173, 20);
            this.tboxNombre.TabIndex = 66;
            // 
            // pnlBarraPrincipal
            // 
            this.pnlBarraPrincipal.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.pnlBarraPrincipal.Controls.Add(this.lbNombrePrograma);
            this.pnlBarraPrincipal.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlBarraPrincipal.Location = new System.Drawing.Point(0, 0);
            this.pnlBarraPrincipal.Name = "pnlBarraPrincipal";
            this.pnlBarraPrincipal.Size = new System.Drawing.Size(365, 41);
            this.pnlBarraPrincipal.TabIndex = 64;
            // 
            // lbNombrePrograma
            // 
            this.lbNombrePrograma.AutoSize = true;
            this.lbNombrePrograma.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbNombrePrograma.Location = new System.Drawing.Point(108, 15);
            this.lbNombrePrograma.Name = "lbNombrePrograma";
            this.lbNombrePrograma.Size = new System.Drawing.Size(156, 13);
            this.lbNombrePrograma.TabIndex = 9;
            this.lbNombrePrograma.Text = "NUEVO TIPO PRODUCTO";
            // 
            // NuevoTipoProducto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(365, 217);
            this.Controls.Add(this.lblCodigoTipo);
            this.Controls.Add(this.tboxCodigoTipo);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnAceptar);
            this.Controls.Add(this.lblDescripcion);
            this.Controls.Add(this.lblNombre);
            this.Controls.Add(this.tboxDescripcion);
            this.Controls.Add(this.tboxNombre);
            this.Controls.Add(this.pnlBarraPrincipal);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "NuevoTipoProducto";
            this.Text = "NuevoTipoProducto";
            this.pnlBarraPrincipal.ResumeLayout(false);
            this.pnlBarraPrincipal.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblCodigoTipo;
        private System.Windows.Forms.TextBox tboxCodigoTipo;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button btnAceptar;
        private System.Windows.Forms.Label lblDescripcion;
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.TextBox tboxDescripcion;
        private System.Windows.Forms.TextBox tboxNombre;
        private System.Windows.Forms.Panel pnlBarraPrincipal;
        private System.Windows.Forms.Label lbNombrePrograma;
    }
}