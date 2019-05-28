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
using Dominio;

namespace PresentacionWinForm
{
    public partial class FormularioListado : Form
    {
        private Utilidades utilidades = new Utilidades();
        private ValidadorDatos validar = new ValidadorDatos();

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

        private void btnBorrar_Click(object sender, EventArgs e)
        {
            try
            {
                validar.SeleccionItemDataGridView(dgvListadoBusqueda);
                object EntidadEliminar = dgvListadoBusqueda.CurrentRow.DataBoundItem;
                utilidades.DefinirTipoEliminacion(EntidadEliminar);
                
   
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
   
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            validar.SeleccionItemDataGridView(dgvListadoBusqueda);
            object EntidadModificar = dgvListadoBusqueda.CurrentRow.DataBoundItem;

            if (EntidadModificar.GetType().Equals(typeof(Producto))) {
                
                Productos FormularioCliente = new Productos((Producto)EntidadModificar);
                FormularioCliente.Show();
            }

            if (EntidadModificar.GetType().Equals(typeof(Cliente))) {

                Clientes FormularioCliente = new Clientes((Cliente)EntidadModificar);
                FormularioCliente.Show();

            }


        }
    }
}
