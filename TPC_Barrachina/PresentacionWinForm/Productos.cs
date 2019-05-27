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
        private string RutaIconosOpcionCorrecta = Application.StartupPath + "/Iconos/OpcionCorrecta.png";
        private string RutaIconosOpcionIncorrecta = Application.StartupPath + "/Iconos/OpcionIncorrecta.png";

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

            if (ProductoModificar != null)
            {

                btnAceptar.Visible = false;
                btnModificar.Visible = true;

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

        private void tboxCodigoProducto_TextChanged(object sender, EventArgs e)
        {
            
            if (ValidarDatos.ContenidoTextBox(tboxCodigoProducto)) {

                pboxProducto.Image = Image.FromFile(RutaIconosOpcionIncorrecta);
                lblErrorCodigoProducto.Text = "Código Vacío.";
            }

            else if (ValidarDatos.ExistenciaDeDatoDB("CodigoProducto", "Productos", tboxCodigoProducto.Text))
            {
                pboxProducto.Image = Image.FromFile(RutaIconosOpcionIncorrecta);
                lblErrorCodigoProducto.Text = "Repetido"; ;
            }
            else {
                pboxProducto.Image = Image.FromFile(RutaIconosOpcionCorrecta);
                lblErrorCodigoProducto.Text = "Correcto";
            }
                        
        }

        private void tboxCodigoBulto_TextChanged(object sender, EventArgs e)
        {
            if (ValidarDatos.ContenidoTextBox(tboxCodigoBulto))
            {
                pboxCodigoBulto.Image = Image.FromFile(RutaIconosOpcionIncorrecta);
                lblErrorCodigoBulto.Text = "Vacío.";
            }

            else if (ValidarDatos.ExistenciaDeDatoDB("CodigoBulto", "Productos", tboxCodigoBulto.Text))
            {
                pboxCodigoBulto.Image = Image.FromFile(RutaIconosOpcionIncorrecta);
                lblErrorCodigoBulto.Text = "Repetido";
            }
            else
            {
                pboxCodigoBulto.Image = Image.FromFile(RutaIconosOpcionCorrecta);
                lblErrorCodigoBulto.Text = "Correcto";
            }
        }

        private void tboxNombre_TextChanged(object sender, EventArgs e)
        {
            if (ValidarDatos.ContenidoTextBox(tboxNombre))
            {
                pboxNombre.Image = Image.FromFile(RutaIconosOpcionIncorrecta);
                lblErrorNombre.Text = "Vacío.";
            }

            else if (ValidarDatos.ExistenciaDeDatoDB("Nombre", "Productos", tboxNombre.Text))
            {
                pboxNombre.Image = Image.FromFile(RutaIconosOpcionIncorrecta);
                lblErrorNombre.Text = "Repetido"; 
            }
            else
            {
                pboxNombre.Image = Image.FromFile(RutaIconosOpcionCorrecta);
                lblErrorNombre.Text = "Correcto";
            }
        }

        private void cboxTipoProducto_Leave(object sender, EventArgs e)
        {
            
            if (ValidarDatos.SeleccionComboBox(cboxTipoProducto)){

                pboxTipo.Image = Image.FromFile(RutaIconosOpcionIncorrecta);
                lblErrorTipo.Text = "Seleccione una opción";
            }
            else
            {
                pboxTipo.Image = Image.FromFile(RutaIconosOpcionCorrecta);
                lblErrorTipo.Text = "Correcto";
            }
        }

        private void cboxProveedor_Leave(object sender, EventArgs e)
        {
            if (ValidarDatos.SeleccionComboBox(cboxProveedor))
            {

                pboxProveedor.Image = Image.FromFile(RutaIconosOpcionIncorrecta);
                lblErrorProveedor.Text = "Seleccione una opción";
            }
            else
            {
                pboxProveedor.Image = Image.FromFile(RutaIconosOpcionCorrecta);
                lblErrorProveedor.Text = "Correcto";
            }
        }

        private void cboxRubro_Leave(object sender, EventArgs e)
        {
            if (ValidarDatos.SeleccionComboBox(cboxRubro))
            {
                pboxRubro.Image = Image.FromFile(RutaIconosOpcionIncorrecta);
                lblErrorRubro.Text = "Seleccione una opción";
            }
            else
            {
                pboxRubro.Image = Image.FromFile(RutaIconosOpcionCorrecta);
                lblErrorRubro.Text = "Correcto";
            }
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            Producto unProducto = new Producto();
            ProductoNegocio unProductoNegocio = new ProductoNegocio();
            unProducto.CodigoProducto = Convert.ToInt32(tboxCodigoProducto.Text);
            unProducto.CodigoBulto = Convert.ToInt32(tboxCodigoBulto.Text);
            unProducto.Nombre = tboxNombre.Text;
            unProducto.TipoProducto = (TipoProducto)cboxTipoProducto.SelectedItem;
            unProducto.CantidadxBulto = Convert.ToInt32(tboxCantidadBulto.Text);
            unProducto.StockCritico = Convert.ToInt32(tboxStockCritico.Text);
            unProducto.Proveedor = (Proveedor)cboxProveedor.SelectedItem;
            unProducto.Rubro = (Rubro)cboxRubro.SelectedItem;
            unProductoNegocio.AgregarProducto(unProducto);
            Avisos FormularioAviso = new Avisos();
            FormularioAviso.Show();

        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            Producto unProducto = new Producto();
            ProductoNegocio unProductoNegocio = new ProductoNegocio();
            unProducto.CodigoProducto = Convert.ToInt32(tboxCodigoProducto.Text);
            unProducto.CodigoBulto = Convert.ToInt32(tboxCodigoBulto.Text);
            unProducto.Nombre = tboxNombre.Text;
            unProducto.TipoProducto = (TipoProducto)cboxTipoProducto.SelectedItem;
            unProducto.CantidadxBulto = Convert.ToInt32(tboxCantidadBulto.Text);
            unProducto.StockCritico = Convert.ToInt32(tboxStockCritico.Text);
            unProducto.Proveedor = (Proveedor)cboxProveedor.SelectedItem;
            unProducto.Rubro = (Rubro)cboxRubro.SelectedItem;
            unProductoNegocio.ModificarProducto(unProducto);

        }
    }
}