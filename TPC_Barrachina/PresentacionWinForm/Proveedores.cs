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
    public partial class Proveedores : Form
    {

        public Proveedores()
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
            
            tboxCodigoProveedor.KeyPress += AsignarSoloNumeros;
            tboxNumeroCUIT.KeyPress += AsignarSoloNumeros;
            tboxNumero.KeyPress += AsignarSoloNumeros;
            tboxCP.KeyPress += AsignarSoloNumeros;
            tboxTelefono.KeyPress += AsignarSoloNumeros;
            tboxCelular.KeyPress += AsignarSoloNumeros;
            tboxIVA.KeyPress += AsignarSoloNumeros; 
            tboxIB.KeyPress += AsignarSoloNumeros;
            tboxImpuesto1.KeyPress += AsignarSoloNumeros;
            tboxImpuesto2.KeyPress += AsignarSoloNumeros;
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            Proveedor unNuevoProveedor = new Proveedor();
            ProveedorNegocio unProveedor = new ProveedorNegocio();
            Direccion unaNuevaDireccion = new Direccion();
            DireccionNegocio unaDireccion = new DireccionNegocio();
            Contacto unNuevoContacto = new Contacto();
            ContactoNegocio unContacto = new ContactoNegocio();
            ImpuestoNegocio unImpuesto = new ImpuestoNegocio();
            //direccion
            unaNuevaDireccion.Calle = tboxCalle.Text;
            unaNuevaDireccion.Numero = Convert.ToInt32(tboxNumero.Text);
            unaNuevaDireccion.CodigoPostal = Convert.ToInt32(tboxCP.Text);
            unaNuevaDireccion.Localidad = tboxLocalidad.Text;
            unaNuevaDireccion.Provincia = tboxProvincia.Text;
            unaDireccion.AgregarDireccion(unaNuevaDireccion);
            //contacto
            unNuevoContacto = new Contacto();
            unNuevoContacto.CodigoContacto = unaDireccion.ContaFilasDireccion();
            unNuevoContacto.Telefono = tboxTelefono.Text;
            unNuevoContacto.Celular = tboxCelular.Text;
            unNuevoContacto.Mail = tboxCorreoElectronico.Text;
            unNuevoContacto.Direccion = unaNuevaDireccion;
            unContacto.AgregarContacto(unNuevoContacto);
            //proveedor
            unNuevoProveedor.CodigoProveedor = Convert.ToInt32(tboxCodigoProveedor.Text);
            unNuevoProveedor.RazonSocial = tboxRazonSocial.Text;
            unNuevoProveedor.NumeroCUIT = tboxNumeroCUIT.Text;
            unNuevoProveedor.NombreFantasia = tboxNombreFantasia.Text;
            unNuevoProveedor.CondicionIVA = (CondicionIVA)cboxCondicionIVA.SelectedItem;
            unNuevoProveedor.Contacto = unNuevoContacto;
            unProveedor.AgregarProveedor(unNuevoProveedor);

            Avisos FormularioAviso = new Avisos();
            FormularioAviso.Show();
           
            /*<-----------------------------------------------------------------------------------------------------------------VALIDAR INGRESO DE CAMPOS*/
            //insert into ProveedorxImpuesto (CodigoProveedor,CodigoImpuesto,Alicuota) VALUES (unProveedor.CodigoProveedor,???,tbox.Impuesto)

        }

        private void Proveedores_Load(object sender, EventArgs e)
        {
            CondicionIVANegocio unaCondicionIVA = new CondicionIVANegocio();
            cboxCondicionIVA.DataSource = unaCondicionIVA.ListarCondicionIVA();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
