using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Negocio
{
    public class Utilidades
    {
        public string AsignarNombreFormulario(string Nombre) {

            if (Nombre == "Cliente") {

                return "BusquedaCliente";
            }

            return "Nada";
        }
    }
}
