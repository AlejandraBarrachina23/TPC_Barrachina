using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dominio;
using AccesoDatos;

namespace Negocio
{
    public class DetalleVentaNegocio
    {
        ValidadorDatos Validar = new ValidadorDatos();
        AdministradorAccesoDatos AccederDatos = new AdministradorAccesoDatos();

        public void ControlStock(List<DetalleVenta> Detalles, Producto unProducto, int CantidadIngresada)
        {
            int Restante = 0;
            int AcumulaStock = 0;

            foreach (DetalleVenta unDetalleVentaCargado in Detalles)
            {

                if (unDetalleVentaCargado.Producto.CodigoProducto == unProducto.CodigoProducto)
                {
                    AcumulaStock += unDetalleVentaCargado.Cantidad;
                    Restante = unProducto.Stock - AcumulaStock;
                    Validar.MaximoValor(Restante, "Cantidad ", CantidadIngresada);
                }
            }

        }

        public void AgregarDetalleVenta(DetalleVenta unDetallVenta, int NumeroFactura)
        {

            AccederDatos.AbrirConexion();
            AccederDatos.DefinirProcedimientoAlmacenado("SP_CargarDetalleVenta");
            AccederDatos.Comando.Parameters.Clear();
            AccederDatos.Comando.Parameters.AddWithValue("@NumeroFactura", NumeroFactura);
            AccederDatos.Comando.Parameters.AddWithValue("@NumeroLinea", unDetallVenta.Linea);
            AccederDatos.Comando.Parameters.AddWithValue("@CodigoProducto", unDetallVenta.Producto.CodigoProducto);
            AccederDatos.Comando.Parameters.AddWithValue("@Unidad", unDetallVenta.Unidades);
            AccederDatos.Comando.Parameters.AddWithValue("@PrecioCosto", unDetallVenta.PrecioCosto);
            AccederDatos.Comando.Parameters.AddWithValue("@PrecioVentaMinorista", unDetallVenta.PrecioMinorista);
            AccederDatos.Comando.Parameters.AddWithValue("@PrecioVentaMayorista", unDetallVenta.PrecioMayorista);
            AccederDatos.Comando.Parameters.AddWithValue("@CantidadxBulto", unDetallVenta.CantidadxBulto);
            AccederDatos.Comando.Parameters.AddWithValue("@Bulto", unDetallVenta.Bultos);
            AccederDatos.EjecutarAccion();
            AccederDatos.CerrarConexion();
        }
    }

}
