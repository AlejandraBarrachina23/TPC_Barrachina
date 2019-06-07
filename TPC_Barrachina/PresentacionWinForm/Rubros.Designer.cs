namespace PresentacionWinForm
{
    partial class Rubros
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Rubros));
            this.pnlBarraPrincipal = new System.Windows.Forms.Panel();
            this.lblRubro = new System.Windows.Forms.Label();
            this.tboxNombre = new System.Windows.Forms.TextBox();
            this.lblNombre = new System.Windows.Forms.Label();
            this.lblCodigoRubro = new System.Windows.Forms.Label();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnAceptar = new System.Windows.Forms.Button();
            this.btnModificar = new System.Windows.Forms.Button();
            this.tboxCodigoRubro = new System.Windows.Forms.TextBox();
            this.pnlBarraPrincipal.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlBarraPrincipal
            // 
            this.pnlBarraPrincipal.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(115)))), ((int)(((byte)(149)))));
            this.pnlBarraPrincipal.Controls.Add(this.lblRubro);
            this.pnlBarraPrincipal.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlBarraPrincipal.Location = new System.Drawing.Point(0, 0);
            this.pnlBarraPrincipal.Name = "pnlBarraPrincipal";
            this.pnlBarraPrincipal.Size = new System.Drawing.Size(330, 41);
            this.pnlBarraPrincipal.TabIndex = 40;
            // 
            // lblRubro
            // 
            this.lblRubro.AutoSize = true;
            this.lblRubro.Font = new System.Drawing.Font("Bebas", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRubro.ForeColor = System.Drawing.Color.White;
            this.lblRubro.Location = new System.Drawing.Point(145, 10);
            this.lblRubro.Name = "lblRubro";
            this.lblRubro.Size = new System.Drawing.Size(50, 23);
            this.lblRubro.TabIndex = 10;
            this.lblRubro.Text = "RUBRO";
            // 
            // tboxNombre
            // 
            this.tboxNombre.Font = new System.Drawing.Font("Oswald Regular", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tboxNombre.Location = new System.Drawing.Point(114, 103);
            this.tboxNombre.Name = "tboxNombre";
            this.tboxNombre.Size = new System.Drawing.Size(173, 25);
            this.tboxNombre.TabIndex = 43;
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.Font = new System.Drawing.Font("Oswald Regular", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNombre.Location = new System.Drawing.Point(52, 109);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(45, 17);
            this.lblNombre.TabIndex = 47;
            this.lblNombre.Text = "Nombre";
            // 
            // lblCodigoRubro
            // 
            this.lblCodigoRubro.AutoSize = true;
            this.lblCodigoRubro.Font = new System.Drawing.Font("Oswald Regular", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCodigoRubro.Location = new System.Drawing.Point(23, 66);
            this.lblCodigoRubro.Name = "lblCodigoRubro";
            this.lblCodigoRubro.Size = new System.Drawing.Size(74, 17);
            this.lblCodigoRubro.TabIndex = 54;
            this.lblCodigoRubro.Text = "Código Rubro";
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
            this.btnCancelar.Location = new System.Drawing.Point(183, 153);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(94, 37);
            this.btnCancelar.TabIndex = 77;
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
            this.btnAceptar.Location = new System.Drawing.Point(83, 153);
            this.btnAceptar.Name = "btnAceptar";
            this.btnAceptar.Size = new System.Drawing.Size(94, 37);
            this.btnAceptar.TabIndex = 78;
            this.btnAceptar.Text = "Aceptar";
            this.btnAceptar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnAceptar.UseVisualStyleBackColor = false;
            this.btnAceptar.Click += new System.EventHandler(this.btnAceptar_Click);
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
            this.btnModificar.Location = new System.Drawing.Point(83, 153);
            this.btnModificar.Name = "btnModificar";
            this.btnModificar.Size = new System.Drawing.Size(94, 37);
            this.btnModificar.TabIndex = 79;
            this.btnModificar.Text = "Modificar";
            this.btnModificar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnModificar.UseVisualStyleBackColor = false;
            this.btnModificar.Click += new System.EventHandler(this.btnModificar_Click);
            // 
            // tboxCodigoRubro
            // 
            this.tboxCodigoRubro.Font = new System.Drawing.Font("Oswald Regular", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tboxCodigoRubro.Location = new System.Drawing.Point(114, 63);
            this.tboxCodigoRubro.Name = "tboxCodigoRubro";
            this.tboxCodigoRubro.Size = new System.Drawing.Size(173, 25);
            this.tboxCodigoRubro.TabIndex = 43;
            this.tboxCodigoRubro.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tboxCodigoRubro_KeyPress);
            // 
            // Rubros
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(330, 220);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnAceptar);
            this.Controls.Add(this.btnModificar);
            this.Controls.Add(this.lblCodigoRubro);
            this.Controls.Add(this.lblNombre);
            this.Controls.Add(this.tboxCodigoRubro);
            this.Controls.Add(this.tboxNombre);
            this.Controls.Add(this.pnlBarraPrincipal);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Location = new System.Drawing.Point(800, 240);
            this.Name = "Rubros";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "NuevoRubro";
            this.Load += new System.EventHandler(this.Rubros_Load);
            this.pnlBarraPrincipal.ResumeLayout(false);
            this.pnlBarraPrincipal.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Panel pnlBarraPrincipal;
        private System.Windows.Forms.TextBox tboxNombre;
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.Label lblCodigoRubro;
        private System.Windows.Forms.Label lblRubro;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button btnAceptar;
        private System.Windows.Forms.Button btnModificar;
        private System.Windows.Forms.TextBox tboxCodigoRubro;
    }
}