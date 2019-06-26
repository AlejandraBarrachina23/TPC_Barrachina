using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dominio;
using AccesoDatos;

namespace Negocio
{
    public class DetalleNotaCreditoNegocio
    {
        public void AgregarDetalleNotaDevolucion(DetalleNotaCredito unDetalleDevolucion, int NumeroFactura)
        {
            AdministradorAccesoDatos AccederDatos = new AdministradorAccesoDatos();

            AccederDatos.AbrirConexion();
            AccederDatos.DefinirProcedimientoAlmacenado("SP_CargarDetalleNotaDevolucion");
            AccederDatos.Comando.Parameters.Clear();
            AccederDatos.Comando.Parameters.AddWithValue("@NumeroFactura", NumeroFactura);
            AccederDatos.Comando.Parameters.AddWithValue("@NumeroLinea", unDetalleDevolucion.Linea);
            AccederDatos.Comando.Parameters.AddWithValue("@CodigoProducto", unDetalleDevolucion.Producto.CodigoProducto);
            AccederDatos.Comando.Parameters.AddWithValue("@Unidad", unDetalleDevolucion.Unidades);
            AccederDatos.Comando.Parameters.AddWithValue("@PrecioCosto", unDetalleDevolucion.PrecioCosto);
            AccederDatos.Comando.Parameters.AddWithValue("@PrecioVentaMinorista", unDetalleDevolucion.PrecioMinorista);
            AccederDatos.Comando.Parameters.AddWithValue("@PrecioVentaMayorista", unDetalleDevolucion.PrecioMayorista);
            AccederDatos.Comando.Parameters.AddWithValue("@CantidadxBulto", unDetalleDevolucion.CantidadxBulto);
            AccederDatos.Comando.Parameters.AddWithValue("@Bulto", unDetalleDevolucion.Bultos);
            AccederDatos.EjecutarAccion();
            AccederDatos.CerrarConexion();
        }

        public DetalleNotaCredito CargarDetalleDevolucion(DetalleVenta unDetalleVenta)
        {
            
            DetalleNotaCredito unDetalleNotaCredito = new DetalleNotaCredito();
            unDetalleNotaCredito.Producto = new Producto();
            unDetalleNotaCredito.Linea = unDetalleVenta.Linea;
            unDetalleNotaCredito.Producto.CodigoProducto = unDetalleVenta.Producto.CodigoProducto;
            unDetalleNotaCredito.Cantidad = unDetalleVenta.Cantidad;
            unDetalleNotaCredito.Bultos = unDetalleVenta.Bultos;
            unDetalleNotaCredito.Unidades = unDetalleVenta.Unidades;
            unDetalleNotaCredito.CantidadxBulto = unDetalleVenta.CantidadxBulto;
            unDetalleNotaCredito.PrecioCosto = unDetalleVenta.PrecioCosto;
            unDetalleNotaCredito.PrecioMinorista = unDetalleVenta.PrecioMinorista;
            unDetalleNotaCredito.PrecioMayorista = unDetalleVenta.PrecioMayorista;
            unDetalleNotaCredito.Subtotal = unDetalleVenta.Subtotal;
            return unDetalleNotaCredito;
            
        }

    }
}
