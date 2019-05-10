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
        public List<Cliente> BusquedaCliente(string Codigo, string Nombre) {

            List<Cliente> ListadoClientes = new List<Cliente>();
            AdministradorAccesoDatos AccederDatos = new AdministradorAccesoDatos();

            string Consulta = "select * from Clientes where IdCliente = " + Codigo;
            AccederDatos.DefinirTipoComando(Consulta);
            AccederDatos.AbrirConexion();
            AccederDatos.EjecutarConsulta();

            while (AccederDatos.LectorDatos.Read())
            {
                Cliente unNuevoCliente = new Cliente();
                unNuevoCliente.CodigoCliente = (int) AccederDatos.LectorDatos["IdCliente"];
                unNuevoCliente.Estado = (bool)AccederDatos.LectorDatos["Estado"];
                ListadoClientes.Add(unNuevoCliente);
            }

            AccederDatos.CerrarReader();
            AccederDatos.CerrarConexion();
            return ListadoClientes;
        }
    }
}
