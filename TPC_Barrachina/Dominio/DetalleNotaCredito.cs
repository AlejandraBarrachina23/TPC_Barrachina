using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dominio
{
    public class DetalleNotaCredito:DetalleDocumento
    {
            public decimal Bultos { get; set; }
            public decimal Unidades { get; set; }
            public int CantidadxBulto { get; set; }
            public decimal PrecioCosto { get; set; }
            public decimal PrecioMinorista { get; set; }
            public decimal PrecioMayorista { get; set; }
            public decimal Subtotal { get; set; }
    }
}
