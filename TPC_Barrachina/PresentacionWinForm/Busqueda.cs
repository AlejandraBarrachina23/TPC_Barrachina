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
    public partial class Busqueda : Form
    {
        public Busqueda(string NombreFormulario)
        {
            InitializeComponent();
            Utilidades utilidades = new Utilidades();
            lblNombreFormulario.Text = utilidades.AsignarNombreFormulario(NombreFormulario);
           
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            try
            {
                Utilidades utilidades = new Utilidades();
                MessageBox.Show(lblNombreFormulario.Text);
                dgvListadoBusqueda.DataSource = utilidades.DefinirTipoBusqueda(lblNombreFormulario.Text, tboxCodigo.Text,tboxNombre.Text);

            }
            catch (Exception)
            {

                throw;
            }
           

        }

        private void Busqueda_Load(object sender, EventArgs e)
        {
            
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void tboxCodigo_Click(object sender, EventArgs e)
        {
           
        }

        private void tboxCodigo_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(char.IsNumber(e.KeyChar)) && (e.KeyChar != (char)Keys.Back))
            {
                MessageBox.Show("Solo se permiten numeros", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                e.Handled = true;
            }
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {

        }
    }
}
