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

        private int CuentaLinea = 1;

        public FormularioCompra()
        {
            InitializeComponent();
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
                cboxProveedor.ValueMember = "CodigoImpuesto";
                cboxProveedor.DisplayMember = "Nombre";
                cboxProveedor.DataSource = unProveedorNegocio.ListarProveedores();
                cboxImpuesto.DataSource = unImpuestoNegocio.ListarImpuestos();

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
                unProductoComprado = unProductoNegocio.BusquedaProducto(tboxCodigoBarra.Text);
                unDetalleCompra.Linea = CuentaLinea;
                unDetalleCompra.Producto = unProductoComprado;
                unDetalleCompra.Cantidad = Convert.ToInt32(tboxCantidad.Text);
                unDetalleCompra.PrecioUnitario = Convert.ToDecimal(tboxPrecioUnitario.Text);
                unDetalleCompra.Descuento = Convert.ToDecimal(tboxDescuento.Text);
                unDetalleCompra.PrecioNeto = Utilidades.CalcularBaseImponible(Convert.ToDecimal(tboxPrecioUnitario.Text), Convert.ToDecimal(tboxDescuento.Text));
                unDetalleCompra.PrecioBruto = Utilidades.CalcularPrecioBruto(ListadoImpuestos,unDetalleCompra.PrecioNeto);
                unDetalleCompra.PrecioPonderado = ((unProductoComprado.PrecioCosto * unProductoComprado.Stock) + (unDetalleCompra.PrecioBruto * unDetalleCompra.Cantidad)) / (unDetalleCompra.Cantidad + unProductoComprado.Stock);
                unDetalleCompra.Rentabilidad = unProductoComprado.Rentabilidad;
                unDetalleCompra.PrecioVenta = Convert.ToInt16(unDetalleCompra.PrecioBruto + (unDetalleCompra.PrecioBruto * unDetalleCompra.Rentabilidad / 100));

                //int ultimoDigito = (int)unDetalleCompra.PrecioVenta % 10;
                //int precioVenta = (int)unDetalleCompra.PrecioVenta;

                //if (ultimoDigito > 5)  precioVenta += (10 - ultimoDigito);
                ////else if(ultimoDigito <5 && ultimoDigito!=0 )  unDetalleCompra.PrecioVenta += (5 - ultimoDigito);
                

                //MessageBox.Show(ultimoDigito.ToString());
                //MessageBox.Show(precioVenta.ToString());

                ListadoDetalleCompra.Add(unDetalleCompra);
                dgvDetalleCompra.DataSource = ListadoDetalleCompra;
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
            dgvImpuestos.DataSource = ListadoImpuestos;
        }

        private void dgvImpuestos_SelectionChanged(object sender, EventArgs e)
        {
            unImpuesto = (Impuesto)dgvImpuestos.CurrentRow.DataBoundItem;
            cboxImpuesto.SelectedIndex = cboxImpuesto.FindString(unImpuesto.Nombre);
            tboxPorcentaje.Text = unImpuesto.Alicuota.ToString();
            
        }
    }
}
