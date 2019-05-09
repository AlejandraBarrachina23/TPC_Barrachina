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
        private string resultado = "Normal";

        public Busqueda(string NombreFormulario)
        {
            InitializeComponent();
            Utilidades utilidades = new Utilidades();
            resultado = utilidades.AsignarNombreFormulario(NombreFormulario);
            lblNombreFormulario.Text = resultado;
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            
        }

        private void Busqueda_Load(object sender, EventArgs e)
        {
            
        }
    }
}
