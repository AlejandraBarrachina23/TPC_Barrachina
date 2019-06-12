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

        public void AgregarDetalleVenta(DetalleVenta unDetallVenta)
        {
            AccederDatos.AbrirConexion();
            AccederDatos.DefinirTipoComando("INSERT INTO DetalleVentas (NumeroLinea,CodigoProducto,Cantidad, PrecioCosto,PrecioCostoLista,PrecioVentaMinorista, PrecioVentaMayorista) VALUES ('" + unDetallVenta.Linea + "','" + unDetallVenta.Producto.CodigoProducto + "','" + unDetallVenta.Cantidad +
                "','" + unDetallVenta.PrecioCosto + "','" + unDetallVenta.PrecioCostoLista + "','" + unDetallVenta.PrecioMinorista + "','" + unDetallVenta.PrecioMayorista + "')");
            AccederDatos.EjecutarAccion();
            AccederDatos.CerrarConexion();
        }
    }

}
