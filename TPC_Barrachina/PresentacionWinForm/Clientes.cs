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
        ValidadorDatos Validar = new ValidadorDatos();
        Cliente ClienteModificar = null;

        public Clientes()
        {
            InitializeComponent();
            tboxCodigo.KeyPress += AsignarSoloNumeros;
            tboxTelefono.KeyPress += AsignarSoloNumeros;
            tboxCelular.KeyPress += AsignarSoloNumeros;
            tboxNumero.KeyPress += AsignarSoloNumeros;
            tboxCP.KeyPress += AsignarSoloNumeros;
            tboxLimitecuenta.KeyPress += AsignarSoloNumeros;
        }

        public Clientes(Cliente unClienteModificar) {

            InitializeComponent();
            ClienteModificar = unClienteModificar;
            tboxCodigo.KeyPress += AsignarSoloNumeros;
            tboxTelefono.KeyPress += AsignarSoloNumeros;
            tboxCelular.KeyPress += AsignarSoloNumeros;
            tboxNumero.KeyPress += AsignarSoloNumeros;
            tboxCP.KeyPress += AsignarSoloNumeros;
            tboxLimitecuenta.KeyPress += AsignarSoloNumeros;
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            AvisoConOpcion FormularioAvisoConOpcion = new AvisoConOpcion("Clientes");
            FormularioAvisoConOpcion.Show(this);
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            try
            {
                Validar.FormularioCliente(tboxCodigo, tboxNombre, tboxApellido, tboxTelefono, tboxCelular, tboxCorreoElectronico, tboxCalle, tboxNumero, tboxCP, tboxProvincia, tboxLocalidad, cboxDescuento, tboxLimitecuenta, "Agregar");
                ClienteNegocio unCliente = new ClienteNegocio();
                DireccionNegocio unaDireccion = new DireccionNegocio();
                CuentaCorrienteNegocio unaCuentaCorriente = new CuentaCorrienteNegocio();
                int CodigoDireccion = unaDireccion.ContaFilasDireccion();
                int CodigoCuentaCorriente = unaCuentaCorriente.ContarFilasCuentaCorriente();
                unCliente.AgregarCliente(unCliente.CargarCliente(tboxCodigo, tboxNombre, tboxApellido, cboxDescuento, tboxLimitecuenta, tboxTelefono, tboxCelular, tboxCorreoElectronico, tboxProvincia, tboxLocalidad, tboxCalle, tboxNumero, tboxCP, CodigoDireccion,CodigoCuentaCorriente));
                Avisos FormularioAviso = new Avisos("Clientes");
                FormularioAviso.Show();
            }

            catch (Exception Excepcion)
            {
                MessageBox.Show(Excepcion.Message);
            }
        }

        private void Clientes_Load(object sender, EventArgs e)
        {
            DescuentoNegocio unDescuento = new DescuentoNegocio();
            cboxDescuento.DataSource = unDescuento.ListarDescuentos();

            if (ClienteModificar != null){ 

                btnAceptar.Visible = false;
                btnModificar.Visible = true;
                tboxCodigo.Enabled = false;

                tboxCodigo.Text = ClienteModificar.CodigoCliente.ToString();
                tboxNombre.Text = ClienteModificar.Nombre;
                tboxApellido.Text = ClienteModificar.Apellido;
                //Direccion
                tboxCalle.Text = ClienteModificar.Contacto.Direccion.Calle;
                tboxNumero.Text = ClienteModificar.Contacto.Direccion.Numero.ToString();
                tboxCP.Text = ClienteModificar.Contacto.Direccion.CodigoPostal.ToString();
                tboxLocalidad.Text = ClienteModificar.Contacto.Direccion.Localidad;
                tboxLocalidad.Text = ClienteModificar.Contacto.Direccion.Localidad;
                tboxProvincia.Text = ClienteModificar.Contacto.Direccion.Provincia;
                //Contacto
                tboxTelefono.Text = ClienteModificar.Contacto.Telefono;
                tboxCelular.Text = ClienteModificar.Contacto.Celular;
                tboxCorreoElectronico.Text = ClienteModificar.Contacto.Mail;
                //Descuento
                cboxDescuento.SelectedIndex = cboxDescuento.FindString(ClienteModificar.Descuento.Nombre + " - " + ClienteModificar.Descuento.Porcentaje+"%");
                if (cboxDescuento.SelectedIndex < 0) { lblAdvertenciaDescuento.Visible = true; }
                //Cuenta Corriente
                tboxLimitecuenta.Text = ClienteModificar.CuentaCorriente.LimiteCuenta.ToString();
                
            }
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            try
            {
                Validar.FormularioCliente(tboxCodigo, tboxNombre, tboxApellido, tboxTelefono, tboxCelular, tboxCorreoElectronico, tboxCalle, tboxNumero, tboxCP, tboxProvincia, tboxLocalidad, cboxDescuento, tboxLimitecuenta, "Modificar");
                ClienteNegocio unClienteNegocio = new ClienteNegocio();
                unClienteNegocio.ModificarCliente(unClienteNegocio.CargarCliente(tboxCodigo, tboxNombre, tboxApellido, cboxDescuento, tboxLimitecuenta, tboxTelefono, tboxCelular, tboxCorreoElectronico, tboxProvincia, tboxLocalidad, tboxCalle, tboxNumero, tboxCP, ClienteModificar.Contacto.CodigoContacto, ClienteModificar.CuentaCorriente.CodigoCuentaCorriente));
                Avisos FormularioAviso = new Avisos("Clientes");
                FormularioAviso.Show();
            }
            catch (Exception Excepcion)
            {

                MessageBox.Show(Excepcion.Message);
            }
            

        }

        private void AsignarSoloNumeros(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }


    }
}
