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
    public partial class DetalleProveedor : Form
    {
        private Proveedor ProveedorSeleccionado;
        public DetalleProveedor()
        {
            InitializeComponent();
        }

        public DetalleProveedor(Proveedor unProveedor)
        {
            InitializeComponent();
            ProveedorSeleccionado = unProveedor;
        }

        private void DetalleProveedor_Load(object sender, EventArgs e)
        {
            lblCodigoProveedor.Text += ProveedorSeleccionado.CodigoProveedor.ToString();
            lblNombreFantasia.Text += ProveedorSeleccionado.NombreFantasia;
            lblNumeroCUIT.Text += ProveedorSeleccionado.NumeroCUIT;
            lblRazonSocial.Text += ProveedorSeleccionado.RazonSocial;
            lblCondicionIVA.Text += ProveedorSeleccionado.CondicionIVA.Nombre;
            lblDireccion.Text += ProveedorSeleccionado.Contacto.Direccion.Calle += ProveedorSeleccionado.Contacto.Direccion.Numero;
            lblLocalidad.Text += ProveedorSeleccionado.Contacto.Direccion.Localidad;
            lblCP.Text += ProveedorSeleccionado.Contacto.Direccion.CodigoPostal.ToString();
            lblProvincia.Text += ProveedorSeleccionado.Contacto.Direccion.Provincia;
            lblTelefono.Text += ProveedorSeleccionado.Contacto.Telefono;
            lblCelular.Text += ProveedorSeleccionado.Contacto.Celular;
            lblMail.Text += ProveedorSeleccionado.Contacto.Mail;
        }
    }
}
