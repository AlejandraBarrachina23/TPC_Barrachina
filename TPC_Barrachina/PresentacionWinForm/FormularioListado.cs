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
    public partial class FormularioListado : Form
    {
        private Utilidades utilidades = new Utilidades();

        public FormularioListado(string NombreFormulario)
        {
            InitializeComponent();
            lblNombreFormulario.Text = utilidades.AsignarNombreFormulario(NombreFormulario);
        }

        private void FormularioListado_Load(object sender, EventArgs e)
        {
            dgvListadoBusqueda.DataSource = utilidades.DefinirTipoBusqueda(lblNombreFormulario.Text.Remove(0, 8));
            utilidades.OcultarColumnasDataGridView(dgvListadoBusqueda, lblNombreFormulario.Text.Remove(0, 8));
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            if (lblNombreFormulario.Text.Remove(0, 8) == "Clientes")
            {
                Clientes FormularioCliente = new Clientes();
                FormularioCliente.Show();
            }

            else if (lblNombreFormulario.Text.Remove(0, 8) == "Productos")
            {

                Productos FormularioProducto = new Productos();
                FormularioProducto.Show();

            }

            else if (lblNombreFormulario.Text.Remove(0, 8) == "Proveedores") {

                Proveedores FormularioProveedor = new Proveedores();
                FormularioProveedor.Show();
            }
        }

  

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnActualizar_Click_1(object sender, EventArgs e)
        {
            dgvListadoBusqueda.DataSource = utilidades.DefinirTipoBusqueda(lblNombreFormulario.Text.Remove(0, 8));
            utilidades.OcultarColumnasDataGridView(dgvListadoBusqueda, lblNombreFormulario.Text.Remove(0, 8));
        }
    }
}
