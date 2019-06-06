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
    public partial class Descuentos : Form
    {
        private Descuento DescuentoModificar = null;
        private DescuentoNegocio unDescuentoNegocio = new DescuentoNegocio();
        public Descuentos()
        {
            InitializeComponent();
        }

        public Descuentos(Descuento unDescuento)
        {
            InitializeComponent();
            DescuentoModificar = unDescuento;
            btnAceptar.Visible = false;
            tboxCodigoDescuento.Enabled=false;
        }

        private void Descuentos_Load(object sender, EventArgs e)
        {
            if (DescuentoModificar != null) {

                tboxCodigoDescuento.Text = DescuentoModificar.CodigoDescuento.ToString();
                tboxNombre.Text = DescuentoModificar.Nombre;
                tboxPorcentaje.Text = DescuentoModificar.Porcentaje.ToString();
            }
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            unDescuentoNegocio.AgregarDescuento(unDescuentoNegocio.CargarDescuento(tboxCodigoDescuento, tboxNombre, tboxPorcentaje));
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            unDescuentoNegocio.ModificarDescuento(unDescuentoNegocio.CargarDescuento(tboxCodigoDescuento, tboxNombre, tboxPorcentaje));
        }
    }
}
