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

        public Usuario ValidarExistencia(Usuario unUsuarioIngresado)
        {

            AdministradorAccesoDatos AccederDatos = new AdministradorAccesoDatos();
            AccederDatos.AbrirConexion();
            AccederDatos.DefinirTipoComando("select * from Usuarios where Nombre = '" + unUsuarioIngresado.Nombre + "'");
            AccederDatos.EjecutarConsulta();

            while (AccederDatos.LectorDatos.Read())
            {

                if (unUsuarioIngresado.Nombre.ToString().ToUpper() == AccederDatos.LectorDatos["Nombre"].ToString().ToUpper())
                {

                    if (unUsuarioIngresado.Constrasenia.ToString().ToUpper() == AccederDatos.LectorDatos["Contrasenia"].ToString().ToUpper())
                    {

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
            return unUsuarioIngresado = null;
        }

        public List<Usuario> ListadoUsuarios()
        {

            List<Usuario> ListadoUsuarios = new List<Usuario>();
            AdministradorAccesoDatos AccederDatos = new AdministradorAccesoDatos();
            AccederDatos.AbrirConexion();
            AccederDatos.DefinirTipoComando("SELECT * FROM Usuarios");
            AccederDatos.EjecutarConsulta();
            while (AccederDatos.LectorDatos.Read())
            {

                if ((bool)AccederDatos.LectorDatos["Estado"])
                {

                    Usuario unUsuario = new Usuario();
                    unUsuario.CodigoUsuario = (int)AccederDatos.LectorDatos["CodigoUsuario"];
                    unUsuario.Nombre = AccederDatos.LectorDatos["Nombre"].ToString();
                    unUsuario.Constrasenia = AccederDatos.LectorDatos["Contrasenia"].ToString();
                    unUsuario.SectorDesignado = AccederDatos.LectorDatos["Sector"].ToString();
                    ListadoUsuarios.Add(unUsuario);
                }
            }
            return ListadoUsuarios;
        }

        public void EliminarUsuario(Usuario unUsuario)
        {

            AdministradorAccesoDatos AccederDatos = new AdministradorAccesoDatos();
            AccederDatos.AbrirConexion();
            AccederDatos.DefinirTipoComando("UPDATE Usuarios SET Estado = 0 WHERE CodigoUsuario = '" + unUsuario.CodigoUsuario + "'");
            AccederDatos.EjecutarAccion();
            AccederDatos.CerrarConexion();
        }

        public bool ValidarExistenciaCodigo(int CodigoIngresado)
        {

            AdministradorAccesoDatos AccederDatos = new AdministradorAccesoDatos();
            AccederDatos.AbrirConexion();
            AccederDatos.DefinirTipoComando("select * from Usuarios where Nombre = '" + CodigoIngresado + "'");
            AccederDatos.EjecutarConsulta();

            while (AccederDatos.LectorDatos.Read())
            {

                if ((int)AccederDatos.LectorDatos["CodigoUsuario"] == CodigoIngresado)
                {
                    return true;
                }
               
            }
            return false;
        }

        public void AgregarUsuario(Usuario unUsuario) {

            AdministradorAccesoDatos AccederDatos = new AdministradorAccesoDatos();
            AccederDatos.AbrirConexion();
            AccederDatos.DefinirTipoComando("INSERT INTO Usuarios (CodigoUsuario, Nombre, Sector, Contrasenia) VALUES ('" + unUsuario.CodigoUsuario + "','" + unUsuario.Nombre + "','" + unUsuario.SectorDesignado + "','"
                + unUsuario.Constrasenia + "')");
            AccederDatos.EjecutarAccion();
            AccederDatos.CerrarConexion();
        }

        public void ModificarUsuario(Usuario unUsuario) {

            AdministradorAccesoDatos AccederDatos = new AdministradorAccesoDatos();
            AccederDatos.AbrirConexion();
            AccederDatos.DefinirTipoComando("UPDATE Usuarios Set Nombre=@Nombre, Contrasenia=@Contrasenia, Sector=@Sector WHERE CodigoUsuario = '" + unUsuario.CodigoUsuario + "'");
            AccederDatos.Comando.Parameters.Clear();
            AccederDatos.Comando.Parameters.AddWithValue("@Nombre", unUsuario.Nombre);
            AccederDatos.Comando.Parameters.AddWithValue("@Contrasenia", unUsuario.Constrasenia);
            AccederDatos.Comando.Parameters.AddWithValue("@Sector", unUsuario.SectorDesignado);
            AccederDatos.EjecutarAccion();
            AccederDatos.CerrarConexion();
        }
    }
}
