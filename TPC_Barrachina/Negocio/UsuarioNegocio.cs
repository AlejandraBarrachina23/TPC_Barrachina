using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dominio;
using AccesoDatos;

namespace Negocio
{
    public class UsuarioNegocio
    {

        public Usuario ValidarExistencia(Usuario unUsuarioIngresado) {

            AdministradorAccesoDatos AccederDatos = new AdministradorAccesoDatos();
            AccederDatos.AbrirConexion();
            AccederDatos.DefinirTipoComando("select * from Usuarios where Nombre = '" + unUsuarioIngresado.Nombre + "'");
            AccederDatos.EjecutarConsulta();

            while (AccederDatos.LectorDatos.Read()) {

                if (unUsuarioIngresado.Nombre.ToString().ToUpper() == AccederDatos.LectorDatos["Nombre"].ToString().ToUpper()) {

                    if (unUsuarioIngresado.Constrasenia.ToString().ToUpper() == AccederDatos.LectorDatos["Contrasenia"].ToString().ToUpper()) {

                        unUsuarioIngresado.CodigoUsuario = (int)AccederDatos.LectorDatos["CodigoUsuario"];
                        unUsuarioIngresado.SectorDesignado = AccederDatos.LectorDatos["Sector"].ToString();
                        AccederDatos.CerrarReader();
                        AccederDatos.CerrarConexion();
                        return unUsuarioIngresado;
                    }

                }

            }

            AccederDatos.CerrarReader();
            AccederDatos.CerrarConexion();
            return unUsuarioIngresado=null;
        }

        public List<Usuario> ListadoUsuarios() {

            List<Usuario> ListadoUsuarios = new List<Usuario>();
            AdministradorAccesoDatos AccederDatos = new AdministradorAccesoDatos();
            AccederDatos.AbrirConexion();
            AccederDatos.DefinirTipoComando("SELECT * FROM Usuarios");
            AccederDatos.EjecutarConsulta();
            while (AccederDatos.LectorDatos.Read()) {

                Usuario unUsuario = new Usuario();

                unUsuario.CodigoUsuario = (int)AccederDatos.LectorDatos["CodigoUsuario"];
                unUsuario.Nombre = AccederDatos.LectorDatos["Nombre"].ToString();
                unUsuario.Constrasenia = AccederDatos.LectorDatos["Contrasenia"].ToString();
                unUsuario.SectorDesignado = AccederDatos.LectorDatos["Sector"].ToString();
                ListadoUsuarios.Add(unUsuario);
            }

            return ListadoUsuarios;
        }

    }
}
