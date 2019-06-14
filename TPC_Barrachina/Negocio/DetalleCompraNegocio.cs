using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dominio;
using AccesoDatos;

namespace Negocio
{
    public class DetalleCompraNegocio
    {
        AdministradorAccesoDatos AccederDatos = new AdministradorAccesoDatos();

        public void AgregarDetalleCompra(DetalleCompra unDetalleCompra) {

            AccederDatos.AbrirConexion();
            AccederDatos.DefinirTipoComando("INSERT INTO DetalleCompras (NumeroLinea,CodigoProducto,Cantidad,PrecioCosto,PrecioVenta,Rentabilidad) VALUES ('" + unDetalleCompra.Linea + "','" + unDetalleCompra.Producto.CodigoProducto + "','" + unDetalleCompra.Cantidad +
                "','" + unDetalleCompra.PrecioBruto + "','" + unDetalleCompra.PrecioVenta + "','" + unDetalleCompra.Rentabilidad+"')");
            AccederDatos.EjecutarAccion();
            AccederDatos.CerrarConexion();
        }
    }
}
