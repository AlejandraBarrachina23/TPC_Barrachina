namespace PresentacionWinForm
{
    partial class BusquedaCliente
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
            this.lbNombrePrograma = new System.Windows.Forms.Label();
            this.lblCodigoCliente = new System.Windows.Forms.Label();
            this.pboxCodigoCliente = new System.Windows.Forms.PictureBox();
            this.tboxCodigoCliente = new System.Windows.Forms.TextBox();
            this.tboxNombreCliente = new System.Windows.Forms.TextBox();
            this.pboxNombreCliente = new System.Windows.Forms.PictureBox();
            this.lblNombreCliente = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.btnAceptar = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.pnlBarraPrincipal.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pboxCodigoCliente)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pboxNombreCliente)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlBarraPrincipal
            // 
            this.pnlBarraPrincipal.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.pnlBarraPrincipal.Controls.Add(this.lbNombrePrograma);
            this.pnlBarraPrincipal.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlBarraPrincipal.Location = new System.Drawing.Point(0, 0);
            this.pnlBarraPrincipal.Name = "pnlBarraPrincipal";
            this.pnlBarraPrincipal.Size = new System.Drawing.Size(720, 41);
            this.pnlBarraPrincipal.TabIndex = 2;
            // 
            // lbNombrePrograma
            // 
            this.lbNombrePrograma.AutoSize = true;
            this.lbNombrePrograma.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbNombrePrograma.Location = new System.Drawing.Point(313, 14);
            this.lbNombrePrograma.Name = "lbNombrePrograma";
            this.lbNombrePrograma.Size = new System.Drawing.Size(131, 13);
            this.lbNombrePrograma.TabIndex = 8;
            this.lbNombrePrograma.Text = "BUSQUEDA CLIENTE";
            // 
            // lblCodigoCliente
            // 
            this.lblCodigoCliente.AutoSize = true;
            this.lblCodigoCliente.Location = new System.Drawing.Point(54, 80);
            this.lblCodigoCliente.Name = "lblCodigoCliente";
            this.lblCodigoCliente.Size = new System.Drawing.Size(40, 13);
            this.lblCodigoCliente.TabIndex = 7;
            this.lblCodigoCliente.Text = "Codigo";
            // 
            // pboxCodigoCliente
            // 
            this.pboxCodigoCliente.Location = new System.Drawing.Point(103, 72);
            this.pboxCodigoCliente.Name = "pboxCodigoCliente";
            this.pboxCodigoCliente.Size = new System.Drawing.Size(31, 31);
            this.pboxCodigoCliente.TabIndex = 6;
            this.pboxCodigoCliente.TabStop = false;
            // 
            // tboxCodigoCliente
            // 
            this.tboxCodigoCliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tboxCodigoCliente.Location = new System.Drawing.Point(132, 72);
            this.tboxCodigoCliente.Name = "tboxCodigoCliente";
            this.tboxCodigoCliente.Size = new System.Drawing.Size(155, 31);
            this.tboxCodigoCliente.TabIndex = 5;
            // 
            // tboxNombreCliente
            // 
            this.tboxNombreCliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tboxNombreCliente.Location = new System.Drawing.Point(378, 72);
            this.tboxNombreCliente.Name = "tboxNombreCliente";
            this.tboxNombreCliente.Size = new System.Drawing.Size(155, 31);
            this.tboxNombreCliente.TabIndex = 5;
            // 
            // pboxNombreCliente
            // 
            this.pboxNombreCliente.Location = new System.Drawing.Point(349, 72);
            this.pboxNombreCliente.Name = "pboxNombreCliente";
            this.pboxNombreCliente.Size = new System.Drawing.Size(31, 31);
            this.pboxNombreCliente.TabIndex = 6;
            this.pboxNombreCliente.TabStop = false;
            // 
            // lblNombreCliente
            // 
            this.lblNombreCliente.AutoSize = true;
            this.lblNombreCliente.Location = new System.Drawing.Point(300, 80);
            this.lblNombreCliente.Name = "lblNombreCliente";
            this.lblNombreCliente.Size = new System.Drawing.Size(44, 13);
            this.lblNombreCliente.TabIndex = 7;
            this.lblNombreCliente.Text = "Nombre";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(34, 120);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(656, 194);
            this.dataGridView1.TabIndex = 8;
            // 
            // btnBuscar
            // 
            this.btnBuscar.Location = new System.Drawing.Point(551, 72);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(110, 31);
            this.btnBuscar.TabIndex = 9;
            this.btnBuscar.Text = "Buscar";
            this.btnBuscar.UseVisualStyleBackColor = true;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // btnAceptar
            // 
            this.btnAceptar.Location = new System.Drawing.Point(270, 335);
            this.btnAceptar.Name = "btnAceptar";
            this.btnAceptar.Size = new System.Drawing.Size(110, 31);
            this.btnAceptar.TabIndex = 9;
            this.btnAceptar.Text = "Aceptar";
            this.btnAceptar.UseVisualStyleBackColor = true;
            // 
            // btnCancelar
            // 
            this.btnCancelar.Location = new System.Drawing.Point(386, 335);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(110, 31);
            this.btnCancelar.TabIndex = 9;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            // 
            // BusquedaCliente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(720, 400);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnAceptar);
            this.Controls.Add(this.btnBuscar);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.lblNombreCliente);
            this.Controls.Add(this.lblCodigoCliente);
            this.Controls.Add(this.pboxNombreCliente);
            this.Controls.Add(this.tboxNombreCliente);
            this.Controls.Add(this.pboxCodigoCliente);
            this.Controls.Add(this.tboxCodigoCliente);
            this.Controls.Add(this.pnlBarraPrincipal);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "BusquedaCliente";
            this.Text = "BusquedaCliente";
            this.pnlBarraPrincipal.ResumeLayout(false);
            this.pnlBarraPrincipal.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pboxCodigoCliente)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pboxNombreCliente)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel pnlBarraPrincipal;
        private System.Windows.Forms.Label lbNombrePrograma;
        private System.Windows.Forms.Label lblCodigoCliente;
        private System.Windows.Forms.PictureBox pboxCodigoCliente;
        private System.Windows.Forms.TextBox tboxCodigoCliente;
        private System.Windows.Forms.TextBox tboxNombreCliente;
        private System.Windows.Forms.PictureBox pboxNombreCliente;
        private System.Windows.Forms.Label lblNombreCliente;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.Button btnAceptar;
        private System.Windows.Forms.Button btnCancelar;
    }
}