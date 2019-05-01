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
            this.pnlBarraPrincipal = new System.Windows.Forms.Panel();
            this.lblRetiroDinero = new System.Windows.Forms.Label();
            this.btnAceptar = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.tboxImporteRetirar = new System.Windows.Forms.TextBox();
            this.lblImporteRetirar = new System.Windows.Forms.Label();
            this.rbtnArqueoCaja = new System.Windows.Forms.RadioButton();
            this.rbtnPagoProveedor = new System.Windows.Forms.RadioButton();
            this.rbtnOtros = new System.Windows.Forms.RadioButton();
            this.gboxConcepto = new System.Windows.Forms.GroupBox();
            this.lblObservaciones = new System.Windows.Forms.Label();
            this.tboxObservaciones = new System.Windows.Forms.TextBox();
            this.pnlBarraPrincipal.SuspendLayout();
            this.gboxConcepto.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlBarraPrincipal
            // 
            this.pnlBarraPrincipal.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.pnlBarraPrincipal.Controls.Add(this.lblRetiroDinero);
            this.pnlBarraPrincipal.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlBarraPrincipal.Location = new System.Drawing.Point(0, 0);
            this.pnlBarraPrincipal.Name = "pnlBarraPrincipal";
            this.pnlBarraPrincipal.Size = new System.Drawing.Size(381, 41);
            this.pnlBarraPrincipal.TabIndex = 5;
            // 
            // lblRetiroDinero
            // 
            this.lblRetiroDinero.AutoSize = true;
            this.lblRetiroDinero.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRetiroDinero.Location = new System.Drawing.Point(131, 15);
            this.lblRetiroDinero.Name = "lblRetiroDinero";
            this.lblRetiroDinero.Size = new System.Drawing.Size(127, 13);
            this.lblRetiroDinero.TabIndex = 8;
            this.lblRetiroDinero.Text = "RETIRO DE DINERO";
            // 
            // btnAceptar
            // 
            this.btnAceptar.Location = new System.Drawing.Point(132, 273);
            this.btnAceptar.Name = "btnAceptar";
            this.btnAceptar.Size = new System.Drawing.Size(75, 36);
            this.btnAceptar.TabIndex = 6;
            this.btnAceptar.Text = "Aceptar";
            this.btnAceptar.UseVisualStyleBackColor = true;
            // 
            // btnCancelar
            // 
            this.btnCancelar.Location = new System.Drawing.Point(217, 273);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(75, 36);
            this.btnCancelar.TabIndex = 7;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            // 
            // tboxImporteRetirar
            // 
            this.tboxImporteRetirar.Location = new System.Drawing.Point(183, 67);
            this.tboxImporteRetirar.Name = "tboxImporteRetirar";
            this.tboxImporteRetirar.Size = new System.Drawing.Size(100, 20);
            this.tboxImporteRetirar.TabIndex = 8;
            // 
            // lblImporteRetirar
            // 
            this.lblImporteRetirar.AutoSize = true;
            this.lblImporteRetirar.Location = new System.Drawing.Point(93, 70);
            this.lblImporteRetirar.Name = "lblImporteRetirar";
            this.lblImporteRetirar.Size = new System.Drawing.Size(80, 13);
            this.lblImporteRetirar.TabIndex = 9;
            this.lblImporteRetirar.Text = "Importe a retirar";
            // 
            // rbtnArqueoCaja
            // 
            this.rbtnArqueoCaja.AutoSize = true;
            this.rbtnArqueoCaja.Location = new System.Drawing.Point(33, 21);
            this.rbtnArqueoCaja.Name = "rbtnArqueoCaja";
            this.rbtnArqueoCaja.Size = new System.Drawing.Size(98, 17);
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
            this.rbtnPagoProveedor.Size = new System.Drawing.Size(111, 17);
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
            this.rbtnOtros.Size = new System.Drawing.Size(50, 17);
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
            this.lblObservaciones.Location = new System.Drawing.Point(12, 173);
            this.lblObservaciones.Name = "lblObservaciones";
            this.lblObservaciones.Size = new System.Drawing.Size(78, 13);
            this.lblObservaciones.TabIndex = 9;
            this.lblObservaciones.Text = "Observaciones";
            // 
            // tboxObservaciones
            // 
            this.tboxObservaciones.Location = new System.Drawing.Point(12, 194);
            this.tboxObservaciones.Multiline = true;
            this.tboxObservaciones.Name = "tboxObservaciones";
            this.tboxObservaciones.Size = new System.Drawing.Size(356, 67);
            this.tboxObservaciones.TabIndex = 12;
            // 
            // RetiroDinero
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(381, 331);
            this.Controls.Add(this.tboxObservaciones);
            this.Controls.Add(this.gboxConcepto);
            this.Controls.Add(this.lblObservaciones);
            this.Controls.Add(this.lblImporteRetirar);
            this.Controls.Add(this.tboxImporteRetirar);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnAceptar);
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
        private System.Windows.Forms.Label lblRetiroDinero;
        private System.Windows.Forms.Button btnAceptar;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.TextBox tboxImporteRetirar;
        private System.Windows.Forms.Label lblImporteRetirar;
        private System.Windows.Forms.RadioButton rbtnArqueoCaja;
        private System.Windows.Forms.RadioButton rbtnPagoProveedor;
        private System.Windows.Forms.RadioButton rbtnOtros;
        private System.Windows.Forms.GroupBox gboxConcepto;
        private System.Windows.Forms.Label lblObservaciones;
        private System.Windows.Forms.TextBox tboxObservaciones;
    }
}