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
    public partial class Descuentos : Form
    {
        private Descuento DescuentoModificar = null;
        public Descuentos()
        {
            InitializeComponent();
        }

        public Descuentos(Descuento unDescuento)
        {
            InitializeComponent();
            DescuentoModificar = unDescuento;
        }

        private void Descuentos_Load(object sender, EventArgs e)
        {
            if (DescuentoModificar != null) {

                tboxCodigoDescuento.Text = DescuentoModificar.CodigoDescuento.ToString();
                tboxNombre.Text = DescuentoModificar.Nombre;
                tboxPorcentaje.Text = DescuentoModificar.Porcentaje.ToString();
            }
        }
    }
}
