namespace PresentacionWinForm
{
    partial class FormularioCompra
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormularioCompra));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle10 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle11 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle12 = new System.Windows.Forms.DataGridViewCellStyle();
            this.pnlFooter = new System.Windows.Forms.Panel();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnAceptar = new System.Windows.Forms.Button();
            this.lblImporteTotal = new System.Windows.Forms.Label();
            this.lblImporteTotalNumerico = new System.Windows.Forms.Label();
            this.lblTotalBruto = new System.Windows.Forms.Label();
            this.lblTotalIVA = new System.Windows.Forms.Label();
            this.lblTotalIB = new System.Windows.Forms.Label();
            this.lblTotalImporteNeto = new System.Windows.Forms.Label();
            this.gboxProveedor = new System.Windows.Forms.GroupBox();
            this.cboxProveedor = new System.Windows.Forms.ComboBox();
            this.pboxProveedor = new System.Windows.Forms.PictureBox();
            this.pnlDatosProveedor = new System.Windows.Forms.Panel();
            this.gboxImpuesto = new System.Windows.Forms.GroupBox();
            this.cboxImpuesto = new System.Windows.Forms.ComboBox();
            this.btnModificarImpuesto = new System.Windows.Forms.Button();
            this.btnBorrarImpuesto = new System.Windows.Forms.Button();
            this.btnAgregarImpuesto = new System.Windows.Forms.Button();
            this.tboxPorcentaje = new System.Windows.Forms.TextBox();
            this.dgvImpuestos = new System.Windows.Forms.DataGridView();
            this.lblImpuestos = new System.Windows.Forms.Label();
            this.lblPorcentaje = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.tboxCodigoBarra = new System.Windows.Forms.TextBox();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.btnBorrar = new System.Windows.Forms.Button();
            this.tboxCantidad = new System.Windows.Forms.TextBox();
            this.dgvDetalleCompra = new System.Windows.Forms.DataGridView();
            this.pnlDetalleCompra = new System.Windows.Forms.Panel();
            this.lblPrecio = new System.Windows.Forms.Label();
            this.tboxPrecioUnitario = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.tboxDescuento = new System.Windows.Forms.TextBox();
            this.pnlFooter.SuspendLayout();
            this.gboxProveedor.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pboxProveedor)).BeginInit();
            this.pnlDatosProveedor.SuspendLayout();
            this.gboxImpuesto.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvImpuestos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDetalleCompra)).BeginInit();
            this.pnlDetalleCompra.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlFooter
            // 
            this.pnlFooter.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.pnlFooter.Controls.Add(this.btnCancelar);
            this.pnlFooter.Controls.Add(this.btnAceptar);
            this.pnlFooter.Controls.Add(this.lblImporteTotal);
            this.pnlFooter.Controls.Add(this.lblImporteTotalNumerico);
            this.pnlFooter.Controls.Add(this.lblTotalBruto);
            this.pnlFooter.Controls.Add(this.lblTotalIVA);
            this.pnlFooter.Controls.Add(this.lblTotalIB);
            this.pnlFooter.Controls.Add(this.lblTotalImporteNeto);
            this.pnlFooter.Location = new System.Drawing.Point(12, 485);
            this.pnlFooter.Name = "pnlFooter";
            this.pnlFooter.Size = new System.Drawing.Size(1135, 96);
            this.pnlFooter.TabIndex = 13;
            // 
            // btnCancelar
            // 
            this.btnCancelar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(115)))), ((int)(((byte)(149)))));
            this.btnCancelar.FlatAppearance.BorderSize = 0;
            this.btnCancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancelar.Font = new System.Drawing.Font("Bebas", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancelar.ForeColor = System.Drawing.Color.White;
            this.btnCancelar.Image = ((System.Drawing.Image)(resources.GetObject("btnCancelar.Image")));
            this.btnCancelar.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnCancelar.Location = new System.Drawing.Point(905, 21);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(100, 60);
            this.btnCancelar.TabIndex = 13;
            this.btnCancelar.Text = "CANCELAR";
            this.btnCancelar.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
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
            this.btnAceptar.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnAceptar.Location = new System.Drawing.Point(799, 21);
            this.btnAceptar.Name = "btnAceptar";
            this.btnAceptar.Size = new System.Drawing.Size(100, 60);
            this.btnAceptar.TabIndex = 12;
            this.btnAceptar.Text = "ACEPTAR";
            this.btnAceptar.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnAceptar.UseVisualStyleBackColor = false;
            // 
            // lblImporteTotal
            // 
            this.lblImporteTotal.AutoSize = true;
            this.lblImporteTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblImporteTotal.Location = new System.Drawing.Point(288, 17);
            this.lblImporteTotal.Name = "lblImporteTotal";
            this.lblImporteTotal.Size = new System.Drawing.Size(107, 13);
            this.lblImporteTotal.TabIndex = 10;
            this.lblImporteTotal.Text = "IMPORTE TOTAL";
            // 
            // lblImporteTotalNumerico
            // 
            this.lblImporteTotalNumerico.AutoSize = true;
            this.lblImporteTotalNumerico.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblImporteTotalNumerico.Location = new System.Drawing.Point(290, 35);
            this.lblImporteTotalNumerico.Name = "lblImporteTotalNumerico";
            this.lblImporteTotalNumerico.Size = new System.Drawing.Size(103, 37);
            this.lblImporteTotalNumerico.TabIndex = 10;
            this.lblImporteTotalNumerico.Text = "$0.00";
            // 
            // lblTotalBruto
            // 
            this.lblTotalBruto.AutoSize = true;
            this.lblTotalBruto.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalBruto.Location = new System.Drawing.Point(47, 50);
            this.lblTotalBruto.Name = "lblTotalBruto";
            this.lblTotalBruto.Size = new System.Drawing.Size(159, 13);
            this.lblTotalBruto.TabIndex = 10;
            this.lblTotalBruto.Text = "SUBTOTAL BRUTO  $0.00";
            // 
            // lblTotalIVA
            // 
            this.lblTotalIVA.AutoSize = true;
            this.lblTotalIVA.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalIVA.Location = new System.Drawing.Point(47, 32);
            this.lblTotalIVA.Name = "lblTotalIVA";
            this.lblTotalIVA.Size = new System.Drawing.Size(71, 13);
            this.lblTotalIVA.TabIndex = 10;
            this.lblTotalIVA.Text = "IVA:  $0.00";
            // 
            // lblTotalIB
            // 
            this.lblTotalIB.AutoSize = true;
            this.lblTotalIB.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalIB.Location = new System.Drawing.Point(48, 68);
            this.lblTotalIB.Name = "lblTotalIB";
            this.lblTotalIB.Size = new System.Drawing.Size(59, 13);
            this.lblTotalIB.TabIndex = 10;
            this.lblTotalIB.Text = "IB: $0.00";
            // 
            // lblTotalImporteNeto
            // 
            this.lblTotalImporteNeto.AutoSize = true;
            this.lblTotalImporteNeto.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalImporteNeto.Location = new System.Drawing.Point(47, 15);
            this.lblTotalImporteNeto.Name = "lblTotalImporteNeto";
            this.lblTotalImporteNeto.Size = new System.Drawing.Size(145, 13);
            this.lblTotalImporteNeto.TabIndex = 10;
            this.lblTotalImporteNeto.Text = "IMPORTE NETO:  $0.00";
            // 
            // gboxProveedor
            // 
            this.gboxProveedor.Controls.Add(this.cboxProveedor);
            this.gboxProveedor.Controls.Add(this.pboxProveedor);
            this.gboxProveedor.Font = new System.Drawing.Font("Oswald", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gboxProveedor.Location = new System.Drawing.Point(59, 19);
            this.gboxProveedor.Name = "gboxProveedor";
            this.gboxProveedor.Size = new System.Drawing.Size(258, 71);
            this.gboxProveedor.TabIndex = 11;
            this.gboxProveedor.TabStop = false;
            this.gboxProveedor.Text = "Proveedor";
            // 
            // cboxProveedor
            // 
            this.cboxProveedor.Font = new System.Drawing.Font("Oswald Regular", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboxProveedor.FormattingEnabled = true;
            this.cboxProveedor.Location = new System.Drawing.Point(55, 28);
            this.cboxProveedor.Name = "cboxProveedor";
            this.cboxProveedor.Size = new System.Drawing.Size(197, 25);
            this.cboxProveedor.TabIndex = 12;
            this.cboxProveedor.SelectedIndexChanged += new System.EventHandler(this.cboxProveedor_SelectedIndexChanged);
            // 
            // pboxProveedor
            // 
            this.pboxProveedor.Image = ((System.Drawing.Image)(resources.GetObject("pboxProveedor.Image")));
            this.pboxProveedor.Location = new System.Drawing.Point(10, 25);
            this.pboxProveedor.Name = "pboxProveedor";
            this.pboxProveedor.Size = new System.Drawing.Size(41, 31);
            this.pboxProveedor.TabIndex = 9;
            this.pboxProveedor.TabStop = false;
            // 
            // pnlDatosProveedor
            // 
            this.pnlDatosProveedor.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.pnlDatosProveedor.Controls.Add(this.gboxImpuesto);
            this.pnlDatosProveedor.Controls.Add(this.gboxProveedor);
            this.pnlDatosProveedor.ForeColor = System.Drawing.SystemColors.ControlText;
            this.pnlDatosProveedor.Location = new System.Drawing.Point(763, 1);
            this.pnlDatosProveedor.Name = "pnlDatosProveedor";
            this.pnlDatosProveedor.Size = new System.Drawing.Size(384, 478);
            this.pnlDatosProveedor.TabIndex = 15;
            // 
            // gboxImpuesto
            // 
            this.gboxImpuesto.Controls.Add(this.cboxImpuesto);
            this.gboxImpuesto.Controls.Add(this.btnModificarImpuesto);
            this.gboxImpuesto.Controls.Add(this.btnBorrarImpuesto);
            this.gboxImpuesto.Controls.Add(this.btnAgregarImpuesto);
            this.gboxImpuesto.Controls.Add(this.tboxPorcentaje);
            this.gboxImpuesto.Controls.Add(this.dgvImpuestos);
            this.gboxImpuesto.Controls.Add(this.lblImpuestos);
            this.gboxImpuesto.Controls.Add(this.lblPorcentaje);
            this.gboxImpuesto.Font = new System.Drawing.Font("Oswald Regular", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gboxImpuesto.Location = new System.Drawing.Point(7, 101);
            this.gboxImpuesto.Name = "gboxImpuesto";
            this.gboxImpuesto.Size = new System.Drawing.Size(361, 357);
            this.gboxImpuesto.TabIndex = 15;
            this.gboxImpuesto.TabStop = false;
            this.gboxImpuesto.Text = "Impuesto";
            // 
            // cboxImpuesto
            // 
            this.cboxImpuesto.Font = new System.Drawing.Font("Oswald Regular", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboxImpuesto.FormattingEnabled = true;
            this.cboxImpuesto.Location = new System.Drawing.Point(59, 23);
            this.cboxImpuesto.Name = "cboxImpuesto";
            this.cboxImpuesto.Size = new System.Drawing.Size(136, 25);
            this.cboxImpuesto.TabIndex = 31;
            // 
            // btnModificarImpuesto
            // 
            this.btnModificarImpuesto.Image = ((System.Drawing.Image)(resources.GetObject("btnModificarImpuesto.Image")));
            this.btnModificarImpuesto.Location = new System.Drawing.Point(316, 168);
            this.btnModificarImpuesto.Name = "btnModificarImpuesto";
            this.btnModificarImpuesto.Size = new System.Drawing.Size(30, 27);
            this.btnModificarImpuesto.TabIndex = 30;
            this.btnModificarImpuesto.UseVisualStyleBackColor = true;
            // 
            // btnBorrarImpuesto
            // 
            this.btnBorrarImpuesto.Image = ((System.Drawing.Image)(resources.GetObject("btnBorrarImpuesto.Image")));
            this.btnBorrarImpuesto.Location = new System.Drawing.Point(316, 135);
            this.btnBorrarImpuesto.Name = "btnBorrarImpuesto";
            this.btnBorrarImpuesto.Size = new System.Drawing.Size(30, 27);
            this.btnBorrarImpuesto.TabIndex = 30;
            this.btnBorrarImpuesto.UseVisualStyleBackColor = true;
            // 
            // btnAgregarImpuesto
            // 
            this.btnAgregarImpuesto.Image = ((System.Drawing.Image)(resources.GetObject("btnAgregarImpuesto.Image")));
            this.btnAgregarImpuesto.Location = new System.Drawing.Point(316, 102);
            this.btnAgregarImpuesto.Name = "btnAgregarImpuesto";
            this.btnAgregarImpuesto.Size = new System.Drawing.Size(30, 27);
            this.btnAgregarImpuesto.TabIndex = 30;
            this.btnAgregarImpuesto.UseVisualStyleBackColor = true;
            // 
            // tboxPorcentaje
            // 
            this.tboxPorcentaje.Location = new System.Drawing.Point(260, 24);
            this.tboxPorcentaje.Name = "tboxPorcentaje";
            this.tboxPorcentaje.Size = new System.Drawing.Size(50, 25);
            this.tboxPorcentaje.TabIndex = 8;
            // 
            // dgvImpuestos
            // 
            this.dgvImpuestos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvImpuestos.Location = new System.Drawing.Point(10, 66);
            this.dgvImpuestos.Name = "dgvImpuestos";
            this.dgvImpuestos.ReadOnly = true;
            this.dgvImpuestos.RowHeadersVisible = false;
            this.dgvImpuestos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvImpuestos.Size = new System.Drawing.Size(300, 273);
            this.dgvImpuestos.TabIndex = 0;
            this.dgvImpuestos.SelectionChanged += new System.EventHandler(this.dgvImpuestos_SelectionChanged);
            // 
            // lblImpuestos
            // 
            this.lblImpuestos.AutoSize = true;
            this.lblImpuestos.Font = new System.Drawing.Font("Oswald Regular", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblImpuestos.Location = new System.Drawing.Point(8, 27);
            this.lblImpuestos.Name = "lblImpuestos";
            this.lblImpuestos.Size = new System.Drawing.Size(45, 17);
            this.lblImpuestos.TabIndex = 29;
            this.lblImpuestos.Text = "Nombre";
            // 
            // lblPorcentaje
            // 
            this.lblPorcentaje.AutoSize = true;
            this.lblPorcentaje.Location = new System.Drawing.Point(201, 31);
            this.lblPorcentaje.Name = "lblPorcentaje";
            this.lblPorcentaje.Size = new System.Drawing.Size(58, 17);
            this.lblPorcentaje.TabIndex = 19;
            this.lblPorcentaje.Text = "Porcentaje";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Oswald", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(3, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(95, 17);
            this.label1.TabIndex = 22;
            this.label1.Text = "Código Producto";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Oswald", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(42, 87);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(56, 17);
            this.label3.TabIndex = 21;
            this.label3.Text = "Cantidad";
            // 
            // tboxCodigoBarra
            // 
            this.tboxCodigoBarra.Font = new System.Drawing.Font("Oswald", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tboxCodigoBarra.Location = new System.Drawing.Point(100, 21);
            this.tboxCodigoBarra.Name = "tboxCodigoBarra";
            this.tboxCodigoBarra.Size = new System.Drawing.Size(293, 36);
            this.tboxCodigoBarra.TabIndex = 18;
            // 
            // btnAgregar
            // 
            this.btnAgregar.BackColor = System.Drawing.Color.Transparent;
            this.btnAgregar.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
            this.btnAgregar.FlatAppearance.BorderSize = 0;
            this.btnAgregar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAgregar.Font = new System.Drawing.Font("Bebas", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAgregar.Image = ((System.Drawing.Image)(resources.GetObject("btnAgregar.Image")));
            this.btnAgregar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAgregar.Location = new System.Drawing.Point(689, 19);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(44, 38);
            this.btnAgregar.TabIndex = 20;
            this.btnAgregar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnAgregar.UseVisualStyleBackColor = false;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // btnBorrar
            // 
            this.btnBorrar.BackColor = System.Drawing.Color.Transparent;
            this.btnBorrar.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
            this.btnBorrar.FlatAppearance.BorderSize = 0;
            this.btnBorrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBorrar.Font = new System.Drawing.Font("Bebas", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBorrar.Image = ((System.Drawing.Image)(resources.GetObject("btnBorrar.Image")));
            this.btnBorrar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnBorrar.Location = new System.Drawing.Point(689, 56);
            this.btnBorrar.Name = "btnBorrar";
            this.btnBorrar.Size = new System.Drawing.Size(44, 38);
            this.btnBorrar.TabIndex = 19;
            this.btnBorrar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnBorrar.UseVisualStyleBackColor = false;
            // 
            // tboxCantidad
            // 
            this.tboxCantidad.Font = new System.Drawing.Font("Oswald", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tboxCantidad.Location = new System.Drawing.Point(99, 75);
            this.tboxCantidad.Name = "tboxCantidad";
            this.tboxCantidad.Size = new System.Drawing.Size(93, 36);
            this.tboxCantidad.TabIndex = 23;
            // 
            // dgvDetalleCompra
            // 
            this.dgvDetalleCompra.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dgvDetalleCompra.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleVertical;
            dataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle9.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle9.Font = new System.Drawing.Font("Oswald", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle9.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle9.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle9.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle9.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvDetalleCompra.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle9;
            this.dgvDetalleCompra.ColumnHeadersHeight = 35;
            this.dgvDetalleCompra.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dataGridViewCellStyle10.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle10.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle10.Font = new System.Drawing.Font("Oswald Regular", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle10.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle10.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle10.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle10.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvDetalleCompra.DefaultCellStyle = dataGridViewCellStyle10;
            this.dgvDetalleCompra.EnableHeadersVisualStyles = false;
            this.dgvDetalleCompra.Location = new System.Drawing.Point(15, 128);
            this.dgvDetalleCompra.Name = "dgvDetalleCompra";
            dataGridViewCellStyle11.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle11.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle11.Font = new System.Drawing.Font("Oswald", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle11.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle11.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle11.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle11.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvDetalleCompra.RowHeadersDefaultCellStyle = dataGridViewCellStyle11;
            this.dgvDetalleCompra.RowHeadersVisible = false;
            dataGridViewCellStyle12.Font = new System.Drawing.Font("Oswald Regular", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle12.SelectionBackColor = System.Drawing.Color.Silver;
            this.dgvDetalleCompra.RowsDefaultCellStyle = dataGridViewCellStyle12;
            this.dgvDetalleCompra.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvDetalleCompra.Size = new System.Drawing.Size(718, 331);
            this.dgvDetalleCompra.TabIndex = 24;
            // 
            // pnlDetalleCompra
            // 
            this.pnlDetalleCompra.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.pnlDetalleCompra.Controls.Add(this.dgvDetalleCompra);
            this.pnlDetalleCompra.Controls.Add(this.tboxDescuento);
            this.pnlDetalleCompra.Controls.Add(this.tboxPrecioUnitario);
            this.pnlDetalleCompra.Controls.Add(this.tboxCantidad);
            this.pnlDetalleCompra.Controls.Add(this.btnBorrar);
            this.pnlDetalleCompra.Controls.Add(this.label2);
            this.pnlDetalleCompra.Controls.Add(this.btnAgregar);
            this.pnlDetalleCompra.Controls.Add(this.lblPrecio);
            this.pnlDetalleCompra.Controls.Add(this.tboxCodigoBarra);
            this.pnlDetalleCompra.Controls.Add(this.label3);
            this.pnlDetalleCompra.Controls.Add(this.label1);
            this.pnlDetalleCompra.Location = new System.Drawing.Point(12, 1);
            this.pnlDetalleCompra.Name = "pnlDetalleCompra";
            this.pnlDetalleCompra.Size = new System.Drawing.Size(745, 478);
            this.pnlDetalleCompra.TabIndex = 12;
            // 
            // lblPrecio
            // 
            this.lblPrecio.AutoSize = true;
            this.lblPrecio.Font = new System.Drawing.Font("Oswald", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPrecio.Location = new System.Drawing.Point(203, 87);
            this.lblPrecio.Name = "lblPrecio";
            this.lblPrecio.Size = new System.Drawing.Size(87, 17);
            this.lblPrecio.TabIndex = 21;
            this.lblPrecio.Text = "Precio Unitario";
            // 
            // tboxPrecioUnitario
            // 
            this.tboxPrecioUnitario.Font = new System.Drawing.Font("Oswald", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tboxPrecioUnitario.Location = new System.Drawing.Point(291, 75);
            this.tboxPrecioUnitario.Name = "tboxPrecioUnitario";
            this.tboxPrecioUnitario.Size = new System.Drawing.Size(93, 36);
            this.tboxPrecioUnitario.TabIndex = 23;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Oswald", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(412, 87);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(68, 17);
            this.label2.TabIndex = 21;
            this.label2.Text = "Descuento:";
            // 
            // tboxDescuento
            // 
            this.tboxDescuento.Font = new System.Drawing.Font("Oswald", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tboxDescuento.Location = new System.Drawing.Point(486, 75);
            this.tboxDescuento.Name = "tboxDescuento";
            this.tboxDescuento.Size = new System.Drawing.Size(93, 36);
            this.tboxDescuento.TabIndex = 23;
            // 
            // FormularioCompra
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1159, 593);
            this.Controls.Add(this.pnlDatosProveedor);
            this.Controls.Add(this.pnlFooter);
            this.Controls.Add(this.pnlDetalleCompra);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormularioCompra";
            this.Text = "FormularioCompra";
            this.Load += new System.EventHandler(this.FormularioCompra_Load);
            this.pnlFooter.ResumeLayout(false);
            this.pnlFooter.PerformLayout();
            this.gboxProveedor.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pboxProveedor)).EndInit();
            this.pnlDatosProveedor.ResumeLayout(false);
            this.gboxImpuesto.ResumeLayout(false);
            this.gboxImpuesto.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvImpuestos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDetalleCompra)).EndInit();
            this.pnlDetalleCompra.ResumeLayout(false);
            this.pnlDetalleCompra.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel pnlFooter;
        private System.Windows.Forms.Label lblImporteTotal;
        private System.Windows.Forms.Label lblImporteTotalNumerico;
        private System.Windows.Forms.Label lblTotalImporteNeto;
        private System.Windows.Forms.GroupBox gboxProveedor;
        private System.Windows.Forms.PictureBox pboxProveedor;
        private System.Windows.Forms.Panel pnlDatosProveedor;
        private System.Windows.Forms.Label lblTotalIVA;
        private System.Windows.Forms.Label lblTotalBruto;
        private System.Windows.Forms.Label lblTotalIB;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button btnAceptar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tboxCodigoBarra;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.Button btnBorrar;
        private System.Windows.Forms.TextBox tboxCantidad;
        private System.Windows.Forms.DataGridView dgvDetalleCompra;
        private System.Windows.Forms.Panel pnlDetalleCompra;
        private System.Windows.Forms.ComboBox cboxProveedor;
        private System.Windows.Forms.GroupBox gboxImpuesto;
        private System.Windows.Forms.ComboBox cboxImpuesto;
        private System.Windows.Forms.Button btnModificarImpuesto;
        private System.Windows.Forms.Button btnBorrarImpuesto;
        private System.Windows.Forms.Button btnAgregarImpuesto;
        private System.Windows.Forms.TextBox tboxPorcentaje;
        private System.Windows.Forms.DataGridView dgvImpuestos;
        private System.Windows.Forms.Label lblImpuestos;
        private System.Windows.Forms.Label lblPorcentaje;
        private System.Windows.Forms.TextBox tboxDescuento;
        private System.Windows.Forms.TextBox tboxPrecioUnitario;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblPrecio;
    }
}