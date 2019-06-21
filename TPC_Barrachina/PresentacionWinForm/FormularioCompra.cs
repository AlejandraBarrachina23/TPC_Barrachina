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
    public partial class FormularioCompra : Form
    {
        private List<DetalleCompra> ListadoDetalleCompra = new List<DetalleCompra>();
        private DetalleCompra unDetalleCompra = new DetalleCompra();
        private Producto unProductoComprado = new Producto();
        private ProductoNegocio unProductoNegocio = new ProductoNegocio();
        private ProveedorNegocio unProveedorNegocio = new ProveedorNegocio();
        private ImpuestoNegocio unImpuestoNegocio = new ImpuestoNegocio();
        private Impuesto unImpuesto = new Impuesto();
        private List<Impuesto> ListadoImpuestos = new List<Impuesto>();
        private Utilidades Utilidades = new Utilidades();
        private CabeceraCompraNegocio unaCabeceraCompraNegocio = new CabeceraCompraNegocio();
        private int CuentaLinea = 1;
        private Usuario UsuarioActivo;

        public FormularioCompra(Usuario UnUsuario)
        {
            InitializeComponent();
            tboxCodigoBarra.KeyPress += AsignarSoloNumeros;
            tboxCantidad.KeyPress += AsignarSoloNumeros;
            tboxPrecioUnitario.KeyPress += AsignarSoloNumeroEnterosDecimales;
            tboxDescuento.KeyPress += AsignarSoloNumeroEnterosDecimales;
            UsuarioActivo = UnUsuario;

        }

        private void btnBusqueda_Click(object sender, EventArgs e)
        {
            string NombreFormulario = "Productos";
            FormularioBusqueda BusquedaProducto = new FormularioBusqueda(NombreFormulario);
            BusquedaProducto.Show();
        }

        private void FormularioCompra_Load(object sender, EventArgs e)
        {
            try
            {
                cboxProveedor.DataSource = unProveedorNegocio.ListarProveedores();
                tboxNumeroOperacion.Text = (unaCabeceraCompraNegocio.CuentaFilasCabeceraCompra() + 1).ToString();
                tboxUsuario.Text = UsuarioActivo.Nombre;
                tboxNumeroOperacion.Enabled = false;
                tboxFechaEmision.Enabled = false;
                tboxHora.Enabled = false;
                tboxUsuario.Enabled = false;
                
            }
            catch (Exception Excepcion)
            {
                MessageBox.Show(Excepcion.Message);
            }
          
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            try
            {
                ValidadorDatos Validar = new ValidadorDatos();
                DetalleCompra unDetalleCompra = new DetalleCompra();
                Validar.ContenidoTextBoxVacio(tboxCodigoBarra, "Codigo");
                unProductoComprado = unProductoNegocio.BusquedaProducto(tboxCodigoBarra.Text);
                unDetalleCompra.Linea = CuentaLinea;
                unDetalleCompra.Producto = unProductoComprado;
                Proveedor ProveedorSeleccionado = (Proveedor)cboxProveedor.SelectedItem;
                Validar.ProductoPertenecienteProveedor(ProveedorSeleccionado.CodigoProveedor, unProductoComprado.Proveedor.CodigoProveedor);
                Validar.ContenidoTextBoxVacio(tboxCantidad, "Cantidad");
                Validar.ContenidoTextBoxVacio(tboxPrecioUnitario, "Precio Unitario");
                dgvDetalleCompra.DataSource = null;
                unDetalleCompra.Cantidad = Convert.ToInt32(tboxCantidad.Text);
                unDetalleCompra.PrecioUnitario = Convert.ToDecimal(tboxPrecioUnitario.Text);
                unDetalleCompra.Descuento = Convert.ToDecimal(tboxDescuento.Text);
                unDetalleCompra.PrecioNeto = Utilidades.CalcularBaseImponible(Convert.ToDecimal(tboxPrecioUnitario.Text), Convert.ToDecimal(tboxDescuento.Text));
                unDetalleCompra.PrecioBruto = Utilidades.CalcularPrecioBruto(ListadoImpuestos,unDetalleCompra.PrecioNeto);
                unDetalleCompra.PrecioPonderado = Utilidades.CalcularPrecioPonderado(unProductoComprado,unDetalleCompra);
                unDetalleCompra.Rentabilidad = unProductoComprado.Rentabilidad;
                unDetalleCompra.PrecioVenta = Utilidades.CalcularPrecioVenta(unDetalleCompra.PrecioBruto, (int)unProductoComprado.Rentabilidad);
                ListadoDetalleCompra.Add(unDetalleCompra);
                dgvDetalleCompra.DataSource = ListadoDetalleCompra;
                Utilidades.AjustarOrdenGridViewCompras(dgvDetalleCompra);
                tboxCodigoBarra.Clear();
                tboxCantidad.Clear();
                tboxPrecioUnitario.Clear();
                CuentaLinea++;
            }
            catch (Exception Excepcion)
            {
                MessageBox.Show(Excepcion.Message);
            }
            
        }

        private void cboxProveedor_SelectedIndexChanged(object sender, EventArgs e)
        {
            Proveedor ProveedorSeleccionado = (Proveedor)cboxProveedor.SelectedItem;
            ListadoImpuestos = unImpuestoNegocio.ListarImpuestosxProveedor(ProveedorSeleccionado.CodigoProveedor);
            dgvDetalleCompra.DataSource = null;
            ListadoDetalleCompra.Clear();
            //dgvImpuestos.DataSource = ListadoImpuestos;
        }

        private void dgvImpuestos_SelectionChanged(object sender, EventArgs e)
        {
                        
        }

        private void HoraActual_Tick(object sender, EventArgs e)
        {
            tboxFechaEmision.Text = DateTime.Now.ToShortDateString();
            tboxHora.Text = DateTime.Now.ToLongTimeString();
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            try
            {
                DetalleCompraNegocio unDetalleCompraNegocio = new DetalleCompraNegocio();
                CabeceraCompraNegocio unaCabeceraCompraNegocio = new CabeceraCompraNegocio();
                Proveedor ProveedorSeleccionado = new Proveedor();
                ProveedorSeleccionado = (Proveedor)cboxProveedor.SelectedItem;
                CabeceraCompra unaCabeceraCompra = new CabeceraCompra();
                unaCabeceraCompra.Proveedor = ProveedorSeleccionado;
                unaCabeceraCompra.Usuario = UsuarioActivo;
                unaCabeceraCompraNegocio.AgregarCabeceraCompra(unaCabeceraCompra);
                foreach (DetalleCompra unDetalleCompra in ListadoDetalleCompra)
                {
                    unDetalleCompraNegocio.AgregarDetalleCompra(unDetalleCompra, unaCabeceraCompraNegocio.CuentaFilasCabeceraCompra());
                }

                CuentaLinea = 1;
                ListadoDetalleCompra.Clear();
                dgvDetalleCompra.DataSource = null;
                tboxCodigoBarra.Clear();
                tboxCantidad.Clear();
                tboxPrecioUnitario.Clear();
                tboxNumeroOperacion.Text = (unaCabeceraCompraNegocio.CuentaFilasCabeceraCompra()+1).ToString();

            }
            catch (Exception Excepcion)
            {

                MessageBox.Show(Excepcion.Message);
            }
            
        }

        private void SeleccionarProducto(Producto unProducto)
        {

            tboxCodigoBarra.Text = unProducto.CodigoProducto;
        }

        void AsignarSoloNumeros(object sender, KeyPressEventArgs e)
        {
            TextBox Tbox = new TextBox();

            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;

            }
        }

        private void AsignarSoloNumeroEnterosDecimales(object sender, KeyPressEventArgs e)
        {

            if (!Char.IsDigit(e.KeyChar) && e.KeyChar != (char)Keys.Back && e.KeyChar != '.')
            {
                e.Handled = true;
            }
        }

        private void btnBusqueda_Click_1(object sender, EventArgs e)
        {
            FormularioBusqueda BusquedaProducto = new FormularioBusqueda("Productos", "Formulario Venta");
            BusquedaProducto.SeleccionarProducto += new FormularioBusqueda.ElegirProducto(SeleccionarProducto);
            BusquedaProducto.MdiParent = this.MdiParent;
            BusquedaProducto.Show();
        }
    }
}
