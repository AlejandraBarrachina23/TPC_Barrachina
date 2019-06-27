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
        private ValidadorDatos Validar = new ValidadorDatos();
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
            try
            {
                Validar.FormularioDescuento(tboxCodigoDescuento, tboxNombre, tboxPorcentaje, "Agregar");
                unDescuentoNegocio.AgregarDescuento(unDescuentoNegocio.CargarDescuento(tboxCodigoDescuento, tboxNombre, tboxPorcentaje));
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
                Validar.FormularioDescuento(tboxCodigoDescuento, tboxNombre, tboxPorcentaje, "Modificar");
                unDescuentoNegocio.ModificarDescuento(unDescuentoNegocio.CargarDescuento(tboxCodigoDescuento, tboxNombre, tboxPorcentaje));
            }
            catch (Exception Excepcion)
            {
                MessageBox.Show(Excepcion.Message);
            }
  
        }

        private void tboxCodigoDescuento_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void tboxPorcentaje_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && e.KeyChar != (char)Keys.Back && e.KeyChar != '.')
            {
                e.Handled = true;
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }
    }
}
