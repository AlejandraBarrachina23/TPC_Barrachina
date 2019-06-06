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
        public FormularioImpuestos()
        {
            InitializeComponent();
        }

        public FormularioImpuestos(Impuesto unImpuesto)
        {
            InitializeComponent();
            ImpuestoModificar = unImpuesto;

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
            Impuesto unImpuesto = new Impuesto();
            ImpuestoNegocio unNegocioImpuesto = new ImpuestoNegocio();
            unImpuesto.CodigoImpuesto = Convert.ToInt32(tboxCodigoImpuesto.Text);                
            unImpuesto.Nombre = tboxNombre.Text;
            unImpuesto.Descripcion = tboxDescripcion.Text;
            unNegocioImpuesto.AgregarImpuesto(unImpuesto);
        }
    }
}
