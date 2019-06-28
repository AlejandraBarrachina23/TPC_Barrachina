using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Dominio;
using Negocio;

namespace PresentacionWebsForm
{
    public partial class InicioSesion : System.Web.UI.Page
    {

        protected void Page_Load(object sender, EventArgs e)
        {
            lblAdvertencia.Visible = false;
        }

        protected void btnAceptar_Click(object sender, EventArgs e)
        {
            Usuario UsuarioIngresado = new Usuario();
            UsuarioNegocio UsuarioNegocio = new UsuarioNegocio();
            UsuarioIngresado.Nombre = tboxNombreUsuario.Text;
            UsuarioIngresado.Constrasenia = tboxContraseniaUsuario.Text;
            UsuarioIngresado = UsuarioNegocio.ValidarExistencia(UsuarioIngresado);
            if (UsuarioIngresado != null)
            {
                Session["UsuarioIngresado"] = UsuarioIngresado;
                Response.Redirect("Principal.aspx");
            }
            else
            {
                tboxNombreUsuario.Text = "";
                tboxContraseniaUsuario.Text = "";
                lblAdvertencia.Text = "Usuario/Contraseña Incorrecto";
                lblAdvertencia.Visible = true;

            }
        }
    }
}