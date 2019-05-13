using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Negocio
{
    public class Utilidades
    {
        public string AsignarNombreFormulario(string Nombre)
        {

            if (Nombre == "Clientes")
            {
                return "Busqueda Cliente";
            }

            else if (Nombre == "Productos")
            {

                return "Busqueda Productos";
            }

            else if (Nombre == "Proveedores") {

                return "Busqueda Proveedores";

            }

            return null;
        }

        public object DefinirTipoBusqueda(string NombreFormulario, string ParametroBusqueda, string NombreColumna)
        {

            if (NombreFormulario == "Busqueda Cliente")
            {
                ClienteNegocio unCliente = new ClienteNegocio();
                return unCliente.BusquedaCliente(ParametroBusqueda, NombreColumna);
            }

            if (NombreFormulario == "Busqueda Productos")
            {

                ProductoNegocio unProducto = new ProductoNegocio();
                return unProducto.BusquedaProducto(ParametroBusqueda, NombreColumna);

            }

            return null;
        }



        //public void DefinirFormularioActivos(Form FormularioActual)
        //{
        //    if (FormularioActual.ActiveMdiChild != null)
        //    {
        //        throw new Exception("La ventana ya se encuentra activa");
        //    }

        //}
    }
}