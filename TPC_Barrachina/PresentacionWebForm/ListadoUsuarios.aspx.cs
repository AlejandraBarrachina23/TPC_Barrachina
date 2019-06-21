using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Negocio;
using Dominio;

namespace PresentacionWebForm
{
    public partial class ListadoUsuarios : System.Web.UI.Page
    {
        Usuario unUsuarioSeleccionado = new Usuario();

        protected void Page_Load(object sender, EventArgs e)
        {
            UsuarioNegocio UsuarioNegocio = new UsuarioNegocio();
            dgvUsuarios.DataSource = UsuarioNegocio.ListadoUsuarios();
            dgvUsuarios.DataBind();
        }

        protected void dgvUsuarios_SelectedIndexChanged(object sender, EventArgs e)
        {
            unUsuarioSeleccionado = (Usuario)dgvUsuarios.SelectedRow.DataItem;
            0

        }

        protected void dgvUsuarios_RowDataBound(object sender, GridViewRowEventArgs e)
        {
            
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            Session["AgregarUsuario"] = unUsuarioSeleccionado;
            Response.Redirect("FormularioUsuario.aspx");
        }
    }
}