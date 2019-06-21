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
        

        protected void Page_Load(object sender, EventArgs e)
        {
            unUsuarioModificar =(Usuario)Session["AgregarUsuario"];
            tboxCodigo.Text = unUsuarioModificar.CodigoUsuario.ToString();
            tboxNombre.Text = unUsuarioModificar.Nombre;
        }

        protected void tboxCodigo_TextChanged(object sender, EventArgs e)
        {
            
        }
    }
}