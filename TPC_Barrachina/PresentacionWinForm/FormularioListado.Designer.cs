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
            this.panel13 = new System.Windows.Forms.Panel();
            this.panel12 = new System.Windows.Forms.Panel();
            this.panel11 = new System.Windows.Forms.Panel();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.btnBorrar = new System.Windows.Forms.Button();
            this.btnModificar = new System.Windows.Forms.Button();
            this.panelContenedor = new System.Windows.Forms.Panel();
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
            this.pboxCodigo.Location = new System.Drawing.Point(98, 32);
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
            this.btnCancelar.Location = new System.Drawing.Point(696, 426);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(94, 37);
            this.btnCancelar.TabIndex = 22;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnCancelar.UseVisualStyleBackColor = false;
            // 
            // tboxCodigo
            // 
            this.tboxCodigo.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tboxCodigo.Location = new System.Drawing.Point(132, 32);
            this.tboxCodigo.Name = "tboxCodigo";
            this.tboxCodigo.Size = new System.Drawing.Size(155, 31);
            this.tboxCodigo.TabIndex = 14;
            // 
            // tboxNombre
            // 
            this.tboxNombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tboxNombre.Location = new System.Drawing.Point(465, 32);
            this.tboxNombre.Name = "tboxNombre";
            this.tboxNombre.Size = new System.Drawing.Size(155, 31);
            this.tboxNombre.TabIndex = 15;
            // 
            // dgvListadoBusqueda
            // 
            this.dgvListadoBusqueda.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvListadoBusqueda.Location = new System.Drawing.Point(12, 88);
            this.dgvListadoBusqueda.Name = "dgvListadoBusqueda";
            this.dgvListadoBusqueda.ReadOnly = true;
            this.dgvListadoBusqueda.Size = new System.Drawing.Size(656, 391);
            this.dgvListadoBusqueda.TabIndex = 20;
            // 
            // pboxNombre
            // 
            this.pboxNombre.Image = ((System.Drawing.Image)(resources.GetObject("pboxNombre.Image")));
            this.pboxNombre.Location = new System.Drawing.Point(430, 32);
            this.pboxNombre.Name = "pboxNombre";
            this.pboxNombre.Size = new System.Drawing.Size(31, 31);
            this.pboxNombre.TabIndex = 17;
            this.pboxNombre.TabStop = false;
            // 
            // lblCodigo
            // 
            this.lblCodigo.AutoSize = true;
            this.lblCodigo.Location = new System.Drawing.Point(54, 42);
            this.lblCodigo.Name = "lblCodigo";
            this.lblCodigo.Size = new System.Drawing.Size(40, 13);
            this.lblCodigo.TabIndex = 18;
            this.lblCodigo.Text = "Codigo";
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.Location = new System.Drawing.Point(383, 40);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(44, 13);
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
            this.pnlBarraPrincipal.Size = new System.Drawing.Size(808, 41);
            this.pnlBarraPrincipal.TabIndex = 13;
            // 
            // panel13
            // 
            this.panel13.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(195)))), ((int)(((byte)(239)))));
            this.panel13.Location = new System.Drawing.Point(691, 168);
            this.panel13.Name = "panel13";
            this.panel13.Size = new System.Drawing.Size(5, 35);
            this.panel13.TabIndex = 11;
            // 
            // panel12
            // 
            this.panel12.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(121)))), ((int)(((byte)(116)))));
            this.panel12.Location = new System.Drawing.Point(691, 128);
            this.panel12.Name = "panel12";
            this.panel12.Size = new System.Drawing.Size(5, 35);
            this.panel12.TabIndex = 7;
            // 
            // panel11
            // 
            this.panel11.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(198)))), ((int)(((byte)(46)))));
            this.panel11.Location = new System.Drawing.Point(691, 88);
            this.panel11.Name = "panel11";
            this.panel11.Size = new System.Drawing.Size(5, 35);
            this.panel11.TabIndex = 11;
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
            this.btnAgregar.Location = new System.Drawing.Point(696, 88);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(90, 35);
            this.btnAgregar.TabIndex = 0;
            this.btnAgregar.Text = "        Agregar";
            this.btnAgregar.UseVisualStyleBackColor = false;
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
            this.btnBorrar.Location = new System.Drawing.Point(696, 128);
            this.btnBorrar.Name = "btnBorrar";
            this.btnBorrar.Size = new System.Drawing.Size(90, 35);
            this.btnBorrar.TabIndex = 0;
            this.btnBorrar.Text = "       Borrar";
            this.btnBorrar.UseVisualStyleBackColor = false;
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
            this.btnModificar.Location = new System.Drawing.Point(696, 168);
            this.btnModificar.Name = "btnModificar";
            this.btnModificar.Size = new System.Drawing.Size(90, 35);
            this.btnModificar.TabIndex = 0;
            this.btnModificar.Text = "        Modificar";
            this.btnModificar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnModificar.UseVisualStyleBackColor = false;
            // 
            // panelContenedor
            // 
            this.panelContenedor.Controls.Add(this.lblCodigo);
            this.panelContenedor.Controls.Add(this.dgvListadoBusqueda);
            this.panelContenedor.Controls.Add(this.pboxCodigo);
            this.panelContenedor.Controls.Add(this.panel13);
            this.panelContenedor.Controls.Add(this.tboxCodigo);
            this.panelContenedor.Controls.Add(this.btnAgregar);
            this.panelContenedor.Controls.Add(this.tboxNombre);
            this.panelContenedor.Controls.Add(this.panel12);
            this.panelContenedor.Controls.Add(this.pboxNombre);
            this.panelContenedor.Controls.Add(this.btnModificar);
            this.panelContenedor.Controls.Add(this.lblNombre);
            this.panelContenedor.Controls.Add(this.btnBorrar);
            this.panelContenedor.Controls.Add(this.panel11);
            this.panelContenedor.Controls.Add(this.btnCancelar);
            this.panelContenedor.Location = new System.Drawing.Point(0, 47);
            this.panelContenedor.Name = "panelContenedor";
            this.panelContenedor.Size = new System.Drawing.Size(808, 482);
            this.panelContenedor.TabIndex = 23;
            // 
            // FormularioListado
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(808, 528);
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
        private System.Windows.Forms.Panel panel13;
        private System.Windows.Forms.Panel panel12;
        private System.Windows.Forms.Panel panel11;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.Button btnBorrar;
        private System.Windows.Forms.Button btnModificar;
        private System.Windows.Forms.Panel panelContenedor;
    }
}