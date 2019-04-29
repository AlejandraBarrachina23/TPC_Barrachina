using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dominio
{
    class Producto
    {
        public int CodigoProducto { get; set; }
        public string Nombre { get; set; }
        public TipoProducto TipoProducto { get;set;}
        public int Stock { get; set; }
        public int StockCritico { get; set; }
        public float PrecioCosto { get; set; }
        public float PrecioVenta { get; set; }
        public Proveedor Proveedor { get; set; }
        public Rubro Rubro { get; set; }
        public Sucursal Sucursal { get; set; }

    }
}
