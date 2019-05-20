using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using AccesoDatos;
using Dominio;

namespace Negocio
{
    public class Utilidades
    {
        public string AsignarNombreFormulario(string Nombre)
        {

            if (Nombre == "Clientes")
            {
                return "Listado Clientes";
            }

            else if (Nombre == "Productos")
            {

                return "Listado Productos";
            }

            else if (Nombre == "Proveedores") {

                return "Listado Proveedores";

            }

            return null;
        }

        public object DefinirTipoBusqueda(string NombreFormulario)
        {

            if (NombreFormulario == "Clientes")
            {
                ClienteNegocio unCliente = new ClienteNegocio();
                return unCliente.ListarClientes();
            }

            if (NombreFormulario == "Productos")
            {

                ProductoNegocio unProducto = new ProductoNegocio();
                return unProducto.ListarProductos();

            }

            if (NombreFormulario == "Proveedores") {

                ProveedorNegocio unProveedor = new ProveedorNegocio();
                return unProveedor.ListarProveedores();

            }

            return null;
        }

        public object DefinirTipoEliminacion(object Entidad) {


            if (Entidad.GetType().Equals(typeof(Cliente)))
            {
                MessageBox.Show("Es un Cliente");
                //ClienteNegocio unCliente = new ClienteNegocio();
                //return unCliente.ListarClientes();
            }

            if (Entidad.GetType().Equals(typeof(Producto)))
            {
                ProductoNegocio unProducto = new ProductoNegocio();
                unProducto.EliminarProducto((Producto)Entidad);
                
            }

            if (Entidad.GetType().Equals(typeof(Proveedor)))
            {
                MessageBox.Show("Es un Proveedor");
                //ProveedorNegocio unProveedor = new ProveedorNegocio();
                //return unProveedor.ListarProveedores();

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

                return Grilla;

            }

            if (NombreTabla == "Proveedores") {

                Grilla.Columns[4].Visible = false;
                Grilla.Columns[5].Visible = false;
                Grilla.Columns[6].Visible = false;
                Grilla.Columns[7].Visible = false;

                return Grilla;

            }

            if (NombreTabla == "Impuestos") {

                Grilla.Columns[0].Visible = false;
                Grilla.Columns[2].Visible = false;
                Grilla.Columns[4].Visible = false;

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