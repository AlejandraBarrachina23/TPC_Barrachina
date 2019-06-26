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

        public void AgregarDetalleCompra(DetalleCompra unDetalleCompra, int NumeroFactura)
        {

            AccederDatos.AbrirConexion();
            AccederDatos.DefinirProcedimientoAlmacenado("SP_CargarDetallaCompra");
            AccederDatos.Comando.Parameters.Clear();
            AccederDatos.Comando.Parameters.AddWithValue("@NumeroFactura", NumeroFactura);
            AccederDatos.Comando.Parameters.AddWithValue("@NumeroLinea", unDetalleCompra.Linea);
            AccederDatos.Comando.Parameters.AddWithValue("@CodigoProducto", unDetalleCompra.Producto.CodigoProducto);
            AccederDatos.Comando.Parameters.AddWithValue("@Cantidad", unDetalleCompra.Cantidad);
            AccederDatos.Comando.Parameters.AddWithValue("@PrecioCosto", unDetalleCompra.PrecioBruto);
            AccederDatos.Comando.Parameters.AddWithValue("@PrecioVentaMinorista", unDetalleCompra.PrecioVentaMinorista);
            AccederDatos.Comando.Parameters.AddWithValue("@PrecioVentaMayorista" ,unDetalleCompra.PrecioVentaMayorista);
            AccederDatos.Comando.Parameters.AddWithValue("@Rentabilidad", unDetalleCompra.Rentabilidad);
            AccederDatos.EjecutarAccion();
            AccederDatos.CerrarConexion();

        }
    }
}
