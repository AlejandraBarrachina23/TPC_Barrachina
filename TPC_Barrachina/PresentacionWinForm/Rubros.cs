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
    public partial class Rubros : Form
    {
        private Rubro RubroModificar = null;
        RubroNegocio unRubroNegocio = new RubroNegocio();
        public Rubros()
        {
            InitializeComponent();
        }

        public Rubros(Rubro unRubro)
        {
            InitializeComponent();
            RubroModificar = unRubro;
            btnAceptar.Visible = false;
            tboxCodigoRubro.Enabled = false;

        }

        private void Rubros_Load(object sender, EventArgs e)
        {
            if (RubroModificar != null) {

                tboxCodigoRubro.Text = RubroModificar.CodigoRubro.ToString();
                tboxNombre.Text = RubroModificar.Nombre;
                tboxCodigoRubro.Enabled = false;
            }
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            unRubroNegocio.AgregarRubro(unRubroNegocio.CargarRubro(tboxCodigoRubro, tboxNombre));
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            unRubroNegocio.ModificarRubro(unRubroNegocio.CargarRubro(tboxCodigoRubro, tboxNombre));
        }
    }
}
