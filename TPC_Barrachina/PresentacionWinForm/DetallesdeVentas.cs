using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Negocio;
using Dominio;

namespace PresentacionWinForm
{
    public partial class DetallesdeVentas : Form
    {
        public DetallesdeVentas()
        {
            InitializeComponent();
        }

        private void DetallesdeVentas_Load(object sender, EventArgs e)
        {
            CabeceraVentaNegocio unDetalleVenta = new CabeceraVentaNegocio();
            Utilidades Utilidades = new Utilidades();
            dgvDetalleVenta.DataSource = unDetalleVenta.ListarVentas();
            Utilidades.AjustarOrdenGridViewCabeceraVenta(dgvDetalleVenta);
        }
    }
}
