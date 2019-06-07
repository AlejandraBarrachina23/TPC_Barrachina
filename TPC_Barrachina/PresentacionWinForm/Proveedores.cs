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
        private Proveedor ProveedorModificar = null;

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

        public Proveedores(Proveedor unProveedorModificar) {

            InitializeComponent();
            ProveedorModificar = unProveedorModificar;

        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {

            DireccionNegocio unaDireccion = new DireccionNegocio();
            ProveedorNegocio unProveedor = new ProveedorNegocio();
            int CodigoDireccion = unaDireccion.ContaFilasDireccion();
            unProveedor.AgregarProveedor(unProveedor.CargarProveedor(tboxCodigoProveedor, tboxRazonSocial, tboxNumeroCUIT, tboxNombreFantasia, cboxCondicionIVA, tboxTelefono, tboxCelular, tboxCorreoElectronico, tboxProvincia, tboxLocalidad, tboxCalle, tboxNumero, tboxCP, CodigoDireccion));
            ImpuestoNegocio unImpuesto = new ImpuestoNegocio();

            foreach (Impuesto unNuevoImpuesto in ListadoImpuestos)
            {
                unImpuesto.AgregarImpuestoXProveedor(unNuevoImpuesto, Convert.ToInt32(tboxCodigoProveedor.Text));
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

            if (ProveedorModificar != null) {

                tboxRazonSocial.Text = ProveedorModificar.RazonSocial;
                tboxNumeroCUIT.Text = ProveedorModificar.NumeroCUIT;
                tboxNombreFantasia.Text = ProveedorModificar.NombreFantasia;
                cboxCondicionIVA.SelectedIndex = cboxCondicionIVA.FindString(ProveedorModificar.CondicionIVA.Nombre);
                tboxCalle.Text = ProveedorModificar.Contacto.Direccion.Calle;
                tboxNumero.Text = ProveedorModificar.Contacto.Direccion.Numero.ToString();
                tboxCP.Text = ProveedorModificar.Contacto.Direccion.CodigoPostal.ToString();
                tboxLocalidad.Text = ProveedorModificar.Contacto.Direccion.Localidad;
                tboxProvincia.Text = ProveedorModificar.Contacto.Direccion.Provincia;
                tboxCelular.Text = ProveedorModificar.Contacto.Celular;
                tboxTelefono.Text = ProveedorModificar.Contacto.Telefono;
                tboxCorreoElectronico.Text = ProveedorModificar.Contacto.Mail;
                ListadoImpuestos = unImpuesto.ListarImpuestosxProveedor(ProveedorModificar.CodigoProveedor);
                dgvImpuestos.DataSource = ListadoImpuestos;
                utilidades.OcultarColumnasDataGridView(dgvImpuestos, "Impuestos");
                btnModificar.Visible = true;

            }

        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
          
            try
            {
               
                Impuesto unNuevoImpuesto = new Impuesto();
                unNuevoImpuesto.Nombre = cboxImpuesto.SelectedItem.ToString();
                unNuevoImpuesto.CodigoImpuesto = cboxImpuesto.FindString(unNuevoImpuesto.Nombre) + 1;
                unNuevoImpuesto.Alicuota = Convert.ToDecimal(tboxPorcentaje.Text);
                listaBindeable = new BindingList<Impuesto>(ListadoImpuestos);
                dgvImpuestos.DataSource = listaBindeable;
                ListadoImpuestos.Add(unNuevoImpuesto);
                listaBindeable.ResetBindings();
                utilidades.OcultarColumnasDataGridView(dgvImpuestos, "Impuestos");

            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
     
        }

        private void dgvImpuestos_SelectionChanged(object sender, EventArgs e)
        {
            Impuesto ImpuestoSeleccionado = (Impuesto)dgvImpuestos.CurrentRow.DataBoundItem;
            cboxImpuesto.Text = ImpuestoSeleccionado.Nombre;
            tboxPorcentaje.Text = ImpuestoSeleccionado.Alicuota.ToString();
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            ProveedorNegocio unProveedor = new ProveedorNegocio();
            ContactoNegocio unContacto = new ContactoNegocio();
            DireccionNegocio unaDireccion = new DireccionNegocio();
            ImpuestoNegocio unImpuesto = new ImpuestoNegocio();

            ProveedorModificar.RazonSocial = tboxRazonSocial.Text;
            ProveedorModificar.NumeroCUIT = tboxNumeroCUIT.Text;
            ProveedorModificar.NombreFantasia = tboxNombreFantasia.Text;
            ProveedorModificar.CondicionIVA =(CondicionIVA)cboxCondicionIVA.SelectedItem;
            ProveedorModificar.Contacto.Direccion.Calle = tboxCalle.Text;
            ProveedorModificar.Contacto.Direccion.Numero = Convert.ToInt32(tboxNumero.Text);
            ProveedorModificar.Contacto.Direccion.CodigoPostal = Convert.ToInt32(tboxCP.Text);
            ProveedorModificar.Contacto.Direccion.Localidad = tboxLocalidad.Text;
            ProveedorModificar.Contacto.Direccion.Provincia = tboxProvincia.Text;
            ProveedorModificar.Contacto.Celular = tboxCelular.Text;
            ProveedorModificar.Contacto.Telefono = tboxTelefono.Text;
            ProveedorModificar.Contacto.Mail = tboxCorreoElectronico.Text;
            unProveedor.ModificarProveedor(ProveedorModificar);
            unContacto.ModificarContacto(ProveedorModificar.Contacto);
            unaDireccion.ModificarDireccion(ProveedorModificar.Contacto.Direccion);

        }
    }
}
