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
        UsuarioNegocio UsuarioNegocio = new UsuarioNegocio();

        protected void Page_Load(object sender, EventArgs e)
        {
            dgvUsuarios.DataSource = UsuarioNegocio.ListadoUsuarios();
            dgvUsuarios.DataBind();
        }
        
        protected void dgvUsuarios_SelectedIndexChanged(object sender, EventArgs e)
        {
            // unUsuarioSeleccionado = (Usuario)dgvUsuarios.SelectedRow.DataItem;
            GridViewRow FilaSeleccionada = dgvUsuarios.SelectedRow;
            unUsuarioSeleccionado.CodigoUsuario = (Convert.ToInt32(dgvUsuarios.DataKeys[FilaSeleccionada.RowIndex].Values["CodigoUsuario"]));
            unUsuarioSeleccionado.Nombre = (dgvUsuarios.DataKeys[FilaSeleccionada.RowIndex].Values["Nombre"]).ToString();
            unUsuarioSeleccionado.Constrasenia = (dgvUsuarios.DataKeys[FilaSeleccionada.RowIndex].Values["Constrasenia"].ToString());
            unUsuarioSeleccionado.SectorDesignado = (dgvUsuarios.DataKeys[FilaSeleccionada.RowIndex].Values["SectorDesignado"].ToString());
            Session["UsuarioSeleccionado"] = unUsuarioSeleccionado;
        }

        protected void dgvUsuarios_RowDataBound(object sender, GridViewRowEventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            
            
        }

        protected void dgvUsuarios_SelectedIndexChanging(object sender, GridViewSelectEventArgs e)
        {
      
        }

        protected void btnAgregar_Click(object sender, EventArgs e)
        {
                pnlAgregarUsuario.Visible = true;
                tboxCodigo.Enabled = true;
                lblTitulo.Text = "Agregar Usuario";
                tboxCodigo.Text = "";
                tboxNombre.Text = "";
                tboxContrasenia.Text = "";
                DdlSectores.SelectedIndex = 1;
                Session["TipoOperacion"] = "Agregar";
        }

        protected void btnModificar_Click(object sender, EventArgs e)
        {
            if (dgvUsuarios.SelectedIndex >= 0)
            {
                pnlAgregarUsuario.Visible = true;
                lblTitulo.Text = "Modificar Usuario";
                unUsuarioSeleccionado = (Usuario)Session["UsuarioSeleccionado"];
                tboxCodigo.Text = unUsuarioSeleccionado.CodigoUsuario.ToString();
                tboxNombre.Text = unUsuarioSeleccionado.Nombre;
                tboxContrasenia.Text = unUsuarioSeleccionado.Constrasenia;
                tboxCodigo.Enabled = false;
                DdlSectores.SelectedIndex = DdlSectores.Items.IndexOf(DdlSectores.Items.FindByText(unUsuarioSeleccionado.SectorDesignado));
                lblAdvertencia.Text = "";
                Session["TipoOperacion"] = "Modificar";
            }

            else {
                lblAdvertencia.Text = "SELECCIONE USUARIO DE LA GRILLA";
                pnlAgregarUsuario.Visible = false;
            }
        }

        protected void btnEliminar_Click(object sender, EventArgs e)
        {
            pnlAgregarUsuario.Visible = false;

            if (dgvUsuarios.SelectedIndex >= 0)
            {
                unUsuarioSeleccionado = (Usuario)Session["UsuarioSeleccionado"];
                UsuarioNegocio.EliminarUsuario(unUsuarioSeleccionado);
                dgvUsuarios.DataSource = UsuarioNegocio.ListadoUsuarios();
                dgvUsuarios.DataBind();
                lblAdvertencia.Text = "";

            }

            else {

                lblAdvertencia.Text = "SELECCIONE USUARIO DE LA GRILLA";
            }

        }

        protected void btnAceptar_Click(object sender, EventArgs e)
        {
            if (Session["TipoOperacion"].ToString() == "Agregar")
            {
                unUsuarioSeleccionado.CodigoUsuario = Convert.ToInt32(tboxCodigo.Text);
                unUsuarioSeleccionado.Nombre = tboxNombre.Text;
                unUsuarioSeleccionado.Constrasenia = tboxContrasenia.Text;
                unUsuarioSeleccionado.SectorDesignado = DdlSectores.SelectedValue;
                UsuarioNegocio.AgregarUsuario(unUsuarioSeleccionado);
            }

            else {

                unUsuarioSeleccionado.CodigoUsuario = Convert.ToInt32(tboxCodigo.Text);
                unUsuarioSeleccionado.Nombre = tboxNombre.Text;
                unUsuarioSeleccionado.Constrasenia = tboxContrasenia.Text;
                unUsuarioSeleccionado.SectorDesignado = DdlSectores.SelectedValue;
                UsuarioNegocio.ModificarUsuario(unUsuarioSeleccionado);
            }

            pnlAgregarUsuario.Visible = false;
            dgvUsuarios.DataSource = UsuarioNegocio.ListadoUsuarios();
            dgvUsuarios.DataBind();
        }
    }
}