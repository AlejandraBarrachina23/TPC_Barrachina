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
                //BUSQUEDA UNIVERSAL DE ENTIDADES
                TextBox TextBoxSeleccionado = panelContenedor.Controls.OfType<TextBox>().FirstOrDefault(x => x.Text != ""); //Tomo el primer valor del textbox que no este vacío, la busqueda se permite a través de Codigo o Nombre
                string NombreTextBox = TextBoxSeleccionado.Name.Remove(0,4); //Defino el nombre del parametro para hacer la busqueda, lo extraigo del Name borrando el "tbox" -> tboxCodigo -> Codigo
                string NombreFormulario = lblNombreFormulario.Text.Remove(0, 9); // Defino el nombre del Formulario a través del text del label borrando el "busqueda" -> busquedaCliente -> Cliente
                dgvListadoBusqueda.DataSource = utilidades.DefinirTipoBusqueda(lblNombreFormulario.Text, TextBoxSeleccionado.Text, NombreTextBox); //Defino la busqueda según la entidad
                dgvListadoBusqueda = utilidades.OcultarColumnasDataGridView(dgvListadoBusqueda, NombreFormulario);//Defino las columnas que van a ser visibles según la entidad que deseo mostrar
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
            tboxNombre.Clear();

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

        private void tboxNombre_Click(object sender, EventArgs e)
        {
            tboxCodigo.Clear();
                     
        }
    }
}
