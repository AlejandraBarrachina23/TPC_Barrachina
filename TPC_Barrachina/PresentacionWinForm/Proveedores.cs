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
        ValidadorDatos Validar = new ValidadorDatos();
        Utilidades Utilidades = new Utilidades();
        List<Impuesto> ListadoImpuestos = new List<Impuesto>();
        private Proveedor ProveedorModificar = null;

        public Proveedores()
        {
            InitializeComponent();
                        
            tboxCodigoProveedor.KeyPress += AsignarSoloNumeros;
            tboxCP.KeyPress += AsignarSoloNumeros;
            tboxNumeroCUIT.KeyPress += AsignarSoloNumeros;
            tboxNumero.KeyPress += AsignarSoloNumeros;
            tboxTelefono.KeyPress += AsignarSoloNumeros;
            tboxCelular.KeyPress += AsignarSoloNumeros;
            tboxPorcentaje.KeyPress += AsignarSoloNumeroEnterosDecimales;

        }

        public Proveedores(Proveedor unProveedorModificar) {

            InitializeComponent();
            ProveedorModificar = unProveedorModificar;
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            try
            {

                Validar.FormularioProveedor(tboxCodigoProveedor, tboxRazonSocial, tboxNumeroCUIT, tboxNombreFantasia, cboxCondicionIVA, tboxTelefono, tboxCelular, tboxCorreoElectronico, tboxCalle, tboxNumero, tboxCP, tboxProvincia, tboxLocalidad, "Agregar");
                DireccionNegocio unaDireccion = new DireccionNegocio();
                ProveedorNegocio unProveedor = new ProveedorNegocio();
                int CodigoDireccion = unaDireccion.ContaFilasDireccion();
                unProveedor.AgregarProveedor(unProveedor.CargarProveedor(tboxCodigoProveedor, tboxRazonSocial, tboxNumeroCUIT, tboxNombreFantasia, cboxCondicionIVA, tboxTelefono, tboxCelular, tboxCorreoElectronico, tboxProvincia, tboxLocalidad, tboxCalle, tboxNumero, tboxCP, CodigoDireccion));
                ImpuestoNegocio unImpuesto = new ImpuestoNegocio();

                foreach (Impuesto unNuevoImpuesto in ListadoImpuestos)
                {
                    unImpuesto.AgregarImpuestoXProveedor(unNuevoImpuesto, Convert.ToInt32(tboxCodigoProveedor.Text));
                }

                Avisos FormularioAviso = new Avisos("Proveedores");
                FormularioAviso.Show();
            }

            catch (Exception Excepcion)
            {

                MessageBox.Show(Excepcion.Message);
            }
      
        }

        private void Proveedores_Load(object sender, EventArgs e)
        {
            CondicionIVANegocio unaCondicionIVA = new CondicionIVANegocio();
            ImpuestoNegocio unImpuesto = new ImpuestoNegocio();
            cboxCondicionIVA.DataSource = unaCondicionIVA.ListarCondicionIVA();
            cboxImpuesto.DataSource = unImpuesto.ListarImpuestos();

            if (ProveedorModificar != null) {
                dgvImpuestos.DataSource = unImpuesto.ListarImpuestosxProveedor(ProveedorModificar.CodigoProveedor);
            }
            

            if (ProveedorModificar != null) {

                tboxCodigoProveedor.Enabled = false;
                tboxCodigoProveedor.Text = ProveedorModificar.CodigoProveedor.ToString();
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
                dgvImpuestos= Utilidades.OcultarColumnasDataGridView(dgvImpuestos, "Impuestos");
                btnModificar.Visible = true;

            }

        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            AvisoConOpcion FormularioAvisoConOpcion = new AvisoConOpcion("Proveedores");
            FormularioAvisoConOpcion.Show(this);
        }

        private void btnAgregarImpuesto_Click(object sender, EventArgs e)
        {
          
            try
            {
                Validar.ContenidoTextBoxVacio(tboxPorcentaje, "Porcentaje");
                Impuesto unNuevoImpuestoAgregar = new Impuesto();
                unNuevoImpuestoAgregar = (Impuesto)cboxImpuesto.SelectedItem;
                unNuevoImpuestoAgregar.Alicuota = Convert.ToDecimal(tboxPorcentaje.Text);
                Validar.ImpuestoRepetido(ListadoImpuestos, unNuevoImpuestoAgregar);
                dgvImpuestos.DataSource = null;
                ListadoImpuestos.Add(unNuevoImpuestoAgregar);
                dgvImpuestos.DataSource = ListadoImpuestos;
                dgvImpuestos = Utilidades.OcultarColumnasDataGridView(dgvImpuestos, "Impuestos");

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
     
        }

        private void btnBorrarImpuesto_Click(object sender, EventArgs e)
        {
            try
            {
                Validar.GrillaVacia(dgvImpuestos);
                Impuesto ImpuestoEliminar = (Impuesto)dgvImpuestos.CurrentRow.DataBoundItem;

                if (ListadoImpuestos.Contains(ImpuestoEliminar))
                {
                    ListadoImpuestos.Remove(ImpuestoEliminar);
                }

                dgvImpuestos.DataSource = null;
                dgvImpuestos.DataSource = ListadoImpuestos;
            }

            catch (Exception Excepcion)
            {
                MessageBox.Show(Excepcion.Message);
            }
        }

        private void btnModificarImpuesto_Click(object sender, EventArgs e)
        {
            try
            {

                Validar.GrillaVacia(dgvImpuestos);
                Impuesto NuevoImpuesto = (Impuesto)dgvImpuestos.CurrentRow.DataBoundItem;
                NuevoImpuesto.Alicuota = Convert.ToDecimal(tboxPorcentaje.Text);
                var posicion = ListadoImpuestos.IndexOf(NuevoImpuesto);
                ListadoImpuestos.RemoveAt(posicion);
                ListadoImpuestos.Insert(posicion, NuevoImpuesto);
                dgvImpuestos.DataSource = null;
                dgvImpuestos.DataSource = ListadoImpuestos;
            }
            catch (Exception Excepcion)
            {
                MessageBox.Show(Excepcion.Message);
            }
            

        }

        private void dgvImpuestos_SelectionChanged(object sender, EventArgs e)
        {
            try
            {
                if (ListadoImpuestos.Any())
                {
                    Impuesto ImpuestoSeleccionado = (Impuesto)dgvImpuestos.CurrentRow.DataBoundItem;
                    cboxImpuesto.SelectedIndex = cboxImpuesto.FindString(ImpuestoSeleccionado.Nombre);
                    tboxPorcentaje.Text = ImpuestoSeleccionado.Alicuota.ToString();
                }
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

                Validar.FormularioProveedor(tboxCodigoProveedor, tboxRazonSocial, tboxNumeroCUIT, tboxNombreFantasia, cboxCondicionIVA, tboxTelefono, tboxCelular, tboxCorreoElectronico, tboxCalle, tboxNumero, tboxCP, tboxProvincia, tboxLocalidad, "Modificar");
                ProveedorNegocio unProveedor = new ProveedorNegocio();
                ImpuestoNegocio unImpuestoNegocio = new ImpuestoNegocio();
                unProveedor.ModificarProveedor(unProveedor.CargarProveedor(tboxCodigoProveedor, tboxRazonSocial, tboxNumeroCUIT, tboxNombreFantasia, cboxCondicionIVA, tboxTelefono, tboxCelular, tboxCorreoElectronico, tboxProvincia, tboxLocalidad, tboxCalle, tboxNumero, tboxCP, ProveedorModificar.Contacto.CodigoContacto));
                unImpuestoNegocio.RestaurarEstadosImpuestosXProveedor(ProveedorModificar.CodigoProveedor);
                foreach (Impuesto unImpuesto in ListadoImpuestos)
                {
                    unImpuestoNegocio.ModificarImpuestoxProveedor(unImpuesto, ProveedorModificar.CodigoProveedor);
                }

                Avisos FormularioAviso = new Avisos("Proveedores");
                FormularioAviso.Show();

            }
            catch (Exception Excepcion)
            {
                MessageBox.Show(Excepcion.Message);
            }
            
        }

        void AsignarSoloNumeros(object sender, KeyPressEventArgs e)
        {
            TextBox Tbox = new TextBox();

            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;

            }
        }

        private void AsignarSoloNumeroEnterosDecimales(object sender, KeyPressEventArgs e)
        {

            if (!Char.IsDigit(e.KeyChar) && e.KeyChar != (char)Keys.Back && e.KeyChar != '.')
            {
                e.Handled = true;
            }
        }

    }
}
