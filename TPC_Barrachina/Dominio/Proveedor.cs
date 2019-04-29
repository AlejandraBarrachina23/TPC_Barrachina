using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dominio
{
    class Proveedor
    {
        public Persona TipoProveedor { get; set; }
        public int CodigoProveedor { get; set; }
        public Impuesto Impuesto { get; set; }
        public bool Estado { get; set; }
    }
}
