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
    
    public partial class MenuAdministrador : Form
    {
        private string OpcionSeleccionada;
        private Utilidades Utilidades = new Utilidades();

        public MenuAdministrador()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void btnVentas_Click(object sender, EventArgs e)
        {
            try
            {
                OpcionSeleccionada = "Ventas";
                FormularioVenta FormularioVenta = new FormularioVenta();
                FormularioVenta.MdiParent = this;
                FormularioVenta.Show();
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        
        }

        private void btnClientes_Click(object sender, EventArgs e)
        {
            OpcionSeleccionada = "Clientes";
            FormularioListado FormularioBusquedaAmplio = new FormularioListado(OpcionSeleccionada);
            FormularioBusquedaAmplio.MdiParent = this;
            FormularioBusquedaAmplio.Show();

        }

        private void btnCompras_Click(object sender, EventArgs e)
        {
            OpcionSeleccionada = "Compras";
            FormularioCompra FormularioCompras = new FormularioCompra();
            FormularioCompras.MdiParent = this;
            FormularioCompras.Show();
        }

        private void btnProveedor_Click(object sender, EventArgs e)
        {
            OpcionSeleccionada = "Proveedores";
            FormularioListado FormularioBusquedaAmplio = new FormularioListado(OpcionSeleccionada);
            FormularioBusquedaAmplio.MdiParent = this;
            FormularioBusquedaAmplio.Show();

        }

        private void btnProductos_Click(object sender, EventArgs e)
        {
            OpcionSeleccionada = "Productos";
            FormularioListado FormularioBusquedaAmplio = new FormularioListado(OpcionSeleccionada);
            FormularioBusquedaAmplio.MdiParent = this;
            FormularioBusquedaAmplio.Show();

        }

    }
}
