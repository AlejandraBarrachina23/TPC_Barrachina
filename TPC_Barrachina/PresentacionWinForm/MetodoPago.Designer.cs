namespace PresentacionWinForm
{
    partial class MetodoPago
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MetodoPago));
            this.pnlBarraPrincipal = new System.Windows.Forms.Panel();
            this.lbNombrePrograma = new System.Windows.Forms.Label();
            this.btnEfectivo = new System.Windows.Forms.Button();
            this.btnDebito = new System.Windows.Forms.Button();
            this.btnCtaCorriente = new System.Windows.Forms.Button();
            this.btnCredito = new System.Windows.Forms.Button();
            this.btnCreditoUnaCuota = new System.Windows.Forms.Button();
            this.btnCreditoTresCuotas = new System.Windows.Forms.Button();
            this.btnAceptar = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnMercadoPago = new System.Windows.Forms.Button();
            this.pnlContenedor = new System.Windows.Forms.Panel();
            this.pnlBarraPrincipal.SuspendLayout();
            this.pnlContenedor.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlBarraPrincipal
            // 
            this.pnlBarraPrincipal.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(115)))), ((int)(((byte)(149)))));
            this.pnlBarraPrincipal.Controls.Add(this.lbNombrePrograma);
            this.pnlBarraPrincipal.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlBarraPrincipal.Location = new System.Drawing.Point(0, 0);
            this.pnlBarraPrincipal.Name = "pnlBarraPrincipal";
            this.pnlBarraPrincipal.Size = new System.Drawing.Size(631, 41);
            this.pnlBarraPrincipal.TabIndex = 3;
            // 
            // lbNombrePrograma
            // 
            this.lbNombrePrograma.AutoSize = true;
            this.lbNombrePrograma.Font = new System.Drawing.Font("Bebas", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbNombrePrograma.ForeColor = System.Drawing.Color.White;
            this.lbNombrePrograma.Location = new System.Drawing.Point(262, 10);
            this.lbNombrePrograma.Name = "lbNombrePrograma";
            this.lbNombrePrograma.Size = new System.Drawing.Size(106, 23);
            this.lbNombrePrograma.TabIndex = 8;
            this.lbNombrePrograma.Text = "Metodo Pago";
            // 
            // btnEfectivo
            // 
            this.btnEfectivo.Image = ((System.Drawing.Image)(resources.GetObject("btnEfectivo.Image")));
            this.btnEfectivo.Location = new System.Drawing.Point(16, 25);
            this.btnEfectivo.Name = "btnEfectivo";
            this.btnEfectivo.Size = new System.Drawing.Size(103, 99);
            this.btnEfectivo.TabIndex = 4;
            this.btnEfectivo.UseVisualStyleBackColor = true;
            // 
            // btnDebito
            // 
            this.btnDebito.Image = ((System.Drawing.Image)(resources.GetObject("btnDebito.Image")));
            this.btnDebito.Location = new System.Drawing.Point(240, 24);
            this.btnDebito.Name = "btnDebito";
            this.btnDebito.Size = new System.Drawing.Size(104, 101);
            this.btnDebito.TabIndex = 4;
            this.btnDebito.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnDebito.UseVisualStyleBackColor = true;
            // 
            // btnCtaCorriente
            // 
            this.btnCtaCorriente.Image = ((System.Drawing.Image)(resources.GetObject("btnCtaCorriente.Image")));
            this.btnCtaCorriente.Location = new System.Drawing.Point(350, 25);
            this.btnCtaCorriente.Name = "btnCtaCorriente";
            this.btnCtaCorriente.Size = new System.Drawing.Size(107, 100);
            this.btnCtaCorriente.TabIndex = 4;
            this.btnCtaCorriente.UseVisualStyleBackColor = true;
            // 
            // btnCredito
            // 
            this.btnCredito.Image = ((System.Drawing.Image)(resources.GetObject("btnCredito.Image")));
            this.btnCredito.Location = new System.Drawing.Point(463, 25);
            this.btnCredito.Name = "btnCredito";
            this.btnCredito.Size = new System.Drawing.Size(98, 100);
            this.btnCredito.TabIndex = 4;
            this.btnCredito.UseVisualStyleBackColor = true;
            this.btnCredito.Click += new System.EventHandler(this.btnCredito_Click);
            // 
            // btnCreditoUnaCuota
            // 
            this.btnCreditoUnaCuota.Image = ((System.Drawing.Image)(resources.GetObject("btnCreditoUnaCuota.Image")));
            this.btnCreditoUnaCuota.Location = new System.Drawing.Point(567, 25);
            this.btnCreditoUnaCuota.Name = "btnCreditoUnaCuota";
            this.btnCreditoUnaCuota.Size = new System.Drawing.Size(45, 50);
            this.btnCreditoUnaCuota.TabIndex = 5;
            this.btnCreditoUnaCuota.UseVisualStyleBackColor = true;
            this.btnCreditoUnaCuota.Visible = false;
            // 
            // btnCreditoTresCuotas
            // 
            this.btnCreditoTresCuotas.Image = ((System.Drawing.Image)(resources.GetObject("btnCreditoTresCuotas.Image")));
            this.btnCreditoTresCuotas.Location = new System.Drawing.Point(567, 79);
            this.btnCreditoTresCuotas.Name = "btnCreditoTresCuotas";
            this.btnCreditoTresCuotas.Size = new System.Drawing.Size(45, 46);
            this.btnCreditoTresCuotas.TabIndex = 5;
            this.btnCreditoTresCuotas.UseVisualStyleBackColor = true;
            this.btnCreditoTresCuotas.Visible = false;
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
            this.btnAceptar.Location = new System.Drawing.Point(230, 135);
            this.btnAceptar.Name = "btnAceptar";
            this.btnAceptar.Size = new System.Drawing.Size(94, 37);
            this.btnAceptar.TabIndex = 6;
            this.btnAceptar.Text = "Aceptar";
            this.btnAceptar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnAceptar.UseVisualStyleBackColor = false;
            this.btnAceptar.Click += new System.EventHandler(this.btnAceptar_Click);
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
            this.btnCancelar.Location = new System.Drawing.Point(341, 135);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(94, 37);
            this.btnCancelar.TabIndex = 6;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnCancelar.UseVisualStyleBackColor = false;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // btnMercadoPago
            // 
            this.btnMercadoPago.Image = ((System.Drawing.Image)(resources.GetObject("btnMercadoPago.Image")));
            this.btnMercadoPago.Location = new System.Drawing.Point(125, 25);
            this.btnMercadoPago.Name = "btnMercadoPago";
            this.btnMercadoPago.Size = new System.Drawing.Size(109, 99);
            this.btnMercadoPago.TabIndex = 4;
            this.btnMercadoPago.UseVisualStyleBackColor = true;
            // 
            // pnlContenedor
            // 
            this.pnlContenedor.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlContenedor.Controls.Add(this.btnEfectivo);
            this.pnlContenedor.Controls.Add(this.btnCancelar);
            this.pnlContenedor.Controls.Add(this.btnMercadoPago);
            this.pnlContenedor.Controls.Add(this.btnAceptar);
            this.pnlContenedor.Controls.Add(this.btnDebito);
            this.pnlContenedor.Controls.Add(this.btnCreditoTresCuotas);
            this.pnlContenedor.Controls.Add(this.btnCtaCorriente);
            this.pnlContenedor.Controls.Add(this.btnCreditoUnaCuota);
            this.pnlContenedor.Controls.Add(this.btnCredito);
            this.pnlContenedor.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnlContenedor.Location = new System.Drawing.Point(0, 41);
            this.pnlContenedor.Name = "pnlContenedor";
            this.pnlContenedor.Size = new System.Drawing.Size(631, 184);
            this.pnlContenedor.TabIndex = 7;
            // 
            // MetodoPago
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(236)))), ((int)(((byte)(239)))));
            this.ClientSize = new System.Drawing.Size(631, 225);
            this.Controls.Add(this.pnlContenedor);
            this.Controls.Add(this.pnlBarraPrincipal);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "MetodoPago";
            this.Text = "MetodoPago";
            this.pnlBarraPrincipal.ResumeLayout(false);
            this.pnlBarraPrincipal.PerformLayout();
            this.pnlContenedor.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlBarraPrincipal;
        private System.Windows.Forms.Label lbNombrePrograma;
        private System.Windows.Forms.Button btnEfectivo;
        private System.Windows.Forms.Button btnDebito;
        private System.Windows.Forms.Button btnCtaCorriente;
        private System.Windows.Forms.Button btnCredito;
        private System.Windows.Forms.Button btnCreditoUnaCuota;
        private System.Windows.Forms.Button btnCreditoTresCuotas;
        private System.Windows.Forms.Button btnAceptar;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button btnMercadoPago;
        private System.Windows.Forms.Panel pnlContenedor;
    }
}