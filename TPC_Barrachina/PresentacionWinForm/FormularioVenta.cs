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
        private Usuario UsuarioActivo;
        public FormularioVenta(Usuario unUsuario)
        {
            InitializeComponent();
            UsuarioActivo = unUsuario;
        }

        string TipoOperacion = "Ventas";
        private List<DetalleVenta> ListadoDetalle = new List<DetalleVenta>();
        private int CuentaLineas = 1;
        private decimal Subtotal = 0;
        ValidadorDatos Validar = new ValidadorDatos();
        Utilidades Utilidades = new Utilidades();
        CabeceraVenta unaCabeceraVenta = new CabeceraVenta();
        CabeceraVentaNegocio unaCabeceraVentaNegocio = new CabeceraVentaNegocio();
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

            tboxMetodoPago.Text = Nombre;
        }

        private void SeleccionarProducto(Producto unProducto) {

            tboxCodigoBarra.Text = unProducto.CodigoProducto;
        }

        private void CambiarCliente(Cliente unClienteSeleccionado) {

            tboxClientes.Text = unClienteSeleccionado.Nombre;
            tboxSaldo.Text = unClienteSeleccionado.CuentaCorriente.Saldo.ToString("N2");
            lblDescuentoNumerico.Text = unClienteSeleccionado.Descuento.Porcentaje + "%";
            unCliente = unClienteSeleccionado;

            if (dgvDetalleVenta.DataSource != null) {

                lblTotalFactura.Text = Utilidades.CalcularDescuento(Convert.ToDecimal(lblSubtotalNumerico.Text), Convert.ToDecimal(unCliente.Descuento.Porcentaje)).ToString();
            }
        }

        private void btnDevolucion_Click(object sender, EventArgs e)
        {
            
            TipoOperacion ="Devolucion";
            lblDatosOperacion.Text = "Datos devolución";
            btnDevolucion.Enabled = false;
            lblMotivoDevolucion.Visible = true;
            cboxMotivoDevolucion.Visible = true;
            tboxNumeroOperacion.Text = Utilidades.DefinirTipoOperacion(TipoOperacion).ToString();

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
            tboxClientes.Text = "Consumidor Final";
            tboxMetodoPago.Text = "Efectivo";
            tboxSaldo.Text = 0.ToString("N2");
            tboxUsuario.Text = UsuarioActivo.Nombre;
            tboxNumeroOperacion.Enabled = false;
            tboxFechaEmision.Enabled = false;
            tboxHora.Enabled = false;
            tboxMetodoPago.Enabled = false;
            tboxClientes.Enabled = false;
            tboxSaldo.Enabled = false;
            tboxUsuario.Enabled = false;
            tboxCantidad.Text = 1.ToString();
            tboxNumeroOperacion.Text = Utilidades.DefinirTipoOperacion(TipoOperacion).ToString();
     
        }

        private void HoraActual_Tick(object sender, EventArgs e)
        {
            tboxFechaEmision.Text = DateTime.Now.ToShortDateString();
            tboxHora.Text = DateTime.Now.ToLongTimeString();
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
                Validar.StockSegunTipoOperacion(TipoOperacion, unProducto, ListadoDetalle, Convert.ToInt32(tboxCantidad.Text));
                unDetalleVenta = (unDetalleVentaNegocio.CargarDetalleVenta(CuentaLineas, unProducto, Convert.ToInt32(tboxCantidad.Text)));
                ListadoDetalle.Add(unDetalleVenta);
                dgvDetalleVenta.DataSource = null;
                tboxCodigoBarra.Clear();
                dgvDetalleVenta.DataSource = ListadoDetalle;
                Utilidades.AjustarOrdenGridViewVentas(dgvDetalleVenta);
                dgvDetalleVenta = Utilidades.OcultarColumnasDataGridView(dgvDetalleVenta, "Detalle Venta");
                lblSubtotalNumerico.Text = (Subtotal += unDetalleVenta.Subtotal).ToString();
                lblTotalFactura.Text = Subtotal.ToString("N2");

                if (unCliente != null) {
                    lblTotalFactura.Text = Utilidades.CalcularDescuento(Convert.ToDecimal(lblSubtotalNumerico.Text), Convert.ToDecimal(unCliente.Descuento.Porcentaje)).ToString();
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

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            try
            {
                ProductoNegocio unProductoNegocio = new ProductoNegocio();
                Validar.GrillaVacia(dgvDetalleVenta);

                if (TipoOperacion == "Ventas")
                {
                    DetalleVentaNegocio unDetallVentaNegocio = new DetalleVentaNegocio();

                    unaCabeceraVentaNegocio.AgregarCabeceraVenta(unaCabeceraVentaNegocio.CargarCabeceraVenta(UsuarioActivo, unCliente, tboxFechaEmision.Text, Convert.ToDecimal(lblTotalFactura.Text), tboxMetodoPago.Text));
                    int NumeroFactura = unaCabeceraVentaNegocio.CuentaFilasCabeceraVenta();

                    foreach (DetalleVenta unDetalleVenta in ListadoDetalle)
                    {
                        unDetallVentaNegocio.AgregarDetalleVenta(unDetalleVenta, NumeroFactura);
                        unProductoNegocio.RestarStock(unDetalleVenta.Producto,unDetalleVenta.Cantidad);
                    }


                }

                else {

                    DetalleNotaCreditoNegocio unDetalleNotaDevolucionNegocio = new DetalleNotaCreditoNegocio();
                    CabeceraNotaCreditoNegocio unaCabeceraDevolucionNegocio = new CabeceraNotaCreditoNegocio();
                    Validar.SeleccionComboBox(cboxMotivoDevolucion, "Motivo devolución");
                    unaCabeceraDevolucionNegocio.AgregarCabeceraNotaDevolucion(unaCabeceraDevolucionNegocio.CargarCabeceraDevolucion(UsuarioActivo, unCliente, tboxFechaEmision.Text, Convert.ToDecimal(lblTotalFactura.Text), tboxMetodoPago.Text, cboxMotivoDevolucion.SelectedItem.ToString(), TipoOperacion));
                    int NumeroFactura = unaCabeceraDevolucionNegocio.CuentaFilasCabeceraNotaCredito();

                    foreach (DetalleVenta unDetalleVenta in ListadoDetalle)
                    {
                        unDetalleNotaDevolucionNegocio.AgregarDetalleNotaDevolucion(unDetalleNotaDevolucionNegocio.CargarDetalleDevolucion(unDetalleVenta), NumeroFactura);
                    }
                }

                //restaurar valores formulario
                CuentaLineas = 1; Subtotal = 0;
                dgvDetalleVenta.DataSource = null;
                ListadoDetalle.Clear();
                tboxNumeroOperacion.Text = unaCabeceraVentaNegocio.CuentaFilasCabeceraVenta().ToString();
                lblSubtotalNumerico.Text = 0.00.ToString();
                lblMotivoDevolucion.Visible = false;
                cboxMotivoDevolucion.Visible = false;
                lblTotalFactura.Text = 0.ToString("N2");
                lblDatosOperacion.Text = "Datos Venta";
                btnDevolucion.Enabled = true;
                TipoOperacion = "Ventas";
                tboxNumeroOperacion.Text = Utilidades.DefinirTipoOperacion(TipoOperacion).ToString();
                

            }
            catch (Exception Excepcion)
            {
                MessageBox.Show(Excepcion.Message);
            }
          
        }

        private void btnBorrar_Click(object sender, EventArgs e)
        {

            try
            {
                Validar.GrillaVacia(dgvDetalleVenta);
                DetalleVenta unDetalleSeleccionado = (DetalleVenta)dgvDetalleVenta.CurrentRow.DataBoundItem;
                lblSubtotalNumerico.Text = (Subtotal -= unDetalleSeleccionado.Subtotal).ToString();
                lblTotalFactura.Text = Subtotal.ToString("N2");
                if (unCliente != null)
                {
                    lblTotalFactura.Text = Utilidades.CalcularDescuento(Convert.ToDecimal(lblSubtotalNumerico.Text), Convert.ToDecimal(unCliente.Descuento.Porcentaje)).ToString();
                }
                
                ListadoDetalle.Remove(unDetalleSeleccionado);
                dgvDetalleVenta.DataSource = null;
                dgvDetalleVenta.DataSource = ListadoDetalle;
                dgvDetalleVenta = Utilidades.OcultarColumnasDataGridView(dgvDetalleVenta, "Detalle Venta");
                Utilidades.AjustarOrdenGridViewVentas(dgvDetalleVenta);
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
