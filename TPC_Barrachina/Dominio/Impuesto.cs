using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dominio
{
    public class Impuesto
    {
        public int CodigoImpuesto { get; set; }
        public string Nombre { get; set; }
        public string Descripcion { get; set; }
        public decimal Alicuota { get; set; }
        public bool Estado { get; set; }

        public override string ToString()
        {
            return Nombre;
        }
    }
}
