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
    public partial class FormularioBusqueda : Form

    {
        private Utilidades utilidades = new Utilidades();
        public FormularioBusqueda(string NombreFormulario)
        {
            InitializeComponent();
            lblNombreFormulario.Text = utilidades.AsignarNombreFormulario(NombreFormulario);
        }

        public FormularioBusqueda(string NombreFormulario, string NombreFormularioQueLlamo) {

            InitializeComponent();
            lblNombreFormulario.Text = utilidades.AsignarNombreFormulario(NombreFormulario);
            btnAceptar.Visible = false;
            btnAgregar.Visible = true;
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            try
            {
                dgvListadoBusqueda.DataSource = utilidades.DefinirEntidadaFiltrar(panelContenedor, lblNombreFormulario);

                //string NombreFormulario = lblNombreFormulario.Text.Remove(0, 8);
                //MessageBox.Show(NombreFormulario,NombreTextBox);
                //dgvListadoBusqueda.DataSource = utilidades.DefinirEntidadAlistar(NombreTextBox); 
                //dgvListadoBusqueda = utilidades.OcultarColumnasDataGridView(dgvListadoBusqueda, NombreFormulario);
            }

            catch (Exception Excepcion)
            {
                MessageBox.Show(Excepcion.Message);
            }

        }

        private void Busqueda_Load(object sender, EventArgs e)
        {
            dgvListadoBusqueda.DataSource = utilidades.DefinirEntidadAlistar(lblNombreFormulario.Text.Remove(0, 8));
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void tboxCodigo_Click(object sender, EventArgs e)
        {
            tboxNombre.Clear();
        }

        private void tboxNombre_Click(object sender, EventArgs e)
        {
            tboxCodigo.Clear();
        }
    }
}
