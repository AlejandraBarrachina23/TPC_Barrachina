using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dominio;
using AccesoDatos;

namespace Negocio
{
    class ProductoNegocio
    {

        public List<Producto> BusquedaProducto(string ParametroBusqueda, string NombreColumna)
        {

            List<Producto> ListadoProductos = new List<Producto>();
            AdministradorAccesoDatos AccederDatos = new AdministradorAccesoDatos();

            string Consulta = "select * from Productos where " + NombreColumna + " = " + ParametroBusqueda;
            AccederDatos.DefinirTipoComando(Consulta);
            AccederDatos.AbrirConexion();
            AccederDatos.EjecutarConsulta();

            while (AccederDatos.LectorDatos.Read())
            {
                Producto unNuevoProducto = new Producto();
                unNuevoProducto.CodigoProducto = (int)AccederDatos.LectorDatos["Codigo"];
                unNuevoProducto.Nombre = (string)AccederDatos.LectorDatos["Nombre"];
                unNuevoProducto.Stock = (int)AccederDatos.LectorDatos["Stock"];
                unNuevoProducto.PrecioVentaMinorista = (decimal)AccederDatos.LectorDatos["PrecioVentaMinorista"];
                unNuevoProducto.PrecioVentaMayorista = (decimal)AccederDatos.LectorDatos["PrecioVentaMayorista"];
                ListadoProductos.Add(unNuevoProducto);
            }

            AccederDatos.CerrarReader();
            AccederDatos.CerrarConexion();
            return ListadoProductos;
        }
    }
}
