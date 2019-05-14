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
    public partial class Clientes : Form
    {
        public Clientes()
        {
            InitializeComponent();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            try
            {
                ClienteNegocio unClienteNegocio = new ClienteNegocio();
                unClienteNegocio.NuevoCliente();
            }
            catch (Exception)
            {

                throw;
            }
        }
    }
}
