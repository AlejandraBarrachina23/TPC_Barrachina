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
    public partial class FormularioCierreCaja : Form
    {
        public FormularioCierreCaja()
        {
            InitializeComponent();
        }

          private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void tboxCantidadMil_TextChanged(object sender, EventArgs e)
        {   
            tboxTotalMil.Text = CalculoSubtotal(Convert.ToDouble(tboxCantidadMil.Text), 1000).ToString();
            tboxTotalTodosBilletes.Text = CalculoSubtotalBilletes().ToString();
        }

        private void tboxCantidadQuinientos_TextChanged(object sender, EventArgs e)
        {
            tboxTotalQuinientos.Text = CalculoSubtotal(Convert.ToDouble(tboxCantidadQuinientos.Text),500).ToString();
            tboxTotalTodosBilletes.Text = CalculoSubtotalBilletes().ToString();
        }

        private void tboxCantidadDoscientos_TextChanged(object sender, EventArgs e)
        {
            tboxTotalDoscientos.Text = CalculoSubtotal(Convert.ToDouble(tboxCantidadDoscientos.Text), 200).ToString();
            tboxTotalTodosBilletes.Text = CalculoSubtotalBilletes().ToString();
        }

        private void tboxCantidadCien_TextChanged(object sender, EventArgs e)
        {
            tboxTotalCien.Text = CalculoSubtotal(Convert.ToDouble(tboxCantidadCien.Text), 100).ToString();
            tboxTotalTodosBilletes.Text = CalculoSubtotalBilletes().ToString();
        }

        private void tboxCantidadCincuenta_TextChanged(object sender, EventArgs e)
        {
            tboxTotalCincuenta.Text = CalculoSubtotal(Convert.ToDouble(tboxCantidadCincuenta.Text), 50).ToString();
            tboxTotalTodosBilletes.Text = CalculoSubtotalBilletes().ToString();
        }

        private void tboxCantidadVeinte_TextChanged(object sender, EventArgs e)
        {
            tboxTotalVeinte.Text = CalculoSubtotal(Convert.ToDouble(tboxCantidadVeinte.Text), 20).ToString();
            tboxTotalTodosBilletes.Text = CalculoSubtotalBilletes().ToString();
        }

        private void tboxCantidadDiezBillete_TextChanged(object sender, EventArgs e)
        {
            tboxTotalDiezMonedas.Text = CalculoSubtotal(Convert.ToDouble(tboxCantidadDiezMoneda.Text), 10).ToString();
            tboxTotalTodasMonedas.Text = CalculoSubtotalMonedas().ToString();
        }

        private void tboxCantidadCincoMonedas_TextChanged(object sender, EventArgs e)
        {
            tboxTotalCincoMonedas.Text = CalculoSubtotal(Convert.ToDouble(tboxCantidadCincoMonedas.Text), 5).ToString();
            tboxTotalTodasMonedas.Text = CalculoSubtotalMonedas().ToString();
        }

        private void tboxCantidadDos_TextChanged(object sender, EventArgs e)
        {
            tboxTotalMonedaDos.Text = CalculoSubtotal(Convert.ToDouble(tboxCantidadDos.Text), 2).ToString();
            tboxTotalTodasMonedas.Text = CalculoSubtotalMonedas().ToString();
        }

        private void tboxCantidadUno_TextChanged(object sender, EventArgs e)
        {
            tboxTotalMonedasUno.Text = CalculoSubtotal(Convert.ToDouble(tboxCantidadUno.Text), 1).ToString();
            tboxTotalTodasMonedas.Text = CalculoSubtotalMonedas().ToString();
        }

        private void tboxCantidadCincuentaCentavos_TextChanged(object sender, EventArgs e)
        {
            tboxTotalMonedasCincuentaCentavos.Text = CalculoSubtotal(Convert.ToDouble(tboxCantidadCincuentaCentavos.Text), 0.5).ToString();
            tboxTotalTodasMonedas.Text = CalculoSubtotalMonedas().ToString();
        }

        private void tboxCantidadVeintiCinco_TextChanged(object sender, EventArgs e)
        {
            tboxTotalMonedasVeintiCinco.Text = CalculoSubtotal(Convert.ToDouble(tboxCantidadVeintiCinco.Text), 0.25).ToString();
            tboxTotalTodasMonedas.Text = CalculoSubtotalMonedas().ToString();
        }

        private double CalculoSubtotal(double Cantidad, double TipoBilleteMoneda)
        {
            return TipoBilleteMoneda * Cantidad;
        }

        private double CalculoSubtotalBilletes() {

            return Convert.ToDouble(tboxTotalMil.Text) + Convert.ToDouble(tboxTotalQuinientos.Text) + Convert.ToDouble(tboxTotalDoscientos.Text) + Convert.ToDouble(tboxTotalCien.Text) + Convert.ToDouble(tboxTotalCincuenta.Text) + Convert.ToDouble(tboxTotalVeinte.Text);
        }

        private double CalculoSubtotalMonedas() {

            return Convert.ToDouble(tboxTotalDiezMonedas.Text) + Convert.ToDouble(tboxTotalCincoMonedas.Text) + Convert.ToDouble(tboxTotalMonedaDos.Text) + Convert.ToDouble(tboxTotalMonedasUno.Text) + Convert.ToDouble(tboxTotalMonedasCincuentaCentavos.Text) + Convert.ToDouble(tboxTotalMonedasVeintiCinco.Text);
        }
    }
}
