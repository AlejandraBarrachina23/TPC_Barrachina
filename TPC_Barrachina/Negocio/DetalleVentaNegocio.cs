using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dominio;

namespace Negocio
{
    public class DetalleVentaNegocio
    {
        ValidadorDatos Validar = new ValidadorDatos();

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
    }
}
