﻿namespace PresentacionWinForm
{
    partial class Productos
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Productos));
            this.pnlBarraPrincipal = new System.Windows.Forms.Panel();
            this.lblCliente = new System.Windows.Forms.Label();
            this.btnModificar = new System.Windows.Forms.Button();
            this.cboxProveedor = new System.Windows.Forms.ComboBox();
            this.cboxRubro = new System.Windows.Forms.ComboBox();
            this.cboxTipoProducto = new System.Windows.Forms.ComboBox();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.tboxCodigoProducto = new System.Windows.Forms.TextBox();
            this.btnAceptar = new System.Windows.Forms.Button();
            this.tboxCantidadBulto = new System.Windows.Forms.TextBox();
            this.tboxStockCritico = new System.Windows.Forms.TextBox();
            this.tboxNombre = new System.Windows.Forms.TextBox();
            this.tboxCodigoBulto = new System.Windows.Forms.TextBox();
            this.lblErrorCodigoProducto = new System.Windows.Forms.Label();
            this.lblCantidadBulto = new System.Windows.Forms.Label();
            this.lblErrorCodigoBulto = new System.Windows.Forms.Label();
            this.lblCodigoBulto = new System.Windows.Forms.Label();
            this.lblStockCritico = new System.Windows.Forms.Label();
            this.lblErrorStockCritico = new System.Windows.Forms.Label();
            this.lblProveedor = new System.Windows.Forms.Label();
            this.lblErrorProveedor = new System.Windows.Forms.Label();
            this.lblRubro = new System.Windows.Forms.Label();
            this.lblErrorRubro = new System.Windows.Forms.Label();
            this.lblTipoProducto = new System.Windows.Forms.Label();
            this.lblNombre = new System.Windows.Forms.Label();
            this.lblCodigoProducto = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblRentabilidad = new System.Windows.Forms.Label();
            this.tboxRentabilidad = new System.Windows.Forms.TextBox();
            this.lblAdvertenciaProveedor = new System.Windows.Forms.Label();
            this.lblAdvertenciaRubro = new System.Windows.Forms.Label();
            this.pnlBarraPrincipal.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlBarraPrincipal
            // 
            this.pnlBarraPrincipal.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(115)))), ((int)(((byte)(149)))));
            this.pnlBarraPrincipal.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlBarraPrincipal.Controls.Add(this.lblCliente);
            this.pnlBarraPrincipal.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlBarraPrincipal.Location = new System.Drawing.Point(0, 0);
            this.pnlBarraPrincipal.Name = "pnlBarraPrincipal";
            this.pnlBarraPrincipal.Size = new System.Drawing.Size(634, 41);
            this.pnlBarraPrincipal.TabIndex = 52;
            // 
            // lblCliente
            // 
            this.lblCliente.AutoSize = true;
            this.lblCliente.Font = new System.Drawing.Font("Bebas", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCliente.ForeColor = System.Drawing.Color.White;
            this.lblCliente.Location = new System.Drawing.Point(276, 8);
            this.lblCliente.Name = "lblCliente";
            this.lblCliente.Size = new System.Drawing.Size(90, 23);
            this.lblCliente.TabIndex = 10;
            this.lblCliente.Text = "PRODUCTOS";
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
            this.btnModificar.Location = new System.Drawing.Point(242, 252);
            this.btnModificar.Name = "btnModificar";
            this.btnModificar.Size = new System.Drawing.Size(94, 37);
            this.btnModificar.TabIndex = 58;
            this.btnModificar.Text = "Modificar";
            this.btnModificar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnModificar.UseVisualStyleBackColor = false;
            this.btnModificar.Click += new System.EventHandler(this.btnModificar_Click);
            // 
            // cboxProveedor
            // 
            this.cboxProveedor.Font = new System.Drawing.Font("Oswald Regular", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboxProveedor.FormattingEnabled = true;
            this.cboxProveedor.Location = new System.Drawing.Point(121, 192);
            this.cboxProveedor.Name = "cboxProveedor";
            this.cboxProveedor.Size = new System.Drawing.Size(173, 25);
            this.cboxProveedor.TabIndex = 8;
            // 
            // cboxRubro
            // 
            this.cboxRubro.Font = new System.Drawing.Font("Oswald Regular", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboxRubro.FormattingEnabled = true;
            this.cboxRubro.Location = new System.Drawing.Point(415, 149);
            this.cboxRubro.Name = "cboxRubro";
            this.cboxRubro.Size = new System.Drawing.Size(173, 25);
            this.cboxRubro.TabIndex = 7;
            // 
            // cboxTipoProducto
            // 
            this.cboxTipoProducto.Font = new System.Drawing.Font("Oswald Regular", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboxTipoProducto.FormattingEnabled = true;
            this.cboxTipoProducto.Location = new System.Drawing.Point(121, 149);
            this.cboxTipoProducto.Name = "cboxTipoProducto";
            this.cboxTipoProducto.Size = new System.Drawing.Size(173, 25);
            this.cboxTipoProducto.TabIndex = 6;
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
            this.btnCancelar.Location = new System.Drawing.Point(353, 254);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(94, 37);
            this.btnCancelar.TabIndex = 10;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnCancelar.UseVisualStyleBackColor = false;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // tboxCodigoProducto
            // 
            this.tboxCodigoProducto.Font = new System.Drawing.Font("Oswald Regular", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tboxCodigoProducto.Location = new System.Drawing.Point(121, 26);
            this.tboxCodigoProducto.Name = "tboxCodigoProducto";
            this.tboxCodigoProducto.Size = new System.Drawing.Size(173, 25);
            this.tboxCodigoProducto.TabIndex = 1;
            this.tboxCodigoProducto.TextChanged += new System.EventHandler(this.tboxCodigoProducto_TextChanged);
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
            this.btnAceptar.Location = new System.Drawing.Point(242, 252);
            this.btnAceptar.Name = "btnAceptar";
            this.btnAceptar.Size = new System.Drawing.Size(94, 37);
            this.btnAceptar.TabIndex = 9;
            this.btnAceptar.Text = "Aceptar";
            this.btnAceptar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnAceptar.UseVisualStyleBackColor = false;
            this.btnAceptar.Click += new System.EventHandler(this.btnAceptar_Click);
            // 
            // tboxCantidadBulto
            // 
            this.tboxCantidadBulto.Font = new System.Drawing.Font("Oswald Regular", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tboxCantidadBulto.Location = new System.Drawing.Point(121, 104);
            this.tboxCantidadBulto.Name = "tboxCantidadBulto";
            this.tboxCantidadBulto.Size = new System.Drawing.Size(173, 25);
            this.tboxCantidadBulto.TabIndex = 4;
            // 
            // tboxStockCritico
            // 
            this.tboxStockCritico.Font = new System.Drawing.Font("Oswald Regular", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tboxStockCritico.Location = new System.Drawing.Point(415, 104);
            this.tboxStockCritico.Name = "tboxStockCritico";
            this.tboxStockCritico.Size = new System.Drawing.Size(173, 25);
            this.tboxStockCritico.TabIndex = 5;
            // 
            // tboxNombre
            // 
            this.tboxNombre.Font = new System.Drawing.Font("Oswald Regular", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tboxNombre.Location = new System.Drawing.Point(121, 61);
            this.tboxNombre.Name = "tboxNombre";
            this.tboxNombre.Size = new System.Drawing.Size(173, 25);
            this.tboxNombre.TabIndex = 2;
            // 
            // tboxCodigoBulto
            // 
            this.tboxCodigoBulto.Font = new System.Drawing.Font("Oswald Regular", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tboxCodigoBulto.Location = new System.Drawing.Point(415, 25);
            this.tboxCodigoBulto.Name = "tboxCodigoBulto";
            this.tboxCodigoBulto.Size = new System.Drawing.Size(173, 25);
            this.tboxCodigoBulto.TabIndex = 2;
            // 
            // lblErrorCodigoProducto
            // 
            this.lblErrorCodigoProducto.AutoSize = true;
            this.lblErrorCodigoProducto.Font = new System.Drawing.Font("Oswald", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblErrorCodigoProducto.Location = new System.Drawing.Point(118, 54);
            this.lblErrorCodigoProducto.Name = "lblErrorCodigoProducto";
            this.lblErrorCodigoProducto.Size = new System.Drawing.Size(0, 15);
            this.lblErrorCodigoProducto.TabIndex = 57;
            // 
            // lblCantidadBulto
            // 
            this.lblCantidadBulto.AutoSize = true;
            this.lblCantidadBulto.Font = new System.Drawing.Font("Oswald Regular", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCantidadBulto.Location = new System.Drawing.Point(15, 108);
            this.lblCantidadBulto.Name = "lblCantidadBulto";
            this.lblCantidadBulto.Size = new System.Drawing.Size(100, 17);
            this.lblCantidadBulto.TabIndex = 43;
            this.lblCantidadBulto.Text = "Cantidad por Bulto";
            // 
            // lblErrorCodigoBulto
            // 
            this.lblErrorCodigoBulto.AutoSize = true;
            this.lblErrorCodigoBulto.Font = new System.Drawing.Font("Oswald", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblErrorCodigoBulto.Location = new System.Drawing.Point(412, 53);
            this.lblErrorCodigoBulto.Name = "lblErrorCodigoBulto";
            this.lblErrorCodigoBulto.Size = new System.Drawing.Size(0, 15);
            this.lblErrorCodigoBulto.TabIndex = 57;
            // 
            // lblCodigoBulto
            // 
            this.lblCodigoBulto.AutoSize = true;
            this.lblCodigoBulto.Font = new System.Drawing.Font("Oswald Regular", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCodigoBulto.Location = new System.Drawing.Point(338, 29);
            this.lblCodigoBulto.Name = "lblCodigoBulto";
            this.lblCodigoBulto.Size = new System.Drawing.Size(71, 17);
            this.lblCodigoBulto.TabIndex = 44;
            this.lblCodigoBulto.Text = "Codigo Bulto";
            // 
            // lblStockCritico
            // 
            this.lblStockCritico.AutoSize = true;
            this.lblStockCritico.Font = new System.Drawing.Font("Oswald Regular", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStockCritico.Location = new System.Drawing.Point(339, 108);
            this.lblStockCritico.Name = "lblStockCritico";
            this.lblStockCritico.Size = new System.Drawing.Size(70, 17);
            this.lblStockCritico.TabIndex = 43;
            this.lblStockCritico.Text = "Stock Crítico";
            // 
            // lblErrorStockCritico
            // 
            this.lblErrorStockCritico.AutoSize = true;
            this.lblErrorStockCritico.Font = new System.Drawing.Font("Oswald", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblErrorStockCritico.Location = new System.Drawing.Point(413, 149);
            this.lblErrorStockCritico.Name = "lblErrorStockCritico";
            this.lblErrorStockCritico.Size = new System.Drawing.Size(0, 15);
            this.lblErrorStockCritico.TabIndex = 57;
            // 
            // lblProveedor
            // 
            this.lblProveedor.AutoSize = true;
            this.lblProveedor.Font = new System.Drawing.Font("Oswald Regular", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblProveedor.Location = new System.Drawing.Point(60, 196);
            this.lblProveedor.Name = "lblProveedor";
            this.lblProveedor.Size = new System.Drawing.Size(55, 17);
            this.lblProveedor.TabIndex = 43;
            this.lblProveedor.Text = "Proveedor";
            // 
            // lblErrorProveedor
            // 
            this.lblErrorProveedor.AutoSize = true;
            this.lblErrorProveedor.Font = new System.Drawing.Font("Oswald", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblErrorProveedor.Location = new System.Drawing.Point(119, 197);
            this.lblErrorProveedor.Name = "lblErrorProveedor";
            this.lblErrorProveedor.Size = new System.Drawing.Size(0, 15);
            this.lblErrorProveedor.TabIndex = 57;
            // 
            // lblRubro
            // 
            this.lblRubro.AutoSize = true;
            this.lblRubro.Font = new System.Drawing.Font("Oswald Regular", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRubro.Location = new System.Drawing.Point(370, 152);
            this.lblRubro.Name = "lblRubro";
            this.lblRubro.Size = new System.Drawing.Size(37, 17);
            this.lblRubro.TabIndex = 43;
            this.lblRubro.Text = "Rubro";
            // 
            // lblErrorRubro
            // 
            this.lblErrorRubro.AutoSize = true;
            this.lblErrorRubro.Font = new System.Drawing.Font("Oswald", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblErrorRubro.Location = new System.Drawing.Point(118, 198);
            this.lblErrorRubro.Name = "lblErrorRubro";
            this.lblErrorRubro.Size = new System.Drawing.Size(0, 15);
            this.lblErrorRubro.TabIndex = 57;
            // 
            // lblTipoProducto
            // 
            this.lblTipoProducto.AutoSize = true;
            this.lblTipoProducto.Font = new System.Drawing.Font("Oswald Regular", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTipoProducto.Location = new System.Drawing.Point(87, 152);
            this.lblTipoProducto.Name = "lblTipoProducto";
            this.lblTipoProducto.Size = new System.Drawing.Size(28, 17);
            this.lblTipoProducto.TabIndex = 43;
            this.lblTipoProducto.Text = "Tipo";
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.Font = new System.Drawing.Font("Oswald Regular", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNombre.Location = new System.Drawing.Point(70, 64);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(45, 17);
            this.lblNombre.TabIndex = 43;
            this.lblNombre.Text = "Nombre";
            // 
            // lblCodigoProducto
            // 
            this.lblCodigoProducto.AutoSize = true;
            this.lblCodigoProducto.Font = new System.Drawing.Font("Oswald Regular", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCodigoProducto.Location = new System.Drawing.Point(27, 29);
            this.lblCodigoProducto.Name = "lblCodigoProducto";
            this.lblCodigoProducto.Size = new System.Drawing.Size(88, 17);
            this.lblCodigoProducto.TabIndex = 45;
            this.lblCodigoProducto.Text = "Codigo Producto";
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.lblAdvertenciaRubro);
            this.panel1.Controls.Add(this.lblAdvertenciaProveedor);
            this.panel1.Controls.Add(this.lblCodigoProducto);
            this.panel1.Controls.Add(this.lblRentabilidad);
            this.panel1.Controls.Add(this.lblNombre);
            this.panel1.Controls.Add(this.lblTipoProducto);
            this.panel1.Controls.Add(this.lblErrorRubro);
            this.panel1.Controls.Add(this.lblRubro);
            this.panel1.Controls.Add(this.lblErrorProveedor);
            this.panel1.Controls.Add(this.lblProveedor);
            this.panel1.Controls.Add(this.lblErrorStockCritico);
            this.panel1.Controls.Add(this.lblStockCritico);
            this.panel1.Controls.Add(this.lblCodigoBulto);
            this.panel1.Controls.Add(this.lblErrorCodigoBulto);
            this.panel1.Controls.Add(this.lblCantidadBulto);
            this.panel1.Controls.Add(this.lblErrorCodigoProducto);
            this.panel1.Controls.Add(this.tboxCodigoBulto);
            this.panel1.Controls.Add(this.tboxRentabilidad);
            this.panel1.Controls.Add(this.tboxNombre);
            this.panel1.Controls.Add(this.tboxStockCritico);
            this.panel1.Controls.Add(this.tboxCantidadBulto);
            this.panel1.Controls.Add(this.btnAceptar);
            this.panel1.Controls.Add(this.tboxCodigoProducto);
            this.panel1.Controls.Add(this.btnCancelar);
            this.panel1.Controls.Add(this.cboxTipoProducto);
            this.panel1.Controls.Add(this.cboxRubro);
            this.panel1.Controls.Add(this.cboxProveedor);
            this.panel1.Controls.Add(this.btnModificar);
            this.panel1.Location = new System.Drawing.Point(0, 41);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(698, 344);
            this.panel1.TabIndex = 58;
            // 
            // lblRentabilidad
            // 
            this.lblRentabilidad.AutoSize = true;
            this.lblRentabilidad.Font = new System.Drawing.Font("Oswald Regular", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRentabilidad.Location = new System.Drawing.Point(338, 68);
            this.lblRentabilidad.Name = "lblRentabilidad";
            this.lblRentabilidad.Size = new System.Drawing.Size(69, 17);
            this.lblRentabilidad.TabIndex = 43;
            this.lblRentabilidad.Text = "Rentabilidad";
            // 
            // tboxRentabilidad
            // 
            this.tboxRentabilidad.Font = new System.Drawing.Font("Oswald Regular", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tboxRentabilidad.Location = new System.Drawing.Point(415, 64);
            this.tboxRentabilidad.Name = "tboxRentabilidad";
            this.tboxRentabilidad.Size = new System.Drawing.Size(173, 25);
            this.tboxRentabilidad.TabIndex = 3;
            // 
            // lblAdvertenciaProveedor
            // 
            this.lblAdvertenciaProveedor.AutoSize = true;
            this.lblAdvertenciaProveedor.Font = new System.Drawing.Font("Oswald", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAdvertenciaProveedor.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lblAdvertenciaProveedor.Location = new System.Drawing.Point(79, 224);
            this.lblAdvertenciaProveedor.Name = "lblAdvertenciaProveedor";
            this.lblAdvertenciaProveedor.Size = new System.Drawing.Size(258, 17);
            this.lblAdvertenciaProveedor.TabIndex = 59;
            this.lblAdvertenciaProveedor.Text = "El Proveedor ha sido borrado, asigne uno nuevo.";
            this.lblAdvertenciaProveedor.Visible = false;
            // 
            // lblAdvertenciaRubro
            // 
            this.lblAdvertenciaRubro.AutoSize = true;
            this.lblAdvertenciaRubro.Font = new System.Drawing.Font("Oswald", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAdvertenciaRubro.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lblAdvertenciaRubro.Location = new System.Drawing.Point(370, 178);
            this.lblAdvertenciaRubro.Name = "lblAdvertenciaRubro";
            this.lblAdvertenciaRubro.Size = new System.Drawing.Size(238, 17);
            this.lblAdvertenciaRubro.TabIndex = 60;
            this.lblAdvertenciaRubro.Text = "El Rubro ha sido borrado, asigne uno nuevo.";
            this.lblAdvertenciaRubro.Visible = false;
            // 
            // Productos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(634, 357);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.pnlBarraPrincipal);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "Productos";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "Productos";
            this.Load += new System.EventHandler(this.Productos_Load);
            this.pnlBarraPrincipal.ResumeLayout(false);
            this.pnlBarraPrincipal.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel pnlBarraPrincipal;
        private System.Windows.Forms.Label lblCliente;
        private System.Windows.Forms.Button btnModificar;
        private System.Windows.Forms.ComboBox cboxProveedor;
        private System.Windows.Forms.ComboBox cboxRubro;
        private System.Windows.Forms.ComboBox cboxTipoProducto;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.TextBox tboxCodigoProducto;
        private System.Windows.Forms.Button btnAceptar;
        private System.Windows.Forms.TextBox tboxCantidadBulto;
        private System.Windows.Forms.TextBox tboxStockCritico;
        private System.Windows.Forms.TextBox tboxNombre;
        private System.Windows.Forms.TextBox tboxCodigoBulto;
        private System.Windows.Forms.Label lblErrorCodigoProducto;
        private System.Windows.Forms.Label lblCantidadBulto;
        private System.Windows.Forms.Label lblErrorCodigoBulto;
        private System.Windows.Forms.Label lblCodigoBulto;
        private System.Windows.Forms.Label lblStockCritico;
        private System.Windows.Forms.Label lblErrorStockCritico;
        private System.Windows.Forms.Label lblProveedor;
        private System.Windows.Forms.Label lblErrorProveedor;
        private System.Windows.Forms.Label lblRubro;
        private System.Windows.Forms.Label lblErrorRubro;
        private System.Windows.Forms.Label lblTipoProducto;
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.Label lblCodigoProducto;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lblRentabilidad;
        private System.Windows.Forms.TextBox tboxRentabilidad;
        private System.Windows.Forms.Label lblAdvertenciaProveedor;
        private System.Windows.Forms.Label lblAdvertenciaRubro;
    }
}