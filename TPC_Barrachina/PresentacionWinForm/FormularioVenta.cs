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
        private decimal Subtotal = 0;
        ValidadorDatos Validar = new ValidadorDatos();
        Cliente unCliente = null;

        public void CambiarTexto(string Texto) {

            lblMetodoPago.Text = Texto;
        }

        private void btnAgregarCliente_Click(object sender, EventArgs e)
        {
            FormularioBusqueda FormularioBusquedaCliente = new FormularioBusqueda("Clientes", "Formulario Venta");
            FormularioBusquedaCliente.SeleccionarCliente += new FormularioBusqueda.ElegirCliente(CambiarCliente);
            FormularioBusquedaCliente.Show();
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

        private void SeleccionarProducto(Producto unProducto) {

            tboxCodigoBarra.Text = unProducto.CodigoProducto;
        }

        private void CambiarCliente(Cliente unClienteSeleccionado) {

            lblCliente.Text = "CLIENTE: " + unClienteSeleccionado.Nombre;
            lblSaldo.Text = "SALDO: " + unClienteSeleccionado.CuentaCorriente.Saldo;
            lblDescuento.Text = "DESCUENTO: " + unClienteSeleccionado.Descuento.Porcentaje + "%";
            unCliente = unClienteSeleccionado;
            
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
            BusquedaProducto.SeleccionarProducto += new FormularioBusqueda.ElegirProducto(SeleccionarProducto);
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
                Validar.ContenidoTextBoxVacio(tboxCodigoBarra, "Código Producto");
                DetalleVenta unDetalleVenta = new DetalleVenta();
                DetalleVentaNegocio unDetalleVentaNegocio = new DetalleVentaNegocio();
                ProductoNegocio unProductoVendido = new ProductoNegocio();
                Producto unProducto = unProductoVendido.BusquedaProducto(tboxCodigoBarra.Text);
                unDetalleVentaNegocio.ControlStock(Detalles, unProducto, Convert.ToInt32(tboxCantidad.Text));
                
                Validar.MaximoValor(unProducto.Stock, "Stock", Convert.ToInt32(tboxCantidad.Text));

                dgvDetalleVenta.DataSource = null;
                unDetalleVenta.Linea = CuentaLineas;
                unDetalleVenta.Producto = unProducto;
                unDetalleVenta.Cantidad = Convert.ToInt32(tboxCantidad.Text);
                unDetalleVenta.Bultos = Convert.ToInt32(unDetalleVenta.Cantidad) / unProducto.CantidadxBulto;
                unDetalleVenta.Unidades = Convert.ToInt32(unDetalleVenta.Cantidad) % unProducto.CantidadxBulto;
                unDetalleVenta.PrecioMayorista = unProducto.PrecioVentaMayorista;
                unDetalleVenta.PrecioMinorista = unProducto.PrecioVentaMinorista;
                unDetalleVenta.Subtotal = (unDetalleVenta.Unidades * unDetalleVenta.PrecioMinorista) + ((unDetalleVenta.Bultos * unProducto.CantidadxBulto) * unDetalleVenta.PrecioMayorista);

                tboxCodigoBarra.Clear();
                Detalles.Add(unDetalleVenta);

                dgvDetalleVenta.DataSource = Detalles;
                Utilidades Utilidades = new Utilidades();
                Utilidades.AjustarOrdenGridView(dgvDetalleVenta);
                dgvDetalleVenta = Utilidades.OcultarColumnasDataGridView(dgvDetalleVenta, "Detalle Venta");
                
                lblSubtotalNumerico.Text = (Subtotal += unDetalleVenta.Subtotal).ToString();
                if (unCliente != null) {

                    decimal resultado = Convert.ToInt32(lblSubtotalNumerico.Text) - (Convert.ToInt32(lblSubtotalNumerico.Text) * Convert.ToDecimal(unCliente.Descuento.Porcentaje) / 100);
                    lblTotalFactura.Text = resultado.ToString();
                }
                

                tboxCantidad.Text = 1.ToString();
                tboxCodigoBarra.Focus();
                CuentaLineas++;
            }
            catch (Exception Excepcion)
            {
                MessageBox.Show(Excepcion.Message);
            }

        }

        private void tboxCodigoBarra_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }
    }
}
