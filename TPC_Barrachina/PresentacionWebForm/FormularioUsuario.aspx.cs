using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Dominio;
using Negocio;

namespace PresentacionWebForm
{
    public partial class About : Page
    {
        Usuario unUsuarioModificar = null;
        Usuario unNuevoUsuario = null;

        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["Accion"].ToString() == "Modificar") {


            }
        }

        protected void tboxCodigo_TextChanged(object sender, EventArgs e)
        {
            if (Session["Accion"].ToString() == "Agregar")
            {
                UsuarioNegocio unUsuarioNegocio = new UsuarioNegocio();
                if (unUsuarioNegocio.ValidarExistenciaCodigo(Convert.ToInt32(tboxCodigo.Text))) {
                    lblCodigo.Visible = true;
                    lblCodigo.Text = "REPETIDO";
                }
                
            }
        }
    }
}