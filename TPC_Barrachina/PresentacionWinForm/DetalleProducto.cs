using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Dominio;
using Negocio;

namespace PresentacionWinForm
{
    public partial class DetalleProducto : Form
    {
        private Producto ProductoSeleccionado = null;

        public DetalleProducto()
        {
            InitializeComponent();
        }

        public DetalleProducto(Producto unProducto)
        {
            InitializeComponent();
            ProductoSeleccionado = unProducto;
        }

        private void DetalleProducto_Load(object sender, EventArgs e)
        {
            lblCodigo.Text += ProductoSeleccionado.CodigoProducto;
            lblNombre.Text += ProductoSeleccionado.Nombre;
            lblCantidadxBulto.Text += ProductoSeleccionado.CantidadxBulto;
            lblPrecioCosto.Text += ProductoSeleccionado.PrecioCosto;
            lblPrecioListaMayorista.Text += ProductoSeleccionado.PrecioCostoLista;
            lblPrecioCostoLista.Text += ProductoSeleccionado.PrecioCostoLista;
            lblPrecioVentaMinorista.Text += ProductoSeleccionado.PrecioVentaMinorista;
            lblProveedor.Text += ProductoSeleccionado.Proveedor.NombreFantasia;
            lblRubro.Text += ProductoSeleccionado.Rubro.Nombre;
            lblStock.Text += ProductoSeleccionado.Stock;
            lblStockCritico.Text += ProductoSeleccionado.StockCritico;
            lblTipoProducto.Text += ProductoSeleccionado.TipoProducto.Nombre;
            
        }
    }
}
