namespace PresentacionWinForm
{
    partial class InicioSesion
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(InicioSesion));
            this.panel3 = new System.Windows.Forms.Panel();
            this.tboxUsuario = new System.Windows.Forms.TextBox();
            this.tboxContrasenia = new System.Windows.Forms.TextBox();
            this.pboxConstrasenia = new System.Windows.Forms.PictureBox();
            this.btnAceptar = new System.Windows.Forms.Button();
            this.btnCerrar = new System.Windows.Forms.Button();
            this.pnlContrasenia = new System.Windows.Forms.Panel();
            this.pnlUsuario = new System.Windows.Forms.Panel();
            this.pboxLogin = new System.Windows.Forms.PictureBox();
            this.lblAdvertencia = new System.Windows.Forms.Label();
            this.pnlLogin = new System.Windows.Forms.Panel();
            this.lblInicioSesion = new System.Windows.Forms.Label();
            this.pboxUsuario = new System.Windows.Forms.PictureBox();
            this.panel4 = new System.Windows.Forms.Panel();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pboxConstrasenia)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pboxLogin)).BeginInit();
            this.pnlLogin.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pboxUsuario)).BeginInit();
            this.SuspendLayout();
            // 
            // panel3
            // 
            this.panel3.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel3.BackgroundImage")));
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel3.Controls.Add(this.pnlLogin);
            this.panel3.Location = new System.Drawing.Point(0, -1);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(660, 452);
            this.panel3.TabIndex = 2;
            // 
            // tboxUsuario
            // 
            this.tboxUsuario.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(231)))), ((int)(((byte)(204)))));
            this.tboxUsuario.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tboxUsuario.Font = new System.Drawing.Font("Oswald Regular", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tboxUsuario.Location = new System.Drawing.Point(115, 201);
            this.tboxUsuario.Name = "tboxUsuario";
            this.tboxUsuario.Size = new System.Drawing.Size(155, 22);
            this.tboxUsuario.TabIndex = 0;
            this.tboxUsuario.Text = "Usuario";
            this.tboxUsuario.Click += new System.EventHandler(this.tboxUsuario_Click);
            // 
            // tboxContrasenia
            // 
            this.tboxContrasenia.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(231)))), ((int)(((byte)(204)))));
            this.tboxContrasenia.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tboxContrasenia.Font = new System.Drawing.Font("Oswald Regular", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tboxContrasenia.Location = new System.Drawing.Point(117, 259);
            this.tboxContrasenia.Name = "tboxContrasenia";
            this.tboxContrasenia.PasswordChar = '*';
            this.tboxContrasenia.Size = new System.Drawing.Size(153, 22);
            this.tboxContrasenia.TabIndex = 1;
            this.tboxContrasenia.Text = "Contraseña";
            this.tboxContrasenia.Click += new System.EventHandler(this.tboxContrasenia_Click);
            // 
            // pboxConstrasenia
            // 
            this.pboxConstrasenia.Image = ((System.Drawing.Image)(resources.GetObject("pboxConstrasenia.Image")));
            this.pboxConstrasenia.Location = new System.Drawing.Point(67, 241);
            this.pboxConstrasenia.Name = "pboxConstrasenia";
            this.pboxConstrasenia.Size = new System.Drawing.Size(33, 44);
            this.pboxConstrasenia.TabIndex = 2;
            this.pboxConstrasenia.TabStop = false;
            // 
            // btnAceptar
            // 
            this.btnAceptar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(115)))), ((int)(((byte)(149)))));
            this.btnAceptar.FlatAppearance.BorderSize = 0;
            this.btnAceptar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAceptar.Font = new System.Drawing.Font("Bebas", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAceptar.ForeColor = System.Drawing.Color.White;
            this.btnAceptar.Location = new System.Drawing.Point(69, 302);
            this.btnAceptar.Name = "btnAceptar";
            this.btnAceptar.Size = new System.Drawing.Size(188, 37);
            this.btnAceptar.TabIndex = 3;
            this.btnAceptar.Text = "ingresar";
            this.btnAceptar.UseVisualStyleBackColor = false;
            this.btnAceptar.Click += new System.EventHandler(this.btnAceptar_Click);
            // 
            // btnCerrar
            // 
            this.btnCerrar.FlatAppearance.BorderSize = 0;
            this.btnCerrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCerrar.Image = ((System.Drawing.Image)(resources.GetObject("btnCerrar.Image")));
            this.btnCerrar.Location = new System.Drawing.Point(295, 0);
            this.btnCerrar.Name = "btnCerrar";
            this.btnCerrar.Size = new System.Drawing.Size(34, 35);
            this.btnCerrar.TabIndex = 4;
            this.btnCerrar.UseVisualStyleBackColor = true;
            this.btnCerrar.Click += new System.EventHandler(this.btnCerrar_Click);
            // 
            // pnlContrasenia
            // 
            this.pnlContrasenia.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(115)))), ((int)(((byte)(149)))));
            this.pnlContrasenia.Location = new System.Drawing.Point(71, 282);
            this.pnlContrasenia.Name = "pnlContrasenia";
            this.pnlContrasenia.Size = new System.Drawing.Size(186, 2);
            this.pnlContrasenia.TabIndex = 5;
            // 
            // pnlUsuario
            // 
            this.pnlUsuario.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(115)))), ((int)(((byte)(149)))));
            this.pnlUsuario.Location = new System.Drawing.Point(71, 229);
            this.pnlUsuario.Name = "pnlUsuario";
            this.pnlUsuario.Size = new System.Drawing.Size(186, 2);
            this.pnlUsuario.TabIndex = 6;
            // 
            // pboxLogin
            // 
            this.pboxLogin.Image = ((System.Drawing.Image)(resources.GetObject("pboxLogin.Image")));
            this.pboxLogin.Location = new System.Drawing.Point(135, 81);
            this.pboxLogin.Name = "pboxLogin";
            this.pboxLogin.Size = new System.Drawing.Size(66, 68);
            this.pboxLogin.TabIndex = 0;
            this.pboxLogin.TabStop = false;
            // 
            // lblAdvertencia
            // 
            this.lblAdvertencia.AutoSize = true;
            this.lblAdvertencia.Font = new System.Drawing.Font("Oswald", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAdvertencia.ForeColor = System.Drawing.Color.Red;
            this.lblAdvertencia.Location = new System.Drawing.Point(76, 361);
            this.lblAdvertencia.Name = "lblAdvertencia";
            this.lblAdvertencia.Size = new System.Drawing.Size(172, 17);
            this.lblAdvertencia.TabIndex = 7;
            this.lblAdvertencia.Text = "Usuario/Contraseña Incorrecta";
            this.lblAdvertencia.Visible = false;
            // 
            // pnlLogin
            // 
            this.pnlLogin.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(231)))), ((int)(((byte)(204)))));
            this.pnlLogin.Controls.Add(this.panel4);
            this.pnlLogin.Controls.Add(this.lblInicioSesion);
            this.pnlLogin.Controls.Add(this.lblAdvertencia);
            this.pnlLogin.Controls.Add(this.pboxLogin);
            this.pnlLogin.Controls.Add(this.pnlUsuario);
            this.pnlLogin.Controls.Add(this.pnlContrasenia);
            this.pnlLogin.Controls.Add(this.btnCerrar);
            this.pnlLogin.Controls.Add(this.btnAceptar);
            this.pnlLogin.Controls.Add(this.pboxConstrasenia);
            this.pnlLogin.Controls.Add(this.tboxContrasenia);
            this.pnlLogin.Controls.Add(this.pboxUsuario);
            this.pnlLogin.Controls.Add(this.tboxUsuario);
            this.pnlLogin.Location = new System.Drawing.Point(329, 0);
            this.pnlLogin.Name = "pnlLogin";
            this.pnlLogin.Size = new System.Drawing.Size(329, 453);
            this.pnlLogin.TabIndex = 1;
            // 
            // lblInicioSesion
            // 
            this.lblInicioSesion.AutoSize = true;
            this.lblInicioSesion.Font = new System.Drawing.Font("Oswald", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblInicioSesion.ForeColor = System.Drawing.Color.Black;
            this.lblInicioSesion.Location = new System.Drawing.Point(132, 170);
            this.lblInicioSesion.Name = "lblInicioSesion";
            this.lblInicioSesion.Size = new System.Drawing.Size(79, 17);
            this.lblInicioSesion.TabIndex = 7;
            this.lblInicioSesion.Text = "Iniciar Sesión";
            // 
            // pboxUsuario
            // 
            this.pboxUsuario.Image = ((System.Drawing.Image)(resources.GetObject("pboxUsuario.Image")));
            this.pboxUsuario.Location = new System.Drawing.Point(67, 195);
            this.pboxUsuario.Name = "pboxUsuario";
            this.pboxUsuario.Size = new System.Drawing.Size(42, 40);
            this.pboxUsuario.TabIndex = 2;
            this.pboxUsuario.TabStop = false;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(115)))), ((int)(((byte)(149)))));
            this.panel4.Location = new System.Drawing.Point(0, 0);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(1, 450);
            this.panel4.TabIndex = 8;
            // 
            // InicioSesion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(659, 450);
            this.Controls.Add(this.panel3);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "InicioSesion";
            this.Opacity = 0.95D;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "InicioSesion";
            this.panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pboxConstrasenia)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pboxLogin)).EndInit();
            this.pnlLogin.ResumeLayout(false);
            this.pnlLogin.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pboxUsuario)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel pnlLogin;
        private System.Windows.Forms.Label lblAdvertencia;
        private System.Windows.Forms.PictureBox pboxLogin;
        private System.Windows.Forms.Panel pnlUsuario;
        private System.Windows.Forms.Panel pnlContrasenia;
        private System.Windows.Forms.Button btnCerrar;
        private System.Windows.Forms.Button btnAceptar;
        private System.Windows.Forms.PictureBox pboxConstrasenia;
        private System.Windows.Forms.TextBox tboxContrasenia;
        private System.Windows.Forms.TextBox tboxUsuario;
        private System.Windows.Forms.Label lblInicioSesion;
        private System.Windows.Forms.PictureBox pboxUsuario;
        private System.Windows.Forms.Panel panel4;
    }
}