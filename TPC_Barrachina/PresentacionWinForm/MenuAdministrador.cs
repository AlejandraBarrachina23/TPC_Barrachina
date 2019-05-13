using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PresentacionWinForm
{
    
    public partial class MenuAdministrador : Form
    {
        private string OpcionSeleccionada;

        public MenuAdministrador()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void btnVentas_Click(object sender, EventArgs e)
        {
            OpcionSeleccionada = "Ventas";
            pnlMenuDesplegable.Visible = false;
            FormularioVenta FormularioVenta = new FormularioVenta();
            FormularioVenta.MdiParent = this;
            FormularioVenta.Show();
        }

        private void btnClientes_Click(object sender, EventArgs e)
        {
            OpcionSeleccionada = "Clientes";
            pnlMenuDesplegable.Location = new Point(109, 171);
            pnlMenuDesplegable.Visible = true;

        }

        private void btnCompras_Click(object sender, EventArgs e)
        {
            OpcionSeleccionada = "Compras";
            pnlMenuDesplegable.Visible = false;
        }

        private void btnProveedor_Click(object sender, EventArgs e)
        {
            OpcionSeleccionada = "Proveedores";
            pnlMenuDesplegable.Visible = true;
            pnlMenuDesplegable.Location = new Point(109, 360);
      
        }

        private void btnProductos_Click(object sender, EventArgs e)
        {
            OpcionSeleccionada = "Productos";
            pnlMenuDesplegable.Visible = true;
            pnlMenuDesplegable.Location = new Point(109, 414);
      
        }
    }
}
