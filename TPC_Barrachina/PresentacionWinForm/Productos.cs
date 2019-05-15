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
            cboxProveedor = Utilidades.CargaComboBox(cboxProveedor, "select PersonaJuridicas.NombreFantasia from PersonaJuridicas INNER JOIN Proveedores ON CodigoInformacionEmpresa = PersonaJuridicas.CodigoPersonaJuridica", "NombreFantasia");
        }

    }
}
