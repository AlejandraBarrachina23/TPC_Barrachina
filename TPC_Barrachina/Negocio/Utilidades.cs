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
                //return unCliente.BusquedaCliente(ParametroBusqueda, NombreColumna);
            }

            if (NombreFormulario == "Busqueda Productos")
            {

                ProductoNegocio unProducto = new ProductoNegocio();
                return unProducto.BusquedaProducto(ParametroBusqueda, NombreColumna);

            }

            if (NombreFormulario == "Busqueda Proveedores") {

                ProveedorNegocio unProveedor = new ProveedorNegocio();
                //return unProveedor.BusquedaProveedores(ParametroBusqueda, NombreColumna);

            }

            return null;
        }

        public DataGridView OcultarColumnasDataGridView(DataGridView Grilla, string NombreTabla) {

            if (NombreTabla == "Productos") {

                Grilla.Columns[1].Visible = false;
                Grilla.Columns[3].Visible = false;
                Grilla.Columns[5].Visible = false;
                Grilla.Columns[6].Visible = false;
                Grilla.Columns[7].Visible = false;
                Grilla.Columns[11].Visible = false;
                Grilla.Columns[12].Visible = false;
                Grilla.Columns[13].Visible = false;
                Grilla.Columns[14].Visible = false;
                return Grilla;

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