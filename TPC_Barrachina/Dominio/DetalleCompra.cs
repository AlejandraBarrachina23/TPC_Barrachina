using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dominio
{
    public class DetalleCompra:DetalleDocumento
    {
        public decimal PrecioUnitario { get; set; }
        public decimal Descuento { get; set; }
        public decimal PrecioNeto { get; set; }
        public decimal PrecioBruto { get; set; }
        public decimal PrecioPonderado { get; set; }
        public int Rentabilidad { get; set; }
        public decimal PrecioVentaMinorista { get; set; }
        public decimal PrecioVentaMayorista { get; set; }
    }
}
