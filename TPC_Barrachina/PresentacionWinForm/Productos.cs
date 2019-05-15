﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Negocio;


namespace PresentacionWinForm
{
    public partial class Productos : Form
    {
        ValidadorDatos ValidarDatos = new ValidadorDatos();
        Utilidades Utilidades = new Utilidades();
        private string RutaIconosOpcionCorrecta = Application.StartupPath + "/Iconos/OpcionCorrecta.png";
        private string RutaIconosOpcionIncorrecta = Application.StartupPath + "/Iconos/OpcionIncorrecta.png";

        public Productos()
        {
            InitializeComponent();

            void AsignarSoloNumeros(object sender, KeyPressEventArgs e)
            {
                TextBox Tbox = new TextBox();

                if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
                {
                    e.Handled = true;

                }
            }
            //Asigno el evento a cada uno de los tbox que necesiten validar que no se ingrese texto 
            tboxCodigoBulto.KeyPress += AsignarSoloNumeros;
            tboxCodigoProducto.KeyPress += AsignarSoloNumeros;
            tboxStockCritico.KeyPress += AsignarSoloNumeros;
            tboxCantidadBulto.KeyPress += AsignarSoloNumeros;
        }

        private void Productos_Load(object sender, EventArgs e)
        {
            cboxTipoProducto = Utilidades.CargaComboBox(cboxTipoProducto, "SELECT Nombre FROM TipoProductos", "Nombre");
            cboxRubro = Utilidades.CargaComboBox(cboxRubro, "SELECT Nombre FROM Rubros", "Nombre");
            cboxProveedor = Utilidades.CargaComboBox(cboxProveedor, "SELECT PersonaJuridicas.NombreFantasia FROM PersonaJuridicas INNER JOIN Proveedores ON CodigoInformacionEmpresa = PersonaJuridicas.CodigoPersonaJuridica", "NombreFantasia");
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            //Avisos FormularioAviso = new Avisos();
            //FormularioAviso.Show(this);
        }

        private void tboxCodigoProducto_TextChanged(object sender, EventArgs e)
        {
            
            if (ValidarDatos.ContenidoTextBox(tboxCodigoProducto)) {

                pboxProducto.Image = Image.FromFile(RutaIconosOpcionIncorrecta);
                lblErrorCodigoProducto.Text = "Código Vacío.";
            }

            else if (ValidarDatos.ExistenciaDeDatoDB("Codigo", "Productos", tboxCodigoProducto.Text))
            {
                pboxProducto.Image = Image.FromFile(RutaIconosOpcionIncorrecta);
                lblErrorCodigoProducto.Text = "Repetido"; ;
            }
            else {
                pboxProducto.Image = Image.FromFile(RutaIconosOpcionCorrecta);
                lblErrorCodigoProducto.Text = "Correcto";
            }
                        
        }

        private void tboxCodigoBulto_TextChanged(object sender, EventArgs e)
        {
            if (ValidarDatos.ContenidoTextBox(tboxCodigoBulto))
            {
                pboxCodigoBulto.Image = Image.FromFile(RutaIconosOpcionIncorrecta);
                lblErrorCodigoBulto.Text = "Vacío.";
            }

            else if (ValidarDatos.ExistenciaDeDatoDB("CodigoBulto", "Productos", tboxCodigoBulto.Text))
            {
                pboxCodigoBulto.Image = Image.FromFile(RutaIconosOpcionIncorrecta);
                lblErrorCodigoBulto.Text = "Repetido";
            }
            else
            {
                pboxCodigoBulto.Image = Image.FromFile(RutaIconosOpcionCorrecta);
                lblErrorCodigoBulto.Text = "Correcto";
            }
        }

        private void tboxNombre_TextChanged(object sender, EventArgs e)
        {
            if (ValidarDatos.ContenidoTextBox(tboxNombre))
            {
                pboxNombre.Image = Image.FromFile(RutaIconosOpcionIncorrecta);
                lblErrorNombre.Text = "Vacío.";
            }

            else if (ValidarDatos.ExistenciaDeDatoDB("Nombre", "Productos", tboxNombre.Text))
            {
                pboxNombre.Image = Image.FromFile(RutaIconosOpcionIncorrecta);
                lblErrorNombre.Text = "Repetido"; 
            }
            else
            {
                pboxNombre.Image = Image.FromFile(RutaIconosOpcionCorrecta);
                lblErrorNombre.Text = "Correcto";
            }
        }

        private void cboxTipoProducto_Leave(object sender, EventArgs e)
        {
            
            if (ValidarDatos.SeleccionComboBox(cboxTipoProducto)){

                pboxTipo.Image = Image.FromFile(RutaIconosOpcionIncorrecta);
                lblErrorTipo.Text = "Seleccione una opción";
            }
            else
            {
                pboxTipo.Image = Image.FromFile(RutaIconosOpcionCorrecta);
                lblErrorTipo.Text = "Correcto";
            }
        }

        private void cboxProveedor_Leave(object sender, EventArgs e)
        {
            if (ValidarDatos.SeleccionComboBox(cboxProveedor))
            {

                pboxProveedor.Image = Image.FromFile(RutaIconosOpcionIncorrecta);
                lblErrorProveedor.Text = "Seleccione una opción";
            }
            else
            {
                pboxProveedor.Image = Image.FromFile(RutaIconosOpcionCorrecta);
                lblErrorProveedor.Text = "Correcto";
            }
        }

        private void cboxRubro_Leave(object sender, EventArgs e)
        {
            if (ValidarDatos.SeleccionComboBox(cboxRubro))
            {

                pboxRubro.Image = Image.FromFile(RutaIconosOpcionIncorrecta);
                lblErrorRubro.Text = "Seleccione una opción";
            }
            else
            {
                pboxRubro.Image = Image.FromFile(RutaIconosOpcionCorrecta);
                lblErrorRubro.Text = "Correcto";
            }
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
          
        }
    }
}