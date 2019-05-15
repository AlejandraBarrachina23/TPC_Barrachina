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
        public Productos()
        {
            InitializeComponent();
        }

        private void Productos_Load(object sender, EventArgs e)
        {

            cboxTipoProducto = Utilidades.CargaComboBox(cboxTipoProducto, "SELECT Nombre FROM TipoProductos", "Nombre");
            cboxRubro = Utilidades.CargaComboBox(cboxRubro, "SELECT Nombre FROM Rubros", "Nombre");
            cboxProveedor = Utilidades.CargaComboBox(cboxProveedor, "SELECT PersonaJuridicas.NombreFantasia FROM PersonaJuridicas INNER JOIN Proveedores ON CodigoInformacionEmpresa = PersonaJuridicas.CodigoPersonaJuridica", "NombreFantasia");
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            Avisos FormularioAviso = new Avisos();
            FormularioAviso.Show(this);
        }

        private void tboxCodigoProducto_KeyPress(object sender, KeyPressEventArgs e)
        {
            
        }

        private void tboxCodigoProducto_TextChanged(object sender, EventArgs e)
        {
            
            if (ValidarDatos.ContenidoTextBox(tboxCodigoProducto.Text)) {

                pboxProducto.Image = Image.FromFile(Application.StartupPath + "/Iconos/OpcionIncorrecta.png");
                lblErrorCodigoProducto.Text = "Código Vacío.";
            }

            else if (ValidarDatos.ExistenciaDeDatoDB("Codigo", "Productos", tboxCodigoProducto.Text))
            {
                pboxProducto.Image = Image.FromFile(Application.StartupPath+"/Iconos/OpcionIncorrecta.png");
                lblErrorCodigoProducto.Text = "El código esta repetido.";
            }
            else {
                pboxProducto.Image = Image.FromFile(Application.StartupPath + "/Iconos/OpcionCorrecta.png");
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
    }
}