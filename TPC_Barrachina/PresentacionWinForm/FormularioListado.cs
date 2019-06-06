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
            
            if (NombreFormulario == "Clientes") { btnDescuento.Visible = true; pnlDescuento.Visible = true; }
            else if (NombreFormulario == "Productos") { btnRubro.Visible = true; pnlRubro.Visible = true; }

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

        private void btnBorrar_Click(object sender, EventArgs e)
        {
            try
            {
                validar.SeleccionItemDataGridView(dgvListadoBusqueda);
                object EntidadEliminar = dgvListadoBusqueda.CurrentRow.DataBoundItem;
                utilidades.DefinirTipoEliminacion(EntidadEliminar);

                dgvListadoBusqueda.DataSource = utilidades.DefinirTipoBusqueda(lblNombreFormulario.Text.Remove(0, 8));
                utilidades.OcultarColumnasDataGridView(dgvListadoBusqueda, lblNombreFormulario.Text.Remove(0, 8));
                
   
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

            if (EntidadModificar.GetType().Equals(typeof(Producto)))
            {
                Productos FormularioProducto = new Productos((Producto)EntidadModificar);
                FormularioProducto.Show();
                
            }

            else if (EntidadModificar.GetType().Equals(typeof(Cliente)))
            {

                Clientes FormularioCliente = new Clientes((Cliente)EntidadModificar);
                FormularioCliente.Show();

            }

            else if (EntidadModificar.GetType().Equals(typeof(Proveedor))) {

                Proveedores FormularioProveedor = new Proveedores((Proveedor)EntidadModificar);
                FormularioProveedor.Show();

            }

        }

        private void btnRubro_Click(object sender, EventArgs e)
        {
            Rubros FormularioRubro = new Rubros();
            FormularioRubro.MdiParent = this.MdiParent;
            FormularioRubro.Show();
                     
        }

        private void btnDescuento_Click(object sender, EventArgs e)
        {
            Descuentos FormularioDescuentos = new Descuentos();
            FormularioDescuentos.MdiParent = this.MdiParent;
            FormularioDescuentos.Show();
        }

        private void tboxCodigo_TextChanged(object sender, EventArgs e)
        {
          
        }

        private void btnDetalle_Click(object sender, EventArgs e)
        {
            try
            {
                validar.SeleccionItemDataGridView(dgvListadoBusqueda);
                object EntidadModificar = dgvListadoBusqueda.CurrentRow.DataBoundItem;

                if (EntidadModificar.GetType().Equals(typeof(Producto)))
                {
                    DetalleProducto FormularioDetalleProducto = new DetalleProducto((Producto)EntidadModificar);
                    FormularioDetalleProducto.MdiParent = this.MdiParent;
                    FormularioDetalleProducto.Show();

                }

                else if (EntidadModificar.GetType().Equals(typeof(Cliente)))
                {

                    DetalleCliente FormularioDetalleCliente = new DetalleCliente((Cliente)EntidadModificar);
                    FormularioDetalleCliente.MdiParent = this.MdiParent;
                    FormularioDetalleCliente.Show();

                }

                else if (EntidadModificar.GetType().Equals(typeof(Proveedor)))
                {

                    Proveedores FormularioProveedor = new Proveedores((Proveedor)EntidadModificar);
                    FormularioProveedor.Show();

                }
            }
            catch (Exception)
            {

                throw;
            }
            
        }
    }
}
