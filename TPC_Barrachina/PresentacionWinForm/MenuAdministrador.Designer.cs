namespace PresentacionWinForm
{
    partial class MenuAdministrador
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MenuAdministrador));
            this.pnlBarraPrincipal = new System.Windows.Forms.Panel();
            this.lbNombrePrograma = new System.Windows.Forms.Label();
            this.btnVentas = new System.Windows.Forms.Button();
            this.btnProveedor = new System.Windows.Forms.Button();
            this.btnClientes = new System.Windows.Forms.Button();
            this.btnCompras = new System.Windows.Forms.Button();
            this.btnProductos = new System.Windows.Forms.Button();
            this.lblCompras = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.panel5 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.panel6 = new System.Windows.Forms.Panel();
            this.panel7 = new System.Windows.Forms.Panel();
            this.panel8 = new System.Windows.Forms.Panel();
            this.panel9 = new System.Windows.Forms.Panel();
            this.panelMenu = new System.Windows.Forms.Panel();
            this.pnlBarraPrincipal.SuspendLayout();
            this.panelMenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlBarraPrincipal
            // 
            this.pnlBarraPrincipal.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(115)))), ((int)(((byte)(149)))));
            this.pnlBarraPrincipal.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.pnlBarraPrincipal.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pnlBarraPrincipal.Controls.Add(this.lbNombrePrograma);
            this.pnlBarraPrincipal.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlBarraPrincipal.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.pnlBarraPrincipal.Location = new System.Drawing.Point(0, 0);
            this.pnlBarraPrincipal.Name = "pnlBarraPrincipal";
            this.pnlBarraPrincipal.Size = new System.Drawing.Size(1278, 41);
            this.pnlBarraPrincipal.TabIndex = 2;
            // 
            // lbNombrePrograma
            // 
            this.lbNombrePrograma.AutoSize = true;
            this.lbNombrePrograma.Font = new System.Drawing.Font("Bebas", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbNombrePrograma.ForeColor = System.Drawing.Color.White;
            this.lbNombrePrograma.Location = new System.Drawing.Point(555, 4);
            this.lbNombrePrograma.Name = "lbNombrePrograma";
            this.lbNombrePrograma.Size = new System.Drawing.Size(165, 25);
            this.lbNombrePrograma.TabIndex = 9;
            this.lbNombrePrograma.Text = "NOMBRE PROGRAMA";
            // 
            // btnVentas
            // 
            this.btnVentas.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnVentas.FlatAppearance.BorderSize = 0;
            this.btnVentas.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnVentas.ForeColor = System.Drawing.Color.White;
            this.btnVentas.Image = ((System.Drawing.Image)(resources.GetObject("btnVentas.Image")));
            this.btnVentas.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnVentas.Location = new System.Drawing.Point(-1, 69);
            this.btnVentas.Name = "btnVentas";
            this.btnVentas.Size = new System.Drawing.Size(100, 60);
            this.btnVentas.TabIndex = 0;
            this.btnVentas.Text = "Vender";
            this.btnVentas.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnVentas.UseVisualStyleBackColor = true;
            this.btnVentas.Click += new System.EventHandler(this.btnVentas_Click);
            // 
            // btnProveedor
            // 
            this.btnProveedor.FlatAppearance.BorderSize = 0;
            this.btnProveedor.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnProveedor.ForeColor = System.Drawing.Color.White;
            this.btnProveedor.Image = ((System.Drawing.Image)(resources.GetObject("btnProveedor.Image")));
            this.btnProveedor.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnProveedor.Location = new System.Drawing.Point(-1, 316);
            this.btnProveedor.Name = "btnProveedor";
            this.btnProveedor.Size = new System.Drawing.Size(100, 60);
            this.btnProveedor.TabIndex = 0;
            this.btnProveedor.Text = "Proveedores";
            this.btnProveedor.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnProveedor.UseVisualStyleBackColor = true;
            this.btnProveedor.Click += new System.EventHandler(this.btnProveedor_Click);
            // 
            // btnClientes
            // 
            this.btnClientes.FlatAppearance.BorderSize = 0;
            this.btnClientes.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClientes.ForeColor = System.Drawing.Color.White;
            this.btnClientes.Image = ((System.Drawing.Image)(resources.GetObject("btnClientes.Image")));
            this.btnClientes.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnClientes.Location = new System.Drawing.Point(0, 135);
            this.btnClientes.Name = "btnClientes";
            this.btnClientes.Size = new System.Drawing.Size(100, 60);
            this.btnClientes.TabIndex = 0;
            this.btnClientes.Text = "Clientes";
            this.btnClientes.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnClientes.UseVisualStyleBackColor = true;
            this.btnClientes.Click += new System.EventHandler(this.btnClientes_Click);
            // 
            // btnCompras
            // 
            this.btnCompras.FlatAppearance.BorderSize = 0;
            this.btnCompras.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCompras.ForeColor = System.Drawing.Color.White;
            this.btnCompras.Image = ((System.Drawing.Image)(resources.GetObject("btnCompras.Image")));
            this.btnCompras.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnCompras.Location = new System.Drawing.Point(-1, 250);
            this.btnCompras.Name = "btnCompras";
            this.btnCompras.Size = new System.Drawing.Size(100, 60);
            this.btnCompras.TabIndex = 0;
            this.btnCompras.Text = "Comprar";
            this.btnCompras.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnCompras.UseVisualStyleBackColor = true;
            this.btnCompras.Click += new System.EventHandler(this.btnCompras_Click);
            // 
            // btnProductos
            // 
            this.btnProductos.FlatAppearance.BorderSize = 0;
            this.btnProductos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnProductos.ForeColor = System.Drawing.Color.White;
            this.btnProductos.Image = ((System.Drawing.Image)(resources.GetObject("btnProductos.Image")));
            this.btnProductos.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnProductos.Location = new System.Drawing.Point(2, 383);
            this.btnProductos.Name = "btnProductos";
            this.btnProductos.Size = new System.Drawing.Size(100, 60);
            this.btnProductos.TabIndex = 0;
            this.btnProductos.Text = "Productos";
            this.btnProductos.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnProductos.UseVisualStyleBackColor = true;
            this.btnProductos.Click += new System.EventHandler(this.btnProductos_Click);
            // 
            // lblCompras
            // 
            this.lblCompras.AutoSize = true;
            this.lblCompras.Font = new System.Drawing.Font("Bebas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCompras.ForeColor = System.Drawing.Color.White;
            this.lblCompras.Location = new System.Drawing.Point(-3, 222);
            this.lblCompras.Name = "lblCompras";
            this.lblCompras.Size = new System.Drawing.Size(61, 19);
            this.lblCompras.TabIndex = 1;
            this.lblCompras.Text = "Compras";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Bebas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(-2, 45);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(50, 19);
            this.label3.TabIndex = 1;
            this.label3.Text = "Ventas";
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(121)))), ((int)(((byte)(116)))));
            this.panel5.Location = new System.Drawing.Point(-1, 250);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(5, 60);
            this.panel5.TabIndex = 6;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(195)))), ((int)(((byte)(239)))));
            this.panel2.Location = new System.Drawing.Point(-1, 383);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(5, 60);
            this.panel2.TabIndex = 7;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(169)))), ((int)(((byte)(38)))));
            this.panel4.Location = new System.Drawing.Point(-1, 135);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(5, 60);
            this.panel4.TabIndex = 5;
            // 
            // panel6
            // 
            this.panel6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(122)))), ((int)(((byte)(203)))));
            this.panel6.Location = new System.Drawing.Point(-1, 316);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(5, 60);
            this.panel6.TabIndex = 9;
            // 
            // panel7
            // 
            this.panel7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(220)))), ((int)(((byte)(70)))));
            this.panel7.Location = new System.Drawing.Point(-1, 69);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(5, 60);
            this.panel7.TabIndex = 10;
            // 
            // panel8
            // 
            this.panel8.BackColor = System.Drawing.Color.White;
            this.panel8.Location = new System.Drawing.Point(-2, 244);
            this.panel8.Name = "panel8";
            this.panel8.Size = new System.Drawing.Size(105, 2);
            this.panel8.TabIndex = 11;
            // 
            // panel9
            // 
            this.panel9.BackColor = System.Drawing.Color.White;
            this.panel9.Location = new System.Drawing.Point(1, 64);
            this.panel9.Name = "panel9";
            this.panel9.Size = new System.Drawing.Size(105, 2);
            this.panel9.TabIndex = 11;
            // 
            // panelMenu
            // 
            this.panelMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(115)))), ((int)(((byte)(149)))));
            this.panelMenu.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panelMenu.Controls.Add(this.panel9);
            this.panelMenu.Controls.Add(this.panel8);
            this.panelMenu.Controls.Add(this.panel7);
            this.panelMenu.Controls.Add(this.panel6);
            this.panelMenu.Controls.Add(this.panel4);
            this.panelMenu.Controls.Add(this.panel2);
            this.panelMenu.Controls.Add(this.panel5);
            this.panelMenu.Controls.Add(this.label3);
            this.panelMenu.Controls.Add(this.lblCompras);
            this.panelMenu.Controls.Add(this.btnProductos);
            this.panelMenu.Controls.Add(this.btnCompras);
            this.panelMenu.Controls.Add(this.btnClientes);
            this.panelMenu.Controls.Add(this.btnProveedor);
            this.panelMenu.Controls.Add(this.btnVentas);
            this.panelMenu.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelMenu.Font = new System.Drawing.Font("Bebas", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panelMenu.Location = new System.Drawing.Point(0, 41);
            this.panelMenu.Name = "panelMenu";
            this.panelMenu.Size = new System.Drawing.Size(105, 556);
            this.panelMenu.TabIndex = 3;
            // 
            // MenuAdministrador
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1278, 597);
            this.Controls.Add(this.panelMenu);
            this.Controls.Add(this.pnlBarraPrincipal);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.IsMdiContainer = true;
            this.Name = "MenuAdministrador";
            this.Text = "Reportes";
            this.pnlBarraPrincipal.ResumeLayout(false);
            this.pnlBarraPrincipal.PerformLayout();
            this.panelMenu.ResumeLayout(false);
            this.panelMenu.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel pnlBarraPrincipal;
        private System.Windows.Forms.Label lbNombrePrograma;
        private System.Windows.Forms.Button btnVentas;
        private System.Windows.Forms.Button btnProveedor;
        private System.Windows.Forms.Button btnClientes;
        private System.Windows.Forms.Button btnCompras;
        private System.Windows.Forms.Button btnProductos;
        private System.Windows.Forms.Label lblCompras;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Panel panel7;
        private System.Windows.Forms.Panel panel8;
        private System.Windows.Forms.Panel panel9;
        private System.Windows.Forms.Panel panelMenu;
    }
}