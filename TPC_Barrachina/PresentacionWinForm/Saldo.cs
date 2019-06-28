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
    public partial class Saldo : Form

    {
        private Cliente unCliente = new Cliente();
        private ValidadorDatos Validar = new ValidadorDatos();

        public Saldo(Cliente unClienteDeudor)
        {
            InitializeComponent();
            unCliente = unClienteDeudor;
        }

        private void Saldo_Load(object sender, EventArgs e)
        {
            tboxCodigoCliente.Text = unCliente.CodigoCliente.ToString();
            tboxNombre.Text = unCliente.Nombre;
            tboxSaldo.Text = unCliente.CuentaCorriente.Saldo.ToString();
            
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {

            try
            {
                Validar.ContenidoTextBoxVacio(tboxRecibido, "Recibido");
                Validar.MaximoValor(Convert.ToDecimal(tboxSaldo.Text), "Recibido", Convert.ToDecimal(tboxRecibido.Text));
                unCliente.CuentaCorriente.Saldo = unCliente.CuentaCorriente.Saldo - Convert.ToDecimal(tboxRecibido.Text);
                
                ClienteNegocio unClienteNegocio = new ClienteNegocio();
                unClienteNegocio.ActualizarSaldo(unCliente);
                this.Dispose();
            }
            catch (Exception Excepcion)
            {
                MessageBox.Show(Excepcion.Message);
            }
 
        }
    }
}
