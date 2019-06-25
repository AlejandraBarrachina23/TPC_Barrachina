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
    public partial class InicioSesion : Form
    {
        private UsuarioNegocio UsuarioNegocio = new UsuarioNegocio();

        public InicioSesion()
        {
            InitializeComponent();
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            Usuario unUsuarioIngresado = new Usuario();
            unUsuarioIngresado.Nombre = tboxUsuario.Text;
            unUsuarioIngresado.Constrasenia = tboxContrasenia.Text;
            unUsuarioIngresado = UsuarioNegocio.ValidarExistencia(unUsuarioIngresado);

            if (unUsuarioIngresado != null)
            {
                if (unUsuarioIngresado.SectorDesignado == "Administración")
                {
                    MenuAdministrador menuAdministador = new MenuAdministrador(unUsuarioIngresado);
                    menuAdministador.ShowDialog();
                    this.Close();
                }

                else {

                    MenuVendedor menuVendedor = new MenuVendedor(unUsuarioIngresado);
                    menuVendedor.ShowDialog();
                    this.Dispose();
                }
                
            }

            else {

                lblAdvertencia.Visible = true;
            }

        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void tboxUsuario_Click(object sender, EventArgs e)
        {
            tboxUsuario.Clear();
        }

        private void tboxContrasenia_Click(object sender, EventArgs e)
        {
            tboxContrasenia.Clear();
        }
    }
}
