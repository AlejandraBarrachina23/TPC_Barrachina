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

        private void btnAgregarCliente_Click(object sender, EventArgs e)
        {
            FormularioBusqueda BusquedaCliente = new FormularioBusqueda("Cliente", "Formulario Venta");
            BusquedaCliente.Show();
        }

        private void btnMetodoPago_Click(object sender, EventArgs e)
        {
            MetodoPago FormularioMetodoPago = new MetodoPago();
            FormularioMetodoPago.Show();
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
            BusquedaProducto.Show();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnCalculadora8_Click(object sender, EventArgs e)
        {

        }

        private void tboxCodigoBarra_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((int)e.KeyChar == (int)Keys.Enter)
            {
                try
                {
                    dgvDetalleVenta.DataSource = null;
                    DetalleVenta unDetalleVenta = new DetalleVenta();
                    ProductoNegocio unProductoVendido = new ProductoNegocio();
                    Producto unProducto = unProductoVendido.BusquedaProducto(tboxCodigoBarra.Text);
                    unDetalleVenta.Linea = CuentaLineas;
                    unDetalleVenta.Producto = unProducto;
                    unDetalleVenta.Cantidad = Convert.ToInt32(tboxCantidad.Text);
                    unDetalleVenta.Bultos = Convert.ToInt32(tboxCantidad.Text) / unProducto.CantidadxBulto;
                    unDetalleVenta.Unidades = Convert.ToInt32(tboxCantidad.Text) % unProducto.CantidadxBulto;
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
                }
                catch (Exception Excepcion)
                {
                    MessageBox.Show(Excepcion.Message);
                }
                

            }
        }

        private void FormularioVenta_Load(object sender, EventArgs e)
        {
            
           
        }
    }
}
