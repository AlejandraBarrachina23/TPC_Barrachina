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
    public partial class FormularioVenta : Form
    {

        public FormularioVenta()
        {
            InitializeComponent();
        }

        private List<DetalleVenta> Detalles = new List<DetalleVenta>();
        private int CuentaLineas = 1;
        private decimal subtotal = 0;
        ValidadorDatos Validar = new ValidadorDatos();

        public void CambiarTexto(string Texto) {

            lblMetodoPago.Text = Texto;
        }

        private void btnAgregarCliente_Click(object sender, EventArgs e)
        {
            FormularioBusqueda BusquedaCliente = new FormularioBusqueda("Clientes", "Formulario Venta");
            BusquedaCliente.Show();
        }

        private void btnMetodoPago_Click(object sender, EventArgs e)
        {
            MetodoPago FormularioMetodoPago = new MetodoPago();
            FormularioMetodoPago.SeleccionarMetodoPago += new MetodoPago.ElegirMetodoPago(CambiarMetodoPago);
            FormularioMetodoPago.Show();
        }

        private void CambiarMetodoPago(string Nombre) {

            lblMetodoPago.Text = "METODO PAGO: " + Nombre;
        }

        private void btnDevolucion_Click(object sender, EventArgs e)
        {
            MotivoDevolucion FormularioMotivoDevolucion = new MotivoDevolucion();
            FormularioMotivoDevolucion.Show();
        }

        private void btnUltimasActualizaciones_Click(object sender, EventArgs e)
        {
            UltimasActualizaciones FormularioUltimasActualizaciones = new UltimasActualizaciones();
            FormularioUltimasActualizaciones.Show();
        }

        private void btnRetiroDinero_Click(object sender, EventArgs e)
        {
            RetiroDinero FormularioRetiroDinero = new RetiroDinero();
            FormularioRetiroDinero.Show();
        }

        private void btnCierreCaja_Click(object sender, EventArgs e)
        {
            FormularioCierreCaja FormularioCierreCaja = new FormularioCierreCaja();
            FormularioCierreCaja.Show();
        }

        private void btnBusqueda_Click(object sender, EventArgs e)
        {
            FormularioBusqueda BusquedaProducto = new FormularioBusqueda("Productos", "Formulario Venta");
            BusquedaProducto.MdiParent = this.MdiParent;
            BusquedaProducto.Show();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void FormularioVenta_Load(object sender, EventArgs e)
        {
            HoraActual.Enabled = true;
            lblCliente.Text = "CLIENTE: Consumidor Final";
        }

        private void HoraActual_Tick(object sender, EventArgs e)
        {
            lblFecha.Text = "FECHA: " + DateTime.Now.ToShortDateString();
            lblHora.Text = "HORA: " + DateTime.Now.ToLongTimeString();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            try
            {
                DetalleVenta unDetalleVenta = new DetalleVenta();
                ProductoNegocio unProductoVendido = new ProductoNegocio();
                Producto unProducto = unProductoVendido.BusquedaProducto(tboxCodigoBarra.Text);
                dgvDetalleVenta.DataSource = null;
                unDetalleVenta.Linea = CuentaLineas;
                unDetalleVenta.Producto = unProducto;
                unDetalleVenta.Cantidad = Convert.ToInt32(tboxCantidad.Text);
                unDetalleVenta.Bultos = Convert.ToInt32(unDetalleVenta.Cantidad) / unProducto.CantidadxBulto;
                unDetalleVenta.Unidades = Convert.ToInt32(unDetalleVenta.Cantidad) % unProducto.CantidadxBulto;
                unDetalleVenta.PrecioMayorista = unProducto.PrecioVentaMayorista;
                unDetalleVenta.PrecioMinorista = unProducto.PrecioVentaMinorista;
                tboxCodigoBarra.Clear();
                Detalles.Add(unDetalleVenta);
                dgvDetalleVenta.DataSource = Detalles;
                Utilidades Utilidades = new Utilidades();
                Utilidades.AjustarOrdenGridView(dgvDetalleVenta);
                dgvDetalleVenta = Utilidades.OcultarColumnasDataGridView(dgvDetalleVenta, "Detalle Venta");
                unDetalleVenta.Subtotal = (unDetalleVenta.Unidades * unDetalleVenta.PrecioMinorista) + ((unDetalleVenta.Bultos * unProducto.CantidadxBulto) * unDetalleVenta.PrecioMayorista);
                lblSubtotalNumerico.Text = (subtotal += unDetalleVenta.Subtotal).ToString();
                lblTotalFactura.Text = (Convert.ToDouble(lblSubtotalNumerico.Text) * 0.9).ToString();
                tboxCantidad.Text = 1.ToString();
                tboxCodigoBarra.Focus();
            }
            catch (Exception Excepcion)
            {
                MessageBox.Show(Excepcion.Message);
            }

        }
    }
}
