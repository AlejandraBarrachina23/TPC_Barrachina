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
        ValidadorDatos validar = new ValidadorDatos();
        Utilidades utilidades = new Utilidades();
        List<Impuesto> ListadoImpuestos = new List<Impuesto>();
        private BindingList<Impuesto> listaBindeable;

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
            tboxPorcentaje.KeyPress += AsignarSoloNumeros;
            tboxTelefono.KeyPress += AsignarSoloNumeros;
            tboxCelular.KeyPress += AsignarSoloNumeros;

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
            //impuestos
            foreach (Impuesto unNuevoImpuesto in ListadoImpuestos)
            {
                unImpuesto.AgregarImpuesto(unNuevoImpuesto, unNuevoProveedor.CodigoProveedor);
            }

            Avisos FormularioAviso = new Avisos();
            FormularioAviso.Show();
           
            /*<-----------------------------------------------------------------------------------------------------------------VALIDAR INGRESO DE CAMPOS*/
        }

        private void Proveedores_Load(object sender, EventArgs e)
        {
            CondicionIVANegocio unaCondicionIVA = new CondicionIVANegocio();
            ImpuestoNegocio unImpuesto = new ImpuestoNegocio();
            cboxCondicionIVA.DataSource = unaCondicionIVA.ListarCondicionIVA();
            cboxImpuesto.DataSource = unImpuesto.ListarImpuestos();

        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
     
            Impuesto unNuevoImpuesto = new Impuesto();

            unNuevoImpuesto.Nombre = cboxImpuesto.SelectedItem.ToString();
            unNuevoImpuesto.CodigoImpuesto = cboxImpuesto.FindString(unNuevoImpuesto.Nombre)+1;
            unNuevoImpuesto.Alicuota = Convert.ToDecimal(tboxPorcentaje.Text);
            listaBindeable = new BindingList<Impuesto>(ListadoImpuestos);
            dgvImpuestos.DataSource = listaBindeable;
            ListadoImpuestos.Add(unNuevoImpuesto);
            listaBindeable.ResetBindings();
            utilidades.OcultarColumnasDataGridView(dgvImpuestos, "Impuestos");

        }
    }
}
