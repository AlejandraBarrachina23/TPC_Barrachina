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
        public Productos()
        {
            InitializeComponent();
        }

        private void Productos_Load(object sender, EventArgs e)
        {
            Utilidades Utilidades = new Utilidades();
            cboxTipoProducto = Utilidades.CargaComboBox(cboxTipoProducto,"SELECT Nombre FROM TipoProductos","Nombre");
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
            if ((int)e.KeyChar == (int)Keys.Tab || (int)e.KeyChar == (int)Keys.Enter ) { 
            ValidadorDatos ValidarDatos = new ValidadorDatos();
                if (ValidarDatos.ValidarExistenciaDeDato("Codigo", "Productos", tboxCodigoProducto.Text))
                {
                    pboxProducto.Image = Image.FromFile("C:/Users/Alejandra/Desktop/TPC_Barrachina/TPC_Barrachina/Iconos/OpcionIncorrecta.png");

                }
                else { pboxProducto.Image = Image.FromFile("C:/Users/Alejandra/Desktop/TPC_Barrachina/TPC_Barrachina/Iconos/OpcionCorrecta.png"); }

            }
        }
    }
}
