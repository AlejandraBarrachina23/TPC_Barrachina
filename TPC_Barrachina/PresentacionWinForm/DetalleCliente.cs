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

namespace PresentacionWinForm
{
    public partial class DetalleCliente : Form
    {
        private Cliente ClienteSeleccionado;
        public DetalleCliente()
        {
            InitializeComponent();
        }

        public DetalleCliente(Cliente unCliente)
        {
            InitializeComponent();
            ClienteSeleccionado = unCliente;

        }

        private void DetalleCliente_Load(object sender, EventArgs e)
        {
            lblCodigoCliente.Text += ClienteSeleccionado.CodigoCliente.ToString();
            lblNombre.Text += ClienteSeleccionado.Nombre;
            lblApellido.Text += ClienteSeleccionado.Apellido;
            lblDireccion.Text += ClienteSeleccionado.Contacto.Direccion.Calle += ClienteSeleccionado.Contacto.Direccion.Numero;
            lblCP.Text += ClienteSeleccionado.Contacto.Direccion.CodigoPostal;
            lblLocalidad.Text += ClienteSeleccionado.Contacto.Direccion.Localidad;
            lblProvincia.Text += ClienteSeleccionado.Contacto.Direccion.Provincia;
            lblTelefono.Text += ClienteSeleccionado.Contacto.Telefono;
            lblCelular.Text += ClienteSeleccionado.Contacto.Celular;
            lblMail.Text += ClienteSeleccionado.Contacto.Mail;
            lblSaldoCuentaCorriente.Text += ClienteSeleccionado.CuentaCorriente.Saldo;
            lblDescuento.Text += ClienteSeleccionado.Descuento.Porcentaje;
        }
    }
}
