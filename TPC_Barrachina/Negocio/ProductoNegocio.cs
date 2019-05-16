using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dominio;
using AccesoDatos;

namespace Negocio
{
    public class ProductoNegocio
    {
        private AdministradorAccesoDatos AccederDatos = new AdministradorAccesoDatos();

        public List<Producto> BusquedaProducto(string ParametroBusqueda, string NombreColumna)
        {
            ParametroBusqueda.ToUpper();
            List<Producto> ListadoProductos = new List<Producto>();
            
            string Consulta = "select * from Productos where " + NombreColumna + " LIKE " + "'"+ ParametroBusqueda +"%'";
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

        public void AgregarProducto(Producto unProducto) {

            AccederDatos.LecturaBaseDatos("INSERT INTO Productos (Codigo,CodigoBulto,Nombre,CodigoTipoProducto,CantidadxBulto,StockCritico,CodigoProveedor,CodigoRubro)" +
                 "VALUES (" + unProducto.CodigoProducto + unProducto.CodigoBulto + unProducto.Nombre + unProducto.TipoProducto + unProducto.StockCritico + unProducto.Proveedor +
                 unProducto.Rubro + ")");
            AccederDatos.CerrarReader();
            AccederDatos.CerrarConexion();
        }
    }
}
