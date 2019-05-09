﻿namespace PresentacionWinForm
{
    partial class Busqueda
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
            this.lblNombreFormulario = new System.Windows.Forms.Label();
            this.lblCodigoCliente = new System.Windows.Forms.Label();
            this.pboxCodigoCliente = new System.Windows.Forms.PictureBox();
            this.tboxCodigoCliente = new System.Windows.Forms.TextBox();
            this.tboxNombreCliente = new System.Windows.Forms.TextBox();
            this.pboxNombreCliente = new System.Windows.Forms.PictureBox();
            this.lblNombreCliente = new System.Windows.Forms.Label();
            this.dgvListadoClientes = new System.Windows.Forms.DataGridView();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.btnAceptar = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.pnlBarraPrincipal.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pboxCodigoCliente)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pboxNombreCliente)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvListadoClientes)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlBarraPrincipal
            // 
            this.pnlBarraPrincipal.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.pnlBarraPrincipal.Controls.Add(this.lblNombreFormulario);
            this.pnlBarraPrincipal.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlBarraPrincipal.Location = new System.Drawing.Point(0, 0);
            this.pnlBarraPrincipal.Name = "pnlBarraPrincipal";
            this.pnlBarraPrincipal.Size = new System.Drawing.Size(730, 41);
            this.pnlBarraPrincipal.TabIndex = 2;
            // 
            // lblNombreFormulario
            // 
            this.lblNombreFormulario.AutoSize = true;
            this.lblNombreFormulario.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNombreFormulario.Location = new System.Drawing.Point(300, 14);
            this.lblNombreFormulario.Name = "lblNombreFormulario";
            this.lblNombreFormulario.Size = new System.Drawing.Size(79, 13);
            this.lblNombreFormulario.TabIndex = 8;
            this.lblNombreFormulario.Text = "BUSQUEDA ";
            // 
            // lblCodigoCliente
            // 
            this.lblCodigoCliente.AutoSize = true;
            this.lblCodigoCliente.Location = new System.Drawing.Point(56, 66);
            this.lblCodigoCliente.Name = "lblCodigoCliente";
            this.lblCodigoCliente.Size = new System.Drawing.Size(40, 13);
            this.lblCodigoCliente.TabIndex = 7;
            this.lblCodigoCliente.Text = "Codigo";
            // 
            // pboxCodigoCliente
            // 
            this.pboxCodigoCliente.Location = new System.Drawing.Point(105, 58);
            this.pboxCodigoCliente.Name = "pboxCodigoCliente";
            this.pboxCodigoCliente.Size = new System.Drawing.Size(31, 31);
            this.pboxCodigoCliente.TabIndex = 6;
            this.pboxCodigoCliente.TabStop = false;
            // 
            // tboxCodigoCliente
            // 
            this.tboxCodigoCliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tboxCodigoCliente.Location = new System.Drawing.Point(134, 58);
            this.tboxCodigoCliente.Name = "tboxCodigoCliente";
            this.tboxCodigoCliente.Size = new System.Drawing.Size(155, 31);
            this.tboxCodigoCliente.TabIndex = 5;
            // 
            // tboxNombreCliente
            // 
            this.tboxNombreCliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tboxNombreCliente.Location = new System.Drawing.Point(380, 58);
            this.tboxNombreCliente.Name = "tboxNombreCliente";
            this.tboxNombreCliente.Size = new System.Drawing.Size(155, 31);
            this.tboxNombreCliente.TabIndex = 5;
            // 
            // pboxNombreCliente
            // 
            this.pboxNombreCliente.Location = new System.Drawing.Point(351, 58);
            this.pboxNombreCliente.Name = "pboxNombreCliente";
            this.pboxNombreCliente.Size = new System.Drawing.Size(31, 31);
            this.pboxNombreCliente.TabIndex = 6;
            this.pboxNombreCliente.TabStop = false;
            // 
            // lblNombreCliente
            // 
            this.lblNombreCliente.AutoSize = true;
            this.lblNombreCliente.Location = new System.Drawing.Point(302, 66);
            this.lblNombreCliente.Name = "lblNombreCliente";
            this.lblNombreCliente.Size = new System.Drawing.Size(44, 13);
            this.lblNombreCliente.TabIndex = 7;
            this.lblNombreCliente.Text = "Nombre";
            // 
            // dgvListadoClientes
            // 
            this.dgvListadoClientes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvListadoClientes.Location = new System.Drawing.Point(36, 106);
            this.dgvListadoClientes.Name = "dgvListadoClientes";
            this.dgvListadoClientes.Size = new System.Drawing.Size(656, 169);
            this.dgvListadoClientes.TabIndex = 8;
            // 
            // btnBuscar
            // 
            this.btnBuscar.Location = new System.Drawing.Point(553, 58);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(110, 31);
            this.btnBuscar.TabIndex = 9;
            this.btnBuscar.Text = "Buscar";
            this.btnBuscar.UseVisualStyleBackColor = true;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // btnAceptar
            // 
            this.btnAceptar.Location = new System.Drawing.Point(264, 293);
            this.btnAceptar.Name = "btnAceptar";
            this.btnAceptar.Size = new System.Drawing.Size(110, 31);
            this.btnAceptar.TabIndex = 9;
            this.btnAceptar.Text = "Aceptar";
            this.btnAceptar.UseVisualStyleBackColor = true;
            // 
            // btnCancelar
            // 
            this.btnCancelar.Location = new System.Drawing.Point(380, 293);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(110, 31);
            this.btnCancelar.TabIndex = 9;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            // 
            // Busqueda
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(730, 340);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnAceptar);
            this.Controls.Add(this.btnBuscar);
            this.Controls.Add(this.dgvListadoClientes);
            this.Controls.Add(this.lblNombreCliente);
            this.Controls.Add(this.lblCodigoCliente);
            this.Controls.Add(this.pboxNombreCliente);
            this.Controls.Add(this.tboxNombreCliente);
            this.Controls.Add(this.pboxCodigoCliente);
            this.Controls.Add(this.tboxCodigoCliente);
            this.Controls.Add(this.pnlBarraPrincipal);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Busqueda";
            this.Text = "BusquedaCliente";
            this.Load += new System.EventHandler(this.Busqueda_Load);
            this.pnlBarraPrincipal.ResumeLayout(false);
            this.pnlBarraPrincipal.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pboxCodigoCliente)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pboxNombreCliente)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvListadoClientes)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel pnlBarraPrincipal;
        private System.Windows.Forms.Label lblNombreFormulario;
        private System.Windows.Forms.Label lblCodigoCliente;
        private System.Windows.Forms.PictureBox pboxCodigoCliente;
        private System.Windows.Forms.TextBox tboxCodigoCliente;
        private System.Windows.Forms.TextBox tboxNombreCliente;
        private System.Windows.Forms.PictureBox pboxNombreCliente;
        private System.Windows.Forms.Label lblNombreCliente;
        private System.Windows.Forms.DataGridView dgvListadoClientes;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.Button btnAceptar;
        private System.Windows.Forms.Button btnCancelar;
    }
}