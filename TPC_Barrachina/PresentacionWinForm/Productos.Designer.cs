namespace PresentacionWinForm
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
            this.lblCodigoProducto = new System.Windows.Forms.Label();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.tboxCodigoProducto = new System.Windows.Forms.TextBox();
            this.btnAceptar = new System.Windows.Forms.Button();
            this.tboxCodigoBulto = new System.Windows.Forms.TextBox();
            this.lblCodigoBulto = new System.Windows.Forms.Label();
            this.lblNombre = new System.Windows.Forms.Label();
            this.pnlBarraPrincipal = new System.Windows.Forms.Panel();
            this.lblCliente = new System.Windows.Forms.Label();
            this.tboxNombre = new System.Windows.Forms.TextBox();
            this.cboxTipoProducto = new System.Windows.Forms.ComboBox();
            this.lblTipoProducto = new System.Windows.Forms.Label();
            this.lblStockCritico = new System.Windows.Forms.Label();
            this.tboxStockCritico = new System.Windows.Forms.TextBox();
            this.lblCantidadBulto = new System.Windows.Forms.Label();
            this.tboxCantidadBulto = new System.Windows.Forms.TextBox();
            this.lblProveedor = new System.Windows.Forms.Label();
            this.lblRubro = new System.Windows.Forms.Label();
            this.cboxRubro = new System.Windows.Forms.ComboBox();
            this.cboxProveedor = new System.Windows.Forms.ComboBox();
            this.pboxCodigoBulto = new System.Windows.Forms.PictureBox();
            this.pboxTipo = new System.Windows.Forms.PictureBox();
            this.pboxProducto = new System.Windows.Forms.PictureBox();
            this.pboxNombre = new System.Windows.Forms.PictureBox();
            this.pboxCantidadBulto = new System.Windows.Forms.PictureBox();
            this.pboxProveedor = new System.Windows.Forms.PictureBox();
            this.pboxStockCritico = new System.Windows.Forms.PictureBox();
            this.pboxRubro = new System.Windows.Forms.PictureBox();
            this.lblErrorCodigoProducto = new System.Windows.Forms.Label();
            this.lblErrorCodigoBulto = new System.Windows.Forms.Label();
            this.lblErrorCantidadxBulto = new System.Windows.Forms.Label();
            this.lblErrorStockCritico = new System.Windows.Forms.Label();
            this.lblErrorNombre = new System.Windows.Forms.Label();
            this.lblErrorTipo = new System.Windows.Forms.Label();
            this.lblErrorProveedor = new System.Windows.Forms.Label();
            this.lblErrorRubro = new System.Windows.Forms.Label();
            this.pnlBarraPrincipal.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pboxCodigoBulto)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pboxTipo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pboxProducto)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pboxNombre)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pboxCantidadBulto)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pboxProveedor)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pboxStockCritico)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pboxRubro)).BeginInit();
            this.SuspendLayout();
            // 
            // lblCodigoProducto
            // 
            this.lblCodigoProducto.AutoSize = true;
            this.lblCodigoProducto.Font = new System.Drawing.Font("Oswald Regular", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCodigoProducto.Location = new System.Drawing.Point(24, 67);
            this.lblCodigoProducto.Name = "lblCodigoProducto";
            this.lblCodigoProducto.Size = new System.Drawing.Size(88, 17);
            this.lblCodigoProducto.TabIndex = 45;
            this.lblCodigoProducto.Text = "Codigo Producto";
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
            this.btnCancelar.Location = new System.Drawing.Point(339, 254);
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
            this.tboxCodigoProducto.Location = new System.Drawing.Point(118, 64);
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
            this.btnAceptar.Location = new System.Drawing.Point(228, 254);
            this.btnAceptar.Name = "btnAceptar";
            this.btnAceptar.Size = new System.Drawing.Size(94, 37);
            this.btnAceptar.TabIndex = 9;
            this.btnAceptar.Text = "Aceptar";
            this.btnAceptar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnAceptar.UseVisualStyleBackColor = false;
            this.btnAceptar.Click += new System.EventHandler(this.btnAceptar_Click);
            // 
            // tboxCodigoBulto
            // 
            this.tboxCodigoBulto.Font = new System.Drawing.Font("Oswald Regular", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tboxCodigoBulto.Location = new System.Drawing.Point(412, 63);
            this.tboxCodigoBulto.Name = "tboxCodigoBulto";
            this.tboxCodigoBulto.Size = new System.Drawing.Size(173, 25);
            this.tboxCodigoBulto.TabIndex = 2;
            this.tboxCodigoBulto.TextChanged += new System.EventHandler(this.tboxCodigoBulto_TextChanged);
            // 
            // lblCodigoBulto
            // 
            this.lblCodigoBulto.AutoSize = true;
            this.lblCodigoBulto.Font = new System.Drawing.Font("Oswald Regular", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCodigoBulto.Location = new System.Drawing.Point(335, 67);
            this.lblCodigoBulto.Name = "lblCodigoBulto";
            this.lblCodigoBulto.Size = new System.Drawing.Size(71, 17);
            this.lblCodigoBulto.TabIndex = 44;
            this.lblCodigoBulto.Text = "Codigo Bulto";
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.Font = new System.Drawing.Font("Oswald Regular", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNombre.Location = new System.Drawing.Point(67, 114);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(45, 17);
            this.lblNombre.TabIndex = 43;
            this.lblNombre.Text = "Nombre";
            // 
            // pnlBarraPrincipal
            // 
            this.pnlBarraPrincipal.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(115)))), ((int)(((byte)(149)))));
            this.pnlBarraPrincipal.Controls.Add(this.lblCliente);
            this.pnlBarraPrincipal.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlBarraPrincipal.Location = new System.Drawing.Point(0, 0);
            this.pnlBarraPrincipal.Name = "pnlBarraPrincipal";
            this.pnlBarraPrincipal.Size = new System.Drawing.Size(635, 41);
            this.pnlBarraPrincipal.TabIndex = 52;
            // 
            // lblCliente
            // 
            this.lblCliente.AutoSize = true;
            this.lblCliente.Font = new System.Drawing.Font("Bebas", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCliente.ForeColor = System.Drawing.Color.White;
            this.lblCliente.Location = new System.Drawing.Point(263, 9);
            this.lblCliente.Name = "lblCliente";
            this.lblCliente.Size = new System.Drawing.Size(90, 23);
            this.lblCliente.TabIndex = 10;
            this.lblCliente.Text = "PRODUCTOS";
            // 
            // tboxNombre
            // 
            this.tboxNombre.Font = new System.Drawing.Font("Oswald Regular", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tboxNombre.Location = new System.Drawing.Point(118, 111);
            this.tboxNombre.Name = "tboxNombre";
            this.tboxNombre.Size = new System.Drawing.Size(173, 25);
            this.tboxNombre.TabIndex = 3;
            this.tboxNombre.TextChanged += new System.EventHandler(this.tboxNombre_TextChanged);
            // 
            // cboxTipoProducto
            // 
            this.cboxTipoProducto.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboxTipoProducto.Font = new System.Drawing.Font("Oswald Regular", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboxTipoProducto.FormattingEnabled = true;
            this.cboxTipoProducto.Location = new System.Drawing.Point(412, 113);
            this.cboxTipoProducto.Name = "cboxTipoProducto";
            this.cboxTipoProducto.Size = new System.Drawing.Size(173, 25);
            this.cboxTipoProducto.TabIndex = 4;
            this.cboxTipoProducto.Leave += new System.EventHandler(this.cboxTipoProducto_Leave);
            // 
            // lblTipoProducto
            // 
            this.lblTipoProducto.AutoSize = true;
            this.lblTipoProducto.Font = new System.Drawing.Font("Oswald Regular", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTipoProducto.Location = new System.Drawing.Point(378, 116);
            this.lblTipoProducto.Name = "lblTipoProducto";
            this.lblTipoProducto.Size = new System.Drawing.Size(28, 17);
            this.lblTipoProducto.TabIndex = 43;
            this.lblTipoProducto.Text = "Tipo";
            // 
            // lblStockCritico
            // 
            this.lblStockCritico.AutoSize = true;
            this.lblStockCritico.Font = new System.Drawing.Font("Oswald Regular", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStockCritico.Location = new System.Drawing.Point(336, 160);
            this.lblStockCritico.Name = "lblStockCritico";
            this.lblStockCritico.Size = new System.Drawing.Size(70, 17);
            this.lblStockCritico.TabIndex = 43;
            this.lblStockCritico.Text = "Stock Crítico";
            // 
            // tboxStockCritico
            // 
            this.tboxStockCritico.Font = new System.Drawing.Font("Oswald Regular", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tboxStockCritico.Location = new System.Drawing.Point(413, 161);
            this.tboxStockCritico.Name = "tboxStockCritico";
            this.tboxStockCritico.Size = new System.Drawing.Size(173, 25);
            this.tboxStockCritico.TabIndex = 6;
            // 
            // lblCantidadBulto
            // 
            this.lblCantidadBulto.AutoSize = true;
            this.lblCantidadBulto.Font = new System.Drawing.Font("Oswald Regular", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCantidadBulto.Location = new System.Drawing.Point(12, 164);
            this.lblCantidadBulto.Name = "lblCantidadBulto";
            this.lblCantidadBulto.Size = new System.Drawing.Size(100, 17);
            this.lblCantidadBulto.TabIndex = 43;
            this.lblCantidadBulto.Text = "Cantidad por Bulto";
            // 
            // tboxCantidadBulto
            // 
            this.tboxCantidadBulto.Font = new System.Drawing.Font("Oswald Regular", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tboxCantidadBulto.Location = new System.Drawing.Point(118, 160);
            this.tboxCantidadBulto.Name = "tboxCantidadBulto";
            this.tboxCantidadBulto.Size = new System.Drawing.Size(173, 25);
            this.tboxCantidadBulto.TabIndex = 5;
            // 
            // lblProveedor
            // 
            this.lblProveedor.AutoSize = true;
            this.lblProveedor.Font = new System.Drawing.Font("Oswald Regular", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblProveedor.Location = new System.Drawing.Point(57, 213);
            this.lblProveedor.Name = "lblProveedor";
            this.lblProveedor.Size = new System.Drawing.Size(55, 17);
            this.lblProveedor.TabIndex = 43;
            this.lblProveedor.Text = "Proveedor";
            // 
            // lblRubro
            // 
            this.lblRubro.AutoSize = true;
            this.lblRubro.Font = new System.Drawing.Font("Oswald Regular", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRubro.Location = new System.Drawing.Point(369, 213);
            this.lblRubro.Name = "lblRubro";
            this.lblRubro.Size = new System.Drawing.Size(37, 17);
            this.lblRubro.TabIndex = 43;
            this.lblRubro.Text = "Rubro";
            // 
            // cboxRubro
            // 
            this.cboxRubro.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboxRubro.Font = new System.Drawing.Font("Oswald Regular", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboxRubro.FormattingEnabled = true;
            this.cboxRubro.Location = new System.Drawing.Point(412, 208);
            this.cboxRubro.Name = "cboxRubro";
            this.cboxRubro.Size = new System.Drawing.Size(173, 25);
            this.cboxRubro.TabIndex = 8;
            this.cboxRubro.Leave += new System.EventHandler(this.cboxRubro_Leave);
            // 
            // cboxProveedor
            // 
            this.cboxProveedor.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboxProveedor.Font = new System.Drawing.Font("Oswald Regular", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboxProveedor.FormattingEnabled = true;
            this.cboxProveedor.Location = new System.Drawing.Point(118, 209);
            this.cboxProveedor.Name = "cboxProveedor";
            this.cboxProveedor.Size = new System.Drawing.Size(173, 25);
            this.cboxProveedor.TabIndex = 7;
            this.cboxProveedor.Leave += new System.EventHandler(this.cboxProveedor_Leave);
            // 
            // pboxCodigoBulto
            // 
            this.pboxCodigoBulto.Location = new System.Drawing.Point(592, 67);
            this.pboxCodigoBulto.Name = "pboxCodigoBulto";
            this.pboxCodigoBulto.Size = new System.Drawing.Size(15, 20);
            this.pboxCodigoBulto.TabIndex = 56;
            this.pboxCodigoBulto.TabStop = false;
            // 
            // pboxTipo
            // 
            this.pboxTipo.Location = new System.Drawing.Point(592, 117);
            this.pboxTipo.Name = "pboxTipo";
            this.pboxTipo.Size = new System.Drawing.Size(16, 19);
            this.pboxTipo.TabIndex = 56;
            this.pboxTipo.TabStop = false;
            // 
            // pboxProducto
            // 
            this.pboxProducto.Location = new System.Drawing.Point(302, 70);
            this.pboxProducto.Name = "pboxProducto";
            this.pboxProducto.Size = new System.Drawing.Size(16, 19);
            this.pboxProducto.TabIndex = 56;
            this.pboxProducto.TabStop = false;
            // 
            // pboxNombre
            // 
            this.pboxNombre.Location = new System.Drawing.Point(302, 117);
            this.pboxNombre.Name = "pboxNombre";
            this.pboxNombre.Size = new System.Drawing.Size(16, 19);
            this.pboxNombre.TabIndex = 56;
            this.pboxNombre.TabStop = false;
            // 
            // pboxCantidadBulto
            // 
            this.pboxCantidadBulto.Location = new System.Drawing.Point(302, 163);
            this.pboxCantidadBulto.Name = "pboxCantidadBulto";
            this.pboxCantidadBulto.Size = new System.Drawing.Size(16, 19);
            this.pboxCantidadBulto.TabIndex = 56;
            this.pboxCantidadBulto.TabStop = false;
            // 
            // pboxProveedor
            // 
            this.pboxProveedor.Location = new System.Drawing.Point(302, 215);
            this.pboxProveedor.Name = "pboxProveedor";
            this.pboxProveedor.Size = new System.Drawing.Size(16, 19);
            this.pboxProveedor.TabIndex = 56;
            this.pboxProveedor.TabStop = false;
            // 
            // pboxStockCritico
            // 
            this.pboxStockCritico.Location = new System.Drawing.Point(591, 164);
            this.pboxStockCritico.Name = "pboxStockCritico";
            this.pboxStockCritico.Size = new System.Drawing.Size(16, 19);
            this.pboxStockCritico.TabIndex = 56;
            this.pboxStockCritico.TabStop = false;
            // 
            // pboxRubro
            // 
            this.pboxRubro.Location = new System.Drawing.Point(591, 215);
            this.pboxRubro.Name = "pboxRubro";
            this.pboxRubro.Size = new System.Drawing.Size(16, 19);
            this.pboxRubro.TabIndex = 56;
            this.pboxRubro.TabStop = false;
            // 
            // lblErrorCodigoProducto
            // 
            this.lblErrorCodigoProducto.AutoSize = true;
            this.lblErrorCodigoProducto.Font = new System.Drawing.Font("Oswald", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblErrorCodigoProducto.Location = new System.Drawing.Point(115, 92);
            this.lblErrorCodigoProducto.Name = "lblErrorCodigoProducto";
            this.lblErrorCodigoProducto.Size = new System.Drawing.Size(0, 15);
            this.lblErrorCodigoProducto.TabIndex = 57;
            // 
            // lblErrorCodigoBulto
            // 
            this.lblErrorCodigoBulto.AutoSize = true;
            this.lblErrorCodigoBulto.Font = new System.Drawing.Font("Oswald", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblErrorCodigoBulto.Location = new System.Drawing.Point(409, 91);
            this.lblErrorCodigoBulto.Name = "lblErrorCodigoBulto";
            this.lblErrorCodigoBulto.Size = new System.Drawing.Size(0, 15);
            this.lblErrorCodigoBulto.TabIndex = 57;
            // 
            // lblErrorCantidadxBulto
            // 
            this.lblErrorCantidadxBulto.AutoSize = true;
            this.lblErrorCantidadxBulto.Font = new System.Drawing.Font("Oswald", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblErrorCantidadxBulto.Location = new System.Drawing.Point(116, 193);
            this.lblErrorCantidadxBulto.Name = "lblErrorCantidadxBulto";
            this.lblErrorCantidadxBulto.Size = new System.Drawing.Size(0, 15);
            this.lblErrorCantidadxBulto.TabIndex = 57;
            // 
            // lblErrorStockCritico
            // 
            this.lblErrorStockCritico.AutoSize = true;
            this.lblErrorStockCritico.Font = new System.Drawing.Font("Oswald", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblErrorStockCritico.Location = new System.Drawing.Point(410, 194);
            this.lblErrorStockCritico.Name = "lblErrorStockCritico";
            this.lblErrorStockCritico.Size = new System.Drawing.Size(0, 15);
            this.lblErrorStockCritico.TabIndex = 57;
            // 
            // lblErrorNombre
            // 
            this.lblErrorNombre.AutoSize = true;
            this.lblErrorNombre.Font = new System.Drawing.Font("Oswald", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblErrorNombre.Location = new System.Drawing.Point(116, 140);
            this.lblErrorNombre.Name = "lblErrorNombre";
            this.lblErrorNombre.Size = new System.Drawing.Size(0, 15);
            this.lblErrorNombre.TabIndex = 57;
            // 
            // lblErrorTipo
            // 
            this.lblErrorTipo.AutoSize = true;
            this.lblErrorTipo.Font = new System.Drawing.Font("Oswald", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblErrorTipo.Location = new System.Drawing.Point(410, 141);
            this.lblErrorTipo.Name = "lblErrorTipo";
            this.lblErrorTipo.Size = new System.Drawing.Size(0, 15);
            this.lblErrorTipo.TabIndex = 57;
            // 
            // lblErrorProveedor
            // 
            this.lblErrorProveedor.AutoSize = true;
            this.lblErrorProveedor.Font = new System.Drawing.Font("Oswald", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblErrorProveedor.Location = new System.Drawing.Point(116, 235);
            this.lblErrorProveedor.Name = "lblErrorProveedor";
            this.lblErrorProveedor.Size = new System.Drawing.Size(0, 15);
            this.lblErrorProveedor.TabIndex = 57;
            // 
            // lblErrorRubro
            // 
            this.lblErrorRubro.AutoSize = true;
            this.lblErrorRubro.Font = new System.Drawing.Font("Oswald", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblErrorRubro.Location = new System.Drawing.Point(410, 236);
            this.lblErrorRubro.Name = "lblErrorRubro";
            this.lblErrorRubro.Size = new System.Drawing.Size(0, 15);
            this.lblErrorRubro.TabIndex = 57;
            // 
            // Productos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(635, 312);
            this.Controls.Add(this.lblErrorTipo);
            this.Controls.Add(this.lblErrorNombre);
            this.Controls.Add(this.lblErrorRubro);
            this.Controls.Add(this.lblErrorProveedor);
            this.Controls.Add(this.lblErrorStockCritico);
            this.Controls.Add(this.lblErrorCantidadxBulto);
            this.Controls.Add(this.lblErrorCodigoBulto);
            this.Controls.Add(this.lblErrorCodigoProducto);
            this.Controls.Add(this.pboxProveedor);
            this.Controls.Add(this.pboxCantidadBulto);
            this.Controls.Add(this.pboxNombre);
            this.Controls.Add(this.pboxProducto);
            this.Controls.Add(this.pboxRubro);
            this.Controls.Add(this.pboxStockCritico);
            this.Controls.Add(this.pboxTipo);
            this.Controls.Add(this.pboxCodigoBulto);
            this.Controls.Add(this.cboxProveedor);
            this.Controls.Add(this.cboxRubro);
            this.Controls.Add(this.cboxTipoProducto);
            this.Controls.Add(this.pnlBarraPrincipal);
            this.Controls.Add(this.lblCodigoProducto);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.tboxCodigoProducto);
            this.Controls.Add(this.btnAceptar);
            this.Controls.Add(this.tboxCantidadBulto);
            this.Controls.Add(this.tboxStockCritico);
            this.Controls.Add(this.tboxNombre);
            this.Controls.Add(this.tboxCodigoBulto);
            this.Controls.Add(this.lblCantidadBulto);
            this.Controls.Add(this.lblCodigoBulto);
            this.Controls.Add(this.lblStockCritico);
            this.Controls.Add(this.lblProveedor);
            this.Controls.Add(this.lblRubro);
            this.Controls.Add(this.lblTipoProducto);
            this.Controls.Add(this.lblNombre);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Productos";
            this.Text = "Productos";
            this.Load += new System.EventHandler(this.Productos_Load);
            this.pnlBarraPrincipal.ResumeLayout(false);
            this.pnlBarraPrincipal.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pboxCodigoBulto)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pboxTipo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pboxProducto)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pboxNombre)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pboxCantidadBulto)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pboxProveedor)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pboxStockCritico)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pboxRubro)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblCodigoProducto;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.TextBox tboxCodigoProducto;
        private System.Windows.Forms.Button btnAceptar;
        private System.Windows.Forms.TextBox tboxCodigoBulto;
        private System.Windows.Forms.Label lblCodigoBulto;
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.Panel pnlBarraPrincipal;
        private System.Windows.Forms.Label lblCliente;
        private System.Windows.Forms.TextBox tboxNombre;
        private System.Windows.Forms.ComboBox cboxTipoProducto;
        private System.Windows.Forms.Label lblTipoProducto;
        private System.Windows.Forms.Label lblStockCritico;
        private System.Windows.Forms.TextBox tboxStockCritico;
        private System.Windows.Forms.Label lblCantidadBulto;
        private System.Windows.Forms.TextBox tboxCantidadBulto;
        private System.Windows.Forms.Label lblProveedor;
        private System.Windows.Forms.Label lblRubro;
        private System.Windows.Forms.ComboBox cboxRubro;
        private System.Windows.Forms.ComboBox cboxProveedor;
        private System.Windows.Forms.PictureBox pboxCodigoBulto;
        private System.Windows.Forms.PictureBox pboxTipo;
        private System.Windows.Forms.PictureBox pboxProducto;
        private System.Windows.Forms.PictureBox pboxNombre;
        private System.Windows.Forms.PictureBox pboxCantidadBulto;
        private System.Windows.Forms.PictureBox pboxProveedor;
        private System.Windows.Forms.PictureBox pboxStockCritico;
        private System.Windows.Forms.PictureBox pboxRubro;
        private System.Windows.Forms.Label lblErrorCodigoProducto;
        private System.Windows.Forms.Label lblErrorCodigoBulto;
        private System.Windows.Forms.Label lblErrorCantidadxBulto;
        private System.Windows.Forms.Label lblErrorStockCritico;
        private System.Windows.Forms.Label lblErrorNombre;
        private System.Windows.Forms.Label lblErrorTipo;
        private System.Windows.Forms.Label lblErrorProveedor;
        private System.Windows.Forms.Label lblErrorRubro;
    }
}