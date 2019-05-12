using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Negocio
{
    public class Utilidades
    {
        public string AsignarNombreFormulario(string Nombre)
        {

            if (Nombre == "Cliente")
            {
                return "Busqueda Cliente";
            }

            else if (Nombre == "Productos")
            {

                return "Busqueda Productos";
            }

            return null;
        }

        public object DefinirTipoBusqueda(string NombreFormulario, string CodigoEntidad, string NombreEntidad)
        {

            if (NombreFormulario == "Busqueda Cliente")
            {
                ClienteNegocio unCliente = new ClienteNegocio();
                return unCliente.BusquedaCliente(CodigoEntidad, NombreEntidad);
            }

            return null;
        }


    }
}