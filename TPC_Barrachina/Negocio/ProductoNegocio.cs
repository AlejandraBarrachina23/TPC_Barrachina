using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dominio;
using AccesoDatos;
using System.Windows.Forms;

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

                unNuevoProducto.CodigoProducto = (int)AccederDatos.LectorDatos["CodigoProducto"];
                unNuevoProducto.Nombre = AccederDatos.LectorDatos["Nombre"].ToString();
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

            AccederDatos.DefinirTipoComando(("INSERT INTO Productos (CodigoProducto,CodigoBulto,Nombre,CodigoTipoProducto,CantidadxBulto,StockCritico,CodigoProveedor,CodigoRubro)" +
                 "VALUES ('" + unProducto.CodigoProducto + "','" + unProducto.CodigoBulto + "','" + unProducto.Nombre.ToString() + "','" + unProducto.TipoProducto.CodigoTipoProducto.ToString() + "','" + unProducto.CantidadxBulto + "','" + unProducto.StockCritico + "','" + unProducto.Proveedor.CodigoProveedor + "','" +
                 unProducto.Rubro.CodigoRubro + "')"));
            AccederDatos.AbrirConexion();
            AccederDatos.EjecutarConsulta();
            AccederDatos.CerrarReader();
            AccederDatos.CerrarConexion();
        }
    }
}
