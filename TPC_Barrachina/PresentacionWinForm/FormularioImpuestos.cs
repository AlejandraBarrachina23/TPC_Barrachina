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
    public partial class FormularioImpuestos : Form
    {
        private Impuesto ImpuestoModificar = null;
        private ImpuestoNegocio unNegocioImpuesto = new ImpuestoNegocio();
        private ValidadorDatos Validar = new ValidadorDatos();

        public FormularioImpuestos()
        {
            InitializeComponent();
        }

        public FormularioImpuestos(Impuesto unImpuesto)
        {
            InitializeComponent();
            ImpuestoModificar = unImpuesto;
            btnAceptar.Visible = false;
            tboxCodigoImpuesto.Enabled = false;
        }

        private void FormularioImpuestos_Load(object sender, EventArgs e)
        {
            if (ImpuestoModificar != null) {

                tboxCodigoImpuesto.Text = ImpuestoModificar.CodigoImpuesto.ToString();
                tboxNombre.Text = ImpuestoModificar.Nombre;
                tboxDescripcion.Text = ImpuestoModificar.Descripcion;
            }
            
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            try
            {
                Validar.FormularioImpuesto(tboxCodigoImpuesto, tboxNombre, tboxDescripcion, "Agregar");
                unNegocioImpuesto.AgregarImpuesto(unNegocioImpuesto.CargarImpuesto(tboxCodigoImpuesto, tboxNombre, tboxDescripcion));   
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
                Validar.FormularioImpuesto(tboxCodigoImpuesto, tboxNombre, tboxDescripcion, "Modificar");
                unNegocioImpuesto.ModificarImpuesto(unNegocioImpuesto.CargarImpuesto(tboxCodigoImpuesto, tboxNombre, tboxDescripcion));
            }
            catch (Exception Excepcion)
            {
                MessageBox.Show(Excepcion.Message);
            }
            
        }
    }
}
