using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Negocio;
using Dominio;

namespace PresentacionWebsForm
{
    public partial class _Default : Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            CabeceraVentaNegocio unaCabeceraVenta = new CabeceraVentaNegocio();
            lblRedaudacionNumerico.Text = "$ " + unaCabeceraVenta.TotalVentasDelDia().ToString();
            lblCantidadVentas.Text = unaCabeceraVenta.CantidadVentasDelDia().ToString();
            lblGananciaNumerica.Text = "$" + unaCabeceraVenta.GananciaDelDia().ToString();
        }
    }
}