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
    public partial class Productos : Form
    {
        ValidadorDatos ValidarDatos = new ValidadorDatos();
        Utilidades Utilidades = new Utilidades();
        private Producto ProductoModificar = null;

        //FORMULARIO CREAR
        public Productos()
        {
            InitializeComponent();

            void AsignarSoloNumeros(object sender, KeyPressEventArgs e)
            {
                TextBox Tbox = new TextBox();

                if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
                {
                    e.Handled = true;

                }
            }

            //Asigno el evento a cada uno de los tbox que necesiten validar que no se ingrese texto 
            tboxCodigoBulto.KeyPress += AsignarSoloNumeros;
            tboxCodigoProducto.KeyPress += AsignarSoloNumeros;
            tboxStockCritico.KeyPress += AsignarSoloNumeros;
            tboxCantidadBulto.KeyPress += AsignarSoloNumeros;
            
        }
        
        //FORMULARIO MODIFICAR
        public Productos(Producto unProductoModificar)
        {

            InitializeComponent();
            ProductoModificar = unProductoModificar;

            void AsignarSoloNumeros(object sender, KeyPressEventArgs e)
            {
                TextBox Tbox = new TextBox();

                if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
                {
                    e.Handled = true;

                }
            }
            tboxCodigoBulto.KeyPress += AsignarSoloNumeros;
            tboxCodigoProducto.KeyPress += AsignarSoloNumeros;
            tboxStockCritico.KeyPress += AsignarSoloNumeros;
            tboxCantidadBulto.KeyPress += AsignarSoloNumeros;
        }

        private void Productos_Load(object sender, EventArgs e)
        {
            TipoProductoNegocio unTipoProducto = new TipoProductoNegocio();
            RubroNegocio unRubro = new RubroNegocio();
            ProveedorNegocio unProveedor = new ProveedorNegocio();

            cboxTipoProducto.DataSource = unTipoProducto.ListarTipoProducto();
            cboxRubro.DataSource = unRubro.ListarRubros();
            cboxProveedor.DataSource = unProveedor.ListarProveedores();

            //PRECARGA PARA MODIFICAR
            if (ProductoModificar != null)
            {

                btnAceptar.Visible = false;
                btnModificar.Visible = true;
                tboxCodigoProducto.Enabled = false;

                tboxCodigoProducto.Text = ProductoModificar.CodigoProducto.ToString();
                tboxCodigoBulto.Text = ProductoModificar.CodigoBulto.ToString();
                tboxNombre.Text = ProductoModificar.Nombre;
                cboxTipoProducto.SelectedItem = ProductoModificar.TipoProducto;
                tboxCantidadBulto.Text = ProductoModificar.CantidadxBulto.ToString();
                tboxStockCritico.Text = ProductoModificar.StockCritico.ToString();

                cboxProveedor.SelectedIndex = cboxProveedor.FindString(ProductoModificar.Proveedor.NombreFantasia);
                cboxTipoProducto.SelectedIndex = cboxTipoProducto.FindString(ProductoModificar.TipoProducto.Nombre);
                cboxRubro.SelectedIndex = cboxRubro.FindString(ProductoModificar.Rubro.Nombre);
                
            }
                        
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            AvisoConOpcion FormularioAvisoConOpcion = new AvisoConOpcion();
            FormularioAvisoConOpcion.Show(this);
        }
              
        private void btnAceptar_Click(object sender, EventArgs e)
        {
            try
            {
                ProductoNegocio unProductoNegocio = new ProductoNegocio();
                ValidarDatos.FormularioProducto(tboxCodigoProducto, tboxCodigoBulto, tboxNombre, tboxCantidadBulto, tboxStockCritico, cboxTipoProducto, cboxRubro, cboxProveedor);
                unProductoNegocio.AgregarProducto(unProductoNegocio.CargarProducto(tboxCodigoProducto, tboxCodigoBulto, tboxNombre, cboxTipoProducto, tboxCantidadBulto, tboxStockCritico, cboxProveedor, cboxRubro));
                Avisos FormularioAviso = new Avisos();
                FormularioAviso.Show();
            }
            catch (Exception Excepcion)
            {

                MessageBox.Show(Excepcion.Message);
            }
         
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            try
            {
                ProductoNegocio unProductoNegocio = new ProductoNegocio();
                ValidarDatos.FormularioProducto(tboxCodigoProducto, tboxCodigoBulto, tboxNombre, tboxCantidadBulto, tboxStockCritico, cboxTipoProducto, cboxRubro, cboxProveedor);
                unProductoNegocio.ModificarProducto(unProductoNegocio.CargarProducto(tboxCodigoProducto, tboxCodigoBulto, tboxNombre, cboxTipoProducto, tboxCantidadBulto, tboxStockCritico, cboxProveedor, cboxRubro));
            }
            catch (Exception Excepcion)
            {
                MessageBox.Show(Excepcion.Message);
            }
           
        }
    }
}