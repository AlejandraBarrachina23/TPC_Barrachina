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

namespace PresentacionWinForm
{
    public partial class FormularioListado : Form
    {
        private Utilidades utilidades = new Utilidades();

        public FormularioListado(string NombreFormulario)
        {
            InitializeComponent();
            lblNombreFormulario.Text = utilidades.AsignarNombreFormulario(NombreFormulario);
        }

        private void FormularioListado_Load(object sender, EventArgs e)
        {
            List<object> ListadoEntidad;
            dgvListadoBusqueda.DataSource = utilidades.DefinirTipoBusqueda(lblNombreFormulario.Text.Remove(0, 8));
            utilidades.OcultarColumnasDataGridView(dgvListadoBusqueda, lblNombreFormulario.Text.Remove(0, 8));
        }
    }
}
