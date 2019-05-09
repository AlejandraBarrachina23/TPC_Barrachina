using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PresentacionWinForm
{
    public partial class FormularioVenta : Form
    {
       

        public FormularioVenta()
        {
            InitializeComponent();
        }

        private void btnAgregarCliente_Click(object sender, EventArgs e)
        {
            string NombreFormulario = "Cliente";
            Busqueda BusquedaCliente = new Busqueda(NombreFormulario);
            BusquedaCliente.Show();
            
        }
    }
}
