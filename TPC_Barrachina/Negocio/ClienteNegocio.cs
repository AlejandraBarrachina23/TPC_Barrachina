using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dominio;
using AccesoDatos;

namespace Negocio
{
    class ClienteNegocio
    {
        public List<Cliente> BusquedaCliente(string ParametroBusqueda, string NombreColumna) {

            ParametroBusqueda.ToUpper();
            List<Cliente> ListadoClientes = new List<Cliente>();
            AdministradorAccesoDatos AccederDatos = new AdministradorAccesoDatos();

            string Consulta = "select * from Clientes where " + NombreColumna + " LIKE '" + ParametroBusqueda +"'";
            AccederDatos.DefinirTipoComando(Consulta);
            AccederDatos.AbrirConexion();
            AccederDatos.EjecutarConsulta();

            while (AccederDatos.LectorDatos.Read())
            {
                Cliente unNuevoCliente = new Cliente();
                unNuevoCliente.CodigoCliente = (int) AccederDatos.LectorDatos["Codigo"];
                unNuevoCliente.Estado = (bool)AccederDatos.LectorDatos["Estado"];
                ListadoClientes.Add(unNuevoCliente);
            }

            AccederDatos.CerrarReader();
            AccederDatos.CerrarConexion();
            return ListadoClientes;
        }
    }
}
