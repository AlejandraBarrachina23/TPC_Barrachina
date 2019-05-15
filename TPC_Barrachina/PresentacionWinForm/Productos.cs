using System;
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
            
            if (ValidarDatos.ContenidoTextBox(tboxCodigoProducto.Text)) {

                pboxProducto.Image = Image.FromFile(RutaIconosOpcionIncorrecta);
                lblErrorCodigoProducto.Text = "Código Vacío.";
            }

            else if (ValidarDatos.ExistenciaDeDatoDB("Codigo", "Productos", tboxCodigoProducto.Text))
            {
                pboxProducto.Image = Image.FromFile(RutaIconosOpcionIncorrecta);
                lblErrorCodigoProducto.Text = "El código esta repetido.";
            }
            else {
                pboxProducto.Image = Image.FromFile(RutaIconosOpcionCorrecta);
                lblErrorCodigoProducto.Text = "Ok";
            }
                        
        }

        private void tboxCodigoBulto_TextChanged(object sender, EventArgs e)
        {
            if (ValidarDatos.ContenidoTextBox(tboxCodigoBulto.Text))
            {
                pboxCodigoBulto.Image = Image.FromFile(Application.StartupPath + "/Iconos/OpcionIncorrecta.png");
                lblErrorCodigoBulto.Text = "Vacío.";
            }

            else if (ValidarDatos.ExistenciaDeDatoDB("CodigoBulto", "Productos", tboxCodigoBulto.Text))
            {
                pboxCodigoBulto.Image = Image.FromFile(Application.StartupPath + "/Iconos/OpcionIncorrecta.png");
                lblErrorCodigoBulto.Text = "El código esta repetido.";
            }
            else
            {
                pboxCodigoBulto.Image = Image.FromFile(Application.StartupPath + "/Iconos/OpcionCorrecta.png");
                lblErrorCodigoBulto.Text = "Ok";
            }
        }

        private void tboxNombre_TextChanged(object sender, EventArgs e)
        {
            if (ValidarDatos.ContenidoTextBox(tboxNombre.Text))
            {
                pboxNombre.Image = Image.FromFile(Application.StartupPath + "/Iconos/OpcionIncorrecta.png");
                lblErrorNombre.Text = "Vacío.";
            }

            else if (ValidarDatos.ExistenciaDeDatoDB("Nombre", "Productos", tboxNombre.Text))
            {
                pboxNombre.Image = Image.FromFile(Application.StartupPath + "/Iconos/OpcionIncorrecta.png");
                lblErrorNombre.Text = "El código esta repetido.";
            }
            else
            {
                pboxNombre.Image = Image.FromFile(Application.StartupPath + "/Iconos/OpcionCorrecta.png");
                lblErrorNombre.Text = "Ok";
            }
        }

        private void cboxTipoProducto_Leave(object sender, EventArgs e)
        {
            
            if (ValidarDatos.ContenidoComboBox(cboxTipoProducto.Text)){

                pboxTipo.Image = Image.FromFile(Application.StartupPath + "/Iconos/OpcionIncorrecta.png");
                lblErrorTipo.Text = "Seleccione una opción";
            }
            else
            {
                pboxTipo.Image = Image.FromFile(Application.StartupPath + "/Iconos/OpcionCorrecta.png");
                lblErrorTipo.Text = "Ok";
            }
        }
    }
}