using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Dominio;
using Negocio;

namespace PresentacionWinForm
{
    public partial class Proveedores : Form
    {

        public Proveedores()
        {
            InitializeComponent();
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            Proveedor unNuevoProveedor = new Proveedor();
            ProveedorNegocio unProveedorNegocio = new ProveedorNegocio();
            
            
        }
    }
}
