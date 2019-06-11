namespace PresentacionWinForm
{
    partial class FormularioListado
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormularioListado));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.pboxCodigo = new System.Windows.Forms.PictureBox();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.tboxCodigo = new System.Windows.Forms.TextBox();
            this.tboxNombre = new System.Windows.Forms.TextBox();
            this.dgvListadoBusqueda = new System.Windows.Forms.DataGridView();
            this.pboxNombre = new System.Windows.Forms.PictureBox();
            this.lblCodigo = new System.Windows.Forms.Label();
            this.lblNombre = new System.Windows.Forms.Label();
            this.lblNombreFormulario = new System.Windows.Forms.Label();
            this.pnlBarraPrincipal = new System.Windows.Forms.Panel();
            this.pnlModificar = new System.Windows.Forms.Panel();
            this.pnlBorrar = new System.Windows.Forms.Panel();
            this.pnlAgregar = new System.Windows.Forms.Panel();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.btnBorrar = new System.Windows.Forms.Button();
            this.btnModificar = new System.Windows.Forms.Button();
            this.panelContenedor = new System.Windows.Forms.Panel();
            this.pnlImpuesto = new System.Windows.Forms.Panel();
            this.pnlDescuento = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pnlRubro = new System.Windows.Forms.Panel();
            this.pnlDetalle = new System.Windows.Forms.Panel();
            this.btnImpuesto = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.btnDescuento = new System.Windows.Forms.Button();
            this.btnRubro = new System.Windows.Forms.Button();
            this.btnDetalle = new System.Windows.Forms.Button();
            this.btnBuscar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pboxCodigo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvListadoBusqueda)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pboxNombre)).BeginInit();
            this.pnlBarraPrincipal.SuspendLayout();
            this.panelContenedor.SuspendLayout();
            this.SuspendLayout();
            // 
            // pboxCodigo
            // 
            this.pboxCodigo.Image = ((System.Drawing.Image)(resources.GetObject("pboxCodigo.Image")));
            this.pboxCodigo.Location = new System.Drawing.Point(70, 32);
            this.pboxCodigo.Name = "pboxCodigo";
            this.pboxCodigo.Size = new System.Drawing.Size(31, 31);
            this.pboxCodigo.TabIndex = 16;
            this.pboxCodigo.TabStop = false;
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
            this.btnCancelar.Location = new System.Drawing.Point(662, 443);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(95, 37);
            this.btnCancelar.TabIndex = 22;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnCancelar.UseVisualStyleBackColor = false;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // tboxCodigo
            // 
            this.tboxCodigo.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tboxCodigo.Location = new System.Drawing.Point(104, 32);
            this.tboxCodigo.Name = "tboxCodigo";
            this.tboxCodigo.Size = new System.Drawing.Size(155, 31);
            this.tboxCodigo.TabIndex = 14;
            this.tboxCodigo.TextChanged += new System.EventHandler(this.tboxCodigo_TextChanged);
            // 
            // tboxNombre
            // 
            this.tboxNombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tboxNombre.Location = new System.Drawing.Point(376, 33);
            this.tboxNombre.Name = "tboxNombre";
            this.tboxNombre.Size = new System.Drawing.Size(155, 31);
            this.tboxNombre.TabIndex = 15;
            // 
            // dgvListadoBusqueda
            // 
            this.dgvListadoBusqueda.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Oswald Regular", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvListadoBusqueda.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgvListadoBusqueda.GridColor = System.Drawing.SystemColors.ControlLight;
            this.dgvListadoBusqueda.Location = new System.Drawing.Point(12, 88);
            this.dgvListadoBusqueda.Name = "dgvListadoBusqueda";
            this.dgvListadoBusqueda.ReadOnly = true;
            this.dgvListadoBusqueda.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvListadoBusqueda.Size = new System.Drawing.Size(632, 404);
            this.dgvListadoBusqueda.TabIndex = 20;
            // 
            // pboxNombre
            // 
            this.pboxNombre.Image = ((System.Drawing.Image)(resources.GetObject("pboxNombre.Image")));
            this.pboxNombre.Location = new System.Drawing.Point(341, 33);
            this.pboxNombre.Name = "pboxNombre";
            this.pboxNombre.Size = new System.Drawing.Size(31, 31);
            this.pboxNombre.TabIndex = 17;
            this.pboxNombre.TabStop = false;
            // 
            // lblCodigo
            // 
            this.lblCodigo.AutoSize = true;
            this.lblCodigo.Font = new System.Drawing.Font("Oswald Regular", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCodigo.Location = new System.Drawing.Point(26, 42);
            this.lblCodigo.Name = "lblCodigo";
            this.lblCodigo.Size = new System.Drawing.Size(42, 17);
            this.lblCodigo.TabIndex = 18;
            this.lblCodigo.Text = "Codigo";
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.Font = new System.Drawing.Font("Oswald Regular", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNombre.Location = new System.Drawing.Point(294, 41);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(45, 17);
            this.lblNombre.TabIndex = 19;
            this.lblNombre.Text = "Nombre";
            // 
            // lblNombreFormulario
            // 
            this.lblNombreFormulario.AutoSize = true;
            this.lblNombreFormulario.Font = new System.Drawing.Font("Bebas", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNombreFormulario.ForeColor = System.Drawing.Color.White;
            this.lblNombreFormulario.Location = new System.Drawing.Point(293, 8);
            this.lblNombreFormulario.Name = "lblNombreFormulario";
            this.lblNombreFormulario.Size = new System.Drawing.Size(60, 23);
            this.lblNombreFormulario.TabIndex = 8;
            this.lblNombreFormulario.Text = "LISTADO";
            // 
            // pnlBarraPrincipal
            // 
            this.pnlBarraPrincipal.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(115)))), ((int)(((byte)(149)))));
            this.pnlBarraPrincipal.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlBarraPrincipal.Controls.Add(this.lblNombreFormulario);
            this.pnlBarraPrincipal.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlBarraPrincipal.Location = new System.Drawing.Point(0, 0);
            this.pnlBarraPrincipal.Name = "pnlBarraPrincipal";
            this.pnlBarraPrincipal.Size = new System.Drawing.Size(772, 41);
            this.pnlBarraPrincipal.TabIndex = 13;
            // 
            // pnlModificar
            // 
            this.pnlModificar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(195)))), ((int)(((byte)(239)))));
            this.pnlModificar.Location = new System.Drawing.Point(657, 168);
            this.pnlModificar.Name = "pnlModificar";
            this.pnlModificar.Size = new System.Drawing.Size(5, 35);
            this.pnlModificar.TabIndex = 11;
            // 
            // pnlBorrar
            // 
            this.pnlBorrar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(121)))), ((int)(((byte)(116)))));
            this.pnlBorrar.Location = new System.Drawing.Point(657, 128);
            this.pnlBorrar.Name = "pnlBorrar";
            this.pnlBorrar.Size = new System.Drawing.Size(5, 35);
            this.pnlBorrar.TabIndex = 7;
            // 
            // pnlAgregar
            // 
            this.pnlAgregar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(198)))), ((int)(((byte)(46)))));
            this.pnlAgregar.Location = new System.Drawing.Point(657, 88);
            this.pnlAgregar.Name = "pnlAgregar";
            this.pnlAgregar.Size = new System.Drawing.Size(5, 35);
            this.pnlAgregar.TabIndex = 11;
            // 
            // btnAgregar
            // 
            this.btnAgregar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(115)))), ((int)(((byte)(149)))));
            this.btnAgregar.FlatAppearance.BorderSize = 0;
            this.btnAgregar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAgregar.Font = new System.Drawing.Font("Bebas", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAgregar.ForeColor = System.Drawing.Color.White;
            this.btnAgregar.Image = ((System.Drawing.Image)(resources.GetObject("btnAgregar.Image")));
            this.btnAgregar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAgregar.Location = new System.Drawing.Point(662, 88);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(90, 35);
            this.btnAgregar.TabIndex = 0;
            this.btnAgregar.Text = "        Agregar";
            this.btnAgregar.UseVisualStyleBackColor = false;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // btnBorrar
            // 
            this.btnBorrar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(115)))), ((int)(((byte)(149)))));
            this.btnBorrar.FlatAppearance.BorderSize = 0;
            this.btnBorrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBorrar.Font = new System.Drawing.Font("Bebas", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBorrar.ForeColor = System.Drawing.Color.White;
            this.btnBorrar.Image = ((System.Drawing.Image)(resources.GetObject("btnBorrar.Image")));
            this.btnBorrar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnBorrar.Location = new System.Drawing.Point(662, 128);
            this.btnBorrar.Name = "btnBorrar";
            this.btnBorrar.Size = new System.Drawing.Size(90, 35);
            this.btnBorrar.TabIndex = 0;
            this.btnBorrar.Text = "       Borrar";
            this.btnBorrar.UseVisualStyleBackColor = false;
            this.btnBorrar.Click += new System.EventHandler(this.btnBorrar_Click);
            // 
            // btnModificar
            // 
            this.btnModificar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(115)))), ((int)(((byte)(149)))));
            this.btnModificar.FlatAppearance.BorderSize = 0;
            this.btnModificar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnModificar.Font = new System.Drawing.Font("Bebas", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnModificar.ForeColor = System.Drawing.Color.White;
            this.btnModificar.Image = ((System.Drawing.Image)(resources.GetObject("btnModificar.Image")));
            this.btnModificar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnModificar.Location = new System.Drawing.Point(662, 168);
            this.btnModificar.Name = "btnModificar";
            this.btnModificar.Size = new System.Drawing.Size(90, 35);
            this.btnModificar.TabIndex = 0;
            this.btnModificar.Text = "        Modificar";
            this.btnModificar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnModificar.UseVisualStyleBackColor = false;
            this.btnModificar.Click += new System.EventHandler(this.btnModificar_Click);
            // 
            // panelContenedor
            // 
            this.panelContenedor.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelContenedor.Controls.Add(this.btnBuscar);
            this.panelContenedor.Controls.Add(this.lblCodigo);
            this.panelContenedor.Controls.Add(this.dgvListadoBusqueda);
            this.panelContenedor.Controls.Add(this.pboxCodigo);
            this.panelContenedor.Controls.Add(this.pnlImpuesto);
            this.panelContenedor.Controls.Add(this.pnlDescuento);
            this.panelContenedor.Controls.Add(this.panel1);
            this.panelContenedor.Controls.Add(this.pnlRubro);
            this.panelContenedor.Controls.Add(this.pnlDetalle);
            this.panelContenedor.Controls.Add(this.pnlModificar);
            this.panelContenedor.Controls.Add(this.tboxCodigo);
            this.panelContenedor.Controls.Add(this.btnAgregar);
            this.panelContenedor.Controls.Add(this.tboxNombre);
            this.panelContenedor.Controls.Add(this.pnlBorrar);
            this.panelContenedor.Controls.Add(this.pboxNombre);
            this.panelContenedor.Controls.Add(this.btnImpuesto);
            this.panelContenedor.Controls.Add(this.button1);
            this.panelContenedor.Controls.Add(this.btnDescuento);
            this.panelContenedor.Controls.Add(this.btnRubro);
            this.panelContenedor.Controls.Add(this.btnDetalle);
            this.panelContenedor.Controls.Add(this.btnModificar);
            this.panelContenedor.Controls.Add(this.lblNombre);
            this.panelContenedor.Controls.Add(this.btnBorrar);
            this.panelContenedor.Controls.Add(this.pnlAgregar);
            this.panelContenedor.Controls.Add(this.btnCancelar);
            this.panelContenedor.Location = new System.Drawing.Point(0, 35);
            this.panelContenedor.Name = "panelContenedor";
            this.panelContenedor.Size = new System.Drawing.Size(772, 506);
            this.panelContenedor.TabIndex = 23;
            // 
            // pnlImpuesto
            // 
            this.pnlImpuesto.BackColor = System.Drawing.Color.CadetBlue;
            this.pnlImpuesto.Location = new System.Drawing.Point(657, 250);
            this.pnlImpuesto.Name = "pnlImpuesto";
            this.pnlImpuesto.Size = new System.Drawing.Size(5, 35);
            this.pnlImpuesto.TabIndex = 11;
            this.pnlImpuesto.Visible = false;
            // 
            // pnlDescuento
            // 
            this.pnlDescuento.BackColor = System.Drawing.Color.OrangeRed;
            this.pnlDescuento.Location = new System.Drawing.Point(657, 250);
            this.pnlDescuento.Name = "pnlDescuento";
            this.pnlDescuento.Size = new System.Drawing.Size(5, 35);
            this.pnlDescuento.TabIndex = 11;
            this.pnlDescuento.Visible = false;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Gold;
            this.panel1.Location = new System.Drawing.Point(657, 250);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(5, 35);
            this.panel1.TabIndex = 11;
            this.panel1.Visible = false;
            // 
            // pnlRubro
            // 
            this.pnlRubro.BackColor = System.Drawing.Color.Gold;
            this.pnlRubro.Location = new System.Drawing.Point(657, 250);
            this.pnlRubro.Name = "pnlRubro";
            this.pnlRubro.Size = new System.Drawing.Size(5, 35);
            this.pnlRubro.TabIndex = 11;
            this.pnlRubro.Visible = false;
            // 
            // pnlDetalle
            // 
            this.pnlDetalle.BackColor = System.Drawing.Color.Orange;
            this.pnlDetalle.Location = new System.Drawing.Point(657, 209);
            this.pnlDetalle.Name = "pnlDetalle";
            this.pnlDetalle.Size = new System.Drawing.Size(5, 35);
            this.pnlDetalle.TabIndex = 11;
            // 
            // btnImpuesto
            // 
            this.btnImpuesto.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(115)))), ((int)(((byte)(149)))));
            this.btnImpuesto.FlatAppearance.BorderSize = 0;
            this.btnImpuesto.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnImpuesto.Font = new System.Drawing.Font("Bebas", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnImpuesto.ForeColor = System.Drawing.Color.White;
            this.btnImpuesto.Image = ((System.Drawing.Image)(resources.GetObject("btnImpuesto.Image")));
            this.btnImpuesto.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnImpuesto.Location = new System.Drawing.Point(662, 250);
            this.btnImpuesto.Name = "btnImpuesto";
            this.btnImpuesto.Size = new System.Drawing.Size(90, 35);
            this.btnImpuesto.TabIndex = 0;
            this.btnImpuesto.Text = "Impuestos";
            this.btnImpuesto.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnImpuesto.UseVisualStyleBackColor = false;
            this.btnImpuesto.Visible = false;
            this.btnImpuesto.Click += new System.EventHandler(this.btnImpuesto_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(115)))), ((int)(((byte)(149)))));
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Bebas", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Image = ((System.Drawing.Image)(resources.GetObject("button1.Image")));
            this.button1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button1.Location = new System.Drawing.Point(662, 250);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(90, 35);
            this.button1.TabIndex = 0;
            this.button1.Text = "RUBRO";
            this.button1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Visible = false;
            this.button1.Click += new System.EventHandler(this.btnRubro_Click);
            // 
            // btnDescuento
            // 
            this.btnDescuento.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(115)))), ((int)(((byte)(149)))));
            this.btnDescuento.FlatAppearance.BorderSize = 0;
            this.btnDescuento.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDescuento.Font = new System.Drawing.Font("Bebas", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDescuento.ForeColor = System.Drawing.Color.White;
            this.btnDescuento.Image = ((System.Drawing.Image)(resources.GetObject("btnDescuento.Image")));
            this.btnDescuento.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDescuento.Location = new System.Drawing.Point(662, 250);
            this.btnDescuento.Name = "btnDescuento";
            this.btnDescuento.Size = new System.Drawing.Size(90, 35);
            this.btnDescuento.TabIndex = 0;
            this.btnDescuento.Text = "Descuento";
            this.btnDescuento.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnDescuento.UseVisualStyleBackColor = false;
            this.btnDescuento.Visible = false;
            this.btnDescuento.Click += new System.EventHandler(this.btnDescuento_Click);
            // 
            // btnRubro
            // 
            this.btnRubro.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(115)))), ((int)(((byte)(149)))));
            this.btnRubro.FlatAppearance.BorderSize = 0;
            this.btnRubro.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRubro.Font = new System.Drawing.Font("Bebas", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRubro.ForeColor = System.Drawing.Color.White;
            this.btnRubro.Image = ((System.Drawing.Image)(resources.GetObject("btnRubro.Image")));
            this.btnRubro.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnRubro.Location = new System.Drawing.Point(662, 250);
            this.btnRubro.Name = "btnRubro";
            this.btnRubro.Size = new System.Drawing.Size(90, 35);
            this.btnRubro.TabIndex = 0;
            this.btnRubro.Text = "RUBRO";
            this.btnRubro.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnRubro.UseVisualStyleBackColor = false;
            this.btnRubro.Visible = false;
            this.btnRubro.Click += new System.EventHandler(this.btnRubro_Click);
            // 
            // btnDetalle
            // 
            this.btnDetalle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(115)))), ((int)(((byte)(149)))));
            this.btnDetalle.FlatAppearance.BorderSize = 0;
            this.btnDetalle.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDetalle.Font = new System.Drawing.Font("Bebas", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDetalle.ForeColor = System.Drawing.Color.White;
            this.btnDetalle.Image = ((System.Drawing.Image)(resources.GetObject("btnDetalle.Image")));
            this.btnDetalle.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDetalle.Location = new System.Drawing.Point(662, 209);
            this.btnDetalle.Name = "btnDetalle";
            this.btnDetalle.Size = new System.Drawing.Size(90, 35);
            this.btnDetalle.TabIndex = 0;
            this.btnDetalle.Text = "Detalle";
            this.btnDetalle.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnDetalle.UseVisualStyleBackColor = false;
            this.btnDetalle.Click += new System.EventHandler(this.btnDetalle_Click);
            // 
            // btnBuscar
            // 
            this.btnBuscar.Image = ((System.Drawing.Image)(resources.GetObject("btnBuscar.Image")));
            this.btnBuscar.Location = new System.Drawing.Point(549, 29);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(47, 42);
            this.btnBuscar.TabIndex = 24;
            this.btnBuscar.UseVisualStyleBackColor = true;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // FormularioListado
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(772, 541);
            this.Controls.Add(this.pnlBarraPrincipal);
            this.Controls.Add(this.panelContenedor);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormularioListado";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "FormularioBusquedaAmplio";
            this.Load += new System.EventHandler(this.FormularioListado_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pboxCodigo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvListadoBusqueda)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pboxNombre)).EndInit();
            this.pnlBarraPrincipal.ResumeLayout(false);
            this.pnlBarraPrincipal.PerformLayout();
            this.panelContenedor.ResumeLayout(false);
            this.panelContenedor.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.PictureBox pboxCodigo;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.TextBox tboxCodigo;
        private System.Windows.Forms.TextBox tboxNombre;
        private System.Windows.Forms.DataGridView dgvListadoBusqueda;
        private System.Windows.Forms.PictureBox pboxNombre;
        private System.Windows.Forms.Label lblCodigo;
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.Label lblNombreFormulario;
        private System.Windows.Forms.Panel pnlBarraPrincipal;
        private System.Windows.Forms.Panel pnlModificar;
        private System.Windows.Forms.Panel pnlBorrar;
        private System.Windows.Forms.Panel pnlAgregar;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.Button btnBorrar;
        private System.Windows.Forms.Button btnModificar;
        private System.Windows.Forms.Panel panelContenedor;
        private System.Windows.Forms.Panel pnlDescuento;
        private System.Windows.Forms.Panel pnlRubro;
        private System.Windows.Forms.Button btnDescuento;
        private System.Windows.Forms.Button btnRubro;
        private System.Windows.Forms.Panel pnlDetalle;
        private System.Windows.Forms.Button btnDetalle;
        private System.Windows.Forms.Panel pnlImpuesto;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnImpuesto;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btnBuscar;
    }
}