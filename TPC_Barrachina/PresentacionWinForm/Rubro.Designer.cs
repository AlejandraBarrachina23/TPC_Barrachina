namespace PresentacionWinForm
{
    partial class Rubro
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
            this.lbNombrePrograma = new System.Windows.Forms.Label();
            this.pnlBarraPrincipal = new System.Windows.Forms.Panel();
            this.tboxNombre = new System.Windows.Forms.TextBox();
            this.lblNombre = new System.Windows.Forms.Label();
            this.btnAceptar = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.tboxCodigoRubro = new System.Windows.Forms.TextBox();
            this.lblCodigoRubro = new System.Windows.Forms.Label();
            this.pnlBarraPrincipal.SuspendLayout();
            this.SuspendLayout();
            // 
            // lbNombrePrograma
            // 
            this.lbNombrePrograma.AutoSize = true;
            this.lbNombrePrograma.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbNombrePrograma.Location = new System.Drawing.Point(160, 15);
            this.lbNombrePrograma.Name = "lbNombrePrograma";
            this.lbNombrePrograma.Size = new System.Drawing.Size(98, 13);
            this.lbNombrePrograma.TabIndex = 9;
            this.lbNombrePrograma.Text = "NUEVO RUBRO";
            // 
            // pnlBarraPrincipal
            // 
            this.pnlBarraPrincipal.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.pnlBarraPrincipal.Controls.Add(this.lbNombrePrograma);
            this.pnlBarraPrincipal.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlBarraPrincipal.Location = new System.Drawing.Point(0, 0);
            this.pnlBarraPrincipal.Name = "pnlBarraPrincipal";
            this.pnlBarraPrincipal.Size = new System.Drawing.Size(407, 41);
            this.pnlBarraPrincipal.TabIndex = 40;
            // 
            // tboxNombre
            // 
            this.tboxNombre.Location = new System.Drawing.Point(154, 83);
            this.tboxNombre.Name = "tboxNombre";
            this.tboxNombre.Size = new System.Drawing.Size(173, 20);
            this.tboxNombre.TabIndex = 43;
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.Location = new System.Drawing.Point(56, 86);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(44, 13);
            this.lblNombre.TabIndex = 47;
            this.lblNombre.Text = "Nombre";
            // 
            // btnAceptar
            // 
            this.btnAceptar.Location = new System.Drawing.Point(91, 124);
            this.btnAceptar.Name = "btnAceptar";
            this.btnAceptar.Size = new System.Drawing.Size(100, 29);
            this.btnAceptar.TabIndex = 50;
            this.btnAceptar.Text = "Aceptar";
            this.btnAceptar.UseVisualStyleBackColor = true;
            // 
            // btnCancelar
            // 
            this.btnCancelar.Location = new System.Drawing.Point(207, 124);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(97, 29);
            this.btnCancelar.TabIndex = 49;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            // 
            // tboxCodigoRubro
            // 
            this.tboxCodigoRubro.Location = new System.Drawing.Point(154, 59);
            this.tboxCodigoRubro.Name = "tboxCodigoRubro";
            this.tboxCodigoRubro.Size = new System.Drawing.Size(173, 20);
            this.tboxCodigoRubro.TabIndex = 53;
            // 
            // lblCodigoRubro
            // 
            this.lblCodigoRubro.AutoSize = true;
            this.lblCodigoRubro.Location = new System.Drawing.Point(56, 62);
            this.lblCodigoRubro.Name = "lblCodigoRubro";
            this.lblCodigoRubro.Size = new System.Drawing.Size(72, 13);
            this.lblCodigoRubro.TabIndex = 54;
            this.lblCodigoRubro.Text = "Código Rubro";
            // 
            // NuevoRubro
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(407, 174);
            this.Controls.Add(this.lblCodigoRubro);
            this.Controls.Add(this.tboxCodigoRubro);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnAceptar);
            this.Controls.Add(this.lblNombre);
            this.Controls.Add(this.tboxNombre);
            this.Controls.Add(this.pnlBarraPrincipal);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "NuevoRubro";
            this.Text = "NuevoRubro";
            this.pnlBarraPrincipal.ResumeLayout(false);
            this.pnlBarraPrincipal.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbNombrePrograma;
        private System.Windows.Forms.Panel pnlBarraPrincipal;
        private System.Windows.Forms.TextBox tboxNombre;
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.Button btnAceptar;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.TextBox tboxCodigoRubro;
        private System.Windows.Forms.Label lblCodigoRubro;
    }
}