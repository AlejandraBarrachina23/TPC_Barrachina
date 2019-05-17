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
                pnlMenuDesplegable.Visible = false;
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
            pnlMenuDesplegable.Location = new Point(105, 171);
            pnlMenuDesplegable.Visible = true;
            FormularioListado FormularioBusquedaAmplio = new FormularioListado(OpcionSeleccionada);
            FormularioBusquedaAmplio.MdiParent = this;
            FormularioBusquedaAmplio.Show();

        }

        private void btnCompras_Click(object sender, EventArgs e)
        {
            OpcionSeleccionada = "Compras";
            pnlMenuDesplegable.Visible = false;
            FormularioCompra FormularioCompras = new FormularioCompra();
            FormularioCompras.MdiParent = this;
            FormularioCompras.Show();
        }

        private void btnProveedor_Click(object sender, EventArgs e)
        {
            OpcionSeleccionada = "Proveedores";
            pnlMenuDesplegable.Visible = true;
            pnlMenuDesplegable.Location = new Point(105, 360);
            FormularioListado FormularioBusquedaAmplio = new FormularioListado(OpcionSeleccionada);
            FormularioBusquedaAmplio.MdiParent = this;
            FormularioBusquedaAmplio.Show();

        }

        private void btnProductos_Click(object sender, EventArgs e)
        {
            OpcionSeleccionada = "Productos";
            pnlMenuDesplegable.Visible = true;
            pnlMenuDesplegable.Location = new Point(105, 414);
            FormularioListado FormularioBusquedaAmplio = new FormularioListado(OpcionSeleccionada);
            FormularioBusquedaAmplio.MdiParent = this;
            FormularioBusquedaAmplio.Show();


        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            pnlMenuDesplegable.Visible = false;

            if (OpcionSeleccionada == "Productos")
            {
                Productos AgregarFormularioProductos = new Productos();
                AgregarFormularioProductos.Show();
                AgregarFormularioProductos.MdiParent = this;
            }

            else if (OpcionSeleccionada == "Proveedores")
            {
                Proveedores FormularioProveedor = new Proveedores();
                FormularioProveedor.Show();
                FormularioProveedor.MdiParent = this;
            }

            else if (OpcionSeleccionada == "Clientes")
            {
                Clientes FormularioCliente = new Clientes();
                FormularioCliente.Show();
                FormularioCliente.MdiParent = this;
            }
        }

        private void btnBorrar_Click(object sender, EventArgs e)
        {
            pnlMenuDesplegable.Visible = false;
            FormularioBusqueda FormularioBusqueda = new FormularioBusqueda(OpcionSeleccionada);
            FormularioBusqueda.Show();
            FormularioBusqueda.MdiParent = this;

        }
        private void btnModificar_Click(object sender, EventArgs e)
        {
            pnlMenuDesplegable.Visible = false;
            FormularioBusqueda FormularioBusqueda = new FormularioBusqueda(OpcionSeleccionada);
            FormularioBusqueda.Show();
            FormularioBusqueda.MdiParent = this;

        }

        private void btnListar_Click(object sender, EventArgs e)
        {
            pnlMenuDesplegable.Visible = false;
            FormularioBusqueda FormularioBusqueda = new FormularioBusqueda(OpcionSeleccionada);
            FormularioBusqueda.Show();
            FormularioBusqueda.MdiParent = this;
        }
    }
}
