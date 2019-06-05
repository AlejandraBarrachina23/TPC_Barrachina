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

                if ((bool)AccederDatos.LectorDatos["Estado"]) {

                unNuevoProducto.CodigoProducto = AccederDatos.LectorDatos["CodigoProducto"].ToString();
                unNuevoProducto.Nombre = AccederDatos.LectorDatos["Nombre"].ToString();
                unNuevoProducto.Stock = (int)AccederDatos.LectorDatos["Stock"];
                unNuevoProducto.PrecioVentaMinorista = (decimal)AccederDatos.LectorDatos["PrecioVentaMinorista"];
                unNuevoProducto.PrecioVentaMayorista = (decimal)AccederDatos.LectorDatos["PrecioVentaMayorista"];
                ListadoProductos.Add(unNuevoProducto);
                }
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

        public List<Producto> ListarProductos()
        {

            List<Producto> ListaProductos = new List<Producto>();
            AccederDatos.LecturaBaseDatos("SELECT * FROM Productos INNER JOIN Proveedores on Proveedores.CodigoProveedor = Productos.CodigoProveedor INNER JOIN Rubros ON Rubros.CodigoRubro = Productos.CodigoRubro" +
                " inner join TipoProductos ON Productos.CodigoTipoProducto = TipoProductos.CodigoTipoProducto");

            while (AccederDatos.LectorDatos.Read())
            {

                if ((bool)AccederDatos.LectorDatos["Estado"]) {

                    Producto unProducto = new Producto();
                    unProducto.Proveedor = new Proveedor();
                    unProducto.Rubro = new Rubro();
                    unProducto.TipoProducto = new TipoProducto();
                    unProducto.CodigoProducto = AccederDatos.LectorDatos["CodigoProducto"].ToString();
                    unProducto.CodigoBulto = (int)AccederDatos.LectorDatos["CodigoBulto"];
                    unProducto.Nombre = AccederDatos.LectorDatos["Nombre"].ToString();
                    unProducto.Stock = (int)AccederDatos.LectorDatos["Stock"];
                    unProducto.StockCritico = (int)AccederDatos.LectorDatos["StockCritico"];
                    unProducto.CantidadxBulto = (int)AccederDatos.LectorDatos["CantidadxBulto"];
                    unProducto.PrecioVentaMinorista = (decimal)AccederDatos.LectorDatos["PrecioVentaMinorista"];
                    unProducto.PrecioVentaMayorista = (decimal)AccederDatos.LectorDatos["PrecioVentaMayorista"];
                    unProducto.Proveedor.CodigoProveedor = (int)AccederDatos.LectorDatos["CodigoProveedor"];
                    unProducto.Proveedor.NombreFantasia = AccederDatos.LectorDatos["NombreFantasia"].ToString();
                    unProducto.Rubro.CodigoRubro = (int)AccederDatos.LectorDatos["CodigoRubro"];
                    unProducto.Rubro.Nombre = AccederDatos.LectorDatos["NombreRubro"].ToString();
                    unProducto.TipoProducto.CodigoTipoProducto = (int)AccederDatos.LectorDatos["CodigoTipoProducto"];
                    unProducto.TipoProducto.Nombre = AccederDatos.LectorDatos["NombreTipoProducto"].ToString();

                    ListaProductos.Add(unProducto);
                }

            }

            AccederDatos.CerrarReader();
            AccederDatos.CerrarConexion();
            return ListaProductos;
        }

        public void EliminarProducto(Producto unProducto) {

            AccederDatos.AbrirConexion();
            AccederDatos.DefinirTipoComando("UPDATE Productos SET Estado = 0 WHERE CodigoProducto =" + unProducto.CodigoProducto);
            AccederDatos.EjecutarConsulta();

        }

        public void ModificarProducto(Producto unProducto) {

            AccederDatos.AbrirConexion();
            AccederDatos.DefinirTipoComando("UPDATE Productos Set CodigoBulto=@CodigoBulto, Nombre=@Nombre, CodigoTipoProducto=@CodigoTipoProducto, CantidadxBulto=@CantidadxBulto, StockCritico=@StockCritico, " +
            "CodigoProveedor=@CodigoProveedor, CodigoRubro=@CodigoRubro WHERE CodigoProducto = " + unProducto.CodigoProducto);
            AccederDatos.Comando.Parameters.Clear();
            AccederDatos.Comando.Parameters.AddWithValue("@CodigoBulto", unProducto.CodigoBulto);
            AccederDatos.Comando.Parameters.AddWithValue("@Nombre", unProducto.Nombre);
            AccederDatos.Comando.Parameters.AddWithValue("@CodigoTipoProducto", unProducto.TipoProducto.CodigoTipoProducto);
            AccederDatos.Comando.Parameters.AddWithValue("@CantidadxBulto", unProducto.CantidadxBulto);
            AccederDatos.Comando.Parameters.AddWithValue("@StockCritico", unProducto.StockCritico);
            AccederDatos.Comando.Parameters.AddWithValue("@CodigoProveedor", unProducto.Proveedor.CodigoProveedor);
            AccederDatos.Comando.Parameters.AddWithValue("@CodigoRubro", unProducto.Rubro.CodigoRubro);
            AccederDatos.EjecutarAccion();

        }

        public Producto CargarProducto(TextBox tboxCodigoProducto, TextBox tboxCodigoBulto, TextBox tboxNombre, ComboBox cboxTipoProducto, TextBox tboxCantidadBulto, TextBox tboxStockCritico, ComboBox cboxProveedor, ComboBox cboxRubro) {

            
            Producto unProducto = new Producto();

            unProducto.CodigoProducto = tboxCodigoProducto.Text;
            unProducto.CodigoBulto = Convert.ToInt32(tboxCodigoBulto.Text);
            unProducto.Nombre = tboxNombre.Text;
            unProducto.TipoProducto = (TipoProducto)cboxTipoProducto.SelectedItem;
            unProducto.CantidadxBulto = Convert.ToInt32(tboxCantidadBulto.Text);
            unProducto.StockCritico = Convert.ToInt32(tboxStockCritico.Text);
            unProducto.Proveedor = (Proveedor)cboxProveedor.SelectedItem;
            unProducto.Rubro = (Rubro)cboxRubro.SelectedItem;

            return unProducto;
        }
    }
}
