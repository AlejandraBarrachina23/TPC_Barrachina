using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dominio
{
    public class Producto
    {
        public string CodigoProducto { get; set; }
        public int CodigoBulto { get; set; }
        public string Nombre { get; set; }
        public TipoProducto TipoProducto { get;set;}
        public int Stock { get; set; }
        public int StockCritico { get; set; }
        public decimal PrecioCosto { get; set; }
        public decimal PrecioCostoLista { get; set; }
        public decimal PrecioVentaMinorista { get; set; }
        public decimal PrecioVentaMayorista { get; set; }
        public int CantidadxBulto { get; set; }
        public Proveedor Proveedor { get; set; }
        public Rubro Rubro { get; set; }
        public bool Estado { get; set; }

    }
}
