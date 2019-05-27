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
    public partial class Clientes : Form
    {
        Utilidades utilidades = new Utilidades();
        Cliente unClienteModificarLocal = new Cliente();

        public Clientes()
        {
            InitializeComponent();
        }

        public Clientes(Cliente unClienteModificar) {

            InitializeComponent();
            unClienteModificarLocal = unClienteModificar;
            btnAceptar.Visible = false;
            btnModificar.Visible = true;

        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            try
            {
                
                //direccion
                Direccion unaNuevaDireccion = new Direccion();
                DireccionNegocio unaDireccion = new DireccionNegocio();
                unaNuevaDireccion.Calle = tboxCalle.Text;
                unaNuevaDireccion.Numero = Convert.ToInt32(tboxNumero.Text);
                unaNuevaDireccion.CodigoPostal = Convert.ToInt32(tboxCP.Text);
                unaNuevaDireccion.Localidad = tboxLocalidad.Text;
                unaNuevaDireccion.Provincia = tboxProvincia.Text;
                unaDireccion.AgregarDireccion(unaNuevaDireccion);
                
                
                //contacto
                Contacto unNuevoContacto = new Contacto();
                ContactoNegocio unContacto = new ContactoNegocio();
                unNuevoContacto.Direccion = new Direccion();
                unNuevoContacto.CodigoContacto = unaDireccion.ContaFilasDireccion();
                unNuevoContacto.Telefono = tboxTelefono.Text;
                unNuevoContacto.Celular = tboxCelular.Text;
                unNuevoContacto.Mail = tboxCorreoElectronico.Text;
                unNuevoContacto.Direccion.CodigoDireccion = unNuevoContacto.CodigoContacto;
                
                unContacto.AgregarContacto(unNuevoContacto);
                

                //cuentaCorriente
                CuentaCorriente unaNuevaCuentaCorriente = new CuentaCorriente();
                unaNuevaCuentaCorriente.LimiteCuenta = Convert.ToUInt32(tboxLimitecuenta.Text);
                CuentaCorrienteNegocio unaCuentaCorriente = new CuentaCorrienteNegocio();
                unaCuentaCorriente.AgregarCuentaCorriente(unaNuevaCuentaCorriente);
                unaNuevaCuentaCorriente.CodigoCuentaCorriente = unaCuentaCorriente.ContarFilasCuentaCorriente();


                //cliente
                Cliente unNuevoCliente = new Cliente();
                ClienteNegocio unCliente = new ClienteNegocio();
                unNuevoCliente.CodigoCliente = Convert.ToInt32(tboxCodigo.Text);
                unNuevoCliente.Nombre = tboxNombre.Text;
                unNuevoCliente.Apellido = tboxApellido.Text;
                unNuevoCliente.Descuento = (Descuento)cboxDescuento.SelectedItem;
                unNuevoCliente.CuentaCorriente = unaNuevaCuentaCorriente;
                unNuevoCliente.Contacto = unNuevoContacto;

                unCliente.AgregarCliente(unNuevoCliente);

                Avisos FormularioAviso = new Avisos();
                FormularioAviso.Show();

                /*<-----------------------------------------------------------------------------------------------------------------VALIDAR INGRESO DE CAMPOS*/
    
            }

            catch (Exception)
            {

                throw;
            }
        }

        private void Clientes_Load(object sender, EventArgs e)
        {
            DescuentoNegocio unDescuento = new DescuentoNegocio();
            cboxDescuento.DataSource = unDescuento.ListarDescuentos();
            
        }
    }
}
