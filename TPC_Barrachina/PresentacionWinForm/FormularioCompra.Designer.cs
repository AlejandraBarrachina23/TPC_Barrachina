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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.pnlFooter = new System.Windows.Forms.Panel();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnAceptar = new System.Windows.Forms.Button();
            this.lblImporteTotal = new System.Windows.Forms.Label();
            this.lblImporteTotalNumerico = new System.Windows.Forms.Label();
            this.lblTotalBruto = new System.Windows.Forms.Label();
            this.lblTotalIVA = new System.Windows.Forms.Label();
            this.lblTotalIB = new System.Windows.Forms.Label();
            this.lblTotalImporteNeto = new System.Windows.Forms.Label();
            this.pnlDetalleCompra = new System.Windows.Forms.Panel();
            this.lblPrecioBruto = new System.Windows.Forms.Label();
            this.lblPrecioNeto = new System.Windows.Forms.Label();
            this.lblNumeroLinea = new System.Windows.Forms.Label();
            this.lblPrecioVenta = new System.Windows.Forms.Label();
            this.lblRentabilidad = new System.Windows.Forms.Label();
            this.lblPrecioPonderado = new System.Windows.Forms.Label();
            this.lblPrecioxBulto = new System.Windows.Forms.Label();
            this.lblDescuento = new System.Windows.Forms.Label();
            this.lblPrecioUnitario = new System.Windows.Forms.Label();
            this.lblCantidad = new System.Windows.Forms.Label();
            this.lblNombre = new System.Windows.Forms.Label();
            this.gboxImpuestos = new System.Windows.Forms.GroupBox();
            this.button2 = new System.Windows.Forms.Button();
            this.lblImpuesto1 = new System.Windows.Forms.Label();
            this.lblImpuesto2 = new System.Windows.Forms.Label();
            this.lblIB = new System.Windows.Forms.Label();
            this.tboxImpuesto1 = new System.Windows.Forms.TextBox();
            this.tboxImpuesto2 = new System.Windows.Forms.TextBox();
            this.lblIVA = new System.Windows.Forms.Label();
            this.txtIB = new System.Windows.Forms.TextBox();
            this.tboxIVA = new System.Windows.Forms.TextBox();
            this.gboxProveedor = new System.Windows.Forms.GroupBox();
            this.cboxProveedor = new System.Windows.Forms.ComboBox();
            this.lblNombreProveedor = new System.Windows.Forms.Label();
            this.pboxProveedor = new System.Windows.Forms.PictureBox();
            this.pnlDatosProveedor = new System.Windows.Forms.Panel();
            this.tboxCantidad = new System.Windows.Forms.TextBox();
            this.btnBorrar = new System.Windows.Forms.Button();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.tboxCodigoBarra = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dgvDetalleVenta = new System.Windows.Forms.DataGridView();
            this.pnlFooter.SuspendLayout();
            this.pnlDetalleCompra.SuspendLayout();
            this.gboxImpuestos.SuspendLayout();
            this.gboxProveedor.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pboxProveedor)).BeginInit();
            this.pnlDatosProveedor.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDetalleVenta)).BeginInit();
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
            this.pnlFooter.Location = new System.Drawing.Point(12, 414);
            this.pnlFooter.Name = "pnlFooter";
            this.pnlFooter.Size = new System.Drawing.Size(1024, 96);
            this.pnlFooter.TabIndex = 13;
            // 
            // btnCancelar
            // 
            this.btnCancelar.Location = new System.Drawing.Point(897, 33);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(116, 46);
            this.btnCancelar.TabIndex = 11;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            // 
            // btnAceptar
            // 
            this.btnAceptar.Location = new System.Drawing.Point(775, 33);
            this.btnAceptar.Name = "btnAceptar";
            this.btnAceptar.Size = new System.Drawing.Size(116, 46);
            this.btnAceptar.TabIndex = 11;
            this.btnAceptar.Text = "Aceptar";
            this.btnAceptar.UseVisualStyleBackColor = true;
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
            // pnlDetalleCompra
            // 
            this.pnlDetalleCompra.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.pnlDetalleCompra.Controls.Add(this.dgvDetalleVenta);
            this.pnlDetalleCompra.Controls.Add(this.tboxCantidad);
            this.pnlDetalleCompra.Controls.Add(this.btnBorrar);
            this.pnlDetalleCompra.Controls.Add(this.btnAgregar);
            this.pnlDetalleCompra.Controls.Add(this.tboxCodigoBarra);
            this.pnlDetalleCompra.Controls.Add(this.label3);
            this.pnlDetalleCompra.Controls.Add(this.label1);
            this.pnlDetalleCompra.Controls.Add(this.lblPrecioBruto);
            this.pnlDetalleCompra.Controls.Add(this.lblPrecioNeto);
            this.pnlDetalleCompra.Controls.Add(this.lblNumeroLinea);
            this.pnlDetalleCompra.Controls.Add(this.lblPrecioVenta);
            this.pnlDetalleCompra.Controls.Add(this.lblRentabilidad);
            this.pnlDetalleCompra.Controls.Add(this.lblPrecioPonderado);
            this.pnlDetalleCompra.Controls.Add(this.lblPrecioxBulto);
            this.pnlDetalleCompra.Controls.Add(this.lblDescuento);
            this.pnlDetalleCompra.Controls.Add(this.lblPrecioUnitario);
            this.pnlDetalleCompra.Controls.Add(this.lblCantidad);
            this.pnlDetalleCompra.Controls.Add(this.lblNombre);
            this.pnlDetalleCompra.Location = new System.Drawing.Point(12, 1);
            this.pnlDetalleCompra.Name = "pnlDetalleCompra";
            this.pnlDetalleCompra.Size = new System.Drawing.Size(773, 396);
            this.pnlDetalleCompra.TabIndex = 12;
            // 
            // lblPrecioBruto
            // 
            this.lblPrecioBruto.AutoSize = true;
            this.lblPrecioBruto.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPrecioBruto.Location = new System.Drawing.Point(509, 79);
            this.lblPrecioBruto.Name = "lblPrecioBruto";
            this.lblPrecioBruto.Size = new System.Drawing.Size(50, 13);
            this.lblPrecioBruto.TabIndex = 15;
            this.lblPrecioBruto.Text = "BRUTO";
            // 
            // lblPrecioNeto
            // 
            this.lblPrecioNeto.AutoSize = true;
            this.lblPrecioNeto.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPrecioNeto.Location = new System.Drawing.Point(452, 79);
            this.lblPrecioNeto.Name = "lblPrecioNeto";
            this.lblPrecioNeto.Size = new System.Drawing.Size(41, 13);
            this.lblPrecioNeto.TabIndex = 15;
            this.lblPrecioNeto.Text = "NETO";
            // 
            // lblNumeroLinea
            // 
            this.lblNumeroLinea.AutoSize = true;
            this.lblNumeroLinea.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNumeroLinea.Location = new System.Drawing.Point(36, 79);
            this.lblNumeroLinea.Name = "lblNumeroLinea";
            this.lblNumeroLinea.Size = new System.Drawing.Size(14, 13);
            this.lblNumeroLinea.TabIndex = 15;
            this.lblNumeroLinea.Text = "L";
            // 
            // lblPrecioVenta
            // 
            this.lblPrecioVenta.AutoSize = true;
            this.lblPrecioVenta.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPrecioVenta.Location = new System.Drawing.Point(687, 79);
            this.lblPrecioVenta.Name = "lblPrecioVenta";
            this.lblPrecioVenta.Size = new System.Drawing.Size(23, 13);
            this.lblPrecioVenta.TabIndex = 8;
            this.lblPrecioVenta.Text = "PV";
            // 
            // lblRentabilidad
            // 
            this.lblRentabilidad.AutoSize = true;
            this.lblRentabilidad.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRentabilidad.Location = new System.Drawing.Point(627, 79);
            this.lblRentabilidad.Name = "lblRentabilidad";
            this.lblRentabilidad.Size = new System.Drawing.Size(41, 13);
            this.lblRentabilidad.TabIndex = 8;
            this.lblRentabilidad.Text = "RENT";
            // 
            // lblPrecioPonderado
            // 
            this.lblPrecioPonderado.AutoSize = true;
            this.lblPrecioPonderado.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPrecioPonderado.Location = new System.Drawing.Point(572, 79);
            this.lblPrecioPonderado.Name = "lblPrecioPonderado";
            this.lblPrecioPonderado.Size = new System.Drawing.Size(42, 13);
            this.lblPrecioPonderado.TabIndex = 8;
            this.lblPrecioPonderado.Text = "POND";
            // 
            // lblPrecioxBulto
            // 
            this.lblPrecioxBulto.AutoSize = true;
            this.lblPrecioxBulto.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPrecioxBulto.Location = new System.Drawing.Point(282, 79);
            this.lblPrecioxBulto.Name = "lblPrecioxBulto";
            this.lblPrecioxBulto.Size = new System.Drawing.Size(48, 13);
            this.lblPrecioxBulto.TabIndex = 8;
            this.lblPrecioxBulto.Text = "BULTO";
            // 
            // lblDescuento
            // 
            this.lblDescuento.AutoSize = true;
            this.lblDescuento.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDescuento.Location = new System.Drawing.Point(394, 79);
            this.lblDescuento.Name = "lblDescuento";
            this.lblDescuento.Size = new System.Drawing.Size(40, 13);
            this.lblDescuento.TabIndex = 8;
            this.lblDescuento.Text = "DESC";
            // 
            // lblPrecioUnitario
            // 
            this.lblPrecioUnitario.AutoSize = true;
            this.lblPrecioUnitario.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPrecioUnitario.Location = new System.Drawing.Point(348, 79);
            this.lblPrecioUnitario.Name = "lblPrecioUnitario";
            this.lblPrecioUnitario.Size = new System.Drawing.Size(24, 13);
            this.lblPrecioUnitario.TabIndex = 8;
            this.lblPrecioUnitario.Text = "PU";
            // 
            // lblCantidad
            // 
            this.lblCantidad.AutoSize = true;
            this.lblCantidad.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCantidad.Location = new System.Drawing.Point(225, 79);
            this.lblCantidad.Name = "lblCantidad";
            this.lblCantidad.Size = new System.Drawing.Size(40, 13);
            this.lblCantidad.TabIndex = 8;
            this.lblCantidad.Text = "CANT";
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNombre.Location = new System.Drawing.Point(94, 79);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(60, 13);
            this.lblNombre.TabIndex = 8;
            this.lblNombre.Text = "NOMBRE";
            // 
            // gboxImpuestos
            // 
            this.gboxImpuestos.Controls.Add(this.button2);
            this.gboxImpuestos.Controls.Add(this.lblImpuesto1);
            this.gboxImpuestos.Controls.Add(this.lblImpuesto2);
            this.gboxImpuestos.Controls.Add(this.lblIB);
            this.gboxImpuestos.Controls.Add(this.tboxImpuesto1);
            this.gboxImpuestos.Controls.Add(this.tboxImpuesto2);
            this.gboxImpuestos.Controls.Add(this.lblIVA);
            this.gboxImpuestos.Controls.Add(this.txtIB);
            this.gboxImpuestos.Controls.Add(this.tboxIVA);
            this.gboxImpuestos.Location = new System.Drawing.Point(11, 92);
            this.gboxImpuestos.Name = "gboxImpuestos";
            this.gboxImpuestos.Size = new System.Drawing.Size(223, 161);
            this.gboxImpuestos.TabIndex = 11;
            this.gboxImpuestos.TabStop = false;
            this.gboxImpuestos.Text = "Impuestos";
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(58, 116);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(113, 30);
            this.button2.TabIndex = 11;
            this.button2.Text = "Modificar";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // lblImpuesto1
            // 
            this.lblImpuesto1.AutoSize = true;
            this.lblImpuesto1.Location = new System.Drawing.Point(24, 79);
            this.lblImpuesto1.Name = "lblImpuesto1";
            this.lblImpuesto1.Size = new System.Drawing.Size(26, 13);
            this.lblImpuesto1.TabIndex = 10;
            this.lblImpuesto1.Text = "IMP";
            // 
            // lblImpuesto2
            // 
            this.lblImpuesto2.AutoSize = true;
            this.lblImpuesto2.Location = new System.Drawing.Point(116, 76);
            this.lblImpuesto2.Name = "lblImpuesto2";
            this.lblImpuesto2.Size = new System.Drawing.Size(26, 13);
            this.lblImpuesto2.TabIndex = 10;
            this.lblImpuesto2.Text = "IMP";
            // 
            // lblIB
            // 
            this.lblIB.AutoSize = true;
            this.lblIB.Location = new System.Drawing.Point(116, 34);
            this.lblIB.Name = "lblIB";
            this.lblIB.Size = new System.Drawing.Size(17, 13);
            this.lblIB.TabIndex = 10;
            this.lblIB.Text = "IB";
            // 
            // tboxImpuesto1
            // 
            this.tboxImpuesto1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tboxImpuesto1.Location = new System.Drawing.Point(55, 67);
            this.tboxImpuesto1.Name = "tboxImpuesto1";
            this.tboxImpuesto1.Size = new System.Drawing.Size(48, 31);
            this.tboxImpuesto1.TabIndex = 8;
            // 
            // tboxImpuesto2
            // 
            this.tboxImpuesto2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tboxImpuesto2.Location = new System.Drawing.Point(148, 67);
            this.tboxImpuesto2.Name = "tboxImpuesto2";
            this.tboxImpuesto2.Size = new System.Drawing.Size(48, 31);
            this.tboxImpuesto2.TabIndex = 8;
            // 
            // lblIVA
            // 
            this.lblIVA.AutoSize = true;
            this.lblIVA.Location = new System.Drawing.Point(26, 34);
            this.lblIVA.Name = "lblIVA";
            this.lblIVA.Size = new System.Drawing.Size(24, 13);
            this.lblIVA.TabIndex = 10;
            this.lblIVA.Text = "IVA";
            // 
            // txtIB
            // 
            this.txtIB.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtIB.Location = new System.Drawing.Point(148, 25);
            this.txtIB.Name = "txtIB";
            this.txtIB.Size = new System.Drawing.Size(48, 31);
            this.txtIB.TabIndex = 8;
            // 
            // tboxIVA
            // 
            this.tboxIVA.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tboxIVA.Location = new System.Drawing.Point(55, 25);
            this.tboxIVA.Name = "tboxIVA";
            this.tboxIVA.Size = new System.Drawing.Size(48, 31);
            this.tboxIVA.TabIndex = 8;
            // 
            // gboxProveedor
            // 
            this.gboxProveedor.Controls.Add(this.cboxProveedor);
            this.gboxProveedor.Controls.Add(this.lblNombreProveedor);
            this.gboxProveedor.Controls.Add(this.pboxProveedor);
            this.gboxProveedor.Location = new System.Drawing.Point(11, 21);
            this.gboxProveedor.Name = "gboxProveedor";
            this.gboxProveedor.Size = new System.Drawing.Size(223, 71);
            this.gboxProveedor.TabIndex = 11;
            this.gboxProveedor.TabStop = false;
            this.gboxProveedor.Text = "Proveedor";
            // 
            // cboxProveedor
            // 
            this.cboxProveedor.FormattingEnabled = true;
            this.cboxProveedor.Location = new System.Drawing.Point(87, 23);
            this.cboxProveedor.Name = "cboxProveedor";
            this.cboxProveedor.Size = new System.Drawing.Size(119, 21);
            this.cboxProveedor.TabIndex = 11;
            // 
            // lblNombreProveedor
            // 
            this.lblNombreProveedor.AutoSize = true;
            this.lblNombreProveedor.Location = new System.Drawing.Point(6, 31);
            this.lblNombreProveedor.Name = "lblNombreProveedor";
            this.lblNombreProveedor.Size = new System.Drawing.Size(44, 13);
            this.lblNombreProveedor.TabIndex = 10;
            this.lblNombreProveedor.Text = "Nombre";
            // 
            // pboxProveedor
            // 
            this.pboxProveedor.Location = new System.Drawing.Point(55, 23);
            this.pboxProveedor.Name = "pboxProveedor";
            this.pboxProveedor.Size = new System.Drawing.Size(31, 31);
            this.pboxProveedor.TabIndex = 9;
            this.pboxProveedor.TabStop = false;
            // 
            // pnlDatosProveedor
            // 
            this.pnlDatosProveedor.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.pnlDatosProveedor.Controls.Add(this.gboxProveedor);
            this.pnlDatosProveedor.Controls.Add(this.gboxImpuestos);
            this.pnlDatosProveedor.ForeColor = System.Drawing.SystemColors.ControlText;
            this.pnlDatosProveedor.Location = new System.Drawing.Point(791, 1);
            this.pnlDatosProveedor.Name = "pnlDatosProveedor";
            this.pnlDatosProveedor.Size = new System.Drawing.Size(245, 396);
            this.pnlDatosProveedor.TabIndex = 15;
            // 
            // tboxCantidad
            // 
            this.tboxCantidad.Font = new System.Drawing.Font("Oswald", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tboxCantidad.Location = new System.Drawing.Point(533, 21);
            this.tboxCantidad.Name = "tboxCantidad";
            this.tboxCantidad.Size = new System.Drawing.Size(93, 36);
            this.tboxCantidad.TabIndex = 23;
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
            this.btnBorrar.Location = new System.Drawing.Point(717, 19);
            this.btnBorrar.Name = "btnBorrar";
            this.btnBorrar.Size = new System.Drawing.Size(44, 38);
            this.btnBorrar.TabIndex = 19;
            this.btnBorrar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnBorrar.UseVisualStyleBackColor = false;
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
            this.btnAgregar.Location = new System.Drawing.Point(654, 19);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(44, 38);
            this.btnAgregar.TabIndex = 20;
            this.btnAgregar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnAgregar.UseVisualStyleBackColor = false;
            // 
            // tboxCodigoBarra
            // 
            this.tboxCodigoBarra.Font = new System.Drawing.Font("Oswald", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tboxCodigoBarra.Location = new System.Drawing.Point(100, 21);
            this.tboxCodigoBarra.Name = "tboxCodigoBarra";
            this.tboxCodigoBarra.Size = new System.Drawing.Size(360, 36);
            this.tboxCodigoBarra.TabIndex = 18;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Oswald", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(476, 33);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(56, 17);
            this.label3.TabIndex = 21;
            this.label3.Text = "Cantidad";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Oswald", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(1, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(95, 17);
            this.label1.TabIndex = 22;
            this.label1.Text = "Código Producto";
            // 
            // dgvDetalleVenta
            // 
            this.dgvDetalleVenta.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dgvDetalleVenta.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleVertical;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Oswald", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvDetalleVenta.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvDetalleVenta.ColumnHeadersHeight = 35;
            this.dgvDetalleVenta.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Oswald Regular", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvDetalleVenta.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgvDetalleVenta.EnableHeadersVisualStyles = false;
            this.dgvDetalleVenta.Location = new System.Drawing.Point(15, 100);
            this.dgvDetalleVenta.Name = "dgvDetalleVenta";
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Oswald", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvDetalleVenta.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dgvDetalleVenta.RowHeadersVisible = false;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Oswald Regular", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.Silver;
            this.dgvDetalleVenta.RowsDefaultCellStyle = dataGridViewCellStyle4;
            this.dgvDetalleVenta.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvDetalleVenta.Size = new System.Drawing.Size(744, 282);
            this.dgvDetalleVenta.TabIndex = 24;
            // 
            // FormularioCompra
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1050, 520);
            this.Controls.Add(this.pnlDatosProveedor);
            this.Controls.Add(this.pnlFooter);
            this.Controls.Add(this.pnlDetalleCompra);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormularioCompra";
            this.Text = "FormularioCompra";
            this.pnlFooter.ResumeLayout(false);
            this.pnlFooter.PerformLayout();
            this.pnlDetalleCompra.ResumeLayout(false);
            this.pnlDetalleCompra.PerformLayout();
            this.gboxImpuestos.ResumeLayout(false);
            this.gboxImpuestos.PerformLayout();
            this.gboxProveedor.ResumeLayout(false);
            this.gboxProveedor.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pboxProveedor)).EndInit();
            this.pnlDatosProveedor.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvDetalleVenta)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel pnlFooter;
        private System.Windows.Forms.Label lblImporteTotal;
        private System.Windows.Forms.Label lblImporteTotalNumerico;
        private System.Windows.Forms.Label lblTotalImporteNeto;
        private System.Windows.Forms.Panel pnlDetalleCompra;
        private System.Windows.Forms.Label lblNumeroLinea;
        private System.Windows.Forms.Label lblPrecioxBulto;
        private System.Windows.Forms.Label lblCantidad;
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.Label lblPrecioNeto;
        private System.Windows.Forms.Label lblDescuento;
        private System.Windows.Forms.Label lblPrecioVenta;
        private System.Windows.Forms.Label lblRentabilidad;
        private System.Windows.Forms.GroupBox gboxImpuestos;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label lblImpuesto1;
        private System.Windows.Forms.Label lblIB;
        private System.Windows.Forms.TextBox tboxImpuesto1;
        private System.Windows.Forms.Label lblIVA;
        private System.Windows.Forms.TextBox txtIB;
        private System.Windows.Forms.TextBox tboxIVA;
        private System.Windows.Forms.GroupBox gboxProveedor;
        private System.Windows.Forms.Label lblNombreProveedor;
        private System.Windows.Forms.PictureBox pboxProveedor;
        private System.Windows.Forms.Label lblImpuesto2;
        private System.Windows.Forms.TextBox tboxImpuesto2;
        private System.Windows.Forms.Panel pnlDatosProveedor;
        private System.Windows.Forms.Label lblTotalIVA;
        private System.Windows.Forms.Label lblTotalBruto;
        private System.Windows.Forms.Label lblTotalIB;
        private System.Windows.Forms.Label lblPrecioUnitario;
        private System.Windows.Forms.Label lblPrecioBruto;
        private System.Windows.Forms.Label lblPrecioPonderado;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button btnAceptar;
        private System.Windows.Forms.ComboBox cboxProveedor;
        private System.Windows.Forms.TextBox tboxCantidad;
        private System.Windows.Forms.Button btnBorrar;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.TextBox tboxCodigoBarra;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dgvDetalleVenta;
    }
}