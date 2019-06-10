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
    public partial class MetodoPago : Form
    {

        string nombreboton;

        public MetodoPago()
        {
            InitializeComponent();
            btnEfectivo.Click += boton_click;
            btnMercadoPago.Click += boton_click;
            btnDebito.Click += boton_click;
            btnCtaCorriente.Click += boton_click;
            btnCreditoUnaCuota.Click += boton_click;
            btnCreditoTresCuotas.Click += boton_click;
        }

        public delegate void ElegirMetodoPago(string Nombre);
        public event ElegirMetodoPago SeleccionarMetodoPago;

          private void btnCredito_Click(object sender, EventArgs e)
        {
            btnCreditoUnaCuota.Visible = true;
            btnCreditoTresCuotas.Visible = true;
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            SeleccionarMetodoPago(nombreboton);
            this.Dispose();
        }
        
        void boton_click(Object sender, EventArgs e)
        {
            Button btnTipoPago = sender as Button;
            nombreboton = btnTipoPago.Name;
            nombreboton = nombreboton.Remove(0, 3);
            
        }

    }
}
