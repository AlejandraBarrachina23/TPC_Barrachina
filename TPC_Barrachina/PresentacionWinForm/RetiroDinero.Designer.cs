namespace PresentacionWinForm
{
    partial class RetiroDinero
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RetiroDinero));
            this.pnlBarraPrincipal = new System.Windows.Forms.Panel();
            this.tboxImporteRetirar = new System.Windows.Forms.TextBox();
            this.lblImporteRetirar = new System.Windows.Forms.Label();
            this.rbtnArqueoCaja = new System.Windows.Forms.RadioButton();
            this.rbtnPagoProveedor = new System.Windows.Forms.RadioButton();
            this.rbtnOtros = new System.Windows.Forms.RadioButton();
            this.gboxConcepto = new System.Windows.Forms.GroupBox();
            this.lblObservaciones = new System.Windows.Forms.Label();
            this.tboxObservaciones = new System.Windows.Forms.TextBox();
            this.lblRetiroDinero = new System.Windows.Forms.Label();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnAceptar = new System.Windows.Forms.Button();
            this.pnlBarraPrincipal.SuspendLayout();
            this.gboxConcepto.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlBarraPrincipal
            // 
            this.pnlBarraPrincipal.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(115)))), ((int)(((byte)(149)))));
            this.pnlBarraPrincipal.Controls.Add(this.lblRetiroDinero);
            this.pnlBarraPrincipal.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlBarraPrincipal.Location = new System.Drawing.Point(0, 0);
            this.pnlBarraPrincipal.Name = "pnlBarraPrincipal";
            this.pnlBarraPrincipal.Size = new System.Drawing.Size(381, 41);
            this.pnlBarraPrincipal.TabIndex = 5;
            // 
            // tboxImporteRetirar
            // 
            this.tboxImporteRetirar.Font = new System.Drawing.Font("Oswald Regular", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tboxImporteRetirar.Location = new System.Drawing.Point(183, 67);
            this.tboxImporteRetirar.Name = "tboxImporteRetirar";
            this.tboxImporteRetirar.Size = new System.Drawing.Size(100, 25);
            this.tboxImporteRetirar.TabIndex = 8;
            // 
            // lblImporteRetirar
            // 
            this.lblImporteRetirar.AutoSize = true;
            this.lblImporteRetirar.Font = new System.Drawing.Font("Oswald Regular", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblImporteRetirar.Location = new System.Drawing.Point(93, 71);
            this.lblImporteRetirar.Name = "lblImporteRetirar";
            this.lblImporteRetirar.Size = new System.Drawing.Size(87, 17);
            this.lblImporteRetirar.TabIndex = 9;
            this.lblImporteRetirar.Text = "Importe a retirar";
            // 
            // rbtnArqueoCaja
            // 
            this.rbtnArqueoCaja.AutoSize = true;
            this.rbtnArqueoCaja.Location = new System.Drawing.Point(33, 21);
            this.rbtnArqueoCaja.Name = "rbtnArqueoCaja";
            this.rbtnArqueoCaja.Size = new System.Drawing.Size(98, 21);
            this.rbtnArqueoCaja.TabIndex = 10;
            this.rbtnArqueoCaja.TabStop = true;
            this.rbtnArqueoCaja.Text = "Arqueo de Caja";
            this.rbtnArqueoCaja.UseVisualStyleBackColor = true;
            // 
            // rbtnPagoProveedor
            // 
            this.rbtnPagoProveedor.AutoSize = true;
            this.rbtnPagoProveedor.Location = new System.Drawing.Point(140, 21);
            this.rbtnPagoProveedor.Name = "rbtnPagoProveedor";
            this.rbtnPagoProveedor.Size = new System.Drawing.Size(109, 21);
            this.rbtnPagoProveedor.TabIndex = 10;
            this.rbtnPagoProveedor.TabStop = true;
            this.rbtnPagoProveedor.Text = "Pago a Proveedor";
            this.rbtnPagoProveedor.UseVisualStyleBackColor = true;
            // 
            // rbtnOtros
            // 
            this.rbtnOtros.AutoSize = true;
            this.rbtnOtros.Location = new System.Drawing.Point(269, 21);
            this.rbtnOtros.Name = "rbtnOtros";
            this.rbtnOtros.Size = new System.Drawing.Size(52, 21);
            this.rbtnOtros.TabIndex = 10;
            this.rbtnOtros.TabStop = true;
            this.rbtnOtros.Text = "Otros";
            this.rbtnOtros.UseVisualStyleBackColor = true;
            // 
            // gboxConcepto
            // 
            this.gboxConcepto.Controls.Add(this.rbtnArqueoCaja);
            this.gboxConcepto.Controls.Add(this.rbtnOtros);
            this.gboxConcepto.Controls.Add(this.rbtnPagoProveedor);
            this.gboxConcepto.Font = new System.Drawing.Font("Oswald Regular", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gboxConcepto.Location = new System.Drawing.Point(12, 107);
            this.gboxConcepto.Name = "gboxConcepto";
            this.gboxConcepto.Size = new System.Drawing.Size(356, 52);
            this.gboxConcepto.TabIndex = 11;
            this.gboxConcepto.TabStop = false;
            this.gboxConcepto.Text = "Concepto";
            // 
            // lblObservaciones
            // 
            this.lblObservaciones.AutoSize = true;
            this.lblObservaciones.Font = new System.Drawing.Font("Oswald Regular", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblObservaciones.Location = new System.Drawing.Point(12, 173);
            this.lblObservaciones.Name = "lblObservaciones";
            this.lblObservaciones.Size = new System.Drawing.Size(76, 17);
            this.lblObservaciones.TabIndex = 9;
            this.lblObservaciones.Text = "Observaciones";
            // 
            // tboxObservaciones
            // 
            this.tboxObservaciones.Font = new System.Drawing.Font("Oswald Regular", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tboxObservaciones.Location = new System.Drawing.Point(12, 194);
            this.tboxObservaciones.Multiline = true;
            this.tboxObservaciones.Name = "tboxObservaciones";
            this.tboxObservaciones.Size = new System.Drawing.Size(356, 67);
            this.tboxObservaciones.TabIndex = 12;
            // 
            // lblRetiroDinero
            // 
            this.lblRetiroDinero.AutoSize = true;
            this.lblRetiroDinero.Font = new System.Drawing.Font("Bebas", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRetiroDinero.ForeColor = System.Drawing.Color.White;
            this.lblRetiroDinero.Location = new System.Drawing.Point(128, 9);
            this.lblRetiroDinero.Name = "lblRetiroDinero";
            this.lblRetiroDinero.Size = new System.Drawing.Size(135, 23);
            this.lblRetiroDinero.TabIndex = 9;
            this.lblRetiroDinero.Text = "Retiro de dinero";
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
            this.btnCancelar.Location = new System.Drawing.Point(198, 272);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(94, 37);
            this.btnCancelar.TabIndex = 13;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnCancelar.UseVisualStyleBackColor = false;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
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
            this.btnAceptar.Location = new System.Drawing.Point(87, 272);
            this.btnAceptar.Name = "btnAceptar";
            this.btnAceptar.Size = new System.Drawing.Size(94, 37);
            this.btnAceptar.TabIndex = 14;
            this.btnAceptar.Text = "Aceptar";
            this.btnAceptar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnAceptar.UseVisualStyleBackColor = false;
            // 
            // RetiroDinero
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(381, 331);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnAceptar);
            this.Controls.Add(this.tboxObservaciones);
            this.Controls.Add(this.gboxConcepto);
            this.Controls.Add(this.lblObservaciones);
            this.Controls.Add(this.lblImporteRetirar);
            this.Controls.Add(this.tboxImporteRetirar);
            this.Controls.Add(this.pnlBarraPrincipal);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "RetiroDinero";
            this.Text = "RetiroDinero";
            this.pnlBarraPrincipal.ResumeLayout(false);
            this.pnlBarraPrincipal.PerformLayout();
            this.gboxConcepto.ResumeLayout(false);
            this.gboxConcepto.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel pnlBarraPrincipal;
        private System.Windows.Forms.TextBox tboxImporteRetirar;
        private System.Windows.Forms.Label lblImporteRetirar;
        private System.Windows.Forms.RadioButton rbtnArqueoCaja;
        private System.Windows.Forms.RadioButton rbtnPagoProveedor;
        private System.Windows.Forms.RadioButton rbtnOtros;
        private System.Windows.Forms.GroupBox gboxConcepto;
        private System.Windows.Forms.Label lblObservaciones;
        private System.Windows.Forms.TextBox tboxObservaciones;
        private System.Windows.Forms.Label lblRetiroDinero;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button btnAceptar;
    }
}