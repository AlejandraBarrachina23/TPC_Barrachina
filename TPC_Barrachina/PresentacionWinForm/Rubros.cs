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
    public partial class Rubros : Form
    {
        private Rubro RubroModificar = null;
        public Rubros()
        {
            InitializeComponent();
        }

        public Rubros(Rubro unRubro)
        {
            InitializeComponent();
            RubroModificar = unRubro;

        }

        private void Rubros_Load(object sender, EventArgs e)
        {
            if (RubroModificar != null) {

                tboxCodigoRubro.Text = RubroModificar.CodigoRubro.ToString();
                tboxNombre.Text = RubroModificar.Nombre;
                tboxCodigoRubro.Enabled = false;
            }
        }
    }
}
