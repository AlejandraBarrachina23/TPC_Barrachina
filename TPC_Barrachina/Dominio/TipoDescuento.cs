using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dominio
{
    public class Descuento
    {
        public int CodigoDescuento { get; set; }
        public string Nombre { get; set; }
        public decimal Porcentaje { get; set; }
        public bool Estado { get; set; }

    }

   
}
